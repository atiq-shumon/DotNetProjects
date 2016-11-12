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
    public partial class frmSpecimenSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmSpecimenSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtSpecimenName", "txtSpecimenNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Specimen specobj = this.PopulateSpecSetup();
                short i = dmsSc.SaveSpecsetup(specobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
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
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void FormatGrid()
        {
            lvSpec.CheckBoxes = false;
            lvSpec.Columns.Add("Specimen ID", 150, HorizontalAlignment.Center);
            lvSpec.Columns.Add("Specimen Name", 200, HorizontalAlignment.Left);
            lvSpec.Columns.Add("Specimen Name(Bangla)", 200, HorizontalAlignment.Left);
            lvSpec.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }

        private Specimen PopulateSpecSetup()
        {
            Specimen spec = new Specimen();
            spec.SpecimenID = txtSpecimenID.Text;
            spec.SpecimenTitle = txtSpecimenName.Text;
            spec.SpecimenTitleBeng = txtSpecimenNameBeng.Text;
            spec.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            spec.EntryParameter = ep;
            return spec;
        }

        private void frmSpecimenSetup_Load(object sender, EventArgs e)
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
            try
            {
                lvSpec.Items.Clear();
                List<Specimen> spec = dmsSc.GetSpec().ToList();
                int i = 0;
                foreach (Specimen sp in spec)
                {
                    ListViewItem itm = new ListViewItem(sp.SpecimenID);
                    itm.SubItems.Add(sp.SpecimenTitle);
                    itm.SubItems.Add(sp.SpecimenTitleBeng);
                    itm.SubItems.Add(sp.Remarks);
                    lvSpec.Items.Add(itm);
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

        private void lvSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSpec.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSpec.SelectedItems[0];
                txtSpecimenID.Text = itm.SubItems[0].Text;
                txtSpecimenName.Text = itm.SubItems[1].Text;
                txtSpecimenNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtSpecimenName", "txtSpecimenNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifySpecSetup(txtSpecimenID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNew.PerformClick();
                return;
            }
            try
            {
                Specimen specobj = this.PopulateSpecSetup();
                short i = dmsSc.UpdateSpecimen(specobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtSpecimenID.Focus();
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

        private void lvSpec_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtSpecimenName_TextChanged(object sender, EventArgs e)
        {
            txtSpecimenNameBeng.Text = txtSpecimenName.Text;
        }
    }
}
