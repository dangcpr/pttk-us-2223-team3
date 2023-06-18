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
    public partial class LeTan_Room_Searching : UserControl
    {
        public LeTan_Room_Searching()
        {
            InitializeComponent();
        }

        private void quitBookingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LeTanRoomInfoBtn_Click(object sender, EventArgs e)
        {
            // List view setting
            const int width = 100;

            LeTanRoomInfoListView.Items.Clear(); // Clear all list view data
            LeTanRoomInfoListView.Columns.Clear();
            LeTanRoomInfoListView.View = View.Details; // To see add columns

            LeTanFormBookingListView.Items.Clear(); // Clear all list view data
            LeTanFormBookingListView.Columns.Clear();
            LeTanFormBookingListView.View = View.Details; // To see add columns

            LeTanRoomInfoListView.Columns.Add("Mã đặt phòng", 80);
            LeTanRoomInfoListView.Columns.Add("Mã khách hàng", width);
            LeTanRoomInfoListView.Columns.Add("Ngày đặt", 150);
            LeTanRoomInfoListView.Columns.Add("Loại phòng", width);
            LeTanRoomInfoListView.Columns.Add("Ngày checkin", 150);
            LeTanRoomInfoListView.Columns.Add("Ngày checkout", 150);
            LeTanRoomInfoListView.Columns.Add("Yêu cầu", 150);
            LeTanRoomInfoListView.Columns.Add("Ngày ghi nhận", 150);

            LeTanFormBookingListView.Columns.Add("Mã phiếu", 80);
            LeTanFormBookingListView.Columns.Add("Mã đặt phòng", 80);
            LeTanFormBookingListView.Columns.Add("Mã phòng", 80);
            LeTanFormBookingListView.Columns.Add("Mã khách hàng", width);
            LeTanFormBookingListView.Columns.Add("Ngày ghi", 150);
            LeTanFormBookingListView.Columns.Add("Nhân viên ghi nhận", 120);

            // Business class calling
            int checkRoomInfoInput = RoomBUS.checkRoomInfoInput(LeTanRoomInfoInput.Text, LeTanRoomInfoListView, LeTanFormBookingListView);

            if (checkRoomInfoInput == 1) MessageBox.Show("Nhập mã đặt phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (checkRoomInfoInput == 2) MessageBox.Show("Mã phòng phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (checkRoomInfoInput == 3) MessageBox.Show("Không tìm thấy mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input
            LeTanRoomInfoInput.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
           
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

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LeTanRoomInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
