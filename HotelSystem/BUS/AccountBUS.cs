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
    }
}
