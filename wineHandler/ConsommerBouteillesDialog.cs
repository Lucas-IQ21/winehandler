using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wineHandler.Utils;
using wineHandler.Models;

namespace wineHandler
{
    public partial class ConsommerBouteillesDialog : Form
    {
        private readonly ComboBox comboStatut = new ComboBox();
        private readonly DateTimePicker dtpDate = new DateTimePicker();
        private readonly Button btnOK = new Button();
        private readonly Button btnCancel = new Button();

        private static readonly StatutBouteille[] Allowed =
            { StatutBouteille.C, StatutBouteille.V, StatutBouteille.G, StatutBouteille.X };

        public string SelectedCode => (string)comboStatut.SelectedValue;
        public DateTime SelectedDate => dtpDate.Value.Date;

        public ConsommerBouteillesDialog()
        {
            Text = "Consommer la bouteille";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = MinimizeBox = false;
            ClientSize = new Size(380, 180);
            Font = new Font("Segoe UI", 10);

            var lblStatut = new Label { Text = "Statut :", AutoSize = true, Location = new Point(20, 25) };
            var lblDate = new Label { Text = "Date :", AutoSize = true, Location = new Point(20, 70) };

            var items = Allowed
                .Select(ev => new { Code = ev.ToString(), Label = EnumHelper.GetDescription(ev) })
                .ToList();

            comboStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatut.DisplayMember = "Label";
            comboStatut.ValueMember = "Code";
            comboStatut.DataSource = items;
            comboStatut.Location = new Point(120, 20);
            comboStatut.Width = 220;

            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(120, 65);
            dtpDate.Width = 220;
            dtpDate.Value = DateTime.Today;

            btnOK.Text = "Valider";
            btnOK.BackColor = Color.ForestGreen;
            btnOK.ForeColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Location = new Point(120, 115);
            btnOK.Size = new Size(100, 35);
            btnOK.DialogResult = DialogResult.OK;

            btnCancel.Text = "Annuler";
            btnCancel.BackColor = Color.DimGray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new Point(240, 115);
            btnCancel.Size = new Size(100, 35);
            btnCancel.DialogResult = DialogResult.Cancel;

            Controls.AddRange(new Control[] { lblStatut, comboStatut, lblDate, dtpDate, btnOK, btnCancel });
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }
    }
}
