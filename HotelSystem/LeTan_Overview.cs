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
using HotelSystem.DAO;

namespace HotelSystem
{
    public partial class LeTan_Overview : Form
    {

        public LeTan_Overview()
        {
            InitializeComponent();
        }

        private void LeTan_Overview_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LeTan_HomePage.BringToFront();
            BellmanCancel.BringToFront();

            // Get account username
            Console.WriteLine(AccountDAO.overviewUsername);
            leTanOverviewName.Text = AccountDAO.overviewUsername;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 213);
            LeTan_HomePage.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 264);
            LeTan_Service.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 315);
            LeTan_Room.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void RuleButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 366);
            //bellman_Rule1.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void BellmanCancel_Click(object sender, EventArgs e)
        {
            DatabaseDAO.sqlConn.Close();
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

        private void CheckinButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 366);
            LeTan_Checkin.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 417);
            LeTan_Checkout.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void TourDuLichButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 468);
            LeTan_Tour.BringToFront();
            BellmanCancel.BringToFront();
        }
    }
}
