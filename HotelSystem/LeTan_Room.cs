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
        }

        private void viewRoomBtn_Click(object sender, EventArgs e)
        {
            LeTanRoomListView.Show();
            LeTanRoomListView.BringToFront();
            RoomDAO.viewAllRoom(LeTanRoomListView, sqlConn);
        }

        private void LeTanGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LeTanRoomGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
