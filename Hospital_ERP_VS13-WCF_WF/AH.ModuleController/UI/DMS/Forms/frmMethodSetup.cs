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
    public partial class frmMethodSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmMethodSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvMethod.CheckBoxes = false;
            lvMethod.Columns.Add("Method ID", 150, HorizontalAlignment.Center);
            lvMethod.Columns.Add("Method Name", 200, HorizontalAlignment.Left);
            lvMethod.Columns.Add("Method Name(Bangla)", 200, HorizontalAlignment.Left);
            lvMethod.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvMethod.Items.Clear();
            List<TestMethod> macs = dmsSc.GetMethodSetup().ToList();
            foreach (TestMethod mac in macs)
            {
                ListViewItem itm = new ListViewItem(mac.MethodID);
                itm.SubItems.Add(mac.MethodTitle);
                itm.SubItems.Add(mac.MethodTitleBeng);
                itm.SubItems.Add(mac.Remarks);
                lvMethod.Items.Add(itm);
            }
        }

        private void frmMethodSetup_Load(object sender, EventArgs e)
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

        private void lvMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMethod.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvMethod.SelectedItems[0];
                txtMethodID.Text = itm.SubItems[0].Text;
                txtMethodName.Text = itm.SubItems[1].Text;
                txtMethodNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void lvMethod_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private TestMethod PopulateMethodSetup()
        {
            TestMethod mac = new TestMethod();
            mac.MethodID = txtMethodID.Text;
            mac.MethodTitle = txtMethodName.Text;
            mac.MethodTitleBeng = txtMethodNameBeng.Text;
            mac.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            mac.EntryParameter = ep;
            return mac;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMethodName", "txtMethodNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                TestMethod oMac = this.PopulateMethodSetup();
                if (Utility.IsDuplicateFoundInList(lvMethod, 1, txtMethodName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMethodName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveMethodSetup(oMac);
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
            List<string> vf = new List<string>() { "txtMethodName", "txtMethodNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                TestMethod oMac = this.PopulateMethodSetup();
                short i = dmsSc.UpdateMethodSetup(oMac);
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

        private void txtMethodName_TextChanged(object sender, EventArgs e)
        {
            txtMethodNameBeng.Text = txtMethodName.Text;
        }

    }
}
