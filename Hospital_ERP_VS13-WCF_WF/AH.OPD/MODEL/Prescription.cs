using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.HR.MODEL;
using AH.DTMS.MODEL;
using AH.DRUGS.MODEL;

namespace AH.OPD.MODEL
{
    public class Prescription : Ticket
    {
        public string Height { set; get; }
        public string Weight { set; get; }
        public string Bp { set; get; }
        public string Temparature { set; get; }
        public string Advice { set; get; }
        public string PackageName { set; get; }
        public string CollTests { set; get; }
        public string Medicine { set; get; }
        public string Complaints { set; get; }
        public string OtherComplaints { set; get; }
        public string ClinicalDiagnosis { set; get;}
        public string ClinicalFindings { set; get; }
        public string comorbidIllness { set; get; }
        public string paediatricHis { set; get; }
        public string GynHis { set; get; }
        public string Refered { set; get; }
        public Department RefDeptID { set; get; }
        public DepartmentUnit RefUnitID { set; get; }
        public Doctor RefDocID { set; get; }

        public OPDDoctorCallQ OPDDoctorCallQ { get; set; }
       
        public ClinicalFindingsValueAssign CFValAssign { set; get; }
        public List<ClinicalFindingsValueAssign> CFValAssignList { set; get; }

        public List<Complaints> OtherComplaintsList { set; get; }
        public List<Complaints> ComplaintsList { set; get; }
        public List<ClinicalDiagnosis> ClinicalDiagnosisList { set; get; }       
        public List<TestSub> TestsList { set; get; }
        public List<DrugDose> DrugsList { set; get; }
        public List<OPDAdvice> AdvicesList { set; get; }
    }
}
