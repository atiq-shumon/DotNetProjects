using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ATMS.MODEL
{
    public class AssetsGroup
    {
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string PrimaryName { get; set; }
        public string group_only_name { get; set; }
        public Int16 Level { get; set; }
        public Int16 grtype { get; set; }
        public string FormName { get; set; }
        public int intMode { get; set; }
        public EntryParameter EntryParameter { set; get; }

    }
}
