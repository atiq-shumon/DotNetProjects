using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.ACCMS.MODEL
{
    public class FinancialYear
    {
        public string YearID { set; get; }

        public string FinancialYearForm { set; get; }
        public string FinancialYearTo { set; get; }
        public int  YearStatus { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
