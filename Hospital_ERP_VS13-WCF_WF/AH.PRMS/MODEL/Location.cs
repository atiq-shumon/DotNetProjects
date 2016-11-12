using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class Location
    {
        public Company Company { set; get; }
        public string LocationID { set; get; }
        public string LocationTitle { set; get; }
        public string LocationTitleBeng { set; get; }
        public string Address { set; get; }
        public string AddressBeng { set; get; }
        public short Serial { set; get; }
        public string WebAddress { set; get; }
        public string PhoneNos { set; get; }
        public string Fax { set; get; }
        public string EMail { set; get; }
        public EntryParameter EntryParameter { set; get; }

    }
}
