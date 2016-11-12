using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.ModuleController.ATMSSR;
using AH.DUtility;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmTreeview : AH.Shared.UI.frmSmartFormStandard
    {
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();
        List<MaterialReceipt> objReceip;
        private const string mcGROUP_PREFIX = "G_";
        private const string mcLEDGER_PREFIX = "L_";
        public frmTreeview()
        {
            InitializeComponent();
        }
        private void getgrouptree()
        {
            
            string strGroup;
            //string strGroupId;
            //dr = DAL.Getgrouptree();
            System.Windows.Forms.TreeNode oNodex = null;
            this.tvwAssets.Nodes.Clear();
            oNodex = tvwAssets.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            oNodex.Expand();
            List<AssetsGroup> objGrp = atms.GetAssetsGroupTree().ToList();
            foreach (AssetsGroup grps in objGrp)
            {
                strGroup = grps.GroupName.ToString();
                oNodex.Expand();
               // oNodex = tvwAssets.Nodes.Find(mcGROUP_PREFIX + grps.GroupID.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strGroup, "closed");
                oNodex = tvwAssets.Nodes.Find(mcGROUP_PREFIX + "Assets", true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strGroup, "closed");
                mAddItem(grps.GroupID, strGroup);
            }
        }
        private void mAddItem(string vstrRoot, string vstrRoot1)
        {
            string strGroup;
            System.Windows.Forms.TreeNode oNodex = null;
            List<Brand> objbra = atms.GeBrandTree("Brand",vstrRoot).ToList();
            foreach (Brand brnd in objbra)
            {
               // strGroup = dr["serial_no"].ToString() + "-" + dr["product_name"].ToString();
                strGroup =brnd.BrandID + " " +  brnd.BrandName;
                oNodex = tvwAssets.Nodes.Find(mcGROUP_PREFIX + vstrRoot1, true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strGroup, 2);
                oNodex.EnsureVisible();
            }
        }

        private void tvwAssets_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var relativeMousePosition = tvwAssets.PointToClient(Cursor.Position);
                //foreach (string ldr in objLedger)
                //{
                //    if (ldr.ToString() == tvwGroup.SelectedNode.Text)
                //    {
                //        MessageBox.Show("It is a Last Level");
                //        return;

                //    }
                //}
                this.menu.Show(tvwAssets, relativeMousePosition);

            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            //if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
            //{
                int index;
                TreeNode obj = new TreeNode();
                obj = tvwAssets.SelectedNode;
                index = tvwAssets.Nodes.IndexOf(obj);
                string str = string.Empty;
                str = index.ToString();

                frmGroup frm = new frmGroup();
                frm.strMode = "Add";
               // frm.strUnder = tvwAssets.SelectedNode.Text;
                //frm.strindex = tvwAssets.SelectedNode.Parent.Text.ToString();
                frm.ShowDialog();
                //GetGroupsTreeView();
            //}
        }
        private void SearchListView(IEnumerable<MaterialReceipt> tests, string searchString = "",int type=0)
        {
            IEnumerable<MaterialReceipt> query;
            if (type == 1)
            {
                if (!(searchString.Length > 0))
                {
                    query = tests;
                }
                else
                {
                    query = (from test in tests
                             where test.ProductName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);

                }
            }
            else if (type==2)
            {
                if (!(searchString.Length > 0))
                {
                    query = tests;
                }
                else
                {
                    query = (from test in tests
                             where test.SerialNo.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);

                }
            }
            else
            {
                if (!(searchString.Length > 0))
                {
                    query = tests;
                }
                else
                {
                    query = (from test in tests
                             where test.TagNo.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select test);

                }
            }
            lvwProcess.Items.Clear();
            foreach (MaterialReceipt Recipr in query)
            {
                ListViewItem item = new ListViewItem(Recipr.TagNo);
                item.Text = Recipr.TagNo;
                item.SubItems.Add(Recipr.ProductID);
                item.SubItems.Add(Recipr.ProductName);
                item.SubItems.Add(Recipr.brandCode);
                item.SubItems.Add(Recipr.brandName);
                item.SubItems.Add(Recipr.ModelId);
                item.SubItems.Add(Recipr.ModelName);
                item.SubItems.Add(Recipr.WarrentyDate);

                item.SubItems.Add(Recipr.supplierCode);
                item.SubItems.Add(Recipr.supplierName);
                item.SubItems.Add(Recipr.ChallanNo);
                item.SubItems.Add(Recipr.ChallanDate);
                item.SubItems.Add(Recipr.agiaintRefNo);
                item.SubItems.Add(Recipr.againstDate);
                item.SubItems.Add(Recipr.SerialNo);
                item.SubItems.Add(Recipr.GroupCode);
                item.SubItems.Add(Recipr.UnitID);
                lvwProcess.Items.Add(item);
            }
           
        }

        private void frmTreeview_Load(object sender, EventArgs e)
        {
            getgrouptree();
            format();
        }

        private void mnuBrandAdd_Click(object sender, EventArgs e)
        {
          
            if ((tvwAssets.SelectedNode.Text != "Assets"))
            {
                int index;
                TreeNode obj = new TreeNode();
                obj = tvwAssets.SelectedNode;
                index = tvwAssets.Nodes.IndexOf(obj);
                string str = string.Empty;
                str = index.ToString();

                frmBrand frm = new frmBrand();
                frm.strMode = "Add";
                frm.strUnder = tvwAssets.SelectedNode.Text;
                frm.strindex = tvwAssets.SelectedNode.Parent.Text.ToString();
                frm.ShowDialog();
                //GetGroupsTreeView();
            }
            
        }
        private void DisplayBrandDetails(string strBrandID)
        {
             objReceip = atms.DisplayBrandDetails("DispalyBrandDetails", strBrandID).ToList();
            foreach (MaterialReceipt Recipr in objReceip )
            {
                ListViewItem item = new ListViewItem();
                item.Text = Recipr.TagNo;
                item.SubItems.Add(Recipr.ProductID);
                item.SubItems.Add(Recipr.ProductName);
                item.SubItems.Add(Recipr.brandCode);
                item.SubItems.Add(Recipr.brandName);
                item.SubItems.Add(Recipr.ModelId );
                item.SubItems.Add(Recipr.ModelName);
                item.SubItems.Add(Recipr.WarrentyDate);
                
                item.SubItems.Add(Recipr.supplierCode);
                item.SubItems.Add(Recipr.supplierName);
                item.SubItems.Add(Recipr.ChallanNo);
                item.SubItems.Add(Recipr.ChallanDate);
                item.SubItems.Add(Recipr.agiaintRefNo);
                item.SubItems.Add(Recipr.againstDate);
                item.SubItems.Add(Recipr.SerialNo);
                item.SubItems.Add(Recipr.GroupCode);
                item.SubItems.Add(Recipr.UnitID);

                lvwProcess.Items.Add(item);
            }
        }

        private void tvwAssets_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwAssets.SelectedNode.Text != "Assets")
            {
                string strNode = tvwAssets.SelectedNode.Text.ToString();
                string strBrand = strNode.ToString().Substring(0, 4);
                lvwProcess.Items.Clear();
                mClear();
                DisplayBrandDetails(strBrand);
            }
        }

        private void format()
        {
            lvwProcess.Clear();
            lvwProcess.Columns.Add("Tag#", 150, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Product Code", 0, HorizontalAlignment.Left );
            lvwProcess.Columns.Add("Product Name", 200, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Brand code", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Brand Name", 200, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Model ID", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Model Name", 200, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Warrenty Date", 150, HorizontalAlignment.Left);

            lvwProcess.Columns.Add("Supplier Id", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Supplier Name", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Challan No", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Challan Date", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Ref No", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Ref Date", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Sl No", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("Group No", 0, HorizontalAlignment.Left);
            lvwProcess.Columns.Add("unit", 0, HorizontalAlignment.Left);

        }
        private ProcessGenerated Process()
        {
            ProcessGenerated objProcess = new ProcessGenerated();
            objProcess.FormName = "Process Generated";
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objProcess.EntryParameter = ep;
            return objProcess;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessGenerated objPro = Process();
            short i = atms.ProcessGenerated(objPro);
            if (i==1)
            {
                MessageBox.Show ("Generation Successfully");
            }
        }

        private void lvwProcess_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var relativeMousePosition = lvwProcess.PointToClient(Cursor.Position);
                this.mnuAssetsPopup.Show(lvwProcess, relativeMousePosition);
            }
        }

        private void mnuAssetsInformation_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwProcess.SelectedItems[0];
                frmAssetsInformation frm = new frmAssetsInformation();
                frm.strTagNo = itm.SubItems[0].Text;
                frm.strModelNo = itm.SubItems[5].Text;
                frm.strModelName  = itm.SubItems[6].Text;
                frm.strWarrentyDate = itm.SubItems[7].Text;
                frm.strsupplierCode  = itm.SubItems[8].Text;
                frm.strsupplierName  = itm.SubItems[9].Text;
                frm.strChallanNo  = itm.SubItems[10].Text;
                frm.strChallanDate  = itm.SubItems[11].Text;
                frm.strInventoryRef = itm.SubItems[12].Text;
                frm.strInventoryDate = itm.SubItems[13].Text;
                frm.strSerialNo  = itm.SubItems[14].Text;
                frm.strProductcode = itm.SubItems[1].Text;
                frm.ShowDialog();

            }
           
        }
        private void mClear()
        {
            txtTagNo.Text  = "";
            txtMobileNo.Text  = "";
            txtModelName.Text  = "";
            txtColor.Text = "";
            txtCondition.Text = "";
            txtManufacturerName.Text = "";
            txtSereviceProviderName.Text = "";
            txtContactPerson.Text = "";
            txtMobileNo.Text = "";
            txtWarrentyDate.Text = "";
            txtSupplierName.Text  = "";
            txtchallanNo.Text  = "";
            txtChallanadte.Text = "";
            txtInvMrr.Text = "";
            txtInvDate.Text  = "";
            txtSerialNo.Text = "";
            DG.Rows.Clear();
            
        }
        private void lvwProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            mClear();
            if (lvwProcess.SelectedItems.Count > 0)
            {
              
                ListViewItem itm = lvwProcess.SelectedItems[0];
                txtTagNo.Text  = itm.SubItems[0].Text;
                txtMobileNo.Text  = itm.SubItems[5].Text;
                txtModelName.Text  = itm.SubItems[6].Text;
                txtWarrentyDate.Text = itm.SubItems[7].Text;
                txtSupplierName.Text  = itm.SubItems[9].Text;
                txtchallanNo.Text  = itm.SubItems[10].Text;
                txtChallanadte.Text = itm.SubItems[11].Text;
                txtInvMrr.Text = itm.SubItems[12].Text;
                txtInvDate.Text  = itm.SubItems[13].Text;
                txtSerialNo.Text = itm.SubItems[14].Text;
                
                List<AdditionalInformation> objadd = atms.DisplayAddInformation("DispalyAddinfo", txtTagNo.Text).ToList();
                int i = objadd.Count();
                int j = 0 ;
                if (i > 0)
                {
                    DG.Rows.Add(i);
                    foreach (AdditionalInformation add in objadd)
                    {
                        txtColor.Text = add.color;
                        txtCondition.Text = add.condition;
                        txtManufacturerName.Text = add.manufacturername;
                        txtSereviceProviderName.Text = add.serviceprovidername;
                        txtContactPerson.Text = add.contactperson;
                        txtMobileNo.Text = add.mobileno;
                        DG.Rows[j].Cells[0].Value = add.componentname;
                        DG.Rows[j].Cells[1].Value = add.description;
                        DG.Rows[j].Cells[2].Value = add.notes;
                        j = j + 1;
                    }
                }

                string appPath = "C:" + @"\Assetsmages\" + txtTagNo.Text + ".Jpg";
                FileInfo info1 = new FileInfo(appPath);
                if (info1.Exists)
                {

                    pictureBox1.Image = new Bitmap(appPath);
                    pictureBox1.Image = ScaleImage(pictureBox1.Image, 216, 257);
                }
                else
                {
                    pictureBox1.Image = null;
                    //string appPath1 = "D:" + @"\Assetsmages\Inven2.Jpg";
                    //pictureBox1.Image = new Bitmap(appPath1);
                    //pictureBox1.Image = ScaleImage(pictureBox1.Image, 216, 257);
                }


            }
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(objReceip, txtProductName.Text,1);
        }

        private void txtSlNo_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(objReceip, txtSlNo.Text,2);
        }

        private void txtTagSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(objReceip, txtTagSearch.Text, 3);
        }

        private void mnuIssue_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwProcess.SelectedItems[0];
                frmIssue frm = new frmIssue();
                frm.strTagNo = itm.SubItems[0].Text;
                frm.strProductCode = itm.SubItems[1].Text;
                frm.strProductName = itm.SubItems[2].Text;
                frm.strBrandCode  = itm.SubItems[3].Text;
                frm.strModelCode  = itm.SubItems[5].Text;
                frm.strGroupCode = itm.SubItems[15].Text;
                frm.strUnitCode  = itm.SubItems[16].Text;
                frm.strSlCode = itm.SubItems[14].Text;
                frm.intVtype = 33;
                frm.ShowDialog();
            }
        
        }
        private void mnuDamage_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwProcess.SelectedItems[0];
                frmVoucher frm = new frmVoucher();
                frm.strTagNo = itm.SubItems[0].Text;
                frm.strProductCode = itm.SubItems[1].Text;
                frm.strProductName = itm.SubItems[2].Text;
                frm.strBrandCode = itm.SubItems[3].Text;
                frm.strModelCode = itm.SubItems[5].Text;
                frm.strGroupCode = itm.SubItems[15].Text;
                frm.strUnitCode = itm.SubItems[16].Text;
                frm.strSlCode = itm.SubItems[14].Text;
                frm.intVtype = 34;
                frm.ShowDialog();
            }
        }
        private void mnuWarrentyService_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwProcess.SelectedItems[0];
                frmWarrentyService frm = new frmWarrentyService();
                frm.strTagNo = itm.SubItems[0].Text; ;
                frm.strProductCode = itm.SubItems[1].Text;
                frm.strProductName = itm.SubItems[2].Text;
                frm.ShowDialog();
            }
        }

        private void mnuReturn_Click(object sender, EventArgs e)
        {
            if (lvwProcess.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwProcess.SelectedItems[0];
                frmVoucher frm = new frmVoucher();
                frm.strTagNo = itm.SubItems[0].Text;
                frm.strProductCode = itm.SubItems[1].Text;
                frm.strProductName = itm.SubItems[2].Text;
                frm.strBrandCode = itm.SubItems[3].Text;
                frm.strModelCode = itm.SubItems[5].Text;
                frm.strGroupCode = itm.SubItems[15].Text;
                frm.strUnitCode = itm.SubItems[16].Text;
                frm.strSlCode = itm.SubItems[14].Text;
                frm.intVtype = 32;
                frm.ShowDialog();
            }
        }

        private void mnuAssetsEdit_Click(object sender, EventArgs e)
        {
            frmAssetsEdit frm = new frmAssetsEdit();
            frm.ShowDialog();
        }

        private void mnuImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Assetsmages\";

            string appPath = "C:" + @"\Assetsmages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //string iName = opFile.SafeFileName;
                    string iName = txtTagNo.Text + ".Jpg";
                    string filepath = opFile.FileName;
                    FileInfo info1 = new FileInfo(appPath + iName);
                    if (!info1.Exists)
                    {
                        //info1.Delete();
                        File.Copy(filepath, appPath + iName, true);
                        //pictureBox1.Image = ScaleImage(pictureBox1.Image, 216, 257);
                        pictureBox1.Image = new Bitmap(opFile.OpenFile());
                        pictureBox1.Image = ScaleImage(pictureBox1.Image, 216, 257);
                    }
                    //else
                    //{
                    //    //File.Copy(filepath, appPath + iName, true);
                    //    pictureBox1.Image = ScaleImage(pictureBox1.Image, 216, 257);
                    //    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                    //}
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        //private void DeleteImageDirectory(string Path)
        //{
        //    for (int attempts = 0; attempts < 5; attempts++)
        //    {
        //        try
        //        {
        //            if (Directory.Exists(Path))
        //            {
        //                System.GC.Collect();
        //                GC.WaitForPendingFinalizers();
        //                Directory.Delete(Path, true);
        //            }
        //            return;
        //        }
        //        catch (IOException ex)
        //        {
        //            GC.Collect();
        //            Thread.Sleep(500);
        //        }
        //    }
        //}

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
