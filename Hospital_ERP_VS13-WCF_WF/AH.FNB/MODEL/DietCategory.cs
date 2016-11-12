using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;


namespace AH.FNB.MODEL
{
    public class DietCategory
    {
        public string dietID { set; get; }
        public string dietcatName { set; get; }
        public string remarks { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
