using HotelSystem.BUS;
using HotelSystem.DAO;
using HotelSystem.CLASS;
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
    public partial class LeTan_Room : UserControl
    {
        //private SqlConnection sqlConn = null;

        public LeTan_Room()
        {
            InitializeComponent();
        }

        private void LeTan_Room_Load(object sender, EventArgs e)
        {
            LeTanRoomListView.Hide();
            LeTanKHListView.Hide();
            LeTanRuleListView.Hide();
            LeTanRoomBookingListView.Hide();
            LeTanRoomBooking.Hide();
            LeTan_Room_Searching.Hide();
            LeTan_Customer_Searching.Hide();
            leTanRoomRequest.Hide();
        }

        private void LeTanRoomSearchingDropbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(LeTanRoomSearchingDropbox.Text);

            if(LeTanRoomSearchingDropbox.Text == "Tra cứu thông tin đặt phòng")
            {
                LeTan_Room_Searching.Show();
                LeTan_Room_Searching.BringToFront();
            }
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu yêu cầu đặt phòng (mã)")
            {
                LeTanRoomListView.Show();
                LeTanRoomListView.BringToFront();

                // List view setting
                const int width = 100;

                LeTanRoomListView.Items.Clear(); // Clear all list view data
                LeTanRoomListView.Columns.Clear();
                LeTanRoomListView.View = View.Details; // To see add columns

                LeTanRoomListView.Columns.Add("Mã yêu cầu", 100);
                LeTanRoomListView.Columns.Add("Mã khách hàng", width);
                LeTanRoomListView.Columns.Add("Ngày đến", 150);
                LeTanRoomListView.Columns.Add("Số đêm lưu trú", width);
                LeTanRoomListView.Columns.Add("Loại yêu cầu", width);
                LeTanRoomListView.Columns.Add("Ngày yêu cầu", 150);
                LeTanRoomListView.Columns.Add("Ngày ghi nhận", 150);           
            }
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu danh sách khách hàng")
            {
                LeTan_Customer_Searching.Show();
                LeTan_Customer_Searching.BringToFront();
            }
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu quy định khách sạn")
            {
                LeTanRuleListView.Show();
                LeTanRuleListView.BringToFront();

                // List view setting
                const int width = 100;

                LeTanRuleListView.Items.Clear(); // Clear all list view data
                LeTanRuleListView.Columns.Clear();
                LeTanRuleListView.View = View.Details; // To see add columns

                LeTanRuleListView.Columns.Add("Mã quy định", width);
                LeTanRuleListView.Columns.Add("Nội dung", 200);
            }
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu danh sách đặt phòng (mã)")
            {
                LeTanRoomBookingListView.Show();
                LeTanRoomBookingListView.BringToFront();

                // List view setting
                const int width = 100;

                LeTanRoomBookingListView.Items.Clear(); // Clear all list view data
                LeTanRoomBookingListView.Columns.Clear();
                LeTanRoomBookingListView.View = View.Details; // To see add columns

                LeTanRoomBookingListView.Columns.Add("Mã đặt phòng", 120);
                LeTanRoomBookingListView.Columns.Add("Mã khách hàng", 120);
                LeTanRoomBookingListView.Columns.Add("Ngày đặt", 150);
                LeTanRoomBookingListView.Columns.Add("Loại phòng", width);
                LeTanRoomBookingListView.Columns.Add("Ngày checkin", 150);
                LeTanRoomBookingListView.Columns.Add("Ngày checkout", 150);
                LeTanRoomBookingListView.Columns.Add("Mã phòng", width);

            }
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu danh sách phòng (mã/loại)")
            {
                LeTanRoomListListView.Show();
                LeTanRoomListListView.BringToFront();

                // List view setting
                const int width = 100;

                LeTanRoomListListView.Items.Clear(); // Clear all list view data
                LeTanRoomListListView.Columns.Clear();
                LeTanRoomListListView.View = View.Details; // To see add columns

                LeTanRoomListListView.Columns.Add("Mã phòng", width);
                LeTanRoomListListView.Columns.Add("Loại phòng", 120);
                LeTanRoomListListView.Columns.Add("Giá tiền", width);
                LeTanRoomListListView.Columns.Add("Ngày thuê", 150);
                LeTanRoomListListView.Columns.Add("Ngày trả", 150);
                LeTanRoomListListView.Columns.Add("Tình trang", width);
                LeTanRoomListListView.Columns.Add("Dọn dẹp", width);
            }

        }

        private void LeTanSearchBtn_Click(object sender, EventArgs e)
        {
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu yêu cầu đặt phòng (mã)")
            {
                if(LeTanRoomListView.Items.Count == 0)
                {
                    RoomBUS.checkRoomRequestInput(LeTanSearchInput.Text, LeTanRoomListView);
                }
                else
                {
                    // List view setting
                    const int width = 100;

                    LeTanRoomListView.Items.Clear(); // Clear all list view data
                    LeTanRoomListView.Columns.Clear();
                    LeTanRoomListView.View = View.Details; // To see add columns

                    LeTanRoomListView.Columns.Add("Mã yêu cầu", 100);
                    LeTanRoomListView.Columns.Add("Mã khách hàng", width);
                    LeTanRoomListView.Columns.Add("Ngày đến", 150);
                    LeTanRoomListView.Columns.Add("Số đêm lưu trú", width);
                    LeTanRoomListView.Columns.Add("Loại yêu cầu", width);
                    LeTanRoomListView.Columns.Add("Ngày yêu cầu", 150);
                    LeTanRoomListView.Columns.Add("Ngày ghi nhận", 150);

                    int checkRoomRequestInput = RoomBUS.checkRoomRequestInput(LeTanSearchInput.Text, LeTanRoomListView);

                    if (checkRoomRequestInput == 1) MessageBox.Show("Nhập mã yêu cầu đặt phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkRoomRequestInput == 2) MessageBox.Show("Không tìm thấy yêu cầu đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (LeTanRoomSearchingDropbox.Text == "Tra cứu quy định khách sạn")
            {
                if (LeTanRuleListView.Items.Count == 0)
                {
                    RuleBUS.checkRuleInput(LeTanRuleListView);
                }
                else
                {
                    LeTanRuleListView.Show();
                    LeTanRuleListView.BringToFront();

                    // List view setting
                    const int width = 100;

                    LeTanRuleListView.Items.Clear(); // Clear all list view data
                    LeTanRuleListView.Columns.Clear();
                    LeTanRuleListView.View = View.Details; // To see add columns

                    LeTanRuleListView.Columns.Add("Mã quy định", width);
                    LeTanRuleListView.Columns.Add("Nội dung", 200);

                    RuleBUS.checkRuleInput(LeTanRuleListView);
                }
                    
            }
            
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu danh sách đặt phòng (mã)")
            {
                if (LeTanRoomBookingListView.Items.Count == 0)
                {
                    RoomBUS.checkRoomBookingInput(LeTanSearchInput.Text, LeTanRoomBookingListView);
                }
                else
                {
                    LeTanRoomBookingListView.Show();
                    LeTanRoomBookingListView.BringToFront();

                    // List view setting
                    const int width = 100;

                    LeTanRoomBookingListView.Items.Clear(); // Clear all list view data
                    LeTanRoomBookingListView.Columns.Clear();
                    LeTanRoomBookingListView.View = View.Details; // To see add columns

                    LeTanRoomBookingListView.Columns.Add("Mã đặt phòng", 120);
                    LeTanRoomBookingListView.Columns.Add("Mã khách hàng", 120);
                    LeTanRoomBookingListView.Columns.Add("Ngày đặt", 150);
                    LeTanRoomBookingListView.Columns.Add("Loại phòng", width);
                    LeTanRoomBookingListView.Columns.Add("Ngày checkin", 150);
                    LeTanRoomBookingListView.Columns.Add("Ngày checkout", 150);
                    LeTanRoomBookingListView.Columns.Add("Mã phòng", width);

                    int checkRoomBookingInput = RoomBUS.checkRoomBookingInput(LeTanSearchInput.Text, LeTanRoomBookingListView);

                    if (checkRoomBookingInput == 1) MessageBox.Show("Nhập mã phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkRoomBookingInput == 2) MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (LeTanRoomSearchingDropbox.Text == "Tra cứu danh sách phòng (mã/loại)")
            {
                if (LeTanRoomListListView.Items.Count == 0)
                {
                    RoomBUS.checkRoomListInput(LeTanSearchInput.Text, LeTanRoomListListView);
                }
                else
                {
                    LeTanRoomListListView.Show();
                    LeTanRoomListListView.BringToFront();

                    // List view setting
                    const int width = 100;

                    LeTanRoomListListView.Items.Clear(); // Clear all list view data
                    LeTanRoomListListView.Columns.Clear();
                    LeTanRoomListListView.View = View.Details; // To see add columns

                    LeTanRoomListListView.Columns.Add("Mã phòng", width);
                    LeTanRoomListListView.Columns.Add("Loại phòng", 120);
                    LeTanRoomListListView.Columns.Add("Giá tiền", width);
                    LeTanRoomListListView.Columns.Add("Ngày thuê", 150);
                    LeTanRoomListListView.Columns.Add("Ngày trả", 150);
                    LeTanRoomListListView.Columns.Add("Tình trang", width);
                    LeTanRoomListListView.Columns.Add("Dọn dẹp", width);

                    int checkRoomListInput = RoomBUS.checkRoomListInput(LeTanSearchInput.Text, LeTanRoomListListView);
                    if (checkRoomListInput == 1) MessageBox.Show("Nhập mã phòng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkRoomListInput == 2) MessageBox.Show("Không tìm thấy danh sách phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkRoomListInput == 3) MessageBox.Show("Không tìm thấy danh sách phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LeTanSearchInput.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
            LeTanRoomBooking.Show();
            LeTanRoomBooking.BringToFront();
        }

        private void LeTanRoomRequestBtn_Click(object sender, EventArgs e)
        {
            leTanRoomRequest.Show();
            leTanRoomRequest.BringToFront();
        }

        private void LeTanGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LeTanRoomGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeTanRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void LeTanRoomBooking_Load(object sender, EventArgs e)
        {

        }

        private void viewRoomBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewKhachHangBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewRuleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
