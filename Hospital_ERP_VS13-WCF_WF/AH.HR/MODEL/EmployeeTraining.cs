using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;



namespace AH.HR.MODEL
{
    public class EmployeeTraining
    {
        public EmployeeMaster EmployeeMaster { get; set; }
        public string Serial { set; get; }
        public string TrainingTitle { get; set; }
        public string TrainingType { get; set; }
        public string OrganizationName { get; set; }
        public string ProvidedBy { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Grade { get; set; }
        public string Remarks { get; set; }
        public EntryParameter EntryParameter { get; set; }
    }
}
