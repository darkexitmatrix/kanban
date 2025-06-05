using atelier2.bddmanager;
using System.Collections.Generic;

namespace atelier2.dal
{
    public class ResponsableAccess
    {
        private readonly BddManager bdd;

        public ResponsableAccess(string stringConnect)
        {
            bdd = BddManager.GetInstance(stringConnect);
        }

        public bool VerifierConnexion(string login, string pwdHash)
        {
            string query = "SELECT * FROM responsable WHERE login = @login AND pwd = @pwd";
            Dictionary<string, object> parameters = new()
            {
                { "@login", login },
                { "@pwd", pwdHash }
            };
            var result = bdd.ReqSelect(query, parameters);
            return result.Count == 1;
        }
    }
}
