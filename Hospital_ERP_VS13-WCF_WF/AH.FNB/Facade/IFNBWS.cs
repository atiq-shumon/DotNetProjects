using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.FNB.MODEL;
using AH.HR.MODEL;
using AH.Shared.MODEL;
using AH.ORGMS.MODEL;



namespace AH.FNB.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFNBWS
    {
        [OperationContract]
        List<Material_Receipt> GetMaterialRefNo(string Where);
        [OperationContract]
        int number();
        [OperationContract]
        List<Material_Receipt> DisplayDetailsAgainsrRef(string Where);
        [OperationContract]
        Dictionary<string, string> GetStockGroup();
        [OperationContract]
        string SaveMrr(Material_Receipt Mrr);
        [OperationContract]
        short SaveMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr);
        [OperationContract]
        List<Material_Receipt> GetpopulatedList();
        [OperationContract]
        List<Material_Receipt> Displaymaterialreceipt(string Where);
        [OperationContract]
        short UpdateMrr(Material_Receipt Mrr);
        [OperationContract]
        short UpdateMrrTrans(string mrrNo, string ProductCode, string unitCode, string brandID,
                                    string modelId, double dblQty, double dblRate, double dblNetAmnount,
                                    Material_Receipt Mrr);
        [OperationContract]
        short InsertDietcat(DietCategory dietcat);
        [OperationContract]
        short UpdateDietcat(DietCategory dietcat);
        [OperationContract]
        List<DietCategory> LoadDietCategory();
        [OperationContract]
        short InsertFoodcat(FoodCategory dietcat);
        [OperationContract]
        short UpdateFoodcat(FoodCategory dietcat);
        [OperationContract]
        List<FoodCategory> LoadFoodCategory();
        [OperationContract]
        Dictionary<string, string> GetFoodCategory();
        [OperationContract]
        Dictionary<string, string> GetDietCategory();
        [OperationContract]
        short InsertFoodItem(FoodItem Foodcat);
        [OperationContract]
        short UpdateFoodItem(FoodItem foodcat);
        [OperationContract]
        List<FoodItem> LoadFoodItem();
        [OperationContract]
        string InsertFoodMaster(FoodMaster Fm);
        [OperationContract]
        short UpdateFoodMaster(FoodMaster Fm);
        [OperationContract]
        List<FoodMaster> LoadFoodMaster();
        [OperationContract]
        short InsertFoodMenuSetup(FoodMenuSetup FMS);
        [OperationContract]
        short UpdateMenuFoodItem(FoodMenuSetup FMS);
        [OperationContract]
        List<FoodMenuSetup> LoadFoodMenuSetup();
        [OperationContract]
        short InsertServiceSetup(ServiceSetup FS);
        [OperationContract]
        short UpdateServiceSetup(ServiceSetup FS);
        [OperationContract]
        List<ServiceSetup> LoadServiceSetup();
        [OperationContract]
        List<FoodItemRO> GetFoodItem(string Where);
        [OperationContract]
        short InsertFoodTypeSetup(FoodMenuType FMS);
        [OperationContract]
        short UpdateFoodTypeSetup(FoodMenuType FMS);
        [OperationContract]
        List<FoodMenuType> GetFoodMenuType();
        [OperationContract]
        Dictionary<string, string> GetFoodMenuItemSetup();
        [OperationContract]
        Dictionary<string, string> GetFoodTypeSetup();
        [OperationContract]
        short InsertFoodRateItem(string strFoodId, double dblRate, FoodMenuItemSetup FMS);
        [OperationContract]
        short UpdateFoodRateItem(string strFoodId, double dblRate,FoodMenuItemSetup FMS);
        [OperationContract]
        List<FoodMenuItemSetup> LoadFoodItemrate();
        [OperationContract]
        List<FoodMenuItemSetup> DisplayFoodItemrate(string where);
        [OperationContract]
        short InsertMealsetup(MealSetup ms);
        [OperationContract]
        short UpdateMealsetup(MealSetup ms);
        [OperationContract]
        List<MealSetup> LoadmealSetup();
        [OperationContract]
        Dictionary<string, string> LoadWeeklyMealSetup();
        [OperationContract]
        short InsertWeeklysetup(WeeklySetupMeal WS);
        [OperationContract]
        short UpdateWeeklysetup(WeeklySetupMeal WS);
        [OperationContract]
        List<WeeklySetupMeal> GetWeeklyMealSetup();
        [OperationContract]
        List<WeeklyEmpMealRegister> GetWeeklySetmenu();
        [OperationContract]
        List<WeeklyEmpMealRegister> DisplaySetmenuDetails(string Where);
        [OperationContract]
        Dictionary<string, string> GetEmp(string type);

        [OperationContract]
        string InsertMealRegistermaster(WeeklyEmpMealRegister WS);
        [OperationContract]
        //string InsertMealRegister(string RefNo,WeeklyEmpMealRegister WS);
        string InsertMealRegister(string strRefNo, string setMenu, double dblMealRate, WeeklyEmpMealRegister WS);

        [OperationContract]
        List<WeeklyEmpMealRegister> GetWeeklySetupregister(string Where, string Where1);
        [OperationContract]
        short UpdateMealRegister(WeeklyEmpMealRegister WS);
        [OperationContract]
        List<WeeklySetupMeal> LaodWeeklySetMenuType();
        [OperationContract]
        EmployeeMaster GetEmpMaster(string ID);
        [OperationContract]
        List<WeeklyChart> LaodWeeklyChart(string strSetMenuTypeID);
        [OperationContract]
        List<FoodMenuItemSetup> GetVisitorsMenuItem(string strSetMenuTypeID);
        [OperationContract]
        string InsertVisitorsMaster(Visitors Vs);
        [OperationContract]
        short InsertVisitorsTran(string strInvNo, string strFoodID, double dblQnty, double dblRate, double dblDiscount, double dblTotal, Visitors Vs);
        [OperationContract]
        List<Visitors> GetVisitors(string where);
        [OperationContract]
        List<Visitors> DisplaytVisitors(string where);
        [OperationContract]
        int UpdateVisitorsMaster(string strInvoiceNo, Visitors Vs);
        [OperationContract]
        List<FoodMaster> LoadFoodItemFromCat(string where);
        [OperationContract]
        List<FoodMaster> GetItemRate(string where);
        [OperationContract]
        List<FoodMenuItemSetup> GetFoodMenuItemSetupFromMenuID(string CallName, string Where);
        [OperationContract]
        string InsertVisitorsOrderTran(Visitors Vs);
        [OperationContract]
        List<VisitorsSlipRO> GetVisitorsSlipRo(string Pcall, string Where);
        [OperationContract]
        AccountsPayment GetCollectionAmount(string userID, string date);
        [OperationContract]
        short InsertUserCloseRegister(AccountsPayment tktFee);
        [OperationContract]
        Dictionary<string, string> GetMealID();
        [OperationContract]
        Dictionary<string, string> GetWeeklySetmenuDetiails(string MealId, string MealName);
        [OperationContract]
        List<MealSetup> GetMealTime();
        [OperationContract]
        Dictionary<string, string> LoadSetmenu(string where, string where1);

        [OperationContract]
        string GetBarcodeLevel(string strBarcode);
        [OperationContract]
        short UpdateIssue(string strCardNo, string strMealID, string strDate);

        [OperationContract]
        List<DailyCollectionRO> LoadDailyCollection(string where, string CallName, string Fdate, string Tdate);

        [OperationContract]
        List<VisitorsSlipRO> GetFoodItemCollection(string where, string CallName, string Fdate, string Tdate);

        [OperationContract]
        List<DailyCollectionRO> LoadStaffCollection(string where, string CallName, string Fdate, string Tdate);

        [OperationContract]
        List<Visitors> GetvisitorsHistory(string where);
        [OperationContract]
        long GetTotalAttendance(string where);
        [OperationContract]
        List<FoodItem> GetFoodID(string where);
        [OperationContract]
        List<DailyCollectionRO> LoadStaffIssuesd(string where, string CallName, string Fdate, string Tdate);
        [OperationContract]
        List<VisitorsSlipRO> GetVisitorsCollection(string where, string CallName, string Fdate, string Tdate);
        [OperationContract]
        List<DailyCollectionRO> LoadUserwiseCollection(string where, string CallName, string Fdate, string Tdate);
        [OperationContract]
        List<VisitorsSlipRO> GetVisitorsItemDetails(string where, string CallName, string Fdate, string Tdate);
        [OperationContract]
        List<Visitors> GetvisitorsHistoryDateRange(string where, string where1, string where2);
        [OperationContract]
        List<VisitorsSlipRO> GetEmpStaffItem(string where, string where1, string where2);
        [OperationContract]
        FoodSubsidy GetFoodSubsidy(string EmpID);
        [OperationContract]
        List<WeeklySetupMeal> GetWeeklyDayMeal(string where, string where1);
        [OperationContract]
        string InsertInventory(Inventory inv);

        [OperationContract]
        List<Inventory> GetMonthVoucher(int intVtype);
        [OperationContract]
        List<Inventory> DisplayVoucher(string where);
        [OperationContract]
        string UpdateInventory(Inventory inv);
        [OperationContract]
        List<Inventory> GetClosingQty(string where);
        [OperationContract]
        List<InventoryRO> GetfnbInventoryDetails(string PfDate, string pTdate);

        [OperationContract]
        Dictionary<string, string> GetDietSubType();

        [OperationContract]
        string SaveDietSubType(DietSubType dst);

        [OperationContract]
        List<DietSubType> DisplaySubType();

        [OperationContract]
        string UpdateDietSubType(DietSubType dst);

        [OperationContract]
        List<WeeklyDietSetup> GetSubType(string Where);
        //HRN
        [OperationContract]
        Dictionary<string, string> GetDeptGroupDicByType(string type);

        [OperationContract]
        Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr);

        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);
        [OperationContract]
        List<MonthwiseMealRegisterRO> GetMonthWiseMealRegister(string strGrpID, string strDepID, string fDate, string tDate);
        [OperationContract]
        string InsertWeeklyDietMenu(WeeklyDietSetup Wds);
        [OperationContract]
        string UpdatetWeeklyDietMenu(WeeklyDietSetup Wds);
        [OperationContract]
        List<WeeklyDietSetup> GetWeeklyDietSetup(string Where);
        [OperationContract]
        List<Visitors> CheckEmpID(string where, string fDate, string tDate);
        [OperationContract]
        List<MonthwiseMealRegisterRO> GetMonthWiseMealRegisterAll(string strGrpID, string strDepID, string fDate, string tDate);




    }
}
