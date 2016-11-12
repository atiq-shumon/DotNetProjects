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
    public partial class frmHolidayTypeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        
        public frmHolidayTypeSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            lvHolidayType.CheckBoxes = false;
            lvHolidayType.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lvHolidayType.Columns.Add("Type Title", 250, HorizontalAlignment.Left);
            lvHolidayType.Columns.Add("Type Title(Bangla)", 250, HorizontalAlignment.Left);
            lvHolidayType.Columns.Add("Weekly", 0, HorizontalAlignment.Center);
            lvHolidayType.Columns.Add("Monthly", 0, HorizontalAlignment.Center);
            lvHolidayType.Columns.Add("Yearly", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvHolidayType.Items.Clear();
            List<HolidayType> oTypes = hmsSC.GetHolidayType().ToList();
            foreach (HolidayType oType in oTypes)
            {
                ListViewItem itm = new ListViewItem(oType.TypeID);
                itm.SubItems.Add(oType.TypeTitle);
                itm.SubItems.Add(oType.TypeTitleBeng);
                itm.SubItems.Add(oType.Weekly);
                itm.SubItems.Add(oType.Monthly);
                itm.SubItems.Add(oType.Yearly);
                lvHolidayType.Items.Add(itm);
            }
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmHolidayTypeSetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            RefreshGrid();
            txtTypeTitle.Focus();
        }
        private HolidayType PopulateHolidayType()
        {
            HolidayType oHolidayType = new HolidayType();
            oHolidayType.TypeID = txtTypeID.Text;
            oHolidayType.TypeTitle = txtTypeTitle.Text;
            oHolidayType.TypeTitleBeng = txtTypeTitleBeng.Text;

            if (chkWeekly.Checked == true)
            {
                oHolidayType.Weekly = "1";
            }
            if (chkWeekly.Checked == false)
            {
                oHolidayType.Weekly = "0";
            }
            if (ChkMonthly.Checked == true)
            {
                oHolidayType.Monthly = "1";
            }
            if (ChkMonthly.Checked == false)
            {
                oHolidayType.Monthly = "0";
            }
            if (chkYearly.Checked == true)
            {
                oHolidayType.Yearly = "1";
            }
            if (chkYearly.Checked == false)
            {
                oHolidayType.Yearly = "0";
            }
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oHolidayType.EntryParameter = ep;
            return oHolidayType;

        }

        private void txtTypeTitle_TextChanged(object sender, EventArgs e)
        {
            txtTypeTitleBeng.Text = txtTypeTitle.Text;
        }

        private void lvHolidayType_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void lvHolidayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHolidayType.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvHolidayType.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeTitle.Text = itm.SubItems[1].Text;
                txtTypeTitleBeng.Text = itm.SubItems[2].Text;
                if (Convert.ToInt32(itm.SubItems[3].Text) == 1)
                {
                    chkWeekly.Checked = true;
                }
                else
                {
                    chkWeekly.Checked = false;
                }
                if (Convert.ToInt32(itm.SubItems[4].Text) == 1)
                {
                    ChkMonthly.Checked = true;
                }
                else
                {
                    ChkMonthly.Checked = false;
                }
                if (Convert.ToInt32(itm.SubItems[5].Text) == 1)
                {
                    chkYearly.Checked = true;
                }
                else
                {
                    chkYearly.Checked = false;
                }  
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeTitle", "txtTypeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvHolidayType, 1, txtTypeTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtTypeTitle.Focus();
                    return;
                }
                else
                {
                    HolidayType oHolidayType = this.PopulateHolidayType();
                    short i = hmsSC.SaveHolidayType(oHolidayType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        txtTypeTitle.Text = "";
                        txtTypeTitleBeng.Text = "";
                        chkWeekly.Checked = false;
                        ChkMonthly.Checked = false;
                        chkYearly.Checked = false;
                        txtTypeTitle.Focus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeID", "txtTypeTitle", "txtTypeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                HolidayType oHolidayType = this.PopulateHolidayType();
                short i = hmsSC.UpdateLHolidayType(oHolidayType);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtTypeTitle.Text = "";
                    txtTypeTitleBeng.Text = "";
                    chkWeekly.Checked = false;
                    ChkMonthly.Checked = false;
                    chkYearly.Checked = false;
                    txtTypeTitle.Focus();
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
