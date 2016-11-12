using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ACMS.MODEL;
using AH.HR.MODEL;
using AH.DUtility;


namespace AH.ACMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IACMSWS" in both code and config file together.
    [ServiceContract]
    public interface IACMSWS
    {
        [OperationContract]
        List<AccessControlRO> GetUserAccessControl();
        [OperationContract]
        List<AccessControlRO> UACGroupReport(string GroupID);
        [OperationContract]
        List<AccessControlRO> UACModuleReport(string ModuleID);
        [OperationContract]
        List<AccessControlRO> GetUserAccessReport(string EmployeeID);
        [OperationContract]
        AccessControl SaveAccessControl(AccessControl oAccessControlBO);
        [OperationContract]
        List<AccessControl> GetsAccessControl();
        [OperationContract]
        List<AccessControl> GetsAccessControlCbo();
        [OperationContract]
        AccessControl EditAccessControl(AccessControl oAccessControlBO);
        [OperationContract]
        AccessControl DeleteAccessControl(string questid);

        [OperationContract]
        short SaveObjectSetup(ObjectSetup oObjectSetupBO);
        [OperationContract]
        List<ObjectSetup> GetsObjectSetupGrid();
        [OperationContract]
        List<ObjectSetup> GetsObjectSetupCbo();
        [OperationContract]
        ObjectSetup UpdateObject(ObjectSetup oUpdate);
        //[OperationContract]
        //ObjectSetup EditObjectSetup(ObjectSetup oObjectSetupBO);
        [OperationContract]
        ObjectSetup DeleteObjectSetup(string questid);


        [OperationContract]
        List<Module> GetUserModule(string empId);

        [OperationContract]
        SecurityQuestion SaveSecQuestion(SecurityQuestion oSecurityQuestionBO);
        [OperationContract]
        List<SecurityQuestion> GetsSecurityQuestions();
        [OperationContract]
        List<SecurityQuestion> GetsSecurityQuestionCbo();
        [OperationContract]
        SecurityQuestion EditSecQuestion(SecurityQuestion oSecurityQuestionBO);
        [OperationContract]
        SecurityQuestion DeleteSecQuest(string questid);
        [OperationContract]
        List<User> GetsUser();
        [OperationContract]
        List<UserGroup> GetsUserGroups();
        [OperationContract]
        List<UserGroup> GetsUserGroupCbo();
        [OperationContract]
        List<User> GetUsersCbo();
        [OperationContract]
        UserGroup SaveUserGroup(UserGroup oUserGroupBO);
        [OperationContract]
        User SaveUser(User oUserBO);
        [OperationContract]
        UserGroup EditUserGroup(UserGroup oUserGroupBO);
        [OperationContract]
        UserGroup DeleteUserGroup(string GroupID);
        [OperationContract]
        User DeleteUser(string UserID);
        [OperationContract]
        List<GroupObjectMap> SaveGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps);
        [OperationContract]
        List<GroupObjectMap> GetsGroupObjectMap(string moduleId, string objID, string grpID);
        [OperationContract]
        List<ObjectSetup> GetsObjSetupCbo(string ModuleID, string ObjectTypeID,string roleType);
        [OperationContract]
        List<GroupObjectMap> EditGroupObjectMap(List<GroupObjectMap> oGroupObjectMaps);
        [OperationContract]
        short SaveUserGroupAssign(UserGroupAssign oUserGroupAssign);
        [OperationContract]
        List<User> GetsUserNotAssigned(string ModuleID, string GroupID);
        [OperationContract]
        List<UserGroupAssign> GetsUserAssigned(string Module, string Group);
        [OperationContract]
        User EditUser (User oUserBO);

        //...........................................................Module Object Zone...................................

        [OperationContract]
        List<ObjectSetup> GetUserObject(string empID, string moduleID);


        ///////////////-------------------------HR---------------------------////////////////////
        [OperationContract]
        EmployeeMaster GetEmpoyee(string empID);

        [OperationContract]
        User GetUser(string empID);

        [OperationContract]
        short UpdateUserPassword(User oUserBO);

        [OperationContract]
        List<AccessList> GetUserObjectList(string empID);

        [OperationContract]
        List<User> GetsAssignedUser(string ModuleID, string GroupID);
        [OperationContract]
         void SaveLoginHistory(AccessControl oAccessControlBO);
     
      }
}
