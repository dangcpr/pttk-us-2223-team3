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
        public SqlConnection getConnectDB(string connectStr)
        {
            SqlConnection sqlConn = new SqlConnection(connectStr);
            return sqlConn;
        }
    }
}
