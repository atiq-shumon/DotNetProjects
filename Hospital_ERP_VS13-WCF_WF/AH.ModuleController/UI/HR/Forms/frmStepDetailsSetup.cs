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
    public partial class frmStepDetailsSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmStepDetailsSetup()
        {
            InitializeComponent();
        }
        private void FormatGrid()
        {
            dgvSalaryHead.ColumnCount = 6;
            this.dgvSalaryHead.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvSalaryHead.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvSalaryHead.Columns[0].Name = "Level";
            dgvSalaryHead.Columns[0].Width = 0;
            dgvSalaryHead.Columns[0].Visible = false;
            dgvSalaryHead.Columns[1].Name = "Grade";
            dgvSalaryHead.Columns[1].Width = 0;
            dgvSalaryHead.Columns[1].Visible = false;
            dgvSalaryHead.Columns[2].Name = "Step";
            dgvSalaryHead.Columns[2].Width = 0;
            dgvSalaryHead.Columns[2].Visible = false;
            dgvSalaryHead.Columns[3].Name = "Head ID";
            dgvSalaryHead.Columns[3].Width = 0;
            dgvSalaryHead.Columns[3].Visible = false;
            dgvSalaryHead.Columns[4].Name = "Salary Head";
            dgvSalaryHead.Columns[4].Width = 320;
            dgvSalaryHead.Columns[4].ReadOnly = true;
            dgvSalaryHead.Columns[5].Name = "Amount";
            dgvSalaryHead.Columns[5].Width =220;
            dgvSalaryHead.Columns[5].ReadOnly = true;
        }
        private void LoadListView(string Grade, string Step)
        {
            dgvSalaryHead.Rows.Clear();
            int i = 0;
            if (cboGrade.SelectedValue.ToString() != "")
            {
                List<ScaleDSetup> oSalHds = hmsSC.GetScaleDSetup(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString()).ToList();
                if (oSalHds.Count > 0)
                {
                    foreach (ScaleDSetup salhd in oSalHds)
                    {
                        dgvSalaryHead.Rows.Add(1);
                        dgvSalaryHead.Rows[i].Cells[0].Value = cboLevels.SelectedValue.ToString();
                        dgvSalaryHead.Rows[i].Cells[1].Value = cboGrade.SelectedValue.ToString();
                        dgvSalaryHead.Rows[i].Cells[2].Value = cboScale.SelectedValue.ToString();
                        dgvSalaryHead.Rows[i].Cells[3].Value = salhd.SalaryHead.HeadID;
                        dgvSalaryHead.Rows[i].Cells[4].Value = salhd.SalaryHead.HeadTitle;
                        dgvSalaryHead.Rows[i].Cells[5].Value = salhd.amount;
                        i = i + 1;
                    }
                }
                //else
                //{
                //    MessageBox.Show("Head is not processed yet!!please provide amount for this grade & step..", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtAmount.Focus();
                //    return;
                //}
            }

        }
        private void frmStepDetailsSetup_Load(object sender, EventArgs e)
        {
            cboLevels.DisplayMember = "Value";
            cboLevels.ValueMember = "Key";
            cboLevels.DataSource = new BindingSource(Utility.GetJobLevels(), null);

            FormatGrid();
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

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrade.SelectedValue != "")
            {
                cboScale.DisplayMember = "ScaleTitle";
                cboScale.ValueMember = "ScaleMID";
                cboScale.DataSource = hmsSC.GetScaleUnderGrade(cboGrade.SelectedValue.ToString()).ToList();              
            }  
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cboGrade.SelectedValue != "")
            {
                if (cboScale.SelectedValue != null)
                {
                    LoadListView(cboGrade.SelectedValue.ToString(), cboScale.SelectedValue.ToString());
                    updateCollectedTestSummary(dgvSalaryHead);
                }
            }
        }

        private ScaleDSetup PopulateStepDetails()
        {
            int j;
            string string1 = "";
            ScaleDSetup oSalD = new ScaleDSetup();

            SalaryGradeSetup oSalGrd = new SalaryGradeSetup();
            oSalGrd.GradeID = cboGrade.SelectedValue.ToString();
            oSalD.SalaryGradeSetup = oSalGrd;

            ScaleMSetup osclM = new ScaleMSetup();
            osclM.ScaleMID = cboScale.SelectedValue.ToString();
            oSalD.ScaleMSetup = osclM;

            for (j = 0; j < dgvSalaryHead.Rows.Count; j++)
            {
                string1 += dgvSalaryHead.Rows[j].Cells[3].Value.ToString() + ":" +
                           dgvSalaryHead.Rows[j].Cells[5].Value.ToString() + ":" + ";";
            }
            oSalD.SalaryHeadString= string1;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalD.EntryParameter = ep;
            return oSalD;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboLevels", "cboGrade", "cboScale"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                 ScaleDSetup oStepDet = this.PopulateStepDetails();
                 short i = hmsSC.SaveStepDetailsSetup(oStepDet);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void updateCollectedTestSummary(DataGridView dtv)
        {
            double sum = 0;
            for (int i = 0; i < dtv.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dtv.Rows[i].Cells[5].Value);
            }
            txtAmount.Text = sum.ToString();          
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dgvSalaryHead.Rows.Clear();
            int count;
            int i=0;
            double Basic=0;
            double HouseRent=0;
            double MedicalAllowance = 0;
            double Transport = 0;
            double Amount = Convert.ToDouble(txtAmount.Text);
            List<SalaryHead> oSalHeads = hmsSC.GetSalaryHead().ToList();
            count = oSalHeads.Count;
            if (count > 0)
            {
                dgvSalaryHead.Rows.Add(count);
                foreach (SalaryHead oSalHead in oSalHeads)
                {
                    dgvSalaryHead.Rows[i].Cells[3].Value = oSalHead.HeadID;
                    dgvSalaryHead.Rows[i].Cells[4].Value = oSalHead.HeadTitle;
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "001")
                    {
                        Basic = Amount * 0.60;
                        dgvSalaryHead.Rows[i].Cells[5].Value = Convert.ToDouble(Basic);
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "002")
                    {
                        HouseRent = Basic * 0.50;
                        dgvSalaryHead.Rows[i].Cells[5].Value = Convert.ToDouble(HouseRent);
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "003")
                    {
                        Transport = Amount * 0.05;
                        dgvSalaryHead.Rows[i].Cells[5].Value = Convert.ToDouble(Transport);
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "004")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "005")
                    {
                        MedicalAllowance = Amount * 0.05; ;
                        dgvSalaryHead.Rows[i].Cells[5].Value = Convert.ToDouble(MedicalAllowance);
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "006")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "007")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "008")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "009")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "010")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "011")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "012")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "013")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "014")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    if (dgvSalaryHead.Rows[i].Cells[3].Value.ToString() == "015")
                    {
                        dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                    }
                    i = i + 1;
                }
            }
            updateCollectedTestSummary(dgvSalaryHead);
        }

        private void dgvSalaryHead_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            for(int i=0;i<dgvSalaryHead.Rows.Count-1;i++)
            {
                if(dgvSalaryHead.Rows[i].Cells[5].Value==null)
                {
                    dgvSalaryHead.Rows[i].Cells[5].Value = 0;
                }
            }
        }
    }
}
