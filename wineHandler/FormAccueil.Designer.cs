namespace wineHandler
{
    partial class FormAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            checkBoxAppoge = new CheckBox();
            txtBoxSearch = new TextBox();
            comboBoxCave = new ComboBox();
            comboBoxAppellation = new ComboBox();
            DataGridVin = new DataGridView();
            Vin = new DataGridViewTextBoxColumn();
            Appellation = new DataGridViewTextBoxColumn();
            DateConsommation = new DataGridViewTextBoxColumn();
            Cave = new DataGridViewTextBoxColumn();
            Tiroir = new DataGridViewTextBoxColumn();
            Consommer = new DataGridViewTextBoxColumn();
            labelAppellation = new Label();
            labelCave = new Label();
            btnRechercher = new Button();
            btnAjouterCave = new Button();
            btnAjouterVin = new Button();
            btnSupprimerBouteille = new Button();
            btnConsommerBouteille = new Button();
            checkBoxStockUniquement = new CheckBox();
            btnExportCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridVin).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(76, 15);
            Title.TabIndex = 0;
            Title.Text = "WineHandler";
            // 
            // checkBoxAppoge
            // 
            checkBoxAppoge.AutoSize = true;
            checkBoxAppoge.Location = new Point(20, 113);
            checkBoxAppoge.Name = "checkBoxAppoge";
            checkBoxAppoge.Size = new Size(68, 19);
            checkBoxAppoge.TabIndex = 1;
            checkBoxAppoge.Text = "Appogé";
            checkBoxAppoge.UseVisualStyleBackColor = true;
            checkBoxAppoge.CheckedChanged += checkBoxAppoge_CheckedChanged;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxSearch.Location = new Point(17, 80);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(194, 23);
            txtBoxSearch.TabIndex = 2;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // comboBoxCave
            // 
            comboBoxCave.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCave.FormattingEnabled = true;
            comboBoxCave.Location = new Point(337, 80);
            comboBoxCave.Name = "comboBoxCave";
            comboBoxCave.Size = new Size(121, 23);
            comboBoxCave.TabIndex = 3;
            // 
            // comboBoxAppellation
            // 
            comboBoxAppellation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAppellation.FormattingEnabled = true;
            comboBoxAppellation.Location = new Point(214, 80);
            comboBoxAppellation.Name = "comboBoxAppellation";
            comboBoxAppellation.Size = new Size(121, 23);
            comboBoxAppellation.TabIndex = 4;
            // 
            // DataGridVin
            // 
            DataGridVin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVin.Columns.AddRange(new DataGridViewColumn[] { Vin, Appellation, DateConsommation, Cave, Tiroir, Consommer });
            DataGridVin.Location = new Point(29, 189);
            DataGridVin.Name = "DataGridVin";
            DataGridVin.Size = new Size(963, 325);
            DataGridVin.TabIndex = 5;
            // 
            // Vin
            // 
            Vin.HeaderText = "Vin";
            Vin.Name = "Vin";
            // 
            // Appellation
            // 
            Appellation.HeaderText = "Appellation";
            Appellation.Name = "Appellation";
            // 
            // DateConsommation
            // 
            DateConsommation.HeaderText = "Date Consommation";
            DateConsommation.Name = "DateConsommation";
            // 
            // Cave
            // 
            Cave.HeaderText = "Cave";
            Cave.Name = "Cave";
            // 
            // Tiroir
            // 
            Tiroir.HeaderText = "Tiroir";
            Tiroir.Name = "Tiroir";
            // 
            // Consommer
            // 
            Consommer.HeaderText = "Statut";
            Consommer.Name = "Consommer";
            // 
            // labelAppellation
            // 
            labelAppellation.AutoSize = true;
            labelAppellation.Location = new Point(212, 62);
            labelAppellation.Name = "labelAppellation";
            labelAppellation.Size = new Size(74, 15);
            labelAppellation.TabIndex = 6;
            labelAppellation.Text = "Appellation :";
            // 
            // labelCave
            // 
            labelCave.AutoSize = true;
            labelCave.Location = new Point(337, 62);
            labelCave.Name = "labelCave";
            labelCave.Size = new Size(39, 15);
            labelCave.TabIndex = 7;
            labelCave.Text = "Cave :";
            labelCave.Click += labelCave_Click;
            // 
            // btnRechercher
            // 
            btnRechercher.Location = new Point(339, 122);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(119, 41);
            btnRechercher.TabIndex = 8;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = true;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnAjouterCave
            // 
            btnAjouterCave.Location = new Point(522, 80);
            btnAjouterCave.Name = "btnAjouterCave";
            btnAjouterCave.Size = new Size(101, 52);
            btnAjouterCave.TabIndex = 9;
            btnAjouterCave.Text = "Ajouter une cave";
            btnAjouterCave.UseVisualStyleBackColor = true;
            btnAjouterCave.Click += btnAjouterCave_Click;
            // 
            // btnAjouterVin
            // 
            btnAjouterVin.Location = new Point(629, 80);
            btnAjouterVin.Name = "btnAjouterVin";
            btnAjouterVin.Size = new Size(104, 52);
            btnAjouterVin.TabIndex = 10;
            btnAjouterVin.Text = "Ajouter un vin";
            btnAjouterVin.UseVisualStyleBackColor = true;
            btnAjouterVin.Click += btnAjouterVin_Click_1;
            // 
            // btnSupprimerBouteille
            // 
            btnSupprimerBouteille.Location = new Point(455, 533);
            btnSupprimerBouteille.Name = "btnSupprimerBouteille";
            btnSupprimerBouteille.Size = new Size(75, 23);
            btnSupprimerBouteille.TabIndex = 11;
            btnSupprimerBouteille.Text = "Supprimer";
            btnSupprimerBouteille.UseVisualStyleBackColor = true;
            btnSupprimerBouteille.Click += btnSupprimerBouteille_Click;
            // 
            // btnConsommerBouteille
            // 
            btnConsommerBouteille.Location = new Point(214, 122);
            btnConsommerBouteille.Name = "btnConsommerBouteille";
            btnConsommerBouteille.Size = new Size(119, 41);
            btnConsommerBouteille.TabIndex = 12;
            btnConsommerBouteille.Text = "Consommer une bouteille";
            btnConsommerBouteille.UseVisualStyleBackColor = true;
            btnConsommerBouteille.Click += btnConsommerBouteille_Click;
            // 
            // checkBoxStockUniquement
            // 
            checkBoxStockUniquement.AutoSize = true;
            checkBoxStockUniquement.Location = new Point(20, 144);
            checkBoxStockUniquement.Name = "checkBoxStockUniquement";
            checkBoxStockUniquement.Size = new Size(123, 19);
            checkBoxStockUniquement.TabIndex = 13;
            checkBoxStockUniquement.Text = "Stock uniquement";
            checkBoxStockUniquement.UseVisualStyleBackColor = true;
            checkBoxStockUniquement.CheckedChanged += checkBoxStockUniquement_CheckedChanged;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(522, 135);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.RightToLeft = RightToLeft.Yes;
            btnExportCSV.Size = new Size(99, 52);
            btnExportCSV.TabIndex = 14;
            btnExportCSV.Text = "Exporter en CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 563);
            Controls.Add(btnExportCSV);
            Controls.Add(checkBoxStockUniquement);
            Controls.Add(btnConsommerBouteille);
            Controls.Add(btnSupprimerBouteille);
            Controls.Add(btnAjouterVin);
            Controls.Add(btnAjouterCave);
            Controls.Add(btnRechercher);
            Controls.Add(labelCave);
            Controls.Add(labelAppellation);
            Controls.Add(DataGridVin);
            Controls.Add(comboBoxAppellation);
            Controls.Add(comboBoxCave);
            Controls.Add(txtBoxSearch);
            Controls.Add(checkBoxAppoge);
            Controls.Add(Title);
            Name = "FormAccueil";
            Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)DataGridVin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private CheckBox checkBoxAppoge;
        private TextBox txtBoxSearch;
        private ComboBox comboBoxCave;
        private ComboBox comboBoxAppellation;
        private DataGridView DataGridVin;
        private Label labelAppellation;
        private Label labelCave;
        private Button btnRechercher;
        private Button btnAjouterCave;
        private Button btnAjouterVin;
        private DataGridViewTextBoxColumn Vin;
        private DataGridViewTextBoxColumn Appellation;
        private DataGridViewTextBoxColumn DateConsommation;
        private DataGridViewTextBoxColumn Cave;
        private DataGridViewTextBoxColumn Tiroir;
        private DataGridViewTextBoxColumn Consommer;
        private Button btnSupprimerBouteille;
        private Button btnConsommerBouteille;
        private CheckBox checkBoxStockUniquement;
        private Button btnExportCSV;
    }
}
