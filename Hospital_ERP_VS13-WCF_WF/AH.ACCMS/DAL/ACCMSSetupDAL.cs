using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.ACCMS.MODEL;
using AH.DUtility;
using AH.OracleManager;

namespace AH.ACCMS.DAL
{
    public class ACCMSSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region GetPurpose
        public List<Purpose> GetPurpose()
        {
            string packageName = "PKG_PURPOSE.GET_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetPurposeSet(packageName, parameterList);

        }
        public List<Branch > GetBranch()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetBranch";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetBranchSet(packageName, parameterList);
        }
        private List<Branch> GetBranchSet(string packageName, OracleParameter[] parameterList)
        {
            List<Branch> bran = new List<Branch>();
            OracleDataReader rdr;
            
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Branch branch = new Branch();
                if (rdr["ID_NO"].ToString() != "")
                {
                    branch.BranchID = rdr["ID_NO"].ToString();
                }
                if (rdr["B_NAME"].ToString() != "")
                {
                    branch.BranchName = rdr["B_NAME"].ToString();
                }

                if (rdr["ADDRESS1"].ToString() != "")
                {
                    branch.Address1 = rdr["ADDRESS1"].ToString();
                }

                if (rdr["ADDRESS2"].ToString() != "")
                {
                    branch.Address2 = rdr["ADDRESS2"].ToString();
                }
                if (rdr["COUNTRY_NAME"].ToString() != "")
                {
                    branch.CountryName = rdr["COUNTRY_NAME"].ToString();
                }
                if (rdr["PHONE_NO"].ToString() != "")
                {
                    branch.PhoneNo = rdr["PHONE_NO"].ToString();
                }
                if (rdr["FAX_NO"].ToString() != "")
                {
                    branch.Fax = rdr["FAX_NO"].ToString();
                }
                if (rdr["ACTIVE"].ToString() != "")
                {
                    branch.BranchFlag = Convert.ToInt16(rdr["ACTIVE"]);
                }

                if (rdr["COMMENTS"].ToString() != "")
                {
                    branch.Comments = rdr["COMMENTS"].ToString();
                }

                //branch.Address1 = !rdr.IsDBNull(2) ? (string)rdr["ADDRESS1"] : "";
                //branch.Address2 = !rdr.IsDBNull(3) ? (string)rdr["ADDRESS2"] : "";

                //branch.CountryName = !rdr.IsDBNull(4) ? (string)rdr["COUNTRY_NAME"] : "";
                //branch.PhoneNo = !rdr.IsDBNull(5) ? (string)rdr["PHONE_NO"] : "";
                //branch.Fax = !rdr.IsDBNull(6) ? (string)rdr["FAX_NO"] : "";
                //branch.BranchFlag  = Convert.ToInt16(rdr["ACTIVE"]);
                ////branch.Comments = !rdr.IsDBNull("COMMENTS") ? (string)rdr["COMMENTS"] : "";
                //if (rdr["COMMENTS"].ToString() != "")
                //{
                //    branch.Comments = rdr["COMMENTS"].ToString();
                //}
                branch.intDefaultFlag = Convert.ToInt32(rdr["B_FLAG"]);
                bran.Add(branch);
            }
            rdr.Close();
            return bran;
        }
        private List<Purpose> GetPurposeSet(string packageName, OracleParameter[] parameterList)
        {
            List<Purpose> purs = new List<Purpose>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Purpose purobj = new Purpose();
                if (rdr["COST_CENTER_ID"].ToString() != "")
                {
                    purobj.PurposeID = rdr["COST_CENTER_ID"].ToString();
                }
                if (rdr["COST_CENTER_TITLE"].ToString() != "")
                {
                    purobj.PurposeTitle = (string)rdr["COST_CENTER_TITLE"];
                }
                if (rdr["COST_CATEGORY_CODE"].ToString() != "")
                {
                    purobj.Purposecategory = rdr["COST_CATEGORY_CODE"].ToString();
                }
                else
                {
                    purobj.Purposecategory = "";
                }
                if (rdr["CODE_ALLOC"].ToString() != "")
                {
                    purobj.Codeallocation = rdr["CODE_ALLOC"].ToString();
                }
                else
                {
                    purobj.Codeallocation = "";
                }

                if (rdr["CODE_ALLOC"].ToString() != "")
                {
                    purobj.Codeallocation = rdr["CODE_ALLOC"].ToString();
                }
                else
                {
                    purobj.Codeallocation = "";
                }


                if (rdr["HR_GR_CODE"].ToString() != "")
                {
                    purobj.GrpID = rdr["HR_GR_CODE"].ToString();
                }
                else
                {
                    purobj.GrpID = "";
                }

                if (rdr["DEP_TYPE"].ToString() != "")
                {
                    purobj.TypeID = rdr["DEP_TYPE"].ToString();
                }
                else
                {
                    purobj.TypeID = "";
                }





                COA cobj = new COA();
                cobj.AccCode = (string)rdr[3];
                purobj.COA = cobj;
                purs.Add(purobj);
            }
            rdr.Close();
            return purs;

        }
        #endregion
        #region VerifyPurpose
        public int VerifyPurpose(string purposeid)
        {
            packageName = "PKG_PURPOSE.VERIFY_PURPOSEID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PurposeID",OracleDbType.Varchar2,4,purposeid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        #endregion
        #region SavePurposeSetup
        public short SavePurposeSetup(Purpose prs)
        {
            packageName = "PKG_PURPOSE.INSERT_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                //new OracleParameter("PurposeID",OracleDbType.Varchar2,4,prs.PurposeID,ParameterDirection.Input),
                new OracleParameter("p_purpose_title",OracleDbType.Varchar2,70,prs.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("p_purpose_title_beng",OracleDbType.Varchar2,70,prs.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,30,prs.COA.AccCode,ParameterDirection.Input),
                new OracleParameter("p_cost_category_code",OracleDbType.Varchar2,30,prs.Purposecategory,ParameterDirection.Input),
                 new OracleParameter("p_cost_category_Name",OracleDbType.Varchar2,100,prs.PurposecategoryName,ParameterDirection.Input),
                new OracleParameter("p_dept_type",OracleDbType.Varchar2,30,prs.TypeID,ParameterDirection.Input),
                new OracleParameter("p_grp_ID",OracleDbType.Varchar2,30,prs.GrpID,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,prs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,prs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,prs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,prs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        #endregion
        #region"SaveBranch"
        public short SaveBranchSetup(Branch branch)
        {
            packageName = "PKG_ACCOUNTS_SETUP.InsertBranch";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("PbranchName",OracleDbType.Varchar2,30, branch.BranchName,ParameterDirection.Input),
                new OracleParameter("PbranchNameInt",OracleDbType.Varchar2 ,30, branch.BranchName,ParameterDirection.Input),
                new OracleParameter("Paddress1",OracleDbType.Varchar2,60,branch.Address1,ParameterDirection.Input),
                new OracleParameter("Paddress2",OracleDbType.Varchar2,60,branch.Address2,ParameterDirection.Input),
                new OracleParameter("PCountryName",OracleDbType.Varchar2,60,branch.CountryName,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,60,branch.PhoneNo,ParameterDirection.Input),
                new OracleParameter("PfaxNo",OracleDbType.Varchar2,60,branch.Fax,ParameterDirection.Input),
                new OracleParameter("Pbflag",OracleDbType.Int16,2,branch.BranchFlag,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,branch.EntryParameter.EntryName,ParameterDirection.Input),
                new OracleParameter("Pcomments",OracleDbType.Varchar2,60,branch.Comments ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,branch.EntryParameter.CompanyID ,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,branch.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,10,branch.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
                return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateBranchSetup(Branch branch)
        {
            packageName = "PKG_ACCOUNTS_SETUP.UpdateBranch";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PBranchID",OracleDbType.Varchar2,30, branch.BranchID,ParameterDirection.Input),
                new OracleParameter("PbranchName",OracleDbType.Varchar2,30, branch.BranchName,ParameterDirection.Input),
                new OracleParameter("PbranchNameInt",OracleDbType.Varchar2 ,30,  branch.BranchName,ParameterDirection.Input),
                new OracleParameter("Paddress1",OracleDbType.Varchar2,60,branch.Address1,ParameterDirection.Input),
                new OracleParameter("Paddress2",OracleDbType.Varchar2,60,branch.Address2,ParameterDirection.Input),
                new OracleParameter("PCountryName",OracleDbType.Varchar2,60,branch.CountryName,ParameterDirection.Input),
                new OracleParameter("PhoneNo",OracleDbType.Varchar2,60,branch.PhoneNo,ParameterDirection.Input),
                new OracleParameter("PfaxNo",OracleDbType.Varchar2,60,branch.Fax,ParameterDirection.Input),
                new OracleParameter("Pbflag",OracleDbType.Int16,2,branch.BranchFlag,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,branch.EntryParameter.EntryName,ParameterDirection.Input),
                new OracleParameter("Pcomments",OracleDbType.Varchar2,60,branch.Comments ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,branch.EntryParameter.CompanyID ,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,branch.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,10,branch.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short DeleteBranch(Branch branch)
        {
            packageName = "PKG_ACCOUNTS_SETUP.DeleteBranch";
            OracleParameter[] parameterList = new OracleParameter[]
            {
               new OracleParameter("PBranchID",OracleDbType.Varchar2,30,branch.BranchID,ParameterDirection.Input),
               new OracleParameter("PEntryby",OracleDbType.Varchar2,60,branch.EntryParameter.EntryName,ParameterDirection.Input),
               new OracleParameter("PcomID",OracleDbType.Varchar2,2,branch.EntryParameter.CompanyID ,ParameterDirection.Input),
               new OracleParameter("PlocID",OracleDbType.Varchar2,2,branch.EntryParameter.LocationID,ParameterDirection.Input),
               new OracleParameter("PmacID",OracleDbType.Varchar2,10,branch.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion
        #region UpdatePurpose
        public short UpdatePurpose(Purpose uprs)
        {
            packageName = "PKG_PURPOSE.UPDATE_PURPOSE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("PurposeID",OracleDbType.Varchar2,4,uprs.PurposeID,ParameterDirection.Input),
                new OracleParameter("PurposeTitle",OracleDbType.Varchar2,70,uprs.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("PurposeTitleBeng",OracleDbType.Varchar2,70,uprs.PurposeTitle,ParameterDirection.Input),
                new OracleParameter("AccountCode",OracleDbType.Varchar2,30,uprs.COA.AccCode,ParameterDirection.Input),
                new OracleParameter("p_cost_category_code",OracleDbType.Varchar2,30,uprs.Purposecategory,ParameterDirection.Input),
                new OracleParameter("p_cost_category_Name",OracleDbType.Varchar2,30,uprs.PurposecategoryName,ParameterDirection.Input),
                new OracleParameter("p_dept_type",OracleDbType.Varchar2,30,uprs.TypeID,ParameterDirection.Input),
                new OracleParameter("p_grp_ID",OracleDbType.Varchar2,30,uprs.GrpID,ParameterDirection.Input),

                new OracleParameter("CODE_ALLOC",OracleDbType.Varchar2,30,uprs.Codeallocation,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,uprs.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,uprs.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,uprs.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,uprs.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
        #region "using for group Dictionary"
        public List<GroupsConfig> Getgroup()
        {
            List<GroupsConfig> objGroup = new List<GroupsConfig>();
            string packageName = "PKG_ACCOUNTS_SETUP.Getgroup";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            
            while (rdr.Read())
            {
                GroupsConfig Grp = new GroupsConfig();
             
                Grp.GrName = (string)rdr["GR_NAME"];
                objGroup.Add(Grp);
            }
            rdr.Close();
            return objGroup;
        }
        #endregion
        #region "using for Ledger Dictionary"
        public List<Ledgers> GetLedgerUnder()
        {
            List<Ledgers> objLedgers = new List<Ledgers>();
            string packageName = "PKG_ACCOUNTS_SETUP.Getgroup";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);

            while (rdr.Read())
            {
                Ledgers  objled = new Ledgers();
                objled.strGrUnder  = (string)rdr["GR_NAME"];
                objled.strLedgerCode = (string)rdr["gr_code"];
                objLedgers.Add(objled);
            }
            rdr.Close();
            return objLedgers;
        }
        #endregion
    }
}
