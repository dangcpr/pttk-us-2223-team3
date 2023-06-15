using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.DAO;

namespace HotelSystem.BUS
{
    internal class CheckinBUS
    {
        public static Boolean checkMadp(string madp)
        {
            Boolean checkKh = CheckinDAO.checkMadp(madp);

            return checkKh;
        }

        public static List<String> getThongTinDatPhongByMadp(string madp)
        {
            List<String> list = new List<String>();

            SqlDataReader reader = CheckinDAO.getThongTinDatPhongByMadp(madp);

            while (reader.Read())
            {
                list.Add(reader["MA_DP"].ToString());
                list.Add(reader["MA_KHACH_HANG"].ToString());
                list.Add(reader["NGAY_DAT"].ToString());
                list.Add(reader["LOAI_PHONG"].ToString());
                list.Add(reader["NGAY_CHECKIN"].ToString());
                list.Add(reader["NGAY_CHECKOUT"].ToString());
            }

            reader.Close();

            return list;
        }

        public static Boolean saveDataCheckin(List<String> list)
        {
            DateTime dateValue;
            DateTime.TryParse(list[2], out dateValue);

            bool check = CheckinDAO.saveDataCheckin(list, dateValue);
            return check;
        }
    }
}
