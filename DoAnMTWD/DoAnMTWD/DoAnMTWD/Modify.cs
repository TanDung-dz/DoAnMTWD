using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAnMTWD
{
     class Modify
    {
       

        public Modify()
        {
            // Constructor code here (nếu cần)
        }
        SqlConnection sqlConnection; // Dùng để truy vấn các câu lệnh insert, update, delete
        SqlDataReader dataReader; // Dùng để đọc dữ liệ

        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

        public List<TaiKhoan> TaiKhoans(string query, SqlConnection sqlConnection)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection); // Khai báo SqlCommand ở đây
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }

            return taiKhoans;
        }  
    }
}

