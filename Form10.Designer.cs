namespace Final_project
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.frm10MinimizeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.frm10closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FanIDLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatchIDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StadiumNameLabel = new System.Windows.Forms.Label();
            this.CATnameLabel = new System.Windows.Forms.Label();
            this.Team1Name = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.BackBTN = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm10MinimizeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm10closeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.frm10MinimizeBTN);
            this.panel1.Controls.Add(this.frm10closeBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // frm10MinimizeBTN
            // 
            this.frm10MinimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.frm10MinimizeBTN.Image = ((System.Drawing.Image)(resources.GetObject("frm10MinimizeBTN.Image")));
            this.frm10MinimizeBTN.ImageActive = null;
            this.frm10MinimizeBTN.Location = new System.Drawing.Point(737, 3);
            this.frm10MinimizeBTN.Name = "frm10MinimizeBTN";
            this.frm10MinimizeBTN.Size = new System.Drawing.Size(27, 27);
            this.frm10MinimizeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frm10MinimizeBTN.TabIndex = 18;
            this.frm10MinimizeBTN.TabStop = false;
            this.frm10MinimizeBTN.Zoom = 10;
            this.frm10MinimizeBTN.Click += new System.EventHandler(this.frm10MinimizeBTN_Click);
            // 
            // frm10closeBTN
            // 
            this.frm10closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.frm10closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("frm10closeBTN.Image")));
            this.frm10closeBTN.ImageActive = null;
            this.frm10closeBTN.Location = new System.Drawing.Point(769, 3);
            this.frm10closeBTN.Name = "frm10closeBTN";
            this.frm10closeBTN.Size = new System.Drawing.Size(27, 27);
            this.frm10closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frm10closeBTN.TabIndex = 17;
            this.frm10closeBTN.TabStop = false;
            this.frm10closeBTN.Zoom = 10;
            this.frm10closeBTN.Click += new System.EventHandler(this.frm10closeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "TICKET";
            // 
            // TicketImage
            // 
            this.TicketImage.Image = ((System.Drawing.Image)(resources.GetObject("TicketImage.Image")));
            this.TicketImage.Location = new System.Drawing.Point(0, 100);
            this.TicketImage.Name = "TicketImage";
            this.TicketImage.Size = new System.Drawing.Size(800, 414);
            this.TicketImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TicketImage.TabIndex = 1;
            this.TicketImage.TabStop = false;
            this.TicketImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(262, 192);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(0, 17);
            this.UserNameLabel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fan-ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FanIDLabel
            // 
            this.FanIDLabel.AutoSize = true;
            this.FanIDLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FanIDLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanIDLabel.Location = new System.Drawing.Point(399, 192);
            this.FanIDLabel.Name = "FanIDLabel";
            this.FanIDLabel.Size = new System.Drawing.Size(0, 18);
            this.FanIDLabel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Match-ID:";
            // 
            // MatchIDLabel
            // 
            this.MatchIDLabel.AutoSize = true;
            this.MatchIDLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MatchIDLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchIDLabel.Location = new System.Drawing.Point(517, 192);
            this.MatchIDLabel.Name = "MatchIDLabel";
            this.MatchIDLabel.Size = new System.Drawing.Size(0, 18);
            this.MatchIDLabel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stadium:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(560, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "CAT:";
            // 
            // StadiumNameLabel
            // 
            this.StadiumNameLabel.AutoSize = true;
            this.StadiumNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StadiumNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StadiumNameLabel.Location = new System.Drawing.Point(266, 417);
            this.StadiumNameLabel.Name = "StadiumNameLabel";
            this.StadiumNameLabel.Size = new System.Drawing.Size(0, 17);
            this.StadiumNameLabel.TabIndex = 11;
            this.StadiumNameLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // CATnameLabel
            // 
            this.CATnameLabel.AutoSize = true;
            this.CATnameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CATnameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CATnameLabel.Location = new System.Drawing.Point(581, 417);
            this.CATnameLabel.Name = "CATnameLabel";
            this.CATnameLabel.Size = new System.Drawing.Size(0, 17);
            this.CATnameLabel.TabIndex = 13;
            // 
            // Team1Name
            // 
            this.Team1Name.AutoSize = true;
            this.Team1Name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Team1Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Name.Location = new System.Drawing.Point(283, 287);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(0, 34);
            this.Team1Name.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 34);
            this.label15.TabIndex = 15;
            this.label15.Text = "VS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Team2Name
            // 
            this.Team2Name.AutoSize = true;
            this.Team2Name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Team2Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Name.Location = new System.Drawing.Point(486, 287);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(0, 34);
            this.Team2Name.TabIndex = 16;
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackBTN.FlatAppearance.BorderSize = 0;
            this.BackBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBTN.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBTN.ForeColor = System.Drawing.Color.DarkGray;
            this.BackBTN.Location = new System.Drawing.Point(627, 462);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(173, 40);
            this.BackBTN.TabIndex = 27;
            this.BackBTN.Text = "Exit";
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(368, 417);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 17);
            this.dateLabel.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Time:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.Team2Name);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Team1Name);
            this.Controls.Add(this.CATnameLabel);
            this.Controls.Add(this.StadiumNameLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MatchIDLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FanIDLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketImage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Opacity = 0.9D;
            this.Text = "Form10";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form10_FormClosed);
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm10MinimizeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm10closeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox TicketImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FanIDLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MatchIDLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StadiumNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CATnameLabel;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Team1Name;
        private Bunifu.Framework.UI.BunifuImageButton frm10MinimizeBTN;
        private Bunifu.Framework.UI.BunifuImageButton frm10closeBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label3;
    }
}