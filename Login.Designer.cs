namespace HotelManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.viewPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.login_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.movePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Login_exit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.movePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.viewPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.login_btn);
            this.guna2CustomGradientPanel1.Controls.Add(this.login_password);
            this.guna2CustomGradientPanel1.Controls.Add(this.login_username);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(80, 90);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(673, 351);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // viewPass
            // 
            this.viewPass.BackColor = System.Drawing.Color.Transparent;
            this.viewPass.CheckedState.Image = global::HotelManagementSystem.Properties.Resources.view;
            this.viewPass.Image = global::HotelManagementSystem.Properties.Resources.eye;
            this.viewPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.viewPass.ImageRotate = 0F;
            this.viewPass.Location = new System.Drawing.Point(590, 183);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(24, 24);
            this.viewPass.TabIndex = 7;
            this.viewPass.CheckedChanged += new System.EventHandler(this.viewPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(361, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Login";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wrong Username or Password";
            this.label1.Visible = false;
            // 
            // login_btn
            // 
            this.login_btn.Animated = true;
            this.login_btn.AutoRoundedCorners = true;
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderRadius = 28;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.login_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.login_btn.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.IndicateFocus = true;
            this.login_btn.Location = new System.Drawing.Point(341, 237);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(189, 59);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseTransparentBackground = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_password
            // 
            this.login_password.Animated = true;
            this.login_password.AutoRoundedCorners = true;
            this.login_password.BackColor = System.Drawing.Color.Transparent;
            this.login_password.BorderRadius = 26;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.DefaultText = "";
            this.login_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.Black;
            this.login_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.IconLeft = global::HotelManagementSystem.Properties.Resources.lock_25px;
            this.login_password.Location = new System.Drawing.Point(296, 165);
            this.login_password.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.PlaceholderText = "Password";
            this.login_password.SelectedText = "";
            this.login_password.Size = new System.Drawing.Size(286, 55);
            this.login_password.TabIndex = 3;
            // 
            // login_username
            // 
            this.login_username.Animated = true;
            this.login_username.AutoRoundedCorners = true;
            this.login_username.BackColor = System.Drawing.Color.Transparent;
            this.login_username.BorderRadius = 26;
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.DefaultText = "";
            this.login_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.Color.Black;
            this.login_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username.IconLeft = global::HotelManagementSystem.Properties.Resources.user_25px;
            this.login_username.Location = new System.Drawing.Point(296, 98);
            this.login_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.PlaceholderText = "Username";
            this.login_username.SelectedText = "";
            this.login_username.Size = new System.Drawing.Size(286, 55);
            this.login_username.TabIndex = 2;
            this.login_username.MouseEnter += new System.EventHandler(this.login_username_MouseEnter);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::HotelManagementSystem.Properties.Resources.Hotel_Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(262, 262);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // movePanel
            // 
            this.movePanel.Controls.Add(this.Login_exit);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.movePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.movePanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(839, 45);
            this.movePanel.TabIndex = 2;
            this.movePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.movePanel_Paint);
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            // 
            // Login_exit
            // 
            this.Login_exit.BackColor = System.Drawing.Color.Transparent;
            this.Login_exit.BorderColor = System.Drawing.Color.Transparent;
            this.Login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.Login_exit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.Login_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_exit.ForeColor = System.Drawing.Color.White;
            this.Login_exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.Login_exit.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.Login_exit.Location = new System.Drawing.Point(794, 1);
            this.Login_exit.Name = "Login_exit";
            this.Login_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Login_exit.Size = new System.Drawing.Size(40, 41);
            this.Login_exit.TabIndex = 2;
            this.Login_exit.Text = "X";
            this.Login_exit.Click += new System.EventHandler(this.Login_exit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.ColorB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 484);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.movePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Login_exit;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel movePanel;
        private Guna.UI2.WinForms.Guna2TextBox login_username;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private Guna.UI2.WinForms.Guna2GradientTileButton login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox viewPass;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}

