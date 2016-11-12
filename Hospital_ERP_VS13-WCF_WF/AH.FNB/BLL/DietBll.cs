using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.FNB.DAL;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.FNB.MODEL;

namespace AH.FNB.BLL
{
    public class DietBll
    {
        
        public Dictionary<string, string> GetDietSubType()
        {
            Dictionary<string, string> objDietType = new Dictionary<string, string>();
            foreach (DietSubType DT in new DietDal().GetDietSubType())
            {
                objDietType.Add(DT.DietSubID, DT.DietSubTypeName);
            }
            return objDietType;
        }

        public string SaveDietSubType(DietSubType dst)
        {
            return new DietDal().SaveDietSubType(dst);

        }

        public List<DietSubType> DisplaySubType()
        {
            return new DietDal().DisplaySubType();
        }

        public string UpdateDietSubType(DietSubType dst)
        {
            return new DietDal().UpdateDietSubType(dst);
        }


        public List<WeeklyDietSetup> GetSubType(string Where)
        {
            return new DietDal().GetSubType(Where);
        }

        public string InsertWeeklyDietMenu(WeeklyDietSetup Wds)
        {
            return new DietDal().InsertWeeklyDietMenu(Wds);
        }

        public string UpdatetWeeklyDietMenu(WeeklyDietSetup Wds)
        {
            return new DietDal().UpdatetWeeklyDietMenu(Wds);
        }
        public List<WeeklyDietSetup> GetWeeklyDietSetup(string Where)
        {
            return new DietDal().GetWeeklyDietSetup(Where);
        }



    }
}
