using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmAjouterPersonnel : Form
    {
        private readonly ServiceAccess serviceAccess;
        private readonly PersonnelAccess personnelAccess;

        public FrmAjouterPersonnel()
        {
            InitializeComponent();
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAccess();
        }

        private void FrmAjouterPersonnel_Load(object sender, EventArgs e)
        {
            List<Service> services = serviceAccess.GetAllServices();
            cmbService.DataSource = services;
            cmbService.DisplayMember = "Nom";
            cmbService.ValueMember = "IdService";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string tel = txtTel.Text.Trim();
            string mail = txtMail.Text.Trim();
            Service selectedService = (Service)cmbService.SelectedItem;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(mail) || selectedService == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            Personnel nouveau = new Personnel(0, nom, prenom, tel, mail, selectedService.IdService);
            personnelAccess.AjouterPersonnel(nouveau);

            MessageBox.Show("Personnel ajouté avec succès.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
