using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.IPDSR;
using AH.DUtility;
//using AH.IPD.MODEL;


namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmCancelReasonSetup : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmCancelReasonSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtReasonName", "txtReasonNameBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lstCancelReason, 1, txtReasonName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReasonName.Focus();
                    return;
                }

                CancelReasonSetup oCanRes = this.PopulateCancelReason();
                short i = ipdSc.SaveCancelReason(oCanRes);
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
            lstCancelReason.CheckBoxes = false;
            lstCancelReason.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lstCancelReason.Columns.Add("Reason Name", 200, HorizontalAlignment.Left);
            lstCancelReason.Columns.Add("Reason Name(Bangla)", 200, HorizontalAlignment.Left);
            lstCancelReason.Columns.Add("Remarks", 340, HorizontalAlignment.Left);

        }

        private CancelReasonSetup PopulateCancelReason()
        {
            CancelReasonSetup oCanRes = new CancelReasonSetup();
            oCanRes.ID = txtReasonID.Text;
            oCanRes.Title = txtReasonName.Text;
            oCanRes.TitleBeng = txtReasonNameBeng.Text;
            oCanRes.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oCanRes.EntryParameter = ep;
            return oCanRes;
        }
        private void LoadListView()
        {
            lstCancelReason.Items.Clear();

            List<CancelReasonSetup> oCanRess = ipdSc.GetCancelReason().ToList();
            foreach (CancelReasonSetup di in oCanRess)
            {
                ListViewItem itm = new ListViewItem(di.ID);
                itm.SubItems.Add(di.Title);
                itm.SubItems.Add(di.TitleBeng);
                itm.SubItems.Add(di.Remarks);
                lstCancelReason.Items.Add(itm);
            }

        }

        private void frmCancelReasonSetup_Load(object sender, EventArgs e)
        {         
                FormatGrid();
                LoadListView();
                txtReasonName.Select();      
        }

        private void lstCancelReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstCancelReason.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lstCancelReason.SelectedItems[0];
                    txtReasonID.Text = itm.SubItems[0].Text;
                    txtReasonName.Text = itm.SubItems[1].Text;
                    txtReasonNameBeng.Text = itm.SubItems[2].Text;
                    txtRemarks.Text = itm.SubItems[3].Text;
                }
                btnSave.Enabled = false;
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
            List<string> vf = new List<string>() { "txtReasonID", "txtReasonName", "txtReasonNameBeng"};
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

                CancelReasonSetup oCanRes = this.PopulateCancelReason();
                short i = ipdSc.UpdateCancelReason(oCanRes);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

    }
}
