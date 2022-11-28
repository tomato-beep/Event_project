using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    public static class TicketDAL
    {

        public static int bookTicket(int matchId, int userId, int degree)
        {
            string query = "INSERT into ticket (matchId ,userId ,Degree ) ";

            query += String.Format("Values('{0}', '{1}', '{2}')", matchId, userId, degree);

            return DBL.ExcuteNonQuery(query);
        }

        public static DataTable getTicketByUserIdAndMatchId(int userId, int matchId)
        {
            string query = "select * from ticket ";
            query += String.Format("Where userId= '{0}' and matchId = '{1}' ", userId, matchId);
            return DBL.ExecuteQuery(query);
        }

        public static DataTable getAllTickets(int matchId)
        {
            string query = "select * from ticket ";
            query += String.Format("Where matchId= {0} ", matchId);
            return DBL.ExecuteQuery(query);

        }
        public static DataTable getTicketByUser(int userId)
        {
            string query = "select * from ticket ";
            query += String.Format("Where userId = {0} ", userId);  
            return DBL.ExecuteQuery(query);

        }

        public static DataTable getTicketById(int ticketId)
        {
            string query = "select * from ticket ";
            query += String.Format("Where ticketId = {0} ", ticketId);
            return DBL.ExecuteQuery(query);

        }

        

    }
}
