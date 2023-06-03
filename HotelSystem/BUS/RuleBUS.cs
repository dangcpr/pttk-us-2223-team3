using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.BUS
{
    internal class RuleBUS
    {
        public static Boolean checkRuleInput(ListView LeTanRuleListView)
        {
            RuleDAO.viewAllRule(LeTanRuleListView);
            return true;
        }
    }
}
