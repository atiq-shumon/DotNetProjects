using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.FNB.DAL;
using AH.FNB.MODEL;
using System.Threading.Tasks;
using AH.HR.MODEL;
using AH.Shared.MODEL;


namespace AH.FNB.BLL
{
    public class FnbBll
    {
        public List<Material_Receipt> GetMaterialRefNo(string Where)
        {
            return new FnbDal().GetMaterialRefNo(Where);
        }
        public int number()
        {
            return new FnbDal().number();
        }

        public List<Material_Receipt> DisplayDetailsAgainsrRef(string Where)
        {
            return new FnbDal().DisplayDetailsAgainsrRef( Where);
        }
        public Dictionary<string, string> GetStockGroup()
        {
            Dictionary<string, string> objGroup = new Dictionary<string, string>();
            foreach (Material_Receipt mrr in new FnbDal().GetStockGroup())
            {
                objGroup.Add(mrr.Groupcode,mrr.GroupName);
            }
            return objGroup;
        }
        public string SaveMrr(Material_Receipt Mrr)
        {
            return new FnbDal().SaveMrr(Mrr);
        }
        public short SaveMrrTrans(string mrrNo,string ProductCode,string unitCode,string brandID,
                                    string modelId,double  dblQty,double dblRate,double  dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            return new FnbDal().SaveMrrTrans(mrrNo, ProductCode, unitCode, brandID, modelId, dblQty, dblRate, dblNetAmnount, Mrr);
        }

        public List<Material_Receipt> GetpopulatedList()
        {
            return new FnbDal().GetpopulatedList();
        }
        public List<Material_Receipt> Displaymaterialreceipt(string Where)
        {
            return new FnbDal().Displaymaterialreceipt(Where);
        }

        public short UpdateMrr(Material_Receipt Mrr)
        {
            return new FnbDal().UpdateMrr(Mrr);
        }

        public short UpdateMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            return new FnbDal().UpdateMrrTrans(mrrNo, ProductCode, unitCode, brandID, modelId, dblQty, dblRate, dblNetAmnount, Mrr);
        }
        public short InsertDietcat(DietCategory dietcat)
        {
            return new FnbDal().InsertDietcat(dietcat);
        }
        public short UpdateDietcat(DietCategory dietcat)
        {
            return new FnbDal().UpdateDietcat(dietcat);
        }
        public List<DietCategory> LoadDietCategory()
        {
            return new FnbDal().LoadDietCategory();
        }


        public short InsertFoodcat(FoodCategory dietcat)
        {
            return new FnbDal().InsertFoodcat(dietcat);
        }
        public short UpdateFoodcat(FoodCategory dietcat)
        {
            return new FnbDal().UpdateFoodcat(dietcat);
        }
        public List<FoodCategory> LoadFoodCategory()
        {
            return new FnbDal().LoadFoodCategory();
        }
        public Dictionary<string, string> GetFoodCategory()
        {
            Dictionary<string, string> objFood = new Dictionary<string, string>();
            foreach (FoodCategory objFoodcat in new FnbDal().GetFoodCategory())
            {
                objFood.Add(objFoodcat.FoodID, objFoodcat.FoodcatName);
            }
            return objFood;
        }
        public Dictionary<string, string> GetDietCategory()
        {
            Dictionary<string, string> objDiet = new Dictionary<string, string>();
            foreach (DietCategory objDietcat in new FnbDal().GetDietCategory())
            {
                objDiet.Add(objDietcat.dietID, objDietcat.dietcatName);
            }
            return objDiet;
        }

        public short InsertFoodItem(FoodItem Foodcat)
        {
            return new FnbDal().InsertFoodItem(Foodcat);
        }

        public short UpdateFoodItem(FoodItem foodcat)
        {
            return new FnbDal().UpdateFoodItem(foodcat);
        }
        public List<FoodItem> LoadFoodItem()
        {
            return new FnbDal().LoadFoodItem();
        }
        public string InsertFoodMaster(FoodMaster Fm)
        {
            return new FnbDal().InsertFoodMaster(Fm);
        }

        public short UpdateFoodMaster(FoodMaster Fm)
        {
            return new FnbDal().UpdateFoodMaster(Fm);
        }

