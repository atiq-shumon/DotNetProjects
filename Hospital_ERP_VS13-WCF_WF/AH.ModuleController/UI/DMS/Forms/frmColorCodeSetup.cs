using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;


namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmColorCodeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmColorCodeSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvColorCode.CheckBoxes = false;
            lvColorCode.Columns.Add("Color ID", 150, HorizontalAlignment.Center);
            lvColorCode.Columns.Add("Color Name", 200, HorizontalAlignment.Left);
            lvColorCode.Columns.Add("Color Name(Bangla)", 200, HorizontalAlignment.Left);
            lvColorCode.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvColorCode.Items.Clear();
            List<ColorCode> oCols = dmsSc.GetColorCodeSetup().ToList();
            foreach (ColorCode oCol in oCols)
            {
                ListViewItem itm = new ListViewItem(oCol.ColorID);
                itm.SubItems.Add(oCol.ColorTitle);
                itm.SubItems.Add(oCol.ColorTitleBeng);
                itm.SubItems.Add(oCol.Remarks);
                lvColorCode.Items.Add(itm);
            }
        }

        private void frmColorCodeSetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
            }
            catch (System.ServiceModel.CommunicationException commp)
            {
                MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }

        }

        private void lvColorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvColorCode.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvColorCode.SelectedItems[0];
                txtColorID.Text = itm.SubItems[0].Text;
                txtColorName.Text = itm.SubItems[1].Text;
                txtColorNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void lvColorCode_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private ColorCode PopulateColorCodeSetup()
        {
            ColorCode oCol = new ColorCode();
            oCol.ColorID = txtColorID.Text;
            oCol.ColorTitle = txtColorName.Text;
            oCol.ColorTitleBeng = txtColorNameBeng.Text;
            oCol.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oCol.EntryParameter = ep;
            return oCol;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtColorName", "txtColorNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ColorCode oCol = this.PopulateColorCodeSetup();
                if (Utility.IsDuplicateFoundInList(lvColorCode, 1, txtColorName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtColorName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveColorCodeSetup(oCol);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
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
            List<string> vf = new List<string>() { "txtColorName", "txtColorNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ColorCode oCol = this.PopulateColorCodeSetup();
                short i = dmsSc.UpdateColorCodeSetup(oCol);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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

        private void txtColorName_TextChanged(object sender, EventArgs e)
        {
            txtColorNameBeng.Text = txtColorName.Text;
        }

    }
}
