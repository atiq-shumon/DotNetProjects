using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ACCMS.MODEL
{
    public class Ledgers
    {
        public string strLedgerName {set; get;}
        public string strGrUnder { set; get; }
        public string strCurrencsysymbol { set; get; }
        public double dblopeningBalance { set; get; }
        public string strAddress1 { set; get; }
        public string straddress2 { set; get; }
        public string strCity { set; get; }
        public string strPostal { set; get; }
        public string strFax { set; get; }
        public string strPhone { set; get; }
        public string strEmail { set; get; }
        public string strComments { set; get; }
        public string strStatus {set; get; }
        public string strDRCR { set; get; }
        public long  lngSlNo { set; get; }
        public long lngLegerGroup { set; get;}
        public long lngDefaultLedger { set; get; }
        public long lngLedgerPrimaryType { set; get; }
        public string strLedgerCode { set; get; }
        public int intCostCenter { set; get; }
        public string CodeAllocation { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }

}
