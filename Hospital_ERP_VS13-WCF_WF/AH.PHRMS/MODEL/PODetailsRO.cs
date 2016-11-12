using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class PODetailsRO
    {
        public string PharmacyID { set; get; }
        public string PharmacyName { set; get; }
        public string POID { set; get; }
        public string POTYPE { set; get; }
        public string PRID { set; get; }
        public string SupplierID { set; get; }
        public string SupplierName { set; get; }
        public string SupplierAddress { set; get; }
        public string SupplierPhone { set; get; }
        public string SupplierFaxNo { set; get; }
        public string DrugID { set; get; }
        public string DrugName { set; get; }
        public string DrugCompany { set; get; }
        public string CompanyName { set; get; }
        public string DrugGroup { set; get; }
        public string GroupName { set; get; }
        public string DrugUnit { set; get; }
        public string UnitName { set; get; }
        public string Type { set; get; }
        public string TypeName { set; get; }
        public float POQty { set; get; }
        public float SalesRate { set; get; }
        public float Rate { set; get; }
        public float Vat { set; get; }
        public float Discount { set; get; }
        public float RemainingQty { set; get; }
        public string CompleteFlag { set; get; }
        public string DeliveryNote { set; get; }
        public DateTime DeliveryDate { set; get; }
        public DateTime PODATE { set; get; }
        public string Remarks { set; get; }
    }
}
