using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    public class RoomBUS
    {
        public static Boolean checkRoomBookingInput(string customerIdText, string roomIdText, string bookingDateText, string roomTypeText, string checkinDateText, string checkoutDateText, string specialRequestText)
        {
            DateTime dDate;

            if (customerIdText == "" || roomIdText == "" || bookingDateText == "" || roomTypeText == "" || checkinDateText == "" || checkoutDateText == "" || specialRequestText == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!DateTime.TryParse(bookingDateText, out dDate))
            {
                MessageBox.Show("Ngày đặt phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!DateTime.TryParse(checkinDateText, out dDate))
            {
                MessageBox.Show("Ngày checkin phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!DateTime.TryParse(checkoutDateText, out dDate))
            {
                MessageBox.Show("Ngày checkout phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public static Boolean checkAddRoomBooking(Boolean checkInput, string customerId, string roomId, string bookingDate, string roomType, string checkinDate, string checkoutDate, string specialRequest)
        {
            Boolean checkInitCustomer = CustomerDAO.checkInitCustomerUsername(customerId);

            if (!checkInitCustomer)
            {
                MessageBox.Show("Khách hàng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            RoomDAO.addNewRoomBooking(customerId, roomId, bookingDate, roomType, checkinDate, checkoutDate, specialRequest);

            return true;
        }

        public static Boolean checkRoomInfoInput(string value, ListView LeTanRoomInfoListView, ListView LeTanFormBookingListView)
        {
            int n;
            bool isNumeric = int.TryParse(value, out n);

            if (value == "")
            {
                MessageBox.Show("Nhập mã đặt phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!isNumeric)
            {
                MessageBox.Show("Mã phòng phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindRoomInfo = RoomDAO.viewRoomInfoById(value, LeTanRoomInfoListView, LeTanFormBookingListView);

            if(!checkFindRoomInfo)
            {
                MessageBox.Show("Không tìm thấy mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public static Boolean checkRoomRequestInput(string value, ListView LeTanKHListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã yêu cầu đặt phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindRoomRequest = RoomDAO.viewRoomRequestById(value, LeTanKHListView);

            if (!checkFindRoomRequest)
            {
                MessageBox.Show("Không tìm thấy yêu cầu đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        
        public static Boolean checkRoomBookingInput(string value, ListView LeTanRoomBookingListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindRoomBooking = RoomDAO.viewRoomBookingById(value, LeTanRoomBookingListView);

            if (!checkFindRoomBooking)
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public static Boolean checkRoomListInput(string value, ListView LeTanRoomListListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (value == "Thường" || value == "Vip")
            {
                Boolean checkFindRoomList = RoomDAO.viewRoomListByType(value, LeTanRoomListListView);

                if (!checkFindRoomList)
                {
                    MessageBox.Show("Không tìm thấy danh sách phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                Boolean checkFindRoomList = RoomDAO.viewRoomListById(value, LeTanRoomListListView);

                if (!checkFindRoomList)
                {
                    MessageBox.Show("Không tìm thấy danh sách phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            return true;
        }

        public static Boolean checkRoomRequestInput(string username, string password, string name, string address, string cccd, string phone, string dateStart, string dateRequest, string count, string requestDes)
        {

            if (username == "" || password == "" || name == "" || address == "" || cccd == "" || phone == "" || dateStart == "" || dateRequest == "" || count == "" || requestDes == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkInitCustomer = CustomerDAO.checkInitCustomerUsername(username);

            if (checkInitCustomer)
            {
                MessageBox.Show("Khách hàng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(!int.TryParse(cccd, out _))
            {
                MessageBox.Show("CCCD phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!int.TryParse(phone, out _))
            {
                MessageBox.Show("Số điện thoại phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!int.TryParse(count, out _))
            {
                MessageBox.Show("Số đêm lưu trú phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            RoomDAO.addNewRoomRequest(username, password, name, address, cccd, phone, dateStart, dateRequest, count, requestDes);

            return true;
        }

        //KhachHang tìm kiếm thông tin đặt phòng, hiện dữ liệu lên datagridview
        public static Boolean KHcheckRoomRequestInput(string value, DataGridView KhachHangFormBookingDataGridView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã khách hàng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindRoomRequest = RoomDAO.KHviewRoomRequestListById(value, KhachHangFormBookingDataGridView);

            if (!checkFindRoomRequest)
            {
                MessageBox.Show("Không tìm thấy thông tin đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        public static Boolean KHcheckBookingDetailInput(int value, DataGridView BookingDetail)
        {
            try
            {
                if (value.ToString() == "")
                {
                    MessageBox.Show("Nhập mã đặt phòng tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                Boolean checkFindRoomRequest = RoomDAO.KHviewBookingDetail(value, BookingDetail);

                if (!checkFindRoomRequest)
                {
                    MessageBox.Show("Không tìm thấy chi tiết thông tin đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return true;
            } 
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng chọn dòng dữ liệu hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
