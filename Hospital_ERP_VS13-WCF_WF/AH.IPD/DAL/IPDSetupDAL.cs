using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.PatReg.MODEL;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.IPD.MODEL;
//using AH.Shared.MODEL;

namespace AH.IPD.DAL
{
    public class IPDSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;

        public List<DeliveryType> GetDeliveryType()
        {
            string packageName = "PKG_IPD_SETUP.GET_DELV_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetDelivery(packageName, parameterList);
        }
        private List<DeliveryType> GetDelivery(string packageName, OracleParameter[] parameterList)
        {
            List<DeliveryType> dltype = new List<DeliveryType>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DeliveryType deltp = new DeliveryType();
                deltp.ID = (string)rdr[0];
                deltp.Title = (string)rdr[1];
                deltp.TitleBeng = (string)rdr[2];
                deltp.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";
                dltype.Add(deltp);

            }
            rdr.Close();
            return dltype;
        }
        public int VerifyDelivery(string delid)
        {
            packageName = "PKG_IPD_SETUP.VERIFY_DELID";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("DeliveryID",OracleDbType.Varchar2,3,delid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        public short SaveDeliveryType(DeliveryType tipd)
        {
            packageName = "PKG_IPD_SETUP.INSERT_DELV_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("TypeName",OracleDbType.Varchar2,70,tipd.Title,ParameterDirection.Input),
              new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,tipd.TitleBeng,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,tipd.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tipd.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tipd.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,tipd.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,tipd.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateDelType(DeliveryType uipd)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_DELV_TYPE";

            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TypeId",OracleDbType.Varchar2,3,uipd.ID,ParameterDirection.Input),
                new OracleParameter("TypeName",OracleDbType.Varchar2,70,uipd.Title,ParameterDirection.Input),
                new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,uipd.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,uipd.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,uipd.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,uipd.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,uipd.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,uipd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        
        public List<AdmissionReason> GetAdmReason()
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_REASON";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetAdmRes(packageName, parameterList);

        }

        private List<AdmissionReason> GetAdmRes(string packageName, OracleParameter[] parameterList)
        {
            List<AdmissionReason> admn = new List<AdmissionReason>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdmissionReason adrs = new AdmissionReason();
                adrs.ID = (string)rdr[0];
                adrs.Title = (string)rdr[1];
                adrs.TitleBeng = (string)rdr[2];
                adrs.MinStayDays = short.Parse(rdr[3].ToString());
                admn.Add(adrs);
            }
            rdr.Close();
            return admn;
        }
        public int GetMinStayingDays(string admReason)
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_REASON";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MinStay",OracleDbType.Int32,3,admReason,ParameterDirection.Input)
            };
            return GetMinStay(packageName, parameterList);
        }
        private int GetMinStay(string packageName, OracleParameter[] parameterList)
        {
            OracleDataReader rdr;
            int i = 0;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                i = short.Parse(rdr[3].ToString());
            }
            rdr.Close();
            return i;

        }
        public short SaveAdmissionReason(AdmissionReason admr)
        {
            packageName = "PKG_IPD_SETUP.INSERT_ADM_REASON";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReasonID",OracleDbType.Varchar2,3,admr.ID,ParameterDirection.Input),
                new OracleParameter("ReasonName",OracleDbType.Varchar2,70,admr.Title,ParameterDirection.Input),
                new OracleParameter("ReasonNameBeng",OracleDbType.Varchar2,70,admr.TitleBeng,ParameterDirection.Input),
                new OracleParameter("MinStayingDays",OracleDbType.Int32,3,admr.MinStayDays,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,admr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,admr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,admr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,admr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }
        public List<AdmReasonAssign> GetAdmReasonAss()
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_REASON_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetAdmReasonAssnm(packageName, parameterList);
        }
        public List<AdmReasonAssign> GetAdmReasonAss(string departmentID)
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_REASON_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Dept",OracleDbType.Varchar2,5,departmentID,ParameterDirection.Input)
            };
            return GetAdmReasonAssnm(packageName, parameterList);
        }
        private List<AdmReasonAssign> GetAdmReasonAssnm(string packageName, OracleParameter[] parameterList)
        {
            List<AdmReasonAssign> adass = new List<AdmReasonAssign>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdmReasonAssign ads = new AdmReasonAssign();

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr[0];
                dpt.DepartmentTitle = (string)rdr[1];
                ads.Department = dpt;

                AdmissionReason admis = new AdmissionReason();
                admis.ID = (string)rdr[2];
                admis.Title = (string)rdr[3];
                ads.AdmissionReason = admis;

                adass.Add(ads);
            }
            rdr.Close();
            return adass;

        }
        public short SaveAdmReasonAss(AdmReasonAssign admass)
        {
            packageName = "PKG_IPD_SETUP.INSERT_ADM_REASON_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReasonID",OracleDbType.Varchar2,3,admass.AdmissionReason.ID,ParameterDirection.Input),
                new OracleParameter("DepartmentID",OracleDbType.Varchar2,5,admass.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,admass.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,admass.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,admass.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,admass.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }

        public short UpdateAdmissionReason(AdmissionReason admr)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_ADM_REASON";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReasonID",OracleDbType.Varchar2,3,admr.ID,ParameterDirection.Input),
                new OracleParameter("ReasonName",OracleDbType.Varchar2,70,admr.Title,ParameterDirection.Input),
                new OracleParameter("ReasonNameBeng",OracleDbType.Varchar2,70,admr.TitleBeng,ParameterDirection.Input),
                new OracleParameter("MinStayingDays",OracleDbType.Int32,3,admr.MinStayDays,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,admr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,admr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,admr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,admr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        //===================10-11-2014=========================================//
        public short SaveAdmissionReffType(AdmissionReference delType)
        {
            packageName = "PKG_IPD_SETUP.INSERT_ADM_REFF_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("TypeTitle",OracleDbType.Varchar2,100,delType.Title,ParameterDirection.Input),
              new OracleParameter("TypeTitleBeng",OracleDbType.Varchar2,100,delType.TitleBeng,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,delType.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,delType.EntryParameter.EntryBy,ParameterDirection.Input),
               new OracleParameter("Update",OracleDbType.Varchar2,20,delType.EntryParameter.UpdateBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,delType.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,delType.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,delType.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<AdmissionReference> GetAdmReffType()
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_REFF_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetAdmReffType(packageName, parameterList);

        }

        private List<AdmissionReference> GetAdmReffType(string packageName, OracleParameter[] parameterList)
        {
            List<AdmissionReference> delTyps = new List<AdmissionReference>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                AdmissionReference delTyp = new AdmissionReference();
                delTyp.ID = (string)rdr[0];
                delTyp.Title = (string)rdr[1];
                delTyp.TitleBeng = (string)rdr[2];     
                delTyp.Remarks = !rdr.IsDBNull(3) ? (string)rdr[3] : "";     
                delTyps.Add(delTyp);
            }
            rdr.Close();
            return delTyps;
        }

        public short UpdateAdmissionReffType(AdmissionReference delType)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_ADM_REFF_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("TypeID",OracleDbType.Varchar2,5,delType.ID,ParameterDirection.Input),
              new OracleParameter("TypeTitle",OracleDbType.Varchar2,100,delType.Title,ParameterDirection.Input),
              new OracleParameter("TypeTitleBeng",OracleDbType.Varchar2,100,delType.TitleBeng,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,delType.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,delType.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("Update",OracleDbType.Varchar2,20,delType.EntryParameter.UpdateBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,delType.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,delType.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,delType.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        //===========================17-12-2014=============================



        public short SaveCancelReason(CancelReasonSetup canRes)
        {
            packageName = "PKG_IPD_SETUP.INSERT_ADM_CANCEL_REASON";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("ReasonTitle",OracleDbType.Varchar2,70,canRes.Title,ParameterDirection.Input),
              new OracleParameter("ReasonTitle_Beng",OracleDbType.Varchar2,70,canRes.TitleBeng,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,canRes.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,canRes.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,canRes.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,canRes.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,canRes.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public List<CancelReasonSetup> GetCancelReason()
        {
            string packageName = "PKG_IPD_SETUP.GET_ADM_CANCEL_REASON";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetCancelReason(packageName, parameterList);
        }

        private List<CancelReasonSetup> GetCancelReason(string packageName, OracleParameter[] parameterList)
        {
            List<CancelReasonSetup> dltype = new List<CancelReasonSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                CancelReasonSetup deltp = new CancelReasonSetup();
                deltp.ID = (string)rdr["REASON_ID"];
                deltp.Title = (string)rdr["REASON_TITLE"];
                deltp.TitleBeng = (string)rdr["REASON_TITLE_BENG"];
                deltp.Remarks = !rdr.IsDBNull(3) ? (string)rdr["REMARKS"] : "";
                dltype.Add(deltp);

            }
            rdr.Close();
            return dltype;
        }
        public short UpdateCancelReason(CancelReasonSetup canRes)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_ADM_CANCEL_REASON";

            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReasonId",OracleDbType.Varchar2,3,canRes.ID,ParameterDirection.Input),
                new OracleParameter("ReasonTitle",OracleDbType.Varchar2,70,canRes.Title,ParameterDirection.Input),
                new OracleParameter("ReasonTitleBeng",OracleDbType.Varchar2,70,canRes.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,canRes.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,canRes.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,canRes.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,canRes.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,canRes.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        //============================06-01-2015===========================//
        public short SavePackageMaster(PackageSetup pkg)
        {
            packageName = "PKG_IPD_SETUP.INSERT_PKG_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("p_PackageTitle",OracleDbType.Varchar2,200,pkg.PackageTitle,ParameterDirection.Input),
              new OracleParameter("p_PackageTitleBeng",OracleDbType.Varchar2,200,pkg.PackageTitleBeng,ParameterDirection.Input),
              new OracleParameter("p_pkg_s_date",OracleDbType.Date,pkg.PackageStartDate,ParameterDirection.Input),
              new OracleParameter("p_pkg_e_date",OracleDbType.Date,pkg.PackageEndDate,ParameterDirection.Input),

              new OracleParameter("p_is_stay_dependent",OracleDbType.Char,1,pkg.IsStayDependent,ParameterDirection.Input),
              new OracleParameter("p_stay_days",OracleDbType.Decimal,pkg.StayDays,ParameterDirection.Input),
              new OracleParameter("p_is_amt_dependent",OracleDbType.Char,pkg.IsAmountDependent,ParameterDirection.Input),
              new OracleParameter("p_amount",OracleDbType.Decimal,pkg.Amount,ParameterDirection.Input),

              new OracleParameter("Remarks",OracleDbType.Varchar2,200,pkg.Remarks,ParameterDirection.Input),
              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,pkg.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,pkg.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,pkg.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,pkg.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        //=============07-01-2015======================////
        public List<PackageSetup> GetPackageMaster()
        {
            string packageName = "PKG_IPD_SETUP.GET_PACKAGE_MASTER";

            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetPackageMaster(packageName, parameterList);

        }
        private List<PackageSetup> GetPackageMaster(string packageName, OracleParameter[] parameterList)
        {
            List<PackageSetup> oPkgs = new List<PackageSetup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageSetup oPkg = new PackageSetup();
                oPkg.PackageID = (string)rdr["PKG_ID"];
                oPkg.PackageTitle = (string)rdr["PKG_TITLE"];
                oPkg.PackageTitleBeng = (string)rdr["PKG_TITLE_BENG"];
                oPkg.PackageStartDate = (DateTime)rdr["PKG_S_DATE"];
                oPkg.PackageEndDate = (DateTime)rdr["PKG_E_DATE"];
                oPkg.IsStayDependent = Convert.ToChar(rdr["IS_STAY_DEPENDENT"]);
                oPkg.IsAmountDependent = Convert.ToChar(rdr["IS_AMT_DEPENDENT"]);
                oPkg.StayDays = Convert.ToInt32(rdr["STAY_DAYS"]);
                oPkg.Amount = Convert.ToInt32(rdr["AMOUNT"]);
                oPkg.Remarks = !rdr.IsDBNull(9) ? (string)rdr["Remarks"] : "";
                oPkgs.Add(oPkg);

            }
            rdr.Close();
            return oPkgs;
        }
        public short UpdatePackageMaster(PackageSetup pkg)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_PACKAGE_MASTER";
            OracleParameter[] parameterList = new OracleParameter[]{
              new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
              new OracleParameter("p_PackageID",OracleDbType.Varchar2,10,pkg.PackageID,ParameterDirection.Input),
              new OracleParameter("p_PackageTitle",OracleDbType.Varchar2,200,pkg.PackageTitle,ParameterDirection.Input),
              new OracleParameter("p_PackageTitleBeng",OracleDbType.Varchar2,200,pkg.PackageTitleBeng,ParameterDirection.Input),
              new OracleParameter("p_pkg_s_date",OracleDbType.Date,pkg.PackageStartDate,ParameterDirection.Input),
              new OracleParameter("p_pkg_e_date",OracleDbType.Date,pkg.PackageEndDate,ParameterDirection.Input),

              new OracleParameter("p_is_stay_dependent",OracleDbType.Char,1,pkg.IsStayDependent,ParameterDirection.Input),
              new OracleParameter("p_stay_days",OracleDbType.Decimal,pkg.StayDays,ParameterDirection.Input),
              new OracleParameter("p_is_amt_dependent",OracleDbType.Char,pkg.IsAmountDependent,ParameterDirection.Input),
              new OracleParameter("p_amount",OracleDbType.Decimal,pkg.Amount,ParameterDirection.Input),
              new OracleParameter("Remarks",OracleDbType.Varchar2,200,pkg.Remarks,ParameterDirection.Input),

              new OracleParameter("EntryBy",OracleDbType.Varchar2,20,pkg.EntryParameter.EntryBy,ParameterDirection.Input),
              new OracleParameter("CompanyID",OracleDbType.Varchar2,2,pkg.EntryParameter.CompanyID,ParameterDirection.Input),
              new OracleParameter("LocationID",OracleDbType.Varchar2,2,pkg.EntryParameter.LocationID,ParameterDirection.Input),
              new OracleParameter("MachineID",OracleDbType.Varchar2,20,pkg.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

    }
}
