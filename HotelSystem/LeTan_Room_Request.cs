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
    public partial class LeTan_Room_Request : UserControl
    {
        public LeTan_Room_Request()
        {
            InitializeComponent();
        }

        private void quitRequestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void resetRequestBookingInput()
        {
            LeTanRequestUsernameInput.Text = "";
            LeTanRequestPasswordInput.Text = "";
            LeTanRequestNameInput.Text = "";
            LeTanRequestAddressInput.Text = "";
            LeTanRequestCCCDInput.Text = "";
            LeTanRequestPhoneInput.Text = "";
            LeTanRequestDateStartInput.Text = DateTime.Today.ToString("yyyy-MM-dd");
            LeTanRequestDateRequestInput.Text = DateTime.Today.ToString("yyyy-MM-dd");
            LeTanRequestCountInput.Text = "";
            LeTanRequestDesInput.Text = "";
        }

        private void LeTanAddRequestBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmAddRoomRequest = MessageBox.Show("Bạn có chắc muốn thêm yêu cầu đặt phòng?.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (confirmAddRoomRequest == DialogResult.Yes)
            {
                int checkRoomRequestInput = RoomBUS.checkRoomRequestInput(LeTanRequestUsernameInput.Text, LeTanRequestPasswordInput.Text, LeTanRequestNameInput.Text, LeTanRequestAddressInput.Text, LeTanRequestCCCDInput.Text, LeTanRequestPhoneInput.Text, LeTanRequestDateStartInput.Value.ToString("yyyy-MM-dd"), LeTanRequestDateRequestInput.Value.ToString("yyyy-MM-dd"), LeTanRequestCountInput.Text, LeTanRequestDesInput.Text);

                if (checkRoomRequestInput == 1) MessageBox.Show("Nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkRoomRequestInput == 2) MessageBox.Show("Khách hàng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkRoomRequestInput == 3) MessageBox.Show("CCCD phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkRoomRequestInput == 4) MessageBox.Show("Số điện thoại phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkRoomRequestInput == 5) MessageBox.Show("Số đêm lưu trú phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkRoomRequestInput == 6) MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (checkRoomRequestInput == 0) MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resetRequestBookingInput();
            }
        }
    }
}
