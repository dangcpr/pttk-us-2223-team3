using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class CustomerDAO
    {
        public static string customerQueryStr = "SELECT KH.MA_KHACH_HANG, KH.HO_TEN, KH.DIA_CHI, KH.CCCD, KH.SDT, KD.TEN_DOAN FROM THONG_TIN_KHACH_HANG AS KH, THONG_TIN_KHACH_DOAN AS KD, CHI_TIET_KHACH_DOAN AS CT WHERE KH.MA_KHACH_HANG = CT.MA_KHACH_HANG AND CT.MA_DOAN = KD.MA_DOAN";

        public static SqlDataReader getAllCustomer(SqlConnection sqlConn)
        {
            SqlCommand sqlCmd = new SqlCommand(customerQueryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static void viewAllCustomer(ListView LeTanKHListView, SqlConnection sqlConn)
        {
            LeTanKHListView.BringToFront();
            LeTanKHListView.Items.Clear(); // Clear all list view data
            LeTanKHListView.Columns.Clear();
            LeTanKHListView.View = View.Details; // To see add columns

            // Get connect to database
            sqlConn = DatabaseDAO.getConnectDB();

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getAllRoom(SignInForm.sqlConn);

            const int width = 100;

            LeTanKHListView.Columns.Add("Mã khách hàng", width);
            LeTanKHListView.Columns.Add("Họ tên", width);
            LeTanKHListView.Columns.Add("Địa chỉ", width);
            LeTanKHListView.Columns.Add("CCCD", width);
            LeTanKHListView.Columns.Add("SĐT", width);
            LeTanKHListView.Columns.Add("Tên đoàn", width);

            int index = 0;
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());

                LeTanKHListView.Items.Add(item);
                index++;
            }
            reader.Close();
        }
    }
}
