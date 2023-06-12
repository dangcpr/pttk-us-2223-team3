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
            Boolean checkInput = RoomBUS.KHcheckRoomRequestInput(customerID, infoBooking);
        }

        private void infoBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.infoBooking.Rows[e.RowIndex];
                int requestID = Int32.Parse(row.Cells[0].Value.ToString());
                Boolean result = RoomBUS.KHcheckBookingDetailInput(requestID, infoBookingDetail);
            }
        }
    }
}
