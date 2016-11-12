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
    public partial class frmSpecimenHolder : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        public frmSpecimenHolder()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboColorCode", "txtHolderName", "txtHolderNameBeng", "cboPriority" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                SpecimenHolder spchldr = this.PopulateSpecHolder();
                short i = dmsSC.SaveSpecHolder(spchldr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtHolderName.Focus();
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
        private SpecimenHolder PopulateSpecHolder()
        {
            SpecimenHolder spchlobj = new SpecimenHolder();
            spchlobj.HolderID = txtHolderID.Text;
            spchlobj.HolderTitle = txtHolderName.Text;
            spchlobj.HolderTitleBeng = txtHolderNameBeng.Text;
            ColorCode oCol = new ColorCode();
            oCol.ColorID = cboColorCode.SelectedValue.ToString();
            spchlobj.ColorCode = oCol;
            spchlobj.Priority = cboPriority.SelectedValue.ToString();
            spchlobj.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            spchlobj.EntryParameter = ep;

            return spchlobj;
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvSpecHolder.CheckBoxes = false;
            lvSpecHolder.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lvSpecHolder.Columns.Add("Specimen Holder Name", 250, HorizontalAlignment.Left);
            lvSpecHolder.Columns.Add("SpecHolder Name(Bangla)", 0, HorizontalAlignment.Left);
            lvSpecHolder.Columns.Add("color ID", 0, HorizontalAlignment.Left);
            lvSpecHolder.Columns.Add("color", 200, HorizontalAlignment.Left);
            lvSpecHolder.Columns.Add("Priority", 100, HorizontalAlignment.Center);
            lvSpecHolder.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
            
        }

        private void frmSpecimenHolder_Load(object sender, EventArgs e)
        {
            try
            {
                cboColorCode.DisplayMember = "Value";
                cboColorCode.ValueMember = "Key";
                cboColorCode.DataSource = new BindingSource(dmsSC.GetColorCode("D"), null);

                cboPriority.DisplayMember = "Value";
                cboPriority.ValueMember = "Key";
                cboPriority.DataSource = new BindingSource(Utility.GetNumbers(0, 16), null);

                FormatGrid();
                LoadListViewColorWise(cboColorCode.SelectedValue.ToString());
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
            lvSpecHolder.Items.Clear();

            List<SpecimenHolder> spchls = dmsSC.GetSpecHolder().ToList();
            foreach (SpecimenHolder spchld in spchls)
            {
                ListViewItem itm = new ListViewItem(spchld.HolderID);
                itm.SubItems.Add(spchld.HolderTitle);
                itm.SubItems.Add(spchld.HolderTitleBeng);
                itm.SubItems.Add(spchld.ColorCode.ColorID);
                itm.SubItems.Add(spchld.ColorCode.ColorTitle);
                itm.SubItems.Add(spchld.Priority);
                itm.SubItems.Add(spchld.Remarks);                
                lvSpecHolder.Items.Add(itm);
            }
        }
        private void LoadListViewColorWise(string ColorCode)
        {
            lvSpecHolder.Items.Clear();

            List<SpecimenHolder> spchls = dmsSC.GetSpecimenHolder(cboColorCode.SelectedValue.ToString()).ToList();
            foreach (SpecimenHolder spchld in spchls)
            {
                ListViewItem itm = new ListViewItem(spchld.HolderID);
                itm.SubItems.Add(spchld.HolderTitle);
                itm.SubItems.Add(spchld.HolderTitleBeng);
                itm.SubItems.Add(spchld.ColorCode.ColorID);
                itm.SubItems.Add(spchld.ColorCode.ColorTitle);
                itm.SubItems.Add(spchld.Priority);
                itm.SubItems.Add(spchld.Remarks);                
                lvSpecHolder.Items.Add(itm);
            }
        }

        private void lvSpecHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSpecHolder.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSpecHolder.SelectedItems[0];
                txtHolderID.Text = itm.SubItems[0].Text;
                txtHolderName.Text = itm.SubItems[1].Text;
                txtHolderNameBeng.Text = itm.SubItems[2].Text;
                cboColorCode.SelectedValue = itm.SubItems[3].Text;
                cboPriority.Text = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboColorCode", "txtHolderName", "txtHolderNameBeng", "cboPriority"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSC.VerifySpecHolder(txtHolderID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNew.PerformClick();
                return;
            }
            try
            {
                SpecimenHolder spchldr = this.PopulateSpecHolder();
                short i = dmsSC.UpdateSpcHolder(spchldr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtHolderName.Focus();
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
        private void btnAddColorCode_Click(object sender, EventArgs e)
        {
            frmColorCodeSetup oCol = new frmColorCodeSetup();
            oCol.ShowDialog();
        }

        private void btnRefreshColorCode_Click(object sender, EventArgs e)
        {
            cboColorCode.DisplayMember = "Value";
            cboColorCode.ValueMember = "Key";
            cboColorCode.DataSource = new BindingSource(dmsSC.GetColorCode("D"), null);
        }

        private void txtHolderName_TextChanged(object sender, EventArgs e)
        {
            txtHolderNameBeng.Text = txtHolderName.Text;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboColorCode" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                LoadListViewColorWise(cboColorCode.SelectedValue.ToString());
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

        private void cboColorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender,e);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadListView();
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
