using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.DAL;
using AH.PRMS.MODEL;

namespace AH.PRMS.BLL
{
    public class NurseStationBLL
    {
        public List<NurseStation> GetNurseStation()
        {
            return new NurseStationDAL().GetNurseStation();
        }
        public Dictionary<string, string> GetNurseStationDic(string type)
        {
            Dictionary<string, string> nurseDic = new Dictionary<string, string>();
            foreach (NurseStation nurse in new NurseStationDAL().GetNurseStation())
            {
                nurseDic.Add(nurse.NurseStationID, nurse.NurseStationTitle);
            }
            return nurseDic;
        }
        public short SaveNurseStation(NurseStation nurse)
        {
            return new NurseStationDAL().SaveNurseStation(nurse);
        }
        public List<NurseStation> GetNurseAllStation()
        {
            return new NurseStationDAL().GetNurseAllStation();
        }
        public short UpdateNurseStation(NurseStation nurse)
        {
            return new NurseStationDAL().UpdateNurseStation(nurse);
        }
        public List<NurseStation> GetNurseStationFloorWise(int floorNo)
        {
            return new NurseStationDAL().GetNurseStationFloorWise(floorNo);
        }

    }
}
