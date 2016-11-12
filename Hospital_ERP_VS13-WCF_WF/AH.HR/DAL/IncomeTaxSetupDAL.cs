using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;

namespace AH.HR.DAL
{
    public class IncomeTaxSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

        #region SaveIncomeTax
        public short SaveIncomeTax(IncomeTax oIncomeTax)
        {
            packagename = "PKG_INCOME_TAX_SETUP .INSERT_IT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_fiscal_year",OracleDbType.Varchar2,15,oIncomeTax.FiscalYear ,ParameterDirection.Input),
                new OracleParameter("p_catagory",OracleDbType.Varchar2,1,oIncomeTax.Catagory,ParameterDirection.Input),
                new OracleParameter("p_hra_exm",OracleDbType.Varchar2,300,oIncomeTax.HraExm,ParameterDirection.Input),
                new OracleParameter("p_ma_exm",OracleDbType.Varchar2,300,oIncomeTax.MaExm,ParameterDirection.Input),
                new OracleParameter("p_con_exm",OracleDbType.Varchar2,300,oIncomeTax.ConExm,ParameterDirection.Input),               
                new OracleParameter("p_invst_limit",OracleDbType.Varchar2,300,oIncomeTax.InvstLimit,ParameterDirection.Input),
                new OracleParameter("p_invst_tax_rebate",OracleDbType.Varchar2,300,oIncomeTax.InvstTaxRebat,ParameterDirection.Input),
                new OracleParameter("p_tax_free_limit",OracleDbType.Varchar2,300,oIncomeTax.TaxFreeLimit,ParameterDirection.Input),
                new OracleParameter("p_min_tax_amt",OracleDbType.Varchar2,300,oIncomeTax.MinTaxAmt,ParameterDirection.Input),
                new OracleParameter("p_slot_1",OracleDbType.Varchar2,300,oIncomeTax.Slot1,ParameterDirection.Input),
                new OracleParameter("p_slot_1_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot1Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_2",OracleDbType.Varchar2,300,oIncomeTax.Slot2,ParameterDirection.Input),
                new OracleParameter("p_slot_2_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot2Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_3",OracleDbType.Varchar2,300,oIncomeTax.Slot3,ParameterDirection.Input),
                new OracleParameter("p_slot_3_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot3Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_4",OracleDbType.Varchar2,300,oIncomeTax.Slot4,ParameterDirection.Input),
                new OracleParameter("p_slot_4_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot4Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_5",OracleDbType.Varchar2,300,oIncomeTax.Slot5,ParameterDirection.Input),
                new OracleParameter("p_slot_5_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot5Limit,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oIncomeTax.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oIncomeTax.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oIncomeTax.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oIncomeTax.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateIncomeTax

        public short UpdateIncomeTax(IncomeTax oIncomeTax)
        {
            packagename = "PKG_INCOME_TAX_SETUP .UPDATE_IT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_fiscal_year",OracleDbType.Varchar2,15,oIncomeTax.FiscalYear ,ParameterDirection.Input),
                new OracleParameter("p_catagory",OracleDbType.Varchar2,1,oIncomeTax.Catagory,ParameterDirection.Input),
                new OracleParameter("p_hra_exm",OracleDbType.Varchar2,300,oIncomeTax.HraExm,ParameterDirection.Input),
                new OracleParameter("p_ma_exm",OracleDbType.Varchar2,300,oIncomeTax.MaExm,ParameterDirection.Input),
                new OracleParameter("p_con_exm",OracleDbType.Varchar2,300,oIncomeTax.ConExm,ParameterDirection.Input),               
                new OracleParameter("p_invst_limit",OracleDbType.Varchar2,300,oIncomeTax.InvstLimit,ParameterDirection.Input),
                new OracleParameter("p_invst_tax_rebate",OracleDbType.Varchar2,300,oIncomeTax.InvstTaxRebat,ParameterDirection.Input),
                new OracleParameter("p_tax_free_limit",OracleDbType.Varchar2,300,oIncomeTax.TaxFreeLimit,ParameterDirection.Input),
                new OracleParameter("p_min_tax_amt",OracleDbType.Varchar2,300,oIncomeTax.MinTaxAmt,ParameterDirection.Input),
                new OracleParameter("p_slot_1",OracleDbType.Varchar2,300,oIncomeTax.Slot1,ParameterDirection.Input),
                new OracleParameter("p_slot_1_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot1Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_2",OracleDbType.Varchar2,300,oIncomeTax.Slot2,ParameterDirection.Input),
                new OracleParameter("p_slot_2_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot2Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_3",OracleDbType.Varchar2,300,oIncomeTax.Slot3,ParameterDirection.Input),
                new OracleParameter("p_slot_3_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot3Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_4",OracleDbType.Varchar2,300,oIncomeTax.Slot4,ParameterDirection.Input),
                new OracleParameter("p_slot_4_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot4Limit,ParameterDirection.Input),
                new OracleParameter("p_slot_5",OracleDbType.Varchar2,300,oIncomeTax.Slot5,ParameterDirection.Input),
                new OracleParameter("p_slot_5_limit",OracleDbType.Varchar2,300,oIncomeTax.Slot5Limit,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oIncomeTax.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oIncomeTax.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oIncomeTax.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oIncomeTax.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

        #region GetIncomeTax      
        public List<IncomeTax> GetIncomeTax(string oIncomeTax)
        {
            string packageName = "PKG_INCOME_TAX_SETUP.GET_IT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_fiscal_year",OracleDbType.Varchar2,15,oIncomeTax,ParameterDirection.Input)
           };
            return GetIncomeTaxDetails(packageName, parameterList);
        }
        public List<IncomeTax> GetIncomeTaxInfo(string FiscalYear,string Category)
        {
            string packageName = "PKG_INCOME_TAX_SETUP.GET_IT_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_fiscal_year",OracleDbType.Varchar2,15,FiscalYear,ParameterDirection.Input),
                new OracleParameter("p_category",OracleDbType.Varchar2,15,Category,ParameterDirection.Input)
           };
            return GetIncomeTaxDetails(packageName, parameterList);
        }
        private List<IncomeTax> GetIncomeTaxDetails(string packageName, OracleParameter[] parameterList)
        {
            List<IncomeTax> oIncomeTaxs = new List<IncomeTax>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IncomeTax oIncomeTax = new IncomeTax();
                oIncomeTax.FiscalYear = (string)rdr["FISCAL_YR"].ToString();
                oIncomeTax.Catagory = (string)rdr["CATEGORY"].ToString();
                oIncomeTax.HraExm = (string)rdr["HRA_EXM"].ToString();
                oIncomeTax.MaExm = (string)rdr["MA_EXM"].ToString();
                oIncomeTax.ConExm = (string)rdr["CON_EXM"].ToString();
                oIncomeTax.InvstLimit = (string)rdr["INVST_LIMIT"].ToString();
                oIncomeTax.InvstTaxRebat = (string)rdr["INVST_TAX_REBATE"].ToString();
                oIncomeTax.TaxFreeLimit = (string)rdr["TAX_FREE_LMT"].ToString();
                oIncomeTax.Slot1 = (string)rdr["SLOT1"].ToString();
                oIncomeTax.Slot2 = (string)rdr["SLOT2"].ToString();
                oIncomeTax.Slot3 = (string)rdr["SLOT3"].ToString();
                oIncomeTax.Slot4 = (string)rdr["SLOT4"].ToString();
                oIncomeTax.Slot5 = (string)rdr["SLOT5"].ToString();
                oIncomeTax.MinTaxAmt = (string)rdr["MIN_TX_AMT"].ToString();
                oIncomeTax.Slot1Limit = (string)rdr["SLOT1_LIMIT"].ToString();
                oIncomeTax.Slot2Limit = (string)rdr["SLOT2_LIMIT"].ToString();
                oIncomeTax.Slot3Limit = (string)rdr["SLOT3_LIMIT"].ToString();
                oIncomeTax.Slot4Limit = (string)rdr["SLOT4_LIMIT"].ToString();
                oIncomeTax.Slot5Limit = (string)rdr["SLOT5_LIMIT"].ToString();
                oIncomeTaxs.Add(oIncomeTax);
            }
            rdr.Close();
            return oIncomeTaxs;
        }
        #endregion
    }
}
