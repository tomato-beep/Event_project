using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public static class signInDAL
    {
        public static DataTable getUserByNameAndPassword(string userName, string password)
        {
            string query = "Select * From users ";

            query += "Where username= '" + userName + "'" + " and pass = '" + password + "'";
            return DBL.ExecuteQuery(query);
        }
        /* public static DataTable getUserByNameAndPassword(string userName, string password)
         {
             string query = "Select * From users ";

             query += "where username = '" + userName + "'" + " and pass = '" + password + "'";
             return DBL.ExecuteQuery(query);
         }
         */
        public static DataTable getUserById(int userId)
        {
            string query = "Select * From users ";
            query += String.Format("Where userId= {0} ", userId);
            return DBL.ExecuteQuery(query);
        }


    }
}
