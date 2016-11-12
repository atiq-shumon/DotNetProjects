using AH.DIET.MODEL;
using AH.FNB.MODEL;
using AH.IPDShared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AH.DIET.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDIETWS" in both code and config file together.
    [ServiceContract]
    public interface IDIETWS
    {

        [OperationContract]
        string SaveIPDPatientDiet(IPDDiet diet);

        [OperationContract]
        Dictionary<string, string> GetDietDic();

        [OperationContract]
        List<IPDDiet> GetIPDDiet(string nurseStationID);

        [OperationContract]
        List<IPDDiet> GetDietList();

        [OperationContract]
        string SaveIPDPatientDietReg(IPDDiet diet);

        [OperationContract]
        Dictionary<string, string> GetNurseStnWiseDietType(string nsID, DateTime date);

        [OperationContract]
        string UpdateOrderedIPDPatientDietList(IPDDiet diet);

        [OperationContract]
        List<IPDDiet> DietTypeOrderedDelevered(string nsID, DateTime date);

        [OperationContract]
        List<IPDDiet> GetTotalOrderList(DateTime p_date, string mealId);

        [OperationContract]
        List<IPDDiet> Total(DateTime p_date, string mealId);

        //=============================FNB=============================//

        [OperationContract]
        List<MealSetup> LoadmealSetup();

        //=============================IPD Shared=============================//
        [OperationContract]
        List<InPatient> GetAdmittedPatientListNSWise(string nurseStationId);

        [OperationContract]
        List<InPatient> NSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid);

        [OperationContract]
        List<InPatient> OrderdNSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid);

        [OperationContract]
        List<InPatient> ReadyToDelevPatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid);

        [OperationContract]
        string UpdateFoodServedtDietList(IPDDiet diet);

        [OperationContract]
        List<InPatient> GetNewPatient();

        [OperationContract]
        List<InPatient> PatList();

        [OperationContract]
        List<InPatient> BedTransferPatList();

        [OperationContract]
        List<InPatient> GetAdmittedAllPatList();

        [OperationContract]
        List<InPatient> GetAdmDateWisePatList(DateTime fromDate, DateTime toDate);
        [OperationContract]
        List<InPatient> GetBedTransferDateWisePatList(DateTime fromDate, DateTime toDate);

        [OperationContract]
        List<InPatient> GetDischargeDateWisePatList(DateTime fromDate, DateTime toDate);
    }
}
