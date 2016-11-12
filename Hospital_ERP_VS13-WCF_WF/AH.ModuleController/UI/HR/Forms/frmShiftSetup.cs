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


namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmShiftSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmShiftSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvShift.CheckBoxes = false;
            lvShift.Columns.Add("Shift ID", 150, HorizontalAlignment.Center);
            lvShift.Columns.Add("Shift Title", 450, HorizontalAlignment.Left);
            lvShift.Columns.Add("Shift Title(Bangla)", 0, HorizontalAlignment.Left);          
        }
        private Shift PopulateShiftSetup()
        {
            Shift oShift = new Shift();
            oShift.ShiftID = txtShiftID.Text;
            oShift.ShiftTitle = txtShiftTitle.Text;
            oShift.ShiftTitleBeng = txtShiftTitleBeng.Text;
           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oShift.EntryParameter = ep;
            return oShift;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtShiftTitle", "txtShiftTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvShift, 1, txtShiftTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtShiftTitle.Focus();
                    return;
                }
                else
                {
                    Shift oShift = this.PopulateShiftSetup();
                    short i = hmsSC.SaveShiftSetup(oShift);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        btnNew.PerformClick();
                        txtShiftTitle.Focus();
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

        private void frmShiftSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();
            txtShiftTitle.Focus();
        }
        private void LoadListView()
        {
            lvShift.Items.Clear();
            List<Shift> oShifts = hmsSC.GetShiftSetup().ToList();
            foreach (Shift oShift in oShifts)
            {
                ListViewItem itm = new ListViewItem(oShift.ShiftID);
                itm.SubItems.Add(oShift.ShiftTitle);
                itm.SubItems.Add(oShift.ShiftTitleBeng);
                lvShift.Items.Add(itm);
            }

        }

        private void lvShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShift.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvShift.SelectedItems[0];
                txtShiftID.Text = itm.SubItems[0].Text;
                txtShiftTitle.Text = itm.SubItems[1].Text;
                txtShiftTitleBeng.Text = itm.SubItems[2].Text;              
            }
        }

        private void lvShift_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtShiftTitle_TextChanged(object sender, EventArgs e)
        {
            txtShiftTitleBeng.Text = txtShiftTitle.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtShiftID", "txtShiftTitle", "txtShiftTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Shift oShift = this.PopulateShiftSetup();
                short i = hmsSC.UpdateShiftSetup(oShift);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtShiftTitle.Focus();
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
    }
}
