using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.INVMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class PRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SavePurchaseRequisition
        public string SavePurchaseRequisition(PurchaseRequisition opurchase)
        {
            string packageName = "PKG_PR.SAVE_PR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,opurchase.ID,ParameterDirection.InputOutput),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,opurchase.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,6,opurchase.Warehouse.TypeID,ParameterDirection.Input),
                //new OracleParameter("DemandRequisition",OracleDbType.Varchar2,15,opurchase.DemandRequisition.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,opurchase.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,opurchase.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                //new OracleParameter("Department",OracleDbType.Varchar2,4,opurchase.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,3,opurchase.TransactionType,ParameterDirection.Input),
                new OracleParameter("RequisitionDate",OracleDbType.Date,opurchase.RequisitionDate,ParameterDirection.Input),
                new OracleParameter("DeliveryDate",OracleDbType.Date,opurchase.DeliveryDate,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,2,opurchase.Priority,ParameterDirection.Input),
                new OracleParameter("RequisitionType",OracleDbType.Varchar2,1,opurchase.RequisitionType,ParameterDirection.Input),
                new OracleParameter("RequisitionBy",OracleDbType.Varchar2,30,opurchase.RequisitionBy,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,opurchase.Remarks,ParameterDirection.Input),
                new OracleParameter("RequisitionDetails",OracleDbType.Varchar2,32000,opurchase.PrDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,opurchase.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,opurchase.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,opurchase.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,opurchase.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region ModifyPurchaseRequisition
        public short ModifyPurchaseRequisition(PurchaseRequisition opurchase)
        {
            string packageName = "PKG_PR.MODIFY_PURCHASE_REQ";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,opurchase.ID,ParameterDirection.Input),               
                new OracleParameter("AlterPrDetails",OracleDbType.Varchar2,1000,opurchase.AlterPrDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,opurchase.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,opurchase.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,opurchase.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,opurchase.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
           
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
            //string regno = (string)(OracleString)prm.Value;
            //return regno;
        }
        #endregion

        #region GetPRDetails
        public List<PurchaseRequisition> GetPRDetails(string prid)
        {
            string packageName = "PKG_PR.GET_PRREQ_DETAILS";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPRLists(packageName,paramterList);
        }
        public List<PurchaseRequisition> GetPRDetailsForPR(string prid)
        {
            string packageName = "PKG_PR.GET_PRREQ_DETAILSFOR_PR";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPRLists(packageName, paramterList);
        }
        private List<PurchaseRequisition> GetPRLists(string packageName, OracleParameter[] paramterList)
        {
            List<PurchaseRequisition> opurreq = new List<PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                PurchaseRequisition dem = new PurchaseRequisition();
                dem.ID = (string)rdr["PRID"];
                dem.RequisitionType = (string)rdr["RequisitionType"];
                dem.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                dem.RequisitionQty = float.Parse(rdr["REQUIREDQTY"].ToString());
                dem.RemainingQty = float.Parse(rdr["REMAININGQTY"].ToString());

                Department odept = new Department();
                odept.DepartmentID = !rdr.IsDBNull(rdr.GetOrdinal("DepartmentID")) ? (string)rdr["DepartmentID"] : "";
                odept.DepartmentTitle = !rdr.IsDBNull(rdr.GetOrdinal("DepartmentName")) ? (string)rdr["DepartmentName"] : "";
                dem.Department = odept;

                DepartmentUnit  odeptunit = new DepartmentUnit();
                odeptunit.UnitId = !rdr.IsDBNull(rdr.GetOrdinal("DepartUnitID")) ? (string)rdr["DepartUnitID"] : "";
                odeptunit.UnitTitle = !rdr.IsDBNull(rdr.GetOrdinal("DepartUnitName")) ? (string)rdr["DepartUnitName"] : "";
                dem.DepartmentUnit = odeptunit;


                DemandRequisition odemand = new DemandRequisition();
                odemand.ID = (string)rdr["DRID"];
                dem.DemandRequisition = odemand;

                Warehouse ostore = new Warehouse();
                ostore.TypeID = (string)rdr["StoreID"];
                ostore.TypeName = (string)rdr["StoreName"];
                dem.Warehouse = ostore;

                

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ItemID"];
                omaster.Name = (string)rdr["ItemName"];
                omaster.Urate = float.Parse(rdr["RATE"].ToString());
                omaster.VAT = float.Parse(rdr["VAT"].ToString());
                omaster.Discount = float.Parse(rdr["DISCOUNT"].ToString());
                //omaster.Rackrate = float.Parse(rdr["RACKRATE"].ToString());
                omaster.Slrate = float.Parse(rdr["SLRATE"].ToString());
                omaster.StockQty = float.Parse(rdr["STOCKQTY"].ToString());

                CompanySetup dc = new CompanySetup();
                dc.ID = (string)rdr["CompanyID"];
                dc.Name = (string)rdr["CompanyName"];
                omaster.Company = dc;

                GroupDetails dg = new GroupDetails();
                dg.ID = (string)rdr["GroupID"];
                dg.Name = (string)rdr["GroupName"];
                omaster.GroupDetails = dg;

                PacketType dpac = new PacketType();
                dpac.ID = (string)rdr["TypeID"];
                dpac.Name = (string)rdr["TypeName"];
                omaster.PacketType = dpac;

                Units un = new Units();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];

                omaster.Units = un;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["ModelID"];
                omodel.Name = (string)rdr["ModelName"];
                omaster.ModelSetup = omodel;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BrandID"];
                obrand.Name = (string)rdr["BrandName"];
                omaster.BrandSetup = obrand;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                omaster.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                omaster.StoreType = ostrtype;

                dem.ItemMaster = omaster;


                opurreq.Add(dem);
            }
            rdr.Close();
            return opurreq;
        }
        #endregion

        #region GetPRID
        public List<PurchaseRequisition> GetPRID()
        {
            string packageName = "PKG_PR.GET_PRID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                
            };
            List<PurchaseRequisition> oreq = new List<PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PurchaseRequisition po = new PurchaseRequisition();
                po.ID = (string)rdr["PR_ID"];
                po.RequisitionDate = DateTime.Parse(rdr["REQ_DATE"].ToString());
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetRequisitionTrack
        public List<PurchaseRequisition> GetRequisitionTrack(string storeid,string startDate,string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_REQ_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<PurchaseRequisition> orequisition = new List<PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                PurchaseRequisition oreq = new PurchaseRequisition();
                oreq.ID = (string)rdr["PRID"];
                oreq.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                oreq.RequisitionQty = float.Parse(rdr["REQUIREDQTY"].ToString());

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ItemID"];
                omaster.Name = (string)rdr["ItemName"];
               

                Units un = new Units();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];
                omaster.Units = un;
                oreq.ItemMaster = omaster;

                orequisition.Add(oreq);
            }
            rdr.Close();
            return orequisition;

        }
        #endregion

        #region GetPOTracking
        public List<PurchaseOrder> GetPOTracking(string storeid,string startDate,string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_PO_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetPOTrackMaster(packageName,parameterList);
        }
        public List<PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_PO_TRACKING_BYREQNO";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("PRNo",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPOTrackMaster(packageName, parameterList);
        }
        private List<PurchaseOrder> GetPOTrackMaster(string packageName,OracleParameter[] parameterList)
        {
            List<PurchaseOrder> opurchaseorder = new List<PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                PurchaseOrder po = new PurchaseOrder();
                po.ID = (string)rdr["POID"];
                po.PODate = DateTime.Parse(rdr["PODATE"].ToString());
                

                Supplier osup = new Supplier();
                osup.ID = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERID")) ? (string)rdr["SUPPLIERID"] : "";
                osup.Name = !rdr.IsDBNull(rdr.GetOrdinal("SupplierName")) ? (string)rdr["SupplierName"] : "";
                po.Supplier = osup;

                ItemOrder itm = new ItemOrder();
                itm.Rate = Single.Parse(rdr["RATE"].ToString());
                itm.POQty = Single.Parse(rdr["POQTY"].ToString());

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ItemID"];
                omaster.Name = (string)rdr["ItemName"];

                Units un = new Units();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];
                omaster.Units = un;
                itm.ItemMaster = omaster;
                po.ItemOrder = itm;

                opurchaseorder.Add(po);
            }
            rdr.Close();
            return opurchaseorder;
        }
        #endregion

        #region GetMrrTracking
        public List<MaterialReceive> GetMrrTracking(string storeid,string startDate,string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_MRR_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetMrrTrackMaster(packageName, parameterList);
        }
        public List<MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_MRR_TRACKING_BYPO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
            };
            return GetMrrTrackMaster(packageName, parameterList);
        }
        private List<MaterialReceive> GetMrrTrackMaster(string packageName,OracleParameter[] parameterList)
        {
            List<MaterialReceive> omatreceive = new List<MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                MaterialReceive omrr = new MaterialReceive();
                omrr.ID = (string)rdr["MRRID"];
                omrr.MrrDate = DateTime.Parse(rdr["MRRDATE"].ToString());
                omrr.MrrQuantity = float.Parse(rdr["Quantity"].ToString());

                ItemOrder oitem = new ItemOrder();
                oitem.Rate = Single.Parse(rdr["RATE"].ToString());

                ItemMaster mas = new ItemMaster();
                mas.ID = (string)rdr["ITEMID"];
                mas.Name = (string)rdr["ITEMNAME"];
                oitem.ItemMaster = mas;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UNITID"];
                ounit.Name = (string)rdr["UNITNAME"];
                mas.Units = ounit;
                oitem.ItemMaster = mas;
                omrr.ItemOrder = oitem;


                omatreceive.Add(omrr);
            }
            rdr.Close();
            return omatreceive;
        }
        #endregion

        #region VarifyPurchaseReqNo
        public int VarifyPurchaseReqNo(string prid)
        {
            string packageName = "PKG_PR.VERIFY_PURCHASE_REQUISITION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region VarifyPRForModify
        public int VarifyPRForModify(string prid)
        {
            string packageName = "PKG_PR.VERIFY_PR_FORMODIFY";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region GetPrDetailsDeptUnitWise
        public List<PurchaseRequisition> GetPrDetailsDeptUnitWise(string storetypeid)
        {
            string packageName = "PKG_PR.GET_PR_DETAILS_DEPTUNITWISE";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,storetypeid,ParameterDirection.Input)
                //new OracleParameter("Store",OracleDbType.Varchar2,2,storeid,ParameterDirection.Input)
            };
            return GetPrDetailsDeptUnit(packageName, paramterList);
        }

        private List<PurchaseRequisition> GetPrDetailsDeptUnit(string packageName, OracleParameter[] paramterList)
        {
            List<PurchaseRequisition> opurchasereq = new List<PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                PurchaseRequisition oreq = new PurchaseRequisition();
                oreq.ID = (string)rdr["PRID"];
                oreq.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                oreq.RequisitionBy = (string)rdr["RequisitionBy"];
                oreq.RequisitionByName = !rdr.IsDBNull(rdr.GetOrdinal("RequisitionByName")) ? (string)rdr["RequisitionByName"] : "";

                StoreTypeSCM ostrscm = new StoreTypeSCM();
                ostrscm.strTypeID = (string)rdr["STORETYPE"];
                ostrscm.TypeTitle = (string)rdr["STORETYPENAME"];
                oreq.StoreType = ostrscm;

                Warehouse ostrloc = new Warehouse();
                ostrloc.TypeID = (string)rdr["StoreId"];
                ostrloc.TypeName = (string)rdr["STORENAME"];
                oreq.Warehouse = ostrloc;

                opurchasereq.Add(oreq);
            }
            rdr.Close();
            return opurchasereq;

        }
        #endregion
    }
}