        public List<FoodMaster> LoadFoodMaster()
        {
            return new FnbDal().LoadFoodMaster();
        }
        public short InsertFoodMenuSetup(FoodMenuSetup FMS)
        {
            return new FnbDal().InsertFoodMenuSetup(FMS);
        }
        public short UpdateMenuFoodItem(FoodMenuSetup FMS)
        {
            return new FnbDal().UpdateMenuFoodItem(FMS);
        }
        public List<FoodMenuSetup> LoadFoodMenuSetup()
        {
            return new FnbDal().LoadFoodMenuSetup();
        }
        public short InsertServiceSetup(ServiceSetup FS)
        {
            return new FnbDal().InsertServiceSetup(FS);
        }
        public short UpdateServiceSetup(ServiceSetup FS)
        {
            return new FnbDal().UpdateServiceSetup(FS);
        }
        public List<ServiceSetup> LoadServiceSetup()
        {
            return new FnbDal().LoadServiceSetup();
        }
        public List<FoodItemRO> GetFoodItem(string Where)
        {
            return new FnbDal().GetFoodItem(Where);
        }
        public short InsertFoodTypeSetup(FoodMenuType FMS)
        {
            return new FnbDal().InsertFoodTypeSetup(FMS);
        }

        public short UpdateFoodTypeSetup(FoodMenuType FMS)
        {
            return new FnbDal().UpdateFoodTypeSetup(FMS);
        }

        public List<FoodMenuType> GetFoodMenuType()
        {
            return new FnbDal().GetFoodMenuType();
        }
        public Dictionary<string, string> GetFoodMenuItemSetup()
        {
            Dictionary<string, string> objGroup = new Dictionary<string, string>();
            foreach (FoodMenuItemSetup objfms in new FnbDal().GetFoodMenuItemSetup())
            {
                objGroup.Add(objfms.FoodMenuID, objfms.FoodMenuName);
            }
            return objGroup;
        }

        public Dictionary<string, string> GetFoodTypeSetup()
        {
            Dictionary<string, string> objGroup = new Dictionary<string, string>();
            foreach (FoodMenuItemSetup objfms in new FnbDal().GetFoodTypeSetup())
            {
                objGroup.Add(objfms.FoodTypeID, objfms.FoodTypeName);
            }
            return objGroup;
        }

        public short InsertFoodRateItem(string strFoodId,double  dblRate,FoodMenuItemSetup FMS)
        {
            return new FnbDal().InsertFoodRateItem(strFoodId, dblRate,FMS);
        }
        public short UpdateFoodRateItem(string strFoodId,double  dblRate,FoodMenuItemSetup FMS)
        {
            return new FnbDal().UpdateFoodRateItem(strFoodId, dblRate, FMS);
        }
        public List<FoodMenuItemSetup> LoadFoodItemrate()
        {
            return new FnbDal().LoadFoodItemrate();
        }
        public List<FoodMenuItemSetup> DisplayFoodItemrate(string where)
        {
            return new FnbDal().DisplayFoodItemrate(where);
        }
        public short InsertMealsetup(MealSetup ms)
        {
            return new FnbDal().InsertMealsetup(ms);
        }

        public short UpdateMealsetup(MealSetup ms)
        {
            return new FnbDal().UpdateMealsetup(ms);
        }
        public List<MealSetup> LoadmealSetup()
        {
            return new FnbDal().LoadmealSetup();
        }
        public Dictionary<string, string> LoadWeeklyMealSetup()
        {
            Dictionary<string, string> objSetup = new Dictionary<string, string>();
            foreach (WeeklySetupMeal objWsetup in new FnbDal().LoadWeeklyMealSetup())
            {
                objSetup.Add(objWsetup.MealID,objWsetup.MealName);
            }
            return objSetup;
        }

