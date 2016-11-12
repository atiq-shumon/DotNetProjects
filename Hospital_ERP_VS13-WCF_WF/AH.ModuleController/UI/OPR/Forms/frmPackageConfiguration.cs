using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;
using System.Globalization;


namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmPackageConfiguration : AH.Shared.UI.frmSmartFormStandard
    {
        private int intpos { get; set; }
        List<PackageItem> objPack;
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmPackageConfiguration()
        {
            InitializeComponent();
            this.GotFocus += new EventHandler(Sub_GotFocus);
        }

        private void Sub_GotFocus(object sender, EventArgs e)
        {
            MessageBox.Show("'" + this.Text + "' got focus");
        }

        #region "Format Grid"
        private void FormatGrid()
        {
            lvwPackageConfig.CheckBoxes = true;
            lvwPackageConfig.Columns.Add("Item Code", 260, HorizontalAlignment.Left);
            lvwPackageConfig.Columns.Add("Package Item Name", 300, HorizontalAlignment.Left);
            lvwPackageConfig.Columns.Add("Item rate", 290, HorizontalAlignment.Left);

            lvwpackageList.CheckBoxes = false;
            lvwpackageList.Columns.Add("Package Code", 200, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("Package Name", 150, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("Net Amount", 130, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("oprtype", 0, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("Bedtype", 0, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("bedstatus", 0, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("fromdate", 0, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("toate", 0, HorizontalAlignment.Left);
            lvwpackageList.Columns.Add("Unit", 0, HorizontalAlignment.Left);

        }
        #endregion 
        #region "CalculateTotal"
        private void Calculatetotal()
        {
            double dblAmount=0;
            for (int i = 0; i < lvwPackageConfig.Items.Count ; i++)
            {
                if (lvwPackageConfig.Items[i].Checked == true)
                {
                    dblAmount = dblAmount + Convert.ToDouble(lvwPackageConfig.Items[i].SubItems[2].Text);
                }
            }
            txtNetAmount.Text = dblAmount.ToString();
        }
        #endregion 
        #region "Comment"
        //private void LoadListView()
        //{
        //    lvwPackageConfig.Items.Clear();
        //    try
        //    {
        //        //List<PackageItem> objPack = accmSc.GetPackageItem("PackageItemAll", "").ToList();
        //        objPack = accmSc.GetPackageItem("PackageItemAll", "").ToList();

        //        foreach (PackageItem pack in objPack)
        //        {
        //            ListViewItem itm = new ListViewItem(pack.ItemNo);
        //            itm.SubItems.Add(pack.ItemName);
        //            itm.SubItems.Add(pack.ItemRate.ToString());
        //            lvwPackageConfig.Items.Add(itm);
        //        }
        //    }

        //    catch (System.ServiceModel.CommunicationException commp)
        //    {
        //        MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}
        #endregion 
        #region "Loadd List View"
        private void LoadPackageListView()
        {
            lvwpackageList.Items.Clear();
            try
            {
                List<PackageItem> objPack = accmSc.GetPackage("PackageMasterAll", "").ToList();
                foreach (PackageItem pack in objPack)
                {
                    ListViewItem itm = new ListViewItem(pack.PackageItemNo);
                    itm.SubItems.Add(pack.ItemName.ToString());
                    itm.SubItems.Add(pack.NetAmount.ToString());
                    itm.SubItems.Add(pack.Oprtype.ToString());
                    itm.SubItems.Add(pack.Bedtype.ToString());
                    itm.SubItems.Add(pack.Bedstatus.ToString());
                    itm.SubItems.Add(pack.fromdate.ToString());
                    itm.SubItems.Add(pack.todate.ToString());
                    itm.SubItems.Add(pack.unitID.ToString());
                    lvwpackageList.Items.Add(itm);
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
        private void LoadBedtype()
        {
            try
            {
                cboBedType.ValueMember = "Key";
                cboBedType.DisplayMember = "Value";
                cboBedType.DataSource = new BindingSource(accmSc.Getbedconfig("Bedtype"), null);
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
        #region  "Operation Type"
        private void LoadOperationtype()
        {
            try
            {
                cboOperationType.ValueMember = "Key";
                cboOperationType.DisplayMember = "Value";
                cboOperationType.DataSource = new BindingSource(accmSc.GetOperationType("D"), null);
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
        #region "Load"
        private void frmPackageConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                cboUnitName.DisplayMember = "UnitTitle";
                cboUnitName.ValueMember = "UnitId";
                cboUnitName.DataSource = accmSc.GetUnits().ToList();

                cboSubMenu.DisplayMember = "ItemName";
                cboSubMenu.ValueMember = "ItemNo";
               // cboSubMenu.DataSource = accmSc.GetPackageItemConfig().ToList();
                cboSubMenu.DataSource = new BindingSource(accmSc.GetPackageItemConfig(), null);


                FormatGrid();
                //LoadListView();
                LoadPackageListView();
                LoadBedtype();
                LoadOperationtype();
                txtPre.Select();
                txtPre.Focus();
                
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
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtPackageName","txtPre" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }
        #region "Populate"
        private PackageItem PopulatePackage(int i = 0, string strParentNo="")
        {
            int k=0;
            if (radWithoutBed.Checked == true)
                k = 1;
            PackageItem package = new PackageItem();
            package.PackageItemNo = strParentNo.ToString();
            package.ItemName = txtPackageName.Text.ToString();
            if (txtNetAmount.Text.ToString() != "")
            {
                package.NetAmount = Convert.ToDouble(txtNetAmount.Text.ToString());
            }
            else
            {
                package.NetAmount = 0;
            }
            if (cboOperationType.Text.ToString() != "")
            {
                package.Oprtype = cboOperationType.SelectedValue.ToString();
            }
            else
            {
                package.Oprtype = "";
            }
            if (cboBedType.Enabled)
            {
                if (cboBedType.SelectedValue.ToString() != "Select")
                {
                    package.Bedtype = cboBedType.SelectedValue.ToString();
                }
                else
                {
                    package.Bedtype = "";
                }
            }

            package.Bedstatus  =Convert.ToInt16(k.ToString());
            if (mskFromdate.Text.ToString() != "  /  /")
            {
                package.fromdate = mskFromdate.Text.ToString();
            }
            else
            {
                package.fromdate = "";
            }
            if (mskTodate.Text.ToString() != "  /  /")
            {
                package.todate = mskTodate.Text.ToString();
            }
            else
            {
                package.todate = "";
            }

            package.unitID = cboUnitName.SelectedValue.ToString();
            package.unitName = txtPre.Text;


            package.ItemNo = lvwPackageConfig.Items[i].SubItems[0].Text;
            package.ItemRate  = Convert.ToDouble(lvwPackageConfig.Items[i].SubItems[2].Text.ToString());
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            package.EntryParameter = ep;
            return package;
        }
        #endregion
        private void lvwPackageConfig_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Calculatetotal();
        }
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            short K=0;
            if (ValidateFields() == false)
            {
                return;
            }

            if (Utility.IsDuplicateFoundInList(lvwPackageConfig, 1, txtPackageName.Text) == true)
            {
                MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    PackageItem package = this.PopulatePackage();
                    //string  i = accmSc.SavedPackageMaster(package);
                    string strParentNo = accmSc.SavedPackageMaster(package);
                    if (strParentNo == "")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (strParentNo != "")
                    {

                        for (int j = 0; j < lvwPackageConfig.Items.Count; j++)
                        {
                            if (lvwPackageConfig.Items[j].Checked == true)
                            {
                                PackageItem packageChild = this.PopulatePackage(j, strParentNo);
                                K = accmSc.SavedPackageChild(packageChild);
                            }
                        }
                        if (K == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                           // MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtPackageName.Focus();
                            LoadPackageListView();
                            radWithoutBed.Checked = true;
                            cboUnitName.Enabled = true;
                            Clear();
                        }

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
        private void lvwpackageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwpackageList.SelectedItems.Count > 0)
            {
                Clear();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwpackageList.SelectedItems[0];
                string strPrefix = "";
                strPrefix = itm.SubItems[0].Text.Substring(itm.SubItems[0].Text.LastIndexOf("-") + 1);

                int intlen = itm.SubItems[0].Text.ToString().Length;
                //strPrefix = itm.SubItems[0].Text.ToString().Length.ToString().Substring(itm.SubItems[0].Text.ToString().Length.LastIndexOf("~") + 1).ToString();
                strPrefix = itm.SubItems[0].Text.ToString().Substring(0, intlen- (strPrefix.Length+1));
                txtPre.Text = strPrefix;
                txtPre.ReadOnly = true;

                txtPackageCode.Text = itm.SubItems[0].Text;
                txtPackageName.Text = itm.SubItems[1].Text;
                cboOperationType.SelectedValue = itm.SubItems[3].Text;
                
                if (Convert.ToInt16(itm.SubItems[5].Text) == 1)
                {
                    radWithoutBed.Checked = true;
                }
                if (Convert.ToInt16(itm.SubItems[5].Text) == 0)
                {
                    radwithBed.Checked = true;
                }


                cboBedType.SelectedValue = itm.SubItems[4].Text;
                if (itm.SubItems[6].Text.ToString() != "")
                {
                    DateTime dtefromDate = Convert.ToDateTime(itm.SubItems[6].Text.ToString());
                    mskFromdate.Text = dtefromDate.ToString("dd/MM/yyyy");
                }
                if (itm.SubItems[7].Text.ToString() != "")
                {
                    //string strToDate = itm.SubItems[7].Text.ToString();
                    DateTime dteToDate = Convert.ToDateTime(itm.SubItems[7].Text.ToString());
                    mskTodate.Text = dteToDate.ToString("dd/MM/yyyy");
                }
                int i = 0;
                lvwPackageConfig.Items.Clear();
                List<PackageItem> objPack = accmSc.DisplayPackage("Displaypackage", txtPackageCode.Text).ToList();
                foreach (PackageItem pack in objPack)
                {
                    ListViewItem itm1 = new ListViewItem(pack.ItemNo);
                    itm1.SubItems.Add(pack.ItemName);
                    itm1.SubItems.Add(pack.NetAmount.ToString());
                    lvwPackageConfig.Items.Add(itm1);
                    //for (int i = 0; i < lvwPackageConfig.Items.Count; i++)
                    //{
                    //    if (pack.ItemNo.ToString() == lvwPackageConfig.Items[i].Text)
                    //    {
                    lvwPackageConfig.Items[i].Checked = true;
                    //    }
                    //}
                    i = i + 1;
                  
                }

                cboUnitName.SelectedValue = itm.SubItems[8].Text;
                cboUnitName.Enabled = false ;
                //this.lvwPackageConfig.Items[0].Selected = false;
                txtPackageName.Focus();
                txtPackageName.Select();
            }
        }
        #region "Clear"
        private void ClearlistviewCheck()
        {
            for (int i = 0; i < lvwPackageConfig.Items.Count; i++)
            {
               lvwPackageConfig.Items[i].Checked = false ;
             
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            //ClearlistviewCheck();
            lvwPackageConfig.Items.Clear();
            PanelChangeAmount.Visible = false;
            cboUnitName.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtPre.ReadOnly = false;
            txtPre.Focus();
        }
        private void Clear()
        {
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            //for (int i = 0; i < lvwPackageConfig.Items.Count; i++)
            //{
            //        lvwPackageConfig.Items[i].Checked = false;
                
            //}
            lvwPackageConfig.Items.Clear();
                  
        }
        #endregion
        #region  "Edit"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            short K = 0;
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                //if (Utility.IsDuplicateFoundInList(lvwPackageConfig, 1, txtPackageName.Text) == true)
                //{
                //    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                //    return;
                //}
                try
                {
                    var strResponse = MessageBox.Show("Do You Want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {

                        PackageItem package = this.PopulatePackage(0, txtPackageCode.Text.ToString());
                        int i = accmSc.UpdatePackageMaster(package);

                        if (i == 0)
                        {
                            MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i == 1)
                        {

                            for (int j = 0; j < lvwPackageConfig.Items.Count; j++)
                            {
                                if (lvwPackageConfig.Items[j].Checked == true)
                                {
                                    PackageItem packageChild = this.PopulatePackage(j, txtPackageCode.Text.ToString());
                                    K = accmSc.UpdatePackageChild(packageChild);
                                }
                            }
                            if (K == 0)
                            {
                                MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnNew.PerformClick();
                                txtPackageName.Focus();
                                LoadPackageListView();
                                cboUnitName.Enabled = true;
                                radWithoutBed.Checked = true;
                                txtPre.ReadOnly = false;
                                Clear();
                            }

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
        #region "Selectedchanged"
        private void lvwPackageConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvwPackageConfig.SelectedItems.Count > 0)
            //{
            //    PanelChangeAmount.Visible = true;
            //    intpos = Convert.ToInt16(lvwPackageConfig.FocusedItem.Index);
            //    txtChangeAmount.Text = lvwPackageConfig.Items[intpos].SubItems[2].Text;
            //    txtChangeAmount.ReadOnly = false;
            //    txtChangeAmount.Focus();
            //}
        }
        #endregion 
        #region  "Keypress"
        private void txtChangeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                lvwPackageConfig.Items[intpos].SubItems[2].Text = txtChangeAmount.Text.ToString();
                lvwPackageConfig.Items[intpos].SubItems[2].BackColor = Color.Pink;
                lvwPackageConfig.Items[intpos].SubItems[1].BackColor = Color.Pink;
                lvwPackageConfig.Items[intpos].SubItems[0].BackColor = Color.Pink;
                lvwPackageConfig.Items[intpos].Checked = true;
                PanelChangeAmount.Visible = false;
                Calculatetotal();
            }
        }
        #endregion
        #region "Changed"
        private void radWithoutBed_CheckedChanged(object sender, EventArgs e)
        {
            cboBedType.Enabled = false;
            cboBedType.Text = "";
        }
        #endregion
        #region "CheckgedCahanged"
        private void radwithBed_CheckedChanged(object sender, EventArgs e)
        {
            cboBedType.Enabled = true;
            cboBedType.Text = "";
        }
        #endregion
        private void SearchListView(IEnumerable<PackageItem> tests, string searchString = "")
        {
            IEnumerable<PackageItem> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.ItemName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }
            lvwPackageConfig.Items.Clear();
            foreach (PackageItem pack in query)
            {
                ListViewItem itm = new ListViewItem(pack.ItemNo);
                itm.SubItems.Add(pack.ItemName);
                itm.SubItems.Add(pack.ItemRate.ToString());
                //itm.SubItems.Add(dt.TestGroup.GroupId);
                //itm.SubItems.Add(dt.TestMainID);
                lvwPackageConfig.Items.Add(itm);
            }
        }
        #region  "Keypress"

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(objPack, txtSearch.Text);
        }

        private void txtPackageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)(Keys.Return))
            {
                cboOperationType.Focus();
            }
        }

        //private void txtNoofDays_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)(Keys.Return))
        //    {
        //        int  intNoofDays = Convert.ToInt16(txtNoofDays.Value);
        //        DateTime dteToDate = Convert.ToDateTime(mskFromdate.Text);
        //        DateTime dteToDate1 = dteToDate.AddDays(intNoofDays);
        //        mskTodate.Text = dteToDate1.ToString("dd/MM/yyyy");
        //        mskTodate.Focus();
        //    }
        //}

      
        private void cboBedType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                mskFromdate.Focus();
            }
        }

        private void cboOperationType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                if (cboUnitName.Enabled)
                {
                    cboUnitName.Focus();
                }
                else
                {
                    if (cboBedType.Enabled)
                    {
                        cboBedType.Focus();
                    }
                    else
                    {
                        mskFromdate.Focus();
                    }

                }

            }
        }

        private void mskFromdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                mskTodate.Focus();
            }
        }

        private void mskTodate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                cboSubMenu.Focus();
            }
        }

      
      
        private void cboOperationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                frmOperationType frm = new frmOperationType();
                frm.ShowDialog();
                LoadOperationtype();
            }

        }
        #endregion
        #region  "Click"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboSubMenu.Text == "--Select--" || cboSubMenu.Text == "")
            {
                MessageBox.Show("Cannot Empty");
                cboSubMenu.Focus();
                return;
            }
            if (txtRate.Text == ""  && txtRate.Text =="0")
            {
                MessageBox.Show("Cannot Empty");
                txtRate.Focus();
                return;
            }
            mAdditem(cboSubMenu.Text, cboSubMenu.SelectedValue.ToString(), Convert.ToDouble(txtRate.Text));
            txtRate.Text = "";
            cboSubMenu.Text = "--Select--";
            cboSubMenu.Focus();
        }


        private void mAdditem(string strSubMenuName, string strMenuCode,double dnlRate)
        {
            string strDown = "";
            Boolean blngCheck = false;
            for (int j = 0; j < lvwPackageConfig.Items.Count; j++)
            {

                strDown = lvwPackageConfig.Items[j].SubItems[1].Text;
                
                if (strSubMenuName == strDown.ToString())
                {
                    blngCheck = true;
                }

            }
            if (blngCheck == false)
            {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = strMenuCode;
                    lvi.SubItems.Add(strSubMenuName);
                    lvi.SubItems.Add(dnlRate.ToString());
                    lvwPackageConfig.Items.Add(lvi);
               // txtNetTotal.Text = intTotal.ToString();
            }
            for (int j = 0; j < lvwPackageConfig.Items.Count; j++)
            {
                lvwPackageConfig.Items[j].Checked = true;
            }

        }

        private void cboUnitName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                if (cboBedType.Enabled)
                {
                    cboBedType.Focus();
                }
                else
                {
                    mskFromdate.Focus();
                }
            }
        }

        private void cboSubMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                txtRate.Focus();
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Return))
            {
                
                btnAdd.Focus();
            }
        }
        #endregion

      


        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo txt = new CultureInfo("en-US", false).TextInfo;
            //return txt.ToUpper(text.ToUpper());
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            // Return char and concat substring.
           // return char.ToUpper(text[0]) + text.Substring(1);
            return txt.ToUpper(text.ToUpper());
        }

        private void txtPre_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == (char)(Keys.Return))
            {
                txtPackageName.Focus();
            }
        }

        private void txtPre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPre_TextChanged(object sender, EventArgs e)
        {
            int x = txtPre.SelectionStart;
            txtPre.Text = ConvertTo_ProperCase(txtPre.Text);
            txtPre.SelectionStart = x;
        }

        private void lvwPackageConfig_DoubleClick(object sender, EventArgs e)
        {
            if (lvwPackageConfig.SelectedItems.Count > 0)
            {
                PanelChangeAmount.Visible = true;
                intpos = Convert.ToInt16(lvwPackageConfig.FocusedItem.Index);
                txtChangeAmount.Text = lvwPackageConfig.Items[intpos].SubItems[2].Text;
                lvwPackageConfig.Items[intpos].Checked = true;
                txtChangeAmount.ReadOnly = false;
                txtChangeAmount.Focus();
            }
        }

       

       

    






    }
}
