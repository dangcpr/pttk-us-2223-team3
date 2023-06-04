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
                Boolean checkRoomRequestInput = RoomBUS.checkRoomRequestInput(LeTanRequestUsernameInput.Text, LeTanRequestPasswordInput.Text, LeTanRequestNameInput.Text, LeTanRequestAddressInput.Text, LeTanRequestCCCDInput.Text, LeTanRequestPhoneInput.Text, LeTanRequestDateStartInput.Value.ToString("yyyy-MM-dd"), LeTanRequestDateRequestInput.Value.ToString("yyyy-MM-dd"), LeTanRequestCountInput.Text, LeTanRequestDesInput.Text);

                resetRequestBookingInput();
            }
        }
    }
}
