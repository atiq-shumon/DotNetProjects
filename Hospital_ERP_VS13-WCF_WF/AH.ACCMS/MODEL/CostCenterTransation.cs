using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
   public class CostCenterTransation
    {
       public string  TransactionCode { set; get; }
       public string Categorycode { set; get; }
       public string CategoryTitle { set; get; }
       public string CostCenteCode { set; get; }
       public string CoatCenterName { set; get; }
       public string GroupCode { set; get; }
       public string GroupName { set; get; }
       public double Amount { set; get; }
       public string Trandate { set; get; }
       public string LedgerCode { set; get; }

       public string GrCode { set; get; }
       public string GrName { set; get; }

       public string DepCode { set; get; }
       public string DepName { set; get; }



       public EntryParameter EntryParameter { set; get; }
    }
}
