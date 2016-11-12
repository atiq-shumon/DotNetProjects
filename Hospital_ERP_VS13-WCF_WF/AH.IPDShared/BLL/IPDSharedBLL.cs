using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.IPDShared.MODEL;
using AH.IPDShared.DAL;
using AH.DUtility;

namespace AH.IPDShared.BLL
{
    public class IPDSharedBLL
    {
        public InPatient GetAdmittedPatient(string RegistrationNo)
        {
            return new IPDSharedDAL().GetAdmittedPatient(RegistrationNo);
        }
        public InPatient GetPatientDetails(string presID)
        {
            return new IPDSharedDAL().GetPatientDetails(presID);
        }

        public string VerifyInPatient(string regNo)
        {
            if (regNo == "")
            {
                return Utility.GetMsg(Utility.Msg.ValidRegistrationNo);
            };
            var res = new IPDSharedDAL().verifyPatient(regNo);
            if (res != "1")
            {
                return res;
            }
            return "";
        }
      
        public InPatient GetPatRegID(string bedID)
        {
            return new IPDSharedDAL().GetPatRegID(bedID);
        }
        public List<InPatient> GetAdmittedPatientListNSWise(string nurseStationId)
        {
            return new IPDSharedDAL().GetAdmittedPatientListNSWise(nurseStationId);
        }
        public List<InPatient> NSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date,string mealid)
        {
            return new IPDSharedDAL().NSWisePatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> OrderdNSWisePatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            return new IPDSharedDAL().OrderdNSWisePatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> ReadyToDelevPatientListDiet(string nurseStationId, string dietTypeId, DateTime date, string mealid)
        {
            return new IPDSharedDAL().ReadyToDelevPatientListDiet(nurseStationId, dietTypeId, date, mealid);
        }
        public List<InPatient> GetNewPatient()
        {
            return new IPDSharedDAL().GetNewPatient();
        }
        public List<InPatient> GetAdmittedPatientList()
        {
            return new IPDSharedDAL().GetAdmittedPatientList();
        }
        public List<InPatient> PatList()
        {
            return new IPDSharedDAL().PatList();
        }
        public List<InPatient> GetAdmittedAllPatList()
        {
            return new IPDSharedDAL().GetAdmittedAllPatList();
        }
        public List<InPatient> GetAdmDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedDAL().GetAdmDateWisePatList(fromDate, toDate);
        }
        public List<InPatient> GetDischargeDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedDAL().GetDischargeDateWisePatList(fromDate, toDate);
        }
        public List<InPatient> GetBedTransferDateWisePatList(DateTime fromDate, DateTime toDate)
        {
            return new IPDSharedDAL().GetBedTransferDateWisePatList(fromDate, toDate);
        }
        //================================IPD Doctor Setup======================================// 
        public short InsertIPDDoctors(IPDDoctor oIPDDOc)
        {
            return new IPDSharedDAL().InsertIPDDoctors(oIPDDOc);
        }

        public List<IPDDoctor> GetIPDDoctorsList()
        {
            return new IPDSharedDAL().GetIPDDoctorsList();
        }
        public List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID)
        {
            return new IPDSharedDAL().GetIPDVisitingFeeDetails(reg_ID);
        }

        public IPDDoctor GetDoctorsDetails(string DocID)
        {
            return new IPDSharedDAL().GetDoctorsDetails(DocID);
        }

        public Dictionary<string, string> GetIPDDoctorsDict(string dept, string unit)
        {
            Dictionary<string, string> odic = new Dictionary<string, string>();

            foreach (IPDDoctor i in new IPDSharedDAL().GetIPDDoctorsList_ByDept(dept, unit))
            {
                odic.Add(i.ID, i.Name);
            }
            return odic;
        }
        public List<InPatient> BedTransferPatList()
        {
            return new IPDSharedDAL().BedTransferPatList();
        }

    }
}
