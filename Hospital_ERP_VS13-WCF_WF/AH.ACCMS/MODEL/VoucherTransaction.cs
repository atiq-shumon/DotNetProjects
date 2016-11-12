using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
    public class VoucherTransaction
    {
        public string strRefNo { set; get; }
        public string strVoucherDate { set; get; }
        public string strBranchName { set; get; }
        public string strDrCr { set; get; }
        public string strLedgerName { set; get; }
        public string strSingleNarration { set; get; }
        public string strChequeNo { set; get; }
        public string strChequedate { set; get; }
        public string strDrawnon { set; get; }
        public double dblDebitamount { set; get; }
        public double dblCreditAmount { set; get; }
        public string strNarration { set; get; }
        public double dblNetDebitAmount { set; get; }
        public double dbleNetCreditAmount {set; get; }
        public string strMonthID { set; get; }
        public string strReferseLedger { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public int vintVoucherType { set; get; }
        public int intCashflow { set; get; }
        public int intVoucherPos { set; get; }
        public string strBranchId { set; get; }
        public int intmodetype { set; get; }
        public string  LedgerCode { set; get; }
        public string ModuleRefNo { set; get; }
        public int  Modulestatus { set; get; }
        public string PostStatus { set; get; }
        public string Primarygroup { set; get; }
        public string entryby { set; get; }
    }
}
