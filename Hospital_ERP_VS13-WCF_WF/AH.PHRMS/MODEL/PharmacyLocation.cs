using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;



namespace AH.PHRMS.MODEL
{
    public class Pharmacy
    {
        public string PharmacyID { set; get; }
        public string PharmacyTitle { set; get; }
        public string Phone { set; get; }
        public string ContactPerson { set; get; }
        public string Remarks { set; get; }
        public string Priority { set; get; }
        public string Block { set; get; }
        public Building Building { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
