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
    public partial class frmLeaveReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmLeaveReportManager()
        {
            InitializeComponent();
        }

        private void frmLeaveReportManager_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2030), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            rdoEmpLeaveRegister.Checked = true;          
        }
        public void DeptWiseLeave()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.DepartmentWiseLeaveDetails;
            if(rdoAll.Checked==true)
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
            ofrmReportViewerHR.strYear = cboYear.SelectedValue.ToString();
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();            
            ofrmReportViewerHR.ViewReport();
        }

        public void AllLeaveRequisition()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.LeaveRequisition;
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
            ofrmReportViewerHR.strYear = cboYear.SelectedValue.ToString();
            ofrmReportViewerHR.strDeptGrp = cboDepartmentGroup.SelectedValue.ToString();
            ofrmReportViewerHR.strDept = cboDepartment.SelectedValue.ToString();
            ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }

        public void EmployeeDetailsLeave()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeLeaveRegister;
            ofrmReportViewerHR.strEmpID =  txtEmpId.Text.ToString();
            ofrmReportViewerHR.strYear = cboYear.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void EmployeeLeaveTemplate()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeLeaveTemplate;
            ofrmReportViewerHR.strParam1 = txtEmpId.Text.ToString();
            ofrmReportViewerHR.strParam2 = txtSerial.Text.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        public void HolidayCalender()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.HolidayCalender;
            ofrmReportViewerHR.strParam = cboYear.SelectedValue.ToString();
            ofrmReportViewerHR.ViewReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdoDeptWiseLeave.Checked == true)
            {
                if (cboDepartment.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Provide Search Content");
                    cboDepartment.Focus();
                    return;
                }
                DeptWiseLeave();
            }

            if (rdoDeptWiseLeaveReq.Checked == true)
            {
                AllLeaveRequisition();
            }

            if (rdoleaveTemplate.Checked == true)
            {
                EmployeeLeaveTemplate();
            }

            if (rdoHolidayCalender.Checked == true)
            {
                if (cboYear.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Provide Search Content");
                    cboYear.Focus();
                    return;
                }
                HolidayCalender();

            }

            if (rdoEmpLeaveRegister.Checked == true)
            {
                txtEmpId.Focus();
               
                if (txtEmpId.Text.ToString() == "")
                {
                    MessageBox.Show("Provide Employee ID as Search Content");
                    txtEmpId.Focus();
                    return;
                }
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtEmpId.Text);

                if (txtEmpId.Text == oEmpMas.EmpId)
                {
                    EmployeeDetailsLeave();
                }
                else
                {
                    MessageBox.Show("Invalid EmployeeID",Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

        private void rdoEmpLeaveRegister_CheckedChanged(object sender, EventArgs e)
        {
            gbSelectOptions.Visible = false;
            pnlDepartment.Visible = false;
            pnlEmployee.Visible = true;
            pnlYear.Visible = true;
            pnlSerial.Visible = false;
        }

        private void rdoDeptWiseLeave_CheckedChanged(object sender, EventArgs e)
        {
            gbSelectOptions.Visible = true;
            pnlDepartment.Visible = true;
            pnlEmployee.Visible = false;
            pnlYear.Visible = true;
            pnlSerial.Visible = false;
            rdoAll.Checked = true;
        }

        private void rdoHolidayCalender_CheckedChanged(object sender, EventArgs e)
        {
            gbSelectOptions.Visible = false;
            pnlDepartment.Visible = false;
            pnlEmployee.Visible = false;
            pnlYear.Visible = true;
            pnlSerial.Visible = false;
        }

        private void rdoleaveTemplate_CheckedChanged(object sender, EventArgs e)
        {
            gbSelectOptions.Visible = false;
            pnlDepartment.Visible = false;
            pnlEmployee.Visible = true;
            pnlYear.Visible = false;
            pnlSerial.Visible = true;
        }

        private void rdoDeptWiseLeaveReq_CheckedChanged(object sender, EventArgs e)
        {
            gbSelectOptions.Visible = true;
            pnlDepartment.Visible = true;
            pnlEmployee.Visible = false;
            pnlYear.Visible = true;
            pnlSerial.Visible = false;
            rdoAll.Checked = true;
        }
    }
}
