using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class ClinicalFindingsValueAssign
    {
        public string FindingsID { set; get; }
        public string FindingsTitle { set; get; }
        public string FindingsGrpID { set; get; }
        public string FindingsValID { set; get; }
        public string FindingsValTitle { set; get; }
        public string FindingsValDetails { set; get; }
        public string AssignedFindingsValue { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}