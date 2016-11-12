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
    public partial class frmPayrollReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmPayrollReportManager()
        {
            InitializeComponent();
        }

        private void frmPayrollReportManager_Load(object sender, EventArgs e)
        {           
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015, 2025), null);

            cboYear.Text = DateTime.Now.ToString("yyyy");
        }
        public void PayrollDetails()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.PayrollDetails;
            ofrmReportViewerHR.strMonth = cboMonth.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void PayrollSummary()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.PayrollSummary;
            ofrmReportViewerHR.strMonth = cboMonth.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void SalaryStatement()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.SalaryStatementForBank;
            ofrmReportViewerHR.strParam = cboMonth.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void DeptWisePayroll()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DepartmentWisePayroll;
            if (rdoAll.Checked == true)
            {
                ofrmReportViewerHR.Mode = "C";
            }
            if (rdoDeptGrp.Checked == true)
            {
                ofrmReportViewerHR.Mode = "D";
            }
            if (rdoGrpDeptUnit.Checked == true)
            {
                ofrmReportViewerHR.Mode = "E";
            }
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.strMonth = cboMonth.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void PaySlip()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.PaySlip;
            ofrmReportViewerHR.strParam = cboMonth.SelectedValue.ToString();
            ofrmReportViewerHR.strParam1 = txtEmpID.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void EmployeeUnderSalary()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeUnderSalary;
            ofrmReportViewerHR.ViewReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoPayrollDetails.Checked == true)
            {
                if (cboMonth.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Select Month Name..");
                    cboMonth.Focus();
                    return;
                }
                PayrollDetails();

            }
            if (rdoPayrollSummary.Checked == true)
            {
                if (cboMonth.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Select Month Name..");
                    cboMonth.Focus();
                    return;
                }
                PayrollSummary();

            }
            if (rdoEmployeeUnderSalary.Checked == true)
            {
                EmployeeUnderSalary();
            }
            if (rdoSalaryStatement.Checked == true)
            {
                if (cboMonth.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Select Month Name..");
                    cboMonth.Focus();
                    return;
                }
                SalaryStatement();

            }
            if (rdoDeptWisePayroll.Checked == true)
            {
                if (cboDepartment.SelectedValue=="")
                {
                    MessageBox.Show("Please Select Department..");
                    cboDepartment.Focus();
                    return;
                }
                if (cboMonth.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Select Month Name..");
                    cboMonth.Focus();
                    return;
                }
                DeptWisePayroll();
            }

            if (rdoPaySlip.Checked == true)
            {
                if (cboMonth.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Select Month Name..");
                    cboMonth.Focus();
                    return;
                }
                if (txtEmpID.Text.ToString() == "")
                {
                    MessageBox.Show("Please Provide Employee ID");
                    txtEmpID.Focus();
                    return;
                }
                PaySlip();
            }

        }

        private void rdoPayrollDetails_Click(object sender, EventArgs e)
        {
            if (rdoPayrollDetails.Checked == true)
            {
                pnlMonth.Visible = true;

                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");

                gbSelectOptions.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
            }
            else
            {
                pnlMonth.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
        }
        private void rdoDeptWisePayroll_Click(object sender, EventArgs e)
        {
            if (rdoDeptWisePayroll.Checked == true)
            {
                pnlMonth.Visible = true;

                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);
                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");

                gbSelectOptions.Visible = true;
                rdoDeptGrp.Checked = true;
                pnlDepartment.Visible = true;
                pnlEmployee.Visible = false;
            }
            else
            {
                pnlMonth.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
        }

        private void rdoSalaryStatement_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSalaryStatement.Checked == true)
            {
                pnlMonth.Visible = true;
                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");

                pnlDepartment.Visible = false;
                gbSelectOptions.Visible = false;
                pnlEmployee.Visible = false;
            }
            else
            {
                pnlMonth.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
        }

        private void rdoPaySlip_Click(object sender, EventArgs e)
        {
            if (rdoPaySlip.Checked == true)
            {
                pnlMonth.Visible = true;

                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");

                pnlDepartment.Visible = false;
                gbSelectOptions.Visible = false;
                pnlEmployee.Visible = true;
                txtEmpID.Focus();
            }
            else
            {
                pnlMonth.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
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

        private void rdoPayrollSummary_Click(object sender, EventArgs e)
        {
            if (rdoPayrollSummary.Checked == true)
            {
                pnlMonth.Visible = true;

                cboMonth.DisplayMember = "Value";
                cboMonth.ValueMember = "Key";
                cboMonth.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");

                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
            else
            {
                pnlMonth.Visible = false;
                pnlDepartment.Visible = false;
                pnlEmployee.Visible = false;
                gbSelectOptions.Visible = false;
            }
        }

        private void rdoEmployeeUnderSalary_Click(object sender, EventArgs e)
        {
            pnlMonth.Visible = false;
            pnlDepartment.Visible = false;
            pnlEmployee.Visible = false;
            gbSelectOptions.Visible = false;
        }

    }
}
