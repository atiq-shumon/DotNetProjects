using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.DRUGS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.Shared.MODEL;


namespace AH.DRUGS.DAL
{
    public class DrugSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region GetDrugCompany
        public List<DrugCompany> GetDrugCompany()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_COMP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };
            return GetDrugs(packageName, parameterList);
        }
       
        private List<DrugCompany> GetDrugs(string packageName, OracleParameter[] parameterList)
        {
            List<DrugCompany> dgcom = new List<DrugCompany>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugCompany dg = new DrugCompany();
                dg.ID = (string)rdr["id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Address = (string)rdr["address"].ToString();
                dg.Web = (string)rdr["web"].ToString();
                dg.Phone = (string)rdr["phone"].ToString();
                dg.Fax = (string)rdr["fax"].ToString();
                dg.Email = (string)rdr["email"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                dgcom.Add(dg);
            }
            rdr.Close();
            return dgcom;
        }
        #endregion

        #region GetDrugCompanyDictionary
        public List<DrugCompany> GetDrugCompanyDictionary()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUGCOMP_DIC";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };
            return GetDrugCompany(packageName, parameterList);
        }
        private List<DrugCompany> GetDrugCompany(string packageName, OracleParameter[] parameterList)
        {
            List<DrugCompany> dgcom = new List<DrugCompany>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugCompany dg = new DrugCompany();
                dg.ID = (string)rdr["id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
               
                dgcom.Add(dg);
            }
            rdr.Close();
            return dgcom;
        }
        #endregion

        #region SaveDrugCompany
        public short SaveDrugCompany(DrugCompany dg)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_COMP";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("Name",OracleDbType.Varchar2,200,dg.Name,ParameterDirection.Input),
               new OracleParameter("NameBeng",OracleDbType.Varchar2,200,dg.NameBeng,ParameterDirection.Input),
               new OracleParameter("Address",OracleDbType.Varchar2,300,dg.Address,ParameterDirection.Input),
               new OracleParameter("Web",OracleDbType.Varchar2,30,dg.Web,ParameterDirection.Input),
               new OracleParameter("Phone",OracleDbType.Varchar2,20,dg.Phone,ParameterDirection.Input),
               new OracleParameter("Fax",OracleDbType.Varchar2,20,dg.Fax,ParameterDirection.Input),
               new OracleParameter("E-Mail",OracleDbType.Varchar2,30,dg.Email,ParameterDirection.Input),
               new OracleParameter("Remarks",OracleDbType.Varchar2,200,dg.Remarks,ParameterDirection.Input),
               new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dg.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dg.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("LocationID",OracleDbType.Varchar2,2,dg.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("MachineID",OracleDbType.Varchar2,20,dg.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDrugCompany
        public short UpdateDrugCompany(DrugCompany udg)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_COMP";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
               new OracleParameter("ID",OracleDbType.Varchar2,6,udg.ID,ParameterDirection.Input),
               new OracleParameter("Name",OracleDbType.Varchar2,200,udg.Name,ParameterDirection.Input),
               new OracleParameter("NameBeng",OracleDbType.Varchar2,200,udg.NameBeng,ParameterDirection.Input),
               new OracleParameter("Address",OracleDbType.Varchar2,300,udg.Address,ParameterDirection.Input),
               new OracleParameter("Web",OracleDbType.Varchar2,30,udg.Web,ParameterDirection.Input),
               new OracleParameter("Phone",OracleDbType.Varchar2,20,udg.Phone,ParameterDirection.Input),
               new OracleParameter("Fax",OracleDbType.Varchar2,20,udg.Fax,ParameterDirection.Input),
               new OracleParameter("E-Mail",OracleDbType.Varchar2,30,udg.Email,ParameterDirection.Input),
               new OracleParameter("Remarks",OracleDbType.Varchar2,200,udg.Remarks,ParameterDirection.Input),
               new OracleParameter("EntryBy",OracleDbType.Varchar2,20,udg.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("CompanyID",OracleDbType.Varchar2,2,udg.EntryParameter.CompanyID,ParameterDirection.Input),
               new OracleParameter("LocationID",OracleDbType.Varchar2,2,udg.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("MachineID",OracleDbType.Varchar2,20,udg.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;
        }
        #endregion

        #region GetDrugGroup
        public List<DrugGroup> GetDrugGroup()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_GROUP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            return GetDrugGr(packageName, parameterList);
        }
        private List<DrugGroup> GetDrugGr(string packageName, OracleParameter[] parameterList)
        {
            List<DrugGroup> drgr = new List<DrugGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugGroup dg = new DrugGroup();
                dg.ID = (string)rdr[0].ToString();
                dg.Name = (string)rdr[1].ToString();
                dg.NameBeng = (string)rdr[2].ToString();
                dg.Remarks = (string)rdr[3].ToString();
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveDrugGroup
        public short SaveDrugGroup(DrugGroup drgr)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,drgr.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,drgr.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,drgr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,drgr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,drgr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,drgr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,drgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateGroup
        public short UpdateGroup(DrugGroup ugr)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_GROUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,6,ugr.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ugr.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,ugr.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ugr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ugr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ugr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ugr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ugr.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;
        }
        #endregion

        #region GetDrugUnit
        public List<DrugUnit> GetDrugUnit()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_UNIT";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            return GetDrugUn(packageName, parameterList);
        }
        private List<DrugUnit> GetDrugUn(string packageName, OracleParameter[] parameterList)
        {
            List<DrugUnit> drgr = new List<DrugUnit>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugUnit dg = new DrugUnit();
                dg.ID = (string)rdr[0].ToString();
                dg.Name = (string)rdr[1].ToString();
                dg.NameBeng = (string)rdr[2].ToString();
                dg.Remarks = (string)rdr[3].ToString();
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveDrugUnit
        public short SaveDrugUnit(DrugUnit dunit)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_UNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,dunit.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,dunit.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,dunit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dunit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dunit.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dunit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dunit.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDrugUnit
        public short UpdateDrugUnit(DrugUnit unt)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_UNIT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,unt.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,unt.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,unt.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,unt.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,unt.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,unt.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,unt.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,unt.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;
        }
        #endregion

        #region GetDrugPackType
        public List<DrugPackType> GetDrugPackType()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_PACKTYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            return GetDrugPack(packageName, parameterList);
        }
        private List<DrugPackType> GetDrugPack(string packageName, OracleParameter[] parameterList)
        {
            List<DrugPackType> drgr = new List<DrugPackType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugPackType dg = new DrugPackType();
                dg.ID = (string)rdr["type_id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveDrugPackType
        public short SaveDrugPackType(DrugPackType pack)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_PACKTYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,pack.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,pack.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,pack.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,pack.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,pack.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,pack.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,pack.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDrugPackType
        public short UpdateDrugPackType(DrugPackType upac)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_PACKTYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,upac.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,upac.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,upac.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,upac.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,upac.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,upac.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,upac.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,upac.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;

        }
        #endregion

        #region SaveDrugMaster

        public short SaveDrugMaster(DrugMaster ms)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DrugCompany",OracleDbType.Varchar2,6,ms.DrugCompany.ID,ParameterDirection.Input),
                new OracleParameter("DrugGroup",OracleDbType.Varchar2,6,ms.DrugGroup.ID,ParameterDirection.Input),
                new OracleParameter("DrugUnit",OracleDbType.Varchar2,4,ms.DrugUnit.ID,ParameterDirection.Input),
                new OracleParameter("DrugPacket",OracleDbType.Varchar2,4,ms.DrugPackType.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,ms.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,ms.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ms.Remarks,ParameterDirection.Input),
                new OracleParameter("ReorderQuantity",OracleDbType.Int32,ms.ReorderQty,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int32,ms.Priority,ParameterDirection.Input),
                new OracleParameter("SerialPriority",OracleDbType.Int32,ms.SerialPriority,ParameterDirection.Input),
                new OracleParameter("DrugDoseDetails",OracleDbType.Varchar2,5000,ms.DrugDoseString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ms.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDrugMaster

        public List<DrugMaster> GetDrugMasterByCompany(string drugcompany)
        {
            string packageName = "PKG_DRUG_SETUP.Get_Drug_List_ByCompany";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("CompanyId",OracleDbType.Varchar2,6,drugcompany,ParameterDirection.Input)
            };
            return GetDrugMas(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugMaster()
        {
            string packageName = "PKG_DRUG_SETUP.Get_Drug_List";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDrugMas(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugMasterList(string drugName)
        {
            string packageName = "PKG_DRUG_SETUP.Get_Drug_List";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugName",OracleDbType.Varchar2,500,drugName,ParameterDirection.Input)
            };
            return GetDrugMas(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugMasterListCompanyWise(string drugName,string company)
        {
            string packageName = "PKG_DRUG_SETUP.Get_Drug_List";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugName",OracleDbType.Varchar2,500,drugName,ParameterDirection.Input),
                new OracleParameter("DrugCompany",OracleDbType.Varchar2,500,company,ParameterDirection.Input)
            };
            return GetDrugMas(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugListCompanyWise(string company)
        {
            string packageName = "PKG_DRUG_SETUP.Get_DrugName_CompanyWise";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugCompany",OracleDbType.Varchar2,500,company,ParameterDirection.Input)
            };
            return GetDrugMas(packageName, parameterList);
        }
        private List<DrugMaster> GetDrugMas(string packageName, OracleParameter[] parameterList)
        {
            List<DrugMaster> drls = new List<DrugMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugMaster dm = new DrugMaster();
                dm.ID = (string)rdr["DrugID"];
                dm.Name = (string)rdr["DrugName"];
                dm.NameBeng = (string)rdr["DrugNameBangla"];
                dm.ReorderQty = int.Parse(rdr["REORDER_QTY"].ToString());
                //dm.Dose = (string)rdr[15];
                //dm.Route = (string)rdr[16];
                //dm.BeforeAfterMeal = char.Parse(rdr[17].ToString());
                //dm.MealTimeDuration = int.Parse(rdr[18].ToString());
                //dm.MealName = char.Parse(rdr[19].ToString());
                //dm.MinUseDuration = int.Parse(rdr[20].ToString());
                //dm.DurationIndicator = char.Parse(rdr[21].ToString());

                dm.Priority = int.Parse(rdr["PRIORITY"].ToString());
                dm.SerialPriority = int.Parse(rdr["SERIAL_PRIORITY"].ToString());
                dm.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                dm.Urate = Single.Parse(rdr["URATE"].ToString());
                dm.VAT = Single.Parse(rdr["VAT"].ToString());
                dm.Discount = Single.Parse(rdr["DISC"].ToString());
                dm.Rackrate = Single.Parse(rdr["RACK_RATE"].ToString());
                dm.Slrate = Single.Parse(rdr["SL_RATE"].ToString());
                dm.StockQty = Int32.Parse(rdr["STOCK_QTY"].ToString());

                DrugCompany dc = new DrugCompany();
                dc.ID = (string)rdr["CompanyID"];
                dc.Name = (string)rdr["CompanyName"];
                dm.DrugCompany = dc;

                DrugGroup dg = new DrugGroup();
                dg.ID = (string)rdr["GroupID"];
                dg.Name = (string)rdr["GroupName"];
                dg.NameBeng = (string)rdr["GroupNameBangla"];
                dm.DrugGroup = dg;

                DrugPackType dpac = new DrugPackType();
                dpac.ID = (string)rdr["TypeID"];
                dpac.Name = (string)rdr["PackName"];
                dpac.NameBeng = (string)rdr["PackNameBangla"];
                dm.DrugPackType = dpac;

                DrugUnit un = new DrugUnit();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];
                un.NameBeng = (string)rdr["UnitNameBangla"];
                dm.DrugUnit = un;


                drls.Add(dm);
            }
            rdr.Close();
            return drls;
        }
        #endregion

        #region UpdateDrugMaster
        public short UpdateDrugMaster(DrugMaster ums)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),                
                new OracleParameter("DrugCompany",OracleDbType.Varchar2,6,ums.DrugCompany.ID,ParameterDirection.Input),
                new OracleParameter("DrugGroup",OracleDbType.Varchar2,6,ums.DrugGroup.ID,ParameterDirection.Input),
                new OracleParameter("DrugUnit",OracleDbType.Varchar2,4,ums.DrugUnit.ID,ParameterDirection.Input),
                new OracleParameter("DrugPacket",OracleDbType.Varchar2,4,ums.DrugPackType.ID,ParameterDirection.Input),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,ums.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,ums.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,ums.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ums.Remarks,ParameterDirection.Input),
                new OracleParameter("ReorderQuantity",OracleDbType.Int32,ums.ReorderQty,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int32,ums.Priority,ParameterDirection.Input),
                new OracleParameter("SerialPriority",OracleDbType.Int32,ums.SerialPriority,ParameterDirection.Input),
                new OracleParameter("DrugDoseDetails",OracleDbType.Varchar2,5000,ums.DrugDoseString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ums.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ums.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ums.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ums.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveDrugDose
        public short SaveDrugDose(DrugDose dr)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_DOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,dr.DrugMaster.ID,ParameterDirection.Input),
                new OracleParameter("AgeGroup",OracleDbType.Varchar2,2,dr.AgeGroup,ParameterDirection.Input),
                new OracleParameter("Dose",OracleDbType.Varchar2,10,dr.DoseStr,ParameterDirection.Input),
                new OracleParameter("Route",OracleDbType.Varchar2,3,dr.RouteID,ParameterDirection.Input),
                new OracleParameter("BeforeAfterMeal",OracleDbType.Char,1,dr.BeforeAfterMeal,ParameterDirection.Input),
                new OracleParameter("MealTimeDuration",OracleDbType.Int32,dr.MealTimeDuration,ParameterDirection.Input),
                new OracleParameter("MealTime",OracleDbType.Char,1,dr.MealID,ParameterDirection.Input),
                new OracleParameter("MinUseDuration",OracleDbType.Int32,dr.MinUseDuration,ParameterDirection.Input),
                new OracleParameter("DurationIndicator",OracleDbType.Char,1,dr.DurationIndicator,ParameterDirection.Input),
                new OracleParameter("ConsQty",OracleDbType.Int32,4,dr.ConsumptionForm.ConsQty,ParameterDirection.Input),
                new OracleParameter("ConsForm",OracleDbType.Varchar2,3,dr.ConsumptionForm.ID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateDrugDose
        public short UpdateDrugDose(DrugDose dr)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_DOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,dr.DrugMaster.ID,ParameterDirection.Input),
                new OracleParameter("AgeGroup",OracleDbType.Varchar2,2,dr.AgeGroup,ParameterDirection.Input),
                new OracleParameter("Dose",OracleDbType.Varchar2,10,dr.DoseStr,ParameterDirection.Input),
                new OracleParameter("Route",OracleDbType.Varchar2,3,dr.RouteID,ParameterDirection.Input),
                new OracleParameter("BeforeAfterMeal",OracleDbType.Char,1,dr.BeforeAfterMeal,ParameterDirection.Input),
                new OracleParameter("MealTimeDuration",OracleDbType.Int32,dr.MealTimeDuration,ParameterDirection.Input),
                new OracleParameter("MealTime",OracleDbType.Char,1,dr.MealID,ParameterDirection.Input),
                new OracleParameter("MinUseDuration",OracleDbType.Int32,dr.MinUseDuration,ParameterDirection.Input),
                new OracleParameter("DurationIndicator",OracleDbType.Char,1,dr.DurationIndicator,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,dr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,dr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,dr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,dr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetDrugDose
        public List<DrugDose> GetDrugDose()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_DOSE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<DrugDose> drdose = new List<DrugDose>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugDose dr = new DrugDose();

                dr.AgeGroup = (string)rdr["age_group"];

                dr.DoseStr = (string)rdr["dose_str"];
                dr.RouteID = (string)rdr["route_id"];
                dr.BeforeAfterMeal = char.Parse(rdr["b_a_meal"].ToString());
                dr.MealTimeDuration = int.Parse(rdr["meal_time_duration"].ToString());
                dr.MealID = char.Parse(rdr["meal_name"].ToString());
                dr.MinUseDuration = int.Parse(rdr["min_use_duration"].ToString());
                dr.DurationIndicator = char.Parse(rdr["dur_indicator"].ToString());
                dr.RouteName = (string)rdr["RouteName"];
                dr.B_A_MealName = (string)rdr["B_A_MealName"];
                dr.M_T_DurationName = (string)rdr["MealTimeDurName"];
                dr.MealName = (string)rdr["MealName"];
                dr.AgeGroupName = (string)rdr["AgeGroupName"];
                dr.Dur_Ind_Name = (string)rdr["Dur_IndicatorName"];

                ConsumptionForm ocons = new ConsumptionForm();
                ocons.ConsQty = float.Parse(rdr["cons_qty"].ToString());
                ocons.ID = (string)rdr["cons_form_id"];
                ocons.Name = (string)rdr["ConsumptionFormName"];
                dr.ConsumptionForm = ocons;


                DrugMaster dc = new DrugMaster();
                dc.ID = (string)rdr["drug_id"];
                dc.Name = (string)rdr["DrugName"];
                dr.DrugMaster = dc;

                drdose.Add(dr);
            }
            rdr.Close();
            return drdose;

        }
        #endregion

        #region GetConsumption
        public List<ConsumptionForm> GetConsumption()
        {
            string packageName = "PKG_DRUG_SETUP.GET_CONSUMPTION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<ConsumptionForm> olist = new List<ConsumptionForm>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ConsumptionForm ocons = new ConsumptionForm();
                ocons.ID = (string)rdr["Form_ID"];
                ocons.Name = (string)rdr["Name"];
                ocons.NameBeng = (string)rdr["Name_Beng"];
                ocons.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                olist.Add(ocons);
            }
            rdr.Close();
            return olist;
        }
        #endregion

        #region SaveDrugConsumption
        public string SaveDrugConsumption(ConsumptionForm odrug)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_CONSUMPTION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,3,odrug.ID,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,odrug.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,odrug.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odrug.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odrug.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odrug.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odrug.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odrug.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region ModifyDrugConsumption
        public short ModifyDrugConsumption(ConsumptionForm odrug)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_CONSUMPTION";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,3,odrug.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,odrug.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,odrug.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odrug.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odrug.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odrug.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odrug.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odrug.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
        //private string connString = Utility.GetConnectionString(Utility.Module.OPDMIS);
        string packageName = string.Empty;

        #region Search
        public List<DrugMaster> GetMedicineList(string MedicineName)
        {
            string packageName = "AGH_PHRMS.PKG_DRUG_SETUP.Get_Drug_List";

            //wherecondition = " where Unit_ID = 01";

            OracleParameter[] parameterList = new OracleParameter[]
            {             
             new OracleParameter ("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),  
             new OracleParameter ("p_DrugName",OracleDbType.Varchar2,300,MedicineName,ParameterDirection.Input)             
            };

            return GetMedicineListDetails(packageName, parameterList);
        }
        private List<DrugMaster> GetMedicineListDetails(string packageName, OracleParameter[] parameterList)
        {
            List<DrugMaster> rDRSs = new List<DrugMaster>();
            IDataReader reader = null;

            DrugMaster oMedicine = new DrugMaster();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.ErrorMessage = "";
            oMedicine.EntryParameter = oEntryParameter;
            rDRSs.Add(oMedicine);

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
        #endregion
        #region DataReaderMappingwithNUll

        private DrugMaster MapObject(NullHandler oReader)
        {
            //DrugMaster oDRS = new DrugMaster();
            EntryParameter oEntryParameter = new EntryParameter();
            DrugGroup oDrugGroup = new DrugGroup();
            DrugMaster oDrugMaster = new DrugMaster();
            DrugCompany oDrugCompany = new DrugCompany();
            DrugUnit oDrugUnit = new DrugUnit();
            DrugPackType oDrugPackType = new DrugPackType();

            oDrugMaster.ID = oReader.GetString("DrugID");
            oDrugMaster.Name = oReader.GetString("DrugName");
            oDrugMaster.NameBeng = oReader.GetString("DrugNameBangla");
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

            //oDRS.ReorderQuantity = oReader.GetString("ReorderQuantity");
            //oDrugMaster.DoseDrug = oReader.GetString("DOSE_STR");
            //oDrugMaster.RouteID = oReader.GetString("Route_ID");

            //oDrugMaster.BeforeAfterMeal = oReader.GetChar("B_A_Meal");
            //oDrugMaster.MealTimeGap = oReader.GetString("Meal_Time_Duration");
            //oDrugMaster.MealName = oReader.GetChar("Meal_Name");

            //oDrugMaster.DurationPeriod = oReader.GetString("Min_Use_Duration");
            //oDrugMaster.DurationInd = oReader.GetString("Dur_Indicator");

            oDrugMaster.EntryParameter = oEntryParameter;
            oDrugMaster.DrugGroup = oDrugGroup;
            //oDRS.Drug = oDrugMaster;
            oDrugMaster.DrugPackType = oDrugPackType;
            oDrugMaster.DrugCompany = oDrugCompany;
            oDrugMaster.DrugUnit = oDrugUnit;

            return oDrugMaster;
        }

        private DrugMaster CreateObject(NullHandler oReader)
        {
            DrugMaster oDRS = new DrugMaster();
            oDRS = MapObject(oReader);
            return oDRS;
        }

        private List<DrugMaster> CreateObjects(IDataReader oReader)
        {
            List<DrugMaster> rDRSs = new List<DrugMaster>();
            NullHandler oHandler = new NullHandler(oReader);
            while (oReader.Read())
            {
                DrugMaster oItem = CreateObject(oHandler);
                rDRSs.Add(oItem);
            }
            return rDRSs;
        }
        #endregion

        #region GetDrugRoute
        public List<DrugRoute> GetDrugRoute()
        {
            string packageName = "PKG_DRUG_SETUP.GET_DRUG_ROUTE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<DrugRoute> olist = new List<DrugRoute>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DrugRoute ocons = new DrugRoute();
                ocons.ID = (string)rdr["route_id"];
                ocons.Name = (string)rdr["Name"];
                ocons.NameBeng = (string)rdr["Name_Beng"];
                ocons.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                olist.Add(ocons);
            }
            rdr.Close();
            return olist;
        }
        #endregion

        #region SaveDrugRoute
        public string SaveDrugRoute(DrugRoute odrug)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_DRUG_ROUTE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,3,odrug.ID,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,odrug.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,odrug.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odrug.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odrug.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odrug.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odrug.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odrug.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            string regno = (string)(OracleString)prm.Value;
            return regno;
        }
        #endregion

        #region ModifyDrugRoute
        public short ModifyDrugRoute(DrugRoute odrug)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_DRUG_ROUTE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,3,odrug.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,odrug.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,odrug.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,odrug.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,odrug.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,odrug.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,odrug.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,odrug.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
       

        
    }
}
