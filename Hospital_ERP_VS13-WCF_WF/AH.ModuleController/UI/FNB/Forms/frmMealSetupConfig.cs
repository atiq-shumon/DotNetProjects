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
    public partial class frmMealSetupConfig : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmMealSetupConfig()
        {
            InitializeComponent();
        }

        private void FormaList()
        {
            lvwMealSetup.CheckBoxes = false;
            lvwMealSetup.Columns.Add("Meal ID", 100, HorizontalAlignment.Left);
            lvwMealSetup.Columns.Add("Meal Name", 400, HorizontalAlignment.Left);
            lvwMealSetup.Columns.Add("Remarks", 380, HorizontalAlignment.Left);
            lvwMealSetup.Columns.Add("StartTime", 0, HorizontalAlignment.Left);
            lvwMealSetup.Columns.Add("EndTime", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwMealSetup.Items.Clear();
            List<MealSetup> Io = fnbs.LoadmealSetup().ToList();
            if (Io.Count > 0)
            {
                foreach (MealSetup objMs in Io)
                {
                    ListViewItem itm = new ListViewItem(objMs.MealID);
                    itm.SubItems.Add(objMs.MealName);
                    itm.SubItems.Add(objMs.Remarks);
                    itm.SubItems.Add(objMs.StartTime);
                    itm.SubItems.Add(objMs.EndTime);
                    lvwMealSetup.Items.Add(itm);
                }
            }
        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtMealName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        private MealSetup PopulateMealSetup()
        {
            MealSetup objMs = new MealSetup();
            if (txtMealID.Text != "")
            {
                objMs.MealID = txtMealID.Text;
            }
            else
            {
                objMs.MealID = "";
            }

            objMs.MealName = txtMealName.Text;
            objMs.StartTime = StartTime.Text;
            objMs.EndTime = EndTime.Text ;

            if (txtRemarks.Text != "")
            {
                objMs.Remarks = txtRemarks.Text;
            }
            else
            {
                objMs.Remarks = "";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objMs.EntryParameter = ep;
            return objMs;
        }
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

                    MealSetup objMs = this.PopulateMealSetup();
                    int i = fnbs.InsertMealsetup(objMs);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtMealID.Text = "";
                        txtMealName.Text = "";
                        txtRemarks.Text = "";
                        txtMealName.Focus();
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

                MealSetup objMs = this.PopulateMealSetup();
                int i = fnbs.UpdateMealsetup(objMs);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadListView();
                    txtMealID.Text = "";
                    txtMealName.Text = "";
                    txtRemarks.Text = "";
                    txtMealName.Focus();
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

        private void frmMealSetupConfig_Load(object sender, System.EventArgs e)
        {

            //StartTime.Value = StartTime.Value.ToString("HH:MM:SS tt");
            FormaList();
            LoadListView();
        
        }

        private void txtMealName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                StartTime.Focus();
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

        private void lvwMealSetup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvwMealSetup.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwMealSetup.SelectedItems[0];
                txtMealID.Text = itm.SubItems[0].Text;
                txtMealName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[2].Text;
                StartTime.Text = itm.SubItems[3].Text;
                EndTime.Text = itm.SubItems[4].Text;
                txtMealName.Focus();
            }
        }

        private void StartTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                EndTime.Focus();
            }
        }

        private void EndTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }










    }
}
