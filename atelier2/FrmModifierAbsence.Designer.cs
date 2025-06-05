using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmModifierAbsence : Form
    {
        private Absence absence;
        private readonly AbsenceAccess absenceAccess;
        private readonly MotifAccess motifAccess;
        private List<Motif> motifs;

        private ComboBox cmbMotif;
        private DateTimePicker dtpDebut;
        private DateTimePicker dtpFin;
        private Button btnValider;
        private Button btnAnnuler;
        private TextBox txtPersonnel;

        public FrmModifierAbsence(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        private void FrmModifierAbsence_Load(object sender, EventArgs e)
        {
            txtPersonnel.Text = $"{absence.IdPersonnel}";
            dtpDebut.Value = absence.DateDebut;
            dtpFin.Value = absence.DateFin.HasValue ? absence.DateFin.Value : DateTime.Today;
            dtpFin.Checked = absence.DateFin.HasValue;

            motifs = motifAccess.GetAllMotifs();
            cmbMotif.DataSource = motifs;
            cmbMotif.DisplayMember = "Libelle";
            cmbMotif.ValueMember = "IdMotif";
            cmbMotif.SelectedItem = motifs.Find(m => m.Libelle == absence.Motif);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cmbMotif.SelectedItem is Motif selectedMotif)
            {
                absence.DateDebut = dtpDebut.Value;
                absence.DateFin = dtpFin.Checked ? dtpFin.Value : (DateTime?)null;
                absence.Motif = selectedMotif.Libelle;

                absenceAccess.ModifierAbsence(absence);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void InitializeComponent()
        {
            this.cmbMotif = new ComboBox();
            this.dtpDebut = new DateTimePicker();
            this.dtpFin = new DateTimePicker();
            this.btnValider = new Button();
            this.btnAnnuler = new Button();
            this.txtPersonnel = new TextBox();

            this.SuspendLayout();

            this.txtPersonnel.Location = new System.Drawing.Point(30, 20);
            this.txtPersonnel.ReadOnly = true;
            this.txtPersonnel.Width = 200;

            this.dtpDebut.Location = new System.Drawing.Point(30, 60);
            this.dtpDebut.Width = 200;

            this.dtpFin.Location = new System.Drawing.Point(30, 100);
            this.dtpFin.Width = 200;
            this.dtpFin.ShowCheckBox = true;

            this.cmbMotif.Location = new System.Drawing.Point(30, 140);
            this.cmbMotif.Width = 200;

            this.btnValider.Text = "Valider";
            this.btnValider.Location = new System.Drawing.Point(30, 180);
            this.btnValider.Click += new EventHandler(this.btnValider_Click);

            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Location = new System.Drawing.Point(150, 180);
            this.btnAnnuler.Click += new EventHandler(this.btnAnnuler_Click);

            this.Controls.Add(this.txtPersonnel);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.cmbMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);

            this.Text = "Modifier une absence";
            this.ClientSize = new System.Drawing.Size(280, 240);
            this.Load += new EventHandler(this.FrmModifierAbsence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
