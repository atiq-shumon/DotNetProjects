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
    public class PayrollSetupDAL
    {
        public string connstring = Utility.GetConnectionString(Utility.Module.HRMMIS);
        string packagename = string.Empty;

      #region SaveSalaryHeadGroup
        public short SaveSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            packagename = "PKG_PAYROLL_SETUP .INSERT_SALARY_HEAD_GROUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,1,oSalGrp.HeadType ,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_id",OracleDbType.Varchar2,3,oSalGrp.HeadGroupID,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_title",OracleDbType.Varchar2,300,oSalGrp.HeadGroupTitle,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_title_beng",OracleDbType.Varchar2,300,oSalGrp.HeadGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalGrp.SerialNumber,ParameterDirection.Input),               
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,oSalGrp.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalGrp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalGrp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
    #endregion

    #region GetSalaryHeadGroup
        public List<SalaryHeadGroup> GetSalHeadGroup()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SALARY_HEAD_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetSalaryHeadGroup(packageName, parameterList);
        }

        public List<SalaryHeadGroup> GetSalHeadGroupSetup(string oSalHdGrp)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SALARY_HEAD_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,3,oSalHdGrp,ParameterDirection.Input)
           };

            return GetSalaryHeadGroup(packageName, parameterList);
        }
        private List<SalaryHeadGroup> GetSalaryHeadGroup(string packageName, OracleParameter[] parameterList)
        {
            List<SalaryHeadGroup> oSalHdGrps = new List<SalaryHeadGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                SalaryHeadGroup oSalHdGrp = new SalaryHeadGroup();
                oSalHdGrp.HeadType = (String)rdr["HD_TYPE"].ToString();
                oSalHdGrp.HeadGroupID = (String)rdr["HD_GRP_ID"].ToString();
                oSalHdGrp.HeadGroupTitle = (string)rdr["HD_GRP_TITLE"].ToString();
                oSalHdGrp.HeadGroupTitleBeng = (string)rdr["HD_GRP_TITLE_BENG"].ToString();
                oSalHdGrp.SerialNumber = rdr["SRL"].ToString();
                oSalHdGrp.Remarks =(String)rdr["REMARKS"].ToString();
                oSalHdGrps.Add(oSalHdGrp);
            }
            rdr.Close();
            return oSalHdGrps;
        }
