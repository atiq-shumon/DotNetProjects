using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ADMS.MODEL;
using AH.ADMS.BLL;
using AH.PRMS.BLL;
using AH.PRMS.MODEL;
using AH.Shared.MODEL;
//using AH.ACCMS.BLL;

namespace AH.ADMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ADMSWS" in both code and config file together.
    public class ADMSWS : IADMSWS
    {
        public short SaveBedFee(BedCharges tbd)
        {
            return new BedFeesBLL().SaveBedFee(tbd);
        }
        public short UpdateBedFee(BedCharges ubd)
        {
            return new BedFeesBLL().UpdateBedFee(ubd);
        }
        public List<BedCharges> GetBedRateShow(string bedtype)
        {
            return new BedFeesBLL().GetBedRateShow(bedtype);
        }
        public int VerifyBedTestFee(string bedtype)
        {
            return new BedFeesBLL().VerifyBedTestFee(bedtype);
        }
        public Dictionary<string, string> GetBedtype(string type)
        {
            return new PropertySetupBLL().GetBedtype(type);
        }
        public Dictionary<string, string> GetBuildings(string type)
        {
            return new PropertySetupBLL().GetBuildings(type);
        }

        public List<BedCharges> GetBedRates()
        {
            return new BedFeesBLL().GetBedRates();
        }

        //public Dictionary<string, string> GetRevHdGrps(string type)
        //{
        //    return new RevenueSetupBLL().GetRevHdGrps(type);
        //}
        //public Dictionary<string, string> GetRevenueHead(string type)
        //{
        //    return new RevenueSetupBLL().GetRevenueHead(type);
        //}
        //public List<RevenueHead> GetRevenueHeads(string headgr)
        //{
        //    return new RevenueSetupBLL().GetRevenueHeads(headgr);
        //}
        //public Dictionary<string, string> GetRevenueHeads(string type, string headgr)
        //{
        //    return new RevenueSetupBLL().GetRevenueHeads(type, headgr);
        //}
        public List<BedCharges> GetBedRateSetup(string bedtype, string headgroup)
        {
            return new BedFeesBLL().GetBedRateSetup(bedtype, headgroup);
        }
        //public Dictionary<string, string> GetBedRateSetup(string deptid)
        //{
        //    return new BedFeesBLL().GetBedRateSetup(deptid);
        //}
    }
}
