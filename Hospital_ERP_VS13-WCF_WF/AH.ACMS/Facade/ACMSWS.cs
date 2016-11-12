using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ACMS.MODEL;
using AH.ACMS.BLL;
using AH.HR.BLL;
using AH.HR.MODEL;
using AH.DUtility;

namespace AH.ACMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ACMSWS" in both code and config file together.
    public class ACMSWS : IACMSWS
    {
        //Fauzul 13 July 2014
        public List<AccessControlRO> GetUserAccessControl()
        {
            return new ACMSSetupBLL().GetUserAccessControl();
        }
        public List<AccessControlRO> UACGroupReport(string GroupID)
        {
            return new ACMSSetupBLL().UACGroupReport(GroupID);
        }
        public List<AccessControlRO> UACModuleReport(string ModuleID)
        {
            return new ACMSSetupBLL().UACModuleReport(ModuleID);
        }
        public List<AccessControlRO> GetUserAccessReport(string EmployeeID)
        {
            return new ACMSSetupBLL().GetUserAccessReport(EmployeeID);
        }
        public AccessControl SaveAccessControl(AccessControl oAccessControlBO)
        {
            return new ACMSSetupBLL().SaveAccessControl(oAccessControlBO);
        }
        public List<AccessControl> GetsAccessControl()
        {
            return new ACMSSetupBLL().GetsAccessControl();
        }
        public List<AccessControl> GetsAccessControlCbo()
        {
            return new ACMSSetupBLL().GetsAccessControlCbo();
        }
        public AccessControl EditAccessControl(AccessControl oAccessControlBO)
        {
            return new ACMSSetupBLL().EditAccessControl(oAccessControlBO);
        }
        public AccessControl DeleteAccessControl(string questid)
        {
            return new ACMSSetupBLL().DeleteAccessControl(questid);
        }

#region -------------------------------------------------------------------------------------------

        public short SaveObjectSetup(ObjectSetup oObjectSetupBO)
        {
            return new ACMSSetupBLL().SaveObjectSetup(oObjectSetupBO);
        }

        public List<ObjectSetup> GetsObjectSetupGrid()
        {
            return new ACMSSetupBLL().GetsObjectSetupGrid();
        }
        public List<ObjectSetup> GetsObjectSetupCbo()
        {
            return new ACMSSetupBLL().GetsObjectSetupCbo();
        }

        public ObjectSetup UpdateObject(ObjectSetup oUpdate)
        {
            return new ACMSSetupBLL().UpdateObject(oUpdate);
        }

        //public ObjectSetup EditObjectSetup(ObjectSetup oObjectSetupBO)
        //{
        //    return new ACMSSetupBLL().EditObjectSetup(oObjectSetupBO);
        //}
        public ObjectSetup DeleteObjectSetup(string questid)
        {
            return new ACMSSetupBLL().DeleteObjectSetup(questid);
        }

        public List<Module> GetUserModule(string empId)
        {
            return new ACMSSetupBLL().GetUserModule(empId);
        }

#endregion//-------------------------------------------------------------------------------

        public SecurityQuestion SaveSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            return new ACMSSetupBLL().SaveSecQuestion(oSecurityQuestionBO);
        }
        public List<SecurityQuestion> GetsSecurityQuestions()
        {
            return new ACMSSetupBLL().GetsSecurityQuestions();
        }
        public List<SecurityQuestion> GetsSecurityQuestionCbo()
        {
            return new ACMSSetupBLL().GetsSecurityQuestionCbo();
        }
        public SecurityQuestion EditSecQuestion(SecurityQuestion oSecurityQuestionBO)
        {
            return new ACMSSetupBLL().EditSecQuestion(oSecurityQuestionBO);
        }
        public SecurityQuestion DeleteSecQuest(string questid)
        {
            return new ACMSSetupBLL().DeleteSecQuest(questid);
        }
        public List<User> GetsUser()
        {
            return new ACMSSetupBLL().GetsUser();
        }

        public List<UserGroup> GetsUserGroups()
        {
            return new ACMSSetupBLL().GetsUserGroups();
        }
        public List<UserGroup> GetsUserGroupCbo()
        {
            return new ACMSSetupBLL().GetsUserGroupCbo();
        }
        public List<User> GetUsersCbo()
        {
            return new ACMSSetupBLL().GetUsersCbo();
        }
        public UserGroup SaveUserGroup(UserGroup oUserGroupBO)
        {
            return new ACMSSetupBLL().SaveUserGroup(oUserGroupBO);
        }
        public User SaveUser(User oUserBO)
        {
            return new ACMSSetupBLL().SaveUser(oUserBO);
        }
        public UserGroup EditUserGroup(UserGroup oUserGroupBO)
        {
            return new ACMSSetupBLL().EditUserGroup(oUserGroupBO);
        }
        public UserGroup DeleteUserGroup(string GroupID)
        {
            return new ACMSSetupBLL().DeleteUserGroup(GroupID);
        }
        public User DeleteUser(string UserID)
        {
            return new ACMSSetupBLL().DeleteUser(UserID);
        }
        public List<GroupObjectMap> SaveGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            return new ACMSSetupBLL().SaveGroupObjectMap(oGroupObjectMaps);
        }
        public List<GroupObjectMap> GetsGroupObjectMap(string moduleId, string objID, string grpID)
        {
            return new ACMSSetupBLL().GetsGroupObjectMap(moduleId, objID, grpID);
        }
        public List<ObjectSetup> GetsObjSetupCbo(string ModuleID, string ObjectTypeID,string roleType)
        {
            return new ACMSSetupBLL().GetsObjSetupCbo(ModuleID, ObjectTypeID, roleType);
        }
        public List<GroupObjectMap> EditGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps)
        {
            return new ACMSSetupBLL().EditGroupObjectMap(oGroupObjectMaps);
        }

        public short SaveUserGroupAssign(UserGroupAssign oUserGroupAssign)
        {
            return new ACMSSetupBLL().SaveUserGroupAssign(oUserGroupAssign);
        }
        public List<User> GetsUserNotAssigned(string ModuleID, string GroupID)
        {
            return new ACMSSetupBLL().GetsUserNotAssigned(ModuleID, GroupID);
        }
        public List<UserGroupAssign> GetsUserAssigned(string Module, string Group)
        {
            return new ACMSSetupBLL().GetsUserAssigned(Module, Group);
        }
        public User EditUser(User oUserBO)
        {
            return new ACMSSetupBLL().EditUser(oUserBO);
           
            
        }

        //..................................................................Module Object Zone..............................

        public List<ObjectSetup> GetUserObject(string empID, string moduleID)
        {
            return new ACMSSetupBLL().GetUserObject(empID, moduleID);
        }

        ///////////////-------------------------HR---------------------------////////////////////
        public EmployeeMaster GetEmpoyee(string empID)
        {
            return new EmployeeSetUpBLL().GetEmpMaster(empID);
        }

        public User GetUser(string empID)
        {
            return new ACMSSetupBLL().GetUser(empID);
        }

        public short UpdateUserPassword(User oUserBO)
        {
            return new ACMSSetupBLL().UpdateUserPassword(oUserBO);
        }
        public List<AccessList> GetUserObjectList(string empID)
        {
            return new ACMSSetupBLL().GetUserObjectList(empID);
        }
        public List<User> GetsAssignedUser(string ModuleID, string GroupID)
        {
            return new ACMSSetupBLL().GetsAssignedUser(ModuleID, GroupID);
        }
        public void SaveLoginHistory(AccessControl oAccessControlBO)
        {
            new ACMSSetupBLL().SaveLoginHistory(oAccessControlBO);
        }
    }
}
