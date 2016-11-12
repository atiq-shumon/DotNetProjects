using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;


namespace AH.ModuleController.UI.HR.Reports.ParameterForms
{
    public partial class frmAttendanceReport : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmAttendanceReport()
        {
            InitializeComponent();
        }
        public void DailyAttendanceReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DailyAttendance;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
             if (rdoAll.Checked == true)
             {
                ofrmReportViewerHR.Mode="C";
             }
             if (rdoDeptGrp.Checked == true)
             {
                ofrmReportViewerHR.Mode="A";
             }
             if (rdoGrpDeptUnit.Checked == true)
             {
                 ofrmReportViewerHR.Mode = "B";
             }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void MonthlyAttendanceReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.MonthlyAttendance;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            ofrmReportViewerHR.strEmpID = txtEmpID.Text.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void DailyAbsentReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DailyAbsent;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void DailyLateReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DailyLate;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void DailyLeaveReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DailyLeave;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoDailyAttendance.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    DailyAttendanceReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            if (rdoMonthAttn.Checked == true)
            {
                if (txtEmpID.Text == "")
                {
                    MessageBox.Show("Please Povide a Valid Employee ID");
                    txtEmpID.Focus();
                    return;
                }
                if (txtEmpID.Text != "")
                {
                    if (cboDateType.Text != "")
                    {
                        MonthlyAttendanceReport();
                    }
                    else
                        MessageBox.Show("You must Have to Give Date Range");
                }
            }
            if (rdoDailyAbsent.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    DailyAbsentReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            if (rdoDailyLate.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    DailyLateReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            if (rdoDailyLeave.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    DailyLeaveReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
        }
        private void frmDailyAttendance_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            rdoDailyAttendance.Checked = true;
        }

        private void cboDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region DateLogic
            DateTime _dateTo = DateTime.Parse(DateTime.Now.ToString());
            string sTo = _dateTo.ToString("dd-MM-yyyy");
            dtEndDate.Text = sTo;

            if (cboDateType.Text == "Today")
            {
                DateTime _dFrom = _dateTo.AddDays(0);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            if (cboDateType.Text == "Last One Week")
            {
                DateTime _dFrom = _dateTo.AddDays(-7);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Month")
            {
                DateTime _dFrom = _dateTo.AddDays(-30);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Three Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-3);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last Six Month")
            {
                DateTime _dFrom = _dateTo.AddMonths(-6);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }

            if (cboDateType.Text == "Last One Year")
            {
                DateTime _dFrom = _dateTo.AddYears(-1);
                string sdFrom = _dFrom.ToString("dd-MM-yyyy");
                dtStartDate.Text = sdFrom;

            }
            #endregion
        }

        private void rdoDailyAttendance_CheckedChanged(object sender, EventArgs e)
        {
            gbEmp.Visible = false;
            gbSelectOptions.Visible = true;
            gbDept.Visible = true;
            gbDateRange.Visible = true;
            cboDateType.Text = "Today";
            rdoDeptGrp.Checked = true;
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(hmsSC.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }
        private void rdoMonthAttn_CheckedChanged(object sender, EventArgs e)
        {           
            gbDept.Visible = false;
            gbSelectOptions.Visible = false;
            gbEmp.Visible = true;
            txtEmpID.Focus();
            gbDateRange.Visible = true;
            cboDateType.Text = "Last One Month";
        }

        private void rdoDailyAbsent_CheckedChanged(object sender, EventArgs e)
        {
            gbEmp.Visible = false;
            gbSelectOptions.Visible = true;
            gbDept.Visible = true;
            gbDateRange.Visible = true;
            cboDateType.Text = "Today";
            rdoDeptGrp.Checked = true;
        }

        private void rdoDailyLeave_CheckedChanged(object sender, EventArgs e)
        {
            gbEmp.Visible = false;
            gbDept.Visible = true;
            gbSelectOptions.Visible = true;
            gbDateRange.Visible = true;
            cboDateType.Text = "Today";

            rdoDeptGrp.Checked = true;
        }

        private void rdoDailyLate_CheckedChanged(object sender, EventArgs e)
        {
            gbEmp.Visible = false;
            gbSelectOptions.Visible = true;
            gbDept.Visible = true;
            gbDateRange.Visible = true;
            cboDateType.Text = "Today";

            rdoDeptGrp.Checked = true;
        }

    }
}
