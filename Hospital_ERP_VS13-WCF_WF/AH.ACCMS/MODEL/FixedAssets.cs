using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
    public class FixedAssets
    {
        public string strLedgerName { set; get; }
        public string strDepMethod { set; get; }
        public string strLedgerCode { set; get; }
        public double dblPurchaseCost { set; get; }
        public string dteDepEffDate { set; get; }
        public int intDepMethod { set; get; }
        public double  dblAssetsLife { set; get; }
        public double dblAssetsDepRate { set; get; }
        public double dblAssetsAccDep { set; get; }
        public double dblWrittenValue { set; get; }
        public double dblsalvageValue { set; get; }
        public double dblPercent { set; get; }
        public long SerialNo { set; get; }
        public string Locationcode { set; get; }
        public string LocationName { set; get; }
        public string supplierCode { set; get; }
        public string SupplierName { set; get; }
        public string ManufactureDate { set; get; }
        public string ManufacturerName { set; get; }
        public string ManufacturerCode { set; get; }
        public string PurchaseDate { set; get; }
        public string NameofOrigin { set; get; }
        public string ModelNo { set; get; }
        public string AssetsIdenticode { set; get; }
        public string FloorNo { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
    
}
