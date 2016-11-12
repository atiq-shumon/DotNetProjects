using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.DRUGS.DAL;

namespace AH.DRUGS.BLL
{
    public class DrugSetupBLL
    {
         public short SaveDrugCompany(DrugCompany dg)
        {
            return new DrugSetupDAL().SaveDrugCompany(dg);
        }
        public short UpdateDrugCompany(DrugCompany udg)
        {
            return new DrugSetupDAL().UpdateDrugCompany(udg);
        }
        public short SaveDrugGroup(DrugGroup drgr)
        {
            return new DrugSetupDAL().SaveDrugGroup(drgr);
        }
        public short UpdateGroup(DrugGroup ugr)
        {
            return new DrugSetupDAL().UpdateGroup(ugr);
        }
        public short SaveDrugUnit(DrugUnit dunit)
        {
            return new DrugSetupDAL().SaveDrugUnit(dunit);
        }
        public short UpdateDrugUnit(DrugUnit unt)
        {
            return new DrugSetupDAL().UpdateDrugUnit(unt);
        }
        public short SaveDrugPackType(DrugPackType pack)
        {
            return new DrugSetupDAL().SaveDrugPackType(pack);
        }
        public short UpdateDrugPackType(DrugPackType upac)
        {
            return new DrugSetupDAL().UpdateDrugPackType(upac);
        }
        public List<DrugCompany> GetDrugCompany()
        {
            return new DrugSetupDAL().GetDrugCompany();
        }
        public Dictionary<string, string> GetDrugCompany(string type)
        {
            Dictionary<string, string> dgcom = new Dictionary<string, string>();
            foreach (DrugCompany dg in new DrugSetupDAL().GetDrugCompany())
            {
                dgcom.Add(dg.ID,dg.Name);
            }
            return dgcom;
        }
        public List<DrugGroup> GetDrugGroup()
        {
            return new DrugSetupDAL().GetDrugGroup();
        }
        public Dictionary<string,string> GetDrugGroup(string type)
        {
            Dictionary<string, string> dgroup = new Dictionary<string, string>();
            foreach(DrugGroup dgr in new DrugSetupDAL().GetDrugGroup())
            {
                dgroup.Add(dgr.ID,dgr.Name);
            }
            return dgroup;
        }
        public List<DrugUnit> GetDrugUnit()
        {
            return new DrugSetupDAL().GetDrugUnit();
        }
        public Dictionary<string, string> GetDrugUnit(string type)
        {
            Dictionary<string, string> dgunit = new Dictionary<string, string>();
            foreach (DrugUnit dun in new DrugSetupDAL().GetDrugUnit())
            {
                dgunit.Add(dun.ID,dun.Name);
            }
            return dgunit;
        }
        public List<DrugPackType> GetDrugPackType()
        {
            return new DrugSetupDAL().GetDrugPackType();
        }
        public Dictionary<string, string> GetDrugPackType(string type)
        {
            Dictionary<string, string> dpack = new Dictionary<string, string>();
            foreach (DrugPackType pac in new DrugSetupDAL().GetDrugPackType())
            {
                dpack.Add(pac.ID,pac.Name);
            }
            return dpack;
        }
        public short SaveDrugMaster(DrugMaster ms)
        {
            return new DrugSetupDAL().SaveDrugMaster(ms);
        }
        public short UpdateDrugMaster(DrugMaster ums)
        {
            return new DrugSetupDAL().UpdateDrugMaster(ums);
        }
        public List<DrugMaster> GetDrugMaster()
        {
            return new DrugSetupDAL().GetDrugMaster();
        }
        public Dictionary<string, string> GetDrugName(string type)
        {
            Dictionary<string, string> dname = new Dictionary<string, string>();
            foreach (DrugMaster dm in new DrugSetupDAL().GetDrugMaster())
            {
                dname.Add(dm.ID,dm.Name);
            }
            return dname;
        }
        public List<DrugMaster> GetDrugMasterList(string drugName)
        {
            return new DrugSetupDAL().GetDrugMasterList(drugName);
        }
        public short SaveDrugDose(DrugDose dr)
        {
            return new DrugSetupDAL().SaveDrugDose(dr);
        }
        public short UpdateDrugDose(DrugDose dr)
        {
            return new DrugSetupDAL().UpdateDrugDose(dr);
        }
        public List<DrugDose> GetDrugDose()
        {
            return new DrugSetupDAL().GetDrugDose();
        }
        public List<DrugMaster> GetMedicineList(string medicineName)
        {
            return new DrugSetupDAL().GetMedicineList(medicineName);
        }
        public List<ConsumptionForm> GetConsumption()
        {
            return new DrugSetupDAL().GetConsumption();
        }
        public Dictionary<string, string> getConsumptionForm(string type)
        {
            Dictionary<string, string> consumptionForm = new Dictionary<string, string>();
            consumptionForm.Add("", "--Select--");
            foreach (ConsumptionForm cnsmp in new DrugSetupBLL().GetConsumption())
            {
                consumptionForm.Add(cnsmp.ID, cnsmp.Name);
            }
            return consumptionForm;
        }

        public string SaveDrugConsumption(ConsumptionForm odrug)
        {
            return new DrugSetupDAL().SaveDrugConsumption(odrug);
        }
        public short ModifyDrugConsumption(ConsumptionForm odrug)
        {
            return new DrugSetupDAL().ModifyDrugConsumption(odrug);
        }
        public List<DrugMaster> GetDrugMasterListCompanyWise(string drugName,string company)
        {
            return new DrugSetupDAL().GetDrugMasterListCompanyWise(drugName,company);
        }
        public List<DrugMaster> GetDrugMasterByCompany(string drugcompany)
        {
            return new DrugSetupDAL().GetDrugMasterByCompany(drugcompany);
        }
        public List<DrugCompany> GetDrugCompanyDictionary()
        {
            return new DrugSetupDAL().GetDrugCompanyDictionary();
        }
        public List<DrugMaster> GetDrugListCompanyWise(string company)
        {
            return new DrugSetupDAL().GetDrugListCompanyWise(company);
        }
        public List<DrugRoute> GetDrugRoute()
        {
            return new DrugSetupDAL().GetDrugRoute();
        }
        public string SaveDrugRoute(DrugRoute odrug)
        {
            return new DrugSetupDAL().SaveDrugRoute(odrug);
        }
        public short ModifyDrugRoute(DrugRoute odrug)
        {
            return new DrugSetupDAL().ModifyDrugRoute(odrug);
        }
    }
}

