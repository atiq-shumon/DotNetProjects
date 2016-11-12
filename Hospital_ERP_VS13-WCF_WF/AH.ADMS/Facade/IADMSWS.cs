using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.ADMS.MODEL;
using AH.Shared.MODEL;

namespace AH.ADMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IADMSWS" in both code and config file together.
    [ServiceContract]
    public interface IADMSWS
    {
        [OperationContract]
        short SaveBedFee(BedCharges tbd);
        [OperationContract]
        short UpdateBedFee(BedCharges ubd);
        [OperationContract]
        List<BedCharges> GetBedRateShow(string bedtype);
        [OperationContract]
        int VerifyBedTestFee(string bedtype);

        [OperationContract(Name = "GetBedtypeDict")]
        Dictionary<string, string> GetBedtype(string type);

        [OperationContract(Name = "GetBuildingDict")]
        Dictionary<string, string> GetBuildings(string type);


        [OperationContract]
        List<BedCharges> GetBedRates();

        //[OperationContract(Name = "GetRevHdGrDic")]
        //Dictionary<string, string> GetRevHdGrps(string type);
        //[OperationContract(Name = "GetRevenueHead")]
        //Dictionary<string, string> GetRevenueHead(string type);
        //[OperationContract]
        //List<RevenueHead> GetRevenueHeads(string headgr);
        //[OperationContract(Name = "GetRevDict")]
        //Dictionary<string, string> GetRevenueHeads(string type, string headgr);
        [OperationContract]
        List<BedCharges> GetBedRateSetup(string bedtype, string headgroup);
        //[OperationContract]
        //Dictionary<string, string> GetBedRateSetup(string deptid);
    }
}
