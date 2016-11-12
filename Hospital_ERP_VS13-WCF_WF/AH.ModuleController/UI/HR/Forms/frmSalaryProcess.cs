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
    public partial class frmSalaryProcess : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryProcess()
        {
            InitializeComponent();
        }

        private void frmSalaryProcess_Load(object sender, EventArgs e)
        {
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");
           
        }

     
        private Payroll PopulatePayroll()
          {
             Payroll oPay = new Payroll();
            oPay.month = cboMonthID.SelectedValue.ToString();
            oPay.year = cboYear.SelectedValue.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oPay.EntryParameter = ep;

            return oPay;

          }
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonthID.DisplayMember = "Value";
            cboMonthID.ValueMember = "Key";
            cboMonthID.DataSource = new BindingSource(hmsSC.GetMonth(cboYear.SelectedValue.ToString()), null);

            cboMonthID.Text = DateTime.Now.ToString("MMM-yyyy");
            
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear","cboMonthID" };
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
                string i = hmsSC.SavePayroll(oPay);
                if (i == "0")
                {
                    MessageBox.Show("Salary Processed Successfully", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnPrint_Click(sender, e);
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
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DepartmentWisePayroll;
            vr.Mode = "C";
            vr.strDeptGrp = "";
            vr.strDept = "";
            vr.strUnit = "";
            vr.strMonth = cboMonthID.SelectedValue.ToString();
            vr.ViewReport();
        }
    }
}
