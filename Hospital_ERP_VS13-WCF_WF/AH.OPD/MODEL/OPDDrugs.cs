using AH.DRUGS.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.OPD.MODEL
{
    public class OPDDrugs
    {
        public DrugDose DrugDose { get; set; }
        public Prescription Prescription { get; set; }
      //  public EntryParameter EntryParameter { set; get; }
    }
}
