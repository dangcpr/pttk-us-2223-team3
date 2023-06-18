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
    public partial class LeTan_Checkin : UserControl
    {
        public LeTan_Checkin()
        {
            InitializeComponent();
        }

        private void btnAddPYC_Click(object sender, EventArgs e)
        {
            leTan_Checkin_PDK.Show();
            leTan_Checkin_PDK.BringToFront();
        }

        private void leTan_Checkin_PDK_Load(object sender, EventArgs e)
        {
            leTan_Checkin_PDK.Hide();
            leTan_Checkin_KM1.Hide();
        }

        private void btn_KM_Click(object sender, EventArgs e)
        {
            leTan_Checkin_KM1.Show();
            leTan_Checkin_KM1.BringToFront();
        }
    }
}
