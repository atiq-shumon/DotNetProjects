using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;
using System.Collections.Generic;
using System;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmFoodService : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmFoodService()
        {
            InitializeComponent();
        }

        #region "FormatList"
        private void FormaList()
        {
            lvwService.CheckBoxes = false;
            lvwService.Columns.Add("Service ID", 100, HorizontalAlignment.Left);
            lvwService.Columns.Add("Service Name", 370, HorizontalAlignment.Left);
            lvwService.Columns.Add("Remarks", 330, HorizontalAlignment.Left);
        }
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            lvwService.Items.Clear();
            List<ServiceSetup> Io = fnbs.LoadServiceSetup().ToList();
            if (Io.Count > 0)
            {
                foreach (ServiceSetup objService in Io)
                {
                    ListViewItem itm = new ListViewItem(objService.ServiceID);
                    itm.SubItems.Add(objService.ServiceName);
                    itm.SubItems.Add(objService.Remarks);
                    lvwService.Items.Add(itm);
                }
            }
        }
        #endregion
        #region "Populated Service"
        private ServiceSetup PopulateService()
        {
            ServiceSetup objService = new ServiceSetup();
            if (txtServiceId.Text != "")
            {
                objService.ServiceID = txtServiceId.Text;
            }
            else
            {
                objService.ServiceID = "";
            }

            objService.ServiceName = txtServiceName.Text;

            if (txtRemarks.Text != "")
            {
                objService.Remarks = txtRemarks.Text;
            }
            else
            {
                objService.Remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objService.EntryParameter = ep;
            return objService;
        }
        #endregion
        #region "Validationfields"
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtServiceName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "Keypress"
        private void txtServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }

            }
        }
        #endregion
        #region "Click"
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    ServiceSetup objService = this.PopulateService();
                    int i = fnbs.InsertServiceSetup(objService);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtServiceName.Text = "";
                        txtServiceId.Text = "";
                        txtRemarks.Text = "";
                        txtServiceName.Focus();
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
             if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {

                ServiceSetup objService = this.PopulateService();
                int i = fnbs.UpdateServiceSetup(objService);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadListView();
                    txtServiceName.Text = "";
                    txtServiceId.Text = "";
                    txtRemarks.Text = "";
                    txtServiceName.Focus();
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                }
            }
        }
        private void btnNew_Click(object sender, System.EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion
        #region "SelectedIndexchanged"
        private void lvwService_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwService.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwService.SelectedItems[0];
                txtServiceId.Text = itm.SubItems[0].Text;
                txtServiceName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                txtServiceName.Focus();
            }
        }
        #endregion
        #region "Load"
        private void frmFoodService_Load(object sender, System.EventArgs e)
        {
            txtServiceName.Select();
            FormaList();
            LoadListView();
        }
        #endregion
      
    }
}
