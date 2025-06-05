using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmModifierPersonnel : Form
    {
        private readonly Personnel personnel;
        private readonly ServiceAccess serviceAccess;
        private readonly PersonnelAccess personnelAccess;

        public FrmModifierPersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAccess();
            this.Load += FrmModifierPersonnel_Load;
        }

        private void FrmModifierPersonnel_Load(object sender, EventArgs e)
        {
            try
            {
                List<Service> services = serviceAccess.GetAllServices();

                cmbService.DisplayMember = "Nom";
                cmbService.ValueMember = "IdService";
                cmbService.DataSource = services;

                // Préremplir les champs
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;

                int index = services.FindIndex(s => s.IdService == personnel.IdService);
                if (index >= 0)
                {
                    cmbService.SelectedIndex = index;
                }
                else
                {
                    cmbService.SelectedIndex = -1;
                    MessageBox.Show("Le service associé n’existe plus.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text)
                    || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtMail.Text)
                    || cmbService.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mise à jour des données
                personnel.Nom = txtNom.Text.Trim();
                personnel.Prenom = txtPrenom.Text.Trim();
                personnel.Tel = txtTel.Text.Trim();
                personnel.Mail = txtMail.Text.Trim();
                personnel.IdService = ((Service)cmbService.SelectedItem).IdService;

                // Appel DAL
                bool success = personnelAccess.ModifierPersonnel(personnel);

                if (success)
                {
                    MessageBox.Show("Modification réussie.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("La modification a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
