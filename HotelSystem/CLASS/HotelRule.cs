using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.CLASS
{
    public class HotelRule
    {
        private string ruleID;
        private string ruleTitle;
        private List<HotelRule> rulesList;

        public void addNewRule(string id, string title)
        {
            this.ruleID = id;
            this.ruleTitle = title;
        }

        public string getRuleID()
        {
            return this.ruleID;
        }

        public string getRuleTile()
        {
            return this.ruleTitle;
        }

        public List<HotelRule> getRulesList ()
        {
            this.rulesList = new List<HotelRule>();
            HotelRule newRule1 = new HotelRule();
            HotelRule newRule2 = new HotelRule();
            HotelRule newRule3 = new HotelRule();
            HotelRule newRule4 = new HotelRule();
            HotelRule newRule5 = new HotelRule();

            newRule1.addNewRule("R01", "Không gây hư hỏng tài sản trong khách sạn");
            newRule2.addNewRule("R02", "Không hút thuốc trong sảnh");
            newRule3.addNewRule("R03", "Liên hệ với lễ tân trong trường hợp khẩn cấp");
            newRule4.addNewRule("R04", "Thanh toán đầy đủ lệ phí trước khi checkout");
            newRule5.addNewRule("R05", "Đến nhận phòng đúng thời gian đã đăng ký");

            rulesList.Add(newRule1);
            rulesList.Add(newRule2);
            rulesList.Add(newRule3);
            rulesList.Add(newRule4);
            rulesList.Add(newRule5);

            return this.rulesList;
        }

    }
}
