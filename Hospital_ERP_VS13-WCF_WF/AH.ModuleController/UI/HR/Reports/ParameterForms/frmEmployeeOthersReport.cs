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
    public partial class frmEmployeeOthersReport : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeOthersReport()
        {
            InitializeComponent();
        }
        public void EmployeeListByJoingDateReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeListByJoiningDate;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.strHeading = "Employee List By Joining Date";
            ofrmReportViewerHR.ViewReport();
        }

        public void EmployeeListByResignationDateReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeListByResignationDate;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.strHeading = "Employee List By Resignation Date";
            ofrmReportViewerHR.ViewReport();
        }

        public void EmployeeListByConfDueDateReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeListByConfirmationDueDate;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.strHeading = "Employee List By Confirmation Due Date";
            ofrmReportViewerHR.ViewReport();
        }
        public void EmployeeListByOthersDropTypeReport()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeListByOtherDropTypes;
            ofrmReportViewerHR.StartDate = Convert.ToDateTime(dtStartDate.Text);
            ofrmReportViewerHR.EndDate = Convert.ToDateTime(dtEndDate.Text);
            ofrmReportViewerHR.ReportSecondParameter = ofrmReportViewerHR.GetDateRange();
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "A";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "B";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.strDropType = cboDropType.SelectedValue.ToString();
            ofrmReportViewerHR.Sdate = dtStartDate.Text.ToString();
            ofrmReportViewerHR.Edate = dtEndDate.Text.ToString();
            ofrmReportViewerHR.strHeading = "Employee List By Others Drop Type";
            ofrmReportViewerHR.ViewReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoJoiningDate.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    EmployeeListByJoingDateReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            if (rdoResigDate.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    EmployeeListByResignationDateReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

            if (rdoConfDueDate.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    EmployeeListByConfDueDateReport();
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }
            if (rdoEmpListByDropType.Checked == true)
            {
                if (cboDateType.Text != "")
                {
                    if (rdoAll.Checked == false && rdoDeptGrp.Checked == false && rdoGrpDeptUnit.Checked == false)
                    {
                        MessageBox.Show("Please Select a Type From Select Options");
                        return;
                    }
                    if (cboDropType.SelectedValue != "")
                    {
                        EmployeeListByOthersDropTypeReport();
                    }
                }
                else
                    MessageBox.Show("You must Have to Give Date Range");
            }

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

        private void frmEmployeeOthersReport_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboDropType.DisplayMember = "Value";
            cboDropType.ValueMember = "Key";
            cboDropType.DataSource = new BindingSource(Utility.GetDropTypes(), null);

            rdoJoiningDate.Checked = true;
            rdoAll.Checked = true;

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

        private void rdoJoiningDate_CheckedChanged(object sender, EventArgs e)
        {
            lblDropType.Enabled = false;
            cboDropType.Enabled = false;
            gbSelectOptions.Enabled = true;
            gbDept.Enabled = true;
            gbDateRange.Enabled = true;
        }

        private void rdoResigDate_CheckedChanged(object sender, EventArgs e)
        {
            lblDropType.Enabled = false;
            cboDropType.Enabled = false;
            gbSelectOptions.Enabled = true;
            gbDept.Enabled = true;
            gbDateRange.Enabled = true;
        }

        private void rdoConfDueDate_CheckedChanged(object sender, EventArgs e)
        {
            lblDropType.Enabled = false;
            cboDropType.Enabled = false;
            gbSelectOptions.Enabled = true;
            gbDept.Enabled = true;
            gbDateRange.Enabled = true;
        }

        private void rdoEmpListByDropType_CheckedChanged(object sender, EventArgs e)
        {
            lblDropType.Enabled = true;
            cboDropType.Enabled = true;
            gbSelectOptions.Enabled = true;
            gbDept.Enabled = true;
            gbDateRange.Enabled = true;
        }


    }
}
