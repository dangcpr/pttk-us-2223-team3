using HotelSystem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelSystem.BUS
{
    public class FeedbackBUS
    {
        public static int checkFeedbackInput(string customerID, string feedbackContent)
        {
            if (customerID == "")
            {
                return -1;
            }
            if (feedbackContent == "")
            {
                return -2;
            }
            else
            {
                FeedbackDAO FeedbackDAO = new FeedbackDAO();
                int checkFeedback = FeedbackDAO.insertFeedback(DatabaseDAO.sqlConn, customerID, feedbackContent);
                return checkFeedback;
            }
        }
        public static int checkSelectFeedback(string customerID, DataGridView feedbackTable)
        {
            if (customerID == "")
            {
                return -1;
            }
            else
            {
                FeedbackDAO FeedbackDAO = new FeedbackDAO();
                int checkFeedback = FeedbackDAO.selectFeedback(customerID, feedbackTable);
                return checkFeedback;
            }
        }
        public static int checkUpdateFeedback(int feedbackID, string customerID, string feedbackContent)
        {
            if (customerID == "")
            {
                return -1;
            }
            else if (feedbackContent == "")
            {
                return -2;
            }
            else if (feedbackID.ToString() == "")
            {
                return -3;
            }
            else
            {
                FeedbackDAO FeedbackDAO = new FeedbackDAO();
                int checkFeedback = FeedbackDAO.updateFeedback(feedbackID, customerID, feedbackContent);
                return checkFeedback;
            }
        }
    }
}
