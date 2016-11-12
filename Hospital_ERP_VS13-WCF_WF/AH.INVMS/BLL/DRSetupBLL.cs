using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class DRSetupBLL
    {
        public string SaveDemandRequisition(DemandRequisition odemand)
        {
            return new DRSetupDAL().SaveDemandRequisition(odemand);
        }
        public List<DemandRequisition> GetDrID()
        {
            return new DRSetupDAL().GetDrID();
        }
        public List<DemandRequisition> GetDrNODeptUnitwise(string deptid, string unitid, string startDate, string endDate)
        {
            return new DRSetupDAL().GetDrNODeptUnitwise(deptid,unitid,startDate,endDate);
        }
        public List<DemandRequisition> GetDrDetails(string drid)
        {
            return new DRSetupDAL().GetDrDetails(drid);
        }
        public List<DemandRequisition> GetRequisitionVerifiedBy(string deptid, string unitid,string userid)
        {
            return new DRSetupDAL().GetRequisitionVerifiedBy(deptid,unitid,userid);
        }
        public short VerifyDemandRequisition(DemandRequisition odemand)
        {
            return new DRSetupDAL().VerifyDemandRequisition(odemand);
        }
        public int VarifyDemandReqNo(string drid)
        {
            return new DRSetupDAL().VarifyDemandReqNo(drid);
        }
        public List<DemandRequisition> GetDrDetailsDeptUnitWise(string deptid,string unitid)
        {
            return new DRSetupDAL().GetDrDetailsDeptUnitWise(deptid,unitid);
        }
        public List<DemandRequisition> GetDrVerifiedbyList(string verifyid)
        {
            return new DRSetupDAL().GetDrVerifiedbyList(verifyid);
        }
    }
}
