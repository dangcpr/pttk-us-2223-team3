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
    public partial class LeTan_Service_Booking : UserControl
    {
        public LeTan_Service_Booking()
        {
            InitializeComponent();
            resetAddBookingInput();
        }

        private void resetAddBookingInput()
        {
            tb_MKH.Text = "";
            cbLoaiDV.SelectedIndex = -1;
            DK_Date.Text = DateTime.Today.ToString("yyyy-MM-dd");
            cbThanhToan.SelectedIndex = -1;
            tbSoLuong.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bntAddDV_Click(object sender, EventArgs e)
        {
            DialogResult confirmAddRoomBooking = MessageBox.Show("Bạn có chắc muốn đăng ký dịch vụ?.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (confirmAddRoomBooking == DialogResult.Yes)
            {
                int result = ServiceBUS.CheckInput(tb_MKH.Text, cbLoaiDV.Text, DK_Date.Text, tbSoLuong.Text, cbThanhToan.Text);
                if (result == 1) MessageBox.Show("Nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == 2) MessageBox.Show("Ngày đặt phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == 0)
                {
                    int resultBooking = ServiceBUS.AddServiceBooking(tb_MKH.Text, cbLoaiDV.Text, DK_Date.Text, tbSoLuong.Text, cbThanhToan.Text);
                    if (resultBooking == 1)
                    {
                        MessageBox.Show("Khách hàng chưa đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (resultBooking == 2)
                    {
                        MessageBox.Show("Dịch vụ đã hết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (resultBooking == 3)
                    {
                        MessageBox.Show("Dịch vụ hông hỗ trợ phòng khách hàng đang ở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (resultBooking == 4)
                    {
                        MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            resetAddBookingInput();
        }

        private void LeTan_Service_Booking_Load(object sender, EventArgs e)
        {
        }

        private void cbLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
