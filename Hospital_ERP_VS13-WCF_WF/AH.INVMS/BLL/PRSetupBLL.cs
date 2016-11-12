using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.DAL;
using AH.INVMS.MODEL;

namespace AH.INVMS.BLL
{
    public class PRSetupBLL
    {
        public string SavePurchaseRequisition(PurchaseRequisition opurchase)
        {
            return new PRSetupDAL().SavePurchaseRequisition(opurchase);
        }
        public List<PurchaseRequisition> GetPRDetails(string prid)
        {
            return new PRSetupDAL().GetPRDetails(prid);
        }
        public List<PurchaseRequisition> GetPRDetailsForPR(string prid)
        {
            return new PRSetupDAL().GetPRDetailsForPR(prid);
        }
        public List<PurchaseRequisition> GetPRID()
        {
            return new PRSetupDAL().GetPRID();
        }
        public List<PurchaseRequisition> GetRequisitionTrack(string storeid,string startDate,string endDate)
        {
            return new PRSetupDAL().GetRequisitionTrack(storeid,startDate,endDate);
        }
        public List<PurchaseOrder> GetPOTracking(string storeid,string startDate,string endDate)
        {
            return new PRSetupDAL().GetPOTracking(storeid, startDate, endDate);
        }
        public List<MaterialReceive> GetMrrTracking(string storeid,string startDate,string endDate)
        {
            return new PRSetupDAL().GetMrrTracking(storeid, startDate, endDate);
        }
        public List<PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            return new PRSetupDAL().GetPOTrackingByPrId(prid);
        }
        public List<MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            return new PRSetupDAL().GetMrrTrackingByPONo(poid);
        }
        public int VarifyPurchaseReqNo(string prid)
        {
            return new PRSetupDAL().VarifyPurchaseReqNo(prid);
        }
        public List<PurchaseRequisition> GetPrDetailsDeptUnitWise(string storetypeid)
        {
            return new PRSetupDAL().GetPrDetailsDeptUnitWise(storetypeid);
        }
        public short ModifyPurchaseRequisition(PurchaseRequisition opurchase)
        {
            return new PRSetupDAL().ModifyPurchaseRequisition(opurchase);
        }
        public int VarifyPRForModify(string prid)
        {
            return new PRSetupDAL().VarifyPRForModify(prid);
        }
    }
}
