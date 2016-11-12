using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.PHRMS.DAL;
using AH.PHRMS.MODEL;
using AH.Shared.MODEL;

namespace AH.PHRMS.BLL
{
    public class PHRMSSetupBLL
    {
        //public short SaveDrugCompany(DrugCompany dg)
        //{
        //    return new DrugSetupDAL().SaveDrugCompany(dg);
        //}
        //public short UpdateDrugCompany(DrugCompany udg)
        //{
        //    return new DrugSetupDAL().UpdateDrugCompany(udg);
        //}
        //public short SaveDrugGroup(DrugGroup drgr)
        //{
        //    return new DrugSetupDAL().SaveDrugGroup(drgr);
        //}
        //public short UpdateGroup(DrugGroup ugr)
        //{
        //    return new DrugSetupDAL().UpdateGroup(ugr);
        //}
        //public short SaveDrugUnit(DrugUnit dunit)
        //{
        //    return new DrugSetupDAL().SaveDrugUnit(dunit);
        //}
        //public short UpdateDrugUnit(DrugUnit unt)
        //{
        //    return new DrugSetupDAL().UpdateDrugUnit(unt);
        //}
        //public short SaveDrugPackType(DrugPackType pack)
        //{
        //    return new DrugSetupDAL().SaveDrugPackType(pack);
        //}
        //public short UpdateDrugPackType(DrugPackType upac)
        //{
        //    return new DrugSetupDAL().UpdateDrugPackType(upac);
        //}
        //public List<DrugCompany> GetDrugCompany()
        //{
        //    return new DrugSetupDAL().GetDrugCompany();
        //}
        //public Dictionary<string, string> GetDrugCompany(string type)
        //{
        //    Dictionary<string, string> dgcom = new Dictionary<string, string>();
        //    foreach (DrugCompany dg in new DrugSetupDAL().GetDrugCompany())
        //    {
        //        dgcom.Add(dg.ID,dg.Name);
        //    }
        //    return dgcom;
        //}
        //public List<DrugGroup> GetDrugGroup()
        //{
        //    return new DrugSetupDAL().GetDrugGroup();
        //}
        //public Dictionary<string,string> GetDrugGroup(string type)
        //{
        //    Dictionary<string, string> dgroup = new Dictionary<string, string>();
        //    foreach(DrugGroup dgr in new DrugSetupDAL().GetDrugGroup())
        //    {
        //        dgroup.Add(dgr.ID,dgr.Name);
        //    }
        //    return dgroup;
        //}
        //public List<DrugUnit> GetDrugUnit()
        //{
        //    return new DrugSetupDAL().GetDrugUnit();
        //}
        //public Dictionary<string, string> GetDrugUnit(string type)
        //{
        //    Dictionary<string, string> dgunit = new Dictionary<string, string>();
        //    foreach (DrugUnit dun in new DrugSetupDAL().GetDrugUnit())
        //    {
        //        dgunit.Add(dun.ID,dun.Name);
        //    }
        //    return dgunit;
        //}
        //public List<DrugPackType> GetDrugPackType()
        //{
        //    return new DrugSetupDAL().GetDrugPackType();
        //}
        //public Dictionary<string, string> GetDrugPackType(string type)
        //{
        //    Dictionary<string, string> dpack = new Dictionary<string, string>();
        //    foreach (DrugPackType pac in new DrugSetupDAL().GetDrugPackType())
        //    {
        //        dpack.Add(pac.ID,pac.Name);
        //    }
        //    return dpack;
        //}
        //public short SaveDrugMaster(DrugMaster ms)
        //{
        //    return new DrugSetupDAL().SaveDrugMaster(ms);
        //}
        //public short UpdateDrugMaster(DrugMaster ums)
        //{
        //    return new DrugSetupDAL().UpdateDrugMaster(ums);
        //}
        //public List<DrugMaster> GetDrugMaster()
        //{
        //    return new DrugSetupDAL().GetDrugMaster();
        //}
        //public List<DrugMaster> GetDrugMasterList(string drugName)
        //{
        //    return new DrugSetupDAL().GetDrugMasterList(drugName);
        //}
        public short SavePharmacyLocation(Pharmacy loc)
        {
            return new PHRMSSetupDAL().SavePharmacyLocation(loc);
        }
        public short UpdatePharmacyLocation(Pharmacy loc)
        {
            return new PHRMSSetupDAL().UpdatePharmacyLocation(loc);
        }
        public short SaveSupplier(Supplier sp)
        {
            return new PHRMSSetupDAL().SaveSupplier(sp);
        }
        public short UpdateSupplier(Supplier sp)
        {
            return new PHRMSSetupDAL().UpdateSupplier(sp);
        }
        public List<Pharmacy> GetPharmacyLocation()
        {
            return new PHRMSSetupDAL().GetPharmacyLocation();
        }
        public Dictionary<string, string> GetPharmacyLocation(string type)
        {
            Dictionary<string, string> phar = new Dictionary<string, string>();
            phar.Add("", "--Select--");
            foreach (Pharmacy lc in new PHRMSSetupDAL().GetPharmacyLocation())
            {
                phar.Add(lc.PharmacyID,lc.PharmacyTitle);
            }
            return phar;
        }
        public List<Supplier> GetSupplierList()
        {
            return new PHRMSSetupDAL().GetSupplierList();
        }
        public List<Supplier> GetSupplierListed(string supname)
        {
            return new PHRMSSetupDAL().GetSupplierListed(supname);
        }
        
