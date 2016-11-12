using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using AH.DUtility;
using AH.ModuleController.HRSR;
using System.Drawing.Drawing2D;
using System.IO;

using System.Drawing.Imaging;


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmLeaveDaysSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmLeaveDaysSetup()
        {
            InitializeComponent();
        }

        private void frmLeaveDaysSetup_Load(object sender, EventArgs e)
        {
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2014,2031), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            cboLeaveType.DisplayMember = "Value";
            cboLeaveType.ValueMember = "Key";
            cboLeaveType.DataSource = new BindingSource(hmsSC.GetLeaveID("D"), null);

            FormatGrid();
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboLeaveType", "txtDays", "txtReqDays", "txtReqWithin"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvLeaveDays, 2, txtDays.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtDays.Focus();
                    return;
                }              
                    else
                    {
                        LeaveDaysSetup oLvDaysSet = this.PopulateLeaveDays();
                        short i = hmsSC.SaveLeaveDays(oLvDaysSet);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                            RefreshGrid();
                            txtDays.Text = "";
                            txtReqDays.Text = "";
                            txtReqWithin.Text = "";
                            txtRemarks.Text = "";
                            txtDays.Focus();
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


        private LeaveDaysSetup PopulateLeaveDays()
        {
            LeaveDaysSetup oLvDaysSet = new LeaveDaysSetup();

            oLvDaysSet.year = cboYear.SelectedValue.ToString();
            LeaveType olvType = new LeaveType();
            olvType.TypeID = cboLeaveType.SelectedValue.ToString();
            oLvDaysSet.LeaveType = olvType;            
            oLvDaysSet.days = txtDays.Text;
            oLvDaysSet.ReqDays = txtReqDays.Text.ToString();
            oLvDaysSet.ReqWithin = txtReqWithin.Text.ToString();
            oLvDaysSet.Reamrks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oLvDaysSet.EntryParameter = ep;
            return oLvDaysSet;

        }
        private void RefreshGrid()
        {
            LoadListView(cboYear.SelectedValue.ToString());
        }
        private void FormatGrid()
        {
            lvLeaveDays.CheckBoxes = false;
            lvLeaveDays.Columns.Add("Year", 100, HorizontalAlignment.Center);
            lvLeaveDays.Columns.Add("Leave Type", 200, HorizontalAlignment.Left);
            lvLeaveDays.Columns.Add("Days", 100, HorizontalAlignment.Center);
            lvLeaveDays.Columns.Add("Req Days", 100, HorizontalAlignment.Center);
            lvLeaveDays.Columns.Add("Req Within", 100, HorizontalAlignment.Center);  
            lvLeaveDays.Columns.Add("Remarks", 250, HorizontalAlignment.Left);
        }
        private void LoadListView(string oLvTpSet)
        {
            lvLeaveDays.Items.Clear();
            List<LeaveDaysSetup> oLvDaysSets = new List<LeaveDaysSetup>();
            oLvDaysSets = hmsSC.GetLeaveDay(cboYear.SelectedValue.ToString()).ToList();
            foreach (LeaveDaysSetup oLvDay in oLvDaysSets)
            {
                ListViewItem itm = new ListViewItem(oLvDay.year);
                itm.SubItems.Add(oLvDay.LeaveType.TypeID);
                itm.SubItems.Add(oLvDay.days);
                itm.SubItems.Add(oLvDay.ReqDays);
                itm.SubItems.Add(oLvDay.ReqWithin);
                itm.SubItems.Add(oLvDay.Reamrks);
                lvLeaveDays.Items.Add(itm);

            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboLeaveType", "txtDays", "txtReqDays", "txtReqWithin"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                LeaveDaysSetup oLvDaysSet = this.PopulateLeaveDays();
                short i = hmsSC.UpdateLeaveDays(oLvDaysSet);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtDays.Text = "";
                    txtReqDays.Text = "";
                    txtReqWithin.Text = "";
                    txtRemarks.Text = "";
                    txtDays.Focus();
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

        private void lvLeaveDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLeaveDays.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvLeaveDays.SelectedItems[0];
                cboYear.Text = itm.SubItems[0].Text;
                cboLeaveType.Text = itm.SubItems[1].Text;
                txtDays.Text = itm.SubItems[2].Text;
                txtReqDays.Text = itm.SubItems[3].Text;
                txtReqWithin.Text = itm.SubItems[4].Text;
                txtRemarks.Text = itm.SubItems[5].Text;
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           LoadListView(cboYear.SelectedValue.ToString());
        }

        private void lvLeaveDays_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
