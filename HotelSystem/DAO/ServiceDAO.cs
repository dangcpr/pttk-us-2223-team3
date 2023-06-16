using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAO
{
    internal class ServiceDAO
    {
        public static SqlDataAdapter getDanhSachDatLichDv()
        {
            String getData = "SELECT * FROM LICH_SU_DUNG_DICH_VU";
            SqlDataAdapter adapter = new SqlDataAdapter(getData, DatabaseDAO.sqlConn);
            return adapter;
        }
    }
}
