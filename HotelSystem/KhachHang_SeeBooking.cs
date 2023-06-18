using HotelSystem.BUS;
using HotelSystem.CLASS;
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
    public partial class KhachHang_SeeBooking : UserControl
    {
        private static string customerID = "";
        public KhachHang_SeeBooking()
        {
            InitializeComponent();
        }
        public void setCustomerID(string customerID1)
        {
            customerID = customerID1;
        }

        private void KhachHang_SeeBooking_Load(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            int checkInput = RoomBUS.KHcheckRoomRequestInput(customerID);
            if (checkInput == -1)
            {
                MessageBox.Show("Nhập mã khách hàng tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkInput == -2)
            {
                MessageBox.Show("Không tìm thấy thông tin đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable result = RoomBUS.KHselectRoomRequest(customerID);
                infoBooking.DataSource = result;
            }
        }

        private void infoBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.infoBooking.Rows[e.RowIndex];
                int requestID = Int32.Parse(row.Cells[0].Value.ToString());
                int result = RoomBUS.KHcheckBookingDetailInput(requestID);
                if (result == -2)
                {
                    MessageBox.Show("Không tìm thấy chi tiết thông tin đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == -1)
                {
                    MessageBox.Show("Nhập mã đặt phòng tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == -3)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng chọn dòng dữ liệu hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable result1 = RoomBUS.KHselectBookingDetail(requestID);
                    infoBookingDetail.DataSource = result1;
                }
            }
        }
    }
}