using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DTMS.MODEL;
using AH.DTMS.DAL;

namespace AH.DTMS.BLL
{
    public class EmergencySetupBLL
    {
        public short SaveEmrCollHead(EmrCollHead oEmrCollHead)
        {
            return new EmergencySetupDAL().SaveEmrCollHead(oEmrCollHead);
        }
        public short UpdateEmrCollHead(EmrCollHead oEmrCollHead)
        {
            return new EmergencySetupDAL().UpdateEmrCollHead(oEmrCollHead);
        }
        public List<EmrCollHead> GetEmrCollHead(string Mode, string DeptGroup, string Dept, string Unit)
        {
            return new EmergencySetupDAL().GetEmrCollHead(Mode, DeptGroup, Dept, Unit);
        }
    }
}
