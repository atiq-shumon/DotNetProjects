using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AH.Shared.MODEL;
using AH.HR.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeJobInformation
    {
        public EmployeeMaster EmployeeMaster { get; set; }

        public FringeBenefit FringeBenefit { set; get; }
        public DeptUnitAss DeptUnitAss { get; set; }
        public Department Department{ get; set; }
        public DepartmentGroup DepartmentGroup { get; set; }
        public DepartmentUnit DepartmentUnit { get; set; }
        public Designation Designation { get; set; }
        public DesignationGroup DesignationGroup { get; set; }
        public string Class { get; set; }
        public string JobType{ get; set; }
        public string RecruitmentType { get; set; }
        public string DeptHead { get; set; }
        public string DeptHeadName { get; set; }
        public string ReportingPerson { get; set; }
        public string ReportingPersonName { get; set; }
        public string DOJAsHead { set; get; }
        public string HeadString { set; get; }
        public string FoodSubsidy { set; get; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RetireDate { get; set; }
        public DateTime? TransferDate { get; set; }
        public string ServiceBookReffNo { get; set; }
        public string JobDesc { get; set; }
        public string JobUpdateCauseType { get; set; }
        public string Responsibilities { get; set; }

        public string OfficeOrderNo { get; set; }
        public string ConsolidateScaleFlag { get; set; }
        public double ConsolidatedAmount { get; set; }
        public string SalGradeID { get; set; }
        public string SalScaleID { get; set; }
        public string SerialNo { set; get; }
        public string BenefitString { set; get; }

        public EntryParameter Entryparameter { get; set; }

    }
}
