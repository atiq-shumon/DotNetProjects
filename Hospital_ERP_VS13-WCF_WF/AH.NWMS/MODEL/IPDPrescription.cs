using AH.DRUGS.MODEL;
using AH.DTMS.MODEL;
using AH.HR.MODEL;
using AH.IPDShared.MODEL;
using AH.OPD.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AH.NWMS.MODEL
{
    public class IPDPrescription 
    {
        public string DocVisitID {set; get;}
        public OPDDoctorCallQ OPDPatInfo { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public Prescription Prescription { set; get; }
        public DrugDose Drugs { set; get; }
        public TestSub Tests { set; get; }
        public OPDAdvice Advice { set; get; }
        public InPatient Patient { set; get; }
        public IPDDoctor IPDDoctor { set; get; }
        public string RefDeptGrp { get; set; }
        public string VisitToDeptGrpID { set; get; }
        public string VisitToDeptID { get; set; }
        public string VisitToDeptUnitID { get; set; }
        public string VisitToDocID { set; get; }

        public string DietAdvice { set; get; }
        public string DischargeStatus { get; set; }
        public string DischargeType { get; set; }
        public string DischargeDiagnosis { set; get; }
        public string CaseSummary { set; get; }
        public string HospitalCourse{ set; get; }
        public string OperationNote{ set; get; }
    }
}
