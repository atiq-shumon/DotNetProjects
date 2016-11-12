using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.UI.HR.Reports.ReportUI;
using CrystalDecisions.CrystalReports.Engine;
using AH.ModuleController.HRSR;
using AH.DUtility;


namespace AH.ModuleController.UI.HR.Reports.Viewer
{
    public partial class frmReportViewer : Form
    {
        private Boolean isPrintDirect = false;
        private String reportTitle = "";
        private String secondParameter = "";
        public ViewerSelector selector;
        public String ReportTitle { set { reportTitle = value; } get { return reportTitle; } }
        public String ReportSecondParameter { set { secondParameter = value; } get { return secondParameter; } }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public string Sdate { set; get; }
        public string Edate { set; get; }
        public string PatientNo { set; get; }
        public string WhereCondition { set; get; }
        public string strParam { set; get; }
        public string strParam1 { set; get; }
        public string strParam2 { set; get; }
        public string strParam3 { set; get; }
        public string strParam4 { set; get; }
        public string strImage { set; get; }
        public string strDeptType { set; get; }
        public string strDept { set; get; }
        public string strDeptGrp { set; get; }
        public string strUnit { set; get; }
        public string strMonth { set; get; }
        public string strEmpID { set; get; }
        public string strAttendanceDate { set; get; }
        public string Mode { set; get; }
        public string strYear { set; get; }
        public string strHeading { set; get; }
        public string strDropType { set; get; }
       
        public string strSignature { set; get; }
        ReportDocument rpt1;
        HRSR.HRWSClient hmcSC = new HRSR.HRWSClient();

        public frmReportViewer()
        {
            InitializeComponent();
        }
        public frmReportViewer(Boolean isPrintDirect)
            : this()
        {
            this.isPrintDirect = isPrintDirect;
        }

        public string GetDateRange()
        {
            return StartDate.ToString("dd-MM-yyyy") + "    To    " + EndDate.ToString("dd-MM-yyyy");
        }

