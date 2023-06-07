using HotelSystem.BUS;
using HotelSystem.DAO;
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
    public partial class LeTan_Customer_Searching : UserControl
    {
        public LeTan_Customer_Searching()
        {
            InitializeComponent();
        }

        private void quitBookingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LeTanCustomerInfoBtn_Click(object sender, EventArgs e)
        {
            const int width = 100;

            if (LeTancustomerTypeComboBox.Text == "Khách hàng")
            {
                // List view setting
                LeTanCustomerMainListView.Items.Clear(); // Clear all list view data
                LeTanCustomerMainListView.Columns.Clear();
                LeTanCustomerMainListView.View = View.Details; // To see add columns  

                LeTanCustomerMainListView.Columns.Add("Mã khách hàng", width);
                LeTanCustomerMainListView.Columns.Add("Họ tên", 150);
                LeTanCustomerMainListView.Columns.Add("Địa chỉ", 150);
                LeTanCustomerMainListView.Columns.Add("CCCD", 150);
                LeTanCustomerMainListView.Columns.Add("SDT", 150);

                Boolean checkCustomerGroupInfoInput = CustomerBUS.checkCustomerInfoInput(LeTanCustomerInfoInput.Text, LeTanCustomerMainListView);
            }
            if (LeTancustomerTypeComboBox.Text == "Khách đoàn")
            {
                // List view setting             
                LeTanCustomerGroupListView.Items.Clear(); // Clear all list view data
                LeTanCustomerGroupListView.Columns.Clear();
                LeTanCustomerGroupListView.View = View.Details; // To see add columns

                LeTanCustomerMainListView.Items.Clear(); // Clear all list view data
                LeTanCustomerMainListView.Columns.Clear();
                LeTanCustomerMainListView.View = View.Details; // To see add columns           

                LeTanCustomerGroupListView.Columns.Add("Mã đoàn", 80);
                LeTanCustomerGroupListView.Columns.Add("Tên đoàn", 150);
                LeTanCustomerGroupListView.Columns.Add("Số FAX", 120);
                LeTanCustomerGroupListView.Columns.Add("Số lượng", width);

                LeTanCustomerMainListView.Columns.Add("Mã khách hàng", width);
                LeTanCustomerMainListView.Columns.Add("Mã đoàn", 80);
                LeTanCustomerMainListView.Columns.Add("Họ tên", 150);
                LeTanCustomerMainListView.Columns.Add("Địa chỉ", 150);
                LeTanCustomerMainListView.Columns.Add("CCCD", 150);
                LeTanCustomerMainListView.Columns.Add("SDT", 150);

                Boolean checkCustomerGroupInfoInput = CustomerBUS.checkCustomerGroupInfoInput(LeTanCustomerInfoInput.Text, LeTanCustomerGroupListView, LeTanCustomerMainListView);
            }
            
            LeTanCustomerInfoInput.Text = "";
        }

        private void addRoomBookingBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void LeTan_Room_Booking_Load(object sender, EventArgs e)
        {

        }

        private void roomId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LeTanCustomerInfoInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
