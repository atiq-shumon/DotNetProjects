using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
   public class CollectionRO
    {
       public string Lname { set; get; }
       public string Lcode { set; get; }
       public string CodeAllocation { set; get; }
       public string RefNo { set; get; }
       public DateTime voucherdate { set; get; }
       public string moduleRefNo { set; get; }
       public int  voucherType { set; get; }
       public double NetAmount { set; get; }
       

    }
}
