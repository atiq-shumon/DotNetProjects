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
using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmLeaveApproved : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public Boolean Chk;

        public string ApprovedByRprPrsn { set; get; }
        public string ApprovedByRprPrsnName { set; get; }
        public string ApprovedByHead { set; get; }
        public string ApprovedByHeadName { set; get; }
        public string ApprovedByHR { set; get; }
        public string ApprovedByHRName { set; get; }
        public string EmpId { set; get; }
        public string LeaveTypeId { set; get; }
        public string LeaveSerial { set; get; }
        public string Flag { set; get; }
        private short CallMode;
      
        public frmLeaveApproved()
        {
            InitializeComponent();
        }
      
        private void frmLeaveApprovedByHead_Load(object sender, EventArgs e)
        {
            cboCancelCauseRpt.DisplayMember = "Value";
            cboCancelCauseRpt.ValueMember = "Key";
            cboCancelCauseRpt.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);

            cboCancelCauseHead.DisplayMember = "Value";
            cboCancelCauseHead.ValueMember = "Key";
            cboCancelCauseHead.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);

            cboCancelCauseHR.DisplayMember = "Value";
            cboCancelCauseHR.ValueMember = "Key";
            cboCancelCauseHR.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2010, 2030), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            cboLeaveType.DisplayMember = "Value";
            cboLeaveType.ValueMember = "Key";
            cboLeaveType.DataSource = new BindingSource(hmsSC.GetLeaveID(cboYear.SelectedValue.ToString()), null);

            cboLeaveCause.DisplayMember = "Value";
            cboLeaveCause.ValueMember = "Key";
            cboLeaveCause.DataSource = new BindingSource(Utility.GetLeaveCauses(), null);

            ModeSelector();           
        }
        private void ModeSelector()
        {
            EmpLeaveRegister oEmp = new EmpLeaveRegister();
            oEmp = hmsSC.GetLeaveReg(EmpId, LeaveTypeId, LeaveSerial);
            if (EmpId == null)
            {
                return;
            }
            if (EmpId != null)
            {
                if (oEmp.ReptPrsnAppFlag == "0")
                {
                    pnlHead.Enabled = false;
                    pnlHR.Enabled = false;
                    CallMode = 1;
                    txtEmp.Text = EmpId;
                    cboLeaveType.SelectedValue = oEmp.LeaveType.TypeID;
                    cboYear.Text = oEmp.year;
                    cboLeaveCause.SelectedValue = oEmp.LeaveCauseFlag;
                    txtResponsibility.Text = oEmp.ResponsibilityHolderID;
                    txtStartDate.Text = oEmp.StartDate.ToString();
                    txtEndDate.Text = oEmp.EndDate.ToString();
                    txtAddress.Text = oEmp.AddrtessWhileOnLeave.ToString();
                    txtApprovedByRpt.Text = ApprovedByRprPrsn;
                    txtserial.Text = LeaveSerial;
                    txtResponsibilityHolderName.Text = oEmp.ResponsibilityHolderName;
                    txtEmpName.Text = oEmp.EmployeeMaster.Name;
                    txtApprvdByRptName.Text = ApprovedByRprPrsnName;
                    txtTotalDays.Text = oEmp.LeaveDays.ToString();
                    txtLeaveWithPay.Text = oEmp.WithPayDays.ToString();
                    txtLeaveWithoutpay.Text = oEmp.WithoutPayDays.ToString();
                }
                if (oEmp.DeptAppFlag == "0" && oEmp.ReptPrsnAppFlag == "1")
                {
                    pnlRptPrsn.Enabled = false;
                    pnlHR.Enabled = false;
                    CallMode = 2;
                    txtEmp.Text = EmpId;
                    cboLeaveType.SelectedValue = oEmp.LeaveType.TypeID;
                    cboYear.Text = oEmp.year;
                    cboLeaveCause.SelectedValue = oEmp.LeaveCauseFlag;
                    txtResponsibility.Text = oEmp.ResponsibilityHolderID;
                    txtStartDate.Text = oEmp.StartDate.ToString();
                    txtEndDate.Text = oEmp.EndDate.ToString();
                    txtAddress.Text = oEmp.AddrtessWhileOnLeave.ToString();
                    txtApprovedByHead.Text = ApprovedByHead;
                    txtserial.Text = LeaveSerial;
                    txtResponsibilityHolderName.Text = oEmp.ResponsibilityHolderName;
                    txtEmpName.Text = oEmp.EmployeeMaster.Name;
                    txtApprovedByRpt.Text = oEmp.ReportingPersonID.ToString();
                    txtApprvdByRptName.Text = oEmp.ReportingPersonName.ToString();
                    txtApprovedByHeadName.Text = ApprovedByHeadName;
                    txtTotalDays.Text = oEmp.LeaveDays.ToString();
                    txtLeaveWithPay.Text = oEmp.WithPayDays.ToString();
                    txtLeaveWithoutpay.Text = oEmp.WithoutPayDays.ToString();
                    if (Convert.ToInt16(oEmp.ReptPrsnAppFlag) == 1)
                    {
                        chkAppRptYes.Checked = true;
                        chkAppRptNo.Checked = false;
                        cboCancelCauseRpt.Enabled = false;
                        btnAddCancelCauseRpt.Enabled = false;
                        btnRefreshCancelCauseRptPrsn.Enabled = false;
                    }
                    else
                    {
                        chkAppRptYes.Checked = false;
                        chkAppRptNo.Checked = true;
                        cboCancelCauseRpt.Enabled = true;
                        btnAddCancelCauseRpt.Enabled = true;
                        btnRefreshCancelCauseRptPrsn.Enabled = true;
                    }
                }
                if (oEmp.ReptPrsnAppFlag == "1" && oEmp.DeptAppFlag == "1")
                {
                    pnlRptPrsn.Enabled = false;
                    pnlHead.Enabled = false;
                    txtStartDate.ReadOnly = true;
                    txtEndDate.ReadOnly = true;
                    txtResponsibilityHolderName.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtEmpName.ReadOnly = true;                   
                    CallMode = 3;
                    txtEmp.Text = EmpId;
                    cboLeaveType.SelectedValue = oEmp.LeaveType.TypeID;
                    cboYear.Text = oEmp.year;
                    cboLeaveCause.SelectedValue = oEmp.LeaveCauseFlag;
                    txtResponsibility.Text = oEmp.ResponsibilityHolderID;
                    txtStartDate.Text = oEmp.StartDate.ToString();
                    txtEndDate.Text = oEmp.EndDate.ToString();
                    txtAddress.Text = oEmp.AddrtessWhileOnLeave.ToString();
                    txtApprovedByRpt.Text = oEmp.ReportingPersonID.ToString();
                    txtApprvdByRptName.Text = oEmp.ReportingPersonName.ToString();
                    txtApprovedByHead.Text = oEmp.ApprovedByID.ToString();
                    txtApprovedByHeadName.Text = oEmp.ApprovedByName.ToString();
                    txtTotalDays.Text = oEmp.LeaveDays.ToString();
                    txtLeaveWithPay.Text = oEmp.WithPayDays.ToString();
                    txtLeaveWithoutpay.Text = oEmp.WithoutPayDays.ToString();

                    if (Convert.ToInt16(oEmp.ReptPrsnAppFlag) == 1)
                    {
                        chkAppRptYes.Checked = true;
                        chkAppRptNo.Checked = false;
                        cboCancelCauseRpt.Enabled = false;
                        btnAddCancelCauseRpt.Enabled = false;
                        btnRefreshCancelCauseRptPrsn.Enabled = false;
                    }
                    else
                    {
                        chkAppRptYes.Checked = false;
                        chkAppRptNo.Checked = true;
                        cboCancelCauseRpt.Enabled = true;
                        btnAddCancelCauseRpt.Enabled = true;
                        btnRefreshCancelCauseRptPrsn.Enabled = true;
                    }

                    if (Convert.ToInt16(oEmp.DeptAppFlag) == 1)
                    {
                        chkAppHeadYes.Checked = true;
                        chkAppHeadNo.Checked = false;
                        cboCancelCauseHead.Enabled = false;
                        btnAddCauseHD.Enabled = false;
                        btnRefreshCauseHD.Enabled = false;
                    }
                    else
                    {
                        chkAppHeadYes.Checked = false;
                        chkAppHeadNo.Checked = true;
                        cboCancelCauseHead.Enabled = true;
                        btnAddCauseHD.Enabled = true;
                        btnRefreshCauseHD.Enabled = true;
                    }

                    txtRemarksHead.Text = oEmp.Remarks.ToString();
                    cboCancelCauseHead.Text = oEmp.CancelCauseID;
                    cboCancelCauseRpt.Text = oEmp.CancelCauseRptPrsn;

                    txtApprovedByHR.Text = ApprovedByHR;
                    txtserial.Text = LeaveSerial;
                    txtResponsibilityHolderName.Text = oEmp.ResponsibilityHolderName;
                    txtEmpName.Text = oEmp.EmployeeMaster.Name;
                    txtApprovedByHRName.Text = ApprovedByHRName;
                }
            }
        }
     
        private void chkAppHead_Click(object sender, EventArgs e)
        {
            if (chkAppHeadYes.Checked == true)
            {
                chkAppHeadNo.Checked = false;
                lblCancelCauseHd.Enabled = false;
                cboCancelCauseHead.Enabled = false;
            }
            else
            {
                chkAppHeadNo.Checked = true;
                chkAppHeadYes.Checked = false;
                lblCancelCauseHd.Enabled = true;
                cboCancelCauseHead.Enabled = true;               
            }
        }

        private EmpLeaveRegister UpdateLeaveRegister()
        {
            EmpLeaveRegister oEmpLeaveRegis = new EmpLeaveRegister();

            EmployeeMaster oEmpMas = new EmployeeMaster();
            EmployeeMaster oEmpMaster = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmp.Text);
            oEmpMaster = hmsSC.GetEmpMaster(Utility.UserId);

            if (txtEmp.Text == oEmpMas.EmpId)
            {
                txtTO.Text = oEmpMas.Email.ToString();
                txtFrom.Text = oEmpMaster.Email.ToString();

                if (CallMode == 1)
                {
                    oEmpLeaveRegis.Mode = "1";
                    oEmpMas.EmpId = txtEmp.Text;
                    oEmpLeaveRegis.EmployeeMaster = oEmpMas;
                    oEmpLeaveRegis.year = cboYear.SelectedValue.ToString();
                    oEmpLeaveRegis.Serial = txtserial.Text.ToString();
                    oEmpLeaveRegis.WithPayDays =Convert.ToDouble(txtLeaveWithPay.Text.ToString());
                    oEmpLeaveRegis.WithoutPayDays = Convert.ToDouble(txtLeaveWithoutpay.Text.ToString());

                    LeaveType oLvTp = new LeaveType();
                    oLvTp.TypeID = cboLeaveType.SelectedValue.ToString();
                    oEmpLeaveRegis.LeaveType = oLvTp;

                    if (txtStartDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.StartDate = null;
                    }
                    if (txtEndDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.EndDate = null;
                    }
                    oEmpLeaveRegis.LeaveCauseFlag = cboLeaveCause.SelectedValue.ToString();
                    oEmpLeaveRegis.AddrtessWhileOnLeave = txtAddress.Text;
                    oEmpLeaveRegis.ResponsibilityHolderID = txtResponsibility.Text.ToString();
                    oEmpLeaveRegis.ReportingPersonID = txtApprovedByRpt.Text.ToString();
                    if (chkAppRptYes.Checked == true)
                    {
                        oEmpLeaveRegis.ReptPrsnAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseRptPrsn = "";
                    }
                    if (chkAppRptNo.Checked == true)
                    {
                        oEmpLeaveRegis.ReptPrsnAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseRptPrsn = cboCancelCauseRpt.SelectedValue.ToString();
                    }
                    oEmpLeaveRegis.ApprovedByID = "";
                    oEmpLeaveRegis.DeptAppFlag = "0";
                    oEmpLeaveRegis.CancelCauseID = "";
                    oEmpLeaveRegis.Remarks = "";
                    oEmpLeaveRegis.ApprovedByHR = "";
                    oEmpLeaveRegis.HrAppFlag = "0";
                    oEmpLeaveRegis.NotificationFlag = "0";
                    oEmpLeaveRegis.CancelCauseIDHr = "";
                    oEmpLeaveRegis.RemarksHR = " ";
                }

                if (CallMode == 2)
                {
                    oEmpLeaveRegis.Mode = "2";
                    oEmpMas.EmpId = txtEmp.Text;
                    oEmpLeaveRegis.EmployeeMaster = oEmpMas;
                    oEmpLeaveRegis.year = cboYear.SelectedValue.ToString();
                    oEmpLeaveRegis.Serial = txtserial.Text.ToString();
                    oEmpLeaveRegis.WithPayDays = Convert.ToDouble(txtLeaveWithPay.Text.ToString());
                    oEmpLeaveRegis.WithoutPayDays = Convert.ToDouble(txtLeaveWithoutpay.Text.ToString());

                    LeaveType oLvTp = new LeaveType();
                    oLvTp.TypeID = cboLeaveType.SelectedValue.ToString();
                    oEmpLeaveRegis.LeaveType = oLvTp;

                    if (txtStartDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.StartDate = null;
                    }
                    if (txtEndDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.EndDate = null;
                    }
                    oEmpLeaveRegis.LeaveCauseFlag = cboLeaveCause.SelectedValue.ToString();
                    oEmpLeaveRegis.AddrtessWhileOnLeave = txtAddress.Text;
                    oEmpLeaveRegis.ResponsibilityHolderID = txtResponsibility.Text.ToString();
                    oEmpLeaveRegis.ReportingPersonID = txtRemarksRptPrsn.Text.ToString();
                    if (chkAppRptYes.Checked == true)
                    {
                        oEmpLeaveRegis.ReptPrsnAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseRptPrsn = "";
                    }
                    if (chkAppRptYes.Checked == false)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseRptPrsn = cboCancelCauseRpt.SelectedValue.ToString();
                    }

                    oEmpLeaveRegis.ApprovedByID = txtApprovedByHead.Text.ToString();
                    if (chkAppHeadYes.Checked == true)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseID = "";
                    }
                    if (chkAppHeadYes.Checked == false)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseID = cboCancelCauseHead.SelectedValue.ToString();
                    }
                    oEmpLeaveRegis.Remarks = txtRemarksHead.Text.ToString();

                    oEmpLeaveRegis.ApprovedByHR = "";
                    oEmpLeaveRegis.HrAppFlag = "0";
                    oEmpLeaveRegis.NotificationFlag = "0";
                    oEmpLeaveRegis.CancelCauseIDHr = "";
                    oEmpLeaveRegis.RemarksHR = " ";
                }
                if (CallMode == 3)
                {
                    oEmpLeaveRegis.Mode = "3";
                    oEmpMas.EmpId = txtEmp.Text;
                    oEmpLeaveRegis.EmployeeMaster = oEmpMas;
                    oEmpLeaveRegis.year = cboYear.SelectedValue.ToString();
                    oEmpLeaveRegis.Serial = txtserial.Text.ToString();
                    oEmpLeaveRegis.WithPayDays = Convert.ToDouble(txtLeaveWithPay.Text.ToString());
                    oEmpLeaveRegis.WithoutPayDays = Convert.ToDouble(txtLeaveWithoutpay.Text.ToString());

                    LeaveType oLvTp = new LeaveType();
                    oLvTp.TypeID = cboLeaveType.SelectedValue.ToString();
                    oEmpLeaveRegis.LeaveType = oLvTp;

                    if (txtStartDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.StartDate = null;
                    }
                    if (txtEndDate.Text != "  /  /")
                    {
                        oEmpLeaveRegis.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                    }
                    else
                    {
                        oEmpLeaveRegis.EndDate = null;
                    }
                    oEmpLeaveRegis.LeaveCauseFlag = cboLeaveCause.SelectedValue.ToString();
                    oEmpLeaveRegis.AddrtessWhileOnLeave = txtAddress.Text;
                    oEmpLeaveRegis.ResponsibilityHolderID = txtResponsibility.Text.ToString();
                    oEmpLeaveRegis.ReportingPersonID = txtApprovedByRpt.Text.ToString();
                    oEmpLeaveRegis.ApprovedByID = txtApprovedByHead.Text.ToString();

                    if (chkAppRptYes.Checked == true)
                    {
                        oEmpLeaveRegis.ReptPrsnAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseRptPrsn = "";
                    }
                    if (chkAppRptYes.Checked == false)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseRptPrsn = cboCancelCauseRpt.SelectedValue.ToString();
                    }

                    if (chkAppHeadYes.Checked == true)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseID = "0";
                    }
                    if (chkAppHeadYes.Checked == false)
                    {
                        oEmpLeaveRegis.DeptAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseID = cboCancelCauseHead.SelectedValue.ToString();
                    }

                    oEmpLeaveRegis.Remarks = txtRemarksHead.Text.ToString();

                    oEmpLeaveRegis.ApprovedByHR = txtApprovedByHR.Text.ToString();
                    if (chkAppHRYes.Checked == true)
                    {
                        oEmpLeaveRegis.HrAppFlag = "1";
                        oEmpLeaveRegis.CancelCauseIDHr = "0";
                    }
                    else
                    {
                        oEmpLeaveRegis.HrAppFlag = "0";
                        oEmpLeaveRegis.CancelCauseIDHr = cboCancelCauseHR.SelectedValue.ToString();
                    }
                    oEmpLeaveRegis.NotificationFlag = "0";
                    oEmpLeaveRegis.RemarksHR = txtRemarksHR.Text.ToString();
                }
                oEmpLeaveRegis.LeaveDocPath = "C";
                oEmpLeaveRegis.MailTO = txtTO.Text.ToString();
                oEmpLeaveRegis.MailFrom = txtFrom.Text.ToString();

                EntryParameter ep = new EntryParameter();
                ep.CompanyID = Utility.CompanyID;
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = Utility.UserId;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oEmpLeaveRegis.EntryParameter = ep;

            }
            else
            {
                MessageBox.Show("Invalid Employee ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oEmpLeaveRegis;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "txtEmpName", "cboLeaveType", "txtStartDate", "txtEndDate", "cboLeaveCause", "txtResponsibilityHolderName", "txtAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (CallMode == 1)
            {
                if (chkAppRptYes.Checked == false && chkAppRptNo.Checked == false)
                {
                    MessageBox.Show("Please Select Approval Type", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chkAppRptNo.Checked == true)
                {
                    if (cboCancelCauseRpt.SelectedValue == "")
                    {
                        MessageBox.Show("Please Select a Cancel Cause", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboCancelCauseRpt.Focus();
                        return;
                    }
                }
            }

            if (CallMode == 2)
            {
                if (chkAppHeadYes.Checked == false && chkAppHeadNo.Checked==false)
                {
                    MessageBox.Show("Please Select Approval Type", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chkAppHeadNo.Checked==true)
                {
                    if(cboCancelCauseHead.SelectedValue =="")
                    {
                        MessageBox.Show("Please Select a Cancel Cause", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboCancelCauseHead.Focus();
                        return;
                    }
                }
            }
            if (CallMode == 3)
            {
                if (chkAppHRYes.Checked == false && chkAppHRNo.Checked == false)
                {
                    MessageBox.Show("Please Select Approval Type", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chkAppHRNo.Checked == true)
                {
                    if (cboCancelCauseHR.SelectedValue == "")
                    {
                        MessageBox.Show("Please Select a Cancel Cause", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboCancelCauseHR.Focus();
                        return;
                    }
                }
            }

            try
            {
                EmpLeaveRegister oEmpLeaveRegis = this.UpdateLeaveRegister();
                if ((Convert.ToDouble(txtLeaveWithPay.Text.ToString()) + Convert.ToDouble(txtLeaveWithoutpay.Text.ToString())) != Convert.ToDouble(txtTotalDays.Text.ToString()))
                {
                    MessageBox.Show("Please Correct Leave Days!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    short i = hmsSC.UpdateLeaveRegister(oEmpLeaveRegis);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClose.PerformClick();
                    }

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
        private void chkAppHRYes_Click(object sender, EventArgs e)
        {
            if (chkAppHRYes.Checked == true)
            {
                chkAppHRNo.Enabled = false;
                lblCancelCauseHR.Enabled = false;
                cboCancelCauseHR.Enabled = false;
            }
            else
            {
                lblCancelCauseHR.Enabled = true;
                chkAppHRYes.Enabled = false;
                cboCancelCauseHR.Enabled = true;
                chkAppHRNo.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            EmpId= "";
        }
        private void btnAddCauseHD_Click(object sender, EventArgs e)
        {
            frmLeaveCancelCause oCancelCause = new frmLeaveCancelCause();
            oCancelCause.ShowDialog();
        }

        private void btnRefreshCauseHD_Click(object sender, EventArgs e)
        {
            cboCancelCauseHead.DisplayMember = "Value";
            cboCancelCauseHead.ValueMember = "Key";
            cboCancelCauseHead.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);
        }

        private void btnAddCauseHR_Click(object sender, EventArgs e)
        {
            frmLeaveCancelCause oCancelCause = new frmLeaveCancelCause();
            oCancelCause.ShowDialog();
        }

        private void btnRefreshCauseHR_Click(object sender, EventArgs e)
        {
            cboCancelCauseHR.DisplayMember = "Value";
            cboCancelCauseHR.ValueMember = "Key";
            cboCancelCauseHR.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);
        }

        private void chkAppHeadNo_Click(object sender, EventArgs e)
        {
            if (chkAppHeadNo.Checked == true)
            {
                chkAppHeadYes.Checked = false;
                lblCancelCauseHd.Enabled = true;
                cboCancelCauseHead.Enabled = true;
            }
        }

        private void chkAppHRNo_Click(object sender, EventArgs e)
        {
            if (chkAppHRNo.Checked == true)
            {
                chkAppHRYes.Checked = false;
                lblCancelCauseHR.Enabled = true;
                lblCancelCauseHR.Enabled = true;
            }
        }

        private void btnAddCancelCauseRpt_Click(object sender, EventArgs e)
        {
            frmLeaveCancelCause oCancelCause = new frmLeaveCancelCause();
            oCancelCause.ShowDialog();
        }
        private void btnRefreshCancelCauseRptPrsn_Click(object sender, EventArgs e)
        {
            cboCancelCauseRpt.DisplayMember = "Value";
            cboCancelCauseRpt.ValueMember = "Key";
            cboCancelCauseRpt.DataSource = new BindingSource(hmsSC.GetLvCanCause("D"), null);
        }

        private void chkAppRptYes_Click(object sender, EventArgs e)
        {
            if (chkAppRptYes.Checked == true)
            {
                chkAppRptNo.Checked = false;
                cboCancelCauseRpt.Enabled = false;
                lblCancelCauseRpt.Enabled = false;
            }
            else
            {
                chkAppRptNo.Checked = true;
                cboCancelCauseRpt.Enabled = true;
                lblCancelCauseRpt.Enabled = true;
            }
        }

        private void chkAppRptNo_Click(object sender, EventArgs e)
        {
            if (chkAppRptNo.Checked == true)
            {
                chkAppRptYes.Checked = false;
                cboCancelCauseRpt.Enabled = true;
                lblCancelCauseRpt.Enabled = true;
            }
            else
            {
                chkAppRptYes.Checked = true;
                cboCancelCauseRpt.Enabled = false;
                lblCancelCauseRpt.Enabled = false;
            }
        }

       
    }
}
