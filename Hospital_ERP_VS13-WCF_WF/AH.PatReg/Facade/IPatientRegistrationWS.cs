using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PatReg.MODEL;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.HR.BLL;
using AH.APPOPD.MODEL;
using AH.ORGMS.MODEL;
using AH.ORGMS.BLL;


namespace AH.PatReg.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPatientRegistrationWS" in both code and config file together.
    [ServiceContract]
    public interface IPatientRegistrationWS
    {
        //[OperationContract]
        //string SavePatient(Patient patObj, OPDPayment payment);
        [OperationContract]
        string SavePatient(Patient patObj);
        [OperationContract]
        short UpdatePatientDetails(Patient pat);
        [OperationContract]
        string PatientCardIssue(OPDPayment payment);
        [OperationContract]
        string VerifyPatientNo(string patNo);
        [OperationContract]
        List<Patient> GetPatients(string pId);
        [OperationContract]
        Patient GetPatient(string pId);
        [OperationContract]
        Patient GetStaffTypePatient(string staffID, string isStaffSelf);
        [OperationContract]
        List<string> GetNamePrefixes(string prefix);
        [OperationContract]
        //List<string> GetBloodGroups();
        Dictionary<String, String> GetBloodGroups();
        [OperationContract]
        Dictionary<String, String> GetSexes();
        [OperationContract]
        Dictionary<String, String> GetReligions();
        [OperationContract]
        Dictionary<String, String> GetEducationLevels();
        [OperationContract]
        Dictionary<short, String> GetIncomeGroups();
        [OperationContract]
        Dictionary<short, String> GetMaritalStatus();
        [OperationContract]
        Dictionary<short, String> GetOccupations();
        [OperationContract]
        Dictionary<short, string> GetRelationships();
        [OperationContract]
        List<string> GetDistricts();
        [OperationContract]
        List<string> GetThanas();
        [OperationContract]
        string GetStaff(string id);
        [OperationContract]
        Dictionary<string, string> GetAgeIndicators();
        [OperationContract]
        DateTime GetDOB(DateTime sysDate, short age, string ageIndicator);

        [OperationContract]
        EmployeeMaster GetEmpMaster(string ID);

        [OperationContract]
        EmployeeMaster GetEmployeeMaster(string ID);
        [OperationContract]
        List<EmployeeDependent> GetEmpDependent(string emp);

        [OperationContract]
        List<Patient> ViewList();

        [OperationContract]
        List<PatRegRO> GetPatientRegistartionDetailsbyHCN(string WhereCondition);
        [OperationContract]
        List<PatRegRO> GetPatientRegistartionDetailsbyDateRange(string WhereCondition);
        [OperationContract]
        List<PatRegRO> GetPatientRegistartionDetails();
        [OperationContract]
        List<PatRegRO> PatientAdvanceSearch(string WhereCondition);

        [OperationContract]
        short SaveStaffType(StaffType sType);
        [OperationContract]
        short UpdateStaffType(StaffType sType);

        [OperationContract]
        List<StaffType> getStaffType();

        [OperationContract]
        Dictionary<string, string> getStaffTypeDic(string type);
        [OperationContract]
        List<Patient> GetPatientsDetails();

        [OperationContract]
        List<Patient> GetPatientDetails(string  name, string cell);

        [OperationContract]
        List<Patient> GetPatientDetailsAppointment(string parameter);

        [OperationContract]
        List<OpdAppointment> GetPatientListForHcn();

        [OperationContract]
        Dictionary<string, string> GetDistrictDict(string type);
         
        [OperationContract]
        List<DistrictThana> GetDistrictAndThana();
        [OperationContract]
        List<Patient> SearchPatients(string DOB, string name = "", string fname = "", string cell = "");

        [OperationContract]
        short SaveCorpType(CorporateType corpType);
        [OperationContract]
        short UpdateCorpType(CorporateType corpType);
        [OperationContract]        
        List<CorporateType> GetCorpTypes();

        [OperationContract]
        Dictionary<string, string> GetCorpTypeDic(string type);

        [OperationContract]
        List<Patient> VerifyMobileOldORNew(string mobile_number);
        //[OperationContract]
        //[OperationContract]
        //[OperationContract]
        //[OperationContract]

    }
}
