using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.BUS
{
    internal class DatabaseBUS
    {
        public static Boolean checkDatabaseConnect()
        {
            DatabaseDAO.sqlConn = DatabaseDAO.getConnectDB();
            return true;
        }

        public static Boolean checkDatabaseDisconnect()
        {
            DatabaseDAO.sqlConn.Close();
            return true;
        }
    }
}
