using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form10 : Form
    {
        int move, moveX, moveY;
        public Form10()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(Form2.userId), matchID = Convert.ToInt32(Form8.matchId);
            DataTable z = TicketDAL.getTicketByUserIdAndMatchId(userID, matchID);
            int ticketId = 0, cat = 0;
            


            //Getting ticket ID using user id and matchId..
            foreach (DataRow row in z.Rows)
            {
                ticketId = Convert.ToInt32(row["ticketId"]);
                cat = Convert.ToInt32(row["Degree"]);
            }
            //Name -> username, Fan-id -> userId, Match-ID -> matchID

            z = signInDAL.getUserById(userID);
            string username = "";

            foreach (DataRow row in z.Rows)
            {
                username = Convert.ToString(row["username"]);
            }

            z = RoundsDAL.getMatchesData(matchID);
            string stadium = "";
            string date = "";
            int teamOneId = 0, teamTwoId = 0;

            foreach (DataRow row in z.Rows)
            {
                stadium = Convert.ToString(row["stadium"]);
                date = Convert.ToString(row["matchDate"]);
                teamOneId = Convert.ToInt32(row["teamOneId"]); 
                teamTwoId = Convert.ToInt32(row["teamTwoId"]);
            }

            string teamOneName = "";
            string teamTwoName = "";

            z = teamDAL.getTeamName(teamOneId);
            foreach (DataRow row in z.Rows)
            {
                teamOneName = Convert.ToString(row["teamName"]);
            }

            z = teamDAL.getTeamName(teamTwoId);
            foreach (DataRow row in z.Rows)
            {
                teamTwoName = Convert.ToString(row["teamName"]);
            }





            StadiumNameLabel.Text = stadium;
            dateLabel.Text = date;
            MatchIDLabel.Text = matchID.ToString();
            FanIDLabel.Text = userID.ToString();
            CATnameLabel.Text = cat.ToString();
            UserNameLabel.Text = username;
            Team1Name.Text = teamOneName;
            Team2Name.Text = teamTwoName;


            /*
DataTable s = RoundsDAL.getMatchesData(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in s.Rows)
            {
                StadiumNameLabel.Text = row["stadium"].ToString();
            }
            DataTable d = RoundsDAL.getMatchesData(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in d.Rows)
            {
                dateLabel.Text = row["matchDate"].ToString();
            }
            MatchIDLabel.Text = Form8.matchId;
            string userId = "";
            DataTable u = TicketDAL.getAllTickets(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in u.Rows)
            {
                FanIDLabel.Text = row["userId"].ToString();
                userId = row["userId"].ToString();
            }
            DataTable c = TicketDAL.getAllTickets(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in c.Rows)
            {
                CATnameLabel.Text = row["Degree"].ToString();
                string x = CATnameLabel.Text;
            }
            DataTable n = signInDAL.getUserById(Convert.ToInt32(userId));
            foreach (DataRow row in n.Rows)
            {
                UserNameLabel.Text = row["username"].ToString();
            }
            string team1Id = "";
            string team2Id = "";
            DataTable ti1 = RoundsDAL.getTeamMatches(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in ti1.Rows)
            {
                team1Id += row["teamOneId"].ToString();
            }
            DataTable ti2 = RoundsDAL.getTeamMatches(Convert.ToInt32(Form8.matchId));
            foreach (DataRow row in ti2.Rows)
            {
                team2Id += row["teamTwoId"].ToString();
            }
            */
            // IAM RUNNINIG OUT OF TIME AND THERE IS UNHANDLED EXCEPTION THROWN HERE I DON'T KNOW WHY AND I AM SURE IT'S SILLY BUT I HAV NO TIME 
            // IAM DOING IT IN A BRAINLESS WAY SORRY
            /* int id1 = Convert.ToInt32(team1Id);
             int id2 = Convert.ToInt32(team2Id);

             DataTable t1 = teamDAL.getTeamName(id1);
             foreach (DataRow row in t1.Rows)
             {
                 Team1Name.Text = row["teamName"].ToString() + System.Environment.NewLine;
             }
             DataTable t2 = teamDAL.getTeamName(id2);
             foreach (DataRow row in t2.Rows)
             {
                 Team2Name.Text = row["teamName"].ToString() + System.Environment.NewLine;
             }
             */
            /*Team1Name.Text = Form8.choosenTeam1;
            Team2Name.Text = Form8.choosenTeam2;*/




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frm10MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.OpenForms[4].Show();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frm10closeBTN_Click(object sender, EventArgs e)
        {
            Application.OpenForms[4].Show();
            this.Hide();
        }
        
    }
}
