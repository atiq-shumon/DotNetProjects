using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.FNB.MODEL;
using AH.FNB.BLL;
using AH.DUtility;
using AH.HR.BLL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.ORGMS.BLL;
using AH.ORGMS.MODEL;
using AH.FNB.DAL;

namespace AH.FNB.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FNBWS : IFNBWS
    {
        public List<Material_Receipt> GetMaterialRefNo(string Where)
        {
            return new FnbBll().GetMaterialRefNo(Where);
        }
        public int number()
        {
            return new FnbBll().number();
        }
        public List<Material_Receipt> DisplayDetailsAgainsrRef(string Where)
        {
            return new FnbBll().DisplayDetailsAgainsrRef(Where);
        }
        public Dictionary<string, string> GetStockGroup()
        {
            return new FnbBll().GetStockGroup();
        }
        public string SaveMrr(Material_Receipt Mrr)
        {
            return new FnbBll().SaveMrr(Mrr);
        }
        public short SaveMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            return new FnbBll().SaveMrrTrans(mrrNo, ProductCode, unitCode, brandID, modelId, dblQty, dblRate, dblNetAmnount, Mrr);
        }
        public List<Material_Receipt> GetpopulatedList()
        {
            return new FnbBll().GetpopulatedList();
        }
        public List<Material_Receipt> Displaymaterialreceipt(string Where)
        {
            return new FnbBll().Displaymaterialreceipt(Where);
        }

        public short UpdateMrr(Material_Receipt Mrr)
        {
            return new FnbBll().UpdateMrr(Mrr);
        }

        public short UpdateMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr)
        {
            return new FnbBll().UpdateMrrTrans(mrrNo, ProductCode, unitCode, brandID, modelId, dblQty, dblRate, dblNetAmnount, Mrr);
        }
        public short InsertDietcat(DietCategory dietcat)
        {
            return new FnbBll().InsertDietcat(dietcat);
        }
        public short UpdateDietcat(DietCategory dietcat)
        {
            return new FnbBll().UpdateDietcat(dietcat);
        }
        public List<DietCategory> LoadDietCategory()
        {
            return new FnbBll().LoadDietCategory();
        }


        public short InsertFoodcat(FoodCategory dietcat)
        {
            return new FnbBll().InsertFoodcat(dietcat);
        }
        public short UpdateFoodcat(FoodCategory dietcat)
        {
            return new FnbBll().UpdateFoodcat(dietcat);
        }
        public List<FoodCategory> LoadFoodCategory()
        {
            return new FnbBll().LoadFoodCategory();
        }

        public Dictionary<string, string> GetFoodCategory()
        {
            return new FnbBll().GetFoodCategory();
         }
        public Dictionary<string, string> GetDietCategory()
        {
            return new FnbBll().GetDietCategory();
        }


        public short InsertFoodItem(FoodItem Foodcat)
        {
            return new FnbBll().InsertFoodItem(Foodcat);
        }

        public short UpdateFoodItem(FoodItem foodcat)
        {
            return new FnbBll().UpdateFoodItem(foodcat);
        }
        public List<FoodItem> LoadFoodItem()
        {
            return new FnbBll().LoadFoodItem();
        }
        public string InsertFoodMaster(FoodMaster Fm)
        {
            return new FnbBll().InsertFoodMaster(Fm);
        }

        public short UpdateFoodMaster(FoodMaster Fm)
        {
            return new FnbBll().UpdateFoodMaster(Fm);
        }

        public List<FoodMaster> LoadFoodMaster()
        {
            return new FnbBll().LoadFoodMaster();
        }
        public short InsertFoodMenuSetup(FoodMenuSetup FMS)
        {
            return new FnbBll().InsertFoodMenuSetup(FMS);
        }
        public short UpdateMenuFoodItem(FoodMenuSetup FMS)
        {
            return new FnbBll().UpdateMenuFoodItem(FMS);
        }
        public List<FoodMenuSetup> LoadFoodMenuSetup()
        {
            return new FnbBll().LoadFoodMenuSetup();
        }
        public short InsertServiceSetup(ServiceSetup FS)
        {
            return new FnbBll().InsertServiceSetup(FS);
        }
        public short UpdateServiceSetup(ServiceSetup FS)
        {
            return new FnbBll().UpdateServiceSetup(FS);
        }
        public List<ServiceSetup> LoadServiceSetup()
        {
            return new FnbBll().LoadServiceSetup();
        }
        public List<FoodItemRO> GetFoodItem(string Where)
        {
            return new FnbBll().GetFoodItem(Where);
        }

        public short InsertFoodTypeSetup(FoodMenuType FMS)
        {
            return new FnbBll().InsertFoodTypeSetup(FMS);
        }

        public short UpdateFoodTypeSetup(FoodMenuType FMS)
        {
            return new FnbBll().UpdateFoodTypeSetup(FMS);
        }

        public List<FoodMenuType> GetFoodMenuType()
        {
            return new FnbBll().GetFoodMenuType();
        }
        public Dictionary<string, string> GetFoodMenuItemSetup()
        {
            return new FnbBll().GetFoodMenuItemSetup();
        }

        public Dictionary<string, string> GetFoodTypeSetup()
        {
            return new FnbBll().GetFoodTypeSetup();
        }

        public short InsertFoodRateItem(string strFoodId, double dblRate, FoodMenuItemSetup FMS)
        {
            return new FnbBll().InsertFoodRateItem(strFoodId, dblRate, FMS);
        }
        public short UpdateFoodRateItem(string strFoodId, double dblRate, FoodMenuItemSetup FMS)
        {
            return new FnbBll().UpdateFoodRateItem(strFoodId, dblRate, FMS);
        }
        public List<FoodMenuItemSetup> LoadFoodItemrate()
        {
            return new FnbBll().LoadFoodItemrate();
        }
        public List<FoodMenuItemSetup> DisplayFoodItemrate(string where)
        {
            return new FnbBll().DisplayFoodItemrate(where);
        }

        public short InsertMealsetup(MealSetup ms)
        {
            return new FnbBll().InsertMealsetup(ms);
        }

        public short UpdateMealsetup(MealSetup ms)
        {
            return new FnbBll().UpdateMealsetup(ms);
        }
        public List<MealSetup> LoadmealSetup()
        {
            return new FnbBll().LoadmealSetup();
        }
        public Dictionary<string, string> LoadWeeklyMealSetup()
        {
            return new FnbBll().LoadWeeklyMealSetup();
        }
        public short InsertWeeklysetup(WeeklySetupMeal WS)
        {
            return new FnbBll().InsertWeeklysetup(WS);
        }
        public short UpdateWeeklysetup(WeeklySetupMeal WS)
        {
            return new FnbBll().UpdateWeeklysetup(WS);
        }
        public List<WeeklySetupMeal> GetWeeklyMealSetup()
        {
            return new FnbBll().GetWeeklyMealSetup();
        }
        public List<WeeklyEmpMealRegister> GetWeeklySetmenu()
        {
            return new FnbBll().GetWeeklySetmenu();
        }
        public List<WeeklyEmpMealRegister> DisplaySetmenuDetails(string Where)
        {
            return new FnbBll().DisplaySetmenuDetails(Where);
        }

        public Dictionary<string, string> GetEmp(string type)
        {
            return new PayrollSetupBLL().GetEmp(type);
        }
        public string InsertMealRegistermaster(WeeklyEmpMealRegister WS)
        {
            return new FnbBll().InsertMealRegistermaster(WS);
        }

        public string InsertMealRegister(string strRefNo, string setMenu, double dblMealRate, WeeklyEmpMealRegister WS)
        {
            return new FnbBll().InsertMealRegister(strRefNo, setMenu, dblMealRate, WS);
        }
        public List<WeeklyEmpMealRegister> GetWeeklySetupregister(string Where, string Where1)
        {
            return new FnbBll().GetWeeklySetupregister(Where, Where1);
        }
        public short UpdateMealRegister(WeeklyEmpMealRegister WS)
        {
            return new FnbBll().UpdateMealRegister(WS);
        }

       public List<WeeklySetupMeal> LaodWeeklySetMenuType()
        {
            return new FnbBll().LaodWeeklySetMenuType();
        }


       public EmployeeMaster GetEmpMaster(string ID)
       {
           return new EmployeeSetUpBLL().GetEmpMaster(ID);
       }

      public List<WeeklyChart> LaodWeeklyChart(string strSetMenuTypeID)
       {
           return new FnbBll().LaodWeeklyChart(strSetMenuTypeID);
       }

      public List<FoodMenuItemSetup> GetVisitorsMenuItem(string where)
      {
          return new FnbBll().GetVisitorsMenuItem(where);
      }
      public string InsertVisitorsMaster(Visitors Vs)
      {
          return new FnbBll().InsertVisitorsMaster(Vs);
      }

      public short InsertVisitorsTran(string strInvNo, string strFoodID, double dblQnty, double dblRate, double dblDiscount, double dblTotal, Visitors Vs)
      {
          return new FnbBll().InsertVisitorsTran(strInvNo, strFoodID, dblQnty, dblRate, dblDiscount,  dblTotal, Vs);
      }


      public List<Visitors> GetVisitors(string where)
      {
          return new FnbBll().GetVisitors(where);
      }

      public List<Visitors> DisplaytVisitors(string where)
      {
          return new FnbBll().DisplaytVisitors(where);
      }


      public int UpdateVisitorsMaster(string strInvoiceNo, Visitors Vs)
      {
          return new FnbBll().UpdateVisitorsMaster(strInvoiceNo, Vs);
      }

     public List<FoodMaster> LoadFoodItemFromCat(string where)
      {
          return new FnbBll().LoadFoodItemFromCat(where);
      }

     public List<FoodMaster> GetItemRate(string where)
     {
         return new FnbBll().GetItemRate(where);
     }

     public List<FoodMenuItemSetup> GetFoodMenuItemSetupFromMenuID(string CallName, string Where)
     {
         return new FnbBll().GetFoodMenuItemSetupFromMenuID(CallName, Where);
     }


     public string InsertVisitorsOrderTran(Visitors Vs)
     {
         return new FnbBll().InsertVisitorsOrderTran(Vs);
     }


     public List<VisitorsSlipRO> GetVisitorsSlipRo(string Pcall, string Where)
     {
         return new FnbBll().GetVisitorsSlipRo(Pcall,Where);
     }


     public AccountsPayment GetCollectionAmount(string userID, string date)
     {
         return new FnbBll().GetCollectionAmount(userID, date);
     }
     public short InsertUserCloseRegister(AccountsPayment tktFee) //(Ticket tktFee)
     {
         return new FnbBll().InsertUserCloseRegister(tktFee);
     }


     public Dictionary<string, string> GetMealID()
     {
         return new FnbBll().GetMealID();
     }
     public Dictionary<string, string> GetWeeklySetmenuDetiails(string MealId, string MealName)
     {
         return new FnbBll().GetWeeklySetmenuDetiails(MealId, MealName);
     }


     public List<MealSetup> GetMealTime()
     {
         return new FnbBll().GetMealTime();
     }

     public Dictionary<string, string> LoadSetmenu(string where, string where1)
       
     {
         return new FnbBll().LoadSetmenu( where ,where1);
    }

    public string GetBarcodeLevel(string strBarcode)
     {
         return new FnbBll().GetBarcodeLevel(strBarcode);
     }


    public short UpdateIssue(string strCardNo, string strMealID, string strDate)
    {
        return new FnbBll().UpdateIssue(strCardNo, strMealID, strDate);
    }


    public List<DailyCollectionRO> LoadDailyCollection(string where, string CallName, string Fdate, string Tdate)
    {
        return new FnbBll().LoadDailyCollection(where, CallName, Fdate, Tdate);
    }

    public List<VisitorsSlipRO> GetFoodItemCollection(string where, string CallName, string Fdate, string Tdate)
    {
        return new FnbBll().GetFoodItemCollection(where, CallName, Fdate, Tdate);
    }


    public List<DailyCollectionRO> LoadStaffCollection(string where, string CallName, string Fdate, string Tdate)
    {
        return new FnbBll().LoadStaffCollection(where, CallName, Fdate, Tdate);
    }


    public List<Visitors> GetvisitorsHistory(string where)
    {
        return new FnbBll().GetvisitorsHistory(where);
    }

    public long GetTotalAttendance(string where)
    {
        return new FnbBll().GetTotalAttendance(where);
    }


    public List<FoodItem> GetFoodID(string where)
    {
        return new FnbBll().GetFoodID(where);
    }

  public List<DailyCollectionRO> LoadStaffIssuesd(string where, string CallName, string Fdate, string Tdate)
    {
            return  new FnbBll().LoadStaffIssuesd(where,  CallName,Fdate, Tdate);
    }


  public List<VisitorsSlipRO> GetVisitorsCollection(string where, string CallName, string Fdate, string Tdate)
  {
      return new FnbBll().GetVisitorsCollection(where, CallName, Fdate, Tdate);
  }

  public List<DailyCollectionRO> LoadUserwiseCollection(string where, string CallName, string Fdate, string Tdate)
  {
      return new FnbBll().LoadUserwiseCollection(where, CallName, Fdate, Tdate);
  }


  public List<VisitorsSlipRO> GetVisitorsItemDetails(string where, string CallName, string Fdate, string Tdate)
  {
      return new FnbBll().GetVisitorsItemDetails(where, CallName, Fdate, Tdate);
  }

    public List<Visitors> GetvisitorsHistoryDateRange(string where, string where1,string where2)
    {
        return new FnbBll().GetvisitorsHistoryDateRange(where, where1, where2);
    }

    public List<VisitorsSlipRO> GetEmpStaffItem(string where, string where1, string where2)
    {
        return new FnbBll().GetEmpStaffItem(where, where1, where2);
    }

    public FoodSubsidy GetFoodSubsidy(string EmpID)
    {
        return new AdministrationSetupBLL().GetFoodSubsidy(EmpID);
    }

    public List<WeeklySetupMeal> GetWeeklyDayMeal(string where, string where1)
    {
        return new FnbBll().GetWeeklyDayMeal(where, where1);
    }

    public string InsertInventory(Inventory inv)
    {
        return new FnbBll().InsertInventory(inv);
    }


    public List<Inventory> GetMonthVoucher(int intVtype)
    {
        return new FnbBll().GetMonthVoucher(intVtype);
    }
    public List<Inventory> DisplayVoucher(string where)
    {
        return new FnbBll().DisplayVoucher(where);
    }

    public string UpdateInventory(Inventory inv)
    {
        return new FnbBll().UpdateInventory(inv);
    }

    public List<Inventory> GetClosingQty(string where)
    {
        return new FnbBll().GetClosingQty(where);
    }

    public List<InventoryRO> GetfnbInventoryDetails(string PfDate, string pTdate)
    {
        return new FnbBll().GetfnbInventoryDetails(PfDate, pTdate);
    }


   //*******************Diet****************************

    public Dictionary<string, string> GetDietSubType()
    {
        return new DietBll().GetDietSubType();
    }


    public string SaveDietSubType(DietSubType dst)
    {
        return new DietBll().SaveDietSubType(dst);

    }


    public List<DietSubType> DisplaySubType()
    {
        return new DietBll().DisplaySubType();
    }

    public string UpdateDietSubType(DietSubType dst)
    {
        return new DietBll().UpdateDietSubType(dst);
    }

    public List<WeeklyDietSetup> GetSubType(string Where)
    {
        return new DietBll().GetSubType(Where);
    }

        //HRM

    public Dictionary<string, string> GetDeptGroupDicByType(string type)
    {
        return new AdministrationSetupBLL().GetDeptGroupDicByType(type);
    }
    public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
    {
        return new AdministrationSetupBLL().GetDepartmentsetupDic(type, deptgr);
    }


    public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
    {
        return new AdministrationSetupBLL().GetDeptUnitDic(deptgrp, deptid);
    }

    public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegister(string strGrpID, string strDepID, string fDate, string tDate)
    {
        return new FnbBll().GetMonthWiseMealRegister(strGrpID, strDepID, fDate, tDate);
    }


    public string InsertWeeklyDietMenu(WeeklyDietSetup Wds)
    {
        return new DietBll().InsertWeeklyDietMenu(Wds);
    }

    public string UpdatetWeeklyDietMenu(WeeklyDietSetup Wds)
    {
        return new DietBll().UpdatetWeeklyDietMenu(Wds);
    }
    public List<WeeklyDietSetup> GetWeeklyDietSetup(string Where)
    {
        return new DietBll().GetWeeklyDietSetup(Where);
    }


    public List<Visitors> CheckEmpID(string where, string fDate, string tDate)
    {
        return new FnbBll().CheckEmpID(where, fDate, tDate);
    }


    public List<MonthwiseMealRegisterRO> GetMonthWiseMealRegisterAll(string strGrpID, string strDepID, string fDate, string tDate)
    {
        return new FnbBll().GetMonthWiseMealRegisterAll(strGrpID, strDepID, fDate, tDate);
    }




    }
}
