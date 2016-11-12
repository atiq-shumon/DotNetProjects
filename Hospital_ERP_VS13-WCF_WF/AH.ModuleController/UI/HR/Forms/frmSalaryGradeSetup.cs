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
    public partial class frmSalaryGradeSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string Level { set; get; }
        public frmSalaryGradeSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGradeTitle","txtGradeTitleBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {                               
                    SalaryGradeSetup oSalGrade = this.PopulateGradeSetup();
                    if (Utility.IsDuplicateFoundInList(lvGradeSetup, 2, txtGradeTitle.Text))
                    {
                        MessageBox.Show("Cannot Insert Duplicate Name");
                        txtGradeTitle.Focus();
                        return;
                    }
                    else
                    {
                        short i = hmsSC.SaveSalaryGrade(oSalGrade);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //btnNew.PerformClick();
                            
                            RefreshGrid();
                            txtGradeTitle.Text = "";
                            txtGradeTitleBeng.Text = "";
                            txtGradeTitle.Focus();
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



        private SalaryGradeSetup PopulateGradeSetup()
        {
            SalaryGradeSetup oSalGrade = new SalaryGradeSetup();
            oSalGrade.Level = cboLevels.SelectedValue.ToString();
            oSalGrade.GradeID = txtGradeID.Text;
            oSalGrade.GradeTitle = txtGradeTitle.Text;
            oSalGrade.GradeTitleBeng = txtGradeTitleBeng.Text;
            oSalGrade.Srl = txtSerialNumber.Text;
            
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalGrade.EntryParameter = ep;
            return oSalGrade;

        }


        private void RefreshGrid()
        {
            LoadListView(cboLevels.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvGradeSetup.CheckBoxes = false;
            lvGradeSetup.Columns.Add("Grade ID", 150, HorizontalAlignment.Center);
            lvGradeSetup.Columns.Add("Serial", 100, HorizontalAlignment.Center);
            lvGradeSetup.Columns.Add("Grade Title", 300, HorizontalAlignment.Center);
            lvGradeSetup.Columns.Add("Grade Title (Bangla)", 300, HorizontalAlignment.Center);
            lvGradeSetup.Columns.Add("Level", 0, HorizontalAlignment.Center); 
        }

        private void LoadListView(string level)
        {
            lvGradeSetup.Items.Clear();
            if (cboLevels.SelectedValue != "")
            {
                List<SalaryGradeSetup> oSalGrds = hmsSC.GetGradeSetup(cboLevels.SelectedValue.ToString()).ToList();

                foreach (SalaryGradeSetup osalgrd in oSalGrds)
                {
                    ListViewItem itm = new ListViewItem(osalgrd.GradeID);
                    itm.SubItems.Add(osalgrd.Srl);
                    itm.SubItems.Add(osalgrd.GradeTitle);
                    itm.SubItems.Add(osalgrd.GradeTitleBeng);
                    itm.SubItems.Add(osalgrd.Level);
                    lvGradeSetup.Items.Add(itm);
                }
            }

        }
        private void frmSalaryGradeSetup_Load(object sender, EventArgs e)
        {
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            FormatGrid();
            if (Level != null)
            {
                cboLevels.SelectedValue = Level;
            }
            //if (cboLevels.SelectedValue != "")
            //{
            //    LoadListView(cboLevels.SelectedValue.ToString());
            //}
            txtGradeTitle.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGradeID", "txtGradeTitle", "txtGradeTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                SalaryGradeSetup oSalGrade = this.PopulateGradeSetup();
                short i = hmsSC.UpdateGradeSetup(oSalGrade);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtGradeTitle.Text = "";
                    txtGradeTitleBeng.Text = "";
                    txtGradeTitle.Focus();
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

        private void lvGradeSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGradeSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvGradeSetup.SelectedItems[0];
                txtGradeID.Text = itm.SubItems[0].Text;
                txtSerialNumber.Text = itm.SubItems[1].Text;
                txtGradeTitle.Text = itm.SubItems[2].Text;
                txtGradeTitleBeng.Text = itm.SubItems[3].Text;
                cboLevels.SelectedValue = itm.SubItems[4].Text;
            }
        }

        private void lvGradeSetup_Click(object sender, EventArgs e)
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
                LoadListView(cboLevels.SelectedValue.ToString());
            }
        }

        private void txtGradeTitle_TextChanged(object sender, EventArgs e)
        {
            txtGradeTitleBeng.Text = txtGradeTitle.Text;
        }
    }
}
