using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace HotelSystem.BUS
{
    public class KhachDoanBUS
    {
        public static List<string> selectKhachHang()
        {
            return KhachDoanDAO.selectKhachHang();
        }
        public static int checkInput(string maDoan, string password, string tenDoan, string soFax, string soLuong, string leader, List<String> customers)
        {
            if (maDoan == "" || password == "" || tenDoan == "" || soFax == "" || soLuong == "" || leader == "" || customers.Count == 0)
            {
                return 2;
            }
            else if (!int.TryParse(soFax, out int n) || (int.TryParse(soFax, out int k) && k == 0))
            {
                return 3;
            }
            else if (!int.TryParse(soLuong, out int m))
            {
                return 4;
            }
            else if (customers.Count != m)
            {
                return 5;
            }
            else
            {
                return KhachDoanDAO.ThemKhachDoan(maDoan, password, tenDoan, soFax, soLuong, leader, customers);
            }
        }
    }
}
