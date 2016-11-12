using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DUtility;
using AH.PHRMS.DAL;
using AH.DRUGS.MODEL;
using AH.PHRMS.MODEL;

namespace AH.PHRMS.BLL
{
    public class PHRMSReportBLL
    {
        public List<ProductListRO> GetDrugsCompanyWise(string company)
        {
            return new PHRMSReportDAL().GetDrugsCompanyWise(company);
        }
        public List<SalesReportRO> GetSalesReport(string issueid)
        {
            return new PHRMSReportDAL().GetSalesReport(issueid);
        }
        public List<SalesReportRO> GetSalesReportDet(string startDate, string endDate)
        {
            return new PHRMSReportDAL().GetSalesReportDet(startDate,endDate);
        }
        public List<StockListRO> GetDrugStockList(string groupid, string pharmacyid)
        {
            return new PHRMSReportDAL().GetDrugStockList(groupid,pharmacyid);
        }
        public List<StockListRO> GetDrugStockListDetails(string pharmacyid)
        {
            return new PHRMSReportDAL().GetDrugStockListDetails(pharmacyid);
        }
        public List<ItemRatesRO> GetItemRatesReport()
        {
            return new PHRMSReportDAL().GetItemRatesReport();

        }
        public List<ItemRatesHistRO> GetItemRatesHistReport(string prodid,string startDate,string endDate)
        {
            return new PHRMSReportDAL().GetItemRatesHistReport(prodid,startDate,endDate);
        }
        public List<MrrReportRO> GetMrrReportByMrID(string mrid)
        {
            return new PHRMSReportDAL().GetMrrReportByMrID(mrid);
        }
        public List<PRReportRO> GetPRreport(string prid)
        {
            return new PHRMSReportDAL().GetPRreport(prid);
        }
        public List<SalesReportRO> GetSalRetReport(string issueid)
        {
            return new PHRMSReportDAL().GetSalRetReport(issueid);
        }
        public List<SalesReportRO> GetSalRetReportDet(string startDate, string endDate)
        {
            return new PHRMSReportDAL().GetSalRetReportDet(startDate,endDate);
        }
    }
}
