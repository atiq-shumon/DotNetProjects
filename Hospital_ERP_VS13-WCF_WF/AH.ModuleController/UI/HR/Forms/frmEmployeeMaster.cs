using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using AH.ModuleController.UI.HR.Reports.ParameterForms;
using System.Drawing.Imaging;
using System.Net.Mail;
using AH.ModuleController.ACMSSR;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeMaster : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        ACMSSR.ACMSWSClient AcmsSC = new ACMSSR.ACMSWSClient();
        public string EmpId { set; get; }

        #region GlobalDeclaration
        OpenFileDialog open1 = new OpenFileDialog();
        SaveFileDialog save1 = new SaveFileDialog();
        OpenFileDialog open2 = new OpenFileDialog();
        SaveFileDialog save2 = new SaveFileDialog();
        List<DistrictThana> oDistThanas;
        
        string appImagePath = "C:\\Images\\";
        string appSignaturePath = "C:\\Signatures\\";     
        string LocalSrcFile = "";
        string LocalSrcFile1 = "";
        #endregion
        public frmEmployeeMaster()
        {
            InitializeComponent();
        }

        #region DeleteImageDirectory
        private void DeleteImageDirectory(string Path)
        {
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
        private void DeleteImageFile(string Path)
        {
            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    System.GC.Collect();
                    GC.WaitForPendingFinalizers();
                    FileInfo oInfo = new FileInfo(Path);
                    oInfo.Delete();
                }
                catch (IOException ex)
                {
                    GC.Collect();
                    Thread.Sleep(500);
                }
            }
        }
        #endregion

        #region FormLoad
        private void frmEmployeeMaster_Load(object sender, EventArgs e)
        {
            DeleteImageDirectory(appImagePath);
            DeleteImageDirectory(appSignaturePath);

            cboSex.DisplayMember = "Value";
            cboSex.ValueMember = "Key";
            cboSex.DataSource = new BindingSource(Utility.GetSexes(), null);         

            cboEmployeeType.DisplayMember = "Value";
            cboEmployeeType.ValueMember = "Key";
            cboEmployeeType.DataSource = new BindingSource(Utility.GetEmployeeTypes(), null);

            cboReligion.DisplayMember = "Value";
            cboReligion.ValueMember = "Key";
            cboReligion.DataSource = new BindingSource(Utility.GetReligions(), null);

            cboBloodGrp.DisplayMember = "Value";
            cboBloodGrp.ValueMember = "Key";
            cboBloodGrp.DataSource = new BindingSource(Utility.GetBloodGroups(), null);

            cboMaritialStatus.DisplayMember = "Value";
            cboMaritialStatus.ValueMember = "Key";
            cboMaritialStatus.DataSource = new BindingSource(Utility.GetMaritalStatus(), null);

            cboCountry.DisplayMember = "Value";
            cboCountry.ValueMember = "Key";
            cboCountry.DataSource = new BindingSource(Utility.GetCountries(), null);

            cboDistrict.DisplayMember = "Value";
            cboDistrict.ValueMember = "Key";
            cboDistrict.DataSource = new BindingSource(hmsSC.GetDistrictDict("D"), null);

            cboPerDistrict.DisplayMember = "Value";
            cboPerDistrict.ValueMember = "Key";
            cboPerDistrict.DataSource = new BindingSource(hmsSC.GetDistrictDict("D"), null);

            cboBankName.DisplayMember = "Value";
            cboBankName.ValueMember = "Key";
            cboBankName.DataSource = new BindingSource(hmsSC.GetBankDict("D"), null);

            oDistThanas = hmsSC.GetDistrictAndThana().ToList();

            Refresh();

            FormatGridForDependent();
            FormatGridForTraining();
            FormatGridForPrevEx();
            FormatGridForEducation();
            FormatGridForMedInfo();
            FormatGridForNomineeInfo();
            FormatGridForPunishment();
            

        }
        #endregion
        private void Refresh()
        {
            if (EmpId != null)
            {
                txtEmpID.Text = EmpId;
                SearchInformation();
            }
            if (EmpId == null)
            {
                return;
            }
        }

        #region ShowImageAndSignature
        private void ShowImage(string SigPath, string DestinationPath)
        {   
            LocalSrcFile = "C:\\Images\\" + txtEmpID.Text + ".JPEG";
            PopulateImage(appImagePath, Utility.EmployeePhotoPath, LocalSrcFile, DestinationPath);
            pbImage.Image = new Bitmap(LocalSrcFile);
            pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;           
        }
        private void PopulateImage(string path, string utilityPath, string localSourceFile, string destinationPath)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            FileInfo imge = new FileInfo(localSourceFile);
            if (imge.Exists != true)
            {               
                File.Copy(destinationPath, localSourceFile, true);            
            }
        }

        private void ShowSignature(string SigPath, string DestinationPath1)
        {         
            LocalSrcFile1 = "C:\\Signatures\\" + txtEmpID.Text + ".JPEG";
            PopulateImage(appSignaturePath, Utility.EmployeePhotoPath, LocalSrcFile1, DestinationPath1);
            pbSignature.Image = new Bitmap(LocalSrcFile1);
            pbSignature.Image = Utility.ScaleImage(pbSignature.Image, 220, 257);
            pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion  
       
        private void CheckTab(string txt)
        {
            int i = 0;
            foreach (Control tab in tbEmpMaster.Controls)
            {
                TabPage tabPage = (TabPage)tab;
                foreach (Control control in tabPage.Controls)                
                {
                    
                    //if (control.Name == "txtDOB")
                    //{
                    //    MessageBox.Show(control.Name);
                        if (control.Name == txt.ToString())
                        {
                            tbEmpMaster.SelectTab(i);
                            MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tab.Focus();
                            control.Focus();
                            return;
                        }
                    //}
                }
                i = i + 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtFirstName", "txtFatherName", "txtFatherNameBeng", "txtMotherName", "txtNationality", "txtMotherNameBeng", "cboReligion", "cboSex", "cboBloodGrp", "cboMaritialStatus", "txtDOB", "txtHoViArRd", "txtHoViArRdBeng", "cboDistrict", "cboThana", "cboPrePostOffice", "cboCountry", "txtPerHoViArRd", "txtPerHoViArRdBeng", "cboPerDistrict", "cboPerThana", "cboParPostOffice", "cboEmployeeType", "txtReff1" };
            Control control = Utility.ReqFieldValidator(this, vf);           
             if (control != null)
               {
                   MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   if (control.Name == "txtFirstName" || control.Name == "txtFatherName" || control.Name == "txtFatherNameBeng" || control.Name == "txtMotherName" ||
                      control.Name == "txtMotherNameBeng" || control.Name == "txtNationality" || control.Name == "cboReligion" || control.Name == "cboSex" ||
                      control.Name == "cboBloodGrp" || control.Name == "cboMaritialStatus" || control.Name == "txtDOB")
                     {
                       tbEmpMaster.SelectedIndex = 0;
                       control.Focus();
                       return;
                     }

                   if (control.Name == "txtHoViArRd" || control.Name == "txtPostCode" || control.Name == "cboDistrict" || control.Name == "cboThana" ||
                       control.Name == "cboCountry" || control.Name == "txtPerHoViArRd" || control.Name == "txtPerPostCode" ||
                       control.Name == "txtPerThana" || control.Name == "cboPerDistrict")
                     {
                       tbEmpMaster.SelectedIndex = 1;
                       control.Focus();
                       return;
                     }

                   if (control.Name == "txtDOJ" || control.Name == "txtReff1")
                   {
                       tbEmpMaster.SelectedIndex = 2;
                       control.Focus();
                       return;
                   }                          
               }

             if (txtDOB.Text == "  /  /" || txtDOJ.Text == "  /  /")
             {
                 MessageBox.Show("Date cannot be empty");
                 return;
             }
            if(cboThana.Text=="--Select--")
            {
                MessageBox.Show("Please Provide Valid Present Thana");
                return;
            }
            if (cboPerThana.Text == "--Select--")
            {
                MessageBox.Show("Please Provide Valid Parmanent Thana");
                return;
            }                     
            try
            {
                string strEmpID = "";
                AH.ModuleController.HRSR.EmployeeMaster emaster = this.PopulateEmployeeMaster();
                User oUserBO = new User();
                if (txtPersonalEmail.Text != "")
                {
                    if (Utility.IsValidEmail(txtPersonalEmail.Text) == false)
                    {
                        MessageBox.Show("Please Provide a valid Email ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPersonalEmail.Focus();
                        return;
                    }
                }
                if (txtEmailId.Text != "")
                {
                    if (Utility.IsValidEmail(txtEmailId.Text) == false)
                    {
                        MessageBox.Show("Please Provide a valid Email ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmailId.Focus();
                        return;
                    }
                }
                frmEmpJobInfo oEmp = new frmEmpJobInfo(emaster);
                oEmp.ShowDialog();
                List<AH.ModuleController.HRSR.EmployeeMaster> objEmp = hmsSC.GetEmployeeID().ToList();
                foreach (AH.ModuleController.HRSR.EmployeeMaster emp in objEmp)
                {
                    strEmpID = emp.EmpId;
                }
                SaveImage(strEmpID);
                SaveSignature(strEmpID);

                //****************Create General User********************//
                oUserBO = AcmsSC.SaveUser(PopulateUserCreation(strEmpID));
                //**************************END*************************//

                MessageBox.Show("Thank you for your Cooperation", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDOB.Text = null;
                txtDOC.Text = null;
                txtDOJ.Text = null;
                txtDOR.Text = null;

                txtEmpID.Text = strEmpID;
                SearchInformation();      
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
        private User PopulateUserCreation(string EmpID)
        {
            User oUserBO = new User();
            UserGroup oUserGroup = new UserGroup();
            oUserBO.UserGroup = oUserGroup;
            SecurityQuestion oSecurityQuestion = new SecurityQuestion();
            AH.ModuleController.ACMSSR.EntryParameter oEntryParameter = new ACMSSR.EntryParameter();
            oUserBO.SecurityQuestion = oSecurityQuestion;
            oUserBO.EmpID = EmpID;
            oUserBO.UserGroup.GroupID = "1";
            oUserBO.ValidUpto = DateTime.Today.ToString("dd/MM/yyyy");
            oUserBO.UserPassw = Utility.Encrypt("123", EmpID);//txtPassword.Text;
            oUserBO.PinCode = "123";//CalculateMD5Hash(txtPinCode.Text); 
            oUserBO.Email = "";
            oUserBO.SecurityQuestion.QID = "01";
            oUserBO.SecurityQuestion.Answer = "Cat";
            oUserBO.Remarks = "Active";
            oUserBO.NickName = "Nick Name";


            Module oModule = new Module();
            oModule.ModuleID = "ADMIS";
            oUserBO.Module = oModule;           
            oEntryParameter.Active = "1";
           
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            oUserBO.EntryParameter = oEntryParameter;
            return oUserBO;
        }

        #region SaveImageAndSignature
        private void SaveImage(string EmployeeIDNumber)
        {
            string filePathImage = save1.FileName + Utility.EmployeePhotoPath + EmployeeIDNumber + ".JPEG";
            Stream buffer;
            if (open1.FileName == "")
            {
                return;
            }
            StreamReader srImage = new StreamReader(open1.FileName);

            buffer = srImage.BaseStream;
            Bitmap bmImage = new Bitmap(buffer);

            if (File.Exists(filePathImage))
            {
                DialogResult msg = MessageBox.Show("Same file name already exists,Do u want to update?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msg == DialogResult.Yes)
                {
                    File.Delete(filePathImage);
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    oImage.Save(filePathImage);
                }
            }
            else
            {
                File.Delete(filePathImage);
                Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                oImage.Save(filePathImage);              
            }

        }
        private void SaveSignature(string EmployeeIDNumber)
        {
            string filePathSignature = save2.FileName + Utility.EmployeeSignaturePath + EmployeeIDNumber + ".JPEG";
            Stream buffer;
            if (open2.FileName == "")
            {
                return;
            }
            StreamReader srSignature = new StreamReader(open2.FileName);
            buffer = srSignature.BaseStream;
            Bitmap bmSignature = new Bitmap(buffer);


            if (File.Exists(filePathSignature))
            {
                DialogResult msg = MessageBox.Show("Same file name already exists,Do u want to update?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msg == DialogResult.Yes)
                {
                    File.Delete(filePathSignature);
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(200, 100));
                    pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
                    oSignature.Save(filePathSignature);
                }
            }
            else
            {
                File.Delete(filePathSignature);
                Bitmap oSignature = new Bitmap(bmSignature, new Size(200, 100));
                pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
                oSignature.Save(filePathSignature);
            }
        }
        #endregion

        #region PopulateEmployeeMaster
        private AH.ModuleController.HRSR.EmployeeMaster PopulateEmployeeMaster()
        {
            AH.ModuleController.HRSR.EmployeeMaster oEmas = new AH.ModuleController.HRSR.EmployeeMaster();
            oEmas.EmpId = txtEmpID.Text;
            oEmas.FirstName = txtFirstName.Text;
            oEmas.MiddleName = txtMiddleName.Text;
            oEmas.LastName = txtLastName.Text;
            oEmas.EmpNameBeng = txtEmpNameBeng.Text;
            oEmas.NickName = txtNickName.Text;
            oEmas.FathersName = txtFatherName.Text;
            oEmas.FathersNameBeng = txtFatherNameBeng.Text;
            oEmas.MothersName = txtMotherName.Text;
            oEmas.MothersNameBeng = txtMotherNameBeng.Text;
            oEmas.SpouseName = txtSpouseName.Text;
            oEmas.SpouseNameBeng = txtSpouseNameBeng.Text;
            oEmas.Religion = cboReligion.SelectedValue.ToString();
            oEmas.Sex = cboSex.SelectedValue.ToString();
            oEmas.BloodGroup = cboBloodGrp.SelectedValue.ToString();
            oEmas.MaritalStatus = cboMaritialStatus.SelectedValue.ToString();
            oEmas.Nationality = txtNationality.Text;            
            if (pbImage.Image == null)
            {
                if (open1.SafeFileName == "")
                {
                    oEmas.PhotoPath = "";
                }
                else
                {
                    oEmas.PhotoPath = "image";
                }
            }
            if (pbImage.Image != null)
            {
                if (open1.SafeFileName == "")
                {
                    oEmas.PhotoPath = "";
                }
                else
                {
                    oEmas.PhotoPath = "image";
                }
            }

            if (pbSignature.Image== null)
            {
                if (open2.SafeFileName == "")
                {
                    oEmas.SignaturePath = "";
                }
                else
                {
                    oEmas.SignaturePath = "signature";
                }
            }
            if (pbSignature.Image != null)
            {
                if (open2.SafeFileName == "")
                {
                    oEmas.SignaturePath = "";
                }
                else
                {
                    oEmas.SignaturePath = "signature";
                }
            }
            if (txtDOB.Text != "  /  /")
            {
                oEmas.DOB = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            if (txtDOJ.Text != "  /  /")
            {
                oEmas.DOJ = DateTime.ParseExact(txtDOJ.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmas.DOJ = null;
            }
            if (txtDOC.Text != "  /  /")
            {
                oEmas.DOC = DateTime.ParseExact(txtDOC.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmas.DOC = null;
            }
            if (txtDOR.Text != "  /  /")
            {
                oEmas.DOR = DateTime.ParseExact(txtDOR.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmas.DOR = null;
            }
            oEmas.BankID = cboBankName.SelectedValue.ToString();
            oEmas.BankAccNo = txtBnkAccNo.Text;
            oEmas.PfAccNo = txtPfAccNo.Text;
            oEmas.TIN = txtTIN.Text;
            oEmas.Passport = txtPassport.Text;
            oEmas.InsuranceNo = txtInsuranceNo.Text;
            oEmas.AttnCardNumber = txtAttnCardNumber.Text;
            oEmas.IntercomNumber = txtIntercomNumber.Text;
            oEmas.Email = txtEmailId.Text;
            oEmas.PersonalEmail = txtPersonalEmail.Text;
            oEmas.HomePhone = txtHomePhone.Text;
            oEmas.CellPhone = txtCellPhone.Text;
            oEmas.NID = txtNationalId.Text;
            oEmas.Present_H_R_B = txtHoViArRd.Text;
            oEmas.Present_H_R_B_Beng = txtHoViArRdBeng.Text;            
            oEmas.PresentDistrict = cboDistrict.Text;
            oEmas.PresentThana = cboThana.Text;
            oEmas.Present_Post = cboPrePostOffice.SelectedValue.ToString(); 
            oEmas.Country = cboCountry.SelectedValue.ToString();
            oEmas.Permanent_H_R_B = txtPerHoViArRd.Text;
            oEmas.PermanentDistrict = cboPerDistrict.Text;
            oEmas.PermanentThana = cboPerThana.Text;
            oEmas.Permanent_Post = cboParPostOffice.SelectedValue.ToString(); 
            if (txtSalFlgChgDate.Text != "  /  /")
            {
                oEmas.SalFlagChangeDt = DateTime.ParseExact(txtSalFlgChgDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            }
            else
            {
                oEmas.SalFlagChangeDt = null;
            }
            oEmas.Reff1 = txtReff1.Text;
            oEmas.Reff2 = txtReff2.Text;
            oEmas.FringeBenefitGrp = "0";

            if (cbConfirmFlag.Checked == true)
            {
                oEmas.ConfirmFlag = "1";
            }
            if (cbConfirmFlag.Checked == false)
            {
                oEmas.ConfirmFlag = "0";
            }
            if (cbGratMember.Checked == true)
            {
                oEmas.GratuityMember = "1";
            }
            if (cbGratMember.Checked == false)
            {
                oEmas.GratuityMember = "0";
            }
            if (cbPfMember.Checked == true)
            {
                oEmas.PfMember = "1";
            }
            if (cbPfMember.Checked == false)
            {
                oEmas.PfMember = "0";
            }
            if (cbSalFlag.Checked == true)
            {
                oEmas.SalFlag = "1";
            }
            if (cbSalFlag.Checked == false)
            {
                oEmas.SalFlag = "0";
            }
            oEmas.EmployeeType = cboEmployeeType.SelectedValue.ToString();
            AH.ModuleController.HRSR.EntryParameter ep = new AH.ModuleController.HRSR.EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmas.EntryParameter = ep;

            return oEmas;
        }

        #endregion

        #region EditImageAndSignature
        private void EditImage()
        {
            string ImagePath = save1.FileName + Utility.EmployeePhotoPath + txtEmpID.Text + ".JPEG";
            Stream buffer1;
            if (open1.SafeFileName == "")
            {
                return;
            }
            if (open1.SafeFileName != "")
             {
                StreamReader srImage = new StreamReader(open1.FileName);
                buffer1 = srImage.BaseStream;
                Bitmap bmImage = new Bitmap(buffer1);

                string SourcePath = open1.FileName;
                string DestinationPath = Utility.EmployeePhotoPath;
                FileInfo img = new FileInfo(DestinationPath + txtEmpID.Text + ".JPEG");

                if (img.Exists)
                {
                    img.Delete();
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + txtEmpID.Text + ".JPEG");
                }
                if (!img.Exists)
                {
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + txtEmpID.Text + ".JPEG");                  
                }
            }
        }
        private void EditSignature()
        {
            string SignaturePath = save2.FileName + Utility.EmployeeSignaturePath + txtEmpID.Text + ".JPEG";
            Stream buffer2;
            if (open2.SafeFileName == "")
            {
                return;               
            }
            if (open2.SafeFileName != "")
            {
                StreamReader srSignature = new StreamReader(open2.FileName);
                buffer2 = srSignature.BaseStream;
                Bitmap bmSignature = new Bitmap(buffer2);
                string SourcePath = open2.FileName;
                string DestinationPath = Utility.EmployeeSignaturePath;
                FileInfo Sig = new FileInfo(DestinationPath + txtEmpID.Text + ".JPEG");

                if (Sig.Exists)
                {
                    Sig.Delete();
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                    oSignature.Save(DestinationPath + txtEmpID.Text + ".JPEG");                  
                }
                if (!Sig.Exists)
                {
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                    oSignature.Save(DestinationPath + txtEmpID.Text + ".JPEG");                
                }
            }
        }
        private void EditImageForPatient()
        {
            string ImagePath = save1.FileName + Utility.PatientPhotoPath + lblHCN.Text + ".JPEG";
            Stream buffer1;  
            if(open1.SafeFileName =="")
            {
                return;
            }
            if (open1.SafeFileName != "")
            {
                StreamReader srImage = new StreamReader(open1.FileName);
                buffer1 = srImage.BaseStream;
                Bitmap bmImage = new Bitmap(buffer1);

                string SourcePath = open1.FileName;
                string DestinationPath = Utility.PatientPhotoPath;
                FileInfo img = new FileInfo(DestinationPath + lblHCN.Text + ".JPEG");

                if (img.Exists)
                {
                    img.Delete();
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + lblHCN.Text + ".JPEG");
                }
                if (!img.Exists)
                {
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + lblHCN.Text + ".JPEG");
                }
            }
        }

        #endregion
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtFirstName", "txtFatherName", "txtFatherNameBeng", "txtMotherName", "txtNationality", "txtMotherNameBeng", "cboReligion", "cboSex", "cboBloodGrp", "cboMaritialStatus", "txtDOB", "txtHoViArRd", "txtHoViArRdBeng", "cboDistrict", "cboThana", "cboPrePostOffice", "cboCountry", "txtPerHoViArRd", "txtPerHoViArRdBeng", "cboPerDistrict", "cboPerThana", "cboParPostOffice", "cboEmployeeType", "txtReff1" };
            Control control = Utility.ReqFieldValidator(this, vf); 
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtDOB.Text == "  /  /")
            {
                MessageBox.Show("Date of Birth cannot be empty");
                return;
            }
            if(txtDOJ.Text == "  /  /")
            {
                MessageBox.Show("Date of Join cannot be empty");
                return;
            }
            if (cboThana.Text == "--Select--")
            {
                MessageBox.Show("Please Provide Valid Present Thana");
                return;
            }
            if (cboPerThana.Text == "--Select--")
            {
                MessageBox.Show("Please Provide Valid Parmanent Thana");
                return;
            }
            try
            {

                AH.ModuleController.HRSR.EmployeeMaster oMas = this.PopulateEmployeeMaster();
                if (txtPersonalEmail.Text != "")
                {
                    if(Utility.IsValidEmail(txtPersonalEmail.Text)==false)
                    {
                        MessageBox.Show("Please Provide a valid Email ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (txtEmailId.Text != "")
                {
                    if (Utility.IsValidEmail(txtEmailId.Text) == false)
                    {
                        MessageBox.Show("Please Provide a valid Email ID", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmailId.Focus();
                        return;
                    }
                }
                DialogResult msg = MessageBox.Show("Do you want to update the information?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    string i = hmsSC.UpdateEmployeeMaster(oMas);
                    
                    if (i == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmpID.Select();
                    }
                    else if (i != "0")
                    {
                        EditImage();
                        EditSignature();
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblHCN.Text = i.ToString();
                        EditImageForPatient();
                        btnSearch_Click(sender, e);
                        DeleteImageFile(LocalSrcFile);
                        DeleteImageFile(LocalSrcFile1);                       
                    }
                }
                else
                {
                    return;
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


        #region SearchInformation
        private void SearchInformation()
        {
            List<string> vf = new List<string>() { "txtEmpID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                AH.ModuleController.HRSR.EmployeeMaster oEmpMast = new AH.ModuleController.HRSR.EmployeeMaster();
                oEmpMast = hmsSC.GetEmpMaster(txtEmpID.Text);
                if (txtEmpID.Text == oEmpMast.EmpId)
                {
                    oEmpMast = hmsSC.GetEmployeeMaster(txtEmpID.Text);
                    txtFirstName.Text = oEmpMast.FirstName;
                    txtMiddleName.Text = oEmpMast.MiddleName;
                    txtLastName.Text = oEmpMast.LastName;
                    txtNickName.Text = oEmpMast.NickName;
                    txtEmpNameBeng.Text = oEmpMast.EmpNameBeng;
                    txtFatherName.Text = oEmpMast.FathersName;
                    txtFatherNameBeng.Text = oEmpMast.FathersNameBeng;
                    txtMotherName.Text = oEmpMast.MothersName;
                    txtMotherNameBeng.Text = oEmpMast.MothersNameBeng;
                    txtSpouseName.Text = oEmpMast.SpouseName;
                    txtSpouseNameBeng.Text = oEmpMast.SpouseNameBeng;
                    txtNationality.Text = oEmpMast.Nationality;
                    txtEmpCls.Text = oEmpMast.EmpClass;
                    txtDOB.Text = oEmpMast.DOB.ToString("dd/MM/yyyy");
                    txtDOJ.Text = oEmpMast.DOJ.ToString();
                    txtDOC.Text = oEmpMast.DOC.ToString();
                    txtDOR.Text = oEmpMast.DOR.ToString();
                    txtJobType.Text = oEmpMast.JobType;
                    cboSex.SelectedValue = oEmpMast.Sex.Trim().ToString();
                    cboReligion.SelectedValue = oEmpMast.Religion.Trim().ToString();
                    cboBloodGrp.Text = oEmpMast.BloodGroup.Trim().ToString();
                    cboMaritialStatus.Text = oEmpMast.MaritalStatus;
                    txtCurrentJobStatus.Text = oEmpMast.CurrentJobStatus;
                    txtBnkAccNo.Text = oEmpMast.BankAccNo;
                    txtPfAccNo.Text = oEmpMast.PfAccNo;
                    txtTIN.Text = oEmpMast.TIN;
                    txtPassport.Text = oEmpMast.Passport;
                    txtInsuranceNo.Text = oEmpMast.InsuranceNo;
                    txtAttnCardNumber.Text = oEmpMast.AttnCardNumber;
                    txtIntercomNumber.Text = oEmpMast.IntercomNumber;
                    txtEmailId.Text = oEmpMast.Email;
                    txtPersonalEmail.Text = oEmpMast.PersonalEmail;
                    txtHomePhone.Text = oEmpMast.HomePhone;
                    txtCellPhone.Text = oEmpMast.CellPhone;
                    txtNationalId.Text = oEmpMast.NID;
                    txtHoViArRd.Text = oEmpMast.Present_H_R_B;
                    txtHoViArRdBeng.Text = oEmpMast.Present_H_R_B_Beng;                                     
                    cboDistrict.Text = oEmpMast.PresentDistrict;
                    cboThana.Text = oEmpMast.PresentThana;
                    cboPrePostOffice.SelectedValue = oEmpMast.Present_Post.ToString();   
                    cboCountry.Text = oEmpMast.Country;
                    txtPerHoViArRd.Text = oEmpMast.Permanent_H_R_B;
                    txtPerHoViArRdBeng.Text = oEmpMast.Permanent_H_R_B;
                    cboPerDistrict.Text = oEmpMast.PermanentDistrict;
                    cboPerThana.Text = oEmpMast.PermanentThana;
                    cboParPostOffice.SelectedValue = oEmpMast.Permanent_Post; 
                    txtSalFlgChgDate.Text = oEmpMast.SalFlagChangeDt.ToString();
                    txtReff1.Text = oEmpMast.Reff1.ToString();
                    txtReff2.Text = oEmpMast.Reff2.ToString();
                    //ShowImage(LocalSrcFile, Utility.EmployeePhotoPath + txtEmpID.Text + ".JPEG");
                    //ShowSignature(LocalSrcFile1, Utility.EmployeeSignaturePath + txtEmpID.Text + ".JPEG");                   
                    ShowImage(LocalSrcFile,Utility.EmployeePhotoPath + oEmpMast.PhotoPath + ".JPEG");
                    ShowSignature(LocalSrcFile1,Utility.EmployeeSignaturePath + oEmpMast.SignaturePath + ".JPEG");
                    txtSalGrd.Text = oEmpMast.SalGradeID;
                    txtSalScl.Text = oEmpMast.SalScaleID;
                    txtConAmount.Text = Convert.ToInt64(oEmpMast.ConsolidatedAmount).ToString();
                    txtDeptGrp.Text = oEmpMast.Department.DepartmentGroup.DepartmentGroupID.ToString();
                    txtDept.Text = oEmpMast.Department.DepartmentID;
                    txtUnit.Text = oEmpMast.DepartmentUnit.UnitId;
                    txtDesigGrp.Text = oEmpMast.Designation.DesignationGroup.GroupId;
                    txtDesig.Text = oEmpMast.Designation.DesignationId;
                    if (Convert.ToInt16(oEmpMast.ConfirmFlag) == 1)
                    {
                        cbConfirmFlag.Checked = true;
                    }
                    else
                        cbConfirmFlag.Checked = false;

                    if (Convert.ToInt16(oEmpMast.GratuityMember) == 1)
                    {
                        cbGratMember.Checked = true;
                    }
                    else
                        cbGratMember.Checked = false;

                    if (Convert.ToInt16(oEmpMast.PfMember) == 1)
                    {
                        cbPfMember.Checked = true;
                    }
                    else
                        cbPfMember.Checked = false;

                    if (Convert.ToInt16(oEmpMast.SalFlag) == 1)
                    {
                        cbSalFlag.Checked = true;
                    }
                    else
                        cbSalFlag.Checked = false;

                    cboEmployeeType.SelectedValue = oEmpMast.EmployeeType.ToString();
                    txtRecruitmentType.Text = oEmpMast.RecruitmentType.ToString();
                    cboBankName.SelectedValue = oEmpMast.BankID.ToString();

                    LoadListViewForDependent(txtEmpID.Text.ToString());
                    LoadListViewForTraining(txtEmpID.Text.ToString());
                    LoadListViewForPrevEx(txtEmpID.Text.ToString());
                    LoadListViewForEducation(txtEmpID.Text.ToString());
                    LoadListViewForMedInfo(txtEmpID.Text.ToString());
                    LoadListViewForNomineeInfo(txtEmpID.Text.ToString());
                    LoadListViewForPunishment(txtEmpID.Text.ToString());

                    btnSave.Enabled = false;
                    lnkJobInfo.Enabled = true;
                    lnkAcademicInfo.Enabled = true;
                    lnkTrainingInfo.Enabled = true;
                    lnkPreviousExperience.Enabled = true;
                    lnkDependentInfo.Enabled = true;
                    lnkMedicalInfo.Enabled = true;
                    lnkPunishment.Enabled = true;
                    lnkNomineeInfo.Enabled = true;
                    chkAddress.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNew.PerformClick();
                    txtEmpID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        #endregion
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInformation();
        }
        #region UploadImageAndSignature
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            open1.Multiselect = true;
            DialogResult result1 = open1.ShowDialog();          
            open1.Filter = "allfiles|*";
            string ext1 = System.IO.Path.GetExtension(open1.FileName);
            if (result1 == DialogResult.OK)
            {              
                    if (pbImage.Image == null || pbImage.Image != null)
                    {
                        pbImage.Image = new Bitmap(open1.OpenFile());
                        pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
                    }               
            }              
                if (result1 == DialogResult.Cancel)
                {
                    return;
                }
        }

        private void btnUploadSignature_Click(object sender, EventArgs e)
        {
            open2.Multiselect = true;
            DialogResult result2 = open2.ShowDialog();
            open2.Filter = "allfiles|*";
            string ext2 = System.IO.Path.GetExtension(open2.FileName);
            if (result2 == DialogResult.OK)
            {                 
                    if (pbSignature.Image == null || pbSignature.Image != null)
                    {
                        pbSignature.Image = new Bitmap(open2.OpenFile());
                        pbSignature.Image = Utility.ScaleImage(pbSignature.Image, 220, 257);
                    }              
            }         
                if (result2 == DialogResult.Cancel)
                {
                    return;
                }         
        }

        #endregion
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmEmployeeReportManager oEmpRepMan = new frmEmployeeReportManager();
            oEmpRepMan.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region ProperCase
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName.Text = Utility.ProperCase(txtFirstName.Text);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            txtMiddleName.Text = Utility.ProperCase(txtMiddleName.Text);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = Utility.ProperCase(txtLastName.Text);
        }

        private void txtEmpNameBeng_Leave(object sender, EventArgs e)
        {
            txtEmpNameBeng.Text = Utility.ProperCase(txtEmpNameBeng.Text);
        }

        private void txtNickName_Leave(object sender, EventArgs e)
        {
            txtNickName.Text = Utility.ProperCase(txtNickName.Text);
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            txtFatherName.Text = Utility.ProperCase(txtFatherName.Text);
        }

        private void txtFatherNameBeng_Leave(object sender, EventArgs e)
        {
            txtFatherNameBeng.Text = Utility.ProperCase(txtFatherNameBeng.Text);
        }

        private void txtMotherName_Leave(object sender, EventArgs e)
        {
            txtMotherName.Text = Utility.ProperCase(txtMotherName.Text);
        }

        private void txtMotherNameBeng_Leave(object sender, EventArgs e)
        {
            txtMotherNameBeng.Text = Utility.ProperCase(txtMotherNameBeng.Text);
        }

        private void txtSpouseName_Leave(object sender, EventArgs e)
        {
            txtSpouseName.Text = Utility.ProperCase(txtSpouseName.Text);
        }

        private void txtSpouseNameBeng_Leave(object sender, EventArgs e)
        {
            txtSpouseNameBeng.Text = Utility.ProperCase(txtSpouseNameBeng.Text);
        }
        #endregion

        private void txtDOC_Leave(object sender, EventArgs e)
        {
            if (txtDOC.Text != "  /  /")
            {
                cbConfirmFlag.Checked = true;
            }
            if (txtDOC.Text == "  /  /")
            {
                cbConfirmFlag.Checked = false;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Focus();
            btnSave.Enabled = true;
            chkAddress.Enabled = true;
            lnkJobInfo.Enabled = false;
            lnkAcademicInfo.Enabled = false;
            lnkDependentInfo.Enabled = false;
            lnkPreviousExperience.Enabled = false;
            lnkTrainingInfo.Enabled = false;
            lnkMedicalInfo.Enabled = false;
            lnkPunishment.Enabled = false;
            lnkNomineeInfo.Enabled = false;
            pbImage.Image.Dispose();
            pbImage.Image = null;
            pbImage.Invalidate();          
            pbSignature.Image.Dispose();
            pbSignature.Image = null;
            pbSignature.Invalidate();
            Application.DoEvents();
            DeleteImageFile(LocalSrcFile);
            DeleteImageFile(LocalSrcFile1);      
            txtDOB.Text = null;
            txtDOC.Text = null;
            txtDOJ.Text = null;
            txtDOR.Text = null;
            txtSalFlgChgDate.Text = null;
            lvAcademicInfo.Items.Clear();
            lvDependent.Items.Clear();
            lvPreviousExperience.Items.Clear();
            lvEmployeeMedicalInformation.Items.Clear();
            lvTraining.Items.Clear();
            lvPunishementType.Items.Clear();
            lvNomineeInfo.Items.Clear();
        }
        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo oEmpInfo = new frmEmployeeInfo();
            oEmpInfo.ShowDialog();
        }
        private void txtHoViArRdBeng_TextChanged(object sender, EventArgs e)
        {
            txtHoViArRdBeng.Text = Utility.ProperCase(txtHoViArRdBeng.Text);
        }
        #region EmployeeDependent
        private void FormatGridForDependent()
        {
            lvDependent.CheckBoxes = false;
            lvDependent.Columns.Add("DependentID", 150, HorizontalAlignment.Left);
            lvDependent.Columns.Add("Serial", 50, HorizontalAlignment.Left);
            lvDependent.Columns.Add("DependentName", 220, HorizontalAlignment.Left);
            lvDependent.Columns.Add("DependentName(Bangla)", 220, HorizontalAlignment.Left);
            lvDependent.Columns.Add("Relation", 150, HorizontalAlignment.Left);
            lvDependent.Columns.Add("DOB", 150, HorizontalAlignment.Left);
        }
        private void LoadListViewForDependent(string oEmp)
        {
            lvDependent.Items.Clear();

            List<EmployeeDependent> oEmpDeps = hmsSC.GetEmpDependent(txtEmpID.Text).ToList();

            foreach (EmployeeDependent oEmpDep in oEmpDeps)
            {
                ListViewItem itm = new ListViewItem(oEmpDep.DependID.ToString());
                itm.SubItems.Add(oEmpDep.DependSerial.ToString());
                itm.SubItems.Add(oEmpDep.DependName.ToString());
                itm.SubItems.Add(oEmpDep.DependNameBeng.ToString());
                itm.SubItems.Add(oEmpDep.RelationID.ToString());
                itm.SubItems.Add(oEmpDep.DOB.ToString());
                lvDependent.Items.Add(itm);
            }

        }
        #endregion

        #region EmployeeTraining
        private void FormatGridForTraining()
        {
            lvTraining.CheckBoxes = false;
            lvTraining.Columns.Add("Serial", 100, HorizontalAlignment.Left);
            lvTraining.Columns.Add("TrainingTitle", 200, HorizontalAlignment.Left);//2
            lvTraining.Columns.Add("OrganizationName", 200, HorizontalAlignment.Left);//4
            lvTraining.Columns.Add("Subject", 200, HorizontalAlignment.Left);//6
            lvTraining.Columns.Add("StartDate", 200, HorizontalAlignment.Left);//7
            lvTraining.Columns.Add("EndDate", 200, HorizontalAlignment.Left);//8
            lvTraining.Columns.Add("Grade", 200, HorizontalAlignment.Left);//9
            lvTraining.Columns.Add("Remarks", 200, HorizontalAlignment.Left);//10
        }

        private void LoadListViewForTraining(string emp)
        {
            lvTraining.Items.Clear();

            List<EmployeeTraining> oEmpTraning = new List<EmployeeTraining>();

            oEmpTraning = hmsSC.GetEmpTraining(txtEmpID.Text).ToList();

            foreach (EmployeeTraining et in oEmpTraning)
            {
                ListViewItem itm = new ListViewItem(et.Serial.ToString());//0              
                itm.SubItems.Add(et.TrainingTitle.ToString());//2
                itm.SubItems.Add(et.OrganizationName.ToString());//4
                itm.SubItems.Add(et.Subject.ToString());//6
                itm.SubItems.Add(et.StartDate.ToString());//7
                itm.SubItems.Add(et.EndDate.ToString());//8
                itm.SubItems.Add(et.Grade.ToString());//9
                itm.SubItems.Add(et.Remarks.ToString());//10

                lvTraining.Items.Add(itm);

            }

        }
        #endregion

        #region EmployeePreviousExperience
        private void FormatGridForPrevEx()
        {
            lvPreviousExperience.CheckBoxes = false;
            lvPreviousExperience.Columns.Add("OraganizationName", 200, HorizontalAlignment.Left);
            lvPreviousExperience.Columns.Add("Designation", 200, HorizontalAlignment.Left);
            lvPreviousExperience.Columns.Add("JobDesc", 200, HorizontalAlignment.Left);
            lvPreviousExperience.Columns.Add("DateOfJoining", 200, HorizontalAlignment.Left);
            lvPreviousExperience.Columns.Add("DateOfRetire", 200, HorizontalAlignment.Left);
            lvPreviousExperience.Columns.Add("ResignCause", 200, HorizontalAlignment.Left);
        }

        private void LoadListViewForPrevEx(string emp)
        {
            lvPreviousExperience.Items.Clear();

            List<EmployeePreviousExperience> oGetEmpPrevExe = new List<EmployeePreviousExperience>();
            oGetEmpPrevExe = hmsSC.GetEmpPreviousExperience(txtEmpID.Text).ToList();

            foreach (EmployeePreviousExperience gep in oGetEmpPrevExe)
            {
                ListViewItem itm = new ListViewItem(gep.OrganizationName.ToString()); //.EmployeeMaster.EmpId.ToString()); 0               
                itm.SubItems.Add(gep.Designation.ToString());//3
                itm.SubItems.Add(gep.JobDesc.ToString());//5
                itm.SubItems.Add(gep.DoJ.ToString());//6
                itm.SubItems.Add(gep.DoR.ToString());//7
                itm.SubItems.Add(gep.ResignCause.ToString());//8
                lvPreviousExperience.Items.Add(itm);

            }
        }
        #endregion

        #region EmployeeAcademicInformation
        private void FormatGridForEducation()
        {
            lvAcademicInfo.CheckBoxes = false;
            lvAcademicInfo.Columns.Add("Name Of Degree", 150, HorizontalAlignment.Center);
            lvAcademicInfo.Columns.Add("Passing Year", 100, HorizontalAlignment.Left);
            lvAcademicInfo.Columns.Add("Institute", 150, HorizontalAlignment.Left);
            lvAcademicInfo.Columns.Add("CGPA", 100, HorizontalAlignment.Left);
            lvAcademicInfo.Columns.Add("Country", 150, HorizontalAlignment.Left);
            lvAcademicInfo.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }
        private void LoadListViewForEducation(string emp)
        {
            lvAcademicInfo.Items.Clear();
            List<EmpEducation> oempedus = new List<EmpEducation>();
            oempedus = hmsSC.GetEmpEducation(txtEmpID.Text.ToString()).ToList();
            foreach (EmpEducation empedu in oempedus)
            {
                ListViewItem itm = new ListViewItem(empedu.NameOfDegree);
                itm.SubItems.Add(empedu.PassingYear);
                itm.SubItems.Add(empedu.Institute);
                itm.SubItems.Add(empedu.Class);
                itm.SubItems.Add(empedu.Staff.Country);
                itm.SubItems.Add(empedu.Remarks);
                lvAcademicInfo.Items.Add(itm);
            }
        }
        #endregion

        #region EmployeeMedicalInformation
        private void FormatGridForMedInfo()
        {
            lvEmployeeMedicalInformation.CheckBoxes = false;
            lvEmployeeMedicalInformation.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Eye Sight", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Height", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Weight", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Disabilities", 200, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Diabitics", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("B.Grp", 50, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("BP", 100, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("X-Ray", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("ECG", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Date", 0, HorizontalAlignment.Left);
            lvEmployeeMedicalInformation.Columns.Add("Mark", 0, HorizontalAlignment.Left);
        }
        private void LoadListViewForMedInfo(string emp)
        {
            lvEmployeeMedicalInformation.Items.Clear();

            List<EmployeeMedicalInfo> oEmpMed = hmsSC.GetEmployeeMedicalInformation(txtEmpID.Text).ToList();

            foreach (EmployeeMedicalInfo et in oEmpMed)
            {
                ListViewItem itm = new ListViewItem(et.MedicalReportSerial.ToString());
                itm.SubItems.Add(et.EyeSight.ToString());
                itm.SubItems.Add(et.Height.ToString());
                itm.SubItems.Add(et.weight.ToString());
                itm.SubItems.Add(et.Disabilities.ToString());
                itm.SubItems.Add(et.IsDiabetics.ToString());
                itm.SubItems.Add(et.BloodGrp.ToString());
                itm.SubItems.Add(et.BP.ToString());
                itm.SubItems.Add(et.XrayReport.ToString());
                itm.SubItems.Add(et.EcgReport.ToString());
                itm.SubItems.Add(et.ReportDate.ToString());
                itm.SubItems.Add(et.Mark.ToString());
                lvEmployeeMedicalInformation.Items.Add(itm);
            }
        }
        #endregion

        #region EmployeeNomineeInformation
        private void FormatGridForNomineeInfo()
        {
            lvNomineeInfo.CheckBoxes = false;
            lvNomineeInfo.Columns.Add("EmpID", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeID", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeName", 200, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeName(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Father", 150, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Father(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Mother", 150, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Mother(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Spouse", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Spouse(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Religion", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Sex", 75, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("B.Group", 50, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("MaritialStatus", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("DOB", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Nationality", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Photo", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Signature", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Email", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("H.Phone", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Cell.Phone", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NID", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Occupation", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Relation", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Pre.Address", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Par.Address", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Work.Address", 0, HorizontalAlignment.Left);
        }
        private void LoadListViewForNomineeInfo(string emp)
        {
            lvNomineeInfo.Items.Clear();
            List<Nominee> oNominess = hmsSC.GetNomineeInformation(txtEmpID.Text).ToList();
            foreach (Nominee oNominee in oNominess)
            {
                ListViewItem itm = new ListViewItem(oNominee.EmployeeMaster.EmpId.ToString());
                itm.SubItems.Add(oNominee.NomineeId.ToString());
                itm.SubItems.Add(oNominee.NomineeName.ToString());
                itm.SubItems.Add(oNominee.NomineeNameBeng.ToString());
                itm.SubItems.Add(oNominee.NomineeFatName.ToString());
                itm.SubItems.Add(oNominee.NomineeFatNameBeng.ToString());
                itm.SubItems.Add(oNominee.NomineeMotName.ToString());
                itm.SubItems.Add(oNominee.NomineeMotNameBeng.ToString());
                itm.SubItems.Add(oNominee.NomineeSpouseName.ToString());
                itm.SubItems.Add(oNominee.NomineeSpouseNameBeng.ToString());
                itm.SubItems.Add(oNominee.Religion.ToString());
                itm.SubItems.Add(oNominee.Sex.ToString());
                itm.SubItems.Add(oNominee.BloodGroup.ToString());
                itm.SubItems.Add(oNominee.MaritialStatus.ToString());
                itm.SubItems.Add(oNominee.DOB.ToString());
                itm.SubItems.Add(oNominee.Nationality.ToString());
                itm.SubItems.Add(oNominee.PhotoPath.ToString());
                itm.SubItems.Add(oNominee.SignaturePath.ToString());
                itm.SubItems.Add(oNominee.PersonalEmail.ToString());
                itm.SubItems.Add(oNominee.HomePhone.ToString());
                itm.SubItems.Add(oNominee.CellPhone.ToString());
                itm.SubItems.Add(oNominee.NationalID.ToString());
                itm.SubItems.Add(oNominee.Occupation.ToString());
                itm.SubItems.Add(oNominee.NomineeSerial.ToString());
                itm.SubItems.Add(oNominee.RelationWithStaff.ToString());
                itm.SubItems.Add(oNominee.PresentAddress.ToString());
                itm.SubItems.Add(oNominee.ParmanentAddress.ToString());
                itm.SubItems.Add(oNominee.WorkAddress.ToString());

                lvNomineeInfo.Items.Add(itm);
            }
        }
        #endregion

        #region EmployeePunishment
        private void FormatGridForPunishment()
        {
            lvPunishementType.CheckBoxes = false;
            lvPunishementType.Columns.Add("Serial", 0, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Emp ID", 0, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Punishment ID", 0, HorizontalAlignment.Center);
            lvPunishementType.Columns.Add("Punishment Title", 250, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Effective Date", 150, HorizontalAlignment.Left);
            lvPunishementType.Columns.Add("Duration", 100, HorizontalAlignment.Left);
        }
        private void LoadListViewForPunishment(string Emp)
        {
            lvPunishementType.Items.Clear();
            List<PunishmentType> oBenTypes = new List<PunishmentType>();
            oBenTypes = hmsSC.GetEmpPunishmentType(txtEmpID.Text.ToString()).ToList();
            foreach (PunishmentType oBenType in oBenTypes)
            {
                ListViewItem itm = new ListViewItem(oBenType.Serial);
                itm.SubItems.Add(oBenType.EmployeeMaster.EmpId);
                itm.SubItems.Add(oBenType.PunID);
                itm.SubItems.Add(oBenType.PunTitle);
                itm.SubItems.Add(oBenType.Amount);
                itm.SubItems.Add(oBenType.EffectiveDate.ToString("dd/MM/yyyy"));
                itm.SubItems.Add(oBenType.Duration);
                lvPunishementType.Items.Add(itm);
            }
        }
        #endregion

        #region AddEmployeeInformationLinkClicked
        private void lnkJobInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmpJobInfo ofrm = new frmEmpJobInfo();
            ofrm.EmpId = txtEmpID.Text.ToString();
            ofrm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchInformation();
        }

        private void lnkAcademicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeEducation oEmpEdu = new frmEmployeeEducation();
            oEmpEdu.EmpId = txtEmpID.Text.ToString();
            oEmpEdu.ShowDialog();
        }

        private void lnkPreviousExperience_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmpPrevExp oPrevEx = new frmEmpPrevExp();
            oPrevEx.EmpId = txtEmpID.Text.ToString();
            oPrevEx.ShowDialog();
        }

        private void lnkTrainingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeTraining oEmpTrain = new frmEmployeeTraining();
            oEmpTrain.EmpId = txtEmpID.Text.ToString();
            oEmpTrain.ShowDialog();
        }

        private void lnkDependentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeDependent oEmpDep = new frmEmployeeDependent();
            oEmpDep.EmpId = txtEmpID.Text.ToString();
            oEmpDep.ShowDialog();
        }

        private void chkAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddress.Checked==true)
            {
                txtPerHoViArRd.Text = txtHoViArRd.Text;
                txtPerHoViArRdBeng.Text = txtHoViArRdBeng.Text;                
                cboPerDistrict.Text = cboDistrict.Text;
                cboPerThana.Text = cboThana.Text;
                cboParPostOffice.Text = cboPrePostOffice.Text;
                
            }
            if (chkAddress.Checked==false)
            {
                txtPerHoViArRd.Text = "";
                txtPerHoViArRdBeng.Text = "";                
                cboPerDistrict.Text = "--Select--";
                cboPerThana.Text = "";
                cboParPostOffice.Text = "";
            }
        }
        private void lnkMedicalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeMedicalInformation oEmpMed = new frmEmployeeMedicalInformation();
            oEmpMed.EmpId = txtEmpID.Text.ToString();
            oEmpMed.ShowDialog();
        }
      
        private void lnkPunishment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeePunishmentSetup oEmpPun = new frmEmployeePunishmentSetup();
            oEmpPun.EmpId = txtEmpID.Text.ToString();
            oEmpPun.ShowDialog();
        }
        #endregion

        #region GetDistrictAndThana
        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cboDistrict.Text != "--Select--")
            {
                cboThana.Items.Clear();
                cboThana.Items.Add("--Select--");
                cboThana.Text = "--Select--";
                List<DistrictThana> oDists = oDistThanas.Where(x => x.DistName == cboDistrict.Text).ToList();                
                foreach (DistrictThana oDist in oDists)
                {                    
                    cboThana.Items.Add(oDist.ThanaName);
                }
            }
        }

        private void cboPerDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPerDistrict.Text != "--Select--")
            {
                cboPerThana.Items.Clear();
                cboPerThana.Items.Add("--Select--");
                cboPerThana.Text = "--Select--";
                List<DistrictThana> oDists = oDistThanas.Where(x => x.DistName == cboPerDistrict.Text).ToList();
                foreach (DistrictThana oDist in oDists)
                {
                    cboPerThana.Items.Add(oDist.ThanaName);
                }
            }

        }

        #endregion       
        private void btnRefreshJob_Click(object sender, EventArgs e)
        {
            SearchInformation();
        }      
        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtReff1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtReff2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void pbSignature_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //pbSignature.Image = null;
            //pbSignature.Invalidate();
            //Application.DoEvents();
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            txtFatherNameBeng.Text = txtFatherName.Text;
        }

        private void txtMotherName_TextChanged(object sender, EventArgs e)
        {
            txtMotherNameBeng.Text = txtMotherName.Text;
        }

        private void txtSpouseName_TextChanged(object sender, EventArgs e)
        {
            txtSpouseNameBeng.Text = txtSpouseName.Text;
        }

        private void txtHoViArRd_TextChanged(object sender, EventArgs e)
        {
            txtHoViArRdBeng.Text = txtHoViArRd.Text;
            //txtHoViArRd.Text = Utility.ProperCase(txtHoViArRd.Text);
        }

        private void txtPerHoViArRd_TextChanged(object sender, EventArgs e)
        {
            txtPerHoViArRdBeng.Text = txtPerHoViArRd.Text;
            //txtPerHoViArRd.Text = Utility.ProperCase(txtPerHoViArRd.Text);
        }

        private void lnkNomineeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNomineeInformation oNominee = new frmNomineeInformation();
            oNominee.EmpId = txtEmpID.Text.ToString();
            oNominee.ShowDialog();
        }

        private void txtHoViArRd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtHoViArRdBeng_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtPerHoViArRd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtPerHoViArRdBeng_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            frmBankSetup oBank = new frmBankSetup();
            oBank.ShowDialog();
        }

        private void btnRefreshBank_Click(object sender, EventArgs e)
        {
            cboBankName.DisplayMember = "Value";
            cboBankName.ValueMember = "Key";
            cboBankName.DataSource = new BindingSource(hmsSC.GetBankDict("D"), null);
        }

        private void cboThana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrict.Text != "--Select--")
            {
                if (cboThana.Text != "--Select--")
                {
                    cboPrePostOffice.DisplayMember = "Value";
                    cboPrePostOffice.ValueMember = "Key";
                    cboPrePostOffice.DataSource = new BindingSource(hmsSC.GetPostOfficeDict(cboDistrict.SelectedValue.ToString(), cboThana.Text.ToString()), null);
                }
            }
        }

        private void cboPerThana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPerDistrict.Text != "--Select--")
            {
                if (cboPerThana.Text != "--Select--")
                {
                    cboParPostOffice.DisplayMember = "Value";
                    cboParPostOffice.ValueMember = "Key";
                    cboParPostOffice.DataSource = new BindingSource(hmsSC.GetPostOfficeDict(cboPerDistrict.SelectedValue.ToString(), cboPerThana.Text.ToString()), null);
                }
            }
        }

        private void btnAddPreThana_Click(object sender, EventArgs e)
        {
            frmThanaSetup oThana = new frmThanaSetup();
            oThana.District = cboDistrict.SelectedValue.ToString();
            oThana.ShowDialog();
        }

        private void btnRefreshPreThana_Click(object sender, EventArgs e)
        {
            oDistThanas = hmsSC.GetDistrictAndThana().ToList();
            cboDistrict_SelectedIndexChanged(sender, e);
        }

        private void btnAddParThana_Click(object sender, EventArgs e)
        {
            frmThanaSetup oThana = new frmThanaSetup();
            oThana.District = cboPerDistrict.SelectedValue.ToString();
            oThana.ShowDialog();
        }

        private void btnRefreshParThana_Click(object sender, EventArgs e)
        {
            oDistThanas = hmsSC.GetDistrictAndThana().ToList();
            cboPerDistrict_SelectedIndexChanged(sender, e);
        }

        private void btnAddPrePost_Click(object sender, EventArgs e)
        {
            frmPostOfficeSetup oPostOffice = new frmPostOfficeSetup();
            oPostOffice.District = cboDistrict.Text.ToString();
            if (cboThana.Text != "")
            {
                oPostOffice.Thana = cboThana.Text.ToString();
            }
            oPostOffice.ShowDialog();
        }

        private void btnRefreshPrePost_Click(object sender, EventArgs e)
        {
            cboThana_SelectedIndexChanged(sender, e);
        }

        private void btnAddParPost_Click(object sender, EventArgs e)
        {
            frmPostOfficeSetup oPostOffice = new frmPostOfficeSetup();
            oPostOffice.District = cboPerDistrict.Text.ToString();
            if (cboPerThana.SelectedValue != "")
            {
                oPostOffice.Thana = cboPerThana.Text.ToString();
            }
            oPostOffice.ShowDialog();
        }

        private void btnRefreshParPost_Click(object sender, EventArgs e)
        {
            cboPerThana_SelectedIndexChanged(sender, e);
        }

    }
}
