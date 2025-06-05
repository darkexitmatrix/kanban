using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using atelier2.dal;

namespace atelier2
{
    public partial class FrmConnexion : Form
    {
        private readonly ResponsableAccess responsableAccess;

        public FrmConnexion()
        {
            InitializeComponent();
            responsableAccess = new ResponsableAccess("server=localhost;user id=root;database=gestion_absences;password=;");
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            txtLogin.Focus(); // optionnel
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string mdp = txtMdp.Text;

            lblMessage.Text = "";

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdp))
            {
                lblMessage.Text = "Veuillez saisir tous les champs.";
                return;
            }

            string hashMdp = HashPassword(mdp);

            try
            {
                if (responsableAccess.VerifierConnexion(login, hashMdp))
                {
                    FrmPersonnel frmPersonnel = new();
                    frmPersonnel.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = "Identifiants incorrects.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private static string HashPassword(string pwd)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            StringBuilder builder = new();
            foreach (byte b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}
