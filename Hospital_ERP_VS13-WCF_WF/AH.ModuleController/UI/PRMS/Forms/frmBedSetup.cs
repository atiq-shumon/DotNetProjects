using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PRMSSR;

namespace AH.ModuleController.UI.PRMS.Forms
{
    public partial class frmBedSetup : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmBedSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (prsSC.VerifyBedSetup(txtBedNo.Text) > 0)
            {
                MessageBox.Show("Bedno Already Exist");
                btnNew.PerformClick();
                return;
            }
            List<string> vf = new List<string>() { "txtBedNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (cboRoomID.SelectedItem == null)
            {
                MessageBox.Show("--Please select Room--");
            }
            
            try
            {
               
                Bed tbd = this.PopulateBedsetup();
                short i = prsSC.SaveBedsetup(tbd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    btnEdit.Enabled = false;  
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
        private Bed PopulateBedsetup()
        {
            Bed tbdobj = new Bed();
            tbdobj.BedID = txtBedID.Text;
            tbdobj.BedNo = txtBedNo.Text;
            tbdobj.BedStatus = cboBedStatus.SelectedValue.ToString();
            //tbdobj.SerialNo = short.Parse(txtSerialNo.Text == "" ? "0" : txtSerialNo.Text);
            //tbdobj.SerialNo = 50;
            tbdobj.Remarks = txtRemarks.Text;
            tbdobj.BedTitle = txtBedTitle.Text;
            tbdobj.BedTitleBeng = txtBedTitleBeng.Text;
            tbdobj.Floor = cboFloorNo.SelectedValue.ToString();
            //cboDeptID.Text = "0001";

            Building bld = new Building();
            bld.BuildingID = cboBuildID.SelectedValue.ToString();
            tbdobj.Building = bld;

            NurseStation ons = new NurseStation();
            ons.NurseStationID = cboNursingStation.SelectedValue.ToString();
            tbdobj.NurseStation = ons;

            
            Room trm = new Room();
            trm.RoomID = cboRoomID.SelectedValue.ToString();
            tbdobj.Room = trm;
            BedType bdtpe = new BedType();
            bdtpe.ID = cboBedTypeID.SelectedValue.ToString();
            tbdobj.BedType = bdtpe;
            BedFacility bfac = new BedFacility();
            bfac.ID = cboBedFacility.SelectedValue.ToString();
            tbdobj.Facility = bfac;
            //Department dpt = new Department();
            //dpt.DepartmentID = cboDeptID.SelectedValue.ToString();
            //tbdobj.Department = dpt;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tbdobj.EntryParameter = ep;

            return tbdobj;
        }
        private void FormatGrid()
        {
            lvBedSetup.Items.Clear();
            lvBedSetup.Columns.Add("Bed ID", 0, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Bed No", 80, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Bed Name", 120, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Bed Name Beng", 0, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Building", 200, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Room", 160, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("BedType", 130, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("BedFacility", 180, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Bed Status", 0, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("SerialNo", 0, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("Floor", 50, HorizontalAlignment.Left);
            lvBedSetup.Columns.Add("NurseStation", 150, HorizontalAlignment.Left);
        }

        private void frmBedSetup_Load(object sender, EventArgs e)
        {

            List<short> ListValues = prsSC.GetNumbers(0, 11).ToList();
            cboFloorNo.DataSource = ListValues;

            cboBedTypeID.DisplayMember = "Value";
            cboBedTypeID.ValueMember = "Key";
            cboBedTypeID.DataSource = new BindingSource(prsSC.GetBedtypeDict("F"), null);

            cboBedFacility.DisplayMember = "Value";
            cboBedFacility.ValueMember = "Key";
            cboBedFacility.DataSource = new BindingSource(prsSC.GetBedfacilityDict("D"), null);

            cboBedStatus.DisplayMember = "Value";
            cboBedStatus.ValueMember = "Key";
            cboBedStatus.DataSource = new BindingSource(prsSC.GetBedStatus(), null);

            cboBuildID.DisplayMember = "Value";
            cboBuildID.ValueMember = "Key";
            cboBuildID.DataSource = new BindingSource(prsSC.GetBuildingDict("D"), null);

            

            cboDeptID.DisplayMember = "Value";
            cboDeptID.ValueMember = "Key";
            cboDeptID.DataSource = new BindingSource(prsSC.GetDepartmentDict("E"), null);

            cboBuildID.SelectedIndexChanged += new EventHandler(cboBuildID_SelectedIndexChanged);

            FormatGrid();
            LoadListView();

            //cboRoomID.DataSource = null;
        }
        private void LoadListView()
        {
            lvBedSetup.Items.Clear();

            List<Bed> bds = prsSC.GetBeds().ToList();
            int i = 0;
            foreach (Bed tbd in bds)
            {
                ListViewItem itm = new ListViewItem(tbd.BedID);
                itm.SubItems.Add(tbd.BedNo);
                itm.SubItems.Add(tbd.BedTitle);
                itm.SubItems.Add(tbd.BedTitleBeng);
                itm.SubItems.Add(tbd.Building.BuildingTitle);
                itm.SubItems.Add(tbd.Room.RoomTitle);
                itm.SubItems.Add(tbd.BedType.Title);
                itm.SubItems.Add(tbd.Facility.Title);
                itm.SubItems.Add(tbd.BedStatus);
                itm.SubItems.Add(tbd.SerialNo.ToString());
                itm.SubItems.Add(tbd.Floor);
                itm.SubItems.Add(tbd.NurseStation.NurseStationTitle);
                lvBedSetup.Items.Add(itm);
            }
        }

        private void lvBedSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBedSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBedSetup.SelectedItems[0];
                txtBedID.Text = itm.SubItems[0].Text;
                txtBedNo.Text = itm.SubItems[1].Text;
                txtBedTitle.Text = itm.SubItems[2].Text;
                txtBedTitleBeng.Text = itm.SubItems[3].Text;
                cboBuildID.Text = itm.SubItems[4].Text;
                cboRoomID.Text = itm.SubItems[5].Text;
                cboBedTypeID.Text = itm.SubItems[6].Text;
                cboBedFacility.Text = itm.SubItems[7].Text;
                cboBedStatus.SelectedValue = itm.SubItems[8].Text;
                txtSerialNo.Text = itm.SubItems[9].Text;
                cboFloorNo.Text = itm.SubItems[10].Text;
                cboNursingStation.Text = itm.SubItems[11].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBedID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (cboRoomID.SelectedItem == null)
            {
                MessageBox.Show("--Please select Room--");
                return;
            }
            //if (prsSC.VerifyBedSetup(txtBedID.Text) == 0)
            //{
            //    MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtBedID.Select();
            //    btnNew.PerformClick();
            //    return;
            //}
            try
            {
                Bed tbd = this.PopulateBedsetup();
                short i = prsSC.UpdateBedSetup(tbd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();

                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtBedNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel15_Click(object sender, EventArgs e)
        {

        }

        private void cboRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboRoomID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            frmRoomSetup frm = new frmRoomSetup();
            frm.ShowDialog();
        }

        private void btnRoomRefresh_Click(object sender, EventArgs e)
        {
            cboRoomID.DisplayMember = "RoomTitle";
            cboRoomID.ValueMember = "RoomID";
            cboRoomID.DataSource = new BindingSource(prsSC.GetRoomByBuild(cboBuildID.SelectedValue.ToString(), "04"), null);
        }
        //private void LoadListViewByGroup(string bedtype,string roomid,string bedstatus)
        //{
        //    lvBedSetup.Items.Clear();



        //    List<Bed> bds ;
                
        //   if(bedtype.Length != 0 || roomid.Length != 0 || bedstatus.Length != 0)     
        //   {  
        //     bds   = prsSC.GetBedSets(bedtype,roomid,bedstatus).ToList();
        //   }
        //    else
        //   {
        //       return;
        //   }
        //    int i = 0;
        //    foreach (Bed tbd in bds)
        //    {
        //        ListViewItem itm = new ListViewItem(tbd.BedID);
        //        itm.SubItems.Add(tbd.BedNo);
        //        itm.SubItems.Add(tbd.BedTitle);
        //        itm.SubItems.Add(tbd.BedTitleBeng);
        //        itm.SubItems.Add(tbd.Building.BuildingTitle);
        //        itm.SubItems.Add(tbd.Room.RoomTitle);
        //        itm.SubItems.Add(tbd.BedType.Title);
        //        itm.SubItems.Add(tbd.Facility.Title);
        //        itm.SubItems.Add(tbd.BedStatus);
        //        itm.SubItems.Add(tbd.SerialNo.ToString());
        //        lvBedSetup.Items.Add(itm);
        //    }
        //}
        //private void LoadListViewByRmtp(string roomid,string bedtype)
        //{
        //    lvBedSetup.Items.Clear();

        //    List<Bed> bds;

        //    if (bedtype.Length != 0 || roomid.Length != 0)
        //    {
        //        bds = prsSC.GetBedByroom(roomid,bedtype).ToList();
        //    }
        //    else
        //    {
        //        return;
        //    }
        //    int i = 0;
        //    foreach (Bed tbd in bds)
        //    {
        //        ListViewItem itm = new ListViewItem(tbd.BedID);
        //        itm.SubItems.Add(tbd.BedNo);
        //        itm.SubItems.Add(tbd.BedTitle);
        //        itm.SubItems.Add(tbd.BedTitleBeng);
        //        itm.SubItems.Add(tbd.Building.BuildingTitle);
        //        itm.SubItems.Add(tbd.Room.RoomTitle);
        //        itm.SubItems.Add(tbd.BedType.Title);
        //        itm.SubItems.Add(tbd.Facility.Title);
        //        itm.SubItems.Add(tbd.BedStatus);
        //        itm.SubItems.Add(tbd.SerialNo.ToString());
        //        lvBedSetup.Items.Add(itm);
        //    }
        //}
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //LoadListViewByGroup(cboBedTypeID.SelectedValue.ToString(),cboRoomID.SelectedValue.ToString(),cboBedStatus.SelectedValue.ToString());
        }

        private void cboBedStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboBedStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadListViewByGroup(cboBedTypeID.SelectedValue.ToString(), cboRoomID.SelectedValue.ToString(), cboBedStatus.SelectedValue.ToString());
        }

        private void cboBedTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadListViewByRmtp(cboRoomID.SelectedValue.ToString(),cboBedTypeID.SelectedValue.ToString());
        }

        private void smartLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cboFloorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFloorNo.SelectedValue != null)
            {
                cboNursingStation.DisplayMember = "NurseStationTitle";
                cboNursingStation.ValueMember = "NurseStationID";
                cboNursingStation.DataSource = new BindingSource(prsSC.GetNurseStationFloorWise(Convert.ToInt32(cboFloorNo.SelectedValue)), null);
            }
        }

        private void cboBuildID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBuildID.SelectedValue != null)
            {
                cboRoomID.DisplayMember = "RoomTitle";
                cboRoomID.ValueMember = "RoomID";
                cboRoomID.DataSource = new BindingSource(prsSC.GetRoomByBuild(cboBuildID.SelectedValue.ToString(), "04"), null);
            }          
            //cboRoomID.DisplayMember = "Value";
            //cboRoomID.ValueMember = "Key";
            //cboRoomID.DataSource = new BindingSource(prsSC.GetRoomsDict("D"), null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

      

    }
}
