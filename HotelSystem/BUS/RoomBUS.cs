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

        public static Boolean checkRoomInfoInput(string value, ListView LeTanRoomInfoListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã đặt phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            RoomDAO.viewRoomInfoById(value, LeTanRoomInfoListView);

            return true;
        }

    }
}
