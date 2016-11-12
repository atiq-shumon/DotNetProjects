using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.HR.MODEL
{
    public class SalaryCycle : Staff
    {
        public string Month { set; get; }
        public string Year { set; get; }
        public string MonthNumber { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public string TotalNoOfDays { set; get; }
        public string TotalFridays { set; get; }
        public string TotalHolidays { set; get; }
        public string TotalWorkDays { set; get; }
        public DateTime PaymentDate { set; get; }
        public DateTime ConfigDate { set; get; }
        public DateTime CalculateDate { set; get; }
        public string MonthStatus { set; get; }
        public string MonthType { set; get; }
        public string EidFlag { set; get; }
        public string MonthEndFlag { set; get; }
    }
}
