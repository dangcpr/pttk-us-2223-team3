using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    internal class CustomerBUS
    {       
        public static Boolean checkCustomerInfoInput(string value, ListView LeTanCustomerListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã khách hàng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindCustomer = CustomerDAO.viewCustomerById(value, LeTanCustomerListView);

            if (!checkFindCustomer)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public static Boolean checkCustomerGroupInfoInput(string value, ListView LeTanCustomerListView, ListView LeTanCustomerGroupListView)
        {
            if (value == "")
            {
                MessageBox.Show("Nhập mã khách hàng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Boolean checkFindCustomer = CustomerDAO.viewCustomerGroupById(value, LeTanCustomerListView, LeTanCustomerGroupListView);

            if (!checkFindCustomer)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

    }
}
