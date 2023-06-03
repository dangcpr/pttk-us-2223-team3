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
        public static int checkRoomBookingInput(string customerIdText, string roomIdText, string bookingDateText, string roomTypeText, string checkinDateText, string checkoutDateText, string specialRequestText)
        {
            // 0: True
            // 1: Fill full input
            // 2: Booking date type
            // 3: Checkin date type
            // 4: Checkout date type

            DateTime dDate;

            if (customerIdText == "" || roomIdText == "" || bookingDateText == "" || roomTypeText == "" || checkinDateText == "" || checkoutDateText == "" || specialRequestText == "")
            {
                return 1;
            }
            else if (!DateTime.TryParse(bookingDateText, out dDate))
            {
                return 2;
            }
            else if (!DateTime.TryParse(checkinDateText, out dDate))
            {
                return 3;
            }
            else if (!DateTime.TryParse(checkoutDateText, out dDate))
            {
                return 4;
            }

            return 0;
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

    }
}
