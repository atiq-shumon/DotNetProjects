using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.DAL;
using AH.INVMS.MODEL;

namespace AH.INVMS.BLL
{
    public class InventorySetupBLL
    {
        public short SaveCompanyDetails(CompanySetup ocompany)
        {
            return new InventorySetupDAL().savecompanydetails(ocompany);
        }
        public List<CompanySetup> GetCompanyDetails()
        {
            return new InventorySetupDAL().GetCompanyDetails();
        }
        public short ModifyCompanyDetails(CompanySetup ocompany)
        {
            return new InventorySetupDAL().ModifyCompanyDetails(ocompany);
        }
        public short SaveGroupDetails(GroupDetails ogroup)
        {
            return new InventorySetupDAL().SaveGroupDetails(ogroup);
        }
        public List<GroupDetails> GetGroupDetails()
        {
            return new InventorySetupDAL().GetGroupDetails();
        }
        public List<GroupDetails> GetGroupList(string groupname)
        {
            return new InventorySetupDAL().GetGroupList(groupname);
        }
        public short ModifyGroupDetails(GroupDetails ogroup)
        {
            return new InventorySetupDAL().ModifyGroupDetails(ogroup);
        }
        public short SaveUnitDetails(Units ounit)
        {
            return new InventorySetupDAL().SaveUnitDetails(ounit);
        }
        public List<Units> GetUnitSetup()
        {
            return new InventorySetupDAL().GetUnitSetup();
        }
        public short ModifyUnitDetails(Units ounit)
        {
            return new InventorySetupDAL().ModifyUnitDetails(ounit);
        }
        public short SavePacketType(PacketType otype)
        {
            return new InventorySetupDAL().SavePacketType(otype);
        }
        public List<PacketType> GetPacketType()
        {
            return new InventorySetupDAL().GetPacketType();
        }
        public short ModifyPacketType(PacketType otype)
        {
            return new InventorySetupDAL().ModifyPacketType(otype);
        }
        public short SaveModelDetails(ModelSetup omodel)
        {
            return new InventorySetupDAL().SaveModelDetails(omodel);
        }
        public List<ModelSetup> GetModelDetails()
        {
            return new InventorySetupDAL().GetModelDetails();
        }
        public short ModifyModelDetails(ModelSetup omodel)
        {
            return new InventorySetupDAL().ModifyModelDetails(omodel);
        }
        public short SaveBrandDetails(BrandSetup obrand)
        {
            return new InventorySetupDAL().SaveBrandDetails(obrand);
        }
        public List<BrandSetup> GetBrandDetails()
        {
            return new InventorySetupDAL().GetBrandDetails();
        }
        public short ModifyBrandDetails(BrandSetup obrand)
        {
            return new InventorySetupDAL().ModifyBrandDetails(obrand);
        }
        public short SaveSupplier(Supplier osupplier)
        {
            return new InventorySetupDAL().SaveSupplier(osupplier);
        }
        public List<Supplier> GetSupplierList()
        {
            return new InventorySetupDAL().GetSupplierList();
        }
        public List<Supplier> GetSupplierByName(string suppliername)
        {
            return new InventorySetupDAL().GetSupplierByName(suppliername);
        }
        public short ModifySupplierList(Supplier osupplier)
        {
            return new InventorySetupDAL().ModifySupplierList(osupplier);
        }
        public short SaveItemMaster(ItemMaster omaster)
        {
            return new InventorySetupDAL().SaveItemMaster(omaster);
        }
        public List<ItemMaster> GetItemMaster()
        {
            return new InventorySetupDAL().GetItemMaster();
        }
        public  List<ItemMaster> GetItemMasterByGroup(string grpid)
        {
            return new InventorySetupDAL().GetItemMasterByGroup(grpid);
        }
        public List<ItemMaster> GetItemsByName(string itemname, string storeid)
        {
            return new InventorySetupDAL().GetItemsByName(itemname,storeid);
        }
        public short ModifyItemMaster(ItemMaster omaster)
        {
            return new InventorySetupDAL().ModifyItemMaster(omaster);
        }
        public short SaveStoreLocation(StoreLocation ostore)
        {
            return new InventorySetupDAL().SaveStoreLocation(ostore);
        }
        public short ModifyStoreLocation(StoreLocation ostore)
        {
            return new InventorySetupDAL().ModifyStoreLocation(ostore);
        }
        public List<StoreLocation> GetStoreLocation()
        {
            return new InventorySetupDAL().GetStoreLocation();
        }
        public short SaveItemRates(ItemRates rate)
        {
            return new InventorySetupDAL().SaveItemRates(rate);
        }
        public List<ItemRates> GetItemRates()
        {
            return new InventorySetupDAL().GetItemRates();
        }
        public List<Stock> GetStockDetails(string itemname, string storeid)
        {
            return new InventorySetupDAL().GetStockDetails(itemname,storeid);
        }
        public short SaveStoreUser(StoreUser ouser)
        {
            return new InventorySetupDAL().SaveStoreUser(ouser);
        }
        public List<StoreUser> GetStoreUser()
        {
            return new InventorySetupDAL().GetStoreUser();
        }
        public short SaveStoreType(StoreTypeSCM St)
        {
            return new InventorySetupDAL().SaveStoreType(St);
        }
        public short UpdateStoreType(StoreTypeSCM St)
        {
            return new InventorySetupDAL().UpdateStoreType(St);
        }
        public List<StoreTypeSCM> GetStoreType()
        {
            return new InventorySetupDAL().GetStoreType();
        }

