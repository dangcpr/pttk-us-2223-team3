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
using System.Windows.Media.Animation;

namespace HotelSystem
{
    public partial class KhachHang_Overview : Form
    {
        public static string customerID = "";
        public KhachHang_Overview()
        {
            InitializeComponent();
        }

        private void Bellman_Overview_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            KhachHang_HomePage.BringToFront();
            BellmanCancel.BringToFront();
            name.Text = DAO.AccountDAO.overviewUsername;

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 213);
            KhachHang_HomePage.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 264);
            KhachHang_Feedback.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 315);
            KhachHang_SeeBooking.BringToFront();
            BellmanCancel.BringToFront();
            
        }

        private void BellmanCancel_Click(object sender, EventArgs e)
        {
            DAO.DatabaseDAO.sqlConn.Close();
            this.Close();
            Application.Exit();
        }        
        
        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void accountService_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();            
            this.Hide();
        }

        public void setCustomerID(string customerID1)
        {
            customerID = customerID1;
            KhachHang_SeeBooking.setCustomerID(customerID);
            KhachHang_Feedback.setCustomerID(customerID);
        }

    }
}
