using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace FantasySports.DataAccess
{
    public class LeagueData
    {
        public static void addLeague(string leagueName)
        {
            SqlParameter[] param = { new SqlParameter("leagueName", leagueName)};
            
            StoredProcedures.callNonQuerySproc("addLeague", param);
        }
    }
}