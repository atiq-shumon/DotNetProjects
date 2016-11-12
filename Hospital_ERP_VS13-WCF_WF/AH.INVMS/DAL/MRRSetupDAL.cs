using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AH.INVMS.MODEL;
using AH.OracleManager;
using AH.DUtility;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AH.INVMS.DAL
{
    public class MRRSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.INVMS);

        #region SaveMrrDetails
        public string SaveMrrDetails(MaterialReceive omatreceive)
        {
            string packageName = "PKG_MRR.SAVE_MRR";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,omatreceive.ID,ParameterDirection.Output),
                new OracleParameter("MrrFlag",OracleDbType.Varchar2,1,omatreceive.MrrFlag,ParameterDirection.Input),
                new OracleParameter("StoreLocation",OracleDbType.Varchar2,6,omatreceive.Warehouse.TypeID,ParameterDirection.Input),
                new OracleParameter("StoreType",OracleDbType.Varchar2,6,omatreceive.PurchaseOrder.StoreType.strTypeID,ParameterDirection.Input),
                new OracleParameter("PurchaseOrder",OracleDbType.Varchar2,15,omatreceive.PurchaseOrder.ID,ParameterDirection.Input),
                new OracleParameter("PurchaseRequisition",OracleDbType.Varchar2,15,omatreceive.PurchaseRequisition.ID,ParameterDirection.Input),
                new OracleParameter("CostCategory",OracleDbType.Varchar2,7,omatreceive.CostCategoryTreeview.CategoryID,ParameterDirection.Input),
                new OracleParameter("CostCenterID",OracleDbType.Varchar2,10,omatreceive.CostCategoryTreeview.CostCenterID,ParameterDirection.Input),
                new OracleParameter("Supplier",OracleDbType.Varchar2,15,omatreceive.Supplier.ID,ParameterDirection.Input),
                new OracleParameter("TransactionType",OracleDbType.Varchar2,15,omatreceive.TransactionType,ParameterDirection.Input),
                new OracleParameter("MrrDate",OracleDbType.Date,omatreceive.MrrDate,ParameterDirection.Input),
                new OracleParameter("MrrType",OracleDbType.Varchar2,1,omatreceive.MrrType,ParameterDirection.Input),
                new OracleParameter("ChallanNo",OracleDbType.Varchar2,30,omatreceive.ChallanNo,ParameterDirection.Input),
                new OracleParameter("ChallanDate",OracleDbType.Date,omatreceive.ChallanDate,ParameterDirection.Input),
                new OracleParameter("VoucherNo",OracleDbType.Varchar2,10,omatreceive.VoucherNo,ParameterDirection.Input),
                new OracleParameter("Remarks",OracleDbType.Varchar2,200,omatreceive.Remarks,ParameterDirection.Input),
                //new OracleParameter("MRRQuantity",OracleDbType.Single,omatreceive.MrrQuantity,ParameterDirection.Input),
                new OracleParameter("MRDetails",OracleDbType.Varchar2,32000,omatreceive.MrrDetails,ParameterDirection.Input),
                new OracleParameter("AssetTracker",OracleDbType.Varchar2,32000,omatreceive.AssetTracker,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,omatreceive.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,omatreceive.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,omatreceive.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,omatreceive.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[1];
            string regno = (string)(OracleString)prm.Value;
            return regno;
          
        }
        #endregion

        #region VerifyOpeningItemID
        public string VerifyOpeningItemID(string itemid, string storeid)
        {
            string packageName = "PKG_MRR.VERIFY_OPENING_ITEMID";
            OracleParameter[] parameterList = new OracleParameter[]  {
                new OracleParameter("IsFound",OracleDbType.Varchar2,900,null,ParameterDirection.Output),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,storeid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            string ponum = (string)(OracleString)prm.Value;
            return ponum;
        }
        #endregion

        #region GetMRRNumber
        public List<MaterialReceive> GetMRRNumber()
        {
            string packageName = "PKG_MRR.GET_MRR_NUMBER";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
                
            };

            //private List<MaterialReceive>
            List<MaterialReceive> omatrec = new List<MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                MaterialReceive mat = new MaterialReceive();
                mat.ID = (string)rdr["MRRID"].ToString();

                omatrec.Add(mat);

            }
            rdr.Close();
            return omatrec;
        }
        #endregion
        
        #region GetOpeningEntry
        public List<MaterialReceive> GetOpeningEntry(string MrrID)
        {
            string packageName = "PKG_MRR.GET_OPENING_ENTRY";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,MrrID,ParameterDirection.Input)
            };
            List<MaterialReceive> omrrnum = new List<MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while (rdr.Read())
            {
                MaterialReceive orec = new MaterialReceive();
                orec.ID = (string)rdr["MRRID"];
                orec.TransactionType = (string)rdr["TransactionType"];
                orec.MrrQuantity = Single.Parse(rdr["Quantity"].ToString());
                orec.ExpDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());

                PurchaseRequisition oreq = new PurchaseRequisition();
                oreq.RequisitionQty = float.Parse(rdr["REQUISITIONQTY"].ToString());
                orec.PurchaseRequisition = oreq;

                ItemOrder oitem = new ItemOrder();
                oitem.Rate = Single.Parse(rdr["Rate"].ToString());
                oitem.SlRate = Single.Parse(rdr["SALESRATE"].ToString());
                oitem.VAT = Single.Parse(rdr["VAT"].ToString());
                oitem.Discount = Single.Parse(rdr["Discount"].ToString());
                oitem.POQty = Single.Parse(rdr["POQTY"].ToString());
                

                ItemMaster mas = new ItemMaster();
                mas.ID = (string)rdr["ITEMID"];
                mas.Name = (string)rdr["ITEMNAME"];
                oitem.ItemMaster = mas;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TYPEID"];
                mas.PacketType = otype;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UnitID"];
                mas.Units = ounit;

                GroupDetails ogrp = new GroupDetails();
                ogrp.ID = (string)rdr["GroupID"];
                ogrp.Name = (string)rdr["GROUPNAME"];
                mas.GroupDetails = ogrp;

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["CompanyID"];
                ocomp.Name = (string)rdr["COMPANYNAME"];
                mas.Company = ocomp;

                BrandSetup obrnd = new BrandSetup();
                obrnd.ID = (string)rdr["BRANDID"];
                obrnd.Name = (string)rdr["BRANDNAME"];
                mas.BrandSetup = obrnd;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["MODELID"];
                omodel.Name = (string)rdr["MODELNAME"];
                mas.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                mas.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                mas.StoreType = ostrtype;
               
                orec.ItemOrder = oitem;

                omrrnum.Add(orec);
            }
            rdr.Close();
            return omrrnum;

        }
        #endregion

        #region GetMrrDetails
        public List<MaterialReceive> GetMrrDetails(string MrrID)
        {
            string packageName = "PKG_MRR.GET_MRR_DET";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,MrrID,ParameterDirection.Input)
            };
            List<MaterialReceive> omrrnum = new List<MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                MaterialReceive orec = new MaterialReceive();
                orec.ID = (string)rdr["MRR_ID"];
                

                PurchaseRequisition oreq = new PurchaseRequisition();
                oreq.ID = (string)rdr["PR_ID"];
                orec.PurchaseRequisition = oreq;

                PurchaseOrder opurorder = new PurchaseOrder();
                opurorder.ID = (string)rdr["PO_ID"];
                orec.PurchaseOrder = opurorder;

                StoreLocation ostr = new StoreLocation();
                ostr.ID = (string)rdr["STR_ID"];
                ostr.Name = (string)rdr["STORE_TITLE"];
                orec.StoreLocation = ostr;

                ItemOrder oitem = new ItemOrder();
               
                ItemMaster mas = new ItemMaster();
                mas.ID = (string)rdr["PROD_ID"];
                mas.Name = (string)rdr["ITEMNAME"];
                oitem.ItemMaster = mas;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["PROD_TYPE_ID"];
                otype.Name = (string)rdr["TYPENAME"];
                mas.PacketType = otype;

                Units ounit = new Units();
                ounit.ID = (string)rdr["PROD_UNIT_ID"];
                ounit.Name = (string)rdr["UNITNAME"];
                mas.Units = ounit;

                GroupDetails ogrp = new GroupDetails();
                ogrp.ID = (string)rdr["PROD_GRP_ID"];
                ogrp.Name = (string)rdr["GROUPNAME"];
                mas.GroupDetails = ogrp;

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["PROD_COMP_ID"];
                ocomp.Name = (string)rdr["COMPANYNAME"];
                mas.Company = ocomp;

                BrandSetup obrnd = new BrandSetup();
                obrnd.ID = (string)rdr["PROD_BRND_ID"];
                obrnd.Name = (string)rdr["BRANDNAME"];
                mas.BrandSetup = obrnd;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["PROD_MODEL_ID"];
                omodel.Name = (string)rdr["MODELNAME"];
                mas.ModelSetup = omodel;

                orec.ItemOrder = oitem;

                omrrnum.Add(orec);
            }
            rdr.Close();
            return omrrnum;

        }
        #endregion

        #region SaveAssetTrackerMaster
        public short SaveAssetTrackerMaster(AssetTrackerMaster oasset)
        {
            string packageName = "PKG_MRR.Insert_AssetsTrackerMaster";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("SerialNo",OracleDbType.Varchar2,50,oasset.SerialNo,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,6,oasset.MaterialReceive.ItemOrder.ItemMaster.Company.ID,ParameterDirection.Input),
                new OracleParameter("Store",OracleDbType.Varchar2,2,oasset.MaterialReceive.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("Group",OracleDbType.Varchar2,6,oasset.MaterialReceive.ItemOrder.ItemMaster.GroupDetails.ID,ParameterDirection.Input),
                new OracleParameter("Unit",OracleDbType.Varchar2,4,oasset.MaterialReceive.ItemOrder.ItemMaster.Units.ID,ParameterDirection.Input),
                new OracleParameter("Type",OracleDbType.Varchar2,4,oasset.MaterialReceive.ItemOrder.ItemMaster.PacketType.ID,ParameterDirection.Input),
                new OracleParameter("Model",OracleDbType.Varchar2,4,oasset.MaterialReceive.ItemOrder.ItemMaster.ModelSetup.ID,ParameterDirection.Input),
                new OracleParameter("Brand",OracleDbType.Varchar2,4,oasset.MaterialReceive.ItemOrder.ItemMaster.BrandSetup.ID,ParameterDirection.Input),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,oasset.MaterialReceive.ItemOrder.ItemMaster.ID,ParameterDirection.Input),
                new OracleParameter("ServiceProvider",OracleDbType.Varchar2,6,oasset.ServiceProviderID,ParameterDirection.Input),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,oasset.MaterialReceive.ID,ParameterDirection.Input),
                new OracleParameter("WarrantyUpto",OracleDbType.Varchar2,12,oasset.WarrantyUpto,ParameterDirection.Input),
                new OracleParameter("ExpireDate",OracleDbType.Varchar2,12,oasset.ExpireDate,ParameterDirection.Input),
                new OracleParameter("EntryBy",OracleDbType.Varchar2,20,oasset.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("CompanyID",OracleDbType.Varchar2,2,oasset.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("LocationID",OracleDbType.Varchar2,2,oasset.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("MachineID",OracleDbType.Varchar2,20,oasset.EntryParameter.MachineID,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString,packageName,parameterList);
            OracleParameter prm = parameterList[0];
            if((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;
        }
        #endregion

        #region GetServiceProvider
        public List<ServiceProviderSCM> GetServiceProvider(string Control, string Where)
        {
            string packageName = "AGH_INVMS.PKG_SERVICE_PROVIDER.GetDetailsInformation";
            OracleParameter[] parameterList = new OracleParameter[]
                {
                    
                    new OracleParameter("Cur_Group",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                    new OracleParameter("pcontrol",OracleDbType.Varchar2,60,"Getservicprovider",ParameterDirection.Input),
                    new OracleParameter("pwhere",OracleDbType.Varchar2,60,Where,ParameterDirection.Input)
                };
            return GetServiceProvider(packageName, parameterList);
        }
        private List<ServiceProviderSCM> GetServiceProvider(string packageName, OracleParameter[] parameterList)
        {
            List<ServiceProviderSCM> objService = new List<ServiceProviderSCM>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                ServiceProviderSCM SP = new ServiceProviderSCM();
                if (rdr["id"].ToString() != "")
                {
                    SP.ID = rdr["id"].ToString();
                }
                if (rdr["name"].ToString() != "")
                {
                    SP.ServiceProviderName = rdr["name"].ToString();
                }
                objService.Add(SP);
            }
            rdr.Close();
            return objService;
        }
        #endregion

        #region SavePurchaseReturn
        public string SavePurchaseReturn(PurchaseReturn oret)
        {
            string packageName = "PKG_PURCHASE_RETURN.SAVE_PURCHASE_RETURN";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("eRows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("ReturnID",OracleDbType.Varchar2,15,oret.ID,ParameterDirection.Output),
                new OracleParameter("StoreID",OracleDbType.Varchar2,6,oret.StoreLocation.ID,ParameterDirection.Input),
                new OracleParameter("POID",OracleDbType.Varchar2,15,oret.PurchaseOrder.ID,ParameterDirection.Input),
                new OracleParameter("MrrID",OracleDbType.Varchar2,15,oret.MaterialReceive.ID,ParameterDirection.Input),
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
        public List<MaterialReceive> GetMrrDetailsForPurchaseReturn(string mrrid)
        {
            string packageName = "PKG_MRR.GET_MRR_DET_FOR_PURRET";
            OracleParameter[] parameterList = new OracleParameter[] {
               new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
               new OracleParameter("MrrID",OracleDbType.Varchar2,15,mrrid,ParameterDirection.Input)
            };
            List<MaterialReceive> omatrec = new List<MaterialReceive>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString,packageName,parameterList);
            while(rdr.Read())
            {
                MaterialReceive orec = new MaterialReceive();
                orec.ID = (string)rdr["MRRID"];
                orec.MrrQuantity = float.Parse(rdr["Quantity"].ToString());
                orec.ExpDate = DateTime.Parse(rdr["EXPIREDATE"].ToString());
                orec.BatchID = (string)rdr["BATCHID"];
                orec.CompareQty = float.Parse(rdr["COMPAREQTY"].ToString());               
                orec.ReturnQty = float.Parse(rdr["RETQTY"].ToString());

                //PurchaseRequisition oreq = new PurchaseRequisition();
                //oreq.ID = (string)rdr["PR_ID"];
                //orec.PurchaseRequisition = oreq;

                PurchaseOrder opurorder = new PurchaseOrder();
                opurorder.ID = (string)rdr["POID"];
                orec.PurchaseOrder = opurorder;

                StoreLocation ostr = new StoreLocation();
                ostr.ID = (string)rdr["STOREID"];
                ostr.Name = (string)rdr["STORENAME"];
                orec.StoreLocation = ostr;

                Supplier osupplier = new Supplier();
                osupplier.ID = (string)rdr["SUPPLIERID"];
                osupplier.Name = (string)rdr["SUPPLIERNAME"];
                orec.Supplier = osupplier;

                ItemOrder oitem = new ItemOrder();
                oitem.Rate = float.Parse(rdr["Rate"].ToString());
                oitem.VAT = float.Parse(rdr["Vat"].ToString());
                oitem.Discount = float.Parse(rdr["Discount"].ToString());
                oitem.POQty = float.Parse(rdr["POQTY"].ToString());

                ItemMaster mas = new ItemMaster();
                mas.ID = (string)rdr["ITEMID"];
                mas.Name = (string)rdr["ITEMNAME"];
                oitem.ItemMaster = mas;

                PacketType otype = new PacketType();
                otype.ID = (string)rdr["TYPEID"];
                //otype.Name = (string)rdr["TYPENAME"];
                mas.PacketType = otype;

                Units ounit = new Units();
                ounit.ID = (string)rdr["UnitID"];
                ounit.Name = (string)rdr["UNITNAME"];
                mas.Units = ounit;

                GroupDetails ogrp = new GroupDetails();
                ogrp.ID = (string)rdr["GroupID"];
                ogrp.Name = (string)rdr["GROUPNAME"];
                mas.GroupDetails = ogrp;

                CompanySetup ocomp = new CompanySetup();
                ocomp.ID = (string)rdr["CompanyID"];
                ocomp.Name = (string)rdr["COMPANYNAME"];
                mas.Company = ocomp;

                BrandSetup obrnd = new BrandSetup();
                obrnd.ID = (string)rdr["BRANDID"];
                obrnd.Name = (string)rdr["BRANDNAME"];
                mas.BrandSetup = obrnd;

                ModelSetup omodel = new ModelSetup();
                omodel.ID = (string)rdr["MODELID"];
                omodel.Name = (string)rdr["MODELNAME"];
                mas.ModelSetup = omodel;

                Majorgroup omajor = new Majorgroup();
                omajor.MajorgrpID = (string)rdr["MAJORGROUPID"];
                omajor.Name = (string)rdr["MAJORGROUPNAME"];
                mas.Majorgroup = omajor;

                StoreTypeSCM ostrtype = new StoreTypeSCM();
                ostrtype.strTypeID = (string)rdr["STORETYPEID"];
                ostrtype.TypeTitle = (string)rdr["STORETYPENAME"];
                mas.StoreType = ostrtype;

                orec.ItemOrder = oitem;

                omatrec.Add(orec);

            }
            rdr.Close();
            return omatrec;
        }
        #endregion

        #region VarifyItemForReturn
        public int VarifyItemForReturn(string mrrid,string itemid)
        {
            string packageName = "PKG_PURCHASE_RETURN.VERIFY_ITEM_FORPURCHASERETURN";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("IsFound",OracleDbType.Int32,null,ParameterDirection.Output),
                new OracleParameter("MRRID",OracleDbType.Varchar2,15,mrrid,ParameterDirection.Input),
                new OracleParameter("ItemID",OracleDbType.Varchar2,7,itemid,ParameterDirection.Input)
            };
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int regno = (int)(OracleDecimal)prm.Value;
            return regno;
        }
        #endregion

        #region MrrDetailsReport
        public List<MaterialReceiveRO> GetMrrReportDateWise(string startDate, string endDate)
        {
            string packageName = "PKG_MRR.GET_MRRDET_REPORT";
            OracleParameter[] parameterList = new OracleParameter[] {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("StartDate",OracleDbType.Varchar2,10,startDate,ParameterDirection.Input),
                new OracleParameter("EndDate",OracleDbType.Varchar2,10,endDate,ParameterDirection.Input)
            };
            List<MaterialReceiveRO> omatrec = new List<MaterialReceiveRO>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
            while (rdr.Read())
            {
                MaterialReceiveRO ro = new MaterialReceiveRO();
                ro.MRRID = (string)rdr["MRRID"].ToString();
                ro.ProductID = (string)rdr["ITEMID"].ToString();
                ro.ProductName = (string)rdr["ITEMNAME"].ToString();
                ro.PackageType = (string)rdr["TYPEID"].ToString();
                ro.UnitID = (string)rdr["UnitID"].ToString();
                ro.GroupID = (string)rdr["GroupID"].ToString();
                ro.GroupName = (string)rdr["GROUPNAME"].ToString();
                ro.CompanyID = (string)rdr["CompanyID"].ToString();
                ro.CompanyName = (string)rdr["COMPANYNAME"].ToString();
                ro.BatchNo = (string)rdr["BatchID"].ToString();
                ro.ExpireDate = DateTime.Parse(rdr["ExpireDate"].ToString());
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
    }
}
