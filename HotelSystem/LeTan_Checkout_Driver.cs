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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSystem
{
    public partial class LeTan_Checkout_Driver : UserControl
    {
        public LeTan_Checkout_Driver()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LeTan_Checkout_Driver_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DriverBUS.viewListDrivers();
            DataTable dt = new DataTable();
            dt.Load(reader);
            driverDataGridView.DataSource = dt;
        }

        private void searchDriverBtn_Click(object sender, EventArgs e)
        {  
            if (DriverBUS.checkDriverExists(driverIDTxb.Text))
            {
                SqlDataReader reader = DriverBUS.viewDriverByID(driverIDTxb.Text);
                DataTable dt = new DataTable();
                dt.Load(reader);
                driverDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tài xế không tồn tại!");
            }
        }
    }
}
