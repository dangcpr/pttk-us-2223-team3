using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAO
{
    public class DatabaseDAO
    {
        public static SqlConnection sqlConn = null;
        public static string dbConnectStr = "Data Source=localhost;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        public static SqlConnection getConnectDB()
        {
            sqlConn = new SqlConnection(dbConnectStr);
            sqlConn.Open();
            return sqlConn;
        }
    }
}
