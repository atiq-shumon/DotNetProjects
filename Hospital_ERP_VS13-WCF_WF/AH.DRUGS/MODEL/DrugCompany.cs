using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.DRUGS.MODEL
{
    public class DrugCompany
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Address { set; get; }
        public string Web { set; get; }
        public string Phone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
