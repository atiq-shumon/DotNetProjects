using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.IPDShared.MODEL;


namespace AH.PHRMS.MODEL
{
    public class NurseDemandRequisition
    {
        public string NurseStationID { set; get; }
        public string NurseStationTitle { set; get; }
        public string DrID { set; get; }
        public StockHelper StockHelper { set; get; }
        public string Department { set; get; }
        public string Unit { set; get; }
        public string Pharmacy { set; get; }
        public string HCN { set; get; }
        public string PrescriptionNo { set; get; }
        public string Doctor { set; get; }
        public InPatient InPatient { set; get; }
        public float NurseDemandQty { set; get; }
        public float RemainingQty { set; get; }
        public DrugMaster DrugMaster { set; get; }

    }
}
