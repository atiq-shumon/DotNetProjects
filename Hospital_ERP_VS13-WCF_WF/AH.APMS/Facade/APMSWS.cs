using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AH.APMS.MODEL;
using AH.APMS.BLL;
using AH.HR.MODEL;
using AH.HR.BLL;
using AH.DUtility;
using AH.ORGMS.BLL;
using AH.PatReg.BLL;
using AH.PatReg.MODEL;
using AH.Shared.MODEL;
using AH.APPOPD.BLL;
using AH.OPD.BLL;
using AH.APPOPD.MODEL;

namespace AH.APMS.Facade
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "APMSWS" in both code and config file together.
    ////created by shabnam 31 Aug 2014
    public class APMSWS : IAPMSWS
    {
        //public short SaveDoctorWeekDays(DoctorWeekDays oWeekDays)
        //{
        //    return new ApmsSetupBLL().SaveDoctorWeekDays(oWeekDays);
        //}

        public Dictionary<string, string> GetDeptUnitDic(string deptgrp, string deptid)
        {
            return new AdministrationSetupBLL().GetDeptUnitDic(deptgrp, deptid);
        }
     
        public Dictionary<int, string> GetWeekDays()
        {
            return Utility.GetWeekDays();
        }

        //public short saveDoctorVSTcal(DoctorWeekDays apms)
        //{
        //    return new ApmsSetupBLL().saveDoctorVSTcal(apms);
        //}

        public List<DoctorWeekDays> GetDoctorVSTcal(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetDoctorVSTcal(deptId, unitId, doctorId, startDate, endDate);
        }

        //public short InsertAppointCust(AppointmentClient apms)
        //{
        //    return new ApmsSetupBLL().InsertAppointCust(apms);
        //}
        public short InsertOpdAppointment(OpdAppointment apms)
        {
            return new ApmsSetupBLL().InsertOpdAppointment(apms);
        }
        //public List<OpdAppointment> Get_View_Get_Opd_Appoint()
        //{
        //    return new ApmsSetupBLL().Get_View_Get_Opd_Appoint();
        //}
        public List<DoctorWeekDays> GetDayList(string doctorId)
        {
            return new ApmsSetupBLL().GetDayList(doctorId);
        }

        public List<DoctorWeekDays> GetDoctorWeekDays(string doctorID, string departmentId, string unitId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetDoctorWeekDays(doctorID, departmentId, unitId, startDate, endDate);
        }
        //03---Sept---2014
        public short SaveDoctorTiming(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().SaveDoctorTiming(apms);
        }
        //04----Sept---2014
        public List<DoctorWeekDays> GetDoctorDutyTiming(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetDoctorDutyTiming(deptId, unitId, doctorId, startDate, endDate);
        }

        //10--Sept---2014
        public List<OpdAppointment> GetPatientName(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetPatientName(deptId, unitId, doctorId, startDate, endDate);
        }
        public List<OpdAppointment> GetPatientInfo(string deptId, string unitId, string doctorId, string tokenNo, string appointDate)
        {
            return new AppointmentBLL().GetPatientInfo(deptId, unitId, doctorId, tokenNo, appointDate);
        }

        public short UpdatePatientInformation(OpdAppointment apms)
        {
            return new ApmsSetupBLL().UpdatePatientInformation(apms);
        }
        public short DeleteDoctorTiming(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().DeleteDoctorTiming(apms);
        }

        ///=====================
        public Dictionary<string, string> GetOPDDoctorsDict(string deptID, string UnitID)
        {
            return new OPDBLL().GetOPDDoctorsDict(deptID, UnitID);
        }
       
        public Dictionary<string, string> GetDepartmentsetup(string type, string deptgr)
        {
            return new OPDBLL().GetDepartmentsetupDic (type, deptgr);
        }

        //========================Patregistration=============//
        public List<Patient> GetPatientDetailsAppointment(string parameter)
        {
            return new PatientRegistrationBLL().GetPatientDetailsAppointment(parameter);
        }
        //===============//

        //=======================APPOPD===============//////////
        public List<OpdAppointment> Appointment(string hcn)
        {
            return new AppointmentBLL().Appointment(hcn);
        }

        public List<OPDDoctor> GetOPDDoctors()
        {
            return new OPDDoctorsBLL().GetOPDDoctors();
        }
        public List<OpdAppointment> GetPatientListForHcn()
        {
            return new AppointmentBLL().GetPatientListForHcn();
        }
        public List<DoctorWeekDays> GetTodaysDoctorList()
        {
            return new ApmsSetupBLL().GetTodaysDoctorList();
        }
        public short DeleteDoctorSchedule(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().DeleteDoctorSchedule(apms);
        }
        public short ModifyDoctorCalendar(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().ModifyDoctorCalendar(apms);
        }
        public int GetDoctorTimingInterval(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetDoctorTimingInterval(deptId, unitId, doctorId, startDate, endDate);
        }
        public List<OpdAppointment> GetAppointedDate(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            return new ApmsSetupBLL().GetAppointedDate(deptId, unitId, doctorId, startDate, endDate);
        }
        public short CheckForAppointment(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().CheckForAppointment(apms);
        }
        public short VerifyDoctorSchedule(DoctorWeekDays apms)
        {
            return new ApmsSetupBLL().VerifyDoctorSchedule(apms);
        }
        public List<OpdAppointment> SingleDayPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupBLL().SingleDayPatientList(deptId, unitId, doctorId, startDate);
        }
        public List<OpdAppointment> PrescribePatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupBLL().PrescribePatientList(deptId, unitId, doctorId, startDate);
        }
        public List<OpdAppointment> TicketOkPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            return new ApmsSetupBLL().TicketOkPatientList(deptId, unitId, doctorId, startDate);
        }
    }
}
