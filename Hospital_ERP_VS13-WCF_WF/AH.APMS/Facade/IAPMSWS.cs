using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.APMS.MODEL;
using AH.PatReg.MODEL;
using AH.APPOPD.MODEL;
using AH.Shared.MODEL;

namespace AH.APMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAPMSWS" in both code and config file together.
    ////created by shabnam 10 Aug 2014
    [ServiceContract]
    public interface IAPMSWS
    {
        //[OperationContract]
        //short SaveDoctorWeekDays(DoctorWeekDays oWeekDays);

      
        [OperationContract]
        Dictionary<string, string> GetDepartmentsetup(string type, string deptgr);

        [OperationContract]
        Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid);

     
        [OperationContract]
        Dictionary<int, string> GetWeekDays();

        //[OperationContract]
        //short saveDoctorVSTcal(DoctorWeekDays apms);

        ////created by shabnam 10 Aug 2014
        [OperationContract]
        List<DoctorWeekDays> GetDoctorVSTcal(string deptId, string unitId, string doctorId, string startDate, string endDate);

        ////created by shabnam 10 Aug 2014

        //[OperationContract]
     
        [OperationContract]
        short InsertOpdAppointment(OpdAppointment apms);

        //[OperationContract]
        //List<OpdAppointment> Get_View_Get_Opd_Appoint();

        [OperationContract]
        List<DoctorWeekDays> GetDayList(string doctorId);

        [OperationContract]
        List<DoctorWeekDays> GetDoctorWeekDays(string doctorID, string departmentId, string unitId, string startDate, string endDate);

        //03---sept-2014
        [OperationContract]
        short SaveDoctorTiming(DoctorWeekDays apms);

        //04---sept-2014
        [OperationContract]
        List<DoctorWeekDays> GetDoctorDutyTiming(string deptId, string unitId, string doctorId, string startDate, string endDate);

        //10----Sept---2014
        [OperationContract]
        List<OpdAppointment> GetPatientName(string deptId, string unitId, string doctorId, string startDate, string endDate);

        [OperationContract]
        List<OpdAppointment> GetPatientInfo(string deptId, string unitId, string doctorId, string tokenNo, string appointDate);

        [OperationContract]
        short UpdatePatientInformation(OpdAppointment apms);

        [OperationContract]
        short DeleteDoctorTiming(DoctorWeekDays apms);

        [OperationContract]
        Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID);

        [OperationContract]
        List<Patient> GetPatientDetailsAppointment(string parameter);
        [OperationContract]
        List<OpdAppointment> Appointment(string hcn);

        [OperationContract]
        List<OPDDoctor> GetOPDDoctors();

        [OperationContract]
        List<OpdAppointment> GetPatientListForHcn();

        [OperationContract]
        List<DoctorWeekDays> GetTodaysDoctorList();

        [OperationContract]
        short DeleteDoctorSchedule(DoctorWeekDays apms);

        [OperationContract]
        short ModifyDoctorCalendar(DoctorWeekDays apms);
         [OperationContract]
        int GetDoctorTimingInterval(string deptId, string unitId, string doctorId, string startDate, string endDate);

        [OperationContract]
        List<OpdAppointment> GetAppointedDate(string deptId, string unitId, string doctorId, string startDate, string endDate);

        [OperationContract]
        short CheckForAppointment(DoctorWeekDays apms);

        [OperationContract]
        short VerifyDoctorSchedule(DoctorWeekDays apms);

        [OperationContract]
        List<OpdAppointment> SingleDayPatientList(string deptId, string unitId, string doctorId, string startDate);

        [OperationContract]
        List<OpdAppointment> PrescribePatientList(string deptId, string unitId, string doctorId, string startDate);

        [OperationContract]
        List<OpdAppointment> TicketOkPatientList(string deptId, string unitId, string doctorId, string startDate);
    }
}
