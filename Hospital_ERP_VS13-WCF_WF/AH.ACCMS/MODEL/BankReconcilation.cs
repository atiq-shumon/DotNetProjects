using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ACCMS.MODEL
{
    public  class BankReconcilation
    {
        public string voucherRefKey { set; get; }
        public string RefNo { set; get; }
        public string voucherDate { set; get; }
        public string lcode { set; get; }
        public string lName { set; get; }
        public string voucherType { set; get; }
        public string chequeNo { set; get; }
        public string chequeDate { set; get; }
        public string BankDate { set; get; }
        public string Drawnon { set; get; }
        public string VoucherToby { set; get; }
        public double  DebitAmount { set; get; }
        public double  CreditAmount { set; get; }
        public double childAmount { set; get; }
        public string BranchID { set; get; }
        public string PostStatus { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
