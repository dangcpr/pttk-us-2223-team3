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
    public partial class LeTan_Checkin_PDK : UserControl
    {
        public LeTan_Checkin_PDK()
        {
            InitializeComponent();
        }

        private void bntAddPDK_Click(object sender, EventArgs e)
        {
            int check = CheckinBUS.InsertPDK(customerId.Text, CCCD.Text);

            if (check == 1)
            {
                MessageBox.Show("Không tồn tại Mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (check == 2)
            {
                MessageBox.Show("Căn cước công dân không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (check == 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvPDK.Items.Clear(); // Clear all list view data
                CheckinBUS.loadData(lvPDK);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LeTan_Checkin_PDK_Load(object sender, EventArgs e)
        {
            lvPDK.Items.Clear(); // Clear all list view data
            lvPDK.Columns.Clear();
            lvPDK.View = View.Details; // To see add columns

            lvPDK.Columns.Add("Mã phiếu", 100);
            lvPDK.Columns.Add("Mã khách hàng", 100);
            lvPDK.Columns.Add("Căn cước công dân", 150);
            
        }

        private void btnXemND_Click(object sender, EventArgs e)
        {
            lvPDK.Items.Clear();
            CheckinBUS.loadData(lvPDK);
        }
    }
}
