using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.Shared.MODEL;
using AH.DUtility;
using AH.APMS.DAL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.APMS.MODEL;
using AH.APPOPD.MODEL;


namespace AH.APMS.BLL
{
    public class ApmsSetupBLL
    {
        //public short SaveDoctorWeekDays(DoctorWeekDays oWeekDays)
        //{
        //    return new ApmsSetupDAL().SaveDoctorWeekDays(oWeekDays);
        //}
        //public List<DoctorWeekDays> GetDoctorWeekDays()
        //{
        //    return new ApmsSetupDAL().GetDoctorWeekDays();
        //}

        //public short saveDoctorVSTcal(DoctorWeekDays apms)
        //{
        //    return new ApmsSetupDAL().saveDoctorVSTcal(apms);
        //}

        public List<DoctorWeekDays> GetDoctorVSTcal(string deptId, string unitId, string doctorId,string startDate,string endDate)
        {
            return new ApmsSetupDAL().GetDoctorVSTcal(deptId, unitId, doctorId, startDate, endDate);
        }

        //created by shabnam 10 Aug 2014
        //public short InsertAppointCust(AppointmentClient apms)
        //{
        //    return new ApmsSetupDAL().InsertAppointCust(apms);
        //}
        public short InsertOpdAppointment(OpdAppointment apms)
        {
            return new ApmsSetupDAL().InsertOpdAppointment(apms);
        }
        //public List<OpdAppointment> Get_View_Get_Opd_Appoint()
        //{
        //    return new ApmsSetupDAL().Get_View_Get_Opd_Appoint();
        //}
        public List<DoctorWeekDays> GetDayList(string doctorId)
        {
            return new ApmsSetupDAL().GetDayList(doctorId);
        }

        public List<DoctorWeekDays> GetDoctorWeekDays(string doctorID, string departmentId, string unitId, string startDate, string endDate)
        {
            return new ApmsSetupDAL().GetDoctorWeekDays(doctorID, departmentId, unitId, startDate, endDate);
        }
        //03-Sept-2014
        public short SaveDoctorTiming(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().SaveDoctorTiming(apms);
        }
        //04--Sept--2014
        public List<DoctorWeekDays> GetDoctorDutyTiming(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupDAL().GetDoctorDutyTiming(deptId, unitId, doctorId, startDate, endDate);
        }

        //10----Sept-----2014
        public List<OpdAppointment> GetPatientName(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupDAL().GetPatientName(deptId, unitId, doctorId, startDate, endDate);
        }

        //public List<OpdAppointment> GetPatientInfo(string deptId, string unitId, string doctorId, string tokenNo, string appointDate)
        //{
        //    return new ApmsSetupDAL().GetPatientInfo(deptId, unitId, doctorId, tokenNo, appointDate);
        //}
        public short UpdatePatientInformation(OpdAppointment apms)
        {
            return new ApmsSetupDAL().UpdatePatientInformation(apms);
        }

        public short DeleteDoctorTiming(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().DeleteDoctorTiming(apms);
        }
        //public List<OpdAppointment> GetPatientListForHcn()
        //{
        //    return new ApmsSetupDAL().GetPatientListForHcn();
        //}
        public List<DoctorWeekDays> GetTodaysDoctorList()
        {
            return new ApmsSetupDAL().GetTodaysDoctorList();
        }
        public short DeleteDoctorSchedule(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().DeleteDoctorSchedule(apms);
        }
        public short ModifyDoctorCalendar(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().ModifyDoctorCalendar(apms);
        }
        public int GetDoctorTimingInterval(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupDAL().GetDoctorTimingInterval(deptId, unitId, doctorId, startDate, endDate);
        }
        public List<OpdAppointment> GetAppointedDate(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupDAL().GetAppointedDate(deptId, unitId, doctorId, startDate, endDate);
        }
        public short CheckForAppointment(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().CheckForAppointment(apms);
        }
        public short VerifyDoctorSchedule(DoctorWeekDays apms)
        {
            return new ApmsSetupDAL().VerifyDoctorSchedule(apms);
        }
        public List<OpdAppointment> SingleDayPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupDAL().SingleDayPatientList(deptId, unitId, doctorId, startDate);
        }
        public List<OpdAppointment> PrescribePatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupDAL().PrescribePatientList(deptId, unitId, doctorId, startDate);
        }
        public List<OpdAppointment> TicketOkPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupDAL().TicketOkPatientList(deptId, unitId, doctorId, startDate);
        }
               
    }
}
