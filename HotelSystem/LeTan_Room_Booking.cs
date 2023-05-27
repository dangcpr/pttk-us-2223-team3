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
        }

        private void quitBookingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void resetAddBookingInput()
        {
            customerId.Text = "";
            roomId.Text = "";
            bookingDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            roomType.Text = "";
            checkinDate.Text = "";
            checkoutDate.Text = "";
            specialRequest.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmAddRoomBooking = MessageBox.Show("Bạn có chắc muốn thêm thông tin đặt phòng?.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirmAddRoomBooking == DialogResult.Yes)
            {
                int checkInput = RoomBUS.checkRoomBookingInput(customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);

                SqlConnection sqlConnn = DatabaseDAO.getConnectDB();

                SqlDataReader reader = CustomerDAO.getCustomerById(DatabaseDAO.sqlConn, customerId.Text);

                string checkCustomerInit = "";

                if (reader.Read())
                {
                    checkCustomerInit = reader[0].ToString();
                }
                else
                {
                    checkCustomerInit = "None";
                }

                Console.WriteLine(checkCustomerInit + checkInput);

                Boolean checkValid = CustomerBUS.checkCustomerInit(checkCustomerInit, checkInput);

                reader.Close();

                if (checkValid)
                {
                    RoomDAO.addNewRoomBooking(customerId.Text, roomId.Text, bookingDate.Text, roomType.Text, checkinDate.Text, checkoutDate.Text, specialRequest.Text);
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
