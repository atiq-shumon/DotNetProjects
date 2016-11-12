using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AH.IPD.MODEL
{
    public class PackageSetup
    {
        public string PackageID { set; get; }
        public string PackageTitle { set; get; }
        public string PackageTitleBeng { set; get; }
        public DateTime PackageStartDate { set; get; }
        public DateTime PackageEndDate { set; get; }
        public char IsStayDependent { set; get; }
        public decimal StayDays { set; get; }
        public char IsAmountDependent { set; get; }
        public decimal Amount { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
