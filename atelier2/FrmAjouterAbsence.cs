using System;
using System.Windows.Forms;
using atelier2.model;
using atelier2.dal;

namespace atelier2
{
    public partial class FrmAjouterAbsence : Form
    {
        private readonly Personnel personnel;
        private readonly AbsenceAccess absenceAccess;

        public FrmAjouterAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            absenceAccess = new AbsenceAccess();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Absence newAbs = new Absence(
                    personnel.IdPersonnel,
                    dtpDebut.Value,
                    dtpFin.Value,
                    txtMotif.Text.Trim()
                );

                absenceAccess.AjouterAbsence(newAbs);
                MessageBox.Show("Absence ajoutée !");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
