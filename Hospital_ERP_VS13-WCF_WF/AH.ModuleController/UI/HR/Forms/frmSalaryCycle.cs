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
    public partial class frmSalaryCycle : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryCycle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboYear", "cboMonthNumber", "txtMonthType", "txtFormDate", "txtToDate", "txtTotalNoDays", "txtTotalFriday", "txtTotalHoliday", "txtTotalWorkDays" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtFormDate.Text == "  /  /")
            {
                MessageBox.Show("Month Start Date cannot be empty");
                return;
            }
            if (txtToDate.Text == "  /  /")
            {
                MessageBox.Show("Month End Date cannot be empty");
                return;
            }
            try
            {              
                SalaryCycle oSalCycle = this.PopulateSalaryCycle();

                if (Utility.IsDuplicateFoundInList(lvSalaryCycle, 0, txtMonthID.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate ID");
                    txtMonthID.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveSalaryCycle(oSalCycle);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
                        txtMonthType.Text = "";
                        txtFormDate.Text = null;
                        txtToDate.Text = null;
                        txtTotalNoDays.Text = "";
                        txtTotalFriday.Text = "";
                        txtTotalHoliday.Text = "";
                        txtTotalWorkDays.Text = "";
                        RefreshGrid();
                        txtMonthID.Focus();
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

        private SalaryCycle PopulateSalaryCycle()
        {
            SalaryCycle oSal = new SalaryCycle();
            oSal.Month = txtMonthID.Text;
            oSal.Year = cboYear.SelectedValue.ToString();
            oSal.MonthNumber = cboMonthNumber.SelectedValue.ToString();
            oSal.FromDate = DateTime.ParseExact(txtFormDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            oSal.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-GB"));
            oSal.TotalNoOfDays = txtTotalNoDays.Text;
            oSal.TotalFridays = txtTotalFriday.Text;
            oSal.TotalHolidays = txtTotalHoliday.Text;
            oSal.TotalWorkDays = txtTotalWorkDays.Text;
            oSal.MonthType = txtMonthType.Text;

            if (cbMonthStatus.Checked == true)
            {
                oSal.MonthStatus = "1";
            }
            if (cbMonthStatus.Checked == false)
            {
                oSal.MonthStatus = "0";
            }

            if (cbEidFlag.Checked == true)
            {
                oSal.EidFlag = "1";
            }
            if (cbEidFlag.Checked == false)
            {
                oSal.EidFlag = "0";
            }

            if (cbMonthEndFlag.Checked == true)
            {
                oSal.MonthEndFlag = "1";
            }
            if (cbMonthEndFlag.Checked == false)
            {
                oSal.MonthEndFlag = "0";
            }

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSal.EntryParameter = ep;

            return oSal;
        }

        private void frmSalaryCycle_Load(object sender, EventArgs e)
        {
            cboMonthNumber.DisplayMember = "Value";
            cboMonthNumber.ValueMember = "Key";
            cboMonthNumber.DataSource = new BindingSource(Utility.GetNumbers(1, 13), null);

            cboYear.DisplayMember = "Value";
            cboYear.ValueMember = "Key";
            cboYear.DataSource = new BindingSource(Utility.GetNumbers(2014, 2025), null);
            cboYear.Text = DateTime.Now.ToString("yyyy");

            FormatGrid();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            LoadListView(cboYear.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvSalaryCycle.CheckBoxes = false;
            lvSalaryCycle.Columns.Add("Month", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Year", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Month Number", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Total Days", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Total Fridays", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Total Holidays", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Total Works Days", 100, HorizontalAlignment.Center);
            lvSalaryCycle.Columns.Add("Month Type", 0, HorizontalAlignment.Left);
            lvSalaryCycle.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
            lvSalaryCycle.Columns.Add("End Date", 100, HorizontalAlignment.Left);           
            lvSalaryCycle.Columns.Add("Month Status", 0, HorizontalAlignment.Left);
            lvSalaryCycle.Columns.Add("Eid Flag", 0, HorizontalAlignment.Left);
            lvSalaryCycle.Columns.Add("Month End Flag", 0, HorizontalAlignment.Left);
        }

        private void LoadListView(string Year)
        {
            lvSalaryCycle.Items.Clear();
            List<SalaryCycle> oSalCycles = new List<SalaryCycle>();
            oSalCycles = hmsSC.GetSalaryCycle(cboYear.SelectedValue.ToString()).ToList();
            foreach (SalaryCycle oSalCycle in oSalCycles)
            {
                ListViewItem itm = new ListViewItem(oSalCycle.Month);
                itm.SubItems.Add(oSalCycle.Year);
                itm.SubItems.Add(oSalCycle.MonthNumber);
                itm.SubItems.Add(oSalCycle.TotalNoOfDays);
                itm.SubItems.Add(oSalCycle.TotalFridays);
                itm.SubItems.Add(oSalCycle.TotalHolidays);
                itm.SubItems.Add(oSalCycle.TotalWorkDays);
                itm.SubItems.Add(oSalCycle.MonthType);
                itm.SubItems.Add(oSalCycle.FromDate.ToString("dd-MM-yyyy"));
                itm.SubItems.Add(oSalCycle.ToDate.ToString("dd-MM-yyyy"));               
                itm.SubItems.Add(oSalCycle.MonthStatus.ToString());
                itm.SubItems.Add(oSalCycle.EidFlag.ToString());
                itm.SubItems.Add(oSalCycle.MonthEndFlag.ToString());
                lvSalaryCycle.Items.Add(itm);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMonthID", "cboYear", "cboMonthNumber", "txtMonthType", "txtFormDate", "txtToDate", "txtTotalNoDays", "txtTotalFriday", "txtTotalHoliday", "txtTotalWorkDays" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                SalaryCycle oSal = this.PopulateSalaryCycle();
                short i = hmsSC.UpdateSalaryCycle(oSal);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonthID.Select();
                }
                if (txtFormDate.Text == "  /  /")
                {
                    MessageBox.Show("Month Start Date cannot be empty");
                    return;
                }
                if (txtToDate.Text == "  /  /")
                {
                    MessageBox.Show("Month End Date cannot be empty");
                    return;
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMonthType.Text = "";
                    txtFormDate.Text = null;
                    txtToDate.Text = null;
                    txtTotalNoDays.Text = "";
                    txtTotalFriday.Text = "";
                    txtTotalHoliday.Text = "";
                    txtTotalWorkDays.Text = "";
                    RefreshGrid();
                    txtMonthID.Focus();
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

        private void lvSalaryCycle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSalaryCycle.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSalaryCycle.SelectedItems[0];
                txtMonthID.Text = itm.SubItems[0].Text;
                cboYear.Text = itm.SubItems[1].Text;
                cboMonthNumber.Text = itm.SubItems[2].Text;
                txtTotalNoDays.Text = itm.SubItems[3].Text;
                txtTotalFriday.Text = itm.SubItems[4].Text;
                txtTotalHoliday.Text = itm.SubItems[5].Text;
                txtTotalWorkDays.Text = itm.SubItems[6].Text;
                txtMonthType.Text = itm.SubItems[7].Text;
                txtFormDate.Text = itm.SubItems[8].Text;
                txtToDate.Text = itm.SubItems[9].Text;
                if (Convert.ToInt32(itm.SubItems[10].Text) == 1)
                {
                    cbMonthStatus.Checked = true;                    
                }
                else
                {
                    cbMonthStatus.Checked = false; 
                }
                if (Convert.ToInt32(itm.SubItems[11].Text) == 1)
                {
                    cbEidFlag.Checked = true;
                }
                else
                {
                    cbEidFlag.Checked = false;
                }
                if (Convert.ToInt32(itm.SubItems[12].Text) == 1)
                {
                    cbMonthEndFlag.Checked = true;
                }
                else
                {
                    cbMonthEndFlag.Checked = false;
                }

               
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView(cboYear.SelectedValue.ToString());
        }

        private void lvSalaryCycle_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