#endregion

    #region UpdateSalaryHeadGroup

        public short UpdateSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_SALARY_HEAD_GROUP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,1,oSalGrp.HeadType ,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_id",OracleDbType.Varchar2,3,oSalGrp.HeadGroupID,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_title",OracleDbType.Varchar2,300,oSalGrp.HeadGroupTitle,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_title_beng",OracleDbType.Varchar2,300,oSalGrp.HeadGroupTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalGrp.SerialNumber,ParameterDirection.Input),               
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,oSalGrp.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalGrp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalGrp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalGrp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

 #endregion

    #region GetSalaryHead
        public List<SalaryHead> GetSalaryHead()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SALARY_HEAD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSalHead(packageName, parameterList);

        }
        public List<SalaryHead> GetSalaryHeadsetup(string oSalHdG,string oSalHdH)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SALARY_HEAD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,3,oSalHdG,ParameterDirection.Input),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,3,oSalHdH,ParameterDirection.Input)
            };
            return GetSalHead(packageName, parameterList);

        }
        private List<SalaryHead> GetSalHead(string packageName, OracleParameter[] parameterList)
        {
            List<SalaryHead> oSalHds = new List<SalaryHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                SalaryHead oSalHd = new SalaryHead();


                SalaryHeadGroup oSalHdGrp = new SalaryHeadGroup();

                oSalHdGrp.HeadType = !rdr.IsDBNull(0) ? (string)rdr["HD_TYPE"].ToString() : "";
                oSalHd.SalaryHeadGroup = oSalHdGrp;

                oSalHdGrp.HeadGroupID = !rdr.IsDBNull(1) ? (string)rdr["HD_GRP_ID"].ToString() : "";
                oSalHd.SalaryHeadGroup = oSalHdGrp; 
          
                oSalHd.HeadID = (string)rdr["HD_ID"].ToString();
                oSalHd.HeadTitle = (string)rdr["HD_TITLE"].ToString();
                oSalHd.HeadTitleBeng = (string)rdr["HD_TITLE_BENG"].ToString();
                oSalHd.Srl = !rdr.IsDBNull(5) ?(string)rdr["SRL"].ToString() : "";
                oSalHd.Remarks = !rdr.IsDBNull(6) ? (string)rdr["REMARKS"].ToString() : "";


                
                
                oSalHds.Add(oSalHd);

            }
            rdr.Close();
            return oSalHds;

        }
        #endregion

    #region SaveSalaryHead

        public short SaveSalaryHead(SalaryHead oSalHead)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_SALARY_HEAD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,1,oSalHead.SalaryHeadGroup.HeadType ,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_id",OracleDbType.Varchar2,3,oSalHead.SalaryHeadGroup.HeadGroupID,ParameterDirection.Input),
                new OracleParameter("p_hd_id",OracleDbType.Varchar2,3,oSalHead.HeadID,ParameterDirection.Input),
                new OracleParameter("p_hd_title",OracleDbType.Varchar2,300,oSalHead.HeadTitle,ParameterDirection.Input),
                new OracleParameter("p_hd_title_beng",OracleDbType.Varchar2,300,oSalHead.HeadTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalHead.Srl,ParameterDirection.Input),               
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,oSalHead.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalHead.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalHead.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalHead.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalHead.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalHead.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

    #region UpdateSalaryHead

        public short UpdateSalaryHead(SalaryHead oSalHead)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_SALARY_HEAD_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_hd_type",OracleDbType.Varchar2,1,oSalHead.SalaryHeadGroup.HeadType ,ParameterDirection.Input),
                new OracleParameter("p_hd_grp_id",OracleDbType.Varchar2,3,oSalHead.SalaryHeadGroup.HeadGroupID,ParameterDirection.Input),
                new OracleParameter("p_hd_id",OracleDbType.Varchar2,3,oSalHead.HeadID,ParameterDirection.Input),
                new OracleParameter("p_hd_title",OracleDbType.Varchar2,300,oSalHead.HeadTitle,ParameterDirection.Input),
                new OracleParameter("p_hd_title_beng",OracleDbType.Varchar2,300,oSalHead.HeadTitleBeng,ParameterDirection.Input),
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalHead.Srl,ParameterDirection.Input),               
                new OracleParameter("p_remarks ",OracleDbType.Varchar2,300,oSalHead.Remarks,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalHead.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalHead.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalHead.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalHead.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalHead.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

    #region GetGradeSetup
        public List<SalaryGradeSetup> GetSalGradeSetup()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_GRADE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetSalaryGradeSetup(packageName, parameterList);
        }
        public List<SalaryGradeSetup> GetGradeSetup(string level)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_GRADE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_level_id",OracleDbType.Varchar2,30,level,ParameterDirection.Input)
           };

            return GetSalaryGradeSetup(packageName, parameterList);
        }

        private List<SalaryGradeSetup> GetSalaryGradeSetup(string packageName, OracleParameter[] parameterList)
        {
            List<SalaryGradeSetup> oSalGrades = new List<SalaryGradeSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                SalaryGradeSetup oSalGrade = new SalaryGradeSetup();
                oSalGrade.Level = (String)rdr["level_id"].ToString();
                oSalGrade.GradeID = (String)rdr["GRADE_ID"].ToString();
                oSalGrade.GradeTitle = (string)rdr["GRADE_TITLE"].ToString();
                oSalGrade.GradeTitleBeng = (string)rdr["GRADE_TITLE_BENG"].ToString();
                oSalGrade.Srl = rdr["SRL"].ToString();
                oSalGrades.Add(oSalGrade);
            }
            rdr.Close();
            return oSalGrades;
        }

#endregion

    #region SaveGradeSetup

        public short SaveSalaryGrade(SalaryGradeSetup oSalGrade)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_GRADE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_level_id",OracleDbType.Varchar2,5,oSalGrade.Level ,ParameterDirection.Input),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSalGrade.GradeID ,ParameterDirection.Input),
                new OracleParameter("p_grade_title",OracleDbType.Varchar2,300,oSalGrade.GradeTitle,ParameterDirection.Input),
                new OracleParameter("p_grade_title_beng",OracleDbType.Varchar2,300,oSalGrade.GradeTitleBeng,ParameterDirection.Input),               
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalGrade.Srl,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalGrade.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalGrade.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
 #endregion

 #region UpdateGradeSetup

        public short UpdateGradeSetup(SalaryGradeSetup oSalGrade)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_GRADE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_level_id",OracleDbType.Varchar2,5,oSalGrade.Level ,ParameterDirection.Input),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSalGrade.GradeID ,ParameterDirection.Input),
                new OracleParameter("p_grade_title",OracleDbType.Varchar2,300,oSalGrade.GradeTitle,ParameterDirection.Input),
                new OracleParameter("p_grade_title_beng",OracleDbType.Varchar2,300,oSalGrade.GradeTitleBeng,ParameterDirection.Input),               
                new OracleParameter("p_srl",OracleDbType.Varchar2,300,oSalGrade.Srl,ParameterDirection.Input),               
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalGrade.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalGrade.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalGrade.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

