using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{

    public class RoomDAO
    {
        public static string roomQueryStr = "SELECT * FROM THONG_TIN_PHONG_KHACH_SAN";

        public static SqlDataReader getAllRoom (SqlConnection sqlConn) {
            SqlCommand sqlCmd = new SqlCommand(roomQueryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static void viewAllRoom(ListView LeTanRoomListView, SqlConnection sqlConn)
        {
            LeTanRoomListView.BringToFront();
            LeTanRoomListView.Items.Clear(); // Clear all list view data
            LeTanRoomListView.Columns.Clear();
            LeTanRoomListView.View = View.Details; // To see add columns

            // Get connect to database
            sqlConn = DatabaseDAO.getConnectDB();

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getAllRoom(SignInForm.sqlConn);

            const int width = 100;

            LeTanRoomListView.Columns.Add("Mã phòng", width);
            LeTanRoomListView.Columns.Add("Loại phòng", width);
            LeTanRoomListView.Columns.Add("Giá tiền", width);
            LeTanRoomListView.Columns.Add("Ngày thuê", width);
            LeTanRoomListView.Columns.Add("Ngày trả", width);
            LeTanRoomListView.Columns.Add("Tình trạng", width);
            LeTanRoomListView.Columns.Add("Dọn dẹp", width);

            int index = 0;
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());

                // Check if NGAYTHUE = NULL
                if (reader[3] == DBNull.Value)
                {
                    item.SubItems.Add("Chưa có");
                }
                else
                {
                    item.SubItems.Add(reader[3].ToString());
                }

                // Check if NGAYTRA = NULL
                if (reader[4] == DBNull.Value)
                {
                    item.SubItems.Add("Chưa có");
                }
                else
                {
                    item.SubItems.Add(reader[4].ToString());
                }

                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());

                LeTanRoomListView.Items.Add(item);
                index++;
            }
            reader.Close();
            //sqlConn.Close();
        }
    }
}
