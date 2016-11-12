 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACMS.MODEL;
using AH.DUtility;
using AH.Shared;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using AH.OracleManager;

namespace AH.ACMS.DAL
{
    public class AccessControlDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region Save
        public AccessControl SaveAccessControl(AccessControl oAccessControlBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_Access_Control";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oAccessControlBO.User.EmpID,ParameterDirection.Input),
             new OracleParameter ("P_Module_ID",OracleDbType.Varchar2,20,oAccessControlBO.Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("P_Grp_ID",OracleDbType.Varchar2,30, oAccessControlBO.UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("P_Obj_ID",OracleDbType.Varchar2,10,oAccessControlBO.ObjectSetup.ObjID,ParameterDirection.Input),
             new OracleParameter ("P_Auth_Lvl",OracleDbType.Varchar2,10,oAccessControlBO.AuthenticationLevel,ParameterDirection.Input),
              new OracleParameter ("P_Remarks",OracleDbType.Varchar2,300,oAccessControlBO.Remarks,ParameterDirection.Input),
             new OracleParameter ("P_ENTRY_BY",OracleDbType.Varchar2,30,oAccessControlBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.MachineID,ParameterDirection.Input)
            
            };

            return AccessControlDetails(packageName, parameterList);
        }
        public AccessControl AccessControlDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            AccessControl oAccessControlBO = new AccessControl();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oAccessControlBO.EntryParameter = oEntryParameter;

            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                if (reader.Read())
                {

                    oAccessControlBO = CreateObject(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oAccessControlBO.EntryParameter = oEntryParameter;
            }
            return oAccessControlBO;
        }
        #endregion
        #region Edit
        public AccessControl EditAccessControl(AccessControl oAccessControlBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Edit_Access_Control";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oAccessControlBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("P_Module_ID",OracleDbType.Varchar2,30,oAccessControlBO.Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("P_Grp_ID",OracleDbType.Varchar2,30, oAccessControlBO.UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("P_Obj_ID",OracleDbType.Varchar2,30,oAccessControlBO.ObjectSetup.ObjID,ParameterDirection.Input),
             new OracleParameter ("P_Auth_Lvl",OracleDbType.Varchar2,30,oAccessControlBO.AuthenticationLevel,ParameterDirection.Input),
             new OracleParameter ("P_Remarks",OracleDbType.Varchar2,300,oAccessControlBO.Remarks,ParameterDirection.Input),
            };

            return AccessControlDetails(packageName, parameterList);
        }
        #endregion
        #region Delete
        public AccessControl DeleteAccessControl(string empid)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Delete_AC_Control";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, empid,ParameterDirection.Input)
            };

            return AccessControlDetails(packageName, parameterList);
        }
        #endregion
        #region GetsforGrid
        public List<AccessControl> GetsAccessControlGrid()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GET_Access_Controls";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "GRID",ParameterDirection.Input),
            };
            return GetsAccessControlGridDetails(packageName, parameterList);
        }
        private List<AccessControl> GetsAccessControlGridDetails(string packageName, OracleParameter[] parameterList)
        {
            List<AccessControl> rDRSs = new List<AccessControl>();
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
        
        private AccessControl MapObject(NullHandler oReader)
        {
            AccessControl oDRS = new AccessControl();
            EntryParameter oEntryParameter = new EntryParameter();
            Module oModule = new Module();
            ObjectSetup oObjectSetup = new ObjectSetup();
            UserGroup oUserGroup = new UserGroup();
            User oUser = new User();

            oEntryParameter.EntryBy = oReader.GetString("EMP_ID");
            oModule.ModuleID = oReader.GetString("MODULE_ID");
            oObjectSetup.ObjID = oReader.GetString("Obj_Name");
            oObjectSetup.ObjType = oReader.GetString("ObjType");
            oDRS.AuthenticationLevel = oReader.GetInt16("AUTH_LVL");
            oDRS.AuthLevel = oReader.GetString("Auth_Level");               
            oUserGroup.GroupID = oReader.GetString("Grp_Title");
            oUser.NickName = oReader.GetString("Nick_Name");
            oDRS.Remarks = oReader.GetString("Remarks");
            oDRS.EntryParameter = oEntryParameter;
            oDRS.ObjectSetup = oObjectSetup;
            oDRS.Module = oModule;
            oDRS.UserGroup = oUserGroup;
            oDRS.User = oUser;
            return oDRS;
        }
        private AccessControl CreateObject(NullHandler oReader)
        {
            AccessControl oDRS = new AccessControl();
            oDRS = MapObject(oReader);
            return oDRS;
        }
        private List<AccessControl> CreateObjects(IDataReader oReader)
        {
            List<AccessControl> rDRSs = new List<AccessControl>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                AccessControl oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion   
        #region GetsforCombo
        public List<AccessControl> GetsAccessControlCbo()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Security_Question";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "COMBO",ParameterDirection.Input),
            };
            return GetsAccessControlCboDetails(packageName, parameterList);
        }
        private List<AccessControl> GetsAccessControlCboDetails(string packageName, OracleParameter[] parameterList)
        {
            List<AccessControl> rDRSs = new List<AccessControl>();
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
        private AccessControl MapObjectCbo(NullHandler oReader)
        {
            AccessControl oDRS = new AccessControl();
            //oDRS.Q_ID = oReader.GetString("Q_ID");
            //oDRS.Q_TITLE = oReader.GetString("Q_TITLE");
            return oDRS;
        }
        private AccessControl CreateObjectCbo(NullHandler oReader)
        {
            AccessControl oDRS = new AccessControl();
            oDRS = MapObjectCbo(oReader);
            return oDRS;
        }
        private List<AccessControl> CreateObjectsCbo(IDataReader oReader)
        {
            List<AccessControl> rDRSs = new List<AccessControl>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                AccessControl oItem = CreateObjectCbo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion

        #region GetUserAccessControlReport

        public List<AccessControlRO> GetUserAccessControl()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.User_Access_Control";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)            
            };
            return AccessControlReportDetails(packageName, parameterList);
        }

        public List<AccessControlRO> GetUserAccessReport(string EmployeeID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Get_User_Access_Details";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_empid",OracleDbType.Varchar2,30,EmployeeID,ParameterDirection.Input),
            };
            return AccessControlReportDetails(packageName, parameterList);
        }
        public List<AccessControlRO> UACGroupReport(string GroupID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.UAC_Group_Report";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_groupid",OracleDbType.Varchar2,30,GroupID,ParameterDirection.Input),
            };
            return AccessControlReportDetails(packageName, parameterList);
        }
        public List<AccessControlRO> UACModuleReport(string ModuleID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.UAC_Module_Report";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_moduleid",OracleDbType.Varchar2,30,ModuleID,ParameterDirection.Input),
            };
            return AccessControlReportDetails(packageName, parameterList);
        }
        private List<AccessControlRO> AccessControlReportDetails(string packageName, OracleParameter[] parameterList)
        {
            List<AccessControlRO> rDRSs = new List<AccessControlRO>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsRO(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        private List<AccessControlRO> CreateObjectsRO(IDataReader oReader)
        {
            List<AccessControlRO> rDRSs = new List<AccessControlRO>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                AccessControlRO oItem = CreateObjectRO(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        private AccessControlRO CreateObjectRO(NullHandler oReader)
        {
            AccessControlRO oDRS = new AccessControlRO();
            oDRS = MapObjectRO(oReader);
            return oDRS;
        }
        private AccessControlRO MapObjectRO(NullHandler oReader)
        {
            AccessControlRO oACRO = new AccessControlRO();
            oACRO.Emp_ID = oReader.GetString("EMP_ID");
            oACRO.Nick_Name = oReader.GetString("Nick_Name");
            oACRO.E_Mail = oReader.GetString("E_Mail");
            oACRO.Grp_Title = oReader.GetString("Grp_Title");
            oACRO.Remarks = oReader.GetString("Remarks");
            oACRO.Module_ID = oReader.GetString("MODULE_ID");
            oACRO.ModuleName = oReader.GetString("ModuleName");
            oACRO.Obj_Name = oReader.GetString("Obj_Name");
            oACRO.Obj_Type = oReader.GetString("Obj_Type");
            oACRO.ObjType = oReader.GetString("ObjType");
            oACRO.Auth_Lvl = oReader.GetString("AUTH_LVL");
            oACRO.Auth_Level = oReader.GetString("Auth_Level");
            oACRO.Grp_ID = oReader.GetString("Grp_ID");
            return oACRO;
        }
        #endregion

        public void SaveLoginHistory(AccessControl oAccessControlBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS.INSERT_LOGIN_HIST";

            OracleParameter[] parameterList = new OracleParameter[]
            {            
             new OracleParameter ("P_EMP_ID",OracleDbType.Varchar2,30, oAccessControlBO.EntryParameter.EntryBy,ParameterDirection.Input),
            // new OracleParameter ("P_Module_ID",OracleDbType.Varchar2,20,oAccessControlBO.Module.ModuleID,ParameterDirection.Input),         
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oAccessControlBO.EntryParameter.MachineID,ParameterDirection.Input)
            
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
      
        }
    }
}
