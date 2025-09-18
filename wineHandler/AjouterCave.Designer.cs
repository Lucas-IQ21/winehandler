namespace wineHandler
{
    partial class AjouterCave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelNom = new Label();
            txtBoxNom = new TextBox();
            labelFamille = new Label();
            labelFabricant = new Label();
            labelNbrTiroir = new Label();
            labelBouteilleParTiroir = new Label();
            txtBoxFamille = new TextBox();
            txtBoxFabricant = new TextBox();
            txtBoxNbrTiroir = new TextBox();
            txtBoxBouteilleParTiroir = new TextBox();
            btnAjouterCave = new Button();
            label1 = new Label();
            txtBoxTemp = new TextBox();
            buttonSupprimerCave = new Button();
            dataGridViewCaves = new DataGridView();
            groupBoxInfos = new GroupBox();
            groupBoxListe = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCaves).BeginInit();
            groupBoxInfos.SuspendLayout();
            groupBoxListe.SuspendLayout();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(20, 40);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(50, 19);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(180, 37);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(180, 25);
            txtBoxNom.TabIndex = 1;
            txtBoxNom.TextChanged += textBox1_TextChanged;
            // 
            // labelFamille
            // 
            labelFamille.AutoSize = true;
            labelFamille.Location = new Point(20, 90);
            labelFamille.Name = "labelFamille";
            labelFamille.Size = new Size(65, 19);
            labelFamille.TabIndex = 2;
            labelFamille.Text = "Famille :";
            // 
            // labelFabricant
            // 
            labelFabricant.AutoSize = true;
            labelFabricant.Location = new Point(20, 140);
            labelFabricant.Name = "labelFabricant";
            labelFabricant.Size = new Size(79, 19);
            labelFabricant.TabIndex = 4;
            labelFabricant.Text = "Fabricant :";
            // 
            // labelNbrTiroir
            // 
            labelNbrTiroir.AutoSize = true;
            labelNbrTiroir.Location = new Point(20, 190);
            labelNbrTiroir.Name = "labelNbrTiroir";
            labelNbrTiroir.Size = new Size(117, 19);
            labelNbrTiroir.TabIndex = 6;
            labelNbrTiroir.Text = "Nombre tiroirs :";
            // 
            // labelBouteilleParTiroir
            // 
            labelBouteilleParTiroir.AutoSize = true;
            labelBouteilleParTiroir.Location = new Point(20, 240);
            labelBouteilleParTiroir.Name = "labelBouteilleParTiroir";
            labelBouteilleParTiroir.Size = new Size(122, 19);
            labelBouteilleParTiroir.TabIndex = 8;
            labelBouteilleParTiroir.Text = "Bouteilles/tiroir :";
            // 
            // txtBoxFamille
            // 
            txtBoxFamille.Location = new Point(180, 87);
            txtBoxFamille.Name = "txtBoxFamille";
            txtBoxFamille.Size = new Size(180, 25);
            txtBoxFamille.TabIndex = 3;
            // 
            // txtBoxFabricant
            // 
            txtBoxFabricant.Location = new Point(180, 137);
            txtBoxFabricant.Name = "txtBoxFabricant";
            txtBoxFabricant.Size = new Size(180, 25);
            txtBoxFabricant.TabIndex = 5;
            // 
            // txtBoxNbrTiroir
            // 
            txtBoxNbrTiroir.Location = new Point(180, 187);
            txtBoxNbrTiroir.Name = "txtBoxNbrTiroir";
            txtBoxNbrTiroir.Size = new Size(180, 25);
            txtBoxNbrTiroir.TabIndex = 7;
            // 
            // txtBoxBouteilleParTiroir
            // 
            txtBoxBouteilleParTiroir.Location = new Point(180, 237);
            txtBoxBouteilleParTiroir.Name = "txtBoxBouteilleParTiroir";
            txtBoxBouteilleParTiroir.Size = new Size(180, 25);
            txtBoxBouteilleParTiroir.TabIndex = 9;
            // 
            // btnAjouterCave
            // 
            btnAjouterCave.BackColor = Color.DarkRed;
            btnAjouterCave.FlatAppearance.BorderSize = 0;
            btnAjouterCave.FlatStyle = FlatStyle.Flat;
            btnAjouterCave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjouterCave.ForeColor = Color.White;
            btnAjouterCave.Location = new Point(80, 380);
            btnAjouterCave.Name = "btnAjouterCave";
            btnAjouterCave.Size = new Size(220, 50);
            btnAjouterCave.TabIndex = 12;
            btnAjouterCave.Text = "➕ Ajouter la cave";
            btnAjouterCave.UseVisualStyleBackColor = false;
            btnAjouterCave.Click += btnAjouterCave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 290);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 10;
            label1.Text = "Température (°C) :";
            // 
            // txtBoxTemp
            // 
            txtBoxTemp.Location = new Point(180, 287);
            txtBoxTemp.Name = "txtBoxTemp";
            txtBoxTemp.Size = new Size(180, 25);
            txtBoxTemp.TabIndex = 11;
            // 
            // buttonSupprimerCave
            // 
            buttonSupprimerCave.BackColor = Color.DimGray;
            buttonSupprimerCave.FlatAppearance.BorderSize = 0;
            buttonSupprimerCave.FlatStyle = FlatStyle.Flat;
            buttonSupprimerCave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonSupprimerCave.ForeColor = Color.White;
            buttonSupprimerCave.Location = new Point(110, 430);
            buttonSupprimerCave.Name = "buttonSupprimerCave";
            buttonSupprimerCave.Size = new Size(220, 40);
            buttonSupprimerCave.TabIndex = 1;
            buttonSupprimerCave.Text = "🗑 Supprimer la cave";
            buttonSupprimerCave.UseVisualStyleBackColor = false;
            buttonSupprimerCave.Click += buttonSupprimerCave_Click;
            // 
            // dataGridViewCaves
            // 
            dataGridViewCaves.AllowUserToAddRows = false;
            dataGridViewCaves.AllowUserToDeleteRows = false;
            dataGridViewCaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCaves.BackgroundColor = Color.White;
            dataGridViewCaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCaves.Location = new Point(20, 40);
            dataGridViewCaves.MultiSelect = false;
            dataGridViewCaves.Name = "dataGridViewCaves";
            dataGridViewCaves.ReadOnly = true;
            dataGridViewCaves.RowHeadersVisible = false;
            dataGridViewCaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCaves.Size = new Size(430, 370);
            dataGridViewCaves.TabIndex = 0;
            dataGridViewCaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 
            // groupBoxInfos
            // 
            groupBoxInfos.Controls.Add(labelNom);
            groupBoxInfos.Controls.Add(txtBoxNom);
            groupBoxInfos.Controls.Add(labelFamille);
            groupBoxInfos.Controls.Add(txtBoxFamille);
            groupBoxInfos.Controls.Add(labelFabricant);
            groupBoxInfos.Controls.Add(txtBoxFabricant);
            groupBoxInfos.Controls.Add(labelNbrTiroir);
            groupBoxInfos.Controls.Add(txtBoxNbrTiroir);
            groupBoxInfos.Controls.Add(labelBouteilleParTiroir);
            groupBoxInfos.Controls.Add(txtBoxBouteilleParTiroir);
            groupBoxInfos.Controls.Add(label1);
            groupBoxInfos.Controls.Add(txtBoxTemp);
            groupBoxInfos.Controls.Add(btnAjouterCave);
            groupBoxInfos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxInfos.Location = new Point(30, 30);
            groupBoxInfos.Name = "groupBoxInfos";
            groupBoxInfos.Size = new Size(400, 500);
            groupBoxInfos.TabIndex = 0;
            groupBoxInfos.TabStop = false;
            groupBoxInfos.Text = "Ajouter une cave";
            // 
            // groupBoxListe
            // 
            groupBoxListe.Controls.Add(dataGridViewCaves);
            groupBoxListe.Controls.Add(buttonSupprimerCave);
            groupBoxListe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxListe.Location = new Point(460, 30);
            groupBoxListe.Name = "groupBoxListe";
            groupBoxListe.Size = new Size(450, 500);
            groupBoxListe.TabIndex = 1;
            groupBoxListe.TabStop = false;
            groupBoxListe.Text = "Liste des caves";
            // 
            // AjouterCave
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(950, 600);
            Controls.Add(groupBoxInfos);
            Controls.Add(groupBoxListe);
            Font = new Font("Segoe UI", 10F);
            Name = "AjouterCave";
            Text = "Gestion des caves";
            Load += AjouterCave_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCaves).EndInit();
            groupBoxInfos.ResumeLayout(false);
            groupBoxInfos.PerformLayout();
            groupBoxListe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelNom;
        private TextBox txtBoxNom;
        private Label labelFamille;
        private Label labelFabricant;
        private Label labelNbrTiroir;
        private Label labelBouteilleParTiroir;
        private TextBox txtBoxFamille;
        private TextBox txtBoxFabricant;
        private TextBox txtBoxNbrTiroir;
        private TextBox txtBoxBouteilleParTiroir;
        private Button btnAjouterCave;
        private Label label1;
        private TextBox txtBoxTemp;
        private Button buttonSupprimerCave;
        private DataGridView dataGridViewCaves;
        private GroupBox groupBoxInfos;
        private GroupBox groupBoxListe;
    }
}
