using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;
using AH.ModuleController.UI.HR.Reports.Viewer;

using System.Drawing.Imaging;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmSalaryDisverse : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryDisverse()
        {
            InitializeComponent();
        }
        private void frmSalaryDisverse_Load(object sender, EventArgs e)
        {
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonthID.DisplayMember = "Value";
            cboMonthID.ValueMember = "Key";
            cboMonthID.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonthID.Text = DateTime.Now.ToString("MMM-yyyy");

            LoadAccountAmount(cboMonthID.Text.ToString());
        }

        private void LoadAccountAmount(string MonthID)
        {
            List<PayrollRO> oAccounts = hmsSC.GetAccountsPart(cboMonthID.Text.ToString()).ToList();
            if (oAccounts.Count > 0)
            {
                foreach (PayrollRO oAccount in oAccounts)
                {
                    lblBank.Text = oAccount.BankAmount.ToString();
                    lblCash.Text = oAccount.Cash.ToString();
                    lblOthers.Text = oAccount.Others.ToString();
                    lblTotal.Text =(Convert.ToDouble(oAccount.BankAmount.ToString()) + Convert.ToDouble(oAccount.Cash.ToString()) + Convert.ToDouble(oAccount.Others.ToString())).ToString();
                }
            }
        }

        private Payroll PopulatePayroll()
        {
            Payroll oPay = new Payroll();
            oPay.month = cboMonthID.SelectedValue.ToString();
            oPay.year = cboYear.SelectedValue.ToString();

            if (chkDisverse.Checked == true)
            {
                oPay.SalaryLock = "1";
            }
            if (chkDisverse.Checked == false)
            {
                oPay.SalaryLock = "0";
             
            }
            
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPay.EntryParameter = ep;

            return oPay;
        }

        private void btnDisburse_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboYear","cboMonthID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                DialogResult msg = MessageBox.Show("Do You want to Disburse?", "Disbursing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    Payroll oPay = this.PopulatePayroll();               
                    string i = hmsSC.SaveSalaryDisbursing(oPay);
                    if (i == "0")
                    {
                        MessageBox.Show("Salary Disbursing Successfully", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnPrint_Click(sender, e);
                        btnNew.PerformClick();
                    }
                    if (i != "0")
                    {
                        MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (msg == DialogResult.No)
                {
                    return;
                }
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void chkDisverse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisverse.Checked == true)
            {
                btnDisburse.Enabled = true;
            }
            if (chkDisverse.Checked == false)
            {
                btnDisburse.Enabled = false;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.PayrollDetails;
            vr.strMonth = cboMonthID.SelectedValue.ToString();
            vr.ViewReport();
        }
    }
}
