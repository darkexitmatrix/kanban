using System;
using System.Collections.Generic;
using atelier2.model;
using atelier2.bddmanager;
using System.Configuration;

namespace atelier2.dal
{
    public class AbsenceAccess
    {
        private readonly BddManager bdd;

        public AbsenceAccess()
        {
            string stringConnect = ConfigurationManager.ConnectionStrings["connexion"].ConnectionString;
            bdd = BddManager.GetInstance(stringConnect);
        }

        public List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            string query = "SELECT idabsence, datedebut, datefin, motif FROM absence WHERE idpersonnel = @id ORDER BY datedebut DESC;";
            var parameters = new Dictionary<string, object> { { "@id", idPersonnel } };
            var records = bdd.ReqSelect(query, parameters);

            List<Absence> absences = new();
            foreach (object[] row in records)
            {
                absences.Add(new Absence(
                    Convert.ToInt32(row[0]),
                    idPersonnel,
                    Convert.ToDateTime(row[1]),
                    Convert.ToDateTime(row[2]),
                    row[3].ToString()
                ));
            }

            return absences;
        }

        public void SupprimerAbsence(int idAbsence)
        {
            string query = "DELETE FROM absence WHERE idabsence = @id";
            var parameters = new Dictionary<string, object> { { "@id", idAbsence } };
            bdd.ReqUpdate(query, parameters);
        }

        public void AjouterAbsence(Absence absence)
        {
            string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, motif) VALUES (@idp, @deb, @fin, @motif)";
            var parameters = new Dictionary<string, object>
            {
                { "@idp", absence.IdPersonnel },
                { "@deb", absence.DateDebut },
                { "@fin", absence.DateFin },
                { "@motif", absence.Motif }
            };
            bdd.ReqUpdate(query, parameters);
        }

        public void ModifierAbsence(Absence absence)
        {
            string query = "UPDATE absence SET datedebut = @deb, datefin = @fin, motif = @motif WHERE idabsence = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", absence.IdAbsence },
                { "@deb", absence.DateDebut },
                { "@fin", absence.DateFin },
                { "@motif", absence.Motif }
            };
            bdd.ReqUpdate(query, parameters);
        }
    }
}
