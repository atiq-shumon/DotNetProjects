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
    public class POReportBLL
    {
        public List<PODetailsRO> GetPOReportDet(string poid)
        {
            return new POReportDAL().GetPOReportDet(poid);
        }
        public int VerifyPOID(string poid)
        {
            return new POReportDAL().VerifyPOID(poid);
        }
        public List<ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate)
        {
            return new POReportDAL().GetProductLedger(prodid,startDate,endDate);
        }
        public List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            return new POReportDAL().GetPOReportDateWise(startDate, endDate);
        }
        public List<POTermsConditionRO> GetPOTermsConditions(string poid)
        {
            return new POReportDAL().GetPOTermsConditions(poid);
        }
    }
}
