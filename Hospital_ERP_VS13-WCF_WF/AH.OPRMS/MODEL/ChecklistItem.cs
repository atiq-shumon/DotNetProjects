using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
namespace AH.OPRMS.MODEL
{
   public class ChecklistItem
    {
       public string itemCode { set; get; }
       public string itemName { set; get; }
       public string oprType { set; get; }
       public string RegNo { set; get; }
       public string PatientName { set; get; }
       public string RegDate { set; get; }
       public string startime { set; get; }
       public string endtime { set; get; }
       public string ChecklistDate { set; get; }
       public int intYes { set; get; }
       public int intNo { set; get; }
       public string Checklistitemcode { set; get; }
       public string Comments { set; get; }
       public EntryParameter EntryParameter { set; get; }
    }
}
