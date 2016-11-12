using AH.NWMS.DAL;
using AH.NWMS.MODEL;
using AH.PRMS.MODEL;
using AH.DRUGS.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AH.OPD.MODEL;

namespace AH.NWMS.BLL
{
    public class NWMSBLL
    {
        public List<DrugDose> GetDrugs(string age, string name, string drugID)
        {
            return new NWMSDAL().GetDrugs(age, name, drugID);
        }

        public short SaveNurseRequisition(NurseRequisition nrq)
        {
            return new NWMSDAL().SaveNurseRequisition(nrq);
        }

        public short ChangeBedStatus(Bed bdst)
        {
            return new NWMSDAL().ChangeBedStatus(bdst);
        }

        public List<NWMSReceiveRequisition> ReceiveRequisition(string regId)
        {
            return new NWMSDAL().ReceiveRequisition(regId);
        }
        public List<NWMSReceiveRequisition> ReceiveReqTest(string regId)
        {
            return new NWMSDAL().ReceiveReqTest(regId);
        }

        public short CheckIssueIDforRcv(string issue_id)
        {
            return new NWMSDAL().CheckIssueIDforRcv(issue_id);
        }
        public short VerifyIssueID(string issue_id, string Reg_id)
        {
            return new NWMSDAL().VerifyIssueID(issue_id, Reg_id);
        }

        public short SaveDrugReqRcv(NWMSReceiveRequisition DrugRcv)
        {
            return new NWMSDAL().SaveDrugReqRcv(DrugRcv);
        }
        public short CancelIPDDrugs(NurseRequisition nrq)
        {
            return new  NWMSDAL().CancelIPDDrugs(nrq);
        }
        public List<DrugDose> GetAllProvidedDrugs(string regID)
        {
            return new NWMSDAL().GetAllProvidedDrugs(regID);
        }

        public short IssueFromNurseStn(NurseRequisition nrq)
        {
            return new NWMSDAL().IssueFromNurseStn(nrq);
        }



     /*  public short InsertIPDDoctors(IPDDoctor oIPDDOc)
        {
            return new NWMSDAL().InsertIPDDoctors(oIPDDOc);
        }

        public List<IPDDoctor> GetIPDDoctorsList()
        {
            return new NWMSDAL().GetIPDDoctorsList();
        }
        public List<IPDDoctor> GetIPDVisitingFeeDetails(string reg_ID)
        {
            return new NWMSDAL().GetIPDVisitingFeeDetails(reg_ID);
        }
       

        public Dictionary<string, string> GetIPDDoctorsDict(string dept, string unit)
        {
            Dictionary<string, string> odic = new Dictionary<string, string>();

            foreach (IPDDoctor i in new NWMSDAL().GetIPDDoctorsList_ByDept(dept, unit))
            {
                odic.Add(i.ID, i.Name);
            }
            return odic;
        }*/

     /*  public OPDDoctorCallQ GetPatHealthInfo(string Hcn)
        {
            return new NWMSDAL().GetPatHealthInfo(Hcn);
        }*/
    }
}
