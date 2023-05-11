namespace Presentation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnOut = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 770);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::GUI.Properties.Resources.bieu_tuong_sinh_vien_nganh_duoc;
            this.pictureBox1.Location = new System.Drawing.Point(67, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý \r\nHiệu Thuốc";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1304, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(781, 441);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(344, 50);
            this.txtPassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(831, 93);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(153, 145);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Panel1.Location = new System.Drawing.Point(559, 151);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(10, 500);
            this.guna2Panel1.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(781, 320);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(344, 50);
            this.txtUserName.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(622, 597);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 67);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOut
            // 
            this.btnOut.BorderRadius = 19;
            this.btnOut.BorderThickness = 1;
            this.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnOut.HoverState.FillColor = System.Drawing.Color.White;
            this.btnOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(898, 597);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(180, 67);
            this.btnOut.TabIndex = 15;
            this.btnOut.Text = "Thoát";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnOut;
    }
}