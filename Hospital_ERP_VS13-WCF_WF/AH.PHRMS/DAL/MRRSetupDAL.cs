using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.DUtility;
using AH.INVMS.MODEL;
using AH.PHRMS.MODEL;
using AH.DRUGS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace AH.PHRMS.DAL
{
    public class MRRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.PHRMIS);

        #region SaveMRR
        public string SaveMaterialReceive(AH.PHRMS.MODEL.MaterialReceive mr)
        {
            string packageName = "PKG_MRR.SAVE_MRR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,mr.MRRID,ParameterDirection.Output),
                new OracleParameter("Type",OracleDbType.Int32,5,mr.OpeningFlag,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,mr.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("POID",OracleDbType.Varchar2,15,mr.PurchaseOrder.ID,ParameterDirection.Input),
                new OracleParameter("PRID",OracleDbType.Varchar2,15,mr.PurchaseOrder.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,30,mr.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,4,mr.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("SupplierID",OracleDbType.Varchar2,6,mr.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("TransacType",OracleDbType.Varchar2,15,mr.TransactionType,ParameterDirection.Input),
                new OracleParameter("MRRDate",OracleDbType.Date,mr.MRRDate,ParameterDirection.Input),
                new OracleParameter("MRRType",OracleDbType.Varchar2,1,mr.MRRType,ParameterDirection.Input),
                //new OracleParameter("MRRQuantity",OracleDbType.Single,mr.MRRQuantity,ParameterDirection.Input),
                new OracleParameter("ChallanNo",OracleDbType.Varchar2,30,mr.ChallanNo,ParameterDirection.Input),
                new OracleParameter("ChallanDate",OracleDbType.Date,mr.ChallanDate,ParameterDirection.Input),
                new OracleParameter("VoucherNo",OracleDbType.Varchar2,10,mr.VoucherNo,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,mr.Remarks,ParameterDirection.Input),
                new OracleParameter("MRDetails",OracleDbType.Varchar2,32000,mr.MRRDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            //if ((OracleDecimal)prm.Value == 1)
            //    return 1;
            //else
            //    return 0;
            string regno = (string)(OracleString)prm.Value;
            return regno;

        }
        #endregion

        #region GetMRRNumber
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMRRNumber()
        {
            string packageName = "PKG_MRR.GET_MRR_NUMBER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };

        //private List<MaterialReceive>
            List<AH.PHRMS.MODEL.MaterialReceive> omatrec = new List<AH.PHRMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceive mat = new AH.PHRMS.MODEL.MaterialReceive();
                mat.MRRID = (string)rdr["MRRID"].ToString();

                omatrec.Add(mat);

            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region GetOpeningEntry
        public List<AH.PHRMS.MODEL.MaterialReceive> GetOpeningEntry(string MrrID)
        {
            string packageName = "PKG_MRR.GET_OPENING_ENTRY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,MrrID,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.MaterialReceive> omatrec = new List<AH.PHRMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceive mat = new AH.PHRMS.MODEL.MaterialReceive();
                mat.MRRQuantity = Single.Parse(rdr["Quantity"].ToString());
                mat.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                mat.BatchNo = (string)rdr["BATCHNO"];


                ItemsOrder itm = new ItemsOrder();
                itm.URate = Single.Parse(rdr["Rate"].ToString());
                itm.SlRate = Single.Parse(rdr["SALESRATE"].ToString());
                itm.VAT = Single.Parse(rdr["Vat"].ToString());
                itm.Discount = Single.Parse(rdr["Discount"].ToString());

                DrugMaster mas = new DrugMaster();
                mas.ID = (string)rdr["ProductID"].ToString();
                mas.Name = (string)rdr["ProductName"].ToString();
                itm.DrugMaster = mas;

                DrugPackType pack = new DrugPackType();
                pack.ID = (string)rdr["PackageType"].ToString();
                mas.DrugPackType = pack;

                DrugUnit unit = new DrugUnit();
                unit.ID = (string)rdr["UnitID"].ToString();
                mas.DrugUnit = unit;

                DrugGroup grp = new DrugGroup();
                grp.ID = (string)rdr["GroupID"].ToString();
                grp.Name = (string)rdr["GroupName"].ToString();
                mas.DrugGroup = grp;

                DrugCompany comp = new DrugCompany();
                comp.ID = (string)rdr["CompanyID"].ToString();
                comp.Name = (string)rdr["CompanyName"].ToString();
                mas.DrugCompany = comp;

                mat.ItemsOrder = itm;

                omatrec.Add(mat);

            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region VerifyOpeningDrugID
        public string VerifyOpeningDrugID(string drugid, string pharmacyid)
        {
            string packageName = "PKG_MRR.VERIFY_OPENING_DRUGID";
            OracleParameter[] parameterList = new OracleParameter[]  {
                new OracleParameter("IsFound",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,pharmacyid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string ponum = (string)(OracleString)prm.Value;
            return ponum;
        }
        #endregion

        #region UpdateOpeningEntry
        public short UpdateOpeningEntry(AH.PHRMS.MODEL.MaterialReceive mr)
        {
            string packageName = "PKG_MRR.UPDATE_OPENING_ENTRY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,mr.MRRID,ParameterDirection.Input),
                new OracleParameter("Quantity",OracleDbType.Single,mr.MRRQuantity,ParameterDirection.Input),
                new OracleParameter("Rate",OracleDbType.Single,mr.ItemsOrder.URate,ParameterDirection.Input),
                new OracleParameter("VAT",OracleDbType.Single,mr.ItemsOrder.VAT,ParameterDirection.Input),
                new OracleParameter("Discount",OracleDbType.Single,mr.ItemsOrder.Discount,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,mr.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,mr.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,mr.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,mr.EntryParameter.MachineID,ParameterDirection.Input)

            };
            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;

        }
        #endregion

        #region MrrDetailsReport
        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetMrrReport(string startDate, string endDate)
        {
            string packageName = "PKG_MRR.GET_MRR_DETAILS";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.MaterialReceiveRO> omatrec = new List<AH.PHRMS.MODEL.MaterialReceiveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceiveRO ro = new AH.PHRMS.MODEL.MaterialReceiveRO();
                ro.MRRID = (string)rdr["MRRID"].ToString();
                ro.ProductID = (string)rdr["ProductID"].ToString();
                ro.ProductName = (string)rdr["ProductName"].ToString();
                ro.PackageType = (string)rdr["PackageType"].ToString();
                ro.UnitID = (string)rdr["UnitID"].ToString();
                ro.GroupID = (string)rdr["GroupID"].ToString();
                ro.GroupName = (string)rdr["GroupName"].ToString();
                ro.CompanyID = (string)rdr["CompanyID"].ToString();
                ro.CompanyName = (string)rdr["CompanyName"].ToString();
                ro.Rate = Single.Parse(rdr["Rate"].ToString());
                ro.Vat = Single.Parse(rdr["Vat"].ToString());
                ro.Discount = Single.Parse(rdr["Discount"].ToString());
                ro.Quantity = Single.Parse(rdr["Quantity"].ToString());
                ro.TransactionType = (string)rdr["TransactionType"].ToString();
                ro.Day = DateTime.Parse(rdr["Day"].ToString());
                omatrec.Add(ro);
            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region OpeningReport

        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetOpeningReport()
        {
            string packageName = "PKG_MRR.GET_OPENING_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
               
            };
            List<AH.PHRMS.MODEL.MaterialReceiveRO> omatrec = new List<AH.PHRMS.MODEL.MaterialReceiveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceiveRO ro = new AH.PHRMS.MODEL.MaterialReceiveRO();
                ro.MRRID = (string)rdr["MRRID"].ToString();
                ro.ProductID = (string)rdr["ProductID"].ToString();
                ro.ProductName = (string)rdr["ProductName"].ToString();
                ro.PackageType = (string)rdr["PackageType"].ToString();
                ro.UnitID = (string)rdr["UnitID"].ToString();
                ro.GroupID = (string)rdr["GroupID"].ToString();
                ro.GroupName = (string)rdr["GroupName"].ToString();
                ro.CompanyID = (string)rdr["CompanyID"].ToString();
                ro.CompanyName = (string)rdr["CompanyName"].ToString();
                ro.Rate = Single.Parse(rdr["Rate"].ToString());
                ro.Vat = Single.Parse(rdr["Vat"].ToString());
                ro.Discount = Single.Parse(rdr["Discount"].ToString());
                ro.Quantity = Single.Parse(rdr["Quantity"].ToString());
                ro.TransactionType = (string)rdr["TransactionType"].ToString();
                ro.Day = DateTime.Parse(rdr["Day"].ToString());
                ro.MRRDATE = DateTime.Parse(rdr["MRRDATE"].ToString());
                ro.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                ro.BatchNo = (string)rdr["BatchNo"].ToString();
                omatrec.Add(ro);
            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region ExpireDateReport

        public List<AH.PHRMS.MODEL.MaterialReceiveRO> GetDrugsByExpireDate(string startDate, string endDate)
        {
            string packageName = "PKG_MRR.GET_DRUGS_ONEXPIREDATE";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
               
            };
            List<AH.PHRMS.MODEL.MaterialReceiveRO> omatrec = new List<AH.PHRMS.MODEL.MaterialReceiveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceiveRO ro = new AH.PHRMS.MODEL.MaterialReceiveRO();
                ro.MRRID = (string)rdr["MRRID"].ToString();
                ro.ProductID = (string)rdr["ProductID"].ToString();
                ro.ProductName = (string)rdr["ProductName"].ToString();
                ro.PackageType = (string)rdr["PackageType"].ToString();
                ro.UnitID = (string)rdr["UnitID"].ToString();
                ro.GroupID = (string)rdr["GroupID"].ToString();
                ro.GroupName = (string)rdr["GroupName"].ToString();
                ro.CompanyID = (string)rdr["CompanyID"].ToString();
                ro.CompanyName = (string)rdr["CompanyName"].ToString();
                ro.Rate = Single.Parse(rdr["Rate"].ToString());
                ro.Vat = Single.Parse(rdr["Vat"].ToString());
                ro.Discount = Single.Parse(rdr["Discount"].ToString());
                ro.Quantity = Single.Parse(rdr["Quantity"].ToString());
                ro.TransactionType = (string)rdr["TransactionType"].ToString();
                ro.Day = DateTime.Parse(rdr["Day"].ToString());
                ro.MRRDATE = DateTime.Parse(rdr["MRRDATE"].ToString());
                ro.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                ro.BatchNo = (string)rdr["BatchNo"].ToString();
                ro.SupplierName = (string)rdr["SupplierName"].ToString();
                omatrec.Add(ro);
            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region SavePurchaseReturn
        public string SavePurchaseReturn(AH.PHRMS.MODEL.PurchaseReturn oret)
        {
            string packageName = "PKG_PURCHASE_RETURN.SAVE_PURCHASE_RETURN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReturnID",OracleDbType.Varchar2,15,oret.ID,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,oret.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("POID",OracleDbType.Varchar2,15,oret.PurchaseOrder.ID,ParameterDirection.Input),
                new OracleParameter("MRID",OracleDbType.Varchar2,15,oret.MaterialReceive.MRRID,ParameterDirection.Input),
                new OracleParameter("ReturnDate",OracleDbType.Date,oret.ReturnDate,ParameterDirection.Input),
                new OracleParameter("ReturnType",OracleDbType.Varchar2,2,oret.ReturnType,ParameterDirection.Input),
                new OracleParameter("Supplier",OracleDbType.Varchar2,10,oret.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("ReturnCause",OracleDbType.Varchar2,5,oret.ReturnCause,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,100,oret.Remarks,ParameterDirection.Input),
                new OracleParameter("ReturnDetails",OracleDbType.Varchar2,32000,oret.ReturnDetails,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oret.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oret.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oret.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oret.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[1];
            //OracleParameter prm = parameterList[0];
            string regno = (string)(OracleString)prm.Value;
            return regno;

        }
        #endregion

        #region GetMrrDetailsForPurchaseReturn
        public List<AH.PHRMS.MODEL.MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            string packageName = "PKG_MRR.GET_MRR_DET_FOR_PURRET";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("MrrID",OracleDbType.Varchar2,15,mrrid,ParameterDirection.Input)
            };
            List<AH.PHRMS.MODEL.MaterialReceive> omatrec = new List<AH.PHRMS.MODEL.MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                AH.PHRMS.MODEL.MaterialReceive orec = new AH.PHRMS.MODEL.MaterialReceive();
                orec.MRRID = (string)rdr["MRRID"];
                orec.MRRQuantity = float.Parse(rdr["Quantity"].ToString());
                orec.ExpireDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                orec.BatchNo = (string)rdr["BATCHNO"];
                orec.CompareQty = float.Parse(rdr["COMPAREQTY"].ToString());


                //PurchaseRequisition oreq = new PurchaseRequisition();
                //oreq.ID = (string)rdr["PR_ID"];
                //orec.PurchaseRequisition = oreq;

                AH.PHRMS.MODEL.PurchaseOrder opurorder = new AH.PHRMS.MODEL.PurchaseOrder();
                opurorder.ID = (string)rdr["POID"];
                orec.PurchaseOrder = opurorder;


                Warehouse ostr = new Warehouse();
                ostr.TypeID = (string)rdr["PharmacyID"];
                ostr.TypeName = (string)rdr["PharmacyName"];
                orec.Warehouse = ostr;

                AH.PHRMS.MODEL.Supplier osupplier = new AH.PHRMS.MODEL.Supplier();
                osupplier.ID = (string)rdr["SUPPLIERID"];
                osupplier.Name = (string)rdr["SUPPLIERNAME"];
                orec.Supplier = osupplier;


                ItemsOrder oitem = new ItemsOrder();
                oitem.URate = float.Parse(rdr["Rate"].ToString());
                oitem.VAT = float.Parse(rdr["Vat"].ToString());
                oitem.Discount = float.Parse(rdr["Discount"].ToString());
                oitem.POQty = float.Parse(rdr["POQTY"].ToString());

                DrugMaster mas = new DrugMaster();
                mas.ID = (string)rdr["ProductID"];
                mas.Name = (string)rdr["ProductName"];
                oitem.DrugMaster = mas;

                DrugPackType otype = new DrugPackType();
                otype.ID = (string)rdr["PackageType"];
                //otype.Name = (string)rdr["TYPENAME"];
                mas.DrugPackType = otype;

                DrugUnit ounit = new DrugUnit();
                ounit.ID = (string)rdr["UnitID"];
                ounit.Name = (string)rdr["UNITNAME"];
                mas.DrugUnit = ounit;

                DrugGroup ogrp = new DrugGroup();
                ogrp.ID = (string)rdr["GroupID"];
                ogrp.Name = (string)rdr["GroupName"];
                mas.DrugGroup = ogrp;

                DrugCompany ocomp = new DrugCompany();
                ocomp.ID = (string)rdr["CompanyID"];
                ocomp.Name = (string)rdr["CompanyName"];
                mas.DrugCompany = ocomp;
               
                orec.ItemsOrder = oitem;

                omatrec.Add(orec);

            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region VarifyDrugForReturn
        public int VarifyDrugForReturn(string mrrid,string drugid)
        {
            string packageName = "PKG_PURCHASE_RETURN.VERIFY_DRUG_FORPURCHASERETURN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,mrrid,ParameterDirection.Input),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input),
                
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region VarifyDuplicateBatch
        public int VarifyDuplicateBatch(string phrid,string drugid,string batchno)
        {
            string packageName = "PKG_MRR.VARIFY_DUP_BATCH";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,2,phrid,ParameterDirection.Input),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input),
                new OracleParameter("BatchNo",OracleDbType.Varchar2,15,batchno,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region VarifyExpireDate
        public int VarifyExpireDate(string phrid, string drugid)
        {
            string packageName = "PKG_MRR.VARIFY_EXP_DATE";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("PharmacyID",OracleDbType.Varchar2,6,phrid,ParameterDirection.Input),
                new OracleParameter("DrugID",OracleDbType.Varchar2,7,drugid,ParameterDirection.Input)
                
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion
    }
}
