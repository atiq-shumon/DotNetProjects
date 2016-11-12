using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DUtility;
using AH.HR.MODEL;
using AH.PRMS.MODEL;
using AH.PatReg.MODEL;
using AH.DTMS.MODEL;
using AH.OracleManager;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using AH.Shared.MODEL;

namespace AH.DTMS.DAL
{
    public class EmergencySetupDAL
    {
        public string connString = Utility.GetConnectionString(Utility.Module.DMSMIS);
        string packageName = string.Empty;

        #region SaveEmrCollHead
        public short SaveEmrCollHead(EmrCollHead oEmrCollHead)
        {
            packageName = "PKG_EMERGENCY_SETUP.INSERT_EMR_COLL_HEAD";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                  new OracleParameter("p_dept_grp",OracleDbType.Varchar2,70,oEmrCollHead.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                  new OracleParameter("p_dept",OracleDbType.Varchar2,70,oEmrCollHead.Department.DepartmentID,ParameterDirection.Input),
                  new OracleParameter("p_unit",OracleDbType.Varchar2,5,oEmrCollHead.DepartmentUnit.UnitId,ParameterDirection.Input),
                  new OracleParameter("p_head_grp",OracleDbType.Varchar2,300,oEmrCollHead.HeadGroupID,ParameterDirection.Input),
                  new OracleParameter("p_head_id",OracleDbType.Varchar2,300,oEmrCollHead.HeadID,ParameterDirection.Input),
                  new OracleParameter("p_head_title",OracleDbType.Varchar2,300,oEmrCollHead.HeadTitle,ParameterDirection.Input),
                  new OracleParameter("p_head_title_beng",OracleDbType.Varchar2,300,oEmrCollHead.HeadTitleBeng,ParameterDirection.Input),
                  new OracleParameter("p_fee",OracleDbType.Varchar2,300,oEmrCollHead.Fee,ParameterDirection.Input),
                  new OracleParameter("p_set_as_default",OracleDbType.Varchar2,300,oEmrCollHead.SetAsDefault,ParameterDirection.Input),
                  new OracleParameter("p_is_selectable",OracleDbType.Varchar2,300,oEmrCollHead.IsSelectable,ParameterDirection.Input),
                  new OracleParameter("p_pos_serial",OracleDbType.Varchar2,300,oEmrCollHead.PosSerial,ParameterDirection.Input),
                  new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmrCollHead.EntryParameter.EntryBy,ParameterDirection.Input),
                  new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmrCollHead.EntryParameter.CompanyID,ParameterDirection.Input),
                  new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmrCollHead.EntryParameter.LocationID,ParameterDirection.Input),
                  new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmrCollHead.EntryParameter.MachineID,ParameterDirection.Input)
          };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateEmrCollHead
        public short UpdateEmrCollHead(EmrCollHead oEmrCollHead)
        {
            packageName = "PKG_EMERGENCY_SETUP.UPDATE_EMR_COLL_HEAD";
            OracleParameter[] parameterList = new OracleParameter[] { 
                  new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                  new OracleParameter("p_dept_grp",OracleDbType.Varchar2,70,oEmrCollHead.DepartmentGroup.DepartmentGroupID,ParameterDirection.Input),
                  new OracleParameter("p_dept",OracleDbType.Varchar2,70,oEmrCollHead.Department.DepartmentID,ParameterDirection.Input),
                  new OracleParameter("p_unit",OracleDbType.Varchar2,5,oEmrCollHead.DepartmentUnit.UnitId,ParameterDirection.Input),
                  new OracleParameter("p_head_grp",OracleDbType.Varchar2,300,oEmrCollHead.HeadGroupID,ParameterDirection.Input),
                  new OracleParameter("p_head_id",OracleDbType.Varchar2,300,oEmrCollHead.HeadID,ParameterDirection.Input),
                  new OracleParameter("p_head_title",OracleDbType.Varchar2,300,oEmrCollHead.HeadTitle,ParameterDirection.Input),
                  new OracleParameter("p_head_title_beng",OracleDbType.Varchar2,300,oEmrCollHead.HeadTitleBeng,ParameterDirection.Input),
                  new OracleParameter("p_fee",OracleDbType.Varchar2,300,oEmrCollHead.Fee,ParameterDirection.Input),
                  new OracleParameter("p_set_as_default",OracleDbType.Varchar2,300,oEmrCollHead.SetAsDefault,ParameterDirection.Input),
                  new OracleParameter("p_is_selectable",OracleDbType.Varchar2,300,oEmrCollHead.IsSelectable,ParameterDirection.Input),
                  new OracleParameter("p_pos_serial",OracleDbType.Varchar2,300,oEmrCollHead.PosSerial,ParameterDirection.Input),
                  new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oEmrCollHead.EntryParameter.EntryBy,ParameterDirection.Input),
                  new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oEmrCollHead.EntryParameter.CompanyID,ParameterDirection.Input),
                  new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oEmrCollHead.EntryParameter.LocationID,ParameterDirection.Input),
                  new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oEmrCollHead.EntryParameter.MachineID,ParameterDirection.Input)
          };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetEmrCollHead
        public List<EmrCollHead> GetEmrCollHead(string Mode, string DeptGroup, string Dept, string Unit)
        {
            string packagename = "PKG_EMERGENCY_SETUP.GET_EMR_COLL_HEAD";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_mode",OracleDbType.Varchar2,4,Mode,ParameterDirection.Input),
                new OracleParameter("p_dept_grp",OracleDbType.Varchar2,4,DeptGroup,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,4,Dept,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,4,Unit,ParameterDirection.Input)
            };
            return GetEmrCollHeadDetails(packagename, parameterList);
        }
        private List<EmrCollHead> GetEmrCollHeadDetails(string packagename, OracleParameter[] parameterList)
        {
            List<EmrCollHead> oEmrCollHeads = new List<EmrCollHead>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packagename, parameterList);
            while (rdr.Read())
            {
                EmrCollHead oEmrCollHead = new EmrCollHead();
                DepartmentGroup oDeptGroup = new DepartmentGroup();
                Department oDept = new Department();
                DepartmentUnit oUnit = new DepartmentUnit();

                oDeptGroup.DepartmentGroupID = (string)rdr["DEPT_GRP_ID"].ToString();
                oDeptGroup.DepartmentGroupTitle = (string)rdr["DEPT_GROUP_TITLE"].ToString();
                oDeptGroup.DepartmentTypeID = rdr["Type_id"].ToString();
                oEmrCollHead.DepartmentGroup = oDeptGroup;

                oDept.DepartmentID = (string)rdr["DEPT_ID"].ToString();
                oDept.DepartmentTitle = (string)rdr["DEPT_TITLE"].ToString();
                oEmrCollHead.Department = oDept;

                oUnit.UnitId = (string)rdr["UNIT_ID"].ToString();
                oUnit.UnitTitle = (string)rdr["UNIT_TITLE"].ToString();
                oEmrCollHead.DepartmentUnit = oUnit;

                oEmrCollHead.HeadGroupID = (string)rdr["HEAD_GRP"].ToString();
                oEmrCollHead.HeadID = (string)rdr["HEAD_ID"].ToString();
                oEmrCollHead.HeadTitle = (string)rdr["HEAD_TITLE"].ToString();
                oEmrCollHead.HeadTitleBeng = (string)rdr["HEAD_TITLE_BENG"].ToString();
                oEmrCollHead.Fee = Convert.ToDouble(rdr["FEE"].ToString());
                oEmrCollHead.SetAsDefault = (string)rdr["SET_AS_DEFULT"].ToString();
                oEmrCollHead.IsSelectable = (string)rdr["IS_SELECTABLE"].ToString();
                oEmrCollHead.PosSerial = (string)rdr["POS_SERIAL"].ToString();
               
                oEmrCollHeads.Add(oEmrCollHead);
            }
            rdr.Close();
            return oEmrCollHeads;
        }
        #endregion


    }
}
