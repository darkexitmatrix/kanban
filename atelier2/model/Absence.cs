using System;

namespace atelier2.model
{
    public class Absence
    {
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }

        public Absence(int idAbsence, int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            IdAbsence = idAbsence;
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }

        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }
    }
}
