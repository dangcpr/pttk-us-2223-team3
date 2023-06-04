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
                Boolean checkInput = RoomBUS.checkRoomBookingInput(customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);
                Boolean addRoomBooking = RoomBUS.checkAddRoomBooking(checkInput, customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);

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
