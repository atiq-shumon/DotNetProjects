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
    public partial class frmRoomSetup : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmRoomSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (prsSC.VerifyRoomSetup(txtRoomNo.Text) > 0)
            {
                MessageBox.Show("Roomno Already Exist");
                btnNew.PerformClick();
                return;
            }
            List<string> vf = new List<string>() { "txtRoomNo", "txtRoomName", "txtRoomNameBeng", "txtBlockNo", "txtLocation", "txtRoomSize" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Room trm = this.PopulateRoomsetup();
                short i = prsSC.SaveRoomsetup(trm);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtRoomName.Focus();
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
            LoadListView(cboBuildID.SelectedValue.ToString(), cboRoomTypeID.SelectedValue.ToString());
        }
        private Room PopulateRoomsetup()
        {
            Room trmobj = new Room();
            trmobj.RoomID = txtRoomID.Text;
            trmobj.RoomTitle = txtRoomName.Text;
            trmobj.RoomTitleBeng = txtRoomNameBeng.Text;
            trmobj.RoomNo = short.Parse(txtRoomNo.Text);
            trmobj.Block = txtBlockNo.Text;
            trmobj.Floor = cboFloorNo.SelectedValue.ToString();
            trmobj.Location = txtLocation.Text;
            trmobj.RoomSft = txtRoomSize.Text;
            trmobj.TotalBed = Int16.Parse(txtTotalBed.Text);
            trmobj.AllowedGender = cboGender.SelectedValue.ToString();
            trmobj.AgeGroupMin = txtAgeGroupMin.Text;
            trmobj.AgeGroupMax = txtAgeGroupMax.Text;
            trmobj.SerialPriority = short.Parse(cboSerialPriority.Text);

            trmobj.isGenderRestricted = chkGender.Checked ? "1" : "0";
            trmobj.isAgeRestricted = chkAge.Checked ? "1" : "0";
            trmobj.isDepartmentRestricted = chkDepartment.Checked ? "1" : "0";

            Department deptobj = new Department();
            deptobj.DepartmentID = cboDept.SelectedValue.ToString();
            trmobj.Department = deptobj;

            Building bldobj = new Building();
            bldobj.BuildingID = cboBuildID.SelectedValue.ToString();
            trmobj.Building = bldobj;

            RoomType rmtps = new RoomType();
            rmtps.ID = cboRoomTypeID.SelectedValue.ToString();
            trmobj.RoomType = rmtps;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            trmobj.EntryParameter = ep;


            return trmobj;
        }
        private void FormatGrid()
        {
            lvRoomSetup.CheckBoxes = false;
            lvRoomSetup.Columns.Add("Room ID", 100, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Room Name", 180, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("Room Name(Bangla)", 180, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("Building", 0, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Room", 0, HorizontalAlignment.Center);
            //lvRoomSetup.Columns.Add("Dept", 0, HorizontalAlignment.Center);

            lvRoomSetup.Columns.Add("Room No", 100, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Block", 0, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Floor No", 100, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Room Location", 150, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("Room Size(sqft)", 165, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("Bed", 0, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("Gender", 0, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("IsGenderRestricted", 50, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("IsDeptRestricted", 50, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("IsAgeRestricted", 50, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("AgeGroupMin", 0, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("AgeGroupMax", 0, HorizontalAlignment.Left);
            lvRoomSetup.Columns.Add("Serial Prior", 0, HorizontalAlignment.Center);
            lvRoomSetup.Columns.Add("RoomType", 0, HorizontalAlignment.Left);
        }

        private void frmRoomSetup_Load(object sender, EventArgs e)
        {
            List<short> ListValues = prsSC.GetNumbers(0, 21).ToList();
            cboFloorNo.DataSource = ListValues;

            List<short> ListItems = prsSC.GetNumbers(0, 6).ToList();
            cboSerialPriority.DataSource = ListItems;

            cboBuildID.DisplayMember = "Value";
            cboBuildID.ValueMember = "Key";
            cboBuildID.DataSource = new BindingSource(prsSC.GetBuildingDict("D"), null);

            cboDept.DisplayMember = "Value";
            cboDept.ValueMember = "Key";
            cboDept.DataSource = new BindingSource(prsSC.GetDepartmentDict("E"), null);

            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";
            cboGender.DataSource = new BindingSource(prsSC.GetGenderDict("F"), null);

            //cboDeptID.DisplayMember = "Value";
            //cboDeptID.ValueMember = "Key";
            //cboDeptID.DataSource = new BindingSource(prsSC.GetDepartmentDict("E"), null);

            cboRoomTypeID.DisplayMember = "Value";
            cboRoomTypeID.ValueMember = "Key";
            cboRoomTypeID.DataSource = new BindingSource(prsSC.GetRoomTypeDict("E"), null);

            cboDept.Enabled = false;
            txtAgeGroupMin.Enabled = false;
            txtAgeGroupMax.Enabled = false;
            cboGender.Enabled = false;

            FormatGrid();
            //LoadListView();
        }
        private void LoadListView(string building,string roomtype)
        {
            lvRoomSetup.Items.Clear();

            List<Room> rms ; 
            if(building.Length != 0 || roomtype.Length != 0)
            {

                rms = prsSC.GetRoomByBuild(building,roomtype).ToList();
            }
            else
            {
                return;
            }

            int i = 0;
            foreach (Room trm in rms)
            {
                ListViewItem itm = new ListViewItem(trm.RoomID);
                itm.SubItems.Add(trm.RoomTitle);
                itm.SubItems.Add(trm.RoomTitleBeng);
                itm.SubItems.Add(trm.Building.BuildingID);
                itm.SubItems.Add(trm.RoomType.ID);
                //itm.SubItems.Add(trm.Department.DepartmentID);
                itm.SubItems.Add(trm.RoomNo.ToString());
                itm.SubItems.Add(trm.Block);
                itm.SubItems.Add(trm.Floor);
                itm.SubItems.Add(trm.Location);
                itm.SubItems.Add(trm.RoomSft);
                itm.SubItems.Add(trm.TotalBed.ToString());
                itm.SubItems.Add(trm.AllowedGender);
                itm.SubItems.Add(trm.isGenderRestricted);
                itm.SubItems.Add(trm.isDepartmentRestricted);
                itm.SubItems.Add(trm.isAgeRestricted);
                itm.SubItems.Add(trm.AgeGroupMin);
                itm.SubItems.Add(trm.AgeGroupMax);
                itm.SubItems.Add(trm.SerialPriority.ToString());
                itm.SubItems.Add(trm.RoomType.ToString());
                lvRoomSetup.Items.Add(itm);
            }

        }

        private void lvRoomSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoomSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvRoomSetup.SelectedItems[0];
                txtRoomID.Text = itm.SubItems[0].Text;
                txtRoomName.Text = itm.SubItems[1].Text;
                txtRoomNameBeng.Text = itm.SubItems[2].Text;
                cboBuildID.SelectedValue = itm.SubItems[3].Text;
                cboRoomTypeID.SelectedValue = itm.SubItems[4].Text;
                //cboDeptID.SelectedValue = itm.SubItems[5].Text;
                txtRoomNo.Text = itm.SubItems[5].Text;
                txtBlockNo.Text = itm.SubItems[6].Text;
                cboFloorNo.Text = itm.SubItems[7].Text;
                txtLocation.Text = itm.SubItems[8].Text;
                txtRoomSize.Text = itm.SubItems[9].Text;
                txtTotalBed.Text = itm.SubItems[10].Text;
                cboGender.SelectedValue = itm.SubItems[11].Text;
                chkGender.Checked = itm.SubItems[12].Text == "1" ? true : false;
                chkDepartment.Checked = itm.SubItems[13].Text == "1" ? true : false;
                chkAge.Checked = itm.SubItems[14].Text == "1" ? true : false;
                txtAgeGroupMin.Text = itm.SubItems[15].Text;
                txtAgeGroupMax.Text = itm.SubItems[16].Text;
                cboSerialPriority.Text = itm.SubItems[17].Text;
                cboRoomTypeID.Text = itm.SubItems[18].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtRoomID", "txtRoomName", "txtRoomNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //if (prsSC.VerifyRoomSetup(txtRoomID.Text) == 0)
            //{
            //    MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtRoomID.Select();
            //    btnNew.PerformClick();
            //    return;

            //}
            try
            {
                Room trm = this.PopulateRoomsetup();
                short i = prsSC.UpdateRoomSetup(trm);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtRoomName.Focus();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(cboBuildID.SelectedValue.ToString(),cboRoomTypeID.SelectedValue.ToString());
        }
    }
}
