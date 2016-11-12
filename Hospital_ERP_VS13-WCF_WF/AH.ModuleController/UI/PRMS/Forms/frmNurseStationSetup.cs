using System;
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
    public partial class frmNurseStationSetup : AH.Shared.UI.frmSmartFormStandard
    {
        PRMSSR.PRMSWSClient prsSC = new PRMSSR.PRMSWSClient();
        public frmNurseStationSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtNurseStationName", "txtNurseStationNameBeng", "cboFloorNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lstViewNurseStation, 1, txtNurseStationName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNurseStationName.Focus();
                    return;
                }

                NurseStation oNurse = this.PopulateNurseStation();
                short i = prsSC.SaveNurseStation(oNurse);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtNurseStationName.Focus();
                    RefreshGrid();
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
            lstViewNurseStation.CheckBoxes = false;
            lstViewNurseStation.Columns.Add("Floor Number", 40, HorizontalAlignment.Center);
            lstViewNurseStation.Columns.Add("Nurse Station ID", 100, HorizontalAlignment.Center);
            lstViewNurseStation.Columns.Add("Nurse Station Name", 200, HorizontalAlignment.Left);
            lstViewNurseStation.Columns.Add("Nurse Station Name(Bangla)", 200, HorizontalAlignment.Left);
            //lstViewNurseStation.Columns.Add("Room", 100, HorizontalAlignment.Left);
            lstViewNurseStation.Columns.Add("Intercom Number", 60, HorizontalAlignment.Left);
            lstViewNurseStation.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }

        private NurseStation PopulateNurseStation()
        {
            NurseStation oNurse = new NurseStation();
            oNurse.NurseStationID = txtNurseStationId.Text;
            oNurse.NurseStationTitle = txtNurseStationName.Text;
            oNurse.NurseStationTitleBangla = txtNurseStationNameBeng.Text;
            oNurse.Remarks = txtRemarks.Text;
            Room oRoom = new Room();
            oRoom.RoomID = "211";// cboRoomId.SelectedValue.ToString();
            oNurse.Room = oRoom;
            oNurse.FloorNo =Convert.ToInt32(cboFloorNo.SelectedValue.ToString());
            oNurse.IntercomNo = txtIntercomNo.Text;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oNurse.EntryParameter = ep;
            return oNurse;
        }
        private void LoadListView()
        {
            lstViewNurseStation.Items.Clear();

            List<NurseStation> dtps = prsSC.GetNurseAllStation().ToList();
            //int i = 0;
            foreach (NurseStation di in dtps)
            {
                ListViewItem itm = new ListViewItem(di.FloorNo.ToString());
                itm.SubItems.Add(di.NurseStationID);
                itm.SubItems.Add(di.NurseStationTitle);
                itm.SubItems.Add(di.NurseStationTitleBangla);
                itm.SubItems.Add(di.IntercomNo);
                itm.SubItems.Add(di.Remarks);
                lstViewNurseStation.Items.Add(itm);
            }

        }

        private void frmDeliveryType_Load(object sender, EventArgs e)
        {
            
                FormatGrid();
                LoadListView();
                txtNurseStationName.Select();            
                cboFloorNo.DataSource = Utility.GetNumbers(1,11);
           
        }

        private void lvDeliv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstViewNurseStation.SelectedItems.Count > 0)
                {
                    ListViewItem itm = lstViewNurseStation.SelectedItems[0];
                    cboFloorNo.Text = itm.SubItems[0].Text;
                    txtNurseStationId.Text = itm.SubItems[1].Text;
                    txtNurseStationName.Text = itm.SubItems[2].Text;
                    txtNurseStationNameBeng.Text = itm.SubItems[3].Text;
                    txtIntercomNo.Text = itm.SubItems[4].Text; 
                    txtRemarks.Text = itm.SubItems[5].Text;
                }
                txtNurseStationId.Enabled = false;
                btnSave.Enabled = false;
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
            List<string> vf = new List<string>() { "txtNurseStationId", "txtNurseStationName", "txtNurseStationNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }        
            try
            {
                NurseStation oNurse = this.PopulateNurseStation();
                short i = prsSC.UpdateNurseStation(oNurse);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtNurseStationName.Focus();
                    RefreshGrid();
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
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
