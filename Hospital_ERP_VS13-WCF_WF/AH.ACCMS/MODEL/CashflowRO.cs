using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
    public class CashflowRO
    {
        public string Cashflowtype { get; set; }
        public string CashflowSign { get; set; }
        public string CashflowLedger { get; set; }
        public string CashflowGroup { get; set; }
        public double CashflowAmount { get; set; }
        public double CashflowOpening { get; set; }
        
    }
}
