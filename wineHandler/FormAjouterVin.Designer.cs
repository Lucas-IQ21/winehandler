namespace wineHandler
{
    partial class FormAjouterVin
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
            labelNomDuVin = new Label();
            labelAppellation = new Label();
            labelCouleur = new Label();
            labelMillesime = new Label();
            labelCave = new Label();
            labelQuantite = new Label();
            btnAjouter = new Button();
            txtBoxNomVin = new TextBox();
            comboBoxAppellation = new ComboBox();
            txtBoxMillesime = new TextBox();
            comboBoxCave = new ComboBox();
            textBoxQuantite = new TextBox();
            comboBoxCouleur = new ComboBox();
            labelGardeMin = new Label();
            labelGardeMax = new Label();
            txtBoxGardeMin = new TextBox();
            txtBoxGardeMax = new TextBox();
            SuspendLayout();
            // 
            // labelNomDuVin
            // 
            labelNomDuVin.AutoSize = true;
            labelNomDuVin.Location = new Point(116, 25);
            labelNomDuVin.Name = "labelNomDuVin";
            labelNomDuVin.Size = new Size(76, 15);
            labelNomDuVin.TabIndex = 0;
            labelNomDuVin.Text = "Nom du vin :";
            // 
            // labelAppellation
            // 
            labelAppellation.AutoSize = true;
            labelAppellation.Location = new Point(116, 84);
            labelAppellation.Name = "labelAppellation";
            labelAppellation.Size = new Size(74, 15);
            labelAppellation.TabIndex = 1;
            labelAppellation.Text = "Appellation :";
            // 
            // labelCouleur
            // 
            labelCouleur.AutoSize = true;
            labelCouleur.Location = new Point(116, 137);
            labelCouleur.Name = "labelCouleur";
            labelCouleur.Size = new Size(55, 15);
            labelCouleur.TabIndex = 2;
            labelCouleur.Text = "Couleur :";
            // 
            // labelMillesime
            // 
            labelMillesime.AutoSize = true;
            labelMillesime.Location = new Point(116, 186);
            labelMillesime.Name = "labelMillesime";
            labelMillesime.Size = new Size(101, 15);
            labelMillesime.TabIndex = 3;
            labelMillesime.Text = "Année millésime :";
            // 
            // labelCave
            // 
            labelCave.AutoSize = true;
            labelCave.Location = new Point(116, 234);
            labelCave.Name = "labelCave";
            labelCave.Size = new Size(39, 15);
            labelCave.TabIndex = 4;
            labelCave.Text = "Cave :";
            // 
            // labelQuantite
            // 
            labelQuantite.AutoSize = true;
            labelQuantite.Location = new Point(116, 291);
            labelQuantite.Name = "labelQuantite";
            labelQuantite.Size = new Size(59, 15);
            labelQuantite.TabIndex = 5;
            labelQuantite.Text = "Quantité :";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(445, 151);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(203, 87);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click_1;
            // 
            // txtBoxNomVin
            // 
            txtBoxNomVin.Location = new Point(116, 43);
            txtBoxNomVin.Name = "txtBoxNomVin";
            txtBoxNomVin.Size = new Size(121, 23);
            txtBoxNomVin.TabIndex = 7;
            // 
            // comboBoxAppellation
            // 
            comboBoxAppellation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAppellation.FormattingEnabled = true;
            comboBoxAppellation.Location = new Point(116, 102);
            comboBoxAppellation.Name = "comboBoxAppellation";
            comboBoxAppellation.Size = new Size(121, 23);
            comboBoxAppellation.TabIndex = 8;
            // 
            // txtBoxMillesime
            // 
            txtBoxMillesime.Location = new Point(116, 208);
            txtBoxMillesime.Name = "txtBoxMillesime";
            txtBoxMillesime.Size = new Size(121, 23);
            txtBoxMillesime.TabIndex = 10;
            // 
            // comboBoxCave
            // 
            comboBoxCave.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCave.FormattingEnabled = true;
            comboBoxCave.Location = new Point(116, 252);
            comboBoxCave.Name = "comboBoxCave";
            comboBoxCave.Size = new Size(121, 23);
            comboBoxCave.TabIndex = 11;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Location = new Point(116, 309);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(121, 23);
            textBoxQuantite.TabIndex = 12;
            // 
            // comboBoxCouleur
            // 
            comboBoxCouleur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCouleur.FormattingEnabled = true;
            comboBoxCouleur.Location = new Point(116, 155);
            comboBoxCouleur.Name = "comboBoxCouleur";
            comboBoxCouleur.Size = new Size(121, 23);
            comboBoxCouleur.TabIndex = 13;
            // 
            // labelGardeMin
            // 
            labelGardeMin.AutoSize = true;
            labelGardeMin.Location = new Point(116, 345);
            labelGardeMin.Name = "labelGardeMin";
            labelGardeMin.Size = new Size(100, 15);
            labelGardeMin.TabIndex = 14;
            labelGardeMin.Text = "Garde minimum :";
            // 
            // labelGardeMax
            // 
            labelGardeMax.AutoSize = true;
            labelGardeMax.Location = new Point(116, 394);
            labelGardeMax.Name = "labelGardeMax";
            labelGardeMax.Size = new Size(102, 15);
            labelGardeMax.TabIndex = 15;
            labelGardeMax.Text = "Garde maximum :";
            // 
            // txtBoxGardeMin
            // 
            txtBoxGardeMin.Location = new Point(116, 364);
            txtBoxGardeMin.Name = "txtBoxGardeMin";
            txtBoxGardeMin.Size = new Size(121, 23);
            txtBoxGardeMin.TabIndex = 16;
            // 
            // txtBoxGardeMax
            // 
            txtBoxGardeMax.Location = new Point(116, 412);
            txtBoxGardeMax.Name = "txtBoxGardeMax";
            txtBoxGardeMax.Size = new Size(121, 23);
            txtBoxGardeMax.TabIndex = 17;
            // 
            // FormAjouterVin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxGardeMax);
            Controls.Add(txtBoxGardeMin);
            Controls.Add(labelGardeMax);
            Controls.Add(labelGardeMin);
            Controls.Add(comboBoxCouleur);
            Controls.Add(textBoxQuantite);
            Controls.Add(comboBoxCave);
            Controls.Add(txtBoxMillesime);
            Controls.Add(comboBoxAppellation);
            Controls.Add(txtBoxNomVin);
            Controls.Add(btnAjouter);
            Controls.Add(labelQuantite);
            Controls.Add(labelCave);
            Controls.Add(labelMillesime);
            Controls.Add(labelCouleur);
            Controls.Add(labelAppellation);
            Controls.Add(labelNomDuVin);
            Name = "FormAjouterVin";
            Text = "Ajouter Vin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomDuVin;
        private Label labelAppellation;
        private Label labelCouleur;
        private Label labelMillesime;
        private Label labelCave;
        private Label labelQuantite;
        private Button btnAjouter;
        private TextBox txtBoxNomVin;
        private ComboBox comboBoxAppellation;
        private TextBox txtBoxMillesime;
        private ComboBox comboBoxCave;
        private TextBox textBoxQuantite;
        private ComboBox comboBoxCouleur;
        private Label labelGardeMin;
        private Label labelGardeMax;
        private TextBox txtBoxGardeMin;
        private TextBox txtBoxGardeMax;
    }
}