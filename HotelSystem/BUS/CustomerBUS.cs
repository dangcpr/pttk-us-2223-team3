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
        public static int checkCustomerInfoInput(string value, ListView LeTanCustomerListView)
        {
            // 1: Thiếu mã khách hàng
            // 2: Không tìm thấy khách hàng

            if (value == "")
            {               
                return 1;
            }

            Boolean checkFindCustomer = CustomerDAO.viewCustomerById(value, LeTanCustomerListView);

            if (!checkFindCustomer)
            {               
                return 2;
            }

            return 0;
        }

        public static int checkCustomerGroupInfoInput(string value, ListView LeTanCustomerListView, ListView LeTanCustomerGroupListView)
        {
            // 1: Thiếu mã khách hàng
            // 2: Không tìm thấy khách hàng

            if (value == "")
            {              
                return 1;
            }

            Boolean checkFindCustomer = CustomerDAO.viewCustomerGroupById(value, LeTanCustomerListView, LeTanCustomerGroupListView);

            if (!checkFindCustomer)
            {               
                return 2;
            }

            return 0;
        }
    }
}
