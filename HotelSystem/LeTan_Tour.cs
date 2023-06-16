using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.BUS;

namespace HotelSystem
{
    public partial class LeTan_Tour : UserControl
    {
        public LeTan_Tour()
        {
            InitializeComponent();
        }

        private void hoanthanh_tour_btn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(makh_tour_txt.Text);
            list.Add(madvlh_tour_txt.Text);
            if ((makh_tour.Text == "") || (madvlh_tour_txt.Text == ""))
            {
                MessageBox.Show("Không để thông tin trống");
            }
            else
            {
                bool check = DangKyTourBUS.saveDataDatTour(list, dateTimePicker1.Value);

                if (check)
                {
                    MessageBox.Show("Thêm dữ liệu vào Thông Tin Đặt Tour thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu vào Thông Tin Đặt Tour bị lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void xemtour_tour_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            DataTable dt = new DataTable();
            dt = DangKyTourBUS.getTourDuLich();
            dataGridView1.DataSource = dt;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            DataTable dt = new DataTable();
            dt = DangKyTourBUS.getDoiTacDuLich();
            dataGridView2.DataSource = dt;
        }
    }
}
