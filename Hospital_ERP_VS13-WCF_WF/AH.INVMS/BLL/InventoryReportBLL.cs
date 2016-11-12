using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.INVMS.DAL;

namespace AH.INVMS.BLL
{
    public class InventoryReportBLL
    {
        public List<ItemListRO> GetItemListGroupWise(string groupid)
        {
            return new InventoryReportDAL().GetItemListGroupWise(groupid);
        }
        public List<StockListRO> GetStockDetailsStoreWise(string storeid)
        {
            return new InventoryReportDAL().GetStockDetailsStoreWise(storeid);
        }
        public List<ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate)
        {
            return new InventoryReportDAL().GetProductLedger(prodid,startDate,endDate);
        }
        public List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            return new InventoryReportDAL().GetPOReportDateWise(startDate,endDate);
        }
        public List<IssueReportRO> GetIssueReportDateWise(string startDate, string endDate)
        {
            return new InventoryReportDAL().GetIssueReportDateWise(startDate, endDate);
        }
        public List<PODetailsRO> GetPOReport(string poid)
        {
            return new InventoryReportDAL().GetPOReport(poid);
        }
        public List<MrrReportRO> GetMrrReport(string mrid)
        {
            return new InventoryReportDAL().GetMrrReport(mrid);
        }
        public List<MrrReportRO> GetOpeningReport(string mrid)
        {
            return new InventoryReportDAL().GetOpeningReport(mrid);
        }
        public List<SalesReportRO> GetSalesReport(string issueid)
        {
            return new InventoryReportDAL().GetSalesReport(issueid);
        }
        public List<StockDetailsReportRO> GetStockDetailsReport(string grpid, string startDate, string endDate)
        {
            return new InventoryReportDAL().GetStockDetailsReport(grpid, startDate, endDate);
        }
        public List<POTermsConditionRO> GetPOTermsConditions(string poid)
        {
            return new InventoryReportDAL().GetPOTermsConditions(poid);
        }
        public List<ItemListGrpStrWiseRO> GetItemGroupStoretypeWise(string storetype,string majorgroup)
        {
            return new InventoryReportDAL().GetItemGroupStoretypeWise(storetype,majorgroup);
        }
        public List<PRReportRO> GetPRreport(string prid)
        {
            return new InventoryReportDAL().GetPRreport(prid);
        }
        public List<StockReportGroupwiseRO> GetStockReportGroupwise(string startDate, string endDate)
        {
            return new InventoryReportDAL().GetStockReportGroupwise(startDate,endDate);
        }
        public List<IssueReportRO> GetIssueReportGroupWise(string groupid,string startDate, string endDate)
        {
            return new InventoryReportDAL().GetIssueReportGroupWise(groupid,startDate,endDate);
        }
        public List<DRReportRO> GetDRreport(string drid)
        {
            return new InventoryReportDAL().GetDRreport(drid);
        }
    }
}
