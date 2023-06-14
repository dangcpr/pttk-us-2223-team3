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
using HotelSystem.DAO;
using HotelSystem.BUS;

namespace HotelSystem
{
    public partial class LeTan_Checkin : UserControl
    {
        public LeTan_Checkin()
        {
            InitializeComponent();
        }

        private void getAllInformation(String makh)
        {
            List<String> list = new List<String>();
            list = CheckinBUS.getThongTinDatPhongByMadp(makh);

            madp_checkin_txt.Text = list[0];
            makh_checkin_txt.Text = list[1];
            ngaydat_checkin_txt.Text = list[2];
            loaiphong_checkin_txt.Text = list[3];
            ngaycheckin_checkin_txt.Text = list[4];
            ngaycheckout_checkin_txt.Text = list[5];
            
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void ghichu_checkin_Click(object sender, EventArgs e)
        {

        }

        private void hoanthanh_checkin_btn_Click(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            list.Add(makh_checkin_txt.Text);
            list.Add(cccd_checkin_txt.Text);
            list.Add(ngaycheckin_checkin_txt.Text);
            list.Add(ghichu_checkin_txt.Text);

            if ((ngaycheckin_checkin_txt.Text == "") || (cccd_checkin_txt.Text == "") || (makh_checkin_txt.Text == ""))
            {
                MessageBox.Show("Không để thông tin trống");
            }
            else
            {

                CheckinBUS.saveDataCheckin(list);
                
            } 
             
        }

        private void check_checkin_btn_Click(object sender, EventArgs e)
        {
            string madp = madp_checkin_txt.Text;

            bool check = CheckinBUS.checkMadp(madp);

            if (check == false)
            {
                MessageBox.Show("Thông tin khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                getAllInformation(madp);
            }
   
        }
    }
}
