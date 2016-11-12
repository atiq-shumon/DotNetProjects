using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.INVMS.MODEL
{
    public class Stock
    {
        public float StockQty { set; get; }
        public StoreLocation StoreLocaton { set; get; }
        public ItemOrder ItemOrder { set; get; }
    }
}
