using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public static class teamDAL
    {
        public static DataTable getAllTeams()
        {
            return DBL.ExecuteQuery("select * from team");

        }

       

        public static DataTable getTeamName(int teamId)
        {
            string query = "select teamName FROM Team   ";
            query += String.Format("where teamId = {0}", teamId);
            return DBL.ExecuteQuery(query);

           // query += String.Format("Where(teamOneId = {0} Or teamTwoId = {0})", teamId);
        }

        public static DataTable getTeamId(string teamName)
        {
            string query = "select teamId FROM Team   ";
            query += String.Format("where teamName = '{0}'", teamName);
            return DBL.ExecuteQuery(query);

            // query += String.Format("Where(teamOneId = {0} Or teamTwoId = {0})", teamId);
        }

    }
}
