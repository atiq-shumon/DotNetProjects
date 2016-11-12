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
using AH.ModuleController.UI.HR.Reports.Viewer;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmIncomeTaxSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmIncomeTaxSetup()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> GetFiscalYear()
        {
            Dictionary<string, string> locFiscalYear = new Dictionary<string, string>();
            locFiscalYear.Add("2013-2014", "2013-2014");
            locFiscalYear.Add("2014-2015", "2014-2015");
            locFiscalYear.Add("2015-2016", "2015-2016");
            locFiscalYear.Add("2016-2017", "2016-2017");
            locFiscalYear.Add("2017-2018", "2017-2018");
            locFiscalYear.Add("2018-2019", "2018-2019");
            locFiscalYear.Add("2019-2020", "2019-2020");
            return locFiscalYear;
        }
        private Dictionary<string, string> GetCategory()
        {
            Dictionary<string, string> locCategory = new Dictionary<string, string>();
            locCategory.Add("M", "Male");
            locCategory.Add("F", "Female");
            locCategory.Add("S", "Senior Citizen");
            locCategory.Add("G", "Freedom Fighter");  
            return locCategory;
        }
        public void GetCurrentFinancialYear()
        {
            int CurrentYear = DateTime.Today.Year;
            int PreviousYear = DateTime.Today.Year - 1;
            int NextYear = DateTime.Today.Year + 1;
            string PreYear = PreviousYear.ToString();
            string NexYear = NextYear.ToString();
            string CurYear = CurrentYear.ToString();
            string FinYear = null;

            if (DateTime.Today.Month > 6)

            FinYear = CurYear + "-" + NexYear;

            else

            FinYear = PreYear + "-" + CurYear;

            cboFiscalYear.Text = FinYear.Trim();
        }
        private void frmIncomeTaxSetup_Load(object sender, EventArgs e)
        {
            cboFiscalYear.DisplayMember = "Value";
            cboFiscalYear.ValueMember = "Key";
            cboFiscalYear.DataSource = new BindingSource(GetFiscalYear(), null);

            cboCatagory.DisplayMember = "Value";
            cboCatagory.ValueMember = "Key";
            cboCatagory.DataSource = new BindingSource(GetCategory(), null);

            GetCurrentFinancialYear();                  

            FormatGrid();
            RefreshGrid();
        }
        private void FormatGrid()
        {
            lvIncomeTax.CheckBoxes = false;
            lvIncomeTax.Columns.Add("Fiscal Year", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Category", 100, HorizontalAlignment.Left);
            lvIncomeTax.Columns.Add("HRA", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("MA", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("CON", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Rebate", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Free Lmt", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Invst Lmt", 100, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Slot1", 53, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Slot2", 53, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Slot3", 53, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Slot4", 53, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("Slot5", 53, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("MinTaxAmt", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("SLot1Lmt", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("SLot2Lmt", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("SLot3Lmt", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("SLot4Lmt", 0, HorizontalAlignment.Center);
            lvIncomeTax.Columns.Add("SLot5Lmt", 0, HorizontalAlignment.Center);
        }
        private IncomeTax PopulateIncomeTaxSetup()
        {
            IncomeTax oIncomeTax = new IncomeTax();
            oIncomeTax.FiscalYear = cboFiscalYear.SelectedValue.ToString();
            oIncomeTax.Catagory = cboCatagory.SelectedValue.ToString();
            oIncomeTax.HraExm = txtHraExm.Text;
            oIncomeTax.MaExm = txtMAExm.Text;
            oIncomeTax.ConExm = txtConveyance.Text;
            oIncomeTax.InvstTaxRebat = txtInvstTaxRebate.Text;
            oIncomeTax.TaxFreeLimit = txtTaxFreeLimit.Text;
            oIncomeTax.InvstLimit = txtInvstLimit.Text;
            oIncomeTax.MinTaxAmt = txtMinTaxAmt.Text;
            oIncomeTax.Slot1 = txtSlot1.Text;
            oIncomeTax.Slot1Limit = txtSlot1Limit.Text;
            oIncomeTax.Slot2 = txtSlot2.Text;
            oIncomeTax.Slot2Limit = txtSlot2Limit.Text;
            oIncomeTax.Slot3 = txtSlot3.Text;
            oIncomeTax.Slot3Limit = txtSlot3Limit.Text;
            oIncomeTax.Slot4 = txtSlot4.Text;
            oIncomeTax.Slot4Limit = txtSlot4Limit.Text;
            oIncomeTax.Slot5 = txtSlot5.Text;
            oIncomeTax.Slot5Limit = txtSlot5Limit.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oIncomeTax.EntryParameter = ep;
            return oIncomeTax;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboFiscalYear", "cboCatagory", "txtHraExm", "txtMAExm", "txtConveyance", "txtInvstTaxRebate", "txtTaxFreeLimit", "txtInvstLimit", "txtSlot1", "txtSlot2", "txtSlot3", "txtSlot4", "txtSlot5" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvIncomeTax, 1, cboCatagory.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Value Under same Category");
                    cboCatagory.Focus();
                    return;
                }
                else
                {
                    IncomeTax oIncomeTax = this.PopulateIncomeTaxSetup();
                    short i = hmsSC.SaveIncomeTax(oIncomeTax);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        btnNew.PerformClick();
                        cboCatagory.Focus();
                        GetCurrentFinancialYear(); 
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
            LoadListView(cboFiscalYear.SelectedValue.ToString());
        }
        private void LoadListView(string FiscalYear)
        {
            lvIncomeTax.Items.Clear();
            List<IncomeTax> oIncomeTaxs = hmsSC.GetIncomeTax(cboFiscalYear.SelectedValue.ToString()).ToList();
            foreach (IncomeTax oIncomeTax in oIncomeTaxs)
            {
                ListViewItem itm = new ListViewItem(oIncomeTax.FiscalYear);
                itm.SubItems.Add(oIncomeTax.Catagory);
                itm.SubItems.Add(oIncomeTax.HraExm);
                itm.SubItems.Add(oIncomeTax.MaExm);
                itm.SubItems.Add(oIncomeTax.ConExm);
                itm.SubItems.Add(oIncomeTax.InvstTaxRebat);
                itm.SubItems.Add(oIncomeTax.TaxFreeLimit);
                itm.SubItems.Add(oIncomeTax.InvstLimit);
                itm.SubItems.Add(oIncomeTax.Slot1);
                itm.SubItems.Add(oIncomeTax.Slot2);
                itm.SubItems.Add(oIncomeTax.Slot3);
                itm.SubItems.Add(oIncomeTax.Slot4);
                itm.SubItems.Add(oIncomeTax.Slot5);
                itm.SubItems.Add(oIncomeTax.MinTaxAmt);
                itm.SubItems.Add(oIncomeTax.Slot1Limit);
                itm.SubItems.Add(oIncomeTax.Slot2Limit);
                itm.SubItems.Add(oIncomeTax.Slot3Limit);
                itm.SubItems.Add(oIncomeTax.Slot4Limit);
                itm.SubItems.Add(oIncomeTax.Slot5Limit);
                lvIncomeTax.Items.Add(itm);
            }
        }

        private void lvIncomeTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIncomeTax.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvIncomeTax.SelectedItems[0];
                cboFiscalYear.Text = itm.SubItems[0].Text;
                cboCatagory.SelectedValue = itm.SubItems[1].Text;
                txtHraExm.Text = itm.SubItems[2].Text;
                txtMAExm.Text = itm.SubItems[3].Text;
                txtConveyance.Text = itm.SubItems[4].Text;
                txtInvstTaxRebate.Text = itm.SubItems[5].Text;
                txtTaxFreeLimit.Text = itm.SubItems[6].Text;
                txtInvstLimit.Text = itm.SubItems[7].Text;
                txtSlot1.Text = itm.SubItems[8].Text;
                txtSlot2.Text = itm.SubItems[9].Text;
                txtSlot3.Text = itm.SubItems[10].Text;
                txtSlot4.Text = itm.SubItems[11].Text;
                txtSlot5.Text = itm.SubItems[12].Text;
                txtMinTaxAmt.Text = itm.SubItems[13].Text;
                txtSlot1Limit.Text = itm.SubItems[14].Text;
                txtSlot2Limit.Text = itm.SubItems[15].Text;
                txtSlot3Limit.Text = itm.SubItems[16].Text;
                txtSlot4Limit.Text = itm.SubItems[17].Text;
                txtSlot5Limit.Text = itm.SubItems[18].Text;
            }
        }

        private void lvIncomeTax_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboFiscalYear", "cboCatagory", "txtHraExm", "txtMAExm", "txtConveyance", "txtInvstTaxRebate", "txtTaxFreeLimit", "txtInvstLimit", "txtSlot1", "txtSlot2", "txtSlot3", "txtSlot4", "txtSlot5" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                IncomeTax oIncomeTax = this.PopulateIncomeTaxSetup();
                short i = hmsSC.UpdateIncomeTax(oIncomeTax);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    cboCatagory.Focus();
                    GetCurrentFinancialYear(); 
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListView(cboFiscalYear.SelectedValue.ToString());
        }

        private void cboFiscalYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnShow_Click(sender,e);
        }     
    }
}
