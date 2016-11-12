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
    public class TRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SaveTransferRequisition
        public string SaveTransferRequisition(TransferRequisition otr)
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

        #region SaveTransferReceive
        public string SaveTransferReceive(AH.INVMS.MODEL.TransferReceive otr)
        {
            string packageName = "PKG_TRR.SAVE_TRR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TRRID",OracleDbType.Varchar2,15,otr.ID,ParameterDirection.Output),
                new OracleParameter("FromStore",OracleDbType.Varchar2,6,otr.Warehouse.TypeID,ParameterDirection.Input),  
                new OracleParameter("ToStore",OracleDbType.Varchar2,6,otr.Warehouse.ToTypeID,ParameterDirection.Input), 
                new OracleParameter("POID",OracleDbType.Varchar2,15,otr.MaterialReceive.PurchaseOrder.ID,ParameterDirection.Input),           
                new OracleParameter("PRID",OracleDbType.Varchar2,15,otr.MaterialReceive.PurchaseOrder.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,otr.MaterialReceive.ID,ParameterDirection.Input),
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

        #region GetTRID
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRID(string store)
        {
            string packageName = "PKG_TR.GET_TR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Store",OracleDbType.Varchar2,6,store,ParameterDirection.Input)
            };
            List<AH.INVMS.MODEL.TransferRequisition> oreq = new List<AH.INVMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.INVMS.MODEL.TransferRequisition po = new AH.INVMS.MODEL.TransferRequisition();
                po.ID = (string)rdr["tr_id"];
                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetTRDetails
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetails(string trid)
        {
            string packageName = "PKG_TR.GET_TR_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,trid,ParameterDirection.Input)
            };
            return GetTRList(packageName, parameterList);
        }
        private List<AH.INVMS.MODEL.TransferRequisition> GetTRList(string packageName, OracleParameter[] parameterList)
        {
            List<AH.INVMS.MODEL.TransferRequisition> oreq = new List<AH.INVMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.INVMS.MODEL.TransferRequisition po = new AH.INVMS.MODEL.TransferRequisition();
                po.ID = (string)rdr["tr_id"];
                po.TrQty = float.Parse(rdr["RQ_QTY"].ToString());
                po.TrrQty = float.Parse(rdr["TRR_QTY"].ToString());
                po.StockQty = float.Parse(rdr["StockQty"].ToString());

                Warehouse owh = new Warehouse();
                owh.TypeID = (string)rdr["str_id"];
                owh.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("StoreName")) ? (string)rdr["StoreName"] : "";
                owh.ToTypeID = (string)rdr["TO_STR_ID"];
                owh.ToTypeName = !rdr.IsDBNull(rdr.GetOrdinal("ToStoreName")) ? (string)rdr["ToStoreName"] : "";
                po.Warehouse = owh;

                ItemMaster omas = new ItemMaster();
                omas.ID = (string)rdr["prod_id"];
                omas.Name = (string)rdr["ItemName"];

                PacketType opac = new PacketType();
                opac.ID = (string)rdr["prod_type_id"];
                opac.Name = (string)rdr["PacketType"];
                omas.PacketType = opac;

                GroupDetails ogrp = new GroupDetails();
                ogrp.ID = (string)rdr["prod_grp_id"];
                ogrp.Name = (string)rdr["ItemGroup"];
                omas.GroupDetails = ogrp;

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["prod_comp_id"];
                ocomp.Name = (string)rdr["ItemCompany"];
                omas.Company = ocomp;

                Units ounit = new Units();
                ounit.ID = (string)rdr["prod_unit_id"];
                ounit.Name = (string)rdr["UnitName"];
                omas.Units = ounit;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["prod_brnd_id"];
                obrand.Name = (string)rdr["BrandName"];
                omas.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["prod_model_id"];
                omodel.Name = (string)rdr["ModelName"];
                omas.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["PROD_MAJOR_GRP_ID"];
                omajor.Name = (string)rdr["MajorGroup"];
                omas.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STR_TYPE_ID"];
                ostrtype.TypeTitle = (string)rdr["StoreType"];
                omas.StoreType = ostrtype;

                po.ItemMaster = omas;


                oreq.Add(po);
            }
            rdr.Close();
            return oreq;
        }
        #endregion

        #region GetDrugDetailsBatch
        public List<AH.INVMS.MODEL.MaterialReceive> GetItemDetBatchTransfer(string trid, string itemid, string storeid)
        {
            string packageName = "PKG_TR.GET_TR_ITEMDET";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TRID",OracleDbType.Varchar2,15,trid,ParameterDirection.Input),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input)
            };
            List<AH.INVMS.MODEL.MaterialReceive> omaterialrec = new List<AH.INVMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {

                AH.INVMS.MODEL.MaterialReceive oitmorder = new AH.INVMS.MODEL.MaterialReceive();
                oitmorder.BatchID = (string)rdr["BATCH_ID"];
                oitmorder.ID = (string)rdr["MRRID"];
                oitmorder.ExpDate = DateTime.Parse(rdr["EXP_DATE"].ToString());
                oitmorder.TransactionType = (string)rdr["TransactionType"];
                oitmorder.ChallanNo = (string)rdr["ChallanNo"];
                oitmorder.ChallanDate = DateTime.Parse(rdr["ChallanDate"].ToString());
                oitmorder.VoucherNo = (string)rdr["VoucherNo"];

                AH.INVMS.MODEL.PurchaseOrder opo = new AH.INVMS.MODEL.PurchaseOrder();
                opo.ID = (string)rdr["POID"];

                AH.INVMS.MODEL.PurchaseRequisition opr = new AH.INVMS.MODEL.PurchaseRequisition();
                opr.ID = (string)rdr["PRID"];
                opr.RequisitionQty = float.Parse(rdr["TrQty"].ToString());
                opo.PurchaseRequisition = opr;
                oitmorder.PurchaseOrder = opo;


                //Warehouse ophr = new Warehouse();
                //ophr.ToTypeID = (string)rdr["PHR_ID"];
                //ophr.ToTypeName = (string)rdr["PharmacyName"];
                //oitmorder.Warehouse = ophr;

                AH.INVMS.MODEL.ItemOrder oitm = new AH.INVMS.MODEL.ItemOrder();
                oitm.Rate = float.Parse(rdr["Rate"].ToString());
                oitm.SlRate = float.Parse(rdr["SlRate"].ToString());
                oitm.VAT = float.Parse(rdr["Vat"].ToString());
                oitm.Discount = float.Parse(rdr["Discount"].ToString());

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ITEM_ID"];
                omaster.Name = (string)rdr["ItemName"];

                CompanySetup ocompsetup = new CompanySetup();
                ocompsetup.ID = (string)rdr["COMP_ID"];
                ocompsetup.Name = (string)rdr["CompanyName"];
                omaster.Company = ocompsetup;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["GRP_ID"];
                ogroup.Name = (string)rdr["GroupName"];
                omaster.GroupDetails = ogroup;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UNIT_ID"];
                ounit.Name = (string)rdr["UnitName"];
                omaster.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TYPE_ID"];
                otype.Name = (string)rdr["PacketType"];
                omaster.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BrandID"];
                omaster.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["ModelID"];
                omaster.ModelSetup = omodel;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["str_type_id"];
                omaster.StoreType = ostrtype;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["major_grp_id"];
                omaster.Majorgroup = omajor;

                oitm.ItemMaster = omaster;
                oitmorder.ItemOrder = oitm;

                omaterialrec.Add(oitmorder);

            }
            rdr.Close();
            return omaterialrec;
        }
        #endregion

        #region GetTRDetSearch
        public List<AH.INVMS.MODEL.TransferRequisition> GetTRDetSearch()
        {
            string packageName = "PKG_TR.GET_TRNO";
            OracleParameter[] paramterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                //new OracleParameter("PRID",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetTRSearch(packageName, paramterList);
        }
        private List<AH.INVMS.MODEL.TransferRequisition> GetTRSearch(string packageName, OracleParameter[] paramterList)
        {

            List<AH.INVMS.MODEL.TransferRequisition> opurreq = new List<AH.INVMS.MODEL.TransferRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, paramterList);
            while (rdr.Read())
            {
                AH.INVMS.MODEL.TransferRequisition dem = new AH.INVMS.MODEL.TransferRequisition();
                dem.ID = (string)rdr["tr_id"];

                dem.RequisitionDate = DateTime.Parse(rdr["rq_date"].ToString());
                //dem.RequisitionBy = !rdr.IsDBNull(rdr.GetOrdinal("REQUISITIONBYNAME")) ? (string)rdr["REQUISITIONBYNAME"] : "";


                Warehouse ophr = new Warehouse();
                ophr.TypeID = (string)rdr["str_id"];
                ophr.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("FromStore")) ? (string)rdr["FromStore"] : "";
                ophr.ToTypeID = (string)rdr["to_str_id"];
                ophr.ToTypeName = !rdr.IsDBNull(rdr.GetOrdinal("ToStore")) ? (string)rdr["ToStore"] : "";
                dem.Warehouse = ophr;
                opurreq.Add(dem);
            }
            rdr.Close();
            return opurreq;
        }
        #endregion

    }
}
