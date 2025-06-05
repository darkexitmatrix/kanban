namespace atelier2.model
{
    /// <summary>
    /// Représente un service dans l'organisation.
    /// </summary>
    public class Service
    {
        /// <summary>Identifiant du service</summary>
        public int IdService { get; set; }

        /// <summary>Nom du service</summary>
        public string Nom { get; set; }

        public Service(int idService, string nom)
        {
            IdService = idService;
            Nom = nom;
        }
    }
}
