using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.Shared.UI;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmissionCancel : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        List<InPatient> oPats = new List<InPatient>();
        string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
       
        public frmAdmissionCancel()
        {
            InitializeComponent();
        }

        private void cboPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string vrfy = ipdSc.VerifyInPatient(txtRegistrationId.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationId.Focus();
                    btnNew.PerformClick();
                    return;
                }

                string vrfySatyingTime = ipdSc.CheckPatStayingTime(txtRegistrationId.Text);
                if (vrfySatyingTime.Length > 0)
                {
                    MessageBox.Show(vrfySatyingTime, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationId.Focus();
                    btnNew.PerformClick();
                    return;
                }


                InPatient pat = ipdSc.GetAdmittedPatient(txtRegistrationId.Text);
                LoadPatient(pat);
                rdPreviousAmount.Text = ipdSc.GetTotalAmount(txtRegistrationId.Text).ToString();
                LoadListViewReport(txtRegistrationId.Text);
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
            txthcn.Text = pat.HCN;
            txtStaffId.Text = pat.StaffID;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;

            txtBedNo.Text = pat.Bed.BedNo;
            txtReffDocName.Text = pat.Doctor.Name;
            txtDeptId.Text = pat.Department.DepartmentID;
            txtDept.Text = pat.Department.DepartmentTitle;

            txtUnitId.Text = pat.DepartmentUnit.UnitId;
            txtRoomNo.Text = pat.Room.RoomNo.ToString();

            if ((txtDeptId.Text != null) && txtUnitId.Text != null)
            {
                oPats = ipdSc.GetDepartmentHead(txtDeptId.Text, txtUnitId.Text).ToList();
            }

            foreach (InPatient oPat in oPats)
            {
                txtRdDepartmentHead.Text = oPat.Department.DepartmentUnitHeadID;
                txtDepartmentHead.Text = oPat.Department.DepartmentUnitHead;
            }
           
        }

        private void btnDepositHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string vrfy = ipdSc.VerifyInPatient(txtRegistrationId.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationId.Focus();
                    btnNew.PerformClick();
                    return;
                }

                frmAdvancePaymentHistory payHist = new frmAdvancePaymentHistory(txtRegistrationId.Text, txtPatientName.Text);
                payHist.ShowDialog();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
             List<string> vf = new List<string>() {"txtRegistrationId", "txtPatientName","txtAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            string label = "Advance Deposit Payment";
            string patNo = txthcn.Text;
            string patName = txtPatientName.Text;
            string department = txtDeptId.Text;
            string departmentUnit = txtUnitId.Text;
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = txtTotalAmount.Text;// "0";// txtAmount.Text;
            string advance = rdPreviousAmount.Text;//"0";
            string vat = "0";
            string discount = "0";
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            try
            {
                AH.Shared.UI.frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType,0,false);
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

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                InPatient pat = this.PopulatePatAdmissionCancel((OPDPayment)PaymentObject(payment));
                short i = ipdSc.SavePatientAdmissionCancel(pat);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void FormatGridReport()
        {
            lstRevenueDetails.CheckBoxes = false;
            lstRevenueDetails.Columns.Add("Service Name", 200, HorizontalAlignment.Left);
            lstRevenueDetails.Columns.Add("Amount", 150, HorizontalAlignment.Left);
        }

        private void LoadListViewReport(string regno)
        {
            lstRevenueDetails.Items.Clear();

            List<RevenueHead> rvhds = ipdSc.GetDepartmentRevenue(regno).ToList();

            foreach (RevenueHead rv in rvhds)
            {
                ListViewItem itm = new ListViewItem(rv.Title);
                itm.SubItems.Add(rv.Amount.ToString());
                lstRevenueDetails.Items.Add(itm);
                txtTotalAmount.Text = (+Convert.ToInt32(rv.Amount)).ToString();
                // = rv.ID + ',' + rv.RevenueHeadGroup.ID + ',' + rv.Amount.ToString() + ';';
                rdTxtNetPayment.Text = ((Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(rdPreviousAmount.Text)).ToString());
            }
        }

        private void frmAdmissionCancel_Load(object sender, EventArgs e)
        {
            FormatGridReport();
            txtRegistrationId.Select();

            cboCancelReason.DisplayMember = "Value";
            cboCancelReason.ValueMember = "Key";
            cboCancelReason.DataSource = new BindingSource((ipdSc.GetAdmCancelReasonDic("E")), null);
        }

        private InPatient PopulatePatAdmissionCancel(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.RegistrationNo = txtRegistrationId.Text;
            patObj.Remarks = txtRemarks.Text;

            patObj.StaffID =txtStaffId.Text;

            patObj.CancellationReason = cboCancelReason.SelectedValue.ToString();

            Department odept = new Department();
            odept.DepartmentID = txtDeptId.Text;
            patObj.Department = odept;

            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = txtUnitId.Text;
            patObj.DepartmentUnit = oUnit;

            OPDPayment opdObj = payment;
            patObj.Payment = opdObj;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
