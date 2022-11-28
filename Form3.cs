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
    public partial class Form3 : Form
    {
        
        int move, moveX, moveY;
        public Form3()
        {
            InitializeComponent();
        }
        private void frm3closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }
        private void frm3MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User NewUser = new User(UserNameTextbox.Text, EmailTextbox.Text, PasswordTextbox.Text, CountryTextbox.Text, NationalIdTextbox.Text);
            if (NewUser.UserPassword.Length >= 8 && NewUser.UserPassword == CPasswordTextbox.Text && NewUser.userName != "" && NewUser.UserEmail != "" && NewUser.UserCountry != "" && NewUser.UserNationalID != "")
            {
                int rows = registerDAL.addUser(NewUser.userName, NewUser.UserPassword, NewUser.UserCountry, NewUser.UserNationalID, NewUser.UserEmail);           
                //Application.OpenForms[0].Show();
                this.Close();

            }

            else
            {
                MessageBox.Show("Enter Valid data");
            }
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

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
        }

        private void CPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            CPasswordTextbox.PasswordChar = '*';
        }

        private void CPasswordTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            CPasswordTextbox.Text = "";
        }
        private void UserName_MouseClick(object sender, MouseEventArgs e)
        {
            UserNameTextbox.Text = "";
        }

        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            EmailTextbox.Text = "";
        }

        private void PasswordTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordTextbox.Text = "";
        }

        private void CountryTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            CountryTextbox.Text = "";
        }

        private void NationalIdTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            NationalIdTextbox.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.OpenForms[0].Show();
        }
    }
}
