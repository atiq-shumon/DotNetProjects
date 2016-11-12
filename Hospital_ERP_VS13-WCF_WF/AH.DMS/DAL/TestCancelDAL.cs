using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.PatReg.MODEL;
using AH.DTMS.MODEL;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;

namespace AH.DMS.DAL
{
    public class TestCancelDAL
    {
        public string connString = Utility.GetConnectionString(Utility.Module.DMSMIS);

     #region SaveTestCancel
        public string SaveTestCancel(DiagnosticMR mr)
        {
            string tests = "";
            foreach (TestFee dt in mr.Tests)
            {
                tests += (dt.TestSub.Room.RoomID == "" ? "0" : dt.TestSub.Room.RoomID)
                     + ":" + (dt.TestSub.Technologist.ID == "" ? "0" : dt.TestSub.Technologist.ID)
                     + ":" + dt.TestSub.ReportGroup.ReportGroupID
                     + ":" + dt.TestSub.TestDepartment.DepartmentID
                     + ":" + dt.TestSub.TestGroup.GroupId
                     + ":" + dt.TestSub.TestMainID
                     + ":" + dt.TestSub.TestSubID
                     + ":" + dt.FeeCategory.FeeCategoryID
                     + ":" + dt.Fee.ToString()
                     + ":" + dt.DeptFee.ToString()
                     + ":" + dt.RefdFee.ToString()
                     + ":" + dt.DoctorFee.ToString()
                     + ":" + dt.Discount.ToString()
                     + ":" + (dt.VAT.ToString() == "" ? "0" : dt.VAT.ToString())
                     + ";";               
            }
            string packageName = "PKG_TEST_CANCEL.TEST_CANCEL";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("p_trans_no",OracleDbType.Varchar2,30,null,ParameterDirection.Output),
              new OracleParameter("p_mr_no",OracleDbType.Varchar2,30,mr.MRNo,ParameterDirection.Input),  
              new OracleParameter("p_refund",OracleDbType.Varchar2,30,mr.RefundAmount,ParameterDirection.Input), 
              new OracleParameter("p_due",OracleDbType.Varchar2,30,mr.Due,ParameterDirection.Input), 
              new OracleParameter("P_TEST_COLLS",OracleDbType.Varchar2,4000,tests,ParameterDirection.Input), 
              new OracleParameter("p_cancel_cause",OracleDbType.Varchar2,100,mr.TestCancelCause,ParameterDirection.Input), 
              new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)              
             };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter prm1 = parameterList[1];         
            string DMR_No = (string)(OracleString)prm.Value;
            return DMR_No;
        }

        #endregion

     #region SaveTestCancelCause

        public short SaveTestCancelCause(TestCancelCause oCanCause)
        {
            string packageName = "PKG_TEST_CANCEL.INSERT_CAUSE_CANCEL_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,2,oCanCause.CauseId,ParameterDirection.Input),
                new OracleParameter("p_cause_title",OracleDbType.Varchar2,70,oCanCause.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_cause_title_beng",OracleDbType.Varchar2,70,oCanCause.CauseTitleBeng,ParameterDirection.Input),                    
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oCanCause.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oCanCause.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oCanCause.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oCanCause.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oCanCause.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oCanCause.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

     #region GetCancelCause
        public List<TestCancelCause> GetCancelCause()
        {
            string packageName = "PKG_TEST_CANCEL.GET_CANCEL_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetCauseTypes(packageName, parameterList);
        }
        private List<TestCancelCause> GetCauseTypes(string packageName, OracleParameter[] parameterList)
        {
            List<TestCancelCause> oTests = new List<TestCancelCause>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                TestCancelCause oTest = new TestCancelCause();
                oTest.CauseId = (String)rdr["CAUSE_ID"].ToString();
                oTest.CauseTitle = (String)rdr["CAUSE_TITLE"];
                oTest.CauseTitleBeng = (string)rdr["CAUSE_TITLE_BENG"];
                oTest.Remarks = !rdr.IsDBNull(3) ? (String)rdr["REMARKS"] : "";
                oTests.Add(oTest);
            }
            rdr.Close();
            return oTests;
        }
        #endregion

     #region UpdateCancelCause

        public short UpdateCancelCause(TestCancelCause oCanCause)
        {
            string packageName = "PKG_TEST_CANCEL.UPDATE_CANCEL_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,2,oCanCause.CauseId,ParameterDirection.Input),
                new OracleParameter("p_cause_title",OracleDbType.Varchar2,70,oCanCause.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_cause_title_beng",OracleDbType.Varchar2,70,oCanCause.CauseTitleBeng,ParameterDirection.Input),                    
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oCanCause.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oCanCause.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oCanCause.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oCanCause.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oCanCause.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oCanCause.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

  #endregion

     #region SaveRefundCause
        public short SaveRefundCause(RefundCause oRefundCause)
        {
            string packageName = "PKG_TEST_CANCEL.INSERT_REFUND_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,2,oRefundCause.CauseId,ParameterDirection.Input),
                new OracleParameter("p_cause_title",OracleDbType.Varchar2,70,oRefundCause.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_cause_title_beng",OracleDbType.Varchar2,70,oRefundCause.CauseTitleBeng,ParameterDirection.Input),                    
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oRefundCause.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oRefundCause.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oRefundCause.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

     #region UpdateRefundCause
        public short UpdateRefundCause(RefundCause oRefundCause)
        {
            string packageName = "PKG_TEST_CANCEL.UPDATE_REFUND_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_cause_id",OracleDbType.Varchar2,2,oRefundCause.CauseId,ParameterDirection.Input),
                new OracleParameter("p_cause_title",OracleDbType.Varchar2,70,oRefundCause.CauseTitle,ParameterDirection.Input),
                new OracleParameter("p_cause_title_beng",OracleDbType.Varchar2,70,oRefundCause.CauseTitleBeng,ParameterDirection.Input),                    
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oRefundCause.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oRefundCause.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oRefundCause.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oRefundCause.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

     #region GetRefundCause
        public List<RefundCause> GetRefundCause()
        {
            string packageName = "PKG_TEST_CANCEL.GET_REFUND_CAUSE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetRefundCauseDetails(packageName, parameterList);
        }
        private List<RefundCause> GetRefundCauseDetails(string packageName, OracleParameter[] parameterList)
        {
            List<RefundCause> oRefunds = new List<RefundCause>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                RefundCause oRefund = new RefundCause();
                oRefund.CauseId = (String)rdr["CAUSE_ID"].ToString();
                oRefund.CauseTitle = (String)rdr["CAUSE_TITLE"];
                oRefund.CauseTitleBeng = (string)rdr["CAUSE_TITLE_BENG"];
                oRefund.Remarks = !rdr.IsDBNull(3) ? (String)rdr["REMARKS"] : "";
                oRefunds.Add(oRefund);
            }
            rdr.Close();
            return oRefunds;
        }
        #endregion

    }
}
