using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.HR.Reports.ParameterForms;
using AH.ModuleController.UI.ACMS.Forms;
using AH.ModuleController.UI.INVMS.Forms;
using AH.ModuleController.UI.OPD.Forms;
using AH.ModuleController.UI.PRMS.Forms;
using AH.ModuleController.UI.APMS.Forms;
using AH.ModuleController.UI.FNB.Forms;
using AH.ModuleController.UI.FNB.Reports.ParameterForms;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmHRMMain : Form
    {
        public frmHRMMain()
        {
            InitializeComponent();
        }

        private void frmPatientRegistrationMain_Load(object sender, EventArgs e)
        {
            pnlPatientRegistration.Visible = false;
            Utility.EnforceSecurity("HRMMIS", menuStrip1, pnlPatientRegistration);
            Utility.InitialiseMainForm(this, pnlPatientRegistration, pnlModuleName, userWidgetMetro1, dateWidget1);
            pnlPatientRegistration.Visible = true;
            btnCloseModule.Enabled = true;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientRegistrationModule_Click(object sender, EventArgs e)
        {
            frmDisplayRosterDuty oMonthly = new frmDisplayRosterDuty();
            oMonthly.ShowDialog();

        }

        private void btnPatientRegRptManager_Click(object sender, EventArgs e)
        {
            frmDepartmentWiseManualAttendence oDeptmanu = new frmDepartmentWiseManualAttendence();
            oDeptmanu.ShowDialog();
        }
        private void mnuDoctorSetup_Click(object sender, EventArgs e)
        {
            //frmDoctorSetup docsetup = new frmDoctorSetup();
            //docsetup.ShowDialog();
        }

        private void mnuUnitSetup_Click(object sender, EventArgs e)
        {
            frmUnitSetup unitsetup = new frmUnitSetup();
            unitsetup.ShowDialog();
        }

        private void btnCloseModule_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //string appImagePath = "C:\\Images";
            //string appSignaturePath = "C:\\Signatures";
            //System.IO.DirectoryInfo img = new System.IO.DirectoryInfo(appImagePath);
            //img.Delete(true);
            //System.IO.DirectoryInfo sig = new System.IO.DirectoryInfo(appSignaturePath);
            //sig.Delete(true);
        }


        private void btnDoctor_Click(object sender, EventArgs e)
        {
            //frmDoctorSetup docsetup = new frmDoctorSetup();
            //docsetup.ShowDialog();
        }

        private void mnuNurseSetup_Click(object sender, EventArgs e)
        {
            //frmNurseSetup nur = new frmNurseSetup();
            //nur.ShowDialog();
        }
        private void mnudepartmentGroupSetup_Click(object sender, EventArgs e)
        {
            frmDepartmentGroup deptgrp = new frmDepartmentGroup();
            deptgrp.ShowDialog();
        }

        private void nmudepartmentSetup_Click(object sender, EventArgs e)
        {
            frmDepartmentSetup deptsetup = new frmDepartmentSetup();
            deptsetup.ShowDialog();
        }

        private void mnudepartmentUnitSetup_Click(object sender, EventArgs e)
        {
            frmUnitSetup unitsetup = new frmUnitSetup();
            unitsetup.ShowDialog();
        }

        private void mnudepartmentUnitAssign_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oAssign = new frmAssignOrganogram();
            oAssign.ShowDialog();         
        }

        private void mnudesignationGroupSetup_Click(object sender, EventArgs e)
        {
            frmDesignatonGroup oDsgrp = new frmDesignatonGroup();
            oDsgrp.ShowDialog();        
        }

        private void mnudesignationSetup_Click(object sender, EventArgs e)
        {

            frmDesignationSetup dsigsetup = new frmDesignationSetup();
            dsigsetup.ShowDialog();
        }
        //private void btnEmployeeMaster_Click(object sender, EventArgs e)
        //{

        //    frmEmployeeMaster emaster = new frmEmployeeMaster();
        //    emaster.ShowDialog();
        //}

        private void btnCloseModule_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLeaveRegister_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRequisition oemp = new frmEmployeeLeaveRequisition();
            oemp.ShowDialog();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmSalaryProcess ofm = new frmSalaryProcess();
            ofm.ShowDialog();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmPayrollReportManager oPayReport = new frmPayrollReportManager();
            oPayReport.ShowDialog();
        }

        private void btnEmployeeInformationReport_Click(object sender, EventArgs e)
        {
            frmEmployeeReportManager ofrm = new frmEmployeeReportManager();
            ofrm.ShowDialog();
        }         
        private void mnuLeave_Click(object sender, EventArgs e)
        {
            //frmEmpLeaveRegister ofrmDS = new frmEmpLeaveRegister();
            //ofrmDS.ShowDialog();
        }
        private void mnuSalaryHeadGroup_Click(object sender, EventArgs e)
        {
            frmSalaryHeadGroup oFrm = new frmSalaryHeadGroup();
            oFrm.ShowDialog();
        }

        private void mnuSalaryHeadSetup_Click(object sender, EventArgs e)
        {
            frmSalaryHead ofrm = new frmSalaryHead();
            ofrm.ShowDialog();
        }

        private void mnuGradeSetup_Click(object sender, EventArgs e)
        {
            frmSalaryGradeSetup ofrm = new frmSalaryGradeSetup();
            ofrm.ShowDialog();
        }

        private void mnuScaleMasterSetup_Click(object sender, EventArgs e)
        {
            frmScaleMSetup ofrm = new frmScaleMSetup();
            ofrm.ShowDialog();
        }

        private void mnuSalarycycleSetup_Click(object sender, EventArgs e)
        {
            frmSalaryCycle ofrm = new frmSalaryCycle();
            ofrm.ShowDialog();
        }

        private void mnuScaleDetailsSetup_Click(object sender, EventArgs e)
        {
            frmScaleDetailsSetup ofrm = new frmScaleDetailsSetup();
            ofrm.ShowDialog();
        }

        private void mnuLeaveTypeSetup_Click(object sender, EventArgs e)
        {
            frmLeaveType ofrm = new frmLeaveType();
            ofrm.ShowDialog();
        }

        private void mnuLeaveDaysSetup_Click(object sender, EventArgs e)
        {
            frmLeaveDaysSetup ofrm = new frmLeaveDaysSetup();
            ofrm.ShowDialog();
        }

        private void mnuEmployeeMaster_Click(object sender, EventArgs e)
        {
            frmEmployeeMaster ofrm = new frmEmployeeMaster();
            ofrm.ShowDialog();
        }

        private void mnuAcadInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeEducation ofrm = new frmEmployeeEducation();
            ofrm.ShowDialog();
        }

        private void mnuEmployeeJobInfo_Click(object sender, EventArgs e)
        {
            frmEmpJobInfo ofrm = new frmEmpJobInfo();
            ofrm.ShowDialog();
        }

        private void mnuEmployeePreviousExperience_Click(object sender, EventArgs e)
        {
            frmEmpPrevExp ofrm = new frmEmpPrevExp();
            ofrm.ShowDialog();
        }

        private void mnuEmployeeTraining_Click(object sender, EventArgs e)
        {
            frmEmployeeTraining ofrm = new frmEmployeeTraining();
            ofrm.ShowDialog();
        }

        private void mnuSalaryProcess_Click(object sender, EventArgs e)
        {
            frmSalaryProcess ofrm = new frmSalaryProcess();
            ofrm.ShowDialog();
        }

        private void mnuDepartmentWisePayroll_Click(object sender, EventArgs e)
        {
            frmDepartmentWisePayroll ofrm = new frmDepartmentWisePayroll();
            ofrm.ShowDialog();
        }

        private void mnuUpdatePayroll_Click(object sender, EventArgs e)
        {
            frmPayrollUpdate ofrm = new frmPayrollUpdate();
            ofrm.ShowDialog();
        }

        private void mnuEmployeeInformationReport_Click(object sender, EventArgs e)
        {
            frmEmployeeReportManager ofrm = new frmEmployeeReportManager();
            ofrm.ShowDialog();
        }

        private void mnuPayrollInformationReport_Click(object sender, EventArgs e)
        {
            frmPayrollReportManager ofrm = new frmPayrollReportManager();
            ofrm.ShowDialog();
        }

        private void mnuLeaveInformationReport_Click(object sender, EventArgs e)
        {
            frmLeaveReportManager ofrm = new frmLeaveReportManager();
            ofrm.ShowDialog();
        }

        private void mnuOraganizationSetupReport_Click(object sender, EventArgs e)
        {
            frmOrganizationSetupReportManager ofrm = new frmOrganizationSetupReportManager();
            ofrm.ShowDialog();
        }      
        private void mnuLeaveRqstListHead_Click(object sender, EventArgs e)
        {
            frmLeaveRequestListOfHead ofrm = new frmLeaveRequestListOfHead();
            ofrm.ShowDialog();
        }     
        private void mnuLeaveReqstListHR_Click(object sender, EventArgs e)
        {
            frmLeaveRequestListOfHR ofrm = new frmLeaveRequestListOfHR();
            ofrm.ShowDialog();
        }

        private void mnuLeaveCancelCause_Click(object sender, EventArgs e)
        {
            frmLeaveCancelCause ofrm = new frmLeaveCancelCause();
            ofrm.ShowDialog();
        }

        private void mnuEmpDepInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeDependent ofrm = new frmEmployeeDependent();
            ofrm.ShowDialog();
        }

        private void btnEmployeeMaster_Click(object sender, EventArgs e)
        {
            frmEmployeeMaster ofrm = new frmEmployeeMaster();
            ofrm.ShowDialog();
        }

        private void mnuLeaveCancelCause_Click_1(object sender, EventArgs e)
        {
            frmLeaveCancelCause ofrm = new frmLeaveCancelCause();
            ofrm.ShowDialog();
        }

        private void mnuEmpLeaveRegister_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRequisition ofrm = new frmEmployeeLeaveRequisition();
            ofrm.ShowDialog();
        }

        private void mnuAttendence_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuDeptWiseAttendence_Click(object sender, EventArgs e)
        {
            frmDepartmentWiseManualAttendence ofrm = new frmDepartmentWiseManualAttendence();
            ofrm.ShowDialog();
        }

        private void mnuManualSalaryProcess_Click(object sender, EventArgs e)
        {
            frmManualSalaryProcess ofrm = new frmManualSalaryProcess();
            ofrm.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmPasswordReset oPassRes = new frmPasswordReset();
            oPassRes.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void userWidgetMetro1_btnLogout_Clicked(object sender, EventArgs e)
        {
            userWidgetMetro1.Parent.Dispose();
            Utility.isAuthenticated = 0;
            frmLogIn logIn = new frmLogIn("HRMMIS");
            logIn.atiqsLogInUserControl1.IsPrefilled = false;
            logIn.ShowDialog();
            logIn.atiqsLogInUserControl1.txtUserID.Text = "";
            logIn.atiqsLogInUserControl1.txtPassword.Text = "";
        }

        private void mnuDeptTree_Click(object sender, EventArgs e)
        {
            frmDepartmentTree ofrm = new frmDepartmentTree();
            ofrm.ShowDialog();
        }

        private void mnuSalaryDisverse_Click(object sender, EventArgs e)
        {
            frmSalaryDisverse ofrm = new frmSalaryDisverse();
            ofrm.ShowDialog();
        }

        private void mnuEmpMedInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeMedicalInformation oMed = new frmEmployeeMedicalInformation();
            oMed.ShowDialog();
        }

        private void mnuPunishmentSetup_Click(object sender, EventArgs e)
        {
            frmPunishmentTypeSetup oPun = new frmPunishmentTypeSetup();
            oPun.ShowDialog();
        }

        private void mnuEmpPunInfo_Click(object sender, EventArgs e)
        {
            frmEmployeePunishmentSetup oEmpPun = new frmEmployeePunishmentSetup();
            oEmpPun.ShowDialog();
        }

        private void mnuStepDetSetup_Click(object sender, EventArgs e)
        {
            frmStepDetailsSetup oStp = new frmStepDetailsSetup();
            oStp.ShowDialog();
        }

        private void mnuHolidayTypeSetup_Click(object sender, EventArgs e)
        {
            frmHolidayTypeSetup oHolidayType = new frmHolidayTypeSetup();
            oHolidayType.ShowDialog();
        }

        private void mnuHolidayNameSetup_Click(object sender, EventArgs e)
        {
            frmHolidayNameSetup oHolidayName = new frmHolidayNameSetup();
            oHolidayName.ShowDialog();
        }

        private void mnuHolidayCalender_Click(object sender, EventArgs e)
        {
            frmHolidayCalender oHolidayCalender = new frmHolidayCalender();
            oHolidayCalender.ShowDialog();
        }

        private void mnuNomineeInfo_Click(object sender, EventArgs e)
        {
            frmNomineeInformation oNominee = new frmNomineeInformation();
            oNominee.ShowDialog();
        }

        private void mnuBankSetup_Click(object sender, EventArgs e)
        {
            frmBankSetup oBank = new frmBankSetup();
            oBank.ShowDialog();
        }

        private void mnuPayrollBase_Click(object sender, EventArgs e)
        {
            frmPayrollBaseSetup oPayBase = new frmPayrollBaseSetup();
            oPayBase.ShowDialog();
        }
        private void mnuPayrollBaseSetup_Click(object sender, EventArgs e)
        {
            frmPayrollBaseSetup oPayrollBase = new frmPayrollBaseSetup();
            oPayrollBase.ShowDialog();
        }
     
        private void mnuDeptHdSetup_Click(object sender, EventArgs e)
        {
            frmDepartmentHeadSetup oDeptHd = new frmDepartmentHeadSetup();
            oDeptHd.ShowDialog();
        }
        private void mnuAppointmentSetup_Click(object sender, EventArgs e)
        {
            frmAppointmentSetup oApp = new frmAppointmentSetup();
            oApp.ShowDialog();
        }

        private void mnuAppointmentLetter_Click(object sender, EventArgs e)
        {
            frmAppointmentLetter oAppoint = new frmAppointmentLetter();
            oAppoint.ShowDialog();
        }

        private void mnuShiftSetup_Click(object sender, EventArgs e)
        {
            frmShiftSetup oShift = new frmShiftSetup();
            oShift.ShowDialog();
        }

        private void mnuShiftTimingSetup_Click(object sender, EventArgs e)
        {
            frmShiftTimingSetup oShiftTiming = new frmShiftTimingSetup();
            oShiftTiming.ShowDialog();
        }

        private void mnuOrganogramSetup_Click(object sender, EventArgs e)
        {
            frmOranogramSetup oOrg = new frmOranogramSetup();
            oOrg.ShowDialog();
        }

        private void mnuRosterDutySetup_Click(object sender, EventArgs e)
        {
            frmRosterDutySetup oRoster = new frmRosterDutySetup();
            oRoster.ShowDialog();
        }

        private void mnuMonthlyRosterDuty_Click(object sender, EventArgs e)
        {
            frmDisplayRosterDuty oMonthly = new frmDisplayRosterDuty();
            oMonthly.ShowDialog();
        }

        private void mnuEmployeeDropList_Click(object sender, EventArgs e)
        {
            frmEmployeeDropList oDropList = new frmEmployeeDropList();
            oDropList.ShowDialog();
        }

        private void mnuFinalizeDropList_Click(object sender, EventArgs e)
        {
            frmFinalizeDropList oFinalizeDrop = new frmFinalizeDropList();
            oFinalizeDrop.ShowDialog();
        }

        private void mnuIncomeTaxSetup_Click(object sender, EventArgs e)
        {
            frmIncomeTaxSetup oIncomeTax = new frmIncomeTaxSetup();
            oIncomeTax.ShowDialog();
        }

        private void mnuEmpFringeBenefit_Click(object sender, EventArgs e)
        {
            frmFringeBenefitSetup oBenefit = new frmFringeBenefitSetup();
            oBenefit.ShowDialog();
        }

        private void mnuEmployeeLeaveRegister_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRegister oEmpLeavRegis = new frmEmployeeLeaveRegister();
            oEmpLeavRegis.ShowDialog();
        }

        private void mnuLeaveRegister_Click(object sender, EventArgs e)
        {
            frmEmployeeLeaveRegister oLeaveRegis = new frmEmployeeLeaveRegister();
            oLeaveRegis.ShowDialog();
        }
        private void mnuThanaSetup_Click(object sender, EventArgs e)
        {
            frmThanaSetup oThana = new frmThanaSetup();
            oThana.ShowDialog();
        }

        private void mnuPostOfficeSetup_Click(object sender, EventArgs e)
        {
            frmPostOfficeSetup oPostOffice = new frmPostOfficeSetup();
            oPostOffice.ShowDialog();
        }

        private void mnuFoodSubsidySetup_Click(object sender, EventArgs e)
        {
            frmFoodSubsidySetup oFood = new frmFoodSubsidySetup();
            oFood.ShowDialog();
        }

        private void mnuDemandRequisiotion_Click(object sender, EventArgs e)
        {
            frmDemandRequisition oDemand = new frmDemandRequisition();
            oDemand.ShowDialog();
        }

        private void mnuReportingPerson_Click(object sender, EventArgs e)
        {
            frmLeaveRequestListofReportingPerson oRep = new frmLeaveRequestListofReportingPerson();
            oRep.ShowDialog();
        }      

        private void mnuRoomGrpAssign_Click(object sender, EventArgs e)
        {
            frmRoomGrpAssign oRoomGroup = new frmRoomGrpAssign();
            oRoomGroup.ShowDialog();
        }

        private void mnuOPDDoctor_Click(object sender, EventArgs e)
        {
            frmOPDDoctor oOPDDoctor = new frmOPDDoctor();
            oOPDDoctor.ShowDialog();
        }

        private void mnuRoomType_Click(object sender, EventArgs e)
        {
            frmRoomType oRoomType = new frmRoomType();
            oRoomType.ShowDialog();

        }
        private void mnuRoomSetup_Click(object sender, EventArgs e)
        {
            frmRoomSetup oRoomSetup = new frmRoomSetup();
            oRoomSetup.ShowDialog();
        }

        private void mnuWardSetup_Click(object sender, EventArgs e)
        {
            frmWardSetup oWardSetup = new frmWardSetup();
            oWardSetup.ShowDialog();
        }

        private void mnuBedType_Click(object sender, EventArgs e)
        {
            frmBedType oBedType = new frmBedType();
            oBedType.ShowDialog();
        }

        private void mnuBedSetup_Click(object sender, EventArgs e)
        {
            frmBedSetup oBedSetup = new frmBedSetup();
            oBedSetup.ShowDialog();
        }

        private void mnuBedFacilities_Click(object sender, EventArgs e)
        {
            frmBedFacilites oBedFacilities = new frmBedFacilites();
            oBedFacilities.ShowDialog();
        }

        private void mnuDoctorDutySch_Click(object sender, EventArgs e)
        {
            frmCreateDoctorSchedule oCreateDoctor = new frmCreateDoctorSchedule();
            oCreateDoctor.ShowDialog();
        }
        private void mnuDailyAtten_Click(object sender, EventArgs e)
        {
            frmDailyAttendance oDaily = new frmDailyAttendance();
            oDaily.ShowDialog();
        }

        private void mnuAttendance_Click(object sender, EventArgs e)
        {
            frmAttendanceReport oAtten = new frmAttendanceReport();
            oAtten.ShowDialog();
        }
        private void mnuVeriftDeReq_Click(object sender, EventArgs e)
        {
            frmVerifyRequisition oVerify = new frmVerifyRequisition();
            oVerify.ShowDialog();
        }

        private void mnuEmpDegreeSetup_Click(object sender, EventArgs e)
        {
            frmEmployeeDegreeSetup oEmpDegree = new frmEmployeeDegreeSetup();
            oEmpDegree.ShowDialog();
        }

        private void mnuAttenProcess_Click(object sender, EventArgs e)
        {
            frmAttendanceProcess oAttenProcess = new frmAttendanceProcess();
            oAttenProcess.ShowDialog();
        }

        private void mnuFoodSubsidyReport_Click(object sender, EventArgs e)
        {
            frmRptMealRegister frm = new frmRptMealRegister();
            frm.ShowDialog();
        }

        private void mnuOthersReport_Click(object sender, EventArgs e)
        {
            frmEmployeeOthersReport oOthers = new frmEmployeeOthersReport();
            oOthers.ShowDialog();
        }

          
    }
}
