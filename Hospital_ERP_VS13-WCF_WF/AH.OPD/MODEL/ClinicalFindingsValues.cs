using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.OPD.MODEL
{
    public class ClinicalFindingsValues
    {
        public string FindingsValID { set; get; }
        public string FindingsValTitle { set; get; }
        public string FindingsValTitleBeng { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
