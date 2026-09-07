using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class AddRooms : UserControl
    {
        private function fn = new function();
        private int getID = 0;

        public AddRooms()
        {
            InitializeComponent();
        }

        private void AddRooms_Load(object sender, EventArgs e)
        {
            string query = "SELECT roomid, roomNo, roomType, bed, price, booked FROM rooms";
            DataSet ds = fn.getData(query);
            if (ds.Tables.Count > 0)
            {
                AddRoomsData.DataSource = ds.Tables[0];
            }
        }

        public void clearFields()
        {
            txtroomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
            getID = 0;
        }

        public bool emptyFields()
        {
            return string.IsNullOrWhiteSpace(txtroomNo.Text)
                || txtType.SelectedIndex == -1
                || txtBed.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(txtPrice.Text);
        }

        private void addRoombtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtPrice.Text.Trim(), out long price))
            {
                MessageBox.Show("Please enter a valid numeric price.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM rooms WHERE roomNo = @roomNo";
            var checkParams = new Dictionary<string, object> { { "@roomNo", txtroomNo.Text.Trim() } };
            DataSet checkDs = fn.getData(checkQuery, checkParams);
            if (checkDs.Tables.Count > 0 && Convert.ToInt32(checkDs.Tables[0].Rows[0][0]) > 0)
            {
                MessageBox.Show("Room number already exists. Please choose a unique room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = "INSERT INTO rooms (roomNo, roomType, bed, price, booked) VALUES (@roomNo, @roomType, @bed, @price, 'NO')";
            var parameters = new Dictionary<string, object>
            {
                { "@roomNo", txtroomNo.Text.Trim() },
                { "@roomType", txtType.SelectedItem?.ToString() ?? txtType.Text.Trim() },
                { "@bed", txtBed.SelectedItem?.ToString() ?? txtBed.Text.Trim() },
                { "@price", price }
            };

            fn.setData(insertQuery, "Room Added Successfully.", parameters);
            AddRooms_Load(this, null);
            clearFields();
        }

        private void AddRoomsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AddRoomsData.Rows.Count)
            {
                DataGridViewRow row = AddRoomsData.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    getID = id;
                    txtroomNo.Text = row.Cells[1].Value?.ToString() ?? "";
                    txtType.Text = row.Cells[2].Value?.ToString() ?? "";
                    txtBed.Text = row.Cells[3].Value?.ToString() ?? "";
                    txtPrice.Text = row.Cells[4].Value?.ToString() ?? "";
                }
            }
        }

        private void updateRooms_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (getID == 0)
            {
                MessageBox.Show("Please select a room from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtPrice.Text.Trim(), out long price))
            {
                MessageBox.Show("Please enter a valid numeric price.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this room?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string updateRooms = "UPDATE rooms SET roomNo = @RoomNo, roomType = @RoomType, bed = @bed, price = @price WHERE roomid = @id";
                var parameters = new Dictionary<string, object>
                {
                    { "@RoomNo", txtroomNo.Text.Trim() },
                    { "@RoomType", txtType.SelectedItem?.ToString() ?? txtType.Text.Trim() },
                    { "@bed", txtBed.SelectedItem?.ToString() ?? txtBed.Text.Trim() },
                    { "@price", price },
                    { "@id", getID }
                };

                fn.setData(updateRooms, "Room Updated Successfully.", parameters);
                clearFields();
                AddRooms_Load(this, null);
            }
        }

        private void deleteRooms_Click(object sender, EventArgs e)
        {
            if (getID == 0 && string.IsNullOrWhiteSpace(txtroomNo.Text))
            {
                MessageBox.Show("Please select a room to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete Room: " + txtroomNo.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deleteRooms = "DELETE FROM rooms WHERE roomid = @id";
                var parameters = new Dictionary<string, object> { { "@id", getID } };

                try
                {
                    fn.setData(deleteRooms, "Room Deleted Successfully.", parameters);
                    clearFields();
                    AddRooms_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete room with active customer reservations: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddRooms_Leave(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddRooms_Enter(object sender, EventArgs e)
        {
            AddRooms_Load(this, null);
        }
    }
}
