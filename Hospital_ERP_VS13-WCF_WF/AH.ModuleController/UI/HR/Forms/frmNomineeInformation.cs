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

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmNomineeInformation : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();

        #region GlobalDeclaration
        OpenFileDialog open1 = new OpenFileDialog();
        SaveFileDialog save1 = new SaveFileDialog();
        OpenFileDialog open2 = new OpenFileDialog();
        SaveFileDialog save2 = new SaveFileDialog();

        string appImagePath = "C:\\NomineeImages\\";
        string appSignaturePath = "C:\\NomineeSignatures\\";
        string LocalSrcFile = "";
        string LocalSrcFile1 = "";
        public string EmpId { set; get; }
        #endregion
        public frmNomineeInformation()
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

        private void frmNomineeInformation_Load(object sender, EventArgs e)
        {
            DeleteImageDirectory(appImagePath);
            DeleteImageDirectory(appSignaturePath);

            cboSex.DisplayMember = "Value";
            cboSex.ValueMember = "Key";
            cboSex.DataSource = new BindingSource(Utility.GetSexes(), null);

            cboReligion.DisplayMember = "Value";
            cboReligion.ValueMember = "Key";
            cboReligion.DataSource = new BindingSource(Utility.GetReligions(), null);

            cboBloodGrp.DisplayMember = "Value";
            cboBloodGrp.ValueMember = "Key";
            cboBloodGrp.DataSource = new BindingSource(Utility.GetBloodGroups(), null);

            cboMaritialStatus.DisplayMember = "Value";
            cboMaritialStatus.ValueMember = "Key";
            cboMaritialStatus.DataSource = new BindingSource(Utility.GetMaritalStatus(), null);

            cboRelation.DisplayMember = "Value";
            cboRelation.ValueMember = "Key";
            cboRelation.DataSource = new BindingSource(Utility.GetRelationships(), null);

            cboOccupation.DisplayMember = "Value";
            cboOccupation.ValueMember = "Key";
            cboOccupation.DataSource = new BindingSource(Utility.GetOccupations(), null);

            FormatGrid();
            RefreshGrid();
            txtEmpID.Focus();
        }
        private void FormatGrid()
        {
            lvNomineeInfo.CheckBoxes = false;
            lvNomineeInfo.Columns.Add("EmpID", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeID", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeName", 250, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("NomineeName(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Father", 250, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Father(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Mother", 250, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Mother(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Spouse", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Spouse(Beng)", 0, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Religion", 100, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("Sex", 100, HorizontalAlignment.Left);
            lvNomineeInfo.Columns.Add("BloodGroup", 100, HorizontalAlignment.Left);
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
        private void RefreshGrid()
        {
            if (EmpId != "")
            {
                txtEmpID.Text = EmpId;
                LoadListView(txtEmpID.Text);
            }
            if (EmpId == "")
            {
                return;
            }

        } 
        #region ShowImageAndSignature
        private void ShowImage(string SigPath, string DestinationPath)
        {
            LocalSrcFile = "C:\\NomineeImages\\" + txtNomineeID.Text + ".JPEG";
            PopulateImage(appImagePath, Utility.EmployeeNomineePhotoPath, LocalSrcFile, DestinationPath);
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
            LocalSrcFile1 = "C:\\NomineeSignatures\\" + txtNomineeID.Text + ".JPEG";
            PopulateImage(appSignaturePath, Utility.EmployeeNomineeSignaturePath, LocalSrcFile1, DestinationPath1);
            pbSignature.Image = new Bitmap(LocalSrcFile1);
            pbSignature.Image = Utility.ScaleImage(pbSignature.Image, 220, 257);
            pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion     
        private void LoadListView(string oEmp)
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

        private void txtEmpID_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (txtEmpID.Text == "")
            {
                lblInfo.Text = "";
                return;
            }
            if (txtEmpID.Text != "")
            {
                EmployeeMaster oEmpMas = new EmployeeMaster();
                oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);
                if (txtEmpID.Text == oEmpMas.EmpId)
                {

                    lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
                }

                else
                {
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtNomineeName_TextChanged(object sender, EventArgs e)
        {
            txtNomineeNameBeng.Text = txtNomineeName.Text;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            pbImage.Image = null;
            pbSignature.Image = null;
            txtDOB.Text = null;
            lblInfo.Text = "";
            if (lvNomineeInfo.Items.Count > 0)
            {
                lvNomineeInfo.Items.Clear();
            }
        }

        private void lvNomineeInfo_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void lvNomineeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNomineeInfo.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvNomineeInfo.SelectedItems[0];
                txtEmpID.Text = itm.SubItems[0].Text;
                txtNomineeID.Text = itm.SubItems[1].Text;
                txtNomineeName.Text = itm.SubItems[2].Text;
                txtNomineeNameBeng.Text = itm.SubItems[3].Text;
                txtFatherName.Text = itm.SubItems[4].Text.ToString();
                txtFatherNameBeng.Text = itm.SubItems[5].Text;
                txtMotherName.Text = itm.SubItems[6].Text;
                txtMotherNameBeng.Text = itm.SubItems[7].Text;
                txtSpouseName.Text = itm.SubItems[8].Text;
                txtSpouseNameBeng.Text = itm.SubItems[9].Text;
                cboReligion.SelectedValue = itm.SubItems[10].Text;
                cboSex.Text = itm.SubItems[11].Text;
                cboBloodGrp.Text = itm.SubItems[12].Text;
                cboMaritialStatus.Text = itm.SubItems[13].Text;
                txtDOB.Text = Convert.ToDateTime(itm.SubItems[14].Text).ToString("dd/MM/yyyy");
                txtNationality.Text = itm.SubItems[15].Text;
                if (itm.SubItems[16].Text == "default")
                {
                    ShowImage(LocalSrcFile, Utility.EmployeeNomineePhotoPath + "\\" + itm.SubItems[16].Text + ".JPEG");
                }
                if (itm.SubItems[16].Text != "default")
                {
                    ShowImage(LocalSrcFile, Utility.EmployeeNomineePhotoPath +"\\" + txtEmpID.Text + "\\" + itm.SubItems[16].Text + ".JPEG");
                }
                if (itm.SubItems[17].Text == "default")
                {
                    ShowSignature(LocalSrcFile1, Utility.EmployeeNomineeSignaturePath + "\\" + itm.SubItems[17].Text + ".JPEG");
                }
                if (itm.SubItems[17].Text != "default")
                {
                    ShowSignature(LocalSrcFile1, Utility.EmployeeNomineeSignaturePath + "\\" + txtEmpID.Text + "\\" + itm.SubItems[17].Text + ".JPEG");
                }
                txtPersonalEmail.Text = itm.SubItems[18].Text;
                txtHomePhone.Text = itm.SubItems[19].Text;
                txtCellPhone.Text = itm.SubItems[20].Text;
                txtNationalId.Text = itm.SubItems[21].Text;
                cboOccupation.Text = itm.SubItems[22].Text;
                txtSerial.Text = itm.SubItems[23].Text;
                cboRelation.Text = itm.SubItems[24].Text;
                txtPresentAddress.Text = itm.SubItems[25].Text;
                txtParmanentAddress.Text = itm.SubItems[26].Text;
                txtWorkAddress.Text = itm.SubItems[27].Text;
            }     
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }


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

        private void SaveImage(string NomineeIDNumber)
        {
            string activeDir = Utility.EmployeeNomineePhotoPath;
            string newImagePath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newImagePath);

            string filePathImage = save1.FileName + newImagePath + "\\" + NomineeIDNumber + ".JPEG";
            Stream buffer1;
            if (open1.FileName == "")
            {
                return;
            }
            StreamReader srImage = new StreamReader(open1.FileName);

            buffer1 = srImage.BaseStream;
            Bitmap bmImage = new Bitmap(buffer1);

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
        private void SaveSignature(string NomineeIDNumber)
        {
            string activeDir = Utility.EmployeeNomineeSignaturePath;
            string newSignaturePath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newSignaturePath);

            string filePathSignature = save2.FileName + newSignaturePath + "\\" + NomineeIDNumber + ".JPEG";
            Stream buffer2;
            if (open2.FileName == "")
            {
                return;
            }
            StreamReader srSignature = new StreamReader(open2.FileName);

            buffer2 = srSignature.BaseStream;
            Bitmap bmSignature = new Bitmap(buffer2);

            if (File.Exists(filePathSignature))
            {

                DialogResult msg = MessageBox.Show("Same file name already exists,Do u want to update?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msg == DialogResult.Yes)
                {
                    File.Delete(filePathSignature);
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    oSignature.Save(filePathSignature);
                }
            }
            else
            {
                File.Delete(filePathSignature);
                Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                oSignature.Save(filePathSignature);
            }

        }

        private Nominee populateEmployeeNominee()
        {
            Nominee oNominee = new Nominee();

            EmployeeMaster oEmp = new EmployeeMaster();
            oEmp = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text == oEmp.EmpId)
            {
                oEmp.EmpId = txtEmpID.Text.ToString();
                oNominee.EmployeeMaster = oEmp;

                oNominee.NomineeId = txtNomineeID.Text.ToString();
                oNominee.NomineeName = txtNomineeName.Text.ToString();
                oNominee.NomineeNameBeng = txtNomineeNameBeng.Text.ToString();
                oNominee.NomineeFatName = txtFatherName.Text.ToString();
                oNominee.NomineeFatNameBeng = txtFatherNameBeng.Text.ToString();
                oNominee.NomineeMotName = txtMotherName.Text.ToString();
                oNominee.NomineeMotNameBeng = txtMotherNameBeng.Text.ToString();
                oNominee.NomineeSpouseName = txtSpouseName.Text.ToString();
                oNominee.NomineeSpouseNameBeng = txtSpouseNameBeng.Text.ToString();
                oNominee.Religion = cboReligion.SelectedValue.ToString();
                oNominee.Sex = cboSex.SelectedValue.ToString();
                oNominee.BloodGroup = cboBloodGrp.SelectedValue.ToString();
                oNominee.DOB = txtDOB.Text.ToString();
                oNominee.MaritialStatus = cboMaritialStatus.SelectedValue.ToString();
                oNominee.Nationality = txtNationality.Text.ToString();

                if (pbImage.Image == null)
                {
                    if (open1.SafeFileName == "")
                    {
                        oNominee.PhotoPath = "";
                    }
                    else
                    {
                        oNominee.PhotoPath = "image";
                    }
                }
                if (pbImage.Image != null)
                {
                    if (open1.SafeFileName == "")
                    {
                        oNominee.PhotoPath = "";
                    }
                    else
                    {
                        oNominee.PhotoPath = "image";
                    }
                }

                if (pbSignature.Image == null)
                {
                    if (open2.SafeFileName == "")
                    {
                        oNominee.SignaturePath = "";
                    }
                    else
                    {
                        oNominee.SignaturePath = "signature";
                    }
                }
                if (pbSignature.Image != null)
                {
                    if (open2.SafeFileName == "")
                    {
                        oNominee.SignaturePath = "";
                    }
                    else
                    {
                        oNominee.SignaturePath = "signature";
                    }
                }

                oNominee.PersonalEmail = txtPersonalEmail.Text.ToString();
                oNominee.HomePhone = txtHomePhone.Text.ToString();
                oNominee.CellPhone = txtCellPhone.Text.ToString();
                oNominee.NationalID = txtNationalId.Text.ToString();
                oNominee.Occupation = cboOccupation.SelectedValue.ToString();
                oNominee.NomineeSerial = txtSerial.Text.ToString();
                oNominee.RelationWithStaff = cboRelation.SelectedValue.ToString();
                oNominee.PresentAddress = txtPresentAddress.Text.ToString();
                oNominee.ParmanentAddress = txtParmanentAddress.Text.ToString();
                oNominee.WorkAddress = txtWorkAddress.Text.ToString();

                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.UpdateBy = Utility.UserId;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oNominee.EntryParameter = ep;
            }
            else
            {
                MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return oNominee;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtNomineeName", "txtNomineeNameBeng", "txtFatherName", "txtFatherNameBeng", "txtMotherName", "txtMotherNameBeng", "cboReligion", "cboSex", "cboMaritialStatus", "cboBloodGrp", "cboOccupation", "cboRelation", "txtNationality","txtPresentAddress", "txtParmanentAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtDOB.Text == "  /  /")
            {
                MessageBox.Show("Date cannot be empty");
                return;
            }
            try
            {
                string strNomineeID = "";
                Nominee oNominee = this.populateEmployeeNominee();
                short i = hmsSC.SaveNomineeInformation(oNominee);
                List<Nominee> objEmp = hmsSC.GetNomineeInfo().ToList();
                foreach (Nominee emp in objEmp)
                {
                    strNomineeID = emp.NomineeId;
                }
                SaveImage(strNomineeID);
                SaveSignature(strNomineeID);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSearch_Click(sender, e);
                    btnNew.PerformClick();
                    pbImage.Image = null;
                    pbSignature.Image = null; 
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(txtEmpID.Text.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtNomineeID", "txtNomineeName", "txtNomineeNameBeng", "txtFatherName", "txtFatherNameBeng", "txtMotherName", "txtMotherNameBeng", "cboReligion", "cboSex", "cboMaritialStatus", "cboBloodGrp", "cboOccupation", "cboRelation", "txtNationality","txtPresentAddress", "txtParmanentAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtDOB.Text == "  /  /")
            {
                MessageBox.Show("Date cannot be empty");
                return;
            }
            try
            {
                Nominee oNominee = this.populateEmployeeNominee();
                short i = hmsSC.UpdateNomineeInformation(oNominee);
               
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    EditImage();
                    EditSignature();
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteImageFile(LocalSrcFile);
                    DeleteImageFile(LocalSrcFile1);
                    btnNew.PerformClick();
                    pbImage.Image = null;
                    pbSignature.Image = null; 
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

        #region EditImageAndSignature
        private void EditImage()
        {
            Stream buffer1;
            string activeDir = Utility.EmployeeNomineePhotoPath;
            string newPath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newPath);

            string ImagePath = save1.FileName + newPath + "\\" + txtNomineeID.Text + ".JPEG";

            if (open1.FileName =="")
            {
                return;
            }
            if (open1.FileName != "")
            {
                StreamReader srImage = new StreamReader(open1.FileName);
                buffer1 = srImage.BaseStream;
                Bitmap bmImage = new Bitmap(buffer1);

                string SourcePath = open1.FileName;
                string DestinationPath = newPath;

                FileInfo img = new FileInfo(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");

                if (img.Exists)
                {
                    img.Delete();
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");
                }
                if (!img.Exists)
                {
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");
                }
            }
        }
        private void EditSignature()
        {
            Stream buffer2;
            string activeDir = Utility.EmployeeNomineeSignaturePath;
            string newPath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newPath);

            string ImagePath = save2.FileName + newPath + "\\" + txtNomineeID.Text + ".JPEG";

            if (open2.FileName.ToString() == "")
            {
                return;
            }
            if (open2.FileName.ToString() != "")
            {
                StreamReader srImage = new StreamReader(open2.FileName);
                buffer2 = srImage.BaseStream;
                Bitmap bmSignature = new Bitmap(buffer2);

                string SourcePath = open1.FileName;
                string DestinationPath = newPath;

                FileInfo img = new FileInfo(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");

                if (img.Exists)
                {
                    img.Delete();
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                    oSignature.Save(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");
                }
                if (!img.Exists)
                {
                    Bitmap oSignature = new Bitmap(bmSignature, new Size(220, 257));
                    oSignature.Save(DestinationPath + "\\" + txtNomineeID.Text + ".JPEG");
                }
            }
        }
        #endregion


    }
}
