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
    public partial class frmHRReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmHRReportManager()
        {
            InitializeComponent();
        }

        private void GoToFind()
        {
            string gridFor = "";
            if (txtParam.Text != "")
            {
                txtParam.Focus();
                return;
            }
            if (txtParam.Text == "")
            {
                if (rdoDeptList.Checked == true)
                {
                    //gridFor = "AllDetails";
                    ////frmOPDSearch frm = new frmOPDSearch();
                    //frm.ReportCrieteria = gridFor;
                    //frm.onPrintButtonClicked = new frmOPDSearch.PrintButtonClick(ReturnedData);
                    //frm.ShowDialog();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GoToFind();
        }

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoToFind();
            }
        }

        public void DEPT()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.departmentList;
            ofrmReportViewerHR.ViewReport();
        }
        public void LEAVE()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.LeaveDays;
            ofrmReportViewerHR.strParam = txtParam.Text.ToString();
           
            ofrmReportViewerHR.ViewReport();
        }

        public void EmployeeDetails()
        {

            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.EmployeeDetails;
            ofrmReportViewerHR.strParam = txtParam.Text.ToString();
            ofrmReportViewerHR.strImage= (Utility.EmployeePhotoPath) + txtParam.Text.ToString() + ".JPEG";
            ofrmReportViewerHR.strSignature = (Utility.EmployeeSignaturePath) + txtParam.Text.ToString() + ".JPEG";
            ofrmReportViewerHR.ViewReport();
        }

        public void EmployeeList()
        {
            if (chkDept.Checked == true)
            {
                frmReportViewer ofrmReportViewerHR = new frmReportViewer();
                ofrmReportViewerHR.selector = ViewerSelector.DepartmentWiseEmployeeList;
                ofrmReportViewerHR.strParam = cboDept.SelectedValue.ToString();
                ofrmReportViewerHR.ViewReport();
            }
           if (chkDesig.Checked == true)
            {
                frmReportViewer ofrmReportViewerHR = new frmReportViewer();
                ofrmReportViewerHR.selector = ViewerSelector.DesignationWiseEmployeeList;
                ofrmReportViewerHR.strParam = cboDesig.SelectedValue.ToString();
                ofrmReportViewerHR.ViewReport();

            }
            if (chkDept.Checked == true && chkDesig.Checked == true)
            {
                frmReportViewer ofrmReportViewerHR = new frmReportViewer();
                ofrmReportViewerHR.selector = ViewerSelector.DeptAndDesigWiseEmployeeList;
                ofrmReportViewerHR.strParam = cboDept.SelectedValue.ToString();
                ofrmReportViewerHR.strParam1 = cboDesig.SelectedValue.ToString();
                ofrmReportViewerHR.ViewReport();
            }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {          
            if (rdoDeptList.Checked == true)
            {
                DEPT();                             
            }

             if (rdoLeaveDays.Checked == true)
            {               
                if (txtParam.Text == "")
                {
                    MessageBox.Show("Provide Search Content");
                    txtParam.Focus();
                    return;
                }
                LEAVE();
            }

             else if (rdoEmpDetails.Checked == true)
            {
               
                if (txtParam.Text == "")
                {
                    MessageBox.Show("You Must Provide Search Content for Viewing Report", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParam.Focus();
                    return;
                }
                EmployeeDetails();              
            }

             else if (rdoEmployeeList.Checked == true)
             {
                 if (cboDept.SelectedValue.ToString() == "")
                 {
                     MessageBox.Show("Provide Search Content");
                     cboDept.Focus();
                     return;
                 }
                 EmployeeList();
             }
        }

        private void cboDeptGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDept.DisplayMember = "DepartmentTitle";
            cboDept.ValueMember = "DepartmentID";
            cboDept.DataSource = hmsSC.GetDeptUnderGroup(cboDeptGrp.SelectedValue.ToString()).ToList();
        }

        private void frmHRReportManager_Load(object sender, EventArgs e)
        {
            cboDeptGrp.DisplayMember = "Value";
            cboDeptGrp.ValueMember = "Key";
            cboDeptGrp.DataSource = new BindingSource(hmsSC.GetDeptGroupDictionary("D"), null);

            cboDesigGrp.DisplayMember = "Value";
            cboDesigGrp.ValueMember = "Key";
            cboDesigGrp.DataSource = new BindingSource(hmsSC.GetDesignGrpDictionary("D"), null);


          
        }

        private void cboDesigGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDesig.DisplayMember = "DesignationTitle";
            cboDesig.ValueMember = "DesignationId";
            cboDesig.DataSource = hmsSC.GetDesigUnderGroup(cboDesigGrp.SelectedValue.ToString()).ToList();
        }

        private void rdoEmployeeList_Click(object sender, EventArgs e)
        {
            if (rdoEmployeeList.Checked == true)
            {
                    panelMultiCombo.Visible = true;                                       
            }

        }

        private void rdoEmpMaster_Click(object sender, EventArgs e)
        {
            if (rdoEmpDetails.Checked == true)
            {
                MessageBox.Show("Please Provide Employee ID Number As a Search Content", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtParam.Focus();
                panelMultiCombo.Visible = false;
            }
        }

        private void rdoDeptList_Click(object sender, EventArgs e)
        {
            if (rdoDeptList.Checked == true)
            {
                panelMultiCombo.Visible = false;
            }
        }

        private void rdoLeaveDays_Click(object sender, EventArgs e)
        {
            if (rdoLeaveDays.Checked == true)
            {
                panelMultiCombo.Visible = false;
            }
        }

        private void chkDept_Click(object sender, EventArgs e)
        {
            if (chkDept.Checked == true)
            {              
                cboDeptGrp.Focus();
                cboDept.Focus();
            }           
        }

        private void chkDesig_Click(object sender, EventArgs e)
        {
            if (chkDesig.Checked == true)
            {                     
                cboDesigGrp.Focus();
                cboDesig.Focus();              
                
            }          

        }

    }
}
