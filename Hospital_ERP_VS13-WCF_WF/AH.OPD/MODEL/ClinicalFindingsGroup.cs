using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class ClinicalFindingsGroup
    {
        public string CfGrpID { set; get; }
        public string CfGrpTitle { set; get; }
        public string CfGrpTitleBeng { set; get; }
        public string CfGrpCategory { set; get; }
        public string Remarks { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }

        public EntryParameter EntryParameter { set; get; }
    }
}
