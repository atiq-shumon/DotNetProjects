using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class PRReportRO
    {
        public string PRID { set; get; }
        public DateTime PRDATE { set; get; }
        public string PHARMACYID { set; get; }
        public string PHARMACYNAME { set; get; }
        public float Qty { set; get; }
        public string REMARKS { set; get; }
        public float LPRATE { set; get; }
        public string LPDATE { set; get; }
        public float CURRENTSTOCK { set; get; }
        public string EntryById { set; get; }
        public string EntryByName { set; get; }
        public string DRUGID { set; get; }
        public string DRUGNAME { set; get; }
        public string COMPANYID { set; get; }
        public string COMPANYNAME { set; get; }
        public string GROUPID { set; get; }
        public string GROUPNAME { set; get; }
        public string UNITID { set; get; }
        public string UNITNAME { set; get; }
        public string PACKTYPEID { set; get; }
        public string TYPENAME { set; get; }



    }
}
