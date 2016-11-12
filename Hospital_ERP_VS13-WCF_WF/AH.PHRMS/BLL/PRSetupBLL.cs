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
    public class PRSetupBLL
    {
        public string SavePurchaseRequisition(PurchaseRequisition opurchase)
        {
            return new PRSetupDAL().SavePurchaseRequisition(opurchase);

        }
        public List<PurchaseRequisition> GetPRID()
        {
            return new PRSetupDAL().GetPRID();
        }
        public List<PurchaseRequisition> GetPRDetails(string prid)
        {
            return new PRSetupDAL().GetPRDetails(prid);
        }
        public List<NurseDemandRequisition> GetDRID()
        {
            return new PRSetupDAL().GetDRID();
        }
        public List<NurseDemandRequisition> GetReqDetForIPDIssue(string drid)
        {
            return new PRSetupDAL().GetReqDetForIPDIssue(drid);
        }
        public List<PurchaseRequisition> GetPRDetSearch()
        {
            return new PRSetupDAL().GetPRDetSearch();
        }
        public List<PurchaseRequisition> GetPRSearchDetails(string prid)
        {
            return new PRSetupDAL().GetPRSearchDetails(prid);
        }
        public int VarifyPurchaseReqNo(string prid)
        {
            return new PRSetupDAL().VarifyPurchaseReqNo(prid);

        }
    }
}
