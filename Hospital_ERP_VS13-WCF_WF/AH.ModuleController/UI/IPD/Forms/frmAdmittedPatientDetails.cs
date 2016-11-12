using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.DUtility;
using AH.Shared.UI;
using AH.ModuleController.IPDSR;
using AH.ModuleController.UI.IPD.Reports.Viewer;


namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmittedPatientDetails : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        private string bedID;
        private string hcn;
        private string photoPath;
        string revHead = "";       
        List<InPatient> oPats = new List<InPatient>();
        string MasterCode = Utility.GetMasterChargeCode(Utility.ChargesCode.BedCharges);
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
        string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        string admission_id;
        public frmAdmittedPatientDetails(string bedID)
        {
            this.bedID = bedID;
            InitializeComponent();
        }

        private void tbDetailsInfo_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tbDetailsInfo.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tbDetailsInfo.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.Orange, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        private void AdvancePayment()
        {
            List<string> vf = new List<string>() { "txtPatRegNo", "nmrAdvanceDeposite" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            string label = "Advance Deposit Payment";
            string patNo = txtPatHcnNo.Text;
            string patName = txtPatientName.Text;
            string department = txtDeptID.Text;
            string departmentUnit = txtUnitID.Text;
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = nmrAdvanceDeposite.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            if (float.Parse(nmrAdvanceDeposite.Text) > 0) 
            {
                try
                {
                    frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                    frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(AdvancePaymentData);
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
            else
            {
                MessageBox.Show("You can't pay zero(0) amount", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nmrAdvanceDeposite.Focus();
            }
        }
        private void BedTransferPayment()
        {
            List<string> vf = new List<string>() { "txtPatRegNo", "cboBedNo", "cboReceivingNurse", "txtAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            string label = "Bed Transfer Deposit Payment";
            string patNo = txtPatHcnNo.Text;
            string patName = txtPatientName.Text;
            string department = txtDeptID.Text;
            string departmentUnit = txtUnitID.Text;
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
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
            if (float.Parse(txtAmount.Text) > 0)
            {
               try
                {
                    frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                    frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(BedTransferPaymentData);
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

             else
            {             
                AH.Shared.MODEL.OPDPayment paymentObject = new AH.Shared.MODEL.OPDPayment();
                paymentObject.Advance =Convert.ToInt64(advance);
                paymentObject.Amount = Convert.ToInt64(txtAmount.Text);
                paymentObject.Department = department;
                paymentObject.DepartmentUnit = departmentUnit;
                paymentObject.DeptAmount = departmentAmount;
                paymentObject.Discount =Convert.ToInt64(discount);
                paymentObject.HCN = hcn;
                paymentObject.NetAmount = Convert.ToInt64(txtAmount.Text);
                paymentObject.PaymentDate = updateDate;
                paymentObject.PaymentType = paymentType;
                paymentObject.PurposeID = purposeID;              
                paymentObject.ReffDept = reffDepartment;
                paymentObject.ReffDeptAmount = reffDepartmentAmount;
                paymentObject.ReffDeptUnit = departmentReffUnit;            
                paymentObject.VAT = Convert.ToInt64(vat);
                paymentObject.PaymentString = Convert.ToInt64(txtAmount.Text) + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + ";";

                BedTransferPaymentData(paymentObject);
            }

        }
        private void DepartmentTransferPayment()
        {
            List<string> vf = new List<string>() { "txtPatRegNo", "cboPatDepartment","cboUnit","cboRecNurseDeptTransfer" ,"txtAdvancePayment"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            string label = "Department transfer Deposit Payment";
            string patNo = txtPatHcnNo.Text;
            string patName = txtPatientName.Text;
            string department = cboPatDepartment.SelectedValue.ToString();
            string departmentUnit = cboUnit.SelectedValue.ToString();
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = txtAdvancePayment.Text;
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            if (float.Parse(txtAdvancePayment.Text) > 0)
            {
            try
            {
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(DeptTransferPaymentData);
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
           else
            {             
                AH.Shared.MODEL.OPDPayment paymentObject = new AH.Shared.MODEL.OPDPayment();
                paymentObject.Advance =Convert.ToInt64(advance);
                paymentObject.Amount = Convert.ToInt64(txtAdvancePayment.Text);
                paymentObject.Department = department;
                paymentObject.DepartmentUnit = departmentUnit;
                paymentObject.DeptAmount = departmentAmount;
                paymentObject.Discount =Convert.ToInt64(discount);
                paymentObject.HCN = hcn;
                paymentObject.NetAmount = Convert.ToInt64(txtAdvancePayment.Text);
                paymentObject.PaymentDate = updateDate;
                paymentObject.PaymentType = paymentType;
                paymentObject.PurposeID = purposeID;              
                paymentObject.ReffDept = reffDepartment;
                paymentObject.ReffDeptAmount = reffDepartmentAmount;
                paymentObject.ReffDeptUnit = departmentReffUnit;            
                paymentObject.VAT = Convert.ToInt64(vat);
                paymentObject.PaymentString = Convert.ToInt64(txtAdvancePayment.Text) + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + ";";

                DeptTransferPaymentData(paymentObject);
            }

        }
        private void PatientDischarge()
        {

            string label = "Final Payment";
            string patNo = hcn;
            string patName = txtPatientName.Text;
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.IPDCollection);
            string department = txtDeptID.Text;
            string departmentUnit = txtUnitID.Text;
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 300;
            decimal reffDepartmentAmount = 0;
            string totalAmount = nmrTxtTotal.Text;
            string advance = nmrTxtAdvance.Text;
            string vat = "0";
            string discount = "0";
            string discountBy = "";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            if (  float.Parse(txtNetAmount.Text) > 0)
            {
                try
                {
                    frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, totalAmount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                    frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(DischargePaymentData);
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
            else
            {             
                AH.Shared.MODEL.OPDPayment paymentObject = new AH.Shared.MODEL.OPDPayment();
                paymentObject.Advance =Convert.ToInt64(advance);
                paymentObject.Amount =decimal.Parse(nmrTxtTotal.Text);
                paymentObject.Department = department;
                paymentObject.DepartmentUnit = departmentUnit;
                paymentObject.DeptAmount = departmentAmount;
                paymentObject.Discount =Convert.ToInt64(discount);
                paymentObject.HCN = hcn;
                paymentObject.NetAmount = decimal.Parse(txtNetAmount.Text);
                paymentObject.PaymentDate = updateDate;
                paymentObject.PaymentType = paymentType;
                paymentObject.PurposeID = purposeID;              
                paymentObject.ReffDept = reffDepartment;
                paymentObject.ReffDeptAmount = reffDepartmentAmount;
                paymentObject.ReffDeptUnit = departmentReffUnit;
                paymentObject.VAT = decimal.Parse(vat);
                paymentObject.PaymentString = decimal.Parse(txtNetAmount.Text) + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + ";";

                DischargePaymentData(paymentObject);
            }

        }
        private void AdmissionCancellation()
        {
            List<string> vf = new List<string>() { "txtPatRegNo", "txtPatName", "txtCancelTotalAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

           // string label = "Admission Cancellation Deposit Payment";
            string patNo = txtPatHcnNo.Text;
            string patName = txtPatientName.Text;
            string department = txtDeptID.Text;
            string departmentUnit = txtUnitID.Text;
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.IPDCollection);
            string reffDepartment = "N/A";
            string departmentReffUnit = "N/A";
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = txtCancelTotalAmount.Text;// "0";// txtAmount.Text;
            string advance = rdPreviousAmount.Text;//"0";
            string vat = "0";
            string discount = "0";
           // string discountBy = "";
            string paymentType = "0";

            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            AH.Shared.MODEL.OPDPayment paymentObject = new AH.Shared.MODEL.OPDPayment();
            paymentObject.Advance = Convert.ToInt64(advance);
            paymentObject.Amount = Convert.ToInt64(amount);
            paymentObject.Department = department;
            paymentObject.DepartmentUnit = departmentUnit;
            paymentObject.DeptAmount = departmentAmount;
            paymentObject.Discount = Convert.ToInt64(discount);
            paymentObject.HCN = hcn;
            paymentObject.NetAmount = Convert.ToInt64(rdTxtNetPayment.Text);
            paymentObject.PaymentDate = updateDate;
            paymentObject.PaymentType = paymentType;
            paymentObject.PurposeID = purposeID;
            paymentObject.ReffDept = reffDepartment;
            paymentObject.ReffDeptAmount = reffDepartmentAmount;
            paymentObject.ReffDeptUnit = departmentReffUnit;
            paymentObject.VAT = Convert.ToInt64(vat);
            paymentObject.PaymentString = Convert.ToInt64(rdTxtNetPayment.Text) + "~" + "0" + "~" + "0" + "~" + "0" + "~"+"0" + "~" + "0" + "~" + "0" + "~"+"0" + "~" + "0" + ";";

            CancelPaymentData(paymentObject);
            //try
            //{
            //    AH.Shared.UI.frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
            //    frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(CancelPaymentData);
            //    frm.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
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
            paymentObject.PaymentString = payment.PaymentString;
            return paymentObject;
        }

        private void frmAdmittedPatientDetails_Load(object sender, EventArgs e)
        {
           
                txtRegistrationID.Select();

                FormatGridAddress();
                FormatGridEmerg();
                FormatPatientDrugsList();
                FormatPatientDiagTest();
                FormatPatientOperationDetails();
                FormatDoctorVisit();
                FormatPatientBillableItemList();
                FormatPatientEmergency();
                obj.FormatListBedForBedInformation(lvBedHistory);
                obj.FormatListDept(lvDepartmentHist);
                obj.cboBedType(cboBedType);

                obj.ComboDepartment(cboPatDepartment);
                obj.cboReceivingNurseStation(cboReceivingNurseStation);
                obj.FormatListForBed(lstRepGr);

                obj.FormatAdvancePaymentList(lvAdPayHist);
                obj.FormatAdvancePaymentList(lstAdPay);
                obj.cboBedType(cboBedDeptTransfer);

                obj.cboReceivingNurseStation(cboRecNurseStnDeptTransfer);
                obj.FormatListForBed(lstBedDeptTransfer);
                obj.FormatListBedForBedInformation(lstDeptBedHistory);

                obj.FormatGridReport(lvDeptTransferRepGr);
                obj.FormatListBedForBedInformation(lstDischargeBedHist);
                obj.FormatListDept(lstDischargeDeptHist);
                obj.FormatGridReport(lstDischargeReport);
                obj.cboDischargeType(cboDischargeType);

                if (bedID != "D")
                {
                    InPatient pat = ipdSc.GetPatRegID(bedID);
                    txtRegistrationID.Text = pat.RegistrationNo;
                }

                cboBedNumber.Enabled = false;
                cboBedDeptTransfer.Enabled = false;
                cboBedCategoryDeptTransfer.Enabled = false;
                lblStar.Visible = false;
                cboRecNurseStnDeptTransfer.Enabled = false;
                label14.Visible = false;
                label10.Visible = false;
                label12.Visible = false;

                cboCancelReason.DisplayMember = "Value";
                cboCancelReason.ValueMember = "Key";
                cboCancelReason.DataSource = new BindingSource((ipdSc.GetAdmCancelReasonDic("E")), null);
                obj.FormatGridReport(lstRevenueDetails);

                admission_id = txtRegistrationID.Text;          


        }
        private void LoadPatient(InPatient pat)
        {
            nmrAdvanceDeposite.Text = "";
            txtCurrentTotal.Text = "";
            hcn = pat.HCN;
            txthcn.Text = pat.HCN;
            txtPatHcnNo.Text = pat.HCN;
            txtRegNo.Text = pat.RegistrationNo;
            txtPatRegNo.Text = pat.RegistrationNo;
            txtPatientName.Text = pat.Name;
            txtPatName.Text = pat.Name;

            txtStaffID.Text = pat.StaffID;
            txtDeptID.Text = pat.Department.DepartmentID;
            txtDept.Text = pat.Department.DepartmentTitle;
            txtUnitID.Text = pat.DepartmentUnit.UnitId;
            txtDoc.Text = pat.Doctor.ID;
            txtDocName.Text = pat.Department.DepartmentUnitHead;// pat.Doctor.Name;
            txtDeptHeadName.Text = pat.Department.DepartmentUnitHead;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));
            txtPatAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));

            txtSex.Text = pat.Sex;
            txtFatherName.Text = pat.FathersName;
            txtMotherName.Text = pat.MothersName;
            txtReligion.Text = pat.Religion;
            txtEmail.Text = pat.Email;
            txtContactNo.Text = pat.CellPhone;
            txtBloodGroup.Text = pat.BloodGroup;
            photoPath = pat.Photo;


            rdTxtAdvancePayDept.Text = pat.Department.DepartmentTitle;
            txtAdvancUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
            txtRoom.Text = pat.Room.RoomTitle;
            txtAdvancPayBed.Text = pat.Bed.BedTitle;
            rdTxtAdvanceFloor.Text = pat.Room.Floor;

            txtDept.Text = pat.Department.DepartmentTitle;
            txtRoomNo.Text = pat.Room.RoomTitle;
            txtBedTransferUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
            txtBedNo.Text = pat.Bed.BedTitle;
            txtBedId.Text = pat.Bed.BedNo;

            rdTxtDeptTransDept.Text = txtDept.Text;
            txtDeptTransferUnitTitle.Text = pat.DepartmentUnit.UnitTitle;// pat.Department.DepartmentTitle;
            rdTxtDeptTransBed.Text = pat.Bed.BedTitle;
            rdPreviousAmount.Text= ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();


            txtReffDocName.Text = pat.Department.DepartmentUnitHead; // pat.Doctor.Name;
            txtCancelBed.Text = txtBedNo.Text;
            txtCancelRoom.Text = txtRoomNo.Text;
            txtCancelDepartment.Text = txtDept.Text;
            cancelUnit.Text = pat.DepartmentUnit.UnitTitle;
            if (pat.HourDifference > 12)
            {
                tbDetailsInfo.Controls[5].Enabled = false;
            }
            else
            {
                tbDetailsInfo.Controls[5].Enabled = true;
            }
        }
        private void FormatGridEmerg()
        {
            lstContactInfo.CheckBoxes = false;
            lstContactInfo.Columns.Add("Name", 150, HorizontalAlignment.Center);
            lstContactInfo.Columns.Add("Address", 250, HorizontalAlignment.Left);
            lstContactInfo.Columns.Add("Cell Phone", 150, HorizontalAlignment.Left);
            lstContactInfo.Columns.Add("Home Phone", 150, HorizontalAlignment.Left);
            lstContactInfo.Columns.Add("Relation With Patient", 150, HorizontalAlignment.Center);
        }
        private void LoadListViewEmergContact()
        {
            lstContactInfo.Items.Clear();

            InPatient inPat = ipdSc.GetPatientEmergencyContactDetails(hcn);
            ListViewItem itm = new ListViewItem(inPat.EmergencyContactPerson.ToString());
            itm.SubItems.Add(inPat.EmergencyAddress);
            itm.SubItems.Add(inPat.EmergencyCellPhone);
            itm.SubItems.Add(inPat.EmergencyHomePhone);
            itm.SubItems.Add(inPat.EmergencyPersonRelation);
            lstContactInfo.Items.Add(itm);
        }
        private void FormatGridAddress()
        {
            lstAdressInfo.CheckBoxes = false;
            lstAdressInfo.Columns.Add("Present Address", 150, HorizontalAlignment.Center);
            lstAdressInfo.Columns.Add("Present Post Code", 150, HorizontalAlignment.Left);
            lstAdressInfo.Columns.Add("Present Police Station", 250, HorizontalAlignment.Left);
            lstAdressInfo.Columns.Add("Present District", 150, HorizontalAlignment.Center);
            lstAdressInfo.Columns.Add("Permanent Address", 150, HorizontalAlignment.Center);
            lstAdressInfo.Columns.Add("Permanent Post Code", 150, HorizontalAlignment.Left);
            lstAdressInfo.Columns.Add("Permanent Police Station", 150, HorizontalAlignment.Left);
            lstAdressInfo.Columns.Add("Permanent District", 150, HorizontalAlignment.Center);
            lstAdressInfo.Columns.Add("Country", 200, HorizontalAlignment.Center);
        }
        private void LoadListViewAddressInfo()
        {
            lstAdressInfo.Items.Clear();

            InPatient inPat = ipdSc.GetPatientAdressInformation(hcn);
            ListViewItem itm = new ListViewItem(inPat.Present_H_R_B);
            itm.SubItems.Add(inPat.Present_Post);
            itm.SubItems.Add(inPat.PresentThana);
            itm.SubItems.Add(inPat.PresentDistrict);
            itm.SubItems.Add(inPat.Permanent_H_R_B);
            itm.SubItems.Add(inPat.Permanent_Post);
            itm.SubItems.Add(inPat.PermanentThana);
            itm.SubItems.Add(inPat.PermanentDistrict);
            itm.SubItems.Add(inPat.Country);
            lstAdressInfo.Items.Add(itm);
        }
        private void btnPatientFind_Click(object sender, EventArgs e)
        {
            try
            {
                string vrfy = ipdSc.VerifyInPatient(txtRegistrationID.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegNo.Focus();
                    // btnNew.PerformClick();
                    return;
                }
                InPatient pat = ipdSc.GetAdmittedPatient(txtRegistrationID.Text);
                LoadPatient(pat);
                if (photoPath != "default")
                {
                    string LocalSrcFile = Utility.PatientPhotoPath + photoPath + ".JPEG";
                    pbImage.Image = new Bitmap(LocalSrcFile);
                    pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
                }
                else
                {
                    string LocalSrcFile = Utility.PatientPhotoPath + "Default.JPEG";
                    pbImage.Image = new Bitmap(LocalSrcFile);
                    pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
                }
             
                obj.LoadListViewDept(lvDepartmentHist, txtRegNo.Text);
                obj.LoadAdnceListView(lvAdPayHist, txtRegNo.Text);
                obj.LoadAdnceListView(lstAdPay, txtRegNo.Text);
                //obj.LoadListViewBed(lvBedHistory, txtRegNo.Text);
                LoadListViewAddressInfo();
                LoadListViewEmergContact();

                obj.LoadListViewBed(lstDeptBedHistory, txtPatRegNo.Text);
                LoadListViewReport(lvDeptTransferRepGr, txtPatRegNo.Text);
                txtrdPreviousAmount.Text = ipdSc.GetTotalAmount(txtRegNo.Text).ToString();
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

        private void txtRegistrationID_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegistrationID.Text.Length == Utility.ScanLength)
            {
                btnPatientFind_Click(sender, e);
            }
        }

        private void cboBedTrnaBedCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboBedTrnaBedCategoryType.SelectedValue.ToString() != null) && cboBedType.Items.Count > 0 && cboBedTrnaBedCategoryType.Items.Count > 0)
            {
                obj.getBeds(cboBedNo, cboBedType.SelectedValue.ToString(), cboBedTrnaBedCategoryType.SelectedValue.ToString());
                obj.LoadListView(lstRepGr, cboBedTrnaBedCategoryType.SelectedValue.ToString());
            }
        }

        private void cboBedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBedTrnaBedCategoryType.SelectedValue != "" && cboBedNo.SelectedValue != "")
            {
                List<Bed> room = obj.getFloorAndRoom(cboBedNo.SelectedValue.ToString());
                foreach (Bed oBed in room)
                {
                    lblBedFloorAndRoom.Text = "Floor" + "-" + oBed.Floor + "\r\n" + "Room No" + "-" + oBed.Room.RoomTitle;
                    txtFloorNo.Text = oBed.Floor;
                    txtRoomID.Text = oBed.Room.RoomID;
                    cboReceivingNurseStation.SelectedValue = oBed.NurseStation.NurseStationID;
                    cboReceivingNurseStation.Enabled = false;
                }
            }      
           
        }
        private void LoadListViewReport(ListView lst, string regno)
        {
            lst.Items.Clear();

            List<RevenueHead> rvhds = ipdSc.GetDepartmentRevenue(regno).ToList();

            foreach (RevenueHead rv in rvhds)
            {
                ListViewItem itm = new ListViewItem(rv.Title);
                itm.SubItems.Add(rv.Amount.ToString());
                lst.Items.Add(itm);
                revHead = rv.RevenueHeadGroup.ID + ',' +rv.ID + ',' + rv.Amount.ToString() + ';' + revHead;
            }
        }
        #region Patient Medicine Details

        private void FormatPatientDrugsList()
        {
            lstDrugs.CheckBoxes = false;
            lstDrugs.Columns.Add("IssuDate", 200, HorizontalAlignment.Center);         
            lstDrugs.Columns.Add("DrugName", 250, HorizontalAlignment.Left);
            lstDrugs.Columns.Add("IssuQty", 200, HorizontalAlignment.Center);
            lstDrugs.Columns.Add("Amount", 150, HorizontalAlignment.Right);          
        }
        private void FormatPatientBillableItemList()
        {
            lstBillableItem.CheckBoxes = false;
            lstBillableItem.Columns.Add("Issue Date", 180, HorizontalAlignment.Center);
            lstBillableItem.Columns.Add("Product Name",300, HorizontalAlignment.Left);
            lstBillableItem.Columns.Add("Quantity", 100, HorizontalAlignment.Center);
            lstBillableItem.Columns.Add("Amount", 100, HorizontalAlignment.Right);
        }       
        private void LoadBillableItemList()
        {
            decimal amount = 0;
            lstBillableItem.Items.Clear();
            List<ItemOrder> itmOrders = ipdSc.GetBillableItemDetails(txtPatRegNo.Text).ToList();
            if (itmOrders.Count > 0)
            {
                foreach (ItemOrder itmOrder in itmOrders)
                {
                    ListViewItem itm = new ListViewItem(itmOrder.ItemMaster.PODate);
                    itm.SubItems.Add(itmOrder.ItemMaster.Name);
                    itm.SubItems.Add(itmOrder.ItemMaster.ReorderQty.ToString());
                    itm.SubItems.Add((itmOrder.ItemMaster.Urate * itmOrder.ItemMaster.ReorderQty).ToString());
                    lstBillableItem.Items.Add(itm);
                    amount = amount + Convert.ToDecimal(itmOrder.ItemMaster.Urate * itmOrder.ItemMaster.ReorderQty);
                }
                 txtBillableItemTotal.Text = amount.ToString();
            }
        }
        private void FormatPatientEmergency()
        {
            lstEmergency.CheckBoxes = false;
            //lstEmergency.Columns.Add("Date", 180, HorizontalAlignment.Center);
            lstEmergency.Columns.Add("Name",300, HorizontalAlignment.Left);
            lstEmergency.Columns.Add("Quantity", 100, HorizontalAlignment.Center);
            lstEmergency.Columns.Add("Amount", 100, HorizontalAlignment.Right);
        }       
        private void LoadEmergencyAmountDetails()
        {        
            lstEmergency.Items.Clear();
            List<EmergencyCollectionMR> oEmrgs = ipdSc.GetEmerDetailsForIPD(txtPatHcnNo.Text).ToList();
            if (oEmrgs.Count > 0)
            {
                foreach (EmergencyCollectionMR oEmrg in oEmrgs)
                {
                    ListViewItem itm = new ListViewItem(oEmrg.EmrCollHead.HeadTitle);
                   // itm.SubItems.Add(oEmrg.EmrCollHead.HeadTitle);
                    itm.SubItems.Add(oEmrg.EmrCollHead.Qty.ToString());
                    if (oEmrg.EmrCollHead.HeadID == "000049")
                    {
                      itm.SubItems.Add(oEmrg.EmrCollHead.Fee.ToString());
                    }
                    else
                    {
                        itm.SubItems.Add((oEmrg.EmrCollHead.Fee * oEmrg.EmrCollHead.Qty).ToString());
                    }                 
                    lstEmergency.Items.Add(itm);
                    txtTotalEmrg.Text =oEmrg.EmrCollHead.NetPaid.ToString();
             
                }           
            }
        }
        private void LoadListPatientDrugs()
        {
            decimal amount = 0;
            lstDrugs.Items.Clear();
            List<DrugIssue> oDrugs = ipdSc.GetIssueDetailsByRegID(txtPatRegNo.Text).ToList();
            if (oDrugs.Count > 0)
            {
                foreach (DrugIssue oDrug in oDrugs)
                {
                    ListViewItem itm = new ListViewItem(oDrug.IssueDate.ToString("dd-MM-yyyy"));                  
                    itm.SubItems.Add(oDrug.DrugMaster.Name);
                    itm.SubItems.Add(oDrug.IssueQty.ToString());
                    itm.SubItems.Add(oDrug.DrugMaster.NetAmount.ToString());
                    lstDrugs.Items.Add(itm);
                    amount = amount + Convert.ToDecimal(oDrug.DrugMaster.NetAmount);                    
                }
                txtTotalMedAmount.Text = amount.ToString();
            }
        }
        private void FormatPatientDiagTest()
        {
            lstTestDetails.CheckBoxes = false;
            lstTestDetails.Columns.Add("Test Date", 100, HorizontalAlignment.Center);
            lstTestDetails.Columns.Add("Test Name", 350, HorizontalAlignment.Left);          
            lstTestDetails.Columns.Add("Vat", 50, HorizontalAlignment.Right);
            lstTestDetails.Columns.Add("Discount",50, HorizontalAlignment.Right);
            lstTestDetails.Columns.Add("Test Fee", 200, HorizontalAlignment.Right);
        }
        private void LoadListPatientDiagTest()
        {
            decimal DiagTotalAmount = 0;
            decimal vat = 0;
            decimal discount = 0;
            lstTestDetails.Items.Clear();
            List<TestFee> oTests = ipdSc.GetDmrTestsForIPD(txtPatRegNo.Text).ToList();
            foreach (TestFee oTest in oTests)
            {
                ListViewItem itm = new ListViewItem(oTest.TestSub.EntryParameter.EntryDate.ToString("dd-mm-yyy"));
                itm.SubItems.Add(oTest.TestSub.TestSubTitle);
                itm.SubItems.Add(oTest.VAT.ToString());
                itm.SubItems.Add(oTest.Discount.ToString());
                itm.SubItems.Add(oTest.Fee.ToString());               
                lstTestDetails.Items.Add(itm);
                vat = vat + Convert.ToDecimal(oTest.VAT);
                discount=discount+Convert.ToDecimal(oTest.Discount);
                DiagTotalAmount = DiagTotalAmount + Convert.ToDecimal(oTest.Fee);
            }
                txtDiagTotal.Text = DiagTotalAmount.ToString();
                txtTotalVat.Text = vat.ToString();
                txttotalDics.Text = discount.ToString();
                txtDiagTotalAmount.Text = ((DiagTotalAmount+ vat) - discount).ToString();
           
        }
        private void FormatPatientOperationDetails()
        {
            lstOperationDetails.CheckBoxes = false;
            lstOperationDetails.Columns.Add("Operation Date", 200, HorizontalAlignment.Center);
            lstOperationDetails.Columns.Add("Operation Name", 350, HorizontalAlignment.Left);
            lstOperationDetails.Columns.Add("Operation Fee", 250, HorizontalAlignment.Right);
        }
        private void LoadListPatientOperationDetails()
        {
            decimal OperationTotal= 0;
            lstOperationDetails.Items.Clear();
            List<CalenderOT> oOTs = ipdSc.GetRegDetailsFromOperarion("OperationDettoRegId", txtPatRegNo.Text).ToList();
            foreach (CalenderOT OT in oOTs)
            {
                ListViewItem itm = new ListViewItem(OT.RegDate);
                itm.SubItems.Add(OT.OprName);
                itm.SubItems.Add(OT.PackageAmount.ToString());              
                lstOperationDetails.Items.Add(itm);
                OperationTotal = OperationTotal + Convert.ToDecimal(OT.PackageAmount);               
            }
            txtPatOperationTotal.Text = OperationTotal.ToString();
        }

        #endregion

        private void FormatDoctorVisit()
        {
            lstDoctorVisit.CheckBoxes = false;
            lstDoctorVisit.Columns.Add("Visit Date", 100, HorizontalAlignment.Left);
            lstDoctorVisit.Columns.Add("Department", 100, HorizontalAlignment.Left);
            lstDoctorVisit.Columns.Add("Unit", 200, HorizontalAlignment.Left);
            lstDoctorVisit.Columns.Add("Doctor Name", 300, HorizontalAlignment.Left);
            lstDoctorVisit.Columns.Add("Visiting Fee", 100, HorizontalAlignment.Right);

        }
        private void LoadListDoctorVisit()
        {
            decimal docVisitTotal = 0;
           
            lstDoctorVisit.Items.Clear();
            List<IPDDoctor> oDocs = ipdSc.GetIPDVisitingFeeDetails(txtPatRegNo.Text).ToList();
            foreach (IPDDoctor doc in oDocs)
            {
                ListViewItem itm = new ListViewItem(doc.EntryParameter.EntryDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(doc.Department.DepartmentTitle);
                itm.SubItems.Add(doc.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(doc.Name);
                itm.SubItems.Add(doc.IPDVisitingFee.ToString());
                lstDoctorVisit.Items.Add(itm);
                docVisitTotal = docVisitTotal + Convert.ToDecimal(doc.IPDVisitingFee);         
            }
            txtDocAmount.Text = docVisitTotal.ToString();

        }

        #region Populate Advance Payment
        private InPatient populateReAdvance(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.HCN = txtPatHcnNo.Text;
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
        #endregion

        #region PopulateBedTransfer
        private InPatient PopulateBedTransfer(OPDPayment payment)
        {
            InPatient patobj = new InPatient();
            patobj.HCN = txtPatHcnNo.Text;
            patobj.RegistrationNo = txtRegNo.Text;

            patobj.StaffID = "0";

            Department dept = new Department();
            dept.DepartmentID = txtDeptID.Text;
            patobj.Department = dept;
            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtUnitID.Text;
            patobj.DepartmentUnit = dunit;


            Bed bds = new Bed();
            bds.BedNo = cboBedNo.SelectedValue.ToString();
            BedType bdType = new BedType();
            bdType.ID = cboBedType.SelectedValue.ToString();

            BedFacility bedFec = new BedFacility();
            bedFec.ID = cboBedTrnaBedCategoryType.SelectedValue.ToString();
            bdType.BedFacility = bedFec;
            bds.BedType = bdType;

            Room rm = new Room();
            rm.RoomID = txtRoomID.Text;
            rm.Floor = txtFloorNo.Text;
            patobj.Room = rm;

            RevenueHead rvnHd = new RevenueHead();
            rvnHd.ID = revenueHead;

            RevenueHeadGroup rvnHdGroup = new RevenueHeadGroup();
            rvnHdGroup.ID = revenueHeadGroupAdvance;

            rvnHd.RevenueHeadGroup = rvnHdGroup;

            patobj.RevenueHead = rvnHd;

            BedCharges bch = new BedCharges();

            string bedCharges = "";
            foreach (ListViewItem itemRow in lstRepGr.Items)
            {
                bedCharges += itemRow.SubItems[0].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[5].Text;
                bedCharges += ";";
            }

            bds.BedChargesString = bedCharges;
            patobj.Bed = bds;

            Nurse nrs = new Nurse();
            nrs.ID = txtDutyNurse.Text;
            patobj.DutyNurse = nrs;
            patobj.DutyNurse.ID = cboReceivingNurseStation.SelectedValue.ToString();

            NurseStation stn = new NurseStation();
            stn.NurseStationID = cboReceivingNurseStation.SelectedValue.ToString();
            patobj.NurseStation = stn;

            patobj.Payment = payment;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            patobj.EntryParameter = ep;

            return patobj;
        }
        #endregion

        #region PopulateDeptTransfer
        private InPatient PopulateDeptTransfer(OPDPayment payment)
        {
            InPatient patobj = new InPatient();
            patobj.HCN = txtPatHcnNo.Text;
            patobj.RegistrationNo = txtRegNo.Text;

            patobj.StaffID = txtStaffID.Text;

            Doctor dct = new Doctor();
            dct.ID = txtDoc.Text;
            patobj.Doctor = dct;


            RevenueHead rvnHd = new RevenueHead();
            rvnHd.ID = revenueHead;

            RevenueHeadGroup rvnHdGroup = new RevenueHeadGroup();
            rvnHdGroup.ID = revenueHeadGroupAdvance;
            rvnHd.RevenueHeadGroup = rvnHdGroup;
            patobj.RevenueHead = rvnHd;


            Department dpt = new Department();
            dpt.DepartmentID = cboPatDepartment.SelectedValue.ToString();
            dpt.DepartmentUnitHead = txtDeptHead.Text;
            patobj.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = cboUnit.SelectedValue.ToString();
            patobj.DepartmentUnit = dunit;

            patobj.Payment = payment;


            if (chkBedTransfer.Checked == true)
            {

                Bed bds = new Bed();
                bds.BedNo = cboBedNumber.SelectedValue.ToString();

                BedType bdType = new BedType();
                bdType.ID = cboBedDeptTransfer.SelectedValue.ToString();
                BedFacility bedFec = new BedFacility();
                bedFec.ID = cboBedCategoryDeptTransfer.SelectedValue.ToString();
                bdType.BedFacility = bedFec;
                bds.BedType = bdType;

                Room rm = new Room();
                rm.RoomID = txtRoomID.Text;
                rm.Floor = txtFloorNo.Text;
                patobj.Room = rm;

                BedCharges bch = new BedCharges();
                string bedCharges = "";
                foreach (ListViewItem itemRow in lstBedDeptTransfer.Items)
                {
                    bedCharges += itemRow.SubItems[0].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[5].Text;
                    bedCharges += ";";
                }

                bds.BedChargesString = bedCharges;
                patobj.Bed = bds;

                Nurse nrs = new Nurse();
                nrs.ID = txtDutyNurse.Text;
                patobj.DutyNurse = nrs;
                patobj.DutyNurse.ID = cboReceivingNurseStation.SelectedValue.ToString();

                NurseStation stn = new NurseStation();
                stn.NurseStationID = cboReceivingNurseStation.SelectedValue.ToString();
                patobj.NurseStation = stn;
            }

            else
            {
                Bed bds = new Bed();
                bds.BedNo = "0";

                BedType bdType = new BedType();
                bdType.ID = "0";
                BedFacility bedFec = new BedFacility();
                bedFec.ID = "0";
                bdType.BedFacility = bedFec;
                bds.BedType = bdType;

                Room rm = new Room();
                rm.RoomID = "0";
                rm.Floor = "0";
                patobj.Room = rm;


                BedCharges bch = new BedCharges();
                bds.BedChargesString = "0";
                patobj.Bed = bds;

                Nurse nrs = new Nurse();
                nrs.ID = cboRecNurseStnDeptTransfer.SelectedValue.ToString();
                patobj.DutyNurse = nrs;
                patobj.DutyNurse.ID = "0";

                NurseStation stn = new NurseStation();
                stn.NurseStationID = "0";
                patobj.NurseStation = stn;
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patobj.EntryParameter = ep;

            return patobj;
        }
        #endregion

        #region PopulateDischarge
        private InPatient PopulateDischarge(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.RegistrationNo = txtRegNo.Text;


            Department odept = new Department();
            odept.DepartmentID = txtDeptID.Text;
            patObj.Department = odept;

            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = txtUnitID.Text;
            patObj.DepartmentUnit = oUnit;


            //Doctor docObj = new Doctor();
            //docObj.ID = cboDoctor.SelectedValue.ToString();


            OPDPayment opdObj = payment;
            patObj.Payment = opdObj;

            //IPDSR.Age patAge = new IPDSR.Age();
            //patAge.Year = int.Parse(txtAgeYears.Text);
            //patAge.Month = int.Parse(txtAgeMonths.Text);
            //patAge.Day = int.Parse(txtAgeDays.Text);
            //patAge.Hour = int.Parse(txtAgeHours.Text);
            //patObj.Age = patAge;

            patObj.DischargeType = cboDischargeType.SelectedValue.ToString();


            RevenueHead oRev = new RevenueHead();
            oRev.RevenueHeadString = revHead;
            patObj.RevenueHead = oRev;

            Bed obed = new Bed();
            obed.BedNo = txtBedId.Text;
            obed.SerialNo = Convert.ToInt16(lstDischargeBedHist.Items[0].SubItems[9].Text);
            patObj.Bed = obed;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patObj.EntryParameter = ep;
            patObj.StaffID = "0";


            return patObj;
        }
        #endregion

        #region PopulatePatAdmissionCancel
        private InPatient PopulatePatAdmissionCancel(OPDPayment payment)
        {
            InPatient patObj = new InPatient();
            patObj.RegistrationNo = txtPatRegNo.Text;
            patObj.Remarks = txtRemarks.Text;

            patObj.StaffID = txtStaffID.Text;

            patObj.CancellationReason = cboCancelReason.SelectedValue.ToString();

            Department odept = new Department();
            odept.DepartmentID = txtDeptID.Text;
            patObj.Department = odept;

            DepartmentUnit oUnit = new DepartmentUnit();
            oUnit.UnitId = txtUnitID.Text;
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
        #endregion

        #region PaymentData For Re-Advance
        private void AdvancePaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                InPatient ipat = this.populateReAdvance((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveAdvanpay(ipat);
                if (i.Length<0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Successfully Deposited!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var str = i.Split('~');
                    string transNo = str[0];
                    string value = str[1];
                    printResult(transNo);
                    //btnNew.PerformClick();
                    btnPatientFind.PerformClick();
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
        #endregion
        private void printResult(string transNo)
        {

            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.AddmissionMoneyReceipt;
            vr.TransactionNo = transNo;
            vr.ReportTitle = "Advance Money Receipt";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();

        }

        #region PaymentData For BedTransfer
        private void BedTransferPaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                InPatient inPat = this.PopulateBedTransfer((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveBedTransfer(inPat);
                if (i == "0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bed Transfer Successfully", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var str = i.Split('~');          
                    string trnsNo = str[0];
                    txtRegNo.Focus();
                    printResult(trnsNo);
                    btnPatientFind.PerformClick();
                    txtAmount.Text = "";
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
        #endregion

        #region PaymentData For DepartmentTransfer
        private void DeptTransferPaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                if ((cboPatDepartment.SelectedValue.ToString() != null) && cboUnit.Items.Count > 0)
                {
                    string j = ipdSc.VerifyPatientDepartment(txtRegNo.Text, cboPatDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                    if (j != "1")
                    {
                        MessageBox.Show(j, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                InPatient oInPat = this.PopulateDeptTransfer((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveDeptTransfer(oInPat);
                if (i == "0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show("Department Transfer Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var str = i.Split('~');
                    string trnsNo = str[0];
                    txtRegNo.Focus();
                    printResult(trnsNo);
                    btnPatientFind.PerformClick();
                    txtAdvancePayment.Text = "";
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

            txtRegNo.Focus();
        }
        #endregion

        #region PaymentData For Discharge
        private void DischargePaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                bool opStats = ipdSc.GetOperationStatus(txtPatRegNo.Text);
                if (opStats==true)
                {
                    MessageBox.Show("Patient is Still in Operation Theater!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (float.Parse(txtNetAmount.Text) > 0)
                {
                     InPatient oInPat = this.PopulateDischarge((OPDPayment)PaymentObject(payment));
                    string i = ipdSc.SavePatientForDischarge(oInPat);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Patient Discharge Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrintDischargeBillSammary(i);
                        PrintDischargeBillDetails(i);
                        this.Dispose();
                    }
                }
                else
                  {
                    if (MessageBox.Show("Are You Sure to Refund Amount?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        InPatient oInPat = this.PopulateDischarge((OPDPayment)PaymentObject(payment));
                        string i = ipdSc.SavePatientForDischarge(oInPat);
                        if (i == "0")
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Patient Discharge Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PrintDischargeBillSammary(i);
                            PrintDischargeBillDetails(i);
                            this.Dispose();
                            // btnNew.PerformClick();
                        }

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

            txtRegistrationID.Focus();

        }

        private void PrintDischargeBillSammary(string regID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DischargeBillSummary;
            vr.TransactionNo = regID;
            vr.ReportTitle = "Patient Discharge Bill Summary";
            vr.ViewReport();          
        }
        private void PrintDischargeBillDetails(string regID)
        {
            frmReportViewer vr = new frmReportViewer();                  
            vr.selector = ViewerSelector.DischargeBillDetails;
            vr.TransactionNo = regID;
            vr.ReportTitle = "Patient Discharge Bill Details";
            vr.ViewReport();
        }
        #endregion

        #region PaymentData For Admission Cancellation
        private void CancelPaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                if (MessageBox.Show("Are You Sure to Cancel Admission?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InPatient pat = this.PopulatePatAdmissionCancel((OPDPayment)PaymentObject(payment));
                    short i = ipdSc.SavePatientAdmissionCancel(pat);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Admission Cancel successfully", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        lstAdPay.Items.Clear();
                        lstAdressInfo.Items.Clear();
                        lstContactInfo.Items.Clear();
                        lstDeptBedHistory.Items.Clear();
                        lstDischargeBedHist.Items.Clear();
                        lstRevenueDetails.Items.Clear();
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
        #endregion

        private void cboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.cboBedTypeCategory(cboBedTrnaBedCategoryType, cboBedType.SelectedValue.ToString());
        }

        private void cboPatDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatDepartment.SelectedValue != "")
            {
                obj.cboUnit(cboUnit, cboPatDepartment.SelectedValue.ToString());
            }
        }

        private void cboBedDeptTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.cboBedTypeCategory(cboBedCategoryDeptTransfer, cboBedDeptTransfer.SelectedValue.ToString()); 
        }

        private void cboBedCategoryDeptTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboBedCategoryDeptTransfer.SelectedValue.ToString() != null) && cboBedDeptTransfer.Items.Count > 0 && cboBedCategoryDeptTransfer.Items.Count > 0)
            {
                obj.getBeds(cboBedNumber, cboBedDeptTransfer.SelectedValue.ToString(), cboBedCategoryDeptTransfer.SelectedValue.ToString());
                obj.LoadListView(lstBedDeptTransfer, cboBedCategoryDeptTransfer.SelectedValue.ToString());
            }
        }

        private void cboBedNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBedTrnaBedCategoryType.SelectedValue != "" && cboBedNumber.SelectedValue != "")
            {
                List<Bed> room = obj.getFloorAndRoom(cboBedNumber.SelectedValue.ToString());
                foreach (Bed oBed in room)
                {
                    lblFloorAndRoom.Text = "Floor" + "-" + oBed.Floor + "\r\n" + "Room No" + "-" + oBed.Room.RoomTitle;
                    txtFloorNo.Text = oBed.Floor;
                    txtRoomID.Text = oBed.Room.RoomID;
                    cboRecNurseStnDeptTransfer.SelectedValue = oBed.NurseStation.NurseStationID;
                    cboRecNurseStnDeptTransfer.Enabled = false;
                }
            }     
        }

        private void chkBedTransfer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBedTransfer.Checked == true)
                {
                    cboBedDeptTransfer.Enabled = true;
                    cboBedCategoryDeptTransfer.Enabled = true;
                    cboBedNumber.Enabled = true;
                    cboRecNurseStnDeptTransfer.Enabled = true;
                    label14.Visible = true;
                    label10.Visible = true;
                    label12.Visible = true;
                }
                else
                {
                    cboBedDeptTransfer.Enabled = false;
                    cboBedCategoryDeptTransfer.Enabled = false;
                    cboBedNumber.Enabled = false;
                    cboRecNurseStnDeptTransfer.Enabled = false;
                    label14.Visible = false;
                    label10.Visible = false;
                    label12.Visible = false;
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

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cboPatDepartment.SelectedValue.ToString() != null) && cboUnit.Items.Count > 0)
                {

                    oPats = ipdSc.GetDepartmentHead(cboPatDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
                }

                foreach (InPatient oPat in oPats)
                {
                    txtDeptHead.Text = oPat.Department.DepartmentUnitHeadID;
                    txtDepartmentHead.Text = oPat.Department.DepartmentUnitHead;
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

        private void nmrAdvanceDeposite_TextChanged(object sender, EventArgs e)
        {
            if (nmrAdvanceDeposite.Text == string.Empty || nmrAdvanceDeposite.Text == ".")
            {
                txtCurrentTotal.Text = "";
                return;
            }
            if (nmrAdvanceDeposite.Text.Length >= 3)
            {
                txtCurrentTotal.Text = (float.Parse(nmrAdvanceDeposite.Text) + float.Parse(txtAdvanceAmount.Text)).ToString();
            }
        }

        private void txtRegistrationID_TextChanged(object sender, EventArgs e)
        {
            if (txtRegistrationID.Text != "" && txtRegistrationID.TextLength == 11)
            {
                btnPatientFind.PerformClick();
            }
        }

        private void tbDetailsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbDetailsInfo.SelectedTab == tabPageAdvPayment)
                {
                    if (txtPatRegNo.Text != "")
                    {
                        txtAdvanceAmount.Text = ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();
                        obj.LoadAdnceListView(lstAdPay, txtPatRegNo.Text);
                    }
                }
                if (tbDetailsInfo.SelectedTab == tabPageBedTransfer)
                {
                    if (txtPatRegNo.Text != "")
                        rdTxtBedAdvance.Text = ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDeptTransfer)
                {
                    if (txtPatRegNo.Text != "")
                        txtrdPreviousAmount.Text = ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDischarge)
                {                
                    revHead = "";
                    if (txtPatRegNo.Text != "")
                    {
                        obj.LoadListViewBed(lstDischargeBedHist, txtPatRegNo.Text);
                        obj.LoadListViewDept(lstDischargeDeptHist, txtPatRegNo.Text);
                        LoadListViewReport(lstDischargeReport,txtPatRegNo.Text);
                        nmrTxtTotal.Text = ipdSc.GetTotalAmountForDischarge(txtRegNo.Text).ToString();
                        nmrTxtAdvance.Text = ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();
                        txtNetAmount.Text = (Convert.ToDecimal(nmrTxtTotal.Text) - Convert.ToDecimal(nmrTxtAdvance.Text)).ToString();
                    }
                    if (txtNetAmount.Text != "")
                    {
                        if (float.Parse(txtNetAmount.Text) < 0)
                            lblPayment.Text = "Refund Amount";
                    }
                }
                if (tbDetailsInfo.SelectedTab == tabPageAdmissionCancel)
                {
                    if (txtPatRegNo.Text != "")
                    {
                        string vrfySatyingTime = ipdSc.CheckPatStayingTime(txtPatRegNo.Text);
                        if (vrfySatyingTime.Length > 0)
                        {
                            //  MessageBox.Show(vrfySatyingTime, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                            // btnNew.PerformClick();
                            return;
                        }
                    }                
                    if (txtPatRegNo.Text != "")
                    {
                        txtCancelTotalAmount.Text = ipdSc.GetTotalAmountForDischarge(txtPatRegNo.Text).ToString();
                        rdTxtNetPayment.Text = ((Convert.ToDecimal(txtCancelTotalAmount.Text) - Convert.ToDecimal(rdPreviousAmount.Text)).ToString());
                    }
                    if (txtPatRegNo.Text != "")
                    {
                        if ((txtDeptID.Text != null) && txtUnitID.Text != null)
                        {
                            oPats = ipdSc.GetDepartmentHead(txtDeptID.Text, txtUnitID.Text).ToList();
                        }

                        foreach (InPatient oPat in oPats)
                        {
                            //  txtRdDepartmentHead.Text = oPat.Department.DepartmentUnitHeadID;
                            txtCancelDeptHead.Text = oPat.Department.DepartmentUnitHead;
                        }
                        LoadListViewReport(lstRevenueDetails, txtPatRegNo.Text);
                    }
                }
                if (tbDetailsInfo.SelectedTab == tabPageBedInfo)
                {
                    if (txtPatRegNo.Text != "")
                    {
                        obj.LoadListViewBed(lvBedHistory, txtPatRegNo.Text);
                    }
                }
                if (tbDetailsInfo.SelectedTab == tabPagePaymentHist)
                {
                    if (txtPatRegNo.Text != "")
                    {
                        txtTotalAmount.Text = ipdSc.GetTotalAmount(txtPatRegNo.Text).ToString();
                        obj.LoadAdnceListView(lvAdPayHist, txtPatRegNo.Text);
                    }
                }
                if (tbDetailsInfo.SelectedTab == tabPageDoctorVisit)
                {
                    LoadListDoctorVisit();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDrugInfo)
                {
                    LoadListPatientDrugs();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDiagTestInfo)
                {
                    LoadListPatientDiagTest();
                }

                if (tbDetailsInfo.SelectedTab == tabPageOprInfo)
                {
                    LoadListPatientOperationDetails();
                }
                if (tbDetailsInfo.SelectedTab == tbPageBillableItem)
                {
                    LoadBillableItemList();
                }
                if (tbDetailsInfo.SelectedTab == tbPageEmrg)
                {
                    LoadEmergencyAmountDetails();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDetailsInfo.SelectedTab == tabPageAdvPayment)
                {
                    AdvancePayment();
                }
                //if (tbDetailsInfo.Controls[2] == tbDetailsInfo.SelectedTab)
                //{
                //    BedTransferPayment();
                //}
                if (tbDetailsInfo.SelectedTab == tabPageBedTransfer)
                {
                    BedTransferPayment();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDeptTransfer)
                {
                    DepartmentTransferPayment();
                }
                if (tbDetailsInfo.SelectedTab == tabPageDischarge)
                {
                    PatientDischarge();
                }
                if (tbDetailsInfo.SelectedTab == tabPageAdmissionCancel)
                {
                    AdmissionCancellation();
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
    
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtRegistrationID.Text = admission_id;
                btnPatientFind.PerformClick();
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

        private void tabPageDischarge_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistrationID_Leave(object sender, EventArgs e)
        {
            txtRegistrationID.Text = txtRegistrationID.Text.ToUpper ();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {         
        }

        private void nmrAdvanceDeposite_Leave(object sender, EventArgs e)
        {

        }

    }
}
