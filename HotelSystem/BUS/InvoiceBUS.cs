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
    public class InvoiceBUS
    {

        public static float caculateRoomChargeCheckout(string MaPhong)
        {
            float roomCharge = 0;
            roomCharge = (70 * RoomDAO.getRoomPrice(MaPhong))/100;
            return roomCharge;
        }

        public static float caculateToTalPaymentCheckout(string MaPhong, string MaKH)
        {
            float TongTien = 0;
            TongTien += ServiceDAO.getTotalPaymentByCustomerID(MaKH);
            
            TongTien += caculateRoomChargeCheckout(MaPhong);
            return TongTien;
        }

        public static string createInvoice(string MaPhong, string typeInvoice)
        {
            string CustomerID = "";
            string CustomerName = "";
            string MaHoaDon = InvoiceDAO.getNewInvoiceID();
            if (MaHoaDon is null||MaHoaDon == "")
                MaHoaDon = "1";
            if (typeInvoice == "checkout")
            {
                RoomDAO.getCustomerByRoomID(MaPhong, ref CustomerID, ref CustomerName);
                InvoiceDAO.addInvoiceAndDetail(MaHoaDon, CustomerID, caculateRoomChargeCheckout(MaPhong), caculateToTalPaymentCheckout(MaPhong, CustomerID));
            }
            return MaHoaDon;
        }
        
        public static Boolean checkInvoiceExists(string MaHoaDon, string MaKH, string NgayXuat)
        {
            Boolean isExists = true;
            if (!(MaHoaDon is null))
            {
                SqlDataReader reader = InvoiceDAO.getInvoiceByID(MaHoaDon);
                if (!reader.HasRows || reader is null)
                {
                    reader.Close();
                    isExists = false;
                }
                reader.Close();
            }
            else if (!(MaKH is null))
            {
                SqlDataReader reader = InvoiceDAO.getInvoiceByCustomerID(MaKH);
                if (!reader.HasRows || reader is null)
                {
                    reader.Close();
                    isExists = false;
                }
                reader.Close();
            }
            else if (!(NgayXuat is null))
            {
                SqlDataReader reader = InvoiceDAO.getInvoiceByInvoiceDate(NgayXuat);
                if (!reader.HasRows || reader is null)
                {
                    reader.Close();
                    isExists = false;
                }
                reader.Close();
            }
            else
                isExists = false;

            return isExists;
        }

        public static SqlDataReader viewInvoiceByID(string MaHoaDon)
        {
            SqlDataReader reader = InvoiceDAO.getInvoiceByID(MaHoaDon);
            return reader;
        }

        public static SqlDataReader viewInvoiceByCustomerID(string MaKH)
        {
            SqlDataReader reader = InvoiceDAO.getInvoiceByCustomerID(MaKH);
            return reader;
        }

        public static SqlDataReader viewInvoiceByInvoiceDate(string NgayXuat)
        {
            SqlDataReader reader = InvoiceDAO.getInvoiceByInvoiceDate(NgayXuat);
            return reader;
        }

        public static SqlDataReader viewInvoiceDetailByID(string MaHoaDon)
        {
            SqlDataReader reader = InvoiceDAO.getInvoiceDetailByID(MaHoaDon);
            return reader;
        }

        public static SqlDataReader viewListInvoices()
        {
            SqlDataReader reader = InvoiceDAO.getListInvoices();
            return reader;
        }

        public static Boolean checkStatusPayment(string MaHoaDon)
        {
            Boolean status = false;
            if (InvoiceDAO.getStatusPayment(MaHoaDon) == "Đã thanh toán")
            {
                status = true;
            }
            return status;
        }

        public static void changeStatusPayment(string MaHoaDon)
        {
            if (checkStatusPayment(MaHoaDon) == false)
            {
                InvoiceDAO.updateStatusPayment(MaHoaDon,"Đã thanh toán");
            }
            else
            {
                InvoiceDAO.updateStatusPayment(MaHoaDon, "Chưa thanh toán");
            }
        }
    }
}
