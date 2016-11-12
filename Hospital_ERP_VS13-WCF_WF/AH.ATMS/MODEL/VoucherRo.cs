using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
   public  class VoucherRo
    {
        public string MrrNo { set; get; }
        public string mrrdate { set; get; }
        public string againstDate { set; get; }
        public string agiaintRefNo { set; get; }
        public string voucherNo { set; get; }
        public string vDate { set; get; }
        public string supplierName { set; get; }
        public string supplierCode { set; get; }
        public string GroupCode { set; get; }
        public string GroupName { set; get; }
        public string brandCode { set; get; }
        public string brandName { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string ChallanNo { set; get; }
        public string ChallanDate { set; get; }
        public double dblQty { set; get; }
        public string UnitID { set; get; }
        public string UnitName { set; get; }
        public string ModelId { set; get; }
        public string ModelName { set; get; }
        public string FormName { set; get; }
        public string Notes { set; get; }
        public string TagNo { set; get; }
        public string assetsUser { set; get; }
        public string DepID { set; get; }
        public string DepName { set; get; }
        public int intVtype { set; get; }
        public string WarrentyDate { set; get; }
        public string SerialNo { set; get; }

        public string Des1 { set; get; }
        public string Des2 { set; get; }
        public string Des3 { set; get; }

        public EntryParameter EntryParameter { set; get; }

    }
}
