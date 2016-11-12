using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.HR.MODEL
{
    public class EmployeeDropList
    {
        public EmployeeMaster EmployeeMaster { set; get; }
        public string ListSerial { set; get; }
        public string DropTypeID { set; get; }
        public string DropDate { set; get; }
        public string DropEffectiveDate { set; get; }
        public string VerifiedBy { set; get; }
        public string VerifiedByName { set; get; }
        public string VerifiedDate { set; get; }
        public string FinalizeBy { set; get; }
        public string FinalizeDate { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
