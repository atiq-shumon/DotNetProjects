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
    public class MaterialReceiveBLL
    {
        public string SaveMaterialReceive(MaterialReceive mr)
        {
            return new MRRSetupDAL().SaveMaterialReceive(mr);
        }
        public List<MaterialReceive> GetOpeningEntry(string MrrID)
        {
            return new MRRSetupDAL().GetOpeningEntry(MrrID);
        }
        public List<MaterialReceive> GetMRRNumber()
        {
            return new MRRSetupDAL().GetMRRNumber();
        }
        public short UpdateOpeningEntry(MaterialReceive mr)
        {
            return new MRRSetupDAL().UpdateOpeningEntry(mr);
        }
        public List<MaterialReceiveRO> GetMrrReport(string startDate, string endDate)
        {
            return new MRRSetupDAL().GetMrrReport(startDate,endDate);
        }
        public string VerifyOpeningDrugID(string drugid, string pharmacyid)
        {
            return new MRRSetupDAL().VerifyOpeningDrugID(drugid,pharmacyid);
        }
        public List<MaterialReceiveRO> GetOpeningReport()
        {
            return new MRRSetupDAL().GetOpeningReport();
        }
        public List<MaterialReceiveRO> GetDrugsByExpireDate(string startDate, string endDate)
        {
            return new MRRSetupDAL().GetDrugsByExpireDate(startDate,endDate);
        }
        public string SavePurchaseReturn(PurchaseReturn oret)
        {
            return new MRRSetupDAL().SavePurchaseReturn(oret);
        }
        public List<MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            return new MRRSetupDAL().GetMrrDetailsForPurchaseReturn(mrrid);
        }
        public int VarifyDrugForReturn(string mrrid,string drugid)
        {
            return new MRRSetupDAL().VarifyDrugForReturn(mrrid,drugid);
        }
        public int VarifyDuplicateBatch(string phrid,string drugid,string batchno)
        {
            return new MRRSetupDAL().VarifyDuplicateBatch(phrid,drugid,batchno);
        }
        public int VarifyExpireDate(string phrid, string drugid)
        {
            return new MRRSetupDAL().VarifyExpireDate(phrid,drugid);
        }
    }
}
