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
    public partial class frmRoomGrpAssign : AH.Shared.UI.frmSmartFormStandard
    {
        public frmRoomGrpAssign()
        {
            InitializeComponent();
        }
         OPDSR.OPDWSClient opdSc = new OPDSR.OPDWSClient();
         List<OPDRoomGrpAssign> oRoomGrps = new List<OPDRoomGrpAssign>();

        private void frmRoomGrpAssign_Load(object sender, EventArgs e)
        {
            string BuildingID = "01";
            string RmType ="07";

            GetNursesStationId();
            RoomNo(BuildingID,RmType);
            FormatGrid();
            LoadListView();
            cboNsStnId.Select();
        }

        private void RoomNo(string BuildingID, string RmType)
        {
            cboRoomNo.ValueMember = "Key";
            cboRoomNo.DisplayMember = "Value";
            cboRoomNo.DataSource = new BindingSource(opdSc.GetOPDRoomsDict(BuildingID, RmType), null); 
        }
        private void GetNursesStationId()
        {  
            cboNsStnId.ValueMember = "Key";
            cboNsStnId.DisplayMember = "Value";
            cboNsStnId.DataSource = new BindingSource(opdSc.GetNurseStationDic("D"), null); 
        }
       /* 
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
            cboRoomNo.DataSource = new BindingSource(opdSc.GetRooms("D"), null);  //opdSc.GetRoomGroupByID(cboRoomGroup.SelectedValue.ToString()).ToList();
        }
        */
        private void FormatGrid()
        {
            lvlRoomGrpAssign.Clear();
            lvlRoomGrpAssign.Columns.Add("Nursing Station", 200, HorizontalAlignment.Center);
            lvlRoomGrpAssign.Columns.Add("Room ID", 0, HorizontalAlignment.Center);
            lvlRoomGrpAssign.Columns.Add("Room No", 200, HorizontalAlignment.Center);
            lvlRoomGrpAssign.Columns.Add("Entry Date", 300, HorizontalAlignment.Center);
        }

        private void LoadListView()
        {
            lvlRoomGrpAssign.Items.Clear();

            List<OPDRoomGrpAssign> oRmGrps = opdSc.GetRoomGroup().ToList();
          
            foreach (OPDRoomGrpAssign oRoom in oRmGrps)
            {
                ListViewItem itm = new ListViewItem(oRoom.RoomGroup);   //R Group            
                itm.SubItems.Add(Convert.ToString(oRoom.RoomID));       //R ID
                itm.SubItems.Add(Convert.ToString(oRoom.RoomNO));       //R Number  
                itm.SubItems.Add(oRoom.EntryParameter.EntryDate.ToString("dd-MM-yyyy"));
                lvlRoomGrpAssign.Items.Add(itm);
            }
            this.lvlRoomGrpAssign.View = View.Details;

        }
        private void LoadListViewBySearch(string roomgrp)
        {
            lvlRoomGrpAssign.Items.Clear();

            List<OPDRoomGrpAssign> oRmGrps = opdSc.GetRoomGroupByID(cboNsStnId.SelectedValue.ToString()).ToList();

            foreach (OPDRoomGrpAssign oRoom in oRmGrps)
            {
                ListViewItem itm = new ListViewItem(oRoom.RoomGroup);   //R Group            
                itm.SubItems.Add(Convert.ToString(oRoom.RoomID));        //R ID
                itm.SubItems.Add(Convert.ToString(oRoom.RoomNO));       //R Number  
                itm.SubItems.Add(oRoom.EntryParameter.EntryDate.ToString("dd-MM-yyyy"));
                lvlRoomGrpAssign.Items.Add(itm);
            }
            this.lvlRoomGrpAssign.View = View.Details;
        }  
    
        private OPDRoomGrpAssign PopulateObject()
        {
            OPDRoomGrpAssign oRoom = new OPDRoomGrpAssign();
            oRoom.RoomGroup =cboNsStnId.SelectedValue.ToString();
            oRoom.RoomID = cboRoomNo.SelectedValue.ToString();

            EntryParameter oEP = new EntryParameter();
            oEP.EntryBy = Utility.UserId;
            oRoom.EntryParameter = oEP;

            return oRoom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
//----------------------------------------------------OLD Version-----------------------------------------------------
            //List<string> vf = new List<string>() { "cboRoomGroup", "cboRoomNo" };
            //Control control = Utility.ReqFieldValidator(this, vf);
            //if (control != null)
            //{
            //    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            //    control.Focus();
            //    return;
            //}

            //oRoomGrps = opdSc.InsertRoomGroup(PopulateObject()).ToList();

            //if (oRoomGrps.Count > 0)
            //    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //FormatGrid();

            //LoadListView();

            //if (oRoomGrps[0].EntryParameter.ErrorMessage == null)
            //{
            //    lvlRoomGrpAssign.Items.Clear();

            //    foreach (Room oRoom in oRoomGrps)
            //    {

            //        ListViewItem itm = new ListViewItem(oRoom.RoomSft); //R Group
            //        //itm.SubItems.Add(Convert.ToString(oRoom.RoomSft));
            //        itm.SubItems.Add(Convert.ToString(oRoom.RoomID));
            //        itm.SubItems.Add(Convert.ToString(oRoom.RoomNo)); //R Number                 

            //        itm.SubItems.Add(oRoom.EntryParameter.EntryDate.ToString());
            //        lvlRoomGrpAssign.Items.Add(itm);
            //    }
            //    this.lvlRoomGrpAssign.View = View.Details;
            //    return;
            //}
//---------------------------------------------------------------------------------------------------------
            List<string> vf = new List<string>() { "cboNsStnId", "cboRoomNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //cboNsStnId.SelectedValue

            if (Utility.IsDuplicateFoundInList(lvlRoomGrpAssign, 2, cboRoomNo.Text))
            {
                MessageBox.Show("This Room Setup Already exists!!");
                return;
            }
            else
            {
                short oRoomGrps = opdSc.InsertRoomGroup(PopulateObject());

                if (oRoomGrps == 1)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            FormatGrid();
            LoadListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
         /*    List<string> vf = new List<string>() { "cboRoomGroup", "cboRoomNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

           // oRoomGrps = opdSc.UpdateRoomGroup(PopulateObject()).ToList();

            FormatGrid();

            LoadListView();

            if (oRoomGrps[0].EntryParameter.ErrorMessage == null)
            {
              lvlRoomGrpAssign.Items.Clear();

                //foreach (Room oRoom in oRoomGrps)
                //{
                //    ListViewItem itm = new ListViewItem(oRoom.RoomSft); //R Group
                //    //itm.SubItems.Add(Convert.ToString(oRoom.RoomSft));
                //    itm.SubItems.Add(Convert.ToString(oRoom.RoomID));
                //    itm.SubItems.Add(Convert.ToString(oRoom.RoomNo)); //R Number  
                //    itm.SubItems.Add(oRoom.EntryParameter.EntryDate.ToString());
                //    lvlRoomGrpAssign.Items.Add(itm);
                //}
                //this.lvlRoomGrpAssign.View = View.Details;
                //return;
            }
            //if (oRoomGrps[0].EntryParameter.ErrorMessage != "")
            //{
            //    MessageBox.Show(oRoomGrps[0].EntryParameter.ErrorMessage.ToString());
            //}  */
        }

        private void lvlRoomGrpAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (lvlRoomGrpAssign.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvlRoomGrpAssign.SelectedItems[0];
                cboNsStnId.Text = itm.SubItems[0].Text;
                //cboRoomNo.Text = itm.SubItems[1].Text;
                cboRoomNo.Text = itm.SubItems[2].Text;              
            }
        }

        private void smartLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cboRoomGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByRoomGroup_Click(object sender, EventArgs e)
        {
            LoadListViewBySearch(cboNsStnId.SelectedValue.ToString());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            LoadListView();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListView();
        }       
    }
}
