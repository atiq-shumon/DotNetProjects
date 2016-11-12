using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.INVMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class PODAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SavePurchaseOrder
        public string SavePurchaseOrder(PurchaseOrder opurchaseorder)
        {
            string packageName = "PKG_PO.SAVE_PO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,opurchaseorder.ID,ParameterDirection.InputOutput),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,opurchaseorder.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,6,opurchaseorder.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,opurchaseorder.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,opurchaseorder.PurchaseRequisition.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,opurchaseorder.PurchaseRequisition.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("SupplierID",OracleDbType.Varchar2,6,opurchaseorder.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,opurchaseorder.TransactionType,ParameterDirection.Input),
                new OracleParameter("PODATE",OracleDbType.Date,opurchaseorder.PODate,ParameterDirection.Input),
                new OracleParameter("POType",OracleDbType.Varchar2,3,opurchaseorder.POType,ParameterDirection.Input),
                new OracleParameter("DeliveryDate",OracleDbType.Date,opurchaseorder.DeliveryDate,ParameterDirection.Input),
                new OracleParameter("DeliveryNote",OracleDbType.Varchar2,200,opurchaseorder.DeliveryNote,ParameterDirection.Input),
                //new OracleParameter("CompleteFlag",OracleDbType.Varchar2,1,opurchaseorder.CompleteFlag,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,opurchaseorder.Remarks,ParameterDirection.Input),
                new OracleParameter("PurchaseBy",OracleDbType.Varchar2,30,opurchaseorder.PurchaseBy,ParameterDirection.Input), 
                new OracleParameter("PODetails",OracleDbType.Varchar2,32000,opurchaseorder.POString,ParameterDirection.Input),
                new OracleParameter("TermsDetails",OracleDbType.Varchar2,32000,opurchaseorder.TermsDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,opurchaseorder.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,opurchaseorder.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,opurchaseorder.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,opurchaseorder.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region GetPONumbers
        public List<PurchaseOrder> GetPONumbers()
        {
            string packageName = "PKG_PO.GET_PONUMBERS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<PurchaseOrder> oporder = new List<PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                PurchaseOrder po = new PurchaseOrder();
                po.ID = (string)rdr["PO_ID"];
                po.PODate = DateTime.Parse(rdr["po_date"].ToString());
                oporder.Add(po);
            }
            rdr.Close();
            return oporder;
        }
        #endregion

        #region GetPODetails
        public List<PurchaseOrder> GetPODetails(string poid)
        {
            string packageName = "PKG_PO.GET_PODETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
            };
            List<PurchaseOrder> oporder = new List<PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                PurchaseOrder po = new PurchaseOrder();
                po.ID = (string)rdr["POID"];
                po.POType = (string)rdr["POTYPE"];
                po.PODate = DateTime.Parse(rdr["PODATE"].ToString());
                po.DeliveryDate = DateTime.Parse(rdr["DELIVERYDATE"].ToString());
                po.DeliveryNote = !rdr.IsDBNull(rdr.GetOrdinal("DELIVERYNOTE")) ? (string)rdr["DELIVERYNOTE"] : ""; 
                po.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("REMARKS")) ? (string)rdr["REMARKS"] : "";
                po.PendingReqQty = !rdr.IsDBNull(rdr.GetOrdinal("PENDINGREQQTY")) ? Convert.ToSingle(rdr["PENDINGREQQTY"]) : 0;
                po.PrevPO = float.Parse(rdr["PrevPO"].ToString());
                
                Warehouse ostore = new Warehouse();
                ostore.TypeID = (string)rdr["StoreID"];
                ostore.TypeName = (string)rdr["StoreName"];
                po.Warehouse = ostore;
               
                
                PurchaseRequisition req = new PurchaseRequisition();
                req.ID = (string)rdr["PRID"];
                req.RequisitionQty = Single.Parse(rdr["REQUISITIONQTY"].ToString());
                po.PurchaseRequisition = req;

                Supplier osup = new Supplier();
                osup.ID = (string)rdr["SUPPLIERID"];
                osup.Name = (string)rdr["SupplierName"];
                po.Supplier = osup;

                ItemOrder itm = new ItemOrder();
                itm.Rate = Single.Parse(rdr["RATE"].ToString());
                itm.SlRate = !rdr.IsDBNull(rdr.GetOrdinal("SalesRate")) ? Convert.ToSingle(rdr["SalesRate"]) : 0;
                itm.VAT = Single.Parse(rdr["VAT"].ToString());
                itm.Discount = Single.Parse(rdr["DISCOUNT"].ToString());
                itm.POQty = Single.Parse(rdr["POQTY"].ToString());
                itm.RemQty = Single.Parse(rdr["REMAININGQTY"].ToString());
                itm.RetQty = Single.Parse(rdr["RETURNQTY"].ToString());

                ItemMaster item = new ItemMaster();
                item.ID = (string)rdr["ItemID"];
                item.Name = (string)rdr["ItemName"];
                item.IsSerial = (string)rdr["ISSERIALREQ"];

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["CompanyID"];
                ocomp.Name = (string)rdr["CompanyName"];
                item.Company = ocomp;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["GroupID"];
                ogroup.Name = (string)rdr["GroupName"];
                item.GroupDetails = ogroup;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UnitID"];
                ounit.Name = (string)rdr["UnitName"];
                item.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TypeID"];
                otype.Name = (string)rdr["TypeName"];
                item.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BrandID"];
                obrand.Name = (string)rdr["BrandName"];
                item.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["ModelID"];
                omodel.Name = (string)rdr["ModelName"];
                item.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                item.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                item.StoreType = ostrtype;

                itm.ItemMaster = item;
                po.ItemOrder = itm;

                oporder.Add(po);
            }
            rdr.Close();
            return oporder;
        }
        #endregion

        #region SaveTermsandCondition
        public short SaveTermsandCondition(TermsAndConditions oterms)
        {
            string packageName = "PKG_TERMS_CONDITION.Insert_TermsCondition";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,2,oterms.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,oterms.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,oterms.NameBeng,ParameterDirection.Input),
                new OracleParameter("AutoSelected",OracleDbType.Char,1,oterms.IsAutoSelected,ParameterDirection.Input),
                new OracleParameter("Bold",OracleDbType.Char,1,oterms.IsBold,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,oterms.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Char,1,oterms.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oterms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oterms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oterms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oterms.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm =  parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyTermsandCondition
        public short ModifyTermsandCondition(TermsAndConditions oterms)
        {
            string packageName = "PKG_TERMS_CONDITION.Update_TermsCondition";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,2,oterms.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("ID",OracleDbType.Varchar2,6,oterms.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,oterms.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,oterms.NameBeng,ParameterDirection.Input),
                new OracleParameter("AutoSelected",OracleDbType.Char,1,oterms.IsAutoSelected,ParameterDirection.Input),
                new OracleParameter("Bold",OracleDbType.Char,1,oterms.IsBold,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,oterms.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Char,1,oterms.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oterms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oterms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oterms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oterms.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetTermsandCondition
        public List<TermsAndConditions> GetTermsandCondition()
        {
            string packageName = "PKG_TERMS_CONDITION.GetTermscondition";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetTermsandCond(packageName,parameterList);
        }
        private List<TermsAndConditions> GetTermsandCond(string packageName,OracleParameter[] parameterList)
        {
            List<TermsAndConditions> otermscond = new List<TermsAndConditions>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                TermsAndConditions oterms = new TermsAndConditions();
                oterms.ID = (string)rdr["id"];
                oterms.Name = (string)rdr["Name"];
                oterms.NameBeng = (string)rdr["name_beng"];
                oterms.IsAutoSelected = (string)rdr["is_auto_selected"];
                oterms.IsBold = (string)rdr["is_bold"];
                oterms.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                oterms.Priority = (string)rdr["priority"];

                StoreLocation ostore = new StoreLocation();
                ostore.ID = (string)rdr["store_id"];
                ostore.Name = (string)rdr["StoreName"];
                oterms.StoreLocation = ostore;

                otermscond.Add(oterms);
            }
            rdr.Close();
            return otermscond;
        }
        #endregion

        #region GetPORecord
        public List<PurchaseOrder> GetPORecord(string itemid)
        {
            string packageName = "PKG_PO.GET_LAST_PORECORD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ItemId",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input)
            };
            List<PurchaseOrder> opurorder = new List<PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                PurchaseOrder opur = new PurchaseOrder();
                opur.ID = (string)rdr["POID"];
                opur.PODate = DateTime.Parse(rdr["PODATE"].ToString());

                ItemOrder oitmorder = new ItemOrder();
                oitmorder.Rate = float.Parse(rdr["PORATE"].ToString());
                oitmorder.POQty = float.Parse(rdr["Quantity"].ToString());
                oitmorder.Batch = (string)rdr["BATCHNO"];
                oitmorder.StockQty = float.Parse(rdr["StockQty"].ToString());

                ItemMaster oitem = new ItemMaster();
                oitem.ID = (string)rdr["ITEMID"];
                oitem.Name = (string)rdr["ITEMNAME"];
                oitmorder.ItemMaster = oitem;

                opur.ItemOrder = oitmorder;
                

                Supplier osupp = new Supplier();
                osupp.ID = (string)rdr["SUPPLIERID"];
                osupp.Name = (string)rdr["SUPPLIERNAME"];
                opur.Supplier = osupp;



                opurorder.Add(opur);
            }
            return opurorder;
        }
        #endregion

        #region VarifyPOForModify
        public int VarifyPOForModify(string poid)
        {
            string packageName = "PKG_PO.VERIFY_PO_FORMODIFY";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

    }
}
