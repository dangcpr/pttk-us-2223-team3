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
    public partial class LeTan_Invoice_Search : UserControl
    {
        LeTan_Invoice_Search_Detail leTan_Invoice_Search_Detail = new LeTan_Invoice_Search_Detail();
        public LeTan_Invoice_Search()
        {
            InitializeComponent();
            this.Controls.Add(leTan_Invoice_Search_Detail);
            leTan_Invoice_Search_Detail.Hide();
            leTan_Invoice_Search_Detail.Exit += new EventHandler(leTan_Invoice_Search_Detail_Exit);
        }

        void leTan_Invoice_Search_Detail_Exit(object sender, EventArgs e)
        {
            LeTan_Invoice_Search_Detail leTan_Invoice_Search_Detail = sender as LeTan_Invoice_Search_Detail;
            if (leTan_Invoice_Search_Detail != null)
            {
                this.Hide();
            }
        }

        private void LeTan_Invoice_Search_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = InvoiceBUS.viewListInvoices();
            DataTable dt = new DataTable();
            dt.Load(reader);
            listInvoicesDataGridView.DataSource = dt;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchByInvoiceIDBtn_Click(object sender, EventArgs e)
        {
            if (InvoiceBUS.checkInvoiceExists(invoiceIDTxb.Text,null,null))
            {
                SqlDataReader reader = InvoiceBUS.viewInvoiceByID(invoiceIDTxb.Text);
                DataTable dt = new DataTable();
                dt.Load(reader);
                listInvoicesDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!");
            }
        }

        private void searchByCustomerIDBtn_Click(object sender, EventArgs e)
        {
            if (InvoiceBUS.checkInvoiceExists(null, customerIDTxb.Text, null))
            {
                SqlDataReader reader = InvoiceBUS.viewInvoiceByCustomerID(customerIDTxb.Text);
                DataTable dt = new DataTable();
                dt.Load(reader);
                listInvoicesDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Mã khách hàng không tồn tại hoặc không có hóa đơn!");
            }
        }

        private void searchByInvoiceDateBtn_Click(object sender, EventArgs e)
        {
            string NgayXuat = invoiceDatePicker.Value.ToString("yyyy-MM-dd");
            if (InvoiceBUS.checkInvoiceExists(null, null, NgayXuat))
            {
                SqlDataReader reader = InvoiceBUS.viewInvoiceByInvoiceDate(NgayXuat);
                DataTable dt = new DataTable();
                dt.Load(reader);
                listInvoicesDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có hóa đơn trong ngày được chọn!");
            }
        }

        private void showDetailBtn_Click(object sender, EventArgs e)
        {
            if (listInvoicesDataGridView.CurrentRow.Selected)
            {
                string MaHoaDon = listInvoicesDataGridView.CurrentRow.Cells[0].Value.ToString();
                leTan_Invoice_Search_Detail.setInvoiceID(MaHoaDon);
                leTan_Invoice_Search_Detail.Show();
                leTan_Invoice_Search_Detail.BringToFront();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem chi tiết!");
            }
        }

    }
}
