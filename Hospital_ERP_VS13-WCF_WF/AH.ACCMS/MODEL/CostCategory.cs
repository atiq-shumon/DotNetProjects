using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
    public class CostCategory
    {
        public string Categorycode { set; get; }
        public string Categoryname { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
