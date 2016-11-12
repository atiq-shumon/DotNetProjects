using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DMS.MODEL;
using AH.DTMS.MODEL;
using AH.IPDShared.MODEL;

namespace AH.DRS.MODEL
{
    public class DiagnosticReport
    {
        public InPatient Patient { set; get; }
        public Specimen Specimen { set; get; }
        public ResultHead head { set; get; }
        public List<ResultHead> heads { set; get; }
        public DiagnosticMR DiagnosticMR { set; get; }
        public SpecimenCollection SpecimenCollection { set; get; }
        public ReportGroup ReportGroup { set; get; }
        public string Advice { set; get; }
        public string Comments { set; get; }
        public string DraftResultID { set; get; }
        public string ResultID { set; get; }
        public string GrowthResultsA { set; get; }
        public string GrowthResultsB { set; get; }
        public string GrowthResultsC { set; get; }
        public short IsGrowth { set; get; }
        public string Tempareture { set; get; }
        public string Results { set; get; }
        public string ResultA { set; get; }
        public string ResultB { set; get; }
        public string ResultC { set; get; }
        public string TestDetailsID { set; get; }
        public string Age { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
