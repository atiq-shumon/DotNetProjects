using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFoodMaster : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        OpenFileDialog open1 = new OpenFileDialog();
        SaveFileDialog save1 = new SaveFileDialog();
        List<FoodMaster> objfood;
        string LocalSrcFile;
        string appImagePath = "C:\\Images\\";
        public frmFoodMaster()
        {
            InitializeComponent();
        }

        #region "Format List"
        private void FormaList()
        {
            lvwFoodItem.CheckBoxes = false;
            lvwFoodItem.Columns.Add("Food ID", 150, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Food Name", 550, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Cat ID", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Normal", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Diebetes", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("High Protein", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Low Protein", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Renal", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("High Fat",0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Low Fat", 0, HorizontalAlignment.Left);
            lvwFoodItem.Columns.Add("Price", 110, HorizontalAlignment.Left);
        }
        #endregion
        #region "Load"
        private void frmFoodMaster_Load(object sender, EventArgs e)
        {
            try
            {
                cboFoodCat.ValueMember = "key";
                cboFoodCat.DisplayMember = "value";
                cboFoodCat.DataSource = new BindingSource(fnbs.GetFoodCategory(), null);
                FormaList();
                LoadListViewFood();

                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(FoodImage.DisplayRectangle);
                FoodImage.Region = new Region(gp);
                FoodImage.Image = imageList1.Images[1];

                //pbImage.Image = new Bitmap(LocalSrcFile);
                FoodImage.Image = Utility.ScaleImage(FoodImage.Image, 220, 257);
                FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;

                DeleteImageDirectory("C:\\Images");
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
        #endregion
        #region "Validatefields"
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtItemName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (cboFoodCat.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboFoodCat.Focus();
                return false;
            }
            
            return true;
        }
        #endregion
        #region "PopulatedFoodItem"
        private FoodMaster PopulateFoodItem()
        {
            FoodMaster objFood = new FoodMaster();
            if (txtItemID.Text != "")
            {
                objFood.FoodID = txtItemID.Text;
            }
            else
            {
                objFood.FoodID = "";
            }
            objFood.FoodName = txtFoodItem.Text;
        
            objFood.CatID  = cboFoodCat.SelectedValue.ToString();
            objFood.UnitId = "0001";
            objFood.Remarks = txtRemarks.Text.ToString();
            objFood.Price = Convert.ToDouble(txtFoodRate.Text);
            if (chkNormal.Checked== true )
            {
                objFood.IsNormal ="1" ;
            }
            else
            {
              objFood.IsNormal = "0";
            }

            if (chkdiabetic.Checked == true)
            {
                objFood.IsDiabetic = "1";
            }
            else
            {
                objFood.IsDiabetic = "0";
            }

            if (chkhighprotein.Checked == true)
            {
                objFood.IsHighprotein = "1";
            }
            else
            {
                objFood.IsHighprotein = "0";
            }

            if (chklowprotein.Checked == true)
            {
                objFood.IsLowProtein = "1";
            }
            else
            {
                objFood.IsLowProtein = "0";
            }

            if (chkisrenal.Checked == true)
            {
                objFood.IsRenal = "1";
            }
            else
            {
                objFood.IsRenal = "0";
            }

            if (chkhighfat.Checked == true)
            {
                objFood.IsHighFat = "1";
            }
            else
            {
                objFood.IsHighFat = "0";
            }
            if (chkLowFat.Checked == true)
            {
                objFood.IsLowFat  = "1";
            }
            else
            {
                objFood.IsLowFat = "0";
            }


            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFood.EntryParameter = ep;
            return objFood;
        }
        #endregion
        #region "LoadlistFood"
        private void LoadListViewFood()
        {
            try
            {
                lvwFoodItem.Items.Clear();
                objfood = fnbs.LoadFoodMaster().ToList();
                if (objfood.Count > 0)
                {
                    foreach (FoodMaster objFm in objfood)
                    {
                        ListViewItem itm = new ListViewItem(objFm.FoodID);
                        itm.SubItems.Add(objFm.FoodName);
                        itm.SubItems.Add(objFm.CatID);
                        itm.SubItems.Add(objFm.UnitId);
                        itm.SubItems.Add(objFm.Remarks);
                        itm.SubItems.Add(objFm.IsNormal);
                        itm.SubItems.Add(objFm.IsDiabetic);
                        itm.SubItems.Add(objFm.IsHighprotein);
                        itm.SubItems.Add(objFm.IsLowProtein);
                        itm.SubItems.Add(objFm.IsRenal);
                        itm.SubItems.Add(objFm.IsHighFat);
                        itm.SubItems.Add(objFm.IsLowFat);
                        itm.SubItems.Add(objFm.Price.ToString());
                        lvwFoodItem.Items.Add(itm);
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
        #endregion
        #region"Button"
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (ValidateFields() == false)
            {
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvwFoodItem, 1, txtFoodItem.Text) == true)
            {
                MessageBox.Show("Cannot Inssert Duplicate Value", "Fnb");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FoodMaster objfood = this.PopulateFoodItem();
                    string i = fnbs.InsertFoodMaster(objfood);
                    if (i != "")
                    {
                        SaveImage(i);
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadListViewFood();
                        txtFoodItem.Text = "";
                        txtRemarks.Text = "";
                        txtItemID.Text = "";
                        txtFoodRate.Text = "0";
                        chkNormal.Checked = false;
                        chkdiabetic.Checked = false;
                        chkhighprotein.Checked = false;
                        chklowprotein.Checked = false;
                        chkisrenal.Checked = false;
                        chkhighfat.Checked = false;
                        chkLowFat.Checked = false;
                        FoodImage.Image = imageList1.Images[1];
                        txtFoodItem.Focus();
                    }
                    else
                    {
                        LoadListViewFood();
                        txtFoodItem.Text = "";
                        txtRemarks.Text = "";
                        txtItemID.Text = "";
                        txtFoodRate.Text = "0";
                        chkNormal.Checked = false;
                        chkdiabetic.Checked = false;
                        chkhighprotein.Checked = false;
                        chklowprotein.Checked = false;
                        chkisrenal.Checked = false;
                        chkhighfat.Checked = false;
                        chkLowFat.Checked = false;
                        FoodImage.Image = imageList1.Images[1];
                        txtFoodItem.Focus();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    FoodMaster objfood = this.PopulateFoodItem();
                    int i = fnbs.UpdateFoodMaster(objfood);
                    if (i == 0)
                    {

                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SaveImage(txtItemID.Text);
                        LoadListViewFood();
                        txtFoodItem.Text = "";
                        txtRemarks.Text = "";
                        txtItemID.Text = "";
                        txtFoodRate.Text = "0";
                        chkNormal.Checked = false;
                        chkdiabetic.Checked = false;
                        chkhighprotein.Checked = false;
                        chklowprotein.Checked = false;
                        chkisrenal.Checked = false;
                        chkhighfat.Checked = false;
                        chkLowFat.Checked = false;
                        txtFoodItem.Focus();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
                        FoodImage.Image = imageList1.Images[1];
                        DeleteImageDirectory("C:\\Images");
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

        private void ShowImage(string SigPath, string DestinationPath)
        {
            try
            {

                LocalSrcFile = "C:\\Images\\" + txtItemID.Text + ".JPEG";
                PopulateImage(appImagePath, Utility.FoodPhotoPath, LocalSrcFile, DestinationPath);
                FoodImage.Image = new Bitmap(LocalSrcFile);
                FoodImage.Image = Utility.ScaleImage(FoodImage.Image, 220, 257);
                FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {

            }

        }
        private void PopulateImage(string path, string utilityPath, string localSourceFile, string destinationPath)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                FileInfo imge = new FileInfo(localSourceFile);
                if (imge.Exists != true)
                {
                    File.Copy(destinationPath, localSourceFile, true);
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void lvwFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFoodItem.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFoodItem.SelectedItems[0];
              
                txtItemID.Text = itm.SubItems[0].Text;
                txtFoodItem.Text = itm.SubItems[1].Text;
                cboFoodCat.SelectedValue = itm.SubItems[2].Text;
                cboUnitId.Text  = "Pcs";
                txtRemarks.Text = itm.SubItems[4].Text;
                if (itm.SubItems[5].Text == "1")
                {
                    chkNormal.Checked = true;
                }
                else
                {
                    chkNormal.Checked = false;
                }
                if (itm.SubItems[6].Text == "1")
                {
                    chkdiabetic.Checked = true;
                }
                else
                {
                    chkdiabetic.Checked = false;
                }

                if (itm.SubItems[7].Text == "1")
                {
                    chkhighprotein.Checked = true;
                }
                else
                {
                    chkhighprotein.Checked = false;
                }


                if (itm.SubItems[8].Text == "1")
                {
                    chklowprotein.Checked = true;
                }
                else
                {
                    chklowprotein.Checked = false;
                }

                if (itm.SubItems[9].Text == "1")
                {
                    chkisrenal.Checked = true;
                }
                else
                {
                    chkisrenal.Checked = false;
                }


                if (itm.SubItems[10].Text == "1")
                {
                    chkhighfat.Checked = true;
                }
                else
                {
                    chkhighfat.Checked = false;
                }

                if (itm.SubItems[11].Text == "1")
                {
                    chkLowFat.Checked = true;
                }
                else
                {
                    chkLowFat.Checked = false;
                }

                txtFoodRate.Text = itm.SubItems[12].Text.ToString();
                FoodImage.Image = imageList1.Images[1];
                ShowImage("", Utility.FoodPhotoPath + itm.SubItems[0].Text + ".JPEG");
                txtFoodItem.Focus();
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFoodRate.Text = "0";
            LoadListViewFood();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(FoodImage.DisplayRectangle);
            FoodImage.Region = new Region(gp);
            FoodImage.Image = imageList1.Images[1];
        }
        #endregion
        #region "Keypress"
        private void txtFoodItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                cboUnitId.Focus();
            }
        }
        
        private void cboFoodCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //txtFoodRate.Focus();
                txtFoodItem.Focus();
            }
        }
        private void txtFoodRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }
            }
        }
        #endregion
        #region "Linq"
        private void SearchListView(IEnumerable<FoodMaster> tests, string searchString = "")
        {
            IEnumerable<FoodMaster> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.CatID.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwFoodItem.Items.Clear();
            foreach (FoodMaster objFm in query)
            {
                ListViewItem itm = new ListViewItem(objFm.FoodID);
                itm.SubItems.Add(objFm.FoodName);
                itm.SubItems.Add(objFm.CatID);
                itm.SubItems.Add(objFm.UnitId);
                itm.SubItems.Add(objFm.Remarks);
                itm.SubItems.Add(objFm.IsNormal);
                itm.SubItems.Add(objFm.IsDiabetic);
                itm.SubItems.Add(objFm.IsHighprotein);
                itm.SubItems.Add(objFm.IsLowProtein);
                itm.SubItems.Add(objFm.IsRenal);
                itm.SubItems.Add(objFm.IsHighFat);
                itm.SubItems.Add(objFm.IsLowFat);
                itm.SubItems.Add(objFm.Price.ToString());
                lvwFoodItem.Items.Add(itm);
            }
        }

        private void SearchItemListView(IEnumerable<FoodMaster> tests, string searchString = "")
        {
            IEnumerable<FoodMaster> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.FoodName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwFoodItem.Items.Clear();
            foreach (FoodMaster objFm in query)
            {
                ListViewItem itm = new ListViewItem(objFm.FoodID);
                itm.SubItems.Add(objFm.FoodName);
                itm.SubItems.Add(objFm.CatID);
                itm.SubItems.Add(objFm.UnitId);
                itm.SubItems.Add(objFm.Remarks);
                itm.SubItems.Add(objFm.IsNormal);
                itm.SubItems.Add(objFm.IsDiabetic);
                itm.SubItems.Add(objFm.IsHighprotein);
                itm.SubItems.Add(objFm.IsLowProtein);
                itm.SubItems.Add(objFm.IsRenal);
                itm.SubItems.Add(objFm.IsHighFat);
                itm.SubItems.Add(objFm.IsLowFat);
                itm.SubItems.Add(objFm.Price.ToString());
                lvwFoodItem.Items.Add(itm);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            if (cboFoodCat.Text.ToString() != "--Select--" && cboFoodCat.Text.ToString() !="")
            {
                SearchListView(objfood, cboFoodCat.SelectedValue.ToString());
            }
        }
        #endregion
        private void SaveImage(string FoodIdName)
        {
            try
            {
                string filePathImage = save1.FileName + Utility.FoodPhotoPath + FoodIdName + ".JPEG";

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
                        FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        oImage.Save(filePathImage);
                    }
                }
                else
                {
                    File.Delete(filePathImage);
                    Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
                    FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    oImage.Save(filePathImage);
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

        private void cboFoodCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            open1.Multiselect = true;
            DialogResult result1 = open1.ShowDialog();
            open1.Filter = "allfiles|*";
            string ext1 = System.IO.Path.GetExtension(open1.FileName);
            if (result1 == DialogResult.OK)
            {
                if (FoodImage.Image == null || FoodImage.Image != null)
                {
                    FoodImage.Image = new Bitmap(open1.OpenFile());
                    FoodImage.Image = Utility.ScaleImage(FoodImage.Image, 220, 257);
                }
            }
            if (result1 == DialogResult.Cancel)
            {
                return;
            }

        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmFoodCategory frm = new frmFoodCategory();
            frm.ShowDialog();

        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cboFoodCat.ValueMember = "key";
                cboFoodCat.DisplayMember = "value";
                cboFoodCat.DataSource = new BindingSource(fnbs.GetFoodCategory(), null);
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

        private void txtFoodItem_KeyUp(object sender, KeyEventArgs e)
        {
            SearchItemListView(objfood, txtFoodItem.Text.ToString());
        }

        private void cboUnitId_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (e.KeyChar == (char)Keys.Return)
            {
                //cboFoodCat.Focus();
                txtFoodRate.Focus();
            }
        }

       
        #region "Upload Image"
        //private void btnUploadImage_Click(object sender, EventArgs e)
        //{
        //    open1.Multiselect = true;
        //    DialogResult result1 = open1.ShowDialog();
        //    open1.Filter = "allfiles|*";
        //    string ext1 = System.IO.Path.GetExtension(open1.FileName);
        //    if (result1 == DialogResult.OK)
        //    {
        //        if (pbImage.Image == null || pbImage.Image != null)
        //        {
        //            pbImage.Image = new Bitmap(open1.OpenFile());
        //            pbImage.Image = Utility.ScaleImage(pbImage.Image, 220, 257);
        //        }
        //    }
        //    if (result1 == DialogResult.Cancel)
        //    {
        //        return;
        //    }

        //}
        //private void SaveImage(string EmployeeIDNumber)
        //{
        //    string filePathImage = save1.FileName + Utility.EmployeePhotoPath + EmployeeIDNumber + ".JPEG";
        //    Stream buffer;
        //    if (open1.FileName == "")
        //    {
        //        return;
        //    }
        //    StreamReader srImage = new StreamReader(open1.FileName);

        //    buffer = srImage.BaseStream;
        //    Bitmap bmImage = new Bitmap(buffer);

        //    if (File.Exists(filePathImage))
        //    {
        //        DialogResult msg = MessageBox.Show("Same file name already exists,Do u want to update?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (msg == DialogResult.Yes)
        //        {
        //            File.Delete(filePathImage);
        //            Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
        //            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //            oImage.Save(filePathImage);
        //        }
        //    }
        //    else
        //    {
        //        File.Delete(filePathImage);
        //        Bitmap oImage = new Bitmap(bmImage, new Size(220, 257));
        //        pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //        oImage.Save(filePathImage);
        //    }

        //}
        #endregion

















    }
}
