using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.PRMS.MODEL
{
    public class Company
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string LogoPath { set; get; }
        public string Slogan { set; get; }
        public string SloganBeng { set; get; }
        public string Address { set; get; }
        public string AddressBeng { set; get; }
        public string WebSiteAddress { set; get; }
        public string PhoneNos { set; get; }
        public string Fax { set; get; }
        public string EMail { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
