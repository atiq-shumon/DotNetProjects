using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ACCMS.MODEL
{
   public class LedgerOpening
    {
       public string OpnID { set; get; }
       public string LedgerName { set; get; }
       public string LedgerCode { set; get; }
       public string BranchName { set; get; }
       public string BranchCode { set; get; }
       public string OpnDate { set; get; }
       public double  dblOpeningAmount { set; get; }
       public string DRCR { set; get; }
       public EntryParameter EntryParameter { set; get; }
    }
}
