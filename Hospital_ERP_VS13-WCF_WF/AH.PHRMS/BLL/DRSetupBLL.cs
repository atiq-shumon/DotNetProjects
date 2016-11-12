using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.PHRMS.MODEL;
using AH.PHRMS.DAL;

namespace AH.PHRMS.BLL
{
    public class DRSetupBLL
    {
       public string SaveDemandRequisition(DemandRequisition odr)
        {
            return new DRSetupDAL().SaveDemandRequisition(odr);
        }
    }
}
