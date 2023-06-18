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
            string status = "";
            string customerName = "";
            string roomType = "";
            SqlDataReader reader = null;
            RoomBUS.createCheckoutCard(ref status, ref customerName, ref roomType, ref reader, MaPhong);
            roomStatusTxb.Text = status;
            customerNameTxb.Text = customerName;
            roomTypeTxb.Text = roomType;
            if (reader is null || !reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MA_DICH_VU");
                dt.Rows.Add("Khách hàng không sử dụng dịch vụ");
                serviceDataGridView.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                serviceDataGridView.DataSource = dt;
                reader.Close();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void createInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (roomStatusTxb.Text == "" || customerNameTxb.Text == "" || roomTypeTxb.Text == "" || serviceDataGridView.DataSource is null)
            {
                MessageBox.Show("Vui lòng tải dữ liệu!");
            }
            else
            {
                leTan_Invoice.setTypeInvoice("checkout");
                leTan_Invoice.Show();
                leTan_Invoice.BringToFront();
                leTan_Invoice.setRoomID(MaPhong);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string status = "";
            string customerName = "";
            string roomType = "";
            SqlDataReader reader = null;
            RoomBUS.createCheckoutCard(ref status, ref customerName, ref roomType, ref reader, MaPhong);
            roomStatusTxb.Text = status;
            customerNameTxb.Text = customerName;
            roomTypeTxb.Text = roomType;
            if (reader is null || !reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MA_DICH_VU");
                dt.Rows.Add("Khách hàng không sử dụng dịch vụ");
                serviceDataGridView.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                serviceDataGridView.DataSource = dt;
            }
            reader.Close();
        }
    }
}
