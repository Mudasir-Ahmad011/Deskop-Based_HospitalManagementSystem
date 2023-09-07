using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_App.BL
{
    class ExpiredMedicine
    {
        private string expiredmedicine;

        public string getExpiredmedicine() { return expiredmedicine; }
        public void setExpiredmedicine(string expiredmedicine) { this.expiredmedicine = expiredmedicine; }
        public ExpiredMedicine() { }
        public ExpiredMedicine(string expiredmedicine)
        {
            this.expiredmedicine = expiredmedicine;
        }
        public static int convertDatetodays(string date)
        {
            char[] datedays = { date[0], date[1], '\0' };
            char[] datemonths = { date[3], date[4], '\0' };
            char[] dateyears = { date[6], date[7], date[8], date[9], '\0' };
            string dateDays = new string(datedays);
            string dateMonths = new string(datemonths);
            string dateYears = new string(dateyears);
            return int.Parse(dateDays) + int.Parse(dateMonths) * 30 + (int.Parse(dateYears) - 2000) * 365;
        }
        public static bool isExpired(string currentDate, string expiryDate)
        {
            int currentDays = convertDatetodays(currentDate);
            int expiryDays = convertDatetodays(expiryDate);
            return (currentDays > expiryDays);
        }
    }

}
