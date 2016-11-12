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
using AH.ModuleController.UI.IPD.Reports.Viewer;

namespace  AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmission : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        string MasterCode = Utility.GetMasterChargeCode(Utility.ChargesCode.BedCharges);
        string revenueHeadGroupAdvance = Utility.GetMasterChargeCode(Utility.ChargesCode.AdvanceCharges);
        string revenueHead = Utility.GetHeadChargeCode(Utility.HeadChargeCode.Advance);
        string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
        private string AdmissionType;
        private string NSID;
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        public frmAdmission(string AdmissionType)
        {
            InitializeComponent();
            this.AdmissionType = AdmissionType;      
        }
        private void frmAdmission_Load(object sender, EventArgs e)
        {
           
                obj.ComboDepartment(cboPatDepartment);
                obj.cboBedType(cboBedType);
                obj.cboReceivingNurseStation(cboReceivingNurseStation);
                obj.FormatListForBed(lstAdmission);

                cboAdmReason.DisplayMember = "Value";
                cboAdmReason.ValueMember = "Key";
                cboAdmReason.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetAdmReasonDict("E")), null);

                cboAdmissionReff.DisplayMember = "Value";
                cboAdmissionReff.ValueMember = "Key";
                cboAdmissionReff.DataSource = new BindingSource((ipdSc.GetAdmReffTypeDic("E")), null);

                txtDepartmentHead.Text = "";
                txtRdDepartmentHead.Text = "";
                txtPrescriptionNo.Select();

                cboOperationType.Enabled = false;
                dtExpecOprDate.Enabled = false;
                lblOprType.Enabled = false;
                lblExpecOprDate.Enabled = false;
                

                showHideAdmissionType(AdmissionType);
          

        }

        #region

         //cboAdmType.SelectedValue = AdmissionType;
         //showHideAdmissionType(AdmissionType);

        // btnNew.PerformClick();
        // txtPatientNo.Select();
        // //FormatGrid();
        // txtDisDate.Text = "__/__/__";
        #endregion;

        private void cboPatDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboPatDepartment.SelectedValue.ToString())), null);
            }

        }
        private void cboBedTypeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if(cboBedType.SelectedValue!="" && cboBedTypeCategory.SelectedValue!="")
            {              
                obj.getBeds(cboBedNo, cboBedType.SelectedValue.ToString(), cboBedTypeCategory.SelectedValue.ToString());
                obj.LoadListView(lstAdmission, cboBedTypeCategory.SelectedValue.ToString());
            }

        }

        private void cboAdmReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExpDisDate.Text = ipdSc.GetMinStayingDays(cboAdmReason.SelectedValue.ToString()).ToString();
            if (!string.IsNullOrEmpty(txtExpDisDate.Text))
            {
                txtDisDate.Text = Utility.DateGenerator(DateTime.Now, int.Parse(txtExpDisDate.Text), "D").ToString("dd/MM/yyyy"); ;
            }

        }

        private void cboPatientSearch_Click(object sender, EventArgs e)
        {
            if (txtHCN.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCN.Focus(); return;
            };
            if (ipdSc.VerifyPatientNo(txtHCN.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCN.Focus(); return;
            };

            Patient pat = ipdSc.GetPatient(txtHCN.Text);
            LoadPatient(pat);
        }

        private void LoadPatient(Patient pat)
        {
            txtPatientName.Text = pat.Name;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;
            txtStaffNo.Text = pat.StaffID;
            //txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
        }

        private void cboBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.cboBedTypeCategory(cboBedTypeCategory, cboBedType.SelectedValue.ToString());
           
        }      
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtPrescriptionNo", "txtHCN", "cboAdmissionReff", "cboUnit", "cboWard", "cboBedType", "cboBedTypeCategory", "cboRoomNo", "cboBedNo", "cboAdmReason", "cboPatDepartment", "cboReceivingNurseStation", "txtAmount"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(txtDepartmentHead.Text=="")
            {
                MessageBox.Show("Department Head is not Assign yet, Please contact with H_R Detartment!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartmentHead.Select();
                return;
            }

            string label = "Advance Deposit Payment";
            string patNo = txtHCN.Text;
            string patName = txtPatientName.Text;
            string department = cboPatDepartment.SelectedValue.ToString();
            string departmentUnit = cboUnit.SelectedValue.ToString();
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.AdvanceCollection);
            string reffDepartment = cboPatDepartment.SelectedValue.ToString();// "N/A";
            string departmentReffUnit = cboUnit.SelectedValue.ToString(); //"N/A";
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
            else
            {
                AH.Shared.MODEL.OPDPayment paymentObject = new AH.Shared.MODEL.OPDPayment();
                paymentObject.Advance = Convert.ToInt64(advance);
                paymentObject.Amount = Convert.ToInt64(txtAmount.Text);
                paymentObject.Department = department;
                paymentObject.DepartmentUnit = departmentUnit;
                paymentObject.DeptAmount = departmentAmount;
                paymentObject.Discount = Convert.ToInt64(discount);
                paymentObject.HCN = txtHCN.Text;
                paymentObject.NetAmount = Convert.ToInt64(txtAmount.Text);
                paymentObject.PaymentDate = updateDate;
                paymentObject.PaymentType = paymentType;
                paymentObject.PurposeID = purposeID;
                paymentObject.ReffDept = reffDepartment;
                paymentObject.ReffDeptAmount = reffDepartmentAmount;
                paymentObject.ReffDeptUnit = departmentReffUnit;
                paymentObject.VAT = Convert.ToInt64(vat);
                paymentObject.PaymentString = Convert.ToInt64(txtAmount.Text) + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + "~" + "0" + ";";

                PaymentData(paymentObject);
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
            paymentObject.PaymentString = payment.PaymentString;
            return paymentObject;
        }

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                if (chkOprAdvised.Checked == true)
                {
                    List<string> vf = new List<string>() { "cboOperationType", "dtExpecOprDate" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }
                }
                if (lstAdmission.Items.Count != 0)
                {
                    if (txtPrescriptionNo.Text.Substring(0, 1) == "P")
                    {
                        string vrfy = ipdSc.VerifyTicketNo(txtPrescriptionNo.Text, true);
                        if (vrfy != "1")
                        {
                            MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPrescriptionNo.Focus();
                            return;
                        }
                    }
                    string vrfyHcn = ipdSc.VerifyHcnNo(txtHCN.Text);
                    if (vrfyHcn != "1")
                    {
                        MessageBox.Show(vrfyHcn, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHCN.Text = "";
                        txtPrescriptionNo.Focus();
                        return;
                    }
                    InPatient pat = this.PopulatePatAdmission((OPDPayment)PaymentObject(payment));
                    string i = ipdSc.saveAdmission(pat);
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Patient Admitted Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var str = i.Split('~');
                        string regNo = str[0];
                        string mrNo = str[1];
                        PrintAdmissionCard(regNo);
                        printResult(mrNo);
                        btnNew.PerformClick();
                        cboPatDepartment.Focus();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Bed Charge is not define yet,Please check!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void showHideAdmissionType(string admisisonType)
        {
            if (admisisonType == "G")
            {
                cboPackage.Enabled = false;
                lblPackage.Enabled = false;
                frmLabel.Text = "General Admission";
            }

            else if (admisisonType == "P")
            {
                frmLabel.Text = "Package Admission";
                cboPackage.Enabled = true;
                lblPackage.Enabled = true;

                cboPackage.DisplayMember = "Value";
                cboPackage.ValueMember = "Key";
                cboPackage.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetPackageMasteDic("P")), null);

            }
            else
            {
                cboPackage.Enabled = false;
                lblPackage.Enabled = false;
                frmLabel.Text = "General Admission";
                Bed oBed = new Bed();
                oBed = ipdSc.GetBedInfoByBedID(AdmissionType);
                cboBedType.SelectedValue = oBed.BedType.ID;
                cboBedTypeCategory.SelectedValue = oBed.BedType.BedFacility.ID;
                cboBedNo.SelectedValue = oBed.BedID;
                cboReceivingNurseStation.SelectedValue = oBed.NurseStation.NurseStationID;
                cboReceivingNurseStation.Enabled = false;
            }
        }
      

        //////////////////////report call here 
        /*
        frmReportViewer vr = new frmReportViewer();
        vr.selector = ViewerSelector.Admission;
        vr.PatientNo = txtPatientNo.Text;
        //vr.TicketNo = txtTicketNo.Text;
        vr.ReportTitle = "OPD Prescription";
        vr.ReportSecondParameter = "";
        //"Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);

        vr.ViewReport();
        */

        private InPatient PopulatePatAdmission(OPDPayment payment)
        {
            InPatient patobj = new InPatient();
            patobj.HCN = txtHCN.Text;
            patobj.StaffID = txtStaffNo.Text;
            patobj.ReferenceType =cboAdmissionReff.SelectedValue.ToString();
            if (txtPrescriptionNo.Text.Substring(0, 1) == "H")
            {
                patobj.ReferenceNo = txtEmergencyNo.Text;
            }
            else
            {
                patobj.ReferenceNo = txtPrescriptionNo.Text;
            }
            patobj.Remarks = txtRemarks.Text;

            if (chkOprAdvised.Checked == true)
            {
                patobj.IsOperationAdvised = "1";
                patobj.OperationID = "1";//cboOperationType.SelectedValue.ToString();
                patobj.ExpectedOperationDate = DateTime.Parse(dtExpecOprDate.Text);
            }
            else
            {
                patobj.IsOperationAdvised = "0";
                patobj.OperationID = "0";              
            }
            patobj.AdmissionType = this.AdmissionType;
            if (patobj.AdmissionType == "G")
            {
                patobj.PackageID = "0";
            }
            else if (AdmissionType == "P")            
            {
                patobj.PackageID = cboPackage.SelectedValue.ToString();
            }
            else 
            {
                patobj.PackageID = "0";
            }
           
            IPDSR.Age patAge = new IPDSR.Age();
            patAge.Year = int.Parse(txtAgeYears.Text);
            patAge.Month = int.Parse(txtAgeMonths.Text);
            patAge.Day = int.Parse(txtAgeDays.Text);
            patAge.Hour = int.Parse(txtAgeHours.Text);
            patobj.Age = patAge;

            patobj.ExpDischargeDate = DateTime.Parse(txtDisDate.Text);

            Purpose purs = new Purpose();
            purs.PurposeID = purposeID;
            patobj.Purpose = purs;

            AdmissionReason adms = new AdmissionReason();
            adms.ID = cboAdmReason.SelectedValue.ToString();
            adms.MinStayDays = short.Parse(txtExpDisDate.Text);
            patobj.AdmissionReason = adms;

            Department dpt = new Department();
            dpt.DepartmentID = cboPatDepartment.SelectedValue.ToString();
            dpt.DepartmentUnitHead = txtRdDepartmentHead.Text;
            patobj.Department = dpt;

            DepartmentUnit unt = new DepartmentUnit();
            unt.UnitId = cboUnit.SelectedValue.ToString();
            patobj.DepartmentUnit = unt;



            Bed bds = new Bed();
            bds.BedNo = cboBedNo.SelectedValue.ToString();
            bds.Floor = txtFloorNo.Text;

           
            patobj.Bed = bds;

            BedType bdType = new BedType();
            bdType.ID = cboBedType.SelectedValue.ToString();

            BedFacility bedFac = new BedFacility();
            bedFac.ID = cboBedTypeCategory.SelectedValue.ToString();
            bdType.BedFacility = bedFac;
            bds.BedType = bdType;

            string bedCharges = "";
            foreach (ListViewItem itemRow in lstAdmission.Items)
            {
                bedCharges += itemRow.SubItems[0].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[5].Text;
                bedCharges += ";";
            }

            bds.BedChargesString = bedCharges;

            Nurse nrs = new Nurse();
            nrs.ID = cboReceivingNurseStation.SelectedValue.ToString();
            patobj.DutyNurse = nrs;

            NurseStation nrStn = new NurseStation();
            nrStn.NurseStationID = cboReceivingNurseStation.SelectedValue.ToString();
            patobj.NurseStation = nrStn;

            Room rm = new Room();
            rm.RoomID = txtRoomNo.Text;
            patobj.Room = rm;

            RevenueHead rvnHd = new RevenueHead();
            rvnHd.ID = revenueHead;

            RevenueHeadGroup rvnHdGroup = new RevenueHeadGroup();
            rvnHdGroup.ID = revenueHeadGroupAdvance;
            rvnHd.RevenueHeadGroup = rvnHdGroup;
            patobj.RevenueHead = rvnHd;

            OPDPayment deposit = new OPDPayment();
            deposit.Amount = decimal.Parse(txtAmount.Text);
            patobj.Payment = deposit;
            patobj.Payment.PaymentType = "1";
           
            patobj.Payment.PaymentString = payment.PaymentString;


            Doctor doc = new Doctor();
            doc.ID = txtDocID.Text;
            patobj.Doctor = doc;
            if(txtEmergencyAmount.Text!="")
            {
                patobj.EmergencyAmount = Convert.ToInt32(txtEmergencyAmount.Text);
            }
            else
            {
                patobj.EmergencyAmount = Convert.ToInt32("0");
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patobj.EntryParameter = ep;

            return patobj;

        }
      
        List<InPatient> oPats = new List<InPatient>();

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboPatDepartment.SelectedValue.ToString() != null) && cboUnit.Items.Count > 0 )
            {
               
                oPats = ipdSc.GetDepartmentHead(cboPatDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString()).ToList();
            }

            foreach (InPatient oPat in oPats)
            {
                txtRdDepartmentHead.Text = oPat.Department.DepartmentUnitHeadID;
                txtDepartmentHead.Text = oPat.Department.DepartmentUnitHead;
            }
        }


        private void btnPatientFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrescriptionNo.Text.Substring(0,1)== "P")
                {
                    string vrfy = ipdSc.VerifyTicketNo(txtPrescriptionNo.Text, true);
                    if (vrfy != "1")
                    {
                        MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrescriptionNo.Focus();
                        //btnNew.PerformClick();
                        return;
                    }


                    InPatient opat = ipdSc.GetPatientDetails(txtPrescriptionNo.Text);
                    LoadPatientDetails(opat);
                }
                if (txtPrescriptionNo.Text.Substring(0, 1) == "H")
                {
                    List<EmergencyCollectionMR> oEm = new List<EmergencyCollectionMR>();
                    oEm = ipdSc.GetEmerDetailsForIPD(txtPrescriptionNo.Text).ToList();
                    if(oEm.Count>0)                 
                    {
                        EmergencyPatientInfoLoad(oEm[0]);
                    }
                }
                if (txtHCN.Text != "")
                {
                    string vrfyHcn = ipdSc.VerifyHcnNo(txtHCN.Text);
                    if (vrfyHcn != "1")
                    {
                        MessageBox.Show(vrfyHcn, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrescriptionNo.Focus();
                        txtHCN.Text = "";
                        return;
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
        private void LoadPatientDetails(InPatient opat)
        {
            cboAdmissionReff.Enabled = false;
            txtHCN.Enabled = false;
            txtHCN.Text = opat.HCN;
            txtPatientName.Text = opat.Name;
            AH.DUtility.Age age = Utility.CalculateAge(opat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = opat.Sex;
            txtReffDocName.Text = opat.Doctor.Name;
            txtDocID.Text = opat.Doctor.ID;
            cboPatDepartment.Text = opat.Department.DepartmentTitle;
            cboUnit.Text = opat.DepartmentUnit.UnitTitle;
            txtStaffNo.Text = opat.StaffID;         
            txtPrescriptionNo.Enabled = false;
            cboAdmissionReff.SelectedValue = "O";
        }
        private void EmergencyPatientInfoLoad(EmergencyCollectionMR opat)
        {
            EmergencyCollectionMR oEmeregency = new EmergencyCollectionMR();
          
            InPatient Pat = new InPatient();
            txtHCN.Text = opat.Patient.HCN;
            txtPatientName.Text = opat.Patient.Name;
            AH.DUtility.Age age = Utility.CalculateAge(opat.Patient.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = opat.Patient.Sex;
            txtReffDocName.Text = opat.Patient.Doctor.Name;
            txtDocID.Text = opat.Patient.Doctor.ID;
            cboPatDepartment.SelectedValue = opat.Patient.Department.DepartmentID;
            cboUnit.SelectedValue = opat.Patient.DepartmentUnit.UnitId;
            txtStaffNo.Text = "0";
            txtPrescriptionNo.Enabled = false;
            cboAdmissionReff.SelectedValue = "E";
            cboAdmissionReff.Enabled = false;
            txtEmergencyAmount.Text = opat.EmrCollHead.NetPaid.ToString();
            txtEmergencyNo.Text = opat.EmergencyMR.ToString();

        }
        private void cboAdmissionReff_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtPrescriptionNo.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPrescriptionNo.Enabled = true;
            cboAdmissionReff.Enabled = true;
        }

        private void chkOprAdvised_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOprAdvised.Checked == true)
            {
                cboOperationType.Enabled = true;
                dtExpecOprDate.Enabled = true;
                lblOprType.Enabled = true;
                lblExpecOprDate.Enabled = true;
                
            }
            else
            {
                cboOperationType.Enabled = false;
                dtExpecOprDate.Enabled = false;
                lblOprType.Enabled = false;
                lblExpecOprDate.Enabled = false;
            }
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrescriptionNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrescriptionNo.Text.Length == Utility.ScanLength)
            {
                btnPatientFind_Click(sender, e);
            }
        }

        private void txtPrescriptionNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPrescriptionNo.Text == "")
            {
                btnNew.PerformClick(); 
            }
        }

        private void printResult(string moneyReceipt)
        {

            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.AddmissionMoneyReceipt;
            vr.TransactionNo = moneyReceipt;
            //vr.ReportTitle = "AH Health Card";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();

        }
        private void PrintAdmissionCard(string moneyReceipt)
        {

            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.AdmissionCard;
            vr.TransactionNo = moneyReceipt;
            vr.ReportTitle = "Admission Label";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();

        }
      
        private void cboBedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboBedTypeCategory.SelectedValue!="" && cboBedNo.SelectedValue!="")
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

        private void txtRemarks_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }

        }

        private void txtPrescriptionNo_Leave(object sender, EventArgs e)
        {
            txtPrescriptionNo.Text= txtPrescriptionNo.Text.ToUpper();
        }

        private void lstAdmission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
      }
       
  }

