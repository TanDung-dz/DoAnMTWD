using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMTWD
{
    class Connection
    {
        private static string stringconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diept\OneDrive\Desktop\DoAnMTWD_SapHoanChinh\DoAnMTWD\DoAnMTWD\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}

