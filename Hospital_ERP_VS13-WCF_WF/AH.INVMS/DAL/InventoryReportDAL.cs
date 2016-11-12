using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.DUtility;
using AH.INVMS.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class InventoryReportDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region ItemListsReport
        public List<ItemListRO> GetItemListGroupWise(string groupid)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_ITEM_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,6,groupid,ParameterDirection.Input)
            };
            return GetItems(packageName,parameterList);
        }
       
        private List<ItemListRO> GetItems(string packageName,OracleParameter[] parameterList)
        {

            List<ItemListRO> omaster = new List<ItemListRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                ItemListRO oitm = new ItemListRO();
                oitm.ItemID = (string)rdr["ItemID"];
                oitm.ItemName = (string)rdr["ItemName"];
                oitm.ItemNameBengali = (string)rdr["ItemNameBengali"];
                oitm.CompanyID = (string)rdr["CompanyID"];
                oitm.CompanyName = (string)rdr["CompanyName"];
                oitm.GroupID = (string)rdr["GroupID"];
                oitm.GroupName = (string)rdr["GroupName"];
                oitm.GroupNameBengali = (string)rdr["GroupNameBengali"];
                oitm.UnitID = (string)rdr["UnitID"];
                oitm.UnitName = (string)rdr["UnitName"];
                oitm.TypeID = (string)rdr["TypeID"];
                oitm.TypeName = (string)rdr["TypeName"];
                oitm.TypeNameBengali = (string)rdr["TypeNameBengali"];
                oitm.ModelID = (string)rdr["ModelID"];
                oitm.ModelName = (string)rdr["ModelName"];
                oitm.BrandID = (string)rdr["BrandID"];
                oitm.BrandName = (string)rdr["BrandName"];
                oitm.ReorderQty = int.Parse(rdr["ReorderQty"].ToString());
                oitm.Priority = int.Parse(rdr["Priority"].ToString());
                oitm.SerialPriority = int.Parse(rdr["SerialPriority"].ToString());
                oitm.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                oitm.ISEXPREQ = !rdr.IsDBNull(rdr.GetOrdinal("ISEXPREQ")) ? (string)rdr["ISEXPREQ"] : "";
                oitm.Rate = Single.Parse(rdr["Rate"].ToString());
                oitm.VAT = Single.Parse(rdr["VAT"].ToString());
                oitm.Discount = Single.Parse(rdr["Discount"].ToString());
                oitm.RackRate = Single.Parse(rdr["RackRate"].ToString());
                oitm.SlRate = Single.Parse(rdr["SlRate"].ToString());
                oitm.Stock = !rdr.IsDBNull(rdr.GetOrdinal("Stock")) ? Convert.ToSingle(rdr["Stock"]) : 0;

                omaster.Add(oitm);
            }
            rdr.Close();
            return omaster;
        }
        #endregion

        #region ItemListGroupAndStoreWise
        public List<ItemListGrpStrWiseRO> GetItemGroupStoretypeWise(string storetype, string majorgroup)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_ITEM_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreTypeID",OracleDbType.Varchar2,2,storetype,ParameterDirection.Input),
                new OracleParameter("GroupID",OracleDbType.Varchar2,6,majorgroup,ParameterDirection.Input)
            };
            return GetItemMajorGrpStrType(packageName, parameterList);
        }
        private List<ItemListGrpStrWiseRO> GetItemMajorGrpStrType(string packageName,OracleParameter[] parameterList)
        {
            List<ItemListGrpStrWiseRO> oitemsmjrstr = new List<ItemListGrpStrWiseRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                ItemListGrpStrWiseRO oitm = new ItemListGrpStrWiseRO();
                oitm.ID = (string)rdr["itemid"];
                oitm.Name = (string)rdr["itemname"];
                oitm.NameBeng = (string)rdr["itemnamebengali"];
                oitm.ReorderQty = int.Parse(rdr["ReorderQty"].ToString());
                oitm.ReorderCycle = int.Parse(rdr["ReorderCycle"].ToString());
                oitm.Priority = int.Parse(rdr["Priority"].ToString());
                oitm.SerialPriority = int.Parse(rdr["SerialPriority"].ToString());
                oitm.Day = DateTime.Parse(rdr["Day"].ToString());
                oitm.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                //oitm.StoreType = (string)rdr["STORETYPE"];
                oitm.IsExpDate = !rdr.IsDBNull(rdr.GetOrdinal("ISEXPREQ")) ? (string)rdr["ISEXPREQ"] : "";
                oitm.IsSerial = !rdr.IsDBNull(rdr.GetOrdinal("IS_SERIAL_REQ")) ? (string)rdr["IS_SERIAL_REQ"] : "";
                oitm.IsBillable = !rdr.IsDBNull(rdr.GetOrdinal("IS_BILLABLE")) ? (string)rdr["IS_BILLABLE"] : "";
                oitm.IsWarranty = !rdr.IsDBNull(rdr.GetOrdinal("IS_WARRANTY_APP")) ? (string)rdr["IS_WARRANTY_APP"] : "";

                oitm.Urate = !rdr.IsDBNull(rdr.GetOrdinal("Rate")) ? Convert.ToSingle(rdr["Rate"]) : 0;
                oitm.VAT = !rdr.IsDBNull(rdr.GetOrdinal("Vat")) ? Convert.ToSingle(rdr["Vat"]) : 0;
                oitm.Discount = !rdr.IsDBNull(rdr.GetOrdinal("DISCOUNT")) ? Convert.ToSingle(rdr["DISCOUNT"]) : 0;
                oitm.Rackrate = !rdr.IsDBNull(rdr.GetOrdinal("Rackrate")) ? Convert.ToSingle(rdr["Rackrate"]) : 0;
                oitm.Slrate = !rdr.IsDBNull(rdr.GetOrdinal("Slrate")) ? Convert.ToSingle(rdr["Slrate"]) : 0;
                oitm.StockQty = !rdr.IsDBNull(rdr.GetOrdinal("Stock")) ? Convert.ToSingle(rdr["Stock"]) : 0;

                oitm.strTypeID = !rdr.IsDBNull(rdr.GetOrdinal("STORETYPE")) ? (string)rdr["STORETYPE"] : "";
                oitm.TypeTitle = !rdr.IsDBNull(rdr.GetOrdinal("STORETYPENAME")) ? (string)rdr["STORETYPENAME"] : "";

                oitm.MajorgrpID = (string)rdr["MAJORGROUPID"];
                oitm.MajorgrpName = (string)rdr["MAJORGROUPNAME"];

                oitm.CompanyID = (string)rdr["companyid"];
                oitm.CompanyName = (string)rdr["companyname"];

                oitm.GroupID = (string)rdr["groupid"];
                oitm.GroupName = (string)rdr["groupname"];
                oitm.GroupNameBeng = (string)rdr["groupnamebengali"];

                oitm.PacketTypeID = (string)rdr["typeid"];
                oitm.PacketTypeName = (string)rdr["typename"];
                oitm.PacketTypeNameBeng = (string)rdr["typenamebengali"];

                oitm.UnitID = (string)rdr["unitid"];
                oitm.UnitName = (string)rdr["unitname"];

                oitm.ModelID = (string)rdr["modelid"];
                oitm.ModelName = (string)rdr["modelname"];

                oitm.BrandID = (string)rdr["brandid"];
                oitm.BrandName = (string)rdr["brandname"];

                oitemsmjrstr.Add(oitm);
            }
            rdr.Close();
            return oitemsmjrstr;
        }
        #endregion

        #region StockDetailsReport
        public List<StockListRO> GetStockDetailsStoreWise(string storeid)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_STOCKLIST_STOREWISE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,5,storeid,ParameterDirection.Input)
            };
            return GetStore(packageName,parameterList);
        }
        private List<StockListRO> GetStore(string packageName, OracleParameter[] parameterList)
        {
            List<StockListRO> ostock = new List<StockListRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                StockListRO oitm = new StockListRO();
                oitm.ItemID = (string)rdr["ItemID"];
                oitm.ItemName = (string)rdr["ItemName"];

                oitm.CompanyID = (string)rdr["CompanyID"];
                oitm.CompanyName = (string)rdr["CompanyName"];
                oitm.GroupID = (string)rdr["GroupID"];
                oitm.GroupName = (string)rdr["GroupName"];
                
                oitm.UnitID = (string)rdr["UnitID"];
                oitm.UnitName = (string)rdr["UnitName"];
                oitm.TypeID = (string)rdr["TypeID"];
                oitm.TypeName = (string)rdr["TypeName"];
               
                oitm.ModelID = (string)rdr["ModelID"];
                oitm.ModelName = (string)rdr["ModelName"];
                oitm.BrandID = (string)rdr["BrandID"];
                oitm.BrandName = (string)rdr["BrandName"];

                oitm.STOREID = (string)rdr["StoreID"];
                oitm.StoreName = (string)rdr["StoreName"];

                oitm.Rate = !rdr.IsDBNull(rdr.GetOrdinal("Rate")) ? Convert.ToSingle(rdr["Rate"]) : 0;
                oitm.Vat = !rdr.IsDBNull(rdr.GetOrdinal("Vat")) ? Convert.ToSingle(rdr["Vat"]) : 0;
                oitm.DISCOUNT = !rdr.IsDBNull(rdr.GetOrdinal("DISCOUNT")) ? Convert.ToSingle(rdr["DISCOUNT"]) : 0;
                oitm.STOCK = !rdr.IsDBNull(rdr.GetOrdinal("STOCK")) ? Convert.ToSingle(rdr["STOCK"]) : 0;


                ostock.Add(oitm);
            }
            rdr.Close();
            return ostock;
        }
        #endregion

        #region GetProductLedger
        public List<ProductLedgerRO> GetProductLedger(string prodid, string startDate, string endDate)
        {
            string packageName = "PKG_PRODUCT_LEDGER.PRODUCT_LEDGER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ProductID",OracleDbType.Varchar2,7,prodid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<ProductLedgerRO> oprod = new List<ProductLedgerRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ProductLedgerRO opled = new ProductLedgerRO();
                opled.Transac = (string)rdr["Transac"];
                opled.Product = (string)rdr["Product"];
                opled.ProductName = (string)rdr["ProductName"];
                opled.Qty = Single.Parse(rdr["Qty"].ToString());
                opled.Rate = Single.Parse(rdr["Rate"].ToString());
                opled.Vat = Single.Parse(rdr["Vat"].ToString());
                opled.Discount = Single.Parse(rdr["Discount"].ToString());
                opled.Supplier = (string)rdr["Supplier"].ToString();
                opled.SupplierName = (string)rdr["SupplierName"].ToString();
                opled.StoreID = (string)rdr["storeid"].ToString();
                opled.StoreName = (string)rdr["storename"].ToString();
                opled.DT = DateTime.Parse(rdr["DT"].ToString());
                oprod.Add(opled);
            }
            rdr.Close();
            return oprod;
        }
        #endregion

        #region GetPOReportDateWise
        public List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_POREPORT_DATEWISE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetPOLists(packageName, parameterList);
        }
        private List<PODetailsRO> GetPOLists(string packageName, OracleParameter[] parameterList)
        {
            List<PODetailsRO> podet = new List<PODetailsRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PODetailsRO po = new PODetailsRO();
                po.POID = (string)rdr["POID"];
                po.PRID = (string)rdr["PRID"];
                po.StoreID = (string)rdr["StoreID"];
                po.StoreName = (string)rdr["StoreName"];
                po.TransactionType = (string)rdr["TransactionType"];
                po.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                po.POTYPE = (string)rdr["POTYPE"];
                po.SupplierID = (string)rdr["SupplierID"];
                po.SupplierName = (string)rdr["SupplierName"];
                po.ItemID = (string)rdr["ItemID"];
                po.ItemName = (string)rdr["ItemName"];
                po.CompanyID = (string)rdr["CompanyID"];
                po.CompanyName = (string)rdr["CompanyName"];
                po.GroupID = (string)rdr["GroupID"];
                po.GroupName = (string)rdr["GroupName"];
                po.UnitID = (string)rdr["UnitID"];
                po.UnitName = (string)rdr["UnitName"];
                po.TypeID = (string)rdr["TypeID"];
                po.TypeName = (string)rdr["TypeName"];
                po.ModelID = (string)rdr["ModelID"];
                po.ModelName = (string)rdr["ModelName"];
                po.BrandID = (string)rdr["BrandID"];
                po.BrandName = (string)rdr["BrandName"];
                po.Rate = Single.Parse(rdr["Rate"].ToString());
                po.Vat = Single.Parse(rdr["Vat"].ToString());
                po.Discount = Single.Parse(rdr["Discount"].ToString());
                po.RequisitionQty = Single.Parse(rdr["RequisitionQty"].ToString());               
                po.POQty = Single.Parse(rdr["POQty"].ToString());
                po.RemainingQty = Single.Parse(rdr["RemainingQty"].ToString());
                po.ReturnQty = Single.Parse(rdr["ReturnQty"].ToString());               
                podet.Add(po);
            }
            rdr.Close();
            return podet;

        }
        #endregion

        #region GetIssueReportDateWise
        public List<IssueReportRO> GetIssueReportDateWise(string startDate, string endDate)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_ISSUEREPORT_DATEWISE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetIssueList(packageName,parameterList);
        }

        public List<IssueReportRO> GetIssueReportGroupWise(string groupid,string startDate, string endDate)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_ISSUEREPORT_GROUPDATEWISE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,6,groupid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetIssueList(packageName, parameterList);
        }
        private List<IssueReportRO> GetIssueList(string packageName, OracleParameter[] parameterList)
        {
            List<IssueReportRO> osales = new List<IssueReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                IssueReportRO orpt = new IssueReportRO();
                orpt.IssueId = (string)rdr["IssueId"];
                //orpt.IRID = (string)rdr["DRID"];
                orpt.StoreID = (string)rdr["StoreID"];
                orpt.StoreName = (string)rdr["StoreName"];
                orpt.WarehouseID = (string)rdr["WAREHOUSEID"];
                orpt.WarehouseName = (string)rdr["WAREHOUSENAME"];
                orpt.ItemGroup = (string)rdr["ItemGroup"];
                orpt.ItemType = (string)rdr["ItemType"];
                orpt.ItemUnit = (string)rdr["ItemUnit"];
                orpt.ItemName = (string)rdr["ItemName"];
                orpt.ItemCompany = (string)rdr["ItemCompany"];
                orpt.ModelName = (string)rdr["ModelName"];
                orpt.BrandName = (string)rdr["BrandName"];
                orpt.ReqQty = Single.Parse(rdr["reqqty"].ToString());
                orpt.Quantity = Single.Parse(rdr["quantity"].ToString());

                orpt.Rate = Single.Parse(rdr["Rate"].ToString());
                orpt.Vat = Single.Parse(rdr["vat"].ToString());
                orpt.Discount = Single.Parse(rdr["Discount"].ToString());
                orpt.Hcn = (string)rdr["hcn"];
                orpt.PatientName = !rdr.IsDBNull(rdr.GetOrdinal("PatientName")) ? (string)rdr["PatientName"] : "";
                orpt.EntryBy = (string)rdr["entryby"];
                orpt.EntryDate = DateTime.Parse(rdr["entrydate"].ToString());

                osales.Add(orpt);
            }
            rdr.Close();
            return osales;
        }
        #endregion

        #region GetPOReport
        public List<PODetailsRO> GetPOReport(string poid)
        {
            string packageName = "PKG_PO.GET_PODET_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
            };
            List<PODetailsRO> oporder = new List<PODetailsRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PODetailsRO po = new PODetailsRO();
                po.POID = (string)rdr["POID"];
                po.PRID = (string)rdr["PRID"];
                po.StoreID = (string)rdr["StoreID"];
                po.StoreName = (string)rdr["StoreName"];
                po.TransactionType = (string)rdr["TransactionType"];
                po.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                po.DeliveryDate = DateTime.Parse(rdr["DELIVERYDATE"].ToString());
                po.POTYPE = (string)rdr["POTYPE"];
                po.SupplierID = (string)rdr["SupplierID"];
                po.SupplierName = (string)rdr["SupplierName"];
                po.SupplierAddress = !rdr.IsDBNull(rdr.GetOrdinal("SupplierAddress")) ? (string)rdr["SupplierAddress"] : "";
                po.SupplierPhone = !rdr.IsDBNull(rdr.GetOrdinal("SupplierPhone")) ? (string)rdr["SupplierPhone"] : "";
                po.SupplierFax = !rdr.IsDBNull(rdr.GetOrdinal("SupplierFax")) ? (string)rdr["SupplierFax"] : "";
                po.ItemID = (string)rdr["ItemID"];
                po.ItemName = (string)rdr["ItemName"];
                po.CompanyID = (string)rdr["CompanyID"];
                po.CompanyName = (string)rdr["CompanyName"];
                po.GroupID = (string)rdr["GroupID"];
                po.GroupName = (string)rdr["GroupName"];
                po.UnitID = (string)rdr["UnitID"];
                po.UnitName = (string)rdr["UnitName"];
                po.TypeID = (string)rdr["TypeID"];
                po.TypeName = (string)rdr["TypeName"];
                po.ModelID = (string)rdr["ModelID"];
                po.ModelName = (string)rdr["ModelName"];
                po.BrandID = (string)rdr["BrandID"];
                po.BrandName = (string)rdr["BrandName"];
                po.Rate = Single.Parse(rdr["Rate"].ToString());
                po.Vat = Single.Parse(rdr["Vat"].ToString());
                po.Discount = Single.Parse(rdr["Discount"].ToString());
                po.DeliveryNote = !rdr.IsDBNull(rdr.GetOrdinal("DELIVERYNOTE")) ? (string)rdr["DELIVERYNOTE"] : "";
                po.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                po.RequisitionQty = !rdr.IsDBNull(rdr.GetOrdinal("RequisitionQty")) ? Convert.ToSingle(rdr["RequisitionQty"]) : 0;
                po.POQty = Single.Parse(rdr["POQty"].ToString());
                po.RemainingQty = Single.Parse(rdr["RemainingQty"].ToString());
                po.ReturnQty = Single.Parse(rdr["ReturnQty"].ToString());
                po.Entry_By_Name = (string)rdr["ENTRY_BY_NAME"];
                oporder.Add(po);
            }
            rdr.Close();
            return oporder;
        }
        #endregion

        #region GetMrrReport
        public List<MrrReportRO> GetMrrReport(string mrid)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_MRR_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MRID",OracleDbType.Varchar2,15,mrid,ParameterDirection.Input)
            };
            List<MrrReportRO> omrrpt = new List<MrrReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                MrrReportRO omr = new MrrReportRO();
                omr.MRRID = (string)rdr["MRRID"];
                omr.MRRDATE = DateTime.Parse(rdr["MRRDATE"].ToString());
                omr.StoreID = (string)rdr["StoreID"];
                omr.StoreName = (string)rdr["StoreName"];
                omr.PRNO = (string)rdr["PRNO"];
                omr.PRDATE = DateTime.Parse(rdr["PRDATE"].ToString());
                omr.POID = (string)rdr["POID"];
                omr.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                omr.ChallanNo = (string)rdr["ChallanNo"];
                omr.ChallanDate = DateTime.Parse(rdr["ChallanDate"].ToString());
                omr.VoucherNo = (string)rdr["VoucherNo"];
                omr.SupplierID = (string)rdr["SupplierID"];
                omr.SupplierName = (string)rdr["SupplierName"];
                omr.ItemID = (string)rdr["ItemID"];
                omr.ItemName = (string)rdr["ItemName"];
                omr.TypeID = (string)rdr["TypeID"];
                omr.UnitID = (string)rdr["UnitID"];
                omr.UnitName = (string)rdr["UnitName"];
                omr.GroupID = (string)rdr["GroupID"];
                omr.GroupName = (string)rdr["GroupName"];
                omr.CompanyID = (string)rdr["CompanyID"];
                omr.CompanyName = (string)rdr["CompanyName"];
                omr.ModelID = (string)rdr["ModelID"];
                omr.ModelName = (string)rdr["ModelName"];
                omr.BrandID = (string)rdr["BrandID"];
                omr.BrandName = (string)rdr["BrandName"];
                omr.Rate = float.Parse(rdr["Rate"].ToString());
                omr.Vat = float.Parse(rdr["VAT"].ToString());
                omr.Discount = float.Parse(rdr["Discount"].ToString());
                omr.Quantity = float.Parse(rdr["Quantity"].ToString());
                omr.RequisitionQty = float.Parse(rdr["RequisitionQty"].ToString());
                omr.POQty = float.Parse(rdr["POQty"].ToString());
                omr.TransactionType = (string)rdr["TransactionType"];
                omr.Day = DateTime.Parse(rdr["Day"].ToString());
                omr.EntryBy = (string)rdr["EntryBy"];
                omr.Entry_By_Name = (string)rdr["ENTRY_BY_NAME"];
                omrrpt.Add(omr);
            }
            rdr.Close();
            return omrrpt;
        }
        #endregion

        #region GetOpeningReport
        public List<MrrReportRO> GetOpeningReport(string mrid)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_OPENING_DETAILS";
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
                omr.StoreID = (string)rdr["StoreID"];
                omr.StoreName = (string)rdr["StoreName"];
               
               
               
                omr.ItemID = (string)rdr["ItemID"];
                omr.ItemName = (string)rdr["ItemName"];
                omr.TypeID = (string)rdr["TypeID"];
                omr.UnitID = (string)rdr["UnitID"];
                omr.UnitName = (string)rdr["UnitName"];
                omr.GroupID = (string)rdr["GroupID"];
                omr.GroupName = (string)rdr["GroupName"];
                omr.CompanyID = (string)rdr["CompanyID"];
                omr.CompanyName = (string)rdr["CompanyName"];
                omr.ModelID = (string)rdr["ModelID"];
                omr.ModelName = (string)rdr["ModelName"];
                omr.BrandID = (string)rdr["BrandID"];
                omr.BrandName = (string)rdr["BrandName"];
                omr.Rate = float.Parse(rdr["Rate"].ToString());
                omr.Vat = float.Parse(rdr["VAT"].ToString());
                omr.Discount = float.Parse(rdr["Discount"].ToString());
                omr.Quantity = float.Parse(rdr["Quantity"].ToString());
                omr.RequisitionQty = float.Parse(rdr["RequisitionQty"].ToString());
                omr.POQty = float.Parse(rdr["POQty"].ToString());
                omr.TransactionType = (string)rdr["TransactionType"];
                omr.Day = DateTime.Parse(rdr["Day"].ToString());
                omr.EntryBy = (string)rdr["EntryBy"];

                omrrpt.Add(omr);
            }
            rdr.Close();
            return omrrpt;
        }
        #endregion

        #region SalesReport
        public List<SalesReportRO> GetSalesReport(string issueid)
        {
            string packageName = "PKG_SALES_REPORT.Get_Sales";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input)
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
                SalesReportRO osal = new SalesReportRO();
                osal.Issue_id = (string)rdr["Issue_id"];
                osal.Str_id = (string)rdr["Str_id"];
                osal.StoreTitle = (string)rdr["StoreName"];
                osal.DRID = (string)rdr["REQID"];
                osal.DeptID = (string)rdr["DeptID"];
                osal.DeptName = (string)rdr["DEPARTMENTNAME"];
                osal.UnitID = (string)rdr["UNITID"];
                osal.UnitName = (string)rdr["DEPTUNITNAME"];
                osal.ItemGroup = (string)rdr["GROUPNAME"];
                osal.ItemType = (string)rdr["TYPENAME"];
                osal.ItemUnit = (string)rdr["UNITNAME"];
                osal.ItemName = (string)rdr["ITEMNAME"];
                osal.ItemCompany = (string)rdr["COMPANYNAME"];
                osal.ItemBrand = (string)rdr["BRANDNAME"];
                osal.ItemModel = (string)rdr["MODELNAME"];
                osal.ReqQty = float.Parse(rdr["ReqQty"].ToString());
                osal.IssueQty = float.Parse(rdr["IssueQty"].ToString());
                osal.Urate = float.Parse(rdr["URATE"].ToString());
                osal.Vat = !rdr.IsDBNull(rdr.GetOrdinal("VAT")) ? Convert.ToSingle(rdr["VAT"]) : 0;
                osal.Disc = !rdr.IsDBNull(rdr.GetOrdinal("DISC")) ? Convert.ToSingle(rdr["DISC"]) : 0;
                osal.EntryBy = (string)rdr["EntryBy"];
                osal.EntryDate = DateTime.Parse(rdr["EntryDate"].ToString());
                osal.ENTRY_BY_NAME = (string)rdr["ENTRY_BY_NAME"];

                osales.Add(osal);
            }
            rdr.Close();
            return osales;
        }
        #endregion

        #region GetStockDetailsReport
        public List<StockDetailsReportRO> GetStockDetailsReport(string grpid, string startDate, string endDate)
        {
            string packageName = "PKG_STOCK_DETAILS_REPORT.STOCK_DETAILS_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupID",OracleDbType.Varchar2,7,grpid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetStockDetails(packageName, parameterList);
        }
        private List<StockDetailsReportRO> GetStockDetails(string packageName, OracleParameter[] parameterList)
        {
            List<StockDetailsReportRO> oprod = new List<StockDetailsReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                StockDetailsReportRO opled = new StockDetailsReportRO();
               
                opled.Product = (string)rdr["Product"];
                opled.ProductName = (string)rdr["ProductName"];
                opled.GroupID = (string)rdr["GROUPID"];
                opled.GroupName = (string)rdr["GROUPNAME"];
                opled.OpenQty = Single.Parse(rdr["openqty"].ToString());
                opled.OpenRate = Single.Parse(rdr["openrate"].ToString());
                opled.PurchaseQty = Single.Parse(rdr["purchaseqty"].ToString());
                opled.PurchaseRate = Single.Parse(rdr["purchaserate"].ToString());
                opled.SalesQty = Single.Parse(rdr["salesqty"].ToString());
                opled.SalesRate = Single.Parse(rdr["salesrate"].ToString());
                opled.ClosingQty = Single.Parse(rdr["closingqty"].ToString());
                opled.ClosingRate = Single.Parse(rdr["closingrate"].ToString());
                //opled.Vat = Single.Parse(rdr["Vat"].ToString());
                //opled.Discount = Single.Parse(rdr["Discount"].ToString());
               
                opled.StoreID = (string)rdr["storeid"].ToString();
                opled.StoreName = (string)rdr["storename"].ToString();

               
                oprod.Add(opled);
            }
            rdr.Close();
            return oprod;
        }
        #endregion

        #region GetPOTermsConditions
        public List<POTermsConditionRO> GetPOTermsConditions(string poid)
        {
            string packageName = "PKG_PO.GET_PO_TERMSCONDITIONS";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input),
            };
            return GetPOTerms(packageName,parameterList);
        }
        private List<POTermsConditionRO> GetPOTerms(string packageName, OracleParameter[] parameterList)
        {
            List<POTermsConditionRO> opoterms = new List<POTermsConditionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                POTermsConditionRO oterm = new POTermsConditionRO();
                oterm.StoreID = (string)rdr["str_id"];
                oterm.POID = (string)rdr["po_id"];
                oterm.TermsID = (string)rdr["terms_id"];
                oterm.TermsName = (string)rdr["TERMSNAME"];

                opoterms.Add(oterm);
            }
            rdr.Close();
            return opoterms;
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
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                PRReportRO orpt = new PRReportRO();
                orpt.PRID = (string)rdr["PRID"];
                orpt.PRDATE = DateTime.Parse(rdr["PRDATE"].ToString());
                orpt.Qty = float.Parse(rdr["QTY"].ToString());
                orpt.STOREID = (string)rdr["STOREID"];
                orpt.STORENAME = (string)rdr["STORENAME"];
                orpt.ItemID = (string)rdr["ItemID"];
                orpt.ItemName = (string)rdr["ItemName"];
                orpt.CompanyID = (string)rdr["CompanyID"];
                orpt.CompanyName = (string)rdr["CompanyName"];
                orpt.GroupID = (string)rdr["GroupID"];
                orpt.GroupName = (string)rdr["GroupName"];
                orpt.UnitID = (string)rdr["UnitID"];
                orpt.UnitName = (string)rdr["UnitName"];
                orpt.TypeID = (string)rdr["TypeID"];
                orpt.TypeName = (string)rdr["TypeName"];
                orpt.BrandID = (string)rdr["BrandID"];
                orpt.BrandName = (string)rdr["BrandName"];
                orpt.ModelID = (string)rdr["ModelID"];
                orpt.ModelName = (string)rdr["ModelName"];
                orpt.STORETYPEID = (string)rdr["STORETYPEID"];
                orpt.STORETYPENAME = (string)rdr["STORETYPENAME"];
                orpt.MAJORGROUPID = (string)rdr["MAJORGROUPID"];
                orpt.MAJORGROUPNAME = (string)rdr["MAJORGROUPNAME"];
                orpt.LPQTY = !rdr.IsDBNull(rdr.GetOrdinal("LPQTY")) ? Convert.ToSingle(rdr["LPQTY"]) : 0;
                orpt.LPRATE = !rdr.IsDBNull(rdr.GetOrdinal("LPRATE")) ? Convert.ToSingle(rdr["LPRATE"]) : 0;
                orpt.LPDATE = !rdr.IsDBNull(rdr.GetOrdinal("LPDATE")) ? (string)rdr["LPDATE"] : "";
                orpt.CURRENTSTOCK = !rdr.IsDBNull(rdr.GetOrdinal("CURRENTSTOCK")) ? Convert.ToSingle(rdr["CURRENTSTOCK"]) : 0;
                orpt.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("REMARKS")) ? (string)rdr["REMARKS"] : "";
                orpt.EntryBy = (string)rdr["EntryById"];
                orpt.EntryByName = (string)rdr["ENTRY_BY_NAME"];
                oprreport.Add(orpt);
            }
            rdr.Close();
            return oprreport;
        }
        #endregion

        #region GetStockReportGroupwise
        public List<StockReportGroupwiseRO> GetStockReportGroupwise(string startDate, string endDate)
        {
            string packageName = "PKG_INVENTORY_REPORT.GET_STOCKREPORT_GROUPWISE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<StockReportGroupwiseRO> ostockrpt = new List<StockReportGroupwiseRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                StockReportGroupwiseRO ostk = new StockReportGroupwiseRO();
                ostk.Itemid = (string)rdr["ItemID"];
                ostk.ItemName = (string)rdr["ItemName"];
                ostk.MinorGroupID = (string)rdr["MINORGROUPID"];
                ostk.MinorGroupName = (string)rdr["MINORGROUPNAME"];
                ostk.MajorGroupID = (string)rdr["MAJORGROUPID"];
                ostk.MajorGroupName = (string)rdr["MAJORGROUPNAME"];
                ostk.Stock = float.Parse(rdr["Stock"].ToString());
                ostk.BatchNo = (string)rdr["BATCHNO"];
                ostk.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                ostk.MrrDate = DateTime.Parse(rdr["MRRDATE"].ToString());
                ostk.SupplierID = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERID")) ? (string)rdr["SUPPLIERID"] : "";
                ostk.SupplierName = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERNAME")) ? (string)rdr["SUPPLIERNAME"] : ""; 
                ostk.PuchaseRate = float.Parse(rdr["PURCHASERATE"].ToString());
                ostk.SalesRate = float.Parse(rdr["SALESRATE"].ToString());
                ostk.GRNNO = (string)rdr["GRNNO"];
                ostk.StockValue = float.Parse(rdr["STOCKVALUE"].ToString());

                ostockrpt.Add(ostk);
            }
            rdr.Close();
            return ostockrpt;
        }
        #endregion

        #region GetDRreport
        public List<DRReportRO> GetDRreport(string drid)
        {
            string packageName = "PKG_DR.GET_DR_REPORT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,drid,ParameterDirection.Input)
            };
            List<DRReportRO> odrreport = new List<DRReportRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                DRReportRO ort = new DRReportRO();
                ort.DRID = (string)rdr["DRID"];
                ort.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                ort.DepartmentID = (string)rdr["DepartmentID"];
                ort.DEPARTMENTNAME = !rdr.IsDBNull(rdr.GetOrdinal("DEPARTMENTNAME")) ? (string)rdr["DEPARTMENTNAME"] : "";
                ort.DEPTUNITID = !rdr.IsDBNull(rdr.GetOrdinal("DEPTUNITID")) ? (string)rdr["DEPTUNITID"] : "";
                ort.DEPTUNITNAME = !rdr.IsDBNull(rdr.GetOrdinal("DEPTUNITNAME")) ? (string)rdr["DEPTUNITNAME"] : "";
                ort.ItemID = (string)rdr["ItemID"];
                ort.ItemName = (string)rdr["ItemName"];
                ort.UnitID = (string)rdr["UnitID"];
                ort.UnitName = (string)rdr["UnitName"];
                ort.CompanyID = (string)rdr["CompanyID"];
                ort.CompanyName = (string)rdr["CompanyName"];
                ort.GroupID = (string)rdr["GroupID"];
                ort.GroupName = (string)rdr["GroupName"];
                ort.BrandID = !rdr.IsDBNull(rdr.GetOrdinal("BrandID")) ? (string)rdr["BrandID"] : "";
                ort.BrandName = !rdr.IsDBNull(rdr.GetOrdinal("BrandName")) ? (string)rdr["BrandName"] : "";
                ort.ModelID = !rdr.IsDBNull(rdr.GetOrdinal("ModelID")) ? (string)rdr["ModelID"] : "";
                ort.ModelName = !rdr.IsDBNull(rdr.GetOrdinal("ModelName")) ? (string)rdr["ModelName"] : "";
                ort.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                ort.DemandQty = !rdr.IsDBNull(rdr.GetOrdinal("DemandQty")) ? Convert.ToSingle(rdr["DemandQty"]) : 0;
                ort.STOCK = !rdr.IsDBNull(rdr.GetOrdinal("STOCK")) ? Convert.ToSingle(rdr["STOCK"]) : 0;
                ort.RaisedReqByName = !rdr.IsDBNull(rdr.GetOrdinal("RaisedReqByName")) ? (string)rdr["RaisedReqByName"] : "";
                ort.RaisedDesigName = !rdr.IsDBNull(rdr.GetOrdinal("RaisedDesigName")) ? (string)rdr["RaisedDesigName"] : "";
                ort.VerifiedReqByName = !rdr.IsDBNull(rdr.GetOrdinal("VERIFIEDBYNAME")) ? (string)rdr["VERIFIEDBYNAME"] : "";
                ort.VerifiedDesigName = !rdr.IsDBNull(rdr.GetOrdinal("VerifiedReqByName")) ? (string)rdr["VerifiedReqByName"] : "";
                odrreport.Add(ort);
            }
            rdr.Close();
            return odrreport;
        }
         #endregion
    }
}
