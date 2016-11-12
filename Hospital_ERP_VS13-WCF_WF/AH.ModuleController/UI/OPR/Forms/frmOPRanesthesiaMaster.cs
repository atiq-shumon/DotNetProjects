using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOPRanesthesiaMaster : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOPRanesthesiaMaster()
        {
            InitializeComponent();
        }

        #region "Loadmodule"
        private void LoadModule()
        {
            cbogroupID.ValueMember = "Key";
            cbogroupID.DisplayMember = "Value";
            cbogroupID.DataSource = new BindingSource(accmSc.GetAnesthesiaGroups("D"), null);
        }
        #endregion
        #region "Form Load"
        private void frmOPRanesthesiaMaster_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
                LoadModule();
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
        #region "Populated"
        private AnesthesiaMaster PopulateAnesthesia()
        {
            AnesthesiaMaster anesthesia = new AnesthesiaMaster();
            anesthesia.Anesesthesia = txtAnesthesiaID.Text.ToString();
            anesthesia.GroupID = cbogroupID.SelectedValue.ToString();
            anesthesia.Anesthesiatitle = txtAnesthesiatitle.Text.ToString();
            anesthesia.AnesthesiatitleBangla = txtAnesthesiatitle.Text.ToString();
            anesthesia.Remarks = txtRemarks.Text.ToString();
            //anesthesia.Active = Cboactive.Text.ToString().Substring(0, 1);
            if (Cboactive.Text.ToString() == "Active")
            {
                anesthesia.Active = "1";
            }
            else
            {
                anesthesia.Active = "0";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            anesthesia.EntryParameter = ep;
            return anesthesia;
        }
        #endregion
        #region "Formatgrid"
        private void FormatGrid()
        {
            lvwAnesthesiaDetails.CheckBoxes = false;
            lvwAnesthesiaDetails.Columns.Add("Anesthesia Id", 260, HorizontalAlignment.Center);
            lvwAnesthesiaDetails.Columns.Add("Anesthesia Title", 290, HorizontalAlignment.Left);
            lvwAnesthesiaDetails.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwAnesthesiaDetails.Columns.Add("Group ID", 0, HorizontalAlignment.Left);
            lvwAnesthesiaDetails.Columns.Add("Status", 290, HorizontalAlignment.Left);
        }
        #endregion
        #region "Validationfields"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtRemarks", "txtAnesthesiatitle" };
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
                control.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {

                if (Utility.IsDuplicateFoundInList(lvwAnesthesiaDetails, 1, txtAnesthesiaID.Text) == true)
                {
                    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                    return;
                }

                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    AnesthesiaMaster anesthesia = this.PopulateAnesthesia();
                    short i = accmSc.SaveAnesSetupMaster(anesthesia);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtAnesthesiaID.Focus();
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
            try
            {

                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    AnesthesiaMaster anesthesia = this.PopulateAnesthesia();
                    short i = accmSc.UpdateAnesSetupMaster(anesthesia);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cbogroupID.Select();
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
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            try
            {
                lvwAnesthesiaDetails.Items.Clear();
                List<AnesthesiaMaster> anesthesia = accmSc.GetAnesthesiaMaster().ToList();
                foreach (AnesthesiaMaster bo in anesthesia)
                {
                    ListViewItem itm = new ListViewItem(bo.Anesesthesia);
                    itm.SubItems.Add(bo.Anesthesiatitle);
                    itm.SubItems.Add(bo.Remarks);
                    itm.SubItems.Add(bo.GroupID);
                    if (bo.Active == "A")
                    {
                        itm.SubItems.Add("Active");
                    }
                    else
                    {
                        itm.SubItems.Add("Inactive");
                    }
                    lvwAnesthesiaDetails.Items.Add(itm);
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
        #endregion
        #region "Selectedindex"
        private void lvwAnesthesiaDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwAnesthesiaDetails.SelectedItems.Count > 0)
            {
                txtAnesthesiaID.ReadOnly = true;
                ListViewItem itm = lvwAnesthesiaDetails.SelectedItems[0];
                txtAnesthesiaID.Text = itm.SubItems[0].Text;
                txtAnesthesiatitle.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                cbogroupID.SelectedValue  = itm.SubItems[3].Text;
                if (itm.SubItems[4].Text == "A")
                {
                    Cboactive.Text = "Active";
                }
                else
                {
                    Cboactive.Text = "Inactive";
                }
                txtAnesthesiatitle.Select();

            }
        }
        #endregion
        #region "New/Delete"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    AnesthesiaMaster anes = this.PopulateAnesthesia();
                    short i = accmSc.DeleteAnesMaster(anes);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        cbogroupID.Select();
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
        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
