namespace atelier2.model
{
    /// <summary>
    /// Représente le responsable de l'application (authentification).
    /// </summary>
    public class Responsable
    {
        /// <summary>Login du responsable</summary>
        public string Login { get; set; }

        /// <summary>Mot de passe du responsable (hashé en SHA2)</summary>
        public string Pwd { get; set; }

        public Responsable(string login, string pwd)
        {
            Login = login;
            Pwd = pwd;
        }
    }
}
