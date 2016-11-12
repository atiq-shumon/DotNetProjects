using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OPD.MODEL;
using AH.OPD.DAL;
using AH.DRUGS.MODEL;
using AH.DRUGS.BLL;

namespace AH.OPD.BLL
{
   public class OPDDrugsBLL
    {
       public List<OPDDrugs> GetOpdDrugsTkt(string tktno)
       {
           return new OPDDrugsDAL().GetOpdDrugsTkt(tktno);
       }

       public List<DrugDose> GetMedicineListOPD(string drugid, string patage)
       {
           return new OPDDrugsDAL().GetMedicineListOPD(drugid, patage);
       }
     
    }
}
