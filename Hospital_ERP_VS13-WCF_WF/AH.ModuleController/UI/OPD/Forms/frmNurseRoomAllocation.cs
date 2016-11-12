using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.OPDSR;

namespace AH.ModuleController.UI.OPD.Forms
{
    public partial class frmNurseRoomAllocation : AH.Shared.UI.frmSmartFormStandard
    {
        OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
        List<OPDNurseRoomAllocation> oOPDNurRoomAlls = new List<OPDNurseRoomAllocation>();

        public frmNurseRoomAllocation()
        {
            InitializeComponent();
        }

        private void FormatGrid()
        {
            lvlNurseRoomSetup.Columns.Add("Room Group", 200, HorizontalAlignment.Center);
            lvlNurseRoomSetup.Columns.Add("Room No", 200, HorizontalAlignment.Center);
            //lvlNurseRoomSetup.Columns.Add("Nurse ID", 200, HorizontalAlignment.Center);
            lvlNurseRoomSetup.Columns.Add("Nurse Name", 200, HorizontalAlignment.Center);
            lvlNurseRoomSetup.Columns.Add("Entry Date", 230, HorizontalAlignment.Center);
        }

        private void LoadListView()
        {
            lvlNurseRoomSetup.Items.Clear();
            //List<OPDNurseRoomAllocation> oOPDNurRoomAlls = new List<OPDNurseRoomAllocation>();
            oOPDNurRoomAlls = opdSc.GetNurseRoom().ToList();
            lvlNurseRoomSetup.Items.Clear();
            foreach (OPDNurseRoomAllocation oNRA in oOPDNurRoomAlls)
            {
                ListViewItem itm = new ListViewItem(oNRA.RoomGroup);
                itm.SubItems.Add(Convert.ToString(oNRA.Room.RoomNo));
                //itm.SubItems.Add(oNRA.Nurse.ID);
                itm.SubItems.Add(oNRA.Nurse.Name);
                itm.SubItems.Add(oNRA.EntryParameter.EntryDate.ToString());
                lvlNurseRoomSetup.Items.Add(itm);
            }
            this.lvlNurseRoomSetup.View = View.Details;
        }
        
        private void LoadNurse()
        {
            cboNurse.ValueMember = "Key";
            cboNurse.DisplayMember = "Value";
            cboNurse.DataSource = new BindingSource(opdSc.GetNurses("D"), null);
        }

        private void LoadRoomGroup()
        {
            cboRoomGroup.ValueMember = "Key";
            cboRoomGroup.DisplayMember = "Value";
            cboRoomGroup.DataSource = new BindingSource(Utility.GetNumbers(1, 5), null);
        }
        private void LoadRoom()
        {
            cboRoomNo.ValueMember = "Key";
            cboRoomNo.DisplayMember = "Value";
            cboRoomNo.DataSource = new BindingSource(opdSc.GetRooms("D"), null);
        }

        private void frmNurseRoomAllocation_Load(object sender, EventArgs e)
        {
            FormatGrid();            
            LoadListView();
            LoadRoomGroup();
            LoadRoom();
            LoadNurse();
        }

        private OPDNurseRoomAllocation PopulateObject()
        {
            OPDNurseRoomAllocation oNRA = new OPDNurseRoomAllocation();
            EntryParameter oEP = new EntryParameter();
            Room oRoom = new Room();
            Nurse oNurse = new Nurse();

            oRoom.RoomID = cboRoomNo.SelectedValue.ToString();
            oNRA.Room = oRoom;

            oNRA.RoomGroup = cboRoomGroup.SelectedValue.ToString();
            oNurse.ID = cboNurse.SelectedValue.ToString();
            oNRA.Nurse = oNurse;
            oEP.CompanyID = Utility.CompanyID;
            oEP.LocationID = Utility.LocationID;
            oEP.MachineID = Utility.MachineID;
            oEP.EntryBy = Utility.UserId;
            oNRA.EntryParameter = oEP;
            return oNRA;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<OPDNurseRoomAllocation> oOPDNurseRoomAllocations = new List<OPDNurseRoomAllocation>();
            oOPDNurRoomAlls = opdSc.InsertNurseRoom(PopulateObject()).ToList();
            lvlNurseRoomSetup.Items.Clear();
            LoadListView();
            //foreach (OPDNurseRoomAllocation oNRA in oOPDNurRoomAlls)
            //{
            //    ListViewItem itm = new ListViewItem(oNRA.RoomGroup);
            //    //itm.SubItems.Add(oNRA.Nurse.ID);
            //    itm.SubItems.Add(oNRA.Nurse.Name);
            //    //itm.SubItems.Add(oNRA.EntryParameter.EntryDate.ToString());
            //    lvlNurseRoomSetup.Items.Add(itm);
            //}
            this.lvlNurseRoomSetup.View = View.Details;
        }

        public class RefreshDataGrid
        {
            public string RoomGroup { get; set; }
            public string RoomNo { get; set; }
            public string ID { get; set; }
            public string Name { get; set;}
            public string EntryDate { get; set; }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<RefreshDataGrid> oRDGs = new List<RefreshDataGrid>();
            if (oOPDNurRoomAlls.Count > 0)
            {
                for (int i = 0; i < oOPDNurRoomAlls.Count; i++)
                {
                    if (oOPDNurRoomAlls[i].RoomGroup == cboRoomGroup.SelectedValue.ToString())
                    {
                        RefreshDataGrid oRDG = new RefreshDataGrid();
                        oRDG.RoomGroup = oOPDNurRoomAlls[i].RoomGroup;
                        oRDG.RoomNo = Convert.ToString(oOPDNurRoomAlls[i].Room.RoomNo);
                        //oRDG.ID = oOPDNurRoomAlls[i].Nurse.ID;
                        oRDG.Name = oOPDNurRoomAlls[i].Nurse.Name;
                        //oRDG.EntryDate = oOPDNurRoomAlls[i].EntryParameter.EntryDate.ToString();                       
                        oRDGs.Add(oRDG);
                    }

                }
                lvlNurseRoomSetup.Items.Clear();
                foreach (RefreshDataGrid oDSetup in oRDGs)
                {
                    ListViewItem itm = new ListViewItem(oDSetup.RoomGroup);
                    itm.SubItems.Add(oDSetup.RoomNo);
                    //itm.SubItems.Add(oDSetup.RoomNo);
                    //itm.SubItems.Add(oDSetup.ID);
                    itm.SubItems.Add(oDSetup.Name);
                    // itm.SubItems.Add(oDSetup.EntryDate);
                    lvlNurseRoomSetup.Items.Add(itm);
                }
                this.lvlNurseRoomSetup.View = View.Details;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lvlNurseRoomSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlNurseRoomSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvlNurseRoomSetup.SelectedItems[0];
                cboRoomGroup.Text = itm.SubItems[0].Text;
                cboRoomNo.Text = itm.SubItems[1].Text;
                cboNurse.Text = itm.SubItems[2].Text;  
            }
        }

        private void cboRoomGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
    }
}
