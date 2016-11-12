using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DMSSR;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmDiagPackageMaster : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmDiagPackageMaster()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvDiagPackage.CheckBoxes = false;
            lvDiagPackage.Columns.Add("Package ID", 100, HorizontalAlignment.Left);
            lvDiagPackage.Columns.Add("Package Name", 350, HorizontalAlignment.Left);
            lvDiagPackage.Columns.Add("Package Name(Bangla)", 0, HorizontalAlignment.Left);
            lvDiagPackage.Columns.Add("Package Amount", 200, HorizontalAlignment.Center);
            lvDiagPackage.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }

        private void frmDiagPackageMaster_Load(object sender, EventArgs e)
        {
            try
            {
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
        private void LoadListView()
        {
            lvDiagPackage.Items.Clear();

            List<DiagPackage> oDiagPackages = dmsSC.GetDiagPackageMaster().ToList();
            foreach (DiagPackage oDiagPackage in oDiagPackages)
            {
                ListViewItem itm = new ListViewItem(oDiagPackage.PackageID);
                itm.SubItems.Add(oDiagPackage.PackageTitle);
                itm.SubItems.Add(oDiagPackage.PackageTitleBeng);
                itm.SubItems.Add(oDiagPackage.PackageAmount.ToString());
                itm.SubItems.Add(oDiagPackage.Remarks);
                lvDiagPackage.Items.Add(itm);

            }

        }

        private void lvDiagPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiagPackage.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDiagPackage.SelectedItems[0];
                txtDiagPkgID.Text = itm.SubItems[0].Text;
                txtDiagPkgName.Text = itm.SubItems[1].Text;
                txtDiagPkgNameBeng.Text = itm.SubItems[2].Text;
                txtDiagPkgAmt.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
            }
        }

        private void lvDiagPackage_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtDiagPkgName_TextChanged(object sender, EventArgs e)
        {
            txtDiagPkgNameBeng.Text = txtDiagPkgName.Text;
        }
        private DiagPackage PopulateDiagPackage()
        {
            DiagPackage oDiagPackage = new DiagPackage();
            oDiagPackage.PackageID = txtDiagPkgID.Text;
            oDiagPackage.PackageTitle = txtDiagPkgName.Text;
            oDiagPackage.PackageTitleBeng = txtDiagPkgNameBeng.Text;
            oDiagPackage.PackageAmount =Convert.ToDouble(txtDiagPkgAmt.Text.ToString());
            oDiagPackage.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oDiagPackage.EntryParameter = ep;

            return oDiagPackage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDiagPkgName", "txtDiagPkgNameBeng", "txtDiagPkgAmt"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                DiagPackage oDiagPackage = this.PopulateDiagPackage();
                if (Utility.IsDuplicateFoundInList(lvDiagPackage, 1, txtDiagPkgName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Package Name!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiagPkgName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSC.SaveDiagPackageMaster(oDiagPackage);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtDiagPkgName.Focus();
                        LoadListView();
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
            List<string> vf = new List<string>() { "txtDiagPkgID", "txtDiagPkgName", "txtDiagPkgNameBeng", "txtDiagPkgAmt" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                 DiagPackage oDiagPackage = this.PopulateDiagPackage();
                 short i = dmsSC.UpdateDiagPackageMaster(oDiagPackage);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtDiagPkgName.Focus();
                        LoadListView();
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

    }
}
