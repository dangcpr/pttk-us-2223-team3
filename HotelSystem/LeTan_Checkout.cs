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
using HotelSystem.BUS;

namespace HotelSystem
{
    public partial class LeTan_Checkout : UserControl
    {
        LeTan_Checkout_Card leTan_Checkout_Card = new LeTan_Checkout_Card();
        LeTan_Checkout_Driver leTan_Checkout_Driver = new LeTan_Checkout_Driver();
        LeTan_Invoice_Search leTan_Invoice_Search = new LeTan_Invoice_Search();
        public LeTan_Checkout()
        {
            InitializeComponent();
            
            this.Controls.Add(leTan_Checkout_Card);
            this.Controls.Add(leTan_Checkout_Driver);
            this.Controls.Add(leTan_Invoice_Search);
            leTan_Checkout_Card.Hide();
            leTan_Checkout_Driver.Hide();
            leTan_Invoice_Search.Hide();
        }

        private void createCheckoutCardBtn_Click(object sender, EventArgs e)
        {
            if (roomDataGridView.CurrentRow.Selected)
            {
                string MaPhong = roomDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (RoomBUS.checkRoomStatusCheckout(MaPhong) == true)
                {
                    leTan_Checkout_Card.setRoomID(MaPhong);
                    leTan_Checkout_Card.Show();
                    leTan_Checkout_Card.BringToFront();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng có tình trạng 'Hết' để checkout!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 phòng cần checkout!");
            }
        }

        private void showDriverBtn_Click(object sender, EventArgs e)
        {
            leTan_Checkout_Driver.Show();
            leTan_Checkout_Driver.BringToFront();
        }

        private void showInvoiceBtn_Click(object sender, EventArgs e)
        {
            leTan_Invoice_Search.Show();
            leTan_Invoice_Search.BringToFront();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.OnLoad(null);
        }

        private void LeTan_Checkout_Load(object sender, EventArgs e)
        {
            SqlDataReader listRoom = RoomBUS.viewListRoom();
            DataTable dt = new DataTable();
            dt.Load(listRoom);
            roomDataGridView.DataSource = dt;
        }
    }
}
