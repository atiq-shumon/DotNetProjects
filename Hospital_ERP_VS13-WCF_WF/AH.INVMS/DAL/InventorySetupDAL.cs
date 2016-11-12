using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.ACCMS.MODEL;
using AH.INVMS.MODEL;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.DUtility;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace AH.INVMS.DAL
{
    public class InventorySetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region GetCompanyDetails
        public List<CompanySetup> GetCompanyDetails()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_COMPANY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetCompany(packageName,parameterList);
        }
        private List<CompanySetup> GetCompany(string packageName, OracleParameter[] parameterList)
        {
            List<CompanySetup> ocompany = new List<CompanySetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                CompanySetup com = new CompanySetup();
                com.ID = (string)rdr["ID"];
                com.Name = (string)rdr["Name"];
                com.NameBeng = (string)rdr["Name_beng"];
                com.Address = (string)rdr["address"];
                com.Web = (string)rdr["web"];
                com.Phone = (string)rdr["phone"];
                com.Fax = !rdr.IsDBNull(rdr.GetOrdinal("Fax")) ? (string)rdr["Fax"] : "";
                com.Email = (string)rdr["Email"];
                com.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                ocompany.Add(com);
            }
            rdr.Close();
            return ocompany;
        }
        #endregion

        #region SaveCompanyDetails
        public short savecompanydetails(CompanySetup ocompany)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_COMPANY_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ocompany.Name,ParameterDirection.Input),
                new OracleParameter("NameBengali",OracleDbType.Varchar2,300,ocompany.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,ocompany.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,ocompany.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,ocompany.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,ocompany.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,30,ocompany.Email,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ocompany.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ocompany.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ocompany.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ocompany.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ocompany.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyCompanyDetails
        public short ModifyCompanyDetails(CompanySetup ocompany)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_COMPANY_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,6,ocompany.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ocompany.Name,ParameterDirection.Input),
                new OracleParameter("NameBengali",OracleDbType.Varchar2,300,ocompany.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,ocompany.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,ocompany.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,ocompany.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,ocompany.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,30,ocompany.Email,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ocompany.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ocompany.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ocompany.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ocompany.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ocompany.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region SaveGroupDetails
        public short SaveGroupDetails(GroupDetails ogroup)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_GROUP_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,ogroup.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("MajorGroup",OracleDbType.Varchar2,4,ogroup.Majorgroup.MajorgrpID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ogroup.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,ogroup.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ogroup.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ogroup.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ogroup.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ogroup.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ogroup.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyGroupDetails
        public short ModifyGroupDetails(GroupDetails ogroup)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_GROUP_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,ogroup.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("MajorGroup",OracleDbType.Varchar2,4,ogroup.Majorgroup.MajorgrpID,ParameterDirection.Input),
                new OracleParameter("ID",OracleDbType.Varchar2,6,ogroup.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ogroup.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,ogroup.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ogroup.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ogroup.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ogroup.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ogroup.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ogroup.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;
        }
        #endregion

        #region GetGroupDetails
        public List<GroupDetails> GetGroupDetails()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_GROUP_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            return GetGroup(packageName, parameterList);
        
        }
        public List<GroupDetails> GetGroupList(string groupname)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_GROUP_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("GroupName",OracleDbType.Varchar2,300,groupname,ParameterDirection.Input)
              };
            return GetGroup(packageName, parameterList);
        }
        public List<GroupDetails> GetGroupByMajorGrp(string strtype,string majorgrp)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_GROUP_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,strtype,ParameterDirection.Input),
                new OracleParameter("MajorGroup",OracleDbType.Varchar2,2,majorgrp,ParameterDirection.Input)
              };
            return GetGroup(packageName, parameterList);
        }
        private List<GroupDetails> GetGroup(string packageName, OracleParameter[] parameterList)
        {
            List<GroupDetails> drgr = new List<GroupDetails>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                GroupDetails dg = new GroupDetails();
                dg.ID = (string)rdr["grp_id"].ToString();
                dg.Name = (string)rdr["Name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";

                StoreTypeSCM ostore = new StoreTypeSCM();
                ostore.strTypeID = (string)rdr["str_type_id"];
                ostore.TypeTitle = (string)rdr["STORETYPENAME"];
                dg.StoreType = ostore;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["major_grp_id"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                dg.Majorgroup = omajor;

                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveUnitDetails
        public short SaveUnitDetails(Units ounit)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_UNIT_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ounit.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,ounit.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ounit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ounit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ounit.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ounit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ounit.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyUnitDetails
        public short ModifyUnitDetails(Units ounit)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_UNIT_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,ounit.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,ounit.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,ounit.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ounit.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ounit.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ounit.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ounit.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ounit.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetUnits
        public List<Units> GetUnitSetup()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_UNIT_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            List<Units> drgr = new List<Units>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Units dg = new Units();
                dg.ID = (string)rdr["unit_id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SavePacketType
        public short SavePacketType(PacketType otype)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_PACK_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,otype.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,otype.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otype.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otype.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otype.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otype.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otype.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyPacketType
        public short ModifyPacketType(PacketType otype)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_PACK_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,otype.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,otype.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,otype.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,otype.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,otype.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,otype.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,otype.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,otype.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetPacketType
        public List<PacketType> GetPacketType()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_PACK_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            List<PacketType> drgr = new List<PacketType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                PacketType dg = new PacketType();
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

        #region SaveModelDetails
        public short SaveModelDetails(ModelSetup omodel)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_MODEL_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,omodel.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,omodel.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,omodel.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,omodel.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,omodel.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,omodel.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,omodel.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyModelDetails
        public short ModifyModelDetails(ModelSetup omodel)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_MODEL_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,omodel.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,omodel.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,omodel.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,omodel.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,omodel.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,omodel.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,omodel.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,omodel.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetModelDetails
        public List<ModelSetup> GetModelDetails()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_MODEL_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            List<ModelSetup> drgr = new List<ModelSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ModelSetup dg = new ModelSetup();
                dg.ID = (string)rdr["model_id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveBrandDetails
        public short SaveBrandDetails(BrandSetup obrand)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_BRAND_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,obrand.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,obrand.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,obrand.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,obrand.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,obrand.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,obrand.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,obrand.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyBrandDetails
        public short ModifyBrandDetails(BrandSetup obrand)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_BRAND_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ID",OracleDbType.Varchar2,4,obrand.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,300,obrand.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,300,obrand.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,obrand.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,obrand.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,obrand.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,obrand.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,obrand.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetBrandDetails
        public List<BrandSetup> GetBrandDetails()
        {
            
            string packageName = "PKG_INVENTORY_SETUP.GET_BRAND_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
              };
            List<BrandSetup> drgr = new List<BrandSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                BrandSetup dg = new BrandSetup();
                dg.ID = (string)rdr["brand_id"].ToString();
                dg.Name = (string)rdr["name"].ToString();
                dg.NameBeng = (string)rdr["name_beng"].ToString();
                dg.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                drgr.Add(dg);
            }
            rdr.Close();
            return drgr;
        }
        #endregion

        #region SaveSupplier
        public short SaveSupplier(Supplier osupplier)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SupplierName",OracleDbType.Varchar2,300,osupplier.Name,ParameterDirection.Input),
                new OracleParameter("SupplierNameBeng",OracleDbType.Varchar2,300,osupplier.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,osupplier.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,osupplier.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,osupplier.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,osupplier.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,20,osupplier.Email,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,300,osupplier.ContactPerson,ParameterDirection.Input),
                new OracleParameter("AccCode",OracleDbType.Varchar2,30,osupplier.Acc_code.strLedgerCode,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,osupplier.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,osupplier.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,osupplier.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,osupplier.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,osupplier.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,osupplier.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifySupplierList
        public short ModifySupplierList(Supplier osupplier)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SupplierID",OracleDbType.Varchar2,6,osupplier.ID,ParameterDirection.Input),
                new OracleParameter("SupplierName",OracleDbType.Varchar2,300,osupplier.Name,ParameterDirection.Input),
                new OracleParameter("SupplierNameBeng",OracleDbType.Varchar2,300,osupplier.NameBeng,ParameterDirection.Input),
                new OracleParameter("Address",OracleDbType.Varchar2,300,osupplier.Address,ParameterDirection.Input),
                new OracleParameter("Web",OracleDbType.Varchar2,30,osupplier.Web,ParameterDirection.Input),
                new OracleParameter("Phone",OracleDbType.Varchar2,20,osupplier.Phone,ParameterDirection.Input),
                new OracleParameter("Fax",OracleDbType.Varchar2,20,osupplier.Fax,ParameterDirection.Input),
                new OracleParameter("Email",OracleDbType.Varchar2,20,osupplier.Email,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,300,osupplier.ContactPerson,ParameterDirection.Input),
                new OracleParameter("AccCode",OracleDbType.Varchar2,30,osupplier.Acc_code.strGrUnder,ParameterDirection.Input),
                new OracleParameter("ChildAccCode",OracleDbType.Varchar2,30,osupplier.Acc_code.strLedgerCode,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,osupplier.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,osupplier.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,osupplier.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,osupplier.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,osupplier.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,osupplier.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetSupplierList
        public List<Supplier> GetSupplierList()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetSupplier(packageName, parameterList);
        }
        public List<Supplier> GetSupplierByName(string suppliername)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_SUPPLIER";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Name",OracleDbType.Varchar2,300,suppliername,ParameterDirection.Input)
            };
            return GetSupplier(packageName, parameterList);
        }
        private List<Supplier> GetSupplier(string packageName, OracleParameter[] parameterList)
        {
            List<Supplier> spl = new List<Supplier>();
            OracleDataReader rdr; 
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Supplier sup = new Supplier();
                sup.ID = (string)rdr["ID"];
                sup.Name = (string)rdr["Name"];
                sup.NameBeng = (string)rdr["name_beng"];
                sup.Address = (string)rdr["address"];
                sup.Web = !rdr.IsDBNull(rdr.GetOrdinal("web")) ? (string)rdr["web"] : "";
                sup.Phone = (string)rdr["phone"];
                sup.Fax = !rdr.IsDBNull(rdr.GetOrdinal("Fax")) ? (string)rdr["Fax"] : "";
                sup.Email = !rdr.IsDBNull(rdr.GetOrdinal("Email")) ? (string)rdr["Email"] : "";
                sup.ContactPerson = !rdr.IsDBNull(rdr.GetOrdinal("cont_person")) ? (string)rdr["cont_person"] : "";
                sup.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("remarks")) ? (string)rdr["remarks"] : "";
                sup.Priority = (string)rdr["priority"];

                Ledgers oledger = new Ledgers();
                oledger.strGrUnder = !rdr.IsDBNull(rdr.GetOrdinal("parent_acc_code")) ? (string)rdr["parent_acc_code"] : "";
                //oledger.strLedgerCode = !rdr.IsDBNull(rdr.GetOrdinal("acc_code")) ? (string)rdr["acc_code"] : "";
                sup.Acc_code = oledger;
               

                spl.Add(sup);

            }
            rdr.Close();
            return spl;
        }
        #endregion

        #region SaveItemMaster
        public short SaveItemMaster(ItemMaster omaster)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_ITEM_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Company",OracleDbType.Varchar2,6,omaster.Company.ID,ParameterDirection.Input),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,2,omaster.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("MajorGroup",OracleDbType.Varchar2,4,omaster.Majorgroup.MajorgrpID,ParameterDirection.Input),
                new OracleParameter("Group",OracleDbType.Varchar2,6,omaster.GroupDetails.ID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,4,omaster.Units.ID,ParameterDirection.Input),
                new OracleParameter("Packet",OracleDbType.Varchar2,4,omaster.PacketType.ID,ParameterDirection.Input),
                new OracleParameter("Model",OracleDbType.Varchar2,4,omaster.ModelSetup.ID,ParameterDirection.Input),
                new OracleParameter("Brand",OracleDbType.Varchar2,4,omaster.BrandSetup.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,omaster.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,omaster.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,omaster.Remarks,ParameterDirection.Input),
                new OracleParameter("ReorderQuantity",OracleDbType.Int32,omaster.ReorderQty,ParameterDirection.Input),
                new OracleParameter("ReorderCycle",OracleDbType.Int32,omaster.ReorderCycle,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int32,omaster.Priority,ParameterDirection.Input),
                new OracleParameter("SerialPriority",OracleDbType.Int32,omaster.SerialPriority,ParameterDirection.Input),
                new OracleParameter("IsExpireDate",OracleDbType.Varchar2,1,omaster.IsExpDate,ParameterDirection.Input),
                new OracleParameter("IsSerial",OracleDbType.Varchar2,1,omaster.IsSerial,ParameterDirection.Input),
                new OracleParameter("IsBillable",OracleDbType.Varchar2,1,omaster.IsBillable,ParameterDirection.Input),
                new OracleParameter("IsWarranty",OracleDbType.Varchar2,1,omaster.IsWarranty,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,omaster.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,omaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,omaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,omaster.EntryParameter.MachineID,ParameterDirection.Input)
                
                
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region ModifyItemMaster
        public short ModifyItemMaster(ItemMaster omaster)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_ITEM_MASTER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,omaster.ID,ParameterDirection.Input),
                new OracleParameter("Company",OracleDbType.Varchar2,6,omaster.Company.ID,ParameterDirection.Input),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,2,omaster.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("MajorGroup",OracleDbType.Varchar2,4,omaster.Majorgroup.MajorgrpID,ParameterDirection.Input),
                new OracleParameter("Group",OracleDbType.Varchar2,6,omaster.GroupDetails.ID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,4,omaster.Units.ID,ParameterDirection.Input),
                new OracleParameter("Packet",OracleDbType.Varchar2,4,omaster.PacketType.ID,ParameterDirection.Input),
                new OracleParameter("Packet",OracleDbType.Varchar2,4,omaster.ModelSetup.ID,ParameterDirection.Input),
                new OracleParameter("Packet",OracleDbType.Varchar2,4,omaster.BrandSetup.ID,ParameterDirection.Input),
                new OracleParameter("Name",OracleDbType.Varchar2,500,omaster.Name,ParameterDirection.Input),
                new OracleParameter("NameBeng",OracleDbType.Varchar2,500,omaster.NameBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,omaster.Remarks,ParameterDirection.Input),
                new OracleParameter("ReorderQuantity",OracleDbType.Int32,omaster.ReorderQty,ParameterDirection.Input),
                new OracleParameter("ReorderCycle",OracleDbType.Int32,omaster.ReorderCycle,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int32,omaster.Priority,ParameterDirection.Input),
                new OracleParameter("SerialPriority",OracleDbType.Int32,omaster.SerialPriority,ParameterDirection.Input),
                new OracleParameter("IsExpireDate",OracleDbType.Varchar2,1,omaster.IsExpDate,ParameterDirection.Input),
                new OracleParameter("IsSerial",OracleDbType.Varchar2,1,omaster.IsSerial,ParameterDirection.Input),
                new OracleParameter("IsBillable",OracleDbType.Varchar2,1,omaster.IsBillable,ParameterDirection.Input),
                new OracleParameter("IsWarranty",OracleDbType.Varchar2,1,omaster.IsWarranty,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,omaster.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,omaster.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,omaster.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,omaster.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetItemMaster
        public List<ItemMaster> GetItemMaster()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetItems(packageName, parameterList);
        }
        public List<ItemMaster> GetItemMasterByGroup(string grpid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,6,grpid,ParameterDirection.Input)
            };
            return GetItems(packageName, parameterList);
        }
       
        public List<ItemMaster> GetItemsByName(string itemname,string storeid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ItemName",OracleDbType.Varchar2,500,itemname,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,2,storeid,ParameterDirection.Input)
            };
            return GetItems(packageName, parameterList);
        }
        public List<ItemMaster> GetItemsByNameForTransfer(string itemname, string storeid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEMLIST_CENTRAL";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ItemName",OracleDbType.Varchar2,500,itemname,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input)
            };
            return GetItems(packageName, parameterList);
        }
        public List<ItemMaster> GetItemsForOpening(string itemname, string storeid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEMOPENING_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("ItemName",OracleDbType.Varchar2,500,itemname,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,2,storeid,ParameterDirection.Input)
            };
            return GetItems(packageName, parameterList);
        }
        private List<ItemMaster> GetItems(string packageName, OracleParameter[] parameterList)
        {
            List<ItemMaster> drls = new List<ItemMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ItemMaster dm = new ItemMaster();
                dm.ID = (string)rdr["itemid"];
                dm.Name = (string)rdr["itemname"];
                dm.NameBeng = (string)rdr["itemnamebengali"];
                dm.ReorderQty = int.Parse(rdr["ReorderQty"].ToString());
                dm.ReorderCycle = int.Parse(rdr["ReorderCycle"].ToString());
                dm.Priority = int.Parse(rdr["Priority"].ToString());
                dm.SerialPriority = int.Parse(rdr["SerialPriority"].ToString());
                dm.Day = DateTime.Parse(rdr["Day"].ToString());
                dm.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                //dm.StoreType = (string)rdr["STORETYPE"];
                dm.IsExpDate = !rdr.IsDBNull(rdr.GetOrdinal("ISEXPREQ")) ? (string)rdr["ISEXPREQ"] : "";
                dm.IsSerial = !rdr.IsDBNull(rdr.GetOrdinal("IS_SERIAL_REQ")) ? (string)rdr["IS_SERIAL_REQ"] : "";
                dm.IsBillable = !rdr.IsDBNull(rdr.GetOrdinal("IS_BILLABLE")) ? (string)rdr["IS_BILLABLE"] : "";
                dm.IsWarranty = !rdr.IsDBNull(rdr.GetOrdinal("IS_WARRANTY_APP")) ? (string)rdr["IS_WARRANTY_APP"] : "";

                dm.Urate = !rdr.IsDBNull(rdr.GetOrdinal("Rate")) ? Convert.ToSingle(rdr["Rate"]) : 0;
                dm.VAT = !rdr.IsDBNull(rdr.GetOrdinal("Vat")) ? Convert.ToSingle(rdr["Vat"]) : 0;
                dm.Discount = !rdr.IsDBNull(rdr.GetOrdinal("DISCOUNT")) ? Convert.ToSingle(rdr["DISCOUNT"]) : 0;
                dm.Rackrate = !rdr.IsDBNull(rdr.GetOrdinal("Rackrate")) ? Convert.ToSingle(rdr["Rackrate"]) : 0;
                dm.Slrate = !rdr.IsDBNull(rdr.GetOrdinal("Slrate")) ? Convert.ToSingle(rdr["Slrate"]) : 0;
                dm.StockQty = !rdr.IsDBNull(rdr.GetOrdinal("Stock")) ? Convert.ToSingle(rdr["Stock"]) : 0;

                
                StoreTypeSCM ostore = new StoreTypeSCM();
                ostore.strTypeID = !rdr.IsDBNull(rdr.GetOrdinal("STORETYPE")) ? (string)rdr["STORETYPE"] : "";
                ostore.TypeTitle = !rdr.IsDBNull(rdr.GetOrdinal("STORETYPENAME")) ? (string)rdr["STORETYPENAME"] : "";
                dm.StoreType = ostore;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                dm.Majorgroup = omajor;

                CompanySetup dc = new CompanySetup();
                dc.ID = (string)rdr["companyid"];
                dc.Name = (string)rdr["companyname"];
                dm.Company = dc;

                GroupDetails dg = new GroupDetails();
                dg.ID = (string)rdr["groupid"];
                dg.Name = (string)rdr["groupname"];
                dg.NameBeng = (string)rdr["groupnamebengali"];
                dm.GroupDetails = dg;

                PacketType dpac = new PacketType();
                dpac.ID = (string)rdr["typeid"];
                dpac.Name = (string)rdr["typename"];
                dpac.NameBeng = (string)rdr["typenamebengali"];
                dm.PacketType = dpac;

                Units un = new Units();
                un.ID = (string)rdr["unitid"];
                un.Name = (string)rdr["unitname"];                
                dm.Units = un;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["modelid"];
                omodel.Name = (string)rdr["modelname"];
                dm.ModelSetup = omodel;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["brandid"];
                obrand.Name = (string)rdr["brandname"];
                dm.BrandSetup = obrand;

                Warehouse oware = new Warehouse();
                oware.TypeID = !rdr.IsDBNull(rdr.GetOrdinal("StoreID")) ? (string)rdr["StoreID"] : "";
                oware.TypeName = !rdr.IsDBNull(rdr.GetOrdinal("StoreName")) ? (string)rdr["StoreName"] : "";
                dm.Warehouse = oware;

                drls.Add(dm);
            }
            rdr.Close();
            return drls;
        }
        #endregion

        #region SaveStoreLocation
        public short SaveStoreLocation(StoreLocation ostore)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_STORE_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Building",OracleDbType.Varchar2,2,ostore.Building.BuildingID,ParameterDirection.Input),
                new OracleParameter("Floor",OracleDbType.Varchar2,2,ostore.Building.Floors,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,ostore.Block,ParameterDirection.Input),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,ostore.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("StoreName",OracleDbType.Varchar2,50,ostore.Name,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,100,ostore.Phone,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,30,ostore.ContactPerson,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ostore.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,ostore.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ostore.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ostore.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ostore.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ostore.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region ModifyStoreLocation
        public short ModifyStoreLocation(StoreLocation ostore)
        {
            string packageName = "PKG_INVENTORY_SETUP.MODIFY_STORE_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,2,ostore.ID,ParameterDirection.Input),
                new OracleParameter("Building",OracleDbType.Varchar2,2,ostore.Building.BuildingID,ParameterDirection.Input),
                new OracleParameter("Floor",OracleDbType.Varchar2,2,ostore.Building.Floors,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,ostore.Block,ParameterDirection.Input),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,ostore.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("StoreName",OracleDbType.Varchar2,50,ostore.Name,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,100,ostore.Phone,ParameterDirection.Input),
                new OracleParameter("ContactPerson",OracleDbType.Varchar2,30,ostore.ContactPerson,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ostore.Remarks,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Varchar2,1,ostore.Priority,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ostore.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ostore.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ostore.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ostore.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region GetStoreLocation
        public List<StoreLocation> GetStoreLocation()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_STORE_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetStoreLoc(packageName, parameterList);
        }
        public List<StoreLocation> GetStoreLocByType(string strtype)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_STORE_LOCATION";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,strtype,ParameterDirection.Input)
            };
            return GetStoreLoc(packageName, parameterList);
        }
        private List<StoreLocation> GetStoreLoc(string packageName, OracleParameter[] parameterList)
            {
            List<StoreLocation> phr = new List<StoreLocation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                StoreLocation lc = new StoreLocation();
                lc.Block = (string)rdr["BlockNo"];
                lc.ID = (string)rdr["StoreID"];
                lc.Name = (string)rdr["StoreName"];
                lc.Phone = (string)rdr["PhoneNo"];
                lc.ContactPerson = (string)rdr["ContactPerson"];
                lc.Remarks = !rdr.IsDBNull(rdr.GetOrdinal("Remarks")) ? (string)rdr["Remarks"] : "";
                lc.Priority = (string)rdr["Priority"];

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                lc.StoreType = ostrtype;

                Building bl = new Building();
                bl.BuildingID = (string)rdr["BuildingID"];
                bl.Floors = short.Parse(rdr["FloorNo"].ToString());
                bl.BuildingTitle = (string)rdr["BuildingName"];
                lc.Building = bl;

                phr.Add(lc);
            }
            rdr.Close();
            return phr;
        }
        #endregion

        #region InsertItemRates
        public short SaveItemRates(ItemRates rate)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,5,rate.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,rate.ItemMaster.ID,ParameterDirection.Input),
                new OracleParameter("ItemType",OracleDbType.Varchar2,7,rate.ItemMaster.PacketType.ID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,4,rate.ItemMaster.Units.ID,ParameterDirection.Input),
                new OracleParameter("Group",OracleDbType.Varchar2,6,rate.ItemMaster.GroupDetails.ID,ParameterDirection.Input),
                new OracleParameter("Company",OracleDbType.Varchar2,6,rate.ItemMaster.Company.ID,ParameterDirection.Input),
                new OracleParameter("Brand",OracleDbType.Varchar2,6,rate.ItemMaster.BrandSetup.ID,ParameterDirection.Input),
                new OracleParameter("Model",OracleDbType.Varchar2,6,rate.ItemMaster.ModelSetup.ID,ParameterDirection.Input),
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
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetItemRates
        public List<ItemRates> GetItemRates()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_RATES";
            OracleParameter[] parameterList = new OracleParameter[] {
              new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetItemRateLists(packageName, parameterList);
        }
        private List<ItemRates> GetItemRateLists(string packageName, OracleParameter[] parameterList)
        {
            List<ItemRates> rate = new List<ItemRates>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ItemRates rt = new ItemRates();
                rt.Urate = float.Parse(rdr[10].ToString());
                rt.VAT = float.Parse(rdr[11].ToString());
                rt.Discount = float.Parse(rdr[12].ToString());
                rt.Rackrate = float.Parse(rdr[13].ToString());
                rt.Slrate = float.Parse(rdr[14].ToString());


                ItemMaster ms = new ItemMaster();
                ms.ID = (string)rdr["prod_id"];
                ms.Name = (string)rdr["ItemName"];


                GroupDetails gr = new GroupDetails();
                gr.ID = (string)rdr["prod_grp_id"];
                gr.Name = (string)rdr["ItemGroup"];
                ms.GroupDetails = gr;

                CompanySetup dc = new CompanySetup();
                dc.ID = (string)rdr["prod_comp_id"];
                dc.Name = (string)rdr["ItemCompany"];
                ms.Company = dc;

                Units unit = new Units();
                unit.ID = (string)rdr["prod_unit_id"];
                ms.Units = unit;

                PacketType pack = new PacketType();
                pack.ID = (string)rdr["prod_type_id"];
                ms.PacketType = pack;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["prod_brnd_id"];
                ms.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["prod_model_id"];
                ms.ModelSetup = omodel;

                rt.ItemMaster = ms;

                rate.Add(rt);

            }
            rdr.Close();
            return rate;
        }
        #endregion

        #region GetStockDetails
        public List<Stock> GetStockDetails(string itemname, string storeid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_STOCKDETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Item",OracleDbType.Varchar2,300,itemname,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,5,storeid,ParameterDirection.Input)
            };
            List<Stock> oreceive = new List<Stock>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Stock omat = new Stock();
                omat.StockQty = float.Parse(rdr["Stock"].ToString());

                StoreLocation ostore = new StoreLocation();
                ostore.ID = (string)rdr["StoreID"];
                ostore.Name = (string)rdr["StoreName"];
                omat.StoreLocaton = ostore;

                ItemOrder itm = new ItemOrder();

                ItemMaster item = new ItemMaster();
                item.ID = (string)rdr["ItemID"];
                item.Name = (string)rdr["ItemName"];
                item.Urate = float.Parse(rdr["Rate"].ToString());
                item.VAT = float.Parse(rdr["VAT"].ToString());
                item.Discount = float.Parse(rdr["Discount"].ToString());

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["CompanyID"];
                ocomp.Name = (string)rdr["CompanyName"];
                item.Company = ocomp;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["GroupID"];
                ogroup.Name = (string)rdr["GroupName"];
                item.GroupDetails = ogroup;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UnitID"];
                ounit.Name = (string)rdr["UnitName"];
                item.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TypeID"];
                otype.Name = (string)rdr["TypeName"];
                item.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["BrandID"];
                obrand.Name = (string)rdr["BrandName"];
                item.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["ModelID"];
                omodel.Name = (string)rdr["ModelName"];
                item.ModelSetup = omodel;

                itm.ItemMaster = item;
                omat.ItemOrder = itm;

                oreceive.Add(omat);
            }
            rdr.Close();
            return oreceive;
        }
        #endregion

        #region SaveStoreUser
        public short SaveStoreUser(StoreUser ouser)
        {
            string packageName = "PKG_INVENTORY_SETUP.INSERT_STORE_USER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("EmployeeID",OracleDbType.Varchar2,30,ouser.EmployeeMaster.ID,ParameterDirection.Input),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,ouser.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ouser.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ouser.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ouser.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ouser.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        #endregion

        #region GetStoreUser
        public List<StoreUser> GetStoreUser()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_STORE_USER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetUserSetup(packageName,parameterList);
        }
        private List<StoreUser> GetUserSetup(string packageName, OracleParameter[] parameterList)
        {
            List<StoreUser> ostruser = new List<StoreUser>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                StoreUser ouser = new StoreUser();

                EmployeeMaster oemp = new EmployeeMaster();
                oemp.ID = (string)rdr["emp_Id"];
                oemp.FirstName = (string)rdr["EmployeeName"];
                ouser.EmployeeMaster = oemp;

                StoreLocation ostr = new StoreLocation();
                ostr.ID = (string)rdr["str_id"];
                ostr.Name = (string)rdr["StoreName"];
                ouser.StoreLocation = ostr;

                ostruser.Add(ouser);
            }
            rdr.Close();
            return ostruser;


        }
        #endregion

        #region SaveMajorGroup
        public short SaveMajorGrp(Majorgroup Mg)
        {

            string packageName = "PKG_MAJOR_GROUP.Insert_Majorgroup";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_type_id",OracleDbType.Varchar2 ,4,Mg.StoreType.strTypeID ,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,Mg.Name  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,Mg.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,Mg.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Mg.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Mg.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Mg.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Mg.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Mg.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }

        #endregion

        #region UpdateMajorGroup
        public short Update_Majorgroup(Majorgroup Mg)
        {

            string packageName = "PKG_MAJOR_GROUP.Update_Majorgroup";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Punique",OracleDbType.Varchar2 ,4,Mg.MajorgrpID ,ParameterDirection.Input),
                new OracleParameter("p_type_id",OracleDbType.Varchar2 ,4,Mg.StoreType.strTypeID ,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,Mg.Name  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,Mg.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,Mg.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Mg.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,Mg.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,Mg.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,Mg.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Mg.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region GetMajorGroup

        public List<Majorgroup> GetMajorGrp()
        {
            string packageName = "PKG_MAJOR_GROUP.GetMajorgroup";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetMajorGrp(packageName, parameterList);
        }
        public List<Majorgroup> GetMajorGrpByStrtype(string strtype)
        {
            string packageName = "PKG_MAJOR_GROUP.GetMajorgroup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StoreType",OracleDbType.Varchar2,2,strtype,ParameterDirection.Input)
            };
            return GetMajorGrp(packageName, parameterList);
        }
        private List<Majorgroup> GetMajorGrp(string packageName, OracleParameter[] parameterList)
        {
            List<Majorgroup> objStoretype = new List<Majorgroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Majorgroup Mg = new Majorgroup();

                StoreTypeSCM ostore = new StoreTypeSCM();
                ostore.strTypeID =  rdr["str_type_id"].ToString();
                Mg.StoreType = ostore;

                Mg.MajorgrpID = rdr["major_grp_id"].ToString();
                if (rdr["name"].ToString() != "")
                {
                    Mg.Name = rdr["name"].ToString();
                }
                else
                {
                    Mg.Name = "";
                }
                if (rdr["remarks"].ToString() != "")
                {
                    Mg.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    Mg.Remarks = "";
                }


                if (rdr["active"].ToString() != "")
                {
                    Mg.Active = Convert.ToChar(rdr["active"]);
                }
                objStoretype.Add(Mg);
            }
            rdr.Close();
            return objStoretype;
        }

        #endregion

        #region GetStoreTypeofGroup

        public List<Majorgroup> GetStoreTypeofGroup()
        {
            string packageName = "PKG_MAJOR_GROUP.GetStoretype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetStoreTypeofGroup(packageName, parameterList);
        }
        private List<Majorgroup> GetStoreTypeofGroup(string packageName, OracleParameter[] parameterList)
        {
            List<Majorgroup> objGroup = new List<Majorgroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Majorgroup gp = new Majorgroup();
                //if (rdr["str_type_id"].ToString() != "")
                //{
                //    gp.storeTypeID = rdr["str_type_id"].ToString();
                //}
                //if (rdr["str_type_title"].ToString() != "")
                //{
                //    gp.Name  = rdr["str_type_title"].ToString();
                //}

                StoreTypeSCM ostore = new StoreTypeSCM();
                ostore.strTypeID = rdr["str_type_id"].ToString();
                ostore.TypeTitle = rdr["str_type_title"].ToString();
                gp.StoreType = ostore;

                objGroup.Add(gp);
            }
            rdr.Close();
            return objGroup;
        }
        #endregion

        #region SaveStoreType
        public short SaveStoreType(StoreTypeSCM St)
        {
            string packageName = "PKG_STORE_TYPE.Insert_Storetype";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,St.TypeTitle  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,St.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,St.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,St.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,St.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,St.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,St.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,St.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region UpdateStoreType
        public short UpdateStoreType(StoreTypeSCM St)
        {

            string packageName = "PKG_STORE_TYPE.Update_Storetype";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Punique",OracleDbType.Varchar2 ,2,St.strTypeID ,ParameterDirection.Input),
                new OracleParameter("p_name",OracleDbType.Varchar2 ,500,St.TypeTitle  ,ParameterDirection.Input),
                new OracleParameter("p_remarks",OracleDbType.Varchar2,200,St.Remarks ,ParameterDirection.Input),
                new OracleParameter("p_active",OracleDbType.Char,2,St.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,St.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Varchar2,60,St.EntryParameter.Version ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,St.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,St.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,St.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }

        #endregion

        #region LoadStoreType
        public List<StoreTypeSCM> LoadStoreType()
        {
            string packageName = "PKG_STORE_TYPE.LoadStoreType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return LoadStoreType(packageName, parameterList);
        }
        private List<StoreTypeSCM> LoadStoreType(string packageName, OracleParameter[] parameterList)
        {
            List<StoreTypeSCM> objStoretypescm = new List<StoreTypeSCM>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                StoreTypeSCM St = new StoreTypeSCM();
                St.strTypeID = rdr["str_type_id"].ToString();
                St.TypeTitle = rdr["str_type_title"].ToString();
                objStoretypescm.Add(St);
            }
            rdr.Close();
            return objStoretypescm;
        }
        #endregion

        #region GetStoreType
        public List<StoreTypeSCM> GetStoreType()
        {
            string packageName = "PKG_STORE_TYPE.GetStoreType";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetStoreType(packageName, parameterList);
        }
       

        private List<StoreTypeSCM> GetStoreType(string packageName, OracleParameter[] parameterList)
        {
            List<StoreTypeSCM> objStoretype = new List<StoreTypeSCM>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                StoreTypeSCM St = new StoreTypeSCM();
                St.strTypeID = rdr["str_type_id"].ToString();
                if (rdr["str_type_title"].ToString() != "")
                {
                    St.TypeTitle = rdr["str_type_title"].ToString();
                }
                else
                {
                    St.TypeTitle = "";
                }
                if (rdr["remarks"].ToString() != "")
                {
                    St.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    St.Remarks = "";
                }


                if (rdr["active"].ToString() != "")
                {
                    St.Active = Convert.ToChar(rdr["active"]);
                }
                objStoretype.Add(St);
            }
            rdr.Close();
            return objStoretype;
        }

        #endregion

        #region SaveWarehouseType
        public short Savewarehousetype(Warehouse Wh)
        {
            string packageName = "PKG_WAREHOUSE.insertWarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pWarehouseName",OracleDbType.Varchar2,60,Wh.TypeName,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,60,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region UpdateWarehouseType
        public short Updatewarehousetype(Warehouse Wh)
        {
            string packageName = "PKG_WAREHOUSE.updateWarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ptypeid",OracleDbType.Varchar2,60,Wh.TypeID,ParameterDirection.Input),
                new OracleParameter("pWarehouseName",OracleDbType.Varchar2,60,Wh.TypeName,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,60,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region GetWarehousetype
        public List<Warehouse> GetWarehousetype()
        {
            string packageName = "PKG_WAREHOUSE.Getwarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetWarehousetype(packageName, parameterList);
        }
        private List<Warehouse> GetWarehousetype(string packageName, OracleParameter[] parameterList)
        {
            List<Warehouse> objWH = new List<Warehouse>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Warehouse wh = new Warehouse();
                if (rdr["type_id"].ToString() != "")
                {
                    wh.TypeID = rdr["type_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    wh.TypeName = rdr["name"].ToString();
                }
                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }
                if (rdr["active"].ToString() != "")
                {
                    wh.Active = Convert.ToChar(rdr["active"]);
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion

        #region Savewarehouse
        public short Savewarehouse(WarehouseConfig Wh)
        {
            string packageName = "PKG_WAREHOUSE.insertwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Buildid",OracleDbType.Varchar2,3,Wh.BuildID,ParameterDirection.Input),
                new OracleParameter("floorNo",OracleDbType.Varchar2,2,Wh.FloorNo,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,Wh.BlockNo,ParameterDirection.Input),
                new OracleParameter("depID",OracleDbType.Varchar2,5,Wh.DepID,ParameterDirection.Input),
                new OracleParameter("unitid",OracleDbType.Varchar2,60,Wh.UnitID,ParameterDirection.Input),
                new OracleParameter("nursestationid",OracleDbType.Varchar2,3,Wh.NurseStationID,ParameterDirection.Input),
                new OracleParameter("categoryid",OracleDbType.Varchar2,7,Wh.CostCategoryID,ParameterDirection.Input),
                new OracleParameter("costCenterid",OracleDbType.Varchar2,7,Wh.CostCenterID,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2,4,Wh.Typeid,ParameterDirection.Input),
                new OracleParameter("pwhname",OracleDbType.Varchar2,300,Wh.WhName,ParameterDirection.Input),
                new OracleParameter("phoneNo",OracleDbType.Varchar2,100,Wh.phoneNo,ParameterDirection.Input),
                new OracleParameter("pcontactPerson",OracleDbType.Varchar2,30,Wh.Contactperson,ParameterDirection.Input),
                new OracleParameter("PharmacyTransferAllowed",OracleDbType.Varchar2,1,Wh.IsPharmacyTransferAllowed,ParameterDirection.Input),
                new OracleParameter("SCMTransferAllowed",OracleDbType.Varchar2 ,1,Wh.IsSCMTransferAllowed,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region Updatewarehouse
        public short Updatewarehouse(WarehouseConfig Wh)
        {
            string packageName = "PKG_WAREHOUSE.Updatewarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Buildid",OracleDbType.Varchar2,3,Wh.BuildID,ParameterDirection.Input),
                new OracleParameter("floorNo",OracleDbType.Varchar2,2,Wh.FloorNo,ParameterDirection.Input),
                new OracleParameter("BlockNo",OracleDbType.Varchar2,30,Wh.BlockNo,ParameterDirection.Input),
                new OracleParameter("depID",OracleDbType.Varchar2,5,Wh.DepID,ParameterDirection.Input),
                new OracleParameter("unitid",OracleDbType.Varchar2,60,Wh.UnitID,ParameterDirection.Input),
                new OracleParameter("nursestationid",OracleDbType.Varchar2,3,Wh.NurseStationID,ParameterDirection.Input),
                new OracleParameter("categoryid",OracleDbType.Varchar2,7,Wh.CostCategoryID,ParameterDirection.Input),
                new OracleParameter("costCenterid",OracleDbType.Varchar2,7,Wh.CostCenterID,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2,60,Wh.Typeid,ParameterDirection.Input),
                new OracleParameter("pwhid",OracleDbType.Varchar2,60,Wh.Whid,ParameterDirection.Input),
                new OracleParameter("pwhname",OracleDbType.Varchar2,300,Wh.WhName,ParameterDirection.Input),
                new OracleParameter("phoneNo",OracleDbType.Varchar2,100,Wh.phoneNo,ParameterDirection.Input),
                new OracleParameter("pcontactPerson",OracleDbType.Varchar2,30,Wh.Contactperson,ParameterDirection.Input),
                new OracleParameter("PharmacyTransferAllowed",OracleDbType.Varchar2,1,Wh.IsPharmacyTransferAllowed,ParameterDirection.Input),
                new OracleParameter("SCMTransferAllowed",OracleDbType.Varchar2 ,1,Wh.IsSCMTransferAllowed,ParameterDirection.Input),
                new OracleParameter("premarks",OracleDbType.Varchar2 ,200,Wh.Remarks,ParameterDirection.Input),
                new OracleParameter("pactive",OracleDbType.Varchar2,60,Wh.Active,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Wh.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Wh.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Wh.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Wh.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        #region GetWarehouse
        public List<WarehouseConfig> GetWarehouse()
        {
            string packageName = "PKG_WAREHOUSE.Getwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return GetWarehouse(packageName, parameterList);
        }
        public List<WarehouseConfig> GetWarehouseTypewise(string phr,string str)
        {
            string packageName = "PKG_WAREHOUSE.GetwarehouseTypewise";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Pharmacy",OracleDbType.Varchar2,1,phr,ParameterDirection.Input),
                    new OracleParameter("SCM",OracleDbType.Varchar2,1,str,ParameterDirection.Input)
                };
            return GetWarehouse(packageName, parameterList);
        }

        public List<WarehouseConfig> GetWhTypeforCentral(string warehouse,string type)
        {
            string packageName = "PKG_WAREHOUSE.GetWhTypeForCentral";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Warehouse",OracleDbType.Varchar2,4,warehouse,ParameterDirection.Input),
                    new OracleParameter("Type",OracleDbType.Varchar2,4,type,ParameterDirection.Input)
                };
            return GetWarehouse(packageName, parameterList);
        }
        public List<WarehouseConfig> GetWhTypeforSCM(string warehouse, string type)
        {
            string packageName = "PKG_WAREHOUSE.GetWhTypeForSCM";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("Warehouse",OracleDbType.Varchar2,4,warehouse,ParameterDirection.Input),
                    new OracleParameter("Type",OracleDbType.Varchar2,4,type,ParameterDirection.Input)
                };
            return GetWarehouse(packageName, parameterList);
        }
        private List<WarehouseConfig> GetWarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseConfig> objWH = new List<WarehouseConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseConfig wh = new WarehouseConfig();

                if (rdr["build_id"].ToString() != "")
                {
                    wh.BuildID = rdr["build_id"].ToString();
                }
                else
                {
                    wh.BuildID = "";
                }
                if (rdr["floor_no"].ToString() != "")
                {
                    wh.FloorNo = rdr["floor_no"].ToString();
                }
                else
                {
                    wh.FloorNo = "";
                }
                if (rdr["dept_id"].ToString() != "")
                {
                    wh.DepID = rdr["dept_id"].ToString();
                }
                else
                {
                    wh.DepID = "";
                }
                if (rdr["unit_id"].ToString() != "")
                {
                    wh.UnitID = rdr["unit_id"].ToString();
                }
                else
                {
                    wh.UnitID = "";
                }
                if (rdr["ns_stn_id"].ToString() != "")
                {
                    wh.NurseStationID = rdr["ns_stn_id"].ToString();
                }
                else
                {
                    wh.NurseStationID = "";
                }
                if (rdr["cost_category_id"].ToString() != "")
                {
                    wh.CostCategoryID = rdr["cost_category_id"].ToString();
                }
                else
                {
                    wh.CostCategoryID = "";
                }
                if (rdr["cost_center_id"].ToString() != "")
                {
                    wh.CostCenterID = rdr["cost_center_id"].ToString();
                }
                else
                {
                    wh.CostCenterID = "";
                }
                if (rdr["phone_no"].ToString() != "")
                {
                    wh.phoneNo = rdr["phone_no"].ToString();
                }
                else
                {
                    wh.phoneNo = "";
                }
                if (rdr["cont_person"].ToString() != "")
                {
                    wh.Contactperson = rdr["cont_person"].ToString();
                }
                else
                {
                    wh.Contactperson = "";
                }
                if (rdr["is_ph_trn_allowed"].ToString() != "")
                {
                    wh.IsPharmacyTransferAllowed = rdr["is_ph_trn_allowed"].ToString();
                }
                else
                {
                    wh.IsPharmacyTransferAllowed = "";
                }
                if (rdr["is_scm_trn_allowd"].ToString() != "")
                {
                    wh.IsSCMTransferAllowed = rdr["is_scm_trn_allowd"].ToString();
                }
                else
                {
                    wh.IsSCMTransferAllowed = "";
                }

                if (rdr["type_id"].ToString() != "")
                {
                    wh.Typeid = rdr["type_id"].ToString();
                }
                else
                {
                    wh.Typeid = "";
                }
                if (rdr["wh_id"].ToString() != "")
                {
                    wh.Whid = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.Whid = "";
                }

                if (rdr["wh_name"].ToString() != "")
                {
                    wh.WhName = rdr["wh_name"].ToString();
                }
                else
                {
                    wh.WhName = "";
                }

                if (rdr["remarks"].ToString() != "")
                {
                    wh.Remarks = rdr["remarks"].ToString();
                }
                else
                {
                    wh.Remarks = "";
                }
                if (rdr["active"].ToString() != "")
                {
                    wh.Active = Convert.ToChar(rdr["active"]);
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion

        #region GeHktwarehouse
        public List<Warehouse> GeHktwarehouse(string where)
        {
            string packageName = "PKG_HOUSE_KEEPING.getwarehouse";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,where,ParameterDirection.Input),
                };
            return GeHktwarehouse(packageName, parameterList);
        }
        private List<Warehouse> GeHktwarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<Warehouse> objWH = new List<Warehouse>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                Warehouse wh = new Warehouse();
                if (rdr["wh_id"].ToString() != "")
                {
                    wh.TypeID = rdr["wh_id"].ToString();
                }
                else
                {
                    wh.TypeID = "";
                }
                if (rdr["wh_name"].ToString() != "")
                {
                    wh.TypeName = rdr["wh_name"].ToString();
                }
                else
                {
                    wh.TypeName = "";
                }
                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion

        #region LoadWarehouse
        public List<WarehouseConfig> LoadWarehouse()
        {
            string packageName = "PKG_WAREHOUSE.Loadwarehousetype";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_out",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                };
            return LoadWarehouse(packageName, parameterList);
        }
        private List<WarehouseConfig> LoadWarehouse(string packageName, OracleParameter[] parameterList)
        {
            List<WarehouseConfig> objWH = new List<WarehouseConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                WarehouseConfig wh = new WarehouseConfig();
                if (rdr["type_id"].ToString() != "")
                {
                    wh.Typeid = rdr["type_id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    wh.TypeName = rdr["name"].ToString();
                }

                objWH.Add(wh);
            }
            rdr.Close();
            return objWH;
        }
        #endregion

        #region GetItemStockList
        public List<ItemMaster> GetItemStockList(string grpid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_STOCK_LIST";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,6,grpid,ParameterDirection.Input)
            };
            return GetItemStock(packageName, parameterList);
        }
        public List<ItemMaster> GetItemStockListAll()
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_ITEM_STOCK_LISTALL";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               
            };
            return GetItemStock(packageName, parameterList);
        }
        private List<ItemMaster> GetItemStock(string packageName, OracleParameter[] parameterList)
        {
            List<ItemMaster> drls = new List<ItemMaster>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ItemMaster dm = new ItemMaster();
                dm.ID = (string)rdr["ItemID"];
                dm.Name = (string)rdr["ItemName"];
                //dm.PODate = (string)rdr["PODATE"]; ;
                if (rdr["PODATE"].ToString() != "")
                {
                    dm.PODate = rdr["PODATE"].ToString();
                }
                else
                {
                    dm.PODate = "";
                }
               

                dm.Urate = !rdr.IsDBNull(rdr.GetOrdinal("PORATE")) ? Convert.ToSingle(rdr["PORATE"]) : 0;
                dm.StockQty = !rdr.IsDBNull(rdr.GetOrdinal("STOCK")) ? Convert.ToSingle(rdr["STOCK"]) : 0;

                Supplier osupplier = new Supplier();
                osupplier.ID = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERID")) ? (string)rdr["SUPPLIERID"] : "--";
                osupplier.Name = !rdr.IsDBNull(rdr.GetOrdinal("SUPPLIERNAME")) ? (string)rdr["SUPPLIERNAME"] : "--";
                dm.Supplier = osupplier;

   
                GroupDetails dg = new GroupDetails();
                dg.ID = (string)rdr["GROUPID"];
                dg.Name = (string)rdr["GROUPNAME"];               
                dm.GroupDetails = dg;

                drls.Add(dm);
            }
            rdr.Close();
            return drls;
        }
        #endregion

        #region GetItemStockListForNS
        public List<ItemOrder> GetItemStockForNS(string grpid, string strid)
        {
            string packageName = "PKG_INVENTORY_SETUP.GET_NURSING_STATIONSTOCK";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Group",OracleDbType.Varchar2,7,grpid,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,6,strid,ParameterDirection.Input)                
            };
            //return GetItemStockForNurs(packageName, parameterList);
            List<ItemOrder> drls = new List<ItemOrder>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {

                ItemOrder oitmorder = new ItemOrder();
                oitmorder.Batch = (string)rdr["BatchID"];
                oitmorder.MRRID = (string)rdr["MrrID"];

                ItemMaster item = new ItemMaster();
                item.ID = (string)rdr["item_id"];
                item.Name = (string)rdr["ItemName"];
                item.Urate = float.Parse(rdr["Rate"].ToString());
                item.VAT = float.Parse(rdr["VAT"].ToString());
                item.Discount = float.Parse(rdr["Disc"].ToString());
                item.StockQty = float.Parse(rdr["StockQty"].ToString());

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["prod_comp_id"];
                ocomp.Name = (string)rdr["CompanyName"];
                item.Company = ocomp;

                GroupDetails ogroup = new GroupDetails();
                ogroup.ID = (string)rdr["grp_id"];
                ogroup.Name = (string)rdr["GroupName"];
                item.GroupDetails = ogroup;

                Units ounit = new Units();
                ounit.ID = (string)rdr["unit_id"];
                ounit.Name = (string)rdr["UnitName"];
                item.Units = ounit;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["type_id"];
                otype.Name = (string)rdr["TypeName"];
                item.PacketType = otype;

                BrandSetup obrand = new BrandSetup();
                obrand.ID = (string)rdr["brand_id"];
                obrand.Name = (string)rdr["BrandName"];
                item.BrandSetup = obrand;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["Model_ID"];
                omodel.Name = (string)rdr["ModelName"];
                item.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["major_grp_id"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                item.Majorgroup = omajor;
                  
                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["str_type_id"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                item.StoreType =ostrtype;

                Warehouse owh = new Warehouse();
                owh.TypeID = (string)rdr["str_id"];
                owh.TypeName = (string)rdr["StoreName"];
                item.Warehouse = owh;

                oitmorder.ItemMaster = item;

                drls.Add(oitmorder);
            }
            rdr.Close();
            return drls;
        }
        #endregion
       

    }
}
