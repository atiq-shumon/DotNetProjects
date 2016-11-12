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
using System.Globalization;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmHolidayCalender : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmHolidayCalender()
        {
            InitializeComponent();
        }

        private void frmHolidayCalender_Load(object sender, EventArgs e)
        {
            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2015,2030), null);

            cboHolidayType.DisplayMember = "Value";
            cboHolidayType.ValueMember = "Key";
            cboHolidayType.DataSource = new BindingSource(hmsSC.GetHolidayTypeDict("D"), null);

            FormatGrid();
            RefreshGrid();
        }

        private void cboHolidayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboHolidayType.SelectedValue.ToString() !="")
            {
                cboHolidayName.DisplayMember = "Value";
                cboHolidayName.ValueMember = "Key";
                cboHolidayName.DataSource = new BindingSource(hmsSC.GetHolidayNameDict(cboHolidayType.SelectedValue.ToString()), null);
                if (cboHolidayType.SelectedValue.ToString() == "01")
                {
                    btnSave.Enabled = false;
                    btnEdit.Enabled = false;
                    btnProcess.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnEdit.Enabled = true;
                    btnProcess.Enabled = false;
                }
                RefreshGrid();
            }
        }
        private void FormatGrid()
        {
            lvHolidayCalender.CheckBoxes = false;
            lvHolidayCalender.Columns.Add("Year", 0, HorizontalAlignment.Center);
            lvHolidayCalender.Columns.Add("Type ID", 0, HorizontalAlignment.Left);
            lvHolidayCalender.Columns.Add("Type Tilte", 200, HorizontalAlignment.Left);
            lvHolidayCalender.Columns.Add("Name ID", 0, HorizontalAlignment.Left);
            lvHolidayCalender.Columns.Add("Name Title", 250, HorizontalAlignment.Left);
            lvHolidayCalender.Columns.Add("Date", 150, HorizontalAlignment.Left);
            lvHolidayCalender.Columns.Add("Moon", 0, HorizontalAlignment.Left);
        }
        private void LoadListView(string Year,string Type)
        {
            lvHolidayCalender.Items.Clear();
            List<HolidayCalender> oCalenders = hmsSC.GetHolidayCalender(cboYear.SelectedValue.ToString(), cboHolidayType.SelectedValue.ToString()).ToList();
            foreach (HolidayCalender oCalender in oCalenders)
            {
                ListViewItem itm = new ListViewItem(oCalender.Year);
                itm.SubItems.Add(oCalender.HolidayType.TypeID);
                itm.SubItems.Add(oCalender.HolidayType.TypeTitle);
                itm.SubItems.Add(oCalender.HolidayName.NameID);
                itm.SubItems.Add(oCalender.HolidayName.NameTitle);
                itm.SubItems.Add(oCalender.HolidayDate.ToString());
                itm.SubItems.Add(oCalender.IsDependsOnMoon);
                lvHolidayCalender.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            if (cboHolidayType.SelectedValue.ToString() != "")
            {
                LoadListView(cboYear.SelectedValue.ToString(), cboHolidayType.SelectedValue.ToString());
            }
        }

        private void lvHolidayCalender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHolidayCalender.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvHolidayCalender.SelectedItems[0];
                cboYear.Text = itm.SubItems[0].Text;
                cboHolidayType.SelectedValue = itm.SubItems[1].Text;
                cboHolidayName.SelectedValue = itm.SubItems[3].Text;
                txtHolidayDate.Text = itm.SubItems[5].Text;
                if (Convert.ToInt32(itm.SubItems[6].Text) == 1)
                {
                    chkMoon.Checked = true;
                }
                else
                {
                    chkMoon.Checked = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void lvHolidayCalender_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private HolidayCalender PopulateHolidayCalender()
        {
            HolidayCalender oHolidayCalender = new HolidayCalender();
            oHolidayCalender.Year = cboYear.SelectedValue.ToString();
            oHolidayCalender.HolidayDate = txtHolidayDate.Text.ToString();

            HolidayType oHolidayType = new HolidayType();
            oHolidayType.TypeID = cboHolidayType.SelectedValue.ToString();
            oHolidayCalender.HolidayType = oHolidayType;

            HolidayName oHolidayName = new HolidayName();
            oHolidayName.NameID = cboHolidayName.SelectedValue.ToString();
            oHolidayCalender.HolidayName = oHolidayName;

            if (chkMoon.Checked == true)
            {
                oHolidayCalender.IsDependsOnMoon = "1";
            }
            if (chkMoon.Checked == false)
            {
                oHolidayCalender.IsDependsOnMoon = "0";
            }
           
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oHolidayCalender.EntryParameter = ep;
            return oHolidayCalender;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboHolidayType", "cboHolidayName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtHolidayDate.Text == "  /  /")
            {
                MessageBox.Show("Holiday Date cannot be empty");
                return;
            }
            try
            {
                HolidayCalender oHolidayCalender = this.PopulateHolidayCalender();
                short i = hmsSC.SaveHolidayCalender(oHolidayCalender);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtHolidayDate.Text = "";
                        chkMoon.Checked = false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboHolidayType", "cboHolidayName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtHolidayDate.Text == "  /  /")
            {
                MessageBox.Show("Holiday Date cannot be empty");
                return;
            }
            try
            {
                HolidayCalender oHolidayCalender = this.PopulateHolidayCalender();
                short i = hmsSC.UpdateHolidayCalender(oHolidayCalender);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtHolidayDate.Text = "";
                    chkMoon.Checked = false;
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
        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmHolidayTypeSetup oHolidayType = new frmHolidayTypeSetup();
            oHolidayType.ShowDialog();
        }

        private void btnRefreshType_Click(object sender, EventArgs e)
        {
            cboHolidayType.DisplayMember = "Value";
            cboHolidayType.ValueMember = "Key";
            cboHolidayType.DataSource = new BindingSource(hmsSC.GetHolidayTypeDict("D"), null);
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            frmHolidayNameSetup oHolidayName = new frmHolidayNameSetup();
            oHolidayName.TypeID = cboHolidayType.SelectedValue.ToString();
            oHolidayName.ShowDialog();
        }

        private void btnRefreshName_Click(object sender, EventArgs e)
        {
            this.cboHolidayType_SelectedIndexChanged(sender, e);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(cboHolidayType.SelectedValue.ToString()=="01")
            {
                List<string> vf = new List<string>() { "cboYear", "cboHolidayType", "cboHolidayName" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                try
                {
                    HolidayCalender oHolidayCalender = this.PopulateHolidayCalender();
                    short i = hmsSC.SaveHolidayCalender(oHolidayCalender);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtHolidayDate.Text = "";
                        chkMoon.Checked = false;
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
}
