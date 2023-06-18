using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class InvoiceDAO
    {
        public static SqlDataReader getListInvoices()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOA_DON;", DatabaseDAO.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getInvoiceByID(string MaHoaDon)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOA_DON WHERE MA_HOA_DON = @InvoiceID;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@InvoiceID", MaHoaDon);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getInvoiceByCustomerID(string MaKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOA_DON WHERE @CustomerID IN (SELECT MA_KHACH_HANG FROM CHI_TIET_HOA_DON WHERE CHI_TIET_HOA_DON.MA_HOA_DON = HOA_DON.MA_HOA_DON);", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@CustomerID", MaKH);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getInvoiceByInvoiceDate(string NgayXuat)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOA_DON WHERE NGAY_XUAT = @InvoiceDate;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@InvoiceDate", NgayXuat);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getInvoiceDetailByID(string MaHoaDon)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHI_TIET_HOA_DON WHERE MA_HOA_DON = @InvoiceID;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@InvoiceID", MaHoaDon);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static string getNewInvoiceID()
        {
            string MaHoaDon = "";
            SqlCommand getNewID = new SqlCommand("SELECT MAX(MA_HOA_DON) + 1 FROM HOA_DON;", DatabaseDAO.getConnectDB());
            MaHoaDon = getNewID.ExecuteScalar().ToString();
            return MaHoaDon;
        }

        public static void addInvoiceAndDetail(string MaHoaDon, string MaKH, float TienPhong, float TongTien, Boolean hasServicePayment)
        {
            SqlCommand insertNewInvoice = new SqlCommand("INSERT INTO HOA_DON(TIEN_PHONG,TONG_TIEN,TINH_TRANG_THANH_TOAN,LE_TAN_GHI_NHAN) VALUES(@TienPhong,@TongTien,N'Chưa thanh toán',@LeTan);", DatabaseDAO.sqlConn);
            insertNewInvoice.Parameters.AddWithValue("@TienPhong", TienPhong.ToString());
            insertNewInvoice.Parameters.AddWithValue("@LeTan", AccountDAO.overviewUsername);
            insertNewInvoice.Parameters.AddWithValue("@TongTien", TongTien.ToString());
            insertNewInvoice.ExecuteNonQuery();

            if (hasServicePayment)
            {
                SqlCommand getServices = new SqlCommand("SELECT DICH_VU.MA_DICH_VU, SO_LUONG, GIA_TIEN, THANH_TIEN FROM THONG_TIN_DANG_KY_DICH_VU JOIN DICH_VU ON THONG_TIN_DANG_KY_DICH_VU.MA_DICH_VU = DICH_VU.MA_DICH_VU WHERE MA_KHACH_HANG = @CustomerID AND TINH_TRANG_THANH_TOAN = N'Chưa thanh toán';", DatabaseDAO.sqlConn);
                getServices.Parameters.AddWithValue("@CustomerID", MaKH);
                SqlDataReader reader = getServices.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow row in dt.Rows)
                {
                    string MaDV = row["MA_DICH_VU"].ToString();
                    string SL = row["SO_LUONG"].ToString();
                    string DonGia = row["GIA_TIEN"].ToString();
                    string ThanhTien = row["THANH_TIEN"].ToString();
                    SqlCommand insertInvoiceDetail = new SqlCommand("INSERT INTO CHI_TIET_HOA_DON(MA_HOA_DON, MA_DICH_VU,MA_KHACH_HANG,SO_LUONG,DON_GIA,THANH_TIEN) VALUES (@MaHoaDon,@MaDV,@MaKH,@SL,@DonGia,@ThanhTien);", DatabaseDAO.sqlConn);
                    insertInvoiceDetail.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                    insertInvoiceDetail.Parameters.AddWithValue("@MaDV", MaDV);
                    insertInvoiceDetail.Parameters.AddWithValue("@MaKH", MaKH);
                    insertInvoiceDetail.Parameters.AddWithValue("@SL", SL);
                    insertInvoiceDetail.Parameters.AddWithValue("@DonGia", DonGia);
                    insertInvoiceDetail.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                    insertInvoiceDetail.ExecuteNonQuery();
                }
            }
        }

        public static string getStatusPayment(string MaHoaDon)
        {
            string status = "";
            SqlCommand cmd = new SqlCommand("SELECT TINH_TRANG_THANH_TOAN FROM HOA_DON WHERE MA_HOA_DON = @MaHoaDon;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            status = cmd.ExecuteScalar().ToString();
            return status;
        }

        public static void updateStatusPayment(string MaHoaDon, string Status)
        {
            SqlCommand cmd = new SqlCommand("UPDATE HOA_DON SET TINH_TRANG_THANH_TOAN = @Status WHERE MA_HOA_DON = @MaHoaDon;", DatabaseDAO.sqlConn);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            cmd.ExecuteNonQuery();
        }
    }
}
