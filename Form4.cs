using Bunifu.Framework.UI;
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
    public partial class Form4 : Form
    {
        public static int TeamCode = 0;
        int move, moveX, moveY;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        //TeamId --> Form 8
        //TeamName --> Form8
        //Form 8 --> 

        public static string getTeamNameFromImgControl(string imgControlName)
        {
            string teamName = "";
            for (int i = 0; i < imgControlName.Length; i++)
            {
                if (imgControlName[i] != 'I')
                {

                    teamName += imgControlName[i];
                }
                else
                {
                    if (i != 0)
                        break;
                }
            }
            return teamName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frm4closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm4MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }

        private void openForm8(object sender)
        {
            BunifuImageButton x = (BunifuImageButton)sender;
            string ImageName = getTeamNameFromImgControl(x.Name);


            Form8 frm = new Form8(ImageName);
            frm.Show();
            this.Hide();
        }

        private void ArsenalImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);

            /*
            TeamCode = 1;
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();*/
        }

        private void leiceterImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 8;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void southamptonImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 12;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void NorowichImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 9;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void AstonVillaImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 13;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void LiverpoolImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 7;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void TottenhamImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 16;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void WatfordImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 11;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void ChelseaImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 5;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void CityImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 10;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void WesthamImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 19;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void BrentfordImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 3;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void EvertonImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 18;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void UnitedImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 15;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void CrystalPalaceImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 2;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void WolvesImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 14;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void LeedsImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 17;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void NewcastleImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 20;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void BrightonImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 6;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void BurnleyImageBTN_Click(object sender, EventArgs e)
        {
            openForm8(sender);
            //TeamCode = 4;
            //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();
        }

        private void MyTicketsBTN_Click(object sender, EventArgs e)
        {
            string result = "";

            DataTable dt = TicketDAL.getTicketByUser(Convert.ToInt32(Form2.userId));
            foreach (DataRow row in dt.Rows)
            {
                result += row["ticketId"].ToString() + System.Environment.NewLine;
            }
            if (result != "")
            {
                Form10 frm = new Form10();
                frm.Show();
                this.Hide();
            }
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
    }
}
