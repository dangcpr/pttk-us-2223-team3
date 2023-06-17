using HotelSystem.DAO;
using HotelSystem.CLASS;
using HotelSystem.BUS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace HotelSystem
{
    public partial class KhachHang_Feedback_Update : Form
    {
        //static public SqlConnection sqlConn = null;
        public static string customerID = "";
        public KhachHang_Feedback_Update()
        {
            InitializeComponent();
        }
        public void setCustomerID(string customerID1)
        {
            customerID = customerID1;
            DataTable result = FeedbackBUS.selectFeedback(customerID);
            feedbackTable.DataSource = result;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KhachHang_Feedback_Update_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void feedbackTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.feedbackTable.Rows[e.RowIndex];
                feedbackIDText.Text = row.Cells[0].Value.ToString();
                customerIDText.Text = row.Cells[1].Value.ToString();
                feedbackContent.Text = row.Cells[2].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int result = FeedbackBUS.checkUpdateFeedback(int.Parse(feedbackIDText.Text), customerIDText.Text, feedbackContent.Text);
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable result1 = FeedbackBUS.selectFeedback(customerID);
                feedbackTable.DataSource = result1;
            }
            else if (result == -1)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -2)
            {
                MessageBox.Show("Vui lòng nhập Feedback", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -3)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu Feedback", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
