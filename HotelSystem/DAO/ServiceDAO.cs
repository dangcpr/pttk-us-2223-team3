using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSystem.DAO
{
    public class ServiceDAO
    {
        public static SqlDataReader getListServicesByCustomerID(string CustomerID)
        {
            SqlCommand cmd = new SqlCommand("SELECT MA_KHACH_HANG, DICH_VU.MA_DICH_VU, TEN_DICH_VU, NGAY, SO_LUONG FROM THONG_TIN_DANG_KY_DICH_VU JOIN DICH_VU ON THONG_TIN_DANG_KY_DICH_VU.MA_DICH_VU = DICH_VU.MA_DICH_VU WHERE MA_KHACH_HANG = @CustomerID;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            SqlDataReader reader = cmd.ExecuteReader();
                
            return reader;
        }

        public static int getTotalPaymentByCustomerID(string CustomerID)
        {
            int TongTien = 0;
            SqlCommand cmd = new SqlCommand("SELECT SUM(THANH_TIEN) FROM THONG_TIN_DANG_KY_DICH_VU WHERE MA_KHACH_HANG = @CustomerID AND TINH_TRANG_THANH_TOAN = N'Chưa thanh toán';", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            TongTien = Convert.ToInt32(cmd.ExecuteScalar());
            return TongTien;
        }

        public static SqlDataReader getListServicesByInvoiceID(string InvoiceID)
        {
            SqlCommand cmd = new SqlCommand("SELECT MA_KHACH_HANG, MA_DICH_VU FROM THONG_TIN_DANG_KY_DICH_VU WHERE MA_DICH_VU IN (SELECT MA_DICH_VU FROM CHI_TIET_HOA_DON WHERE MA_HOA_DON = @InvoiceID AND CHI_TIET_HOA_DON.MA_KHACH_HANG = THONG_TIN_DANG_KY_DICH_VU.MA_KHACH_HANG);", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public static void updateStatusPayment(string MaKH, string MaDV, string Status)
        {
            SqlCommand cmd = new SqlCommand("UPDATE THONG_TIN_DANG_KY_DICH_VU SET TINH_TRANG_THANH_TOAN = @Status WHERE MA_KHACH_HANG = @MaKH AND MA_DICH_VU = @MaDV;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.ExecuteNonQuery();
        }

        public static void updateStatusPaymentByInvoiceID(string InvoiceID)
        {
            SqlDataReader reader = getListServicesByInvoiceID(InvoiceID);
            DataTable dt = new DataTable();
            dt.Load(reader);
            foreach (DataRow row in dt.Rows)
            {
                string MaKH = row["MA_KHACH_HANG"].ToString();
                string MaDV = row["MA_DICH_VU"].ToString();
                updateStatusPayment(MaKH, MaDV, "Đã thanh toán");
            }
        }

        public static SqlDataReader getListServicesPaymentByCustomerID(string CustomerID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM THONG_TIN_DANG_KY_DICH_VU WHERE MA_KHACH_HANG = @CustomerID AND TINH_TRANG_THANH_TOAN = N'Chưa thanh toán';", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}
