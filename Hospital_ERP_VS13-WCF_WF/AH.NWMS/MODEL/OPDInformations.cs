using AH.OPD.MODEL;
using AH.Shared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.NWMS.MODEL
{
    public class OPDInformations
    {
        public OPDDoctorCallQ OPDPatInfo { set; get; }
        public EntryParameter EntryParameter { set; get; }
        public Prescription Prescription { set; get; }
    }
}
