using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.ACCMS.MODEL
{
    public class GroupsConfig
    {
        public long Lngsllno {set; get; }
        public string GrName {set; get; }
        public string GrParent { set; get; }
        public string GrDefaultName { set; get; }
        public long Grlevel { set; get; }
        public string GrUnder {set; get; }
        public long GrPrimaryType {set; get; }
        public string GrNature {set; get; }
        public string GrCashFlow {set; get;}
        public long GrDefaultgroup {set; get;}
        public string Grcode { set; get; }
        public EntryParameter EntryParameter {set; get; }
    }
}
