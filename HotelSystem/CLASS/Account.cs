using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.CLASS
{
    public class Account
    {
        public string username { get; set; }
        public string  password { get; set; }
        public string role { get; set; }

        public Account(string usernameValue, string passwordValue, string roleValue)
        {
            this.username = usernameValue;
            this.password = passwordValue;
            this.role = roleValue;
        }
    }
}
