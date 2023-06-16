using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.BUS
{
    internal class ServiceBUS
    {
        public static DataTable getDanhSachDatLichDv()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter = ServiceDAO.getDanhSachDatLichDv();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
