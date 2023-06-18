using HotelSystem.BUS;
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
    public partial class LeTan_Service : UserControl
    {
        public LeTan_Service()
        {
            InitializeComponent();
            
        }

        private void LeTan_Service_Load(object sender, EventArgs e)
        {
            leTan_Service_Searching1.Hide();
            leTan_Service_Booking1.Hide();

            lvService.Items.Clear(); // Clear all list view data
            lvService.Columns.Clear();
            lvService.View = View.Details; // To see add columns

            lvService.Columns.Add("Mã dịch vụ", 80);
            lvService.Columns.Add("Tên dịch vụ", 100);
            lvService.Columns.Add("Loại", 80);
            lvService.Columns.Add("Loại phòng cho phép", 150);
            lvService.Columns.Add("Giá tiền", 80);
            lvService.Columns.Add("Mô tả", 150);
            lvService.Columns.Add("Tình trạng", 150);

            //ServiceBUS.loadData(lvService);
        }

        private void btnSearchDV_Click(object sender, EventArgs e)
        {
            leTan_Service_Searching1.Show();
            leTan_Service_Searching1.BringToFront();
        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            leTan_Service_Booking1.Show();
            leTan_Service_Booking1.BringToFront();
        }

        private void btnXemKM_Click(object sender, EventArgs e)
        {
            lvService.Items.Clear(); // Clear all list view data
            ServiceBUS.loadData(lvService);
        }

        private void xemlichdv_service_btn_Click(object sender, EventArgs e)
        {
            dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            DataTable dt = new DataTable();
            dt = ServiceBUS.getDanhSachDatLichDv();
            dataGridView3.DataSource = dt;
        }
    }
}
