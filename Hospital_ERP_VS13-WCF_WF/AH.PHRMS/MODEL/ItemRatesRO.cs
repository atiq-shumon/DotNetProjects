using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.PHRMS.MODEL
{
    public class ItemRatesRO
    {
        public string Prod_ID { set; get; }
        public string DrugName { set; get; }
        public string Prod_Type_Id { set; get; }
        public string DrugTypeName { set; get; }
        public string Prod_Unit_Id { set; get; }
        public string DrugUnitName { set; get; }
        public string Prod_Grp_Id { set; get; }
        public string DrugGroup { set; get; }
        public string Prod_Comp_Id { set; get; }
        public string DrugCompany { set; get; }
        public string Prod_Brnd_Id { set; get; }
        public string Prod_Model_Id { set; get; }
        public float Urate { set; get; }
        public float Vat { set; get; }
        public float Disc { set; get; }
        public float rack_rate { set; get; }
        public float Sl_Rate { set; get; }
        public string Remarks { set; get; }

    }
}
