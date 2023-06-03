using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class CustomerDAO
    {
        public static string customerQueryStr = "SELECT KH.MA_KHACH_HANG, KH.HO_TEN, KH.DIA_CHI, KH.CCCD, KH.SDT, KD.TEN_DOAN FROM THONG_TIN_KHACH_HANG AS KH, THONG_TIN_KHACH_DOAN AS KD, CHI_TIET_KHACH_DOAN AS CT WHERE KH.MA_KHACH_HANG = CT.MA_KHACH_HANG AND CT.MA_DOAN = KD.MA_DOAN";
        public static string customerByIdQueryStr = "SELECT * FROM THONG_TIN_KHACH_HANG WHERE MA_KHACH_HANG = ";

        public static SqlDataReader getQueryStr(SqlConnection sqlConn, string queryStr)
        {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static SqlDataReader getCustomerById(SqlConnection sqlConn, string id)
        {
            SqlCommand sqlCmd = new SqlCommand(customerByIdQueryStr + "'" + id + "'", sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            return reader;
        }

        public static Boolean viewCustomerById(string customerID, ListView LeTanCustomerListView)
        {
            Boolean isFound = false;
            int index = 0;

            string customerStr = $"SELECT * FROM THONG_TIN_KHACH_HANG WHERE MA_KHACH_HANG = '{customerID}';";

            // Call Customer DAO method to get customer info
            SqlDataReader reader = CustomerDAO.getQueryStr(DatabaseDAO.sqlConn, customerStr);

            while (reader.Read())
            {
                // Check found customer info
                if (reader[0].ToString() != "") isFound = true;

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());

                LeTanCustomerListView.Items.Add(item);
                index++;
            }

            reader.Close();
            return isFound;
        }

        public static Boolean viewCustomerGroupById(string customerID, ListView LeTanCustomerListView, ListView LeTanCustomerGroupListView)
        {
            Boolean isFound = false;
            int index = 0;

            string customerStr = $"SELECT * FROM THONG_TIN_KHACH_DOAN WHERE MA_DOAN = '{customerID}';";
            string customerStr2 = $"SELECT CTKD.MA_KHACH_HANG, CTKD.MA_DOAN, TTKH.HO_TEN, TTKH.DIA_CHI, TTKH.CCCD, TTKH.SDT FROM CHI_TIET_KHACH_DOAN CTKD JOIN THONG_TIN_KHACH_HANG TTKH ON CTKD.MA_KHACH_HANG = TTKH.MA_KHACH_HANG WHERE MA_DOAN = '{customerID}';";

            // Call Customer DAO method to get customer info
            SqlDataReader reader = CustomerDAO.getQueryStr(DatabaseDAO.sqlConn, customerStr);

            while (reader.Read())
            {
                // Check found customer group info
                if (reader[0].ToString() != "") isFound = true;

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());

                LeTanCustomerListView.Items.Add(item);
                index++;
            }

            reader.Close();

            reader = CustomerDAO.getQueryStr(DatabaseDAO.sqlConn, customerStr2);

            while (reader.Read())
            {
                // Check found room info
                if (reader[0].ToString() != "") isFound = true;

                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());


                LeTanCustomerGroupListView.Items.Add(item);
                index++;
            }

            reader.Close();
            return isFound;
        }
    }
}
