using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PHRMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.PHRMS.DAL
{
    public class POReportDAL
    {
        public string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region GetPOReportDet
        public List<PODetailsRO> GetPOReportDet(string poid)
        {
            string packageName = "PKG_PO.GET_POREPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
                //new OracleParameter("PharmacyID",OracleDbType.Varchar2,15,phrid,ParameterDirection.Input)
            };
            return GetPOReport(packageName, parameterList);
        }
        private List<PODetailsRO> GetPOReport(string packageName, OracleParameter[] parameterList)
        {
            List<PODetailsRO> podet = new List<PODetailsRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PODetailsRO po = new PODetailsRO();

                po.PharmacyID = (string)rdr["PHARMACYID"];
                po.PharmacyName = (string)rdr["PharmacyName"];
                po.POID = (string)rdr["POID"];
                po.POTYPE = (string)rdr["POType"];
                po.PRID = (string)rdr["PRID"];
                po.SupplierID = (string)rdr["SupplierID"];
                po.SupplierName = (string)rdr["SupplierName"];
                po.SupplierAddress = (string)rdr["SupplierAddress"];
                po.SupplierPhone = (string)rdr["SupplierPhone"];
                po.SupplierFaxNo = (string)rdr["SupplierFaxNo"];
                po.DrugID = (string)rdr["drugID"];
                po.DrugName = (string)rdr["DrugName"];
                po.DrugCompany = (string)rdr["DrugCompany"];
                po.CompanyName = (string)rdr["CompanyName"];
                po.DrugGroup = (string)rdr["DrugGroup"];
                po.GroupName = (string)rdr["GroupName"];
                po.DrugUnit = (string)rdr["DrugUnit"];
                po.UnitName = (string)rdr["UnitName"];
                po.Type = (string)rdr["TYPEID"];
                po.TypeName = (string)rdr["TypeName"];
                po.POQty = Single.Parse(rdr["POQty"].ToString());

                po.Rate = Single.Parse(rdr["Rate"].ToString());
                po.SalesRate = Single.Parse(rdr["SalesRate"].ToString());
                po.Vat = Single.Parse(rdr["Vat"].ToString());
                po.Discount = Single.Parse(rdr["Discount"].ToString());
                po.RemainingQty = Single.Parse(rdr["REMAININGQTY"].ToString());
                po.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                po.DeliveryDate = DateTime.Parse(rdr["DELIVERYDATE"].ToString());
                po.DeliveryNote = !rdr.IsDBNull(rdr.GetOrdinal("DELIVERYNOTE")) ? (string)rdr["DELIVERYNOTE"] : "";
                po.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("REMARKS")) ? (string)rdr["REMARKS"] : "";
                po.CompleteFlag = (string)rdr["COMPLETEFLAG"];
                podet.Add(po);
            }
            rdr.Close();
            return podet;

        }
        public List<PODetailsRO> GetPOReportDateWise(string startDate, string endDate)
        {
            string packageName = "PKG_PO.GET_PODATEWISE";
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
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                PODetailsRO po = new PODetailsRO();

                po.PharmacyID = (string)rdr["PharmacyID"];
                po.PharmacyName = (string)rdr["PharmacyName"];
                po.POID = (string)rdr["POID"];
                po.POTYPE = (string)rdr["POTYPE"];
                po.PRID = (string)rdr["PRID"];
                po.SupplierID = (string)rdr["SupplierID"];
                po.SupplierName = (string)rdr["SupplierName"];
                po.SupplierAddress = (string)rdr["SupplierAddress"];
                po.SupplierPhone = (string)rdr["SupplierPhone"];
                po.SupplierFaxNo = (string)rdr["SupplierFaxNo"];
                po.DrugID = (string)rdr["DrugID"];
                po.DrugName = (string)rdr["DrugName"];
                po.DrugCompany = (string)rdr["DrugCompany"];
                po.CompanyName = (string)rdr["CompanyName"];
                po.DrugGroup = (string)rdr["DrugGroup"];
                po.GroupName = (string)rdr["GroupName"];
                po.DrugUnit = (string)rdr["DrugUnit"];
                po.UnitName = (string)rdr["UnitName"];
                po.Type = (string)rdr["Type"];
                po.TypeName = (string)rdr["TypeName"];
                po.POQty = Single.Parse(rdr["POQty"].ToString());
                
                po.Rate = Single.Parse(rdr["Rate"].ToString());
                po.Vat = Single.Parse(rdr["Vat"].ToString());
                po.Discount = Single.Parse(rdr["Discount"].ToString());
                po.RemainingQty = Single.Parse(rdr["RemainingQty"].ToString());
                po.PODATE = DateTime.Parse(rdr["PODATE"].ToString());
                po.DeliveryDate = DateTime.Parse(rdr["DELIVERYDATE"].ToString());
                po.DeliveryNote = !rdr.IsDBNull(rdr.GetOrdinal("DELIVERYNOTE")) ? (string)rdr["DELIVERYNOTE"] : "";
                po.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                po.CompleteFlag = (string)rdr["COMPLETEFLAG"];
                podet.Add(po);
            }
            rdr.Close();
            return podet;

        }
        #endregion

        #region VerifyPOID
        public int VerifyPOID(string poid)
        {
            string packageName = "PKG_PO.VERIFY_POID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,20,poid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            int ponum = (int)(OracleDecimal)prm.Value;
            return ponum;
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
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
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
                opled.Pharmacy = (string)rdr["Pharmacy"].ToString();
                opled.PharmacyName = (string)rdr["PharmacyName"].ToString();
                
                opled.DT = DateTime.Parse(rdr["DT"].ToString());
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
            return GetPOTerms(packageName, parameterList);
        }
        private List<POTermsConditionRO> GetPOTerms(string packageName, OracleParameter[] parameterList)
        {
            List<POTermsConditionRO> opoterms = new List<POTermsConditionRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                POTermsConditionRO oterm = new POTermsConditionRO();
                
                oterm.POID = (string)rdr["po_id"];
                oterm.TermsID = (string)rdr["terms_id"];
                oterm.TermsName = (string)rdr["TERMSNAME"];

                opoterms.Add(oterm);
            }
            rdr.Close();
            return opoterms;
        }
        #endregion

    }
}
