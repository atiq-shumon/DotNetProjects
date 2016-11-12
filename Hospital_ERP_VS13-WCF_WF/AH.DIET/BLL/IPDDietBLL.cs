using AH.DIET.DAL;
using AH.DIET.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.DIET.BLL
{
   public class IPDDietBLL
    {
       public string SaveIPDPatientDiet(IPDDiet diet)
       {
           return new IPDDietDAL().SaveIPDPatientDiet(diet);
       }
       public Dictionary<string, string> GetDietDic()
       {
           Dictionary<string, string> diets = new Dictionary<string, string>();
           foreach (IPDDiet diet in new IPDDietDAL().GetDietType())
           {
               diets.Add(diet.DietTypeID, diet.DietTypeTitle);
           }
           return diets;
       }
       public List<IPDDiet> GetIPDDiet(string nurseStationID)
       {
           return new IPDDietDAL().GetIPDDiet(nurseStationID);
       }
       public List<IPDDiet> GetDietList()
       {
           return new IPDDietDAL().GetDietType();
       }
       public string SaveIPDPatientDietReg(IPDDiet diet)
       {
           return new IPDDietDAL().SaveIPDPatientDietReg(diet);
       }

       public Dictionary<string, string> GetNurseStnWiseDietType(string nsID, DateTime date)
       {
           Dictionary<string, string> diets = new Dictionary<string, string>();
           foreach (IPDDiet diet in new IPDDietDAL().GetNurseStnWiseDietType(nsID, date))
           {
               diets.Add(diet.DietTypeID, diet.DietTypeTitle);
           }
           return diets;
       }
       public string UpdateOrderedIPDPatientDietList(IPDDiet diet)
       {
           return new IPDDietDAL().UpdateOrderedIPDPatientDietList(diet);
       }
       public List<IPDDiet> DietTypeOrderedDelevered(string nsID, DateTime date)
       {
           return new IPDDietDAL().DietTypeOrderedDelevered(nsID, date);
       }
       public string UpdateFoodServedtDietList(IPDDiet diet)
       {
           return new IPDDietDAL().UpdateFoodServedtDietList(diet);
       }
       public List<IPDDiet> GetTotalOrderList(DateTime p_date, string mealId)
       {
           return new IPDDietDAL().GetTotalOrderList(p_date, mealId);
       }
       public List<IPDDiet> Total(DateTime p_date, string mealId)
       {
           return new IPDDietDAL().Total(p_date, mealId);
       }
    }
}
