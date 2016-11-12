using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
using AH.ModuleController.UI.ACCMS.Reports.ParameterForms;

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmFixedAssestsConfig : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmFixedAssestsConfig()
        {
            InitializeComponent();
        }
        #region "Load"
        private void frmFixedAssestsConfig_Load(object sender, EventArgs e)
        {
            try
            {
                //txtAssetsIdentiNo.Select();
                txtAssetsIdentiNo.Focus();
                GetFixedAssetsLedger();

                cboLocation.ValueMember = "Locationcode";
                cboLocation.DisplayMember = "LocationName";
                cboLocation.DataSource = accmSc.GetLocation().ToList();

                cboLocalAgent.ValueMember = "supplierCode";
                cboLocalAgent.DisplayMember = "SupplierName";
                cboLocalAgent.DataSource = accmSc.Getsupplier().ToList();

                cboManufacturerName.ValueMember = "Key";
                cboManufacturerName.DisplayMember = "Value";
                cboManufacturerName.DataSource = new BindingSource(accmSc.GetManufacturerName(), null);

                //cboManufacturerName.DataSource = new BindingSource(accmSc.GetManufacturerName(), null);
                //cboManufacturerName.ValueMember = "Key";
                //cboManufacturerName.DisplayMember = "Value";

                FormatGrid();
                LoadListView();
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
        #region "Validation"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtPurchaseAmount" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboAssestsName.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboAssestsName.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboAssestsName.Focus();
                return false;
            }
            if (cboDepMethod.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboDepMethod.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDepMethod.Focus();
                return false;
            }
            if (dteDepEffectiveMethod.Text == "  /  /")
            {
                MessageBox.Show(Utility.getFMS(dteDepEffectiveMethod.Name) + Utility.Req, "Cannot Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteDepEffectiveMethod.Focus();
                return false;
            }

            if (cboLocalAgent.Text == "--Select--")
            {
                MessageBox.Show(Utility.getFMS(cboLocalAgent.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLocalAgent.Focus();
                return false;
            }

            if (cboLocation.Text == "--Select--")
            {
                MessageBox.Show(Utility.getFMS(cboLocation.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLocation.Focus();
                return false;
            }

            if (txtAssetsIdentiNo.Text == "")
            {
                MessageBox.Show(Utility.getFMS(txtAssetsIdentiNo.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAssetsIdentiNo.Focus();
                return false;
            }
            if (cboLocation.Text == "--Select--")
            {
                MessageBox.Show(Utility.getFMS(cboLocation.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLocation.Focus();
                return false;
            }


            return true;
        }
        #endregion
        #region "PopulatedFixedAssets"
        private FixedAssets  PopulateFixedAssets()
        {
            int intDepMethod = 0;
            FixedAssets objFixed = new FixedAssets();
            if (txtSerialNo.Text.ToString() != "")
            {
                objFixed.SerialNo = Convert.ToInt64(txtSerialNo.Text.ToString());
            }
            else
            {
                objFixed.SerialNo = 0;
            }
            objFixed.ManufactureDate = dteManufacturer.Text;
            objFixed.Locationcode = cboLocation.SelectedValue.ToString();
            objFixed.supplierCode = cboLocalAgent.SelectedValue.ToString();
            objFixed.dblPurchaseCost = Utility.val(txtPurchaseAmount.Text);
            objFixed.PurchaseDate = mskDateofpurchase.Text;
            if (cboDepMethod.Text.ToString() == "Reducing Balance")
            {
                intDepMethod = 1;
            }
            else
            {
                intDepMethod = 2;
            }
            objFixed.strLedgerCode = cboAssestsName.SelectedValue.ToString();
            objFixed.intDepMethod = intDepMethod;

            if  (txtDepRate.Text != "0")
            {
                objFixed.dblPercent = 1;
                objFixed.dblAssetsDepRate = Utility.val((txtDepRate.Text));
            }
            else
            {
                objFixed.dblPercent = 0;
                objFixed.dblAssetsDepRate = Utility.val((txtDepRate.Text));
            }
            
            if (txtAssetsLife.Text.ToString() != "")
            {
                objFixed.dblAssetsLife = Convert.ToDouble(txtAssetsLife.Text.ToString());
            }

            objFixed.dteDepEffDate =  dteDepEffectiveMethod.Text;
            objFixed.dblAssetsAccDep = Utility.val(txtAccumulatedDep.Text);
            objFixed.dblWrittenValue = Utility.val(txtWrittenValue.Text);
            objFixed.dblsalvageValue = Utility.val(txtSalvageValue.Text);

            if (cboManufacturerName.SelectedValue != "")
            {
                objFixed.ManufacturerCode = cboManufacturerName.SelectedValue.ToString();
            }
            else
            {
                objFixed.ManufacturerCode = "";
            }
            if (txtCountryofOrigin.Text != "")
            {
                objFixed.NameofOrigin = txtCountryofOrigin.Text;
            }
            else
            {
                objFixed.NameofOrigin = "";
            }
            if (txtAssetsIdentiNo.Text != "")
            {
                objFixed.AssetsIdenticode = txtAssetsIdentiNo.Text;
            }
            else
            {
                objFixed.AssetsIdenticode = "";
            }
            if (txtFloorNo.Text != "")
            {
                objFixed.FloorNo = txtFloorNo.Text;
            }
            else
            {
                objFixed.FloorNo = "";
            }
            if (txtModelNo.Text != "")
            {
                objFixed.ModelNo = txtModelNo.Text;
            }
            else
            {
                objFixed.ModelNo = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objFixed.EntryParameter = ep;
            return objFixed;
        }
        private void GetFixedAssetsLedger()
        {
            cboAssestsName.ValueMember = "strLedgerCode";
            cboAssestsName.DisplayMember = "strLedgerName";
            cboAssestsName.DataSource = accmSc.GetFixedAssetsLedger().ToList();
            //lstLedger.Items.Clear();
            //CboledgerName.Items.Clear();
            //List<FixedAssets> objldr = accmSc.GetFixedAssetsLedger().ToList();
            //foreach (FixedAssets ldr in objldr)
            //{
            //    CboledgerName.Items.Add(ldr.strLedgerName);
            //    lstLedger.Items.Add(ldr.strLedgerName);
            //}
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvwFixedAssetsDetails,20,txtAssetsIdentiNo.Text))
            {
                MessageBox.Show("Cannot Insert Duplicate Identification No");
                txtAssetsIdentiNo.Focus();
                return;
            }
            try
            {

                var strResponse = MessageBox.Show("Do You Want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    FixedAssets objAssets = this.PopulateFixedAssets();
                    short i = accmSc.SaveFixedAssetsSetup(objAssets);

                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        LoadListView();
                        txtPurchaseAmount.Text = "0";
                        txtDepRate.Text = "0";
                        txtAssetsLife.Text = "0";
                        txtAccumulatedDep.Text = "0";
                        txtWrittenValue.Text = "0";
                        txtSalvageValue.Text = "0";
                        cboAssestsName.Focus();
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
            if (txtAssetsIdentiNo.Text != txtIdentiNo1.Text)
            {
                if (Utility.IsDuplicateFoundInList(lvwFixedAssetsDetails, 20, txtAssetsIdentiNo.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Identification No");
                    txtAssetsIdentiNo.Focus();
                    return;
                }
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  Want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    FixedAssets objAssets = this.PopulateFixedAssets();
                    short i = accmSc.UpdateFixedAssetsSetup(objAssets);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        LoadListView();
                        txtPurchaseAmount.Text = "0";
                        txtDepRate.Text = "0";
                        txtAssetsLife.Text = "0";
                        txtAccumulatedDep.Text = "0";
                        txtWrittenValue.Text = "0";
                        txtSalvageValue.Text = "0";
                        cboAssestsName.Focus();
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
        #region "Listview"
        private void FormatGrid()
        {
            lvwFixedAssetsDetails.CheckBoxes = false;
            lvwFixedAssetsDetails.Columns.Add("SL No", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("LedgerCode", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Ledger Name", 200, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Manufacturer Date", 100, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Location ID", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Supplier ID", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Purchase Date", 100, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Purchase Cost", 150, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Effective Date", 100, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Dep. Method", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Assets Life", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Dep Rate",0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Accu. Dep.", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Written Value",100, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Percentage", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Salvage Value", 100, HorizontalAlignment.Left);

            lvwFixedAssetsDetails.Columns.Add("Manufacturer code", 0, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Manufacturer Name", 200, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Origin Name", 200, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Model No", 150, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Identification code", 200, HorizontalAlignment.Left);
            lvwFixedAssetsDetails.Columns.Add("Floor Name", 150, HorizontalAlignment.Left);

           
        }
        #endregion
        #region "Button"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //grpSerach.Visible = true;
            //txtLedger.Text = "";
            //lstLedger.ValueMember = "Key";
            //lstLedger.DisplayMember = "Value";
            //lstLedger.DataSource = new BindingSource(accmSc.GetGroups("D"), null);
            //txtLedger.Focus();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            //grpSerach.Visible = false;
        }
        #endregion
        #region "Keypress"
        //private void txtLedger_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Return)
        //    {
        //        if (lstLedger.Items.Count > 0)
        //        {
        //            if (lstLedger.SelectedIndex == -1)
        //            {
        //                txtLedger.Text = lstLedger.Items[0].ToString();
        //            }
        //            else
        //            {
        //                txtLedger.Text = lstLedger.Text;
        //            }
        //            CboledgerName.SelectedValue = txtLedger.Text;
        //            cboDepMethod.Focus();
        //            lstLedger.Visible = false;
        //            grpSerach.Visible = false;
        //        }
        //    }
        //}

        //private void txtLedger_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Up)
        //    {
        //        if (lstLedger.SelectedItem != null)
        //        {
        //            lstLedger.SelectedIndex = lstLedger.SelectedIndex - 1;
        //        }
        //    }
        //    if (e.KeyCode == Keys.Down)
        //    {
        //        if (lstLedger.Items.Count - 1 > lstLedger.SelectedIndex)
        //        {
        //            lstLedger.SelectedIndex = lstLedger.SelectedIndex + 1;
        //        }
        //    }
        //}

        //private void lstLedger_DoubleClick(object sender, EventArgs e)
        //{
        //    txtLedger.Text = lstLedger.Text;
        //    CboledgerName.SelectedValue = txtLedger.Text;
        //    lstLedger.Visible = false;
        //    grpSerach.Visible = false;
        //    cboDepMethod.Focus();
        //}

        //private void CboledgerName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == (Keys.Control | Keys.F))
        //    {
        //        grpSerach.Visible = true;
        //        txtLedger.Focus();
        //    }

        //    if (e.KeyData == (Keys.Control | Keys.Z))
        //    {
        //        frmTreeView frm = new frmTreeView();
        //        frm.ShowDialog();
        //        GetFixedAssetsLedger();
        //    }
        //}

        private void CboledgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtPurchaseAmount.Focus();
            }
        }

        private void cboDepMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dteDepEffectiveMethod.Focus();
            }
        }

        private void txtAssetsLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtWrittenValue.Focus();
            }
        }

        private void txtAccumulatedDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtWrittenValue.Text = (Convert.ToDouble(txtPurchaseAmount.Text) - Convert.ToDouble(txtAccumulatedDep.Text)).ToString();
                txtDepRate.Focus();
            }
        }

        private void txtSalvageValue_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPurchaseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtAccumulatedDep.Text=="")
                {
                    txtAccumulatedDep.Text = "0";
                }
                if (txtPurchaseAmount.Text == "")
                {
                    txtPurchaseAmount.Text = "0";
                }

                txtWrittenValue.Text = (Convert.ToDouble(txtPurchaseAmount.Text) - Convert.ToDouble(txtAccumulatedDep.Text)).ToString();
                txtAccumulatedDep.Focus();
            }
        }

        private void txtDepRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDepMethod.Focus();
            }
        }

      

        private void txtWrittenValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtSalvageValue.Focus();
            }
        }

        #endregion
        #region "Load"
        private void LoadListView()
        {
            lvwFixedAssetsDetails.Items.Clear();
            List<FixedAssets> fixedasset = accmSc.LoadFixedAssetsLedger().ToList();
            foreach (FixedAssets Fa in fixedasset)
            {
                ListViewItem itm = new ListViewItem(Fa.SerialNo.ToString());
                itm.SubItems.Add(Fa.strLedgerCode.ToString());
                itm.SubItems.Add(Fa.strLedgerName.ToString());
                itm.SubItems.Add(Fa.ManufactureDate.ToString());
                itm.SubItems.Add(Fa.Locationcode.ToString());
                itm.SubItems.Add(Fa.supplierCode.ToString());
                itm.SubItems.Add(Fa.PurchaseDate);
                itm.SubItems.Add(Fa.dblPurchaseCost.ToString());
                itm.SubItems.Add(Fa.dteDepEffDate);
                itm.SubItems.Add(Fa.intDepMethod.ToString());
                //if (Fa.intDepMethod == 1)
                //{
                //    itm.SubItems.Add("Straight Line");
                //}
                //else
                //{
                //    itm.SubItems.Add("Reducing Balance");
                //}
                itm.SubItems.Add(Fa.dblAssetsLife.ToString());
                itm.SubItems.Add(Fa.dblAssetsDepRate.ToString());
                itm.SubItems.Add(Fa.dblAssetsAccDep.ToString());
                itm.SubItems.Add(Fa.dblWrittenValue.ToString());
                itm.SubItems.Add(Fa.dblPercent.ToString());
                itm.SubItems.Add((Fa.dblsalvageValue.ToString()));
                itm.SubItems.Add((Fa.ManufacturerCode.ToString()));
                itm.SubItems.Add((Fa.ManufacturerName.ToString()));
                itm.SubItems.Add((Fa.NameofOrigin.ToString()));
                itm.SubItems.Add((Fa.ModelNo.ToString()));
                itm.SubItems.Add((Fa.AssetsIdenticode.ToString()));
                itm.SubItems.Add((Fa.FloorNo.ToString()));
                lvwFixedAssetsDetails.Items.Add(itm);
            }
        }
        private void lvwFixedAssetsDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFixedAssetsDetails.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwFixedAssetsDetails.SelectedItems[0];
                txtSerialNo.Text = itm.SubItems[0].Text;
                cboAssestsName.SelectedValue = itm.SubItems[1].Text;
                mskDateofpurchase.Text=itm.SubItems[3].Text;
                cboLocalAgent.SelectedValue = itm.SubItems[5].Text;
                cboLocation.SelectedValue = itm.SubItems[4].Text;
                mskDateofpurchase.Text = itm.SubItems[6].Text;
                txtPurchaseAmount.Text = itm.SubItems[7].Text;
                dteDepEffectiveMethod.Text = itm.SubItems[8].Text; ;
                if (Convert.ToInt16(itm.SubItems[9].Text) == 1)
                {
                    cboDepMethod.SelectedItem = "Reducing Balance";
                }
                else
                {
                    cboDepMethod.SelectedItem = "Straight Line";
                }
                txtAssetsLife.Text = itm.SubItems[10].Text;
                txtDepRate.Text = itm.SubItems[11].Text;
                txtAccumulatedDep.Text = itm.SubItems[12].Text;
                txtWrittenValue.Text = itm.SubItems[13].Text;
                txtSalvageValue.Text = itm.SubItems[15].Text;

                cboManufacturerName.SelectedValue = itm.SubItems[16].Text;
                txtCountryofOrigin.Text = itm.SubItems[18].Text;
                txtModelNo.Text = itm.SubItems[19].Text;
                txtAssetsIdentiNo.Text = itm.SubItems[20].Text;
                txtIdentiNo1.Text = itm.SubItems[20].Text;
                txtFloorNo.Text = itm.SubItems[21].Text;
                cboAssestsName.Focus();
            }
        }
        #endregion 
        #region "new/Delete"
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true ;
            btnEdit.Enabled = false;
            cboAssestsName.Focus();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                var strResponse = MessageBox.Show("Do You Want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    FixedAssets objAssets = this.PopulateFixedAssets();
                    try
                    {
                        short i = accmSc.DeleteFixedAssetsSetup(objAssets);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            LoadListView();
                            txtPurchaseAmount.Text = "0";
                            txtDepRate.Text = "0";
                            txtAssetsLife.Text = "0";
                            txtAccumulatedDep.Text = "0";
                            txtWrittenValue.Text = "0";
                            txtSalvageValue.Text = "0";
                            cboAssestsName.Focus();
                            LoadListView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Transaction Cannot be Delete");
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
        #region "Keypress"
        private void cboAssestsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)
            {
                dteManufacturer.Focus();
            }
        }
        private void dteManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboManufacturerName.Focus();
            }
        }
        private void cboLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtFloorNo.Focus();
            }
        }
        private void cboLocalAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtPurchaseAmount.Focus();
            }
        }
        private void mskDateofpurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboLocalAgent.Focus();
            }
        }
        private void dteDepEffectiveMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtDepRate.Text == "")
                {
                    txtAssetsLife.Focus();
                }
                else
                {
                    txtWrittenValue.Focus();
                }
            }
        }
        #endregion 
        #region "Clock"
        private void btnAdjustment_Click(object sender, EventArgs e)
        {
            if (lvwFixedAssetsDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvwFixedAssetsDetails.SelectedItems[0];
                frmAdjustment frm = new frmAdjustment();
                frm.strLedgerCode = itm.SubItems[1].Text;
                frm.strLedgerName  = itm.SubItems[2].Text;
                frm.ShowDialog();
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            frmACCMSReportFixedAssets frm = new frmACCMSReportFixedAssets();
            frm.ShowDialog();
        }
        #endregion

        private void txtAssetsIdentiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                cboAssestsName.Focus();
            }
        }
        private void cboManufacturerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys .Return)
            {
                txtCountryofOrigin.Focus();
            }
        }
        private void txtCountryofOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtModelNo.Focus();
            }
        }
        private void txtModelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboLocation.Focus();
            }
        }

        private void txtFloorNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                mskDateofpurchase.Focus();
            }
        }

      
    }
}
