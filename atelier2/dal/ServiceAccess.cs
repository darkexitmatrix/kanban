using System;
using System.Collections.Generic;
using System.Configuration;
using atelier2.bddmanager;
using atelier2.model;

namespace atelier2.dal
{
    /// <summary>
    /// Classe d'accès aux données pour les services.
    /// </summary>
    public class ServiceAccess
    {
        private readonly BddManager bdd;

        /// <summary>
        /// Constructeur : initialise la connexion à la base de données.
        /// </summary>
        public ServiceAccess()
        {
            bdd = BddManager.GetInstance("server=localhost;user id=root;password=;database=gestion_absences;SslMode=none");

        }

        /// <summary>
        /// Récupère tous les services depuis la base de données.
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetAllServices()
        {
            var services = new List<Service>();
            const string req = "SELECT idservice, nom FROM service ORDER BY nom;";
            var records = bdd.ReqSelect(req);

            foreach (var record in records)
            {
                if (record.Length >= 2)
                {
                    services.Add(new Service(
                        Convert.ToInt32(record[0]),
                        record[1].ToString()
                    ));
                }
            }

            return services;
        }
    }
}
