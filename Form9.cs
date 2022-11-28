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
    public partial class Form9 : Form
    {
        int move, moveX, moveY;
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VisaImage_Click(object sender, EventArgs e)
        {
            VisaImage.BackColor = Color.DimGray;
            MasterCardImage.BackColor = Color.White;
        }

        private void MasterCardImage_Click(object sender, EventArgs e)
        {
            VisaImage.BackColor = Color.White;
            MasterCardImage.BackColor = Color.DimGray;
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[3].Show();
        }

        private void frm9closeBTN_Click(object sender, EventArgs e)
        {
            Application.OpenForms[3].Show();
            this.Close();
        }

        private void frm9minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void ProceedBTN_Click(object sender, EventArgs e)
        {
            int cvvNo = 0;
            int cardNo = 0;

            bool cvvNoFlag = int.TryParse(CardIdTextbox.Text, out cvvNo);
            bool cardNoFlag = int.TryParse(CardIdTextbox.Text, out cardNo);


            try
            {

                if(cvvNo != 0 && cardNo != 0)
                {
                    if (cvvNo >= 100)
                    {
                        if (cardNo >= 1000)
                        {
                            if (MasterCardImage.BackColor == Color.DimGray || VisaImage.BackColor == Color.DimGray)
                            {
                                Form10 frm = new Form10();
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Please select visa or mastercard");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter valid card number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid cvv");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void CardIdTextbox_Click(object sender, EventArgs e)
        {
            CardIdTextbox.Text = "";
        }

        private void CVVTextbox_Click(object sender, EventArgs e)
        {
            CVVTextbox.Text = "";
        }

        private void Form9_Load(object sender, EventArgs e)
        {

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
    }
}
