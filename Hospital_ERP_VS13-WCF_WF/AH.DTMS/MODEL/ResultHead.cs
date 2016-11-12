using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
//using AH.DMS.MODEL;
using AH.DTMS.MODEL;

namespace AH.DTMS.MODEL
{
    public class ResultHead
    {
        public string ResultHeadID { set; get; }
        public string ResultHeadTitle { set; get; }
        public string ResultHeadTitleBeng { set; get; }
        public string ResultValue { set; get; }
        public string GenderSentitive { set; get; }
        public string QualitiveFlag { set; get; }
        public string QualitiveGroup { set; get; }
        public ReportGroup ReportGroup { set; get; }
        public ResultHeadUnit ResultHeadUnit { set; get; }
        public ResultHeadGroup ResultGroup { set; get; }
        public ReportSection ReportSection { set; get; }
        public string LowerRange { set; get; }
        public string UpperRange { set; get; }
        public string LowerRangeMale { set; get; }
        public string UpperRangeMale { set; get; }
        public string LowerRangeFeMale { set; get; }
        public string UpperRangeFeMale { set; get; }
        public string LowerRangeChild { set; get; }
        public string UpperRangeChild { set; get; }
        public string RangeText { set; get; }
        public string Remarks { set; get; }
        public decimal Serial { set; get; }
        public decimal HdGrpSerial { set; get; }
        public Machine Machine { set; get; }
        public string MachineString { set; get; }
        public string IsLisSyn { set; get; }
        public string DefaultValue { set; get; }
        public string InterpretationText { set; get; }
        public string InterpretationFlag { set; get; }
        public string SpecimenID { set; get; }
        public TestSub TestSub { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
