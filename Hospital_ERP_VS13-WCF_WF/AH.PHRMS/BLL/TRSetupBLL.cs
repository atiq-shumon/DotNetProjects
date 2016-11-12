using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PHRMS.MODEL;
using AH.PHRMS.DAL;

namespace AH.PHRMS.BLL
{
    public class TRSetupBLL
    {
        public string SaveTransferRequisition(TransferRequisition otr)
        {
            return new TRSetupDAL().SaveTransferRequisition(otr);
        }
        public List<TransferRequisition> GetTRID(string pharmacy)
        {
            return new TRSetupDAL().GetTRID(pharmacy);
        }
        public List<TransferRequisition> GetTRDetails(string trid)
        {
            return new TRSetupDAL().GetTRDetails(trid);
        }
        public List<MaterialReceive> GetDrugDetailsBatch(string trid, string drugid, string pharmacyid)
        {
            return new TRSetupDAL().GetDrugDetailsBatch(trid,drugid,pharmacyid);
        }
        public string SaveTransferReceive(TransferReceive otr)
        {
            return new TRSetupDAL().SaveTransferReceive(otr);
        }
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetSearch()
        {
            return new TRSetupDAL().GetTRDetSearch();
        }
    }
}
