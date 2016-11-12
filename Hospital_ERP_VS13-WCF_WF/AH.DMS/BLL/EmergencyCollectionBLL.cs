using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.IPDShared.MODEL;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.DMS.DAL;
using AH.DTMS.MODEL;
using AH.HR.BLL;
using AH.ORGMS.BLL;
using AH.IPDShared.BLL;
using AH.Shared.MODEL;

namespace AH.DMS.BLL
{
    public class EmergencyCollectionBLL
    {
        public string SaveEmergencyCollection(EmergencyCollectionMR mr)
        {
            return new EmergencyCollectionDAL().SaveEmergencyCollection(mr);
        }
        public string SaveEmergencyMaster(EmergencyMaster mr)
        {
            return new EmergencyCollectionDAL().SaveEmergencyMaster(mr);
        }
        public List<EmergencyMaster> GetPatientByEmerPrescription(string Prescription)
        {
            return new EmergencyCollectionDAL().GetPatientByEmerPrescription(Prescription);
        }
        public List<EmergencyCollectionMR> GetEmerBillForPayment(string HCNNo)
        {
            return new EmergencyCollectionDAL().GetEmerBillForPayment(HCNNo);
        }
        public string SaveEmergencyCollectionPayment(EmergencyCollectionMR mr)
        {
            return new EmergencyCollectionDAL().SaveEmergencyCollectionPayment(mr);
        }
        public List<EmergencyCollectionMR> GetEmerMRNo(string HCNNo)
        {
            return new EmergencyCollectionDAL().GetEmerMRNo(HCNNo);
        }
        public List<EmergencyCollectionMR> GetEmerDetailsForIPD(string HCNNo)
        {
            return new EmergencyCollectionDAL().GetEmerDetailsForIPD(HCNNo);
        }
    }
}
