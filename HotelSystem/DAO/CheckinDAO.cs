using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelSystem.DAO
{
    internal class CheckinDAO
    {
        public static string getAllThongTinDatPhong = "SELECT MA_DP FROM THONG_TIN_DAT_PHONG";

        public static Boolean checkMadp(String madp)
        {
            SqlCommand sqlCmd = new SqlCommand(getAllThongTinDatPhong, DatabaseDAO.sqlConn);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool checkMaDatPhong = false;
            while (reader.Read())
            {
                if (reader["MA_DP"].ToString() == madp)
                {
                    checkMaDatPhong = true;
                }

            }

            // Đóng reader sau khi truy xuất xong
            reader.Close();

            return checkMaDatPhong;
        }

        public static SqlDataReader getThongTinDatPhongByMadp(string madp)
        {
            string getThongTinDatPhong = $"SELECT * FROM THONG_TIN_DAT_PHONG where MA_DP = '{madp}'";


            SqlCommand sqlCmd = new SqlCommand(getThongTinDatPhong, DatabaseDAO.sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            return reader;
        }

        public static Boolean saveDataCheckin(List<String> list, DateTime dateValue)
        {
            bool result = false;

            try
            {
                string _saveDataCheckin = $"INSERT INTO PHIEU_DANG_KY (MA_KHACH_HANG, CCCD, NGAY_CHECK_IN, GHI_CHU) VALUES ('{list[0]}', '{list[1]}', '{dateValue.Year.ToString()}-{dateValue.Month.ToString()}-{dateValue.Day.ToString()}', '{list[3]}')";
                SqlCommand sqlCmd = new SqlCommand(_saveDataCheckin, DatabaseDAO.sqlConn);
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
