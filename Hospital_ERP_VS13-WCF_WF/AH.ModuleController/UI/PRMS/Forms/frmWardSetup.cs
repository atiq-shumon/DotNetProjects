using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PRMSSR;

namespace AH.ModuleController.UI.PRMS.Forms
{
    public partial class frmWardSetup : AH.Shared.UI.frmSmartFormStandard
    {
        bool isChecking;
        bool canCheck;
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmWardSetup()
        {
            InitializeComponent();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            List<string> vf = new List<string>() { "txtWardNo", "txtWardName", "txtWardNameBang", "txtNoRoom", "txtBlockNo", "txtTotalBed" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Ward twrd = this.PopulateWardsetup();
                short i = prsSC.SaveWardsetup(twrd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtWardNo.Select();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private Ward PopulateWardsetup()
        {
            Ward trdobj = new Ward();
            trdobj.WardID = txtWardID.Text;
            trdobj.WardTitle = txtWardName.Text;
            trdobj.WardTitleBeng = txtWardNameBang.Text;
            trdobj.WardNo = txtWardNo.Text;
            trdobj.BuildingID = cboBuildID.SelectedValue.ToString();
            trdobj.NthFloor = cboFloorNo.Text;
            trdobj.BlockNo = txtBlockNo.Text;
            trdobj.NoRoom = Int32.Parse(txtNoRoom.Text);
            trdobj.TotalBed = Int16.Parse(txtTotalBed.Text);
            trdobj.AllowedGender = cboGender.SelectedValue.ToString();
            trdobj.AgeGroupMin = txtAgeGroupMin.Text;
            trdobj.AgeGroupMax = txtAgeGroupMax.Text;
            trdobj.SerialPriority = short.Parse(cboSerialPriority.Text);

            trdobj.isGenderRestricted = chkGender.Checked ? "1" : "0";
            trdobj.isAgeRestricted = chkAge.Checked ? "1" : "0";
            trdobj.isDepartmentRestricted = chkDepartment.Checked ? "1" : "0";


            trdobj.Remarks = txtRemarks.Text;

            BedType btp = new BedType();
            btp.ID = cboBedType.SelectedValue.ToString();
            trdobj.BedType = btp;

            Department tdep = new Department();
            tdep.DepartmentID = "0001";
            trdobj.Department = tdep;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            trdobj.EntryParameter = ep;

            return trdobj;
        }
        private void FormatGrid()
        {
            lvWardSetup.CheckBoxes = false;
            lvWardSetup.Columns.Add("Ward ID", 125, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Ward No", 125, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("Ward Name", 220, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("Ward Name(Bangla)", 220, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("Department ID", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Floor No", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Block", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Room", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Bed", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Gender", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("IsGenderRestricted", 50, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("IsDeptRestricted", 50, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("IsAgeRestricted", 50, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("AgeGroupMin", 0, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("AgeGroupMax", 0, HorizontalAlignment.Left);
            lvWardSetup.Columns.Add("Serial Prior", 0, HorizontalAlignment.Center);
            lvWardSetup.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }

        private void frmWardSetup_Load(object sender, EventArgs e)
        {
            List<short> ListValues = prsSC.GetNumbers(0, 21).ToList();
            cboFloorNo.DataSource = ListValues;

            List<short> ListItems = prsSC.GetNumbers(0, 6).ToList();
            cboSerialPriority.DataSource = ListItems;

            cboBedType.DisplayMember = "Value";
            cboBedType.ValueMember = "Key";
            cboBedType.DataSource = new BindingSource(prsSC.GetBedtypeDict("F"), null);

            cboBuildID.DisplayMember = "Value";
            cboBuildID.ValueMember = "Key";
            cboBuildID.DataSource = new BindingSource(prsSC.GetBuildingDict("D"), null);

            cboDept.DisplayMember = "Value";
            cboDept.ValueMember = "Key";
            cboDept.DataSource = new BindingSource(prsSC.GetDepartmentDict("E"), null);

            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";
            cboGender.DataSource = new BindingSource(prsSC.GetGenderDict("F"), null);

            cboDept.Enabled = false;
            txtAgeGroupMin.Enabled = false;
            txtAgeGroupMax.Enabled = false;
            cboGender.Enabled = false;

            txtWardNo.Select();
            FormatGrid();
            LoadListView();
        }
        private void LoadListView()
        {
            lvWardSetup.Items.Clear();

            List<Ward> wrds = prsSC.GetWards().ToList();
            int i = 0;
            foreach (Ward twrd in wrds)
            {
                ListViewItem itm = new ListViewItem(twrd.WardID);
                itm.SubItems.Add(twrd.WardNo);
                itm.SubItems.Add(twrd.WardTitle);
                itm.SubItems.Add(twrd.WardTitleBeng);
                itm.SubItems.Add(twrd.Department.DepartmentTitle);
                itm.SubItems.Add(twrd.NthFloor);
                itm.SubItems.Add(twrd.BlockNo);
                itm.SubItems.Add(twrd.NoRoom.ToString());
                itm.SubItems.Add(twrd.TotalBed.ToString());
                itm.SubItems.Add(twrd.AllowedGender);
                itm.SubItems.Add(twrd.isGenderRestricted);
                itm.SubItems.Add(twrd.isDepartmentRestricted);
                itm.SubItems.Add(twrd.isAgeRestricted);
                itm.SubItems.Add(twrd.AgeGroupMin);
                itm.SubItems.Add(twrd.AgeGroupMax);
                itm.SubItems.Add(twrd.SerialPriority.ToString());
                itm.SubItems.Add(twrd.Remarks);
                lvWardSetup.Items.Add(itm);
            }
        }

        private void lvWardSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWardSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvWardSetup.SelectedItems[0];
                txtWardID.Text = itm.SubItems[0].Text;
                txtWardNo.Text = itm.SubItems[1].Text;
                txtWardName.Text = itm.SubItems[2].Text;
                txtWardNameBang.Text = itm.SubItems[3].Text;
                cboDept.Text = itm.SubItems[4].Text;
                cboFloorNo.Text = itm.SubItems[5].Text;
                txtBlockNo.Text = itm.SubItems[6].Text;
                txtNoRoom.Text = itm.SubItems[7].Text;
                txtTotalBed.Text = itm.SubItems[8].Text;
                cboGender.SelectedValue = itm.SubItems[9].Text;
                chkGender.Checked = itm.SubItems[10].Text == "1" ? true : false;
                chkDepartment.Checked = itm.SubItems[11].Text == "1" ? true : false;
                chkAge.Checked = itm.SubItems[12].Text == "1" ? true : false;
                txtAgeGroupMin.Text = itm.SubItems[13].Text;
                txtAgeGroupMax.Text = itm.SubItems[14].Text;
                cboSerialPriority.Text = itm.SubItems[15].Text;
                txtRemarks.Text = itm.SubItems[16].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtWardID", "txtWardName", "txtWardNameBang" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (prsSC.VerifyWardSetup(txtWardID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWardID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                Ward twrd = this.PopulateWardsetup();
                short i = prsSC.UpdateWardSetup(twrd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtWardName.Focus();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }



        private void smartLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtAgeGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel16_Click(object sender, EventArgs e)
        {

        }

        private void smartTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void chkGender_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                cboGender.Enabled = true;

            }
            else
            {
                cboGender.Enabled = false;
            }
        }

        private void chkAge_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                txtAgeGroupMin.Enabled = true;
                txtAgeGroupMax.Enabled = true;

            }
            else
            {
                txtAgeGroupMin.Enabled = false;
                txtAgeGroupMax.Enabled = false; ;
            }
        }

        private void chkDepartment_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                cboDept.Enabled = true;

            }
            else
            {
                cboDept.Enabled = false;
            }
        }

        private void lvWardSetup_ItemCheck(object sender, ItemCheckEventArgs e)
        {


        }

    }
}