        public short SaveConsumerPurpose(ConsumerPurpose con)
        {
            return new PHRMSSetupDAL().SaveConsumerPurpose(con);
        }
        public short UpdateConsumerPurpose(ConsumerPurpose con)
        {
            return new PHRMSSetupDAL().UpdateConsumerPurpose(con);
        }
        public List<ConsumerPurpose> GetConsumerPurpose()
        {
            return new PHRMSSetupDAL().GetConsumerPurpose();
        }
        public short SaveItemRates(ItemRates rate)
        {
            return new PHRMSSetupDAL().SaveItemRates(rate);
        }
        public short UpdateItemRates(ItemRates urat)
        {
            return new PHRMSSetupDAL().UpdateItemRates(urat);
        }
        public List<ItemRates> GetItemRates()
        {
            return new PHRMSSetupDAL().GetItemRates();
        }
        public short SavePharmacyUsers(PharmacyUser usr)
        {
            return new PHRMSSetupDAL().SavePharmacyUsers(usr);
        }
        public List<PharmacyUser> GetUser()
        {
            return new PHRMSSetupDAL().GetUser();
        }
        public List<DrugMaster> GetDrugListStock(string drugName,string pharmacyid)
        {
            return new PHRMSSetupDAL().GetDrugListStock(drugName,pharmacyid);
        }
        public List<DrugMaster> GetDrugListByGroupName(string groupName)
        {
            return new PHRMSSetupDAL().GetDrugListByGroupName(groupName);
        }
        public List<DrugMaster> GetDrugListByGroupNameForIPD(string groupName)
        {
            return new PHRMSSetupDAL().GetDrugListByGroupNameForIPD(groupName);
        }
        public List<DrugMaster> GetDrugStockByGroup(string groupName)
        {
            return new PHRMSSetupDAL().GetDrugStockByGroup(groupName);
        }
        //public List<DrugMaster> GetDrugStockByCompany(string drugName,string company)
        //{
        //    return new PHRMSSetupDAL().GetDrugStockByCompany(drugName,company);
        //}
        //public short SaveDrugDose(DrugDose dr)
        //{
        //    return new DrugSetupDAL().SaveDrugDose(dr);
        //}
        //public short UpdateDrugDose(DrugDose dr)
        //{
        //    return new DrugSetupDAL().UpdateDrugDose(dr);
        //}
        //public List<DrugDose> GetDrugDose()
        //{
        //    return new DrugSetupDAL().GetDrugDose();
        //}
        public StockHelper GetDrugsStock(string drugid, string phrid)
        {
            return new PHRMSSetupDAL().GetDrugsStock(drugid,phrid);
        }
        public List<PurchaseRequisition> GetRequisitionTrack(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupDAL().GetRequisitionTrack(pharmacyid,startDate,endDate);
        }
        public List<PurchaseOrder> GetPOTracking(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupDAL().GetPOTracking(pharmacyid,startDate,endDate);
        }
        public List<PurchaseOrder> GetPOTrackingByPrId(string prid)
        {
            return new PHRMSSetupDAL().GetPOTrackingByPrId(prid);
        }
        public List<MaterialReceive> GetMrrTracking(string pharmacyid, string startDate, string endDate)
        {
            return new PHRMSSetupDAL().GetMrrTracking(pharmacyid,startDate,endDate);
        }
        public List<MaterialReceive> GetMrrTrackingByPONo(string poid)
        {
            return new PHRMSSetupDAL().GetMrrTrackingByPONo(poid);
        }
        public List<PharmacyUser> GetUserByID(string userid)
        {
            return new PHRMSSetupDAL().GetUserByID(userid);
        }
        public List<DrugMaster> GetDrugStockByPharmacy(string drugName, string pharmacy)
        {
            return new PHRMSSetupDAL().GetDrugStockByPharmacy(drugName,pharmacy);
        }
    }
}
