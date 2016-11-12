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
using System.Drawing.Imaging;
using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmEmployeeDependent : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string EmpId { set; get; }

        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        string appImagePath = Path.GetDirectoryName("C:\\DependentImages\\");
        string appImagePathEdit = Path.GetDirectoryName("C:\\DependentImages\\Edit\\");
        
        private int intSearchFlag = 0;
        string LocalSrcFile = "";
        public frmEmployeeDependent()
        {
            InitializeComponent();
        }

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
        private void frmEmployeeDependent_Load(object sender, EventArgs e)
        {
            DeleteImageDirectory(appImagePath);

            cboRelation.DisplayMember = "Value";
            cboRelation.ValueMember = "Key";
            cboRelation.DataSource = new BindingSource(Utility.GetRelationships(), null);
            FormatGrid();
            RefreshGrid();
            txtEmpID.Focus();
        }

        private void FormatGrid()
        {
            lvEmployeeDependent.CheckBoxes = false;

            lvEmployeeDependent.Columns.Add("EmployeeID", 150, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("DependentID", 150, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("DependentName", 220, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("DependentName(Bangla)", 220, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("status", 0, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("Relation", 150, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("DOB", 150, HorizontalAlignment.Left);
            lvEmployeeDependent.Columns.Add("Photo", 0, HorizontalAlignment.Left);

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
                    MessageBox.Show("Invalid EmployeeID!!!Please Enter Correct ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {           
            EmployeeMaster oEmpMas = new EmployeeMaster();
            oEmpMas = hmsSC.GetEmpMaster(txtEmpID.Text);

            if (txtEmpID.Text == oEmpMas.EmpId)
            {
                lblInfo.Text = oEmpMas.FirstName + Utility.CrLf + oEmpMas.Designation.DesignationId.ToString() + ',' + oEmpMas.DepartmentUnit.UnitId.ToString() + ',' + oEmpMas.Department.DepartmentTitle.ToString();
            }
            LoadListView(txtEmpID.Text);
            txtDOB.Text = null;
            pbImage.Image = null;
        }

        private void LoadListView(string oEmp)
        {
            lvEmployeeDependent.Items.Clear();

            List<EmployeeDependent> oEmpDeps = hmsSC.GetEmpDependent(txtEmpID.Text).ToList();

            foreach (EmployeeDependent oEmpDep in oEmpDeps)
            {
                ListViewItem itm = new ListViewItem(oEmpDep.EmployeeMaster.EmpId.ToString());
                itm.SubItems.Add(oEmpDep.DependID.ToString());
                itm.SubItems.Add(oEmpDep.DependName.ToString());

                itm.SubItems.Add(oEmpDep.DependNameBeng.ToString());
                itm.SubItems.Add(oEmpDep.DependentStatus.ToString());
                itm.SubItems.Add(oEmpDep.RelationID.ToString());
                itm.SubItems.Add(oEmpDep.DOB.ToString("dd/MM/yyyy"));
                itm.SubItems.Add(oEmpDep.PhotoPath.ToString());
            
                lvEmployeeDependent.Items.Add(itm);
            }

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

        private EmployeeDependent populateEmployeeDependent()
        {
            EmployeeDependent oEmpDep = new EmployeeDependent();  
         
            EmployeeMaster oEmp = new EmployeeMaster();
            oEmp = hmsSC.GetEmpMaster(txtEmpID.Text);
            if (txtEmpID.Text == oEmp.EmpId)
            { 
            oEmp.EmpId = txtEmpID.Text.ToString();
            oEmpDep.EmployeeMaster = oEmp;

            oEmpDep.DependID = txtDependID.Text.ToString();
            oEmpDep.DependName = txtDependentName.Text.ToString();
            oEmpDep.DependNameBeng = txtDependentNameBeng.Text.ToString();
            oEmpDep.DOB = DateTime.ParseExact(txtDOB.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            oEmpDep.RelationID = cboRelation.SelectedValue.ToString();

            if (pbImage.Image == null)
            {
                if (open.SafeFileName == "")
                {
                    oEmpDep.PhotoPath = "";
                }
                else
                {
                    oEmpDep.PhotoPath = "image";
                }
            }
            if (pbImage.Image != null)
            {
                oEmpDep.PhotoPath = "image";
            }

            if (chkDependStatus.Checked == true)
            {
                oEmpDep.DependentStatus = "1";
            }
            if (chkDependStatus.Checked == false)
            {
                oEmpDep.DependentStatus = "0";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oEmpDep.EntryParameter = ep;
            }
             else
             {
                 MessageBox.Show("Invalid EmployeeID", "HRM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }

            return oEmpDep;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID", "txtDependentName", "txtDependentNameBeng", "cboRelation" };
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
                string strDepID = "";
                EmployeeDependent oEmpDep = this.populateEmployeeDependent();
                short i = hmsSC.SaveEmployeeDependent(oEmpDep);
                List<EmployeeDependent> objEmp = hmsSC.GetEmployeeDependent().ToList();
                foreach (EmployeeDependent emp in objEmp)
                {
                    strDepID = emp.DependID;
                }
                SaveImage(strDepID);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    btnSearch_Click(sender, e);
                    txtDependentName.Text = "";
                    txtDependentNameBeng.Text = "";
                    pbImage.Image = null;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtEmpID","txtDependID", "txtDependentName", "txtDependentNameBeng", "cboRelation" };
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
                EmployeeDependent oEmpDep = this.populateEmployeeDependent();
                short i = hmsSC.UpdateEmployeeDependent(oEmpDep);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    EditImage();
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    btnSearch_Click(sender, e);
                    DeleteImageFile(LocalSrcFile);
                    txtDependentName.Text = "";
                    txtDependentNameBeng.Text = "";
                    pbImage.Image = null;                  
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

        private void lvEmployeeDependent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployeeDependent.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvEmployeeDependent.SelectedItems[0];
                txtEmpID.Text = itm.SubItems[0].Text;
                txtDependID.Text = itm.SubItems[1].Text;
                txtDependentName.Text = itm.SubItems[2].Text;
                txtDependentNameBeng.Text = itm.SubItems[3].Text;
                if (itm.SubItems[4].Text == "1")
                {
                    chkDependStatus.Checked = true;
                }
                else
                    chkDependStatus.Checked = false;
                cboRelation.Text = itm.SubItems[5].Text.ToString();
                txtDOB.Text = itm.SubItems[6].Text;
                //ShowImage(LocalSrcFile, Utility.EmployeePhotoPath + oEmpMast.PhotoPath + ".JPEG");
                ShowImage(LocalSrcFile, Utility.EmployeeDependentPhotoPath + txtEmpID.Text + "\\" + itm.SubItems[7].Text + ".JPEG");           
                
            }     
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            open.Multiselect = true;
            DialogResult result = open.ShowDialog();
            open.Filter = "allfiles|*";
            if (result == DialogResult.OK)
            {
                if (pbImage.Image == null || pbImage.Image != null)
                {
                    pbImage.Image = new Bitmap(open.OpenFile());
                    pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
                }
            }
            if (result == DialogResult.Cancel)
            {
                return;
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

        private void SaveImage(string DependentIDNumber)
        {
            string activeDir = Utility.EmployeeDependentPhotoPath;
            string newPath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newPath);

            string filePathImage = save.FileName + newPath + "\\" + DependentIDNumber + ".JPEG";
            Stream buffer;
            if (open.FileName == "")
            {
                return;
            }
            StreamReader srImage = new StreamReader(open.FileName);

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
                    filePathImage = " ";
                }
            }
            else
            {
                File.Delete(filePathImage);
                Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                oImage.Save(filePathImage);
                filePathImage = " ";
                oImage.Dispose();
            }

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
                FileInfo extpath = new FileInfo(destinationPath);
                if (extpath.Exists == true)
                {
                    File.Copy(destinationPath, localSourceFile, true);
                }
                else
                {
                    string DestPath = Utility.EmployeeDependentPhotoPath + "default.JPEG";
                    File.Copy(DestPath, localSourceFile, true);
                }
            }
        }

        private void ShowImage(string SigPath, string DestinationPath)
        {
            LocalSrcFile = "C:\\DependentImages\\" + txtDependID.Text + ".JPEG";
            PopulateImage(appImagePath, Utility.EmployeeDependentPhotoPath, LocalSrcFile, DestinationPath);
            pbImage.Image = new Bitmap(LocalSrcFile);
            pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void EditImage()
        {
            Stream buffer1;
            string activeDir = Utility.EmployeeDependentPhotoPath;
            string newPath = System.IO.Path.Combine(activeDir, txtEmpID.Text);
            System.IO.Directory.CreateDirectory(newPath);

            string ImagePath = save.FileName + newPath + "\\" + txtDependID.Text + ".JPEG";

            if (open.FileName == "")
            {
                return;
            }
            if (open.FileName != "")
            {
                StreamReader srImage = new StreamReader(open.FileName);
                buffer1 = srImage.BaseStream;
                Bitmap bmImage = new Bitmap(buffer1);

                string SourcePath = open.FileName;
                string DestinationPath = newPath;

                FileInfo img = new FileInfo(DestinationPath + "\\" + txtDependID.Text + ".JPEG");

                if (img.Exists)
                {
                    img.Delete();
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + "\\" + txtDependID.Text + ".JPEG");
                }
                if (!img.Exists)
                {
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    oImage.Save(DestinationPath + "\\" + txtDependID.Text + ".JPEG");
                }
            }
        }     
        private void lvEmployeeDependent_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            pbImage.Image = null;
            txtDOB.Text = null;
            lblInfo.Text = "";
            if(lvEmployeeDependent.Items.Count>0)
            {
                lvEmployeeDependent.Items.Clear();
            }
        }

        private void chkDependStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDependStatus.Checked==true)
            {
                cboRelation.Enabled = true;
            }
            if (chkDependStatus.Checked == false)
            {
                cboRelation.Enabled = false;
            }
        }

        private void pbImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pbImage.Image = null;
        }

        private void txtDependentName_TextChanged(object sender, EventArgs e)
        {
            txtDependentNameBeng.Text = txtDependentName.Text;
        }

    }
}
