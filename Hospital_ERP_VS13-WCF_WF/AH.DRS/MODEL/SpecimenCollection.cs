using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;
//using AH.PatReg.MODEL;
using AH.HR.MODEL;
using AH.DMS.MODEL;
using AH.DTMS.MODEL;
using AH.IPDShared.MODEL;

namespace AH.DRS.MODEL
{
    public class SpecimenCollection
    {
        public string result_id { get; set; }
        public string SpecimenCollectionID { set; get; }
        public Specimen Specimen { set; get; }
        public SpecimenHolder SpecimenHolder { set; get; }
        public InPatient Patient { set; get; }
        public SpecimenCollector SpecimenCollector { set; get; }
        public LabTechnologist LabTechnologist { set; get; }
        public ReportGroup ReportGroup { set; get; }
        public LabRoom LabRoom { set; get; }
        public string ReportPriority { set; get; }
        public DiagnosticMR DiagnosticMR { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public List<TestFee> Tests { set; get; }
        public string  TestTitle { set; get; }
        public string TestDetailsID { set; get; }
        public string CollTests { get; set; }
        public string Remarks { set; get; }
        public DateTime ReportDeliveryDate { set; get; }       
    }
}
