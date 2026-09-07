using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CustomerRegistration : UserControl
    {
        private function fn = new function();
        private int rid = 0;

        public CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(string query, ComboBox combo, Dictionary<string, object> parameters = null)
        {
            combo.Items.Clear();
            using (SqlDataReader sdr = fn.getForCombo(query, parameters))
            {
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        combo.Items.Add(sdr.GetString(i));
                    }
                }
            }
        }

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtRoomNo.SelectedItem == null) return;

            string query = "SELECT price, roomid FROM rooms WHERE roomNo = @roomNo";
            var parameters = new Dictionary<string, object> { { "@roomNo", txtRoomNo.SelectedItem.ToString() } };
            DataSet ds = fn.getData(query, parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
                rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            }
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            rid = 0;

            if (txtBed.SelectedItem == null || txtRoomType.SelectedItem == null) return;

            string query = "SELECT roomNo FROM rooms WHERE bed = @bed AND roomType = @roomType AND booked = 'NO'";
            var parameters = new Dictionary<string, object>
            {
                { "@bed", txtBed.SelectedItem.ToString() },
                { "@roomType", txtRoomType.SelectedItem.ToString() }
            };
            setComboBox(query, txtRoomNo, parameters);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            rid = 0;
        }

        private bool ValidateRegistrationInputs()
        {
            return !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtContact.Text)
                && txtNationality.SelectedIndex != -1
                && txtGender.SelectedIndex != -1
                && !string.IsNullOrWhiteSpace(txtIDProof.Text)
                && !string.IsNullOrWhiteSpace(txtAddress.Text)
                && !string.IsNullOrWhiteSpace(txtCheckIn.Text)
                && txtRoomNo.SelectedIndex != -1
                && rid > 0;
        }

        private void alloteRoombtn_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInputs())
            {
                MessageBox.Show("All fields are mandatory. Please make sure all details and an available room are selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtContact.Text.Trim(), out long mobile))
            {
                MessageBox.Show("Please enter a valid numeric mobile contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();
            string national = txtNationality.SelectedItem?.ToString() ?? txtNationality.Text.Trim();
            string gender = txtGender.SelectedItem?.ToString() ?? txtGender.Text.Trim();
            string dob = txtDob.Text.Trim();
            string idproof = txtIDProof.Text.Trim();
            string address = txtAddress.Text.Trim();
            string checkin = txtCheckIn.Text.Trim();
            string roomNo = txtRoomNo.SelectedItem.ToString();

            string insertQuery = @"
                INSERT INTO customer (cname, mobile, nationality, gender, dob, idproof, addres, checkin, chekout, roomid) 
                VALUES (@name, @mobile, @national, @gender, @dob, @idproof, @address, @checkin, 'NO', @rid);
                UPDATE rooms SET booked = 'YES' WHERE roomNo = @roomNo;";

            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@mobile", mobile },
                { "@national", national },
                { "@gender", gender },
                { "@dob", dob },
                { "@idproof", idproof },
                { "@address", address },
                { "@checkin", checkin },
                { "@rid", rid },
                { "@roomNo", roomNo }
            };

            fn.setData(insertQuery, $"Room No. {roomNo} Allocation Successful.", parameters);
            clearFields();
        }

        public void clearFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.SelectedIndex = -1;
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            rid = 0;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearFields();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
        }
    }
}
