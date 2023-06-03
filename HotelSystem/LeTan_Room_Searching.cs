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
            const int width = 100;

            LeTanRoomInfoListView.Items.Clear(); // Clear all list view data
            LeTanRoomInfoListView.Columns.Clear();
            LeTanRoomInfoListView.View = View.Details; // To see add columns
        
            LeTanRoomInfoListView.Columns.Add("Mã đặt phòng", width);
            LeTanRoomInfoListView.Columns.Add("Mã khách hàng", width);
            LeTanRoomInfoListView.Columns.Add("Ngày đặt", width);
            LeTanRoomInfoListView.Columns.Add("Loại phòng", width);
            LeTanRoomInfoListView.Columns.Add("Ngày checkin", width);
            LeTanRoomInfoListView.Columns.Add("Ngày checkout", width);
            LeTanRoomInfoListView.Columns.Add("Yêu cầu", width);
            LeTanRoomInfoListView.Columns.Add("Ngày ghi nhận", 120);

            Boolean checkRoomInfoInput = RoomBUS.checkRoomInfoInput(LeTanRoomInfoInput.Text, LeTanRoomInfoListView);          
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
    }
}
