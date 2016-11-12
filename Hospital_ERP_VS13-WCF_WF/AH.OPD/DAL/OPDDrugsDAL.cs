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
using AH.OPD.MODEL;
using AH.DRUGS.MODEL;


namespace AH.OPD.DAL
{
    public class OPDDrugsDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
        public List<OPDDrugs> GetOpdDrugs()
        {
            string packageName = "AGH_OPD.PKG_OPD.GET_OPD_DRUGS";
            OracleParameter[] parameterList = new OracleParameter[] 
               {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               };
            return GetOpdDrugLists(packageName, parameterList);
        }

        public List<OPDDrugs> GetOpdDrugsTkt(string tktno)
        {
            string packageName = "AGH_OPD.PKG_OPD.GET_OPD_DRUGS";
            OracleParameter[] parameterList = new OracleParameter[] 
               {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("TicketNo",OracleDbType.Varchar2,30,tktno,ParameterDirection.Input)
               };
            return GetOpdDrugLists(packageName, parameterList);
        }

        private List<OPDDrugs> GetOpdDrugLists(string packageName, OracleParameter[] parameterList)
        {
            List<OPDDrugs> oDrugsList = new List<OPDDrugs>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                OPDDrugs oDrugs= new OPDDrugs();

                DrugDose dm = new DrugDose();
                dm.DoseStr = (string)rdr["DOSE_STR"];
                dm.RouteID = (string)rdr["DOSE_ROUTE_ID"];
                dm.BeforeAfterMeal = char.Parse(rdr["B_A_MEAL"].ToString());
                dm.MealTimeDuration = Int32.Parse(rdr["MEAL_T_GAP"].ToString());
                dm.MealID = char.Parse(rdr["MEAL_INDICATOR"].ToString());
                dm.MinUseDuration = Int32.Parse(rdr["DURATION"].ToString());
                dm.DurationIndicator = char.Parse(rdr["DUR_IND"].ToString());

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DRUG_ID"];
                omaster.Name = (string)rdr["DrugName"];
                omaster.Remarks = (string)rdr["REMARKS"];
                omaster.Urate = Single.Parse(rdr["URATE"].ToString());
                omaster.VAT = Single.Parse(rdr["VAT"].ToString());
                omaster.Discount = Single.Parse(rdr["DISC"].ToString());
                omaster.Rackrate = Single.Parse(rdr["RACK_RATE"].ToString());
                omaster.Slrate = Single.Parse(rdr["SL_RATE"].ToString());
                omaster.StockQty = Single.Parse(rdr["STOCK_QTY"].ToString());
                omaster.TotalQty = Single.Parse(rdr["T_AMT"].ToString());
                //omaster.CalculatedQty = Single.Parse(rdr["CalculatedQty"].ToString());
                omaster.RemainingQty = Single.Parse(rdr["RemainingQty"].ToString());

                DrugCompany com = new DrugCompany();
                com.ID = (string)rdr["DRUG_COMP_ID"];
                com.Name = (string)rdr["CompanyName"];
                omaster.DrugCompany = com;
                DrugGroup gr = new DrugGroup();
                gr.ID = (string)rdr["GROUP_ID"];
                gr.Name = (string)rdr["GroupName"];
                omaster.DrugGroup = gr;
                DrugUnit unit = new DrugUnit();
                unit.ID = (string)rdr["DRUG_UNIT_ID"];
                unit.Name = (string)rdr["UnitName"];
                omaster.DrugUnit = unit;
                DrugPackType type = new DrugPackType();
                type.ID = (string)rdr["DRUG_TYPE_ID"];
                type.Name = (string)rdr["TypeName"];
                omaster.DrugPackType = type;

                dm.DrugMaster = omaster;

                Prescription oPrescription = new Prescription();
                oPrescription.TicketNo = (string)rdr["TKT_NO"];
                oDrugs.DrugDose = dm;
                oDrugs.Prescription = oPrescription;
                oDrugsList.Add(oDrugs);
            }
            rdr.Close();
            return oDrugsList;
        }
         
        #region FauzulOPDDrugs
        public List<DrugDose> GetMedicineListOPD(string drugid, string patage)
        {
            string packageName = "AGH_OPD.PKG_OPD.GET_DRUGS_OPD";
            //wherecondition = " where Unit_ID = 01";
            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_drug_name",OracleDbType.Varchar2,30,drugid,ParameterDirection.Input),
             new OracleParameter ("p_patage",OracleDbType.Varchar2,300,patage,ParameterDirection.Input)
            };

            return GetMedicineListOPDDetails(packageName, parameterList);
        }

        private List<DrugDose> GetMedicineListOPDDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DrugDose> rDRSs = new List<DrugDose>();
            IDataReader reader = null;

            DrugDose oDrugDose = new DrugDose();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oDrugDose.EntryParameter = oEntryParameter;
            rDRSs.Add(oDrugDose); 
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
            DrugDose oDrugDose = new DrugDose();
            EntryParameter oEntryParameter = new EntryParameter();
            DrugGroup oDrugGroup = new DrugGroup();
            
            DrugCompany oDrugCompany = new DrugCompany();
            DrugUnit oDrugUnit = new DrugUnit();
            DrugPackType oDrugPackType = new DrugPackType();

            oDrugDose.DrugMaster.ID = oReader.GetString("DrugID");
            oDrugDose.DrugMaster.Name = oReader.GetString("DrugName");
            oDrugDose.DrugMaster.NameBeng = oReader.GetString("DrugNameBangla");
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

         
            oDrugDose.DoseDrug = oReader.GetString("DOSE_STR");
            oDrugDose.RouteID = oReader.GetString("Route_ID");

            oDrugDose.BeforeAfterMeal = oReader.GetChar("B_A_Meal");
            oDrugDose.MealTimeGap = oReader.GetString("Meal_Time_Duration");
            oDrugDose.MealID = oReader.GetChar("Meal_Name");

            oDrugDose.DurationPeriod = oReader.GetString("Min_Use_Duration");
            oDrugDose.DurationPeriod = oReader.GetString("Dur_Indicator");

            oDrugDose.EntryParameter = oEntryParameter;
            oDrugDose.DrugMaster.DrugGroup = oDrugGroup;
           // oDrugDose.Drug = oDrugDose;
            oDrugDose.DrugMaster.DrugPackType = oDrugPackType;
            oDrugDose.DrugMaster.DrugCompany = oDrugCompany;
            oDrugDose.DrugMaster.DrugUnit = oDrugUnit;

            return oDrugDose;
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
