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
    public partial class frmMachineSetup : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public frmMachineSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvMachine.CheckBoxes = false;
            lvMachine.Columns.Add("Machine ID", 150, HorizontalAlignment.Center);
            lvMachine.Columns.Add("Machine Name", 200, HorizontalAlignment.Left);
            lvMachine.Columns.Add("Machine Name(Bangla)", 200, HorizontalAlignment.Left);
            lvMachine.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvMachine.Items.Clear();
            List<Machine> macs = dmsSc.GetMachineSetup().ToList();
            foreach (Machine mac in macs)
            {
                ListViewItem itm = new ListViewItem(mac.MachineID);
                itm.SubItems.Add(mac.MachineTitle);
                itm.SubItems.Add(mac.MachineTitleBeng);
                itm.SubItems.Add(mac.Remarks);
                lvMachine.Items.Add(itm);
            }
        }

        private void frmMachineSetup_Load(object sender, EventArgs e)
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

        private void lvMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMachine.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvMachine.SelectedItems[0];
                txtMachineID.Text = itm.SubItems[0].Text;
                txtMachineName.Text = itm.SubItems[1].Text;
                txtMachineNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void lvMachine_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
        private Machine PopulateMacineSetup()
        {
            Machine mac = new Machine();
            mac.MachineID = txtMachineID.Text;
            mac.MachineTitle = txtMachineName.Text;
            mac.MachineTitleBeng = txtMachineNameBeng.Text;
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
            List<string> vf = new List<string>() { "txtMachineName", "txtMachineNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Machine oMac = this.PopulateMacineSetup();
                if (Utility.IsDuplicateFoundInList(lvMachine, 1, txtMachineName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMachineName.Focus();
                    return;
                }
                else
                {
                    short i = dmsSc.SaveMachineSetup(oMac);
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
            List<string> vf = new List<string>() { "txtMachineName", "txtMachineNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }          
            try
            {
                Machine oMac = this.PopulateMacineSetup();
                short i = dmsSc.UpdateMachineSetup(oMac);
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

        private void txtMachineName_TextChanged(object sender, EventArgs e)
        {
            txtMachineNameBeng.Text = txtMachineName.Text;
        }
    }
}
