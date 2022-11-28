using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    
        public static class DBL
        {
            static string conStr;
            static DBL()
            {
                conStr = "Data Source=LAPTOP-1HA090K9;Initial Catalog=EventTicket;Integrated Security=True";

            }
            public static int ExcuteNonQuery(string dmlCommand)
            {
                int result;
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(dmlCommand, con);
                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
                return result;


            }
            public static DataTable ExecuteQuery(string SqlCommand)
            {
                SqlDataAdapter adapt = new SqlDataAdapter(SqlCommand, conStr);
                DataTable result = new DataTable();
                adapt.Fill(result);
                return result;

            }
    /*    public static List<DataTable> ExecuteQueryList(string SqlCommand)
        {
            SqlDataAdapter adapt = new SqlDataAdapter(SqlCommand, conStr);
         List <DataTable> result = new List<DataTable>();
            adapt.Fill(result); 
            return result;

        }
        */


    }
}