        private void InitialiseLabels(ReportDocument rpt)
        {

            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyName"]).Text = Utility.GetCompanyName;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyAddress"]).Text = Utility.GetCompanyAddress;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyEmail"]).Text = Utility.GetCompanyEmail;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyPhone"]).Text = Utility.GetCompanyPhone;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtIT"]).Text = Utility.GetITDvnMsg;
            ((TextObject)rpt.ReportDefinition.ReportObjects["txtCompanyWeb"]).Text = Utility.GetCompanyWeb;
            if (ReportTitle != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtReportTitle"]).Text = this.ReportTitle;
            }
            if (ReportSecondParameter != "")
            {
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtSecondParameter"]).Text = this.secondParameter;
            }
            else
            {
                rpt.ReportDefinition.ReportObjects["txtSecondParameter"].ObjectFormat.EnableSuppress = true;
            }
            //rpt.SetParameterValue("test", "ff");
        }
     
        private void ShowReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt, Boolean isDirectPrint, string strimage = "", string strSignature = "")
        {
            if (isDirectPrint == true)
            {
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                rpt.PrintToPrinter(1, false, 0, 0);

            }
            else
            {
                this.Show();
                if (strimage != "")
                {
                    if (strimage == null)
                    {
                        return;
                    }
                    else
                    {
                        rpt.SetParameterValue("x", strimage);
                    }
                }
                if (strSignature != "")
                {
                    if (strSignature == null)
                    {
                        return;
                    }
                    else
                    {
                        rpt.SetParameterValue("y", strSignature);
                    }
                }
            }

        }
 
        public void ViewReport()
        {
            try
            {
                this.crystalReportViewer1.Cursor = Cursors.WaitCursor;
                this.crystalReportViewer1.RefreshReport();
                switch (selector)
                {
                    case ViewerSelector.AllEmpList:
                        rptEmployeeList oEmpList = new rptEmployeeList();
                        rpt1 = (ReportDocument)oEmpList;
                        InitialiseLabels(rpt1);
                        List<EmployeeMasterRO> oEmpRO = new List<EmployeeMasterRO>();
                        oEmpRO = hmcSC.RptGetAllEmployee().ToList();
                        rpt1.SetDataSource(oEmpRO);
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        crystalReportViewer1.ReportSource = rpt1;
                        break;

                    case ViewerSelector.EmployeeDetails:
                        rptEmployeeMaster oEmp = new rptEmployeeMaster();
                        rpt1 = (ReportDocument)oEmp;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetEmpMaster("Emp", strParam.ToString(), ""));
                        ShowReport(rpt1, this.isPrintDirect, strImage, strSignature);
                        crystalReportViewer1.ReportSource = rpt1;
                        break;

                    case ViewerSelector.departmentList:
                        rpt_Department rpt = new rpt_Department();
                        rpt1 = (ReportDocument)rpt;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetRptDepartment());
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.DesignationList:
                        rptDesignationList Dsig = new rptDesignationList();
                        rpt1 = (ReportDocument)Dsig;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetDesignation());
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.LeaveDays:
                        rptLeaveDays oLv = new rptLeaveDays();
                        rpt1 = (ReportDocument)oLv;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetLeave(strParam.ToString()));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DepartmentWiseEmployeeList:
                        rptDepartmentWiseEmployeeList oEDpt = new rptDepartmentWiseEmployeeList();
                        rpt1 = (ReportDocument)oEDpt;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetEmpMaster("Dept", strDept.ToString(), ""));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DesignationWiseEmployeeList:
                        rptDesignationWiseEmployeeList oDesig = new rptDesignationWiseEmployeeList();
                        rpt1 = (ReportDocument)oDesig;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetEmpMaster("Desig", strParam.ToString(), ""));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DeptAndDesigWiseEmployeeList:
                        rptDeptDesigWiseEmployeeList oDptDesig = new rptDeptDesigWiseEmployeeList();
                        rpt1 = (ReportDocument)oDptDesig;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetEmpMaster("DeptDesig", strParam.ToString(), strParam1.ToString()));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.DeptTypeGrpDeptUnitWise:
                        rptEmployeeList oDepCatGrpDepType = new rptEmployeeList();
                        rpt1 = (ReportDocument)oDepCatGrpDepType;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.RptGetAllEmployeeMas(strDeptType.ToString(), strDeptGrp.ToString(), strDept.ToString(), strUnit.ToString()));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;


                    //***************************Payroll Report Manager*******************************//
                    case ViewerSelector.PayrollDetails:
                        rptPayrollDetails oPayD = new rptPayrollDetails();
                        List<PayrollRO> oPay = hmcSC.GetPayrollDetailsRO("A", "", "", "", strMonth.ToString()).ToList();
                        if (oPay.Count > 0)
                        {
                            rpt1 = (ReportDocument)oPayD;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oPay);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.PayrollSummary:
                        rptPayrollSummary oPaySummary = new rptPayrollSummary();
                        List<PayrollRO> oPaySum = hmcSC.GetPayrollDetailsRO("B", "", "", "", strMonth.ToString()).ToList();
                        if (oPaySum.Count > 0)
                        {
                            rpt1 = (ReportDocument)oPaySummary;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oPaySum);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.DepartmentWisePayroll:
                        rptDepartmentWisePayroll oDeptPay = new rptDepartmentWisePayroll();
                        List<PayrollRO> oPays = hmcSC.GetPayrollDetailsRO(Mode.ToString(), strDeptGrp.ToString(), strDept.ToString(), strUnit.ToString(), strMonth.ToString()).ToList();
                        if (oPays.Count > 0)
                        {
                            rpt1 = (ReportDocument)oDeptPay;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oPays);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.SalaryStatementForBank:
                        rptSalaryStatementForBank oSal = new rptSalaryStatementForBank();
                        List<PayrollRO> oSals = hmcSC.GetSalaryStatementForBank(strParam.ToString()).ToList();
                        if (oSals.Count > 0)
                        {
                            rpt1 = (ReportDocument)oSal;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oSals);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.PaySlip:
                        rptPaySLip oPaySlip = new rptPaySLip();
                        List<PayrollRO> oPaySlips = hmcSC.GetPaySlip(strParam.ToString(), strParam1.ToString()).ToList();
                        if (oPaySlips.Count > 0)
                        {
                            rpt1 = (ReportDocument)oPaySlip;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oPaySlips);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.EmployeeUnderSalary:
                        rptEmployeeUnderSalary oSalSummary = new rptEmployeeUnderSalary();
                        List<PayrollRO> oSalSums = hmcSC.GetEmployeeUnderSalary().ToList();
                        if (oSalSums.Count > 0)
                        {
                            rpt1 = (ReportDocument)oSalSummary;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oSalSums);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;



                    //******************************************************************************//
                    case ViewerSelector.DepartmentWiseLeaveDetails:
                        rptDepartmentWiseLeave oDeptLv = new rptDepartmentWiseLeave();
                        List<LeaveRO> oDeptLeavs = hmcSC.GetDeptWiseLeaveDetails(Mode, strYear.ToString(), strDeptGrp.ToString(), strDept.ToString(), strUnit.ToString()).ToList();
                        if (oDeptLeavs.Count > 0)
                        {
                            rpt1 = (ReportDocument)oDeptLv;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oDeptLeavs);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.LeaveRequisition:
                        rptDepartmentWiseLeaveRequisition oLeaveRequisition = new rptDepartmentWiseLeaveRequisition();
                        List<LeaveRO> oLeaveRequisitions = hmcSC.GetAllLeaveRequisition(Mode, strYear.ToString(), strDeptGrp.ToString(), strDept.ToString(), strUnit.ToString()).ToList();
                        if (oLeaveRequisitions.Count > 0)
                        {
                            rpt1 = (ReportDocument)oLeaveRequisition;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oLeaveRequisitions);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case ViewerSelector.EmployeeLeaveRegister:
                        rptEmployeeLeaveRegister oEmpLv = new rptEmployeeLeaveRegister();
                        rpt1 = (ReportDocument)oEmpLv;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetLeaveRegisterDetailsRO( strEmpID.ToString(), strYear.ToString()));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.EmployeeLeaveTemplate:
                        rptEmployeeLeaveTemplate oEmpLvTem = new rptEmployeeLeaveTemplate();
                        rpt1 = (ReportDocument)oEmpLvTem;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetLeaveTemplateRO(strParam1.ToString(), strParam2.ToString()));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;



                    case ViewerSelector.HolidayCalender:
                        rptHolidayCalender oHolidayCalender = new rptHolidayCalender();
                        List<HolidayCalenderRO> oHoCals = hmcSC.GetHolidayCalenderForReport(strParam.ToString()).ToList();
                        if (oHoCals.Count > 0)
                        {
                            rpt1 = (ReportDocument)oHolidayCalender;
                            InitialiseLabels(rpt1);
                            rpt1.SetDataSource(oHoCals);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Record Found!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.AppointmentLetterForGeneralEmployee:
                        rptGeneralAppointmentLetter orptGeneralAppointmentLetter = new rptGeneralAppointmentLetter();
                        List<AppointmentRO> orptGeneralAppointmentLetters = hmcSC.GetAppointmentLetter(strParam.ToString()).ToList();
                        if (orptGeneralAppointmentLetters.Count > 0)
                        {
                            rpt1 = (ReportDocument)orptGeneralAppointmentLetter;
                            rpt1.SetDataSource(orptGeneralAppointmentLetters);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Data Found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.AppointmentLetterForContractual:
                        rptContructuallAppointmentLetter orptAppointmentLetterForContractual = new rptContructuallAppointmentLetter();
                        List<AppointmentRO> orptAppointmentLetterForContractuals = hmcSC.GetAppointmentLetter(strParam.ToString()).ToList();
                        if (orptAppointmentLetterForContractuals.Count > 0)
                        {
                            rpt1 = (ReportDocument)orptAppointmentLetterForContractual;
                            rpt1.SetDataSource(orptAppointmentLetterForContractuals);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Data Found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case ViewerSelector.AppointmentLetterForPhysician:
                        rptPhysicianlAppointmentLetter orptrptPhysicianlAppointmentLetter = new rptPhysicianlAppointmentLetter();
                        List<AppointmentRO> orptrptPhysicianlAppointmentLetters = hmcSC.GetAppointmentLetter(strParam.ToString()).ToList();
                        if (orptrptPhysicianlAppointmentLetters.Count > 0)
                        {
                            rpt1 = (ReportDocument)orptrptPhysicianlAppointmentLetter;
                            rpt1.SetDataSource(orptrptPhysicianlAppointmentLetters);
                            crystalReportViewer1.ReportSource = rpt1;
                            ShowReport(rpt1, this.isPrintDirect, "", "");
                        }
                        else
                            MessageBox.Show("No Data Found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    //**********************Attendance Report***********************//

                    case ViewerSelector.DailyAttendance:
                        rptDailyAttendance oDailyAttendance = new rptDailyAttendance();
                        rpt1 = (ReportDocument)oDailyAttendance;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetDailyAttndence(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.MonthlyAttendance:
                        rptEmployeeWiseMonthlyAttendance oMonthlyAttendance = new rptEmployeeWiseMonthlyAttendance();
                        rpt1 = (ReportDocument)oMonthlyAttendance;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetMonthlyAttndence(strEmpID, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DailyAbsent:
                        rptDailyAbsent oDailyAbsent = new rptDailyAbsent();
                        rpt1 = (ReportDocument)oDailyAbsent;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetDailyAbsent(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DailyLate:
                        rptDailyLate oDailyLate = new rptDailyLate();
                        rpt1 = (ReportDocument)oDailyLate;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetDailyLate(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                    case ViewerSelector.DailyLeave:
                        rptDailyLeave oDailyLeave = new rptDailyLeave();
                        rpt1 = (ReportDocument)oDailyLeave;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetDailyLeave(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                                ////////////////Employee Others Report/////////////////////////

                    case ViewerSelector.EmployeeListByJoiningDate:
                        rptEmployeeDetailsofAAH oEmpJoin = new rptEmployeeDetailsofAAH();
                        rpt1 = (ReportDocument)oEmpJoin;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetEmpJoiningReport(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        rpt1.SetParameterValue("Heading", strHeading);
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.EmployeeListByResignationDate:
                        rptEmployeeDetailsofAAH oEmpResig = new rptEmployeeDetailsofAAH();
                        rpt1 = (ReportDocument)oEmpResig;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetEmpResigReport(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        rpt1.SetParameterValue("Heading", strHeading);
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.EmployeeListByConfirmationDueDate:
                        rptEmployeeDetailsofAAH oEmpConf = new rptEmployeeDetailsofAAH();
                        rpt1 = (ReportDocument)oEmpConf;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetEmpConfDateReport(Mode, strDeptGrp, strDept, strUnit, Sdate, Edate));
                        rpt1.SetParameterValue("Heading", strHeading);
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;
                    case ViewerSelector.EmployeeListByOtherDropTypes:
                        rptEmployeeDetailsofAAH oEmpOthersType = new rptEmployeeDetailsofAAH();
                        rpt1 = (ReportDocument)oEmpOthersType;
                        InitialiseLabels(rpt1);
                        rpt1.SetDataSource(hmcSC.GetEmpOthersReport(Mode, strDeptGrp, strDept, strUnit,strDropType,Sdate, Edate));
                        rpt1.SetParameterValue("Heading", strHeading);
                        crystalReportViewer1.ReportSource = rpt1;
                        ShowReport(rpt1, this.isPrintDirect, "", "");
                        break;

                }               

                this.crystalReportViewer1.Cursor = Cursors.Arrow;
                crystalReportViewer1.MaximumSize.ToString();
            }

            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       

    }
}
