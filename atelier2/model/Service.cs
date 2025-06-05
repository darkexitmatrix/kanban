namespace atelier2.model
{
    /// <summary>
    /// Représente un service
    /// </summary>
    public class Service
    {
        public int IdService { get; set; }
        public string Nom { get; set; }

        public Service(int id, string nom)
        {
            IdService = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
