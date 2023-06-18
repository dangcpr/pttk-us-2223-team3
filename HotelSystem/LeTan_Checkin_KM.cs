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
    public partial class LeTan_Checkin_KM : UserControl
    {
        public LeTan_Checkin_KM()
        {
            InitializeComponent();
        }

        private void LeTan_Checkin_KM_Load(object sender, EventArgs e)
        {
            lvKM.Items.Clear(); // Clear all list view data
            lvKM.Columns.Clear();
            lvKM.View = View.Details; // To see add columns

            lvKM.Columns.Add("Mã khách hàng", 100);
            lvKM.Columns.Add("Mã khuyến mãi", 100);
            lvKM.Columns.Add("Nội dung", 330);
            lvKM.Columns.Add("Ngày bắt đầu", 130);
            lvKM.Columns.Add("Ngày kết thúc", 130);
        }

        private void btn_KM_TraCuu_Click(object sender, EventArgs e)
        {
            int result = CheckinBUS.SelectKM(tb_KM_MKH.Text, lvKM);
            if (result == 1)
            {
                MessageBox.Show("Khách hàng chưa đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 2)
            {
                MessageBox.Show("Khách hàng không có khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
