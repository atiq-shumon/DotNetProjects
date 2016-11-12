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
    public partial class frmChildBirth : AH.Shared.UI.frmSmartFormStandard
    {
        public frmChildBirth()
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
            }
            try
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
            txthcn.Text = pat.HCN;
           // txtPatName.Text = pat.Name;
           // txtPatName.Text = pat.Name;
            txtDeptId.Text = pat.Department.DepartmentID;
            txtDepartment.Text = pat.Department.DepartmentTitle;
            txtUnitId.Text = pat.DepartmentUnit.UnitId;
            txtDocId.Text = pat.Doctor.ID;
            txtUnitTitle.Text = pat.DepartmentUnit.UnitTitle;
          //  txtDoctorName.Text = pat.Department.DepartmentUnitHead;// pat.Doctor.Name;
           // txtBloodGroup.Text = pat.BloodGroup;
            //txtCountry.Text = pat.Country;
           // txtDeptHeadName.Text = pat.Department.DepartmentUnitHead;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
          //  txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));
         

           // txtSex.Text = pat.Sex;
            txtFatherName.Text = pat.SpouseName;
            txtMotherName.Text = pat.Name;
           // txtReligion.Text = pat.Religion;
           // txtEmail.Text = pat.Email;
            txtContactNo.Text = pat.CellPhone;
           // txtBloodGroup.Text = pat.BloodGroup;
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
        #region Populate Patient Birth
        private IPDBirth PopulatePatientBirth()
        {
            IPDBirth patBirth = new IPDBirth();

            InPatient patObj = new InPatient();
            patObj.HCN = txthcn.Text;
            patObj.RegistrationNo = txtRegistrationID.Text;
            patBirth.DepartmentID = cboPatDepartment.SelectedValue.ToString();
            patBirth.DeptGroupID = "01";
            patBirth.UnitId = cboUnit.SelectedValue.ToString();

            Bed bds = new Bed();
            bds.BedID = txtBedID.Text;
            patObj.Bed = bds;

            //Nurse ns = new Nurse();
            //ns.ID = "01";
            //patObj.DutyNurse = ns;

            patBirth.DoctorId = "1046";//cboDoctorID.SelectedValue.ToString();

            patBirth.InPatient = patObj;
            patBirth.Gender = cboGender.SelectedValue.ToString();
            patBirth.BirthDateTime = dtpBirthDeathTime.Value;
            patBirth.BirthHeight = txtBirthHeight.Text;
            patBirth.BirthWeight = txtBirthWeight.Text;
            patBirth.DischargeWeight = txtDischargeWeight.Text;
            patBirth.BirthType = "01";// cboBirthType.SelectedValue.ToString();
            patBirth.BloodGroup = cboBloodGroup.SelectedValue.ToString();
            patBirth.ChildHCN = txtChildHcn.Text;
            patBirth.GovtRegistrationNo = txtGovtRegID.Text;
            patBirth.BirthMark = txtBirthMarks.Text;
            patBirth.NurseID = "01"; //cboNurseID.SelectedValue.ToString();
            patBirth.Complexion = "01";//cboComplexion.SelectedValue.ToString();
            patBirth.Remarks = txtRemarks.Text;
            patBirth.HealthStatus = "01";// cboHealthStatus.SelectedValue.ToString();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            patBirth.EntryParameter = ep;

            return patBirth;
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRegistrationID", "cboPatDepartment", " cboUnit", "cboGender", "cboBloodGroup", "txtBirthHeight", "txtBirthWeight", "txtDischargeWeight" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            IPDBirth patBirth = this.PopulatePatientBirth();
            string i = ipdSc.SaveChildBirth(patBirth);
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
            obj.ComboDepartment(cboPatDepartment);

            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";
            cboGender.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetSexes()), null);

            cboBloodGroup.DisplayMember = "Value";
            cboBloodGroup.ValueMember = "Key";
            cboBloodGroup.DataSource = new BindingSource(Utility.VerifyDic(Utility.GetBloodGroups()), null);          

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

        private void txtBirthMarks_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void cboPatDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatDepartment.SelectedValue != "")
            {
                obj.cboUnit(cboUnit, cboPatDepartment.SelectedValue.ToString());
            }
        }
      
    }
}
