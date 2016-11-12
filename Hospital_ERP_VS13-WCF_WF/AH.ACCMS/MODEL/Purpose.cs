using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.ACCMS.MODEL
{
    public class Purpose
    {
        public string PurposeID { set; get; }
        public string PurposeTitle { set; get; }
        public string PurposeTitleBeng { set; get; }
        public string Purposecategory { set; get; }
        public string PurposecategoryName { set; get; }
        public string GrpID { set; get; }
        public string GrpName { set; get; }
        public string TypeID { set; get; }
        public string TypeName { set; get; }

        public COA COA { set; get; }
        public string  Codeallocation { set; get; }
        public EntryParameter EntryParameter { set; get; }
    }
    public class Branch
    {
        public string BranchID { set; get; }
        public string BranchName { set; get; }
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string CountryName { set; get; }
        public string PhoneNo { set; get; }
        public string Fax { set; get; }
        public int BranchFlag { set; get; }
        public string Comments { set; get; }
        public int  intDefaultFlag { set; get; }
        public EntryParameter EntryParameter { set; get; }
    
    }
   

}
