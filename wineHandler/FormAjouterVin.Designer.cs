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

        private void InitializeComponent()
        {
            this.labelNomDuVin = new System.Windows.Forms.Label();
            this.labelAppellation = new System.Windows.Forms.Label();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.labelMillesime = new System.Windows.Forms.Label();
            this.labelCave = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelGardeMin = new System.Windows.Forms.Label();
            this.labelGardeMax = new System.Windows.Forms.Label();
            this.txtBoxNomVin = new System.Windows.Forms.TextBox();
            this.comboBoxAppellation = new System.Windows.Forms.ComboBox();
            this.comboBoxCouleur = new System.Windows.Forms.ComboBox();
            this.txtBoxMillesime = new System.Windows.Forms.TextBox();
            this.comboBoxCave = new System.Windows.Forms.ComboBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.txtBoxGardeMin = new System.Windows.Forms.TextBox();
            this.txtBoxGardeMax = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBoxInfos = new System.Windows.Forms.GroupBox();
            this.groupBoxGarde = new System.Windows.Forms.GroupBox();
            this.groupBoxInfos.SuspendLayout();
            this.groupBoxGarde.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormAjouterVin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAjouterVin";
            this.Text = "Ajouter un vin";

            // 
            // groupBoxInfos
            // 
            this.groupBoxInfos.Controls.Add(this.labelNomDuVin);
            this.groupBoxInfos.Controls.Add(this.txtBoxNomVin);
            this.groupBoxInfos.Controls.Add(this.labelAppellation);
            this.groupBoxInfos.Controls.Add(this.comboBoxAppellation);
            this.groupBoxInfos.Controls.Add(this.labelCouleur);
            this.groupBoxInfos.Controls.Add(this.comboBoxCouleur);
            this.groupBoxInfos.Controls.Add(this.labelMillesime);
            this.groupBoxInfos.Controls.Add(this.txtBoxMillesime);
            this.groupBoxInfos.Controls.Add(this.labelCave);
            this.groupBoxInfos.Controls.Add(this.comboBoxCave);
            this.groupBoxInfos.Controls.Add(this.labelQuantite);
            this.groupBoxInfos.Controls.Add(this.textBoxQuantite);
            this.groupBoxInfos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfos.Location = new System.Drawing.Point(50, 30);
            this.groupBoxInfos.Name = "groupBoxInfos";
            this.groupBoxInfos.Size = new System.Drawing.Size(550, 320);
            this.groupBoxInfos.TabIndex = 0;
            this.groupBoxInfos.TabStop = false;
            this.groupBoxInfos.Text = "Informations sur le vin";

            // 
            // labelNomDuVin
            // 
            this.labelNomDuVin.AutoSize = true;
            this.labelNomDuVin.Location = new System.Drawing.Point(30, 40);
            this.labelNomDuVin.Text = "Nom du vin :";
            // 
            // txtBoxNomVin
            // 
            this.txtBoxNomVin.Location = new System.Drawing.Point(200, 37);
            this.txtBoxNomVin.Size = new System.Drawing.Size(300, 25);
            // 
            // labelAppellation
            // 
            this.labelAppellation.AutoSize = true;
            this.labelAppellation.Location = new System.Drawing.Point(30, 80);
            this.labelAppellation.Text = "Appellation :";
            // 
            // comboBoxAppellation
            // 
            this.comboBoxAppellation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppellation.Location = new System.Drawing.Point(200, 77);
            this.comboBoxAppellation.Size = new System.Drawing.Size(300, 25);
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Location = new System.Drawing.Point(30, 120);
            this.labelCouleur.Text = "Couleur :";
            // 
            // comboBoxCouleur
            // 
            this.comboBoxCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCouleur.Location = new System.Drawing.Point(200, 117);
            this.comboBoxCouleur.Size = new System.Drawing.Size(300, 25);
            // 
            // labelMillesime
            // 
            this.labelMillesime.AutoSize = true;
            this.labelMillesime.Location = new System.Drawing.Point(30, 160);
            this.labelMillesime.Text = "Année millésime :";
            // 
            // txtBoxMillesime
            // 
            this.txtBoxMillesime.Location = new System.Drawing.Point(200, 157);
            this.txtBoxMillesime.Size = new System.Drawing.Size(300, 25);
            // 
            // labelCave
            // 
            this.labelCave.AutoSize = true;
            this.labelCave.Location = new System.Drawing.Point(30, 200);
            this.labelCave.Text = "Cave :";
            // 
            // comboBoxCave
            // 
            this.comboBoxCave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCave.Location = new System.Drawing.Point(200, 197);
            this.comboBoxCave.Size = new System.Drawing.Size(300, 25);
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(30, 240);
            this.labelQuantite.Text = "Quantité :";
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(200, 237);
            this.textBoxQuantite.Size = new System.Drawing.Size(300, 25);

            // 
            // groupBoxGarde
            // 
            this.groupBoxGarde.Controls.Add(this.labelGardeMin);
            this.groupBoxGarde.Controls.Add(this.txtBoxGardeMin);
            this.groupBoxGarde.Controls.Add(this.labelGardeMax);
            this.groupBoxGarde.Controls.Add(this.txtBoxGardeMax);
            this.groupBoxGarde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxGarde.Location = new System.Drawing.Point(50, 370);
            this.groupBoxGarde.Name = "groupBoxGarde";
            this.groupBoxGarde.Size = new System.Drawing.Size(550, 100);
            this.groupBoxGarde.TabIndex = 1;
            this.groupBoxGarde.TabStop = false;
            this.groupBoxGarde.Text = "Durée de garde (années)";

            // 
            // labelGardeMin
            // 
            this.labelGardeMin.AutoSize = true;
            this.labelGardeMin.Location = new System.Drawing.Point(30, 45);
            this.labelGardeMin.Text = "Minimum :";
            // 
            // txtBoxGardeMin
            // 
            this.txtBoxGardeMin.Location = new System.Drawing.Point(120, 42);
            this.txtBoxGardeMin.Size = new System.Drawing.Size(80, 25);
            // 
            // labelGardeMax
            // 
            this.labelGardeMax.AutoSize = true;
            this.labelGardeMax.Location = new System.Drawing.Point(250, 45);
            this.labelGardeMax.Text = "Maximum :";
            // 
            // txtBoxGardeMax
            // 
            this.txtBoxGardeMax.Location = new System.Drawing.Point(350, 42);
            this.txtBoxGardeMax.Size = new System.Drawing.Size(80, 25);

            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(225, 500);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 50);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "➕ Ajouter le vin";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);

            // 
            // FormAjouterVin Controls
            // 
            this.Controls.Add(this.groupBoxInfos);
            this.Controls.Add(this.groupBoxGarde);
            this.Controls.Add(this.btnAjouter);

            this.groupBoxInfos.ResumeLayout(false);
            this.groupBoxInfos.PerformLayout();
            this.groupBoxGarde.ResumeLayout(false);
            this.groupBoxGarde.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelNomDuVin;
        private System.Windows.Forms.Label labelAppellation;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.Label labelMillesime;
        private System.Windows.Forms.Label labelCave;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelGardeMin;
        private System.Windows.Forms.Label labelGardeMax;
        private System.Windows.Forms.TextBox txtBoxNomVin;
        private System.Windows.Forms.ComboBox comboBoxAppellation;
        private System.Windows.Forms.ComboBox comboBoxCouleur;
        private System.Windows.Forms.TextBox txtBoxMillesime;
        private System.Windows.Forms.ComboBox comboBoxCave;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.TextBox txtBoxGardeMin;
        private System.Windows.Forms.TextBox txtBoxGardeMax;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBoxInfos;
        private System.Windows.Forms.GroupBox groupBoxGarde;
    }
}
