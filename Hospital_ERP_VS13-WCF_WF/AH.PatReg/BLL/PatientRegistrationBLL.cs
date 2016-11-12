using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.PatReg.MODEL;
using AH.PatReg.DAL;
using AH.Shared.MODEL;


namespace AH.PatReg.BLL
{
    public class PatientRegistrationBLL
    {
        //public string Save(Patient pat, OPDPayment payment)
        //{
        //    return new PatientRegistrationDAL().Insert(pat, payment).ToString();
        //}
        public string Save(Patient pat)
        {
            return new PatientRegistrationDAL().Insert(pat).ToString();
        }
        public short UpdatePatientDetails(Patient pat)
        {
            return new PatientRegistrationDAL().UpdatePatientDetails(pat);
        }

        public string PatientCardIssue(OPDPayment payment)
        {
            return new PatientRegistrationDAL().CardIssue(payment);
        }

        public string VerifyPatientNo(string patNo)
        {
            string res = new PatientRegistrationDAL().VerifyPatientNo(patNo);
            if (res == "0")
                res = "";
            return res;
        }

        public List<Patient> GetPatients(string pId)
        {
            List<Patient> pats = new List<Patient>();
            pats.Add(new PatientRegistrationDAL().GetPatient(pId));
            return pats;
        }
        public Patient GetStaffTypePatient(string staffID, string isStaffSelf)
        {
           return new PatientRegistrationDAL().GetStaffTypePatient(staffID, isStaffSelf);
        }
         

        public Patient GetPatient(string pId)
        {
            return new PatientRegistrationDAL().GetPatient(pId);
        }

        public List<string> GetNamePrefixes(string prefix)
        {
            return Utility.GetNamePrefixes(prefix);
        }
        public Dictionary<String, String> GetBloodGroups()
        {
            return Utility.GetBloodGroups();
        }
        public Dictionary<String, String> GetReligions()
        {
            return Utility.GetReligions();
        }
        public Dictionary<String, String> GetSexes()
        {
            return Utility.GetSexes();
        }

        public Dictionary<short, String> GetMaritalStatus()
        {
            return Utility.GetMaritalStatus();
        }
        public Dictionary<short, String> GetOccupations()
        {
            return Utility.GetOccupations();
        }

        public Dictionary<short, String> GetIncomeGroups()
        {
            return Utility.GetIncomeGroups();
        }
        public Dictionary<String, String> GetEducationLevels()
        {
            return Utility.GetEducationLevels();
        }

        public Dictionary<short, string> GetRelationships()
        {
            return Utility.GetRelationships();
        }

        //public Dictionary<short, string> get_staff_type_id()
        //{
        //    return Utility.get_staff_type_id();
        //}

        public List<string> GetDistricts()
        {
            return Utility.GetDistricts();
        }
        public List<string> GetThanas()
        {
            return Utility.GetThanas();
        }

        //public string GetStaff(string id)
        //{
        //    //return new StaffInformationDAL().GetStaff(id);
        //}

        public Dictionary<string, string> GetAgeIndicators()
        {
            return Utility.GetAgeIndicators();
        }

        public DateTime GetDOB(DateTime sysDate, short age, string ageIndicator)
        {
            return Utility.DOBGenerator(sysDate, age, ageIndicator);
        }
        public List<Patient> ViewList()
        {
            return new PatientRegistrationDAL().ViewList();
        }

        public short SaveStaffType(StaffType sType)
        {
            return new PatientRegistrationDAL().SaveStaffType(sType);
        }

        public List<StaffType> getStaffType()
        {
            return new PatientRegistrationDAL().getStaffType();
        }

        public Dictionary<string, string> getStaffTypeDic(string type)
        {
            Dictionary<string, string> adrsn = new Dictionary<string, string>();
            adrsn.Add("", "--Select--");
            foreach (StaffType adm in new PatientRegistrationDAL().getStaffType())
            {
                adrsn.Add(adm.TypeID, adm.TypeTitle);
            }
            return adrsn;
        }

        public short UpdateStaffType(StaffType sType)
        {
            return new PatientRegistrationDAL().UpdateStaffType(sType);
        }

        public List<Patient> GetPatientsDetails()
        {
            return new PatientRegistrationDAL().GetPatientsDetails();
        }
        public List<Patient> GetPatientDetails(string name, string cell)
        {
            return new PatientRegistrationDAL().GetPatientDetails(name,cell);
        }
        public List<Patient> GetPatientDetailsAppointment(string parameter)
        {
            return new PatientRegistrationDAL().GetPatientDetailsAppointment(parameter);
        }

        public List<Patient> SearchPatients(string DOB, string name = "", string fname = "", string cell = "")
        {
            return new PatientRegistrationDAL().SearchPatients(DOB, name, fname, cell);
        }
        public short SaveCorpType(CorporateType corpType)
        {
            return new PatientRegistrationDAL().SaveCorpType(corpType);
        }
        public short UpdateCorpType(CorporateType corpType)
        {
            return new PatientRegistrationDAL().UpdateCorpType(corpType);
        }
        public List<CorporateType> GetCorpTypes()
        {
            return new PatientRegistrationDAL().GetCorpTypes();
        }
        public Dictionary<string, string> GetCorpTypeDic(string type)
        {
            Dictionary<string, string> adrsn = new Dictionary<string, string>();
            adrsn.Add("", "--Select--");
            foreach (CorporateType adm in new PatientRegistrationDAL().GetCorpTypes())
            {
                adrsn.Add(adm.CorpID, adm.CorpTitle);
            }
            return adrsn;
        }

        //public List<EmployeeDependent> GetEmpDependent(string emp)
        //{
        //    return new EmployeeInformationSetupBLL().GetEmpDependent(emp);
        //}

        public List<Patient> VerifyMobileOldORNew(string mobile_number)
        {
            return new PatientRegistrationDAL().VerifyMobileOldORNew(mobile_number);
        }

    }
}
