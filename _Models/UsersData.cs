using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    internal class UsersData
    {
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Status { set; get; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection conn = new SqlConnection(function.GetConnectionString()))
            {
                conn.Open();
                string selectData = "SELECT id, username, password, status FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsersData uData = new UsersData
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Username = reader["username"]?.ToString(),
                                Password = reader["password"]?.ToString(),
                                Status = reader["status"]?.ToString()
                            };
                            listData.Add(uData);
                        }
                    }
                }
            }
            return listData;
        }
    }
}
