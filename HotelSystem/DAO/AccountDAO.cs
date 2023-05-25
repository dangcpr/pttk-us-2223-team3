using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.DAO
{
    public class AccountDAO
    {
        private string getAllAccountQuery = "SELECT * FROM TAI_KHOAN";
        public static string overviewUsername = "";

        public bool checkAccount(SqlConnection sqlConn, string username, string password, string role)
        {

            SqlCommand sqlCmd = new SqlCommand(getAllAccountQuery, sqlConn);

            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool checkAccount = false;
            while (reader.Read())
            {
                if (reader.GetString(1) == username && reader.GetString(2) == password && reader.GetString(3) == role)
                {
                    overviewUsername = username;
                    checkAccount = true;
                }

            }

            // Đóng reader sau khi truy xuất tài khoản xong
            reader.Close();

            return checkAccount;
        }
    }
}
