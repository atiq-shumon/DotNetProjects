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
    public partial class frmEmployeeReportManager : AH.Shared.UI.frmSmartFormReportStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmEmployeeReportManager()
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
        public void LEAVE()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.LeaveDays;
            ofrmReportViewerHR.strParam = txtParam.Text.ToString();
           
            ofrmReportViewerHR.ViewReport();
        }
        public void AllEmployeeList()
        {
            frmReportViewer ofrmReportViewerHR = new frmReportViewer();
            ofrmReportViewerHR.selector = ViewerSelector.AllEmpList;
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
            if (chkDept.Checked == true && chkDesig.Checked == false)
            {
                frmReportViewer ofrmReportViewerHR = new frmReportViewer();               
                if (cboDeptType.SelectedValue.ToString() != "" && cboDeptGrp.SelectedValue.ToString() != "" & cboDept.SelectedValue.ToString() != "")
                {
                    ofrmReportViewerHR.selector = ViewerSelector.DeptTypeGrpDeptUnitWise;
                    ofrmReportViewerHR.strDeptType = cboDeptType.SelectedValue.ToString();
                    ofrmReportViewerHR.strDeptGrp = cboDeptGrp.SelectedValue.ToString();
                    ofrmReportViewerHR.strDept = cboDept.SelectedValue.ToString();
                    ofrmReportViewerHR.strUnit = cboUnit.SelectedValue.ToString();
                }
                   ofrmReportViewerHR.ViewReport();
            }
            if (chkDesig.Checked == true && chkDept.Checked == false)
            {
                if (cboDesigGrp.SelectedValue != "")
                {
                    if (cboDesig.SelectedValue != null)
                    {
                        frmReportViewer ofrmReportViewerHR = new frmReportViewer();
                        ofrmReportViewerHR.selector = ViewerSelector.DesignationWiseEmployeeList;
                        ofrmReportViewerHR.strParam = cboDesig.SelectedValue.ToString();
                        ofrmReportViewerHR.ViewReport();
                    }
                }

            }
           else if (chkDept.Checked == true && chkDesig.Checked == true)
           {
               if (cboDeptGrp.SelectedValue.ToString() != "" & cboDept.SelectedValue.ToString() != "" && cboDesigGrp.SelectedValue != "" && cboDesig.SelectedValue != null)
               {
                   frmReportViewer ofrmReportViewerHR = new frmReportViewer();
                   ofrmReportViewerHR.selector = ViewerSelector.DeptAndDesigWiseEmployeeList;
                   ofrmReportViewerHR.strParam = cboDept.SelectedValue.ToString();
                   ofrmReportViewerHR.strParam1 = cboDesig.SelectedValue.ToString();
                   ofrmReportViewerHR.ViewReport();
               }
           }
           
        }     
        private void btnPrint_Click(object sender, EventArgs e)
        {          
           
             if (rdoLeaveDays.Checked == true)
            {               
                if (txtParam.Text == "")
                {
                    MessageBox.Show("Please Provide Employee ID as a Search Content");
                    txtParam.Focus();
                    return;
                }
                LEAVE();
            }

             if (rdoEmpDetails.Checked == true)
            {
               
                if (txtParam.Text == "")
                {
                    MessageBox.Show("You Must Provide Search Content for Viewing Report", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtParam.Focus();
                    return;
                }
                EmployeeDetails();              
            }

             if (rdoEmployeeList.Checked == true)
             {               
                 EmployeeList();
             }

             if (rdoAllEmpList.Checked == true)
             {
                 AllEmployeeList();
             }          
        }

        private void cboDeptGrp_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (cboDeptGrp.SelectedValue != null)
            {
                cboDept.DisplayMember = "Value";
                cboDept.ValueMember = "Key";
                cboDept.DataSource = new BindingSource(hmsSC.GetDepartmentsetupDic(null, cboDeptGrp.SelectedValue.ToString()), null);
            }
        }
        private void frmHRReportManager_Load(object sender, EventArgs e)
        {
            cboDeptType.DisplayMember = "Value";
            cboDeptType.ValueMember = "Key";
            cboDeptType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
            
            rdoAllEmpList.Checked = true;
          
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
                    gbInformationControlls.Visible = false;
                    pnlType.Visible = false;  
            }
        }

        private void rdoEmpMaster_Click(object sender, EventArgs e)
        {
            if (rdoEmpDetails.Checked == true)
            {               
                panelMultiCombo.Visible = false;
                gbInformationControlls.Visible = true;
                pnlType.Visible = false;
                txtParam.Focus();
            }
        }

        private void rdoLeaveDays_Click(object sender, EventArgs e)
        {
            if (rdoLeaveDays.Checked == true)
            {
                panelMultiCombo.Visible = false;
                gbInformationControlls.Visible = true; 
            }
        }    
        private void cboDeptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptType.SelectedValue != null)
            {
                cboDeptGrp.DisplayMember = "Value";
                cboDeptGrp.ValueMember = "Key";
                cboDeptGrp.DataSource = new BindingSource(hmsSC.GetDeptGroupDicByType(cboDeptType.SelectedValue.ToString()), null);

                cboDesigGrp.DisplayMember = "Value";
                cboDesigGrp.ValueMember = "Key";
                cboDesigGrp.DataSource = new BindingSource(hmsSC.GetDesignGrpTypeDict(cboDeptType.SelectedValue.ToString()), null);
            }        
        }

        private void cboDeptCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptCatagory.SelectedValue != null)
            {
                cboDeptGrp.DisplayMember = "Value";
                cboDeptGrp.ValueMember = "Key";
                cboDeptGrp.DataSource = new BindingSource(hmsSC.GetGroupCategory(cboDeptCatagory.SelectedValue.ToString()),null);
            }
        }

        private void rdoAllEmpList_Click(object sender, EventArgs e)
        {
            gbInformationControlls.Visible = false;           
            panelMultiCombo.Visible = false;
            pnlType.Visible = false;
        }

        private void chkDept_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDept.Checked == true)
            {
                pnlDept.Visible = true;
                pnlType.Visible = true;
            }
            if (chkDept.Checked == false)
            {
                pnlDept.Visible = false;
                pnlType.Visible = true;
            } 
        }

        private void chkDesig_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesig.Checked == true)
            {
                pnlDesig.Visible = true;
                pnlType.Visible = true;
            }
            if (chkDesig.Checked == false)
            {
                pnlDesig.Visible = false;
                pnlType.Visible = true;
            } 
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDept.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic(cboDeptGrp.SelectedValue.ToString(), cboDept.SelectedValue.ToString())), null);
            }
        }

    }
}
