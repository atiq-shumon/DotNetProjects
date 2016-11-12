using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPRMS.MODEL
{
    public class OperationMaster
    {
        public string OperationID { set; get; }
        public string operationTitle { set; get; }
        public string operationTitleBang { set; get; }
        public string OperationTypeCode { set; get; }
        public string GradeID { set; get; }
        public string Anesthesiatitle { set; get; }
        public double OperationFees { set; get; }
        public double DrFees { set; get; }
        public double AnesFees { set; get; }
        public double AssistantFees { set; get; }
        public double  ExpectedTimeHour { set; get; }
        public string Remarks { set; get; }
        public string Active { set; get; }
        public string RegId { set; get; }
        public string RegName { set; get; }
        public string PackageName { set; get; }
        public string PackageNo { set; get; }
        public string OprSubMenu { set; get; }


        public EntryParameter EntryParameter { set; get; }
    }
}
