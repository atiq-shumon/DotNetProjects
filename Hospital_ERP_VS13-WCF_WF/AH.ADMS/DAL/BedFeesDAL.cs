using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ADMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.DUtility;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.PRMS.MODEL;


namespace AH.ADMS.DAL
{
    public class BedFeesDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.PRMIS);
        string packageName = string.Empty;
        public List<BedCharges> GetBedRateShow(string bedtype)
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_FEESETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
           new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input),
           
       };
            return GetBedCharges(packageName, parameterList);
        }
        private List<BedCharges> GetBedCharges(string packageName, OracleParameter[] parameterList)
        {
            List<BedCharges> bdch = new List<BedCharges>();

            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                BedCharges bdc = new BedCharges();
                bdc.Amount = Decimal.Parse(rdr[5].ToString());

                RevenueHeadGroup rhd = new RevenueHeadGroup();
                rhd.ID = (string)rdr[3];
                rhd.Title = (string)rdr[9];
                bdc.RevenueHeadGroup = rhd;

                RevenueHead rv = new RevenueHead();
                rv.ID = (string)rdr[4];
                rv.Title = (string)rdr[10];
                bdc.RevenueHead = rv;

                BedType btp = new BedType();
                btp.Title = (string)rdr[8];
                bdc.BedType = btp;

                Building bld = new Building();
                bld.BuildingID = (string)rdr[0];
                bld.BuildingTitle = (string)rdr[6];
                bdc.Building = bld;

                Department dpt = new Department();
                dpt.DepartmentID = (string)rdr[1];
                dpt.DepartmentTitle = (string)rdr[7];
                bdc.Department = dpt;

                //Bed bd = new Bed();

                bdch.Add(bdc);
            }
            rdr.Close();
            return bdch;
        }
        public short SaveBedFee(BedCharges tbd)
        {
            packageName = "PKG_PRMS_SETUP.INSERT_BED_FEESETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("BuildID",OracleDbType.Varchar2,3,tbd.Building.BuildingID,ParameterDirection.Input),
           new OracleParameter("Department",OracleDbType.Varchar2,5,tbd.Department.DepartmentID,ParameterDirection.Input),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,tbd.BedType.ID,ParameterDirection.Input),
           new OracleParameter("RevenueHeadGroup",OracleDbType.Varchar2,10,tbd.RevenueHeadGroup.ID,ParameterDirection.Input),
           new OracleParameter("RevenueHead",OracleDbType.Varchar2,10,tbd.RevenueHead.ID,ParameterDirection.Input),
           new OracleParameter("Amount",OracleDbType.Decimal,tbd.Amount,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,tbd.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,tbd.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,tbd.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,tbd.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateBedFee(BedCharges ubd)
        {
            packageName = "PKG_PRMS_SETUP.UPDATE_BED_FEESETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
           new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
           new OracleParameter("BedType",OracleDbType.Varchar2,2,ubd.BedType.ID,ParameterDirection.Input),
           new OracleParameter("RevenueHeadGroup",OracleDbType.Varchar2,10,ubd.RevenueHeadGroup.ID,ParameterDirection.Input),
           new OracleParameter("RevenueHead",OracleDbType.Varchar2,10,ubd.RevenueHead.ID,ParameterDirection.Input),
           new OracleParameter("Amount",OracleDbType.Decimal,ubd.Amount,ParameterDirection.Input),
           new OracleParameter("EntryBy",OracleDbType.Varchar2,20,ubd.EntryParameter.EntryBy,ParameterDirection.Input),
           new OracleParameter("CompanyID",OracleDbType.Varchar2,2,ubd.EntryParameter.CompanyID,ParameterDirection.Input),
           new OracleParameter("LocationID",OracleDbType.Varchar2,2,ubd.EntryParameter.LocationID,ParameterDirection.Input),
           new OracleParameter("MachineID",OracleDbType.Varchar2,20,ubd.EntryParameter.MachineID,ParameterDirection.Input)
       };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public int VerifyBedTestFee(string bedtype)
        {
            packageName = "PKG_PRMS_SETUP.Verify_BedTest_Fee";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Result",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("BedTypeID",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }

        public List<BedCharges> GetBedRates()
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_FEESETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),

        };
            return GetBedCharges(packageName, parameterList);
        }
        public List<BedCharges> GetBedRateSetup(string bedtype, string headgroup)
        {
            string packageName = "PKG_PRMS_SETUP.GET_BED_FEESETUP";
            OracleParameter[] parameterList = new OracleParameter[]{
            new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
            new OracleParameter("BedType",OracleDbType.Varchar2,2,bedtype,ParameterDirection.Input),
            new OracleParameter("HeadGroup",OracleDbType.Varchar2,5,headgroup,ParameterDirection.Input)
        };
            return GetBedCharges(packageName, parameterList);
        }
    }
}
