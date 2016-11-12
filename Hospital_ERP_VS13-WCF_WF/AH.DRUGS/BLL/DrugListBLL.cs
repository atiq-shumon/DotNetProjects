using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRUGS.MODEL;
using AH.DRUGS.DAL;

namespace AH.DRUGS.BLL
{
    public class DrugsListBLL
    {
        public List<DrugDose> GetDrugDoseList(string patage)
        {
            return new DrugsListDAL().GetDrugDoseList(patage);
        }
        public List<DrugDose> GetDrugDoseListForAll()
        {
            return new DrugsListDAL().GetDrugDoseListForAll();
        }
        public List<DrugDose> GetDrugDoseListByDrugName(string patage, string drugname)
        {
            return new DrugsListDAL().GetDrugDoseListByDrugName(patage,drugname);
        }
        public List<DrugDose> GetDrugDoseListByGroupName(string patage, string groupname)
        {
            return new DrugsListDAL().GetDrugDoseListByGroupName(patage,groupname);
        }
        public List<DrugDose> GetDrugDoseByDrugIPD(string patage, string drugname)
        {
            return new DrugsListDAL().GetDrugDoseByDrugIPD(patage,drugname);
        }
        public List<DrugDose> GetDrugDoseByGroupNameIPD(string patage, string groupname)
        {
            return new DrugsListDAL().GetDrugDoseByGroupNameIPD(patage,groupname);
        }
    }
}
