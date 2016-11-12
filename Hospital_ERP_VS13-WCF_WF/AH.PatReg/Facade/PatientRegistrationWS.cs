using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.PatReg.MODEL;
using AH.PatReg.BLL;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.HR.BLL;
using AH.APPOPD.MODEL;
using AH.APPOPD.BLL;
using AH.ORGMS.MODEL;
using AH.ORGMS.BLL;

namespace AH.PatReg.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PatientRegistrationWS" in both code and config file together.
    public class PatientRegistrationWS : IPatientRegistrationWS
    {
        //public string SavePatient(Patient patObj,OPDPayment payment)
        //{
        //    return new PatientRegistrationBLL().Save(patObj,payment);
        //}
        public string SavePatient(Patient patObj)
        {
            return new PatientRegistrationBLL().Save(patObj);
        }

        public short UpdatePatientDetails(Patient pat)
        {
            return new PatientRegistrationBLL().UpdatePatientDetails(pat);
        }

        public string PatientCardIssue(OPDPayment payment)
        {
            return new PatientRegistrationBLL().PatientCardIssue(payment);
        }
        public string VerifyPatientNo(string patNo)
        {
            return new PatientRegistrationBLL().VerifyPatientNo(patNo);
        }
        public List<Patient> GetPatients(string pId)
        {
            List<Patient> pat = new PatientRegistrationBLL().GetPatients(pId);
            return pat;
        }
        public Patient GetStaffTypePatient(string staffID, string isStaffSelf)
        {
           return new PatientRegistrationBLL().GetStaffTypePatient(staffID, isStaffSelf);
        }

        public Patient GetPatient(string pId)
        {
            return new PatientRegistrationBLL().GetPatient(pId);
        }
        public List<string> GetNamePrefixes(string prefix)
        {
            return new PatientRegistrationBLL().GetNamePrefixes(prefix);
        }
        public Dictionary<String, String> GetBloodGroups()
        {
            return new PatientRegistrationBLL().GetBloodGroups();
        }
        
        public Dictionary<String, String> GetSexes()
        {
            return new PatientRegistrationBLL().GetSexes();
        }
        public Dictionary<String, String> GetReligions()
        {
            return new PatientRegistrationBLL().GetReligions();
        }

        public Dictionary<String, String> GetEducationLevels()
        {
            return new PatientRegistrationBLL().GetEducationLevels();
        }
        public Dictionary<short, String> GetOccupations()
        {
            return new PatientRegistrationBLL().GetOccupations();
        }
        public Dictionary<short, String> GetIncomeGroups()
        {
            return new PatientRegistrationBLL().GetIncomeGroups();
        }
        public Dictionary<short, String> GetMaritalStatus()
        {
            return new PatientRegistrationBLL().GetMaritalStatus();
        }
        public Dictionary<short, string> GetRelationships()
        {
            return new PatientRegistrationBLL().GetRelationships();
        }

        public List<string> GetDistricts()
        {
            return new PatientRegistrationBLL().GetDistricts();
        }

        public List<string> GetThanas()
        {
            return new PatientRegistrationBLL().GetThanas();
        }

        public string GetStaff(string id)
        {
            return "";
            // return new PatientRegistrationBLL().GetStaff(id);
        }

        public EmployeeMaster GetEmpMaster(string ID)
        {
            return new EmployeeSetUpBLL().GetEmpMaster(ID);
        }

        public EmployeeMaster GetEmployeeMaster(string ID)
        {
            return new EmployeeSetUpBLL().GetEmployeeMaster(ID);
        }

        public List<EmployeeDependent> GetEmpDependent(string emp)
        {
            return new EmployeeInformationSetupBLL().GetEmpDependent(emp);
        }

        public DateTime GetDOB(DateTime sysDate, short age, string ageIndicator)
        {
            return new PatientRegistrationBLL().GetDOB(sysDate, age, ageIndicator);
        }
        public Dictionary<string, string> GetAgeIndicators()
        {
            return new PatientRegistrationBLL().GetAgeIndicators();
        }
        public List<Patient> ViewList()
        {
            return new PatientRegistrationBLL().ViewList();
        }
        //Report
        public List<PatRegRO> GetPatientRegistartionDetailsbyHCN(string WhereCondition)
        {
            return new PetRegReportBLL().GetPatientRegistartionDetailsbyHCN(WhereCondition);
        }

        public List<PatRegRO> GetPatientRegistartionDetailsbyDateRange(string WhereCondition)
        {
            return new PetRegReportBLL().GetPatientRegistartionDetailsbyDateRange(WhereCondition);
        }

        public List<PatRegRO> GetPatientRegistartionDetails()
        {
            return new PetRegReportBLL().GetPatientRegistartionDetails();
        }

        public List<PatRegRO> PatientAdvanceSearch(string WhereCondition)
        { 
           return new PetRegReportBLL().PatientAdvanceSearch(WhereCondition);
        }

        public short SaveStaffType(StaffType sType)
        {
            return new PatientRegistrationBLL().SaveStaffType(sType);
        }
        public short UpdateStaffType(StaffType sType)
        {
            return new PatientRegistrationBLL().UpdateStaffType(sType);
        }

        public List<StaffType> getStaffType()
        {
            return new PatientRegistrationBLL().getStaffType();
        }

        public Dictionary<string, string> getStaffTypeDic(string type)
        {
            return new PatientRegistrationBLL().getStaffTypeDic(type);
        }

        public List<Patient> GetPatientsDetails()
        {
            return new PatientRegistrationBLL().GetPatientsDetails();
        }
        public List<Patient> GetPatientDetails(string name, string cell)
        {
            return new PatientRegistrationBLL().GetPatientDetails(name,cell);
        }

        public List<Patient> GetPatientDetailsAppointment(string parameter)
        {
            return new PatientRegistrationBLL().GetPatientDetailsAppointment(parameter);
        }

        public List<OpdAppointment> GetPatientListForHcn()
        {
            return new AppointmentBLL().GetPatientListForHcn();
        }

        public Dictionary<string, string> GetDistrictDict(string type)
        {
            return new AdministrationSetupBLL().GetDistrictDict(type);
        }

        public List<DistrictThana> GetDistrictAndThana()
        {
            return new AdministrationSetupBLL().GetDistrictAndThana();
        }

        public List<Patient> SearchPatients(string DOB, string name = "", string fname = "", string cell = "")
        {
            return new PatientRegistrationBLL().SearchPatients(DOB,name, fname, cell);
        }

        public short SaveCorpType(CorporateType corpType)
        {
            return new PatientRegistrationBLL().SaveCorpType(corpType);
        }
        public short UpdateCorpType(CorporateType corpType)
        {
            return new PatientRegistrationBLL().UpdateCorpType(corpType);
        }

        public List<CorporateType> GetCorpTypes()
        {
            return new PatientRegistrationBLL().GetCorpTypes();
        }

        public Dictionary<string, string> GetCorpTypeDic(string type)
        {
            return new PatientRegistrationBLL().GetCorpTypeDic(type);
        }

        public List<Patient> VerifyMobileOldORNew(string mobile_number)
        {
            return new PatientRegistrationBLL().VerifyMobileOldORNew(mobile_number);
        }

    }
}
