using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class KhachDoanDAO
    {
        public static DataTable fillData(SqlConnection sqlConn, string queryStr)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryStr, sqlConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static List<string> selectKhachHang()
        {
            string selectStr = $"SELECT MA_KHACH_HANG FROM THONG_TIN_KHACH_HANG";

            // Call Room DAO method to get room list
            DataTable dataTable = fillData(DatabaseDAO.sqlConn, selectStr);
            List<string> customers = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                customers.Add(row["MA_KHACH_HANG"].ToString());
            }
            return customers;
        }

        public static int ThemKhachDoan(string maDoan, string password, string tenDoan, string soFax, string soLuong, List<String> customers)
        {
            try
            {
                string insertStr = $"INSERT INTO TAI_KHOAN (USERNAME, PASSWORD, ROLE) VALUES (N'{maDoan}', N'{password}', N'Khách hàng'); ";
                insertStr += $"INSERT INTO THONG_TIN_KHACH_DOAN (MA_DOAN, TEN_DOAN, SO_FAX, SO_LUONG) VALUES (N'{maDoan}', N'{tenDoan}', '{soFax}', {soLuong});";
                SqlCommand sqlCmd = new SqlCommand(insertStr, DatabaseDAO.sqlConn);


                for (int i = 0; i < customers.Count; i++)
                {
                    insertStr += $"INSERT INTO CHI_TIET_KHACH_DOAN (MA_DOAN, MA_KHACH_HANG) VALUES (N'{maDoan}', N'{customers[i]}');";
                }
                sqlCmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
