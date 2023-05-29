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
        public static Boolean checkCustomerInit(string checkCustomerInit, int checkInput)
        {
            if (checkCustomerInit == "None")
            {
                MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (checkInput != 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (checkInput == 0 && checkCustomerInit != "None")
                {
                    return true;
                }
            }

            return true;
        }
    }
}
