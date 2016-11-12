using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;
using AH.Shared.UI;
using AH.ModuleController.UI.DMS.Reports.Viewer;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDuePayment : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmDuePayment()
        {
            InitializeComponent();
        }

        private void cboPatientMr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dmsSC.verifyMrno(txtMRNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMRNo.Select();
                    btnNew.PerformClick();
                    return;

                }
                InPatient pat = dmsSC.GetCurrentPatient(txtMRNo.Text);
                DiagnosticMR mr = dmsSC.GetDmrCollMaster(txtMRNo.Text);
                if (mr.DiagnosticPayment != null)
                {
                    if (pat.HCN != null)
                    {
                        LoadPatient(pat);
                        LoadAmount(mr);
                    }
                }
                else
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
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
        
        private void LoadPatient(InPatient pat)
        {           
            txtPatientName.Text = pat.Name;
            txtAgeYears.Text = pat.Age.Year.ToString();
            txtAgeMonths.Text = pat.Age.Month.ToString();
            txtAgeDays.Text = pat.Age.Day.ToString();
            txtAgeHours.Text = pat.Age.Hour.ToString();
            txtSex.Text = pat.Sex;
            txtHCN.Text = pat.HCN.ToString();
            txtReg.Text = pat.RegistrationNo.ToString();
        }

        private void LoadAmount(DiagnosticMR mr)
        {
            txtTransNo.Text = mr.TransNo;            
            txtNetPaid.Text = mr.DiagnosticPayment.Amount.ToString();
            txtDue.Text = mr.DiagnosticPayment.PreviousDue.ToString();
            txtNetAmount.Text = mr.DiagnosticPayment.Amount.ToString() + mr.DiagnosticPayment.PreviousDue.ToString();
            cboPaymentType.SelectedValue = mr.Prescription.TicketType.ToString();
            cboPaymentType.Enabled = false;
        }

        private void frmDuePayment_Load(object sender, EventArgs e)
        {           
            cboPaymentType.DisplayMember = "Value";
            cboPaymentType.ValueMember = "Key";
            cboPaymentType.DataSource = new BindingSource(dmsSC.GetPrescriptionTypes(), null);
            txtMRNo.Focus();
        }
        private DuePayment PopulateDuePayment(OPDPayment payment)
        {
            DuePayment oDuePay = new DuePayment();

            DiagnosticMR odr = new DiagnosticMR();                       
            odr.MRNo = txtMRNo.Text.ToString();
            oDuePay.DiagnosticMR = odr;

            OPDPayment Opr = new OPDPayment();
            Opr.PaymentType = cboPaymentType.SelectedValue.ToString();            
            oDuePay.OPDPayment = Opr;

            oDuePay.RevHdGrp = "01";
            oDuePay.RevHd = "001";
            oDuePay.StaffId = "001";
            oDuePay.PurposeId = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
            oDuePay.OPDPayment = payment;
            oDuePay.PaidAmt = payment.Amount;
            oDuePay.Remarks = txtRemarks.Text.ToString();
           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDuePay.EntryParameter = ep;
            return oDuePay;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMRNo", "cboPaymentType" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            DiagnosticMR mr = dmsSC.GetDmrCollMaster(txtMRNo.Text);
            if (mr.Prescription.TicketType.ToString() == "I")
            {
                MessageBox.Show("IPD payment is not allowed here..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                   string label = "Diagnostic Money Receipt Issue";
                   string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.DiagnosticColl);
                   string patNo = txtHCN.Text;
                   string patName = txtPatientName.Text;
                   string department = txtPatDeptCode.Text;
                   string departmentUnit = txtDeptUnit.Text;
                   string reffDepartment = "0";
                   string departmentReffUnit = txtDeptUnit.Text;
                   decimal departmentAmount = 0;
                   decimal reffDepartmentAmount = 0;
                   string amount = txtDue.Text;
                   string advance = "0";
                   string vat = "0";
                   string discount = "0";
                   string discountBy = "0";
                   string paymentType = "0";
                   DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
                   frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat.ToString(), 
                                                   discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit,
                                                   departmentAmount, reffDepartmentAmount, updateDate, paymentType,0,false);
                   frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                   frm.ShowDialog();

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

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                DuePayment oDuePay = this.PopulateDuePayment((OPDPayment)PaymentObject(payment));              
                    string i = dmsSC.SaveDuePayment(oDuePay);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i == "1")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printMR(txtMRNo.Text);
                        btnNew.PerformClick();
                        txtMRNo.Focus();
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
        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            paymentObject.Advance = payment.Advance;
            paymentObject.Amount = payment.Amount;
            paymentObject.CompanyID = payment.CompanyID;
            paymentObject.ConsultantFee = payment.ConsultantFee;
            paymentObject.Department = payment.Department;
            paymentObject.DepartmentUnit = payment.DepartmentUnit;
            paymentObject.DeptAmount = payment.DeptAmount;
            paymentObject.Discount = payment.Discount;
            paymentObject.EntryBy = payment.EntryBy;
            paymentObject.EntryDate = payment.EntryDate;
            paymentObject.EntryName = payment.EntryName;
            paymentObject.HCN = payment.HCN;
            paymentObject.LocationID = payment.LocationID;
            paymentObject.MachineID = payment.MachineID;
            paymentObject.NetAmount = payment.NetAmount;
            paymentObject.PaymentDate = payment.PaymentDate;
            paymentObject.PaymentType = payment.PaymentType;
            paymentObject.PreviousDue = payment.PreviousDue;
            paymentObject.PurposeID = payment.PurposeID;
            paymentObject.PurposeTitle = payment.PurposeTitle;
            paymentObject.ReffDept = payment.ReffDept;
            paymentObject.ReffDeptAmount = payment.ReffDeptAmount;
            paymentObject.ReffDeptUnit = payment.ReffDeptUnit;
            paymentObject.RefferedFee = payment.RefferedFee;
            paymentObject.RegistrationNo = payment.RegistrationNo;
            paymentObject.Staff = payment.Staff;
            paymentObject.TransactionNo = payment.TransactionNo;
            paymentObject.VAT = payment.VAT;
            paymentObject.Amount = payment.AmountGiven;
            paymentObject.PaymentString = payment.PaymentString; 
            return paymentObject;
        }
        private void printMR(string mrNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DueMoneyReceipt;
            vr.MoneyReceiptNo = txtMRNo.Text;
            vr.ViewReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DueMoneyReceipt;
            vr.MoneyReceiptNo = txtMRNo.Text;
            vr.ViewReport();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMobileNo.Text != "")
                {
                    LoadPatient pat = dmsSC.GetCurrentPatientByPhone(txtMobileNo.Text);

                    if (pat.InPatient.HCN != null)
                    {
                        txtMRNo.Text = pat.MRNo;
                        txtPatientName.Text = pat.InPatient.Name;
                        txtAgeYears.Text = pat.InPatient.Age.Year.ToString();
                        txtAgeMonths.Text = pat.InPatient.Age.Month.ToString();
                        txtAgeDays.Text = pat.InPatient.Age.Day.ToString();
                        txtAgeHours.Text = pat.InPatient.Age.Hour.ToString();
                        txtSex.Text = pat.InPatient.Sex;
                        txtHCN.Text = pat.InPatient.HCN.ToString();
                        txtReg.Text = pat.InPatient.RegistrationNo.ToString();
                        DiagnosticMR mr = dmsSC.GetDmrCollMaster(txtMRNo.Text);
                        LoadAmount(mr);
                    }
                    else
                        MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            lblMobileNo.Enabled = true;
            txtMobileNo.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void txtMRNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMRNo.Text.Length == Utility.ScanLength)
            {
                cboPatientMr_Click(sender, e);
            }
        }

        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {
            txtMRNo.CharacterCasing = CharacterCasing.Upper;
        }

    
    }
}
