using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.OracleManager;
using AH.Shared.MODEL;
using AH.DUtility;
using AH.APPOPD.MODEL;
using AH.APMS.MODEL;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using AH.HR.MODEL;
using System.Drawing;
using AH.Shared.UI;
//using AH.PatReg.MODEL;
namespace AH.APMS.DAL
{
    public class ApmsSetupDAL
    {
        private string connString = Utility.GetConnectionString(Utility.Module.APMS);
        string packageName = string.Empty;

        //public short SaveDoctorWeekDays(DoctorWeekDays apms)
        //{
        //    packageName = "AGH_APMS.pkg_apms_setup.SaveDoctorWeekdays";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
        //        new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
        //        new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
        //        new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input),
        //        new OracleParameter("p_week_day_no",OracleDbType.Varchar2,200,apms.WeekDayNO,ParameterDirection.Input),
        //        new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
        //        new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input), 
        //        new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

        //    };

        //    short i = DALHelper.Insert(connString, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];

        //    if ((OracleDecimal)prm.Value == 1)
        //        return 1;

        //    else
        //        return 0;

        //}

        public List<DoctorWeekDays> GetDoctorWeekDays(string doctorID, string departmentId, string unitId ,string startDate, string endDate)
        {
            string packageName = "pkg_apms_setup.Get_Doctor_WeekDays";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,departmentId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("startDate",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("endDate",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)
                      
            };
            return GetDoctorWeekDays(packageName, parameterList);
        }

        private List<DoctorWeekDays> GetDoctorWeekDays(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorWeekDays> oGrid = new List<DoctorWeekDays>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedureIDataReader(connString, packageName, parameterList);
            while (rdr.Read())
            {
                DoctorWeekDays oDoctorWeekDays = new DoctorWeekDays();
                oDoctorWeekDays.WeekDayName = rdr["WEEK_DAY_NO"].ToString();
                oGrid.Add(oDoctorWeekDays);
            }
            rdr.Close();
            return oGrid;
        }

        //public short saveDoctorVSTcal(DoctorWeekDays apms)
        //{
        //    packageName = "pkg_apms_setup.SaveDoctorVSTcal";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
        //        new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
        //        new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
        //        new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input),
        //        new OracleParameter("p_start_date",OracleDbType.Varchar2,20,apms.StartDate,ParameterDirection.Input),
        //        new OracleParameter("p_last_date",OracleDbType.Varchar2,20,apms.LastDate,ParameterDirection.Input),
        //        new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),              
        //        new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input),               
        //        new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

        //    };

      
        //    short i = DALHelper.Insert(connString, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];

        //    if ((OracleDecimal)prm.Value == 1)
        //        return 1;
        //    else if ((OracleDecimal)prm.Value == 2)
        //        return 2;
        //    else
        //        return 0;
        //}

        public List<DoctorWeekDays> GetDoctorVSTcal(string deptId, string unitId, string doctorId,string startDate,string endDate)
        {
               string packageName = "AGH_APMS.pkg_apms_setup.GetDoctorVSTcal";
               OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)

            };
           
