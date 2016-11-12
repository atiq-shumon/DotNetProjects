using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
   public class CollectionSummaryRO
    {
        public string Transac_NO { get; set; }
        public string Purpose_ID { get; set; }
        public string Purpose_Title { get; set; }
        public string Purpose_Title_Beng { get; set; }
        public double Net_Amt { get; set; }
        public string ErrorMessage { get; set; }
        public string TransactionDate { get; set; }
    }
}
