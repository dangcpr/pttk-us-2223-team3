using HotelSystem.DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class SignInForm : Form
    {
        // Declair DAO class
        private DatabaseDAO databaseDAO = new DatabaseDAO();
        private SqlConnection sqlConn = null;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Sign in form loaded");

            // Get connect to database 
            this.sqlConn = databaseDAO.getConnectDB("Data Source=DESKTOP-DMLAI4E\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");          

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
            this.sqlConn.Open();

            // Check account from database
            AccountDAO accountDAO = new AccountDAO();
            bool checkAccount = accountDAO.checkAccount(this.sqlConn, username.Text, password.Text, role.Text);

            // Open Bellman account
            if (checkAccount && role.Text == "Bellman")
            {
                Bellman_Overview bellman_Overview = new Bellman_Overview();
                bellman_Overview.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            this.sqlConn.Close();

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
