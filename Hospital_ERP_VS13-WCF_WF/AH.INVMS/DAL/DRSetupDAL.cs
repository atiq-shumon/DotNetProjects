using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.INVMS.MODEL;
using AH.DUtility;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class DRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SaveDemandRequisition
        public string SaveDemandRequisition(DemandRequisition odemand)
        {
            string packageName = "PKG_DR.SAVE_DR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,odemand.ID,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,odemand.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("StoreType",OracleDbType.Varchar2,6,odemand.StoreTypeSCM.strTypeID,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,4,odemand.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,6,odemand.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,odemand.TransactionType,ParameterDirection.Input),
                new OracleParameter("RequisitionDate",OracleDbType.Date,odemand.RequisitionDate,ParameterDirection.Input),
                new OracleParameter("RequisitionType",OracleDbType.Varchar2,1,odemand.RequisitionType,ParameterDirection.Input),
                new OracleParameter("RequisitionBy",OracleDbType.Varchar2,30,odemand.RequisitionBy,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odemand.Remarks,ParameterDirection.Input),
                new OracleParameter("DRDetails",OracleDbType.Varchar2,32000,odemand.ReqDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odemand.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odemand.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odemand.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odemand.EntryParameter.MachineID,ParameterDirection.Input)
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

        #region GetDrID
        public List<DemandRequisition> GetDrID()
        {
            string packageName = "PKG_DR.GET_DR_ID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)                
            };
            return GetDrList(packageName, parameterList);
        }
        public List<DemandRequisition> GetDrNODeptUnitwise(string deptid, string unitid, string startDate, string endDate)
        {
            string packageName = "PKG_DR.GET_DRID_DEPTUNITWISE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DeptID",OracleDbType.Varchar2,15,deptid,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,15,unitid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetDrList(packageName, parameterList);
        }
        private List<DemandRequisition> GetDrList(string packageName, OracleParameter[] parameterList)
            {
            List<DemandRequisition> oreq = new List<DemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DemandRequisition po = new DemandRequisition();
                po.ID = (string)rdr["dr_id"];
                po.RequisitionDate = DateTime.Parse(rdr["req_date"].ToString());
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetDrDetails
        public List<DemandRequisition> GetDrDetails(string drid)
        {
            string packageName = "PKG_DR.GET_DR_DETAILS";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,drid,ParameterDirection.Input)
            };
            return GetDrDetailsView(packageName, paramterList);
        }
        

        private List<DemandRequisition> GetDrDetailsView(string packageName, OracleParameter[] paramterList)
        {
            List<DemandRequisition> odemand = new List<DemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,paramterList);
            while (rdr.Read())
            {
                DemandRequisition dem = new DemandRequisition();
                dem.ID = (string)rdr["DRID"];
                dem.RequisitionType = (string)rdr["RequisitionType"];
                dem.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                dem.DemandQty = Single.Parse(rdr["DemandQty"].ToString());
                dem.RemainingQty = Single.Parse(rdr["RemainingQty"].ToString());
                dem.RequisitionBy = (string)rdr["RequisitionBy"];
                dem.RequisitionByName = (string)rdr["RequisitionByName"];
                dem.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("REMARKS")) ? (string)rdr["REMARKS"] : "";

                //StoreLocation ostrloc = new StoreLocation();
                //ostrloc.ID = (string)rdr["StoreId"];
                //ostrloc.Name = (string)rdr["STORENAME"];

                StoreTypeSCM ostoretype = new StoreTypeSCM();
                ostoretype.strTypeID = (string)rdr["STORETYPEID"];
                ostoretype.TypeTitle = (string)rdr["STORETYPENAME"];
                dem.StoreTypeSCM = ostoretype;

                

                Warehouse owarehouse = new Warehouse();
                owarehouse.TypeID = (string)rdr["StoreId"];
                owarehouse.TypeName = (string)rdr["STORENAME"];
                dem.Warehouse = owarehouse;

                Department odept = new Department();
                odept.DepartmentID = (string)rdr["DepartmentID"];
                odept.DepartmentTitle = (string)rdr["DEPARTMENTNAME"];
                dem.Department = odept;

                DepartmentUnit ounit = new DepartmentUnit();
                ounit.UnitId = (string)rdr["DEPTUNITID"];
                ounit.UnitTitle = (string)rdr["DEPTUNITNAME"];
                dem.DepartmentUnit = ounit;

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ItemID"];
                omaster.Name = (string)rdr["ItemName"];
                omaster.StockQty = !rdr.IsDBNull(rdr.GetOrdinal("Stock")) ? Convert.ToSingle(rdr["Stock"]) : 0;
                omaster.Urate = !rdr.IsDBNull(rdr.GetOrdinal("RATE")) ? Convert.ToSingle(rdr["RATE"]) : 0;
                omaster.Slrate = !rdr.IsDBNull(rdr.GetOrdinal("SALESRATE")) ? Convert.ToSingle(rdr["SALESRATE"]) : 0;
                omaster.VAT = !rdr.IsDBNull(rdr.GetOrdinal("VAT")) ? Convert.ToSingle(rdr["VAT"]) : 0;
                omaster.Discount = !rdr.IsDBNull(rdr.GetOrdinal("Discount")) ? Convert.ToSingle(rdr["Discount"]) : 0;

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
                

                odemand.Add(dem);
            }
            rdr.Close();
            return odemand;
        }
        #endregion

        #region GetDrDetailsDeptUnitWise
        public List<DemandRequisition> GetDrDetailsDeptUnitWise(string deptid, string unitid)
        {
            string packageName = "PKG_DR.GET_DR_DETAILS_DEPTUNITWISE";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,15,deptid,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,15,unitid,ParameterDirection.Input)
            };
            return GetDrDetailsDeptUnit(packageName, paramterList);
        }
        public List<DemandRequisition> GetDrVerifiedbyList(string verifyid)
        {
            string packageName = "PKG_DR.GET_DR_VERIFYLIST";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("VerifiedBy",OracleDbType.Varchar2,30,verifyid,ParameterDirection.Input)
                //new OracleParameter("Unit",OracleDbType.Varchar2,15,unitid,ParameterDirection.Input)
            };
            return GetDrDetailsDeptUnit(packageName, paramterList);
        }

        private List<DemandRequisition> GetDrDetailsDeptUnit(string packageName, OracleParameter[] paramterList)
        {
            List<DemandRequisition> odemand = new List<DemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                DemandRequisition dem = new DemandRequisition();
                dem.ID = (string)rdr["DRID"];
                dem.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                dem.RequisitionBy = (string)rdr["RequisitionBy"];
                dem.RequisitionByName = !rdr.IsDBNull(rdr.GetOrdinal("RequisitionByName")) ? (string)rdr["RequisitionByName"] : "";
                dem.VerifiedBy = !rdr.IsDBNull(rdr.GetOrdinal("VerifiedBy")) ? (string)rdr["VerifiedBy"] : "";

                Warehouse ostrloc = new Warehouse();
                ostrloc.TypeID = (string)rdr["StoreId"];
                ostrloc.TypeName = (string)rdr["STORENAME"];
                dem.Warehouse = ostrloc;

                odemand.Add(dem);
            }
            rdr.Close();
            return odemand;

        }
        #endregion

        #region GetRequisitionVerifiedBy
        public List<DemandRequisition> GetRequisitionVerifiedBy(string deptid,string unitid,string userid)
        {
            string packageName = "PKG_DR.GET_REQ_VERIFIED";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DeptID",OracleDbType.Varchar2,15,deptid,ParameterDirection.Input),
                new OracleParameter("UnitID",OracleDbType.Varchar2,15,unitid,ParameterDirection.Input),
                new OracleParameter("UserID",OracleDbType.Varchar2,20,userid,ParameterDirection.Input)
            };
            List<DemandRequisition> odemandreq = new List<DemandRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                DemandRequisition oreq = new DemandRequisition();
                oreq.ID = (string)rdr["dr_id"];
                oreq.VerifiedBy = !rdr.IsDBNull(rdr.GetOrdinal("verified_by")) ? (string)rdr["verified_by"] : "";
                oreq.RequisitionBy = !rdr.IsDBNull(rdr.GetOrdinal("ReqByName")) ? (string)rdr["ReqByName"] : "";

                Department odept = new Department();
                odept.DepartmentID = (string)rdr["dept_id"];
                odept.DepartmentTitle = (string)rdr["DepartmentName"];
                oreq.Department = odept;

                DepartmentUnit ounit = new DepartmentUnit();
                ounit.UnitId = (string)rdr["unit_id"];
                ounit.UnitTitle = (string)rdr["DepartmentUnitName"];
                oreq.DepartmentUnit = ounit;

                odemandreq.Add(oreq);
            }
            rdr.Close();
            return odemandreq;
        }
        #endregion

        #region VerifyDemandRequisition
        public short VerifyDemandRequisition(DemandRequisition odemand)
        {
            string packageName = "PKG_DR.VERIFY_REQUISITION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,odemand.ID,ParameterDirection.Input),
                new OracleParameter("DRDetails",OracleDbType.Varchar2,4000,odemand.ReqDetails,ParameterDirection.Input),
                new OracleParameter("VerifyBy",OracleDbType.Varchar2,30,odemand.RequisitionBy,ParameterDirection.Input),
                new OracleParameter("VerifyDate",OracleDbType.Date,odemand.RequisitionDate,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odemand.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odemand.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odemand.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odemand.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region VarifyDemandReqNo
        public int VarifyDemandReqNo(string drid)
        {
            string packageName = "PKG_DR.VERIFY_DEMAND_REQUISITION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,drid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion
    }
}
