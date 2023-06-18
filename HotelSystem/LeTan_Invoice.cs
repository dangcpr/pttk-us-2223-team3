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

namespace HotelSystem
{
    public partial class LeTan_Invoice : UserControl
    {
        public static string MaPhong = "";
        public static string LoaiHoaDon = "";
        public static string MaHoaDon = "";
        public LeTan_Invoice()
        {
            InitializeComponent();
        }

        //event kích hoạt khi click nút Hoàn thành thì trở về màn hình chính
        public event EventHandler Finish;
        protected virtual void OnFinish(EventArgs e)
        {
            EventHandler eh = Finish;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public void setRoomID(string roomID)
        {
            MaPhong = roomID;
            MaHoaDon = InvoiceBUS.createInvoice(MaPhong, LoaiHoaDon);
            roomIDTxb.Text = MaPhong;
            SqlDataReader readerInvoiceDetail = InvoiceBUS.viewInvoiceDetailByID(MaHoaDon);
            if (readerInvoiceDetail.HasRows || readerInvoiceDetail is null)
            {
                DataTable dtInvoiceDetail = new DataTable();
                dtInvoiceDetail.Load(readerInvoiceDetail);
                invoiceDetailDataGridView.DataSource = dtInvoiceDetail;
            }
            else
            {
                DataTable dtInvoiceDetail = new DataTable();
                dtInvoiceDetail.Columns.Add("MA_HOA_DON");
                dtInvoiceDetail.Rows.Add("Không có dịch vụ cần thanh toán");
                invoiceDetailDataGridView.DataSource = dtInvoiceDetail;
            }
            readerInvoiceDetail.Close();
            SqlDataReader readerInvoice = InvoiceBUS.viewInvoiceByID(MaHoaDon);
            DataTable dtInvoice = new DataTable();
            dtInvoice.Load(readerInvoice);
            invoiceDataGridView.DataSource = dtInvoice;
            readerInvoice.Close();
        }

        public void setTypeInvoice(string typeInvoice)
        {
            LoaiHoaDon = typeInvoice;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (invoiceDetailDataGridView.DataSource is null || invoiceDataGridView.DataSource is null)
            {
                MessageBox.Show("Vui lòng tải dữ liệu!");
            }
            else
            {
                if (InvoiceBUS.checkInvoiceExists(MaHoaDon, null, null))
                {
                    InvoiceBUS.changeStatusPayment(MaHoaDon);
                    ServiceBUS.changeStatusPaymentByInvoiceID(MaHoaDon);
                }
                RoomBUS.changeRoomStatus(MaPhong);
                MessageBox.Show("Checkout thành công!");
                OnFinish(null);
                this.Hide();
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            MaHoaDon = InvoiceBUS.createInvoice(MaPhong, LoaiHoaDon);
            roomIDTxb.Text = MaPhong;
            SqlDataReader readerInvoiceDetail = InvoiceBUS.viewInvoiceDetailByID(MaHoaDon);
            if (!readerInvoiceDetail.HasRows || readerInvoiceDetail is null)
            {
                DataTable dtInvoiceDetail = new DataTable();
                dtInvoiceDetail.Load(readerInvoiceDetail);
                invoiceDetailDataGridView.DataSource = dtInvoiceDetail;
            }
            else
            {
                DataTable dtInvoiceDetail = new DataTable();
                dtInvoiceDetail.Columns.Add("MA_HOA_DON");
                dtInvoiceDetail.Rows.Add("Không có dịch vụ cần thanh toán");
                invoiceDetailDataGridView.DataSource = dtInvoiceDetail;
            }
            readerInvoiceDetail.Close();
            SqlDataReader readerInvoice = InvoiceBUS.viewInvoiceByID(MaHoaDon);
            DataTable dtInvoice = new DataTable();
            dtInvoice.Load(readerInvoice);
            invoiceDataGridView.DataSource = dtInvoice;
            readerInvoice.Close();
        }
    }
}