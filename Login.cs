using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(function.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT status FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usern", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        object result = cmd.ExecuteScalar();
                        string userStatus = result as string;

                        if (!string.IsNullOrEmpty(userStatus) && userStatus.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or account is not active.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            label1.Visible = true;
                            login_password.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = viewPass.Checked ? '\0' : '*';
        }

        private void login_username_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void movePanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
