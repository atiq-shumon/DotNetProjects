using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;
using AH.Shared.UI;
namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdvancePayment : AH.Shared.UI.frmSmartFormStandard
    {
        string MasterCode = Utility.GetMasterChargeCode(Utility.ChargesCode.BedCharges);
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
        string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        private string regID;
        public frmAdvancePayment(string regID)
        {
            InitializeComponent();
            this.regID = regID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRegNo", "txtAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            string label = "Advance Deposit Payment";
            string patNo = txtHcnNo.Text;
            string patName = txtPatientName.Text;
            string department = txtDeptID.Text; 
            string departmentUnit = txtUnitID.Text; 
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = txtAmount.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            try
            {
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType,0,false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
               frm.Show();
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
                InPatient inPat = this.populateReAdvance((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveAdvanpay(inPat);
                if (i == "0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid(txtRegNo.Text);
                    txtRegNo.Focus();
                   
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

            //btnNew.PerformClick();
            //txtRegNo.Focus();
            //AH.MODEL.Payment.Payment paymentObject = payment;
            //ob.PatientCardIssue(paymentObject);

            //frmReportViewer vr = new frmReportViewer();
            //vr.selector = ViewerSelector.OPDTicket;
            //vr.PatientNo = txtPatientNo.Text;
            //vr.TicketNo = txtTicketNo.Text;
            //vr.ReportTitle = "OPD Prescription";
            //vr.ReportSecondParameter = "";
            ////"Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);

            //vr.ViewReport();

            //btnNew.PerformClick();
            //txtPatientNo.Focus();

        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            obj.FormatAdvancePaymentList(lstAdPay);
            txtCurrentTotal.Text = "";
            txtAmount.Text = "";

            string vrfy = ipdSc.VerifyInPatient(txtRegNo.Text);
            if (vrfy.Length > 0)
            {
                MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegNo.Focus();
                btnNew.PerformClick();
                return;
            }
            InPatient pat = ipdSc.GetAdmittedPatient(txtRegNo.Text);
            LoadPatient(pat);
            txtTotalAmount.Text = ipdSc.GetTotalAmount(txtRegNo.Text).ToString();
            RefreshGrid(txtRegNo.Text);
        }
        private void LoadPatient(InPatient pat)
        {
            
            txtHcnNo.Text = pat.HCN;
            txtPatientName.Text = pat.Name;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;

            txtStaffID.Text = pat.StaffID;
            txtBedNo.Text = pat.Bed.BedNo;
            txtDeptID.Text = pat.Department.DepartmentID;
            txtDept.Text = pat.Department.DepartmentTitle;
            txtUnitID.Text = pat.DepartmentUnit.UnitId;
           // txtTransno.Text = pat.Payment.TransactionNo;         
            txtRoom.Text = pat.Room.RoomNo.ToString();
            //txtPaymentType.Text = paymentType;
           // txtPurposeID.Text = "P-04";

        }
        private void RefreshGrid(string regNo)
        {
            obj.LoadAdnceListView(lstAdPay,regNo);
        }
        
       
        private void frmAdvancePayment_Load(object sender, EventArgs e)
        {
            obj.FormatAdvancePaymentList(lstAdPay);
            txtRegNo.Select();

            if (regID == "B")
            {
                txtRegNo.Text = "";
            }
            else
            {
                txtRegNo.Text = regID;
            }

        }
        private OPDPayment PaymentObject(AH.Shared.MODEL.OPDPayment payment)
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
            paymentObject.MachineID = payment.LocationID;
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
            return paymentObject;
        }
        private InPatient populateReAdvance(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.HCN = txtHcnNo.Text;
            patObj.RegistrationNo = txtRegNo.Text;
            patObj.StaffID = txtStaffID.Text;

            Department dept = new Department();
            dept.DepartmentID = txtDeptID.Text;
            patObj.Department = dept;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtUnitID.Text;
            patObj.DepartmentUnit = dunit;

            patObj.Payment = payment;

            RevenueHead rvnHd = new RevenueHead();
            rvnHd.ID = revenueHead;
           
            RevenueHeadGroup rvnHdGroup = new RevenueHeadGroup();
            rvnHdGroup.ID = revenueHeadGroupAdvance;

            rvnHd.RevenueHeadGroup = rvnHdGroup;
            patObj.RevenueHead = rvnHd;

           

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            patObj.EntryParameter = ep;


            return patObj;
        }

        private void btnDepositHistory_Click(object sender, EventArgs e)
        {
            frmAdvancePaymentHistory payHist = new frmAdvancePaymentHistory(txtRegNo.Text, txtPatientName.Text);
            payHist.ShowDialog();
        }

        private void lvAdPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvAdPay.SelectedItems.Count > 0)
            //{
            //    ListViewItem itm = lvAdPay.SelectedItems[0];
            //    txtPaymentType.Text = itm.SubItems[1].Text;
            //    txtAmount.Text = itm.SubItems[2].Text;
            //    txtTransno.Text = itm.SubItems[3].Text;
            //}
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == string.Empty)
            {
                txtCurrentTotal.Text = "";
                return;
            }
            else
            {
                txtCurrentTotal.Text = (Convert.ToInt32(txtAmount.Text) + Convert.ToInt32(txtTotalAmount.Text)).ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstAdPay.Clear();
        }

        private void txtRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}
