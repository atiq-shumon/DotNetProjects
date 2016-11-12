using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.FNB.MODEL
{
    public class Visitors
    {
        public string InvoiceNo { set; get; }
        public string TransNo { set; get; }
        public string VName { set; get; }
        public string DisType { set; get; }
        public string DisRef { set; get; }
        public string DisAuthority { set; get; }
        public double Discount { set; get; }
        public double ItemDiscount { set; get; }
        public string Vat { set; get; }
        public double NetPaid { set; get; }
        public Char Active { set; get; }
        public string SetMenuID { set; get; }
        public OPDPayment FNBPayment { set; get; }
        public string VisOrders { set; get; }
        public string PaymentString { set; get; }
        public string FoodID { set; get; }
        public string FoodName { set; get; }
        public double Qnty { set; get; }
        public double Rate { set; get; }
        public double Total { set; get; }
        public string  entryDate { set; get; }
        public string PurposeID { set; get; }
        public string entryby { set; get; }
        public string empID { set; get; }

        public EntryParameter EntryParameter { set; get; }


    }
}
