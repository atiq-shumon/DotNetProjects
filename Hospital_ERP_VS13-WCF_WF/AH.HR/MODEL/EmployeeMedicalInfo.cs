using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeMedicalInfo
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string MedicalReportSerial { set; get; }
        public string EyeSight { set; get; }
        public string Height { set; get; }
        public string weight { set; get; }
        public string Disabilities { set; get; }
        public string IsDiabetics { set; get; }
        public string BloodGrp { set; get; }
        public string BP { set; get; }
        public string XrayReport { set; get; }
        public string EcgReport { set; get; }
        public string Mark { set; get; }
        public string ReportDate { set; get; }
        public EntryParameter EntryParameter { set; get; }
        
    }
}
