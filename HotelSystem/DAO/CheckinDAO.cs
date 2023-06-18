using System;
using System.Collections.Generic;
﻿using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelSystem.DAO
{
    internal class CheckinDAO
    {
        public static string getAllThongTinDatPhong = "SELECT MA_DP FROM THONG_TIN_DAT_PHONG";

        public static Boolean checkMadp(String madp)
        {
            SqlCommand sqlCmd = new SqlCommand(getAllThongTinDatPhong, DatabaseDAO.sqlConn);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool checkMaDatPhong = false;
            while (reader.Read())
            {
                if (reader["MA_DP"].ToString() == madp)
                {
                    checkMaDatPhong = true;
                }

            }

            // Đóng reader sau khi truy xuất xong
            reader.Close();

            return checkMaDatPhong;
        }

        public static SqlDataReader getThongTinDatPhongByMadp(string madp)
        {
            string getThongTinDatPhong = $"SELECT * FROM THONG_TIN_DAT_PHONG where MA_DP = '{madp}'";


            SqlCommand sqlCmd = new SqlCommand(getThongTinDatPhong, DatabaseDAO.sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            return reader;
        }

        public static Boolean saveDataCheckin(List<String> list, DateTime dateValue)
        {
            bool result = false;

            try
            {
                string _saveDataCheckin = $"INSERT INTO PHIEU_DANG_KY (MA_KHACH_HANG, CCCD, NGAY_CHECK_IN, GHI_CHU) VALUES ('{list[0]}', '{list[1]}', '{dateValue.Year.ToString()}-{dateValue.Month.ToString()}-{dateValue.Day.ToString()}', '{list[3]}')";
                SqlCommand sqlCmd = new SqlCommand(_saveDataCheckin, DatabaseDAO.sqlConn);
                sqlCmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                return result;
            }
            return result;
        }

        public static SqlDataReader getQueryStr(SqlConnection sqlConn, string queryStr)
        {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }
        public static int insertPDK1(string customerId, string CCCD)
        {
            
            string sql = $"SELECT * FROM THONG_TIN_KHACH_HANG WHERE MA_KHACH_HANG = '{customerId}'";
            
            SqlDataReader reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 1;
            }
            reader.Close();

            sql = $"SELECT * FROM THONG_TIN_KHACH_HANG WHERE MA_KHACH_HANG = '{customerId}' AND CCCD = '{CCCD}'";

            reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 2;
            }
            reader.Close();

            sql = $"INSERT INTO PHIEU_DANG_KY (MA_KHACH_HANG, CCCD) VALUES ('{customerId}','{CCCD}')";
            reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            reader.Close();
            return 0;
        }

        public static int SelectKM1(string makh, ListView lvKM)
        {
            string sql = $"SELECT * FROM THONG_TIN_DAT_PHONG WHERE MA_KHACH_HANG = '{makh}'";

            SqlDataReader reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 1;
            }
            reader.Close();

            sql = $"SELECT * FROM THONG_TIN_DAT_PHONG TT, KHUYEN_MAI KM WHERE TT.MA_KHACH_HANG = '{makh}' AND KM.MA_KHUYEN_MAI = TT.KHUYEN_MAI";
            reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
            if (!reader.Read())
            {
                reader.Close();
                return 2;
            }
            reader.Close();

            sql = $"SELECT TT.MA_KHACH_HANG, KM.* FROM THONG_TIN_DAT_PHONG TT, KHUYEN_MAI KM WHERE TT.MA_KHACH_HANG = '{makh}' AND KM.MA_KHUYEN_MAI = TT.KHUYEN_MAI";
            reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sql);
        
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());

                lvKM.Items.Add(item);
            }
            reader.Close();
            return 0;
        }

        public static void LoadlvData(ListView lvPDK)
        {
            string sqlLoaddata = $"SELECT * FROM PHIEU_DANG_KY;";

            // Call Room DAO method to get room booking info
            SqlDataReader reader = CheckinDAO.getQueryStr(DatabaseDAO.sqlConn, sqlLoaddata);

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());

                lvPDK.Items.Add(item);
            }

            reader.Close();
        }
    }
}
