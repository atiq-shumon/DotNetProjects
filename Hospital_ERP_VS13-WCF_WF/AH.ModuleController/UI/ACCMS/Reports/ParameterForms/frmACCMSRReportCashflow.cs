using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.UI.ACCMS.Reports.Viewer;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ACCMS.Reports.ParameterForms
{
    public partial class frmACCMSRReportCashflow : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        DateTime dteFinancialyearform, dteFinancialyearTo;
        public string strSelection { get; set; }
        public frmACCMSRReportCashflow()
        {
            InitializeComponent();
        }

        #region "Load"
        private void GetloadCompany()
        {
            cboCompany.ValueMember = "key";
            cboCompany.DisplayMember = "value";
            cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);
        }
        #endregion
        #region  "Print"

        private bool ValidateFields()
        {
            if (Convert.ToDateTime(dtStartDate.Text.ToString()) < dteFinancialyearform)
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy"));
                dtStartDate.Focus();
                return false;
            }

            if ((Convert.ToDateTime(dtEndDate.Text.ToString()) > dteFinancialyearTo))
            {
                MessageBox.Show("Check Your Financial Year,Financial Year Should be  " + dteFinancialyearform.ToString("dd/MM/yyyy") + " to " + dteFinancialyearTo.ToString("dd/MM/yyyy"));
                dtEndDate.Focus();
                return false;
            }
            if (cboCompany.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboCompany.Focus();
                return false;
            }
            return true;
        }

        private void GetFiscalYear()
        {
            List<FinancialYear> objYear = accmsc.GetActiveFiscalYear().ToList();
            foreach (FinancialYear fy in objYear)
            {
                dteFinancialyearform = Convert.ToDateTime(fy.FinancialYearForm);
                dteFinancialyearTo = Convert.ToDateTime(fy.FinancialYearTo);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (ValidateFields() == false)
            {
                return;
            }
            
            string strControlName = "";
            frmReportViewer frm = new frmReportViewer();
            frm.selector = ViewerSelector.Cashflow;
            frm.strFromDate = dtStartDate.Text;
            frm.strToDate = dtEndDate.Text;
            frm.strBranchID = cboCompany.SelectedValue.ToString();
            frm.strControls = strControlName;
            frm.ShowDialog();
        }
        #endregion 
        #region "FormLoad"
        private void frmACCMSRReportCashflow_Load(object sender, EventArgs e)
        {
            GetFiscalYear();
            GetloadCompany();
            cboCompany.SelectedIndex = 1;
        }
        #endregion

        private void cboCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys.Return )
            {
                dtStartDate.Focus();
            }
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


    }
}
