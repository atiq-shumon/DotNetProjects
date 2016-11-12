using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class MRRSetupBLL
    {
        public string SaveMrrDetails(MaterialReceive omatreceive)
        {
            return new MRRSetupDAL().SaveMrrDetails(omatreceive);
        }
        public List<MaterialReceive> GetOpeningEntry(string MrrID)
        {
            return new MRRSetupDAL().GetOpeningEntry(MrrID);
        }
        public string VerifyOpeningItemID(string itemid, string storeid)
        {
            return new MRRSetupDAL().VerifyOpeningItemID(itemid,storeid);
        }
        public List<MaterialReceive> GetMRRNumber()
        {
            return new MRRSetupDAL().GetMRRNumber();
        }
        public List<MaterialReceive> GetMrrDetails(string MrrID)
        {
            return new MRRSetupDAL().GetMrrDetails(MrrID);
        }
        public short SaveAssetTrackerMaster(AssetTrackerMaster oasset)
        {
            return new MRRSetupDAL().SaveAssetTrackerMaster(oasset);
        }
        public List<ServiceProviderSCM> GetServiceProvider(string Control, string Where)
        {
            return new MRRSetupDAL().GetServiceProvider(Control,Where);
        }
        public Dictionary<string, string> GetServiceProviderInfo(string Control, string Where)
        {
            Dictionary<string, string> objService = new Dictionary<string, string>();
            foreach (ServiceProviderSCM Service in new MRRSetupDAL().GetServiceProvider(Control, Where))
            {
                objService.Add(Service.ID, Service.ServiceProviderName);
            }
            return objService;

        }
        public string SavePurchaseReturn(PurchaseReturn oret)
        {
            return new MRRSetupDAL().SavePurchaseReturn(oret);
        }
        public List<MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            return new MRRSetupDAL().GetMrrDetailsForPurchaseReturn(mrrid);
        }
        public int VarifyItemForReturn(string mrrid,string itemid)
        {
            return new MRRSetupDAL().VarifyItemForReturn(mrrid,itemid);
        }
        public List<MaterialReceiveRO> GetMrrReportDateWise(string startDate, string endDate)
        {
            return new MRRSetupDAL().GetMrrReportDateWise(startDate, endDate);
        }

    }
}
