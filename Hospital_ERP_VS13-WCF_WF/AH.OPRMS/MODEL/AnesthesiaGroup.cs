using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AH.Shared.MODEL;
namespace AH.OPRMS.MODEL
{
   public class AnesthesiaGroup
    {
       public string AnesGroupID { set; get; }
       public string AnesGroupTitle { set; get; }
       public string AnesGroupTitleBeng { set; get; }
       public string AnesRemarks { set; get; }
       public string Active { set; get; }
       public EntryParameter EntryParameter {set; get; }

    }
}
