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
    public class IPDPrescriptionBLL
    {
      /* public IPDDoctor GetDoctorsDetails(string DocID)
       {
           return new IPDPrescriptionDAL().GetDoctorsDetails(DocID);
       }*/
       public short SaveIPDPrescription(IPDPrescription prs)
       {
           return new IPDPrescriptionDAL().SaveIPDPrescription(prs);
       }
       public short EditIPDPrescription(IPDPrescription Iprs)
       {
           return new IPDPrescriptionDAL().EditIPDPrescription(Iprs);
       }

       public List<IPDPrescription> GetPrescribedDrugs(string regId)
       {
            return new IPDPrescriptionDAL().GetPrescribedDrugs(regId);
       }
       public List<IPDPrescription> GetPrescribedTests(string regId)
       {
           return new IPDPrescriptionDAL().GetPrescribedTests(regId);
       }

       public short SaveDischargeAdvices(IPDPrescription prs)
       {
            return new IPDPrescriptionDAL().SaveDischargeAdvices(prs);
       }

       public short IsDischargeAdvCreated(string regId)
       {
           return new IPDPrescriptionDAL().IsDischargeAdvCreated(regId);
       }
       public IPDPrescription GetDischargeAdvicesForEdit(string regId)
       {
           return new IPDPrescriptionDAL().GetDischargeAdvicesForEdit(regId);
       }

       public short EditDischargeAdvices(IPDPrescription Iprs)
       {
           return new IPDPrescriptionDAL().EditDischargeAdvices(Iprs);
       }

       public IPDPrescription GetIPDPrescriptionForEdit(string visit_no, string Reg_ID)
       {
           return new IPDPrescriptionDAL().GetIPDPrescriptionForEdit(visit_no, Reg_ID);
       }

       public short IsDrugReqDone(string visit_id, string drug_id)
       {
           return new IPDPrescriptionDAL().IsDrugReqDone(visit_id, drug_id);
       }
    }
}
