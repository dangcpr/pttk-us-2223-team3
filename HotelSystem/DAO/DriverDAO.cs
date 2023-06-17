using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class DriverDAO
    {
        public static SqlDataReader getListDrivers()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM THONG_TIN_TAI_XE", DatabaseDAO.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getDriverByID(string MaTX)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM THONG_TIN_TAI_XE WHERE MA_TAI_XE = @MaTX", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaTX", MaTX);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
