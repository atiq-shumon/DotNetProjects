using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeMaster : Staff
    {
        public EmployeeJobInformation EmployeeJobInformation { set; get; }
        public string EmpId { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public string EmpNameBeng { set; get; }
        public string NickName { set; get; }       
        public string Nationality { set; get; }
        public string PhotoPath { set; get; }
        public string SignaturePath { set; get; }
        public string CompanyId { set; get; }
        public string JobType { set; get; }
        public string RecruitmentType { set; get; }
        public string EmpClass { set; get; }
        public DateTime? DOC { get; set; }
        public DateTime? DOR { get; set; }
        public string CurrentJobStatus { set; get; }
        public string ConfirmFlag { set; get; }
        public string PfMember { set; get; }
        public string GratuityMember { set; get; }
        public string BankAccNo { set; get; }
        public string PfAccNo { set; get; }
        public string TIN { set; get; }
        public string Passport { set; get; }
        public string InsuranceNo { set; get; }
        public string PersonalEmail { set; get; }       
        public string SalFlag { set; get; }
        public DateTime? SalFlagChangeDt { set; get; }
        public string SalScaleID { set; get; }
        public string SalGradeID { set; get; }
        public string ConsolidateScaleFlag { set; get; }
        public double ConsolidatedAmount { set; get; }
        public DateTime? DOJ { set; get; }
        public string Reff1 { set; get; }
        public string Reff2 { set; get; }
        public string DeptId { set; get; }
        public string DeptTitle { set; get; }
        public string EmployeeType { set; get; }
        public string IntercomNumber { set; get; }
        public string AttnCardNumber { set; get; }
        public string FringeBenefitGrp { set; get; }
        public string BankID{ set; get; }
        public double Age { set; get; }
        public string RosterString { set; get; }
        public string IsSentToDropList { set; get; }
        public SalaryCycle SalaryCycle { set; get; }
        public Shift Shift { set; get; }
        public PayrollBase PayrollBase { set; get; }
        
    }
}
