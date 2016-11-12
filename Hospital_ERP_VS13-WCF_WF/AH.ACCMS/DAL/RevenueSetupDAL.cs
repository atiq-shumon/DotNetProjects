using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.OracleManager;
using AH.DUtility;
using AH.ACCMS.MODEL;
//using AH.HR.MODEL;

namespace AH.ACCMS.DAL
{
    public class RevenueSetupDAL
    {
        //private string connstring = Utility.GetConnectionString(Utility.Module.IPDMIS);
        private string connstring = Utility.GetConnectionString(Utility.Module.ACCMS);
        string packageName = string.Empty;
        #region "Collection"
        public List<RevenueHeadGroup> GetRevHdGrps()
        {
            string packageName = "PKG_REVENUE.GET_REV_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetRevHdGrp(packageName, parameterList);
        }
        private List<RevenueHeadGroup> GetRevHdGrp(string packageName, OracleParameter[] parameterList)
        {
            List<RevenueHeadGroup> rvhdgr = new List<RevenueHeadGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RevenueHeadGroup rvobj = new RevenueHeadGroup();
                rvobj.ID = (string)rdr[0];
                rvobj.Title = (string)rdr[1];
                rvobj.TitleBeng = (string)rdr[2];
                rvobj.Priority = short.Parse(rdr[3].ToString());
                rvobj.Remarks = !rdr.IsDBNull(4) ? (string)rdr[4] : "";
                rvhdgr.Add(rvobj);
            }
            rdr.Close();
            return rvhdgr;
        }
        public List<RevenueHead> GetRevenueHead()
        {
            string packageName = "PKG_REVENUE.GET_REV_HD";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetRevenue(packageName, parameterList);
        }
        public List<RevenueHead> GetRevenueHeads(string headgr)
        {
            string packageName = "PKG_REVENUE.GET_REV_HD";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("HeadGroup",OracleDbType.Varchar2,3,headgr,ParameterDirection.Input)
            };
            return GetRevenue(packageName, parameterList);
        }
        private List<RevenueHead> GetRevenue(string packageName, OracleParameter[] parameterList)
        {
            List<RevenueHead> rvhd = new List<RevenueHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RevenueHead rviobj = new RevenueHead();
                rviobj.ID = (string)rdr[0];
                rviobj.Title = (string)rdr[1];
                rviobj.TitleBeng = (string)rdr[2];
                rviobj.Priority = short.Parse(rdr[3].ToString());
                rviobj.Remarks = !rdr.IsDBNull(4) ? (string)rdr[4] : "";
                rviobj.RevenueAccountsCode = !rdr.IsDBNull(5) ? (string)rdr[5] : "";
                rviobj.RevenueHeadString  = !rdr.IsDBNull(6) ? (string)rdr[6] : "";

                RevenueHeadGroup rvg = new RevenueHeadGroup();
                rvg.ID = (string)rdr[5];
                rviobj.RevenueHeadGroup = rvg;

                rvhd.Add(rviobj);
            }
            rdr.Close();
            return rvhd;
        }
        public List<DepartmentRevenueHead> GetHeadAssign()
        {
            string packageName = "PKG_REVENUE.GET_REV_HD_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetHdAssign(packageName, parameterList);
        }
        public List<DepartmentRevenueHead> GetHeadAssign(string departmentID)
        {
            string packageName = "PKG_REVENUE.GET_REV_HD_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("RefCursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("dept",OracleDbType.Varchar2,5,departmentID,ParameterDirection.Input)
            };
            return GetHdAssign(packageName, parameterList);
        }
        private List<DepartmentRevenueHead> GetHdAssign(string packageName, OracleParameter[] parameterList)
        {
            List<DepartmentRevenueHead> hdas = new List<DepartmentRevenueHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                DepartmentRevenueHead hds = new DepartmentRevenueHead();
                Department dept = new Department();
                dept.DepartmentID = (string)rdr[0];
                dept.DepartmentTitle = (string)rdr[1];
                hds.Department = dept;
                RevenueHeadGroup hdg = new RevenueHeadGroup();
                hdg.ID = (string)rdr[2];
                hdg.Title = (string)rdr[3];
                hds.RevenueHeadGroup = hdg;

                RevenueHead hvg = new RevenueHead();
                hvg.ID = (string)rdr[4];
                hvg.Title = (string)rdr[5];
                hds.RevenueHead = hvg;
                hdas.Add(hds);
            }
            rdr.Close();
            return hdas;
        }
        public List<RevenueHeadGroup> GetRevenueGroup()
        {
            string packageName = "PKG_REVENUE.get_group_id";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                };
            return GetRevenueGroup(packageName, parameterList);
        }
        private List<RevenueHeadGroup> GetRevenueGroup(string packageName, OracleParameter[] parameterList)
        {
            List<RevenueHeadGroup> rLedger = new List<RevenueHeadGroup>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RevenueHeadGroup objLedger = new RevenueHeadGroup();
                if (rdr["hd_grp_id"].ToString() != "")
                {
                    objLedger.ID = rdr["hd_grp_id"].ToString();
                }
                else
                {
                    objLedger.ID = "";
                }
                if (rdr["hd_grp_title"].ToString() != "")
                {
                    objLedger.Title= rdr["hd_grp_title"].ToString();
                }
                else
                {
                    objLedger.Title = "";
                }

                rLedger.Add(objLedger);
            }
            rdr.Close();
            return rLedger;
        }
        #endregion
        #region "Save"
        public int VerifyRevHdGr(string groupid)
        {
            packageName = "PKG_REVENUE.VERIFY_REVHD_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("GroupId",OracleDbType.Varchar2,3,groupid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        public short SaveRevenueHeadGr(RevenueHeadGroup rvgr)
        {
            packageName = "PKG_REVENUE.INSERT_REV_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("RevHdGrName",OracleDbType.Varchar2,70,rvgr.Title,ParameterDirection.Input),
                new OracleParameter("RevHdGrNameBeng",OracleDbType.Varchar2,70,rvgr.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int16,5,rvgr.Priority,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,rvgr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,rvgr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,rvgr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,rvgr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,rvgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public int VerifyRevHead(string headid)
        {
            packageName = "PKG_REVENUE.VERIFY_REVHD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("HeadID",OracleDbType.Varchar2,3,headid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int found = (int)(OracleDecimal)prm.Value;
            return found;
        }
        public short SaveRevenueHead(RevenueHead rvshd)
        {
            packageName = "PKG_REVENUE.INSERT_REV_HD";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("HeadGroupID",OracleDbType.Varchar2,3,rvshd.RevenueHeadString,ParameterDirection.Input),
                new OracleParameter("HeadName",OracleDbType.Varchar2,70,rvshd.Title,ParameterDirection.Input),
                new OracleParameter("HeadNameBeng",OracleDbType.Varchar2,70,rvshd.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int16,5,rvshd.Priority,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,rvshd.Remarks,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,50,rvshd.RevenueAccountsCode,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,rvshd.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,rvshd.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,rvshd.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,rvshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateRevHead(RevenueHead urvshd)
        {
            packageName = "PKG_REVENUE.UPDATE_REV_HD";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("HeadID",OracleDbType.Varchar2,3,urvshd.ID,ParameterDirection.Input),
                new OracleParameter("HeadName",OracleDbType.Varchar2,70,urvshd.Title,ParameterDirection.Input),
                new OracleParameter("HeadNameBeng",OracleDbType.Varchar2,70,urvshd.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int16,5,urvshd.Priority,ParameterDirection.Input),
                new OracleParameter("p_acc_code",OracleDbType.Varchar2,50,urvshd.RevenueAccountsCode,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,urvshd.Remarks,ParameterDirection.Input),
                new OracleParameter("HeadGroupID",OracleDbType.Varchar2,3,urvshd.RevenueHeadString,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,urvshd.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,urvshd.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,urvshd.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,urvshd.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short SaveHeadAssign(DepartmentRevenueHead hdas)
        {
            packageName = "PKG_REVENUE.INSERT_REV_HD_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,5,hdas.Department.DepartmentID,ParameterDirection.Input), 
                new OracleParameter("RevenueHeadGroup",OracleDbType.Varchar2,3,hdas.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("RevenueHead",OracleDbType.Varchar2,3,hdas.RevenueHead.ID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,hdas.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,hdas.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,hdas.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,hdas.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateHdAss(DepartmentRevenueHead uhdas)
        {
            packageName = "PKG_REVENUE.UPDATE_REV_HD_ASSIGN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("Department",OracleDbType.Varchar2,5,uhdas.Department.DepartmentID,ParameterDirection.Input), 
                new OracleParameter("RevenueHeadGroup",OracleDbType.Varchar2,3,uhdas.RevenueHeadGroup.ID,ParameterDirection.Input),
                new OracleParameter("RevenueHead",OracleDbType.Varchar2,3,uhdas.RevenueHead.ID,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,uhdas.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,uhdas.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,uhdas.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,uhdas.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        public short UpdateRevHdGr(RevenueHeadGroup urvgr)
        {
            packageName = "PKG_REVENUE.UPDATE_REV_HD_GRP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("RevHdGrID",OracleDbType.Varchar2,3,urvgr.ID,ParameterDirection.Input),
                new OracleParameter("RevHdGrName",OracleDbType.Varchar2,70,urvgr.Title,ParameterDirection.Input),
                new OracleParameter("RevHdGrNameBeng",OracleDbType.Varchar2,70,urvgr.TitleBeng,ParameterDirection.Input),
                new OracleParameter("Priority",OracleDbType.Int16,5,urvgr.Priority,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,urvgr.Remarks,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,urvgr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,urvgr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,urvgr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,urvgr.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion
    }
}
