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
    public partial class frmModelSetup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();

        public frmModelSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtModelName", "txtModelNameBang"};
            Control control = Utility.ReqFieldValidator(this,vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(Utility.IsDuplicateFoundInList(lvModelDetails,1,txtModelName.Text))
            {
                MessageBox.Show("This Model Name has already been added");
                return;
            }
            try
            {
                ModelSetup omodel = this.populateModelSetup();
                short i = invSr.SaveModelDetails(omodel);

                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtModelName.Select();
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

        private ModelSetup populateModelSetup()
        {
            ModelSetup omodel = new ModelSetup();
            omodel.ID = txtModelID.Text;
            omodel.Name = txtModelName.Text;
            omodel.NameBeng = txtModelNameBang.Text;
            omodel.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            omodel.EntryParameter = ep; 
            return omodel;
        }
        private void FormatGrid()
        {

            lvModelDetails.CheckBoxes = false;
            lvModelDetails.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvModelDetails.Columns.Add("Name", 275, HorizontalAlignment.Left);
            lvModelDetails.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvModelDetails.Columns.Add("Remarks", 350, HorizontalAlignment.Left);
        }

        private void LoadListView()
        {
            lvModelDetails.Items.Clear();

            List<ModelSetup> omodel = invSr.GetModelDetails().ToList();
            int i = 0;
            foreach (ModelSetup mod in omodel)
            {
                ListViewItem itm = new ListViewItem(mod.ID);
                itm.SubItems.Add(mod.Name);
                itm.SubItems.Add(mod.NameBeng);
                itm.SubItems.Add(mod.Remarks);
                lvModelDetails.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void frmModelSetup_Load(object sender, EventArgs e)
        {
            txtModelName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void lvModelDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvModelDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvModelDetails.SelectedItems[0];
                txtModelID.Text = itm.SubItems[0].Text;
                txtModelName.Text = itm.SubItems[1].Text;
                txtModelNameBang.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ModelSetup omodel = this.populateModelSetup();
                short i = invSr.ModifyModelDetails(omodel);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtModelName.Select();
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
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
