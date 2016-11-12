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
    public partial class frmScaleDetailsSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmScaleDetailsSetup()
        {
            InitializeComponent();
        }
        private void frmSalaryDetailsSetup_Load(object sender, EventArgs e)
        {
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            cboHead.DisplayMember = "Value";
            cboHead.ValueMember = "Key";
            cboHead.DataSource = new BindingSource(hmsSC.GetSalHd("D"), null);    

            FormatGrid();
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtAmount", "cboGrade", "cboScale", "cboHead"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }          
            try
            {
                ScaleDSetup oSalD = this.PopulateScaleSetup();
                if (Utility.IsDuplicateFoundInList(lvScaleDetails, 2, cboHead.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Salary Head");
                    cboHead.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveScaleDSetup(oSalD);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnNew.PerformClick();
                        txtAmount.Focus();
                        RefreshGrid();
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

        private ScaleDSetup PopulateScaleSetup()
        {
            ScaleDSetup oSalD = new ScaleDSetup();

            SalaryGradeSetup oSalGrd = new SalaryGradeSetup();
            oSalGrd.GradeID = cboGrade.SelectedValue.ToString(); 
            oSalD.SalaryGradeSetup = oSalGrd;

            ScaleMSetup osclM = new ScaleMSetup();
            osclM.ScaleMID = cboScale.SelectedValue.ToString();
            oSalD.ScaleMSetup = osclM;

            SalaryHead osalHd = new SalaryHead();
            osalHd.HeadID = cboHead.SelectedValue.ToString();
            oSalD.SalaryHead = osalHd;

            oSalD.amount = txtAmount.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalD.EntryParameter = ep;
            return oSalD;

        }


        private void RefreshGrid()
        {
            if (cboGrade.SelectedValue != "")
            {
                LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
            }
        }

        private void FormatGrid()
        {
            lvScaleDetails.CheckBoxes = false;
            lvScaleDetails.Columns.Add("Grade", 200, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Scale", 200, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Head", 250, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Amount", 200, HorizontalAlignment.Right);
        }

        private void LoadListView(string oSalHdG, string oSalM)
        {
            lvScaleDetails.Items.Clear();
            if (cboGrade.SelectedValue != "")
            {
                List<ScaleDSetup> oSalHds = hmsSC.GetScaleDSetup(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString()).ToList();
                foreach (ScaleDSetup salhd in oSalHds)
                {
                    ListViewItem itm = new ListViewItem(salhd.SalaryGradeSetup.GradeID);
                    itm.SubItems.Add(salhd.ScaleMSetup.ScaleMID);
                    itm.SubItems.Add(salhd.SalaryHead.HeadID);
                    itm.SubItems.Add(salhd.amount);
                    lvScaleDetails.Items.Add(itm);
                }
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtAmount", "cboGrade", "cboScale", "cboHead" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                ScaleDSetup oSclDSet = this.PopulateScaleSetup();
                short i = hmsSC.UpdateScaleDSetup(oSclDSet);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtAmount.Focus();
                    RefreshGrid();
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

        private void lvScaleDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvScaleDetails.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvScaleDetails.SelectedItems[0];
                cboGrade.Text = itm.SubItems[0].Text;
                cboScale.Text = itm.SubItems[1].Text;
                cboHead.Text = itm.SubItems[2].Text;
                txtAmount.Text = itm.SubItems[3].Text;              
            }
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if (cboGrade.SelectedValue != "")
            {
                    cboScale.DisplayMember = "ScaleTitle";
                    cboScale.ValueMember = "ScaleMID";
                    cboScale.DataSource = hmsSC.GetScaleUnderGrade(cboGrade.SelectedValue.ToString()).ToList();
                    if (cboScale.SelectedValue != null)
                    {
                        LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
                    }
           }                          
        }

        private void cboScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboScale.SelectedValue != null)
            {
                 LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
               
            }
        }
        private void lvScaleDetails_Click(object sender, EventArgs e)
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
            if(lvScaleDetails.Items.Count>0)
            {
                lvScaleDetails.Items.Clear();
            }
        }

        private void smartLabel8_Click(object sender, EventArgs e)
        {

        }
      

    }
}
