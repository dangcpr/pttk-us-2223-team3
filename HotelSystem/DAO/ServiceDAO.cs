using Guna.UI2.WinForms;
using HotelSystem.CLASS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HotelSystem.DAO
{
    class ServiceDAO
    {
        public static SqlDataReader getQueryStr(SqlConnection sqlConn, string queryStr)
        {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        internal static void loadlvData(ListView lvService)
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

        internal static void LoadDVName(Guna2ComboBox cbLoaiDV)
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

        internal static int CheckServiceBooking(string makh, string loaidv)
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

        internal static int AddServiceBooking1(string makh, string loaidv, string ngaydk, string soluong, string thanhtoan)
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

        internal static int SearchDV1(string makh, ListView lvDVSe)
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
