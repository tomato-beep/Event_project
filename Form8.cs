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
    public partial class Form8 : Form
    {
        public static int CAT = 0, Round = 0;
        public static string matchId = "";
        public static string choosenTeam1 = "";
        public static string choosenTeam2 = "";
        int move, moveX, moveY;
        private object RoundDAL;

        

        public Form8() 
        {
            InitializeComponent();
        }

        public Form8(string ImageName) 
        {
            InitializeComponent();
            Form4.TeamCode = getTeamIdFromTeamName(ImageName);
        }

        public static int getTeamIdFromTeamName(string teamName)
        {
            DataTable z = teamDAL.getTeamId(teamName);
            int teamId = 0;
            foreach (DataRow row in z.Rows)
                teamId = Convert.ToInt32(row["teamId"]);
            return teamId;

        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm8closeBTN_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Hide();
        }

        private void frm8minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            #region trash1
            /*DataTable dt = RoundsDAL.getTeamMatches(Form4.TeamCode);
            string team1 = "";
            string team2 = "";
            string stadium = "";
            string date = "";
            string result = "";
            foreach (DataRow row in dt.Rows)
            {
                 result += row["matchId"].ToString()+" " + row["teamOneId"].ToString() + " " + row["teamTwoId"].ToString() + " " + row["stadium"].ToString() + " " + row["matchDate"].ToString() + System.Environment.NewLine;
                team1 = row["teamOneId"].ToString();
                team2 = row["teamTwoId"].ToString();
                stadium = row["stadium"].ToString();
                date = row["matchDate"].ToString();
            }
            MessageBox.Show(result);    
            string team1Name = "";
            string team2Name = "";
            DataTable d1 = teamDAL.getTeamName(Convert.ToInt32(team1));
            foreach (DataRow row in dt.Rows)
            {
                team1Name = row["teamName"].ToString();
            }
            DataTable d2 = teamDAL.getTeamName(Convert.ToInt32(team2));
            foreach (DataRow row in dt.Rows)
            {
                team2Name = row["teamName"].ToString();
            }
            Round1Team1Name.Text = team1Name;
            Round1Team2Label.Text = team2Name;*/
            #endregion
            #region Trash2
            /*
            DataTable dt = RoundsDAL.getTeamMatches(Form4.TeamCode);
            List<int> team1 = new List<int>();
            List<int> team2 = new List<int>();
            List<string> staduim = new List<string>();
            List<string> date = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                team1.Add(Convert.ToInt32(row["teamOneId"]));
                team2.Add(Convert.ToInt32(row["teamTwoId"]));
                staduim.Add(row["stadium"].ToString());
                date.Add(row["matchDate"].ToString());
            }
            foreach (string m in team1)
            {

            }
                List<string> team1Name = new List<string>();
            List<string> team2Name = new List<string>();

            foreach (int s in team1)
            {
                DataTable d1 = teamDAL.getTeamName(s);
                foreach (DataRow row in dt.Rows)
                {
                    team1Name.Add(row["teamName"].ToString());
                }
                DataTable d2 = teamDAL.getTeamName(s);
                foreach (DataRow row in dt.Rows)
                {
                    team2Name.Add(row["teamName"].ToString());
                }
            }
            Round1Team1Name.Text = team1Name[0];
            Round1Team2Label.Text = team2Name[0];

            Round1DateLabel.Text = date[0];
            Round1StadiumLabel.Text = staduim[0];

            Round2Team1Label.Text = team1Name[1];
            Round2Team2Label.Text = team2Name[1];

            Round2DateLabel.Text = date[1];
            Round2stadiumLabel.Text = staduim[1];

            Round3Team1Label.Text = team1Name[2];
            Round3Team2Label.Text = team2Name[2];

            Round3DateLabel.Text = date[2];
            Round3StadiumLabel.Text = staduim[2];
            */
            #endregion
            #region Trash3


            //string teamLbl = "team";
            //string team2Lbl = "team";
            //string stadiumLbl = "stadium";
            //string dateLbl = "date";

            //List<string> lblNames = new List<string>();
            //for(int i = 1; i< 4; i++)
            //{
            //    lblNames.Add(teamLbl + i.ToString());
            //    lblNames.Add(team2Lbl + (i + 1).ToString());
            //    lblNames.Add(stadiumLbl + i.ToString());
            //    lblNames.Add(dateLbl + i.ToString());
            //}

            //int lablesCount = 0;

            //foreach (DataRow row in s.Rows)
            //{
            //    List<string> temp = new List<string>();

            //    temp.Add(Convert.ToString(row["teamOneId"]));
            //    temp.Add(Convert.ToString(row["teamTwoId"]));
            //    temp.Add(Convert.ToString(row["stadium"]));
            //    temp.Add(Convert.ToString(row["MatchDate"]));

            //    for(int i = 0; i< 3; i++)
            //    {
            //        Label lbl = this.Controls.Find(lblNames[lablesCount++], true).FirstOrDefault() as Label;
            //        lbl.Text = temp[i];
            //    }

            //    int matchId = Convert.ToInt32(row["matchId"]);

            //}
            #endregion



            int team1id = Form4.TeamCode;
            //for stadium labels
            DataTable s = RoundsDAL.getTeamMatches(team1id);
            string stadiums = "";

            int sCount = 0;
            foreach (DataRow row in s.Rows)
            {
                stadiums += row["stadium"].ToString() + System.Environment.NewLine;
                if (sCount == 0)
                {
                    stadium1.Text = stadiums;
                    stadiums = "";

                }
                if (sCount == 1)
                {
                    stadium2.Text = stadiums;
                    stadiums = "";
                }
                if (sCount == 2)
                {
                    stadium3.Text = stadiums;
                    stadiums = "";
                }
                sCount++;

            }
            //for date labels
            string dates = "";
            DataTable d = RoundsDAL.getTeamMatches(team1id);
            int dCount = 0;
            foreach (DataRow row in d.Rows)
            {
                dates += row["matchDate"].ToString() + " " + System.Environment.NewLine;
                if (dCount == 0)
                {
                    date1.Text = dates;
                    dates = "";

                }
                if (dCount == 1)
                {
                    date2.Text = dates;
                    dates = "";
                }
                if (dCount == 2)
                {
                    date3.Text = dates;
                    dates = "";
                }
                dCount++;

            }
            // for teams labels but we first get the teams ids then we use the ids to fill the names

            string teamTwoIds = "";
            string teamOneIds = "";
            DataTable t = RoundsDAL.getTeamMatches(team1id);





            int count = 0;
            int team2Id1 = 0, team2Id2 = 0, team2Id3 = 0 , team1Id1=0 , team1Id2=0 , team1Id3=0;


            foreach (DataRow row in t.Rows)
            {
                teamOneIds += row["teamOneId"].ToString() + System.Environment.NewLine;
                teamTwoIds += row["teamTwoId"].ToString() + System.Environment.NewLine;
                if (count == 0)
                {
                    team2Id1 = Convert.ToInt32(teamTwoIds);
                    teamTwoIds = "";
                    team1Id1 = Convert.ToInt32(teamOneIds);
                    teamOneIds = "";
                }
                if (count == 1)
                {
                    team2Id2 = Convert.ToInt32(teamTwoIds);
                    teamTwoIds = "";
                    team1Id2 = Convert.ToInt32(teamOneIds);
                    teamOneIds = "";
                }
                if (count == 2)
                {
                    team2Id3 = Convert.ToInt32(teamTwoIds);
                    teamTwoIds = "";
                    team1Id3 = Convert.ToInt32(teamOneIds);
                    teamOneIds = "";
                }
                count++;

            }
            if (team2Id1 != Form4.TeamCode)
            {
                DataTable t1 = teamDAL.getTeamName(team2Id1);
                foreach (DataRow row in t1.Rows)
                {
                    team2.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            else
            {
                DataTable t1 = teamDAL.getTeamName(team1Id1);
                foreach (DataRow row in t1.Rows)
                {
                    team2.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            if (team2Id1 != Form4.TeamCode)
            {
                DataTable t2 = teamDAL.getTeamName(team2Id2);
                foreach (DataRow row in t2.Rows)
                {
                    team4.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            else
            {
                DataTable t2 = teamDAL.getTeamName(team1Id2);
                foreach (DataRow row in t2.Rows)
                {
                    team4.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            if (team2Id1 != Form4.TeamCode)
            {
                DataTable t3 = teamDAL.getTeamName(team2Id3);
                foreach (DataRow row in t3.Rows)
                {
                    team6.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            else
            {
                DataTable t3 = teamDAL.getTeamName(team1Id3);
                foreach (DataRow row in t3.Rows)
                {
                    team6.Text = row["teamName"].ToString() + System.Environment.NewLine;
                }
            }
            string rep = "";
            DataTable t0 = teamDAL.getTeamName(team1id);
            foreach (DataRow row in t0.Rows)
            {
                rep = row["teamName"].ToString() + System.Environment.NewLine;
            }
            team1.Text = rep;
            team3.Text = rep;
            team5.Text = rep;


            DataTable n = RoundsDAL.getTeamMatches(team1id);
            foreach (DataRow row in n.Rows)
            {
                matchId = row["matchId"].ToString();
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[2].Show();
        }

        private void Round1radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProceedBTN_Click(object sender, EventArgs e)
        {
            if (Round1radioButton.Checked)
            {
                Round = 1;
                choosenTeam1 = team1.Text;
                choosenTeam2 = team2.Text;
            }
            else if (Round2radioButton.Checked)
            {
                Round = 2;
                choosenTeam1 = team1.Text;
                choosenTeam2 = team4.Text;
            }
            else if (Round3radioButton.Checked)
            {
                Round = 3;
                choosenTeam1 = team1.Text;
                choosenTeam2 = team6.Text;
            }
            else
            {
                MessageBox.Show("please select the round");
            }
            if (CAT1radioButton.Checked && Round != 0)
            {
                CAT = 1;
                int rows = TicketDAL.bookTicket(Convert.ToInt32(matchId), Convert.ToInt32(Form2.userId), CAT);
                Form9 frm = new Form9();
                frm.Show();
                this.Hide();
            }
            else if (CAT2radioButton.Checked && Round != 0)
            {
                CAT = 2;
                int rows = TicketDAL.bookTicket(Convert.ToInt32(matchId), Convert.ToInt32(Form2.userId), CAT);
                Form9 frm = new Form9();
                frm.Show();
                this.Hide();
            }
            else if (CAT3radioButton.Checked && Round != 0)
            {
                CAT = 3;
                int rows = TicketDAL.bookTicket(Convert.ToInt32(matchId), Convert.ToInt32(Form2.userId), CAT);
                Form9 frm = new Form9();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please select the category");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
