using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.DAO;

namespace HotelSystem.BUS
{
    internal class DangKyTourBUS
    {
        public static DataTable getTourDuLich()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter = DangKyTourDAO.getTourDuLich();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static Boolean saveDataDatTour(List<String> list, DateTime dateValue)
        {

            bool check = DangKyTourDAO.saveDataDatTour(list, dateValue);
            return check;
        }

        public static DataTable getDoiTacDuLich()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter = DangKyTourDAO.getDoiTacDuLich();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
