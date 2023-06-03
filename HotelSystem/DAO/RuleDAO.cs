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
    public class RuleDAO
    {
        public static string ruleQueryStr = "SELECT * FROM QUY_DINH_KHACH_SAN";

        public static SqlDataReader getQueryStr(SqlConnection sqlConn, string queryStr)
        {
            SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            return reader;
        }

        public static void viewAllRule(ListView LeTanRuleListView)
        {
            int index = 0;

            // Call Rule DAO method to get customer info
            SqlDataReader reader = RuleDAO.getQueryStr(DatabaseDAO.sqlConn, ruleQueryStr);

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[0].ToString());

                item.SubItems.Add(reader[1].ToString());

                LeTanRuleListView.Items.Add(item);
                index++;
            }

            reader.Close();
        }
    }
}
