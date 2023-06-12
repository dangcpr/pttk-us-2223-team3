using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    public partial class KhachHang_Feedback : UserControl
    {
        public static string customerID = "";
        public KhachHang_Feedback()
        {
            InitializeComponent();
        }
        public void setCustomerID(string customerID1)
        {
            customerID = customerID1;
            customerIDText.Text = customerID;
        }

        private void KhachHang_Feedback_Load(object sender, EventArgs e)
        {
            
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            int result = FeedbackBUS.checkFeedbackInput(customerIDText.Text, feedbackText.Text);
            if (result == -1)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -2)
            {
                MessageBox.Show("Vui lòng nhập Feedback", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(result == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                feedbackText.Text = "";
                MessageBox.Show("Feedback thành công. Xin cảm ơn quý khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void customerIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            KhachHang_Feedback_Update khachHang_Feedback_Update = new KhachHang_Feedback_Update();
            khachHang_Feedback_Update.Show();
            khachHang_Feedback_Update.setCustomerID(customerID);
        }
    }
}
