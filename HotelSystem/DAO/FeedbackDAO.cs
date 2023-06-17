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
    public class FeedbackDAO
    {

        public static DataTable fillData(SqlConnection sqlConn, string queryStr)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryStr, sqlConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public int insertFeedback(SqlConnection sqlConn, string customerID, string feedbackContent)
        {
            try
            {
                string insertFeedbackQuery = "DECLARE @MA_PHIEU INT;" +
                    "SET @MA_PHIEU = (SELECT ISNULL(MAX(MA_PHIEU), 0) FROM PHIEU_FEED_BACK);" +
                    "INSERT INTO PHIEU_FEED_BACK (MA_PHIEU, MA_KHACH_HANG, NOI_DUNG) VALUES (@MA_PHIEU + 1, @customerID, @feedbackContent)";
                SqlCommand sqlCmd = new SqlCommand(insertFeedbackQuery, sqlConn);

                sqlCmd.Parameters.AddWithValue("@customerID", customerID);
                sqlCmd.Parameters.AddWithValue("@feedbackContent", feedbackContent);

                sqlCmd.ExecuteNonQuery();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static DataTable selectFeedback(string customerID)
        {
            string requestIdStr = $"SELECT * FROM PHIEU_FEED_BACK WHERE MA_KHACH_HANG = '{customerID}'";

            // Call Room DAO method to get room list
            DataTable dataTable = fillData(DatabaseDAO.sqlConn, requestIdStr);
            return dataTable;
        }

        public static int updateFeedback(int feedbackID, string customerID, string feedbackContent)
        {
            try
            {
                string updateFeedbackSql = $"UPDATE PHIEU_FEED_BACK SET NOI_DUNG = N'{feedbackContent}', NGAY_FEED_BACK = FORMAT(GETDATE(), 'yyyy-MM-dd') WHERE MA_KHACH_HANG = '{customerID}' AND MA_PHIEU = {feedbackID}";

                // Call Room DAO method to get room list
                SqlCommand sqlCmd = new SqlCommand(updateFeedbackSql, DatabaseDAO.sqlConn);

                sqlCmd.Parameters.AddWithValue("@customerID", customerID);
                sqlCmd.Parameters.AddWithValue("@feedbackContent", feedbackContent);

                sqlCmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

    }

}
