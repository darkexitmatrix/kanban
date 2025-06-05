namespace atelier2
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            lblMessage.Text = ""; // Initialisation du label
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string mdp = txtMdp.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mdp))
            {
                lblMessage.Text = "Veuillez saisir tous les champs.";
            }
            else
            {
                lblMessage.Text = "Tentative de connexion...";
            }
        }
    }
}
