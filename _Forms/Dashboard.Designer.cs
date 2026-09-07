namespace HotelManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.customerDet = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.checkout = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.customerReg = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.addRooms = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.addUsers = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.PanelUp = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.exit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.back = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewCustomerDetails1 = new HotelManagementSystem.ViewCustomerDetails();
            this.customerCheckout1 = new HotelManagementSystem.CustomerCheckout();
            this.addUsers1 = new HotelManagementSystem.AddUsers();
            this.customerRegistration1 = new HotelManagementSystem.CustomerRegistration();
            this.addRooms1 = new HotelManagementSystem.AddRooms();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.PanelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 33;
            this.guna2CustomGradientPanel1.Controls.Add(this.customerDet);
            this.guna2CustomGradientPanel1.Controls.Add(this.checkout);
            this.guna2CustomGradientPanel1.Controls.Add(this.customerReg);
            this.guna2CustomGradientPanel1.Controls.Add(this.addRooms);
            this.guna2CustomGradientPanel1.Controls.Add(this.addUsers);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(9, 18);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(937, 106);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // customerDet
            // 
            this.customerDet.Animated = true;
            this.customerDet.AutoRoundedCorners = true;
            this.customerDet.BackColor = System.Drawing.Color.Transparent;
            this.customerDet.BorderRadius = 33;
            this.customerDet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerDet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerDet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerDet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerDet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerDet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerDet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerDet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.customerDet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerDet.FocusedColor = System.Drawing.Color.White;
            this.customerDet.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.customerDet.ForeColor = System.Drawing.Color.White;
            this.customerDet.HoverState.BorderColor = System.Drawing.Color.White;
            this.customerDet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerDet.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.customerDet.Image = global::HotelManagementSystem.Properties.Resources.customer_Details;
            this.customerDet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerDet.ImageOffset = new System.Drawing.Point(0, 10);
            this.customerDet.IndicateFocus = true;
            this.customerDet.Location = new System.Drawing.Point(589, 21);
            this.customerDet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerDet.Name = "customerDet";
            this.customerDet.Size = new System.Drawing.Size(162, 69);
            this.customerDet.TabIndex = 8;
            this.customerDet.Text = "Customer Details";
            this.customerDet.TextOffset = new System.Drawing.Point(0, -10);
            this.customerDet.UseTransparentBackground = true;
            this.customerDet.Click += new System.EventHandler(this.customerDet_Click);
            // 
            // checkout
            // 
            this.checkout.Animated = true;
            this.checkout.AutoRoundedCorners = true;
            this.checkout.BackColor = System.Drawing.Color.Transparent;
            this.checkout.BorderRadius = 33;
            this.checkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.checkout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.checkout.FocusedColor = System.Drawing.Color.White;
            this.checkout.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.checkout.ForeColor = System.Drawing.Color.White;
            this.checkout.HoverState.BorderColor = System.Drawing.Color.White;
            this.checkout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.checkout.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkout.Image = global::HotelManagementSystem.Properties.Resources.Check_out_50px;
            this.checkout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.checkout.ImageOffset = new System.Drawing.Point(0, 10);
            this.checkout.IndicateFocus = true;
            this.checkout.Location = new System.Drawing.Point(398, 21);
            this.checkout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(186, 69);
            this.checkout.TabIndex = 7;
            this.checkout.Text = "Checkout";
            this.checkout.TextOffset = new System.Drawing.Point(0, -15);
            this.checkout.UseTransparentBackground = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // customerReg
            // 
            this.customerReg.Animated = true;
            this.customerReg.AutoRoundedCorners = true;
            this.customerReg.BackColor = System.Drawing.Color.Transparent;
            this.customerReg.BorderRadius = 33;
            this.customerReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerReg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.customerReg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerReg.FocusedColor = System.Drawing.Color.White;
            this.customerReg.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.customerReg.ForeColor = System.Drawing.Color.White;
            this.customerReg.HoverState.BorderColor = System.Drawing.Color.White;
            this.customerReg.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerReg.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.customerReg.Image = global::HotelManagementSystem.Properties.Resources.customer_registration;
            this.customerReg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerReg.ImageOffset = new System.Drawing.Point(0, 10);
            this.customerReg.IndicateFocus = true;
            this.customerReg.Location = new System.Drawing.Point(191, 21);
            this.customerReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerReg.Name = "customerReg";
            this.customerReg.Size = new System.Drawing.Size(202, 69);
            this.customerReg.TabIndex = 6;
            this.customerReg.Text = "Customer Registration";
            this.customerReg.TextOffset = new System.Drawing.Point(0, -10);
            this.customerReg.UseTransparentBackground = true;
            this.customerReg.Click += new System.EventHandler(this.customerReg_Click);
            // 
            // addRooms
            // 
            this.addRooms.Animated = true;
            this.addRooms.AutoRoundedCorners = true;
            this.addRooms.BackColor = System.Drawing.Color.Transparent;
            this.addRooms.BorderRadius = 33;
            this.addRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRooms.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.addRooms.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addRooms.FocusedColor = System.Drawing.Color.White;
            this.addRooms.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.addRooms.ForeColor = System.Drawing.Color.White;
            this.addRooms.HoverState.BorderColor = System.Drawing.Color.White;
            this.addRooms.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addRooms.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.addRooms.Image = global::HotelManagementSystem.Properties.Resources.add_room;
            this.addRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addRooms.ImageOffset = new System.Drawing.Point(0, 10);
            this.addRooms.IndicateFocus = true;
            this.addRooms.Location = new System.Drawing.Point(10, 21);
            this.addRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRooms.Name = "addRooms";
            this.addRooms.Size = new System.Drawing.Size(177, 69);
            this.addRooms.TabIndex = 5;
            this.addRooms.Text = "Add Rooms";
            this.addRooms.TextOffset = new System.Drawing.Point(0, -15);
            this.addRooms.UseTransparentBackground = true;
            this.addRooms.Click += new System.EventHandler(this.addRooms_Click);
            this.addRooms.Enter += new System.EventHandler(this.addRooms_Enter);
            // 
            // addUsers
            // 
            this.addUsers.Animated = true;
            this.addUsers.AutoRoundedCorners = true;
            this.addUsers.BackColor = System.Drawing.Color.Transparent;
            this.addUsers.BorderRadius = 33;
            this.addUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUsers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.addUsers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addUsers.FocusedColor = System.Drawing.Color.White;
            this.addUsers.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold);
            this.addUsers.ForeColor = System.Drawing.Color.White;
            this.addUsers.HoverState.BorderColor = System.Drawing.Color.White;
            this.addUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addUsers.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.addUsers.Image = global::HotelManagementSystem.Properties.Resources.employee_50px;
            this.addUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUsers.ImageOffset = new System.Drawing.Point(0, 10);
            this.addUsers.IndicateFocus = true;
            this.addUsers.Location = new System.Drawing.Point(755, 21);
            this.addUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(169, 69);
            this.addUsers.TabIndex = 9;
            this.addUsers.Text = "Add Users";
            this.addUsers.TextOffset = new System.Drawing.Point(0, -15);
            this.addUsers.UseTransparentBackground = true;
            this.addUsers.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // PanelUp
            // 
            this.PanelUp.Controls.Add(this.viewCustomerDetails1);
            this.PanelUp.Controls.Add(this.customerCheckout1);
            this.PanelUp.Controls.Add(this.addUsers1);
            this.PanelUp.Controls.Add(this.customerRegistration1);
            this.PanelUp.Controls.Add(this.addRooms1);
            this.PanelUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.PanelUp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.PanelUp.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.PanelUp.Location = new System.Drawing.Point(9, 128);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(973, 410);
            this.PanelUp.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Animated = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BorderColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.exit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.exit.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.exit.Image = global::HotelManagementSystem.Properties.Resources.cancel_50px;
            this.exit.Location = new System.Drawing.Point(958, 10);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit.Size = new System.Drawing.Size(30, 33);
            this.exit.TabIndex = 3;
            this.exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Animated = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BorderColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.back.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(27)))), ((int)(((byte)(254)))));
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.back.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.back.Image = global::HotelManagementSystem.Properties.Resources.back_button;
            this.back.Location = new System.Drawing.Point(958, 48);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.back.Size = new System.Drawing.Size(30, 33);
            this.back.TabIndex = 4;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.PanelUp;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // viewCustomerDetails1
            // 
            this.viewCustomerDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.viewCustomerDetails1.Location = new System.Drawing.Point(44, 2);
            this.viewCustomerDetails1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewCustomerDetails1.Name = "viewCustomerDetails1";
            this.viewCustomerDetails1.Size = new System.Drawing.Size(889, 410);
            this.viewCustomerDetails1.TabIndex = 12;
            // 
            // customerCheckout1
            // 
            this.customerCheckout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerCheckout1.Location = new System.Drawing.Point(44, 2);
            this.customerCheckout1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerCheckout1.Name = "customerCheckout1";
            this.customerCheckout1.Size = new System.Drawing.Size(889, 410);
            this.customerCheckout1.TabIndex = 11;
            // 
            // addUsers1
            // 
            this.addUsers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addUsers1.Location = new System.Drawing.Point(44, 2);
            this.addUsers1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUsers1.Name = "addUsers1";
            this.addUsers1.Size = new System.Drawing.Size(889, 410);
            this.addUsers1.TabIndex = 10;
            // 
            // customerRegistration1
            // 
            this.customerRegistration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.customerRegistration1.Location = new System.Drawing.Point(44, 2);
            this.customerRegistration1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerRegistration1.Name = "customerRegistration1";
            this.customerRegistration1.Size = new System.Drawing.Size(889, 410);
            this.customerRegistration1.TabIndex = 1;
            // 
            // addRooms1
            // 
            this.addRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.addRooms1.Location = new System.Drawing.Point(44, 2);
            this.addRooms1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRooms1.Name = "addRooms1";
            this.addRooms1.Size = new System.Drawing.Size(889, 410);
            this.addRooms1.TabIndex = 0;
            this.addRooms1.Visible = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.addUsers1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(148)))), ((int)(((byte)(245)))));
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.ColorB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 549);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.PanelUp);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Enter += new System.EventHandler(this.Dashboard_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.PanelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelUp;
        private Guna.UI2.WinForms.Guna2GradientCircleButton exit;
        private Guna.UI2.WinForms.Guna2GradientCircleButton back;
        private Guna.UI2.WinForms.Guna2GradientTileButton addRooms;
        private Guna.UI2.WinForms.Guna2GradientTileButton addUsers;
        private Guna.UI2.WinForms.Guna2GradientTileButton customerDet;
        private Guna.UI2.WinForms.Guna2GradientTileButton checkout;
        private Guna.UI2.WinForms.Guna2GradientTileButton customerReg;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AddRooms addRooms1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private CustomerRegistration customerRegistration1;
        private AddUsers addUsers1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private CustomerCheckout customerCheckout1;
        private ViewCustomerDetails viewCustomerDetails1;
    }
}