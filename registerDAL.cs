using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public static class registerDAL
    {
        public static int addUser(string Name, string password, string country, string nationalId, string Email)
        {
            string query = "insert into users (username, pass, countryName, NationalId, userEmail) ";
            query += String.Format("Values('{0}', '{1}', '{2}', '{3}', '{4}') ", Name, password, country, nationalId, Email);

            // query += "'Fatma', 'P@ssword', 'Egypt', '29902415494496', 'Fatma@gmail.com')";
            return DBL.ExcuteNonQuery(query);
        }
    }
}
