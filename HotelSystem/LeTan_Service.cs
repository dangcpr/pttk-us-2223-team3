using HotelSystem.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void xemlichdv_service_btn_Click(object sender, EventArgs e)
        {
            dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            DataTable dt = new DataTable();
            dt = ServiceBUS.getDanhSachDatLichDv();
            dataGridView3.DataSource = dt;
        }
    }
}
