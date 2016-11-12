using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.INVMS.MODEL;
using AH.PRMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class IRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SaveIssueRequisition
        public short SaveIssueRequisition(IssueRequisition oissue)
        {
            string packageName = "PKG_ISSUE_REQUISITION.SAVE_IR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,oissue.Stock.StoreLocaton.ID,ParameterDirection.Input),
                new OracleParameter("IR Type",OracleDbType.Varchar2,1,oissue.IRType,ParameterDirection.Input),
                new OracleParameter("IR Date",OracleDbType.Date,oissue.IRDate,ParameterDirection.Input),
                new OracleParameter("ConsumptionHead",OracleDbType.Varchar2,10,oissue.ConsumptionHeadID,ParameterDirection.Input),
                new OracleParameter("HCN",OracleDbType.Varchar2,30,oissue.HCN,ParameterDirection.Input),
                new OracleParameter("StaffID",OracleDbType.Varchar2,30,oissue.Staff,ParameterDirection.Input),
                new OracleParameter("Department",OracleDbType.Varchar2,10,oissue.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("DepartmentUnit",OracleDbType.Varchar2,10,oissue.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("EmployeeID",OracleDbType.Varchar2,30,oissue.EmpID,ParameterDirection.Input),
                new OracleParameter("Ward",OracleDbType.Varchar2,5,oissue.Bed.Ward.WardID,ParameterDirection.Input),
                new OracleParameter("Room",OracleDbType.Varchar2,5,oissue.Bed.Room.RoomID,ParameterDirection.Input),
                new OracleParameter("BedType",OracleDbType.Varchar2,2,oissue.Bed.BedType.ID,ParameterDirection.Input),
                new OracleParameter("BedNo",OracleDbType.Varchar2,10,oissue.Bed.BedNo,ParameterDirection.Input),
                new OracleParameter("RegID",OracleDbType.Varchar2,30,oissue.RegID,ParameterDirection.Input),
                new OracleParameter("ConsumerID",OracleDbType.Varchar2,15,oissue.ConsumptionID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,oissue.TransactionType,ParameterDirection.Input),
                new OracleParameter("RequisitionBy",OracleDbType.Varchar2,30,oissue.RequisitionBy,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,oissue.Remarks,ParameterDirection.Input),
                new OracleParameter("IRDetails",OracleDbType.Varchar2,5000,oissue.IRDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oissue.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oissue.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oissue.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oissue.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetIRNumbers
        public List<IssueRequisition> GetIRNumbers()
        {
            string packageName = "PKG_ISSUE_REQUISITION.GET_IRNUMBERS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
            };
            List<IssueRequisition> oirdetails = new List<IssueRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                IssueRequisition ir = new IssueRequisition();
                ir.ID = (string)rdr["IR_ID"];
                ir.IRDate = DateTime.Parse(rdr["dt"].ToString());
                oirdetails.Add(ir);
            }
            rdr.Close();
            return oirdetails;
        }
        #endregion

        #region GetIRDetails
        public List<IssueRequisition> GetIRDetails(string irid)
        {
            string packageName = "PKG_ISSUE_REQUISITION.GET_IRDETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("IRID",OracleDbType.Varchar2,15,irid,ParameterDirection.Input)
            };
            List<IssueRequisition> oirdetails = new List<IssueRequisition>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                IssueRequisition ir = new IssueRequisition();
                ir.ID = (string)rdr["IRID"];
                ir.IRDate = DateTime.Parse(rdr["IRDATE"].ToString());
                ir.RequisitionQty = Single.Parse(rdr["REQUISITIONQTY"].ToString());

                Stock ostock = new Stock();
                ostock.StockQty = Single.Parse(rdr["STOCK"].ToString());

                StoreLocation ostore = new StoreLocation();
                ostore.ID = (string)rdr["STOREID"];
                ostore.Name = (string)rdr["STORENAME"];
                ostock.StoreLocaton = ostore;
                ir.Stock = ostock;

                ItemIssue oitm = new ItemIssue();
                oitm.IssueQty = Single.Parse(rdr["ISSUEQTY"].ToString());
                ir.ItemIssue = oitm;
                
                ItemOrder itm = new ItemOrder();
                itm.Rate = Single.Parse(rdr["RATE"].ToString());
                itm.VAT = Single.Parse(rdr["VAT"].ToString());
                itm.Discount = Single.Parse(rdr["DISCOUNT"].ToString());
               

                ItemMaster item = new ItemMaster();
                item.ID = (string)rdr["ItemID"];
                item.Name = (string)rdr["ItemName"];

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
                ir.ItemOrder = itm;

                oirdetails.Add(ir);
            }
            rdr.Close();
            return oirdetails;
        }
        #endregion
    }
}
