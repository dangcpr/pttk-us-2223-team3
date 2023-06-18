using Guna.UI2.WinForms;
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
    public class CheckinBUS
    {
        internal static int InsertPDK(string customerId, string CCCD)
        {
            if(customerId == "")
            {
                return 1;
            }
            else if (CCCD == "")
            {
                return 2;
            }
            int check = CheckinDAO.insertPDK1(customerId, CCCD);

            if (check == 1)
            {
                return 1;
            }
            else if (check == 2){
                return 2;
            }
            else
            {
                return 0;
            }
        }

        internal static void loadData(ListView lvPDK)
        {
            CheckinDAO.LoadlvData(lvPDK);
        }

        internal static int SelectKM(string makh, ListView lvKM)
        {
            if(makh == "")
            {
                return 1;
            }

            int result = CheckinDAO.SelectKM1(makh, lvKM);
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
    }
}
