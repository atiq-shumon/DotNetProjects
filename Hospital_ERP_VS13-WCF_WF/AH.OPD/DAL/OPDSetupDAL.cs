using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.OPD.MODEL;
using AH.Shared.MODEL;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Data;

namespace AH.OPD.DAL
{
    public class OPDSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);


        #region Advice setup insert
        public short AdviceSetupInsert(OPDAdvice oAdvice)
        {
            string packageName = "AGH_OPD.PKG_OPD_SETUP.Advice_Setup_Insert";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("p_advice",OracleDbType.Varchar2,300,oAdvice.AdviceDetails,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,6,oAdvice.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oAdvice.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oAdvice.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oAdvice.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oAdvice.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oAdvice.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion
     
        #region Advice setup GET
        public List<OPDAdvice> AdviceSetupGET()
        {
            string packageName = "AGH_OPD.PKG_OPD_SETUP.Advice_Setup_Get";
            OracleParameter[] paramList = new OracleParameter[]
            { 
                 new OracleParameter("p_e_rows",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output) 
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, paramList);
            List<OPDAdvice> oAdviceLIST = new List<OPDAdvice>();

            while (rdr.Read())
            {
                OPDAdvice oadvice = new OPDAdvice();
               
                oadvice.AdviceID = (string)rdr["ADVICE_ID"];
                oadvice.AdviceDetails = (string)rdr["advice_part1"];

                Department odept = new Department();
                odept.DepartmentID = rdr["dept_id"] != DBNull.Value ? Convert.ToString(rdr["dept_id"]) : "";
                oadvice.Department = odept;

                oadvice.Remarks = rdr["remarks"] != DBNull.Value ? Convert.ToString(rdr["remarks"]) : ""; 

                oAdviceLIST.Add(oadvice);        
            }

            rdr.Close();
            return oAdviceLIST;
        }
        #endregion

        #region Advice setup Update
        public short AdviceSetupUpdate(OPDAdvice oAdvice)
        {
            
            string packageName = "PKG_OPD_SETUP.Advice_Setup_Update";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("p_advice_id",OracleDbType.Varchar2,10,oAdvice.AdviceID,ParameterDirection.Input),
                new OracleParameter("p_advice",OracleDbType.Varchar2,300,oAdvice.AdviceDetails,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,6,oAdvice.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oAdvice.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oAdvice.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oAdvice.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oAdvice.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oAdvice.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion



        #region GetAdviceDetails()
        public List<OPDAdvice> GetAdviceDetails(string adviceID, string deptid)
        {

            string packageName = "AGH_OPD.PKG_OPD_SETUP.Get_Advice_Details";

            OracleParameter[] paramList = new OracleParameter[]
            { 
                 new OracleParameter("p_e_rows",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                  new OracleParameter("p_advice_id",OracleDbType.Varchar2,10,adviceID,ParameterDirection.Input),
                  new OracleParameter("p_dept_id",OracleDbType.Varchar2,6,deptid,ParameterDirection.Input)
            };
            OracleDataReader rdr = DALHelper.ExecuteProcedure(connString, packageName, paramList);

            List<OPDAdvice> oAdviceLIST = new List<OPDAdvice>();


            while (rdr.Read())
            {
                OPDAdvice oadvice = new OPDAdvice();
               
                oadvice.AdviceID = (string)rdr["ADVICE_ID"];
                oadvice.AdviceDetails = (string)rdr["advice_part1"];

                Department odept = new Department();
                odept.DepartmentID = (string)rdr["dept_id"] ;
                oadvice.Department = odept;

                oadvice.Remarks = rdr["remarks"] != DBNull.Value ? Convert.ToString(rdr["remarks"]) : ""; 

                oAdviceLIST.Add(oadvice);
            
            }

            rdr.Close();
            return oAdviceLIST;
        }

        #endregion
    }
}
