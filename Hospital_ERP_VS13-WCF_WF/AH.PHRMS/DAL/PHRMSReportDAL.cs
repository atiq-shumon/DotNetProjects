using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DUtility;
using AH.DRUGS.MODEL;
using AH.PHRMS.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace AH.PHRMS.DAL
{
    public class PHRMSReportDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region GetDrugsCompanyWise
        public List<ProductListRO> GetDrugsCompanyWise(string company)
        {
            string packageName = "PKG_DRUG_SETUP.Get_DrugList_CompanyWise";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Company",OracleDbType.Varchar2,6,company,ParameterDirection.Input)
            };
            return GetDrugsList(packageName, parameterList);
        }
        private List<ProductListRO> GetDrugsList(string packageName, OracleParameter[] parameterList)
        {
            List<ProductListRO> drls = new List<ProductListRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ProductListRO rpt = new ProductListRO();

                
                rpt.DrugID = (string)rdr[0];
                rpt.DrugName = (string)rdr[1];
                rpt.DrugNameBangla = (string)rdr[2]; 
                rpt.CompanyID = (string)rdr[3];
                rpt.CompanyName = (string)rdr[4];
                rpt.GroupID = (string)rdr[5];
                rpt.GroupName = (string)rdr[6];
                rpt.GroupNameBangla = (string)rdr[7];
                rpt.TypeID = (string)rdr[8];
                rpt.PackName = (string)rdr[9];
                rpt.PackNameBangla = (string)rdr[10];
                rpt.UnitID = (string)rdr[11];
                rpt.UnitName = (string)rdr[12];
                rpt.UnitNameBangla = (string)rdr[13];
                rpt.Reorder_Qty = int.Parse(rdr[14].ToString());
                rpt.Priority = int.Parse(rdr[15].ToString());
                rpt.Serial_Priority = int.Parse(rdr[16].ToString());
                rpt.Remarks = !rdr.IsDBNull(17) ? (string)rdr[17] : "";
                rpt.Urate = Single.Parse(rdr[18].ToString());
                rpt.VAT = Single.Parse(rdr[19].ToString());
                rpt.Disc = Single.Parse(rdr[20].ToString());
                rpt.Rack_Rate = Single.Parse(rdr[21].ToString());
                rpt.Sl_Rate = Single.Parse(rdr[22].ToString());
                rpt.Stock_Qty = Int32.Parse(rdr[23].ToString());
                drls.Add(rpt);
            }
            rdr.Close();
            return drls;
        }
        #endregion

        #region GetSalesReport
        public List<SalesReportRO> GetSalesReport(string issueid)
        {
            string packageName = "PKG_SALES_REPORT.Get_PhrSales";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueId",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input)
            };
            return GetSales(packageName,parameterList);
        }
        public List<SalesReportRO> GetSalesReportDet(string startDate,string endDate)
        {
            string packageName = "PKG_SALES_REPORT.Get_PhrSales";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                //new OracleParameter("IssueId",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetSales(packageName, parameterList);
        }
        public List<SalesReportRO> GetSalRetReport(string issueid)
        {
            string packageName = "PKG_SALES_REPORT.Get_PhrSalesReturn";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueId",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input)
            };
            return GetSales(packageName, parameterList);
        }
        public List<SalesReportRO> GetSalRetReportDet(string startDate, string endDate)
        {
            string packageName = "PKG_SALES_REPORT.Get_PhrSalRetDatewise";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                //new OracleParameter("IssueId",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetSales(packageName, parameterList);
        }
        private List<SalesReportRO> GetSales(string packageName, OracleParameter[] parameterList)
        {
            List<SalesReportRO> osales = new List<SalesReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                SalesReportRO orpt = new SalesReportRO();
                orpt.Issue_id = (string)rdr["issue_id"];
                orpt.Phr_id = (string)rdr["phr_id"];
                orpt.PharmacyTitle = (string)rdr["pharmacytitle"];
                orpt.DrugGroup = (string)rdr["druggroup"];
                orpt.DrugType = (string)rdr["drugtype"];
                orpt.DrugUnit = (string)rdr["drugunit"];
                orpt.DrugName = (string)rdr["drugname"];
                orpt.DrugCompany = (string)rdr["drugcompany"];
                orpt.ReqQty = Single.Parse(rdr["reqqty"].ToString());
                orpt.Quantity = Single.Parse(rdr["quantity"].ToString());
                orpt.ReturnQty = !rdr.IsDBNull(rdr.GetOrdinal("RETURNQTY")) ? Convert.ToSingle(rdr["RETURNQTY"]) : 0;
                orpt.NetQty = !rdr.IsDBNull(rdr.GetOrdinal("QTY")) ? Convert.ToSingle(rdr["QTY"]) : 0;
                orpt.ReturnPrice = !rdr.IsDBNull(rdr.GetOrdinal("RetPrice")) ? Convert.ToSingle(rdr["RetPrice"]) : 0;
                orpt.Qty_Over_Pres = Single.Parse(rdr["qty_over_pres"].ToString());
                orpt.Urate = Single.Parse(rdr["urate"].ToString());
                orpt.Vat = Single.Parse(rdr["vat"].ToString());
                orpt.Disc = Single.Parse(rdr["disc"].ToString());
                orpt.Hcn = (string)rdr["hcn"];
                orpt.PatientName = (string)rdr["PatientName"];
                orpt.PatientAddress = (string)rdr["PatientAddress"];
                orpt.EntryBy = (string)rdr["EntryBy"];
                orpt.EntryDate = DateTime.Parse(rdr["EntryDate"].ToString());
                orpt.Entry_By_Name = (string)rdr["ENTRY_BY_NAME"];
                osales.Add(orpt);
            }
            rdr.Close();
            return osales;
        }
        #endregion

        #region GetDrugStockList

        public List<StockListRO> GetDrugStockList(string groupid, string pharmacyid)
        {
            string packageName = "PKG_SALES_REPORT.GET_STOCKLIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,6,groupid,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,5,pharmacyid,ParameterDirection.Input)
            };
            return GetDrugsStock(packageName,parameterList);
        }
        public List<StockListRO> GetDrugStockListDetails(string pharmacyid)
        {
            string packageName = "PKG_SALES_REPORT.GET_STOCKDETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,5,pharmacyid,ParameterDirection.Input)
            };
            return GetDrugsStock(packageName, parameterList);
        }
        private List<StockListRO> GetDrugsStock(string packageName, OracleParameter[] parameterList)
        {
            List<StockListRO> ostklist = new List<StockListRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                StockListRO stkro = new StockListRO();
                stkro.DrugID = (string)rdr["DRUGID"];
                stkro.DrugName = (string)rdr["DRUGNAME"];
                stkro.DrugNameBangla = (string)rdr["DRUGNAMEBANGLA"];
                stkro.CompanyID = (string)rdr["COMPANYID"];
                stkro.CompanyName = (string)rdr["COMPANYNAME"];
                stkro.GroupID = (string)rdr["GROUPID"];
                stkro.GroupName = (string)rdr["GROUPNAME"];
                stkro.GroupNameBangla = (string)rdr["GROUPNAMEBANGLA"];
                stkro.TypeID = (string)rdr["TYPEID"];
                stkro.PackName = (string)rdr["PACKNAME"];
                stkro.PackNameBangla = (string)rdr["PACKNAMEBANGLA"];
                stkro.UnitID = (string)rdr["UNITID"];
                stkro.UnitName = (string)rdr["UNITNAME"];
                stkro.UnitNameBangla = (string)rdr["UNITNAMEBANGLA"];
                stkro.Reorder_Qty = Single.Parse(rdr["REORDERQTY"].ToString());
                stkro.Priority = Int32.Parse(rdr["PRIORITY"].ToString());
                stkro.Serial_Priority = Int32.Parse(rdr["SLPRIORITY"].ToString());
                stkro.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                stkro.Urate = Single.Parse(rdr["urate"].ToString());
                stkro.Vat = Single.Parse(rdr["vat"].ToString());
                stkro.Disc = Single.Parse(rdr["disc"].ToString());
                stkro.Rack_rate = Single.Parse(rdr["RACK_RATE"].ToString());
                stkro.Sl_rate = Single.Parse(rdr["SL_RATE"].ToString());
                stkro.Phr_id = (string)rdr["PHR_ID"];
                stkro.PharmacyName = (string)rdr["PharmacyName"];
                stkro.Stock_Qty = Single.Parse(rdr["STOCK_QTY"].ToString());
                ostklist.Add(stkro);

            }
            rdr.Close();
            return ostklist;
        }
        #endregion

        #region GetItemRatesReport
        public List<ItemRatesRO> GetItemRatesReport()
        {
            string packageName = "PKG_DRUG_SETUP.GET_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<ItemRatesRO> oitemrate = new List<ItemRatesRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                ItemRatesRO rate = new ItemRatesRO();
                rate.Prod_ID = (string)rdr["prod_id"];
                rate.DrugName = (string)rdr["DrugName"];
                rate.Prod_Type_Id = (string)rdr["prod_type_id"];
                rate.DrugTypeName = (string)rdr["DrugTypeName"];
                rate.Prod_Unit_Id = (string)rdr["prod_unit_id"];
                rate.DrugUnitName = (string)rdr["DrugUnitName"];
                rate.Prod_Grp_Id = (string)rdr["prod_grp_id"];
                rate.DrugGroup = (string)rdr["DrugGroup"];
                rate.Prod_Comp_Id = (string)rdr["prod_comp_id"];
                rate.DrugCompany = (string)rdr["DrugCompany"];
                rate.Prod_Brnd_Id = (string)rdr["prod_brnd_id"];
                rate.Prod_Model_Id = (string)rdr["prod_model_id"];
                rate.Urate = float.Parse(rdr["urate"].ToString());
                rate.Vat = float.Parse(rdr["vat"].ToString());
                rate.Disc = float.Parse(rdr["disc"].ToString());
                rate.rack_rate = float.Parse(rdr["rack_rate"].ToString());
                rate.Sl_Rate = float.Parse(rdr["sl_rate"].ToString());
;
                oitemrate.Add(rate);
            }
            rdr.Close();
            return oitemrate;
        }
        #endregion

        #region GetItemRatesHistReport
        public List<ItemRatesHistRO> GetItemRatesHistReport(string prodid,string startDate,string endDate)
        {
            string packageName = "PKG_DRUG_SETUP.GET_ITEM_RATES_HIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Product ID",OracleDbType.Varchar2,7,prodid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<ItemRatesHistRO> oitemrate = new List<ItemRatesHistRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                ItemRatesHistRO rate = new ItemRatesHistRO();
                rate.Prod_ID = (string)rdr["prod_id"];
                rate.DrugName = (string)rdr["DrugName"];
                rate.Prod_Type_Id = (string)rdr["prod_type_id"];
                rate.DrugTypeName = (string)rdr["DrugTypeName"];
                rate.Prod_Unit_Id = (string)rdr["prod_unit_id"];
                rate.DrugUnitName = (string)rdr["DrugUnitName"];
                rate.Prod_Grp_Id = (string)rdr["prod_grp_id"];
                rate.DrugGroup = (string)rdr["DrugGroup"];
                rate.Prod_Comp_Id = (string)rdr["prod_comp_id"];
                rate.DrugCompany = (string)rdr["DrugCompany"];
                rate.Prod_Brnd_Id = (string)rdr["prod_brnd_id"];
                rate.Prod_Model_Id = (string)rdr["prod_model_id"];
                rate.Urate = float.Parse(rdr["urate"].ToString());
                rate.Vat = float.Parse(rdr["vat"].ToString());
                rate.Disc = float.Parse(rdr["disc"].ToString());
                rate.rack_rate = float.Parse(rdr["rack_rate"].ToString());
                rate.Sl_Rate = float.Parse(rdr["sl_rate"].ToString());
                rate.Date = DateTime.Parse(rdr["entry_date"].ToString());
                rate.EntryBy = (string)rdr["entry_by"];
                oitemrate.Add(rate);
            }
            rdr.Close();
            return oitemrate;
        }
        #endregion

        #region GetMrrReport
        public List<MrrReportRO> GetMrrReportByMrID(string mrid)
        {
            string packageName = "PKG_MRR.GET_MRR_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRID",OracleDbType.Varchar2,15,mrid,ParameterDirection.Input)
            };
            List<MrrReportRO> omrrpt = new List<MrrReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                MrrReportRO omr = new MrrReportRO();
                omr.MRRID = (string)rdr["MRRID"];
                omr.MRRDATE = DateTime.Parse(rdr["MRRDATE"].ToString());
                omr.PharmacyID = (string)rdr["PharmacyID"];
                omr.PharmacyName = (string)rdr["PharmacyName"];
                omr.PRNO = (string)rdr["PRNO"];
                omr.PRDATE = DateTime.Parse(rdr["PRDATE"].ToString());
                omr.POID = (string)rdr["POID"];
                omr.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                omr.ChallanNo = (string)rdr["ChallanNo"];
                omr.ChallanDate = DateTime.Parse(rdr["ChallanDate"].ToString());
                omr.VoucherNo = (string)rdr["VoucherNo"];
                omr.SupplierID = (string)rdr["SupplierID"];
                omr.SupplierName = (string)rdr["SupplierName"];
                omr.ProductID = (string)rdr["ProductID"];
                omr.ProductName = (string)rdr["ProductName"];
                omr.TypeID = (string)rdr["PackageType"];
                omr.UnitID = (string)rdr["UnitID"];
                omr.UnitName = (string)rdr["UnitName"];
                omr.GroupID = (string)rdr["GroupID"];
                omr.GroupName = (string)rdr["GroupName"];
                omr.CompanyID = (string)rdr["CompanyID"];
                omr.CompanyName = (string)rdr["CompanyName"];
                
                omr.Rate = float.Parse(rdr["Rate"].ToString());
                omr.Vat = float.Parse(rdr["VAT"].ToString());
                omr.Discount = float.Parse(rdr["Discount"].ToString());
                omr.Quantity = float.Parse(rdr["Quantity"].ToString());
                omr.RequisitionQty = float.Parse(rdr["REQQTY"].ToString());
                omr.POQty = float.Parse(rdr["POQty"].ToString());
                omr.TransactionType = (string)rdr["TransactionType"];
                omr.Day = DateTime.Parse(rdr["Day"].ToString());
                //omr.EntryBy = (string)rdr["EntryBy"];
                omr.Entry_By_Name = (string)rdr["ENTRY_BY_NAME"];
                omrrpt.Add(omr);
            }
            rdr.Close();
            return omrrpt;
        }
        #endregion

        #region GetPRreport
        public List<PRReportRO> GetPRreport(string prid)
        {
            string packageName = "PKG_PR.PR_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            List<PRReportRO> oprreport = new List<PRReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PRReportRO orpt = new PRReportRO();
                orpt.PRID = (string)rdr["PRID"];
                orpt.PRDATE = DateTime.Parse(rdr["PRDATE"].ToString());
                orpt.Qty = float.Parse(rdr["QTY"].ToString());
                orpt.PHARMACYID = (string)rdr["PHARMACYID"];
                orpt.PHARMACYNAME = (string)rdr["PHARMACYNAME"];
                orpt.DRUGID = (string)rdr["DRUGID"];
                orpt.DRUGNAME = (string)rdr["DRUGNAME"];
                orpt.COMPANYID = (string)rdr["COMPID"];
                orpt.COMPANYNAME = (string)rdr["COMPANYNAME"];
                orpt.GROUPID = (string)rdr["GROUPID"];
                orpt.GROUPNAME = (string)rdr["GROUPNAME"];
                orpt.UNITID = (string)rdr["UNITID"];
                orpt.UNITNAME = (string)rdr["UNITNAME"];
                orpt.PACKTYPEID = (string)rdr["PACKTYPEID"];
                orpt.TYPENAME = (string)rdr["TYPENAME"];
                
                orpt.LPRATE = float.Parse(rdr["LPRATE"].ToString());
                if (rdr["LPDATE"].ToString() != "")
                {
                    orpt.LPDATE = rdr["LPDATE"].ToString();
                }
                else
                {
                    orpt.LPDATE = "--";
                }
                //orpt.LPDATE = !rdr.IsDBNull(rdr.GetOrdinal("LPDATE")) ? Convert.ToDateTime(rdr["LPDATE"]) : "--";
                orpt.CURRENTSTOCK = float.Parse(rdr["CURRENTSTOCK"].ToString());
                orpt.REMARKS = !rdr.IsDBNull(rdr.GetOrdinal("REMARKS")) ? (string)rdr["REMARKS"] : "";
                orpt.EntryById = (string)rdr["EntryById"];
                orpt.EntryByName = (string)rdr["ENTRY_BY_NAME"];
                oprreport.Add(orpt);
            }
            rdr.Close();
            return oprreport;
        }
        #endregion

    }
}
