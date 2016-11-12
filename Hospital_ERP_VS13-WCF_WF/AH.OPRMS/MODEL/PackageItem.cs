using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.OPRMS.MODEL
{
   public class PackageItem
    {
       public string PackageItemNo { set; get; }
       public string ItemNo { set; get; }
       public string unitID { set; get; }
       public string unitName { set; get; }
       public string ItemName { set; get; }
       public double ItemRate { set; get; }

       public string  PackChildNo { set; get; }
       public double NetAmount { set; get; }
       public string Oprtype { set; get; }
       public string Bedtype { set; get; }
       public int Bedstatus { set; get; }
       public string fromdate { set; get; }
       public string todate { set; get; }
       
       public string submenuID { set; get; }
       public EntryParameter EntryParameter { set; get; }
       

    }
}
