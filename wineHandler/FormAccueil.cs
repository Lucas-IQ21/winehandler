using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Windows.Forms;
using wineHandler.Models;
using wineHandler.Utils;

namespace wineHandler
{
    public partial class FormAccueil : Form
    {
        private readonly WineHandlerContext _context;
        public FormAccueil()
        {
            InitializeComponent();
            _context = new WineHandlerContext();
            var loader = new Load(_context);
            loader.Appellations(comboBoxAppellation);
            loader.Caves(comboBoxCave);
            loadTableau();
            Style style = new Style();
            // Style général
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Titre
            Title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            Title.ForeColor = Color.DarkRed;
            Title.Location = new Point(20, 15);

            // Boutons
            style.button(btnRechercher, Color.DarkRed);
            style.button(btnAjouterCave, Color.SteelBlue);
            style.button(btnAjouterVin, Color.ForestGreen);

            // Textbox de recherche
            txtBoxSearch.PlaceholderText = "Rechercher un vin...";
            txtBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSearch.BackColor = Color.White;

            // ComboBox
            comboBoxAppellation.FlatStyle = FlatStyle.Flat;
            comboBoxCave.FlatStyle = FlatStyle.Flat;

            // DataGridView
            DataGridVin.BackgroundColor = Color.White;
            DataGridVin.BorderStyle = BorderStyle.None;
            DataGridVin.GridColor = Color.LightGray;
            DataGridVin.DefaultCellStyle.BackColor = Color.White;
            DataGridVin.DefaultCellStyle.ForeColor = Color.Black;
            DataGridVin.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DataGridVin.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            DataGridVin.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            DataGridVin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridVin.EnableHeadersVisualStyles = false;
        }


        public void loadTableau()
        {
            try
            {
                // Config DataGrid
                DataGridVin.ReadOnly = true;
                DataGridVin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridVin.AllowUserToAddRows = false;
                DataGridVin.AllowUserToDeleteRows = false;
                DataGridVin.AllowUserToResizeRows = false;
                DataGridVin.RowHeadersVisible = false;
                DataGridVin.AutoGenerateColumns = false;
                DataGridVin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DataGridVin.Columns.Clear();

                // Colonnes
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nom du vin",
                    DataPropertyName = "NomVin"
                });
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nom appellation",
                    DataPropertyName = "NomAppellation"
                });
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Plage conso",
                    DataPropertyName = "PlageConso"
                });
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Cave",
                    DataPropertyName = "Cave"
                });
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Emplacement",
                    DataPropertyName = "Emplacement"
                });
                DataGridVin.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Statut",
                    DataPropertyName = "Statut"
                });

                var raw = _context.Bouteilles
                    .Include(b => b.IdVinNavigation)
                        .ThenInclude(v => v.IdAppellationNavigation)
                    .Include(b => b.IdCaveNavigation)
                    .AsNoTracking()
                    .Select(b => new
                    {
                        NomVin = b.IdVinNavigation.Nom,
                        NomAppellation = b.IdVinNavigation.IdAppellationNavigation.Nom,
                        PlageConso = (b.IdVinNavigation.AnneeMillesime
                                      + (b.IdVinNavigation.AnneesRecMin ?? 0))
                                     + " - " +
                                     (b.IdVinNavigation.AnneeMillesime
                                      + (b.IdVinNavigation.AnneesRecMax ?? 0)),
                        Cave = b.IdCaveNavigation.Nom,
                        Emplacement = $"Tiroir : {b.NoTiroir} Emplacement : {b.NoEmplacement}",
                        StatutCode = b.Statut
                    })
                    .AsEnumerable()
                    .Select(x => new
                    {
                        x.NomVin,
                        x.NomAppellation,
                        x.PlageConso,
                        x.Cave,
                        x.Emplacement,
                        Statut = EnumHelper.GetDescription(
                            Enum.TryParse<StatutBouteille>(x.StatutCode, out var st) ? st : StatutBouteille.S)
                    })
                    .ToList();

                DataGridVin.DataSource = raw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void checkBoxAppoge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Bouteilles
                    .Include(b => b.IdVinNavigation)
                        .ThenInclude(v => v.IdAppellationNavigation)
                    .Include(b => b.IdCaveNavigation)
                    .AsQueryable();

                // 1) filtre texte (nom vin ou appellation) - insensible à la casse
                if (!string.IsNullOrWhiteSpace(txtBoxSearch.Text))
                {
                    string s = txtBoxSearch.Text.Trim().ToLower();
                    query = query.Where(b =>
                        b.IdVinNavigation.Nom.ToLower().Contains(s) ||
                        b.IdVinNavigation.IdAppellationNavigation.Nom.ToLower().Contains(s));
                }

                // 2) filtre cave par Id si une cave est sélectionnée
                if (comboBoxCave.SelectedIndex >= 0 && comboBoxCave.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxCave.SelectedValue.ToString(), out int caveId))
                    {
                        query = query.Where(b => b.IdCave == caveId);
                    }
                }

                // 3) filtre appellation par Id si une appellation est sélectionnée
                if (comboBoxAppellation.SelectedIndex >= 0 && comboBoxAppellation.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxAppellation.SelectedValue.ToString(), out int appId))
                    {
                        query = query.Where(b => b.IdVinNavigation.IdAppellation == appId);
                    }
                }
                // TODO : C'est le moment de boire !
                //if (checkBoxAppoge.Checked)
                //{
                //    query = query.Where(b => b.)
                //}

                // debug : afficher la SQL générée (utile pour voir les WHERE)
                var sql = query.ToQueryString();

                // debug : nombre de résultats
                var count = query.Count();
                Debug.WriteLine($"Résultats trouvés (avant projection) : {count}");
                MessageBox.Show($"Résultats trouvés : {count}");

                var result = query
                    .AsNoTracking()
                    .Select(b => new
                    {
                        NomVin = b.IdVinNavigation.Nom,
                        NomAppellation = b.IdVinNavigation.IdAppellationNavigation.Nom,
                        PlageConso = $"{b.IdVinNavigation.AnneeMillesime + (b.IdVinNavigation.AnneesRecMin ?? 0)} - {b.IdVinNavigation.AnneeMillesime + (b.IdVinNavigation.AnneesRecMax ?? 0)}",
                        Cave = b.IdCaveNavigation.Nom,
                        Emplacement = $"Tiroir : {b.NoTiroir} Emplacement : {b.NoEmplacement}"
                    })
                    .ToList();

                DataGridVin.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur filtre: " + ex.Message);
            }
        }


        private void labelCave_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterCave_Click(object sender, EventArgs e)
        {
            using (var form = new AjouterCave())
            {
                var result = form.ShowDialog();
                var loader = new Load(_context);

                if (result == DialogResult.OK)
                {
                    loader.Caves(comboBoxCave);
                    loadTableau();
                }
            }
        }

        private void btnAjouterVin_Click_1(object sender, EventArgs e)
        {
            using (var form = new FormAjouterVin())
            {
                var result = form.ShowDialog();
                var loader = new Load(_context);

                if (result == DialogResult.OK)
                {
                    loader.Caves(comboBoxCave);
                    loadTableau();
                }
            }
        }
    }
}
