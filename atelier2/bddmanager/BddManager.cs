using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace atelier2.bddmanager
{
    /// <summary>
    /// Singleton : gère la connexion à la base de données et l'exécution des requêtes SQL.
    /// </summary>
    public class BddManager
    {
        /// <summary>
        /// Instance unique de la classe BddManager.
        /// </summary>
        private static BddManager instance = null;

        /// <summary>
        /// Objet de connexion MySQL.
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Constructeur privé : initialise la connexion à la base et l’ouvre.
        /// </summary>
        /// <param name="stringConnect">Chaîne de connexion MySQL</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Méthode d’accès à l’instance unique de BddManager.
        /// </summary>
        /// <param name="stringConnect">Chaîne de connexion</param>
        /// <returns>Instance unique de BddManager</returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Exécute une requête de type contrôle (ex : begin transaction, commit, rollback).
        /// </summary>
        /// <param name="stringQuery">Requête SQL</param>
        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécute une requête de type mise à jour (insert, update, delete).
        /// </summary>
        /// <param name="stringQuery">Requête SQL</param>
        /// <param name="parameters">Paramètres de la requête (facultatif)</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécute une requête de sélection (select).
        /// </summary>
        /// <param name="stringQuery">Requête SQL</param>
        /// <param name="parameters">Paramètres de la requête (facultatif)</param>
        /// <returns>Liste de tableaux d’objets correspondant aux lignes du résultat</returns>
        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();
            int nbCols = reader.FieldCount;
            List<object[]> records = new List<object[]>();

            while (reader.Read())
            {
                object[] row = new object[nbCols];
                reader.GetValues(row);
                records.Add(row);
            }
            reader.Close();
            return records;
        }
    }
}
