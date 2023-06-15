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
            // 1: Nhập đầy đủ thông tin
            // 2: Ngày đặt phải là số
            // 3: Ngày checkin phải là số
            // 4: Ngày checkout phải là số

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

        public static int checkAddRoomBooking(int checkInput, string customerId, string roomId, string bookingDate, string roomType, string checkinDate, string checkoutDate, string specialRequest)
        {
            // 1: Không tồn tại khách hàng
            // 2: Thêm thất bại

            Boolean checkInitCustomer = CustomerDAO.checkInitCustomerUsername(customerId);

            if (!checkInitCustomer)
            {              
                return 1;
            }

            int checkAddNewRoomBooking = RoomDAO.addNewRoomBooking(customerId, roomId, bookingDate, roomType, checkinDate, checkoutDate, specialRequest);

            if (checkAddNewRoomBooking == 2) return 2;
            else return 0;
        }

        public static int checkRoomInfoInput(string value, ListView LeTanRoomInfoListView, ListView LeTanFormBookingListView)
        {
            // 1: Thiếu mã phòng
            // 2: Mã phòng phải là số
            // 3: Không tìm thấy mã phòng

            int n;
            bool isNumeric = int.TryParse(value, out n);

            if (value == "")
            {                
                return 1;
            }

            if (!isNumeric)
            {            
                return 2;
            }

            Boolean checkFindRoomInfo = RoomDAO.viewRoomInfoById(value, LeTanRoomInfoListView, LeTanFormBookingListView);

            if(!checkFindRoomInfo)
            {             
                return 3;
            }

            return 0;
        }

        public static int checkRoomRequestInput(string value, ListView LeTanKHListView)
        {
            // 1: Thiếu mã yêu cầu
            // 2: Không tìm thấy mã yêu cầu

            if (value == "")
            {             
                return 1;
            }

            Boolean checkFindRoomRequest = RoomDAO.viewRoomRequestById(value, LeTanKHListView);

            if (!checkFindRoomRequest)
            {               
                return 2;
            }

            return 0;
        }
        
        public static int checkRoomBookingInput(string value, ListView LeTanRoomBookingListView)
        {
            // 1: Thiếu mã đặt phòng
            // 2: Không tìm thấy thông tin đặt phòng

            if (value == "")
            {                
                return 1;
            }

            Boolean checkFindRoomBooking = RoomDAO.viewRoomBookingById(value, LeTanRoomBookingListView);

            if (!checkFindRoomBooking)
            {         
                return 2;
            }

            return 0;
        }

        public static int checkRoomListInput(string value, ListView LeTanRoomListListView)
        {
            // 1: Thiếu mã phòng
            // 2: Loại phòng không hợp lệ
            // 3: Không tìm thấy danh sách phòng

            if (value == "")
            {            
                return 1;
            }
            else if (value == "Thường" || value == "Vip")
            {
                Boolean checkFindRoomList = RoomDAO.viewRoomListByType(value, LeTanRoomListListView);

                if (!checkFindRoomList)
                {                   
                    return 2;
                }
            }
            else
            {
                Boolean checkFindRoomList = RoomDAO.viewRoomListById(value, LeTanRoomListListView);

                if (!checkFindRoomList)
                {                   
                    return 3;
                }
            }
            return 0;
        }

        public static int checkRoomRequestInput(string username, string password, string name, string address, string cccd, string phone, string dateStart, string dateRequest, string count, string requestDes)
        {
            // 1: Nhập đầy đủ thông tin
            // 2: Khách hàng tồn tại
            // 3: CCCD phải là số
            // 4: Số điện thoại phải là số
            // 5: Số đêm lưu trú phải là số

            if (username == "" || password == "" || name == "" || address == "" || cccd == "" || phone == "" || dateStart == "" || dateRequest == "" || count == "" || requestDes == "")
            {               
                return 1;
            }

            Boolean checkInitCustomer = CustomerDAO.checkInitCustomerUsername(username);

            if (checkInitCustomer)
            {               
                return 2;
            }

            if(!int.TryParse(cccd, out _))
            {               
                return 3;
            }

            if (!int.TryParse(phone, out _))
            {              
                return 4;
            }

            if (!int.TryParse(count, out _))
            {               
                return 5;
            }

            int checkAddNewRoomRequest = RoomDAO.addNewRoomRequest(username, password, name, address, cccd, phone, dateStart, dateRequest, count, requestDes);

            if (checkAddNewRoomRequest == 6) return 6;

            return 0;
        }

    }
}
