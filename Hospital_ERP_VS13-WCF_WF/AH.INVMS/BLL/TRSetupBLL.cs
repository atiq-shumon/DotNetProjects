using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class TRSetupBLL
    {
       public string SaveTransferRequisition(TransferRequisition otr)
       {
           return new TRSetupDAL().SaveTransferRequisition(otr);
       }
       public string SaveTransferReceive(AH.INVMS.MODEL.TransferReceive otr)
       {
           return new TRSetupDAL().SaveTransferReceive(otr);
       }
       public List<AH.INVMS.MODEL.TransferRequisition> GetTRID(string store)
       {
           return new TRSetupDAL().GetTRID(store);
       }
       public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetails(string trid)
       {
           return new TRSetupDAL().GetTRDetails(trid);
       }
       public List<AH.INVMS.MODEL.MaterialReceive> GetItemDetBatchTransfer(string trid, string itemid, string storeid)
       {
           return new TRSetupDAL().GetItemDetBatchTransfer(trid, itemid, storeid);
       }
       public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetSearch()
       {
           return new TRSetupDAL().GetTRDetSearch();
       }
    }
}
