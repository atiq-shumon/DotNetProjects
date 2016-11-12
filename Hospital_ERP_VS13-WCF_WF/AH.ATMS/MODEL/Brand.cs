using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
    public class Brand
    {
        public string BrandID { set; get; }
        public string BrandName { set; get; }
        public string FormName { set; get; }
        public int intMode { get; set; }
        public string groupid { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
}
 