using System;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class SignInForm : Form
    {

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void LabelSignIn_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (role.Text == "Bellman")
            {
                Bellman_Overview bellman_Overview = new Bellman_Overview();
                bellman_Overview.Show();
                this.Hide();
            }
        }

        private void SignInFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void forgotPass_Click(object sender, EventArgs e)
        {

        }
    }
}
