using HotelSystem.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HotelSystem
{
    public partial class LeTan_Room_KhachDoan : UserControl
    {
        public LeTan_Room_KhachDoan()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addKhachDoanBtn_Click(object sender, EventArgs e)
        {
            List<String> customers = new List<String>();
            foreach (String item in listCustomer.CheckedItems)
            {
                customers.Add(item);
            }
            int result = KhachDoanBUS.checkInput(doanId.Text, password.Text, doanName.Text, numberFax.Text, numberCustomer.Text, leader.Text, customers);
            if (result == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra, có thể là mã đoàn đã tồn tại, người dẫn đoàn chưa đăng ký thông tin hoặc lỗi kết nối");
            }
            else if (result == 1)
            {
                MessageBox.Show("Thêm thông tin thành công");
            }
            else if (result == 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (result == 3)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ");
            }
            else if (result == 4)
            {
                MessageBox.Show("Vui lòng nhập số đêm lưu trú hợp lệ");
            }
            else if (result == 5)
            {
                MessageBox.Show("Vui lòng chọn đúng số lượng khách đã nhập");
            }
        }

        private void selectListCustomerBtn_Click(object sender, EventArgs e)
        {
            List<string> selectKhachHang = KhachDoanBUS.selectKhachHang();
            if (selectKhachHang.Count == 0)
            {
                MessageBox.Show("Không có khách hàng nào trong danh sách");
            }
            else
            {
                listCustomer.Items.Clear();
                foreach (string item in selectKhachHang)
                {
                    listCustomer.Items.Add(item);
                }
            }
        }
    }
}