#endregion

    #region VerifyScale
        public int VerifyScaleSetup(string vscl)
        {
            packagename = "PKG_PAYROLL_SETUP.VERIFY_SCALE_M_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,4,vscl,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion

    #region GetScaleMSetup
        public List<ScaleMSetup> GetScaleMSet()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SCALE_M_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };
            return GetScaleMSet(packageName, parameterList);
        }
        public List<ScaleMSetup> GetScaleMSetup(string oSclMSetup)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SCALE_M_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSclMSetup,ParameterDirection.Input)
           };

            return GetScaleMSet(packageName, parameterList);
        }
        private List<ScaleMSetup> GetScaleMSet(string packageName, OracleParameter[] parameterList)
        {
            List<ScaleMSetup> oSclMSets = new List<ScaleMSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ScaleMSetup oSclMSet = new ScaleMSetup();

                SalaryGradeSetup oSalGrd=new SalaryGradeSetup();
                oSalGrd.Level=(string)rdr["LEVEL_ID"].ToString();
                oSalGrd.GradeID = !rdr.IsDBNull(1) ? (string)rdr["GRADE_ID"].ToString() : "";
                oSclMSet.SalaryGradeSetup = oSalGrd;

                oSclMSet.ScaleMID = (string)rdr["SCALE_M_ID"].ToString();
                oSclMSet.ScaleTitle = (string)rdr["SCALE_TITLE"].ToString();
                oSclMSet.ScaleTitleBeng = (string)rdr["SCALE_TITLE_BENG"].ToString();               
                oSclMSet.Srl = rdr["SRL"].ToString();

                oSclMSets.Add(oSclMSet);
            }
            rdr.Close();
            return oSclMSets;
        }
        #endregion

    #region SaveScaleMSetup

        public short SaveScaleMSetup(ScaleMSetup oSclMSet)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_SCALE_M_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_level_id",OracleDbType.Varchar2,oSclMSet.SalaryGradeSetup.Level ,ParameterDirection.Input),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSclMSet.SalaryGradeSetup.GradeID,ParameterDirection.Input),
                new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,5,oSclMSet.ScaleMID,ParameterDirection.Input),
                new OracleParameter("p_scale_title",OracleDbType.Varchar2,300,oSclMSet.ScaleTitle,ParameterDirection.Input),
                new OracleParameter("p_scale_title_beng",OracleDbType.Varchar2,300,oSclMSet.ScaleTitleBeng,ParameterDirection.Input),                                       
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSclMSet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSclMSet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
 #endregion

    #region UpdateScaleMSetup

        public short UpdateScaleMSetup(ScaleMSetup oSclMSet)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_SCALE_M_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_level_id",OracleDbType.Varchar2,oSclMSet.SalaryGradeSetup.Level ,ParameterDirection.Input),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSclMSet.SalaryGradeSetup.GradeID,ParameterDirection.Input),
                new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,5,oSclMSet.ScaleMID,ParameterDirection.Input),
                new OracleParameter("p_scale_title",OracleDbType.Varchar2,300,oSclMSet.ScaleTitle,ParameterDirection.Input),
                new OracleParameter("p_scale_title_beng",OracleDbType.Varchar2,300,oSclMSet.ScaleTitleBeng,ParameterDirection.Input),                                     
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSclMSet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSclMSet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSclMSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

    #region GetScaleUnderGrade

        public List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SCALE_UNDER_GRADE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,30,oSalHdG,ParameterDirection.Input),              
           };

            return GetScaleUnderGrd(packageName, parameterList);
        }
        private List<ScaleMSetup> GetScaleUnderGrd(string packageName, OracleParameter[] parameterList)
        {
            List<ScaleMSetup> oSclDSets = new List<ScaleMSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            try
            {
                while (rdr.Read())
                {
                    ScaleMSetup oScaleMSetup = new ScaleMSetup();
                    oScaleMSetup.ScaleTitle = !rdr.IsDBNull(0) ? (string)rdr["SCALE_TITLE"].ToString() : "";
                    oScaleMSetup.ScaleMID = !rdr.IsDBNull(0) ? (string)rdr["SCALE_M_ID"].ToString() : "";

                    oSclDSets.Add(oScaleMSetup);

                }
                rdr.Close();
                return oSclDSets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

    #region GetScaleDetailsSetup

        public List<ScaleDSetup> GetScaleDSetup(string oSalHdG, string oSalM)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SCALE_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,30,oSalHdG,ParameterDirection.Input),
                new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,30,oSalM,ParameterDirection.Input)
           };

            return GetScaleDSet(packageName, parameterList);
        }
        private List<ScaleDSetup> GetScaleDSet(string packageName, OracleParameter[] parameterList)
        {
            List<ScaleDSetup> oSclDSets = new List<ScaleDSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                ScaleDSetup oSclDSet = new ScaleDSetup();

                SalaryGradeSetup oSalGrd = new SalaryGradeSetup();
                oSalGrd.GradeID = (string)rdr["GRADE_ID"].ToString();
                oSalGrd.GradeTitle =(string)rdr["GRADE_TITLE"].ToString();
                oSclDSet.SalaryGradeSetup = oSalGrd;

                ScaleMSetup osclM = new ScaleMSetup();
                osclM.ScaleMID =(string)rdr["SCALE_M_ID"].ToString();
                osclM.ScaleTitle = (string)rdr["SCALE_TITLE"].ToString();
                oSclDSet.ScaleMSetup = osclM;

                SalaryHead osalhd = new SalaryHead();
                osalhd.HeadID = (string)rdr["HD_ID"].ToString();
                osalhd.HeadTitle= (string)rdr["HD_TITLE"].ToString();
                oSclDSet.SalaryHead = osalhd;

                oSclDSet.amount = rdr["AMOUNT"].ToString();

                oSclDSets.Add(oSclDSet);
            }
            rdr.Close();
            return oSclDSets;
        }
        #endregion

    #region SaveScaleDSetup

        public short SaveScaleDSetup(ScaleDSetup oSclDSet)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_SCALE_D_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSclDSet.SalaryGradeSetup.GradeID,ParameterDirection.Input),
               new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,5,oSclDSet.ScaleMSetup.ScaleMID,ParameterDirection.Input),
               new OracleParameter("p_salary_head_id",OracleDbType.Varchar2,3,oSclDSet.SalaryHead.HeadID,ParameterDirection.Input),  
               new OracleParameter("p_amount",OracleDbType.Varchar2,300,oSclDSet.amount,ParameterDirection.Input),               
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.UpdateBy ,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSclDSet.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSclDSet.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

     #region UpdateScaleDSetup

        public short UpdateScaleDSetup(ScaleDSetup oSclDSet)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_SCALE_D_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oSclDSet.SalaryGradeSetup.GradeID,ParameterDirection.Input),
                new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,5,oSclDSet.ScaleMSetup.ScaleMID,ParameterDirection.Input),
                new OracleParameter("p_salary_head_id",OracleDbType.Varchar2,5,oSclDSet.SalaryHead.HeadID,ParameterDirection.Input),                          
                new OracleParameter("p_amount",OracleDbType.Varchar2,300,oSclDSet.amount,ParameterDirection.Input),                            
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSclDSet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSclDSet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSclDSet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion

     #region SaveStepDetailsSetup
        public short SaveStepDetailsSetup(ScaleDSetup oStepDetails)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_STEP_DETAILS_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_grade_id",OracleDbType.Varchar2,5,oStepDetails.SalaryGradeSetup.GradeID,ParameterDirection.Input),
               new OracleParameter("p_scale_m_id",OracleDbType.Varchar2,5,oStepDetails.ScaleMSetup.ScaleMID,ParameterDirection.Input),
               new OracleParameter("p_salary_head_string",OracleDbType.Varchar2,10000,oStepDetails.SalaryHeadString,ParameterDirection.Input),             
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oStepDetails.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oStepDetails.EntryParameter.UpdateBy ,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oStepDetails.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oStepDetails.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oStepDetails.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

      #region SaveSalaryCycle
        public short SaveSalaryCycle(SalaryCycle oSalCycle)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_SALARY_CYCLE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_yr",OracleDbType.Varchar2,4,oSalCycle.Year,ParameterDirection.Input),
               new OracleParameter("p_month_number",OracleDbType.Varchar2,2,oSalCycle.MonthNumber,ParameterDirection.Input),  
               new OracleParameter("p_from_date",OracleDbType.Date,oSalCycle.FromDate,ParameterDirection.Input),   
               new OracleParameter("p_to_date",OracleDbType.Date,oSalCycle.ToDate,ParameterDirection.Input),  
               new OracleParameter("p_total_no_days",OracleDbType.Varchar2,3,oSalCycle.TotalNoOfDays,ParameterDirection.Input), 
               new OracleParameter("p_total_friday",OracleDbType.Varchar2,3,oSalCycle.TotalFridays,ParameterDirection.Input), 
               new OracleParameter("p_total_holiday",OracleDbType.Varchar2,3,oSalCycle.TotalHolidays,ParameterDirection.Input), 
               new OracleParameter("p_total_works_days",OracleDbType.Varchar2,3,oSalCycle.TotalWorkDays,ParameterDirection.Input),               
               new OracleParameter("p_month_status",OracleDbType.Varchar2,1,oSalCycle.MonthStatus,ParameterDirection.Input), 
               new OracleParameter("p_month_type",OracleDbType.Varchar2,1,oSalCycle.MonthType,ParameterDirection.Input), 
               new OracleParameter("p_eid_flag",OracleDbType.Varchar2,1,oSalCycle.EidFlag,ParameterDirection.Input),
               new OracleParameter("p_month_end_flag",OracleDbType.Varchar2,1,oSalCycle.MonthEndFlag,ParameterDirection.Input), 
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.UpdateBy ,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalCycle.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalCycle.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

    #region UpdateSalaryCycle

        public short UpdateSalaryCycle(SalaryCycle oSalCycle)
        {
            packagename = "PKG_PAYROLL_SETUP.UPDATE_SALARY_CYCLE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_month_id",OracleDbType.Varchar2,8,oSalCycle.Month,ParameterDirection.Input),
               new OracleParameter("p_yr",OracleDbType.Varchar2,4,oSalCycle.Year,ParameterDirection.Input),
               new OracleParameter("p_month_number",OracleDbType.Varchar2,2,oSalCycle.MonthNumber,ParameterDirection.Input),  
               new OracleParameter("p_from_date",OracleDbType.Date,oSalCycle.FromDate,ParameterDirection.Input),   
               new OracleParameter("p_to_date",OracleDbType.Date,oSalCycle.ToDate,ParameterDirection.Input),  
               new OracleParameter("p_total_no_days",OracleDbType.Varchar2,3,oSalCycle.TotalNoOfDays,ParameterDirection.Input), 
               new OracleParameter("p_total_friday",OracleDbType.Varchar2,3,oSalCycle.TotalFridays,ParameterDirection.Input), 
               new OracleParameter("p_total_holiday",OracleDbType.Varchar2,3,oSalCycle.TotalHolidays,ParameterDirection.Input), 
               new OracleParameter("p_total_works_days",OracleDbType.Varchar2,3,oSalCycle.TotalWorkDays,ParameterDirection.Input),               
               new OracleParameter("p_month_status",OracleDbType.Varchar2,1,oSalCycle.MonthStatus,ParameterDirection.Input), 
               new OracleParameter("p_month_type",OracleDbType.Varchar2,1,oSalCycle.MonthType,ParameterDirection.Input), 
               new OracleParameter("p_eid_flag",OracleDbType.Varchar2,1,oSalCycle.EidFlag,ParameterDirection.Input),
               new OracleParameter("p_month_end_flag",OracleDbType.Varchar2,1,oSalCycle.MonthEndFlag,ParameterDirection.Input), 
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.UpdateBy ,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oSalCycle.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oSalCycle.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oSalCycle.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

    #region GetSalaryCycle

        public List<SalaryCycle> GetSalaryCycle(string Year)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_SALARY_CYCLE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)  ,
                new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input)
           };

            return GetSalCycle(packageName, parameterList);
        }
        private List<SalaryCycle> GetSalCycle(string packageName, OracleParameter[] parameterList)
        {
            List<SalaryCycle> oSalCycles = new List<SalaryCycle>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                SalaryCycle oSalCycle = new SalaryCycle();

                oSalCycle.Month = rdr["MONTH_ID"].ToString();
                oSalCycle.Year = rdr["YR"].ToString();
                oSalCycle.MonthNumber = rdr["MONTH_NUMBER"].ToString();
                oSalCycle.FromDate = Convert.ToDateTime((DateTime)rdr["FROM_DATE"]);
                oSalCycle.ToDate = Convert.ToDateTime((DateTime)rdr["TO_DATE"]);
                oSalCycle.TotalNoOfDays = rdr["TOTAL_NO_DAYS"].ToString();
                oSalCycle.TotalFridays = rdr["TOTAL_FRIDAY"].ToString();
                oSalCycle.TotalHolidays = rdr["TOTAL_HOLIDAY"].ToString();
                oSalCycle.TotalWorkDays = rdr["TOTAL_WORK_DAYS"].ToString();
                oSalCycle.PaymentDate = Convert.ToDateTime((DateTime)rdr["PAYMENT_DATE"]);
                oSalCycle.ConfigDate = Convert.ToDateTime((DateTime)rdr["CONFIG_DATE"]);
                oSalCycle.CalculateDate = Convert.ToDateTime((DateTime)rdr["CALCULATE_DATE"]);
                oSalCycle.MonthStatus = rdr["MONTH_STATUS"].ToString();
                oSalCycle.MonthType = rdr["MONTH_TYPE"].ToString();
                oSalCycle.EidFlag = rdr["EID_FLAG"].ToString();
                oSalCycle.MonthEndFlag = rdr["MONTH_END_FLAG"].ToString();

                oSalCycles.Add(oSalCycle);
            }
            rdr.Close();
            return oSalCycles;
        }
        #endregion

    #region GetMonthID
        public List<SalaryCycle> GetMonthID()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_MONTH_ID";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)                
           };

            return GetSalarycycle(packageName, parameterList);
        }
        public List<SalaryCycle> GetMonthByYear(string year)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_MONTH_BY_YEAR";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_yr",OracleDbType.Varchar2,4,year,ParameterDirection.Input)
           };

            return GetSalarycycle(packageName, parameterList);
        }

        private List<SalaryCycle> GetSalarycycle(string packageName, OracleParameter[] parameterList)
        {
            List<SalaryCycle> oSals = new List<SalaryCycle>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                SalaryCycle oSal = new SalaryCycle();
                
                oSal.Month = (String)rdr["MONTH_ID"].ToString();
                oSals.Add(oSal);
            }
            rdr.Close();
            return oSals;
        }
        #endregion

    #region savePayroll
        public string SavePayroll(Payroll oPay)
        {
            packagename = "PKG_PAYROLL_SETUP.SAVE_PAYROLL";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("p_e_rows",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
             new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
             new OracleParameter("p_sal_cycle_id",OracleDbType.Varchar2,30, oPay.month,ParameterDirection.Input),
             new OracleParameter("p_year",OracleDbType.Varchar2,30, oPay.year,ParameterDirection.Input),
             new OracleParameter("p_entry_by",OracleDbType.Varchar2,20, oPay.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("p_update_by",OracleDbType.Varchar2,20, oPay.EntryParameter.UpdateBy ,ParameterDirection.Input),
             new OracleParameter("p_comp_id",OracleDbType.Varchar2,2, oPay.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("p_loc_id",OracleDbType.Varchar2,2, oPay.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("p_mac_id",OracleDbType.Varchar2,20, oPay.EntryParameter.MachineID,ParameterDirection.Input)
          };

            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
#endregion

    #region CkeckMonth
        public List<Payroll> CheckMonth(string ID)
        {
            string packageName = "PKG_PAYROLL_SETUP.CHECK_MONTH";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("p_id",OracleDbType.Varchar2,30,ID,ParameterDirection.Input)
           };

            return GetMonthInfo(packageName, parameterList);
        }

        private List<Payroll> GetMonthInfo(string packageName, OracleParameter[] parameterList)
        {
            List<Payroll> oSals = new List<Payroll>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Payroll oSal = new Payroll();
                oSal.month= (String)rdr["MONTH_ID"].ToString();
                oSals.Add(oSal);
            }
            rdr.Close();
            return oSals;
        }
        #endregion

    #region GetEMP
        public List<EmployeeMaster> GetEmp()
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_EMP";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
           };

            return GetEmpInfo(packageName, parameterList);
        }

        private List<EmployeeMaster> GetEmpInfo(string packageName, OracleParameter[] parameterList)
        {
            List<EmployeeMaster> oSals = new List<EmployeeMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                EmployeeMaster oSal = new EmployeeMaster();
                oSal.EmpId = (String)rdr["EMP_ID"].ToString();
                oSal.EmpNameBeng= (String)rdr["NAME"].ToString();
                oSals.Add(oSal);
            }
            rdr.Close();
            return oSals;
        }
        #endregion

    #region GetPayrollForUpdate

            public List<PayrollRO> GetPayrollForUpdate(string Emp,string DeptGrp, string Dept,string Unit,string Month,string Year)
            {
                string packageName = "PKG_PAYROLL_SETUP.GET_PAYROLL_FOR_UPDATE";
                OracleParameter[] parameterList = new OracleParameter[] { 
                    new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,Emp,ParameterDirection.Input),
                    new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input),
                    new OracleParameter("p_dept",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input),
                    new OracleParameter("p_unit",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input),
                    new OracleParameter("p_month_id",OracleDbType.Varchar2,30,Month,ParameterDirection.Input),
                    new OracleParameter("p_year",OracleDbType.Varchar2,30,Year,ParameterDirection.Input)  
               };

                return GetPayrollEmp(packageName, parameterList);
            }

            private List<PayrollRO> GetPayrollEmp(string packageName, OracleParameter[] parameterList)
            {
                List<PayrollRO> oPays = new List<PayrollRO>();
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                while (rdr.Read())
                {
                    PayrollRO oPay = new PayrollRO();
                    oPay.EmpId = (String)rdr["EMP_ID"].ToString();
                    oPay.EmpName = (String)rdr["NAME"].ToString();
                    oPay.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                    oPay.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                    oPay.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                    oPay.SalCycleId = (string)rdr["SAL_CYCLE_ID"].ToString();
                    oPay.HeadTitle = (string)rdr["HeadTitle"].ToString();
                    oPay.SalHeadId = (string)rdr["SALARY_HEAD_ID"].ToString();
                    oPay.HeadType = (string)rdr["HeadType"].ToString();
                    oPay.Amount = Convert.ToDouble(rdr["AMOUNT"].ToString());
                    oPay.GrossPay = Convert.ToDouble(rdr["GROSS_PAY"].ToString());
                    oPay.GradeCOnsFlag = rdr["CONSOLIDATE_SCAL_FLAG"].ToString();
                    oPays.Add(oPay);
                }
                rdr.Close();
                return oPays;
            }
     #endregion

    #region SaveUpdatedPayroll

        public string SaveUpdatedPayroll(PayrollRO oPayUp)
        {
            packagename = "PKG_PAYROLL_SETUP.SAVE_PAYROLL_FOR_UPDATE";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
               new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oPayUp.EmpId,ParameterDirection.Input),
                new OracleParameter("p_month_id",OracleDbType.Varchar2,10,oPayUp.Month,ParameterDirection.Input),
                new OracleParameter("p_head_id",OracleDbType.Varchar2,10,oPayUp.SalHeadId,ParameterDirection.Input),              
                new OracleParameter("p_amount",OracleDbType.Varchar2,300,oPayUp.Amount,ParameterDirection.Input),  
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPayUp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPayUp.EntryParameter.UpdateBy ,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPayUp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPayUp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPayUp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
#endregion

    #region GetDepartmentWisePayroll

        public List<PayrollRO> ShowPayrollDetails(string Mode,string DeptGrp, string Dept, string Unit, string Month)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_DEPARTMENT_PAYROLL";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_mode",OracleDbType.Varchar2,30,Mode,ParameterDirection.Input), 
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,30,DeptGrp,ParameterDirection.Input), 
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,30,Dept,ParameterDirection.Input), 
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,30,Unit,ParameterDirection.Input), 
                new OracleParameter("p_sal_cycle",OracleDbType.Varchar2,30,Month,ParameterDirection.Input), 
           };

            return GetPayrollD(packageName, parameterList);
        }

        private List<PayrollRO> GetPayrollD(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollRO> oPays = new List<PayrollRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollRO oPay = new PayrollRO();
                oPay.EmpId = (String)rdr["EMP_ID"].ToString();
                oPay.EmpName = (String)rdr["NAME"].ToString();
                oPay.DeptType = (String)rdr["DEPT_TYPE"].ToString();
                oPay.DeptGrp = (String)rdr["DEPT_GRP"].ToString();
                oPay.DeptId = (String)rdr["DEPT_TITLE"].ToString();
                oPay.FormatDept = (String)rdr["FormatDept"].ToString();
                oPay.DesigId = (String)rdr["DSIG_TITLE"].ToString();
                oPay.UnitId = (String)rdr["UNIT_TITLE"].ToString();
                oPay.ScaleId = (String)rdr["scale_title"].ToString();
                oPay.GradeId = (String)rdr["grade_title"].ToString();
                oPay.ProcessDate = Convert.ToDateTime((DateTime)rdr["PROCESS_DATE"]);
                oPay.SalCycleId = (string)rdr["SAL_CYCLE_ID"].ToString();
                oPay.SalTypeId = (string)rdr["SAL_TYPE_ID"].ToString();
                oPay.GradeCOnsFlag = (string)rdr["GRADE_CONS_FLAG"].ToString();
                oPay.BankAcc = (string)rdr["BANK_ACCOUNT"].ToString();
                oPay.LockFlag = (string)rdr["LOCK_FLAG"].ToString();
                oPay.Basic = double.Parse(rdr["BASIC"].ToString());
                oPay.HouseRent = double.Parse(rdr["HOUSE_RENT"].ToString());
                oPay.Transport = double.Parse(rdr["TRANSPORT"].ToString());
                oPay.MobileBill = double.Parse(rdr["MOBILE_BILL"].ToString());
                oPay.MedicalAllowance = double.Parse(rdr["MEDICAL_ALLOWANCE"].ToString());
                oPay.Consolated = double.Parse(rdr["Consolated"].ToString());
                oPay.Overtime = double.Parse(rdr["OVERTIME"].ToString());
                oPay.Arear = double.Parse(rdr["Arear"].ToString());
                oPay.Others = double.Parse(rdr["Others"].ToString());
                oPay.IncomeTax = double.Parse(rdr["Income_Tax"].ToString());
                oPay.MobileBillDeduce = double.Parse(rdr["Mobile_Deduce"].ToString());
                oPay.Lunch = double.Parse(rdr["Lunch"].ToString());
                oPay.ProvidentFund = double.Parse(rdr["Provident_Fund"].ToString());
                oPay.Advance = double.Parse(rdr["Advance"].ToString());
                oPay.Absent = double.Parse((rdr["Absent"]).ToString());
                oPay.LeaveWithoutPay = double.Parse((rdr["LEAVEWITHOUTPAY"]).ToString());
                oPay.Loan = double.Parse((rdr["Loan"]).ToString());
                oPay.OthersDed = double.Parse((rdr["OthersDed"]).ToString());
                oPay.Addition = double.Parse(rdr["addition"].ToString());
                oPay.Deduction = double.Parse(rdr["deduction"].ToString());
                oPay.GrossPay = double.Parse(rdr["gross_pay"].ToString());
                oPays.Add(oPay);
            }
            rdr.Close();
            return oPays;
        }
