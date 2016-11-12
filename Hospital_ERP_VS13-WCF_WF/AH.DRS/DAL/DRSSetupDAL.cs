using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DRS.MODEL;
using AH.DMS.MODEL;
using AH.HR.MODEL;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.DTMS.MODEL;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace AH.DRS.DAL
{
    public class DRSSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.DRSMIS);
        string packagename = string.Empty;

       

        //#region VerifySpecimenHolder
        //public int VerifySpecHolder(string spchold)
        //{
        //    packagename = "PKG_DRS_SETUP.VERIFY_SPCHOLDID";
        //    OracleParameter[] parameterList = new OracleParameter[] {
        //        new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
        //        new OracleParameter("HolderID",OracleDbType.Varchar2,4,spchold,ParameterDirection.Input)
        //    };
        //    short i = DALHelper.Insert(connstring, packagename, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    int regno = (int)(OracleDecimal)prm.Value;
        //    return regno;
        //}
        //#endregion

        //#region SaveSpecimenHolder
        //public short SaveSpecHolder(SpecimenHolder spchld)
        //{
        //    packagename = "PKG_DRS_SETUP.INSERT_SPC_HOLDER";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("HolderName",OracleDbType.Varchar2,70,spchld.HolderTitle,ParameterDirection.Input),
        //        new OracleParameter("HolderNameBeng",OracleDbType.Varchar2,70,spchld.HolderTitleBeng,ParameterDirection.Input),
        //        new OracleParameter("Remarks",OracleDbType.Varchar2,200,spchld.Remarks,ParameterDirection.Input),
        //        new OracleParameter("EntryBy",OracleDbType.Varchar2,20,spchld.EntryParameter.EntryBy,ParameterDirection.Input),
        //        new OracleParameter("CompanyID",OracleDbType.Varchar2,2,spchld.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("LocationID",OracleDbType.Varchar2,2,spchld.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("MachineID",OracleDbType.Varchar2,20,spchld.EntryParameter.MachineID,ParameterDirection.Input)
        //    };
        //    short i = DALHelper.Insert(connstring, packagename, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    if ((OracleDecimal)prm.Value == 1)
        //        return 1;
        //    else return 0;
        //}
        //#endregion

        //#region UpdateSpecimenHolder
        //public short UpdateSpcHolder(SpecimenHolder usphl)
        //{
        //    packagename = "PKG_DRS_SETUP.UPDATE_SPC_HOLDER";
        //    OracleParameter[] parameterList = new OracleParameter[] {
        //        new OracleParameter("eRows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("HolderID",OracleDbType.Varchar2,4,usphl.HolderID,ParameterDirection.Input),
        //        new OracleParameter("HolderName",OracleDbType.Varchar2,70,usphl.HolderTitle,ParameterDirection.Input),
        //        new OracleParameter("HolderNameBeng",OracleDbType.Varchar2,70,usphl.HolderTitleBeng,ParameterDirection.Input),
        //        new OracleParameter("Remarks",OracleDbType.Varchar2,200,usphl.Remarks,ParameterDirection.Input),
        //        new OracleParameter("EntryBy",OracleDbType.Varchar2,20,usphl.EntryParameter.EntryBy,ParameterDirection.Input),
        //        new OracleParameter("CompanyID",OracleDbType.Varchar2,2,usphl.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("LocationID",OracleDbType.Varchar2,2,usphl.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("MachineID",OracleDbType.Varchar2,20,usphl.EntryParameter.MachineID,ParameterDirection.Input)
        //    };
        //    short i = DALHelper.Update(connstring, packagename, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    if ((OracleDecimal)prm.Value == 1)
        //        return 1;
        //    else return 0;
        //}
        //#endregion

        //#region GetSpecimenHolder
        //public List<SpecimenHolder> GetSpecHolder()
        //{
        //    string packagename = "PKG_DRS_SETUP.GET_SPC_HOLDER";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
        //    };
        //    return GetSpecHld(packagename, parameterList);
        //}
        //private List<SpecimenHolder> GetSpecHld(string packagename, OracleParameter[] parameterList)
        //{
        //    List<SpecimenHolder> spchd = new List<SpecimenHolder>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
        //    while (rdr.Read())
        //    {
        //        SpecimenHolder spechl = new SpecimenHolder();
        //        spechl.HolderID = (string)rdr[0];
        //        spechl.HolderTitle = (string)rdr[1];
        //        spechl.HolderTitleBeng = (string)rdr[2];
        //        spechl.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
        //        spchd.Add(spechl);
        //    }
        //    rdr.Close();
        //    return spchd;
        //}
        //#endregion

        #region SaveUserReportAccess
        public string SaveUserReportAccess(UserReportAccess userAccess)
        {
            packagename = "PKG_DRS_SETUP.INSERT_T_USER_FILTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
               // new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("p_user_id",OracleDbType.Varchar2,30,userAccess.UserID,ParameterDirection.Input),
                new OracleParameter("p_department_id",OracleDbType.Varchar2,5,userAccess.ReportGroup.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_report_section_id",OracleDbType.Varchar2,5,userAccess.ReportGroup.ReportSection.ReportSectionID,ParameterDirection.Input),
                new OracleParameter("p_reportGroup_id",OracleDbType.Varchar2,7,userAccess.ReportGroup.ReportGroupID,ParameterDirection.Input),           
                new OracleParameter("p_EntryBy",OracleDbType.Varchar2,20,userAccess.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,20,userAccess.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,20,userAccess.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,userAccess.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];       
            string output = (string)(OracleString)prm.Value;
            return output;
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
        }
        #endregion
        public List<UserReportAccess> GetUserAccess(string deptID,string rptSecID)
        {
            string packagename = "PKG_DRS_SETUP.Get_User_Access";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_deptID",OracleDbType.Varchar2,5,deptID,ParameterDirection.Input),
             //   new OracleParameter("p_rptGrpID",OracleDbType.Varchar2,5,rptGrpID,ParameterDirection.Input),
                new OracleParameter("p_rptSecID",OracleDbType.Varchar2,7,rptSecID,ParameterDirection.Input)
            };
            return GetUserAccess(packagename, parameterList);
        }
        private List<UserReportAccess> GetUserAccess(string packagename, OracleParameter[] parameterList)
        {
            List<UserReportAccess> oUserRptAcess = new List<UserReportAccess>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packagename, parameterList);
            while (rdr.Read())
            {
                UserReportAccess oUserRptAcs = new UserReportAccess();
                oUserRptAcs.UserID = (string)rdr["USER_ID"];
                oUserRptAcs.UserName = (string)rdr["emp_name"];

                ReportSection oRptSec = new ReportSection();
                oRptSec.ReportSectionID = (string)rdr["RPT_SECTION"];
                oRptSec.ReportSectionTitle = (string)rdr["RrptSection"];

                ReportGroup oRptGrp = new ReportGroup();
                oRptGrp.ReportGroupID = (string)rdr["RPT_GROUP"];
                oRptGrp.ReportGroupTitle = (string)rdr["ReportGroup"];
                oRptGrp.ReportSection = oRptSec;

                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["DEPT_ID"];
                oDept.DepartmentTitle = (string)rdr["dept_title"];
                oRptGrp.Department = oDept;

                EntryParameter ep = new EntryParameter();
                ep.EntryDate = (DateTime)rdr["DT"];
                oUserRptAcs.EntryParameter = ep;

                oUserRptAcs.ReportGroup = oRptGrp;
                oUserRptAcess.Add(oUserRptAcs);
            }
            rdr.Close();
            return oUserRptAcess;
        }
    }
}
