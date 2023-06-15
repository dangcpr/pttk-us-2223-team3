using HotelSystem.BUS;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSystem
{
    public partial class LeTan_Checkout_Card : UserControl
    {
        LeTan_Invoice leTan_Invoice = new LeTan_Invoice();
        public static string MaPhong = "";
        public LeTan_Checkout_Card()
        {
            InitializeComponent();
            this.Controls.Add(leTan_Invoice);
            leTan_Invoice.Hide();
            leTan_Invoice.Finish += new EventHandler(leTan_Invoice_Finish);
        }

        //event giúp trở về màn hình checkout chính khi leTan_Invoice hoàn thành
        void leTan_Invoice_Finish(object sender, EventArgs e)
        {
            LeTan_Invoice leTan_Invoice = sender as LeTan_Invoice;
            if (leTan_Invoice != null)
            {
                this.Hide();
            }
        }

        public void setRoomID(string roomID)
        {
            MaPhong = roomID;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LeTan_Checkout_Card_Load(object sender, EventArgs e)
        {
            
            string status = "";
            string customerName = "";
            string roomType = "";
            SqlDataReader reader = null;
            RoomBUS.createCheckoutCard(ref status, ref customerName, ref roomType, ref reader, MaPhong);
            roomStatusTxb.Text = status;
            customerNameTxb.Text = customerName;
            roomTypeTxb.Text = roomType;
            DataTable dt = new DataTable();
            dt.Load(reader);
            serviceDataGridView.DataSource = dt;
        }

        private void createInvoiceBtn_Click(object sender, EventArgs e)
        {
            leTan_Invoice.setRoomID(MaPhong);
            leTan_Invoice.setTypeInvoice("checkout");
            leTan_Invoice.Show();
            leTan_Invoice.BringToFront();
        }

    }
}
