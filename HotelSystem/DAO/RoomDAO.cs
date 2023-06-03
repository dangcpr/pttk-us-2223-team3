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

        public static SqlDataReader getQueryStr (SqlConnection sqlConn, string queryStr) {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static void viewAllRoom(ListView LeTanRoomListView)
        {
            LeTanRoomListView.BringToFront();
            LeTanRoomListView.Items.Clear(); // Clear all list view data
            LeTanRoomListView.Columns.Clear();
            LeTanRoomListView.View = View.Details; // To see add columns

            // Get connect to database
            //sqlConn = DatabaseDAO.getConnectDB();

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomQueryStr);

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

        public static void viewRoomType(ComboBox LeTanRoomComboBox, String TypeRoom)
        {
            LeTanRoomComboBox.BringToFront();
            LeTanRoomComboBox.Items.Clear(); // Clear all list view data

            // Get connect to database
            //sqlConn = DatabaseDAO.getConnectDB();

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomQueryStr);

            while (reader.Read())
            {

                if (reader.GetString(1) == TypeRoom && reader.GetString(5) == "Trống")
                {
                    LeTanRoomComboBox.Items.Add(reader.GetInt32(0));
                }

            }
            reader.Close();
            //sqlConn.Close();
        }

        public static void addNewRoomBooking(string customerId, string roomId, string bookingDate, string roomType, string checkinDate, string checkoutDate, string specialRequest)
        {
            string addRoomBookingStr = "INSERT INTO THONG_TIN_DAT_PHONG (MA_KHACH_HANG, NGAY_DAT, LOAI_PHONG, NGAY_CHECKIN, NGAY_CHECKOUT)";
            addRoomBookingStr += " VALUES(" + "'" + customerId + "'";
            addRoomBookingStr += "," + "'" + bookingDate + "'";
            addRoomBookingStr += "," + "N'" + roomType + "'";
            addRoomBookingStr += "," + "'" + checkinDate + "'";
            addRoomBookingStr += "," + "'" + checkoutDate + "');";

            addRoomBookingStr += "DECLARE @MA_DP INT; SET @MA_DP = (SELECT MAX(MA_DP) FROM THONG_TIN_DAT_PHONG);";
            addRoomBookingStr += "INSERT INTO CHI_TIET_DAT_PHONG (MA_DP, YEU_CAU) VALUES (@MA_DP, N'" + specialRequest + "');";

            addRoomBookingStr += "INSERT INTO PHIEU_THONG_TIN_DAT_PHONG (MA_DP, MA_PHONG, MA_KHACH_HANG, MA_NV_GHI_NHAN) VALUES";

            addRoomBookingStr += "(@MA_DP," + int.Parse(roomId) + "," + "'" + customerId + "','" + AccountDAO.overviewUsername + "');";

            string updateStateRoom = "UPDATE THONG_TIN_PHONG_KHACH_SAN SET TINH_TRANG = ";
            updateStateRoom += "N'Hết' WHERE MA_PHONG = ";
            updateStateRoom += int.Parse(roomId);

            try
            {
                SqlCommand sqlCmd = new SqlCommand(addRoomBookingStr, DatabaseDAO.sqlConn);
                sqlCmd.ExecuteNonQuery();

                SqlCommand sqlCmd2 = new SqlCommand(updateStateRoom, DatabaseDAO.sqlConn);
                sqlCmd2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void viewRoomInfoById(string roomBookingID, ListView LeTanRoomInfoListView)
        {
            string roomInfoQueryStr = $"SELECT TTDP.*, CTDP.YEU_CAU, CTDP.NGAY_GHI_NHAN FROM THONG_TIN_DAT_PHONG TTDP JOIN CHI_TIET_DAT_PHONG CTDP ON CTDP.MA_DP = TTDP.MA_DP WHERE CTDP.MA_DP = {roomBookingID};";
            Console.WriteLine(roomInfoQueryStr);

            // Call Room DAO method to get all room
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomInfoQueryStr);

            int index = 0;
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());
                item.SubItems.Add(reader[7].ToString());

                LeTanRoomInfoListView.Items.Add(item);
                index++;
            }
            reader.Close();
        }
    }
}
