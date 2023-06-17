using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

        //Fill data in datagridview
        public static DataTable fillData(SqlConnection sqlConn, string queryStr)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryStr, sqlConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
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

        public static Boolean viewRoomInfoById(string roomBookingID, ListView LeTanRoomInfoListView, ListView LeTanFormBookingListView)
        {
            Boolean isFound = false;
            int n;
            int index = 0;
            string roomInfoQueryStr = $"SELECT TTDP.*, CTDP.YEU_CAU, CTDP.NGAY_GHI_NHAN FROM THONG_TIN_DAT_PHONG TTDP JOIN CHI_TIET_DAT_PHONG CTDP ON CTDP.MA_DP = TTDP.MA_DP WHERE CTDP.MA_DP = {roomBookingID};";
            string roomBookingFormStr = $"SELECT * FROM PHIEU_THONG_TIN_DAT_PHONG WHERE MA_DP = {roomBookingID};";

            // Call Room DAO method to get room booking info
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomInfoQueryStr);              
            
            while (reader.Read())
            {
                // Check found room info
                bool isNumeric = int.TryParse(reader[0].ToString(), out n);
                if (isNumeric) isFound = true;
                //if (reader[0].ToString() != "") isFound = true;

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

            // Call Room DAO method to get room booking form
            reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomBookingFormStr);

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());

                LeTanFormBookingListView.Items.Add(item);
                index++;
            }

            reader.Close();

            return isFound;
        }

        public static Boolean viewRoomRequestById(string bookingRequestID, ListView LeTanKHListView)
        {
            Boolean isFound = false;
            int index = 0;

            string bookingRequestStr = $"SELECT TTYCDP.*, CTYCDP.NGAY_GHI_NHAN FROM THONG_TIN_YEU_CAU_DAT_PHONG TTYCDP JOIN CHI_TIET_YEU_CAU_DAT_PHONG CTYCDP ON CTYCDP.MA_YEU_CAU = TTYCDP.MA_YEU_CAU WHERE CTYCDP.MA_YEU_CAU = {bookingRequestID};";

            // Call Room DAO method to get room booking form
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, bookingRequestStr);

            while (reader.Read())
            {
                // Check found room request
                if (reader[0].ToString() != "") isFound = true;

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());

                LeTanKHListView.Items.Add(item);
                index++;
            }

            reader.Close();
            return isFound;
        }

        public static Boolean viewRoomBookingById(string bookingID, ListView LeTanRoomBookingListView)
        {
            Boolean isFound = false;
            int n;
            int index = 0;
            string bookingRequestStr = $"SELECT TTDP.*, PTTDP.MA_PHONG FROM THONG_TIN_DAT_PHONG TTDP JOIN PHIEU_THONG_TIN_DAT_PHONG PTTDP ON TTDP.MA_DP = PTTDP.MA_DP WHERE PTTDP.MA_PHONG = {bookingID};";

            bool isNumeric = int.TryParse(bookingID, out n);

            if(isNumeric)
            {
                // Call Room DAO method to get room booking form
                SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, bookingRequestStr);

                while (reader.Read())
                {
                    // Check found room request
                    if (reader[0].ToString() != "") isFound = true;

                    ListViewItem item = new ListViewItem(reader[0].ToString());

                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
                    item.SubItems.Add(reader[6].ToString());

                    LeTanRoomBookingListView.Items.Add(item);
                    index++;
                }

                reader.Close();
            }            
            return isFound;
        }

        public static Boolean viewRoomListByType(string roomType, ListView LeTanRoomBookingListView)
        {
            Boolean isFound = false;
            int index = 0;
            string roomTypeStr = $"SELECT * FROM THONG_TIN_PHONG_KHACH_SAN WHERE LOAI_PHONG = N'{roomType}'";

            // Call Room DAO method to get room list
            SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomTypeStr);

            while (reader.Read())
            {
                // Check found room request
                if (reader[0].ToString() != "") isFound = true;

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());

                // Check if NGAY_THUE = NULL
                if (reader[3] == DBNull.Value)
                {
                    item.SubItems.Add("Không có");
                }
                else
                {
                    item.SubItems.Add(reader[3].ToString());
                }

                // Check if NGAY_TRA = NULL
                if (reader[4] == DBNull.Value)
                {
                    item.SubItems.Add("Không có");
                }
                else
                {
                    item.SubItems.Add(reader[4].ToString());
                }

                item.SubItems.Add(reader[5].ToString());

                // Check if DON_DEP = NULL
                if (reader[6] == DBNull.Value)
                {
                    item.SubItems.Add("Chưa");
                }
                else
                {
                    item.SubItems.Add(reader[6].ToString());
                }

                LeTanRoomBookingListView.Items.Add(item);
                index++;
            }

            reader.Close();
            return isFound;
        }

        public static Boolean viewRoomListById(string roomId, ListView LeTanRoomBookingListView)
        {
            Boolean isFound = false;
            int n;
            int index = 0;
            string roomIdStr = $"SELECT * FROM THONG_TIN_PHONG_KHACH_SAN WHERE MA_PHONG = '{roomId}';";

            bool isNumeric = int.TryParse(roomId, out n);

            if(isNumeric)
            {
                // Call Room DAO method to get room list
                SqlDataReader reader = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomIdStr);

                while (reader.Read())
                {
                    // Check found room request
                    if (reader[0].ToString() != "") isFound = true;

                    ListViewItem item = new ListViewItem(reader[0].ToString());

                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[2].ToString());

                    // Check if NGAY_THUE = NULL
                    if (reader[3] == DBNull.Value)
                    {
                        item.SubItems.Add("Không có");
                    }
                    else
                    {
                        item.SubItems.Add(reader[3].ToString());
                    }

                    // Check if NGAY_TRA = NULL
                    if (reader[4] == DBNull.Value)
                    {
                        item.SubItems.Add("Không có");
                    }
                    else
                    {
                        item.SubItems.Add(reader[4].ToString());
                    }

                    item.SubItems.Add(reader[5].ToString());

                    // Check if DON_DEP = NULL
                    if (reader[6] == DBNull.Value)
                    {
                        item.SubItems.Add("Chưa");
                    }
                    else
                    {
                        item.SubItems.Add(reader[6].ToString());
                    }

                    LeTanRoomBookingListView.Items.Add(item);
                    index++;
                }
                reader.Close();
            }                     
            return isFound;
        }

        public static void addNewRoomRequest(string username, string password, string name, string address, string cccd, string phone, string dateStart, string dateRequest, string count, string requestDes)
        {
            string addRequestStr = $"INSERT INTO TAI_KHOAN (USERNAME, PASSWORD, ROLE) VALUES ('{username}', '{password}', N'Khách hàng');";
            addRequestStr += $"INSERT INTO THONG_TIN_KHACH_HANG (MA_KHACH_HANG, HO_TEN, DIA_CHI, CCCD, SDT) VALUES ('{username}', N'{name}', N'{address}', '{cccd}', '{phone}');";
            addRequestStr += $"INSERT INTO THONG_TIN_YEU_CAU_DAT_PHONG (MA_KHACH_HANG, NGAY_DEN, SO_DEM_LUU_TRU, LOAI_YEU_CAU, NGAY_YEU_CAU) VALUES ('{username}', '{dateStart}', {count}, N'{requestDes}', '{dateRequest}');";
            addRequestStr += "DECLARE @MA_YEU_CAU INT; SET @MA_YEU_CAU = (SELECT MAX(MA_YEU_CAU) FROM THONG_TIN_YEU_CAU_DAT_PHONG);";
            addRequestStr += "INSERT INTO CHI_TIET_YEU_CAU_DAT_PHONG (MA_YEU_CAU) VALUES (@MA_YEU_CAU);";

            Console.WriteLine(addRequestStr);

            try
            {
                SqlCommand sqlCmd = new SqlCommand(addRequestStr, DatabaseDAO.sqlConn);
                sqlCmd.ExecuteNonQuery();
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
        //KhachHang tìm kiếm thông tin đặt phòng, hiện thông tin lên Datagridview
        public static DataTable KHviewRoomRequestListById(string customerID)
        {
            string roomIdStr = $"SELECT * FROM THONG_TIN_DAT_PHONG WHERE MA_KHACH_HANG = '{customerID}'";

            // Call Room DAO method to get room list
            DataTable dataTable = fillData(DatabaseDAO.sqlConn, roomIdStr);
            return dataTable;
        }

        public static DataTable KHviewBookingDetail(int requestID)
        {
            string requestIdStr = $"SELECT * FROM CHI_TIET_DAT_PHONG WHERE MA_DP = {requestID}";

            // Call Room DAO method to get room list
            DataTable dataTable = fillData(DatabaseDAO.sqlConn, requestIdStr);
            return dataTable;
        }

        public static SqlDataReader getListRoom()
        {
            SqlDataReader listRoom = RoomDAO.getQueryStr(DatabaseDAO.sqlConn, roomQueryStr);
            return listRoom;
        }

        public static string getRoomStatus(string MaPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT TINH_TRANG FROM THONG_TIN_PHONG_KHACH_SAN WHERE MA_PHONG = @MaPhong;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            string status = cmd.ExecuteScalar().ToString();
            return status;
        }

        public static void getCustomerByRoomID(string MaPhong, ref string MaKH, ref string HoTen)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 THONG_TIN_KHACH_HANG.MA_KHACH_HANG, HO_TEN FROM PHIEU_THONG_TIN_DAT_PHONG JOIN THONG_TIN_KHACH_HANG ON PHIEU_THONG_TIN_DAT_PHONG.MA_KHACH_HANG = THONG_TIN_KHACH_HANG.MA_KHACH_HANG WHERE MA_PHONG = @MaPhong ORDER BY NGAY_GHI DESC;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MaKH = reader[0].ToString();
            HoTen = reader[1].ToString();
            reader.Close();
        }

        public static string getRoomTypeByRoomID(string MaPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT LOAI_PHONG FROM THONG_TIN_PHONG_KHACH_SAN WHERE MA_PHONG = @MaPhong;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            string roomType = cmd.ExecuteScalar().ToString();
            return roomType;
        }

        public static int getRoomPrice(string MaPhong)
        {
            int roomPrice = 0;
            SqlCommand cmd = new SqlCommand("SELECT GIA_TIEN FROM THONG_TIN_PHONG_KHACH_SAN WHERE MA_PHONG = @MaPhong;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            roomPrice = Convert.ToInt32(cmd.ExecuteScalar());
            return roomPrice;
        }

        public static void updateRoomStatus(string MaPhong, string Status)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THONG_TIN_PHONG_KHACH_SAN SET TINH_TRANG = @Status WHERE MA_PHONG = @MaPhong;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.ExecuteNonQuery();
        }

    }
}
