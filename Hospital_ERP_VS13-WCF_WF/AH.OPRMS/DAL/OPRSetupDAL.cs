
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OPRMS.MODEL;
using AH.DUtility;
using AH.OracleManager;

namespace AH.OPRMS.DAL
{
    public class OPRSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        string packageName = string.Empty;
        #region "Grade"
        public short SaveGradeSetup(Grade objTran)
        {

            packageName = "AGH_IPD.PKG_OPR.InserOprGrade";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                //new OracleParameter("Pgradeid",OracleDbType.Varchar2,4, objTran.GradeId,ParameterDirection.Input),
                new OracleParameter("Pgradetitle",OracleDbType.Varchar2 ,200,objTran.GradeTitle ,ParameterDirection.Input),
                new OracleParameter("Pgradetitlebang",OracleDbType.Varchar2,200,objTran.GradeTitle ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short UpdateGradeSetup(Grade objTran)
        {

            packageName = "AGH_IPD.PKG_OPR.UpdateOprGrade";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pgradeid",OracleDbType.Varchar2,4, objTran.GradeId,ParameterDirection.Input),
                new OracleParameter("Pgradetitle",OracleDbType.Varchar2 ,200,objTran.GradeTitle ,ParameterDirection.Input),
                new OracleParameter("Pgradetitlebang",OracleDbType.Varchar2,200,objTran.GradeTitle ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short DeleteGrade(Grade objTran)
        {

            packageName = "AGH_IPD.PKG_OPR.DeleteItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcontrol",OracleDbType.Varchar2,30, "DeleteGrade",ParameterDirection.Input),
                new OracleParameter("Pid",OracleDbType.Varchar2 ,4,objTran.GradeId ,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        #endregion
        #region "Theater"
        public short SavetheaterSetup(Theater objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserOprTheater";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pbuildid",OracleDbType.Varchar2 ,3,objTran.Buildid ,ParameterDirection.Input),
                new OracleParameter("Pfloor",OracleDbType.Varchar2,2,objTran.FloorNo  ,ParameterDirection.Input),
                new OracleParameter("Pblockno",OracleDbType.Varchar2,30,objTran.BlockNo  ,ParameterDirection.Input),
                new OracleParameter("ProomID",OracleDbType.Varchar2,30,objTran.RoomId ,ParameterDirection.Input),
                new OracleParameter("Ptheaterid",OracleDbType.Varchar2,5,objTran.Theaterid ,ParameterDirection.Input),
                new OracleParameter("Ptheatertitle",OracleDbType.Varchar2,200,objTran.Theatertitle ,ParameterDirection.Input),
                new OracleParameter("Pnooffacilities",OracleDbType.Int64 ,30,objTran.NoofFacilities ,ParameterDirection.Input),
                new OracleParameter("PisDep_spe",OracleDbType.Char,1,objTran.DepSpe ,ParameterDirection.Input),
                new OracleParameter("Pdep_id",OracleDbType.Varchar2 ,6,objTran.DepId ,ParameterDirection.Input),
                new OracleParameter("Pphoneno",OracleDbType.Varchar2,100,objTran.PhoneNo ,ParameterDirection.Input),
                new OracleParameter("Pinchageid",OracleDbType.Varchar2,30,objTran.Inchargeid ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short UpdatetheaterSetup(Theater objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOprTheater";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                //new OracleParameter("Pgradeid",OracleDbType.Varchar2,4, objTran.GradeId,ParameterDirection.Input),
                new OracleParameter("Pbuildid",OracleDbType.Varchar2 ,3,objTran.Buildid ,ParameterDirection.Input),
                new OracleParameter("Pfloor",OracleDbType.Varchar2,2,objTran.FloorNo  ,ParameterDirection.Input),
                new OracleParameter("Pblockno",OracleDbType.Varchar2,30,objTran.BlockNo  ,ParameterDirection.Input),
                new OracleParameter("ProomID",OracleDbType.Varchar2,4,objTran.RoomId ,ParameterDirection.Input),
                new OracleParameter("Ptheaterid",OracleDbType.Varchar2,5,objTran.Theaterid ,ParameterDirection.Input),
                new OracleParameter("Ptheatertitle",OracleDbType.Varchar2,200,objTran.Theatertitle ,ParameterDirection.Input),
                new OracleParameter("Pnooffacilities",OracleDbType.Int64 ,30,objTran.NoofFacilities ,ParameterDirection.Input),
                new OracleParameter("PisDep_spe",OracleDbType.Char,1,objTran.DepSpe ,ParameterDirection.Input),
                new OracleParameter("Pdep_id",OracleDbType.Varchar2 ,6,objTran.DepId ,ParameterDirection.Input),
                new OracleParameter("Pphoneno",OracleDbType.Varchar2,100,objTran.PhoneNo ,ParameterDirection.Input),
                new OracleParameter("Pinchageid",OracleDbType.Varchar2,30,objTran.Inchargeid ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };

            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        public short Deletetheater(Theater objTran)
        {

            packageName = "AGH_IPD.PKG_OPR.DeleteItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcontrol",OracleDbType.Varchar2,30, "Deletetheater",ParameterDirection.Input),
                new OracleParameter("Pid",OracleDbType.Varchar2 ,5,objTran.Theaterid ,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            return 1;
            //else return 0;
        }
        #endregion
        #region "Anes Group"
        public short SaveAnesSetup(AnesthesiaGroup objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserOprAnesGroup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pgroupid",OracleDbType.Varchar2 ,3,objTran.AnesGroupID ,ParameterDirection.Input),
                new OracleParameter("Pgrouptitle",OracleDbType.Varchar2,200,objTran.AnesGroupTitle  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.AnesRemarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short UpdateAnesSetup(AnesthesiaGroup objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOprAnesGroup";
            OracleParameter[] parameterList = new OracleParameter[]
            {
               new OracleParameter("Pgroupid",OracleDbType.Varchar2 ,3,objTran.AnesGroupID ,ParameterDirection.Input),
                new OracleParameter("Pgrouptitle",OracleDbType.Varchar2,200,objTran.AnesGroupTitle  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.AnesRemarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
        }
        public short DeleteAnesGroup(AnesthesiaGroup objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.DeleteItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcontrol",OracleDbType.Varchar2,30, "DeletetAnesGroup",ParameterDirection.Input),
                new OracleParameter("Pid",OracleDbType.Varchar2 ,5,objTran.AnesGroupID ,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Anes Master"
        public short SaveAnesSetupMaster(AnesthesiaMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserOprAnesMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Panesid",OracleDbType.Varchar2 ,6,objTran.Anesesthesia ,ParameterDirection.Input),
                new OracleParameter("PgroupId",OracleDbType.Varchar2,6,objTran.GroupID  ,ParameterDirection.Input),
                new OracleParameter("Panestitle",OracleDbType.Varchar2,300,objTran.Anesthesiatitle  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short UpdateAnesSetupMaster(AnesthesiaMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOprAnesMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Panesid",OracleDbType.Varchar2 ,6,objTran.Anesesthesia ,ParameterDirection.Input),
                new OracleParameter("PgroupId",OracleDbType.Varchar2,6,objTran.GroupID  ,ParameterDirection.Input),
                new OracleParameter("Panestitle",OracleDbType.Varchar2,300,objTran.Anesthesiatitle  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Varchar2,2,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
        }
        public short DeleteAnesMaster(AnesthesiaMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.DeleteItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcontrol",OracleDbType.Varchar2,30, "DeletetAnesMaster",ParameterDirection.Input),
                new OracleParameter("Pid",OracleDbType.Varchar2 ,6,objTran.Anesesthesia ,ParameterDirection.Input),
            };

            short i = DALHelper.Delete(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Anes Master"
        public short SaveOperationSetup(OperationMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserOperationMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Poprtitle",OracleDbType.Varchar2 ,400,objTran.operationTitle  ,ParameterDirection.Input),
                new OracleParameter("PtypeCode",OracleDbType.Varchar2,10,objTran.OperationTypeCode   ,ParameterDirection.Input),
                new OracleParameter("Pgradeid",OracleDbType.Varchar2,10,objTran.GradeID  ,ParameterDirection.Input),
                new OracleParameter("Panesid",OracleDbType.Varchar2,10,objTran.Anesthesiatitle  ,ParameterDirection.Input),
                new OracleParameter("PoprFees",OracleDbType.Double ,30,objTran.OperationFees  ,ParameterDirection.Input),
                new OracleParameter("PdrFees",OracleDbType.Double,30,objTran.DrFees  ,ParameterDirection.Input),
                new OracleParameter("PanesFees",OracleDbType.Double,30,objTran.AnesFees  ,ParameterDirection.Input),
                new OracleParameter("PasstFees",OracleDbType.Double,30,objTran.AssistantFees  ,ParameterDirection.Input),
                new OracleParameter("Pexpectedhour",OracleDbType.Varchar2,20,objTran.ExpectedTimeHour  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks  ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Int16,1,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short UpdateOperationSetup(OperationMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOperationMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Popr_id",OracleDbType.Varchar2 ,400,objTran.OperationID ,ParameterDirection.Input),
                new OracleParameter("Poprtitle",OracleDbType.Varchar2 ,400,objTran.operationTitle  ,ParameterDirection.Input),
                new OracleParameter("PtypeCode",OracleDbType.Varchar2,10,objTran.OperationTypeCode   ,ParameterDirection.Input),
                new OracleParameter("Pgradeid",OracleDbType.Varchar2,10,objTran.GradeID  ,ParameterDirection.Input),
                new OracleParameter("Panesid",OracleDbType.Varchar2,10,objTran.Anesthesiatitle  ,ParameterDirection.Input),
                new OracleParameter("PoprFees",OracleDbType.Double ,30,objTran.OperationFees  ,ParameterDirection.Input),
                new OracleParameter("PdrFees",OracleDbType.Double,30,objTran.DrFees  ,ParameterDirection.Input),
                new OracleParameter("PanesFees",OracleDbType.Double,30,objTran.AnesFees  ,ParameterDirection.Input),
                new OracleParameter("PasstFees",OracleDbType.Double,30,objTran.AssistantFees  ,ParameterDirection.Input),
                new OracleParameter("Pexpectedhour",OracleDbType.Varchar2,20,objTran.ExpectedTimeHour  ,ParameterDirection.Input),
                new OracleParameter("Premarks",OracleDbType.Varchar2,300,objTran.Remarks  ,ParameterDirection.Input),
                new OracleParameter("Pactive",OracleDbType.Int16,1,objTran.Active ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Category"
        public short SavedDoctotsCategoryMaster(DoctorsCategory objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertDoctorsCategoryMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PidMaster",OracleDbType.Varchar2 ,60,objTran.FixedKeyMaster  ,ParameterDirection.Input),
                new OracleParameter("PassignmentName",OracleDbType.Varchar2,60,objTran.CategoryName   ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short SavedDoctotsCategory(DoctorsCategory  objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertDoctorsCategoryChild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcatdmaster",OracleDbType.Varchar2,60,objTran.FixedKeyMaster ,ParameterDirection.Input),
                new OracleParameter("Pcategorytype",OracleDbType.Int16,2,objTran.assignmenttype  ,ParameterDirection.Input),
                new OracleParameter("Pdoctorscode",OracleDbType.Varchar2,30,objTran.doctorscode   ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Packageitem"
        public short SavedPackagedItem(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertPackageItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PitemName",OracleDbType.Varchar2,60,objTran.ItemName ,ParameterDirection.Input),
                new OracleParameter("PopdMainId",OracleDbType.Varchar2,30,objTran.submenuID ,ParameterDirection.Input),
                new OracleParameter("PitemRate",OracleDbType.Double ,30,objTran.ItemRate,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short UpdatePackagedItem(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdatePackageItem";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pitemcode",OracleDbType.Varchar2,60,objTran.ItemNo ,ParameterDirection.Input),
                new OracleParameter("PitemName",OracleDbType.Varchar2,60,objTran.ItemName ,ParameterDirection.Input),
                new OracleParameter("PopdMainId",OracleDbType.Varchar2,30,objTran.submenuID ,ParameterDirection.Input),
                new OracleParameter("PitemRate",OracleDbType.Double,30,objTran.ItemRate  ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
        }
    #endregion
        #region "PacketMaster"
        public string SavedPackageMaster(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertPackageMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Cur_01",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("PitemName",OracleDbType.Varchar2,60,objTran.ItemName ,ParameterDirection.Input),
                new OracleParameter("PnetAmount",OracleDbType.Double,30,objTran.NetAmount  ,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2, 30,objTran.Oprtype ,ParameterDirection.Input),
                new OracleParameter("pbedtytpe",OracleDbType.Varchar2,30,objTran.Bedtype,ParameterDirection.Input),
                new OracleParameter("pbedstatus",OracleDbType.Int16,2,objTran.Bedstatus,ParameterDirection.Input),
                new OracleParameter("pfromdate",OracleDbType.Varchar2,30,objTran.fromdate,ParameterDirection.Input),
                new OracleParameter("ptodate",OracleDbType.Varchar2,30,objTran.todate,ParameterDirection.Input),
                new OracleParameter("punitID",OracleDbType.Varchar2,30,objTran.unitID,ParameterDirection.Input),
                new OracleParameter("punitname",OracleDbType.Varchar2,200,objTran.unitName,ParameterDirection.Input),

                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0"; 

        }
        public short SavedPackageChild(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertPackageChild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PackageNo",OracleDbType.Varchar2,100,objTran.PackageItemNo ,ParameterDirection.Input),
                new OracleParameter("Pitemcode",OracleDbType.Varchar2,60,objTran.ItemNo ,ParameterDirection.Input),
                new OracleParameter("PitemRate",OracleDbType.Double,30,objTran.ItemRate  ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;

        }

        public short  UpdatePackageMaster(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdatePackageMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PackageNo",OracleDbType.Varchar2,60,objTran.PackageItemNo,ParameterDirection.Input),
                new OracleParameter("PitemName",OracleDbType.Varchar2,60,objTran.ItemName ,ParameterDirection.Input),
                new OracleParameter("PnetAmount",OracleDbType.Double,30,objTran.NetAmount  ,ParameterDirection.Input),
                new OracleParameter("ptypeid",OracleDbType.Varchar2, 30,objTran.Oprtype ,ParameterDirection.Input),
                new OracleParameter("pbedtytpe",OracleDbType.Varchar2,30,objTran.Bedtype,ParameterDirection.Input),
                new OracleParameter("pbedstatus",OracleDbType.Int16,2,objTran.Bedstatus,ParameterDirection.Input),
                new OracleParameter("pfromdate",OracleDbType.Varchar2,30,objTran.fromdate,ParameterDirection.Input),
                new OracleParameter("ptodate",OracleDbType.Varchar2,30,objTran.todate,ParameterDirection.Input),
                new OracleParameter("punitID",OracleDbType.Varchar2,30,objTran.unitID,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;

            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";

        }
        public short UpdatePackageChild(PackageItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdatePackageChild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PackageNo",OracleDbType.Varchar2,100,objTran.PackageItemNo ,ParameterDirection.Input),
                new OracleParameter("Pitemcode",OracleDbType.Varchar2,60,objTran.ItemNo ,ParameterDirection.Input),
                new OracleParameter("PitemRate",OracleDbType.Double,30,objTran.ItemRate  ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;

        }
        #endregion
        #region "Operation Master"

        public string SavedOperationSchedulingMaster(CalenderOT objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertOperationMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Cur_01",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("Pscheduledate",OracleDbType.Varchar2,30,objTran.RegDate,ParameterDirection.Input),
                new OracleParameter("Pinchargeid",OracleDbType.Varchar2,30,objTran.InchargeId ,ParameterDirection.Input),
                new OracleParameter("packageid",OracleDbType.Varchar2,30,objTran.PackageId  ,ParameterDirection.Input),
                new OracleParameter("patientid",OracleDbType.Varchar2,30,objTran.PatientId ,ParameterDirection.Input),
                new OracleParameter("psrattime",OracleDbType.Varchar2,30,objTran.Fromtime  ,ParameterDirection.Input),
                new OracleParameter("Pendtime",OracleDbType.Varchar2,30,objTran.Totime  ,ParameterDirection.Input),
                new OracleParameter("Potduration",OracleDbType.Int32,30,0 ,ParameterDirection.Input),
                new OracleParameter("Potstatus",OracleDbType.Int16 ,2,objTran.status  ,ParameterDirection.Input),
                new OracleParameter("Pcommnets",OracleDbType.Varchar2,100,objTran.Comments ,ParameterDirection.Input),
                new OracleParameter("Pottype",OracleDbType.Varchar2,100,objTran.Oprtype ,ParameterDirection.Input),
                new OracleParameter("Potid",OracleDbType.Varchar2,100,objTran.OprID ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;

            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
            //return 1;
        }

        public short SavedOperationSchedulingChild(string strScheduleid, string stRegDate, 
                                                    int intRow, int intCol, string strTheaterid, 
                                                    string strTimesSlot, string entryby,int intversion,string strcompanyid,string strlocationid,string strmachineid)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertOperationChild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PschedulingId",OracleDbType.Varchar2,30,strScheduleid,ParameterDirection.Input),
                new OracleParameter("Pscheduledate",OracleDbType.Varchar2,30,stRegDate ,ParameterDirection.Input),
                new OracleParameter("PlngRowpos",OracleDbType.Varchar2,30,intRow  ,ParameterDirection.Input),
                new OracleParameter("PlngColpos",OracleDbType.Varchar2,30,intCol ,ParameterDirection.Input),
                new OracleParameter("pstrottheaterid",OracleDbType.Varchar2,30,strTheaterid  ,ParameterDirection.Input),
                new OracleParameter("Pstrtimeslot",OracleDbType.Varchar2,30,strTimesSlot ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,entryby ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,intversion  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,strcompanyid,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,strlocationid,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,strmachineid,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;

            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return 1;
        }

        public short SavedOTteam(string strScheduleid, string strDoctorsID, string entryby,
                                    int intversion, string strcompanyid, string strlocationid, string strmachineid, 
                                    string strdoctorsFtime, string strdoctorsTtime)
        {
            packageName = "AGH_IPD.PKG_OPR.InsertDoctorsTeam";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PschedulingId",OracleDbType.Varchar2,30,strScheduleid,ParameterDirection.Input),
                new OracleParameter("Pdoctorsid",OracleDbType.Varchar2,30,strDoctorsID ,ParameterDirection.Input),
                new OracleParameter("PNotAvilFtime",OracleDbType.Varchar2,150,strdoctorsFtime ,ParameterDirection.Input),
                new OracleParameter("PNotAvilTtime",OracleDbType.Varchar2,150,strdoctorsTtime ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,entryby ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,intversion  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,strcompanyid,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,strlocationid,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,strmachineid,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;

            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return 1;
        }


        public string UpdateOperationSchedulingMaster(CalenderOT objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOperationMaster";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Cur_01",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("psheduleid",OracleDbType.Varchar2,60,objTran.ScheduleID,ParameterDirection.Input),
                new OracleParameter("Pscheduledate",OracleDbType.Varchar2,30,objTran.RegDate,ParameterDirection.Input),
                new OracleParameter("Pinchargeid",OracleDbType.Varchar2,30,objTran.InchargeId ,ParameterDirection.Input),
                new OracleParameter("packageid",OracleDbType.Varchar2,30,objTran.PackageId,ParameterDirection.Input),
                new OracleParameter("patientid",OracleDbType.Varchar2,30,objTran.PatientId ,ParameterDirection.Input),
                new OracleParameter("psrattime",OracleDbType.Varchar2,30,objTran.Fromtime  ,ParameterDirection.Input),
                new OracleParameter("Pendtime",OracleDbType.Varchar2,30,objTran.Totime  ,ParameterDirection.Input),
                new OracleParameter("Potduration",OracleDbType.Int32,30,0 ,ParameterDirection.Input),
                new OracleParameter("Potstatus",OracleDbType.Int16 ,0,objTran.status  ,ParameterDirection.Input),
                new OracleParameter("Pottype",OracleDbType.Varchar2 ,30,objTran.Oprtype  ,ParameterDirection.Input),
                new OracleParameter("Potid",OracleDbType.Varchar2 ,30,objTran.OprID  ,ParameterDirection.Input),
                new OracleParameter("Pcommnets",OracleDbType.Varchar2,100,objTran.Comments ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            //return 1;

            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return "1";
        }

        public string UpdateOTstatus(string strSchedulueID, int intStatus,string hcnno,string Regno,string Depid,
                                            string Unit,double dblPackageAmount, CalenderOT objTran)
        {
            if (intStatus == 3)
            {
                packageName = "AGH_IPD.PKG_OPR.UpdateOTCancelStatus";
            }
            else
            {
                packageName = "AGH_IPD.PKG_OPR.UpdateOTStatus";
            }
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pscheduleid",OracleDbType.Varchar2,60,strSchedulueID.ToString(),ParameterDirection.Input),
                new OracleParameter("Pintotstatus",OracleDbType.Int32,2,intStatus,ParameterDirection.Input),
                new OracleParameter("Phcnno",OracleDbType.Varchar2 ,30,hcnno,ParameterDirection.Input),
                new OracleParameter("Pregid",OracleDbType.Varchar2 ,30,Regno,ParameterDirection.Input),
                new OracleParameter("Pdepid",OracleDbType.Varchar2 ,30,Depid,ParameterDirection.Input),
                new OracleParameter("Punit",OracleDbType.Varchar2 ,30,Unit,ParameterDirection.Input),
                new OracleParameter("PackageAmount",OracleDbType.Double,30,dblPackageAmount,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            //return 1;

            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            return "1";
        }

        #endregion
        #region "Checklist"

        public short Savedchecklist(ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserChecklist";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Pcheklistitemname",OracleDbType.Varchar2,200,objTran.itemName ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short Updatedchecklist(ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateChecklist";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PChecklistCode",OracleDbType.Varchar2,30,objTran.itemCode ,ParameterDirection.Input),
                new OracleParameter("Pcheklistitemname",OracleDbType.Varchar2,200,objTran.itemName ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }

        public short Deletechecklist(ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.DeleteChecklist";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PChecklistCode",OracleDbType.Varchar2,30,objTran.itemCode ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }


        public string SavedChecklistConfigMaster(ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserCheckConfigMasterlist";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("cur_01",OracleDbType.Varchar2,60,null,ParameterDirection.Output),
                new OracleParameter("Poprtype",OracleDbType.Varchar2,30,objTran.oprType,ParameterDirection.Input),
                new OracleParameter("PregNo",OracleDbType.Varchar2,30,objTran.RegNo,ParameterDirection.Input),
                new OracleParameter("Pchecklistdate",OracleDbType.Varchar2,30,objTran.ChecklistDate,ParameterDirection.Input),
                new OracleParameter("Pscheduledate",OracleDbType.Varchar2,30,objTran.RegDate,ParameterDirection.Input),
                new OracleParameter("Pstratime",OracleDbType.Varchar2,30,objTran.startime,ParameterDirection.Input),
                new OracleParameter("Pendtime",OracleDbType.Varchar2,30,objTran.endtime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //return 1;
            OracleParameter prm = parameterList[0];
            if ((OracleString)prm.Value != "")
                return prm.Value.ToString();
            else return "0";
            //return 1;
        }

        public short SavedChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserCheckConfigchild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PoprmasterrefNo",OracleDbType.Varchar2,30,strRefNo,ParameterDirection.Input),
                new OracleParameter("Pchecklistitemcode",OracleDbType.Varchar2,30,stritemcode,ParameterDirection.Input),
                new OracleParameter("PYes",OracleDbType.Int16,2,intYes,ParameterDirection.Input),
                new OracleParameter("PNo",OracleDbType.Int16,2,intNo,ParameterDirection.Input),
                new OracleParameter("Pcommnets",OracleDbType.Varchar2,30,strComments,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            ////return 1;
        }

        public short UpdateChecklistConfigMaster(ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateCheckConfigMasterlist";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PoprmasterrefNo",OracleDbType.Varchar2,60,objTran.itemCode,ParameterDirection.Input),
                new OracleParameter("Poprtype",OracleDbType.Varchar2,30,objTran.oprType,ParameterDirection.Input),
                new OracleParameter("PregNo",OracleDbType.Varchar2,30,objTran.RegNo,ParameterDirection.Input),
                new OracleParameter("Pchecklistdate",OracleDbType.Varchar2,30,objTran.ChecklistDate,ParameterDirection.Input),
                new OracleParameter("Pscheduledate",OracleDbType.Varchar2,30,objTran.RegDate,ParameterDirection.Input),
                new OracleParameter("Pstratime",OracleDbType.Varchar2,30,objTran.startime,ParameterDirection.Input),
                new OracleParameter("Pendtime",OracleDbType.Varchar2,30,objTran.endtime,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            //return 1;
        }

        public short UpdateChecklistConfigChild(string strRefNo, string stritemcode, int intYes, int intNo, string strComments, ChecklistItem objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateCheckConfigchild";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PoprmasterrefNo",OracleDbType.Varchar2,30,strRefNo,ParameterDirection.Input),
                new OracleParameter("Pchecklistitemcode",OracleDbType.Varchar2,30,stritemcode,ParameterDirection.Input),
                new OracleParameter("PYes",OracleDbType.Int16,2,intYes,ParameterDirection.Input),
                new OracleParameter("PNo",OracleDbType.Int16,2,intNo,ParameterDirection.Input),
                new OracleParameter("Pcommnets",OracleDbType.Varchar2,30,strComments,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
            //OracleParameter prm = parameterList[0];
            //if ((OracleString)prm.Value != "")
            //    return prm.Value.ToString();
            //else return "0";
            ////return 1;
        }


        #endregion
        #region "Operation"
        public short SavedOperationInfo(OperationMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.InserOprinformation";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PinfoOpdName",OracleDbType.Varchar2,200,objTran.operationTitle ,ParameterDirection.Input),
                new OracleParameter("Popdtype",OracleDbType.Varchar2,30,objTran.OperationTypeCode,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            return 1;
        }
        public short UpdatOperationInfo(OperationMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.UpdateOprinformation";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PinfoopdCode",OracleDbType.Varchar2,30,objTran.OperationID ,ParameterDirection.Input),
                new OracleParameter("PinfoOpdName",OracleDbType.Varchar2,200,objTran.operationTitle ,ParameterDirection.Input),
                new OracleParameter("Popdtype",OracleDbType.Varchar2,30,objTran.OperationTypeCode ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            return 1;
        }

        public short DeleteOperationInfo(string stroprID, OperationMaster objTran)
        {
            packageName = "AGH_IPD.PKG_OPR.DeleteOprinformation";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("PinfoopdCode",OracleDbType.Varchar2,200,objTran.OperationID ,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,60,objTran.EntryParameter.EntryBy  ,ParameterDirection.Input),
                new OracleParameter("Pentrydate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pupdatedate",OracleDbType.Varchar2,30,DateTime.Now ,ParameterDirection.Input),
                new OracleParameter("Pversion",OracleDbType.Int16,1,objTran.EntryParameter.Version  ,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,objTran.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,objTran.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,objTran.EntryParameter.MachineID,ParameterDirection.Input),
            };
            short i = DALHelper.Delete(connstring, packageName, parameterList);
            return 1;
        }
        #endregion
        #region "Operation Type"
        public short SaveOperationType(OperationType ot)
        {
            packageName = "PKG_IPD_SETUP.INSERT_OPR_TYPE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TypeName",OracleDbType.Varchar2,70,ot.Title,ParameterDirection.Input),
                new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,ot.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,ot.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ot.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ot.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,ot.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,ot.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public short UpdateOperation(OperationType upot)
        {
            packageName = "PKG_IPD_SETUP.UPDATE_OPR_TYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("TypeID",OracleDbType.Varchar2,3,upot.ID,ParameterDirection.Input),
                new OracleParameter("TypeName",OracleDbType.Varchar2,70,upot.Title,ParameterDirection.Input),
                new OracleParameter("TypeNameBeng",OracleDbType.Varchar2,70,upot.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,upot.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,upot.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,upot.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,upot.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,upot.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }

        public int VerifyOperation(string typeid)
        {
            packageName = "PKG_IPD_SETUP.VERIFY_OPRTYPE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("TypeID",OracleDbType.Varchar2,3,typeid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }


        #endregion
        #region "Package Master"

        public short SavePackageOprMaster(PackageItem PI)
        {
            packageName = "PKG_OPR.InserOprPackageMaster";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Pname",OracleDbType.Varchar2,70,PI.ItemName,ParameterDirection.Input),
                new OracleParameter("unit_id",OracleDbType.Varchar2,70,PI.unitID,ParameterDirection.Input),
                new OracleParameter("punitname",OracleDbType.Varchar2,200,PI.unitName,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,PI.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,PI.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,PI.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,PI.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            return 1;
        }

        public short UpdatePackageOprMaster(PackageItem PI)
        {
            packageName = "PKG_OPR.UpdateOprPackageMaster";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("pcode",OracleDbType.Varchar2,70,PI.ItemNo,ParameterDirection.Input),
                new OracleParameter("Pname",OracleDbType.Varchar2,70,PI.ItemName,ParameterDirection.Input),
                new OracleParameter("unit_id",OracleDbType.Varchar2,70,PI.unitID,ParameterDirection.Input),
                new OracleParameter("unit_name",OracleDbType.Varchar2,70,PI.unitName,ParameterDirection.Input),
                new OracleParameter("Pentryby",OracleDbType.Varchar2,20,PI.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("Pcomid",OracleDbType.Varchar2,2,PI.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("Plocid",OracleDbType.Varchar2,2,PI.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("PmacID",OracleDbType.Varchar2,20,PI.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            //OracleParameter prm = parameterList[0];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else return 0;
            return 1;
        }

        public List<PackageItem> GetPackageMaster()
        {
            string packageName = "PKG_OPR.GetpackageMain";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetPackageMaster(packageName, parameterList);
        }
        private List<PackageItem> GetPackageMaster(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPI = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem PI = new PackageItem();
                PI.ItemNo = rdr["opd_main_id"].ToString();
                PI.ItemName = rdr["opd_main_name"].ToString();
                PI.unitID = rdr["unit_id"].ToString();
                objPI.Add(PI);
            }
            rdr.Close();
            return objPI;
        }

        public List<PackageItem> GetOprSubItem()
        {
            string packageName = "PKG_OPR.LoadPackageMain";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetOprSubItem(packageName, parameterList);
        }
        private List<PackageItem> GetOprSubItem(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPI = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem PI = new PackageItem();
                if (rdr["opd_main_id"].ToString() != "")
                {
                    PI.ItemNo = rdr["opd_main_id"].ToString();
                }
                else
                {
                    PI.ItemNo = "";
                }
                if (rdr["opd_main_name"].ToString() != "")
                {
                    PI.ItemName = rdr["opd_main_name"].ToString();
                }
                else
                {
                    PI.ItemName = "";
                }

                objPI.Add(PI);
            }
            rdr.Close();
            return objPI;
        }


        public List<PackageItem> GetPackageItemConfig()
        {
            string packageName = "PKG_OPR.GetPackageItemConfig";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            };
            return GetPackageItemConfig(packageName, parameterList);
        }
        private List<PackageItem> GetPackageItemConfig(string packageName, OracleParameter[] parameterList)
        {
            List<PackageItem> objPI = new List<PackageItem>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                PackageItem PI = new PackageItem();
                if (rdr["item_no"].ToString() != "")
                {
                    PI.ItemNo = rdr["item_no"].ToString();
                }
                else
                {
                    PI.ItemNo = "";
                }
                if (rdr["item_name"].ToString() != "")
                {
                    PI.ItemName = rdr["item_name"].ToString();
                }
                else
                {
                    PI.ItemName = "";
                }

                objPI.Add(PI);
            }
            rdr.Close();
            return objPI;
        }


        #endregion

        //public List<Operation> GetOperationStatus(string strRegNo)
        //{
        //    string packageName = "PKG_OPR.GetOperationStatus";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //         new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
        //        new OracleParameter("Pwhere",OracleDbType.Varchar2,100,strRegNo,ParameterDirection.Input),
        //    };
        //    return GetOperationStatus(packageName, parameterList);
        //}
        //private List<Operation> GetOperationStatus(string packageName, OracleParameter[] parameterList)
        //{
        //    List<Operation> objPI = new List<Operation>();
        //    OracleDataReader rdr;
        //    rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
        //    if (rdr.Read())
        //    {
        //        Operation PI = new Operation();
        //        if (rdr["ot_status"].ToString()=="Yes")
        //        {
        //            PI.blngStatus = true;
        //        }
        //        else
        //        {
        //            PI.blngStatus = false;
        //        }
        //        objPI.Add(PI);
        //    }
        //    rdr.Close();
        //    return objPI;
        //}


        public bool GetOperationStatus(string strRegNo)
        {

            string packageName = "PKG_OPR.GetOperationStatus";
            OracleParameter[] parameterList = new OracleParameter[]{
                 new OracleParameter("Cur_01",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("Pwhere",OracleDbType.Varchar2,100,strRegNo,ParameterDirection.Input),
            };
            return GetOperationStatus(packageName, parameterList);
        }
        private bool GetOperationStatus(string packageName, OracleParameter[] parameterList)
        {
            bool blngOprStatus=false;             
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            if (rdr.Read())
            {
                if  (rdr["ot_status"].ToString() == "1")
                {
                    blngOprStatus = true;
                }
                else
                {
                    blngOprStatus = false;
                }
            
            }
            rdr.Close();
            return blngOprStatus;
        }



    }
}
