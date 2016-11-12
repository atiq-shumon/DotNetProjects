using AH.DIET.BLL;
using AH.DIET.MODEL;
using AH.FNB.BLL;
using AH.FNB.MODEL;
using AH.IPDShared.BLL;
using AH.IPDShared.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AH.DIET.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DIETWS" in both code and config file together.
    public class DIETWS : IDIETWS
    {
        public string SaveIPDPatientDiet(IPDDiet diet)
        {
            return new IPDDietBLL().SaveIPDPatientDiet(diet);
        }
        public Dictionary<string, string> GetDietDic()
        {
            return new IPDDietBLL().GetDietDic();
        }
        public List<IPDDiet> GetIPDDiet(string nurseStationID)
        {
            return new IPDDietBLL().GetIPDDiet(nurseStationID);
        }
        public List<IPDDiet> GetDietList()
        {
            return new IPDDietBLL().GetDietList();
        }
        public string SaveIPDPatientDietReg(IPDDiet diet)
        {
            return new IPDDietBLL().SaveIPDPatientDietReg(diet);
        }
        public Dictionary<string, string> GetNurseStnWiseDietType(string nsID, DateTime date)
        {
            return new IPDDietBLL().GetNurseStnWiseDietType(nsID, date);
        }

        public string UpdateOrderedIPDPatientDietList(IPDDiet diet)
        {
            return new IPDDietBLL().UpdateOrderedIPDPatientDietList(diet);
        }
        public List<IPDDiet> DietTypeOrderedDelevered(string nsID, DateTime date)
        {
            return new IPDDietBLL().DietTypeOrderedDelevered(nsID, date);
        }
        public string UpdateFoodServedtDietList(IPDDiet diet)
        {
            return new IPDDietBLL().UpdateFoodServedtDietList(diet);
        }
        public List<IPDDiet> GetTotalOrderList(DateTime p_date, string mealId)
        {
            return new IPDDietBLL().GetTotalOrderList(p_date, mealId);
        }
        public List<IPDDiet> Total(DateTime p_date, string mealId)
        {
            return new IPDDietBLL().Total(p_date, mealId);
        }
        //=============================FNB=============================//
        public List<MealSetup> LoadmealSetup()
        {
            return new FnbBll().LoadmealSetup();
        }
        //=================IPD Shared=========================//
        public List<InPatient> GetAdmittedPatientListNSWise(string nurseStationId)
        {
            return new IPDSharedBLL().GetAdmittedPatientListNSWise(nurseStationId);
        }
        public List<InPatient> NSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date,string mealid)
        {
            return new IPDSharedBLL().NSWisePatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> OrderdNSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            return new IPDSharedBLL().OrderdNSWisePatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> ReadyToDelevPatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            return new IPDSharedBLL().ReadyToDelevPatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> GetNewPatient()
        {
            return new IPDSharedBLL().GetNewPatient();
        }
        public List<InPatient> PatList()
        {
            return new IPDSharedBLL().PatList();//.GetAdmittedPatientList();
        }
        public List<InPatient> BedTransferPatList()
        {
            return new IPDSharedBLL().BedTransferPatList();
        }
        public List<InPatient> GetAdmittedAllPatList()
        {
            return new IPDSharedBLL().GetAdmittedAllPatList();
        }
        public List<InPatient> GetAdmDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedBLL().GetAdmDateWisePatList(fromDate, toDate);
        }
        public List<InPatient> GetDischargeDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedBLL().GetDischargeDateWisePatList(fromDate, toDate);
        }
        public List<InPatient> GetBedTransferDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedBLL().GetBedTransferDateWisePatList(fromDate, toDate);
        }
    }
}
