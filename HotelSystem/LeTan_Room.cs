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
            LeTanRoomBooking.Hide();
            LeTan_Room_Searching.Hide();
            LeTan_Customer_Searching.Hide();
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
                LeTanKHListView.Show();
                LeTanKHListView.BringToFront();

                // List view setting
                const int width = 100;

                LeTanKHListView.Items.Clear(); // Clear all list view data
                LeTanKHListView.Columns.Clear();
                LeTanKHListView.View = View.Details; // To see add columns

                LeTanKHListView.Columns.Add("Mã yêu cầu", 100);
                LeTanKHListView.Columns.Add("Mã khách hàng", width);
                LeTanKHListView.Columns.Add("Ngày đến", 150);
                LeTanKHListView.Columns.Add("Số đêm lưu trú", width);
                LeTanKHListView.Columns.Add("Loại yêu cầu", width);
                LeTanKHListView.Columns.Add("Ngày yêu cầu", 150);
                LeTanKHListView.Columns.Add("Ngày ghi nhận", 150);           
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
        }

        private void LeTanSearchBtn_Click(object sender, EventArgs e)
        {
            if (LeTanRoomSearchingDropbox.Text == "Tra cứu yêu cầu đặt phòng (mã)")
            {
                if(LeTanKHListView.Items.Count == 0)
                {
                    RoomBUS.checkRoomRequestInput(LeTanSearchInput.Text, LeTanKHListView);
                }
                else
                {
                    // List view setting
                    const int width = 100;

                    LeTanKHListView.Items.Clear(); // Clear all list view data
                    LeTanKHListView.Columns.Clear();
                    LeTanKHListView.View = View.Details; // To see add columns

                    LeTanKHListView.Columns.Add("Mã yêu cầu", 100);
                    LeTanKHListView.Columns.Add("Mã khách hàng", width);
                    LeTanKHListView.Columns.Add("Ngày đến", 150);
                    LeTanKHListView.Columns.Add("Số đêm lưu trú", width);
                    LeTanKHListView.Columns.Add("Loại yêu cầu", width);
                    LeTanKHListView.Columns.Add("Ngày yêu cầu", 150);
                    LeTanKHListView.Columns.Add("Ngày ghi nhận", 150);

                    RoomBUS.checkRoomRequestInput(LeTanSearchInput.Text, LeTanKHListView);
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

            LeTanSearchInput.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
            LeTanRoomBooking.Show();
            LeTanRoomBooking.BringToFront();
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
            LeTanRoomListView.Show();
            LeTanRoomListView.BringToFront();
        }

        private void viewKhachHangBtn_Click(object sender, EventArgs e)
        {
            LeTanKHListView.Show();
            LeTanKHListView.BringToFront();
        }

        private void viewRuleBtn_Click(object sender, EventArgs e)
        {
            LeTanRuleListView.Show();
            LeTanRuleListView.BringToFront();

            HotelRule hotelRule = new HotelRule();
            List<HotelRule> ruleList = hotelRule.getRulesList();
            //RuleDAO.viewAllRule(LeTanRuleListView, ruleList);
        }
    }
}
