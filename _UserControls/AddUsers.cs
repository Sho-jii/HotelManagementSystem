using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AddUsers : UserControl
    {
        private UsersData uData = new UsersData();
        private int getID = 0;

        public AddUsers()
        {
            InitializeComponent();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            displayAllUsersData();
        }

        public void displayAllUsersData()
        {
            List<UsersData> listdata = uData.AllUsersData();
            userData_dgv.DataSource = listdata;
        }

        public void clearFields()
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            txtStatus.SelectedIndex = -1;
            getID = 0;
        }

        private bool emptyFields()
        {
            return string.IsNullOrWhiteSpace(txtusername.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || txtStatus.SelectedIndex == -1;
        }

        private void addData_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(function.GetConnectionString()))
                {
                    con.Open();

                    string checkUsername = "SELECT COUNT(*) FROM users WHERE username = @usern";
                    using (SqlCommand cmdCheck = new SqlCommand(checkUsername, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show(txtusername.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertData = "INSERT INTO users (username, password, status) VALUES (@usern, @pass, @status)";
                    using (SqlCommand insertD = new SqlCommand(insertData, con))
                    {
                        insertD.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                        insertD.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        insertD.Parameters.AddWithValue("@status", txtStatus.SelectedItem.ToString());

                        insertD.ExecuteNonQuery();
                        clearFields();
                        displayAllUsersData();

                        MessageBox.Show("User added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            if (emptyFields() || getID == 0)
            {
                MessageBox.Show("Please select a user to update and fill all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update user: " + txtusername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(function.GetConnectionString()))
                    {
                        con.Open();
                        string updateData = "UPDATE users SET username = @usern, password = @pass, status = @status WHERE id = @id";

                        using (SqlCommand updateD = new SqlCommand(updateData, con))
                        {
                            updateD.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                            updateD.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                            updateD.Parameters.AddWithValue("@status", txtStatus.SelectedItem.ToString());
                            updateD.Parameters.AddWithValue("@id", getID);

                            updateD.ExecuteNonQuery();
                            clearFields();
                            displayAllUsersData();

                            MessageBox.Show("User updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeData_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a user to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove user: " + txtusername.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(function.GetConnectionString()))
                    {
                        con.Open();
                        string deleteData = "DELETE FROM users WHERE id = @id";

                        using (SqlCommand deleteD = new SqlCommand(deleteData, con))
                        {
                            deleteD.Parameters.AddWithValue("@id", getID);
                            deleteD.ExecuteNonQuery();

                            clearFields();
                            displayAllUsersData();

                            MessageBox.Show("User removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void userData_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < userData_dgv.Rows.Count)
            {
                DataGridViewRow row = userData_dgv.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    getID = id;
                    txtusername.Text = row.Cells[1].Value?.ToString() ?? "";
                    txtPassword.Text = row.Cells[2].Value?.ToString() ?? "";
                    txtStatus.Text = row.Cells[3].Value?.ToString() ?? "";
                }
            }
        }
    }
}
