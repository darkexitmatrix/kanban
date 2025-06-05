using System;
using System.Collections.Generic;
using System.Configuration;
using atelier2.bddmanager;
using atelier2.model;
using atelier2.modele;

namespace atelier2.dal
{
    /// <summary>
    /// Classe d’accès aux données pour le personnel.
    /// </summary>
    public class PersonnelAccess
    {
        private readonly string chaineConnexion;

        /// <summary>
        /// Constructeur : initialise la chaîne de connexion depuis App.config.
        /// </summary>
        public PersonnelAccess()
        {
            chaineConnexion = ConfigurationManager.ConnectionStrings["gestionAbsences"].ConnectionString;
        }

        /// <summary>
        /// Récupère la liste complète des personnels.
        /// </summary>
        /// <returns>Liste d'objets Personnel</returns>
        public List<Personnel> GetAllPersonnels()
        {
            List<Personnel> personnels = new List<Personnel>();
            BddManager bdd = BddManager.GetInstance(chaineConnexion);

            string query = @"SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel";

            List<object[]> resultats = bdd.ReqSelect(query);

            foreach (object[] ligne in resultats)
            {
                Personnel p = new Personnel(
                    Convert.ToInt32(ligne[0]),
                    ligne[1].ToString(),
                    ligne[2].ToString(),
                    ligne[3].ToString(),
                    ligne[4].ToString(),
                    Convert.ToInt32(ligne[5])
                );
                personnels.Add(p);
            }

            return personnels;
        }

        /// <summary>
        /// Récupère un personnel par son identifiant.
        /// </summary>
        /// <param name="id">ID du personnel</param>
        /// <returns>Un objet Personnel ou null si non trouvé</returns>
        public Personnel GetPersonnelById(int id)
        {
            BddManager bdd = BddManager.GetInstance(chaineConnexion);

            string query = @"SELECT idpersonnel, nom, prenom, tel, mail, idservice 
                             FROM personnel 
                             WHERE idpersonnel = @id";

            var parameters = new Dictionary<string, object> { { "@id", id } };
            List<object[]> resultats = bdd.ReqSelect(query, parameters);

            if (resultats.Count > 0)
            {
                object[] ligne = resultats[0];
                return new Personnel(
                    Convert.ToInt32(ligne[0]),
                    ligne[1].ToString(),
                    ligne[2].ToString(),
                    ligne[3].ToString(),
                    ligne[4].ToString(),
                    Convert.ToInt32(ligne[5])
                );
            }

            return null;
        }
    }
}
