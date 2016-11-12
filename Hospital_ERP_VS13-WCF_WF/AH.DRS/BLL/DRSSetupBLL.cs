using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DRS.MODEL;
using AH.DTMS.MODEL;
using AH.DRS.DAL;
using AH.DMS.MODEL;



namespace AH.DRS.BLL
{
    public class DRSSetupBLL
    {
       
        //public int VerifySpecHolder(string spchold)
        //{
        //    return new DRSSetupDAL().VerifySpecHolder(spchold);
        //}
        //public short SaveSpecHolder(SpecimenHolder spchld)
        //{
        //    return new DRSSetupDAL().SaveSpecHolder(spchld);
        //}
        //public short UpdateSpcHolder(SpecimenHolder usphl)
        //{
        //    return new DRSSetupDAL().UpdateSpcHolder(usphl);
        //}
        //public List<SpecimenHolder> GetSpecHolder()
        //{
        //    return new DRSSetupDAL().GetSpecHolder();
        //}
        //public Dictionary<string, string> GetSpecHolder(string type)
        //{
        //    Dictionary<string, string> spchld = new Dictionary<string, string>();
        //    foreach (SpecimenHolder spech in new DRSSetupBLL().GetSpecHolder())
        //    {
        //        spchld.Add(spech.HolderID, spech.HolderTitle);
        //    }
        //    return spchld;
        //}
        public string  SaveUserReportAccess(UserReportAccess uerAccess)
        {
            var res= new DRSSetupDAL().SaveUserReportAccess(uerAccess);
            if (res != "1")
            {
                return res;
            }
            else
                return "1";
        }
        public List<UserReportAccess> GetUserAccess(string deptID,string rptSecID)
        {
            return new DRSSetupDAL().GetUserAccess(deptID, rptSecID);
        }
    }
}
