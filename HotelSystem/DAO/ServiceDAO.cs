using System;
using System.Collections.Generic;
using System.Data;
﻿using Guna.UI2.WinForms;
using HotelSystem.CLASS;
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
        public static SqlDataAdapter getDanhSachDatLichDv()
        {
            String getData = "SELECT * FROM LICH_SU_DUNG_DICH_VU";
            SqlDataAdapter adapter = new SqlDataAdapter(getData, DatabaseDAO.sqlConn);
            return adapter;
        }

        public static SqlDataReader getQueryStr(SqlConnection sqlConn, string queryStr)
        {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static void loadlvData(ListView lvService)
        {
            string sqlLoaddata = $"SELECT * FROM DICH_VU;";

            SqlDataReader reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sqlLoaddata);

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());

                lvService.Items.Add(item);
            }

            reader.Close();
        }

        public static void LoadDVName(Guna2ComboBox cbLoaiDV)
        {
            cbLoaiDV.Items.Clear();
            string sql = "SELECT TEN_DICH_VU FROM DICH_VU";
            SqlDataReader reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);

            while (reader.Read())
            {
                cbLoaiDV.Items.Add(reader[0].ToString());

            }
            reader.Close();

        }

        public static int CheckServiceBooking(string makh, string loaidv)
        {
            string sql = $"SELECT * FROM THONG_TIN_DAT_PHONG WHERE MA_KHACH_HANG = '{makh}'";
            SqlDataReader reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 1;
            }
            reader.Close();

            sql = $"SELECT * FROM DICH_VU WHERE TEN_DICH_VU = N'{loaidv}'AND TINH_TRANG = N'Còn'";
            reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 2;
            }
            reader.Close();

            sql = $"select * from DICH_VU WHERE TEN_DICH_VU = N'{loaidv}' AND (LOAI_PHONG_CHO_PHEP = N'Tất cả' OR LOAI_PHONG_CHO_PHEP IN (SELECT LOAI_PHONG FROM THONG_TIN_DAT_PHONG WHERE MA_KHACH_HANG = '{makh}'))";
            reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 3;
            }
            reader.Close();

            return 0;
        }

        public static int AddServiceBooking1(string makh, string loaidv, string ngaydk, string soluong, string thanhtoan)
        {
            int sl = Int32.Parse(soluong);


            string sql = "DECLARE @id int;";
            sql += "SET @id = (SELECT MA_DICH_VU FROM DICH_VU WHERE TEN_DICH_VU = N'" + loaidv + "');";

            sql += "DECLARE @sum int;";
            sql += "SET @sum =" + sl + "*(SELECT GIA_TIEN FROM DICH_VU WHERE TEN_DICH_VU = N'" + loaidv + "');";

            sql += "INSERT INTO THONG_TIN_DANG_KY_DICH_VU VALUES (@id, '";
            sql += makh + "', '";
            sql += ngaydk + "', ";
            sql += sl + ", @sum, N'";
            sql += thanhtoan + "');";

            sql += "INSERT INTO LICH_SU_DUNG_DICH_VU VALUES ('" + ngaydk + "', @id, '" + makh + "');";

            try
            {
                SqlCommand sqlCmd = new SqlCommand(sql, DatabaseDAO.sqlConn);
                sqlCmd.ExecuteNonQuery();
                return 0;
            }
            catch
            {
                return 4;
            }

        }

        public static int SearchDV1(string makh, ListView lvDVSe)
        {
            string sql = $"SELECT * FROM THONG_TIN_DAT_PHONG WHERE MA_KHACH_HANG = '{makh}'";

            SqlDataReader reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 1;
            }
            reader.Close();

            sql = $"SELECT * FROM THONG_TIN_DANG_KY_DICH_VU WHERE MA_KHACH_HANG = '{makh}'";
            reader = ServiceDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 2;
            }
            reader.Close();

            sql = $"SELECT DK.ID, DV.TEN_DICH_VU, DK.MA_KHACH_HANG, DK.NGAY, DK.SO_LUONG, DK.THANH_TIEN, DK.TINH_TRANG_THANH_TOAN FROM THONG_TIN_DANG_KY_DICH_VU DK, DICH_VU DV WHERE MA_KHACH_HANG = '{makh}' AND DK.MA_DICH_VU = DV.MA_DICH_VU";
            reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());

                lvDVSe.Items.Add(item);
            }
            reader.Close();
            return 0;
        }
    }
}
