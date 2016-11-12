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
    public partial class frmACCMSReportaccounts : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc=new AccountsMSSR.ACCMSWSClient() ;
        public frmACCMSReportaccounts()
        {
            InitializeComponent();
        }

        #region "Reports"
        private void GetloadCompany()
        {
            cboCompany.ValueMember = "key";
            cboCompany.DisplayMember = "value";
            cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);
        }
        private void frmACCMSReportaccounts_Load(object sender, EventArgs e)
        {
            
            GetloadCompany();
            cboCompany.SelectedIndex = 1;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int intType;
            if (cboCompany.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboCompany.Focus();
                return;
            }


            if (radGroup.Checked==true)
            {
                intType=1;
            }
            else
            {
                intType=2;
            }

            if (optTrailBalance.Checked == true)
            {
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.TrailBalance;
                frm.WhereCondition = cboCompany.SelectedValue.ToString();
                frm.Where1 = intType;
                frm.strFromDate = dtStartDate.Text;
                frm.strToDate = dtEndDate.Text;
                frm.ShowDialog();
            }

            else if (optBalanceSheet.Checked == true)
            {
                //MessageBox.Show ("Under Contstruction");
                //return;
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.BalanceSheet;
                frm.WhereCondition = cboCompany.SelectedValue.ToString();
                frm.strFromDate = dtStartDate.Text;
                frm.strToDate = dtEndDate.Text;
                frm.ShowDialog();

            }
            else if (optProfitLoss.Checked == true)
            {
                //MessageBox.Show("Under Contstruction");
                //return;
                frmReportViewer frm = new frmReportViewer();
                frm.selector = ViewerSelector.ProfitLoss ;
                frm.WhereCondition = cboCompany.SelectedValue.ToString();
                frm.strFromDate = dtStartDate.Text;
                frm.strToDate = dtEndDate.Text;
                frm.ShowDialog();
            }
        }
        private void cboCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dtStartDate.Focus();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dtStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dtEndDate.Focus();
            }
        }
        private void dtEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnPrint.Focus();
            }
        }
        #endregion

        private void optBalanceSheet_CheckedChanged(object sender, EventArgs e)
        {
            grpselectiontype.Visible = false;
        }

        private void optProfitLoss_CheckedChanged(object sender, EventArgs e)
        {
            grpselectiontype.Visible = false;
        }

        private void optTrailBalance_CheckedChanged(object sender, EventArgs e)
        {
            //grpselectiontype.Visible = true;
        }

      
    }
}
