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
    public partial class frmSalaryDetailsSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryDetailsSetup()
        {
            InitializeComponent();
        }

        private void frmSalaryDetailsSetup_Load(object sender, EventArgs e)
        {
            cboGrade.DisplayMember = "Value";
            cboGrade.ValueMember = "Key";
            cboGrade.DataSource = new BindingSource(hmsSC.GetGrade("D"), null);

            cboHead.DisplayMember = "Value";
            cboHead.ValueMember = "Key";
            cboHead.DataSource = new BindingSource(hmsSC.GetSalHd("D"), null);
           

            FormatGrid();
            LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtAmount" };
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
                    short i = hmsSC.SaveScaleDSetup(oSalD);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtAmount.Focus();
                        RefreshGrid();                      
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvScaleDetails.CheckBoxes = false;
            lvScaleDetails.Columns.Add("Grade", 200, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Scale", 200, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Head", 250, HorizontalAlignment.Left);
            lvScaleDetails.Columns.Add("Amount", 150, HorizontalAlignment.Right);
        }

        private void LoadListView(string oSalHdG, string oSalM)
        {
            lvScaleDetails.Items.Clear();
            List<ScaleDSetup> oSalHds = new List<ScaleDSetup>();
            oSalHds = hmsSC.GetScaleDSetup(cboGrade.SelectedValue.ToString(),cboScale.SelectedValue.ToString()).ToList();
            foreach (ScaleDSetup salhd in oSalHds)
            {
                ListViewItem itm = new ListViewItem(salhd.SalaryGradeSetup.GradeID);
                itm.SubItems.Add(salhd.ScaleMSetup.ScaleMID);
                itm.SubItems.Add(salhd.SalaryHead.HeadID);
                itm.SubItems.Add(salhd.amount);
                lvScaleDetails.Items.Add(itm);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtScaleTitle" };
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
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtAmount.Focus();
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            if (cboGrade.SelectedValue != null)
            {
                cboScale.DisplayMember = "ScaleTitle";
                cboScale.ValueMember = "ScaleMID";
                cboScale.DataSource = hmsSC.GetScaleUnderGrade(cboGrade.SelectedValue.ToString());

               
            }
            LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
            
        }

        private void cboScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboScale.SelectedValue != null)
            {
                //lvScaleDetails.Items.Clear();
                 LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
               
            }
        }

        private void cboHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboHead.Text != "")
            //{                
            //    LoadListView(cboGrade.Text.ToString(), cboScale.Text.ToString(), cboHead.Text.ToString());
            //}
        }

    }
}
