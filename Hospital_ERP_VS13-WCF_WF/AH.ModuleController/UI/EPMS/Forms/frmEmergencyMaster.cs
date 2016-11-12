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
using AH.ModuleController.UI.EPMS.Reports.Viewer;
using System.Threading.Tasks;
using AH.ModuleController.UI.DMS.Forms;


namespace AH.ModuleController.UI.EPMS.Forms
{
    public partial class frmEmergencyMaster : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSR = new DMSSR.DMSWSClient();
        
        public frmEmergencyMaster()
        {
            InitializeComponent();
        }

        private void frmEmergencyMaster_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboAdmDeptType.DisplayMember = "Value";
            cboAdmDeptType.ValueMember = "Key";
            cboAdmDeptType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);

            cboDepartmentType.Text = "Medical";
            cboDepartmentType.Enabled = false;
            cboAdmDeptType.Text = "Medical";
            cboAdmDeptType.Enabled = false;            
            cboDepartmentGroup.Text = "Clinical";
            cboDepartmentGroup.Enabled = false;
            cboDepartment.Text = "Emergency";
            cboDepartment.Enabled = false;
            cboUnit.Text = "--";
            cboUnit.Enabled = false;
            cboAdmDeptGrp.Text = "Clinical";
            cboAdmDeptGrp.Enabled = false;

            txtCopyPrintedBy.Text = Utility.UserId;
            txtCopyPrintedName.Text = Utility.UserName;
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(dmsSR.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(dmsSR.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(dmsSR.GetDeptUnitDic(cboDepartmentGroup.SelectedValue.ToString(), cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Patient pat;
            pat = dmsSR.GetPatient(txtHCNNo.Text, "E");
            LoadPatient(pat);
        }
        private void LoadPatient(Patient pat)
        {
            txtPatientName.Text = pat.Name;
            DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAgeYears.Text = age.Year.ToString();
            txtAgeMonths.Text = age.Month.ToString();
            txtAgeDays.Text = age.Day.ToString();
            txtAgeHours.Text = "0";
            txtSex.Text = pat.Sex;
            txtMobileNo.Text = pat.CellPhone;
            txtHCNNo.Text = pat.HCN;
            txtPresentAddress.Text = pat.Present_H_R_B + Utility.CrLf + Utility.CrLf + pat.PresentThana + ", " + pat.PresentDistrict;
        }

        private void txtHCNNo_TextChanged(object sender, EventArgs e)
        {
            txtHCNNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCNNo.Text.Length == Utility.ScanLength)
            {
                btnSearch_Click(sender, e);
            }
        }

        private EmergencyMaster PopulateEmrergencyRegister(OPDPayment payment)
        {
            EmergencyMaster oEmergencyMaster = new EmergencyMaster();

            oEmergencyMaster.TicketType = "E";
            oEmergencyMaster.PackageID = "0";
            InPatient pat = new InPatient();
            pat.HCN = txtHCNNo.Text;
            AH.ModuleController.DMSSR.Age patientAge = new AH.ModuleController.DMSSR.Age();
            patientAge.Year = int.Parse(txtAgeYears.Text);
            patientAge.Month = int.Parse(txtAgeMonths.Text);
            patientAge.Day = int.Parse(txtAgeDays.Text);
            patientAge.Hour = int.Parse(txtAgeHours.Text);
            pat.AgeBreakDown = patientAge;
            pat.StaffID = "0";
            
            RefdOrg oRefdOrg = new RefdOrg();
            oRefdOrg.OrgID = cboReffOrg.SelectedValue.ToString();
            oEmergencyMaster.RefdOrg = oRefdOrg;          
            DepartmentGroup oDeptGrp = new DepartmentGroup();
            oDeptGrp.DepartmentGroupID = cboDepartmentGroup.SelectedValue.ToString();
            oEmergencyMaster.DepartmentGroup = oDeptGrp;
            Department oDept = new Department();
            oDept.DepartmentID = cboDepartment.SelectedValue.ToString();
            oEmergencyMaster.Department = oDept;
            DepartmentUnit oDeptUnit = new DepartmentUnit();
            oDeptUnit.UnitId = cboUnit.SelectedValue.ToString();
            oEmergencyMaster.DepartmentUnit = oDeptUnit;
            Doctor oDoctor = new Doctor();
            oDoctor.ID = cboReffDoc.SelectedValue.ToString();
            oEmergencyMaster.Doctor = oDoctor;
            NursingTestOrder oNrs = new NursingTestOrder();
            oNrs.NursingStationID = "0";
            oEmergencyMaster.NursingTestOrder = oNrs;
            oEmergencyMaster.TicketValidity = txtTktValid.Text.ToString();
            oEmergencyMaster.CopyPrinted = txtCopyPrinted.Text.ToString();
            oEmergencyMaster.CopyPrintedBY = txtCopyPrintedBy.Text.ToString();
            oEmergencyMaster.PrevTicketNo = "0";
            oEmergencyMaster.TicketFee = 0;
            oEmergencyMaster.ConsultantFee = 0;
            oEmergencyMaster.RefdFee = 0;
            oEmergencyMaster.DeptFee = 0;            
            TestFee oTestFee = new TestFee();
            oTestFee.DiscountType = "0";
            oTestFee.DiscountReff = "0";
            oTestFee.DiscountAuthority = "0";
            oEmergencyMaster.test = oTestFee;
            oEmergencyMaster.NextVisitDate = txtNextVisitDate.Text.ToString();
            if (chkAdmAdv.Checked == true)
            {
                oEmergencyMaster.IsAdmAdv = "1";               

                Department oAdmDept = new Department();
                oAdmDept.DepartmentID = cboAdmDept.SelectedValue.ToString();

                DepartmentGroup oAdmDeptGrp = new DepartmentGroup();
                oAdmDeptGrp.DepartmentGroupID = cboAdmDeptGrp.SelectedValue.ToString();
                oAdmDept.DepartmentGroup = oAdmDeptGrp;

                pat.Department = oAdmDept;

                DepartmentUnit oAdmDeptUnit = new DepartmentUnit();
                oAdmDeptUnit.UnitId = cboAdmUnit.SelectedValue.ToString();
                pat.DepartmentUnit = oAdmDeptUnit;

                Doctor oDoc = new Doctor();
                oDoc.ID = cboadmDoctorID.SelectedValue.ToString();
                pat.Doctor = oDoc;
            }
            if (chkAdmAdv.Checked == false)
            {
                oEmergencyMaster.IsAdmAdv = "0";
                Department oAdmDept = new Department();
                oAdmDept.DepartmentID = "0";

                DepartmentGroup oAdmDeptGrp = new DepartmentGroup();
                oAdmDeptGrp.DepartmentGroupID = "0";
                oAdmDept.DepartmentGroup = oAdmDeptGrp;

                pat.Department = oAdmDept;

                DepartmentUnit oAdmDeptUnit = new DepartmentUnit();
                oAdmDeptUnit.UnitId = "0";
                pat.DepartmentUnit = oAdmDeptUnit;

                Doctor oDoc = new Doctor();
                oDoc.ID = "0";
                pat.Doctor = oDoc;
            }
            Bed oBed = new Bed();
            oBed.Floor = "0";

            Room oRoom = new Room();
            oRoom.RoomID = "0";
            oBed.Room = oRoom;

            BedType oBedType = new BedType();
            oBedType.ID = "0";

            BedFacility oBedFacility = new BedFacility();
            oBedFacility.ID = "0";
            oBedType.BedFacility = oBedFacility;

            oBed.BedType = oBedType;

            oBed.BedNo = "0";

            pat.Bed = oBed;          

            oEmergencyMaster.Patient = pat;
            oEmergencyMaster.DiagnosticPayment = payment;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmergencyMaster.EntryParameter = ep;

            return oEmergencyMaster;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHCNNo", "txtPatientName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSR.VerifyPatientNo(txtHCNNo.Text) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHCNNo.Focus();
                return;
            }
            if (chkAdmAdv.Checked==true)
            {
                List<string> vf1 = new List<string>() { "cboAdmDeptGrp", "cboAdmDept", "cboAdmUnit", "cboadmDoctorID"};
             Control control1 = Utility.ReqFieldValidator(this, vf1);
             if (control1 != null)
                {
                    MessageBox.Show(Utility.getFMS(control1.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control1.Focus();
                    return;
                }
            }
            string label = "Emergency Register Issue";
            string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.PrescriptionFee);
            string patNo = txtHCNNo.Text;
            string patName = txtPatientName.Text;
            string department = cboDepartment.SelectedValue.ToString();
            string departmentUnit = cboUnit.SelectedValue.ToString();
            string reffDepartment = cboDepartment.SelectedValue.ToString();
            string departmentReffUnit = cboUnit.SelectedValue.ToString();
            decimal departmentAmount = 0;
            decimal reffDepartmentAmount = 0;
            string amount = txtTicketFee.Text.ToString();
            string advance = "0";
            string vat = "0";
            string discount = "0";
            string discountBy = "0";
            string paymentType = "0";
            DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));           
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat.ToString(),
                                                discount, discountBy, department, reffDepartment, departmentUnit, departmentReffUnit,
                                                departmentAmount, reffDepartmentAmount, updateDate, paymentType, 0, false);
                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.ShowDialog();
        }
        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            try
            {
                EmergencyMaster oEmergencyRegister = this.PopulateEmrergencyRegister((OPDPayment)PaymentObject(payment));
                string i = dmsSR.SaveEmergencyMaster(oEmergencyRegister);
                txtEmergencyPresNo.Text = i;
                printMR(txtEmergencyPresNo.Text);
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtHCNNo.Focus();
            clear();
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
            paymentObject.AmountGiven = payment.AmountGiven;
            paymentObject.PaymentString = payment.PaymentString;

            return paymentObject;
        }
        private void clear()
        {
            txtHCNNo.Text = "";
            txtMobileNo.Text = "";
            txtPatientName.Text = "";
            txtSex.Text = "";
            txtAgeYears.Text = "";
            txtAgeMonths.Text = "";
            txtAgeDays.Text = "";
            txtAgeHours.Text = "";
            txtPresentAddress.Text = "";
            chkAdmAdv.Checked = false;
        }

        private void cboReffOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
        }

        private void btnAddReffOrg_Click(object sender, EventArgs e)
        {
            frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
            oReffOrg.ShowDialog();
        }
        private void btnRefreshOrg_Click(object sender, EventArgs e)
        {
            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSR.GetReffdOrgDic("D"), null);
        }

        private void btnAddReffDoc_Click(object sender, EventArgs e)
        {
            frmReffdDocSetup oReffDoc = new frmReffdDocSetup();
            oReffDoc.ReffOrg = cboReffOrg.SelectedValue.ToString();
            oReffDoc.ShowDialog();
        }
        private void btnRefreshDoc_Click(object sender, EventArgs e)
        {
            cboReffDoc.DisplayMember = "Value";
            cboReffDoc.ValueMember = "Key";
            cboReffDoc.DataSource = new BindingSource(dmsSR.GetReffdDocDic(cboReffOrg.SelectedValue.ToString()), null);
        }
        private void printMR(string mrNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.EmergencyPrescription;
            vr.MoneyReceiptNo = mrNo;
            vr.ViewReport();
        }

        private void cboAdmDeptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDeptType.SelectedValue != null)
            {
                cboAdmDeptGrp.DisplayMember = "Value";
                cboAdmDeptGrp.ValueMember = "Key";
                cboAdmDeptGrp.DataSource = new BindingSource(dmsSR.GetDeptGroupDicByType(cboAdmDeptType.SelectedValue.ToString()), null);
            }
        }

        private void cboAdmDeptGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDeptGrp.SelectedValue != null)
            {
                cboAdmDept.DisplayMember = "Value";
                cboAdmDept.ValueMember = "Key";
                cboAdmDept.DataSource = new BindingSource(dmsSR.GetDepartmentsetupDic(null, cboAdmDeptGrp.SelectedValue.ToString()), null);
            }
        }

        private void cboAdmDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDept.SelectedValue != "")
            {
                cboAdmUnit.DisplayMember = "Value";
                cboAdmUnit.ValueMember = "Key";
                cboAdmUnit.DataSource = new BindingSource(Utility.VerifyDic(dmsSR.GetDeptUnitDic(cboAdmDeptGrp.SelectedValue.ToString(), cboAdmDept.SelectedValue.ToString())), null);
            }
        }

        private void cboAdmUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAdmDept.SelectedValue != null && cboAdmUnit.SelectedValue != null)
            {
                cboadmDoctorID.ValueMember = "Key";
                cboadmDoctorID.DisplayMember = "Value";
                cboadmDoctorID.DataSource = new BindingSource(dmsSR.GetIPDDoctorsDict(cboAdmDept.SelectedValue.ToString(), cboAdmUnit.SelectedValue.ToString()), null);
            }

        }

    }
}
