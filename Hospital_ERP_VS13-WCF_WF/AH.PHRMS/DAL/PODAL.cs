using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.OracleManager;
using AH.DUtility;
using AH.PHRMS.MODEL;
using AH.INVMS.MODEL;
using AH.PRMS.MODEL;
using AH.DRUGS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PHRMS.DAL
{
    public class PODAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SavePO
        public string SavePurchaseOrder(AH.PHRMS.MODEL.PurchaseOrder po)
        {
            string packageName = "PKG_PO.SAVE_PO";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,po.ID,ParameterDirection.InputOutput),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,po.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("PRId",OracleDbType.Varchar2,15,po.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("Supplier",OracleDbType.Varchar2,15,po.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,po.PurchaseRequisition.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,po.PurchaseRequisition.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,po.TransactionType,ParameterDirection.Input),
                new OracleParameter("PODate",OracleDbType.Date,po.PODate,ParameterDirection.Input),
                new OracleParameter("POType",OracleDbType.Varchar2,3,po.Type,ParameterDirection.Input),
                new OracleParameter("DeliveryDate",OracleDbType.Date,po.Deliverydate,ParameterDirection.Input),
                new OracleParameter("DeliveryNote",OracleDbType.Varchar2,200,po.Deliverynote,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,po.Remarks,ParameterDirection.Input),
                new OracleParameter("PODetails",OracleDbType.Varchar2,32000,po.POString,ParameterDirection.Input),
                new OracleParameter("TermsDetails",OracleDbType.Varchar2,10000,po.TermsDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,po.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,po.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,po.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,po.EntryParameter.MachineID,ParameterDirection.Input)
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

        #region GetPONumbers
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPONumbers(string pharmacyID)
        {
            string packageName = "PKG_PO.GET_PONUMBERS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyID,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.PurchaseOrder> ponum = new List<AH.PHRMS.MODEL.PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseOrder po = new AH.PHRMS.MODEL.PurchaseOrder();
                po.ID = (string)rdr["po_id"];
                ponum.Add(po);
            }
            rdr.Close();
            return ponum;

        }
        #endregion

        #region GetPONum
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPONum()
        {
            string packageName = "PKG_PO.GET_PO_NUM";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };
            List<AH.PHRMS.MODEL.PurchaseOrder> ponum = new List<AH.PHRMS.MODEL.PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseOrder po = new AH.PHRMS.MODEL.PurchaseOrder();
                po.ID = (string)rdr["po_id"];
                po.PODate = DateTime.Parse(rdr["po_date"].ToString());
                ponum.Add(po);
            }
            rdr.Close();
            return ponum;

        }
        #endregion

        #region GetPODetails
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPODetails(string poid, string phrid)
        {
            string packageName = "PKG_PO.GET_PODETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,phrid,ParameterDirection.Input)

            };
           return GetPONumbers(packageName,parameterList);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOList(string poid)
        {
            string packageName = "PKG_PO.GET_PODETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)               

            };
            return GetPONumbers(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.PurchaseOrder> GetPONumbers(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.PurchaseOrder> podet = new List<AH.PHRMS.MODEL.PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseOrder po = new AH.PHRMS.MODEL.PurchaseOrder();
                po.Type = (string)rdr["POTYPE"];                 
                po.PODate = DateTime.Parse(rdr["PODATE"].ToString());

                Warehouse phr = new Warehouse();
                phr.TypeID = (string)rdr["PHARMACYID"];
                phr.TypeName = (string)rdr["PHARMACYNAME"];
                po.Warehouse = phr;

                AH.PHRMS.MODEL.PurchaseRequisition oreq = new AH.PHRMS.MODEL.PurchaseRequisition();
                oreq.ID = (string)rdr["PRID"];
                oreq.RequisitionQty = float.Parse(rdr["REQQTY"].ToString());
                po.PurchaseRequisition = oreq;

                AH.PHRMS.MODEL.Supplier supp = new AH.PHRMS.MODEL.Supplier();
                supp.ID = (string)rdr["SupplierID"];
                supp.Name = (string)rdr["SupplierName"];
                po.Supplier = supp;

                ItemsOrder itm = new ItemsOrder();
                itm.URate = Single.Parse(rdr["RATE"].ToString());
                itm.VAT = Single.Parse(rdr["VAT"].ToString());
                itm.Discount = Single.Parse(rdr["DISCOUNT"].ToString());
                itm.SlRate = Single.Parse(rdr["SalesRate"].ToString());
                itm.POQty = Single.Parse(rdr["POQTY"].ToString());
                itm.RetQty = Single.Parse(rdr["RETURNQTY"].ToString());
                itm.RemQty = Single.Parse(rdr["REMAININGQTY"].ToString());

                DrugMaster ms = new DrugMaster();
                ms.ID = (string)rdr["DRUGID"];
                ms.Name = (string)rdr["DRUGNAME"];
                

                DrugCompany comp = new DrugCompany();
                comp.ID = (string)rdr["DRUGCOMPANY"];
                comp.Name = (string)rdr["COMPANYNAME"];
                ms.DrugCompany = comp;

                DrugGroup grp = new DrugGroup();
                grp.ID = (string)rdr["DrugGroup"];
                grp.Name = (string)rdr["GroupName"];
                ms.DrugGroup = grp;

                DrugUnit unit = new DrugUnit();
                unit.ID = (string)rdr["DrugUnit"];
                unit.Name = (string)rdr["UnitName"];
                ms.DrugUnit = unit;

                DrugPackType type = new DrugPackType();
                type.ID = (string)rdr["TYPE"];
                type.Name = (string)rdr["TypeName"];
                ms.DrugPackType = type;

                itm.DrugMaster = ms;
                po.ItemsOrder = itm;
               

                podet.Add(po);
            }

            rdr.Close();
            return podet;
        }
        #endregion

        #region SavePOType
        public short SavePOType(POTypes type)
        {
            string packageName = "PKG_PO.INSERT_PO_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,70,type.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,70,type.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,type.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,type.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,type.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,type.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,type.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;

        }
        #endregion

        #region GetPOTypes
        public List<POTypes> GetPOTypes()
        {
            string packageName = "PKG_PO.GET_PO_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<POTypes> opolst = new List<POTypes>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                POTypes otype = new POTypes();
                otype.ID = (string)rdr["type_id"];
                otype.Name = (string)rdr["type_title"];
                otype.NameBeng = (string)rdr["type_title_beng"];
                otype.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("remarks")) ? (string)rdr["remarks"] : "";

                opolst.Add(otype);
            }
            rdr.Close();
            return opolst;
        }
        #endregion

        #region ModifyPOType
        public short ModifyPOType(POTypes type)
        {
            string packageName = "PKG_PO.UPDATE_PO_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,3,type.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,70,type.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,70,type.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,type.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,type.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,type.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,type.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,type.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;

        }
        #endregion

        #region SaveTermsandCondition
        public short SaveTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms)
        {
            string packageName = "PKG_TERMS_CONDITIONS.Insert_TermsCondition";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
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
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetTermsandCondition
        public List<AH.PHRMS.MODEL.TermsAndConditions> GetTermsandCondition()
        {
            string packageName = "PKG_TERMS_CONDITIONS.GetTermscondition";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetTermsandCond(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.TermsAndConditions> GetTermsandCond(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.TermsAndConditions> otermscond = new List<AH.PHRMS.MODEL.TermsAndConditions>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.TermsAndConditions oterms = new AH.PHRMS.MODEL.TermsAndConditions();
                oterms.ID = (string)rdr["id"];
                oterms.Name = (string)rdr["Name"];
                oterms.NameBeng = (string)rdr["name_beng"];
                oterms.IsAutoSelected = (string)rdr["is_auto_selected"];
                oterms.IsBold = (string)rdr["is_bold"];
                oterms.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                oterms.Priority = (string)rdr["priority"];

               

                otermscond.Add(oterms);
            }
            rdr.Close();
            return otermscond;
        }
        #endregion

        #region ModifyTermsandCondition
        public short ModifyTermsandCondition(AH.PHRMS.MODEL.TermsAndConditions oterms)
        {
            string packageName = "PKG_TERMS_CONDITIONS.Update_TermsCondition";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
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
    }
}
