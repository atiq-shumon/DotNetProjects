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
    public partial class frmDepartmentTransfer : AH.Shared.UI.frmSmartFormStandard
    {
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
        List<InPatient> oPats = new List<InPatient>();
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        private string RegID;
        public frmDepartmentTransfer(string RegID)
        {
            InitializeComponent();
            this.RegID = RegID;
        }

        private void frmDepartmentTransfer_Load(object sender, EventArgs e)
        {
            if (RegID == "D")
            {
                txtRegNo.Text = "";
            }
            else
            {
                txtRegNo.Text = RegID;
            }          
            obj.ComboDepartment(cboPatDepartment);
            obj.cboBedType(cboBedType);
           // obj.cboReceivingNurseStation(cboReceivingNurse);
           
            obj.FormatListForBed(lstRepGr);

            cboBedType.Enabled = false;            
            cboBedCategoryType.Enabled = false;
            cboBedNo.Enabled = false;
            
            obj.FormatListBedForBedInformation(lvBedHistory);
            obj.FormatGridReport(lvRepGr);           
            txtRegNo.Select();
        }

        private void refreshGrid(string regno)
        {
            obj.LoadListViewBed(lvBedHistory,regno);
            //LoadListViewDept(regno);
           // LoadListViewDiag(regno);
            LoadListViewReport(regno);
        }

        private void cboBedCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if ((cboBedCategoryType.SelectedValue.ToString() != null)  && cboBedType.Items.Count > 0 && cboBedCategoryType.Items.Count > 0)
            {
                if (cboBedType.SelectedValue != "" && cboBedCategoryType.SelectedValue != "")
                {
                    obj.getBeds(cboBedNo, cboBedType.SelectedValue.ToString(), cboBedCategoryType.SelectedValue.ToString());
                    obj.LoadListView(lstRepGr, cboBedCategoryType.SelectedValue.ToString());
                }
            }

        }

        private void cboBedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBedCategoryType.SelectedValue != "" && cboBedNo.SelectedValue != "")
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

        private void btnPatientSearch_Click(object sender, EventArgs e)
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

            refreshGrid(txtRegNo.Text);
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
            txtTransno.Text = pat.Payment.TransactionNo;
            txtBedNo.Text = pat.Bed.BedNo;          
            txtDocID.Text = pat.Doctor.Name;
            txtDoc.Text = pat.Doctor.ID;
            txtDeptID.Text = pat.Department.DepartmentID;
            txtDept.Text = pat.Department.DepartmentTitle;
          
        }

        private void btnSave_Click(object sender, EventArgs e)
         {
             List<string> vf = new List<string>() { "txtRegNo", "cboUnit" };
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
                InPatient oInPat = this.PopulateDeptTransfer((OPDPayment)PaymentObject(payment));
                string i = ipdSc.SaveDeptTransfer(oInPat);
                if (i == "0")
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i == "1")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtRegNo.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
            txtRegNo.Focus();
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
       
        private void cboBedNo_Click_1(object sender, EventArgs e)
        {
        //    //BedCharges bdc = ipdSc.GetBedRatesDictws(cboWard.SelectedValue.ToString(), cboBedType.SelectedValue.ToString(), cboBedNo.SelectedValue.ToString());
        //    //txtAdmCharge.Text = bdc.AdmissionCharge.ToString();
        //    //txtServCharge.Text = bdc.ServiceCharge.ToString();
        //    //txtTransCharge.Text = bdc.TransferCharge.ToString();
        //    //txtBedCharge.Text = bdc.BedCharge.ToString();
        //    // txtVat.Text = bdc.VAT.ToString();
        }

        private void chkBedTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBedTransfer.Checked == true)
            {
                cboBedNo.Enabled = true;
                cboBedType.Enabled = true;
                cboBedCategoryType.Enabled = true;               
            }
            else 
            {
                cboBedNo.Enabled = false;
                cboBedType.Enabled = false;
                cboBedCategoryType.Enabled = false;               
            }
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

        private void cboPatDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatDepartment.SelectedValue != "")
            {
                obj.cboUnit(cboUnit, cboPatDepartment.SelectedValue.ToString());
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
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

            if ((cboPatDepartment.SelectedValue.ToString() != null) && cboUnit.Items.Count > 0)
            {

                string i = ipdSc.VerifyPatientDepartment(txtRegNo.Text, cboPatDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString());
                if (i != "1")
                {
                    MessageBox.Show(i, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }
        private InPatient PopulateDeptTransfer(OPDPayment payment)
        {
            InPatient patobj = new InPatient();
            patobj.HCN = txtHcnNo.Text;
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
          

            if(chkBedTransfer.Checked==true)
            {
            
                    Bed bds = new Bed();
                    bds.BedNo = cboBedNo.SelectedValue.ToString();

                    BedType bdType = new BedType();
                    bdType.ID = cboBedType.SelectedValue.ToString();
                    bds.BedType = bdType;

                    Room rm = new Room();
                    rm.RoomID = cboBedCategoryType.SelectedValue.ToString();
                    patobj.Room = rm;

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
            }

        else{
                Bed bds = new Bed();
                bds.BedNo = "0";

                BedType bdType = new BedType();
                bdType.ID = "0";
                bds.BedType = bdType;

                Room rm = new Room();
                rm.RoomID = "0";
                patobj.Room = rm;

                //Ward wrd = new Ward();
                //wrd.WardID = "0";
                //patobj.Ward = wrd;

                BedCharges bch = new BedCharges();
                bds.BedChargesString = "0";
                patobj.Bed = bds;

                Nurse nrs = new Nurse();
                nrs.ID = "0";
                patobj.DutyNurse = nrs;
                patobj.DutyNurse.ID = "0";
             }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patobj.EntryParameter = ep;

            return patobj;
        }


      
        private void LoadListViewReport(string regno)
        {
            lvRepGr.Items.Clear();

            List<RevenueHead> rvhds = ipdSc.GetDepartmentRevenue(regno).ToList();

            foreach (RevenueHead rv in rvhds)
            {
                ListViewItem itm = new ListViewItem(rv.Title);
                itm.SubItems.Add(rv.Amount.ToString());
                lvRepGr.Items.Add(itm);
            
            }
        }

        private void txtRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRegNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void cboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.cboBedTypeCategory(cboBedCategoryType, cboBedType.SelectedValue.ToString());
        }

      }

   }

