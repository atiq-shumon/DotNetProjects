using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;


namespace AH.INVMS.MODEL
{
    public class StoreLocation
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string ContactPerson { set; get; }
        public string Remarks { set; get; }
        public string Priority { set; get; }
        public string Block { set; get; }
        public StoreTypeSCM StoreType { set; get; }
        public Building Building { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
