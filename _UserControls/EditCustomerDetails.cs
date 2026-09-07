using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class EditCustomerDetails : UserControl
    {
        private function fn = new function();
        private int getID = 0;

        public EditCustomerDetails()
        {
            InitializeComponent();
        }

        private void EditCustomerDetails_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            string query = @"
                SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, 
                       customer.gender, customer.dob, customer.idproof, customer.addres, 
                       customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price 
                FROM customer 
                INNER JOIN rooms ON customer.roomid = rooms.roomid";

            DataSet ds = fn.getData(query);
            if (ds.Tables.Count > 0)
            {
                customerCO_dgv.DataSource = ds.Tables[0];
            }
        }

        private void customerCO_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customerCO_dgv.Rows.Count)
            {
                DataGridViewRow row = customerCO_dgv.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int cid))
                {
                    getID = cid;
                    txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                    txtContact.Text = row.Cells[2].Value?.ToString() ?? "";
                    txtNationality.Text = row.Cells[3].Value?.ToString() ?? "";
                    txtGender.Text = row.Cells[4].Value?.ToString() ?? "";
                    txtIDProof.Text = row.Cells[6].Value?.ToString() ?? "";
                    txtAddress.Text = row.Cells[7].Value?.ToString() ?? "";

                    string dateVal = row.Cells[8].Value?.ToString();
                    if (!string.IsNullOrEmpty(dateVal) && DateTime.TryParse(dateVal, out DateTime checkInDate))
                    {
                        txtCheckIn.Value = checkInDate;
                    }
                }
            }
        }

        public void clearFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.SelectedIndex = -1;
            txtGender.SelectedIndex = -1;
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            getID = 0;
        }

        public bool emptyFields()
        {
            return string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtContact.Text)
                || txtNationality.SelectedIndex == -1
                || txtGender.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(txtIDProof.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (emptyFields() || getID == 0)
            {
                MessageBox.Show("Please select a customer and fill all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtContact.Text.Trim(), out long mobile))
            {
                MessageBox.Show("Please enter a valid numeric contact number.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update customer details?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string updateData = @"
                    UPDATE customer 
                    SET cname = @cname, mobile = @mobile, nationality = @nation, 
                        gender = @gender, idproof = @idproof, addres = @address, 
                        checkin = @checkin 
                    WHERE cid = @id";

                var parameters = new Dictionary<string, object>
                {
                    { "@cname", txtName.Text.Trim() },
                    { "@mobile", mobile },
                    { "@nation", txtNationality.SelectedItem?.ToString() ?? txtNationality.Text.Trim() },
                    { "@gender", txtGender.SelectedItem?.ToString() ?? txtGender.Text.Trim() },
                    { "@idproof", txtIDProof.Text.Trim() },
                    { "@address", txtAddress.Text.Trim() },
                    { "@checkin", txtCheckIn.Value.ToString("dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture) },
                    { "@id", getID }
                };

                fn.setData(updateData, "Customer Details Updated Successfully.", parameters);
                clearFields();
                LoadCustomers();
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void EditCustomerDetails_Leave(object sender, EventArgs e)
        {
            clearFields();
        }

        private void EditCustomerDetails_Enter(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
