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
    public partial class frmReffdDocSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        private List<RefdDoc> oRefdDocs;
        public string ReffOrg { set; get; }
        public frmReffdDocSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvReffdDoc.CheckBoxes = false;
            lvReffdDoc.Columns.Add("Doc ID", 0, HorizontalAlignment.Center);
            lvReffdDoc.Columns.Add("Org ID", 0, HorizontalAlignment.Center);
            lvReffdDoc.Columns.Add("Doctor Name", 220, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Doctor Name(Bangla)", 0, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Degree Line", 250, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Address", 250, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Phone", 150, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Web", 150, HorizontalAlignment.Left);
            lvReffdDoc.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {
            txtDoctorNameBeng.Text = txtDoctorName.Text;
        }
        private void LoadListView(string Organization)
        {
            lvReffdDoc.Items.Clear();
            oRefdDocs = dmsSc.GetReffdDoc(cboReffOrg.SelectedValue.ToString()).ToList();
            foreach (RefdDoc oRefdDoc in oRefdDocs)
            {
                ListViewItem itm = new ListViewItem(oRefdDoc.DocID);
                itm.SubItems.Add(oRefdDoc.RefdOrg.OrgID);
                itm.SubItems.Add(oRefdDoc.DocTitle);
                itm.SubItems.Add(oRefdDoc.DocTitleBeng);
                itm.SubItems.Add(oRefdDoc.DegreeLine);
                itm.SubItems.Add(oRefdDoc.Address);
                itm.SubItems.Add(oRefdDoc.Phone);
                itm.SubItems.Add(oRefdDoc.Email);
                itm.SubItems.Add(oRefdDoc.Web);
                itm.SubItems.Add(oRefdDoc.Remarks);
                lvReffdDoc.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView(cboReffOrg.SelectedValue.ToString());
        }
        private void frmReffdDocSetup_Load(object sender, EventArgs e)
        {
            try
            {
                cboReffOrg.DisplayMember = "Value";
                cboReffOrg.ValueMember = "Key";
                cboReffOrg.DataSource = new BindingSource(dmsSc.GetReffdOrgDic("D"), null);

                if (ReffOrg != null)
                {
                    cboReffOrg.SelectedValue = ReffOrg.ToString();
                }
                FormatGrid();
                RefreshGrid();
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
        private void lvReffdDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReffdDoc.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvReffdDoc.SelectedItems[0];
                txtDocID.Text = itm.SubItems[0].Text;
                cboReffOrg.SelectedValue = itm.SubItems[1].Text;
                txtDoctorName.Text = itm.SubItems[2].Text;
                txtDoctorNameBeng.Text = itm.SubItems[3].Text;
                txtDegreeLine.Text = itm.SubItems[4].Text;
                txtAddress.Text = itm.SubItems[5].Text;
                txtPhone.Text = itm.SubItems[6].Text;
                txtEmail.Text = itm.SubItems[7].Text;
                txtWeb.Text = itm.SubItems[8].Text;
                txtRemarks.Text = itm.SubItems[9].Text;
            }
        }
        private void lvReffdDoc_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private RefdDoc PopulateRefdDocSetup()
        {
            RefdDoc oRefdDoc = new RefdDoc();

            RefdOrg oRefdOrg = new RefdOrg();
            oRefdOrg.OrgID = cboReffOrg.SelectedValue.ToString();
            oRefdDoc.RefdOrg = oRefdOrg;

            oRefdDoc.DocID = txtDocID.Text;
            oRefdDoc.DocTitle = txtDoctorName.Text;
            oRefdDoc.DocTitleBeng = txtDoctorNameBeng.Text;
            oRefdDoc.DegreeLine = txtDegreeLine.Text;
            oRefdDoc.Address = txtAddress.Text;
            oRefdDoc.Phone = txtPhone.Text;
            oRefdDoc.Email = txtEmail.Text;
            oRefdDoc.Web = txtWeb.Text;
            oRefdDoc.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oRefdDoc.EntryParameter = ep;
            return oRefdDoc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDoctorName", "txtDoctorNameBeng", "txtDegreeLine", "txtAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RefdDoc oRefdDoc = this.PopulateRefdDocSetup();
                short i = dmsSc.SaveReffdDoc(oRefdDoc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDocID", "txtDoctorName", "txtDoctorNameBeng", "txtDegreeLine", "txtAddress" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                RefdDoc oRefdDoc = this.PopulateRefdDocSetup();
                short i = dmsSc.UpdateReffdDoc(oRefdDoc);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtDoctorName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(oRefdDocs, txtDoctorName.Text);
        }
        private void SearchListView(IEnumerable<RefdDoc> oResults, string searchString = "")
        {
            IEnumerable<RefdDoc> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.DocTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);
                }
                lvReffdDoc.Items.Clear();
                foreach (RefdDoc oRefdDoc in query)
                {
                    ListViewItem itm = new ListViewItem(oRefdDoc.DocID);
                    itm.SubItems.Add(oRefdDoc.RefdOrg.OrgID);
                    itm.SubItems.Add(oRefdDoc.DocTitle);
                    itm.SubItems.Add(oRefdDoc.DocTitleBeng);
                    itm.SubItems.Add(oRefdDoc.DegreeLine);
                    itm.SubItems.Add(oRefdDoc.Address);
                    itm.SubItems.Add(oRefdDoc.Phone);
                    itm.SubItems.Add(oRefdDoc.Email);
                    itm.SubItems.Add(oRefdDoc.Web);
                    itm.SubItems.Add(oRefdDoc.Remarks);
                    lvReffdDoc.Items.Add(itm);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
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

        private void cboReffOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender, e);
        }
        private void btnAddOrg_Click(object sender, EventArgs e)
        {
            frmReffdOrgSetup oReffOrg = new frmReffdOrgSetup();
            oReffOrg.ShowDialog();
        }
        private void btnRefreshOrg_Click(object sender, EventArgs e)
        {
            cboReffOrg.DisplayMember = "Value";
            cboReffOrg.ValueMember = "Key";
            cboReffOrg.DataSource = new BindingSource(dmsSc.GetReffdOrgDic("D"), null);
        }

    }
}
