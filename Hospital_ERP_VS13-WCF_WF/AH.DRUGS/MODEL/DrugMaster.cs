using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;

namespace AH.DRUGS.MODEL
{
    public class DrugMaster
    {
        
        public DrugCompany DrugCompany { set; get; }
        public DrugGroup DrugGroup { set; get; }
        public DrugUnit DrugUnit { set; get; }
        public DrugPackType DrugPackType { set; get; }
        public string ID { set; get; }
        public string Name { set; get; }
        public string NameBeng { set; get; }
        public string Remarks { set; get; }
        public int ReorderQty { set; get; }
        public float StockQty { set; get; }
        public int Priority { set; get; }
        public int SerialPriority { set; get; }
        public float Urate { set; get; }
        public float VAT { set; get; }
        public float Discount { set; get; }
        public float Rackrate { set; get; }
        public float Slrate { set; get; }
        public float NetAmount { set; get; }

        public string PharmacyName { set; get; }

        //public int DoseTimesID { get; set; }
        //public string DoseTimesInd { get; set; }
        //public string DoseRouteID { get; set; }
        
        //public int Duration { get; set; }
        //public string DurationInd { get; set; }
        //public int Refills { get; set; }
       
        //public string Coll_Status { get; set; }
        //public string HourGap { get; set; }
        //public string MealTimeGap { get; set; }
       
        //public string RouteID { get; set; }
        //public string DoseQuantity { get; set; }
        //public string DoseDrug { get; set; }
        public string ReorderQuantity { get; set; }
        public string PropertiesString { get; set; }
        //public string DurationPeriod { get; set; }
        //public string DurationContinue { get; set; }
        public float TotalQty { get; set; }
        public float CalculatedQty { get; set; }
        public float RemainingQty { get; set; }

        public string DrugDoseString { set; get; }

        public EntryParameter EntryParameter { set; get; }
    }
}
