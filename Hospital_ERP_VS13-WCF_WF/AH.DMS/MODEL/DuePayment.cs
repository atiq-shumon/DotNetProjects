using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.DMS.MODEL
{
    public class DuePayment
    {
        public DiagnosticMR DiagnosticMR { set; get; }
        public OPDPayment OPDPayment { set; get; }
        public decimal PaidAmt { set; get; }
        public string RevHdGrp { set; get; }
        public string RevHd { set; get; }
        public string StaffId { set; get; }
        public string PurposeId { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
