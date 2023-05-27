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
        private SqlConnection sqlConn = null;

        public LeTan_Room()
        {
            InitializeComponent();
        }

        private void LeTan_Room_Load(object sender, EventArgs e)
        {
            LeTanRoomListView.Hide();
            LeTanKHListView.Hide();
            LeTanRuleListView.Hide();
        }

        private void viewRoomBtn_Click(object sender, EventArgs e)
        {
            LeTanRoomListView.Show();
            LeTanRoomListView.BringToFront();
            RoomDAO.viewAllRoom(LeTanRoomListView, sqlConn);
        }

        private void viewKhachHangBtn_Click(object sender, EventArgs e)
        {
            LeTanKHListView.Show();
            LeTanKHListView.BringToFront();
            CustomerDAO.viewAllCustomer(LeTanKHListView, sqlConn);
        }

        private void viewRuleBtn_Click(object sender, EventArgs e)
        {
            LeTanRuleListView.Show();
            LeTanRuleListView.BringToFront();

            HotelRule hotelRule = new HotelRule();
            List<HotelRule> ruleList = hotelRule.getRulesList();
            RuleDAO.viewAllRule(LeTanRuleListView, ruleList);
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
    }
}
