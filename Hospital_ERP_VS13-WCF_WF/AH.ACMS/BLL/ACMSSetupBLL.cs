using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACMS.DAL;
using AH.ACMS.MODEL;
using AH.DUtility;

namespace AH.ACMS.BLL
{
    public class ACMSSetupBLL
    {
        #region AccessControl
        public AccessControl SaveAccessControl(AccessControl oAccessControlBO)
        {
            return new AccessControlDAL().SaveAccessControl(oAccessControlBO);
        }
        public List<AccessControl> GetsAccessControl()
        {
            return new AccessControlDAL().GetsAccessControlGrid();
        }
        public List<AccessControl> GetsAccessControlCbo()
        {
            return new AccessControlDAL().GetsAccessControlCbo();
        }
        public AccessControl EditAccessControl(AccessControl oAccessControlBO)
        {
            return new AccessControlDAL().EditAccessControl(oAccessControlBO);
        }
        public AccessControl DeleteAccessControl(string questid)
        {
            return new AccessControlDAL().DeleteAccessControl(questid);
        }
        #endregion
        #region ObjectSetup
        public short SaveObjectSetup(ObjectSetup oObjectSetupBO)
        {
            return new ObjectSetupDAL().SaveObjectSetup(oObjectSetupBO);
        }

        public List<ObjectSetup> GetsObjectSetupGrid()
        {
            return new ObjectSetupDAL().GetsObjectSetupGrid();
        }
        public List<ObjectSetup> GetsObjectSetupCbo()
        {
            return new ObjectSetupDAL().GetsObjectSetupCbo();
        }
        public List<ObjectSetup> GetsObjSetupCbo(string ModuleID, string ObjectTypeID,string roleType)
        {
            return new ObjectSetupDAL().GetsObjSetupCbo(ModuleID, ObjectTypeID, roleType);
        }

        public ObjectSetup UpdateObject(ObjectSetup oUpdate)
        {
            return new ObjectSetupDAL().UpdateObject(oUpdate);
        }
        //public ObjectSetup EditObjectSetup(ObjectSetup oObjectSetupBO)
        //{
        //    return new ObjectSetupDAL().EditObjectSetup(oObjectSetupBO);
        //}
        public ObjectSetup DeleteObjectSetup(string questid)
        {
            return new ObjectSetupDAL().DeleteObjectSetup(questid);
        }

        public List<Module> GetUserModule(string empId)
        {
            return new ObjectSetupDAL().GetUserModule(empId);
        }
        #endregion
        #region SecurityQuestion
        public SecurityQuestion SaveSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            return new SecurityQuestionDAL().SaveSecQuestion(oSecurityQuestionBO);
        }
        public List<SecurityQuestion> GetsSecurityQuestions()
        {
            return new SecurityQuestionDAL().GetsSecurityQuestionsGrid();
        }
        public List<SecurityQuestion> GetsSecurityQuestionCbo()
        {
            return new SecurityQuestionDAL().GetsSecurityQuestionCbo();
        }
        public SecurityQuestion EditSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            return new SecurityQuestionDAL().EditSecQuestion(oSecurityQuestionBO);
        }
        public SecurityQuestion DeleteSecQuest(string questid)
        {
            return new SecurityQuestionDAL().DeleteSecQuest(questid);
        }
        #endregion
        #region User
        #region Gets
        public List<User> GetsUser()
        {
            return new UserSetUpDAL().GetsUser();
        }
        public List<User> GetsUserNotAssigned(string ModuleID, string GroupID)
        {
            return new UserSetUpDAL().GetsUserNotAssigned(ModuleID, GroupID);
        }
        public List<UserGroupAssign> GetsUserAssigned(string Module, string Group)
        {
            return new UserSetUpDAL().GetsUserAssigned(Module, Group);
        }
        public List<UserGroup> GetsUserGroups()
        {
            return new UserSetUpDAL().GetsUserGroups();
        }
        public List<UserGroup> GetsUserGroupCbo()
        {
            return new UserSetUpDAL().GetsUserGroupCbo();
        }
        public List<User> GetUsersCbo()
        {
            return new UserSetUpDAL().GetUsersCbo();
        }
        #endregion
        #region Save
        public UserGroup SaveUserGroup(UserGroup oUserGroupBO)
        {
            return new UserSetUpDAL().SaveUserGroup(oUserGroupBO);
        }
        public User SaveUser(User oUserBO)
        {
            return new UserSetUpDAL().SaveUser(oUserBO);
        }
        #endregion
        #region Edit
        public UserGroup EditUserGroup(UserGroup oUserGroupBO)
        {
            return new UserSetUpDAL().EditUserGroup(oUserGroupBO);
        }
        public User EditUser(User oUserBO)
        {
            return new UserSetUpDAL().EditUser(oUserBO);
        }
        #endregion
        #region Delete
        public UserGroup DeleteUserGroup(string GroupID)
        {
            return new UserSetUpDAL().DeleteUserGroup(GroupID);
        }
        public User DeleteUser(string UserID)
        {
            return new UserSetUpDAL().DeleteUser(UserID);
        }
        #endregion
        #endregion
        #region GroupObjectMap
        public List<GroupObjectMap> SaveGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            return new ObjectSetupDAL().SaveGroupObjectMap(oGroupObjectMaps);
        }

        public List<GroupObjectMap> EditGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            return new ObjectSetupDAL().EditGroupObjectMap(oGroupObjectMaps);
        }
        public List<GroupObjectMap> GetsGroupObjectMap(string moduleId, string objID, string grpID)
        {
            return new ObjectSetupDAL().GetsGroupObjectMap(moduleId, objID, grpID);
        }

        #endregion
        #region UserGroupAssign
        public short SaveUserGroupAssign(UserGroupAssign oUserGroupAssign)
        {
            return new ObjectSetupDAL().SaveUserGroupAssign(oUserGroupAssign);
        }
        #endregion

        #region GetUserAccessReport
        public List<AccessControlRO> UACGroupReport(string GroupID)
        {
            return new AccessControlDAL().UACGroupReport(GroupID);
        }
        public List<AccessControlRO> GetUserAccessReport(string EmployeeID)
        {
            return new AccessControlDAL().GetUserAccessReport(EmployeeID);
        }
        public List<AccessControlRO> UACModuleReport(string ModuleID)
        {
            return new AccessControlDAL().UACModuleReport(ModuleID);
        }
        public List<AccessControlRO> GetUserAccessControl()
        {
            return new AccessControlDAL().GetUserAccessControl();
        }
        #endregion


        #region UserObject

        public List<ObjectSetup> GetUserObject(string empID, string moduleID)
        {
            return new ObjectSetupDAL().GetUserObject(empID, moduleID);
        }

        #endregion

        public User GetUser(string empID)
        {
            return new UserSetUpDAL().GetUser(empID);
        }
 //=============================14-Oct-2014==========================================//
        public short UpdateUserPassword(User oUserBO)
        {
            return new UserSetUpDAL().UpdateUserPassword(oUserBO);      
        }

        public List<AccessList> GetUserObjectList(string empID)
        {
            return new ObjectSetupDAL().GetUserObjectList(empID);
        }

        public List<User> GetsAssignedUser(string ModuleID, string GroupID)
        {
            return new UserSetUpDAL().GetsAssignedUser(ModuleID, GroupID);      
        }
        public void SaveLoginHistory(AccessControl oAccessControlBO)
        {
            new AccessControlDAL().SaveLoginHistory(oAccessControlBO);      
        }
      
    }
    
}
