using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ViewCustomerDetails : UserControl
    {
        private function fn = new function();

        public ViewCustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseQuery = @"
                SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, 
                       customer.gender, customer.dob, customer.idproof, customer.addres, 
                       customer.checkin, customer.checkout, rooms.roomNo, rooms.roomType, 
                       rooms.bed, rooms.price 
                FROM customer 
                INNER JOIN rooms ON customer.roomid = rooms.roomid";

            if (txtSearchBy.SelectedIndex == 0) // All Customers
            {
                getRecord(baseQuery);
            }
            else if (txtSearchBy.SelectedIndex == 1) // In Hotel / Currently Staying
            {
                getRecord(baseQuery + " WHERE (customer.chekout = 'NO' OR customer.checkout IS NULL)");
            }
            else if (txtSearchBy.SelectedIndex == 2) // Checked Out
            {
                getRecord(baseQuery + " WHERE (customer.chekout = 'YES' OR customer.checkout IS NOT NULL)");
            }
        }

        private void getRecord(string query)
        {
            DataSet ds = fn.getData(query);
            if (ds.Tables.Count > 0)
            {
                customerDetails_dgv.DataSource = ds.Tables[0];
            }
        }

        private void ViewCustomerDetails_Leave(object sender, EventArgs e)
        {
            txtSearchBy.SelectedIndex = -1;
        }

        private void ViewCustomerDetails_Load(object sender, EventArgs e)
        {
            txtSearchBy.SelectedIndex = 0;
        }
    }
}
