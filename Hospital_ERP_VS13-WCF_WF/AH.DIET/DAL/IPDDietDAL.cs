using AH.DIET.MODEL;
using AH.DUtility;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.DIET.DAL
{
   public  class IPDDietDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;

        public string SaveIPDPatientDiet(IPDDiet diet)
        {
            packageName = "AGH_IPD.Pkg_IPD_Diet.T_IPD_PAT_DIET_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("p_Nurse_Station_Id",OracleDbType.Varchar2,5,diet.NurseStationID,ParameterDirection.Input), 
                new OracleParameter("p_admission_id",OracleDbType.Varchar2,30,diet.AdmissionID,ParameterDirection.Input),
                new OracleParameter("p_diet_id",OracleDbType.Varchar2,30,diet.DietTypeID,ParameterDirection.Input),    
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,diet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,diet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,diet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,diet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0]};
            if ((OracleDecimal)prm[0].Value == 1)
                return "1";
            else return "0";
        }
        public List<IPDDiet> GetDietType()
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_DIET_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)               
            };
            return GetDietType(packageName, parameterList);
        }
        public List<IPDDiet> GetNurseStnWiseDietType(string nsID,DateTime date)
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_NS_Wise_DIET_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)  ,
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,5,nsID,ParameterDirection.Input),
                new OracleParameter("p_date",OracleDbType.Date,15,date,ParameterDirection.Input)
            };
            return GetDietType(packageName, parameterList);
        }
        public List<IPDDiet> DietTypeOrderedDelevered(string nsID, DateTime date)
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_DIET_TYPE_For_Delevered";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,5,nsID,ParameterDirection.Input),
                new OracleParameter("p_date",OracleDbType.Date,15,date,ParameterDirection.Input)
            };
            return GetDietType(packageName, parameterList);
        }
        private List<IPDDiet> GetDietType(string packageName, OracleParameter[] parameterList)
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDDiet diet = new IPDDiet();
                diet.DietTypeID = (string)rdr["DIET_TYPE_ID"];
                diet.DietTypeTitle = (string)rdr["DIET_TYPE_NAME"];
                diets.Add(diet);
            }
            rdr.Close();
            return diets;
        }
        public List<IPDDiet> Total(DateTime p_date, string mealId)
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_Total_Order_Count";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_date",OracleDbType.Date,15,p_date,ParameterDirection.Input),
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,5,mealId,ParameterDirection.Input)
            };
            return Total(packageName, parameterList);
        }
        private List<IPDDiet> Total(string packageName, OracleParameter[] parameterList)
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDDiet diet = new IPDDiet();
                diet.DietTypeID = (string)rdr["DIET_TYPE_ID"];
                diet.Total = (decimal)rdr["Total"];
                diet.DietTypeTitle = (string)rdr["DIET_TYPE_NAME"];
                //diet.DietDateTime = (DateTime)rdr["DIET_DATE"];
                diets.Add(diet);
            }
            rdr.Close();
            return diets;
        }
        public List<IPDDiet> GetTotalOrderList(DateTime p_date, string mealId)
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_Total_Order_List";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_date",OracleDbType.Date,15,p_date,ParameterDirection.Input),
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,5,mealId,ParameterDirection.Input)
            };
            return GetTotalOrderList(packageName, parameterList);
        }
        private List<IPDDiet> GetTotalOrderList(string packageName, OracleParameter[] parameterList)
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDDiet diet = new IPDDiet();
                diet.DietTypeID = (string)rdr["DIET_TYPE_ID"];
                diet.DietTypeTitle = (string)rdr["DIET_TYPE_NAME"];              
                diet.NurseStationTitle = (string)rdr["ns_title"];
                diets.Add(diet);
            }
            rdr.Close();
            return diets;
        }
        public List<IPDDiet> GetIPDDiet(string nurseStationID)
        {
            string packageName = "AGH_IPD.Pkg_IPD_Diet.GET_IPD_PAT_DIET_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("P_NS_ID",OracleDbType.Varchar2,5,nurseStationID,ParameterDirection.Input)
            };
            return GetIPDDiet(packageName, parameterList);
        }
        private List<IPDDiet> GetIPDDiet(string packageName, OracleParameter[] parameterList)
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                IPDDiet diet = new IPDDiet();
                diet.DietTypeID = (string)rdr["DIET_TYPE_ID"];
                diet.DietTypeTitle = (string)rdr["DIET_Title"];
                diet.AdmissionID = (string)rdr["REG_ID"];
                diets.Add(diet);
            }
            rdr.Close();
            return diets;
        }
        public string SaveIPDPatientDietReg(IPDDiet diet)
        {
            packageName = "AGH_IPD.Pkg_IPD_Diet.T_IPD_DIET_REG";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("p_Nurse_Station_Id",OracleDbType.Varchar2,5,diet.NurseStationID,ParameterDirection.Input),
                new OracleParameter("p_DateTime",OracleDbType.Date,15,diet.DietDateTime,ParameterDirection.Input),
                new OracleParameter("p_admission_id",OracleDbType.Varchar2,30000,diet.AdmissionID,ParameterDirection.Input),
                new OracleParameter("p_diet_id",OracleDbType.Varchar2,30,diet.DietTypeID,ParameterDirection.Input), 
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,30,diet.MealSetup.MealID,ParameterDirection.Input), 
                new OracleParameter("p_food_id",OracleDbType.Varchar2,30,diet.FoodItem.ItemID,ParameterDirection.Input), 
                new OracleParameter("p_Bill",OracleDbType.Decimal,diet.Bill,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,diet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,diet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,diet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,diet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0] };
            if ((OracleDecimal)prm[0].Value == 1)
                return "1";
            else return "0";
        }
        public string UpdateOrderedIPDPatientDietList(IPDDiet diet)
        {
            packageName = "AGH_IPD.Pkg_IPD_Diet.Update_T_IPD_DIET_REG_Ordr_Com";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("p_Nurse_Station_Id",OracleDbType.Varchar2,5,diet.NurseStationID,ParameterDirection.Input),
                new OracleParameter("p_DateTime",OracleDbType.Date,15,diet.DietDateTime,ParameterDirection.Input),
                new OracleParameter("p_admission_id",OracleDbType.Varchar2,30000,diet.AdmissionID,ParameterDirection.Input),
                new OracleParameter("p_diet_id",OracleDbType.Varchar2,30,diet.DietTypeID,ParameterDirection.Input), 
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,30,diet.MealSetup.MealID,ParameterDirection.Input), 
                new OracleParameter("p_food_id",OracleDbType.Varchar2,30,diet.FoodItem.ItemID,ParameterDirection.Input), 
                new OracleParameter("p_Bill",OracleDbType.Decimal,diet.Bill,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,diet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,diet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,diet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,diet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0] };
            if ((OracleDecimal)prm[0].Value == 1)
                return "1";
            else return "0";
        }
        public string UpdateFoodServedtDietList(IPDDiet diet)
        {
            packageName = "AGH_IPD.Pkg_IPD_Diet.Up_T_IPD_DIET_REG_Food_Serv";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,30,null,ParameterDirection.Output),
                new OracleParameter("p_Nurse_Station_Id",OracleDbType.Varchar2,5,diet.NurseStationID,ParameterDirection.Input),
                new OracleParameter("p_DateTime",OracleDbType.Date,15,diet.DietDateTime,ParameterDirection.Input),
                new OracleParameter("p_admission_id",OracleDbType.Varchar2,30000,diet.AdmissionID,ParameterDirection.Input),
                new OracleParameter("p_diet_id",OracleDbType.Varchar2,30,diet.DietTypeID,ParameterDirection.Input), 
                new OracleParameter("p_meal_id",OracleDbType.Varchar2,30,diet.MealSetup.MealID,ParameterDirection.Input), 
                new OracleParameter("p_food_id",OracleDbType.Varchar2,30,diet.FoodItem.ItemID,ParameterDirection.Input), 
                new OracleParameter("p_Bill",OracleDbType.Decimal,diet.Bill,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,diet.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,diet.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,diet.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,diet.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter[] prm = { parameterList[0] };
            if ((OracleDecimal)prm[0].Value == 1)
                return "1";
            else return "0";
        }
    }
}
