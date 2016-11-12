using AH.IPDShared.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.IPD.MODEL
{
   public class PatientDeath
    {
       public InPatient InPatient { set; get; }
       public EntryParameter EntryParameter { set; get; }
       public string DeathReasonID { set; get; }
       public string DeathNotes { set; get; }
       public DateTime DeathDTTM { set; get; }
       public string Remarks { set; get; }
    }
}
