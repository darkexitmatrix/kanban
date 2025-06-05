using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmAbsences : Form
    {
        private readonly Personnel personnel;
        private readonly AbsenceAccess absenceAccess;
        private readonly MotifAccess motifAccess;

        public FrmAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        private void FrmAbsences_Load(object sender, EventArgs e)
        {
            lblTitre.Text = $"Absences de {personnel.Prenom} {personnel.Nom}";
            ChargerAbsences();
        }

        private void ChargerAbsences()
        {
            dgvAbsences.Rows.Clear();
            List<Absence> absences = absenceAccess.GetAbsencesByPersonnel(personnel.IdPersonnel);
            foreach (Absence abs in absences)
            {
                dgvAbsences.Rows.Add(abs.DateDebut.ToShortDateString(), abs.DateFin?.ToShortDateString() ?? "", abs.Motif.Libelle);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterAbsence frm = new FrmAjouterAbsence(personnel);
            if (frm.ShowDialog() == DialogResult.OK)
                ChargerAbsences();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.CurrentRow == null)
                return;

            Absence absence = absenceAccess.GetAbsencesByPersonnel(personnel.IdPersonnel)[dgvAbsences.CurrentRow.Index];
            FrmModifierAbsence frm = new FrmModifierAbsence(absence);
            if (frm.ShowDialog() == DialogResult.OK)
                ChargerAbsences();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.CurrentRow == null)
                return;

            var result = MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Absence abs = absenceAccess.GetAbsencesByPersonnel(personnel.IdPersonnel)[dgvAbsences.CurrentRow.Index];
                absenceAccess.SupprimerAbsence(abs.IdAbsence);
                ChargerAbsences();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
