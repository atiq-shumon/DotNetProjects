using AH.IPD.DAL;
using AH.IPD.MODEL;
using AH.PRMS.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AH.IPD.BLL
{
    public class BedFeesBLL
    {
        public List<BedCharges> GetBedRate(string bedtype,string bedFacilityTypeId)       
        {
            return new BedFeesDAL().GetBedRate(bedtype,bedFacilityTypeId);
        }
        public short SaveBedFee(BedCharges tbd)
        {
            return new BedFeesDAL().SaveBedFee(tbd);
        }
        public short UpdateBedFee(BedCharges ubd)
        {
            return new BedFeesDAL().UpdateBedFee(ubd);
        }
        public int VerifyBedTestFee(string bedtype, string bedCategoryTypeId)
        {
            return new BedFeesDAL().VerifyBedTestFee(bedtype, bedCategoryTypeId);
        }
        public List<BedCharges> GetBedRates()
        {
            return new BedFeesDAL().GetBedRates();
        }
        public List<BedCharges> GetBedRateSetup(string bedCategoryTypeId, string headgroup)
        {
            return new BedFeesDAL().GetBedRateSetup(bedCategoryTypeId, headgroup);
        }
        //public Dictionary<string, string> GetBedRateSetup(string bedtype, string headgroup)
        //{
        //    Dictionary<string, string> brate = new Dictionary<string, string>();
        //    foreach (BedCharges br in new BedFeesDAL().GetBedRateSetup(bedtype, headgroup))
        //    {
        //        brate.Add(br.BedType.ID, br.Amount);
        //    }
        //    return brate;
        //}

        public Bed GetBedInfoByBedID(string bedID)
        {
            return new BedFeesDAL().GetBedInfoByBedID(bedID);
        }
    }
}
