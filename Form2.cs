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
    public partial class Form2 : Form
    {
        public static string userId = "";
        public static string userName = "";
        int move, moveX, moveY;
        public Form2()
        {
            InitializeComponent();
        }
        public static string username = "", password = "";
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void frm2closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void frm2MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            username = UsernameTextbox.Text;
            password = passwordTextbox.Text;
            string result = "";
            DataTable dt = signInDAL.getUserByNameAndPassword(username, password);
            foreach (DataRow row in dt.Rows)
            {
                result += row["CountryName"].ToString() + "   " + row["NationalId"].ToString() + System.Environment.NewLine;
                userId = row["userId"].ToString();  
            }
            userName = username;
            if (result != "")
            {
                
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Data");
            }
        }

        private void UsernameTextbox_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Text = "";
        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            passwordTextbox.Text = "";
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            passwordTextbox.PasswordChar = '*';
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
