using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class Appointment
    {
        public EmployeeJobInformation EmployeeJobInformation { set; get; }
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
        public EntryParameter EntryParameter { set; get; }
    }
}
