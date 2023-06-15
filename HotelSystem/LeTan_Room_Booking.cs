using HotelSystem.BUS;
using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class LeTan_Room_Booking : UserControl
    {
        public LeTan_Room_Booking()
        {
            InitializeComponent();
            resetAddBookingInput();
        }

        private void quitBookingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void resetAddBookingInput()
        {
            customerId.Text = "";
            roomId.SelectedIndex = -1;
            bookingDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            roomType.SelectedIndex = -1;
            checkinDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            checkoutDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            specialRequest.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmAddRoomBooking = MessageBox.Show("Bạn có chắc muốn thêm thông tin đặt phòng?.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirmAddRoomBooking == DialogResult.Yes)
            {
                int checkInput = RoomBUS.checkRoomBookingInput(customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);

                if (checkInput == 1) MessageBox.Show("Nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkInput == 2) MessageBox.Show("Ngày đặt phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkInput == 3) MessageBox.Show("Ngày checkin phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkInput == 4) MessageBox.Show("Ngày checkout phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (checkInput == 0)
                {
                    int addRoomBooking = RoomBUS.checkAddRoomBooking(checkInput, customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);
                    if (addRoomBooking == 1)
                    {
                        MessageBox.Show("Khách hàng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else if(addRoomBooking == 2)
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                resetAddBookingInput();
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void LeTan_Room_Booking_Load(object sender, EventArgs e)
        {

        }

        private void roomId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RoomDAO.viewRoomType(roomId, roomType.Text);
        }
    }
}
