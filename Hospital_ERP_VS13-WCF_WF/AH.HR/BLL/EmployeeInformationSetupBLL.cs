using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;



namespace AH.HR.BLL
{
    public class EmployeeInformationSetupBLL
    {
        public short SaveEmployeeJobInformation(EmployeeJobInformation oEmpJobInfo)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeJobInformation(oEmpJobInfo);
        }
        public List<EmployeeJobInformation> GetEmployeeFringeBenefit()
        {
            return new EmployeeInformationSetupDAL().GetEmployeeFringeBenefit();
        }
        public Dictionary<string, string> GetEmployeeDictionary(string id,string name)  //dictionary type 
        {
            Dictionary<string, string> EmpDic = new Dictionary<string, string>();
            EmpDic.Add("", "--Select--");
            foreach (EmployeeMaster Emp in new EmployeeInformationSetupDAL().GetEmployeeDictionary())
            {
               EmpDic.Add(Emp.EmpId, Emp.EmpNameBeng);
            }

            return EmpDic;
        }
        public List<EmployeeJobInformation> GetEmployeeJobInfo()
        {
            return new EmployeeInformationSetupDAL().GetEmployeeJobInfo();
        }
        public List<EmployeeJobInformation> GetEmployeeJobInformation(string oEmpJobInfo)
        {
            return new EmployeeInformationSetupDAL().GetEmployeeJobInformation(oEmpJobInfo);
        }
        public EmployeeJobInformation GetEmployeeCurrentJobInformation(string oEmpJobInfo)
        {
            return new EmployeeInformationSetupDAL().GetEmployeeCurrentJobInformation(oEmpJobInfo);
        }
        public short UpdateEmployeeJobInformation(EmployeeJobInformation oEmpUpdateJob)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeJobInformation(oEmpUpdateJob);
        }

        public string SaveEmployeePreviousExperiencen(EmployeePreviousExperience oEmpPrevExp)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeePreviousExperiencen(oEmpPrevExp);
        }

        public List<EmployeePreviousExperience> GetEmployeePreviousExperience()
        {
            return new EmployeeInformationSetupDAL().GetEmployeePreviousExperience();
        }
        public List<EmployeePreviousExperience> GetEmpPreviousExperience(string emp)
        {
            return new EmployeeInformationSetupDAL().GetEmpPreviousExperience(emp);
        }


        public short UpdateEmployeePreviousExperience(EmployeePreviousExperience oEmpUpdatePrevExp)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeePreviousExperience(oEmpUpdatePrevExp);
        }

        //-------------------------

        public short SaveEmployeeTraining(EmployeeTraining oEmpTraning)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeTraining(oEmpTraning);
        }

        public List<EmployeeTraining> GetEmployeeTraining()
        {
            return new EmployeeInformationSetupDAL().GetEmployeeTraining();
        }
        public List<EmployeeTraining> GetEmpTraining(string emp)
        {
            return new EmployeeInformationSetupDAL().GetEmpTraining(emp);
        }

        public short UpdateEmployeeTraining(EmployeeTraining oEmpUpdateTran)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeTraining(oEmpUpdateTran);
        }
        //---------------------------

        public Dictionary<string, string> GetEmp(string type)
        {
            Dictionary<string, string> oEMPDic = new Dictionary<string, string>();
            oEMPDic.Add("", "--Select--");
            foreach (EmployeeMaster sal in new EmployeeInformationSetupDAL().GetEmp())
            {
                oEMPDic.Add(sal.EmpId, sal.EmpNameBeng);
            }

            return oEMPDic;
        }

        public short SaveBenefitType(FringeBenefit oBenType)
        {
            return new EmployeeInformationSetupDAL().SaveBenefitType(oBenType);
        }

        public List<FringeBenefit> GetBenefitType()
        {
            return new EmployeeInformationSetupDAL().GetBenefitType();
        }
        public Dictionary<string, string> GetBenefitDict(string type)
        {
            Dictionary<string, string> oEMPDic = new Dictionary<string, string>();
            oEMPDic.Add("", "--Select--");
            foreach (FringeBenefit sal in new EmployeeInformationSetupDAL().GetBenefitType())
            {
                oEMPDic.Add(sal.BenID, sal.BenTitle);
            }

            return oEMPDic;
        }
        public List<FringeBenefit> CheckBenefitType(string Benefit)
        {
            return new EmployeeInformationSetupDAL().CheckBenefitType(Benefit);
        }
        public short UpdateBenefitType(FringeBenefit oBenType)
        {
            return new EmployeeInformationSetupDAL().UpdateBenefitType(oBenType);
        }
        public short SaveEmployeeDependent(EmployeeDependent oEmpDep)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeDependent(oEmpDep);
        }
        public List<EmployeeDependent> GetEmployeeDependent()
        {
            return new EmployeeInformationSetupDAL().GetEmployeeDependent();
        }
        public List<EmployeeDependent> GetEmpDependent(string emp)
        {
            return new EmployeeInformationSetupDAL().GetEmpDependent(emp);
        }
        public Dictionary<string, string> GetEmployeeDependent(string type)
        {
            Dictionary<string, string> oEMPDic = new Dictionary<string, string>();
            oEMPDic.Add("", "--Select--");
            foreach (EmployeeDependent sal in new EmployeeInformationSetupDAL().GetEmpDependent(type))
            {
                oEMPDic.Add(sal.DependID, sal.DependName);
            }

            return oEMPDic;
        }
        public short UpdateEmployeeDependent(EmployeeDependent oEmpDep)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeDependent(oEmpDep);
        }
        public short SaveEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeMedicalInformation(oEmpDep);
        }
        public short UpdateEmployeeMedicalInformation(EmployeeMedicalInfo oEmpDep)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeMedicalInformation(oEmpDep);
        }
        public List<EmployeeMedicalInfo> GetEmployeeMedicalInformation(string emp)
        {
            return new EmployeeInformationSetupDAL().GetEmployeeMedicalInformation(emp);
        }
        public short SavePunishmentType(PunishmentType oPunType)
        {
            return new EmployeeInformationSetupDAL().SavePunishmentType(oPunType);
        }
        public short UpdatePunishmentType(PunishmentType oPunType)
        {
            return new EmployeeInformationSetupDAL().UpdatePunishmentType(oPunType);
        }
        public List<PunishmentType> GetPunishmentType()
        {
            return new EmployeeInformationSetupDAL().GetPunishmentType();
        }
        public List<PunishmentType> CheckPunishmentType(string Punishment)
        {
            return new EmployeeInformationSetupDAL().CheckPunishmentType(Punishment);
        }
        public Dictionary<string, string> GetPunishmentDict(string type)
        {
            Dictionary<string, string> oEMPDic = new Dictionary<string, string>();
            oEMPDic.Add("", "--Select--");
            foreach (PunishmentType sal in new EmployeeInformationSetupDAL().GetPunishmentType())
            {
                oEMPDic.Add(sal.PunID, sal.PunTitle);
            }

            return oEMPDic;
        }
        public short SaveEmpPunishmentSetup(PunishmentType oPunType)
        {
            return new EmployeeInformationSetupDAL().SaveEmpPunishmentSetup(oPunType);
        }
        public short UpdateEmpPunishmentSetup(PunishmentType oPunType)
        {
            return new EmployeeInformationSetupDAL().UpdateEmpPunishmentSetup(oPunType);
        }
        public List<PunishmentType> GetEmpPunishmentType(string EmpId)
        {
            return new EmployeeInformationSetupDAL().GetEmpPunishmentType(EmpId);
        }
        public short SaveNomineeInformation(Nominee oNominee)
        {
            return new EmployeeInformationSetupDAL().SaveNomineeInformation(oNominee);
        }
        public short UpdateNomineeInformation(Nominee oNominee)
        {
            return new EmployeeInformationSetupDAL().UpdateNomineeInformation(oNominee);
        }
        public List<Nominee> GetNomineeInformation(string EmpID)
        {
            return new EmployeeInformationSetupDAL().GetNomineeInformation(EmpID);
        }
        public List<Nominee> GetNomineeInfo()
        {
            return new EmployeeInformationSetupDAL().GetNomineeInfo();
        }
        public List<EmployeeMaster> GetEmpGender(string EmpID)
        {
            return new EmployeeInformationSetupDAL().GetEmpGender(EmpID);
        }
        public short SaveEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeDropList(oEmployeeDropList);
        }
        public short UpdateEmployeeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeDropList(oEmployeeDropList);
        }
        public short UpdateFinalizeDropList(EmployeeDropList oEmployeeDropList)
        {
            return new EmployeeInformationSetupDAL().UpdateFinalizeDropList(oEmployeeDropList);
        }
        public List<EmployeeDropList> GetEmpDropList()
        {
            return new EmployeeInformationSetupDAL().GetEmpDropList();
        }
        public List<EmployeeDropList> GetEmpDropListForFinalize()
        {
            return new EmployeeInformationSetupDAL().GetEmpDropListForFinalize();
        }
        public short SaveEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            return new EmployeeInformationSetupDAL().SaveEmployeeDegreeSetup(oEmpDegree);
        }
        public short UpdateEmployeeDegreeSetup(EmployeeDegree oEmpDegree)
        {
            return new EmployeeInformationSetupDAL().UpdateEmployeeDegreeSetup(oEmpDegree);
        }
        public List<EmployeeDegree> GetAllEmployeeDegree()
        {
            return new EmployeeInformationSetupDAL().GetAllEmployeeDegree();
        }
        public List<EmployeeDegree> GetEmployeeDegreeSetup(string EmpID)
        {
            return new EmployeeInformationSetupDAL().GetEmployeeDegreeSetup(EmpID);
        }
        public List<EmployeeDropList> GetDropListByType(string DropType)
        {
            return new EmployeeInformationSetupDAL().GetDropListByType(DropType);
        }
        public List<EmployeeDropList> GetEmpDropListForFinalizeByType(string DropType)
        {
            return new EmployeeInformationSetupDAL().GetEmpDropListForFinalizeByType(DropType);
        }
        public List<EmployeeDropList> GetCompletedFinalizedList(string DropType)
        {
            return new EmployeeInformationSetupDAL().GetCompletedFinalizedList(DropType);
        }
    }
}
