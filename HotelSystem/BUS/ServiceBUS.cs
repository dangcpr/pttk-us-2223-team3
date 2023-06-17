using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    public class ServiceBUS
    {
        public static Boolean checkCustomerHasServicePaymentByRoomID(string RoomID)
        {
            Boolean check = true;
            string customerID = "";
            string customerName = "";
            RoomDAO.getCustomerByRoomID(RoomID, ref customerID, ref customerName);
            SqlDataReader reader = ServiceDAO.getListServicesPaymentByCustomerID(customerID);
            if (!reader.HasRows||reader is null)
            {
                reader.Close();
                check = false;
            }
            reader.Close();
            return check;
        }

        public static void changeStatusPaymentByInvoiceID(string InvoiceID)
        {
            ServiceDAO.updateStatusPaymentByInvoiceID(InvoiceID);
        }
    }
}
