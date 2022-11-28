namespace Final_project
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.frm9minimizeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.frm9closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.VisaImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.MasterCardImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.CardIdTextbox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CVVTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProceedBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm9minimizeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm9closeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterCardImage)).BeginInit();
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
            this.panel1.Controls.Add(this.frm9minimizeBTN);
            this.panel1.Controls.Add(this.frm9closeBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // frm9minimizeBTN
            // 
            this.frm9minimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.frm9minimizeBTN.Image = ((System.Drawing.Image)(resources.GetObject("frm9minimizeBTN.Image")));
            this.frm9minimizeBTN.ImageActive = null;
            this.frm9minimizeBTN.Location = new System.Drawing.Point(734, 3);
            this.frm9minimizeBTN.Name = "frm9minimizeBTN";
            this.frm9minimizeBTN.Size = new System.Drawing.Size(27, 27);
            this.frm9minimizeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frm9minimizeBTN.TabIndex = 23;
            this.frm9minimizeBTN.TabStop = false;
            this.frm9minimizeBTN.Zoom = 10;
            this.frm9minimizeBTN.Click += new System.EventHandler(this.frm9minimizeBTN_Click);
            // 
            // frm9closeBTN
            // 
            this.frm9closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.frm9closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("frm9closeBTN.Image")));
            this.frm9closeBTN.ImageActive = null;
            this.frm9closeBTN.Location = new System.Drawing.Point(766, 3);
            this.frm9closeBTN.Name = "frm9closeBTN";
            this.frm9closeBTN.Size = new System.Drawing.Size(27, 27);
            this.frm9closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frm9closeBTN.TabIndex = 22;
            this.frm9closeBTN.TabStop = false;
            this.frm9closeBTN.Zoom = 10;
            this.frm9closeBTN.Click += new System.EventHandler(this.frm9closeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAYMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VisaImage
            // 
            this.VisaImage.BackColor = System.Drawing.Color.White;
            this.VisaImage.Image = ((System.Drawing.Image)(resources.GetObject("VisaImage.Image")));
            this.VisaImage.ImageActive = null;
            this.VisaImage.Location = new System.Drawing.Point(248, 145);
            this.VisaImage.Name = "VisaImage";
            this.VisaImage.Size = new System.Drawing.Size(90, 88);
            this.VisaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisaImage.TabIndex = 1;
            this.VisaImage.TabStop = false;
            this.VisaImage.Zoom = 10;
            this.VisaImage.Click += new System.EventHandler(this.VisaImage_Click);
            // 
            // MasterCardImage
            // 
            this.MasterCardImage.BackColor = System.Drawing.Color.White;
            this.MasterCardImage.Image = ((System.Drawing.Image)(resources.GetObject("MasterCardImage.Image")));
            this.MasterCardImage.ImageActive = null;
            this.MasterCardImage.Location = new System.Drawing.Point(419, 145);
            this.MasterCardImage.Name = "MasterCardImage";
            this.MasterCardImage.Size = new System.Drawing.Size(90, 88);
            this.MasterCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MasterCardImage.TabIndex = 2;
            this.MasterCardImage.TabStop = false;
            this.MasterCardImage.Zoom = 10;
            this.MasterCardImage.Click += new System.EventHandler(this.MasterCardImage_Click);
            // 
            // CardIdTextbox
            // 
            this.CardIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CardIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardIdTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardIdTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.CardIdTextbox.Location = new System.Drawing.Point(232, 282);
            this.CardIdTextbox.Name = "CardIdTextbox";
            this.CardIdTextbox.Size = new System.Drawing.Size(306, 25);
            this.CardIdTextbox.TabIndex = 18;
            this.CardIdTextbox.Text = "CARD-ID";
            this.CardIdTextbox.Click += new System.EventHandler(this.CardIdTextbox_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(232, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 1);
            this.panel6.TabIndex = 17;
            // 
            // CVVTextbox
            // 
            this.CVVTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CVVTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CVVTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.CVVTextbox.Location = new System.Drawing.Point(232, 329);
            this.CVVTextbox.Name = "CVVTextbox";
            this.CVVTextbox.Size = new System.Drawing.Size(306, 25);
            this.CVVTextbox.TabIndex = 20;
            this.CVVTextbox.Text = "CVV";
            this.CVVTextbox.Click += new System.EventHandler(this.CVVTextbox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(232, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 19;
            // 
            // ProceedBTN
            // 
            this.ProceedBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProceedBTN.FlatAppearance.BorderSize = 0;
            this.ProceedBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ProceedBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProceedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedBTN.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedBTN.ForeColor = System.Drawing.Color.DarkGray;
            this.ProceedBTN.Location = new System.Drawing.Point(306, 392);
            this.ProceedBTN.Name = "ProceedBTN";
            this.ProceedBTN.Size = new System.Drawing.Size(163, 40);
            this.ProceedBTN.TabIndex = 21;
            this.ProceedBTN.Text = "PROCEED";
            this.ProceedBTN.UseVisualStyleBackColor = false;
            this.ProceedBTN.Click += new System.EventHandler(this.ProceedBTN_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.ProceedBTN);
            this.Controls.Add(this.CVVTextbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CardIdTextbox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.MasterCardImage);
            this.Controls.Add(this.VisaImage);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm9minimizeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm9closeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton MasterCardImage;
        private Bunifu.Framework.UI.BunifuImageButton VisaImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CVVTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CardIdTextbox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ProceedBTN;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton frm9minimizeBTN;
        private Bunifu.Framework.UI.BunifuImageButton frm9closeBTN;
    }
}