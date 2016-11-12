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
    public class TRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SaveTransferRequisition
        public string SaveTransferRequisition(AH.PHRMS.MODEL.TransferRequisition otr)
        {
            string packageName = "PKG_TR.SAVE_TR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,otr.ID,ParameterDirection.Output),
                new OracleParameter("ToWareHouse",OracleDbType.Varchar2,6,otr.Warehouse.ToTypeID,ParameterDirection.Input),  
                new OracleParameter("WareHouse",OracleDbType.Varchar2,6,otr.Warehouse.TypeID,ParameterDirection.Input),                                             
                new OracleParameter("Department",OracleDbType.Varchar2,4,otr.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,4,otr.DepartmentUnit.UnitId,ParameterDirection.Input),                
                new OracleParameter("RequisitionDate",OracleDbType.Date,otr.RequisitionDate,ParameterDirection.Input),                                
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otr.Remarks,ParameterDirection.Input),
                new OracleParameter("RequisitionDetails",OracleDbType.Varchar2,32000,otr.TrDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];           
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region GetTRID
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRID(string pharmacy)
        {
            string packageName = "PKG_TR.GET_TR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Phamrmacy",OracleDbType.Varchar2,6,pharmacy,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.TransferRequisition> oreq = new List<AH.PHRMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.TransferRequisition po = new AH.PHRMS.MODEL.TransferRequisition();
                po.ID = (string)rdr["tr_id"];               
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetTRDetails
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetails(string trid)
        {
            string packageName = "PKG_TR.GET_TR_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,trid,ParameterDirection.Input)
            };
            return GetTRList(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.TransferRequisition> GetTRList(string packageName, OracleParameter[] parameterList)
         {
             List<AH.PHRMS.MODEL.TransferRequisition> oreq = new List<AH.PHRMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.TransferRequisition po = new AH.PHRMS.MODEL.TransferRequisition();
                po.ID = (string)rdr["tr_id"];
                po.TrQty = float.Parse(rdr["RQ_QTY"].ToString());
                po.TrrQty = float.Parse(rdr["TRR_QTY"].ToString());

                Warehouse owh = new Warehouse();
                owh.TypeID = (string)rdr["PHR_ID"];
                owh.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("PharmacyName")) ? (string)rdr["PharmacyName"] : "";
                owh.ToTypeID = (string)rdr["TO_PHR_ID"];
                owh.ToTypeName = !rdr.IsDBNull(rdr.GetOrdinal("ToPharmacyName")) ? (string)rdr["ToPharmacyName"] : "";
                po.Warehouse = owh;

                DrugMaster omas = new DrugMaster();
                omas.ID = (string)rdr["prod_id"];
                omas.Name = (string)rdr["DrugName"];

                DrugPackType opac = new DrugPackType();
                opac.ID = (string)rdr["prod_type_id"];
                opac.Name = (string)rdr["PacketType"];
                omas.DrugPackType = opac;

                DrugGroup ogrp = new DrugGroup();
                ogrp.ID = (string)rdr["prod_grp_id"];
                ogrp.Name = (string)rdr["DrugGroup"];
                omas.DrugGroup = ogrp;

                DrugCompany ocomp = new DrugCompany();
                ocomp.ID = (string)rdr["prod_comp_id"];
                ocomp.Name = (string)rdr["DrugCompany"];
                omas.DrugCompany = ocomp;

                DrugUnit ounit = new DrugUnit();
                ounit.ID = (string)rdr["prod_unit_id"];
                ounit.Name = (string)rdr["UnitName"];
                omas.DrugUnit = ounit;
                po.DrugMaster = omas;


                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetDrugDetailsBatch
        public List<AH.PHRMS.MODEL.MaterialReceive> GetDrugDetailsBatch(string trid,string drugid,string pharmacyid)
        {
            string packageName = "PKG_TR.GET_TR_ITEMDET";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,trid,ParameterDirection.Input),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,pharmacyid,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.MaterialReceive> omaterialrec = new List<AH.PHRMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {

                AH.PHRMS.MODEL.MaterialReceive oitmorder = new AH.PHRMS.MODEL.MaterialReceive();
                oitmorder.BatchNo = (string)rdr["BATCH_ID"];
                oitmorder.MRRID = (string)rdr["MRRID"];
                oitmorder.ExpireDate = DateTime.Parse(rdr["EXP_DATE"].ToString());
                oitmorder.TransactionType = (string)rdr["TransactionType"];
                oitmorder.ChallanNo = (string)rdr["ChallanNo"];
                oitmorder.ChallanDate = DateTime.Parse(rdr["ChallanDate"].ToString());
                oitmorder.VoucherNo = (string)rdr["VoucherNo"];

                AH.PHRMS.MODEL.PurchaseOrder opo = new AH.PHRMS.MODEL.PurchaseOrder();
                opo.ID = (string)rdr["POID"];

                AH.PHRMS.MODEL.PurchaseRequisition opr = new AH.PHRMS.MODEL.PurchaseRequisition();
                opr.ID = (string)rdr["PRID"];
                opr.RequisitionQty = float.Parse(rdr["TrQty"].ToString());
                opo.PurchaseRequisition = opr;
                oitmorder.PurchaseOrder = opo;


                //Warehouse ophr = new Warehouse();
                //ophr.ToTypeID = (string)rdr["PHR_ID"];
                //ophr.ToTypeName = (string)rdr["PharmacyName"];
                //oitmorder.Warehouse = ophr;

                ItemsOrder oitm = new ItemsOrder();
                oitm.URate = float.Parse(rdr["Rate"].ToString());
                oitm.SlRate = float.Parse(rdr["SlRate"].ToString());
                oitm.VAT = float.Parse(rdr["Vat"].ToString());
                oitm.Discount = float.Parse(rdr["Discount"].ToString());

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DRUG_ID"];
                omaster.Name = (string)rdr["DrugName"];

                DrugCompany ocompsetup = new DrugCompany();
                ocompsetup.ID = (string)rdr["DRG_COMP_ID"];
                ocompsetup.Name = (string)rdr["DrugCompany"];
                omaster.DrugCompany = ocompsetup;

                DrugGroup ogroup = new DrugGroup();
                ogroup.ID = (string)rdr["GRP_ID"];
                ogroup.Name = (string)rdr["DrugGroup"];
                omaster.DrugGroup = ogroup;

                DrugUnit ounit = new DrugUnit();
                ounit.ID = (string)rdr["UNIT_ID"];
                ounit.Name = (string)rdr["DrugUnit"];
                omaster.DrugUnit = ounit;

                DrugPackType otype = new DrugPackType();
                otype.ID = (string)rdr["TYPE_ID"];
                otype.Name = (string)rdr["PacketType"];
                omaster.DrugPackType = otype;

                oitm.DrugMaster = omaster;
                oitmorder.ItemsOrder = oitm;                

                omaterialrec.Add(oitmorder);

            }
            rdr.Close();
            return omaterialrec;
        }
        #endregion

        #region SaveTransferReceive
        public string SaveTransferReceive(AH.PHRMS.MODEL.TransferReceive otr)
        {
            string packageName = "PKG_TRR.SAVE_TRR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TRRID",OracleDbType.Varchar2,15,otr.ID,ParameterDirection.Output),
                new OracleParameter("FromPharmacy",OracleDbType.Varchar2,6,otr.Warehouse.TypeID,ParameterDirection.Input),  
                new OracleParameter("ToPharmacy",OracleDbType.Varchar2,6,otr.Warehouse.ToTypeID,ParameterDirection.Input), 
                new OracleParameter("POID",OracleDbType.Varchar2,15,otr.MaterialReceive.PurchaseOrder.ID,ParameterDirection.Input),           
                new OracleParameter("PRID",OracleDbType.Varchar2,15,otr.MaterialReceive.PurchaseOrder.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,otr.MaterialReceive.MRRID,ParameterDirection.Input),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,otr.TransferRequisition.ID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,2,otr.MaterialReceive.TransactionType,ParameterDirection.Input),                               
                new OracleParameter("TransactionDate",OracleDbType.Date,otr.TrrDate,ParameterDirection.Input),                                
                new OracleParameter("TrrType",OracleDbType.Varchar2,1,otr.TrrType,ParameterDirection.Input),
                new OracleParameter("ChallanNo",OracleDbType.Varchar2,30,otr.MaterialReceive.ChallanNo,ParameterDirection.Input),
                new OracleParameter("ChallanDate",OracleDbType.Date,otr.MaterialReceive.ChallanDate,ParameterDirection.Input),
                new OracleParameter("VoucherNo",OracleDbType.Varchar2,10,otr.MaterialReceive.VoucherNo,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otr.Remarks,ParameterDirection.Input),
                new OracleParameter("TrrDetails",OracleDbType.Varchar2,32000,otr.TrrDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region GetTRDetSearch
        public List<AH.PHRMS.MODEL.TransferRequisition> GetTRDetSearch()
        {
            string packageName = "PKG_TR.GET_TRNO";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                //new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetTRSearch(packageName, paramterList);
        }
        private List<AH.PHRMS.MODEL.TransferRequisition> GetTRSearch(string packageName, OracleParameter[] paramterList)
        {

            List<AH.PHRMS.MODEL.TransferRequisition> opurreq = new List<AH.PHRMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.TransferRequisition dem = new AH.PHRMS.MODEL.TransferRequisition();
                dem.ID = (string)rdr["tr_id"];

                dem.RequisitionDate = DateTime.Parse(rdr["rq_date"].ToString());
                //dem.RequisitionBy = !rdr.IsDBNull(rdr.GetOrdinal("REQUISITIONBYNAME")) ? (string)rdr["REQUISITIONBYNAME"] : "";

                
                Warehouse ophr = new Warehouse();
                ophr.TypeID = (string)rdr["phr_id"];
                ophr.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("FromPharmacy")) ? (string)rdr["FromPharmacy"] : "";
                ophr.ToTypeID = (string)rdr["to_phr_id"];
                ophr.ToTypeName = !rdr.IsDBNull(rdr.GetOrdinal("ToPharmacy")) ? (string)rdr["ToPharmacy"] : "";
                dem.Warehouse = ophr;
                opurreq.Add(dem);
            }
            rdr.Close();
            return opurreq;
        }
        #endregion

        //#region VarifyTransferReqNo
        //public int VarifyPurchaseReqNo(string prid)
        //{
        //    string packageName = "PKG_PR.VERIFY_PURCHASE_REQUISITION";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
        //        new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
        //    };
        //    short i = DALHelper.Insert(connString, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    int regno = (int)(OracleDecimal)prm.Value;
        //    return regno;
        //}
        //#endregion
    }
}
