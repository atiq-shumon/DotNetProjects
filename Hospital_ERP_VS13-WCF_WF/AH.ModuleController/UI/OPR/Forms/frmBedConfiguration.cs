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
    public partial class frmBedConfiguration : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmBedConfiguration()
        {
            InitializeComponent();
        }

        private void frmBedConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                cbotheaterID.Select();
                LoadModule();
                LoadRegID();
                LoadRoomID();
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

        private void LoadModule()
        {
            try
            {
                cbotheaterID.ValueMember = "Key";
                cbotheaterID.DisplayMember = "Value";
                cbotheaterID.DataSource = new BindingSource(accmSc.GetTheaterBed("TheaterDep"), null);
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
        private void LoadRegID()
        {
            try
            {
                cboRegID.ValueMember = "Key";
                cboRegID.DisplayMember = "Value";
                cboRegID.DataSource = new BindingSource(accmSc.GetRegID("BedRegID"), null);
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

        private void LoadRoomID()
        {
            try
            {
                cboRoomID.ValueMember = "Key";
                cboRoomID.DisplayMember = "Value";
                cboRoomID.DataSource = new BindingSource(accmSc.GetRoomIdFromTheater("GetRoomFromTheater", cbotheaterID.SelectedValue.ToString()), null);
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
            List<string> vf = new List<string>() { "txtbedID", "txtBedtTitle", "txtLocation", "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cbotheaterID.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cbotheaterID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbotheaterID.Focus();
                return false;
            }

            if (cboRoomID.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboRoomID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRoomID.Focus();
                return false;
            }
            if (cboRegID.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboRegID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRegID.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (strResponse == DialogResult.Yes)
            //{

            //     objanesthesia = this.PopulateAnesthesia();
            //    short i = accmSc.SaveAnesSetup(objanesthesia);
            //    if (i == 0)
            //    {
            //        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else if (i > 0)
            //    {
            //        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        btnNew.PerformClick();
            //        txtGroupTitle.Focus();
            //        LoadListView();
            //    }
            //}


        }

        private void cbotheaterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbotheaterID.SelectedValue.ToString() != "")
                {
                    LoadRoomID();
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
    }
}
