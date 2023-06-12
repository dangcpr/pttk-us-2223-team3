using HotelSystem.DAO;
using HotelSystem.CLASS;
using HotelSystem.BUS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class SignInForm : Form
    {
        //static public SqlConnection sqlConn = null;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Sign in form loaded");

            // Get connect to database 
            DatabaseDAO.sqlConn = DatabaseDAO.getConnectDB();

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
            Account signinAccount = new Account(username.Text, password.Text, role.Text);
            Boolean checkAcountBUS = AccountBUS.checkSigninInput(signinAccount.username, signinAccount.password, signinAccount.role);

            if(checkAcountBUS)
            {
                // Check account from database
                AccountDAO accountDAO = new AccountDAO();
                bool checkAccount = accountDAO.checkAccount(DatabaseDAO.sqlConn, username.Text, password.Text, role.Text);

                // Open Bellman account
                if (checkAccount && role.Text == "Bellman")
                {
                    Bellman_Overview bellman_Overview = new Bellman_Overview();
                    bellman_Overview.Show();
                    this.Hide();
                }
                // Open Lễ tân account
                else if (checkAccount && role.Text == "Lễ tân")
                {
                    LeTan_Overview LeTan_Overview = new LeTan_Overview();
                    LeTan_Overview.Show();
                    this.Hide();
                }
                else if (checkAccount && role.Text == "Khách hàng")
                {
                    KhachHang_Overview KhachHang_Overview = new KhachHang_Overview();
                    KhachHang_Overview.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private void SignInFormCancel_Click(object sender, EventArgs e)
        {
            DatabaseDAO.sqlConn.Close();
            this.Close();
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void forgotPass_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
