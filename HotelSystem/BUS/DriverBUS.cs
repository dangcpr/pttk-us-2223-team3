using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.BUS
{
    public class DriverBUS
    {
        public static SqlDataReader viewListDrivers()
        {
            SqlDataReader listDrivers = DriverDAO.getListDrivers();
            return listDrivers;
        }

        public static Boolean checkDriverExists(string MaTX)
        {
            Boolean isExists = true;
            SqlDataReader listDrivers = DriverDAO.getDriverByID(MaTX);
            if (!listDrivers.HasRows || listDrivers is null)
            {
                listDrivers.Close();
                isExists = false;
            }
            listDrivers.Close();
            return isExists;
        }

        public static SqlDataReader viewDriverByID(string MaTX)
        {
            SqlDataReader listDrivers = DriverDAO.getDriverByID(MaTX);
            return listDrivers;
        }
    }
}
