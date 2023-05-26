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
        public static string dbConnectStr = "Data Source=.;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        public static SqlConnection getConnectDB()
        {
            SqlConnection sqlConn = new SqlConnection(dbConnectStr);
            sqlConn.Open();
            return sqlConn;
        }
    }
}
