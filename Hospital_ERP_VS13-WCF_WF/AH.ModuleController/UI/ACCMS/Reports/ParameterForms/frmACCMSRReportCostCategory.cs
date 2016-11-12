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
    public partial class frmACCMSRReportCostCategory : AH.Shared.UI.frmSmartFormReportStandard
    {
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        public string strSelection { get; set; }
        public frmACCMSRReportCostCategory()
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
        private void GetCostCategory()
        {
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            cboLedgerName.DataSource = new BindingSource(accmsc.LoadCategory(), null);

        }
        private void GetLedgerInformation(string strControl)
        {
            cboLedgerName.ValueMember = "Key";
            cboLedgerName.DisplayMember = "Value";
            cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);
        }
        private void frmACCMSRReportCostCategory_Load(object sender, EventArgs e)
        {
            strSelection = "CategoryLedgerReport";
            GetloadCompany();
            if (radLedgerWise.Checked == true)
            {
                GetLedgerInformation("Ledger");
                strSelection = "CategoryLedgerReport";
            }
            else
            {
                GetCostCategory();
                strSelection = "CategoryReport";
            }
            cboCompany.SelectedIndex = 1;
        }
        #endregion
        #region "Changed"
        private void radLedgerWise_CheckedChanged(object sender, EventArgs e)
        {
            if (radLedgerWise.Checked == true)
            {
                GetLedgerInformation("Ledger");
                strSelection = "CategoryLedgerReport";
            }
            else
            {
                GetCostCategory();
                strSelection = "CategoryReport";
            }
        }
        private void radCostcategory_CheckedChanged(object sender, EventArgs e)
        {
            if (radLedgerWise.Checked == true)
            {
                GetLedgerInformation("Ledger");
            }
            else
            {
                GetCostCategory();
            }
        }
        #endregion
        #region "Print"
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cboCompany.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboCompany.Focus();
            }
            else if (cboLedgerName.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboLedgerName.Focus();

            }
            else
            {
                if (strSelection == "CategoryReport")
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.CategoryReport;
                    frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
                    frm.LedgerName = cboLedgerName.Text.ToString();
                    frm.strBranchID = cboCompany.SelectedValue.ToString();
                    frm.strFromDate = dtStartDate.Text;
                    frm.strToDate = dtEndDate.Text;
                    frm.ShowDialog();
                }
                else if (strSelection == "CategoryLedgerReport")
                {
                    frmReportViewer frm = new frmReportViewer();
                    frm.selector = ViewerSelector.CategoryLedgerReport;
                    frm.WhereCondition = cboLedgerName.SelectedValue.ToString();
                    frm.LedgerName = cboLedgerName.Text.ToString();
                    frm.strBranchID = cboCompany.SelectedValue.ToString();
                    frm.strFromDate = dtStartDate.Text;
                    frm.strToDate = dtEndDate.Text;
                    frm.ShowDialog();
                }
            }
        }
        #endregion
        #region "Keypress"
        private void cboLedgerName_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
            if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Down) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.PageUp) ||
                (e.KeyCode == Keys.PageDown) ||
                (e.KeyCode == Keys.Home) ||
                (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboLedgerName.Text;

            // Find the first match for the typed value.
            index = this.cboLedgerName.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboLedgerName.Items[index].ToString();

                // Select this item from the list.
                this.cboLedgerName.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboLedgerName.SelectionStart = actual.Length;
                this.cboLedgerName.SelectionLength = found.Length;
            }
        }
        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
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
        #endregion
    }
}
