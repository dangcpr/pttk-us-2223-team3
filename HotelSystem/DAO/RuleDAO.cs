using HotelSystem.CLASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.DAO
{
    public class RuleDAO
    {
        public static void viewAllRule(ListView LeTanRuleListView, List<HotelRule> ruleList)
        {
            LeTanRuleListView.BringToFront();
            LeTanRuleListView.Items.Clear(); // Clear all list view data
            LeTanRuleListView.Columns.Clear();
            LeTanRuleListView.View = View.Details; // To see add columns

            const int width = 100;
            const int with2 = 500;

            LeTanRuleListView.Columns.Add("Mã quy định", width);
            LeTanRuleListView.Columns.Add("Nội dung", with2);

            int index = 0;
            foreach (HotelRule rule in ruleList)
            {
                ListViewItem item = new ListViewItem(rule.getRuleID().ToString());
                item.SubItems.Add(rule.getRuleTile().ToString());

                LeTanRuleListView.Items.Add(item);
                index++;
            }
        }
    }
}
