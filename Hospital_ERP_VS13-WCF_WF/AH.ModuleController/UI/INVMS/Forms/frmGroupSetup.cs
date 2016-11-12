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
    public partial class frmGroupSetup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmGroupSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupNameBang"};
            Control control = Utility.ReqFieldValidator(this,vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name)+Utility.Req,Utility.MessageCaptionMsg,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvGroup,1,txtGroupName.Text))
            {
                MessageBox.Show("This Group Name has already been added");
                return;
            }
            try
            {
                GroupDetails gr = this.populateGroupSetup();
                short i = invSr.SaveGroupDetails(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGroupName.Select();
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
        private GroupDetails populateGroupSetup()
        {
            GroupDetails ogroup = new GroupDetails();
            ogroup.ID = txtGroupID.Text;
            ogroup.Name = txtGroupName.Text;
            ogroup.NameBeng = txtGroupNameBang.Text;
            ogroup.Remarks = txtRemarks.Text;

            Majorgroup omajor = new Majorgroup();
            omajor.MajorgrpID = cboMajorGroup.SelectedValue.ToString();
            ogroup.Majorgroup = omajor;

            StoreTypeSCM ostore = new StoreTypeSCM();
            ostore.strTypeID = cboStoreLocation.SelectedValue.ToString();
            ogroup.StoreType = ostore;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ogroup.EntryParameter = ep; 

            return ogroup;
        }
        private void FormatGrid()
        {

            lvGroup.CheckBoxes = false;
            lvGroup.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvGroup.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvGroup.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvGroup.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvGroup.Columns.Add("MajorGroup", 150, HorizontalAlignment.Left);
            lvGroup.Columns.Add("StoreType", 200, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvGroup.Items.Clear();

            List<GroupDetails> ogroup = invSr.GetGroupDetails().ToList();

            int i = 0;

            foreach (GroupDetails grp in ogroup)
            {
                ListViewItem itm = new ListViewItem(grp.ID);
                itm.SubItems.Add(grp.Name);
                itm.SubItems.Add(grp.NameBeng);
                itm.SubItems.Add(grp.Remarks);
                itm.SubItems.Add(grp.Majorgroup.Name);
                itm.SubItems.Add(grp.StoreType.TypeTitle);
                lvGroup.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmGroupSetup_Load(object sender, EventArgs e)
        {
            cboStoreLocation.ValueMember = "strTypeID";
            cboStoreLocation.DisplayMember = "TypeTitle";
            cboStoreLocation.DataSource = invSr.GetStoreType().ToList();

            cboMajorGroup.ValueMember = "MajorgrpID";
            cboMajorGroup.DisplayMember = "Name";
            cboMajorGroup.DataSource = invSr.GetMajorGrp().ToList();

            txtGroupName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void lvGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvGroup.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboMajorGroup.Text = itm.SubItems[4].Text;
                cboStoreLocation.Text = itm.SubItems[5].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                GroupDetails gr = this.populateGroupSetup();
                short i = invSr.ModifyGroupDetails(gr);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtGroupName.Select();
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

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

    }
}
