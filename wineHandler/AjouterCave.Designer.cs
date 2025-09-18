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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(164, 64);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(40, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(164, 82);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(100, 23);
            txtBoxNom.TabIndex = 1;
            txtBoxNom.TextChanged += textBox1_TextChanged;
            // 
            // labelFamille
            // 
            labelFamille.AutoSize = true;
            labelFamille.Location = new Point(164, 123);
            labelFamille.Name = "labelFamille";
            labelFamille.Size = new Size(54, 15);
            labelFamille.TabIndex = 2;
            labelFamille.Text = "Famille : ";
            // 
            // labelFabricant
            // 
            labelFabricant.AutoSize = true;
            labelFabricant.Location = new Point(164, 191);
            labelFabricant.Name = "labelFabricant";
            labelFabricant.Size = new Size(62, 15);
            labelFabricant.TabIndex = 3;
            labelFabricant.Text = "Fabricant :";
            // 
            // labelNbrTiroir
            // 
            labelNbrTiroir.AutoSize = true;
            labelNbrTiroir.Location = new Point(164, 253);
            labelNbrTiroir.Name = "labelNbrTiroir";
            labelNbrTiroir.Size = new Size(88, 15);
            labelNbrTiroir.TabIndex = 4;
            labelNbrTiroir.Text = "Nombre tiroir : ";
            // 
            // labelBouteilleParTiroir
            // 
            labelBouteilleParTiroir.AutoSize = true;
            labelBouteilleParTiroir.Location = new Point(164, 311);
            labelBouteilleParTiroir.Name = "labelBouteilleParTiroir";
            labelBouteilleParTiroir.Size = new Size(115, 15);
            labelBouteilleParTiroir.TabIndex = 5;
            labelBouteilleParTiroir.Text = "Bouteilles par tiroir : ";
            // 
            // txtBoxFamille
            // 
            txtBoxFamille.Location = new Point(164, 146);
            txtBoxFamille.Name = "txtBoxFamille";
            txtBoxFamille.Size = new Size(100, 23);
            txtBoxFamille.TabIndex = 6;
            // 
            // txtBoxFabricant
            // 
            txtBoxFabricant.Location = new Point(164, 209);
            txtBoxFabricant.Name = "txtBoxFabricant";
            txtBoxFabricant.Size = new Size(100, 23);
            txtBoxFabricant.TabIndex = 7;
            // 
            // txtBoxNbrTiroir
            // 
            txtBoxNbrTiroir.Location = new Point(164, 271);
            txtBoxNbrTiroir.Name = "txtBoxNbrTiroir";
            txtBoxNbrTiroir.Size = new Size(100, 23);
            txtBoxNbrTiroir.TabIndex = 8;
            // 
            // txtBoxBouteilleParTiroir
            // 
            txtBoxBouteilleParTiroir.Location = new Point(164, 329);
            txtBoxBouteilleParTiroir.Name = "txtBoxBouteilleParTiroir";
            txtBoxBouteilleParTiroir.Size = new Size(100, 23);
            txtBoxBouteilleParTiroir.TabIndex = 9;
            // 
            // btnAjouterCave
            // 
            btnAjouterCave.Location = new Point(377, 123);
            btnAjouterCave.Name = "btnAjouterCave";
            btnAjouterCave.Size = new Size(281, 121);
            btnAjouterCave.TabIndex = 10;
            btnAjouterCave.Text = "Ajouter une cave";
            btnAjouterCave.UseVisualStyleBackColor = true;
            btnAjouterCave.Click += btnAjouterCave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 368);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 13;
            label1.Text = "Température :";
            // 
            // txtBoxTemp
            // 
            txtBoxTemp.Location = new Point(164, 386);
            txtBoxTemp.Name = "txtBoxTemp";
            txtBoxTemp.Size = new Size(100, 23);
            txtBoxTemp.TabIndex = 14;
            // 
            // AjouterCave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxTemp);
            Controls.Add(label1);
            Controls.Add(btnAjouterCave);
            Controls.Add(txtBoxBouteilleParTiroir);
            Controls.Add(txtBoxNbrTiroir);
            Controls.Add(txtBoxFabricant);
            Controls.Add(txtBoxFamille);
            Controls.Add(labelBouteilleParTiroir);
            Controls.Add(labelNbrTiroir);
            Controls.Add(labelFabricant);
            Controls.Add(labelFamille);
            Controls.Add(txtBoxNom);
            Controls.Add(labelNom);
            Name = "AjouterCave";
            Text = "AjouterCave";
            Load += AjouterCave_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}