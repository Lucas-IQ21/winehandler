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
using wineHandler.Utils;

namespace wineHandler
{
    public partial class AjouterCave : Form
    {
        private readonly WineHandlerContext _context;

        public AjouterCave()
        {
            InitializeComponent();
            _context = new WineHandlerContext();
            Style style = new Style();
            Load loader = new Load(_context);
            loader.CavesGrid(dataGridViewCaves);

            // Style général du formulaire
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Ajouter une cave";

            // Labels
            style.label(labelNom);
            style.label(labelFamille);
            style.label(labelFabricant);
            style.label(labelNbrTiroir);
            style.label(labelBouteilleParTiroir);
            style.label(label1);

            // TextBox
            style.textBox(txtBoxNom);
            style.textBox(txtBoxFamille);
            style.textBox(txtBoxFabricant);
            style.textBox(txtBoxNbrTiroir);
            style.textBox(txtBoxBouteilleParTiroir);
            style.textBox(txtBoxTemp);

            // Bouton
            style.button(btnAjouterCave, Color.ForestGreen);
            btnAjouterCave.Text = "Ajouter la cave";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterCave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxNom.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxFamille.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxFabricant.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxNbrTiroir.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxBouteilleParTiroir.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxTemp.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                var nouvelleCave = new Cave
                {
                    Nom = txtBoxNom.Text.Trim(),
                    Famille = txtBoxFamille.Text.Trim(),
                    Fabricant = txtBoxFabricant.Text.Trim(),
                    NbTiroirs = int.Parse(txtBoxNbrTiroir.Text.Trim()),
                    BouteillesParTiroir = int.Parse(txtBoxBouteilleParTiroir.Text.Trim()),
                    TemperatureC = decimal.Parse(txtBoxTemp.Text)
                };

                _context.Caves.Add(nouvelleCave);
                _context.SaveChanges();
                int capaciteTotal = nouvelleCave.NbTiroirs * nouvelleCave.BouteillesParTiroir;

                MessageBox.Show("La cave " + nouvelleCave.Nom + " a été ajoutée avec une capacité total de " + capaciteTotal.ToString() + " bouteilles.");

                txtBoxNom.Clear();
                txtBoxFamille.Clear();
                txtBoxFabricant.Clear();
                txtBoxNbrTiroir.Clear();
                txtBoxBouteilleParTiroir.Clear();
                txtBoxTemp.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la cave : " + ex.Message);
            }

        }

        private void AjouterCave_Load(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerCave_Click(object sender, EventArgs e)
        {
            if (dataGridViewCaves.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une cave à supprimer.");
                return;
            }

            try
            {
                var selected = dataGridViewCaves.SelectedRows[0].DataBoundItem as Cave;
                if (selected == null)
                {
                    MessageBox.Show("Impossible de lire la cave sélectionnée.");
                    return;
                }

                var cave = _context.Caves.FirstOrDefault(c => c.IdCave == selected.IdCave);
                if (cave == null)
                {
                    MessageBox.Show("Cave introuvable en base.");
                    return;
                }

                var confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer la cave \"{cave.Nom}\" ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    _context.Caves.Remove(cave);
                    _context.SaveChanges();

                    var loader = new Load(_context);
                    loader.CavesGrid(dataGridViewCaves);

                    MessageBox.Show("La cave a été supprimée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
            }
        }
    }
}