        public short InsertWeeklysetup(WeeklySetupMeal WS)
        {
            return new FnbDal().InsertWeeklysetup(WS);
        }
        public short UpdateWeeklysetup(WeeklySetupMeal WS)
        {
            return new FnbDal().UpdateWeeklysetup(WS);
        }
        public List<WeeklySetupMeal> GetWeeklyMealSetup()
        {
            return new FnbDal().GetWeeklyMealSetup();
        }
        public List<WeeklyEmpMealRegister> GetWeeklySetmenu()
        {
            return new FnbDal().GetWeeklySetmenu();
        }
        public List<WeeklyEmpMealRegister> DisplaySetmenuDetails(string Where)
        {
            return new FnbDal().DisplaySetmenuDetails(Where);
        }
        public string InsertMealRegistermaster(WeeklyEmpMealRegister WS)
        {
            return new FnbDal().InsertMealRegistermaster(WS);
        }
        public string InsertMealRegister(string strRefNo, string setMenu, double dblMealRate, WeeklyEmpMealRegister WS)
        {
            return new FnbDal().InsertMealRegister(strRefNo,setMenu,dblMealRate, WS);
        }
        public List<WeeklyEmpMealRegister> GetWeeklySetupregister(string Where,string Where1)
        {
            return new FnbDal().GetWeeklySetupregister(Where, Where1);
        }

        public short UpdateMealRegister(WeeklyEmpMealRegister WS)
        {
            return new FnbDal().UpdateMealRegister(WS);
        }


        public List<WeeklySetupMeal> LaodWeeklySetMenuType()
        {
            return new FnbDal().LaodWeeklySetMenuType();
        }

        public List<WeeklyChart> LaodWeeklyChart(string strSetMenuTypeID)
        {
            return new FnbDal().LaodWeeklyChart(strSetMenuTypeID);
        }

        public List<FoodMenuItemSetup> GetVisitorsMenuItem(string strSetMenuTypeID)
        {
            return new FnbDal().GetVisitorsMenuItem(strSetMenuTypeID);
        }

        public string InsertVisitorsMaster(Visitors Vs)
        {
            return new FnbDal().InsertVisitorsMaster(Vs);
        }

       public short InsertVisitorsTran(string strInvNo, string strFoodID, double dblQnty, double dblRate, double dblDiscount, double dblTotal, Visitors Vs)
        
        {
            return new FnbDal().InsertVisitorsTran(strInvNo, strFoodID, dblQnty, dblRate, dblDiscount, dblTotal, Vs);
        }

       public List<Visitors> GetVisitors(string where)

       {
           return new FnbDal().GetVisitors(where);
       }

       public List<Visitors> DisplaytVisitors(string where)
       {
           return new FnbDal().DisplaytVisitors(where);
       }

       public int UpdateVisitorsMaster(string strInvoiceNo, Visitors Vs)
       {
           return new FnbDal().UpdateVisitorsMaster(strInvoiceNo, Vs);
       }

       public List<FoodMaster> LoadFoodItemFromCat(string where)
       {
           return new FnbDal().LoadFoodItemFromCat(where);
       }

       public List<FoodMaster> GetItemRate(string where)
       {
           return new FnbDal().GetItemRate(where);
       }

       public List<FoodMenuItemSetup> GetFoodMenuItemSetupFromMenuID(string CallName, string Where)
       {
           return new FnbDal().GetFoodMenuItemSetupFromMenuID(CallName, Where);
       }

       public string  InsertVisitorsOrderTran(Visitors Vs)
       {
           return new FnbDal().InsertVisitorsOrderTran(Vs);
       }

       public List<VisitorsSlipRO> GetVisitorsSlipRo(string Pcall, string Where)
       {
           return new FnbDal().GetVisitorsSlipRo(Pcall,Where);
       }


       public AccountsPayment GetCollectionAmount(string userID, string date)
       {
           return new FnbDal().GetCollectionAmount(userID, date);
       }
       public short InsertUserCloseRegister(AccountsPayment tktFee) //(Ticket tktFee)
       {
           return new FnbDal().InsertUserCloseRegister(tktFee);
       }

       

       public Dictionary<string, string> GetMealID()
       {
           Dictionary<string, string> objDiet = new Dictionary<string, string>();
           foreach (MealSetup objMeal in new FnbDal().GetMealID())
           {
               objDiet.Add(objMeal.MealID, objMeal.MealName);
           }
           return objDiet;
       }
       public Dictionary<string, string> GetWeeklySetmenuDetiails(string MealId,string MealName)
       {
           Dictionary<string, string> objDiet = new Dictionary<string, string>();
           foreach (WeeklyEmpMealRegister objMeal in new FnbDal().GetWeeklySetmenuDetiails(MealId,MealName))
           {
               objDiet.Add(objMeal.Setmenuid, objMeal.SetmenuItem);
           }
           return objDiet;
       }

