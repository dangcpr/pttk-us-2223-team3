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
            LeTanRoomListView.View = View.Details; // To see add columns

            // Get connect to database
            sqlConn = DatabaseDAO.getConnectDB();

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getAllRoom(sqlConn);

            int index = 0;
            while (reader.Read())
            {
                LeTanRoomListView.Items.Add(reader[0].ToString());

                // Check if NGAYTHUE = NULL
                if (reader[1].ToString() == "")
                {
                    LeTanRoomListView.Items[index].SubItems.Add("Chưa có");
                }
                else
                {
                    LeTanRoomListView.Items[index].SubItems.Add(reader[1].ToString());
                }

                // Check if NGAYTRA = NULL
                if (reader[2].ToString() == "")
                {
                    LeTanRoomListView.Items[index].SubItems.Add("Chưa có");
                }
                else
                {
                    LeTanRoomListView.Items[index].SubItems.Add(reader[2].ToString());
                }

                LeTanRoomListView.Items[index].SubItems.Add(reader[3].ToString());
                LeTanRoomListView.Items[index].SubItems.Add(reader[4].ToString());
                index++;
            }

            sqlConn.Close();
        }
    }
}
