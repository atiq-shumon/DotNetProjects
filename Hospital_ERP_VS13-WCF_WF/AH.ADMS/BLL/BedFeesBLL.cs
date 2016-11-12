using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ADMS.MODEL;
using AH.ADMS.DAL;

namespace AH.ADMS.BLL
{
    public class BedFeesBLL
    {
        public List<BedCharges> GetBedRateShow(string bedtype)
        {
            return new BedFeesDAL().GetBedRateShow(bedtype);
        }
        public short SaveBedFee(BedCharges tbd)
        {
            return new BedFeesDAL().SaveBedFee(tbd);
        }
        public short UpdateBedFee(BedCharges ubd)
        {
            return new BedFeesDAL().UpdateBedFee(ubd);
        }
        public int VerifyBedTestFee(string bedtype)
        {
            return new BedFeesDAL().VerifyBedTestFee(bedtype);
        }
        public List<BedCharges> GetBedRates()
        {
            return new BedFeesDAL().GetBedRates();
        }
        public List<BedCharges> GetBedRateSetup(string bedtype, string headgroup)
        {
            return new BedFeesDAL().GetBedRateSetup(bedtype, headgroup);
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
    }
}
