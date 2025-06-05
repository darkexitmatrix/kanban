using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmModifierAbsence : Form
    {
        private readonly MotifAccess motifAccess = new MotifAccess();
        private readonly Absence absence;

        public FrmModifierAbsence(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;
            Load += FrmModifierAbsence_Load;
            btnValider.Click += btnValider_Click;
            btnAnnuler.Click += btnAnnuler_Click;
        }

        private void FrmModifierAbsence_Load(object sender, EventArgs e)
        {
            txtPersonnel.Text = absence.IdPersonnel.ToString();
            dtpDebut.Value = absence.DateDebut;
            dtpFin.Value = absence.DateFin;
            List<Motif> motifs = motifAccess.GetAllMotifs();
            cmbMotif.DataSource = motifs;
            cmbMotif.DisplayMember = "Libelle";
            cmbMotif.ValueMember = "IdMotif";
            cmbMotif.SelectedValue = motifs.Find(m => m.Libelle == absence.Motif)?.IdMotif;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cmbMotif.SelectedItem is Motif motifSelectionne)
            {
                Absence absModif = new Absence(
                    absence.IdAbsence,
                    absence.IdPersonnel,
                    dtpDebut.Value,
                    dtpFin.Value,
                    motifSelectionne.Libelle
                );

                AbsenceAccess access = new AbsenceAccess();
                access.ModifierAbsence(absModif);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
