using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.HR.MODEL;
using AH.Shared.MODEL;

namespace AH.IPD.MODEL
{
    public class AdmReasonAssign
    {
        public Department Department { set; get; }
        public AdmissionReason AdmissionReason { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
