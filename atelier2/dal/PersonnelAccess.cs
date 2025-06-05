using atelier2.bddmanager;
using atelier2.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace atelier2.dal
{
    /// <summary>
    /// Classe d’accès aux données pour le personnel.
    /// </summary>
    public class PersonnelAccess
    {
        private readonly BddManager bddManager;

        public PersonnelAccess()
        {

            bddManager = BddManager.GetInstance("server=localhost;user id=root;password=;database=gestion_absences;SslMode=none");
        }

        /// <summary>
        /// Récupère la liste de tous les personnels.
        /// </summary>
        public List<Personnel> GetAllPersonnels()
        {
            string query = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel ORDER BY nom";
            List<Personnel> liste = new List<Personnel>();
            var records = bddManager.ReqSelect(query);

            foreach (var row in records)
            {
                Personnel p = new Personnel(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    Convert.ToInt32(row[5])
                );
                liste.Add(p);
            }

            return liste;
        }

        /// <summary>
        /// Ajoute un nouveau personnel à la base de données.
        /// </summary>
        public void AjouterPersonnel(Personnel personnel)
        {
            string query = @"INSERT INTO personnel (nom, prenom, tel, mail, idservice)
                             VALUES (@nom, @prenom, @tel, @mail, @idservice)";

            var parameters = new Dictionary<string, object>
            {
                { "@nom", personnel.Nom },
                { "@prenom", personnel.Prenom },
                { "@tel", personnel.Tel },
                { "@mail", personnel.Mail },
                { "@idservice", personnel.IdService }
            };

            bddManager.ReqUpdate(query, parameters);
        }
        /// <summary>
        /// Met à jour les informations d’un personnel existant.
        /// </summary>
        /// <param name="personnel">Objet Personnel contenant les nouvelles données</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            string query = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @id";

            var parameters = new Dictionary<string, object>
    {
        { "@nom", personnel.Nom },
        { "@prenom", personnel.Prenom },
        { "@tel", personnel.Tel },
        { "@mail", personnel.Mail },
        { "@idservice", personnel.IdService },
        { "@id", personnel.IdPersonnel }
    };

            bddManager.ReqUpdate(query, parameters);
        }
        public bool ModifierPersonnel(Personnel personnel)
        {
            string query = @"UPDATE personnel
                     SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice
                     WHERE idpersonnel = @id";

            var parameters = new Dictionary<string, object>
    {
        {"@nom", personnel.Nom},
        {"@prenom", personnel.Prenom},
        {"@tel", personnel.Tel},
        {"@mail", personnel.Mail},
        {"@idservice", personnel.IdService},
            {"@id", personnel.IdPersonnel}
        };

            try
            {
                bddManager.ReqUpdate(query, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void SupprimerPersonnel(int id)
        {
            string req = "DELETE FROM personnel WHERE idpersonnel = @id";
            Dictionary<string, object> parameters = new()
            {
                { "@id", id }
            };
            bddManager.ReqUpdate(req, parameters);
        }

    }
}
