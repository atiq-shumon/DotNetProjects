using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.OracleManager;
using AH.DUtility;
using AH.PHRMS.MODEL;
using AH.PRMS.MODEL;
using AH.DRUGS.MODEL;
using AH.INVMS.MODEL;
using AH.ACCMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace AH.PHRMS.DAL
{
    public class PHRMSSetupDAL
    {

        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        

        #region SavePharmacyLocation
        public short SavePharmacyLocation(Pharmacy loc)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_PHARMACY_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Building",OracleDbType.Varchar2,2,loc.Building.BuildingID,ParameterDirection.Input),
                new OracleParameter("Floor",OracleDbType.Varchar2,2,loc.Building.Floors,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,loc.Block,ParameterDirection.Input),
                new OracleParameter("PharmacyName",OracleDbType.Varchar2,50,loc.PharmacyTitle,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,100,loc.Phone,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,30,loc.ContactPerson,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,loc.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,loc.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,loc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,loc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,loc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,loc.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdatePharmacyLocation
        public short UpdatePharmacyLocation(Pharmacy loc)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_PHARMACY_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Building",OracleDbType.Varchar2,2,loc.Building.BuildingID,ParameterDirection.Input),
                new OracleParameter("Floor",OracleDbType.Varchar2,2,loc.Building.Floors,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,loc.Block,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,loc.PharmacyID,ParameterDirection.Input),
                new OracleParameter("PharmacyName",OracleDbType.Varchar2,50,loc.PharmacyTitle,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,100,loc.Phone,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,30,loc.ContactPerson,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,loc.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,loc.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,loc.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,loc.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,loc.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,loc.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveSupplier
        public short SaveSupplier(AH.PHRMS.MODEL.Supplier sp)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SupplierName",OracleDbType.Varchar2,300,sp.Name,ParameterDirection.Input),
                new OracleParameter("SupplierNameBeng",OracleDbType.Varchar2,300,sp.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,sp.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,sp.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,sp.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,sp.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,20,sp.Email,ParameterDirection.Input),                
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,300,sp.ContactPerson,ParameterDirection.Input),
                new OracleParameter("AccCode",OracleDbType.Varchar2,30,sp.Acc_code.strLedgerCode,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,sp.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,sp.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,sp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,sp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,sp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,sp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateSupplier
        public short UpdateSupplier(AH.PHRMS.MODEL.Supplier sp)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SupplierID",OracleDbType.Varchar2,6,sp.ID,ParameterDirection.Input),
                new OracleParameter("SupplierName",OracleDbType.Varchar2,300,sp.Name,ParameterDirection.Input),
                new OracleParameter("SupplierNameBeng",OracleDbType.Varchar2,300,sp.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,sp.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,sp.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,sp.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,sp.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,20,sp.Email,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,300,sp.ContactPerson,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,sp.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,sp.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,sp.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,sp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,sp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,sp.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetPharmacyLocation

        public List<Pharmacy> GetPharmacyLocation()
        {
            string packageName = "PKG_DRUG_SETUP.GET_PHARMACY_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<Pharmacy> phr = new List<Pharmacy>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                Pharmacy lc = new Pharmacy();
                lc.Block = (string)rdr["block_no"];
                lc.PharmacyID = (string)rdr["phr_id"];
                lc.PharmacyTitle = (string)rdr["phr_title"];
                lc.Phone = (string)rdr["phone_no"];
                lc.ContactPerson = (string)rdr["cont_person"];
                lc.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("remarks")) ? (string)rdr["remarks"] : "";
                lc.Priority = (string)rdr["priority"];

                Building bl = new Building();
                bl.BuildingID = (string)rdr["build_id"];
                bl.Floors = short.Parse(rdr["floor_no"].ToString());
                bl.BuildingTitle = (string)rdr["BuildingName"];
                lc.Building = bl;

                phr.Add(lc);
            }
            rdr.Close();
            return phr;
        }
        #endregion

        #region GetSupplierList
        public List<AH.PHRMS.MODEL.Supplier> GetSupplierList()
        {
            string packageName = "PKG_DRUG_SETUP.GET_SUPPLIER_ALL";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSupplier(packageName,parameterList);
        }
        public List<AH.PHRMS.MODEL.Supplier> GetSupplierListed(string supname)
        {
            string packageName = "PKG_DRUG_SETUP.GET_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("SupplierName",OracleDbType.Varchar2,300,supname,ParameterDirection.Input)
            };
            return GetSupplier(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.Supplier> GetSupplier(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.Supplier> spl = new List<AH.PHRMS.MODEL.Supplier>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.Supplier sup = new AH.PHRMS.MODEL.Supplier();
                sup.ID = (string)rdr["id"];
                sup.Name = (string)rdr["name"];
                sup.NameBeng = (string)rdr["name_beng"];
                sup.Address = (string)rdr["address"];
                sup.Web = (string)rdr["web"];
                sup.Phone = (string)rdr["phone"];
                sup.Fax = (string)rdr["fax"];
                sup.Email = (string)rdr["email"];
                sup.ContactPerson = (string)rdr["cont_person"];

                Ledgers oledger = new Ledgers();
                //oledger.strGrUnder = !rdr.IsDBNull(rdr.GetOrdinal("parent_acc_code")) ? (string)rdr["parent_acc_code"] : "";
                oledger.strGrUnder = !rdr.IsDBNull(rdr.GetOrdinal("acc_code")) ? (string)rdr["acc_code"] : "";
                sup.Acc_code = oledger;


                //sup.Acc_code.strLedgerCode = (string)rdr["acc_code"];
                sup.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                sup.Priority = (string)rdr["priority"];
                spl.Add(sup);

            }
            rdr.Close();
            return spl;
        }
        #endregion

        #region SaveConsumerPurpose
        public short SaveConsumerPurpose(ConsumerPurpose con)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_CONS_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PurposeTitle",OracleDbType.Varchar2,200,con.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,con.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,con.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,con.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,con.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,con.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,con.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateConsumerPurpose
        public short UpdateConsumerPurpose(ConsumerPurpose con)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_CONS_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PurposeID",OracleDbType.Varchar2,7,con.PurposeID,ParameterDirection.Input),
                new OracleParameter("PurposeTitle",OracleDbType.Varchar2,200,con.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,con.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,con.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,con.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,con.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,con.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,con.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetConsumerPurpose
        public List<ConsumerPurpose> GetConsumerPurpose()
        {
            string packageName = "PKG_DRUG_SETUP.GET_CONS_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<ConsumerPurpose> con = new List<ConsumerPurpose>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                ConsumerPurpose cnf = new ConsumerPurpose();
                cnf.PurposeID = (string)rdr[0];
                cnf.PurposeTitle = (string)rdr[1];
                cnf.Priority = (string)rdr[4];
                cnf.Remarks = (string)rdr[3];
                con.Add(cnf);
            }
            rdr.Close();
            return con;
        }
        #endregion

        #region InsertItemRates
        public short SaveItemRates(AH.PHRMS.MODEL.ItemRates rate)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,5,rate.Pharmacy.PharmacyID,ParameterDirection.Input),
                new OracleParameter("MedicineID",OracleDbType.Varchar2,7,rate.DrugMaster.ID,ParameterDirection.Input),
                new OracleParameter("MedicineType",OracleDbType.Varchar2,7,rate.DrugMaster.DrugPackType.ID,ParameterDirection.Input),
                new OracleParameter("MedicineUnit",OracleDbType.Varchar2,4,rate.DrugMaster.DrugUnit.ID,ParameterDirection.Input),
                new OracleParameter("MedicineGroup",OracleDbType.Varchar2,6,rate.DrugMaster.DrugGroup.ID,ParameterDirection.Input),
                new OracleParameter("MedicineCompany",OracleDbType.Varchar2,6,rate.DrugMaster.DrugCompany.ID,ParameterDirection.Input),
                new OracleParameter("Urate",OracleDbType.Single,rate.Urate,ParameterDirection.Input),
                new OracleParameter("VAT",OracleDbType.Single,rate.VAT,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Single,rate.Discount,ParameterDirection.Input),
                new OracleParameter("Rackrate",OracleDbType.Single,rate.Rackrate,ParameterDirection.Input),
                new OracleParameter("Slrate",OracleDbType.Single,rate.Slrate,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,rate.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,rate.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,rate.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,rate.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,rate.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyItemRates
        public short UpdateItemRates(AH.PHRMS.MODEL.ItemRates urat)
        {
            string packageName = "PKG_DRUG_SETUP.UPDATE_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("MedicineID",OracleDbType.Varchar2,7,urat.DrugMaster.ID,ParameterDirection.Input),
                new OracleParameter("Urate",OracleDbType.Single,urat.Urate,ParameterDirection.Input),
                new OracleParameter("VAT",OracleDbType.Single,urat.VAT,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Single,urat.Discount,ParameterDirection.Input),
                new OracleParameter("Rackrate",OracleDbType.Single,urat.Rackrate,ParameterDirection.Input),
                new OracleParameter("Slrate",OracleDbType.Single,urat.Slrate,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,urat.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,urat.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,urat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,urat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,urat.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetItemRates
        public List<AH.PHRMS.MODEL.ItemRates> GetItemRates()
        {
            string packageName = "PKG_DRUG_SETUP.GET_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
              new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetItemRateLists(packageName,parameterList);
        }
        private List<AH.PHRMS.MODEL.ItemRates> GetItemRateLists(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.ItemRates> rate = new List<AH.PHRMS.MODEL.ItemRates>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.ItemRates rt = new AH.PHRMS.MODEL.ItemRates();
                rt.Urate = float.Parse(rdr["urate"].ToString());
                rt.VAT = float.Parse(rdr["vat"].ToString());
                rt.Discount = float.Parse(rdr["disc"].ToString());
                rt.Rackrate = float.Parse(rdr["rack_rate"].ToString());
                rt.Slrate = float.Parse(rdr["sl_rate"].ToString());


                DrugMaster ms = new DrugMaster();
                ms.ID = (string)rdr["prod_id"];
                ms.Name = (string)rdr["DrugName"];
                

                DrugGroup gr = new DrugGroup();
                gr.ID = (string)rdr["prod_grp_id"];
                gr.Name = (string)rdr["DrugGroup"];
                ms.DrugGroup = gr;

                DrugCompany dc = new DrugCompany();
                dc.ID = (string)rdr["prod_comp_id"];
                dc.Name = (string)rdr["DrugCompany"];
                ms.DrugCompany = dc;

                DrugUnit unit = new DrugUnit();
                unit.ID = (string)rdr["prod_unit_id"];
                ms.DrugUnit = unit;

                DrugPackType pack = new DrugPackType();
                pack.ID = (string)rdr["prod_type_id"];
                ms.DrugPackType = pack;

                rt.DrugMaster = ms;

                rate.Add(rt);

            }
            rdr.Close();
            return rate;
        }
        #endregion

        #region SavePharmacyUsers
        public short SavePharmacyUsers(PharmacyUser usr)
        {
            string packageName = "PKG_DRUG_SETUP.INSERT_PHARMACY_USERS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("UserID",OracleDbType.Varchar2,30,usr.UserID,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,usr.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,usr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,usr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,usr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,usr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region User
        public List<PharmacyUser> GetUser()
        {
            string packageName = "PKG_DRUG_SETUP.GET_PHARMACY_USERS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetPharmacyUser(packageName,parameterList);
        }
        public List<PharmacyUser> GetUserByID(string userid)
        {
            string packageName = "PKG_DRUG_SETUP.GET_PHARMACYUSER_BYID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("UserID",OracleDbType.Varchar2,30,userid,ParameterDirection.Input),
            };
            return GetPharmacyUser(packageName, parameterList);
        }
        private List<PharmacyUser> GetPharmacyUser(string packageName, OracleParameter[] parameterList)
        {
            List<PharmacyUser> usr = new List<PharmacyUser>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                PharmacyUser tr = new PharmacyUser();
                tr.UserID = (string)rdr["user_id"];

                Warehouse owh = new Warehouse();
                owh.TypeID = (string)rdr["phr_id"];
                owh.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("PharmacyName")) ? (string)rdr["PharmacyName"] : "";
                tr.Warehouse  = owh;




                usr.Add(tr);
            }
            rdr.Close();
            return usr;
        }
        #endregion

        #region GetDrugListStock
        public List<DrugMaster> GetDrugListStock(string drugName,string pharmacyid)
        {
            string packageName = "PKG_DRUG_SETUP.Get_DrugList_Stock";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugName",OracleDbType.Varchar2,500,drugName,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,pharmacyid,ParameterDirection.Input)
            };
            return GetDrugStock(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugListByGroupName(string groupName)
        {
            string packageName = "PKG_DRUG_SETUP.Get_DrugList_Stock_ByGeneric";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupName",OracleDbType.Varchar2,500,groupName,ParameterDirection.Input)
                //new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyid,ParameterDirection.Input),
            };
            return GetDrugStock(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugListByGroupNameForIPD(string groupName)
        {
            string packageName = "PKG_DRUG_SETUP.Get_DrugList_ByGenericIPD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupName",OracleDbType.Varchar2,500,groupName,ParameterDirection.Input)
                //new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyid,ParameterDirection.Input),
            };
            return GetDrugStock(packageName, parameterList);
        }
        public List<DrugMaster> GetDrugStockByGroup(string groupName)
        {
            string packageName = "PKG_TR.Get_DrugStock_ByGeneric";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupName",OracleDbType.Varchar2,500,groupName,ParameterDirection.Input)
                
            };
            return GetDrugStock(packageName, parameterList);
        }
        //public List<DrugMaster> GetDrugStockByCompany(string drugName,string company)
        //{
        //    string packageName = "PKG_TR.Get_DrugStock_ByCompany";
        //    OracleParameter[] parameterList = new OracleParameter[] {
        //        new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("DrugName",OracleDbType.Varchar2,500,drugName,ParameterDirection.Input),
        //        new OracleParameter("CompanyID",OracleDbType.Varchar2,6,company,ParameterDirection.Input)
                
        //    };
        //    return GetDrugStock(packageName, parameterList);
        //}
        public List<DrugMaster> GetDrugStockByPharmacy(string drugName, string pharmacy)
        {
            string packageName = "PKG_TR.Get_DrugStock_ByCompany";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugName",OracleDbType.Varchar2,500,drugName,ParameterDirection.Input),
                new OracleParameter("Pharmacy",OracleDbType.Varchar2,6,pharmacy,ParameterDirection.Input)
                
            };
            return GetDrugStock(packageName, parameterList);
        }

        private List<DrugMaster> GetDrugStock(string packageName, OracleParameter[] parameterList)
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
                dm.ReorderQty = int.Parse(rdr["REORDERQTY"].ToString());
                dm.PharmacyName = !rdr.IsDBNull(rdr.GetOrdinal("PharmacyName")) ? (string)rdr["PharmacyName"] : "";
                //PharmacyName
                //dm.Dose = (string)rdr[15];
                //dm.Route = (string)rdr[16];
                //dm.BeforeAfterMeal = char.Parse(rdr[17].ToString());
                //dm.MealTimeDuration = int.Parse(rdr[18].ToString());
                //dm.MealName = char.Parse(rdr[19].ToString());
                //dm.MinUseDuration = int.Parse(rdr[20].ToString());
                //dm.DurationIndicator = char.Parse(rdr[21].ToString());

                dm.Priority = int.Parse(rdr["PRIORITY"].ToString());
                dm.SerialPriority = int.Parse(rdr["SLPRIORITY"].ToString());
                dm.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                dm.Urate = Single.Parse(rdr["URATE"].ToString());
                dm.VAT = Single.Parse(rdr["VAT"].ToString());
                dm.Discount = Single.Parse(rdr["DISC"].ToString());
                //dm.Rackrate = Single.Parse(rdr[21].ToString());
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

        #region GetDrugsStockByID
        public StockHelper GetDrugsStock(string drugid,string phrid)
        {
            StockHelper stk = new StockHelper();
            string packageName = "PKG_DRUG_SETUP.Get_DrugStock";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,5,phrid,ParameterDirection.Input)
            };
            
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {

                stk.StockQty = Single.Parse(rdr["stock_qty"].ToString());

                //DrugMaster master = new DrugMaster();
                //master.ID = (string)rdr["DrugID"];

                //DrugCompany com = new DrugCompany();
                //com.ID = (string)rdr["companyid"];
                //master.DrugCompany = com;

                //stk.DrugMaster = master;

                //Pharmacy phr = new Pharmacy();
                //phr.PharmacyID = (string)rdr["phr_id"];
                //stk.Pharmacy = phr;

               // stkhlp.Add(stk);
            }
           
            return stk;
        }
        #endregion

        #region GetRequisitionTrack
        public List<AH.PHRMS.MODEL.PurchaseRequisition> GetRequisitionTrack(string pharmacyid, string startDate, string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_REQ_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.PurchaseRequisition> orequisition = new List<AH.PHRMS.MODEL.PurchaseRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseRequisition oreq = new AH.PHRMS.MODEL.PurchaseRequisition();
                oreq.ID = (string)rdr["PRID"];
                oreq.RequisitionDate = DateTime.Parse(rdr["RequisitionDate"].ToString());
                oreq.RequisitionQty = float.Parse(rdr["REQUIREDQTY"].ToString());

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DrugID"];
                omaster.Name = (string)rdr["DrugName"];


                DrugUnit un = new DrugUnit();
                un.ID = (string)rdr["UnitID"];
                un.Name = (string)rdr["UnitName"];
                omaster.DrugUnit = un;
                oreq.DrugMaster = omaster;

                orequisition.Add(oreq);
            }
            rdr.Close();
            return orequisition;

        }
        #endregion

        #region GetPOTracking
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTracking(string pharmacyid, string startDate, string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_PO_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetPOTrackMaster(packageName, parameterList);
        }
        public List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_PO_TRACKING_BYREQNO";
            OracleParameter[] parameterList = new OracleParameter[] {
                 new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                 new OracleParameter("PRNo",OracleDbType.Varchar2,15,prid,ParameterDirection.Input)
            };
            return GetPOTrackMaster(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.PurchaseOrder> GetPOTrackMaster(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.PurchaseOrder> opurchaseorder = new List<AH.PHRMS.MODEL.PurchaseOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.PurchaseOrder po = new AH.PHRMS.MODEL.PurchaseOrder();
                po.ID = (string)rdr["POID"];
                po.PODate = DateTime.Parse(rdr["PODATE"].ToString());


                AH.PHRMS.MODEL.Supplier osup = new AH.PHRMS.MODEL.Supplier();
                osup.ID = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERID")) ? (string)rdr["SUPPLIERID"] : "";
                osup.Name = !rdr.IsDBNull(rdr.GetOrdinal("SupplierName")) ? (string)rdr["SupplierName"] : "";
                po.Supplier = osup;

                ItemsOrder itm = new ItemsOrder();
                itm.URate = Single.Parse(rdr["RATE"].ToString());
                itm.POQty = Single.Parse(rdr["POQTY"].ToString());

                DrugMaster omaster = new DrugMaster();
                omaster.ID = (string)rdr["DrugID"];
                omaster.Name = (string)rdr["DrugName"];

                DrugUnit un = new DrugUnit();
                un.ID = (string)rdr["DrugUnit"];
                un.Name = (string)rdr["UnitName"];
                omaster.DrugUnit = un;
                itm.DrugMaster = omaster;
                po.ItemsOrder = itm;

                opurchaseorder.Add(po);
            }
            rdr.Close();
            return opurchaseorder;
        }
        #endregion

        #region GetMrrTracking
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTracking(string pharmacyid, string startDate, string endDate)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_MRR_TRACKING";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,pharmacyid,ParameterDirection.Input),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            return GetMrrTrackMaster(packageName, parameterList);
        }
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            string packageName = "PKG_TRACKING_PRPOGRN.GET_MRR_TRACKING_BYPO";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("POID",OracleDbType.Varchar2,15,poid,ParameterDirection.Input)
            };
            return GetMrrTrackMaster(packageName, parameterList);
        }
        private List<AH.PHRMS.MODEL.MaterialReceive> GetMrrTrackMaster(string packageName, OracleParameter[] parameterList)
        {
            List<AH.PHRMS.MODEL.MaterialReceive> omatreceive = new List<AH.PHRMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceive omrr = new AH.PHRMS.MODEL.MaterialReceive();
                omrr.MRRID = (string)rdr["MRRID"];
                omrr.MRRDate = DateTime.Parse(rdr["MRRDATE"].ToString());
                omrr.MRRQuantity = float.Parse(rdr["Quantity"].ToString());

                ItemsOrder oitem = new ItemsOrder();
                oitem.URate = Single.Parse(rdr["RATE"].ToString());

                DrugMaster mas = new DrugMaster();
                mas.ID = (string)rdr["PRODUCTID"];
                mas.Name = (string)rdr["PRODUCTNAME"];
                oitem.DrugMaster = mas;

                DrugUnit ounit = new DrugUnit();
                ounit.ID = (string)rdr["UNITID"];
                ounit.Name = (string)rdr["UNITNAME"];
                mas.DrugUnit = ounit;
                oitem.DrugMaster = mas;
                omrr.ItemsOrder = oitem;


                omatreceive.Add(omrr);
            }
            rdr.Close();
            return omatreceive;
        }
        #endregion
    }
        
}