            return GetDoctorVSTcal(packageName, parameterList);

        }

        private List<DoctorWeekDays> GetDoctorVSTcal(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorWeekDays> oListGrid = new List<DoctorWeekDays>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                DoctorWeekDays oDoctorWeekDays = new DoctorWeekDays();
                oDoctorWeekDays.VisitDate = (DateTime)rdr["VST_DATE"];
                oListGrid.Add(oDoctorWeekDays);
            
            }
            rdr.Close();
             return oListGrid;

        }

         //Created by shabnam 10 Aug 2014
        //public short InsertAppointCust(AppointmentClient apms)
        //{
        //    packageName = "pkg_apms_setup.INSERT_T_APPOINT_CUST";
        //    OracleParameter[] parameterList = new OracleParameter[]{
        //        new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
        //        new OracleParameter("p_hcn",OracleDbType.Varchar2,15,apms.Patient.HCN,ParameterDirection.Input),
        //        new OracleParameter("p_pat_name",OracleDbType.Varchar2,250,apms.Patient.Name,ParameterDirection.Input),
        //        new OracleParameter("p_booked_by",OracleDbType.Varchar2,250,apms.BookedBy,ParameterDirection.Input),
        //        new OracleParameter("p_relation_with_pat",OracleDbType.Varchar2,3,apms.Patient.RelationWithGuardian,ParameterDirection.Input),
        //        new OracleParameter("p_addr",OracleDbType.Varchar2,500,apms.Patient.Permanent_H_R_B,ParameterDirection.Input),
        //        new OracleParameter("p_gender",OracleDbType.Char,1,apms.Patient.Sex,ParameterDirection.Input),
        //        new OracleParameter("p_age_y",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Year,ParameterDirection.Input),
        //        new OracleParameter("p_age_m",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Month,ParameterDirection.Input),
        //        new OracleParameter("p_age_d",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Day,ParameterDirection.Input),
        //        new OracleParameter("p_phone",OracleDbType.Varchar2,15,apms.Patient.HomePhone,ParameterDirection.Input),
        //        new OracleParameter("p_email",OracleDbType.Varchar2,250,apms.Patient.Email,ParameterDirection.Input),
        //        new OracleParameter("p_mobile",OracleDbType.Varchar2,15,apms.Patient.CellPhone,ParameterDirection.Input),
        //        new OracleParameter("p_country",OracleDbType.Varchar2,10,apms.Patient.Country,ParameterDirection.Input),              
        //        new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
        //        new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input),                
        //        new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
        //        new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
        //        new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

        //    };

        //    short i = DALHelper.Insert(connString, packageName, parameterList);
        //    OracleParameter prm = parameterList[0];
        //    if ((OracleDecimal)prm.Value == 1)
        //        return 1;
        //    else return 0;

        //}

        public short InsertOpdAppointment(OpdAppointment apms)
        {
            packageName = "AGH_APMS.pkg_apms_setup.INSERT_T_OPD_APPOINTMENTS";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_hcn",OracleDbType.Varchar2,15,apms.Patient.HCN,ParameterDirection.Input),
                new OracleParameter("p_pat_name",OracleDbType.Varchar2,250,apms.Patient.Name,ParameterDirection.Input),
                new OracleParameter("p_booked_by",OracleDbType.Varchar2,250,apms.Patient.GuardianName,ParameterDirection.Input),
                new OracleParameter("p_relation_with_pat",OracleDbType.Varchar2,3,apms.Patient.RelationWithGuardian,ParameterDirection.Input),
                new OracleParameter("p_addr",OracleDbType.Varchar2,500,apms.Patient.Permanent_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_gender",OracleDbType.Char,1,apms.Patient.Sex,ParameterDirection.Input),
                new OracleParameter("p_age_y",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Year,ParameterDirection.Input),
                new OracleParameter("p_age_m",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Month,ParameterDirection.Input),
                new OracleParameter("p_age_d",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Day,ParameterDirection.Input),
                new OracleParameter("p_phone",OracleDbType.Varchar2,15,apms.Patient.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_email",OracleDbType.Varchar2,200,apms.Patient.Email,ParameterDirection.Input),
                new OracleParameter("p_mobile",OracleDbType.Varchar2,15,apms.Patient.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,10,apms.Patient.Country,ParameterDirection.Input),
                new OracleParameter("p_allow_auto_notification",OracleDbType.Char,1,apms.AllowAutonotification,ParameterDirection.Input), 
                new OracleParameter("p_app_type",OracleDbType.Varchar2,1,apms.AppointmentType,ParameterDirection.Input),
                new OracleParameter("p_app_mode",OracleDbType.Varchar2,1,apms.AppointmentMode,ParameterDirection.Input),
                new OracleParameter("p_booking_type",OracleDbType.Varchar2,3,apms.BookingType,ParameterDirection.Input),
                new OracleParameter("p_visit_type",OracleDbType.Varchar2,3,apms.VisitType,ParameterDirection.Input),
                new OracleParameter("p_visitor_type",OracleDbType.Varchar2,3,apms.VisitorType,ParameterDirection.Input),
                new OracleParameter("p_batch_id",OracleDbType.Varchar2,3,apms.BatchID,ParameterDirection.Input),
                new OracleParameter("p_package_id",OracleDbType.Varchar2,10,apms.PackageID,ParameterDirection.Input),
                new OracleParameter("p_corporate_id",OracleDbType.Varchar2,30,apms.Patient.CorporateID,ParameterDirection.Input),
                new OracleParameter("p_app_status",OracleDbType.Char,1,apms.Patient.Status,ParameterDirection.Input),
                new OracleParameter("p_status_change_cause",OracleDbType.Varchar2,250,apms.StatusChangeCause,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
              //  new OracleParameter("p_completion_status",OracleDbType.Char,1,apms.CompelitionStatus,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input),
                new OracleParameter("p_service_id",OracleDbType.Varchar2,10,apms.ServiceID,ParameterDirection.Input),
                new OracleParameter("p_appoint_date",OracleDbType.Varchar2,apms.AppointDate,ParameterDirection.Input),
                new OracleParameter("p_approx_s_time",OracleDbType.Varchar2,15,apms.ApproxSTime,ParameterDirection.Input),
                new OracleParameter("p_approx_e_time",OracleDbType.Varchar2,15,apms.ApproxETime,ParameterDirection.Input),
                new OracleParameter("p_token_no",OracleDbType.Varchar2,15,apms.TokenNo,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),             
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input),                                             
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else if ((OracleDecimal)prm.Value == 2)
                return 2;
            else return 0;

        }

        //public List<OpdAppointment> Get_View_Get_Opd_Appoint()
        //{
        //    string packageName = "PKG_APMS_SETUP_TEST.Get_View_Get_Opd_Appoint";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
        //        };
        //    return GetViewOpdAppoint(packageName, parameterList);
        //}

        //public List<OpdAppointment> TEST()
        //{
        //    string packageName = "PKG_APMS_SETUP_TEST.Get_View_Get_Opd_Appoint";
        //    OracleParameter[] parameterList = new OracleParameter[]
        //        {
        //            new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)
        //        };
        //    return GetViewOpdAppoint(packageName, parameterList);
        //}

        //private List<OpdAppointment> CreateObjects(IDataReader oReader)
        //{
        //    List<OpdAppointment> oOpdAppointments = new List<OpdAppointment>();
        //    NullHandler oHandler = new NullHandler(oReader);
        //    while (oReader.Read())
        //    {
        //        OpdAppointment oItem = CreateObject(oHandler);
        //        oOpdAppointments.Add(oItem);
        //    }
        //    return oOpdAppointments;
        //}

        //private OpdAppointment CreateObject(NullHandler oReader)
        //{
        //    OpdAppointment oOpdAppointment = new OpdAppointment();
        //    oOpdAppointment = MapObject(oReader);
        //    return oOpdAppointment;
        //}

        //private OpdAppointment MapObject(NullHandler oReader)
        //{
        //    OpdAppointment oOpdAppointment = new OpdAppointment();
        //    //oOpdAppointment.AppointmentClient.Patient.Name = oReader.GetString("PAT_NAME");
        //    //oOpdAppointment.AppointmentTokenNo = oReader.GetString("APP_TOKEN_NO");
        //    //oOpdAppointment.AppointDate = oReader.GetDateTime("APPOINT_DATE");
        //    //oOpdAppointment.AppointmentTokenNo = oReader.GetString("APP_TOKEN_NO");
        //    //oOpdAppointment.AppointmentTokenNo = oReader.GetString("APP_TOKEN_NO");
        //    //oOpdAppointment.ApproxSTime = oReader.GetDateTime("APPROX_S_TIME");
        //    //oOpdAppointment.ApproxETime = oReader.GetDateTime("APPROX_E_TIME");   
           
        //    return oOpdAppointment;
        //}


        //private List<OpdAppointment> GetViewOpdAppoint(string packageName, OracleParameter[] parameterList)
        //{
        //    List<OpdAppointment> OpdAppoints = new List<OpdAppointment>();
        //    IDataReader reader = null;
        //    try
        //    {
        //        reader = DALHelper.ExecuteProcedure(connString, packageName, parameterList);
        //        if (reader.FieldCount > 0)
        //        {
        //            OpdAppoints = CreateObjects(reader);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EntryParameter oEP = new EntryParameter();
        //        throw new Exception(e.Message);
        //    }

        //    return OpdAppoints;
        //}

        public List<DoctorWeekDays> GetDayList(string doctorId)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.Get_Day_List";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input)
            };

            return GetDayList(packageName, parameterList);
        }


        public List<DoctorWeekDays> GetDayList(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorWeekDays> oDays = new List<DoctorWeekDays>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                  DoctorWeekDays oDoctorWeekDays = new DoctorWeekDays();
                  oDoctorWeekDays.WeekDayName = (string)rdr["WEEK_DAY_NO"];
                  oDays.Add(oDoctorWeekDays);
            }
            rdr.Close();
            return oDays;

        }

        //03----Sept----2014 

        public short VerifyDoctorSchedule(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.VerifyDoctorSchedule";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 
                new OracleParameter("p_start_date",OracleDbType.Varchar2,20,apms.StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,20,apms.LastDate,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else
                return 0;

        }

        public short SaveDoctorTiming(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.Doctor_Duty_Timing";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 

                new OracleParameter("p_start_date",OracleDbType.Varchar2,20,apms.StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,20,apms.LastDate,ParameterDirection.Input),
                new OracleParameter("p_doctor_timing",OracleDbType.Varchar2,30000,apms.DoctorTiming,ParameterDirection.Input), 
              
           
                new OracleParameter("p_service_id",OracleDbType.Varchar2,5,apms.ServiceId,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input), 
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;

            //if ((OracleDecimal)prm.Value == 2)
            //    return 2;
            else
                return 0;

        }

        //04---Sept--2014


        public List<DoctorWeekDays> GetDoctorDutyTiming(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetDoctorDutyTiming";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)

            };

            return GetDoctorDutyTiming(packageName, parameterList);

        }

        private List<DoctorWeekDays> GetDoctorDutyTiming(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorWeekDays> oListGrid = new List<DoctorWeekDays>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                DoctorWeekDays oDoctorWeekDays = new DoctorWeekDays();
                oDoctorWeekDays.VisitDate = (DateTime)rdr["VST_DATE"];
                oDoctorWeekDays.StartTime = (string)rdr["AppoinTime"];
                oDoctorWeekDays.Interval = Convert.ToInt32(rdr["APPOINT_INTERVAL"]); 
                oListGrid.Add(oDoctorWeekDays);
            }
            rdr.Close();
            return oListGrid;

        }

        //09----Sept-----2014


        public List<OpdAppointment> GetPatientName(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetPatientName";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)

            };

            return GetPatientName(packageName, parameterList);

        }
        public List<OpdAppointment> SingleDayPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.SingleDayPatientList";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input)
                
            };

            return GetPatientName(packageName, parameterList);

        }
        public List<OpdAppointment> PrescribePatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.PrescribePatientList";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input)
                
            };

            return GetPatientName(packageName, parameterList);

        }

        public List<OpdAppointment> TicketOkPatientList(string deptId, string unitId, string doctorId, string startDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.TicketOkPatientList";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input)
                
            };

            return GetPatientName(packageName, parameterList);

        }
        private List<OpdAppointment> GetPatientName(string packageName, OracleParameter[] parameterList)
        {
            List<OpdAppointment> oListGrid = new List<OpdAppointment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                OpdAppointment oOpdPat = new OpdAppointment();
                oOpdPat.AppointDate = rdr["appoint_date"].ToString();
                oOpdPat.ApproxSTime = (string)rdr["APPROX_S_TIME"];
                Patient oPat = new Patient();
                oPat.Name = (string)rdr["PAT_NAME"];
                oOpdPat.Patient = oPat;
                oOpdPat.TokenNo = (string)rdr["APP_TOKEN_NO"];
                oListGrid.Add(oOpdPat);

            }
            rdr.Close();
            return oListGrid;

        }

        public short UpdatePatientInformation(OpdAppointment apms)
        {
            packageName = "AGH_APMS.pkg_apms_setup.UpdatePatientInformation";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_token_no",OracleDbType.Varchar2,30,apms.TokenNo,ParameterDirection.Input),
                new OracleParameter("p_appoint_date",OracleDbType.Varchar2,30,apms.AppointDate,ParameterDirection.Input),
                new OracleParameter("p_visitor_type",OracleDbType.Varchar2,3,apms.VisitorType,ParameterDirection.Input),
                new OracleParameter("p_pat_name",OracleDbType.Varchar2,250,apms.Patient.Name,ParameterDirection.Input),
                new OracleParameter("p_addr",OracleDbType.Varchar2,500,apms.Patient.Permanent_H_R_B,ParameterDirection.Input),
                new OracleParameter("p_gender",OracleDbType.Char,1,apms.Patient.Sex,ParameterDirection.Input),
                new OracleParameter("p_age_y",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Year,ParameterDirection.Input),
                new OracleParameter("p_age_m",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Month,ParameterDirection.Input),
                new OracleParameter("p_age_d",OracleDbType.Varchar2,4,apms.Patient.AgeBreakDown.Day,ParameterDirection.Input),
                new OracleParameter("p_phone",OracleDbType.Varchar2,15,apms.Patient.HomePhone,ParameterDirection.Input),
                new OracleParameter("p_email",OracleDbType.Varchar2,200,apms.Patient.Email,ParameterDirection.Input),
                new OracleParameter("p_mobile",OracleDbType.Varchar2,15,apms.Patient.CellPhone,ParameterDirection.Input),
                new OracleParameter("p_country",OracleDbType.Varchar2,10,apms.Patient.Country,ParameterDirection.Input),  
                new OracleParameter("p_app_status",OracleDbType.Char,1,apms.Patient.Status,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),             
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input),                                             
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),         
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input),

            };

            short i = DALHelper.Update(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else return 0;

        }


        //========21----Sept-----2014============/////

        public short DeleteDoctorTiming(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.DeleteDoctorTiming";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 
                new OracleParameter("p_appoint_date",OracleDbType.Varchar2,30,apms.StartDate,ParameterDirection.Input),
                new OracleParameter("p_start_time",OracleDbType.Varchar2,15,apms.StartTime,ParameterDirection.Input),
                new OracleParameter("p_end_time",OracleDbType.Varchar2,15,apms.EndTime,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Delete(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;

            else if ((OracleDecimal)prm.Value == 2)
                return 2;
            else
                return 0;

        }
        public List<DoctorWeekDays> GetTodaysDoctorList()
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetTodayDoctorList";
            OracleParameter[] parameterList = new OracleParameter[]
            {
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output)            
            };

            return GetTodaysDoctorList(packageName, parameterList);
        }
        public List<DoctorWeekDays> GetTodaysDoctorList(string packageName, OracleParameter[] parameterList)
        {
            List<DoctorWeekDays> oDays = new List<DoctorWeekDays>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
                DoctorWeekDays oDoctorWeekDays = new DoctorWeekDays();
                oDoctorWeekDays.WeekDayName = (string)rdr["dayName"];

                Department oDept = new Department();
                oDept.DepartmentID = (string)rdr["DEPT_ID"];
                oDept.DepartmentTitle = (string)rdr["DEPT_title"];
                oDoctorWeekDays.Department = oDept;

                DepartmentUnit deptUnit = new DepartmentUnit();
                deptUnit.UnitId = (string)rdr["Unit_ID"];
                deptUnit.UnitTitle = (string)rdr["Unit_title"];
                oDoctorWeekDays.DepartmentUnit = deptUnit;

                Doctor oDoctor = new Doctor();
                oDoctor.ID = (string)rdr["DOCTOR_ID"];
                oDoctor.Name = (string)rdr["DOCName"];//(rdr["DOCTORNAME"] == DBNull.Value ? string.Empty : (string)rdr["DOCTORNAME"]);
                oDoctorWeekDays.Doctor = oDoctor;
                oDoctorWeekDays.VisitDate = (DateTime)rdr["VST_DATE"];

                oDoctorWeekDays.StartTime = (string)rdr["APPOINT_START"];
                oDoctorWeekDays.EndTime = (string)rdr["APPOINT_END"];
                oDays.Add(oDoctorWeekDays);
            }
            rdr.Close();
            return oDays;

        }
        public short DeleteDoctorSchedule(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.DeleteDoctorScheduling";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 

                new OracleParameter("p_start_date",OracleDbType.Varchar2,20,apms.StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,20,apms.LastDate,ParameterDirection.Input),
                new OracleParameter("p_doctor_timing",OracleDbType.Varchar2,10000,apms.DoctorTiming,ParameterDirection.Input), 
              
           
                new OracleParameter("p_service_id",OracleDbType.Varchar2,5,apms.ServiceId,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input), 
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else if ((OracleDecimal)prm.Value == 2)
                return 2;
            else
                return 0;
        }

        public short ModifyDoctorCalendar(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.UpdateDoctorCalendar";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 

                new OracleParameter("p_start_date",OracleDbType.Varchar2,20,apms.StartDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,20,apms.LastDate,ParameterDirection.Input),
                new OracleParameter("p_doctor_timing",OracleDbType.Varchar2,10000,apms.DoctorTiming,ParameterDirection.Input), 
              
           
                new OracleParameter("p_service_id",OracleDbType.Varchar2,5,apms.ServiceId,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input), 
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;
            else if ((OracleDecimal)prm.Value == 2)
                return 2;
            else
                return 0;

        }
        public int GetDoctorTimingInterval(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetDoctorTimingInterval";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output), 
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)

            };
       
            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];
            int interval = (int)((OracleDecimal)prm.Value);
            return interval;
        }

        public List<OpdAppointment> GetAppointedDate(string deptId, string unitId, string doctorId, string startDate, string endDate)
        {
            string packageName = "AGH_APMS.pkg_apms_setup.GetAppointedDate";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("Ref",OracleDbType.RefCursor,DBNull.Value,ParameterDirection.Output), 
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,deptId,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,unitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,20,doctorId,ParameterDirection.Input),
                new OracleParameter("p_start_date",OracleDbType.Varchar2,12,startDate,ParameterDirection.Input),
                new OracleParameter("p_last_date",OracleDbType.Varchar2,12,endDate,ParameterDirection.Input)
            };
            return GetAppointedDate(packageName, parameterList);         
        }
        public List<OpdAppointment> GetAppointedDate(string packageName, OracleParameter[] parameterList)
        {
            List<OpdAppointment> oDays = new List<OpdAppointment>();
            OracleDataReader rdr;
            rdr = DALHelper.ExecuteProcedure(connString, packageName, parameterList);

            while (rdr.Read())
            {
             OpdAppointment oOpdPat = new OpdAppointment();
                oOpdPat.AppointDate = ((DateTime)rdr["appoint_date"]).ToString("dd-mm-yyyy");
                oDays.Add(oOpdPat);   
            }
            rdr.Close();
            return oDays;

        }

        public short CheckForAppointment(DoctorWeekDays apms)
        {
            packageName = "pkg_apms_setup.SAVE_T_TEMP_APP";
            OracleParameter[] parameterList = new OracleParameter[]{
                new OracleParameter("p_e_rows",OracleDbType.Int32,5,null,ParameterDirection.Output),
                new OracleParameter("p_dept_id",OracleDbType.Varchar2,10,apms.Department.DepartmentID,ParameterDirection.Input),
                new OracleParameter("p_unit_id",OracleDbType.Varchar2,6,apms.DepartmentUnit.UnitId,ParameterDirection.Input),
                new OracleParameter("p_doctor_id",OracleDbType.Varchar2,30,apms.Doctor.ID,ParameterDirection.Input), 
                new OracleParameter("p_doctor_timing",OracleDbType.Varchar2,10000,apms.DoctorTiming,ParameterDirection.Input),
              //  new OracleParameter("p_interval",OracleDbType.Int32,10,apms.Interval,ParameterDirection.Input),
                new OracleParameter("p_service_id",OracleDbType.Varchar2,5,apms.ServiceId,ParameterDirection.Input),
                new OracleParameter("p_entry_by",OracleDbType.Varchar2,20,apms.EntryParameter.EntryBy,ParameterDirection.Input),
                new OracleParameter("p_update_by",OracleDbType.Varchar2,20,apms.EntryParameter.UpdateBy,ParameterDirection.Input), 
                new OracleParameter("p_comp_id",OracleDbType.Varchar2,2,apms.EntryParameter.CompanyID,ParameterDirection.Input),
                new OracleParameter("p_loc_id",OracleDbType.Varchar2,2,apms.EntryParameter.LocationID,ParameterDirection.Input),
                new OracleParameter("p_mac_id",OracleDbType.Varchar2,20,apms.EntryParameter.MachineID,ParameterDirection.Input)

            };

            short i = DALHelper.Insert(connString, packageName, parameterList);
            OracleParameter prm = parameterList[0];

            if ((OracleDecimal)prm.Value == 1)
                return 1;

            else
                return 0;

        }

       
   }
}
