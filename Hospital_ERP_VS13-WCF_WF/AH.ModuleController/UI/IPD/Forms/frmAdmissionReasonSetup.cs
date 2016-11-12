using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.IPDSR;
namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmissionReasonSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmAdmissionReasonSetup()
        {
            InitializeComponent();
        }

        private void frmAdmissionReasonSetup_Load(object sender, EventArgs e)
        {         
                txtReasonName.Select();
                FormatGrid();
                LoadListView();
                //txtReasonID.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtReasonName", "txtReasonNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                if (Utility.IsDuplicateFoundInList(lvAdmRsn, 1, txtReasonName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReasonName.Focus();
                    return;
                }
                AdmissionReason adms = this.PopulateAdmissionReason();
                short i = ipdSc.SaveAdmissionReason(adms);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtReasonName.Focus();
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
            lvAdmRsn.CheckBoxes = false;
            lvAdmRsn.Columns.Add("Reason ID",0, HorizontalAlignment.Center);
            lvAdmRsn.Columns.Add("Reason Name", 250, HorizontalAlignment.Left);
            lvAdmRsn.Columns.Add("Reason Name(Bangla)", 250, HorizontalAlignment.Left);
            lvAdmRsn.Columns.Add("Minimum Staying Days", 200, HorizontalAlignment.Center);

        }
        private void LoadListView()
        {
            lvAdmRsn.Items.Clear();

            List<AdmissionReason> admrn = ipdSc.GetAdmReason().ToList();
            // int i = 0;
            foreach (AdmissionReason adms in admrn)
            {
                ListViewItem itm = new ListViewItem(adms.ID);
                itm.SubItems.Add(adms.Title);
                itm.SubItems.Add(adms.TitleBeng);
                itm.SubItems.Add(adms.MinStayDays.ToString());
                lvAdmRsn.Items.Add(itm);
            }

        }
        private AdmissionReason PopulateAdmissionReason()
        {
            AdmissionReason adn = new AdmissionReason();
            adn.ID = txtReasonID.Text;
            adn.Title = txtReasonName.Text;
            adn.TitleBeng = txtReasonNameBeng.Text;
            adn.MinStayDays = short.Parse(txtMinStayDay.Text);

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            adn.EntryParameter = ep;

            return adn;
        }

        private void frmAdmissionReason_Load(object sender, EventArgs e)
        {

            FormatGrid();
            LoadListView();
            txtReasonID.Select();
        }

        private void lvAdmRsn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdmRsn.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvAdmRsn.SelectedItems[0];
                txtReasonID.Text = itm.SubItems[0].Text;
                txtReasonName.Text = itm.SubItems[1].Text;
                txtReasonNameBeng.Text = itm.SubItems[2].Text;
                txtMinStayDay.Text = itm.SubItems[3].Text;
            }
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtReasonID", "txtReasonName", "txtDeptNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (ipdSc.VerifyDelivery(txtReasonID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReasonID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                AdmissionReason adms = this.PopulateAdmissionReason();
                short i = ipdSc.UpdateAdmissionReason(adms);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtReasonName.Focus();

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtReasonName_TextChanged(object sender, EventArgs e)
        {
            txtReasonNameBeng.Text = txtReasonName.Text;
        }

    }
}
