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
    public partial class LeTan_Invoice_Search_Detail : UserControl
    {
        public static string MaHoaDon = "";
        public LeTan_Invoice_Search_Detail()
        {
            InitializeComponent();
        }

        public event EventHandler Exit;
        protected virtual void OnExit(EventArgs e)
        {
            EventHandler eh = Exit;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public void setInvoiceID(string invoiceID)
        {
            MaHoaDon = invoiceID;
        }

        private void LeTan_Invoice_Search_Detail_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = InvoiceBUS.viewInvoiceDetailByID(MaHoaDon);
            DataTable dt = new DataTable();
            dt.Load(reader);
            listInvoiceDetailsDataGridView.DataSource = dt;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            OnExit(null);
            this.Hide();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
