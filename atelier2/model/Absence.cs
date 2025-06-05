using System;

namespace atelier2.model
{
    /// <summary>
    /// Représente une absence d'un personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>Identifiant du personnel lié à l'absence</summary>
        public int IdPersonnel { get; set; }

        /// <summary>Date de début de l'absence</summary>
        public DateTime DateDebut { get; set; }

        /// <summary>Date de fin de l'absence</summary>
        public DateTime DateFin { get; set; }

        /// <summary>Identifiant du motif de l'absence</summary>
        public int IdMotif { get; set; }

        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdMotif = idMotif;
        }
    }
}
