using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.PHRMS.MODEL;
using AH.DRUGS.MODEL;
using AH.INVMS.MODEL;
using AH.IPDShared.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PHRMS.DAL
{
    public class PRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SavePurchaseRequisition
        public string SavePurchaseRequisition(AH.PHRMS.MODEL.PurchaseRequisition opurchase)
        {
            string packageName = "PKG_PR.SAVE_PR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,opurchase.ID,ParameterDirection.Output),
                new OracleParameter("PharmacyLocation",OracleDbType.Varchar2,6,opurchase.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("DemandRequisition",OracleDbType.Varchar2,15,opurchase.DemandRequisition,ParameterDirection.Input),
                new OracleParameter("Supplier",OracleDbType.Varchar2,15,opurchase.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,opurchase.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,8,opurchase.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,4,opurchase.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,4,opurchase.DepartmentUnit.UnitId,ParameterDirection.Input),
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
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region GetPRID
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRID()
        {
            string packageName = "PKG_PR.GET_PRID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                
            };
            List<AH.PHRMS.MODEL.PurchaseRequisition> oreq = new List<AH.PHRMS.MODEL.PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseRequisition po = new AH.PHRMS.MODEL.PurchaseRequisition();
                po.ID = (string)rdr["PR_ID"];
                po.RequisitionDate = DateTime.Parse(rdr["REQ_DATE"].ToString());
                //po.RequisitionDate = DateTime.Parse(rdr["REQ_DATE"].ToString());
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetPRDetails
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetails(string prid)
        {
            string packageName = "PKG_PR.GET_PRREQ_DETAILS";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPRDetList(packageName,paramterList);
        }
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRSearchDetails(string prid)
        {
            string packageName = "PKG_PR.GET_PRREQDET_SEARCH";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPRDetList(packageName, paramterList);
        }

        private List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetList(string packageName, OracleParameter[] paramterList)
        {

            List<AH.PHRMS.MODEL.PurchaseRequisition> opurreq = new List<AH.PHRMS.MODEL.PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseRequisition dem = new AH.PHRMS.MODEL.PurchaseRequisition();
                dem.ID = (string)rdr["PRID"];
                dem.DemandRequisition = (string)rdr["DRID"];
                dem.RequisitionType = (string)rdr["RequisitionType"];
                dem.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                dem.RequisitionQty = float.Parse(rdr["REQUIREDQTY"].ToString());
                dem.RemainingQty = float.Parse(rdr["REMAININGQTY"].ToString());
                dem.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";

                Department odept = new Department();
                odept.DepartmentID = (string)rdr["DepartmentID"];
                dem.Department = odept;

                DepartmentUnit odeptunit = new DepartmentUnit();
                //odeptunit.UnitId = (string)rdr["DepartmentUnitID"];
                odeptunit.UnitId = !rdr.IsDBNull(rdr.GetOrdinal("DepartmentUnitID")) ? (string)rdr["DepartmentUnitID"] : "";
                dem.DepartmentUnit = odeptunit;


                Warehouse ophr = new Warehouse();
                ophr.TypeID = (string)rdr["PharmacyID"];
                ophr.TypeName = (string)rdr["PharmacyName"];
                dem.Warehouse = ophr;

                AH.PHRMS.MODEL.Supplier osupplier = new AH.PHRMS.MODEL.Supplier();
                osupplier.ID = (string)rdr["SUPPLIERID"];
                osupplier.Name = (string)rdr["SUPPLIERNAME"];
                dem.Supplier = osupplier;

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DrugID"];
                omaster.Name = (string)rdr["DrugName"];
                omaster.Urate = float.Parse(rdr["RATE"].ToString());
                omaster.VAT = float.Parse(rdr["VAT"].ToString());
                omaster.Discount = float.Parse(rdr["DISCOUNT"].ToString());
                omaster.Rackrate = float.Parse(rdr["RACKRATE"].ToString());
                omaster.Slrate = float.Parse(rdr["SLRATE"].ToString());
                omaster.StockQty = float.Parse(rdr["Stock"].ToString());

                DrugCompany dc = new DrugCompany();
                dc.ID = (string)rdr["CompanyID"];
                dc.Name = (string)rdr["CompanyName"];
                omaster.DrugCompany  = dc;

                DrugGroup dg = new DrugGroup();
                dg.ID = (string)rdr["GroupID"];
                dg.Name = (string)rdr["GroupName"];
                omaster.DrugGroup = dg;

                DrugPackType dpac = new DrugPackType();
                dpac.ID = (string)rdr["TypeID"];
                dpac.Name = (string)rdr["TypeName"];
                omaster.DrugPackType = dpac;

                DrugUnit un = new DrugUnit();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];
                omaster.DrugUnit = un;

                

                dem.DrugMaster = omaster;


                opurreq.Add(dem);
            }
            rdr.Close();
            return opurreq;
        }
        #endregion

        #region GetPRDetSearch
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRDetSearch()
        {
            string packageName = "PKG_PR.GET_PRREQNO_LIST";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                //new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPRSearch(packageName, paramterList);
        }
        private List<AH.PHRMS.MODEL.PurchaseRequisition> GetPRSearch(string packageName, OracleParameter[] paramterList)
        {

            List<AH.PHRMS.MODEL.PurchaseRequisition> opurreq = new List<AH.PHRMS.MODEL.PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseRequisition dem = new AH.PHRMS.MODEL.PurchaseRequisition();
                dem.ID = (string)rdr["PRID"];

                dem.RequisitionDate = DateTime.Parse(rdr["REQUISITIONDATE"].ToString());
                dem.RequisitionBy = !rdr.IsDBNull(rdr.GetOrdinal("REQUISITIONBYNAME")) ? (string)rdr["REQUISITIONBYNAME"] : "";


                Warehouse ophr = new Warehouse();
                ophr.TypeID = (string)rdr["PharmacyID"];
                ophr.TypeName = (string)rdr["PHARMACYNAME"];
                dem.Warehouse = ophr;
                opurreq.Add(dem);
            }
            rdr.Close();
            return opurreq;
        }
        #endregion

        #region GetPRID
        public List<NurseDemandRequisition> GetDRID()
        {
            string packageName = "PKG_DR_NURSE.GET_DR_NURSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                
            };
            List<NurseDemandRequisition> oreq = new List<NurseDemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NurseDemandRequisition po = new NurseDemandRequisition();
                po.NurseStationID = (string)rdr["NURSESTATION"];
                po.NurseStationTitle = !rdr.IsDBNull(rdr.GetOrdinal("NurseStationName")) ? (string)rdr["NurseStationName"] : "";
                po.DrID = (string)rdr["DRID"];
                //po.RequisitionDate = DateTime.Parse(rdr["REQ_DATE"].ToString());
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetReqDetForIPDIssue
        public List<NurseDemandRequisition> GetReqDetForIPDIssue(string drid)
        {
            string packageName = "PKG_DR_NURSE.GET_DR_NURSEDETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,drid,ParameterDirection.Input),
            };
            List<NurseDemandRequisition> oreq = new List<NurseDemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                NurseDemandRequisition po = new NurseDemandRequisition();
                po.NurseStationID = (string)rdr["NURSESTATION"];
                po.NurseStationTitle = (string)rdr["NurseStationName"];                
                po.NurseDemandQty = float.Parse(rdr["DEMANDQTY"].ToString());
                po.HCN = (string)rdr["HCN"];
                po.Department = (string)rdr["DEPT"];
                po.Unit = (string)rdr["UNIT"];
                po.Doctor = (string)rdr["DOCTOR"];
                po.Pharmacy = (string)rdr["Pharmacy"];
                po.RemainingQty = float.Parse(rdr["REMQTY"].ToString());
                
                //po.PrescriptionNo = (string)rdr["REGID"];

                InPatient opat = new InPatient();
                opat.RegistrationNo = (string)rdr["REGID"];
                po.InPatient = opat;

                StockHelper ostock = new StockHelper();
                ostock.StockQty = float.Parse(rdr["STOCK"].ToString());
                po.StockHelper = ostock;

                DrugMaster ms = new DrugMaster();
                ms.ID = (string)rdr["DRUGID"];
                ms.Name = !rdr.IsDBNull(rdr.GetOrdinal("DrugName")) ? (string)rdr["DrugName"] : "";
                ms.Urate = float.Parse(rdr["RATE"].ToString());
                ms.Slrate = float.Parse(rdr["SALERATE"].ToString());
                ms.VAT = float.Parse(rdr["VAT"].ToString());
                ms.Discount = float.Parse(rdr["DISCOUNT"].ToString());
                ms.NetAmount = float.Parse(rdr["NETAMOUNT"].ToString());

                DrugCompany comp = new DrugCompany();
                comp.ID = (string)rdr["COMPANYID"];
                comp.Name = (string)rdr["CompanyName"];
                ms.DrugCompany = comp;

                DrugGroup grp = new DrugGroup();
                grp.ID = (string)rdr["DRUGGROUP"];
                grp.Name = (string)rdr["GroupName"];
                ms.DrugGroup = grp;

                DrugUnit unit = new DrugUnit();
                unit.ID = (string)rdr["UNITID"];
                unit.Name = (string)rdr["UnitName"];
                ms.DrugUnit = unit;

                DrugPackType type = new DrugPackType();
                type.ID = (string)rdr["TYPEID"];
                type.Name = !rdr.IsDBNull(rdr.GetOrdinal("TypeName")) ? (string)rdr["TypeName"] : "";
                ms.DrugPackType = type;

                po.DrugMaster = ms;

                //po.RequisitionDate = DateTime.Parse(rdr["REQ_DATE"].ToString());
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
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

    }
}
