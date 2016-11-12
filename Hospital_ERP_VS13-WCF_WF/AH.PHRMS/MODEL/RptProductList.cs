using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.Shared.MODEL;
using AH.OracleManager;
using AH.DUtility;
namespace AH.PHRMS.MODEL
{
    public class RptProductList
    {
        public DrugMaster DrugMaster { get; set; }
        public EntryParameter EntryParameter { get; set; }
    }
}
