using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.BUS
{
    public class AccountBUS
    {
        public static Boolean checkSigninInput (string username, string password, string role)
        {
            if(username == "" || password == "" || role =="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean checkAccount(string username, string password, string role)
        {
            AccountDAO accountDAO = new AccountDAO();
            bool checkAccount = accountDAO.checkAccount(DatabaseDAO.sqlConn, username, password, role);
            return checkAccount;
        }
    }
}
