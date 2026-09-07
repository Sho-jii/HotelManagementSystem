using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            }
        }

        private void addRooms_Click(object sender, EventArgs e)
        {  
            addRooms1.Visible = true;
            addRooms1.BringToFront();
            addRooms1.Refresh();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addRooms1.Visible = false;
            customerRegistration1.Visible = false;
            addUsers1.Visible = false;
            customerCheckout1.Visible = false;
            viewCustomerDetails1.Visible = false;
            addRooms.PerformClick();
        }

        private void customerReg_Click(object sender, EventArgs e)
        {
            customerRegistration1.Visible = true;
            customerRegistration1.BringToFront();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            customerCheckout1.Visible = true;
            customerCheckout1.BringToFront();
        }

        private void customerDet_Click(object sender, EventArgs e)
        {
            viewCustomerDetails1.Visible = true;
            viewCustomerDetails1.BringToFront();
        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            addUsers1.Visible = true;
            addUsers1.BringToFront();
        }

        private void Dashboard_Enter(object sender, EventArgs e)
        {
            Dashboard_Load(this, null);
        }

        private void addRooms_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
