using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.INVMS.MODEL
{
    public class AssetTrackerMaster
    {
        public MaterialReceive MaterialReceive { set; get; }
        public ItemMaster ItemMaster { set; get; }
        public string SerialNo { set; get; }
        public string ServiceProviderID { set; get; }
        public string WarrantyUpto { set; get; }
        public string ExpireDate { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
