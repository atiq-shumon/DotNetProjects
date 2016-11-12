using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;

namespace AH.ACMS.DAL
{
    public class SecurityQuestionDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region Save
        public SecurityQuestion SaveSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_Sec_Question";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_q_id",OracleDbType.Varchar2,30, oSecurityQuestionBO.QID,ParameterDirection.Input),
             new OracleParameter ("p_q_title",OracleDbType.Varchar2,300,oSecurityQuestionBO.QTitle,ParameterDirection.Input),
             new OracleParameter ("p_q_title_bang",OracleDbType.Varchar2,300, oSecurityQuestionBO.QTitleBangla,ParameterDirection.Input),
             new OracleParameter ("p_remarks",OracleDbType.Varchar2,300,oSecurityQuestionBO.Remarks,ParameterDirection.Input),
             new OracleParameter ("p_active",OracleDbType.Varchar2,10,oSecurityQuestionBO.EntryParameter.Active,ParameterDirection.Input),
             new OracleParameter ("p_entryby",OracleDbType.Varchar2,30,oSecurityQuestionBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_entrydate",OracleDbType.Varchar2,30,oSecurityQuestionBO.EntryParameter.EntryDate,ParameterDirection.Input),
             new OracleParameter ("p_updateby",OracleDbType.Varchar2,30,oSecurityQuestionBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_updatedate",OracleDbType.Varchar2,30,oSecurityQuestionBO.EntryParameter.EntryDate,ParameterDirection.Input),
             new OracleParameter ("p_version",OracleDbType.Varchar2,30, oSecurityQuestionBO.EntryParameter.Version,ParameterDirection.Input),
             new OracleParameter ("p_dt",OracleDbType.Varchar2,30, oSecurityQuestionBO.Date,ParameterDirection.Input),
             new OracleParameter ("p_comp_id",OracleDbType.Varchar2,20,oSecurityQuestionBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("p_loc_id",OracleDbType.Varchar2,20,oSecurityQuestionBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("p_mac_id",OracleDbType.Varchar2,20,oSecurityQuestionBO.EntryParameter.MachineID,ParameterDirection.Input)
            };

            return SecurityQuestionDetails(packageName, parameterList);
        }
        public SecurityQuestion SecurityQuestionDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            SecurityQuestion oSecurityQuestionBO = new SecurityQuestion();
            EntryParameter oEntryParameter = new EntryParameter();
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                
                oEntryParameter.ErrorMessage = "";
                oSecurityQuestionBO.EntryParameter = oEntryParameter;

                if (reader.Read())
                {
                    oSecurityQuestionBO = CreateObject(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oSecurityQuestionBO.EntryParameter = oEntryParameter;
            }
            return oSecurityQuestionBO;
        }
        #endregion
        #region Edit
        public SecurityQuestion EditSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.EDIT_Sec_Question";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_q_id",OracleDbType.Varchar2,30, oSecurityQuestionBO.QID,ParameterDirection.Input),
             new OracleParameter ("p_q_title",OracleDbType.Varchar2,300,oSecurityQuestionBO.QTitle,ParameterDirection.Input),
             new OracleParameter ("p_q_title_bang",OracleDbType.Varchar2,300, oSecurityQuestionBO.QTitleBangla,ParameterDirection.Input),
             new OracleParameter ("p_remarks",OracleDbType.Varchar2,300,oSecurityQuestionBO.Remarks,ParameterDirection.Input)
            };

            return SecurityQuestionDetails(packageName, parameterList);
        }
        #endregion
        #region Delete
        public SecurityQuestion DeleteSecQuest(string questid)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Delete_Sec_Question";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_q_id",OracleDbType.Varchar2,30, questid,ParameterDirection.Input)
            };

            return SecurityQuestionDetails(packageName, parameterList);
        }
        #endregion
        #region GetsforGrid
        public List<SecurityQuestion> GetsSecurityQuestionsGrid()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Security_Question";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "GRID",ParameterDirection.Input),
            };
            return GetsSecurityQuestionDetailsGrid(packageName, parameterList);
        }
        private List<SecurityQuestion> GetsSecurityQuestionDetailsGrid(string packageName, OracleParameter[] parameterList)
        {
            List<SecurityQuestion> rDRSs = new List<SecurityQuestion>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        #region DataReaderMappingwithNUllGrid
        private SecurityQuestion MapObject(NullHandler oReader)
        {
            SecurityQuestion oDRS = new SecurityQuestion();
            EntryParameter oEntryParameter = new EntryParameter();
            oDRS.QID = oReader.GetString("Q_ID");
            oDRS.QTitle = oReader.GetString("Q_TITLE");
            oDRS.QTitleBangla = oReader.GetString("Q_TITLE_BENG");
            oDRS.Remarks = oReader.GetString("REMARKS");
            oEntryParameter.Active = oReader.GetString("ACTIVE");
            oEntryParameter.Version = oReader.GetString("VERSION");
            oDRS.Date = oReader.GetDateTime("DT").ToString("dd MMM yyyy");
            oDRS.EntryParameter = oEntryParameter;
            return oDRS;
        }
        private SecurityQuestion CreateObject(NullHandler oReader)
        {
            SecurityQuestion oDRS = new SecurityQuestion();
            oDRS = MapObject(oReader);
            return oDRS;
        }
        private List<SecurityQuestion> CreateObjects(IDataReader oReader)
        {
            List<SecurityQuestion> rDRSs = new List<SecurityQuestion>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                SecurityQuestion oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion
        #region GetsforCombo
        public List<SecurityQuestion> GetsSecurityQuestionCbo()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Security_Question";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "COMBO",ParameterDirection.Input),
            };
            return GetsSecurityQuestionDetailsCombo(packageName, parameterList);
        }
        private List<SecurityQuestion> GetsSecurityQuestionDetailsCombo(string packageName, OracleParameter[] parameterList)
        {
            List<SecurityQuestion> rDRSs = new List<SecurityQuestion>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsCbo(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }

        #region DataReaderMappingwithNUllCombo
        private SecurityQuestion MapObjectCbo(NullHandler oReader)
        {
            SecurityQuestion oDRS = new SecurityQuestion();
            oDRS.QID = oReader.GetString("Q_ID");
            oDRS.QTitle = oReader.GetString("Q_TITLE");
            return oDRS;
        }
        private SecurityQuestion CreateObjectCbo(NullHandler oReader)
        {
            SecurityQuestion oDRS = new SecurityQuestion();
            oDRS = MapObjectCbo(oReader);
            return oDRS;
        }
        private List<SecurityQuestion> CreateObjectsCbo(IDataReader oReader)
        {
            List<SecurityQuestion> rDRSs = new List<SecurityQuestion>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                SecurityQuestion oItem = CreateObjectCbo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion

    }
}
