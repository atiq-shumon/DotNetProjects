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
using AH.ModuleController.UI.HR.Reports.ParameterForms;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmManualSalaryProcess : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmManualSalaryProcess()
        {
            InitializeComponent();
        }

        private void frmManualSalaryProcess_Load(object sender, EventArgs e)
        {
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");
            txtEmpId.Focus();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SalaryCycle> oSal = hmsSC.GetMonthByYear(cboYear.SelectedValue.ToString()).ToList();
            if (oSal.Count > 0)
            {
                cboMonth.DisplayMember = "Month";
                cboMonth.ValueMember = "Month";
                cboMonth.DataSource = oSal;

                cboMonth.Text = DateTime.Now.ToString("MMM-yyyy");
            }
            else
                cboMonth.DataSource = null;
        }
        private Payroll PopulatePayroll()
        {
            Payroll oPay = new Payroll();
            oPay.EmpId = txtEmpId.Text.ToString();
            oPay.year = cboYear.SelectedValue.ToString();
            oPay.month = cboMonth.SelectedValue.ToString();
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPay.EntryParameter = ep;

            return oPay;

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpId", "cboYear", "cboMonth" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Payroll oPay = this.PopulatePayroll();
                string i = hmsSC.saveManualPayroll(oPay);
                if (i == "0")
                {
                    MessageBox.Show("Salary Processed Successfully", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                }
                if (i != "0")
                {
                    MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPayrollReportManager oPay = new frmPayrollReportManager();
            oPay.ShowDialog();
        }

    }
}
