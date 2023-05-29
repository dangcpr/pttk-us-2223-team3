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
    public partial class Bellman_Overview : Form
    {
        public Bellman_Overview()
        {
            InitializeComponent();
        }

        private void Bellman_Overview_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            bellman_HomePage1.BringToFront();
            BellmanCancel.BringToFront();
            name.Text = DAO.AccountDAO.overviewUsername;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 213);
            bellman_HomePage1.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 264);
            bellman_Service1.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 315);
            bellman_Room1.BringToFront();
            BellmanCancel.BringToFront();
        }

        private void RuleButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Location = new Point(0, 366);
            bellman_Rule1.BringToFront();
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


    }
}
