using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
    public class BankReconcilationRO
    {
        public string voucherRefKey { set; get; }
        public string RefNo { set; get; }
        public DateTime voucherDate { set; get; }
        public DateTime BankDate { set; get; }
        public string lcode { set; get; }
        public string lName { set; get; }
        public int  voucherType { set; get; }
        public string chequeNo { set; get; }
        public string chequeDate { set; get; }
        public string Drawnon { set; get; }
        public string VoucherToby { set; get; }
        public double DebitAmount { set; get; }
        public double CreditAmount { set; get; }
        public double bankChargePer { set; get; }
        public double bankChargeAmount { set; get; }
        public double bankChargeNetAmount { set; get; }
        public double childAmount { set; get; }
        public double Opening { set; get; }
        public string BranchID { set; get; }
       
    }
}
