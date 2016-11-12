using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmScaleMSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string GradeID { set; get; }
        public string Level { set; get; }
        public frmScaleMSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboGrade", "txtScaleTitle", "txtScaleTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
         
            try
            {
                ScaleMSetup oSclMSet = this.PopulateScaleSetup();
                if (Utility.IsDuplicateFoundInList(lvScaleSetup, 3, txtScaleTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtScaleTitle.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveScaleMSetup(oSclMSet);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        RefreshGrid();
                        txtScaleTitle.Text = "";
                        txtScaleTitleBeng.Text = "";
                        txtScaleTitle.Focus();
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
        private ScaleMSetup PopulateScaleSetup()
        {
            ScaleMSetup oSalM = new ScaleMSetup();

            SalaryGradeSetup oSalGrd = new SalaryGradeSetup();
            oSalGrd.Level = cboLevels.SelectedValue.ToString();
            oSalGrd.GradeID = cboGrade.SelectedValue.ToString();           
            oSalM.SalaryGradeSetup = oSalGrd;

            oSalM.ScaleMID = txtScaleID.Text;
            oSalM.ScaleTitle = txtScaleTitle.Text;
            oSalM.ScaleTitleBeng = txtScaleTitleBeng.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalM.EntryParameter = ep;
            return oSalM;

        }
        private void RefreshGrid()
        {
            if (cboLevels.SelectedValue.ToString() != "")
            {
                if (cboGrade.SelectedValue.ToString() != "")
                {
                    LoadListView(cboGrade.SelectedValue.ToString());
                }
            }
        }

        private void FormatGrid()
        {
            lvScaleSetup.CheckBoxes = false;
            lvScaleSetup.Columns.Add("Grade", 150, HorizontalAlignment.Left);
            lvScaleSetup.Columns.Add("Step ID", 150, HorizontalAlignment.Left);
            lvScaleSetup.Columns.Add("Step Title", 250, HorizontalAlignment.Left);
            lvScaleSetup.Columns.Add("Step Title(Bangla)", 250, HorizontalAlignment.Left);
            lvScaleSetup.Columns.Add("Level", 0, HorizontalAlignment.Left);  
        }

        private void LoadListView(string oSclSet)
        {
            lvScaleSetup.Items.Clear();
            if (cboGrade.SelectedValue != "")
            {
                List<ScaleMSetup> oSclMs = hmsSC.GetScaleMSetup(cboGrade.SelectedValue.ToString()).ToList();
                foreach (ScaleMSetup oScl in oSclMs)
                {
                    ListViewItem itm = new ListViewItem(oScl.SalaryGradeSetup.GradeID);
                    itm.SubItems.Add(oScl.ScaleMID);
                    itm.SubItems.Add(oScl.ScaleTitle);
                    itm.SubItems.Add(oScl.ScaleTitleBeng);
                    itm.SubItems.Add(oScl.SalaryGradeSetup.Level);
                    lvScaleSetup.Items.Add(itm);
                }
            }

        }

        private void frmScaleMSetup_Load(object sender, EventArgs e)
        {
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            FormatGrid();
            RefreshGrid();
            txtScaleTitle.Focus();
            if (Level != null)
            {
                cboLevels.SelectedValue = Level;
                if (GradeID != null)
                {                    
                    cboGrade.SelectedValue = GradeID;
                }
            }
        }
        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrade.SelectedValue != "")
            {
                LoadListView(cboGrade.SelectedValue.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtScaleID", "cboGrade", "txtScaleTitle", "txtScaleTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ScaleMSetup oSclMSet = this.PopulateScaleSetup();
                short i = hmsSC.UpdateScaleMSetup(oSclMSet);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtScaleID.Text = "";
                    txtScaleTitle.Text = "";
                    txtScaleTitleBeng.Text = "";
                    txtScaleTitle.Focus();
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

        private void lvScaleSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvScaleSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvScaleSetup.SelectedItems[0];
                cboGrade.Text = itm.SubItems[0].Text;
                txtScaleID.Text = itm.SubItems[1].Text;
                txtScaleTitle.Text = itm.SubItems[2].Text;
                txtScaleTitleBeng.Text = itm.SubItems[3].Text;
                cboLevels.SelectedValue = itm.SubItems[4].Text;
            }
        }

        private void lvScaleSetup_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void cboLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLevels.SelectedValue != "")
            {
                cboGrade.DisplayMember = "Value";
                cboGrade.ValueMember = "Key";
                cboGrade.DataSource = new BindingSource(hmsSC.GetGradeDict(cboLevels.SelectedValue.ToString()), null);
            }
        }

        private void txtScaleTitle_TextChanged(object sender, EventArgs e)
        {
            txtScaleTitleBeng.Text = txtScaleTitle.Text;
        }
    }
}
