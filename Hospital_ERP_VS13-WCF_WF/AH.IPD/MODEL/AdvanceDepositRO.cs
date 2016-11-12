using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
   public class AdvanceDepositRO
    {
        public string DepositeType { get; set; }
        public int Amount { get; set; }   
        public DateTime DepositDate { get; set; }
        public string DepositBy { get; set; }
        public string TransNo { get; set; }   
      
    }
}
