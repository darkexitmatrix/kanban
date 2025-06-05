namespace atelier2.model
{
    /// <summary>
    /// Représente un personnel de l'organisation.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du personnel.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou définit le prénom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Obtient ou définit l'adresse mail du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du service auquel appartient le personnel.
        /// </summary>
        public int IdService { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Personnel"/>.
        /// </summary>
        /// <param name="id">Identifiant du personnel</param>
        /// <param name="nom">Nom</param>
        /// <param name="prenom">Prénom</param>
        /// <param name="tel">Téléphone</param>
        /// <param name="mail">Adresse mail</param>
        /// <param name="idService">Identifiant du service</param>
        public Personnel(int id, string nom, string prenom, string tel, string mail, int idService)
        {
            IdPersonnel = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            IdService = idService;
        }
    }
}
