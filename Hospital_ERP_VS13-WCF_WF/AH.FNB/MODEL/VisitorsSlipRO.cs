using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.FNB.MODEL
{
   public class VisitorsSlipRO
    {

       public string invoiceNo { set; get; }
       public string TransationNo { set; get; }
       public string Entryby { set; get; }
       public DateTime entry_date { set; get; }

       public string vdate { set; get; }
       public string FoodID { set; get; }
       public string VisitorsName { set; get; }
       public string FoodName { set; get; }
       public double  Qty { set; get; }
       public double  Rate { set; get; }
       public double Itemdisc { set; get; }
       public double NetPaid { set; get; }
       public double TotalDis { set; get; }
       public double TotalVat { set; get; }

       public double DrAmount { set; get; }
       public double CrAmount { set; get; }
       public double CashAmount { set; get; }
       public double Total { set; get; }

       public string empId { set; get; }



    }
}
