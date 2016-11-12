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
    public partial class frmOprtheter : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOprtheter()
        {
            InitializeComponent();
        }
        private void LoadModule()
        {
            try
            {
                cboDepID.ValueMember = "Key";
                cboDepID.DisplayMember = "Value";
                //cboDepID.DataSource = new BindingSource(accmSc.GetAnesthesiaGroups("D"), null);
                cboDepID.DataSource = new BindingSource(accmSc.GetDepID("HrsDep"), null);
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
        #region "Theater"
        private Theater PopulateTheater()
        {
            Theater Theater = new Theater();
            Theater.Buildid = txttheaterTitle.Text.ToString();
            Theater.FloorNo = txtFloorNo.Text.ToString();
            Theater.BlockNo = txtBlockNo.Text.ToString();
            Theater.RoomId = txtRoomNo.Text.ToString();
            Theater.Theaterid = txttheaterId.Text.ToString();
            Theater.Theatertitle = txttheaterTitle.Text.ToString();
            Theater.TheatertitleBangla = txttheaterTitle.Text.ToString();
            Theater.NoofFacilities = Convert.ToInt64(txtNoofFacilities.Text);
            if (cboDepSpeci.Text == "No")
            {
                Theater.DepSpe = "0";
            }
            else
            {
                Theater.DepSpe = "1";
            }
            Theater.DepId = cboDepID.SelectedValue.ToString();
            Theater.PhoneNo  = txtPhoneNo.Text.ToString();
            Theater.Inchargeid = txtInchargeID.Text.ToString();
            Theater.Remarks  = txtRemarks.Text.ToString();
            //Theater.Active  = cboStattus.Text.ToString().Substring(0,1);
            if (cboStattus.Text.ToString() == "Active")
            {
                    Theater.Active = "0";
            }
            else
            {
                Theater.Active = "1";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            Theater.EntryParameter = ep;
            return Theater;
        }
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtBuildID","txtRemarks","FloorNo","txttheaterTitle","txtNoofFacilities" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboStattus.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboStattus.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStattus.Focus();
                return false;
            }
            if (cboDepID.Text == "Select")
            {
                MessageBox.Show(Utility.getFMS(cboDepID.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDepID.Focus();
                return false;
            }
            return true;
        }
        private void FormatGrid()
        {
            lvwTheaterConfig.CheckBoxes = false;
            lvwTheaterConfig.Columns.Add("Build Id", 150, HorizontalAlignment.Center);
            lvwTheaterConfig.Columns.Add("Floor No", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Block No", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Theater Id", 320, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Theater title", 330, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("No of Facilities", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Phone No", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Incharge ID", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Status", 150, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Dep. Spe", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Dep ID", 0, HorizontalAlignment.Left);
            lvwTheaterConfig.Columns.Add("Room No", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwTheaterConfig.Items.Clear();
            List<Theater> theater = accmSc.GetTheater().ToList();
            foreach (Theater bo in theater)
            {
                ListViewItem itm = new ListViewItem(bo.Buildid);
                itm.SubItems.Add(bo.FloorNo);
                itm.SubItems.Add(bo.BlockNo);
                itm.SubItems.Add(bo.Theaterid);
                itm.SubItems.Add(bo.Theatertitle);
                itm.SubItems.Add(bo.NoofFacilities.ToString());
                itm.SubItems.Add(bo.PhoneNo);
                itm.SubItems.Add(bo.Inchargeid);
                itm.SubItems.Add(bo.Remarks);
                if (bo.Active == "0")
                {
                    itm.SubItems.Add("Active");
                }
                else
                {
                    itm.SubItems.Add("Inactive");
                }
                itm.SubItems.Add(bo.DepSpe.ToString());
                itm.SubItems.Add(bo.DepId.ToString());
                itm.SubItems.Add(bo.RoomId.ToString());
                lvwTheaterConfig.Items.Add(itm);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvwTheaterConfig, 1, txttheaterId.Text) == true)
                {
                    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                    return;
                }
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    Theater theater = this.PopulateTheater();
                    short i = accmSc.SavetheaterSetup(theater);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txttheaterId.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
        private void frmOprtheterNew_Load(object sender, EventArgs e)
        {
            try
            {
                txttheaterTitle.Select();
                FormatGrid();
                LoadListView();
                LoadModule();
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
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Theater theater = this.PopulateTheater();
                    short i = accmSc.UpdatetheaterSetup(theater);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txttheaterTitle.Select();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var strResponse = MessageBox.Show("Do U want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    Theater theater = this.PopulateTheater();
                    short i = accmSc.Deletetheater(theater);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.DeleteMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txttheaterId.Select();
                        LoadListView();

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
        #endregion "Theater"
        private void lvwTheaterConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTheaterConfig.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                txttheaterId.ReadOnly = true;
                ListViewItem itm = lvwTheaterConfig.SelectedItems[0];
                txtBuildID.Text = itm.SubItems[0].Text;
                txtFloorNo.Text = itm.SubItems[1].Text;
                txtBlockNo.Text = itm.SubItems[2].Text;
                txttheaterId.Text = itm.SubItems[3].Text;
                txttheaterTitle.Text = itm.SubItems[4].Text;
                txtNoofFacilities.Text = itm.SubItems[5].Text;
                txtPhoneNo.Text = itm.SubItems[6].Text;
                txtInchargeID.Text = itm.SubItems[7].Text;
                txtRemarks.Text = itm.SubItems[8].Text;
                if (itm.SubItems[9].Text == "Active")
                {
                    cboStattus.Text = "Active";
                }
                else
                {
                    cboStattus.Text = "Inactive";
                }
                if (itm.SubItems[10].Text =="0")
                {
                    cboDepSpeci.Text  = "No";
                }
                else
                {
                    cboDepSpeci.Text = "Yes";
                }
                cboDepID.SelectedValue = itm.SubItems[11].Text; ;
                txtRoomNo.Text = itm.SubItems[12].Text ;
                txttheaterTitle.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<CalenderOT> onl = accmSc.GetRegDetailsFromOperarion("OperationDettoRegId", "R0115-0000014").ToList();

                foreach (CalenderOT o in onl)
                {
                    MessageBox.Show(o.RegDate);
                    MessageBox.Show(o.Oprtype);
                    MessageBox.Show(o.OprID);
                    MessageBox.Show(o.PackageAmount.ToString());
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
            btnEdit.Enabled = false;
        }
    }
}
