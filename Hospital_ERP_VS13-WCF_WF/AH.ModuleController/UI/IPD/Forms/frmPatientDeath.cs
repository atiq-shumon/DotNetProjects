using AH.DUtility;
using AH.ModuleController.IPDSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmPatientDeath : AH.Shared.UI.frmSmartFormStandard
    {
        public frmPatientDeath()
        {
            InitializeComponent();
        }
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        PatientAdmissionUtility obj = new PatientAdmissionUtility();
        private void btnPatientFind_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtRegistrationID"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            } try
            {
                string vrfy = ipdSc.VerifyInPatient(txtRegistrationID.Text);
                if (vrfy.Length > 0)
                {
                    MessageBox.Show(vrfy, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationID.Focus();
                    return;
                }
                InPatient pat = ipdSc.GetAdmittedPatient(txtRegistrationID.Text);
                LoadPatient(pat);
             
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
            txthcn.Text = pat.HCN;
            txtPatName.Text = pat.Name;
            txtDeptId.Text = pat.Department.DepartmentID;
            txtDepartment.Text = pat.Department.DepartmentTitle;
            txtUnitId.Text = pat.DepartmentUnit.UnitId;
            txtDocId.Text = pat.Doctor.ID;
            txtUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
            txtDoctorName.Text = pat.Department.DepartmentUnitHead;// pat.Doctor.Name;
            txtBloodGroup.Text = pat.BloodGroup;
            txtCountry.Text = pat.Country;
           // txtDeptHeadName.Text = pat.Department.DepartmentUnitHead;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));
         

            txtSex.Text = pat.Sex;
            txtFatherName.Text = pat.FathersName;
            txtMotherName.Text = pat.MothersName;
            txtReligion.Text = pat.Religion;
            txtEmail.Text = pat.Email;
            txtContactNo.Text = pat.CellPhone;
            txtBloodGroup.Text = pat.BloodGroup;
            //photoPath = pat.Photo;


            //rdTxtAdvancePayDept.Text = pat.Department.DepartmentTitle;
            //txtAdvancUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
            //txtRoom.Text = pat.Room.RoomTitle;
            //txtAdvancPayBed.Text = pat.Bed.BedTitle;
            //rdTxtAdvanceFloor.Text = pat.Room.Floor;

            //txtDept.Text = pat.Department.DepartmentTitle;
            //txtRoomNo.Text = pat.Room.RoomTitle;
            //txtBedTransferUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
            txtBedTitle.Text = pat.Bed.BedTitle;
            txtBedID.Text = pat.Bed.BedNo;
           // txtNurseId.Text = pat.DutyNurse.NID;

        }
        #region Populate Patient Death
        private PatientDeath PopulatePatientDeath()
        {
            PatientDeath patDeth = new PatientDeath();

            InPatient patObj = new InPatient();
            patObj.HCN = txthcn.Text;
            patObj.RegistrationNo = txtRegistrationID.Text;
           // patObj.StaffID = txtStaffID.Text;

            Department dept = new Department();
            dept.DepartmentID = txtDeptId.Text;

            DepartmentGroup depGrp = new DepartmentGroup();
            depGrp.DepartmentGroupID = "01";
            dept.DepartmentGroup = depGrp;
            patObj.Department = dept;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = txtUnitId.Text;
            patObj.DepartmentUnit = dunit;

            Bed bds = new Bed();
            bds.BedID = txtBedID.Text;
            patObj.Bed = bds;

            Nurse ns = new Nurse();
            ns.ID = "01";
            patObj.DutyNurse = ns;

            Doctor doc = new Doctor();
            doc.ID = txtDocId.Text;
            patObj.Doctor = doc;

            patDeth.InPatient = patObj;
            patDeth.DeathReasonID = "01";
            patDeth.DeathDTTM = dtpDeathDateTime.Value;
            patDeth.DeathNotes = txtDeathNotes.Text;
            patDeth.Remarks = txtRemarks.Text;


            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patDeth.EntryParameter = ep;

            return patDeth;
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRegistrationID", "txtDeathNotes"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            PatientDeath patDeath = this.PopulatePatientDeath();
            string i = ipdSc.SavePatientDeath(patDeath);
            if (i == "0")
            {
                MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void frmPatientDeath_Load(object sender, EventArgs e)
        {
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboDoctorID.DisplayMember = "value";
            //cboDoctorID.ValueMember = "key";
            //if (cboPatDepartment.SelectedValue != "" && cboUnit.SelectedValue != "")
            //{
            //    cboDoctorID.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetOPDDoctorsDict(cboPatDepartment.SelectedValue.ToString(), cboUnit.SelectedValue.ToString())), null);
            //}
        }

        private void txtDeathNotes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //PatientDeath patDeath = this.PopulatePatientDeath();
            //string i = ipdSc.SavePatientDeath(patDeath);
            //if (i == "0")
            //{
            //    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
