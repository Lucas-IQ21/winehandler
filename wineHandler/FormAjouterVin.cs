using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wineHandler.Models;

namespace wineHandler
{
    public partial class FormAjouterVin : Form
    {
        private readonly WineHandlerContext _context;
        public FormAjouterVin()
        {
            InitializeComponent();
            _context = new WineHandlerContext();
            var loader = new Load(_context);
            loader.Appellations(comboBoxAppellation);
            loader.Caves(comboBoxCave);

            comboBoxCouleur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCouleur.Items.AddRange(new string[] { "Rouge", "Blanc", "Rose" });
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxNomVin.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxMillesime.Text) ||
                    comboBoxAppellation.SelectedValue == null ||
                    comboBoxCave.SelectedValue == null ||
                    comboBoxCouleur.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(textBoxQuantite.Text) || 
                    string.IsNullOrWhiteSpace(txtBoxGardeMin.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxGardeMax.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                if (!int.TryParse(txtBoxMillesime.Text.Trim(), out int millesime))
                {
                    MessageBox.Show("Millésime invalide.");
                    return;
                }

                if (!int.TryParse(textBoxQuantite.Text.Trim(), out int quantite) || quantite <= 0)
                {
                    MessageBox.Show("Quantité invalide.");
                    return;
                }
                if (!int.TryParse(txtBoxGardeMin.Text.Trim(), out int gardeMin) || quantite <= 0)
                {
                    MessageBox.Show("Année de garde minimum invalide.");
                    return;
                }
                if (!int.TryParse(txtBoxGardeMax.Text.Trim(), out int gardeMax) || quantite <= 0)
                {
                    MessageBox.Show("Année de garde maximum invalide.");
                    return;
                }

                int idAppellation = (int)comboBoxAppellation.SelectedValue;
                int idCave = (int)comboBoxCave.SelectedValue;
                string couleur = comboBoxCouleur.SelectedItem.ToString();

                var couleursValides = new[] { "Rouge", "Blanc", "Rose" };
                if (!couleursValides.Contains(couleur))
                {
                    MessageBox.Show("Couleur invalide. Choisissez parmi : Rouge, Blanc, Rose.");
                    return;
                }

                // vin
                var vin = new Vin
                {
                    Nom = txtBoxNomVin.Text.Trim(),
                    AnneeMillesime = millesime,
                    IdAppellation = idAppellation,
                    Couleur = couleur,
                    AnneesRecMin = gardeMin,
                    AnneesRecMax = gardeMax,
                };

                _context.Vins.Add(vin);
                _context.SaveChanges();

                
                var cave = _context.Caves.First(c => c.IdCave == idCave);

                // Récupére les bouteilles existantes pour savoir où il reste de la place
                var bouteillesExistantes = _context.Bouteilles
                    .Where(b => b.IdCave == idCave)
                    .ToList();

                var remplissage = bouteillesExistantes
                    .GroupBy(b => b.NoTiroir)
                    .ToDictionary(g => g.Key, g => g.Count());

                int restantes = quantite;

                for (int tiroir = 1; tiroir <= cave.NbTiroirs && restantes > 0; tiroir++)
                {
                    int dejaDansTiroir = remplissage.ContainsKey(tiroir) ? remplissage[tiroir] : 0;
                    int placesLibres = cave.BouteillesParTiroir - dejaDansTiroir;

                    int aAjouter = Math.Min(restantes, placesLibres);

                    for (int i = 0; i < aAjouter; i++)
                    {
                        var bouteille = new Bouteille
                        {
                            IdVin = vin.IdVin,
                            IdCave = idCave,
                            NoTiroir = tiroir,
                            NoEmplacement = dejaDansTiroir + i + 1,
                            Statut = "S",
                            DateAcquisition = DateOnly.FromDateTime(DateTime.Now)
                        };

                        _context.Bouteilles.Add(bouteille);
                    }

                    restantes -= aAjouter;
                }

                if (restantes > 0)
                {
                    MessageBox.Show("Attention : toutes les bouteilles n'ont pas pu être ajoutées (capacité de cave atteinte).");
                }

                _context.SaveChanges();

                MessageBox.Show($"Le vin '{vin.Nom}' a été ajouté avec {quantite - restantes} bouteille(s).");

                // Reset UI
                txtBoxNomVin.Clear();
                txtBoxMillesime.Clear();
                textBoxQuantite.Clear();
                comboBoxAppellation.SelectedIndex = -1;
                comboBoxCouleur.SelectedIndex = -1;
                comboBoxCave.SelectedIndex = -1;
                txtBoxGardeMin.Clear();
                txtBoxGardeMax.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Erreur lors de la sauvegarde en base :\n" + GetFullExceptionText(dbEx));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :\n" + GetFullExceptionText(ex));
            }
        }


        private string GetFullExceptionText(Exception ex)
        {
            var sb = new StringBuilder();
            var current = ex;
            while (current != null)
            {
                sb.AppendLine($"[{current.GetType().Name}] {current.Message}");
                if (current.StackTrace != null)
                    sb.AppendLine(current.StackTrace);
                current = current.InnerException;
            }
            return sb.ToString();
        }

    }
}
