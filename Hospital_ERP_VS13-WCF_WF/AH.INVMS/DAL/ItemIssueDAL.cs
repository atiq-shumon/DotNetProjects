using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.INVMS.MODEL;
using AH.PRMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class ItemIssueDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SaveItemIssue
        public string SaveItemIssue(ItemIssue oitems)
        {
           
            string packageName = "PKG_ISSUE.SAVE_ISSUE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,oitems.ID,ParameterDirection.Output),
                new OracleParameter("StackOverFlow",OracleDbType.Varchar2,100,oitems.StockOverFlow,ParameterDirection.Output),
                new OracleParameter("Store",OracleDbType.Varchar2,6,oitems.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("StoreType",OracleDbType.Varchar2,6,oitems.StoreTypeSCM.strTypeID,ParameterDirection.Input),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,oitems.DemandRequisition.ID,ParameterDirection.Input),
                new OracleParameter("IssueType",OracleDbType.Varchar2,1,oitems.IssueType,ParameterDirection.Input),
                new OracleParameter("IssueDate",OracleDbType.Date,oitems.IssueDate,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,oitems.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,oitems.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("WareHouseID",OracleDbType.Varchar2,6,oitems.Warehouse.ToTypeID,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,oitems.HCN,ParameterDirection.Input),
                new OracleParameter("Staff",OracleDbType.Varchar2,30,oitems.Staff,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,10,oitems.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,10,oitems.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("DoctorID",OracleDbType.Varchar2,30,oitems.Doctor,ParameterDirection.Input),
                new OracleParameter("PrescriptionNo",OracleDbType.Varchar2,30,oitems.PrescriptionNo,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,30,oitems.RegID,ParameterDirection.Input),
                new OracleParameter("Room",OracleDbType.Varchar2,5,oitems.Bed.Room.RoomID,ParameterDirection.Input),               
                new OracleParameter("BedID",OracleDbType.Varchar2,10,oitems.Bed.BedID,ParameterDirection.Input),                
                new OracleParameter("ConsumptionID",OracleDbType.Varchar2,15,oitems.ConsumptionID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,oitems.TransactionType,ParameterDirection.Input),
                new OracleParameter("ReceivedBy",OracleDbType.Varchar2,30,oitems.ReceivedBy,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,oitems.Remarks,ParameterDirection.Input),
                new OracleParameter("IssueDetails",OracleDbType.Varchar2,32000,oitems.IssueDetails,ParameterDirection.Input),
                new OracleParameter("AssetTrackerSerial",OracleDbType.Varchar2,3000,oitems.AssetTrackerSerialNo,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oitems.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oitems.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oitems.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oitems.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            OracleParameter prm1 = parameterList[2];
            if ((OracleString)prm.Value != "")
                //return prm.Value.ToString() + "$" + (prm1.Value == null || prm1.Value==string.Empty ? "0" : prm1.Value.ToString());
                return prm.Value.ToString() + "$" + ((prm1.Value == null || prm1.Value == string.Empty) ? "0" : prm1.Value.ToString());
            else return "0";



        }
        #endregion

        #region GetIssueDetails
        public List<ItemIssue> GetIssueDetails(string issueid)
        {
            string packageName = "PKG_ISSUE.GET_ISSUE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input)
            };
            List<ItemIssue> oissue = new List<ItemIssue>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                ItemIssue it = new ItemIssue();
                it.ID = (string)rdr["ISSUEID"];
                it.IssueQty = float.Parse(rdr["IssueQty"].ToString());
                it.ReturnQty = float.Parse(rdr["RETURNQTY"].ToString());
                it.CompareQty = float.Parse(rdr["COMPAREQTY"].ToString());
                it.IssueDate = DateTime.Parse(rdr["IssueDate"].ToString());
                it.IssueType = (string)rdr["ISSUETYPE"];
                it.BatchID = (string)rdr["BATCHNO"];

                StoreLocation ostoreloc = new StoreLocation();
                ostoreloc.ID = (string)rdr["STOREID"];
                ostoreloc.Name = (string)rdr["STORENAME"];
                it.StoreLocation = ostoreloc;

                ItemOrder oitmorder = new ItemOrder();

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["ITEMID"];
                omaster.Name = (string)rdr["ItemName"];

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["COMPANYID"];
                ocomp.Name = (string)rdr["ItemCompany"];
                omaster.Company = ocomp;

                GroupDetails ogrp = new GroupDetails();
                ogrp.ID = (string)rdr["PRODGRPID"];
                ogrp.Name = (string)rdr["ITEMGROUP"];
                omaster.GroupDetails = ogrp;

                Units ounit = new Units();
                ounit.ID = (string)rdr["PRODUNITID"];
                ounit.Name = (string)rdr["UNITNAME"];
                omaster.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["PRODTYPEID"];
                otype.Name = (string)rdr["TYPENAME"];
                omaster.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BRANDID"];
                obrand.Name = (string)rdr["BRANDNAME"];
                omaster.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["MODELID"];
                omodel.Name = (string)rdr["MODELNAME"];
                omaster.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGRPID"];
                omajor.Name = (string)rdr["MAJORGRPNAME"];
                omaster.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                omaster.StoreType = ostrtype;

                oitmorder.ItemMaster = omaster;
                it.ItemOrder = oitmorder;

                oissue.Add(it);
            }
            rdr.Close();
            return oissue;
        }
        #endregion

        #region SaveIssueType
        public short SaveIssueType(IssueType otype)
        {
            string packageName = "PKG_ISSUE.INSERT_ISSUE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueTypeName",OracleDbType.Varchar2,200,otype.Name,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otype.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otype.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otype.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otype.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otype.EntryParameter.MachineID,ParameterDirection.Input)

        };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyIssueType
        public short ModifyIssueType(IssueType otype)
        {
            string packageName = "PKG_ISSUE.UPDATE_ISSUE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueTypeID",OracleDbType.Varchar2,2,otype.ID,ParameterDirection.Input),
                new OracleParameter("IssueTypeName",OracleDbType.Varchar2,200,otype.Name,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otype.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otype.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otype.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otype.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otype.EntryParameter.MachineID,ParameterDirection.Input)

        };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetIssueType
        public List<IssueType> GetIssueType()
        {
            string packageName = "PKG_ISSUE.GET_ISSUE_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<IssueType> otype = new List<IssueType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                IssueType oissue = new IssueType();
                oissue.ID = (string)rdr["Type_ID"];
                oissue.Name = (string)rdr["type_title"];
                oissue.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("remarks")) ? (string)rdr["remarks"] : "";
                otype.Add(oissue);
            }
            rdr.Close();
            return otype;

        }
        #endregion

        #region SaveCostCenter
        public short SaveCostCenter(CostCenter ocost)
        {
            string packageName = "PKG_ISSUE.INSERT_COST_CENTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueType",OracleDbType.Varchar2,2,ocost.IssueType.ID,ParameterDirection.Input),
                new OracleParameter("CostCenterName",OracleDbType.Varchar2,200,ocost.CostCenterTitle,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ocost.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ocost.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ocost.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ocost.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ocost.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyCostCenter
        public short ModifyCostCenter(CostCenter ocost)
        {
            string packageName = "PKG_ISSUE.UPDATE_COST_CENTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueType",OracleDbType.Varchar2,2,ocost.IssueType.ID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,5,ocost.CostCenterID,ParameterDirection.Input),
                new OracleParameter("CostCenterName",OracleDbType.Varchar2,200,ocost.CostCenterTitle,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ocost.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ocost.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ocost.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ocost.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ocost.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetCostCenter
        public List<CostCenter> GetCostCenter()
        {
            string packageName = "PKG_ISSUE.GET_COST_CENTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetCostCentersetup(packageName,parameterList);
        }
        public List<CostCenter> GetCostCenterByIssueType(string issuetype)
        {
            string packageName = "PKG_ISSUE.GET_COST_CENTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IssueType",OracleDbType.Varchar2,2,issuetype,ParameterDirection.Input)
            };
            return GetCostCentersetup(packageName, parameterList);
        }
       private List<CostCenter> GetCostCentersetup(string packageName,OracleParameter[] parameterList)
       {
            List<CostCenter> ocost = new List<CostCenter>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                CostCenter oc = new CostCenter();
                oc.CostCenterID = (string)rdr["c_center_id"];
                oc.CostCenterTitle = (string)rdr["c_center_title"];
                oc.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("remarks")) ? (string)rdr["remarks"] : "";

                IssueType otype = new IssueType();
                otype.Name = (string)rdr["IssueTypeName"];
                oc.IssueType = otype;

                ocost.Add(oc);
            }
            rdr.Close();
            return ocost;
        }
        #endregion

       #region SaveIssueReturn
       public string SaveIssueReturn(IssueReturn oret)
       {
           string packageName = "PKG_ISSUE_RETURN.SAVE_ISSUE_RETURN";
           OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("IssueType",OracleDbType.Varchar2,1,oret.ItemIssue.IssueType,ParameterDirection.Input),
                new OracleParameter("ReturnID",OracleDbType.Varchar2,15,oret.ID,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,oret.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("IssueID",OracleDbType.Varchar2,15,oret.ItemIssue.ID,ParameterDirection.Input),
                //new OracleParameter("BatchID",OracleDbType.Varchar2,15,oret.ItemIssue.BatchID,ParameterDirection.Input),
                new OracleParameter("ReturnDate",OracleDbType.Date,oret.ReturnDate,ParameterDirection.Input),
                new OracleParameter("ReturnType",OracleDbType.Varchar2,2,oret.ReturnType,ParameterDirection.Input),
                new OracleParameter("ReturnFrom",OracleDbType.Varchar2,10,oret.ReturnFrom,ParameterDirection.Input),
                new OracleParameter("ReturnCause",OracleDbType.Varchar2,5,oret.ReturnCause,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,100,oret.Remarks,ParameterDirection.Input),
                new OracleParameter("ReturnDetails",OracleDbType.Varchar2,32000,oret.ReturnDetails,ParameterDirection.Input),
                new OracleParameter("AssetTrackerSerial",OracleDbType.Varchar2,3000,oret.AssetTrackerSerialNo,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oret.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oret.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oret.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oret.EntryParameter.MachineID,ParameterDirection.Input)
            };
           short i = DALHelper.Insert(connString, packageName, parameterList);
           OracleParameter prm = parameterList[2];
           //OracleParameter prm = parameterList[0];
           string regno = (string)(OracleString)prm.Value;
           return regno;

       }
       #endregion

       #region GetAssetTrackerSerialNo
       public List<AssetTrackerMaster> GetAssetTrackerSerialNo(string itemid)
       {
           string packageName = "PKG_ISSUE.GET_ASSET_TRACKER_SERIALNO";
           OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("ItemId",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input)
           };
           return GetAssetSerialNo(packageName,parameterList);
       }
       public List<AssetTrackerMaster> GetAssetSerialNoForIssueReturn(string issueid,string itemid)
       {
           string packageName = "PKG_ISSUE_RETURN.GET_SERIALNO_FORISSUERET";
           OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("IssueID",OracleDbType.Varchar2,15,issueid,ParameterDirection.Input),
               new OracleParameter("ItemId",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input)
           };
           return GetAssetSerialNo(packageName, parameterList);
       }
        private List<AssetTrackerMaster> GetAssetSerialNo(string packageName,OracleParameter[] parameterList)
        {
           List<AssetTrackerMaster> omaster = new List<AssetTrackerMaster>();
           OracleDataReader rdr;
           rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
           while(rdr.Read())
           {
               AssetTrackerMaster oasset = new AssetTrackerMaster();
               oasset.SerialNo = (string)rdr["prod_serial"];

               ItemMaster oitem = new ItemMaster();
               oitem.ID = (string)rdr["item_id"];
               oasset.ItemMaster = oitem;

               omaster.Add(oasset);
           }
           rdr.Close();
           return omaster;
       }
       #endregion

        #region GetItemDetailsBatch
        public List<ItemOrder> GetItemDetailsBatch(string itemid,string drid)
        {
            string packageName = "PKG_ISSUE.GET_ITEMDET_BATCH";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input),
                new OracleParameter("DRID",OracleDbType.Varchar2,15,drid,ParameterDirection.Input)
            };
            List<ItemOrder> omaterialrec = new List<ItemOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
               
                ItemOrder oitmorder = new ItemOrder();
                oitmorder.Batch = (string)rdr["BATCHNO"];
                oitmorder.MRRID = (string)rdr["GRNNO"];
                oitmorder.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                oitmorder.StockQty = float.Parse(rdr["STOCKQTY"].ToString());
                oitmorder.ReqQty = float.Parse(rdr["ReqQty"].ToString());
                oitmorder.RemQty = float.Parse(rdr["RemQty"].ToString());
                oitmorder.Rate = float.Parse(rdr["RATE"].ToString());
                oitmorder.VAT = float.Parse(rdr["VAT"].ToString());
                oitmorder.Discount = float.Parse(rdr["Disc"].ToString());

                ItemMaster omaster = new ItemMaster();
                omaster.ID = (string)rdr["itemid"];
                omaster.Name = (string)rdr["itemname"];

                CompanySetup ocompsetup = new CompanySetup();
                ocompsetup.ID = (string)rdr["CompanyID"];
                ocompsetup.Name = (string)rdr["CompanyName"];
                omaster.Company = ocompsetup;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["GroupID"];
                ogroup.Name = (string)rdr["GroupName"];
                omaster.GroupDetails = ogroup;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UnitID"];
                ounit.Name = (string)rdr["UnitName"];
                omaster.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TypeID"];
                otype.Name = (string)rdr["TypeName"];
                omaster.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BRANDID"];
                obrand.Name = (string)rdr["BrandName"];
                omaster.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["MODELID"];
                omodel.Name = (string)rdr["ModelName"];
                omaster.ModelSetup = omodel;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                omaster.StoreType = ostrtype;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                omaster.Majorgroup = omajor;

                oitmorder.ItemMaster = omaster;

                omaterialrec.Add(oitmorder);

            }
            rdr.Close();
            return omaterialrec;
        }
        #endregion
    }
}
