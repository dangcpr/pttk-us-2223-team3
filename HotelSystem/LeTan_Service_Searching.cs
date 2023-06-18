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
    public partial class LeTan_Service_Searching : UserControl
    {
        public LeTan_Service_Searching()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_DVSe_TraCuu_Click(object sender, EventArgs e)
        {
            lvDVSe.Items.Clear();
            int result = ServiceBUS.SearchDV(tb_DVSe_MKH.Text, lvDVSe);
            if (result == 1)
            {
                MessageBox.Show("Khách hàng chưa đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 2)
            {
                MessageBox.Show("Khách hàng chưa sử dụng dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LeTan_Service_Searching_Load(object sender, EventArgs e)
        {
            lvDVSe.Items.Clear(); // Clear all list view data
            lvDVSe.Columns.Clear();
            lvDVSe.View = View.Details; // To see add columns

            lvDVSe.Columns.Add("ID", 30);
            lvDVSe.Columns.Add("Mã khách hàng", 100);
            lvDVSe.Columns.Add("Mã dịch vụ", 100);
            lvDVSe.Columns.Add("Ngày đăng ký", 100);
            lvDVSe.Columns.Add("Số lượng", 80);
            lvDVSe.Columns.Add("Thành tiền", 100);
            lvDVSe.Columns.Add("Trạng  thái thanh toán", 120);
        }
    }
}
