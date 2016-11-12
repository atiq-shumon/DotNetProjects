using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class ClinicalFindings
    {
        public string GrpCategoryID { set; get; }
        public string GrpCategoryTitle { set; get; }
        public string FindingsGrpID { set; get; }
        public string FindingsGrpTitle { set; get; }
        public string FindingsID { get; set; }
        public string FindingsParentID { set; get; }
        public string FindingsParentTitle { set; get; }
        public string FindingsTitle { get; set; }
        public string FindingsTitleBeng { set; get; }
        public string FindingsLevel { set; get; }
        public string Remarks { set; get; }
        public Department Department { set; get; }
        public DepartmentUnit DepartmentUnit { set; get; }

        public EntryParameter EntryParameter { set; get; }
    }
}
