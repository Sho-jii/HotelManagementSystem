using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    internal class function
    {
        private static string _connectionString;

        public static string GetConnectionString()
        {
            if (!string.IsNullOrEmpty(_connectionString))
            {
                return _connectionString;
            }

            string dbFileName = "inventoryHotel.mdf";
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = null;

            // Search up to 5 parent directories to locate the .mdf file
            string checkDir = currentDir;
            for (int i = 0; i < 5; i++)
            {
                string candidate = Path.Combine(checkDir, dbFileName);
                if (File.Exists(candidate))
                {
                    dbPath = Path.GetFullPath(candidate);
                    break;
                }

                DirectoryInfo parent = Directory.GetParent(checkDir);
                if (parent == null) break;
                checkDir = parent.FullName;
            }

            if (string.IsNullOrEmpty(dbPath))
            {
                dbPath = Path.Combine(currentDir, dbFileName);
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(dbPath));
            _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
            return _connectionString;
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        public SqlDataReader getForCombo(string query, Dictionary<string, object> parameters = null)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }
            conn.Open();
            // CommandBehavior.CloseConnection ensures connection closes when reader is closed
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DataSet getData(string query, Dictionary<string, object> parameters = null)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }
            return ds;
        }

        public void setData(string query, string message, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
