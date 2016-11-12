using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmBrandSetup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmBrandSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtBrandName", "txtBrandNameBang" };
            Control control = Utility.ReqFieldValidator(this,vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvBrand,1,txtBrandName.Text))
            {
                MessageBox.Show("This Brand Name has already been added");
                return;
            }
            try
            {
                BrandSetup br = this.populateBrandSetup();
                short i = invSr.SaveBrandDetails(br);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtBrandName.Select();
                    RefreshGrid();
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
        private BrandSetup populateBrandSetup()
        {
            BrandSetup obrand = new BrandSetup();
            obrand.ID = txtBrandID.Text;
            obrand.Name = txtBrandName.Text;
            obrand.NameBeng = txtBrandNameBang.Text;
            obrand.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            obrand.EntryParameter = ep; 

            return obrand;
        }
        private void FormatGrid()
        {
            
            lvBrand.CheckBoxes = false;
            lvBrand.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvBrand.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvBrand.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvBrand.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvBrand.Items.Clear();

            List<BrandSetup> obrand = invSr.GetBrandDetails().ToList();
            int i = 0;
            foreach (BrandSetup brn in obrand)
            {
                ListViewItem itm = new ListViewItem(brn.ID);
                itm.SubItems.Add(brn.Name);
                itm.SubItems.Add(brn.NameBeng);
                itm.SubItems.Add(brn.Remarks);
                lvBrand.Items.Add(itm);
            }
        }

        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmBrandSetup_Load(object sender, EventArgs e)
        {
            txtBrandName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void lvBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBrand.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBrand.SelectedItems[0];
                txtBrandID.Text = itm.SubItems[0].Text;
                txtBrandName.Text = itm.SubItems[1].Text;
                txtBrandNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                BrandSetup br = this.populateBrandSetup();
                short i = invSr.ModifyBrandDetails(br);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtBrandName.Select();
                    RefreshGrid();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

    }
}
