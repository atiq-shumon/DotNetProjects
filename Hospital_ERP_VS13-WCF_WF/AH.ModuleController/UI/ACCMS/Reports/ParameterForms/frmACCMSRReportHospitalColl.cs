using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSRReportHospitalColl : AH.Shared.UI.frmSmartFormReportStandard
    {
        public string strSelection { get; set; }
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();

        #region "BranchConfig"
        private void GetBranchConfig()
        {
            cboCompany.ValueMember = "Key";
            cboCompany.DisplayMember = "Value";
            cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);
        }
        #endregion
        #region "Collection"
        public frmACCMSRReportHospitalColl()
        {
            InitializeComponent();
        }
        #endregion
        #region "Print"
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int intExp = 0;
            if (radColl.Checked == true)
            {
                intExp = 1;
            }
            else
            {
                intExp = 3;
            }
            if (cboCompany.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboCompany.Focus();
            }
            else
            {
                if (radDetails.Checked == true)
                {
                    if (strSelection == "Revenue")
                    {
                        frmReportViewer frm = new frmReportViewer();
                        frm.selector = ViewerSelector.Revenue;
                        frm.strBranchID = cboCompany.SelectedValue.ToString();
                        frm.WhereCondition = "Details";
                        frm.strFromDate = dtStartDate.Text;
                        frm.strToDate = dtEndDate.Text;
                        frm.Where1 = intExp; 
                        frm.ShowDialog();
                    }
                }
                if (radSumm.Checked == true)
                {
                    if (strSelection == "Revenue")
                    {
                        frmReportViewer frm = new frmReportViewer();
                        frm.selector = ViewerSelector.Revenue;
                        frm.strBranchID = cboCompany.SelectedValue.ToString();
                        frm.WhereCondition = "Summarry";
                        frm.strFromDate = dtStartDate.Text;
                        frm.strToDate = dtEndDate.Text;
                        frm.Where1 = intExp; 
                        frm.ShowDialog();
                    }
                }
            }
        }
        #endregion
        #region "formLoad"
        private void frmACCMSRReportHospitalColl_Load(object sender, EventArgs e)
        {
            GetBranchConfig();
            cboCompany.SelectedIndex = 1;
        }
        #endregion 
    }
}
