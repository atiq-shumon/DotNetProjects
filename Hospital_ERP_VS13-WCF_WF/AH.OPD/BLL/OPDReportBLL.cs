using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.DLayer.OPD;
using AH.HR.MODEL;
using AH.OPD.MODEL;
using AH.OPD.DAL;
using AH.Shared.MODEL;

namespace AH.OPD.BLL
{
    public class OPDReportBLL
    {
        //Fauzul 28 Jun 2014
        public List<OPDDoctorCallQ> GetsOPDDoctorName()
        {
            return new OpdTicketReportDAL().GetsOPDDoctorName();
        }
        //Fauzul 28 Jun 2014
        public List<OPDTicketRO> GetsOPDDocRoomNo(string RoomNo, string DocID)
        {
            return new OpdTicketReportDAL().GetsOPDDocRoomNo(RoomNo, DocID);
        }
        //Fauzul 28 Jun 2014
        public List<OPDTicketRO> ChangePatientStatus(string TicketNo, string RoomNO, string Doc_ID)
        {
            return new OpdTicketReportDAL().ChangePatientStatus(TicketNo, RoomNO, Doc_ID);
        }
        public List<OPDTicketRO> GetOPDTicketDetails( string ParamDateFrom, string ParamDateTo)
        {
            return new OpdTicketReportDAL().GetOPDTicketDetails( ParamDateFrom,  ParamDateTo);
        }
        public List<OPDTicketRO> GetOPDTicketMR(string TicketNo)
        {
            return new OpdTicketReportDAL().GetOPDTicketMR(TicketNo);
        }
        public List<OPDTicketRO> GetOPDDepartment(string DepartmentName, string ParamDateFrom, string ParamDateTo)
        {
            return new OpdTicketReportDAL().GetOPDDepartment(DepartmentName, ParamDateFrom, ParamDateTo);
        }
        public List<OPDTicketRO> GetOPDMRDoctor(string doctorid, string deapartmentname, string ParamDateFrom, string ParamDateTo)
        {
            return new OpdTicketReportDAL().GetOPDMRDoctor( doctorid,  deapartmentname,  ParamDateFrom,  ParamDateTo);
        }
        public List<OPDTicketRO> GetsOPD()
        {
            return new OpdTicketReportDAL().GetsOPD();
        }
        //public List<OPDTicketRO> GetsOPD(string TicketNo)
        //{
        //    return new OpdTicketReportDAL().GetsOPD(TicketNo);
        //}
        public List<Department> GetsDepartmentName()
        {
            return new OpdTicketReportDAL().GetsDepartmentName();
        }
        public List<Doctor> GetDoctorNames()
        {
            return new OpdTicketReportDAL().GetDoctorNames();
        }
        public List<OPDPrescriptionReportNewRO> GetOPDPrescription(string wherecondition)
        {
            return new OpdPrescriptionReportDAL().GetOPDPrescription(wherecondition);
        }
        //public Medicine SaveMedicine(Medicine oMedicine)
        //{
        //    return new OpdPrescriptionReportDAL().SaveMedicine(oMedicine);
        //}
        public List<PatHistoryTree> GetsTree(string HCN)
        {
            return new OpdTicketReportDAL().GetsTree(HCN);
        }

        public List<OPDTicketRO> GetOPDRefundTicketMR(string TicketNo)
        {
            return new OpdTicketReportDAL().GetOPDRefundTicketMR(TicketNo);
        }

        public List<OPDTicketRO> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo)
     //  public  List<AccountsPayment> GetOPDVoucher(string user_id, string ParamDateFrom, string ParamDateTo)
        {
            return new OpdTicketReportDAL().GetOPDVoucher(user_id, ParamDateFrom, ParamDateTo);
        }

        public List<OPDTicketRO> GetOPDCollSummary(string ParamDateFrom, string ParamDateTo)
        {
            return new OpdTicketReportDAL().GetOPDCollSummary(ParamDateFrom,ParamDateTo);
        }

        public List<OPDTicketRO> GetOPDVisitedPatList(string dept_id, string unit_id, string doc_id)
        {
            return new OpdTicketReportDAL().GetOPDVisitedPatList(dept_id, unit_id, doc_id);
        }
        public short ChangeTktStatusFrmDoc(string ticketNo, string DocID)
        {
            return new OpdTicketReportDAL().ChangeTktStatusFrmDoc(ticketNo, DocID);
        }
       
    }
}
