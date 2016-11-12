using System.Data;
using AH.ACMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.ACMS.DAL
{
    public class ObjectSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACMS);
        string packageName = string.Empty;
        #region Save
        public short  SaveObjectSetup(ObjectSetup oObjectSetupBO)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_OBJECT";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("e_user_msg",OracleDbType.Varchar2,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_object_id_serial",OracleDbType.Varchar2,5, oObjectSetupBO.ObjID,ParameterDirection.Input),
             new OracleParameter ("p_module_id",OracleDbType.Varchar2,8, oObjectSetupBO.Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("p_object_id",OracleDbType.Varchar2,200, oObjectSetupBO.ObjID,ParameterDirection.Input),
             new OracleParameter ("p_object_name",OracleDbType.Varchar2,400,oObjectSetupBO.ObjName,ParameterDirection.Input),
             new OracleParameter ("p_object_type",OracleDbType.Varchar2,1,oObjectSetupBO.ObjType,ParameterDirection.Input),
             new OracleParameter ("p_active",OracleDbType.Char,1,oObjectSetupBO.EntryParameter.Active,ParameterDirection.Input),
             
             new OracleParameter ("p_entry_by",OracleDbType.Varchar2,20,oObjectSetupBO.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_update_by",OracleDbType.Varchar2,20,oObjectSetupBO.EntryParameter.UpdateBy,ParameterDirection.Input),
                        
             new OracleParameter ("p_comp_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("p_loc_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("p_mac_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else  if ((OracleDecimal)prm.Value == 2)
                return 2;
            else
                return 0;
           // return SaveObjectSetupDetails(packageName, parameterList);
        }


        public ObjectSetup SaveObjectSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            ObjectSetup oObjectSetupBO = new ObjectSetup();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oObjectSetupBO.EntryParameter = oEntryParameter;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                if (reader.Read())
                {

                    oObjectSetupBO = CreateObject(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oObjectSetupBO.EntryParameter = oEntryParameter;
            }
            return oObjectSetupBO;
        }



        //----------------------------------------------------------------------------------------

        public List<ObjectSetup> GetObjectSetup()
        {
            string packageName = "PKG_EMP_INFO.Get_Object_Setup";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              
            };
            return GetListObjectSetup(packageName, parameterList);

        }

        private List<ObjectSetup> GetListObjectSetup(string packageName, OracleParameter[] parameterList)
        {
            List<ObjectSetup> oListObjectSetup = new List<ObjectSetup>();

            OracleDataReader rdr;

            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                ObjectSetup oObjectSetup = new ObjectSetup();

                oObjectSetup.ObjSerial = (string)rdr["OBJ_ID_SERIAL"];

                Module oModule = new Module();
                oModule.ModuleID = (string)rdr["MODULE_ID"];
                oModule.ModuleName = (string)rdr["MODULE_NAME"];
                oObjectSetup.Module = oModule;

                oObjectSetup.ObjID = (string)rdr["OBJ_ID"];
                oObjectSetup.ObjName = (string)rdr["OBJ_NAME"];
                oObjectSetup.ObjType = (string)rdr["OBJ_TYPE"];

                oListObjectSetup.Add(oObjectSetup);
            }
            rdr.Close();
            return oListObjectSetup;

        }

        //........................................................................................

        public List<GroupObjectMap> SaveGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_GRP_OBJ_MAP";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_module_id",OracleDbType.Varchar2,30, oGroupObjectMaps[0].Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("p_group_id",OracleDbType.Varchar2,300,oGroupObjectMaps[0].UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("p_obj_type",OracleDbType.Varchar2,10,oGroupObjectMaps[0].ObjectSetup.ObjType,ParameterDirection.Input),
             new OracleParameter ("p_object_id",OracleDbType.Varchar2,30000,oGroupObjectMaps[0].ObjectSetup.ObjID,ParameterDirection.Input),
             //new OracleParameter ("P_AUTH_LVL",OracleDbType.Varchar2,oGroupObjectMaps[0].AuthenticationLevel,ParameterDirection.Input),

             new OracleParameter ("p_entry_by",OracleDbType.Varchar2,20,oGroupObjectMaps[0].EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_update_by",OracleDbType.Varchar2,20,oGroupObjectMaps[0].EntryParameter.UpdateBy,ParameterDirection.Input),
           
             new OracleParameter ("p_comp_id",OracleDbType.Varchar2,20,oGroupObjectMaps[0].EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("p_loc_id",OracleDbType.Varchar2,20,oGroupObjectMaps[0].EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("p_mac_id",OracleDbType.Varchar2,20,oGroupObjectMaps[0].EntryParameter.MachineID,ParameterDirection.Input)
            };

            return SaveGroupObjectMapDetails(packageName, parameterList);
        }


        public List<GroupObjectMap> EditGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Update_GRP_OBJ_MAP";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_module_id",OracleDbType.Varchar2,30, oGroupObjectMaps[0].Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("p_group_id",OracleDbType.Varchar2,300,oGroupObjectMaps[0].UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("p_object_id",OracleDbType.Varchar2,200,oGroupObjectMaps[0].ObjectSetup.ObjID,ParameterDirection.Input),
             new OracleParameter ("P_AUTH_LVL",OracleDbType.Varchar2,oGroupObjectMaps[0].AuthenticationLevel,ParameterDirection.Input),
            };

            return SaveGroupObjectMapDetails(packageName, parameterList);
        }

        public List<GroupObjectMap> SaveGroupObjectMapDetails(string packageName, OracleParameter[] parameterList)
        {
            List<GroupObjectMap> oGroupObjectMaps = new List<GroupObjectMap>();
            EntryParameter oEntryParameter = new EntryParameter();
            GroupObjectMap oGroupObjectMap = new GroupObjectMap();
            try
            {
                IDataReader reader = null;
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);

                oEntryParameter.ErrorMessage = "";
                oGroupObjectMap.EntryParameter = oEntryParameter;
                oGroupObjectMaps.Add(oGroupObjectMap);

                if (reader.Read())
                {
                    oGroupObjectMaps = CreateObjectsGrpObj(reader);
                }
                reader.Close();

            }
            catch (Exception e)
            {

                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                oGroupObjectMap.EntryParameter = oEntryParameter;
                oGroupObjectMaps.Add(oGroupObjectMap);

            }
            return oGroupObjectMaps;
        }
        public List<GroupObjectMap> GetsGroupObjectMap(string moduleId,string objID,string grpID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Gets_GrpObjMap";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter("p_module_id",OracleDbType.Varchar2,8,moduleId,ParameterDirection.Input),
              new OracleParameter("p_grp_id",OracleDbType.Varchar2,30,grpID,ParameterDirection.Input),
             new OracleParameter("p_obj_Id",OracleDbType.Varchar2,200,objID,ParameterDirection.Input)
            
            };
            return GetsGroupObjectMapDetails(packageName, parameterList);
        }
        private List<GroupObjectMap> GetsGroupObjectMapDetails(string packageName, OracleParameter[] parameterList)
        {
            List<GroupObjectMap> rDRSs = new List<GroupObjectMap>();
            IDataReader reader = null;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjectsGrpObj(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return rDRSs;
        }
        private GroupObjectMap CreateObjectGOMap(NullHandler oReader)
        {
            GroupObjectMap oDRS = new GroupObjectMap();
            oDRS = MapObjectGOMap(oReader);
            return oDRS;
        }
        private List<GroupObjectMap> CreateObjectsGrpObj(IDataReader oReader)
        {
            List<GroupObjectMap> oGroupObjectMaps = new List<GroupObjectMap>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                GroupObjectMap oItem = CreateObjectGOMap(oHandler);
                oGroupObjectMaps.Add(oItem);
            }
            return oGroupObjectMaps;
        }

        private GroupObjectMap MapObjectGOMap(NullHandler oReader)
        {
            GroupObjectMap oDRS = new GroupObjectMap();

            Module oModule = new Module();
            oModule.ModuleName = oReader.GetString("ModuleName");
            oModule.ModuleID = oReader.GetString("Module_ID");
            oDRS.Module = oModule;

            UserGroup oUserGroup = new UserGroup();
            oUserGroup.GroupTitle = oReader.GetString("GroupName");
            oUserGroup.GroupID = oReader.GetString("Grp_ID");
            oDRS.UserGroup = oUserGroup;

            ObjectSetup oObjectSetup = new ObjectSetup();
            oObjectSetup.ObjID = oReader.GetString("Obj_ID");
            oObjectSetup.ObjName = oReader.GetString("ObjectName");
            oObjectSetup.ObjType = oReader.GetString("ObjectType");
            oDRS.ObjectSetup = oObjectSetup;
     
            oDRS.AuthenticationLevel = oReader.GetString("AuthenticationLevel");

            oDRS.AuthLevID = oReader.GetString("Auth_Lvl");
            
            
            
            return oDRS;
        }

        //public UserGroupAssign SaveUserGroupAssign(UserGroupAssign oUserGroupAssign)
        public short SaveUserGroupAssign(UserGroupAssign oUserGroupAssign)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.INSERT_USER_GRP_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
           //  new OracleParameter ("p_msg",OracleDbType.Varchar2,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("P_MODULE_ID",OracleDbType.Varchar2,300,oUserGroupAssign.Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("P_GRP_ID",OracleDbType.Varchar2,30,oUserGroupAssign.UserGroup.GroupID,ParameterDirection.Input),
             new OracleParameter ("P_EMP_IDs",OracleDbType.Varchar2,20000, oUserGroupAssign.EmpIDs,ParameterDirection.Input),
             new OracleParameter ("P_ACTIVE",OracleDbType.Varchar2,30,oUserGroupAssign.EntryParameter.Active,ParameterDirection.Input),
             new OracleParameter ("P_ENTRY_BY",OracleDbType.Varchar2,20,oUserGroupAssign.EntryParameter.EntryBy,ParameterDirection.Input),
            // new OracleParameter ("ENTRY_DATE",OracleDbType.Date,20,oUserGroupAssign.EntryParameter.EntryDate,ParameterDirection.Input),
             new OracleParameter ("P_VERSION",OracleDbType.Varchar2,30,oUserGroupAssign.EntryParameter.Version,ParameterDirection.Input),
             new OracleParameter ("P_COMP_ID",OracleDbType.Varchar2,20,oUserGroupAssign.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("P_LOC_ID",OracleDbType.Varchar2,20,oUserGroupAssign.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("P_MAC_ID",OracleDbType.Varchar2,20,oUserGroupAssign.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else  if ((OracleDecimal)prm.Value == 2)
                return 2;
            else return 0;
           // return SaveUserGroupAssignDetails(packageName, parameterList);
        }
        public UserGroupAssign SaveUserGroupAssignDetails(string packageName, OracleParameter[] parameterList)
        {
            IDataReader reader = null;
            UserGroupAssign oUserGroupAssign = new UserGroupAssign();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oUserGroupAssign.EntryParameter = oEntryParameter;
            try
            {
                reader = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                NullHandler oReader = new NullHandler(reader);
                if (reader.Read())
                {

                    oUserGroupAssign = CreateObjectUGA(oReader);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                oEntryParameter.ErrorMessage = e.Message.Split('!')[0];
                if (oEntryParameter.ErrorMessage == "")
                {
                    oEntryParameter.ErrorMessage = parameterList[1].ToString();
                }
                oUserGroupAssign.EntryParameter = oEntryParameter;
            }
            return oUserGroupAssign;
        }

        private UserGroupAssign MapObjectUGA(NullHandler oReader)
        {
            UserGroupAssign oDRS = new UserGroupAssign();

            Module oModule = new Module();
            oModule.ModuleID = oReader.GetString("ModuleID");
            oDRS.Module = oModule;

            UserGroup oUserGroup = new UserGroup();
            oUserGroup.GroupID = oReader.GetString("GroupID");
            oDRS.UserGroup = oUserGroup;

            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.EntryBy = oReader.GetString("EmployeeID");
            oEntryParameter.Active = oReader.GetString("Active");
            oEntryParameter.EntryBy = oReader.GetString("EntryBy");
            oEntryParameter.EntryDate = Convert.ToDateTime(oReader.GetString("EntryDate"));
            oEntryParameter.EntryBy = oReader.GetString("UpdateBy");
            oEntryParameter.EntryDate = Convert.ToDateTime(oReader.GetString("UpdateDate"));
            oEntryParameter.Version = oReader.GetString("Version");

            oDRS.Date = oReader.GetString("Date");

            oEntryParameter.CompanyID = oReader.GetString("CompanyID");
            oEntryParameter.LocationID = oReader.GetString("LocationID");
            oEntryParameter.MachineID = oReader.GetString("MachineID");

            oDRS.EntryParameter = oEntryParameter;
           
           
            return oDRS;
        }
        private UserGroupAssign CreateObjectUGA(NullHandler oReader)
        {
            UserGroupAssign oDRS = new UserGroupAssign();
            oDRS = MapObjectUGA(oReader);
            return oDRS;
        }
        private List<UserGroupAssign> CreateObjectsUGA(IDataReader oReader)
        {
            List<UserGroupAssign> rDRSs = new List<UserGroupAssign>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                UserGroupAssign oItem = CreateObjectUGA(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion

        #region updateObject
        public ObjectSetup UpdateObject(ObjectSetup oUpdate)
        {          
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.UPDATE_OBJECT";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_object_id_serial",OracleDbType.Varchar2,5, oUpdate.ObjSerial,ParameterDirection.Input),

             new OracleParameter ("p_module_id",OracleDbType.Varchar2,8, oUpdate.Module.ModuleID,ParameterDirection.Input),
             new OracleParameter ("p_object_id",OracleDbType.Varchar2,200, oUpdate.ObjID,ParameterDirection.Input),
             new OracleParameter ("p_object_name",OracleDbType.Varchar2,400,oUpdate.ObjName,ParameterDirection.Input),
             new OracleParameter ("p_object_type",OracleDbType.Varchar2,1,oUpdate.ObjType,ParameterDirection.Input),
             new OracleParameter ("p_entry_by",OracleDbType.Varchar2,20,oUpdate.EntryParameter.EntryBy,ParameterDirection.Input),
             new OracleParameter ("p_comp_id",OracleDbType.Varchar2,2,oUpdate.EntryParameter.CompanyID,ParameterDirection.Input),
             new OracleParameter ("p_loc_id",OracleDbType.Varchar2,2,oUpdate.EntryParameter.LocationID,ParameterDirection.Input),
             new OracleParameter ("p_mac_id",OracleDbType.Varchar2,2,oUpdate.EntryParameter.MachineID,ParameterDirection.Input)
            };

            return SaveObjectSetupDetails(packageName, parameterList);
        }
        #endregion

        //#region Edit
        //public ObjectSetup EditObjectSetup(ObjectSetup oObjectSetupBO)
        //{
        //    string packageName = "AGH_ACMS.PKG_ACMS_SETUP.EDIT_OBJECT";

        //    OracleParameter[] parameterList = new OracleParameter[]
        //    {
        //     new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
        //     new OracleParameter ("p_object_id_serial",OracleDbType.Varchar2,5, oObjectSetupBO.ObjID,ParameterDirection.Input),
        //     new OracleParameter ("p_module_id",OracleDbType.Varchar2,8, oObjectSetupBO.Module.ModuleID,ParameterDirection.Input),
        //     new OracleParameter ("p_object_id",OracleDbType.Varchar2,200, oObjectSetupBO.ObjID,ParameterDirection.Input),
        //     new OracleParameter ("p_object_name",OracleDbType.Varchar2,400,oObjectSetupBO.ObjName,ParameterDirection.Input),
        //     new OracleParameter ("p_object_type",OracleDbType.Varchar2,1,oObjectSetupBO.ObjType,ParameterDirection.Input),
        //      new OracleParameter ("p_active",OracleDbType.Varchar2,1,oObjectSetupBO.EntryParameter.Active,ParameterDirection.Input),
             
        //     new OracleParameter ("p_entry_by",OracleDbType.Varchar2,20,oObjectSetupBO.EntryParameter.EntryBy,ParameterDirection.Input),
        //     new OracleParameter ("p_update_by",OracleDbType.Varchar2,20,oObjectSetupBO.EntryParameter.UpdateBy,ParameterDirection.Input),
        //     new OracleParameter ("p_version",OracleDbType.Int32,oObjectSetupBO.EntryParameter.Version,ParameterDirection.Input),
             
        //     new OracleParameter ("p_comp_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.CompanyID,ParameterDirection.Input),
        //     new OracleParameter ("p_loc_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.LocationID,ParameterDirection.Input),
        //     new OracleParameter ("p_mac_id",OracleDbType.Varchar2,2,oObjectSetupBO.EntryParameter.MachineID,ParameterDirection.Input)
        //    };

        //    return SaveObjectSetupDetails(packageName, parameterList);
        //}
        //#endregion
        #region Delete
        public ObjectSetup DeleteObjectSetup(string objid)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.Delete_Object";

            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_e_rows",OracleDbType.Int32,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_object_id_serial",OracleDbType.Varchar2,15, objid,ParameterDirection.Input)
            };

            return SaveObjectSetupDetails(packageName, parameterList);
        }
        #endregion
        #region GetsforGrid
        public List<ObjectSetup> GetsObjectSetupGrid()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Object";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "GRID",ParameterDirection.Input),
            };
            return GetsObjectSetupGridDetails(packageName, parameterList);
        }
        private List<ObjectSetup> GetsObjectSetupGridDetails(string packageName, OracleParameter[] parameterList)
        {
            List<ObjectSetup> rDRSs = new List<ObjectSetup>();
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
        private ObjectSetup MapObject(NullHandler oReader)
        {
            ObjectSetup oDRS = new ObjectSetup();

            oDRS.ObjSerial = oReader.GetString("OBJ_ID_SERIAL");
            oDRS.ObjID = oReader.GetString("OBJ_ID");
            oDRS.ObjType = oReader.GetString("OBJ_TYPE");
            oDRS.ObjName = oReader.GetString("OBJ_NAME");
            Module oModule = new Module();
            oModule.ModuleID = oReader.GetString("MODULE_ID");
            oModule.ModuleName = oReader.GetString("ModuleName");

            oDRS.Module = oModule;

            return oDRS;
        }
        private ObjectSetup CreateObject(NullHandler oReader)
        {
            ObjectSetup oDRS = new ObjectSetup();
            oDRS = MapObject(oReader);
            return oDRS;
        }
        private List<ObjectSetup> CreateObjects(IDataReader oReader)
        {
            List<ObjectSetup> rDRSs = new List<ObjectSetup>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                ObjectSetup oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
     #endregion
        #endregion

        #region GetsforCombo 
        public List<ObjectSetup> GetsObjectSetupCbo()
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Object";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_loads_for",OracleDbType.Varchar2,30, "COMBO",ParameterDirection.Input),
            };
            return GetsObjectSetupDetails(packageName, parameterList);
        }

        private List<ObjectSetup> GetsObjectSetupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<ObjectSetup> rDRSs = new List<ObjectSetup>();
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

        public List<ObjectSetup> GetsObjSetupCbo(string ModuleID, string ObjectTypeID,string roleID)
        {
            string packageName = "AGH_ACMS.PKG_ACMS_SETUP.GETs_Object_ModuleID";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                 new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter ("p_module_id",OracleDbType.Varchar2,8, ModuleID,ParameterDirection.Input),
                 new OracleParameter ("p_obj_type",OracleDbType.Varchar2,1, ObjectTypeID,ParameterDirection.Input),
                  new OracleParameter ("p_role_type",OracleDbType.Varchar2,30, roleID,ParameterDirection.Input)
            };
            return GetsObjectSetupDetails(packageName, parameterList);
        }

        #region DataReaderMappingwithNUllCombo
        private ObjectSetup MapObjectCbo(NullHandler oReader)
        {
            ObjectSetup oDRS = new ObjectSetup();
            oDRS.ObjID = oReader.GetString("OBJ_ID");
            oDRS.ObjName = oReader.GetString("OBJ_NAME");
            return oDRS;
        }
        private ObjectSetup CreateObjectCbo(NullHandler oReader)
        {
            ObjectSetup oDRS = new ObjectSetup();
            oDRS = MapObjectCbo(oReader);
            return oDRS;
        }
        private List<ObjectSetup> CreateObjectsCbo(IDataReader oReader)
        {
            List<ObjectSetup> rDRSs = new List<ObjectSetup>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                ObjectSetup oItem = CreateObjectCbo(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion
        #endregion


        #region GetUserModule

        public List<Module> GetUserModule(string empId) //that is EmployeeModule
        {
            string packageName = "AGH_ACMS.PKG_USER_MODULE.Get_User_Module";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_emp_id",OracleDbType.Varchar2,30,empId,ParameterDirection.Input),
            };
            return GetListUserModule(packageName, parameterList);
        }

        private List<Module> GetListUserModule(string packageName, OracleParameter[] parameterList)
        {
            List<Module> oUserModules = new List<Module>();
            try
            {
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

                while (rdr.Read())
                {  
                    Module oUserModule = new Module();
                    oUserModule.ModuleID = !rdr.IsDBNull(0) ?(string)rdr["MODULE_ID"]:"";
                    oUserModule.ModuleName =  !rdr.IsDBNull(1) ?(string)rdr["MODULE_NAME"]:"";
                    oUserModules.Add(oUserModule);
                }

                rdr.Close(); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return oUserModules;
        }

        #endregion

        //..................................................................User Object.........................
        #region  GetUserObject User Object

        public List<ObjectSetup> GetUserObject(string empID, string moduleID) 
        {
            string packageName = "PKG_USER_MODULE.Get_User_Object";
            OracleParameter[] parameterList = new OracleParameter[]
            {
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
             new OracleParameter ("p_emp_id",OracleDbType.Varchar2,30,empID,ParameterDirection.Input),
             new OracleParameter ("p_module_id",OracleDbType.Varchar2,8,moduleID,ParameterDirection.Input),
            };
            return GetListUserObject(packageName, parameterList);
        }

        private List<ObjectSetup> GetListUserObject(string packageName, OracleParameter[] parameterList)
        {
            List<ObjectSetup> oModuleObjects = new List<ObjectSetup>();
            try
            {
                OracleDataReader rdr;
                rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
                
                while (rdr.Read())
                {
                    ObjectSetup oObjectModule = new ObjectSetup();                    
                    Module oModule = new Module();
                    oModule.ModuleID =(string)rdr["MODULE_ID"].ToString();
                    //oModule.ModuleName = (string)rdr["MODULE_NAME"];
                    oObjectModule.Module = oModule;

                    oObjectModule.ObjID = (string)rdr["OBJ_ID"];
                    oObjectModule.ObjName = (string)rdr["OBJ_NAME"];
                    oObjectModule.ObjType = (string)rdr["OBJ_TYPE"];
                    oObjectModule.AuthenticationLevel = (string)rdr["Authentication_LvL"];

                    oModuleObjects.Add(oObjectModule);

                }

                rdr.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return oModuleObjects;
        }

        #endregion


//=============================14-Oct-2014==========================================//

        public List<AccessList> GetUserObjectList(string empID)
        {
            string packageName = "AGH_ACMS.PKG_USER_MODULE.Get_User_Obj";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter ("p_emp_id",OracleDbType.Varchar2,30,empID,ParameterDirection.Input),
            };

            return GetUserObjectList(packageName, parameterList);

        }
        private List<AccessList> GetUserObjectList(string packageName, OracleParameter[] parameterList)
        {
            ObjectSetup oObjectModule = new ObjectSetup();
            List<AccessList> oALs = new List<AccessList>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                AccessList oAL = new AccessList();
                oAL.ModuleID = (string)rdr["MODULE_ID"].ToString();
                oAL.ObjID = (string)rdr["OBJ_ID"];
                oAL.ObjName = (string)rdr["OBJ_NAME"];
                oAL.ObjType = (string)rdr["OBJ_TYPE"];
                oAL.AuthenticationLevel = (string)rdr["Authentication_LvL"];
                oAL.RoleID = (string)rdr["Grp_ID"];
                oAL.RoleName = (string)rdr["Grp_Title"];              
                oALs.Add(oAL);       
            }
            rdr.Close();
            return oALs;

        }

    }
}
