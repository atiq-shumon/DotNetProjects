using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DTMS.MODEL
{
    public class DiagPackage
    {
        public string PackageID { set; get; }
        public string PackageTitle { set; get; }
        public string PackageTitleBeng { set; get; }
        public string Remarks { set; get; }
        public double PackageAmount { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
