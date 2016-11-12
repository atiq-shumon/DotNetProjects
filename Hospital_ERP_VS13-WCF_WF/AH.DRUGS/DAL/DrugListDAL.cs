using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.Shared.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.DRUGS.MODEL;

namespace AH.DRUGS.DAL
{
    public class DrugsListDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
      

        #region 

        public List<DrugDose> GetDrugDoseListForAll()
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGS_DOSE_ForAll";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }
        public List<DrugDose> GetDrugDoseList(string patage)
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGS_DOSE_List";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input)
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }
        public List<DrugDose> GetDrugDoseListByDrugName(string patage,string drugname)
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGS_DOSE_List_ByDrugName";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input),
             new OracleParameter ("DrugName",OracleDbType.Varchar2,300,drugname,ParameterDirection.Input)
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }
        public List<DrugDose> GetDrugDoseByDrugIPD(string patage, string drugname)
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGSList_ByDrugIPD";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input),
             new OracleParameter ("DrugName",OracleDbType.Varchar2,300,drugname,ParameterDirection.Input)
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }
        public List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname)
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGS_ByGenericName";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input),
             new OracleParameter ("DrugName",OracleDbType.Varchar2,300,groupname,ParameterDirection.Input)
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }
        public List<DrugDose> GetDrugDoseByGroupNameIPD(string patage, string groupname)
        {
            string packageName = "AGH_PHRMS.pkg_Drugs.GET_DRUGS_ByGenericNameIPD";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input),
             new OracleParameter ("DrugName",OracleDbType.Varchar2,300,groupname,ParameterDirection.Input)
            };

            return GetGrugListDoseDetails(packageName, parameterList);
        }

        private List<DrugDose> GetGrugListDoseDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DrugDose> rDRSs = new List<DrugDose>();
            IDataReader reader = null;

            DrugDose oDrugMaster = new DrugDose();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oDrugMaster.EntryParameter = oEntryParameter;
            rDRSs.Add(oDrugMaster);
            try
            {
                reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
                if (reader.FieldCount > 0)
                {
                    rDRSs = CreateObjects(reader);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return rDRSs;
        }
        #region DataReaderMappingwithNUll

        private DrugDose MapObject(NullHandler oReader)
        {
            DrugDose oDose = new DrugDose(); 
            DrugMaster oDrugMaster = new DrugMaster();
            EntryParameter oEntryParameter = new EntryParameter();
            DrugGroup oDrugGroup = new DrugGroup();

            DrugCompany oDrugCompany = new DrugCompany();
            DrugUnit oDrugUnit = new DrugUnit();
            DrugPackType oDrugPackType = new DrugPackType();
            ConsumptionForm ocons = new ConsumptionForm();

            oDrugMaster.ID = oReader.GetString("DrugID");
            oDrugMaster.Name = oReader.GetString("DrugName");
            oDrugMaster.NameBeng = oReader.GetString("DrugNameBangla");
            oDrugMaster.StockQty = (Convert.ToSingle(oReader.GetString("STOCKQTY")));
            oDrugCompany.ID = oReader.GetString("CompanyID");
            oDrugCompany.Name = oReader.GetString("CompanyName");

            oDrugGroup.ID = oReader.GetString("GroupID");
            oDrugGroup.Name = oReader.GetString("GroupName");
            oDrugGroup.NameBeng = oReader.GetString("GroupNameBangla");

            oDrugPackType.ID = oReader.GetString("TypeID");
            oDrugPackType.Name = oReader.GetString("PackName");
            oDrugPackType.NameBeng = oReader.GetString("PackNameBangla");


            oDrugUnit.ID = oReader.GetString("UnitID");
            oDrugUnit.Name = oReader.GetString("UnitName");
            oDrugUnit.NameBeng = oReader.GetString("UnitNameBangla");

            oDrugMaster.DrugGroup = oDrugGroup;
            // oDrugMaster.Drug = oDrugMaster;
            oDrugMaster.DrugPackType = oDrugPackType;
            oDrugMaster.DrugCompany = oDrugCompany;
            oDrugMaster.DrugUnit = oDrugUnit;

            oDose.DrugMaster = oDrugMaster;
            
            oDose.DoseStr = oReader.GetString("DOSE_STR");
            oDose.RouteID = oReader.GetString("Route_ID");

            oDose.BeforeAfterMeal = oReader.GetChar("B_A_Meal");
            oDose.MealTimeGap = oReader.GetString("Meal_Time_Duration");
            oDose.MealName = oReader.GetString("Meal_Name");

            oDose.DurationPeriod = oReader.GetString("Min_Use_Duration");
            oDose.DurationIndicator = oReader.GetChar("Dur_Indicator");
            oDose.DoseConsQty = oReader.GetString("CONSUMPTIONQTY");

            ocons.ID = oReader.GetString("CONSFORMID");
            ocons.Name = oReader.GetString("CONSFORMNAME");
            oDose.ConsumptionForm = ocons;

            oDose.EntryParameter = oEntryParameter;


            return oDose;
        }

        private DrugDose CreateObject(NullHandler oReader)
        {
            DrugDose oDRS = new DrugDose();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private List<DrugDose> CreateObjects(IDataReader oReader)
        {
            List<DrugDose> rDRSs = new List<DrugDose>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                DrugDose oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion



        #endregion

    }
}
