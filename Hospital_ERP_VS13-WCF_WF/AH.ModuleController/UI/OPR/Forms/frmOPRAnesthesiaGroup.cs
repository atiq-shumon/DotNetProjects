using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using System.Collections.Generic;
using AH.DUtility;
using System;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOPRAnesthesiaGroup : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOPRAnesthesiaGroup()
        {
            InitializeComponent();
        }


        #region "Anesthesia"

        private AnesthesiaGroup PopulateAnesthesia()
        {
            AnesthesiaGroup  objAnesthesia = new AnesthesiaGroup();
            objAnesthesia.AnesGroupID  = txtGroupId.Text.ToString();
            objAnesthesia.AnesGroupTitle = txtGroupTitle.Text.ToString();
            objAnesthesia.AnesRemarks = txtRemarks.Text.ToString();
            //objAnesthesia.Active =   Cboactive.Text.ToString().Substring(0,1);
            if (Cboactive.Text.ToString() == "Active")
            {
                objAnesthesia.Active = "1";
            }
            else
            {
                objAnesthesia.Active = "0";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objAnesthesia.EntryParameter = ep;
            return objAnesthesia;
        }

        private void LoadListView()
        {
            lvwGroupDetails.Items.Clear();
            try
            {
                List<AnesthesiaGroup> anesesthesia = accmSc.GetTAnesthesia().ToList();
                foreach (AnesthesiaGroup bo in anesesthesia)
                {
                    ListViewItem itm = new ListViewItem(bo.AnesGroupID);
                    itm.SubItems.Add(bo.AnesGroupTitle);
                    itm.SubItems.Add(bo.AnesRemarks);
                    if (bo.Active == "1")
                    {
                        itm.SubItems.Add("Active");
                    }
                    else
                    {
                        itm.SubItems.Add("Inactive");
                    }
                    lvwGroupDetails.Items.Add(itm);
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

        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtRemarks", "txtGroupTitle" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (Cboactive.Text == "")
            {
                MessageBox.Show(Utility.getFMS(Cboactive.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cboactive.Focus();
                return false;
            }
            return true;
        }

        private void FormatGrid()
        {
            lvwGroupDetails.CheckBoxes = false;
            lvwGroupDetails.Columns.Add("Anesthesia Id", 260, HorizontalAlignment.Center);
            lvwGroupDetails.Columns.Add("Group Name", 290, HorizontalAlignment.Left);
            lvwGroupDetails.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwGroupDetails.Columns.Add("Status", 290, HorizontalAlignment.Left);
        }
        #endregion
        #region "Save/edit/Delete"
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvwGroupDetails, 1, txtGroupId.Text) == true)
            {
                MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    AnesthesiaGroup objanesthesia = this.PopulateAnesthesia();
                    short i = accmSc.SaveAnesSetup(objanesthesia);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtGroupTitle.Focus();
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
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    AnesthesiaGroup oAnesthesia = this.PopulateAnesthesia();
                    short i = accmSc.UpdateAnesSetup(oAnesthesia);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtGroupId.Select();
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
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {
                AnesthesiaGroup obAnesthesia = this.PopulateAnesthesia();
                short i = accmSc.DeleteAnesGroup(obAnesthesia);
                if (i == 0)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGroupTitle.Select();
                    LoadListView();

                }
            }
        }
        #endregion
        #region "Form Load"
        private void frmOPRAnesthesiaGroup_Load(object sender, System.EventArgs e)
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
        #endregion
        #region "SalectedIndex"
        private void lvwGroupDetails_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwGroupDetails.SelectedItems.Count > 0)
            {
                txtGroupId.ReadOnly = true;
                ListViewItem itm = lvwGroupDetails.SelectedItems[0];
                txtGroupId.Text = itm.SubItems[0].Text;
                txtGroupTitle.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                if (itm.SubItems[3].Text == "Active")
                {
                    Cboactive.Text = "Active";
                }
                else
                {
                    Cboactive.Text = "Inactive";
                }
                txtGroupId.Select();

            }
        }
        #endregion
    }
}
