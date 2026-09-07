using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CustomerCheckout : UserControl
    {
        private function fn = new function();
        private int id = 0;

        public CustomerCheckout()
        {
            InitializeComponent();
        }

        private void CustomerCheckout_Load(object sender, EventArgs e)
        {
            LoadActiveCheckouts();
            editCustomerDetails1.Visible = false;
        }

        private void LoadActiveCheckouts(string searchName = "")
        {
            string query = @"
                SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, 
                       customer.gender, customer.dob, customer.idproof, customer.addres, 
                       customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price 
                FROM customer 
                INNER JOIN rooms ON customer.roomid = rooms.roomid 
                WHERE (customer.chekout = 'NO' OR customer.chekout IS NULL)";

            Dictionary<string, object> parameters = null;

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                query += " AND customer.cname LIKE @searchName";
                parameters = new Dictionary<string, object> { { "@searchName", searchName + "%" } };
            }

            DataSet ds = fn.getData(query, parameters);
            if (ds.Tables.Count > 0)
            {
                customerCO_dgv.DataSource = ds.Tables[0];
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            LoadActiveCheckouts(txtName.Text.Trim());
        }

        private void customerCO_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customerCO_dgv.Rows.Count)
            {
                DataGridViewRow row = customerCO_dgv.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int cid))
                {
                    id = cid;
                    txtCName.Text = row.Cells[1].Value?.ToString() ?? "";
                    txtRoom.Text = row.Cells[9].Value?.ToString() ?? "";
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (id == 0 || string.IsNullOrWhiteSpace(txtCName.Text))
            {
                MessageBox.Show("Please select a customer from the table to check out.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to check out " + txtCName.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string cdate = txtCheckOutDate.Text;
                string roomNo = txtRoom.Text.Trim();

                string query = @"
                    UPDATE customer SET chekout = 'YES', checkout = @cdate WHERE cid = @cid;
                    UPDATE rooms SET booked = 'NO' WHERE roomNo = @roomNo;";

                var parameters = new Dictionary<string, object>
                {
                    { "@cdate", cdate },
                    { "@cid", id },
                    { "@roomNo", roomNo }
                };

                fn.setData(query, "Checked Out Successfully.", parameters);
                LoadActiveCheckouts();
                clearFields();
            }
        }

        public void clearFields()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
            id = 0;
        }

        private void CustomerCheckout_Leave(object sender, EventArgs e)
        {
            clearFields();
            editCustomerDetails1.Visible = false;
        }

        private void CustomerCheckout_Enter(object sender, EventArgs e)
        {
            CustomerCheckout_Load(this, null);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            editCustomerDetails1.Visible = true;
            editCustomerDetails1.BringToFront();
        }
    }
}
