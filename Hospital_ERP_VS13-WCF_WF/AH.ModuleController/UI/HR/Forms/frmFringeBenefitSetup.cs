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
    public partial class frmFringeBenefitSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmFringeBenefitSetup()
        {
            InitializeComponent();
        }
        private FringeBenefit PopulateBenefitType()
        {
            FringeBenefit oBenType = new FringeBenefit();
            oBenType.BenID = txtBenefitID.Text;
            oBenType.BenTitle = txtBenefitTitle.Text;
            oBenType.BenTitleBeng = txtBenefitTitleBeng.Text;
            oBenType.YMDBasis = cboPeriod.SelectedValue.ToString();
            if (chkQuantitive.Checked == true)
            {
                oBenType.isAmount = "1";
            }
            if (chkQuantitive.Checked == false)
            {
                oBenType.isAmount = "0";
            }
            oBenType.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oBenType.EntryParameter = ep;
            return oBenType;

        }

        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvBenefit.CheckBoxes = false;
            lvBenefit.Columns.Add("Benefit ID", 100, HorizontalAlignment.Center);
            lvBenefit.Columns.Add("Benefit Title", 250, HorizontalAlignment.Left);
            lvBenefit.Columns.Add("Benefit Title(Bangla)", 250, HorizontalAlignment.Left);            
            lvBenefit.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvBenefit.Columns.Add("Period", 0, HorizontalAlignment.Left);
            lvBenefit.Columns.Add("IS Amount", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvBenefit.Items.Clear();
            List<FringeBenefit> oBenTypes = new List<FringeBenefit>();
            oBenTypes = hmsSC.GetBenefitType().ToList();
            foreach (FringeBenefit oBenType in oBenTypes)
            {
                ListViewItem itm = new ListViewItem(oBenType.BenID);
                itm.SubItems.Add(oBenType.BenTitle);
                itm.SubItems.Add(oBenType.BenTitleBeng);
                itm.SubItems.Add(oBenType.Remarks);
                itm.SubItems.Add(oBenType.YMDBasis);
                itm.SubItems.Add(oBenType.isAmount);
                lvBenefit.Items.Add(itm);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBenefitTitle", "txtBenefitTitleBeng", "cboPeriod" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvBenefit, 1, txtBenefitTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtBenefitTitle.Focus();
                    return;
                }
                else
                {
                    FringeBenefit oBenType = this.PopulateBenefitType();
                    short i = hmsSC.SaveBenefitType(oBenType);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
                        //txtBenefitTitle.Focus();
                        RefreshGrid();
                        txtBenefitTitle.Text = "";
                        txtBenefitTitleBeng.Text = "";
                        txtRemarks.Text = "";
                        txtBenefitTitle.Focus();
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
        private void frmFringeBenefitSetup_Load(object sender, EventArgs e)
        {
            cboPeriod.DisplayMember = "Value";            
            cboPeriod.ValueMember = "Key";
            cboPeriod.DataSource = new BindingSource(GetPeriodIndicator(), null);   
            FormatGrid();
            LoadListView();
        }

        private Dictionary<string, string> GetPeriodIndicator()
        {
            Dictionary<string, string> locPeriodIndicator = new Dictionary<string, string>();
            locPeriodIndicator.Add("Y", "Yearly");
            locPeriodIndicator.Add("M", "Monthly");
            locPeriodIndicator.Add("D", "Daily");
            return locPeriodIndicator;
        }
        private void lvBenefit_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lvBenefit.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvBenefit.SelectedItems[0];
                txtBenefitID.Text = itm.SubItems[0].Text;
                txtBenefitTitle.Text = itm.SubItems[1].Text;
                txtBenefitTitleBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                cboPeriod.SelectedValue = itm.SubItems[4].Text;
                if (itm.SubItems[5].Text == "1")
                {
                    chkQuantitive.Checked = true;
                }
                if (itm.SubItems[5].Text == "0")
                {
                    chkQuantitive.Checked = false;
                }
            }        
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtBenefitID", "txtBenefitTitle", "txtBenefitTitleBeng", "cboPeriod" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                FringeBenefit oBenType = this.PopulateBenefitType();
                short i = hmsSC.UpdateBenefitType(oBenType);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    //txtBenefitTitle.Focus();
                    RefreshGrid();
                    txtBenefitTitle.Text = "";
                    txtBenefitTitleBeng.Text = "";
                    txtRemarks.Text = "";
                    txtBenefitTitle.Focus();
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

        private void lvBenefit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;           
        }

        private void txtBenefitTitle_TextChanged(object sender, EventArgs e)
        {
            txtBenefitTitleBeng.Text = txtBenefitTitle.Text;
        }
    }
}
