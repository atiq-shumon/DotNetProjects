using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmUnitSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmUnitSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtUnitName", "txtUnitNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                DepartmentUnit dunitobj = this.PopulateDunitSetup();
                if (Utility.IsDuplicateFoundInList(lvUnit, 1, txtUnitName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtUnitName.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveUnit(dunitobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();                        
                        RefreshGrid();
                        txtUnitName.Text = "";
                        txtUnitNameBeng.Text = "";
                        txtRemarks.Text = "";
                        txtUnitName.Focus();
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
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvUnit.CheckBoxes = false;
            lvUnit.Columns.Add("Unit Id", 100, HorizontalAlignment.Center);
            lvUnit.Columns.Add("Unit Name", 200, HorizontalAlignment.Left);
            lvUnit.Columns.Add("Unit Name(Beng)", 200, HorizontalAlignment.Left);
            lvUnit.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvUnit.Columns.Add("Remarks", 340, HorizontalAlignment.Left);

        }

        private DepartmentUnit PopulateDunitSetup()
        {
            DepartmentUnit tdunit = new DepartmentUnit();
            tdunit.UnitId = txtUnitID.Text;
            tdunit.UnitTitle = txtUnitName.Text;
            tdunit.UnitTitleBeng = txtUnitNameBeng.Text;
            tdunit.Remarks = txtRemarks.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdunit.EntryParameter = ep;
            return tdunit;
        }

        private void frmUnitSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtUnitName.Focus();
        }
        private void LoadListView()
        {
            lvUnit.Items.Clear();

            List<DepartmentUnit> unit = hmsSC.GetUnits().ToList();
            foreach (DepartmentUnit ut in unit)
            {
                ListViewItem itm = new ListViewItem(ut.UnitId);
                itm.SubItems.Add(ut.UnitTitle);
                itm.SubItems.Add(ut.UnitTitleBeng);
                itm.SubItems.Add(ut.Serial.ToString());
                itm.SubItems.Add(ut.Remarks);
                lvUnit.Items.Add(itm);
            }
        }

        private void lvUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUnit.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvUnit.SelectedItems[0];
                txtUnitID.Text = itm.SubItems[0].Text;
                txtUnitName.Text = itm.SubItems[1].Text;
                txtUnitNameBeng.Text = itm.SubItems[2].Text;
                txtSerial.Text = itm.SubItems[3].Text;
                txtRemarks.Text = itm.SubItems[4].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"txtUnitID","txtUnitName","txtUnitNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyUnit(txtUnitID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                DepartmentUnit dunitobj = this.PopulateDunitSetup();
                short i = hmsSC.UpdateUnit(dunitobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtUnitID.Text = "";
                    txtUnitName.Text = "";
                    txtUnitNameBeng.Text = "";
                    txtRemarks.Text = "";
                    txtUnitName.Focus();
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

        private void lvUnit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            txtUnitNameBeng.Text = txtUnitName.Text;
        }
    }
}