        public short SaveMajorGrp(Majorgroup Mg)
        {
            return new InventorySetupDAL().SaveMajorGrp(Mg);
        }
        public short Update_Majorgroup(Majorgroup Mg)
        {
            return new InventorySetupDAL().Update_Majorgroup(Mg);
        }

        public List<Majorgroup> GetMajorGrp()
        {
            return new InventorySetupDAL().GetMajorGrp();
        }

        public Dictionary<string, string> GetStoreTypeofGroup()
        {
            Dictionary<string, string> objService = new Dictionary<string, string>();
            foreach (Majorgroup Mg in new InventorySetupDAL().GetStoreTypeofGroup())
            {
                objService.Add(Mg.StoreType.strTypeID, Mg.StoreType.TypeTitle);
            }
            return objService;

        }
        public List<GroupDetails> GetGroupByMajorGrp(string strtype,string majorgrp)
        {
            return new InventorySetupDAL().GetGroupByMajorGrp(strtype,majorgrp);
        }
        public List<Majorgroup> GetMajorGrpByStrtype(string strtype)
        {
            return new InventorySetupDAL().GetMajorGrpByStrtype(strtype);
        }
        public List<StoreLocation> GetStoreLocByType(string strtype)
        {
            return new InventorySetupDAL().GetStoreLocByType(strtype);
        }
        public short Savewarehousetype(Warehouse Wh)
        {
            return new InventorySetupDAL().Savewarehousetype(Wh);
        }

        public short Updatewarehousetype(Warehouse Wh)
        {
            return new InventorySetupDAL().Updatewarehousetype(Wh);
        }

        public List<Warehouse> GetWarehousetype()
        {
            return new InventorySetupDAL().GetWarehousetype();
        }
        public short Savewarehouse(WarehouseConfig Wh)
        {
            return new InventorySetupDAL().Savewarehouse(Wh);
        }

        public short Updatewarehouse(WarehouseConfig Wh)
        {
            return new InventorySetupDAL().Updatewarehouse(Wh);
        }
        public List<WarehouseConfig> GetWarehouse()
        {
            return new InventorySetupDAL().GetWarehouse();
        }
        public List<WarehouseConfig> LoadWarehouse()
        {
            return new InventorySetupDAL().LoadWarehouse();
        }
        public List<Warehouse> GeHktwarehouse(string where)
        {
            return new InventorySetupDAL().GeHktwarehouse(where);
        }
        public List<ItemMaster> GetItemStockList(string grpid)
        {
            return new InventorySetupDAL().GetItemStockList(grpid);
        }
        public List<ItemMaster> GetItemStockListAll()
        {
            return new InventorySetupDAL().GetItemStockListAll();
        }
        public List<StoreTypeSCM> LoadStoreType()
        {
            return new InventorySetupDAL().LoadStoreType();
        }
        public List<ItemMaster> GetItemsForOpening(string itemname, string storeid)
        {
            return new InventorySetupDAL().GetItemsForOpening(itemname,storeid);
        }
        public List<WarehouseConfig> GetWarehouseTypewise(string phr,string str)
        {
            return new InventorySetupDAL().GetWarehouseTypewise(phr,str);
        }
        public List<WarehouseConfig> GetWhTypeforCentral(string warehouse, string type)
        {
            return new InventorySetupDAL().GetWhTypeforCentral(warehouse,type);
        }
        public List<WarehouseConfig> GetWhTypeforSCM(string warehouse, string type)
        {
            return new InventorySetupDAL().GetWhTypeforSCM(warehouse,type);
        }
        public List<ItemMaster> GetItemsByNameForTransfer(string itemname, string storeid)
        {
            return new InventorySetupDAL().GetItemsByNameForTransfer(itemname,storeid);
        }
        public List<ItemOrder> GetItemStockForNS(string grpid, string strid)
        {
            return new InventorySetupDAL().GetItemStockForNS(grpid,strid);
        }
       
    }
}
