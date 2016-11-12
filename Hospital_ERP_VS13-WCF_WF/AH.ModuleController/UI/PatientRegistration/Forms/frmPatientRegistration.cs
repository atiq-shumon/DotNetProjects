using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.UI.PatientRegistration.Reports.Viewer;
using AH.Shared.UI;
using AH.ModuleController.PatientRegistrationSR;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Text.RegularExpressions;
using AH.ModuleController.UI.HR.Forms;


namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmPatientRegistration : AH.Shared.UI.frmSmartFormStandard
    {  
        PatientRegistrationSR.PatientRegistrationWSClient ob = new PatientRegistrationSR.PatientRegistrationWSClient();
        public string strImagePath = "";
        public string strDepImagePath = "";
        public frmPatientRegistration()
        {
            InitializeComponent();
        }
        public frmPatientRegistration(string HCN)
        {
            InitializeComponent();
            txtHCNNo.Text = HCN;
        }
        List<OpdAppointment> patList;
        List<DistrictThana> oDistThanas;
        private void frmPatientRegistration_Load(object sender, EventArgs e)
        {
            clearDirectory();
            cboPresentAddressDistrict.DisplayMember = "Value";
            cboPresentAddressDistrict.ValueMember = "Key";
            cboPresentAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

            cboPermanentAddressDistrict.DisplayMember = "Value";
            cboPermanentAddressDistrict.ValueMember = "Key";
            cboPermanentAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

            cboEmergencyAddressDistrict.DisplayMember = "Value";
            cboEmergencyAddressDistrict.ValueMember = "Key";
            cboEmergencyAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

            cboCorporateID.DisplayMember = "Value";
            cboCorporateID.ValueMember = "Key";
            cboCorporateID.DataSource = new BindingSource(ob.GetCorpTypeDic("D"), null);

            oDistThanas = ob.GetDistrictAndThana().ToList();

            cboNamePrefixes.DataSource = new BindingSource(ob.GetNamePrefixes(""), null);
            cboNamePrefiexesFat.DataSource = new BindingSource(ob.GetNamePrefixes("m"), null);
            cboNamePrefiexesMot.DataSource = new BindingSource(ob.GetNamePrefixes("f"), null);
            cboNamePrefiexesGuar.DataSource = new BindingSource(ob.GetNamePrefixes(""), null);
            cboNamePrefiexesSpou.DataSource = new BindingSource(ob.GetNamePrefixes(""), null);
            cboNamePrefixes.SelectedIndex = 0;
            cboNamePrefiexesSpou.SelectedIndex = 3;

           //cboPresentAddressThana.DataSource = new BindingSource(ob.GetThanas(), null);
           // cboPermanentAddressThana.DataSource = new BindingSource(ob.GetThanas(), null);
           //cboEmergencyAddressThana.DataSource = new BindingSource(ob.GetThanas(), null);

           // cboPresentAddressDistrict.DataSource = new BindingSource(ob.GetDistricts(), null);
           // cboPermanentAddressDistrict.DataSource = new BindingSource(ob.GetDistricts(), null);
           // cboEmergencyAddressDistrict.DataSource = new BindingSource(ob.GetDistricts(), null);

            cboAgeIndicator.DisplayMember = "Value";
            cboAgeIndicator.ValueMember = "Key";
            cboAgeIndicator.DataSource = new BindingSource(ob.GetAgeIndicators(), null);

            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";
            cboGender.DataSource = new BindingSource(ob.GetSexes(), null);

            cboReligion.DisplayMember = "Value";
            cboReligion.ValueMember = "Key";
            cboReligion.DataSource = new BindingSource(ob.GetReligions(), null);

            cboEducationLevel.DisplayMember = "Value";
            cboEducationLevel.ValueMember = "Key";
            cboEducationLevel.DataSource = new BindingSource(ob.GetEducationLevels(), null);

            cboIncomeGroup.DisplayMember = "Value";
            cboIncomeGroup.ValueMember = "Key";
            cboIncomeGroup.DataSource = new BindingSource(ob.GetIncomeGroups(), null);

            cboMaritialStatus.DisplayMember = "Value";
            cboMaritialStatus.ValueMember = "Key";
            cboMaritialStatus.DataSource = new BindingSource(ob.GetMaritalStatus(), null);

            cboOccupation.DisplayMember = "Value";
            cboOccupation.ValueMember = "Key";
            cboOccupation.DataSource = new BindingSource(ob.GetOccupations(), null);

            cboBloodGroup.DisplayMember = "Value";
            cboBloodGroup.ValueMember = "Key";
            cboBloodGroup.DataSource = new BindingSource(ob.GetBloodGroups(), null);

            cboStaffType.DisplayMember = "Value";
            cboStaffType.ValueMember = "Key";
            cboStaffType.DataSource = new BindingSource(ob.getStaffTypeDic("D"), null);

            cboEmergencyPersonRelationship.DisplayMember = "Value";
            cboEmergencyPersonRelationship.ValueMember = "Key";
            cboEmergencyPersonRelationship.DataSource = new BindingSource(Utility.GetRelationships(), null);

            cboRelationshipWithPatient.DisplayMember = "Value";
            cboRelationshipWithPatient.ValueMember = "Key";
            cboRelationshipWithPatient.DataSource = new BindingSource(Utility.GetRelationships(),null); //new BindingSource(ob.GetRelationships(), null);

           // cboCorporateID.Enabled = false;
            cboCategoryID.Enabled = false;

            chkGeneralPat.Checked = true;
            txtStaffId.Enabled = false;
            btnStaffDetails.Enabled = false;
            lblInfo.Enabled = false;
            cboStaffType.Enabled = false;
            cbodependentId.Enabled = false;
            btnEdit.Enabled = false;

            
          //  txtHCNNo.Select();
           // cboNamePrefixes.Select();
            lvAppointed.Visible = false;
            lvAppointed.Height = 400;
            lvAppointed.Width = 575;
            FormatGrid();
            txtPatientName.Select();

          //  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAppointed_KeyDown);
          //  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAppPat_KeyDown);
            
        }

        private void clearDirectory()
        {
            /*string LocalSourceFile1 = "C:\\P_Photo\\";
            if (Directory.Exists(LocalSourceFile1))
            {
                string[] filePaths = Directory.GetFiles(LocalSourceFile1);
                foreach (string filePath in filePaths)
                File.Delete(filePath);
                Directory.Delete(LocalSourceFile1, true);
            }*/
            string Path = "C:\\P_Photo";
            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    if (Directory.Exists(Path))
                    {
                        System.GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Directory.Delete(Path, true);
                    }
                    return;
                }
                catch (IOException ex)
                {
                    GC.Collect();
                    Thread.Sleep(500);
                }
            }
        }
        private void clearPicFromDirectory()
        {
            string hcn = txtHCNNo.Text;
            string path = "C:\\P_Photo" + "\\" + hcn + ".JPEG";
            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    System.GC.Collect();
                    GC.WaitForPendingFinalizers();
                    FileInfo oInfo = new FileInfo(path);
                    oInfo.Delete();
                }
                catch (IOException ex)
                {
                    System.GC.Collect();
                }
            }
        }

        //public bool IsValidEmailAddress(string email)
        //{
        //    try
        //    {
        //        MailAddress ma = new MailAddress(email);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        { 
            List<string> vf = new List<string>() 
                                { 
                                    "txtPatientName", "txtFatherName", "txtMotherName", "cboGender", "cboReligion", "txtDOB","txtAgeY",
                                    "cboEducationLevel", "cboOccupation", "cboIncomeGroup", "txtCellPhone",
                                    "txtPresentHouseRoad", "cboPresentAddressThana", "cboPresentAddressDistrict", 
                                    /*"txtEmergencyContactPerson", "txtEmergencyAddress", "cboEmergencyAddressThana", "cboEmergencyAddressDistrict",*/
                                    "txtEmergencyCellPhone", "txtPermanentHouseRoadBlock", "cboPermanentAddressThana", "cboPermanentAddressDistrict" 
                                };

            Control control = Utility.ReqFieldValidator(this, vf);
            
            if (control != null )
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (control.Name == "txtPatientName" || control.Name == "txtFatherName" || control.Name == "txtMotherName" || control.Name == "cboGender" ||
                    control.Name == "cboReligion" || control.Name == "txtDOB"  || control.Name == "txtAgeY" || control.Name == "cboEducationLevel" || control.Name == "cboOccupation" ||
                    control.Name == "cboIncomeGroup" || control.Name == "txtCellPhone")
                    {
                    tabPage1.SelectedIndex = 0;
                    control.Focus();
                    return;
                    }

                if (control.Name == "txtPresentHouseRoad" || control.Name == "cboPresentAddressThana" || control.Name == "cboPresentAddressDistrict" ||
                    control.Name == "txtEmergencyCellPhone" || control.Name == "txtPermanentHouseRoadBlock" || control.Name == "cboPermanentAddressThana" ||
                    control.Name == "cboPermanentAddressDistrict")
                    {
                    tabPage1.SelectedIndex = 1;
                    control.Focus();
                    return;
                    }
            }
            if (txtDOB.Text.Length != 10)
            {
                txtDOB.Select();
                return;
            }
            if (txtHCNNo.Text.Length > 0)
            {
                btnSave.Enabled = false;
                return;
            }
            if (txtCellPhone.TextLength != 11)
            {
                txtCellPhone.Focus();
                MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmergencyCellPhone.TextLength != 11)
            {
                this.txtEmergencyCellPhone.Focus();
                MessageBox.Show("Emergency Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmail.Text != string.Empty)
            {
                if (!Utility.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Your Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }

            if (txtNID.Text != string.Empty)
            {
                if (txtNID.TextLength < 13 || txtNID.TextLength > 17)
                {

                    MessageBox.Show("Your NID is incorrect,Please Check !!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNID.Focus();
                    return;
                }
            }
            if (txtDOB.Text == "  /  /")
            {
                txtDOB.Focus();
                return;
            }
               //string i =  new  PatientRegistrationBLL().Save(txtPatientName.Text, txtFatherName.Text);

            if (txtCellPhone.Text != "" || txtCellPhone.Text != null)
            {
                string existingName = "";
                string existingHcn = "";
                List<Patient> searchMblNmbrOldNew = ob.VerifyMobileOldORNew(txtCellPhone.Text).ToList();


                if (searchMblNmbrOldNew.Count > 1)
                {
                    foreach (Patient cl in searchMblNmbrOldNew)
                    {
                        existingName = existingName + cl.Name + " | ";
                        existingHcn = existingHcn + cl.HCN + " | ";
                    }
                    DialogResult dr = MessageBox.Show("Name: " + existingName + "\r\n" +
                                                      "HCN: " + existingHcn + "\r\n" +
                                                      "Already have the same mobile number" + "\r\n" + "\r\n" +
                                                      "Do you want to continue ?", "Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button2
                                                    );
                    if (dr == DialogResult.No)
                    {
                        txtCellPhone.Focus();
                    }

                    if(dr == DialogResult.Yes)
                    {
                        try
                        {
                            #region Payment Commented
                            /* this.tabPage1.SelectedTab = this.tabPage1.TabPages["basicInfo"];
                string label = "Patient Card Issue";
                string patNo = txtHCNNo.Text;
               // string patName = ob.VerifyPatientNo(txtHCNNo.Text);
                string patName = txtPatientName.Text;
                string department = "ADM";
                string departmentUnit = "unit-1";
                string reffDepartment = "N/A";
                string departmentReffUnit = "N/A";
                decimal departmentAmount = 300;
                decimal reffDepartmentAmount = 0;
                string paymentType = "0";
                string discountBy = "0";
                string amount = "300";
                string advance = "0";
                string vat = "0";
                string discount = "0";
                string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.RegistrationCard);
                //DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

                DateTime updateDate = DateTime.Parse(txtDOB.Text);
                    
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance,
                                                vat, discount,discountBy, department, reffDepartment, 
                                                departmentUnit, departmentReffUnit, departmentAmount, 
                                                reffDepartmentAmount, updateDate,paymentType,0,false);

                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.Show();*/
                            #endregion

                            //--------new after excludeing Card Issue Fee ---------
                            Patient patObj = this.PopulatePatient("s");
                            string hcn = ob.SavePatient(patObj);
                            txtHCNNo.Text = hcn;
                            SaveImage(txtHCNNo.Text);

                            string tempHCN = "";
                            tempHCN = txtHCNNo.Text;

                            btnSave.Enabled = false;
                            btnNew.PerformClick();

                            PrintCard(tempHCN);

                            
                            //------------------------------------------------------

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    try
                        {
                            #region Payment Commented
                            /* this.tabPage1.SelectedTab = this.tabPage1.TabPages["basicInfo"];
                string label = "Patient Card Issue";
                string patNo = txtHCNNo.Text;
               // string patName = ob.VerifyPatientNo(txtHCNNo.Text);
                string patName = txtPatientName.Text;
                string department = "ADM";
                string departmentUnit = "unit-1";
                string reffDepartment = "N/A";
                string departmentReffUnit = "N/A";
                decimal departmentAmount = 300;
                decimal reffDepartmentAmount = 0;
                string paymentType = "0";
                string discountBy = "0";
                string amount = "300";
                string advance = "0";
                string vat = "0";
                string discount = "0";
                string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.RegistrationCard);
                //DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

                DateTime updateDate = DateTime.Parse(txtDOB.Text);
                    
                frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance,
                                                vat, discount,discountBy, department, reffDepartment, 
                                                departmentUnit, departmentReffUnit, departmentAmount, 
                                                reffDepartmentAmount, updateDate,paymentType,0,false);

                frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
                frm.Show();*/
                            #endregion

                            //--------new after excludeing Card Issue Fee ---------
                            Patient patObj = this.PopulatePatient("s");
                            string hcn = ob.SavePatient(patObj);
                            txtHCNNo.Text = hcn;
                            SaveImage(txtHCNNo.Text);
                            string tempHCN = "";
                            tempHCN = txtHCNNo.Text;

                            btnSave.Enabled = false;
                            btnNew.PerformClick();

                            PrintCard(tempHCN);
                           
                            //------------------------------------------------------

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                }
            }

        }

        private void PaymentData(AH.Shared.MODEL.OPDPayment payment)
        {
            //Patient patObj = this.PopulatePatient("s");
            //string hcn = ob.SavePatient(patObj, (OPDPayment)PaymentObject(payment));
            //txtHCNNo.Text = hcn;
            //SaveImage(txtHCNNo.Text);
            //PrintCard();
            //btnSave.Enabled = false;
            //btnNew.PerformClick();
        }
        private Patient PopulatePatient(String mode)
        {
            Patient patObj = new Patient();
            patObj.HCN = txtHCNNo.Text;
            patObj.Name = txtPatientName.Text; // mode == "s" ? cboNamePrefixes.Text + " " + txtPatientName.Text : txtPatientName.Text;
            patObj.NameBeng = txtNameBeng.Text;
            patObj.FathersName = txtFatherName.Text; // mode == "s" ? cboNamePrefiexesFat.Text + " " + txtFatherName.Text : txtFatherName.Text;
            patObj.FathersNameBeng = txtFatherNameBeng.Text;
            patObj.MothersName = txtMotherName.Text; // mode == "s" ? cboNamePrefiexesMot.Text + " " + txtMotherName.Text : txtMotherName.Text;
            patObj.MothersNameBeng = txtMotherNameBeng.Text;
            patObj.GuardianName = txtGuardianName.Text; // txtGuardianName.Text != "" ? mode == "s" ? cboNamePrefiexesGuar.Text + " " + txtGuardianName.Text : txtGuardianName.Text : "";
            patObj.GuardianNameBeng = txtGuardianNameBengali.Text;
            patObj.SpouseName = txtSpouseName.Text; // txtSpouseName.Text != "" ? mode == "s" ? cboNamePrefiexesSpou.Text + " " + txtSpouseName.Text : txtSpouseName.Text : "";
            patObj.SpouseNameBeng = txtSpouseNameBeng.Text;
            patObj.BloodGroup = cboBloodGroup.SelectedValue.ToString();
            patObj.Sex = cboGender.SelectedValue.ToString();
            patObj.Religion = cboReligion.SelectedValue.ToString();
            patObj.DOB = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            patObj.Occupation = cboOccupation.SelectedValue.ToString();
            patObj.IncomeGroup = cboIncomeGroup.SelectedValue.ToString();
            patObj.MaritalStatus = cboMaritialStatus.SelectedValue.ToString();
            patObj.MaxEducation = cboEducationLevel.SelectedValue.ToString();
            patObj.CellPhone = txtCellPhone.Text;
            patObj.HomePhone = txtHomePhone.Text;
            patObj.Email = txtEmail.Text;
            patObj.NID = txtNID.Text;

            if(chkGeneralPat.Checked == true)
            {
                patObj.staff_type_id = "";
                patObj.StaffID = "";
                patObj.Dependent_ID = "";
            }

            if (chkStaffPat.Checked == true)
            {
                patObj.staff_type_id = cboStaffType.SelectedValue.ToString();
                patObj.StaffID = txtStaffId.Text;
                patObj.Dependent_ID = "";
            }

            if (chkIsStaffDependent.Checked == true)
            {
                patObj.staff_type_id = cboStaffType.SelectedValue.ToString();
                patObj.StaffID = txtStaffId.Text;
                patObj.Dependent_ID = cbodependentId.SelectedValue.ToString();
            }

            //if (txtStaffId.Text == "")
            //{
            //    patObj.staff_type_id = "";
            //}
            //else
            //{
            //    patObj.staff_type_id = (cboStaffType.Items.Count == 0) ? null : cboStaffType.SelectedValue.ToString();
            //} 

            //patObj.staff_type_id = (cboStaffType.Items.Count == 0) ? null : cboStaffType.SelectedValue.ToString();
            //patObj.StaffID = txtStaffId.Text;

            //if (chkIsStaffDependent.Checked == true)
            //{
            //    patObj.Dependent_ID = cbodependentId.SelectedValue.ToString();
            //}
            //else
            //{
            //    patObj.Dependent_ID = ""; 
            //} 

            patObj.CorporateID = (cboCorporateID.Items.Count == 0) ? null : cboCorporateID.SelectedValue.ToString();
            patObj.Present_H_R_B = txtPresentHouseRoad.Text;
            patObj.Present_H_R_B_Beng = txtPresentAddressBengali.Text;
            patObj.Present_Post = txtPresentPostCode.Text;
            patObj.PresentThana = cboPresentAddressThana.Text;
            patObj.PresentDistrict = cboPresentAddressDistrict.Text;

            patObj.Permanent_H_R_B = txtPermanentHouseRoadBlock.Text;
            patObj.Permanent_Post = txtPermanentPostCode.Text;
            patObj.PermanentThana = cboPermanentAddressThana.Text;
            patObj.PermanentDistrict = cboPermanentAddressDistrict.Text;

            patObj.EmergencyContactPerson = txtEmergencyContactPerson.Text;
            patObj.EmergencyContactPersonBeng = txtContactPersonNameBengali.Text;
            patObj.EmergencyAddress = txtEmergencyAddress.Text;
            patObj.EmergencyAddressBeng = txtEmergencyAddressBengali.Text;
            patObj.EmergencyAddressDistrict =cboEmergencyAddressDistrict.Text;
            patObj.EmergencyAddressThana = cboEmergencyAddressThana.Text;
            patObj.EmergencyHomePhone = txtEmergencyPersonHomePhone.Text;
            patObj.EmergencyCellPhone = txtEmergencyCellPhone.Text;
            patObj.EmergencyPersonEmail = txtEmergencyPersonEmail.Text;
            patObj.EmergencyPersonRelation = cboEmergencyPersonRelationship.SelectedValue.ToString();

            patObj.Photo = Utility.PatientPhotoPath;

            if (picBoxUploadPhoto.Image == null)
            {
                if (open.SafeFileName == "")
                {
                    patObj.Photo = "";
                }
                else
                {
                    patObj.Photo = "image";
                }
            }
            if (picBoxUploadPhoto.Image != null)
            {
                patObj.Photo = "image";           
            }
            //if (chkIsStaffDependent.Checked == false)
            //{
            //    patObj.Photo = "image";
            //}
            patObj.AppointmentID = txtAppointmentID.Text;
            if(chkAllergy.Checked == true)
            {
                patObj.Allergy = "1";
                patObj.AllergyText = txtAllergy.Text;
            }
            if (chkAllergy.Checked == false)
            {
                patObj.Allergy = "0";
                patObj.AllergyText = "";
            }

           // patObj.Allergy = ;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.CompanyID = Utility.CompanyID;
            ep.MachineID = Utility.MachineID;
            patObj.EntryParameter = ep;
      
            return patObj;
        }
 
        private void cboNamePrefixes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PrefixWiseSetter(cboNamePrefixes.Text);
            //if (cboNamePrefixes.Text == "Mr." || cboNamePrefixes.Text == "Mr. Md." || cboNamePrefixes.Text == "Mr. Sree")
            //{
            //    cboGender.Text = "Male";
            //    cboNamePrefiexesSpou.Text = "Mrs.";
            //}
            //if (cboNamePrefixes.Text == "Mrs." || cboNamePrefixes.Text == "Mrs. Mst.")
            //{
            //    cboGender.Text = "Female";
            //    cboNamePrefiexesSpou.Text = "Mr.";
            //}
            //if (cboNamePrefixes.Text == "Miss." || cboNamePrefixes.Text == "Ms.")
            //{
            //    cboGender.Text = "Female";
            //    cboNamePrefiexesSpou.Text = "Mr.";
            //}
        }

        private void PrefixWiseSetter(string prefix)
        {
            switch (prefix)
            {
                case "Mr.":
                    cboGender.Text = "Male";
                    cboNamePrefiexesSpou.Text = "Mrs.";
                    break;
                case "Mr. Md.":
                    cboGender.Text = "Male";
                    cboReligion.Text = "Islam";
                    break;
                case "Mr. Sree":
                    cboGender.Text = "Male";
                    cboReligion.Text = "Hindu";
                    break;
                case "Mrs. Mst.":
                    cboGender.Text = "Female";
                    cboReligion.Text = "Islam";
                    break;
                default:
                    cboGender.Text = "Female";
                    break;
            }
        }

        private void GenerateDOB()
        {
            if (!string.IsNullOrEmpty(txtAgeY.Text) && !string.IsNullOrEmpty(cboAgeIndicator.SelectedValue.ToString()))
            {  
                txtDOB.Text = ob.GetDOB(DateTime.Now, short.Parse(txtAgeY.Text), cboAgeIndicator.SelectedValue.ToString()).ToString("dd/MM/yyyy");
            }
        }  
        private void txtAgeY_Leave(object sender, EventArgs e)
        {
            if (txtAgeY.Text != "" )
            {
                if (Convert.ToInt32(txtAgeY.Text) < 130)
                {
                    DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
                    txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Are you sure about the age???", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus();
                    txtAgeY.Focus();
                }
            }
           
        }
       
        private void txtAgeY_KeyUp(object sender, KeyEventArgs e)
        {
           // if (txtAgeY.Text != "")
          //  {
           //     DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
           //     txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
           // }
        }
        private DUtility.Age PopulateAge(string ageYears, string ageMonths, string ageDays)
        {
            DUtility.Age age = new DUtility.Age();
            age.Year = ageYears.Length > 0 ? int.Parse(ageYears) : 0;
            age.Month = ageMonths.Length > 0 ? int.Parse(ageMonths) : 0;
            age.Day = ageDays.Length > 0 ? int.Parse(ageDays) : 0;
            return age;
        }

        private void txtAgeM_KeyUp(object sender, KeyEventArgs e)
        {
           // if (txtAgeM.Text != "")
          //  {
           //     DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
           //     txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
           // }
        }
        private void txtAgeM_TextChanged(object sender, EventArgs e)
        {
            //DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
           // txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
        }

        private void txtAgeD_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtAgeD.Text != "")
         //   {
          //      DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
          //      txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
          //  }
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            //if (txtHCNNo.Text == "") { MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus(); return; };
            //if (ob.VerifyPatientNo(txtHCNNo.Text) == "") { MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus(); return; };

            //string label = "Patient Card Issue";
            //string patNo = txtHCNNo.Text;
            //string patName = ob.VerifyPatientNo(txtHCNNo.Text);
            //string department = "ADM";
            //string departmentUnit = "unit-1";
            //string reffDepartment = "N/A";
            //string departmentReffUnit = "N/A";
            //decimal departmentAmount = 300;
            //decimal reffDepartmentAmount = 0;
            //string amount = "300";
            //string advance = "0";
            //string vat = Utility.Vat.ToString();
            //string discount = "0";
            //string purposeID = Utility.GetPurposeCode(Utility.PurposeCode.RegistrationCard);
            //DateTime updateDate = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));

            //frmPayment frm = new frmPayment(1, label, patNo, patName, purposeID, amount, advance, vat, discount, department, reffDepartment, departmentUnit, departmentReffUnit, departmentAmount, reffDepartmentAmount, updateDate);
            //frm.onSaveButtonClicked = new frmPayment.SaveButtonClick(PaymentData);
            //frm.Show();
         
            //ci.btnSave.Click+=new EventHandler(btnSave_Click1);
        }

        private object PaymentObject(AH.Shared.MODEL.OPDPayment payment)
        {
            OPDPayment paymentObject = new OPDPayment();
            paymentObject.Advance = payment.Advance;
            paymentObject.Amount = 0 ;//payment.Amount;
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

        private void PrintCard(string tempHCN)
        {       
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.PatientCard;
           // vr.PatientNo = txtHCNNo.Text;
            vr.PatientNo = tempHCN;
            vr.ReportTitle = "AH Health Card";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();        
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            chkFromAppointment.Enabled = false; 
            lblInfo.Enabled = false;
            lblInfo.Text = string.Empty;
            if (txtHCNNo.Text == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus();
                btnNew.PerformClick();
                return;
            };

            if (ob.VerifyPatientNo(txtHCNNo.Text.ToUpper()) == "")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidPatNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHCNNo.Focus();
                btnNew.PerformClick();
                return;
            };

            Patient pat = ob.GetPatient(txtHCNNo.Text.ToUpper());
            LoadPatient(pat);

            chkStaffPat.Enabled = true;
        } 
        
        private void LoadPatient(Patient pat)
        {
            if (pat.StaffID == "" || pat.StaffID == null)
            {
                EnableEditingForGeneralTypePat();
            }
            
            txtPatientName.Text = pat.Name;
            txtFatherName.Text = pat.FathersName;
            txtMotherName.Text = pat.MothersName;
            txtGuardianName.Text = pat.GuardianName;
            txtSpouseName.Text = pat.SpouseName;

            //............b.date calculation.....   
    
            txtDOB.Text = pat.DOB.ToString("dd/MM/yyyy");
            AH.DUtility.Age age = Utility.CalculateAge(DateTime.Parse(txtDOB.Text));
            txtAgeY.Text = age.Year.ToString();
            txtAgeM.Text = age.Month.ToString();
            txtAgeD.Text = age.Day.ToString();

            //DateTime now = DateTime.Today;
            //DateTime birthDate = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy",null);
            //    //get the difference in years
            //TimeSpan ts = now.Date - birthDate.Date;
            //int ageY = (ts.Days/365);
            //int daysleft1 = ts.Days - (ageY*365);
            //int ageM = (daysleft1 / 30);
            //int daysleft2 = daysleft1 - (ageM * 30);
            //int ageD = daysleft2;


            //txtAgeY.Text = ageY.ToString();
            //txtAgeM.Text = ageM.ToString();
            //txtAgeD.Text = ageD.ToString();
      
            //..................................
            
            txtPermanentHouseRoadBlock.Text = pat.Permanent_H_R_B;
            txtPermanentPostCode.Text = pat.Permanent_Post;
            cboPermanentAddressDistrict.Text = pat.PermanentDistrict.ToString();
            cboPermanentAddressThana.Text = pat.PermanentThana.ToString();
            

            txtPresentHouseRoad.Text = pat.Present_H_R_B;
            txtPresentPostCode.Text = pat.Present_Post;
            cboPresentAddressDistrict.Text = pat.PresentDistrict.ToString();
            cboPresentAddressThana.Text = pat.PresentThana.ToString();
            
            ShowImage(LocalSourceFile, Utility.PatientPhotoPath + pat.Photo + ".JPEG");
            txtNameBeng.Text = pat.NameBeng;
            txtFatherNameBeng.Text = pat.FathersNameBeng;
            txtMotherNameBeng.Text = pat.MothersNameBeng;
            txtGuardianNameBengali.Text = pat.GuardianNameBeng;
            txtSpouseNameBeng.Text = pat.SpouseNameBeng;

            txtEmail.Text = pat.Email;
            txtCellPhone.Text = pat.CellPhone;
            txtHomePhone.Text = pat.HomePhone;
            txtNID.Text = pat.NID;
 
            txtEmergencyContactPerson.Text = pat.EmergencyContactPerson;
            txtContactPersonNameBengali.Text = pat.EmergencyContactPersonBeng;
            txtEmergencyAddress.Text = pat.EmergencyAddress;
            txtEmergencyPersonHomePhone.Text = pat.EmergencyHomePhone;
            txtEmergencyCellPhone.Text = pat.EmergencyCellPhone;
            txtEmergencyPersonEmail.Text = pat.EmergencyPersonEmail;
            cboEmergencyAddressDistrict.Text = pat.EmergencyAddressDistrict.ToString();
            cboEmergencyAddressThana.Text = pat.EmergencyAddressThana.ToString();
            
            txtEmergencyPersonEmail.Text = pat.EmergencyPersonEmail;

            cboEmergencyPersonRelationship.SelectedValue = short.Parse(pat.EmergencyPersonRelation);
            
            if (pat.Sex =="Male")
            {
                cboGender.SelectedIndex = 0;
            }
            if (pat.Sex == "Female")
            {
                cboGender.SelectedIndex = 1;
            }
            if (pat.Sex == "Others")
            {
                cboGender.SelectedIndex = 2;
            }
            cboReligion.SelectedValue = pat.Religion;
            if (pat.MaxEducation == "")
            {
                cboEducationLevel.Text = "--Select--";
            }
            else
            {
                cboEducationLevel.SelectedValue = short.Parse(pat.MaxEducation).ToString();
            }    
            cboBloodGroup.SelectedValue = pat.BloodGroup;
            cboOccupation.SelectedValue = short.Parse(pat.Occupation);
            cboIncomeGroup.SelectedValue = short.Parse(pat.IncomeGroup);

            cboStaffType.SelectedValue = pat.staff_type_id;

            if(cboStaffType.SelectedValue == "")
            {
                chkGeneralPat.Checked = true;
                cboStaffType.Enabled = false;
                cboStaffType.SelectedValue = string.Empty;
                txtStaffId.Enabled = false;
                txtStaffId.Text = string.Empty; 
                btnStaffDetails.Enabled = false;
                lblInfo.Enabled = false;
                lblInfo.Text = string.Empty; 
                cbodependentId.Enabled = false;
                cbodependentId.SelectedValue = string.Empty;

                chkStaffPat.Enabled = false;
                chkStaffPat.Checked = false;
                chkIsStaffDependent.Enabled = false;
                chkIsStaffDependent.Checked = false;
                chkFromAppointment.Checked = false;
                chkFromAppointment.Enabled = false;
               // chkFromAppointment.Enabled = false;
            }
            else
            {
                //cboStaffType.SelectedValue = short.Parse(pat.staff_type_id);
                txtStaffId.Text = pat.StaffID;
                StaffVerification();
                GetDependentID();
                cbodependentId.SelectedValue = pat.Dependent_ID.ToString();
                if (cbodependentId.SelectedValue == null)
                {
                    chkStaffPat.Enabled = true;
                    chkStaffPat.Checked = true;
                    cbodependentId.Enabled = false;
                    cbodependentId.SelectedValue = string.Empty;
                    DisableEditingForStaffTypePat();
                }
                else
                {
                    chkStaffPat.Enabled = true;
                    chkStaffPat.Checked = false;
                    lblInfo.Enabled = true;
                    lblInfo.Visible = true;
                    cboStaffType.Enabled = true;
                    chkIsStaffDependent.Enabled = true;
                    chkIsStaffDependent.Checked = true;
                }
           }           
            cboMaritialStatus.SelectedValue = short.Parse(pat.MaritalStatus);
            cboOccupation.SelectedValue = short.Parse(pat.Occupation);

            if (pat.Allergy == "1")
            {
                chkAllergy.Checked = true;
                txtAllergy.Text = pat.AllergyText;
                //if( txtAllergy.Text.Contains(" ")== true)
                //{

                //}
                //if (txtAllergy.Text.Contains(" ") == true)
                //{

                //}
                //if (txtAllergy.Text.Contains(" ") == true)
                //{

                //}
                //else 
            }
            if (pat.Allergy == "0")
            {
                chkAllergy.Checked = false;
                txtAllergy.Text = pat.AllergyText;
            }

            cboCorporateID.SelectedValue = pat.CorporateID;
        }

        private void EnableEditingForGeneralTypePat()
        {
            txtPatientName.ReadOnly = false;
            txtNameBeng.ReadOnly = false;
            txtFatherName.ReadOnly = false;
            txtFatherNameBeng.ReadOnly = false;
            txtMotherName.ReadOnly = false;
            txtMotherNameBeng.ReadOnly =false;
            txtSpouseName.ReadOnly = false;
            txtSpouseNameBeng.ReadOnly = false;
            txtDOB.Enabled = true;
            txtDOB.ReadOnly = false;
            txtAgeY.Enabled = true;
            txtAgeY.ReadOnly = false;
            txtAgeM.Enabled = true;
            txtAgeM.ReadOnly = false;
            txtAgeD.Enabled = true;
            txtAgeD.ReadOnly = false;
            cboReligion.Enabled = true;
            cboGender.Enabled = true;
            cboBloodGroup.Enabled = true;
            cboMaritialStatus.Enabled = true;
            txtCellPhone.ReadOnly = false;
            txtHomePhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNID.ReadOnly = false;
            txtPresentHouseRoad.ReadOnly = false;
            txtPresentPostCode.ReadOnly = false;
            cboPresentAddressDistrict.Enabled = true;
            cboPresentAddressThana.Enabled = true;
            txtPresentAddressBengali.ReadOnly = false;
            txtPresentAddressBengali.Enabled = true;
            txtPermanentHouseRoadBlock.ReadOnly = false;
            txtPermanentPostCode.ReadOnly = false;
            cboPermanentAddressDistrict.Enabled = true;
            cboPermanentAddressThana.Enabled = true;
            btnUploadPhoto.Enabled = true;
            txtContactPersonNameBengali.ReadOnly = false;
            txtEmergencyAddressBengali.ReadOnly = false;
           // txtEmergencyCellPhone.ReadOnly = false;
        }
        private void DisableEditingForStaffTypePat()
        {
            txtPatientName.ReadOnly = true;
            txtNameBeng.ReadOnly = true;
            txtFatherName.ReadOnly = true;
            txtFatherNameBeng.ReadOnly = true;
            txtMotherName.ReadOnly = true;
            txtMotherNameBeng.ReadOnly = true;
            txtSpouseName.ReadOnly = true;
            txtSpouseNameBeng.ReadOnly = true;
            txtDOB.Enabled = false;
            txtAgeY.Enabled = false;
            txtAgeM.Enabled = false;
            txtAgeD.Enabled = false;
            cboReligion.Enabled = false;
            cboGender.Enabled = false;
            cboBloodGroup.Enabled = false;
            cboMaritialStatus.Enabled = false;
            txtCellPhone.ReadOnly = true;
            txtHomePhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNID.ReadOnly = true;
            txtPresentHouseRoad.ReadOnly = true;
            txtPresentPostCode.ReadOnly = true;
            cboPresentAddressDistrict.Enabled = false;
            cboPresentAddressThana.Enabled = false;
            txtPresentAddressBengali.ReadOnly = true;
            txtPresentAddressBengali.Enabled = false;
            txtPermanentHouseRoadBlock.ReadOnly = true;
            txtPermanentPostCode.ReadOnly = true;
            cboPermanentAddressDistrict.Enabled = false;
            cboPermanentAddressThana.Enabled = false;
            btnUploadPhoto.Enabled = false;
            txtContactPersonNameBengali.ReadOnly = true;
            txtEmergencyAddressBengali.ReadOnly = true;
           // txtEmergencyCellPhone.ReadOnly = true;
        }

        private void txtHCNNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHCNNo.Text.ToUpper().Length == Utility.ScanLength)
            {
                txtHCNNo.Text = txtHCNNo.Text.ToUpper();
                btnSave.Enabled = false;
                btnPatientDetails_Click(sender, e);
            }
        }
        private void basicInfo_Click(object sender, EventArgs e)
        {

        }

        private void chkSameAS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSameAS.Checked == true)
            {
                txtPermanentHouseRoadBlock.Text = txtPresentHouseRoad.Text;
                txtPermanentPostCode.Text= txtPresentPostCode.Text;
                cboPermanentAddressDistrict.Text = cboPresentAddressDistrict.Text;
                cboPermanentAddressThana.Text = cboPresentAddressThana.Text;
                chkSameAsPatPresAdd.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableEditingForGeneralTypePat();
            chkGeneralPat.Checked = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            picBoxUploadPhoto.Image = null;

            cbodependentId.Enabled = false;
            cbodependentId.SelectedValue = string.Empty;
            lblInfo.Enabled = false;
            lblInfo.Text = string.Empty;
            //chkIsStaffDependent.Enabled = false;
            chkIsStaffDependent.Checked = false;
            chkStaffPat.Enabled =true;
            chkIsStaffDependent.Enabled = true;
            chkFromAppointment.Enabled = true;
            txtDOB.Text = string.Empty;
            lvAppointed.Visible = false;
        }
        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            frmPatientSearch ps = new frmPatientSearch();
            ps.ShowDialog();
        }

       private void btnEdit_Click(object sender, EventArgs e)
       {
           // StaffVerification();
            List<string> vf = new List<string>() 
                                { 
                                    "txtPatientName", "txtFatherName", "txtMotherName", "cboGender", "cboReligion", "txtDOB","txtAgeY",
                                    "cboEducationLevel", "cboOccupation", "cboIncomeGroup", "txtCellPhone",
                                    "txtPresentHouseRoad", "cboPresentAddressThana", "cboPresentAddressDistrict", 
                                    /*"txtEmergencyContactPerson", "txtEmergencyAddress", "cboEmergencyAddressThana", "cboEmergencyAddressDistrict",*/
                                    "txtEmergencyCellPhone", "txtPermanentHouseRoadBlock", "cboPermanentAddressThana", "cboPermanentAddressDistrict"  
                                };

            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (control.Name == "txtPatientName" || control.Name == "txtFatherName" || control.Name == "txtMotherName" || control.Name == "cboGender" ||
                    control.Name == "cboReligion" || control.Name == "txtDOB" || control.Name == "txtAgeY" || control.Name == "cboEducationLevel" || control.Name == "cboOccupation" ||
                    control.Name == "cboIncomeGroup" || control.Name == "txtCellPhone")
                {
                    tabPage1.SelectedIndex = 0;
                    control.Focus();
                    return;
                }

                if (control.Name == "txtPresentHouseRoad" || control.Name == "cboPresentAddressThana" || control.Name == "cboPresentAddressDistrict" ||
                    control.Name == "txtEmergencyCellPhone" || control.Name == "txtPermanentHouseRoadBlock" || control.Name == "cboPermanentAddressThana" ||
                    control.Name == "cboPermanentAddressDistrict")
                {
                    tabPage1.SelectedIndex = 1;
                    control.Focus();
                    return;
                }
            }
           /* if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }*/
            if (txtDOB.Text.Length != 10)
            {
                txtDOB.Select();
                return;
            }
            if (txtCellPhone.TextLength != 11)
            {
                txtCellPhone.Focus();
                MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (txtEmergencyCellPhone.TextLength != 11)
            {
                txtEmergencyCellPhone.Focus();
                MessageBox.Show(" Emergency Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmail.Text != string.Empty)
            {
                if (!Utility.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Your Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }
            if (txtNID.Text != string.Empty)
            {
                if (txtNID.TextLength < 13 || txtNID.TextLength > 17)
                {
                    MessageBox.Show("Your NID is incorrect,Please Check !!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNID.Focus();
                    return;
                }
            }

            if (txtCellPhone.Text != "" || txtCellPhone.Text != null)
            {
                string existingName = "";
                string existingHcn = "";
                List<Patient> searchMblNmbrOldNew = ob.VerifyMobileOldORNew(txtCellPhone.Text).ToList();

                if (searchMblNmbrOldNew.Count > 1)
                {
                    foreach (Patient cl in searchMblNmbrOldNew)
                    {
                        existingName = existingName + cl.Name + " | ";
                        existingHcn = existingHcn + cl.HCN + " | ";
                    }
                    DialogResult dr = MessageBox.Show("Name: " + existingName + "\r\n" +
                                                      "HCN: " + existingHcn + "\r\n" +
                                                      "Already have the same mobile number" + "\r\n" + "\r\n" +
                                                      "Do you want to continue ?", "Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button2
                                                    );
                    if (dr == DialogResult.No)
                    {
                      //  txtCellPhone.Focus();
                    }

                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            SaveImage(txtHCNNo.Text);
                            short i = ob.UpdatePatientDetails(PopulatePatient("e"));
                            if (i == 0)
                            {
                                MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (i > 0)
                            {
                                MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            clearPicFromDirectory();
                            btnNew.PerformClick();
                            txtPatientName.Select();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }  
                    }
                }
                else
                {
                    try
                    {
                        SaveImage(txtHCNNo.Text);
                        short i = ob.UpdatePatientDetails(PopulatePatient("e"));
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        clearPicFromDirectory();
                        btnNew.PerformClick();
                        txtPatientName.Select();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }  
                }
            }

            
        }

        string LocalSourceFile;
        private void ShowImage(string ImgPath, string DestinationPath)
        {
                string appImagePath = Path.GetDirectoryName("C:\\Patient_Photo") ;
                            
                if (Directory.Exists(appImagePath) == false)
                {
                    Directory.CreateDirectory(appImagePath);
                }

                string folderLocation = "C:\\P_Photo\\";
                LocalSourceFile = "C:\\P_Photo\\" + txtHCNNo.Text + ".JPEG";
                if (Directory.Exists(folderLocation) == false)
                {
                    Directory.CreateDirectory(folderLocation);
                }

                FileInfo patient_image = new FileInfo(LocalSourceFile);
                if (!patient_image.Exists)
                {
                    if (File.Exists(DestinationPath))
                    {
                        File.Copy(DestinationPath, LocalSourceFile, true);
                    }
                    else
                    {
                        File.Copy(Utility.PatientPhotoPath + "\\" + "Default.JPEG", LocalSourceFile, true);
                    }                    
                }
            picBoxUploadPhoto.Image = new Bitmap(LocalSourceFile);
            picBoxUploadPhoto.Image = Utility.ScaleImage(picBoxUploadPhoto.Image, 220, 257);
            picBoxUploadPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            open.Multiselect = true;
            DialogResult result = open.ShowDialog();
            open.Filter = "JPeg Image|*.jpg";
            if (result == DialogResult.OK)
            {
                if (picBoxUploadPhoto.Image == null || picBoxUploadPhoto.Image != null)
                {
                    picBoxUploadPhoto.Image = new Bitmap(open.OpenFile());
                    picBoxUploadPhoto.Image = Utility.ScaleImage(picBoxUploadPhoto.Image, 220, 257);
                    picBoxUploadPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void SaveImage(string HCNNumber)
        {
            if (txtStaffId.Text != "" && chkIsStaffDependent.Checked == false)
            {
                string SourceFile = Utility.EmployeePhotoPath + txtStaffId.Text + ".JPEG";
                FileInfo Staff_image = new FileInfo(SourceFile);
                if (Staff_image.Exists)
                {
                    picBoxUploadPhoto.Image = new Bitmap(SourceFile);
                    picBoxUploadPhoto.Image = Utility.ScaleImage(picBoxUploadPhoto.Image, 220, 257);
                    picBoxUploadPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    File.Copy(Utility.EmployeePhotoPath + "\\" + "Default.JPEG", SourceFile, true);
                }
                Stream buffer;
                string filePathImage = save.FileName + Utility.PatientPhotoPath + HCNNumber + ".JPEG";
                StreamReader srImage = new StreamReader(SourceFile);
                buffer = srImage.BaseStream;
                Bitmap bmImage = new Bitmap(buffer);
                if (File.Exists(filePathImage))
                {
                    DialogResult msg = MessageBox.Show("This file already exists,Do u want to Replace it?", "Replacing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (msg == DialogResult.Yes)
                    {
                        File.Delete(filePathImage);
                        Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                        oImage.Save(filePathImage);
                    }
                }
                else
                {
                    File.Delete(filePathImage);
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(filePathImage);
                    filePathImage = " ";
                    oImage.Dispose();
                }
            }
            else
            {
                string filePathImage = save.FileName + Utility.PatientPhotoPath + HCNNumber + ".JPEG";    // "\\" + HCNNumber + ".JPEG";
                Stream buffer;
                if (open.FileName == "")
                {
                    return;
                }
                else
                {
                    if (open.FileName != "")
                    {
                        StreamReader srImage = new StreamReader(open.FileName);
                        buffer = srImage.BaseStream;
                        Bitmap bmImage = new Bitmap(buffer);

                        if (File.Exists(filePathImage))
                        {
                            DialogResult msg = MessageBox.Show("This file already exists,Do u want to Replace it?", "Replacing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (msg == DialogResult.Yes)
                            {
                                File.Delete(filePathImage);
                                Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                                oImage.Save(filePathImage);
                            }
                        }
                        else
                        {
                            File.Delete(filePathImage);
                            Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                            oImage.Save(filePathImage);
                            filePathImage = " ";
                            oImage.Dispose();
                        }
                    }
                }
            }
        }

        #region Propercase
        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            if (txtPatientName.Text !="")
            { 
                txtPatientName.Text = Utility.ProperCase(txtPatientName.Text); 
            }     
        }
     
        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            if(txtFatherName.Text != "")
            {
                txtFatherName.Text = Utility.ProperCase(txtFatherName.Text);
            }
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            if (txtMotherName.Text != "")
            {
                txtMotherName.Text = Utility.ProperCase(txtMotherName.Text);
            }
        }

        private void txtGuardianName_Leave(object sender, EventArgs e)
        {
            if (txtGuardianName.Text != "")
            {
                txtGuardianName.Text = Utility.ProperCase(txtGuardianName.Text);
            }
        }
        private void txtSpouseName_Leave(object sender, EventArgs e)
        {
            if (txtSpouseName.Text != "")
            {
                txtSpouseName.Text = Utility.ProperCase(txtSpouseName.Text);
            }
        }
        #endregion Propercase

        public void StaffVerification()
        {
            lblInfo.Enabled = true;
            lblInfo.Text = "";
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = ob.GetEmpMaster(txtStaffId.Text);           
            if (txtStaffId.Text != "")
            {
                if (txtStaffId.Text == oEmpMas.EmpId)
                {
                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Department.DepartmentTitle.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Designation.DesignationId.ToString();   
                }
                else
                {
                    lblInfo.Text =string.Empty;
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);       
                }
            }
        } 
      private void GetDependentID()
      {
          EmployeeMaster oEmpMas = new EmployeeMaster();
          oEmpMas = ob.GetEmpMaster(txtStaffId.Text);
          if (txtStaffId.Text != "")
            {
                if (txtStaffId.Text == oEmpMas.EmpId)
                {
                    cbodependentId.Enabled = true;
                    cbodependentId.DisplayMember = "DependName";
                    cbodependentId.ValueMember = "DependID";
                    cbodependentId.DataSource = ob.GetEmpDependent(txtStaffId.Text);
                }
            }
          else
          {
              MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
      }
      private void cbodependentId_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (chkIsStaffDependent.Checked == true)
          {
              if (cbodependentId.SelectedValue.ToString() != "")
              {
                  string dpnd = cbodependentId.SelectedValue.ToString();
                  List<EmployeeDependent> eDepend = ob.GetEmpDependent(txtStaffId.Text).ToList();
                  IEnumerable<EmployeeDependent> EmployeeDependentLocal;
                  //if (dpnd.Length == 0 || dpnd == "")
                  //{
                  //        EmployeeDependentLocal = eDepend;
                  // }
                  //    else
                  //    {
                  EmployeeDependentLocal = eDepend.Where(x => x.DependID.ToLower().Contains(dpnd.ToLower()));
                  //   }

                  foreach (EmployeeDependent oEmpDepnd in EmployeeDependentLocal)
                  {
                      ResetAllTextCbo();
                      txtPatientName.Text = oEmpDepnd.DependName;
                      txtPatientName.ReadOnly = true;
                      txtDOB.Text = Convert.ToString(oEmpDepnd.DOB);
                      string dependentID = oEmpDepnd.DependID.ToString();
                      txtPatientName.ReadOnly = true;
                      txtDOB.ReadOnly = true;
                      txtAgeY.ReadOnly = true;
                      txtAgeM.ReadOnly = true;
                      txtAgeD.ReadOnly = true;
                      string staffId = txtStaffId.Text;
                      txtFatherName.Text = string.Empty;
                      txtMotherName.Text = string.Empty;

                      picBoxUploadPhoto.Image = null;
                      string SourceFile = Utility.EmployeeDependentPhotoPath + staffId+"/"+ dependentID + ".JPEG";
                     // if (strImagePath.ToString() != "default")
                    //  {
                          FileInfo Staff_depend_image = new FileInfo(SourceFile);
                          if (Staff_depend_image.Exists)
                          {
                              picBoxUploadPhoto.Image = new Bitmap(SourceFile);
                              picBoxUploadPhoto.Image = Utility.ScaleImage(picBoxUploadPhoto.Image, 220, 257);
                              picBoxUploadPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                          }
                    //  }
                      else
                      {
                          File.Copy(Utility.EmployeeDependentPhotoPath + "default.JPEG", SourceFile, true);
                      }

                  }

              }
          }

      }

      private void ResetAllTextCbo()
      {
            txtHCNNo.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtMotherName.Text = string.Empty;
            txtGuardianName.Text = string.Empty;
            txtSpouseName.Text = string.Empty;
            txtAgeY.Text = string.Empty;
            txtAgeM.Text = string.Empty;
            txtAgeD.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtCellPhone.Text = string.Empty;
            txtHomePhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNID.Text = string.Empty;
            txtPresentHouseRoad.Text = string.Empty;
            txtPresentPostCode.Text = string.Empty;
            txtPermanentHouseRoadBlock.Text = string.Empty;
            txtPermanentPostCode.Text = string.Empty;
            txtEmergencyContactPerson.Text = string.Empty;
            txtEmergencyPersonEmail.Text = string.Empty;
            txtEmergencyAddress.Text = string.Empty;
            txtEmergencyCellPhone.Text = string.Empty;
            txtEmergencyPersonHomePhone.Text = string.Empty;
            txtAllergy.Text = string.Empty;
            txtGuardianNameBengali.Text = string.Empty;
            txtSpouseNameBeng.Text= string.Empty;

            cboBloodGroup.SelectedIndex =0;
            cboGender.SelectedIndex =0;
            cboReligion.SelectedIndex =0;
            cboMaritialStatus.SelectedIndex =0;
            cboEducationLevel.SelectedIndex =0;
            cboOccupation.SelectedIndex =0;
            cboIncomeGroup.SelectedIndex =0;
            //cboCategoryID.SelectedIndex =0;
            cboPresentAddressDistrict.Text = "--Select--";
            cboPresentAddressThana.Text = "--Select--";
            cboPermanentAddressDistrict.Text = "--Select--";
            cboPermanentAddressThana.Text = "--Select--";
            cboEmergencyAddressDistrict.Text = "--Select--";
            cboEmergencyAddressThana.Text = "--Select--";
            cboEmergencyPersonRelationship.SelectedIndex =0;


            chkSameAS.Checked = false;
            chkSameAsPatPresAdd.Checked = false;
            chkSameAsPatPerAdd.Checked = false;
            chkAllergy.Checked = false;


            txtHCNNo.Enabled = true;
            txtPatientName.Enabled = true;
            txtFatherName.Enabled = true;
            txtMotherName.Enabled = true;
            txtGuardianName.Enabled = true;
            txtSpouseName.Enabled = true;
            txtAgeY.Enabled = true;
            txtAgeM.Enabled = true;
            txtAgeD.Enabled = true;
            txtDOB.Enabled = true;
            txtCellPhone.Enabled = true;
            txtHomePhone.Enabled = true;
            txtEmail.Enabled = true;
            txtNID.Enabled = true;
            txtPresentHouseRoad.Enabled = true;
            txtPresentPostCode.Enabled = true;
            txtPermanentHouseRoadBlock.Enabled = true;
            txtPermanentPostCode.Enabled = true;
            txtEmergencyContactPerson.Enabled = true;
            txtEmergencyPersonEmail.Enabled = true;
            txtEmergencyAddress.Enabled = true;
           // txtEmergencyCellPhone.Enabled = true;
            txtEmergencyPersonHomePhone.Enabled = true;
            txtAllergy.Enabled = true;

            cboBloodGroup.Enabled = true;
            cboGender.Enabled = true;
            cboReligion.Enabled = true;
            cboMaritialStatus.Enabled = true;
            cboEducationLevel.Enabled = true;
            cboOccupation.Enabled = true;
            cboIncomeGroup.Enabled = true;
           // cboCategoryID.Enabled = true;
            cboPresentAddressDistrict.Enabled = true;
            cboPresentAddressThana.Enabled = true;
            cboPermanentAddressDistrict.Enabled = true;
            cboPermanentAddressThana.Enabled = true;
            cboEmergencyAddressDistrict.Enabled = true;
            cboEmergencyAddressThana.Enabled = true;
            cboEmergencyPersonRelationship.Enabled = true;


            chkSameAS.Enabled = true;
            chkSameAsPatPresAdd.Enabled = true;
            chkSameAsPatPerAdd.Enabled = true;
            chkAllergy.Enabled = true;

            txtHCNNo.ReadOnly = false;
            txtPatientName.ReadOnly = false;
            txtFatherName.ReadOnly = false;
            txtMotherName.ReadOnly = false;
            txtGuardianName.ReadOnly = false;
            txtSpouseName.ReadOnly = false;
            txtAgeY.ReadOnly = false;
            txtAgeM.ReadOnly = false;
            txtAgeD.ReadOnly = false;
            txtDOB.ReadOnly = false;
            txtCellPhone.ReadOnly = false;
            txtHomePhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNID.ReadOnly = false;
            txtPresentHouseRoad.ReadOnly = false;
            txtPresentPostCode.ReadOnly = false;
            txtPermanentHouseRoadBlock.ReadOnly = false;
            txtPermanentPostCode.ReadOnly = false;
            txtEmergencyContactPerson.ReadOnly = false;
            txtEmergencyPersonEmail.ReadOnly = false;
            txtEmergencyAddress.ReadOnly = false;
           // txtEmergencyCellPhone.ReadOnly = false;
            txtEmergencyPersonHomePhone.ReadOnly = false;
            txtAllergy.ReadOnly = false;

      }
      private void btnStaffDetails_Click(object sender, EventArgs e)
      {
          if (cboStaffType.SelectedValue == "")
          {
              MessageBox.Show("Please Provide the Staff Type First", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
          }
          else
          {
              if (chkIsStaffDependent.Checked == true)
              {
                  txtHCNNo.Text = string.Empty;
                  StaffVerification();
                  if (lblInfo.Text != string.Empty)
                  {
                      GetDependentID();
                  }
                  else
                  {
                      btnNew.PerformClick();
                      return;
                  }    
              }
              if (chkStaffPat.Checked == true)
              {
                  txtHCNNo.Text = string.Empty;
                  if (txtStaffId.Text != "")
                  {
                      lblInfo.Enabled = true;
                      string staffID = txtStaffId.Text;
                      string isStaffSelf = "1";
                      Patient StaffPat = ob.GetStaffTypePatient(staffID, isStaffSelf);
                      if(StaffPat.HCN !=null)
                      {
                          txtHCNNo.Text = StaffPat.HCN;
                          clearPicFromDirectory();
                          btnPatientDetails.PerformClick();
                          DisableEditingForStaffTypePat();  
                      }
                      if (StaffPat.HCN == null)
                      {
                          StaffVerification();
                          if (lblInfo.Text != string.Empty)
                          {
                              EmployeeMaster sPat = new EmployeeMaster();
                              sPat = ob.GetEmployeeMaster(txtStaffId.Text);
                              strImagePath = sPat.PhotoPath;
                              LoadStaffDetails(sPat);
                              DisableEditingForStaffTypePat(); 
                          }
                          else
                          {
                              btnNew.PerformClick();
                              return;
                          }
                      }
                  }
                  else
                  {
                      MessageBox.Show("Please Provide the Staff ID First", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
              }
          }
      }
  
      public void StaffImageLoad()
      {
          string SourceFile = Utility.EmployeePhotoPath + txtStaffId.Text + ".JPEG";
          if (strImagePath.ToString() != "default")
          {             
              FileInfo Staff_image = new FileInfo(SourceFile);
              if (Staff_image.Exists)
              {
                  picBoxUploadPhoto.Image = new Bitmap(SourceFile);
                  picBoxUploadPhoto.Image = Utility.ScaleImage(picBoxUploadPhoto.Image, 220, 257);
                  picBoxUploadPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
              }
          }
          else
          {
              File.Copy(Utility.EmployeePhotoPath + "default.JPEG", SourceFile, true);
          }
      }

      private void LoadStaffDetails(EmployeeMaster sPat)
      {
         // EnableEditingForGeneralTypePat();
          txtPatientName.Text = sPat.FirstName + " " +sPat.MiddleName + " " + sPat.LastName;
          
          txtFatherName.Text = sPat.FathersName;        
          txtMotherName.Text = sPat.MothersName;        
          txtGuardianName.Text = sPat.GuardianName;        
          txtSpouseName.Text = sPat.SpouseName;
          txtDOB.Text = sPat.DOB.ToString("dd/MM/yyyy");
          
          //DateTime now = DateTime.Today;
          //DateTime birthDate = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", null);
          ////get the difference in years
          //TimeSpan ts = now.Date - birthDate.Date;
          //int ageY = (ts.Days / 365);
          //int daysleft1 = ts.Days - (ageY * 365);
          //int ageM = (daysleft1 / 30);
          //int daysleft2 = daysleft1 - (ageM * 30);
          //int ageD = daysleft2;
          //txtAgeY.Text = ageY.ToString();
          //txtAgeM.Text = ageM.ToString();
          //txtAgeD.Text = ageD.ToString();

          txtPresentAddressBengali.Text = sPat.Present_H_R_B_Beng;
          txtContactPersonNameBengali.Text = sPat.GuardianNameBeng;
         
          txtPermanentHouseRoadBlock.Text = sPat.Permanent_H_R_B;   
          txtPermanentPostCode.Text = sPat.Permanent_Post;
          cboPermanentAddressDistrict.Text = sPat.PermanentDistrict.ToString();
          cboPermanentAddressThana.Text = sPat.PermanentThana.ToString();  

          txtPresentHouseRoad.Text = sPat.Present_H_R_B;
          txtPresentPostCode.Text = sPat.Present_Post;
          cboPresentAddressDistrict.Text = sPat.PresentDistrict.ToString();
          cboPresentAddressThana.Text = sPat.PresentThana.ToString();

          StaffImageLoad();
        //  txtNameBeng.Text = sPat.NameBeng; //txtPatientName.Text;
        //  txtFatherNameBeng.Text = sPat.FathersNameBeng;
        //  txtMotherNameBeng.Text = sPat.MothersNameBeng;
        //  txtGuardianNameBengali.Text = sPat.GuardianNameBeng;
        //  txtSpouseNameBeng.Text = sPat.SpouseNameBeng;

          txtEmail.Text = sPat.Email;
          if(sPat.CellPhone != "")
          {
              string cell = sPat.CellPhone;
              if(cell.Contains (",")==true)
              {
                  string cell1 = cell.Split(',')[0];
                  string cell2 = cell.Split(',')[1];
                  txtCellPhone.Text = sPat.CellPhone;
              }
              else
              {
                  txtCellPhone.Text = sPat.CellPhone;
              }
          }
          else
          {
              txtCellPhone.Text = "";
          }
          
          txtHomePhone.Text = sPat.HomePhone;
          txtNID.Text = sPat.NID;

          txtEmergencyContactPerson.Text = sPat.GuardianName;
          txtContactPersonNameBengali.Text = sPat.GuardianName;
          cboGender.SelectedValue = sPat.Sex;
          cboReligion.SelectedValue = sPat.Religion;
          cboBloodGroup.Text = sPat.BloodGroup; 
      }

      private void cboStaffType_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (cboStaffType.SelectedValue == null)
          {
              txtStaffId.Enabled = false;
              btnStaffDetails.Enabled = false;
              lblInfo.Enabled = false;
          }
          else
          {
              txtStaffId.Enabled = true;
              btnStaffDetails.Enabled = true;
              lblInfo.Enabled = true;
          }
      }

      private void chkGeneralPat_CheckedChanged(object sender, EventArgs e)
      {

          if (chkGeneralPat.Checked == true)
          { 
              chkStaffPat.Checked = false;
              chkIsStaffDependent.Checked = false;
              chkFromAppointment.Checked = false;

              cboStaffType.Enabled = false;
              cboStaffType.SelectedValue = string.Empty;

              txtStaffId.Enabled = false;
              txtStaffId.Text = string.Empty;

              btnStaffDetails.Enabled = false;

              lblInfo.Enabled = false;
              lblInfo.Text = string.Empty;

              cbodependentId.Enabled = false;
              cbodependentId.SelectedValue = string.Empty;
              txtAppPat.Enabled = false;   
          }
      }

      private void chkStaffPat_CheckedChanged(object sender, EventArgs e)
      {
          if (chkStaffPat.Checked == true)
          {
              cboStaffType.Enabled = true;
              chkGeneralPat.Checked = false;
              chkFromAppointment.Checked = false;
              chkIsStaffDependent.Checked = false;
              cbodependentId.Enabled = false;
              txtAppPat.Enabled = false;    
          }
          if (chkStaffPat.Checked == false)
          {
              cboStaffType.Enabled = false;
              cbodependentId.Enabled = false;
              txtAppPat.Enabled = false;
              txtStaffId.Enabled = false;
              btnStaffDetails.Enabled = false;
          }
      }

      private void chkIsStaffDependent_CheckedChanged(object sender, EventArgs e)
      {
          if (chkIsStaffDependent.Checked == true)
          {
              chkStaffPat.Checked = false;
              chkGeneralPat.Checked = false;
              chkFromAppointment.Checked = false;
              cboStaffType.Enabled = true;
              txtStaffId.Enabled = true;
              btnStaffDetails.Enabled = true;      
              cbodependentId.Enabled = true;
              txtAppPat.Enabled = false;

              if (txtStaffId.Text.Length == 4)
              {
                  btnStaffDetails.PerformClick();
              }
          }
          if (chkIsStaffDependent.Checked == false)
          {
              txtStaffId.Enabled = false;
              btnStaffDetails.Enabled = false;
              chkGeneralPat.Checked = false;
              cbodependentId.Enabled = false;
              lblInfo.Text = string.Empty;
          }
      }

      private void btnsearch_Click(object sender, EventArgs e)
      {
          Dispose();
          frmPatientDetails ps = new frmPatientDetails();
          ps.ShowDialog();
      }

      private void chkFromAppointment_CheckedChanged(object sender, EventArgs e)
      {
          if (chkFromAppointment.Checked == true)
          {
              chkGeneralPat.Checked = false;
              chkStaffPat.Checked = false;
              chkIsStaffDependent.Checked = false;

              cboStaffType.Enabled = false;
              cboStaffType.SelectedValue = string.Empty;

              txtStaffId.Enabled = false;
              txtStaffId.Text = string.Empty;

              btnStaffDetails.Enabled = false;

              lblInfo.Enabled = false;
              lblInfo.Text = string.Empty;

              cbodependentId.Enabled = false;
              cbodependentId.SelectedValue = string.Empty;

              txtAppPat.Enabled = true;
              txtAppPat.Focus();     
          }
          if (chkFromAppointment.Checked == false)
          {
              txtAppPat.Enabled = false;
          }
      }  
       
      private void FormatGrid()
      {
              lvAppointed.CheckBoxes = false;
              lvAppointed.Columns.Add("Patient Name", 150, HorizontalAlignment.Left);//0
              lvAppointed.Columns.Add("Phone Number", 110, HorizontalAlignment.Left);//1
              lvAppointed.Columns.Add("Address", 100, HorizontalAlignment.Left);//2
              lvAppointed.Columns.Add("Email", 0, HorizontalAlignment.Left);//3
              lvAppointed.Columns.Add("AgeY", 0, HorizontalAlignment.Left);//4
              lvAppointed.Columns.Add("AgeM", 0, HorizontalAlignment.Left);//5
              lvAppointed.Columns.Add("AgeD", 0, HorizontalAlignment.Left);//6
              lvAppointed.Columns.Add("Appoint Time", 110, HorizontalAlignment.Left);//7
              lvAppointed.Columns.Add("Appoint Date", 100, HorizontalAlignment.Left);//8
              lvAppointed.Columns.Add("Appoint ID", 0, HorizontalAlignment.Left);//9
              
      }
      private void SearchPatientList(IEnumerable<OpdAppointment> patList, string searchString = "")
      {
              IEnumerable<OpdAppointment> query;
              if (!(searchString.Length > 0))
              {
                  query = patList;
              }
              else
              {
                  //query = (from inPats in patList                                                                             //          
                  //         where inPats.Patient.CellPhone.StartsWith(searchString, StringComparison.OrdinalIgnoreCase) ||     // this is not workable to search for a substring anywhere in a string 
                  //         inPats.Patient.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)                   //
                  //         select inPats);
                  query = (from inPats in patList
                           where inPats.Patient.CellPhone.ToLower().Contains(searchString.ToLower()) ||         // this is workable to search for a substring in anywhere in a string 
                           inPats.Patient.Name.ToLower().Contains(searchString.ToLower())
                           select inPats);
              }
              lvAppointed.Items.Clear();
              lvAppointed.Visible = true;
              lvAppointed.Top = chkFromAppointment.Top + chkFromAppointment.Height;
              lvAppointed.Left = chkFromAppointment.Left;

              foreach (OpdAppointment Pat in query)
              {
                  AH.DUtility.Age age = new AH.DUtility.Age();
                  age.Year = Pat.Patient.AgeBreakDown.Year;
                  age.Month = Pat.Patient.AgeBreakDown.Month;
                  age.Day = Pat.Patient.AgeBreakDown.Day;

                  //ListViewItem itm = new ListViewItem(Pat.Patient.Name);  //0
                  //itm.SubItems.Add(Pat.Patient.AgeBreakDown.Year.ToString());   //1
                  //itm.SubItems.Add(Pat.Patient.AgeBreakDown.Month.ToString());  //2
                  //itm.SubItems.Add(Pat.Patient.AgeBreakDown.Day.ToString());    //3
                  //itm.SubItems.Add(Pat.Patient.CellPhone.ToString());   //4
                  //itm.SubItems.Add(Pat.ApproxSTime.ToString());   //5
                  //itm.SubItems.Add(Pat.AppointDate.ToString());   //6
                  //itm.SubItems.Add(Pat.AppointID.ToString());     //7
                  //itm.SubItems.Add(Pat.Patient.Permanent_H_R_B.ToString()); //8
                  //itm.SubItems.Add(Pat.Patient.Email.ToString());   //9
                  ////itm.SubItems.Add(Pat.Patient.Country.ToString());   //10
                  //lvAppointed.Items.Add(itm);

                  ListViewItem itm = new ListViewItem(Pat.Patient.Name);  //0
                  itm.SubItems.Add(Pat.Patient.CellPhone.ToString());   //1
                  itm.SubItems.Add(Pat.Patient.Permanent_H_R_B.ToString()); //2
                  itm.SubItems.Add(Pat.Patient.Email.ToString());   //3
                  itm.SubItems.Add(Pat.Patient.AgeBreakDown.Year.ToString());   //4
                  itm.SubItems.Add(Pat.Patient.AgeBreakDown.Month.ToString());  //5
                  itm.SubItems.Add(Pat.Patient.AgeBreakDown.Day.ToString());    //6
                  itm.SubItems.Add(Pat.ApproxSTime.ToString());   //7
                  itm.SubItems.Add(Pat.AppointDate.ToString());   //8
                  itm.SubItems.Add(Pat.AppointID.ToString());     //9
                  
                  //itm.SubItems.Add(Pat.Patient.Country.ToString());   //10
                  lvAppointed.Items.Add(itm);
                }
      }
      private void lvAppointed_MouseDoubleClick(object sender, MouseEventArgs e)
      {
          if (lvAppointed.SelectedItems.Count > 0)
          {
              ListViewItem itm = lvAppointed.SelectedItems[0];
              txtPatientName.Text = itm.SubItems[0].Text;
              txtCellPhone.Text = itm.SubItems[1].Text;
              txtPresentHouseRoad.Text = itm.SubItems[2].Text;
              txtEmail.Text = itm.SubItems[3].Text;

              txtAgeY.Text = itm.SubItems[4].Text.ToString();
              txtAgeM.Text = itm.SubItems[5].Text.ToString();
              txtAgeD.Text = itm.SubItems[6].Text.ToString();
              DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
              txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
             
              txtAppointmentID.Text = itm.SubItems[9].Text;
              txtPermanentHouseRoadBlock.Text = itm.SubItems[2].Text;
              

          }
          lvAppointed.Visible = false;
          //this.cboNamePrefixes.Focus();
          this.txtPatientName.Focus();
      }

      private void lvAppointed_KeyDown(object sender, KeyEventArgs e)
      {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (lvAppointed.SelectedItems.Count > 0)
            //    {
            //        ListViewItem itm = lvAppointed.SelectedItems[0];
            //        txtPatientName.Text = itm.SubItems[0].Text;

            //        txtAgeY.Text = itm.SubItems[1].Text.ToString();
            //        txtAgeM.Text = itm.SubItems[2].Text.ToString();
            //        txtAgeD.Text = itm.SubItems[3].Text.ToString();
            //        DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
            //        txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");

            //        txtCellPhone.Text = itm.SubItems[4].Text;
            //        txtAppointmentID.Text = itm.SubItems[7].Text;
            //        txtPermanentHouseRoadBlock.Text = itm.SubItems[8].Text;
            //        txtPresentHouseRoad.Text = itm.SubItems[8].Text;
            //        txtEmail.Text = itm.SubItems[9].Text;

            //    }
            //    lvAppointed.Visible = false;
            //    //this.cboNamePrefixes.Focus();
            //    this.txtPatientName.Focus();
           // }
      }
      private void lvAppointed_SelectedIndexChanged(object sender, EventArgs e)
      {
          //if(lvAppointed.SelectedItems.Count> 0)
          //{
          //       ListViewItem itm = lvAppointed.SelectedItems[0];         
          //       txtPatientName.Text =itm.SubItems[0].Text;

          //       txtAgeY.Text = itm.SubItems[1].Text.ToString();
          //       txtAgeM.Text = itm.SubItems[2].Text.ToString();
          //       txtAgeD.Text = itm.SubItems[3].Text.ToString();
          //       DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
          //       txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");

          //       txtCellPhone.Text = itm.SubItems[4].Text;
          //       txtAppointmentID.Text = itm.SubItems[7].Text;
          //       txtPermanentHouseRoadBlock.Text = itm.SubItems[8].Text;
          //       txtPresentHouseRoad.Text = itm.SubItems[8].Text;
          //       txtEmail.Text = itm.SubItems[9].Text;
                 
          //}
          //lvAppointed.Visible = false;
          ////this.cboNamePrefixes.Focus();
          //this.txtPatientName.Focus();
      }

      private void txtAppPat_KeyUp(object sender, KeyEventArgs e)
      {
          lvAppointed.BringToFront();
          patList = ob.GetPatientListForHcn().ToList();
          SearchPatientList(patList, txtAppPat.Text);
          //lvAppointed.Focus();
      }
      private void txtAppPat_KeyPress(object sender, KeyPressEventArgs e)
      {
          //if (Convert.ToInt32(e.KeyChar) == 13)
          //{
          //    lvAppointed.BringToFront();
          //    patList = ob.GetPatientListForHcn().ToList();
          //    SearchPatientList(patList, txtAppPat.Text);
          //    lvAppointed.Focus();
          //}
      }
      private void txtAppPat_KeyDown(object sender, KeyEventArgs e)
      {
          if (e.KeyCode == Keys.Enter)
          {
              lvAppointed.BringToFront();
              patList = ob.GetPatientListForHcn().ToList();
              SearchPatientList(patList, txtAppPat.Text);
              //lvAppointed.Focus();
          }

         

          //if (e.KeyCode == Keys.Enter)
          //{
          //    lvAppointed.BringToFront();
          //    patList = ob.GetPatientListForHcn().ToList();
          //    SearchPatientList(patList, txtAppPat.Text);
          //}
          //else
          //{
          //    lvAppointed.BringToFront();
          //    patList = ob.GetPatientListForHcn().ToList();
          //    SearchPatientList(patList, txtAppPat.Text);
          //}
          //lvAppointed.Select();
      }      
      private void txtEmergencyContactPerson_Leave(object sender, EventArgs e)
      {
          if (txtEmergencyContactPerson.Text != "")
          {
              txtEmergencyContactPerson.Text = Utility.ProperCase(txtEmergencyContactPerson.Text);
              if (txtFatherName.Text == txtEmergencyContactPerson.Text)
              {
                  cboEmergencyPersonRelationship.SelectedIndex = 0;
              }
              if (txtMotherName.Text == txtEmergencyContactPerson.Text)
              {
                  cboEmergencyPersonRelationship.SelectedIndex = 1;
              }
              if(txtSpouseName.Text == txtEmergencyContactPerson.Text)
              {
                 if(cboGender.Text == "Male")
                 {
                     cboEmergencyPersonRelationship.SelectedIndex = 7;
                 }
                 if (cboGender.Text == "Female")
                 {
                     cboEmergencyPersonRelationship.SelectedIndex = 6;
                 }
              }
          }
      }

      private void txtDOB_Leave(object sender, EventArgs e)
      {
        /*  //if (txtDOB.Text != "  /  /") previous
          if (txtDOB.Text != "")
          {
              if (txtDOB.Text.Length == 10 && DateTime.Parse(txtDOB.Text) <= DateTime.Today)
              {
                  //............b.date calculation.....//
                  DateTime now = DateTime.Today;
                  DateTime birthDate = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", null);
                  //get the difference in years
                  TimeSpan ts = now.Date - birthDate.Date;
                  int ageY = (ts.Days / 365);
                  int daysleft1 = ts.Days - (ageY * 365);
                  int ageM = (daysleft1 / 30);
                  int daysleft2 = daysleft1 - (ageM * 30);
                  int ageD = daysleft2;

                  txtAgeY.Text = ageY.ToString();
                  txtAgeM.Text = ageM.ToString();
                  txtAgeD.Text = ageD.ToString();
              }
              else
              {
                  MessageBox.Show("invalid");
                  txtDOB.Text = string.Empty;
                  txtDOB.Select();
              }
              //if (txtDOB.Text.Length != 10)
              //{
              //    txtDOB.Select();
              //    return;
              //}
          }*/
          //if (txtDOB.Text != "")
          //{
          //   string str = txtDOB.Text;
          //   string iDay = str.Substring(0, 2);
          //   int iDayint = Convert.ToInt32(iDay);
          //   string iMon = str.Substring(2, 2);
          //   int iMonint = Convert.ToInt32(iMon);

          //   if(iDayint <=31 && iMonint <=12 )
          //    {

          //    }
          //}
      }
      private void txtDOB_TextChanged(object sender, EventArgs e)
      {
          this.txtDOB_Validated(sender, e);

          //if (txtDOB.Text != "" && txtDOB.Text.Length == 10 && DateTime.Parse(txtDOB.Text) <= DateTime.Today)
          //{
          //    AH.DUtility.Age age = Utility.CalculateAge(DateTime.Parse(txtDOB.Text));
          //    txtAgeY.Text = age.Year.ToString();
          //    txtAgeM.Text = age.Month.ToString();
          //    txtAgeD.Text = age.Day.ToString();
          //}
          //else
          //{
          //    txtAgeY.Text = string.Empty;
          //    txtAgeM.Text = string.Empty;
          //    txtAgeD.Text = string.Empty;
          //}

          //if (txtPatientName.Text != "")
          //{
          //    if (txtDOB.Text.Length == 10)
          //    {
          //        //............b.date calculation.....//
          //        DateTime now = DateTime.Today;
          //        DateTime birthDate = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", null);
          //        //get the difference in years
          //        TimeSpan ts = now.Date - birthDate.Date;
          //        int ageY = (ts.Days / 365);
          //        int daysleft1 = ts.Days - (ageY * 365);
          //        int ageM = (daysleft1 / 30);
          //        int daysleft2 = daysleft1 - (ageM * 30);
          //        int ageD = daysleft2;

          //        txtAgeY.Text = ageY.ToString();
          //        txtAgeM.Text = ageM.ToString();
          //        txtAgeD.Text = ageD.ToString();
          //    }
          //    if (txtDOB.Text.Length != 10)
          //    {
          //        txtDOB.Select();
          //        return;
          //    }
          //}
      }

      #region NextBack

      private void btnNext_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 1;
          txtPresentHouseRoad.Select();
      }

      private void btnNext2_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 2;
          txtNameBeng.Select();
      }

      private void btnNext3_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 3;
          
      }

      private void btnNext4_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 4;
      }
      private void btnBack_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 0;
         // cboNamePrefixes.Select();
          if (btnSave.Enabled == false && txtHCNNo.Text !="")
          {
              this.btnEdit.Focus();
          }
          else
          {
              this.btnSave.Focus();
          }
      }

      private void btnBack2_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 1;
          txtPresentHouseRoad.Select();
      }

      private void btnBack3_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 2;
          txtNameBeng.Select();
      } 

      private void btnBack4_Click(object sender, EventArgs e)
      {
          tabPage1.SelectedIndex = 3;
      }

      #endregion NextBack

      private void txtAgeM_Leave(object sender, EventArgs e)
      {
          if (txtAgeM.Text != "")
          {
              DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
              txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
          }
      }

      private void txtAgeD_Leave(object sender, EventArgs e)
      {
          if (txtAgeD.Text != "")
          {
              DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
              txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
          }
      }
      private void txtAgeD_TextChanged(object sender, EventArgs e)
      {
          if (txtAgeD.Text != "")
          {
              DUtility.Age age = PopulateAge(txtAgeY.Text, txtAgeM.Text, txtAgeD.Text);
              txtDOB.Text = Utility.DOBGenerator(DateTime.Now, age.Year, age.Month, age.Day, 0).ToString("dd/MM/yyyy");
          }
      } 

      private void pnlTop_Click(object sender, EventArgs e)
      {
          hideListView();
      }
      private void hideListView()
      {         
          lvAppointed.Visible = false;
      }

      private void cboPresentAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (cboPresentAddressDistrict.Text != "--Select--")
          {
              cboPresentAddressThana.Items.Clear();
              cboPresentAddressThana.Items.Add("--Select--");
              cboPresentAddressThana.Text = "--Select--";
              List<DistrictThana> oDists = oDistThanas.Where(x => x.DistName == cboPresentAddressDistrict.Text).ToList();
              foreach (DistrictThana oDist in oDists)
              {
                  cboPresentAddressThana.Items.Add(oDist.ThanaName);
              }
          }
      }

      private void cboPermanentAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (cboPermanentAddressDistrict.Text != "--Select--")
          {
              cboPermanentAddressThana.Items.Clear();
              cboPermanentAddressThana.Items.Add("--Select--");
              List<DistrictThana> oDists = oDistThanas.Where(x => x.DistName == cboPermanentAddressDistrict.Text).ToList();
              foreach (DistrictThana oDist in oDists)
              {
                  cboPermanentAddressThana.Items.Add(oDist.ThanaName.ToString());
              }
          }
      }

      private void cboEmergencyAddressDistrict_SelectedIndexChanged(object sender, EventArgs e)
      {
          if (cboEmergencyAddressDistrict.Text != "--Select--")
          {
              cboEmergencyAddressThana.Items.Clear();
              cboEmergencyAddressThana.Items.Add("--Select--");
              cboEmergencyAddressThana.Text = "--Select--";
              List<DistrictThana> oDists = oDistThanas.Where(x => x.DistName == cboEmergencyAddressDistrict.Text).ToList();
              foreach (DistrictThana oDist in oDists)
              {
                  cboEmergencyAddressThana.Items.Add(oDist.ThanaName);
              }
          }
      }

      private void txtPatientName_TextChanged(object sender, EventArgs e)
      {
          txtNameBeng.Text = txtPatientName.Text;
      }

      private void txtFatherName_TextChanged(object sender, EventArgs e)
      {
          txtFatherNameBeng.Text = txtFatherName.Text;
      }

      private void txtMotherName_TextChanged(object sender, EventArgs e)
      {
          txtMotherNameBeng.Text = txtMotherName.Text;
      }

      private void txtGuardianName_TextChanged(object sender, EventArgs e)
      {
          txtGuardianNameBengali.Text = txtGuardianName.Text;
      }

      private void txtSpouseName_TextChanged(object sender, EventArgs e)
      {
          if (txtSpouseName.Text != "")
          {
              txtSpouseNameBeng.Text = txtSpouseName.Text;
              cboMaritialStatus.SelectedIndex = 1;
          }
          else
          {
              cboMaritialStatus.SelectedIndex = 0;
          }
      }
      private void txtEmergencyContactPerson_TextChanged(object sender, EventArgs e)
      {
          txtContactPersonNameBengali.Text = txtEmergencyContactPerson.Text;
      }

      private void txtEmergencyAddress_TextChanged(object sender, EventArgs e)
      {
         txtEmergencyAddressBengali.Text = txtEmergencyAddress.Text;
      }

      private void chkSameAsPatPresAdd_CheckedChanged(object sender, EventArgs e)
      {
          if (chkSameAsPatPresAdd.Checked)
          {
              chkSameAsPatPerAdd.Checked = false;
              txtEmergencyAddress.Text = txtPresentHouseRoad.Text;
              cboEmergencyAddressDistrict.Text = cboPresentAddressDistrict.Text;
              cboEmergencyAddressThana.Text = cboPresentAddressThana.Text;
          }
      }

      private void chkSameAsPatPerAdd_CheckedChanged(object sender, EventArgs e)
      {
          if (chkSameAsPatPerAdd.Checked)
          {
              chkSameAsPatPresAdd.Checked = false;
              txtEmergencyAddress.Text = txtPermanentHouseRoadBlock.Text;
              cboEmergencyAddressDistrict.Text = cboPermanentAddressDistrict.Text;
              cboEmergencyAddressThana.Text = cboPermanentAddressThana.Text;
          }
      }

      private void txtPresentHouseRoad_TextChanged(object sender, EventArgs e)
      {
          txtPresentAddressBengali.Text = txtPresentHouseRoad.Text;
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
          //clearDirectory();
      }

      private void txtDOB_Validated(object sender, EventArgs e)
      {
          if (txtDOB.Text != "" &&  txtDOB.Text.Length == 10 && DateTime.Parse(txtDOB.Text) <= DateTime.Today)
          {
              AH.DUtility.Age age = Utility.CalculateAge(DateTime.Parse(txtDOB.Text));
              txtAgeY.Text = age.Year.ToString();
              txtAgeM.Text = age.Month.ToString();
              txtAgeD.Text = age.Day.ToString();
          }
          else
          {
              txtAgeY.Text = string.Empty;
              txtAgeM.Text = string.Empty;
              txtAgeD.Text = string.Empty;
          }
      }

      private void chkAllergy_CheckedChanged(object sender, EventArgs e)
      {
          if (chkAllergy.Checked == true)
          {
              txtAllergy.ReadOnly = true;
              chkDrugAllergy.Enabled = true;
              chkDustAllergy.Enabled = true;
              chkFoodAllergy.Enabled = true;

          }
          else
          {
              txtAllergy.ReadOnly = true;
              chkDrugAllergy.Enabled = false;
              chkDustAllergy.Enabled = false;
              chkFoodAllergy.Enabled = false;
              chkDrugAllergy.Checked = false;
              chkDustAllergy.Checked = false;
              chkFoodAllergy.Checked = false;
              txtAllergy.Text = "";
          }
      }

      private void AllergyTextGenerate()
      {
          if (chkFoodAllergy.Checked == false && chkDustAllergy.Checked == false && chkDrugAllergy.Checked == false)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = "";
          }
          if (chkFoodAllergy.Checked == false && chkDustAllergy.Checked == false && chkDrugAllergy.Checked == true)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkDrugAllergy.Text;
          }
          if (chkFoodAllergy.Checked == false && chkDustAllergy.Checked == true && chkDrugAllergy.Checked == false)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkDustAllergy.Text;
          }
          if (chkFoodAllergy.Checked == false && chkDustAllergy.Checked == true && chkDrugAllergy.Checked == true)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkDustAllergy.Text + "," + chkDrugAllergy.Text;
          }
          if (chkFoodAllergy.Checked == true && chkDustAllergy.Checked == false && chkDrugAllergy.Checked == false)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkFoodAllergy.Text;
          }
          if (chkFoodAllergy.Checked == true && chkDustAllergy.Checked == false && chkDrugAllergy.Checked == true)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkFoodAllergy.Text + "," + chkDrugAllergy.Text;
          }
          if (chkFoodAllergy.Checked == true && chkDustAllergy.Checked == true && chkDrugAllergy.Checked == false)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkFoodAllergy.Text + "," + chkDustAllergy.Text;
          }
          if (chkFoodAllergy.Checked == true && chkDustAllergy.Checked == true && chkDrugAllergy.Checked == true)
          {
              txtAllergy.Text = string.Empty;
              txtAllergy.Text = chkFoodAllergy.Text + "," + chkDustAllergy.Text + "," + chkDrugAllergy.Text;
          }
      }

      private void chkFoodAllergy_CheckedChanged(object sender, EventArgs e)
      {
          AllergyTextGenerate();
      }

      private void chkDustAllergy_CheckedChanged(object sender, EventArgs e)
      {
          AllergyTextGenerate();
      }

      private void chkDrugAllergy_CheckedChanged(object sender, EventArgs e)
      {
          AllergyTextGenerate();
      }

      private void txtCellPhone_Leave(object sender, EventArgs e)
      {
          if (txtCellPhone.Text != "" || txtCellPhone.Text != null)
          {
              string existingName = "";
              string existingHcn = "";
              List<Patient> searchMblNmbrOldNew = ob.VerifyMobileOldORNew(txtCellPhone.Text).ToList();

              if (txtHCNNo.Text == "")
              {
                  if (searchMblNmbrOldNew.Count > 0)
                  {
                      foreach (Patient cl in searchMblNmbrOldNew)
                      {
                          existingName = existingName + cl.Name + " | ";
                          existingHcn = existingHcn + cl.HCN + " | ";
                      }
                      DialogResult dr = MessageBox.Show("Name: " + existingName + "\r\n" +
                                                        "HCN: " + existingHcn + "\r\n" +
                                                        "Already have the same mobile number" + "\r\n" + "\r\n" +
                                                        "Do you want to continue ?", "Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2
                                                      );
                      if (dr == DialogResult.No)
                      {
                          txtCellPhone.Focus();
                      }
                  }
              }
              if (txtHCNNo.Text != "")
              {
                  if (searchMblNmbrOldNew.Count > 1)
                  {
                      foreach (Patient cl in searchMblNmbrOldNew)
                      {
                          existingName = existingName + cl.Name + " | ";
                          existingHcn = existingHcn + cl.HCN + " | ";
                      }
                      DialogResult dr = MessageBox.Show(
                                                        "Name: " + existingName + "\r\n" +
                                                        "HCN: " + existingHcn + "\r\n" +
                                                        "Already have the same mobile number" + "\r\n" + "\r\n" +
                                                        "Do you want to continue ?", "Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2
                                                      );
                      if (dr == DialogResult.No)
                      {
                          txtCellPhone.Focus();
                      }
                  }
              }
          }
      }

      private void btnToAddThana_Click(object sender, EventArgs e)
      {
          frmThanaSetup othana = new frmThanaSetup();
          othana.ShowDialog();
      }

      private void btnThanaRefresh_Click(object sender, EventArgs e)
      {
          cboPresentAddressDistrict.DisplayMember = "Value";
          cboPresentAddressDistrict.ValueMember = "Key";
          cboPresentAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

          cboPresentAddressDistrict_SelectedIndexChanged( sender,  e);

          cboPermanentAddressDistrict.DisplayMember = "Value";
          cboPermanentAddressDistrict.ValueMember = "Key";
          cboPermanentAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

          cboPermanentAddressDistrict_SelectedIndexChanged( sender,  e);

          cboEmergencyAddressDistrict.DisplayMember = "Value";
          cboEmergencyAddressDistrict.ValueMember = "Key";
          cboEmergencyAddressDistrict.DataSource = new BindingSource(ob.GetDistrictDict("D"), null);

          cboEmergencyAddressDistrict_SelectedIndexChanged(sender, e);

          oDistThanas = ob.GetDistrictAndThana().ToList();
      }

      
   }
}

