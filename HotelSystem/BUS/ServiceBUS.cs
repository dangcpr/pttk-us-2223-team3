using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    class ServiceBUS
    {
        internal static void loadData(ListView lvService)
        {
            ServiceDAO.loadlvData(lvService);
        }

        internal static int SearchDV(string makh, ListView lvDVSe)
        {
            if (makh == "")
            {
                return 1;
            }

            int result = ServiceDAO.SearchDV1(makh, lvDVSe);
            if (result == 1)
            {
                return 1;
            }
            else if (result == 2)
            {
                return 2;
            }
            return 0;
        }

        internal static int CheckInput(string makh, string loaidv, string ngaydk, string soluong, string thanhtoan)
        {
            DateTime dDate;

            if (makh == "" || loaidv == "" || ngaydk == "" || soluong == "" || thanhtoan == "" )
            {
                return 1;
            }
            else if (!DateTime.TryParse(ngaydk, out dDate))
            {
                return 2;
            }
            return 0;
        }

        internal static int AddServiceBooking(string makh, string loaidv, string ngaydk, string soluong, string thanhtoan)
        {

            int check = ServiceDAO.CheckServiceBooking(makh, loaidv);
            if (check == 1)
            {
                return 1;
            }
            else if (check == 2)
            {
                return 2;
            }
            else if (check == 3)
            {
                return 3;
            }
            int result = ServiceDAO.AddServiceBooking1(makh, loaidv, ngaydk, soluong, thanhtoan);
            if (result == 4)
            {
                return 4;
            }
            return 0;
        }
    }
}