#endregion

    #region saveManualPayroll
        public string saveManualPayroll(Payroll oPay)
        {
            packagename = "PKG_PAYROLL_SETUP.SAVE_MANUAL_SALARY_PROCESS";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("p_e_rows",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
             new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
             new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oPay.EmpId,ParameterDirection.Input),
             new OracleParameter("p_year",OracleDbType.Varchar2,30, oPay.year,ParameterDirection.Input),
             new OracleParameter("p_sal_cycle_id",OracleDbType.Varchar2,30,oPay.month,ParameterDirection.Input),             
             new OracleParameter("p_entry_by",OracleDbType.Varchar2,20, oPay.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("p_update_by",OracleDbType.Varchar2,20, oPay.EntryParameter.UpdateBy ,ParameterDirection.Input),
             new OracleParameter("p_comp_id",OracleDbType.Varchar2,2, oPay.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("p_loc_id",OracleDbType.Varchar2,2, oPay.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("p_mac_id",OracleDbType.Varchar2,20, oPay.EntryParameter.MachineID,ParameterDirection.Input)
          };

            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
#endregion

    #region SalaryDisbursing
        public string SaveSalaryDisbursing(Payroll oPay)
        {
            packagename = "PKG_PAYROLL_SETUP.SALARY_DISBURSE";
            OracleParameter[] parameterList = new OracleParameter[]{
             new OracleParameter("p_e_rows",OracleDbType.Varchar2,100,null,ParameterDirection.Output),
             new OracleParameter("p_err_msg",OracleDbType.Varchar2,300,null,ParameterDirection.Output),
             new OracleParameter("p_sal_cycle_id",OracleDbType.Varchar2,30, oPay.month,ParameterDirection.Input),
             new OracleParameter("p_salary_lock",OracleDbType.Varchar2,30, oPay.SalaryLock,ParameterDirection.Input),
             new OracleParameter("p_entry_by",OracleDbType.Varchar2,20, oPay.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter("p_update_by",OracleDbType.Varchar2,20, oPay.EntryParameter.UpdateBy ,ParameterDirection.Input),
             new OracleParameter("p_comp_id",OracleDbType.Varchar2,2, oPay.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter("p_loc_id",OracleDbType.Varchar2,2, oPay.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter("p_mac_id",OracleDbType.Varchar2,20, oPay.EntryParameter.MachineID,ParameterDirection.Input)
          };

            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            OracleParameter errprm = parameterList[1];
            if ((OracleString)errprm.Value != "0")
                return errprm.Value.ToString();

            if ((OracleString)prm.Value.ToString() == "0")
                return prm.Value.ToString();

            else return "0";
        }
        #endregion

        #region SavePayrollBase
        public short SavePayrollBase(PayrollBase oPayrollBase)
        {
            packagename = "PKG_PAYROLL_SETUP.INSERT_PAYROLL_BASE_SETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,oPayrollBase.EmployeeMaster.EmpId,ParameterDirection.Input),
               new OracleParameter("p_salary_head_string",OracleDbType.Varchar2,10000,oPayrollBase.SalaryHeadString,ParameterDirection.Input),             
               new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oPayrollBase.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("p_update_by",OracleDbType.Varchar2,20,oPayrollBase.EntryParameter.UpdateBy ,ParameterDirection.Input),
               new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oPayrollBase.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oPayrollBase.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oPayrollBase.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packagename, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetPayrollBase
        public List<PayrollBase> GetPayrollBase(string EmpID)
        {
            string packageName = "PKG_PAYROLL_SETUP.GET_PAYROLL_BASE";
            OracleParameter[] parameterList = new OracleParameter[] { 
                new OracleParameter("p_test_cursor", OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_emp_id",OracleDbType.Varchar2,30,EmpID,ParameterDirection.Input)
           };

            return GetPayrollBaseDetails(packageName, parameterList);
        }

        private List<PayrollBase> GetPayrollBaseDetails(string packageName, OracleParameter[] parameterList)
        {
            List<PayrollBase> oPayrollBases = new List<PayrollBase>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PayrollBase oPayrollBase = new PayrollBase();
                EmployeeMaster oEmpMaster = new EmployeeMaster();
                oEmpMaster.EmpId = (String)rdr["EMP_ID"].ToString();
                oPayrollBase.EmployeeMaster = oEmpMaster;
                SalaryHead oSalHead = new SalaryHead();
                oSalHead.HeadID = (string)rdr["SALARY_HEAD_ID"].ToString();
                oSalHead.HeadTitle = (string)rdr["HD_TITLE"].ToString();
                oPayrollBase.SalaryHead = oSalHead;
                oPayrollBase.amount = Convert.ToDouble(rdr["AMOUNT"].ToString());
                oPayrollBase.HeadType = (string)rdr["HD_TYPE"].ToString();
                oPayrollBases.Add(oPayrollBase);
            }
            rdr.Close();
            return oPayrollBases;
        }
        #endregion

       
}
}
