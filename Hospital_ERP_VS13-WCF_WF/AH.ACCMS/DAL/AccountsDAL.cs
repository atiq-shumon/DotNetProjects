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
   public  class AccountsDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region "Dal"
        public short SaveGroupSetup(GroupsConfig grp)
        {

            packageName = "PKG_ACCOUNTS_SETUP.InsertGroup";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ParamGroupName",OracleDbType.Varchar2,100, grp.GrName,ParameterDirection.Input),
                new OracleParameter("ParamCashFlowType",OracleDbType.Varchar2 ,60,grp.GrCashFlow,ParameterDirection.Input),
                new OracleParameter("ParamUnder",OracleDbType.Varchar2,100,grp.GrUnder,ParameterDirection.Input),
                new OracleParameter("ParamAccountType",OracleDbType.Varchar2,100,grp.GrNature,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,grp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,grp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,grp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,grp.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateGroupSetup(GroupsConfig grp)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateGroup";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("mlngGroupSerial",OracleDbType.Long,30, grp.Lngsllno, ParameterDirection.Input),
                new OracleParameter("ParamGroupName",OracleDbType.Varchar2,100, grp.GrName,ParameterDirection.Input),
                new OracleParameter("ParamCashFlowType",OracleDbType.Varchar2 ,30, grp.GrCashFlow,ParameterDirection.Input),
                new OracleParameter("ParamUnder",OracleDbType.Varchar2,100,grp.GrUnder,ParameterDirection.Input),
                new OracleParameter("ParamAccountType",OracleDbType.Varchar2,100,grp.GrNature,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,grp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,grp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,grp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,grp.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;

        }
        public short DeleteGroupSetup(GroupsConfig grp)
        {
            packageName = "PKG_ACCOUNTS_SETUP.DeleteGroup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("mlngGroupSerial",OracleDbType.Long,30, grp.Lngsllno, ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,grp.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,grp.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,grp.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,grp.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short SaveLedgerSetup(Ledgers objldr)
        {

            packageName = "PKG_ACCOUNTS_SETUP.mInsertLeger";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                    new OracleParameter("PLedgerName",OracleDbType.Varchar2,100, objldr.strLedgerName,ParameterDirection.Input),
                    new OracleParameter("PUnder",OracleDbType.Varchar2 ,100, objldr.strGrUnder,ParameterDirection.Input),
                    new OracleParameter("PEMail",OracleDbType.Varchar2,100,objldr.strEmail,ParameterDirection.Input),
                    new OracleParameter("PFax",OracleDbType.Varchar2,100,objldr.strFax,ParameterDirection.Input),
                    new OracleParameter("PInactive",OracleDbType.Varchar2,10,objldr.strStatus,ParameterDirection.Input),
                    new OracleParameter("PDrCr",OracleDbType.Varchar2,2,objldr.strDRCR ,ParameterDirection.Input),
                    new OracleParameter("POpeningBalance",OracleDbType.Long ,30,objldr.dblopeningBalance ,ParameterDirection.Input),
                    new OracleParameter("PCurrency",OracleDbType.Varchar2 ,30,objldr.strCurrencsysymbol ,ParameterDirection.Input),
                    new OracleParameter("PAddress1",OracleDbType.Varchar2,60,objldr.strAddress1 ,ParameterDirection.Input),
                    new OracleParameter("PAddress2",OracleDbType.Varchar2,60,objldr.straddress2 ,ParameterDirection.Input),
                    new OracleParameter("PCity",OracleDbType.Varchar2,60,objldr.strCity ,ParameterDirection.Input),
                    new OracleParameter("PPostal",OracleDbType.Varchar2,60,objldr.strPostal ,ParameterDirection.Input),
                    new OracleParameter("PPhone",OracleDbType.Varchar2,60,objldr.strPhone ,ParameterDirection.Input),
                    new OracleParameter("PComments",OracleDbType.Varchar2,60,objldr.strComments ,ParameterDirection.Input),
                    new OracleParameter("PcostCenter",OracleDbType.Int16,2,objldr.intCostCenter ,ParameterDirection.Input),
                    new OracleParameter("Pgr_code",OracleDbType.Varchar2,60,objldr.strLedgerCode ,ParameterDirection.Input),
                    new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objldr.EntryParameter.EntryBy,ParameterDirection.Input),
                    new OracleParameter("PcomID",OracleDbType.Varchar2,2,objldr.EntryParameter.CompanyID,ParameterDirection.Input),
                    new OracleParameter("PlocID",OracleDbType.Varchar2,2,objldr.EntryParameter.LocationID,ParameterDirection.Input),
                    new OracleParameter("PmacID",OracleDbType.Varchar2,30,objldr.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public List<GroupsConfig> GetGroupsConfiguration()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.LoadGroups";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetGroupsConfiguration(packageName, parameterList);
        }
        private List<GroupsConfig> GetGroupsConfiguration(string packageName, OracleParameter[] parameterList)
        {
            List<GroupsConfig> grp = new List<GroupsConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                GroupsConfig  objgrp = new GroupsConfig();
                objgrp.Lngsllno = Convert.ToInt32( rdr["SERIAL_NO"]);
                objgrp.GrName = (string)rdr["GR_NAME"];
                objgrp.GrParent = (string)rdr["GR_PARENT"];

                if (string.IsNullOrEmpty("GR_DEFAULT_NAME") == false)
                {
                    objgrp.GrDefaultName = rdr["GR_DEFAULT_NAME"].ToString();
                }
                else
                {
                    objgrp.GrDefaultName = "";
                }
                objgrp.Grlevel = Convert.ToInt32(rdr["GR_LEVEL"]);
                objgrp.GrDefaultgroup = Convert.ToInt32(rdr["GR_DEFAULT_GROUP"]);
                if (string.IsNullOrEmpty("GrPrimaryType") == false)
                {
                    objgrp.GrPrimaryType = Convert.ToInt32(rdr["GR_PRIMARY_TYPE"].ToString());
                }
                else
                {
                    objgrp.GrPrimaryType = 0;
                }
                if (string.IsNullOrEmpty("GR_CASH_FLOW_TYPE") == false)
                {
                    objgrp.GrCashFlow = rdr["GR_CASH_FLOW_TYPE"].ToString();
                }
                else
                {
                    objgrp.GrCashFlow = "";
                }
                grp.Add(objgrp);
            }
            rdr.Close();
            return grp;
        }
        public List<GroupsConfig> GetGroupTreeview()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetGroupTreeview";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetGroupTreeview(packageName, parameterList);
        }
        private List<GroupsConfig> GetGroupTreeview(string packageName, OracleParameter[] parameterList)
        {
            List<GroupsConfig> grp = new List<GroupsConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                GroupsConfig objgrp = new GroupsConfig();
                objgrp.GrName = (string)rdr["GR_NAME"];
                objgrp.GrParent = (string)rdr["GR_PARENT"];
                objgrp.GrPrimaryType = Convert.ToInt16(rdr["gr_primary_type"]);
                objgrp.Grcode = (string)rdr["gr_code_allo"];
                grp.Add(objgrp);
            }
            rdr.Close();
            return grp;
        }
        public List<Ledgers> GetLedgerTreeview(string vstrRoot)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLegerTreeview";
            OracleParameter[] parameterList = new OracleParameter[]{
               new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output ),
                new OracleParameter("PvstrRoot",OracleDbType.Varchar2 ,60, vstrRoot,ParameterDirection.Input),
            };
            return GetLedgerTreeview(packageName, parameterList);
        }
        private List<Ledgers> GetLedgerTreeview(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> grp = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objLedger = new Ledgers();
                objLedger.strLedgerName = (string)rdr["L_NAME"];
                //objLedger.CodeAllocation = (string)rdr["l_code_gr_code"];
                objLedger.strLedgerCode = (string)rdr["l_code_alloc"];
                //objLedger.CodeAllocation = (string)rdr["l_code_alloc"];
                grp.Add(objLedger);
            }
            rdr.Close();
            return grp;
        }
        public List<Ledgers> GetDebitTotal()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetDrOpening";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDebitTotal(packageName, parameterList);
        }
        private List<Ledgers> GetDebitTotal(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.dblopeningBalance =  double.Parse(rdr["OPENING_BALANCE"].ToString());
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetCreditTotal()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetCrOpening";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetCreditTotal(packageName, parameterList);
        }
        private List<Ledgers> GetCreditTotal(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.dblopeningBalance =  double.Parse(rdr["OPENING_BALANCE"].ToString());
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetLedgersNameDr()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerNameDr";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetLedgersNameDr(packageName, parameterList);
        }
        private List<Ledgers> GetLedgersNameDr(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = Convert.ToInt32( rdr["L_SERIAL"]);
                objldr.strLedgerCode = rdr["l_code"].ToString();
                objldr.strLedgerName  = rdr["L_NAME"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetLedgersNameCr()
        {

            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerNameCr";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetLedgerNameCr(packageName, parameterList);
        }
        private List<Ledgers> GetLedgerNameCr(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = Convert.ToInt32(rdr["L_SERIAL"]);
                objldr.strLedgerCode = rdr["l_code"].ToString();
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> CheckBankLedger(string strLedgerName)
        {

            string packageName = "PKG_ACCOUNTS_SETUP.CheckBankLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PLedgename",OracleDbType.Varchar2,strLedgerName,ParameterDirection.Input)

            };
            return CheckBankLedger(packageName, parameterList);
        }
        private List<Ledgers> CheckBankLedger(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngLegerGroup =Convert.ToInt32(rdr["L_GROUP"].ToString());
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetAllLedgers()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetAllLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetAllLedgers(packageName, parameterList);
        }
        private List<Ledgers> GetAllLedgers(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = Convert.ToInt32(rdr["L_SERIAL"]);
                objldr.strLedgerCode = rdr["l_code"].ToString();
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<VoucherTransaction> GetVoucherNo(int lngVoucherType)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetVoucherAutoNo";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PVoucherType",OracleDbType.Int16,lngVoucherType,ParameterDirection.Input)
            };
            return GetVoucherNo(packageName, parameterList,lngVoucherType );

        }
        private List<VoucherTransaction> GetVoucherNo(string packageName, OracleParameter[] parameterList, long lngVoucherType)
        {
            List<VoucherTransaction> objTran = new List<VoucherTransaction>();
            OracleDataReader rdr;
            VoucherTransaction tran = new VoucherTransaction();
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                
                if (lngVoucherType == 1)
                {
                    tran.strRefNo = "PV#" + rdr["REF_NO"].ToString();
                }
                else if (lngVoucherType == 2)
                {
                    tran.strRefNo = "RV#" + rdr["REF_NO"].ToString();
                }
                else if (lngVoucherType == 3)
                {
                    tran.strRefNo = "JV#" + rdr["REF_NO"].ToString();
                }
                else if (lngVoucherType == 4)
                {
                    tran.strRefNo = "CV#" + rdr["REF_NO"].ToString();
                }
                objTran.Add(tran);
            }
            else
            {
                if (lngVoucherType == 1)
                {
                    tran.strRefNo = "PV#" + "00000001";
                }
                else if (lngVoucherType == 2)
                {
                    tran.strRefNo = "RV#" + "00000001";
                }
                else if (lngVoucherType == 3)
                {
                    tran.strRefNo = "JV#" + "00000001";
                }
                else if (lngVoucherType == 4)
                {
                    tran.strRefNo = "CV#" + "00000001";
                }
                
                objTran.Add(tran);
            }
            rdr.Close();
            return objTran;
        }
        public string SaveVoucherSetup(string strRefNo,VoucherTransaction  objTran)
        {

            if (objTran.intmodetype == 0)
            {
                packageName = "PKG_ACCOUNTS_SETUP.SaveVoucherTransaction";
            }
            else
            {
                packageName = "PKG_ACCOUNTS_SETUP.UpdateVoucherTransaction";
            }

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PstoutRefNumber",OracleDbType.Varchar2,60, null,ParameterDirection.Output),
                new OracleParameter("PstrRefNumber",OracleDbType.Varchar2 ,60,strRefNo,ParameterDirection.Input),
                new OracleParameter("Pbranch",OracleDbType.Varchar2 ,60,objTran.strBranchName,ParameterDirection.Input),
                //new OracleParameter("Pbranch",OracleDbType.Varchar2 ,60,objTran.strBranchName,ParameterDirection.Input),
                new OracleParameter("PcreditTotal",OracleDbType.Double,30,objTran.dbleNetCreditAmount,ParameterDirection.Input),
                new OracleParameter("PlngVoucherAs",OracleDbType.Int32,2,objTran.vintVoucherType,ParameterDirection.Input),
                new OracleParameter("Pdate",OracleDbType.Varchar2,60,objTran.strVoucherDate ,ParameterDirection.Input),
                new OracleParameter("PMonthId",OracleDbType.Varchar2,7,objTran.strMonthID ,ParameterDirection.Input),
                new OracleParameter("PstrLedger",OracleDbType.Varchar2,100,objTran.strLedgerName ,ParameterDirection.Input),
                new OracleParameter("PstrNarrations",OracleDbType.Varchar2,200,objTran.strNarration ,ParameterDirection.Input),
                new OracleParameter("Poststatus",OracleDbType.Char,2,objTran.PostStatus ,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short  i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;

            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0"; 

        }
        public short SaveVoucheChildrSetup(string strRefNo,VoucherTransaction objTran)
        {
            string strBillWiseRef;
            if (objTran.intmodetype == 0)
            {
                packageName = "PKG_ACCOUNTS_SETUP.SaveVoucherTransactionChild";
            }
            else
            {
                packageName = "PKG_ACCOUNTS_SETUP.UpdateVoucherTransactionChild";
            }

            strBillWiseRef = strRefNo + objTran.intVoucherPos.ToString("0000");
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PstrRefNumber",OracleDbType.Varchar2,60, strRefNo,ParameterDirection.Input),
                new OracleParameter("Pbranch",OracleDbType.Varchar2 ,60,objTran.strBranchName,ParameterDirection.Input),
                new OracleParameter("PlngVoucherAs",OracleDbType.Int16,2,objTran.vintVoucherType,ParameterDirection.Input),
                new OracleParameter("PVoucherPosition",OracleDbType.Int16,2,objTran.intVoucherPos,ParameterDirection.Input),
                new OracleParameter("Pdate",OracleDbType.Varchar2,30,objTran.strVoucherDate ,ParameterDirection.Input),
                new OracleParameter("PstrLedger",OracleDbType.Varchar2,100,objTran.strLedgerName ,ParameterDirection.Input),
                new OracleParameter("PstrSingleNarrations",OracleDbType.Varchar2,100,objTran.strSingleNarration ,ParameterDirection.Input),
                new OracleParameter("PstrChequeNo",OracleDbType.Varchar2,60,objTran.strChequeNo,ParameterDirection.Input),
                new OracleParameter("PstrChequeDate",OracleDbType.Varchar2,60,objTran.strChequedate ,ParameterDirection.Input),
                new OracleParameter("PstrDrawnon",OracleDbType.Varchar2,60,objTran.strDrawnon,ParameterDirection.Input),
                new OracleParameter("PdebitAmount",OracleDbType.Double,60,objTran.dblDebitamount ,ParameterDirection.Input),
                new OracleParameter("PCreditAmount",OracleDbType.Double,60,objTran.dblCreditAmount ,ParameterDirection.Input),
                new OracleParameter("PDrCr",OracleDbType.Char,2,objTran.strDrCr ,ParameterDirection.Input),
                new OracleParameter("PReveseLedger",OracleDbType.Varchar2,100,objTran.strReferseLedger ,ParameterDirection.Input),
                new OracleParameter("PintCashFlow",OracleDbType.Int32,3, objTran.intCashflow ,ParameterDirection.Input),
                new OracleParameter("PBillwiseRef",OracleDbType.Varchar2 ,60, strBillWiseRef ,ParameterDirection.Input),
                new OracleParameter("Poststatus",OracleDbType.Char,2,objTran.PostStatus ,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public List<VoucherTransaction> GetVoucherTransactionDetails(int lngVoucherType,string fdate,string tdate,string Poststatus)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetVoucherDetails";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PVoucherType",OracleDbType.Int16,lngVoucherType,ParameterDirection.Input),
                new OracleParameter("fdate",OracleDbType.Varchar2,fdate,ParameterDirection.Input),
                new OracleParameter("tdate",OracleDbType.Varchar2,tdate,ParameterDirection.Input),
                new OracleParameter("poststatus",OracleDbType.Varchar2,Poststatus,ParameterDirection.Input),

            };
            return GetVoucherTransactionDetails(packageName, parameterList);
        }
        private List<VoucherTransaction> GetVoucherTransactionDetails(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherTransaction> ldr = new List<VoucherTransaction>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VoucherTransaction objldr = new VoucherTransaction();
                objldr.strRefNo = rdr["REF_NO"].ToString();
                objldr.strVoucherDate  =rdr["VOUCHER_DATE"].ToString();
                //objldr.strBranchId = rdr["ID_NO"].ToString();
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                objldr.dblNetDebitAmount = Convert.ToDouble(rdr["VOUCHER_NET_AMOUNT"]);
                if (rdr["entry_by"].ToString() != "")
                {
                    objldr.entryby = rdr["entry_by"].ToString();
                }
                else
                {
                    objldr.entryby = "";
                }

                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetLedgersDetails()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetLedgersDetails(packageName, parameterList);
        }
        private List<Ledgers> GetLedgersDetails(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = long.Parse(rdr["L_SERIAL"].ToString ());
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                objldr.strGrUnder = rdr["GR_NAME"].ToString();
                objldr.dblopeningBalance = double.Parse(rdr["OPENING_BALANCE"].ToString());
                objldr.lngDefaultLedger = long.Parse(rdr["L_DEFAULT"].ToString());
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public short DeleteLedger(long lngSlNo)
        {
            packageName = "PKG_ACCOUNTS_SETUP.DeleteLedger";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PstrLedgerSl",OracleDbType.Varchar2,60, lngSlNo,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,'a',ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,'1',ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,'1',ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,10,'1',ParameterDirection.Input),
            };
            try
            {
                short i = DALHelper.Delete(connstring, packageName, parameterList);
                //OracleParameter prm = parameterList[0];
                //if ((OracleDecimal)prm.Value == 1)
                return 1;
            }
            catch (Exception EX)
            {
                return 0;
            }
            //else return 0;
        }
        public List<Ledgers> GetDisplayLedgers(long lngSlNo)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetDisplayLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PlngSlNo",OracleDbType.Long,30,lngSlNo,ParameterDirection.Input)
            };
            return GetDisplayLedgers(packageName, parameterList);
        }
        private List<Ledgers> GetDisplayLedgers(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = Int32.Parse(rdr["L_SERIAL"].ToString());
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                objldr.strGrUnder = rdr["PARENT_GROUP"].ToString();
                objldr.strCurrencsysymbol = rdr["CURRENCY_SYMBOL"].ToString();
                objldr.lngLedgerPrimaryType = long.Parse(rdr["PRIMARY_TYPE"].ToString());
                objldr.dblopeningBalance = double.Parse(rdr["OPENING_BALANCE"].ToString());
                //objldr.strAddress1 = rdr["ADDRESS1"].ToString();
                //objldr.straddress2 = rdr["ADDRESS2"].ToString();
                //objldr.strCity = rdr["CITY"].ToString();
                //objldr.strPostal = rdr["POSTAL"].ToString();
                //objldr.strFax = rdr["FAX"].ToString();
                //objldr.strPhone = rdr["PHONE_NO"].ToString();
                //objldr.strEmail  = rdr["LEMAIL"].ToString();
                //objldr.strComments = rdr["L_COMMENTS"].ToString();
                objldr.strStatus = rdr["L_STATUS"].ToString();
                objldr.lngDefaultLedger = long.Parse(rdr["L_DEFAULT"].ToString());
                objldr.intCostCenter =Convert.ToInt32(rdr["cost_center_status"]);
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public short UpdateLedgerSetup(Ledgers objTran)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateLeger";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                    new OracleParameter("PlngLedgerSerial",OracleDbType.Long,30,objTran.lngSlNo,ParameterDirection.Input),
                    new OracleParameter("PLedgerName",OracleDbType.Varchar2,100, objTran.strLedgerName,ParameterDirection.Input),
                    new OracleParameter("PUnder",OracleDbType.Varchar2 ,100, objTran.strGrUnder ,ParameterDirection.Input),
                    new OracleParameter("PEMail",OracleDbType.Varchar2,100,objTran.strEmail ,ParameterDirection.Input),
                    new OracleParameter("PFax",OracleDbType.Varchar2,100,objTran.strFax ,ParameterDirection.Input),
                    new OracleParameter("PInactive",OracleDbType.Varchar2,10,objTran.strStatus,ParameterDirection.Input),
                    new OracleParameter("PDrCr",OracleDbType.Varchar2,2,objTran.strDRCR ,ParameterDirection.Input),
                    new OracleParameter("POpeningBalance",OracleDbType.Long ,30,objTran.dblopeningBalance  ,ParameterDirection.Input),
                    new OracleParameter("PCurrency",OracleDbType.Varchar2 ,30,objTran.strCurrencsysymbol  ,ParameterDirection.Input),
                    new OracleParameter("PAddress1",OracleDbType.Varchar2,100,objTran.strAddress1 ,ParameterDirection.Input),
                    new OracleParameter("PAddress2",OracleDbType.Varchar2,100,objTran.straddress2 ,ParameterDirection.Input),
                    new OracleParameter("PCity",OracleDbType.Varchar2,100,objTran.strCity  ,ParameterDirection.Input),
                    new OracleParameter("PPostal",OracleDbType.Varchar2,100,objTran.strPostal ,ParameterDirection.Input),
                    new OracleParameter("PPhone",OracleDbType.Varchar2,60,objTran.strPhone ,ParameterDirection.Input),
                    new OracleParameter("PcostCenter",OracleDbType.Int32,2,objTran.intCostCenter ,ParameterDirection.Input),
                    new OracleParameter("PComments",OracleDbType.Varchar2,100,objTran.strComments ,ParameterDirection.Input),
                    new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                    new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                    new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                    new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input)
                    
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public List<Ledgers> GetLedegrCode(string  strLedgerName)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GerLegerCode";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PLedgerName",OracleDbType.Varchar2,60,strLedgerName,ParameterDirection.Input)
            };
            return GetLedegrCode(packageName, parameterList);
        }
        private List<Ledgers> GetLedegrCode(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if  (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.strLedgerCode = rdr["L_CODE"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<Ledgers> GetLederName(string strLedgerCode)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerName";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("PgetldgerCode",OracleDbType.Varchar2,60,strLedgerCode,ParameterDirection.Input)
            };
            return GetLederName(packageName, parameterList);
        }
        private List<Ledgers> GetLederName(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.strLedgerName  = rdr["L_NAME"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public short DeleteVoucher(string strVoucherNo,int vintVoucherType)
        {
            packageName = "PKG_ACCOUNTS_SETUP.DeletevoucherDetails";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ParamVoucherNo",OracleDbType.Varchar2,60, strVoucherNo,ParameterDirection.Input),
                new OracleParameter("PvoucherType",OracleDbType.Int16,2, vintVoucherType,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60, Utility.UserName,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2, Utility.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2, Utility.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,16, Utility.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short SaveFixedAssetsSetup(FixedAssets objTran)
        {

            packageName = "PKG_FIXED_ASSETS.insertfixedassets";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pstrledgercode",OracleDbType.Varchar2,60, objTran.strLedgerCode,ParameterDirection.Input),
                new OracleParameter("pmanufacturedate",OracleDbType.Varchar2,30,objTran.ManufactureDate,ParameterDirection.Input),
                new OracleParameter("plocid",OracleDbType.Varchar2,30,objTran.Locationcode,ParameterDirection.Input),
                new OracleParameter("psuppid",OracleDbType.Varchar2,30,objTran.supplierCode,ParameterDirection.Input),
                new OracleParameter("purchasedate",OracleDbType.Varchar2,30,objTran.PurchaseDate,ParameterDirection.Input),
                new OracleParameter("dblPurchaseCost",OracleDbType.Double,30,objTran.dblPurchaseCost,ParameterDirection.Input),
                new OracleParameter("pdepeffectdate",OracleDbType.Varchar2,30,objTran.dteDepEffDate,ParameterDirection.Input),
                new OracleParameter("pintdepmethod",OracleDbType.Int32,2,objTran.intDepMethod,ParameterDirection.Input),
                new OracleParameter("passetslife",OracleDbType.Long,4,objTran.dblAssetsLife ,ParameterDirection.Input),
                new OracleParameter("dblassetsdeprate",OracleDbType.Double,10,objTran.dblAssetsDepRate ,ParameterDirection.Input),
                new OracleParameter("dblassetsaccdep",OracleDbType.Double,10,objTran.dblAssetsAccDep ,ParameterDirection.Input),
                new OracleParameter("dblwrittenvalue",OracleDbType.Double,60,objTran.dblWrittenValue ,ParameterDirection.Input),
                new OracleParameter("dblsalvage",OracleDbType.Double,10,objTran.dblsalvageValue ,ParameterDirection.Input),
                new OracleParameter("dblpercent",OracleDbType.Double,30,objTran.dblPercent ,ParameterDirection.Input),
                new OracleParameter("pnameofmanufacturer",OracleDbType.Varchar2,30,objTran.ManufacturerCode ,ParameterDirection.Input),
                new OracleParameter("pcountryoforigin",OracleDbType.Varchar2,100,objTran.NameofOrigin ,ParameterDirection.Input),
                new OracleParameter("pModelNo",OracleDbType.Varchar2,100,objTran.ModelNo ,ParameterDirection.Input),
                new OracleParameter("passetsidentcode",OracleDbType.Varchar2,30,objTran.AssetsIdenticode ,ParameterDirection.Input),
                new OracleParameter("pfloorname",OracleDbType.Varchar2,30,objTran.FloorNo ,ParameterDirection.Input),
                new OracleParameter("pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short UpdateFixedAssetsSetup(FixedAssets objTran)
        {

            packageName = "PKG_FIXED_ASSETS.UpdateFixedAssets";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PlngslNo",OracleDbType.Varchar2,60, objTran.SerialNo,ParameterDirection.Input),
                new OracleParameter("pstrledgercode",OracleDbType.Varchar2,60, objTran.strLedgerCode,ParameterDirection.Input),
                new OracleParameter("pmanufacturedate",OracleDbType.Varchar2,30,objTran.ManufactureDate,ParameterDirection.Input),
                new OracleParameter("plocid",OracleDbType.Varchar2,30,objTran.Locationcode,ParameterDirection.Input),
                new OracleParameter("psuppid",OracleDbType.Varchar2,30,objTran.supplierCode,ParameterDirection.Input),
                new OracleParameter("purdate",OracleDbType.Varchar2,30,objTran.PurchaseDate,ParameterDirection.Input),
                new OracleParameter("dblPurchaseCost",OracleDbType.Double,30,objTran.dblPurchaseCost,ParameterDirection.Input),
                new OracleParameter("pdepeffectdate",OracleDbType.Varchar2,30,objTran.dteDepEffDate,ParameterDirection.Input),
                new OracleParameter("pintdepmethod",OracleDbType.Int32,2,objTran.intDepMethod,ParameterDirection.Input),
                new OracleParameter("passetslife",OracleDbType.Long,4,objTran.dblAssetsLife ,ParameterDirection.Input),
                new OracleParameter("dblassetsdeprate",OracleDbType.Double,30,objTran.dblAssetsDepRate ,ParameterDirection.Input),
                new OracleParameter("dblassetsaccdep",OracleDbType.Double,30,objTran.dblAssetsAccDep ,ParameterDirection.Input),
                new OracleParameter("dblwrittenvalue",OracleDbType.Double,60,objTran.dblWrittenValue ,ParameterDirection.Input),
                new OracleParameter("dblsalvage",OracleDbType.Double,30,objTran.dblsalvageValue ,ParameterDirection.Input),
                new OracleParameter("dblpercent",OracleDbType.Double,30,objTran.dblPercent ,ParameterDirection.Input),
                new OracleParameter("pnameofmanufacturer",OracleDbType.Varchar2,30,objTran.ManufacturerCode ,ParameterDirection.Input),
                new OracleParameter("pcountryoforigin",OracleDbType.Varchar2,100,objTran.NameofOrigin ,ParameterDirection.Input),
                new OracleParameter("pModelNo",OracleDbType.Varchar2,100,objTran.ModelNo ,ParameterDirection.Input),
                new OracleParameter("passetsidentcode",OracleDbType.Varchar2,30,objTran.AssetsIdenticode ,ParameterDirection.Input),
                new OracleParameter("pfloorname",OracleDbType.Varchar2,30,objTran.FloorNo ,ParameterDirection.Input),
                new OracleParameter("pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short DeleteFixedAssetsSetup(FixedAssets objTran)
        {

            packageName = "PKG_FIXED_ASSETS.DeleteFixedAssets";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PlngslNo",OracleDbType.Long,60, objTran.SerialNo,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public List<FixedAssets> GetFixedAssetsLedger()
        {
            string packageName = "PKG_FIXED_ASSETS.GetFixedAssetsLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetFixedAssetsLedger(packageName, parameterList);
        }
        private List<FixedAssets> GetFixedAssetsLedger(string packageName, OracleParameter[] parameterList)
        {
            List<FixedAssets> fxd = new List<FixedAssets>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FixedAssets objfxd = new FixedAssets();
                //objfxd.strLedgerName=rdr["L_NAME"].ToString();

                if (rdr["l_code"].ToString() != "")
                {
                    objfxd.strLedgerCode = rdr["l_code"].ToString();
                }
                else
                {
                    objfxd.strLedgerCode = "";
                }
                if (rdr["l_code"].ToString() != "")
                {
                    objfxd.strLedgerName = rdr["L_NAME"].ToString();
                }
                else
                {
                    objfxd.strLedgerName = "";
                }
                fxd.Add(objfxd);
            }
            rdr.Close();
            return fxd ;
        }
        public List<FixedAssets> GetDisplayFixedAssetsLedger()
        {
            string packageName = "PKG_FIXED_ASSETS.GetFixedAssetsLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDisplayFixedAssetsLedger(packageName, parameterList);
        }
        private List<FixedAssets> GetDisplayFixedAssetsLedger(string packageName, OracleParameter[] parameterList)
        {
            List<FixedAssets> fxd = new List<FixedAssets>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FixedAssets objfxd = new FixedAssets();
                objfxd.strLedgerName = rdr["L_NAME"].ToString();
                //objfxd.dblAssetsAccDep =  rdr["ASSET_ACCU_DEP"];
                //objfxd.dblAssetsDepRate = rdr["ASSET_DEP_RATE"].ToString();
                //objfxd.lnfAssetsLife = rdr["ASSET_LIFE"];
               

                fxd.Add(objfxd);
            }
            rdr.Close();
            return fxd;
        }
        private List<VoucherTransaction> GetvoucherDetails(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherTransaction> voucher = new List<VoucherTransaction>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VoucherTransaction objVoucher = new VoucherTransaction();
                objVoucher.strRefNo = rdr["ref_no"].ToString();
                objVoucher.strVoucherDate = rdr["voucher_date"].ToString();
                objVoucher.strBranchName = rdr["b_name"].ToString();
                objVoucher.strLedgerName = rdr["l_name"].ToString();
                objVoucher.strNarration = rdr["voucher_narration"].ToString();
                objVoucher.strSingleNarration = rdr["narration"].ToString();
                objVoucher.strChequeNo = rdr["cheque_number"].ToString();
                objVoucher.strChequedate = rdr["cheque_date"].ToString();
                objVoucher.strDrawnon = rdr["cheque_drawn_on"].ToString();
                objVoucher.dblDebitamount = Convert.ToDouble(rdr["debit_amount"].ToString());
                objVoucher.dblCreditAmount = Convert.ToDouble(rdr["credit_amount"].ToString());
                objVoucher.strDrCr = rdr["voucher_toby"].ToString();
                voucher.Add(objVoucher);
            }
            rdr.Close();
            return voucher;
        }
        public List<VoucherTransaction> GetvoucherDetails(string strRefNo, int vType)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetDisplayVoucher";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("PstrRefNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input),
                    new OracleParameter("PintVtype",OracleDbType.Int16,2,vType,ParameterDirection.Input)
                };
            return GetvoucherDetails(packageName, parameterList); 
        }
        public List<Branch> GetBranchConfig()
        {
            List<Branch> objBranch = new List<Branch>();
            string packageName = "PKG_ACCOUNTS_REPORT.GetComanyInformation";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Branch  Bran = new Branch();
                
                Bran.BranchName = (string)rdr["b_name"];
                if (rdr["id_no"].ToString() != "")
                {
                    Bran.BranchID = (string)rdr["id_no"];
                }
                objBranch.Add(Bran);
            }
            rdr.Close();
            return objBranch;
        }
        //public List<rpt> GetVoucherDetails()
        //{
        //    List<Branch> objBranch = new List<Branch>();
        //    string packageName = "PKG_ACCOUNTS_REPORT.DisplayvoucherDetails";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
        //    };
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    while (rdr.Read())
        //    {
        //        Branch Bran = new Branch();

        //        Bran.BranchName = (string)rdr["b_name"];
        //        if (rdr["id_no"].ToString() != "")
        //        {
        //            Bran.BranchID = (string)rdr["id_no"];
        //        }
        //        objBranch.Add(Bran);
        //    }
        //    rdr.Close();
        //    return objBranch;
        //}
        public List<VoucherTransaction> GetVoucherSearch(string strvoucherNo,int pvouchertype)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetSerachDetails";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pvoucher_no",OracleDbType.Varchar2,60,strvoucherNo,ParameterDirection.Input),
                new OracleParameter("pvouchertype",OracleDbType.Varchar2,2,pvouchertype,ParameterDirection.Input)
            };
            return GetVoucherSearch(packageName, parameterList);
        }
        private List<VoucherTransaction> GetVoucherSearch(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherTransaction> ldr = new List<VoucherTransaction>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while  (rdr.Read())
            {
                VoucherTransaction objldr = new VoucherTransaction();
                objldr.strRefNo = rdr["ref_no"].ToString();
                objldr.strVoucherDate = rdr["voucher_date"].ToString();
                if  (rdr["B_NAME"].ToString()!="")
                {
                    objldr.strBranchName = rdr["B_NAME"].ToString();
                }
                objldr.strLedgerName = rdr["l_name"].ToString();
                if (rdr["cheque_number"].ToString() != "")
                {
                    objldr.strChequeNo = rdr["cheque_number"].ToString();
                }
                else
                {
                    objldr.strChequeNo = "";
                }
                objldr.strChequedate = rdr["cheque_date"].ToString();
                objldr.strDrawnon = rdr["cheque_drawn_on"].ToString();
                objldr.strSingleNarration = rdr["narration"].ToString();
                objldr.strNarration = rdr["voucher_narration"].ToString();
                objldr.strDrCr = rdr["voucher_toby"].ToString();
                objldr.LedgerCode=  rdr["l_code"].ToString();
                objldr.dblDebitamount = Convert.ToDouble(rdr["debit_amount"].ToString());
                objldr.dblCreditAmount = Convert.ToDouble(rdr["credit_amount"].ToString());
                objldr.PostStatus = rdr["post_status"].ToString();
               
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public short InsertLedgerOpening(LedgerOpening objTran)
        {

            packageName = "PKG_ACCOUNTS_SETUP.InsretLedgerOpening";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                    new OracleParameter("PstrLedgerCode",OracleDbType.Varchar2,30,objTran.LedgerCode,ParameterDirection.Input),
                    new OracleParameter("PstrBranchId",OracleDbType.Varchar2,5, objTran.BranchCode,ParameterDirection.Input),
                    new OracleParameter("PstrOpnDate",OracleDbType.Varchar2 ,30, objTran.OpnDate ,ParameterDirection.Input),
                    new OracleParameter("dblopnAmount",OracleDbType.Double,60,objTran.dblOpeningAmount ,ParameterDirection.Input),
                    new OracleParameter("PstrDrCr",OracleDbType.Varchar2,2,objTran.DRCR ,ParameterDirection.Input),
                    new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                    new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                    new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                    new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input)
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short UpdateLedgerOpening(LedgerOpening objTran)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateLedgerOpening";

                OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("PstrOpnID",OracleDbType.Varchar2,30,objTran.OpnID,ParameterDirection.Input),
                        new OracleParameter("PstrLedgerCode",OracleDbType.Varchar2,30,objTran.LedgerCode,ParameterDirection.Input),
                        new OracleParameter("PstrBranchId",OracleDbType.Varchar2,5, objTran.BranchCode,ParameterDirection.Input),
                        new OracleParameter("PstrOpnDate",OracleDbType.Varchar2 ,30, objTran.OpnDate ,ParameterDirection.Input),
                        new OracleParameter("PstrDrCr",OracleDbType.Varchar2,2,objTran.DRCR ,ParameterDirection.Input),
                        new OracleParameter("dblopnAmount",OracleDbType.Double,60,objTran.dblOpeningAmount ,ParameterDirection.Input),
                        new OracleParameter("PEntryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,objTran.EntryParameter.MachineID,ParameterDirection.Input)
                };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public List<LedgerOpening> GetLedgerOpnDetails()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerOpening";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    //new OracleParameter("Pcontrol",OracleDbType.Varchar2,100,strControl,ParameterDirection.Input),
                };
            return GetLedgerOpnDetails(packageName, parameterList);
        }
        private List<LedgerOpening> GetLedgerOpnDetails(string packageName, OracleParameter[] parameterList)
        {
            List<LedgerOpening> objLedger = new List<LedgerOpening>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DateTime dtedate;
                LedgerOpening oLedger = new LedgerOpening();
                oLedger.OpnID = rdr["opn_id"].ToString();
                dtedate = Convert.ToDateTime(rdr["opn_date"].ToString());
                oLedger.OpnDate = dtedate.ToString("dd/MM/yyyy");
                oLedger.LedgerCode = rdr["l_code"].ToString();
                oLedger.LedgerName = rdr["l_name"].ToString();
                oLedger.BranchCode = rdr["id_no"].ToString();
                oLedger.dblOpeningAmount = Convert.ToDouble(rdr["opn_amount"].ToString());
                oLedger.DRCR = rdr["dr_cr"].ToString();
                objLedger.Add(oLedger);
            }
            rdr.Close();
            return objLedger;
        }
        public List<Ledgers> GetLedgersNameDrNew()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerNameDr";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetLedgersNameDrNew(packageName, parameterList);
        }
        private List<Ledgers> GetLedgersNameDrNew(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> ldr = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objldr = new Ledgers();
                objldr.lngSlNo = Convert.ToInt32(rdr["L_SERIAL"]);
                objldr.strLedgerCode = rdr["l_code"].ToString();
                objldr.strLedgerName = rdr["L_NAME"].ToString();
                ldr.Add(objldr);
            }
            rdr.Close();
            return ldr;
        }
        public List<FixedAssets> LoadFixedAssetsLedger()
        {
            string packageName = "PKG_FIXED_ASSETS.GetDiplayFixedAssetsLedger";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return LoadFixedAssetsLedger(packageName, parameterList);
        }
        private List<FixedAssets> LoadFixedAssetsLedger(string packageName, OracleParameter[] parameterList)
        {
            List<FixedAssets> fxd = new List<FixedAssets>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FixedAssets objfxd = new FixedAssets();
                objfxd.SerialNo = Convert.ToInt64(rdr["asset_serial"].ToString());
                objfxd.strLedgerCode = rdr["ledger_code"].ToString();
                objfxd.strLedgerName = rdr["l_name"].ToString();
                objfxd.ManufactureDate = rdr["manufacturerdate"].ToString();
                objfxd.Locationcode = rdr["loc_id"].ToString();
                objfxd.supplierCode = rdr["supp_id"].ToString();
                objfxd.PurchaseDate  = rdr["purchasedate"].ToString();
                objfxd.dblPurchaseCost = Convert.ToDouble(rdr["purchase_cost"].ToString());
                objfxd.dteDepEffDate  = rdr["dep_eff_date"].ToString();
                objfxd.intDepMethod = Convert.ToInt16(rdr["dep_method"].ToString());
                objfxd.dblAssetsLife  = Convert.ToDouble(rdr["asset_life"].ToString());
                objfxd.dblAssetsDepRate  = Convert.ToDouble(rdr["asset_dep_rate"].ToString());
                objfxd.dblAssetsAccDep  = Convert.ToDouble(rdr["asset_accu_dep"].ToString());
                objfxd.dblWrittenValue = Convert.ToDouble(rdr["asset_written_value"].ToString());
                objfxd.dblsalvageValue = Convert.ToDouble(rdr["asset_salvage_value"].ToString());
                if (rdr["manufacturers_code"].ToString() != null)
                {
                    objfxd.ManufacturerCode = rdr["manufacturers_code"].ToString();
                }
                else
                {
                    objfxd.ManufacturerCode = "";
                }
                if (rdr["name"].ToString() != null)
                {
                    objfxd.ManufacturerName = rdr["name"].ToString();
                }
                else
                {
                    objfxd.ManufacturerName = "";
                }
                if (rdr["model_no"].ToString() != null)
                {
                    objfxd.ModelNo = rdr["model_no"].ToString();
                }
                else
                {
                    objfxd.ModelNo = "";
                }
                if (rdr["country_of_origin"].ToString() != null)
                {
                    objfxd.NameofOrigin = rdr["country_of_origin"].ToString();
                }
                else
                {
                    objfxd.NameofOrigin = "";
                }
                if (rdr["floor_no"].ToString() != null)
                {
                    objfxd.FloorNo = rdr["floor_no"].ToString();
                }
                else
                {
                    objfxd.FloorNo = "";
                }
                if (rdr["assets_identification_no"].ToString() != null)
                {
                    objfxd.AssetsIdenticode = rdr["assets_identification_no"].ToString();
                }
                else
                {
                    objfxd.AssetsIdenticode = "";
                }
                fxd.Add(objfxd);
            }
            rdr.Close();
            return fxd;
        }
        #endregion
        #region "Collection"
        public List<GroupsConfig> GetgroupDetails(string strGroupName)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetgroupDetails";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pgrname",OracleDbType.Varchar2,60,strGroupName,ParameterDirection.Input)
                };
            return GetgroupDetails(packageName, parameterList);
        }
        private List<GroupsConfig> GetgroupDetails(string packageName, OracleParameter[] parameterList)
        {
            List<GroupsConfig> rtgrp = new List<GroupsConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                GroupsConfig objgrp = new GroupsConfig();
                objgrp.GrUnder = rdr["gr_code"].ToString();
                objgrp.GrPrimaryType = Convert.ToInt16(rdr["gr_primary_type"].ToString());
                rtgrp.Add(objgrp);
            }
            rdr.Close();
            return rtgrp;
        }
        #endregion
        #region "Save"
        public short SaveCategorySetup(CostCategory cat)
        {

            packageName = "PKG_ACCOUNTS_SETUP.InsretCostCategory";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PstrcategoryName",OracleDbType.Varchar2,100, cat.Categoryname,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,cat.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,cat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,cat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,cat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateCategorySetup(CostCategory cat)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateCostCategory";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pstrcategorycode",OracleDbType.Varchar2,60, cat.Categorycode,ParameterDirection.Input),
                new OracleParameter("PstrcategoryName",OracleDbType.Varchar2,100, cat.Categoryname,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,cat.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,cat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,cat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,cat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short DeleteCategorySetup(string strCatCode,CostCategory cat)
        {

            packageName = "PKG_ACCOUNTS_SETUP.DeleteCostCategory";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pstrcategorycode",OracleDbType.Varchar2,60, strCatCode,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,cat.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,cat.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,cat.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,cat.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }

        public short SaveCostCentertransaction(string strRefNo,string strCategoryCode,string stDate, string strCostCenterCode,string strLedgerCode,double Amount,CostCenterTransation oct)
        {

            packageName = "PKG_ACCOUNTS_SETUP.InsretCostCenterTran";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("prefNo",OracleDbType.Varchar2,100, strRefNo,ParameterDirection.Input),
                new OracleParameter("Pstrcategorycode",OracleDbType.Varchar2,100,strCategoryCode,ParameterDirection.Input),
                new OracleParameter("pstrdate",OracleDbType.Varchar2,100, stDate,ParameterDirection.Input),
                new OracleParameter("Pstrcostcentercode",OracleDbType.Varchar2,100, strCostCenterCode,ParameterDirection.Input),
                new OracleParameter("PstrLedgercode",OracleDbType.Varchar2,100, strLedgerCode,ParameterDirection.Input),
                new OracleParameter("Pamount",OracleDbType.Double,30, Amount,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,oct.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,oct.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,oct.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,oct.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateCostCenterTran(string strRefNo, string strCategoryCode, string stDate, string strCostCenterCode, string strLedgerCode, double Amount, CostCenterTransation oct)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateCostCenterTran";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                
               new OracleParameter("prefNo",OracleDbType.Varchar2,100, strRefNo,ParameterDirection.Input),
                new OracleParameter("Pstrcategorycode",OracleDbType.Varchar2,100,strCategoryCode,ParameterDirection.Input),
                new OracleParameter("pstrdate",OracleDbType.Varchar2,100, stDate,ParameterDirection.Input),
                new OracleParameter("Pstrcostcentercode",OracleDbType.Varchar2,100, strCostCenterCode,ParameterDirection.Input),
                new OracleParameter("PstrLedgercode",OracleDbType.Varchar2,100, strLedgerCode,ParameterDirection.Input),
                new OracleParameter("Pamount",OracleDbType.Double,30, Amount,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,oct.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,oct.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,oct.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,oct.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }

        public short SaveTree(string strparent, string strgroup, string strgroup1)
        {

            packageName = "PKG_ACCOUNTS_SETUP.Insertreeview";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("ParentName",OracleDbType.Varchar2,100, strparent,ParameterDirection.Input),
                new OracleParameter("gr_name1",OracleDbType.Varchar2,100,strgroup,ParameterDirection.Input),
                new OracleParameter("gr_name",OracleDbType.Varchar2,100, strgroup1,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion
        #region "List"
        public List<GroupsConfig> GetGroupTreeviewSelection(string strSelection)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.getgrouptreeviewselection";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Id_No",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pselection",OracleDbType.Varchar2,strSelection,ParameterDirection.Input)
            };
            return GetGroupTreeviewSelection(packageName, parameterList);
        }
        private List<GroupsConfig> GetGroupTreeviewSelection(string packageName, OracleParameter[] parameterList)
        {
            List<GroupsConfig> grp = new List<GroupsConfig>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                GroupsConfig objgrp = new GroupsConfig();
                objgrp.GrName = (string)rdr["GR_NAME"];
                objgrp.GrParent = (string)rdr["GR_PARENT"];
                objgrp.GrPrimaryType = Convert.ToInt16(rdr["gr_primary_type"]);
                grp.Add(objgrp);
            }
            rdr.Close();
            return grp;
        }
        public List<VoucherTransaction> GetArchieve(string Control,string strWhere, int intWhere1, string Fdate, string Tdate,string PostStatus)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GerArchieveSerach";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Serach",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pcontrol",OracleDbType.Varchar2,Control,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2,strWhere,ParameterDirection.Input),
                new OracleParameter("pwhere1",OracleDbType.Int16,intWhere1,ParameterDirection.Input),
                new OracleParameter("pwhereFdate",OracleDbType.Varchar2,Fdate,ParameterDirection.Input),
                new OracleParameter("pwhereTdate",OracleDbType.Varchar2,Tdate,ParameterDirection.Input),
                new OracleParameter("pWherePost",OracleDbType.Varchar2,PostStatus,ParameterDirection.Input),

            };
            return GetArchieve(packageName, parameterList);
        }
        private List<VoucherTransaction> GetArchieve(string packageName, OracleParameter[] parameterList)
        {
            List<VoucherTransaction> vtran = new List<VoucherTransaction>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                VoucherTransaction objTran = new VoucherTransaction();
                objTran.strRefNo = rdr["ref_no"].ToString();
                objTran.LedgerCode = rdr["l_code"].ToString();
                objTran.strLedgerName = rdr["l_name"].ToString();
                objTran.strVoucherDate = rdr["voucher_date"].ToString();
                if (rdr["cheque_number"].ToString() != "")
                {
                    objTran.strChequeNo = rdr["cheque_number"].ToString();
                }
                else
                {
                    objTran.strChequeNo = "";
                }

                if (rdr["cheque_date"].ToString() != "")
                {
                    objTran.strChequedate = rdr["cheque_date"].ToString();
                }
                else
                {
                    objTran.strChequedate = "";
                }
                if (rdr["cheque_drawn_on"].ToString() != "")
                {
                    objTran.strDrawnon = rdr["cheque_drawn_on"].ToString();
                }
                else
                {
                    objTran.strDrawnon = "";
                }
                objTran.strDrCr = rdr["voucher_toby"].ToString();
                objTran.dblDebitamount = Convert.ToDouble(rdr["debit_amount"]);
                objTran.dblCreditAmount = Convert.ToDouble(rdr["credit_amount"].ToString());
                if (rdr["module_ref_no"].ToString() != "")
                {
                    objTran.ModuleRefNo = rdr["module_ref_no"].ToString();
                }
                else
                {
                    objTran.ModuleRefNo = "";
                }
                objTran.Modulestatus = Convert.ToInt16(rdr["module_status"]);
                objTran.vintVoucherType = Convert.ToInt16(rdr["voucher_type"]);
                objTran.Primarygroup = rdr["primary_group"].ToString();

                vtran.Add(objTran);
            }
            rdr.Close();
            return vtran;
        }
        public List<BankReconcilation> GetBankReconcilation(string Contol, string where, string Fdate, string Tdate)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetBankReconcilation";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Serach",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pcontrol",OracleDbType.Varchar2,Contol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2,where,ParameterDirection.Input),
                new OracleParameter("pwhere1",OracleDbType.Varchar2,Fdate,ParameterDirection.Input),
                new OracleParameter("pwhere2",OracleDbType.Varchar2,Tdate,ParameterDirection.Input),

            };
            return GetBankReconcilation(packageName, parameterList);
        }
        private List<BankReconcilation> GetBankReconcilation(string packageName, OracleParameter[] parameterList)
        {
            List<BankReconcilation> grp = new List<BankReconcilation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BankReconcilation objBR = new BankReconcilation();
                objBR.voucherRefKey = rdr["voucher_ref_key"].ToString();
                objBR.voucherDate = rdr["voucher_date"].ToString();
                objBR.RefNo = rdr["ref_no"].ToString();
                objBR.voucherType = rdr["voucher_type"].ToString();
                objBR.chequeNo = rdr["cheque_number"].ToString();
                objBR.chequeDate = rdr["cheque_date"].ToString();
                objBR.BankDate = rdr["bank_date"].ToString();
                objBR.Drawnon = rdr["cheque_drawn_on"].ToString();
                objBR.VoucherToby = rdr["voucher_toby"].ToString();
                objBR.DebitAmount = Convert.ToDouble(rdr["debit_amount"]);
                objBR.CreditAmount = Convert.ToDouble(rdr["credit_amount"]);
                grp.Add(objBR);
            }
            rdr.Close();
            return grp;
        }
        public List<BankReconcilation> GetParticulars(string Contol, string where, string where1)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetBankReconcilation";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_Serach",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pcontrol",OracleDbType.Varchar2,Contol,ParameterDirection.Input),
                new OracleParameter("pwhere",OracleDbType.Varchar2,where,ParameterDirection.Input),
                new OracleParameter("pwhere1",OracleDbType.Varchar2,where1,ParameterDirection.Input),
                new OracleParameter("pwhere2",OracleDbType.Varchar2,"",ParameterDirection.Input),

            };
            return GetParticulars(packageName, parameterList);
        }
        private List<BankReconcilation> GetParticulars(string packageName, OracleParameter[] parameterList)
        {
            List<BankReconcilation> grp = new List<BankReconcilation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                BankReconcilation objBR = new BankReconcilation();
                objBR.lcode  = rdr["l_code"].ToString();
                objBR.lName  = rdr["l_name"].ToString();
                grp.Add(objBR);
            }
            rdr.Close();
            return grp;
        }
        public List<Ledgers> GetLedgerNameBank()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetLedgerBank";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetLedgerNameBank(packageName, parameterList);
        }
        private List<Ledgers> GetLedgerNameBank(string packageName, OracleParameter[] parameterList)
        {
            List<Ledgers> grp = new List<Ledgers>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                Ledgers objBR = new Ledgers();
                objBR.strLedgerCode = rdr["l_code"].ToString();
                objBR.strLedgerName = rdr["l_name"].ToString();
                grp.Add(objBR);
            }
            rdr.Close();
            return grp;
        }
        public List<FixedAssetsAdjustment> GetFixedAssetsAdjustment()
        {
            string packageName = "PKG_FIXED_ASSETS.GetfixedAssetsAdjustment";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetFixedAssetsAdjustment(packageName, parameterList);
        }
        private List<FixedAssetsAdjustment> GetFixedAssetsAdjustment(string packageName, OracleParameter[] parameterList)
        {
            List<FixedAssetsAdjustment> fxd = new List<FixedAssetsAdjustment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FixedAssetsAdjustment objFxd = new FixedAssetsAdjustment();
                objFxd.Ledgercode = rdr["l_code"].ToString();
                objFxd.LedgerName = rdr["l_name"].ToString();
                objFxd.adjustmentdate = rdr["adjustment_date"].ToString();
                objFxd.RefNo  = rdr["adjustment_ref_no"].ToString();
                objFxd.adjustmentAmount = Convert.ToDouble(rdr["adjustment_amount"]);
                fxd.Add(objFxd);
            }
            rdr.Close();
            return fxd;
        }
        public short SaveBankReconcilationSetup(string strRefNo,string strBID,int intVtype,string strDate,string strBrLcode, string strLcode,double dblDr,double dblCr,
                                                double  dblChildAmount,string strtoby,string strChequeNo,string strchequeDate,string strBankDate,string strBkChargePer,
                                                double dblBkAmount,double dblNetAmount,string sstrPostStatus, BankReconcilation  Br)
        {
            packageName = "PKG_ACCOUNTS_SETUP.insertbankreconcilation";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("prefNo",OracleDbType.Varchar2,60,strRefNo,ParameterDirection.Input),
                new OracleParameter("Pbranchid",OracleDbType.Varchar2 ,4,strBID,ParameterDirection.Input),
                new OracleParameter("pcompvtype",OracleDbType.Int16,2,intVtype ,ParameterDirection.Input),
                new OracleParameter("pdate",OracleDbType.Varchar2,60,strDate ,ParameterDirection.Input),
                new OracleParameter("pbrlcode",OracleDbType.Varchar2,60,strBrLcode ,ParameterDirection.Input),
                new OracleParameter("plcode",OracleDbType.Varchar2,60,strLcode ,ParameterDirection.Input),
                new OracleParameter("PdebitAmount",OracleDbType.Double,60,dblDr,ParameterDirection.Input),
                new OracleParameter("PCreditAmount",OracleDbType.Double,60,dblCr,ParameterDirection.Input),
                new OracleParameter("PChildAmount",OracleDbType.Double,60,dblChildAmount,ParameterDirection.Input),
                new OracleParameter("pvouchertoby",OracleDbType.Varchar2,2,strtoby ,ParameterDirection.Input),
                new OracleParameter("pchequeNo",OracleDbType.Varchar2,60,strChequeNo,ParameterDirection.Input),
                new OracleParameter("pchequedate",OracleDbType.Varchar2,60,strchequeDate,ParameterDirection.Input),
                new OracleParameter("pbankdate",OracleDbType.Varchar2,60,strBankDate,ParameterDirection.Input),

                new OracleParameter("pbankchargeper",OracleDbType.Double,60,strBkChargePer,ParameterDirection.Input),
                new OracleParameter("pbankchargeamount",OracleDbType.Double ,60,dblBkAmount,ParameterDirection.Input),
                new OracleParameter("pbankchargenetamount",OracleDbType.Double ,60,dblNetAmount,ParameterDirection.Input),
                new OracleParameter("ppoststatus",OracleDbType.Varchar2,2,sstrPostStatus,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,Br.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,Br.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("PlocID",OracleDbType.Varchar2,2,Br.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,Br.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short SaveAdjustment(FixedAssetsAdjustment  FaAdj)
        {

            packageName = "PKG_FIXED_ASSETS.insretfxdAdjustment";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pstrledgercode",OracleDbType.Varchar2,100, FaAdj.Ledgercode,ParameterDirection.Input),
                new OracleParameter("padjustmentedate",OracleDbType.Varchar2,100, FaAdj.adjustmentdate,ParameterDirection.Input),
                new OracleParameter("padjustmentAmount",OracleDbType.Double,100, FaAdj.adjustmentAmount,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,FaAdj.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,FaAdj.EntryParameter.CompanyID,ParameterDirection.Input),
               // new OracleParameter("PlocID",OracleDbType.Varchar2,2,FaAdj.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,FaAdj.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short UpdateAdjustment(FixedAssetsAdjustment FaAdj)
        {

            packageName = "PKG_FIXED_ASSETS.UpdatefxdAdjustment";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pstrRefNo",OracleDbType.Varchar2,100, FaAdj.RefNo,ParameterDirection.Input),
                new OracleParameter("pstrledgercode",OracleDbType.Varchar2,100, FaAdj.Ledgercode,ParameterDirection.Input),
                new OracleParameter("padjustmentedate",OracleDbType.Varchar2,100, FaAdj.adjustmentdate,ParameterDirection.Input),
                new OracleParameter("padjustmentAmount",OracleDbType.Double,100, FaAdj.adjustmentAmount,ParameterDirection.Input),
                new OracleParameter("PEntryby",OracleDbType.Varchar2,60,FaAdj.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("PcomID",OracleDbType.Varchar2,2,FaAdj.EntryParameter.CompanyID,ParameterDirection.Input),
               // new OracleParameter("PlocID",OracleDbType.Varchar2,2,FaAdj.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,30,FaAdj.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        public short DeleteAdjustment(FixedAssetsAdjustment FaAdj)
        {

            packageName = "PKG_FIXED_ASSETS.DeletefxdAdjustment";

            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("pstrledgercode",OracleDbType.Varchar2,100, FaAdj.Ledgercode,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == -1)
            return 1;
            //return 1;
            //else return 0;
        }
        #endregion

        public List<FixedAssets> GetFxdDepreciationLedger()
        {
            string packageName = "PKG_FIXED_ASSETS.GetFxdLedgerCode";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetFxdDepreciationLedger(packageName, parameterList);
        }
        private List<FixedAssets> GetFxdDepreciationLedger(string packageName, OracleParameter[] parameterList)
        {
            List<FixedAssets> grp = new List<FixedAssets>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FixedAssets objfxd = new FixedAssets();
                objfxd.strLedgerCode = rdr["l_code"].ToString();
                grp.Add(objfxd);
            }
            rdr.Close();
            return grp;
        }

        public List<CashflowRO> GetCashOpening(string fDate, string tDate)
        {
            string packageName = "PKG_ACCOUNTS_REPORT.GetCashFlowopening";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("fDate",OracleDbType.Varchar2,fDate,ParameterDirection.Input),
                new OracleParameter("tDate",OracleDbType.Varchar2,tDate,ParameterDirection.Input)
            };
            return GetCashOpening(packageName, parameterList);
        }
        private List<CashflowRO> GetCashOpening(string packageName, OracleParameter[] parameterList)
        {
            List<CashflowRO> grp = new List<CashflowRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CashflowRO objfxd = new CashflowRO();
                objfxd.CashflowOpening  =Convert.ToDouble(rdr["opn_amount"].ToString());
                grp.Add(objfxd);
            }
            rdr.Close();
            return grp;
        }


        public short UpdateScript(string strLedgercode,string grcode)
        {

            packageName = "PKG_ACCOUNTS_SETUP.UpdateScriptLedger";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("pstrledgercode",OracleDbType.Varchar2,30,strLedgercode,ParameterDirection.Input),
                        new OracleParameter("pgrocde",OracleDbType.Varchar2,30,grcode,ParameterDirection.Input),
                };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }


        public short InsertFiscalYear(FinancialYear fy)
        {

            packageName = "PKG_ACCOUNTS_SETUP.insertfiscalyear";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("pstrfdate",OracleDbType.Varchar2,30,fy.FinancialYearForm,ParameterDirection.Input),
                        new OracleParameter("pstrtdate",OracleDbType.Varchar2,30,fy.FinancialYearTo,ParameterDirection.Input),
                        new OracleParameter("pintstatus",OracleDbType.Int16,2,fy.YearStatus,ParameterDirection.Input),
                        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,fy.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,fy.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,fy.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,fy.EntryParameter.MachineID,ParameterDirection.Input),
                };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }


        public short UpdateFiscalYear(FinancialYear fy)
        {

            packageName = "PKG_ACCOUNTS_SETUP.Updatefiscalyear";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("pyearID",OracleDbType.Varchar2,30,fy.YearID,ParameterDirection.Input),
                        new OracleParameter("pstrfdate",OracleDbType.Varchar2,30,fy.FinancialYearForm,ParameterDirection.Input),
                        new OracleParameter("pstrtdate",OracleDbType.Varchar2,30,fy.FinancialYearTo,ParameterDirection.Input),
                        new OracleParameter("pintstatus",OracleDbType.Int16,2,fy.YearStatus,ParameterDirection.Input),
                        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,fy.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,fy.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,fy.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,fy.EntryParameter.MachineID,ParameterDirection.Input),
                };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }


        public List<FinancialYear> GetFiscalYear()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetFiscalyer";
                OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
                return GetFiscalYear(packageName, parameterList);
        }
        private List<FinancialYear> GetFiscalYear(string packageName, OracleParameter[] parameterList)
        {
            List<FinancialYear> fy = new List<FinancialYear>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FinancialYear objfn = new FinancialYear();
                objfn.YearID = rdr["year_id"].ToString();
                objfn.FinancialYearForm = Convert.ToDateTime(rdr["financial_year_form"].ToString()).ToString("dd/MM/yyyy");
                objfn.FinancialYearTo = Convert.ToDateTime(rdr["financial_year_to"].ToString()).ToString("dd/MM/yyyy");
                objfn.YearStatus = Convert.ToInt16(rdr["financial_status"]);
                fy.Add(objfn);
            }
            rdr.Close();
            return fy;
        }



        public List<FinancialYear> GetActiveFiscalYear()
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetActiveFiscalyer";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetActiveFiscalYear(packageName, parameterList);
        }
        private List<FinancialYear> GetActiveFiscalYear(string packageName, OracleParameter[] parameterList)
        {
            List<FinancialYear> fy = new List<FinancialYear>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                FinancialYear objfn = new FinancialYear();
                objfn.FinancialYearForm = Convert.ToDateTime(rdr["financial_year_form"].ToString()).ToString("dd/MM/yyyy");
                objfn.FinancialYearTo = Convert.ToDateTime(rdr["financial_year_to"].ToString()).ToString("dd/MM/yyyy");
                fy.Add(objfn);
            }
            rdr.Close();
            return fy;
        }

        public short DeleteLedgerTreeview(string strLedgerName, Ledgers fy)
        {

            packageName = "PKG_ACCOUNTS_SETUP.DeleteTreeLedger";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("PstrLedgerName",OracleDbType.Varchar2,100,strLedgerName,ParameterDirection.Input),
                        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,fy.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,fy.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,fy.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,fy.EntryParameter.MachineID,ParameterDirection.Input),
                };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }


        public short DeleteGroupTreeview(string strGrName, GroupsConfig fy)
        {

            packageName = "PKG_ACCOUNTS_SETUP.DeleteTreeGroup";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("GrName",OracleDbType.Varchar2,100,strGrName,ParameterDirection.Input),
                        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,fy.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,fy.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,fy.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,fy.EntryParameter.MachineID,ParameterDirection.Input),
                };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }


        public List<BankReconcilation> GetBankReconPost(string pwhere)
        {
            string packageName = "PKG_ACCOUNTS_SETUP.GetBankReconPost";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("pwhere",OracleDbType.Varchar2,pwhere,ParameterDirection.Input),

            };
            return GetBankReconPost(packageName, parameterList);
        }
        private List<BankReconcilation> GetBankReconPost(string packageName, OracleParameter[] parameterList)
        {
            List<BankReconcilation> fy = new List<BankReconcilation>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                BankReconcilation objfn = new BankReconcilation();
                objfn.PostStatus = rdr["post_status"].ToString();
                fy.Add(objfn);
            }
            rdr.Close();
            return fy;
        }


        public short InsertIntegretedBr(string MofuleRefNo,double dblTotalAmount,int voucheras,string strdate,string Ledgercode,string ReverseLEdger,string Narration,int intModule,BankReconcilation fy)
        {

            packageName = "PKG_ACCOUNTS_SETUP.IntegretedBankCharge";

            OracleParameter[] parameterList = new OracleParameter[]
                {
                        new OracleParameter("pmodulerefno",OracleDbType.Varchar2,60,"",ParameterDirection.Input),
                        new OracleParameter("ptotalamount",OracleDbType.Double,30,dblTotalAmount,ParameterDirection.Input),
                        new OracleParameter("plngvoucheras",OracleDbType.Int32 ,2,voucheras,ParameterDirection.Input),
                        new OracleParameter("pdate",OracleDbType.Varchar2,strdate,ParameterDirection.Input),
                        new OracleParameter("pstrledger",OracleDbType.Varchar2,60 ,Ledgercode,ParameterDirection.Input),
                        new OracleParameter("preveseledger",OracleDbType.Varchar2,60,ReverseLEdger,ParameterDirection.Input),
                        new OracleParameter("pstrnarrations",OracleDbType.Varchar2,300,Narration,ParameterDirection.Input),
                        new OracleParameter("pintmodule",OracleDbType.Int16,2,intModule,ParameterDirection.Input),
                        new OracleParameter("Pentryby",OracleDbType.Varchar2,60,fy.EntryParameter.EntryBy ,ParameterDirection.Input),
                        new OracleParameter("PcomID",OracleDbType.Varchar2,2,fy.EntryParameter.CompanyID,ParameterDirection.Input),
                        new OracleParameter("PlocID",OracleDbType.Varchar2,2,fy.EntryParameter.LocationID,ParameterDirection.Input),
                        new OracleParameter("PmacID",OracleDbType.Varchar2,30,fy.EntryParameter.MachineID,ParameterDirection.Input),
                };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }




    }
}
