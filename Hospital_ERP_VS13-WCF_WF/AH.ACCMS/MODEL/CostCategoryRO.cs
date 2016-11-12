using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
    public class CostCategoryRO
    {
        public string TransactionCode { set; get; }
        public string Categorycode { set; get; }
        public string CategoryTitle { set; get; }
        public string CostCenteCode { set; get; }
        public string CoatCenterName { set; get; }
        public double Amount { set; get; }
        public string lName {set;get;}
        public string LedgerCode { set; get; }
        public DateTime  TranDate { set; get; }
        
    }
}
