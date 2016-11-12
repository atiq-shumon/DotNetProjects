using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class AppointmentRO
    {
        public string RefferenceNumber { set; get; }
        public string AppointTemplType { set; get; }
        public string IssueDate { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Address { set; get; }
        public string AddressBeng { set; get; }
        public string ContractPeriod { set; get; }
        public string ContractUpto { set; get; }
        public string DOJWithin { set; get; }
        public string EffectFrom { set; get; }
        public string ConssolidateAmount { set; get; }
        public string ProbationPeriod { set; get; }
        public string ComplianceWith { set; get; }
        public string CCList { set; get; }
        public string HRManagerID { set; get; }
        public string HRManagerName { set; get; }
        public string PreparedBy { set; get; }
        public string PreparedByName { set; get; }
        public string DeptTypeID { set; get; }
        public string DeptGrpID { set; get; }
        public string DeptID { set; get; }
        public string UnitID { set; get; }
        public string DesigID { set; get; }
        public string DesigTitle { set; get; }
        public string JobType { set; get; }
        public string RecruitmentType { set; get; }
    }
}
