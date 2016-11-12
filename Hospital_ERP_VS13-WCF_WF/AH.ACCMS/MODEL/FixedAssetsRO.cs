using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.ACCMS.MODEL
{
   public class FixedAssetsRO
    {
       public string assetnumber { set; get; }
       public string lname { set; get; }
       public string lCode { set; get; }
       public string branchid { set; get; }
       public double assetprebal { set; get; }
       public double assetaddthisperiod { set; get; }
       public double assetdisposalthisperiod { set; get; }
       public double assetdeprate { set; get; }
       public double assetdepthisperiod { set; get; }
       public double assetdepaccu { set; get; }
       public double assetdepadjustment { set; get; }
       public double assetpurchasevalue { set; get; }
       public long noofdays { set; get; }
    }
}
