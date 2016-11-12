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
using AH.ModuleController.UI.IPD.Reports.Viewer;
using AH.Shared.UI;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmBedTransfer : AH.Shared.UI.frmSmartFormStandard
    {

        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();

        string MasterCode = Utility.GetMasterChargeCode(Utility.ChargesCode.BedCharges);
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
        string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
        private string regID;
        public frmBedTransfer(string regID)
        {
            InitializeComponent();
            this.regID = regID;
        }

        private void frmBedTransfer_Load(object sender, EventArgs e)
        {
            if (regID == "B")
            {
                txtRegNo.Text = "";
            }
            else
            {
                txtRegNo.Text = regID;
            }
            PatientAdmissionUtility obj = new PatientAdmissionUtility();
            obj.cboBedType(cboBedType);
           // obj.cboReceivingNurseStation(cboReceivingNurse);
            obj.FormatListForBed(lstRepGr);
            txtRegNo.Select();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRegNo", "txtAdmCharge", "cboBedNo" };
            Control control = Utility.ReqFieldValidator(this,vf);
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
                InPatient ipat = this.PopulateBedTransfer((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveBedTransfer(ipat);
                if (i == "0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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

        }
        

        private void cboPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
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
            txtHcnNo.Text = pat.HCN;

            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";

            txtSex.Text = pat.Sex;
            txtStaffID.Text =pat.StaffID;
            //txtTransno.Text = pat.Payment.TransactionNo;
            txtBedNo.Text = pat.Bed.BedNo;
            txtDeptID.Text = pat.Department.DepartmentID;
            txtDept.Text = pat.Department.DepartmentTitle;
            txtUnitID.Text = pat.DepartmentUnit.UnitId;
            txtRoomNo.Text = pat.Room.RoomNo.ToString();

        }

        private void cboBedNo_Click(object sender, EventArgs e)
        {
            //BedCharges bdc = ipdSc.GetBedRatesDictws(cboWard.SelectedValue.ToString(), cboBedType.SelectedValue.ToString(), cboBedNo.SelectedValue.ToString());
            //txtAdmCharge.Text = bdc.AdmissionCharge.ToString();
            //txtServCharge.Text = bdc.ServiceCharge.ToString();
            //txtTransCharge.Text = bdc.TransferCharge.ToString();
            //txtBedCharge.Text = bdc.BedCharge.ToString();
            //txtVat.Text = bdc.VAT.ToString();
        }
        private void RefreshGrid(string regNo)
        {
           // LoadListView(regNo);
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

        private InPatient PopulateBedTransfer(OPDPayment payment)
        {
            InPatient patobj = new InPatient();
            patobj.HCN = txtHcnNo.Text;
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
            bds.BedType = bdType;

            Room rm = new Room();
            rm.RoomID = txtRoomNo.Text; 
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
            patobj.DutyNurse.ID = cboReceivingNurse.SelectedValue.ToString();

            patobj.Payment = payment;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;

            patobj.EntryParameter = ep;

            return patobj;
        }

        private void btnDepositHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string vrfy = ipdSc.VerifyInPatient(txtRegNo.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegNo.Focus();
                    btnNew.PerformClick();
                    return;
                }

                frmAdvancePaymentHistory payHist = new frmAdvancePaymentHistory(txtRegNo.Text, txtPatientName.Text);
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

      
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        private void cboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.cboBedTypeCategory(cboBedTypeCategory, cboBedType.SelectedValue.ToString());
        }
   

        private void cboBedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboBedTypeCategory.SelectedValue != "" && cboBedNo.SelectedValue != "")
                {
                    List<Bed> room = obj.getFloorAndRoom(cboBedNo.SelectedValue.ToString());
                    foreach (Bed oBed in room)
                    {
                        lblFloorAndRoom.Text = "Floor" + "-" + oBed.Floor + "\r\n" + "Room No" + "-" + oBed.Room.RoomTitle;
                        txtFloorNo.Text = oBed.Floor;
                        txtRoomNo.Text = oBed.Room.RoomID;
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

        private void cboBedTypeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBedType.SelectedValue != "" && cboBedTypeCategory.SelectedValue != "")
            {
                obj.getBeds(cboBedNo, cboBedType.SelectedValue.ToString(), cboBedTypeCategory.SelectedValue.ToString());
                obj.LoadListView(lstRepGr, cboBedTypeCategory.SelectedValue.ToString());
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

    }
 }

