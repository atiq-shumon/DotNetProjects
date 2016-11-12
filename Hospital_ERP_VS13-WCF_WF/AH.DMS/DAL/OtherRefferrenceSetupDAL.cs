using System;
using System.Collections.Generic;
using System.Data;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.OracleManager;
using Oracle.DataAccess.Client;
using AH.DTMS.MODEL;
using Oracle.DataAccess.Types;

namespace AH.DMS.DAL
{
    public class OtherRefferrenceSetupDAL
    {
        private string connstring = Utility.GetConnectionString(Utility.Module.DMSMIS);
        private string packageName;

        #region SaveReffdOrg
        public short SaveReffdOrg(RefdOrg oReff)
        {
            packageName = "PKG_REFF_SETUP.INSERT_REFFD_ORG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_org_id",OracleDbType.Varchar2,4,oReff.OrgID,ParameterDirection.Input),
            new OracleParameter("p_org_title",OracleDbType.Varchar2,70,oReff.OrgTitle,ParameterDirection.Input),
            new OracleParameter("p_org_title_beng",OracleDbType.Varchar2,70,oReff.OrgTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_address",OracleDbType.Varchar2,200,oReff.Address,ParameterDirection.Input),
            new OracleParameter("p_phone",OracleDbType.Varchar2,100,oReff.Phone,ParameterDirection.Input),
            new OracleParameter("p_email",OracleDbType.Varchar2,100,oReff.Email,ParameterDirection.Input),
            new OracleParameter("p_web",OracleDbType.Varchar2,70,oReff.Web,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oReff.Remarks,ParameterDirection.Input),
            new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oReff.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oReff.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oReff.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oReff.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateReffdOrg
        public short UpdateReffdOrg(RefdOrg oReff)
        {
            packageName = "PKG_REFF_SETUP.UPDATE_REFFD_ORG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_org_id",OracleDbType.Varchar2,4,oReff.OrgID,ParameterDirection.Input),
            new OracleParameter("p_org_title",OracleDbType.Varchar2,70,oReff.OrgTitle,ParameterDirection.Input),
            new OracleParameter("p_org_title_beng",OracleDbType.Varchar2,70,oReff.OrgTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_address",OracleDbType.Varchar2,200,oReff.Address,ParameterDirection.Input),
            new OracleParameter("p_phone",OracleDbType.Varchar2,100,oReff.Phone,ParameterDirection.Input),
            new OracleParameter("p_email",OracleDbType.Varchar2,100,oReff.Email,ParameterDirection.Input),
            new OracleParameter("p_web",OracleDbType.Varchar2,70,oReff.Web,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oReff.Remarks,ParameterDirection.Input),
            new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oReff.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oReff.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oReff.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oReff.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetReffdOrg
        public List<RefdOrg> GetReffdOrg()
        {
            string packageName = "PKG_REFF_SETUP.GET_REFFD_ORG_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            return GetReffdOrgDetails(packageName, parameterList);
        }
        private List<RefdOrg> GetReffdOrgDetails(string packageName, OracleParameter[] parameterList)
        {
            List<RefdOrg> oRefds = new List<RefdOrg>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RefdOrg oRefd = new RefdOrg();
                oRefd.OrgID = (string)rdr["ORG_ID"].ToString();
                oRefd.OrgTitle = (string)rdr["ORG_TITLE"].ToString();
                oRefd.OrgTitleBeng = (string)rdr["ORG_TITLE_BENG"].ToString();
                oRefd.Address = (string)rdr["ADDRESS"].ToString();
                oRefd.Phone = rdr["PHONE"] != DBNull.Value ? (string)rdr["PHONE"].ToString() : "";
                oRefd.Email = rdr["EMAIL"] != DBNull.Value ? (string)rdr["EMAIL"].ToString() : "";
                oRefd.Web= rdr["WEB"] != DBNull.Value ? (string)rdr["WEB"].ToString() : "";
                oRefd.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["remarks"] : "";
                oRefds.Add(oRefd);
            }
            rdr.Close();
            return oRefds;

        }
        #endregion

        #region SaveReffdDoc
        public short SaveReffdDoc(RefdDoc oReff)
        {
            packageName = "PKG_REFF_SETUP.INSERT_REFFD_DOC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_org_id",OracleDbType.Varchar2,4,oReff.RefdOrg.OrgID,ParameterDirection.Input),
            new OracleParameter("p_doc_id",OracleDbType.Varchar2,6,oReff.DocID,ParameterDirection.Input),
            new OracleParameter("p_doc_title",OracleDbType.Varchar2,70,oReff.DocTitle,ParameterDirection.Input),
            new OracleParameter("p_doc_title_beng",OracleDbType.Varchar2,70,oReff.DocTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_degree_line",OracleDbType.Varchar2,100,oReff.DegreeLine,ParameterDirection.Input),
            new OracleParameter("p_address",OracleDbType.Varchar2,200,oReff.Address,ParameterDirection.Input),
            new OracleParameter("p_phone",OracleDbType.Varchar2,100,oReff.Phone,ParameterDirection.Input),
            new OracleParameter("p_email",OracleDbType.Varchar2,100,oReff.Email,ParameterDirection.Input),
            new OracleParameter("p_web",OracleDbType.Varchar2,70,oReff.Web,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oReff.Remarks,ParameterDirection.Input),
            new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oReff.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oReff.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oReff.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oReff.EntryParameter.MachineID,ParameterDirection.Input)
        };
            short i = DALHelper.Insert(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region UpdateReffdDoc
        public short UpdateReffdDoc(RefdDoc oReff)
        {
            packageName = "PKG_REFF_SETUP.UPDATE_REFFD_DOC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
            new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
            new OracleParameter("p_org_id",OracleDbType.Varchar2,4,oReff.RefdOrg.OrgID,ParameterDirection.Input),
            new OracleParameter("p_doc_id",OracleDbType.Varchar2,6,oReff.DocID,ParameterDirection.Input),
            new OracleParameter("p_doc_title",OracleDbType.Varchar2,70,oReff.DocTitle,ParameterDirection.Input),
            new OracleParameter("p_doc_title_beng",OracleDbType.Varchar2,70,oReff.DocTitleBeng,ParameterDirection.Input),
            new OracleParameter("p_degree_line",OracleDbType.Varchar2,100,oReff.DegreeLine,ParameterDirection.Input),
            new OracleParameter("p_address",OracleDbType.Varchar2,200,oReff.Address,ParameterDirection.Input),
            new OracleParameter("p_phone",OracleDbType.Varchar2,100,oReff.Phone,ParameterDirection.Input),
            new OracleParameter("p_email",OracleDbType.Varchar2,100,oReff.Email,ParameterDirection.Input),
            new OracleParameter("p_web",OracleDbType.Varchar2,70,oReff.Web,ParameterDirection.Input),
            new OracleParameter("p_remarks",OracleDbType.Varchar2,300,oReff.Remarks,ParameterDirection.Input),
            new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,oReff.EntryParameter.EntryBy,ParameterDirection.Input),
            new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,oReff.EntryParameter.CompanyID,ParameterDirection.Input),
            new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,oReff.EntryParameter.LocationID,ParameterDirection.Input),
            new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,oReff.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Update(connstring, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetReffdDoc
        public List<RefdDoc> GetReffdDoc(string OrgID)
        {
            string packageName = "PKG_REFF_SETUP.GET_REFFD_DOC_SETUP";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("p_test_cursor",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_org_id",OracleDbType.Varchar2,4,OrgID,ParameterDirection.Input)
            };
            return GetReffdDocDetails(packageName, parameterList);
        }
        private List<RefdDoc> GetReffdDocDetails(string packageName, OracleParameter[] parameterList)
        {
            List<RefdDoc> oRefds = new List<RefdDoc>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connstring, packageName, parameterList);
            while (rdr.Read())
            {
                RefdDoc oRefd = new RefdDoc();

                RefdOrg oRefo = new RefdOrg();
                oRefo.OrgID = (string)rdr["ORG_ID"].ToString();
                oRefd.RefdOrg = oRefo;

                oRefd.DocID = (string)rdr["DOC_ID"].ToString();
                oRefd.DocTitle = (string)rdr["DOC_TITLE"].ToString();
                oRefd.DocTitleBeng = (string)rdr["DOC_TITLE_BENG"].ToString();
                oRefd.DegreeLine = (string)rdr["DEGREE_LINE"].ToString();
                oRefd.Address = (string)rdr["ADDRESS"].ToString();
                oRefd.Phone = rdr["PHONE"] != DBNull.Value ? (string)rdr["PHONE"].ToString() : "";
                oRefd.Email = rdr["EMAIL"] != DBNull.Value ? (string)rdr["EMAIL"].ToString() : "";
                oRefd.Web = rdr["WEB"] != DBNull.Value ? (string)rdr["WEB"].ToString() : "";
                oRefd.Remarks = rdr["REMARKS"] != DBNull.Value ? (string)rdr["remarks"] : "";
                oRefds.Add(oRefd);
            }
            rdr.Close();
            return oRefds;

        }
        #endregion

    }
}