       public List<MealSetup> GetMealTime()
       {
           return new FnbDal().GetMealTime();
       }

       public Dictionary<string, string> LoadSetmenu(string where, string where1)
       {
           Dictionary<string, string> objDiet = new Dictionary<string, string>();
           foreach (WeeklyEmpMealRegister objMeal in new FnbDal().LoadSetmenu(where, where1))
           {
               objDiet.Add(objMeal.Setmenuid, objMeal.SetmenuItem);
           }
           return objDiet;
       }
       
      public string GetBarcodeLevel(string strBarcode)
       {
           return new FnbDal().GetBarcodeLevel(strBarcode);
       }


      public short UpdateIssue(string strCardNo, string strMealID, string strDate)
      {
          return new FnbDal().UpdateIssue(strCardNo, strMealID, strDate);
      }


      public List<DailyCollectionRO> LoadDailyCollection(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().LoadDailyCollection(where, CallName, Fdate, Tdate);
      }

      public List<VisitorsSlipRO> GetFoodItemCollection(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().GetFoodItemCollection(where, CallName, Fdate, Tdate);
      }

      public List<DailyCollectionRO> LoadStaffCollection(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().LoadStaffCollection(where, CallName, Fdate, Tdate);
      }

      public List<Visitors> GetvisitorsHistory(string where)
      {
          return new FnbDal().GetvisitorsHistory(where);
      }

      public long GetTotalAttendance(string where)
      {
          return new FnbDal().GetTotalAttendance(where);
      }

      public List<FoodItem> GetFoodID(string where)
      {
          return new FnbDal().GetFoodID(where);
      }

      public List<DailyCollectionRO> LoadStaffIssuesd(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().LoadStaffIssuesd(where, CallName, Fdate, Tdate);
      }

      public List<VisitorsSlipRO> GetVisitorsCollection(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().GetVisitorsCollection(where, CallName, Fdate, Tdate);
      }
      public List<DailyCollectionRO> LoadUserwiseCollection(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().LoadUserwiseCollection(where, CallName, Fdate, Tdate);
      }

      public List<VisitorsSlipRO> GetVisitorsItemDetails(string where, string CallName, string Fdate, string Tdate)
      {
          return new FnbDal().GetVisitorsItemDetails(where, CallName, Fdate, Tdate);
      }

      public List<Visitors> GetvisitorsHistoryDateRange(string where, string where1,string where2)
      {
          return new FnbDal().GetvisitorsHistoryDateRange(where, where1, where2);
      }
      public List<VisitorsSlipRO > GetEmpStaffItem(string where, string where1, string where2)
      {
          return new FnbDal().GetEmpStaffItem(where, where1, where2);
      }

     public List<WeeklySetupMeal> GetWeeklyDayMeal(string where, string where1)
      {
          return new FnbDal().GetWeeklyDayMeal(where, where1);
      }

     public string InsertInventory(Inventory inv)
     {
         return new FnbDal().InsertInventory(inv);
     }

     public List<Inventory> GetMonthVoucher(int intVtype)
     {
         return new FnbDal().GetMonthVoucher(intVtype);
     }

     public List<Inventory> DisplayVoucher(string where)
     {
         return new FnbDal().DisplayVoucher(where);
     }

     public string UpdateInventory(Inventory inv)
     {
         return new FnbDal().UpdateInventory(inv);
     }


     public List<Inventory> GetClosingQty(string where)
     {
         return new FnbDal().GetClosingQty(where);
     }

    public List<InventoryRO> GetfnbInventoryDetails(string PfDate,string pTdate)
     {
         return new FnbDal().GetfnbInventoryDetails(PfDate, pTdate);
     }


    public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegister(string strGrpID, string strDepID, string fDate, string tDate)
    {
        return new FnbDal().GetMonthWiseMealRegister(strGrpID, strDepID,fDate,tDate);
    }


    public List<Visitors> CheckEmpID(string where, string fDate, string tDate)
    {
        return new FnbDal().CheckEmpID(where, fDate, tDate);
    }


    public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegisterAll(string strGrpID, string strDepID, string fDate, string tDate)
    {
        return new FnbDal().GetMonthWiseMealRegisterAll(strGrpID, strDepID, fDate, tDate);
    }






    }
}
