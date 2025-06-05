namespace atelier2.model
{
    /// <summary>
    /// Représente un motif d'absence (maladie, vacances, etc.).
    /// </summary>
    public class Motif
    {
        /// <summary>Identifiant du motif</summary>
        public int IdMotif { get; set; }

        /// <summary>Libellé du motif</summary>
        public string Libelle { get; set; }

        public Motif(int idMotif, string libelle)
        {
            IdMotif = idMotif;
            Libelle = libelle;
        }
    }
}
