using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class DiseaseCase
    {
        public string DiseaseGrpID { set; get; }
        public string DiseaseGrpTitle { set; get; }
        public string CaseID { set; get; }
        public string CaseTitle { set; get; }
        public string CaseTitleBeng { set; get; }
        public string Remarks { set; get; }
        public string ShownCheckList { set; get; }
        public Department dept { set; get; }
        public DepartmentUnit deptUnit { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
