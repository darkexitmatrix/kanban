using atelier2.bddmanager;
using atelier2.model;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace atelier2.dal
{
    public class MotifAccess
    {
        private readonly BddManager bdd;

        public MotifAccess()
        {
            string stringConnect = ConfigurationManager.ConnectionStrings["connexion"].ConnectionString;
            bdd = BddManager.GetInstance(stringConnect);
        }

        public List<Motif> GetAllMotifs()
        {
            List<Motif> motifs = new();
            string req = "SELECT idmotif, libelle FROM motif ORDER BY libelle;";
            var records = bdd.ReqSelect(req);

            foreach (var record in records)
            {
                motifs.Add(new Motif(Convert.ToInt32(record[0]), record[1].ToString()));
            }

            return motifs;
        }
    }
}
