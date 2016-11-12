using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class SalesReportRO
    {
        public string Issue_id { set; get; }
        public string Phr_id { set; get; }
        public string PharmacyTitle { set; get; }
        public string DrugGroup { set; get; }
        public string DrugType { set; get; }
        public string DrugUnit { set; get; }
        public string DrugName { set; get; }
        public string DrugCompany { set; get; }
        public float ReqQty { set; get; }
        public float Quantity { set; get; }
        public float Qty_Over_Pres { set; get; }
        public float Urate { set; get; }
        public float Vat { set; get; }
        public float Disc { set; get; }
        public string Hcn { set; get; }
        public string PatientName { set; get; }
        public float ReturnQty { set; get; }
        public float NetQty { set; get; }
        public float ReturnPrice { set; get; }
        public string PatientAddress { set; get; }
        public string EntryBy { set; get; }
        public string Entry_By_Name { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
