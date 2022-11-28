using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public static class RoundsDAL
    {
        public static DataTable getTeamMatches(int teamId)
        {
            string query = "select * from Matches ";
            query += String.Format("Where(teamOneId = {0} Or teamTwoId = {0})", teamId);
            return DBL.ExecuteQuery(query);

        }
        public static DataTable getMatchesData(int matchId)
        {
            string query = "select * from Matches ";
            query += String.Format("Where matchId = {0} ", matchId);
            return DBL.ExecuteQuery(query);

        }

        

    }
}
