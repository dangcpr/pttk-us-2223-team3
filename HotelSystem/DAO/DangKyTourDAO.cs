using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAO
{
    internal class DangKyTourDAO
    {
        public static SqlDataAdapter getTourDuLich()
        {
            String getData = "SELECT * FROM TOUR_DU_LICH";
            SqlDataAdapter adapter = new SqlDataAdapter(getData, DatabaseDAO.sqlConn);
            return adapter;
        }

        public static SqlDataAdapter getDoiTacDuLich()
        {
            String getData = "SELECT * FROM DON_VI_LU_HANH";
            SqlDataAdapter adapter = new SqlDataAdapter(getData, DatabaseDAO.sqlConn);
            return adapter;
        }

        public static Boolean saveDataDatTour(List<String> list, DateTime dateValue)
        {
            bool result = false;

            try
            {
                string _saveDataDatTour = $"INSERT INTO THONG_TIN_DAT_TOUR (MA_KHACH_HANG, MA_DON_VI_LU_HANH, THOI_GIAN) VALUES ('{list[0]}', '{list[1]}','{dateValue.Year}-{dateValue.Month}-{dateValue.Day}')";
                SqlCommand sqlCmd = new SqlCommand(_saveDataDatTour, DatabaseDAO.sqlConn);
                sqlCmd.ExecuteNonQuery();
                result = true;

            }
            catch (SqlException ex)
            {
                return result;
            }
            return result;
        }
    }
}
