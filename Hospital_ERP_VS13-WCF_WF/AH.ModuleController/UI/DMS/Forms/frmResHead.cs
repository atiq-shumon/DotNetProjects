using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.DMS.Forms
{
    public partial class frmResHead : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSc = new DMSSR.DMSWSClient();
        public string SecID { set; get; }
        public string GrpID { set; get; }
        List<ResultHead> oResultHeads;
        private List<ResultHead> rshd;
        public frmResHead()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtResHeadName.Text = "";
            txtResHeadNameBeng.Text = "";
            cboUnitID.Text = "--Select--";
            chkLIS.Checked = false;
            chkQualitative.Checked = false;
            chkGender.Checked = false;
            txtRemarks.Text = "";
            txtLowerRange.Text = "";
            txtUpperRange.Text = "";
            txtLRangeMale.Text = "";
            txtURangeMale.Text = "";
            txtLRangeFemale.Text = "";
            txtURangeFemale.Text = "";
            txtLRangeChild.Text = "";
            txtURangeChild.Text = "";
            txtReffValText.Text = "";
            txtReffValText.Text = "";
            txtInterpretation.Text = "";
            cboMachine.Text = "--Select--";
            chkRange.Checked = false;
            txtResHeadName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboSection", "cboGroupID", "txtResHeadName", "txtResHeadNameBeng", "cboUnitID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (dgvResultRange.Rows.Count == 0)
                {
                    MessageBox.Show("At Least One Machine Must Be Added!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Utility.IsDuplicateFoundInList(lvResHead, 1, txtResHeadName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Result Head", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtResHeadName.Focus();
                    return;
                }
                else
                {
                    ResultHead rshdobj = this.PopulateResHd();
                    short i = dmsSc.SaveReshd(rshdobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvResultRange.Rows.Clear();
                        RefreshGrid();
                        clear();
                        txtResHeadName.Focus();
                        oResultHeads = dmsSc.GetResultHdReff().ToList();
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
            LoadListView(cboSection.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString()); 
        }
        private void FormatGrid()
        {
            lvResHead.CheckBoxes = false;
            lvResHead.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Head Name", 700, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Head Name(Bangla)", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Gender Sensitive", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Qualitative", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Qualitative Group", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Serial No", 0, HorizontalAlignment.Left);           
            lvResHead.Columns.Add("Report GroupID", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Unit ID", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("LIS Sycn", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("LIS Sycn", 0, HorizontalAlignment.Left);
            lvResHead.Columns.Add("Section", 0, HorizontalAlignment.Left);
        }
        private ResultHead PopulateResHd()
        {
            string string1 = "";
            int j;
            ResultHead reshd = new ResultHead();
            reshd.ResultHeadID = txtResHeadID.Text;
            reshd.ResultHeadTitle = txtResHeadName.Text;
            reshd.ResultHeadTitleBeng = txtResHeadNameBeng.Text;
            reshd.Remarks = txtRemarks.Text.ToString();
            if (chkGender.Checked == true)
            {
                reshd.GenderSentitive = "1";
            }
            if (chkGender.Checked == false)
            {
                reshd.GenderSentitive = "0";
            }
            if (chkLIS.Checked == true)
            {
                reshd.IsLisSyn= "1";
            }
            if (chkLIS.Checked == false)
            {
                reshd.IsLisSyn = "0";
            }

            if (chkQualitative.Checked == true)
            {
                reshd.QualitiveFlag = "1";
                reshd.QualitiveGroup = cboQualitative.SelectedValue.ToString();  
            }
            if (chkQualitative.Checked == false)
            {
                reshd.QualitiveFlag = "0";
                reshd.QualitiveGroup = "0";              
            }
            ReportGroup rpt = new ReportGroup();
            rpt.ReportGroupID = cboGroupID.SelectedValue.ToString();
            reshd.ReportGroup = rpt;
           
            ResultHeadUnit resunit = new ResultHeadUnit();
            resunit.UnitID = cboUnitID.SelectedValue.ToString();
            reshd.ResultHeadUnit = resunit;

            ReportSection oRptSec = new ReportSection();
            oRptSec.ReportSectionID = cboSection.SelectedValue.ToString();
            reshd.ReportSection = oRptSec;

            for (j = 0; j < dgvResultRange.Rows.Count; j++)
            {
                string1 += dgvResultRange.Rows[j].Cells[0].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[2].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[3].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[4].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[5].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[6].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[7].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[8].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[9].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[10].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[11].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[12].Value.ToString() + "@" +
                           dgvResultRange.Rows[j].Cells[13].Value.ToString() + "@" + ";";
            }
            reshd.MachineString = string1;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            reshd.EntryParameter = ep;

            return reshd;
        }
        private void frmResHead_Load(object sender, EventArgs e)
        {
            try
            {
                cboSection.DisplayMember = "Value";
                cboSection.ValueMember = "Key";
                cboSection.DataSource = new BindingSource(dmsSc.GetRptSecDic("D"), null);

                cboUnitID.DisplayMember = "Value";
                cboUnitID.ValueMember = "Key";
                cboUnitID.DataSource = new BindingSource(dmsSc.GetResUnitDict("D"), null);

                cboMachine.DisplayMember = "Value";
                cboMachine.ValueMember = "Key";
                cboMachine.DataSource = new BindingSource(dmsSc.GetMacSetup("D"), null);

                cboQualitative.DisplayMember = "Value";
                cboQualitative.ValueMember = "Key";
                cboQualitative.DataSource = new BindingSource(dmsSc.GetQualitativeGrp("D"), null);

                FormatGridView();
                oResultHeads = dmsSc.GetResultHdReff().ToList();

                FormatGrid();
                if (SecID != null)
                {
                    cboSection.SelectedValue = SecID;
                    if (GrpID != null)
                    {
                        cboGroupID.SelectedValue = GrpID;
                        btnShow_Click(sender, e);
                    }
                }
                //LoadListView();  
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
        private void LoadListView(string Section,string Group)
        {
            lvResHead.Items.Clear();
             rshd = dmsSc.GetResultHdBySecGrp(Section, Group).ToList();
            foreach (ResultHead rsh in rshd)
            {
                ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                itm.SubItems.Add(rsh.ResultHeadTitle);
                itm.SubItems.Add(rsh.ResultHeadTitleBeng);
                itm.SubItems.Add(rsh.GenderSentitive);
                itm.SubItems.Add(rsh.QualitiveFlag);
                itm.SubItems.Add(rsh.QualitiveGroup);
                itm.SubItems.Add(rsh.Remarks);
                itm.SubItems.Add(rsh.Serial.ToString());             
                itm.SubItems.Add(rsh.ReportGroup.ReportGroupID);
                itm.SubItems.Add(rsh.ResultHeadUnit.UnitID);
                itm.SubItems.Add(rsh.IsLisSyn);
                itm.SubItems.Add(rsh.ReportSection.ReportSectionID);
                lvResHead.Items.Add(itm);
            }
        }

        private void lvResHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResHead.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvResHead.SelectedItems[0];
                txtResHeadID.Text = itm.SubItems[0].Text;
                txtResHeadName.Text = itm.SubItems[1].Text;
                txtResHeadNameBeng.Text = itm.SubItems[2].Text;
                if (itm.SubItems[3].Text == "1")
                {
                    chkGender.Checked = true;
                }
                if (itm.SubItems[3].Text == "0")
                {
                    chkGender.Checked = false;
                }
                if (itm.SubItems[4].Text == "1")
                {
                    chkQualitative.Checked = true;
                }
                if (itm.SubItems[4].Text == "0")
                {
                    chkQualitative.Checked = false;
                }
                cboQualitative.SelectedValue = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
                txtSerial.Text = itm.SubItems[7].Text;
                cboGroupID.SelectedValue = itm.SubItems[8].Text.ToString();
                cboUnitID.SelectedValue = itm.SubItems[9].Text.ToString();
                if (itm.SubItems[10].Text == "1")
                {
                    chkLIS.Checked = true;
                }
                if (itm.SubItems[10].Text == "0")
                {
                    chkLIS.Checked = false;
                }
                cboSection.SelectedValue = itm.SubItems[11].Text;
                dgvResultRange.Rows.Clear();
                List<ResultHead> oResultHeadWithReff = oResultHeads.Where(x => x.ResultHeadID == txtResHeadID.Text).ToList();
                foreach (ResultHead rh in oResultHeadWithReff)
                {
                    AddRowsToSpecimenCollection(dgvResultRange, new string[] { rh.Machine.MachineID, rh.Machine.MachineTitle, rh.LowerRange, rh.UpperRange, rh.LowerRangeMale, rh.UpperRangeMale, rh.LowerRangeFeMale, rh.UpperRangeFeMale, rh.LowerRangeChild, rh.UpperRangeChild, rh.RangeText, rh.DefaultValue, rh.InterpretationText, rh.InterpretationFlag });
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboSection", "cboGroupID", "txtResHeadName", "txtResHeadNameBeng", "cboUnitID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyResHd(txtResHeadID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResHeadID.Select();
                return;
            }
            try
            {
                if (dgvResultRange.Rows.Count == 0)
                {
                    MessageBox.Show("At Least One Machine Must Be Added!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (Utility.IsDuplicateFoundInList(lvResHead, 1, txtResHeadName.Text))
                //{
                //    MessageBox.Show("Cannot Insert Duplicate Result Head Name", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtResHeadName.Focus();
                //    return;
                //}
                 
                else
                {
                ResultHead rshdobj = this.PopulateResHd();
                short i = dmsSc.UpdateReshd(rshdobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvResultRange.Rows.Clear();
                    oResultHeads = dmsSc.GetResultHdReff().ToList();
                    RefreshGrid();
                    clear();
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
        private void lvResHead_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvResultRange.Rows.Clear();
        }
        private void chkQualitative_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQualitative.Checked == true)
            {
                cboQualitative.Enabled = true;               
            }
            else
            {
                cboQualitative.Enabled = false;                
            }
        }
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmResHeadUnit oResUnit = new frmResHeadUnit();
            oResUnit.ShowDialog();
        }

        private void btnRefreshUnit_Click(object sender, EventArgs e)
        {
            cboUnitID.DisplayMember = "Value";
            cboUnitID.ValueMember = "Key";
            cboUnitID.DataSource = new BindingSource(dmsSc.GetResUnitDict("D"), null);
        }

        private void FormatGridView()
        {
            dgvResultRange.ColumnCount = 14;
            this.dgvResultRange.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvResultRange.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvResultRange.Columns[0].Name = "MachineID";
            dgvResultRange.Columns[0].ReadOnly = true;
            dgvResultRange.Columns[0].Width = 0;
            dgvResultRange.Columns[0].Visible = false;
            dgvResultRange.Columns[1].Name = "Machine";
            dgvResultRange.Columns[1].ReadOnly = true;
            dgvResultRange.Columns[1].Width = 140;
            dgvResultRange.Columns[2].Name = "L.Range";
            dgvResultRange.Columns[2].ReadOnly = true;
            dgvResultRange.Columns[2].Width = 100;
            dgvResultRange.Columns[3].Name = "U.Range";
            dgvResultRange.Columns[3].ReadOnly = true;
            dgvResultRange.Columns[3].Width = 100;
            dgvResultRange.Columns[4].Name = "L.Range Male";
            dgvResultRange.Columns[4].ReadOnly = true;
            dgvResultRange.Columns[4].Width = 100;
            dgvResultRange.Columns[5].Name = "U.Range Male";
            dgvResultRange.Columns[5].ReadOnly = true;
            dgvResultRange.Columns[5].Width = 100;
            dgvResultRange.Columns[6].Name = "L.Range Female";
            dgvResultRange.Columns[6].ReadOnly = true;
            dgvResultRange.Columns[6].Width = 100;
            dgvResultRange.Columns[7].Name = "U.Range Female";
            dgvResultRange.Columns[7].ReadOnly = true;
            dgvResultRange.Columns[7].Width = 100;
            dgvResultRange.Columns[8].Name = "L.Range Child";
            dgvResultRange.Columns[8].ReadOnly = true;
            dgvResultRange.Columns[8].Width = 100;
            dgvResultRange.Columns[9].Name = "U.Range Child";
            dgvResultRange.Columns[9].ReadOnly = true;
            dgvResultRange.Columns[9].Width = 100;
            dgvResultRange.Columns[10].Name = "Referrence Value";
            dgvResultRange.Columns[10].ReadOnly = true;
            dgvResultRange.Columns[10].Width = 100;
            dgvResultRange.Columns[11].Name = "Default Value";
            dgvResultRange.Columns[11].ReadOnly = true;
            dgvResultRange.Columns[11].Width = 0;
            dgvResultRange.Columns[11].Visible = false;
            dgvResultRange.Columns[12].Name = "Interpretation";
            dgvResultRange.Columns[12].ReadOnly = true;
            dgvResultRange.Columns[12].Width = 0;
            dgvResultRange.Columns[12].Visible = false;
            dgvResultRange.Columns[13].Name = "Interpretation Flag";
            dgvResultRange.Columns[13].ReadOnly = true;
            dgvResultRange.Columns[13].Width = 0;
            dgvResultRange.Columns[13].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvResultRange.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 60;
        }
        private void AddRowsToSpecimenCollection(DataGridView dtv, string[] row)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, row);
        }
        private bool CheckDuplicate(string Machine)
        {
            for (int i = 0; i < dgvResultRange.Rows.Count; i++)
            {
                string strVar = dgvResultRange.Rows[i].Cells[1].Value.ToString();
                if (Machine == strVar)
                {
                    MessageBox.Show("Cannot Insert Duplicate Machine Name", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        private void btnAddSpecimen_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "cboMachine", "txtLowerRange", "txtUpperRange", "txtLRangeMale", "txtURangeMale", "txtLRangeFemale", "txtURangeFemale", "txtLRangeChild", "txtURangeChild" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                if (CheckDuplicate(cboMachine.Text.ToString()) == false)
                {
                    int flag = 0;
                    if (chkInterpretation.Checked == true)
                    {
                        flag = 1;
                    }
                    if (chkInterpretation.Checked == false)
                    {
                        flag = 0;
                    }
                    AddRowsToSpecimenCollection(dgvResultRange, new string[] { cboMachine.SelectedValue.ToString(), cboMachine.Text.ToString(), txtLowerRange.Text.ToString(), txtUpperRange.Text.ToString(), txtLRangeMale.Text.ToString(), txtURangeMale.Text.ToString(), txtLRangeFemale.Text.ToString(), txtURangeFemale.Text.ToString(), txtLRangeChild.Text.ToString(), txtURangeChild.Text.ToString(), txtReffValText.Text.ToString(), txtDefaultValue.Text.ToString(), txtInterpretation.Text.ToString(), flag.ToString() });
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
        private void dgvResultRange_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dgvResultRange.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgvResultRange.Rows.RemoveAt(selectedIndex);
                dgvResultRange.Refresh();
            }
        }

        private void dgvResultRange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                if (dgvResultRange.Rows.Count > 0)
                {
                    cboMachine.Text = dgvResultRange.Rows[row].Cells[1].Value.ToString();
                    txtLowerRange.Text = dgvResultRange.Rows[row].Cells[2].Value.ToString();
                    txtUpperRange.Text = dgvResultRange.Rows[row].Cells[3].Value.ToString();
                    txtLRangeMale.Text = dgvResultRange.Rows[row].Cells[4].Value.ToString();
                    txtURangeMale.Text = dgvResultRange.Rows[row].Cells[5].Value.ToString();
                    txtLRangeFemale.Text = dgvResultRange.Rows[row].Cells[6].Value.ToString();
                    txtURangeFemale.Text = dgvResultRange.Rows[row].Cells[7].Value.ToString();
                    txtLRangeChild.Text = dgvResultRange.Rows[row].Cells[8].Value.ToString();
                    txtURangeChild.Text = dgvResultRange.Rows[row].Cells[9].Value.ToString();
                    txtReffValText.Text = dgvResultRange.Rows[row].Cells[10].Value.ToString();
                    txtDefaultValue.Text = dgvResultRange.Rows[row].Cells[11].Value.ToString();
                    txtInterpretation.Text = dgvResultRange.Rows[row].Cells[12].Value.ToString();
                    if (dgvResultRange.Rows[row].Cells[13].Value.ToString() == "1")
                    {
                        chkInterpretation.Checked = true;
                    }
                    if (dgvResultRange.Rows[row].Cells[13].Value.ToString() == "0")
                    {
                        chkInterpretation.Checked = false;
                    }
                }
            }

            if (dgvResultRange.Columns[e.ColumnIndex].Name == "btn")
            {
                if (dgvResultRange.CurrentCell != null)
                {
                    int selectedIndex = dgvResultRange.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        dgvResultRange.Rows.RemoveAt(selectedIndex);
                        dgvResultRange.Refresh(); // if needed
                    }
                }
            }          

        }
        private void btnAddReportGrp_Click(object sender, EventArgs e)
        {
            frmReportGroup oRepGrp = new frmReportGroup();
            oRepGrp.ShowDialog();
        }
        private void btnRefreshReportGrp_Click(object sender, EventArgs e)
        {
            if (cboSection.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(dmsSc.GetRptgrpDic(cboSection.SelectedValue.ToString()), null);
            }
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSection.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(dmsSc.GetRptgrpDic(cboSection.SelectedValue.ToString()), null);
            }

        }

        private void btnAddRptSection_Click(object sender, EventArgs e)
        {
            frmReportSection oRptSec = new frmReportSection();
            oRptSec.ShowDialog();
        }

        private void btnRefreshRptSection_Click(object sender, EventArgs e)
        {
            cboSection.DisplayMember = "Value";
            cboSection.ValueMember = "Key";
            cboSection.DataSource = new BindingSource(dmsSc.GetRptSecDic("D"), null);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSection.SelectedValue != "")
                {
                    if (cboGroupID.SelectedValue != "")
                    {
                        LoadListView(cboSection.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString());
                        clear();
                        dgvResultRange.Rows.Clear();
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

        private void btnAddQualitativeGrp_Click(object sender, EventArgs e)
        {
            frmQualitativeGroupSetup oQl = new frmQualitativeGroupSetup();
            oQl.ShowDialog();
        }
        private void btnRefreshQualitativeGrp_Click(object sender, EventArgs e)
        {
            cboQualitative.DisplayMember = "Value";
            cboQualitative.ValueMember = "Key";
            cboQualitative.DataSource = new BindingSource(dmsSc.GetQualitativeGrp("D"), null);
        }
        private void chkRange_CheckedChanged(object sender, EventArgs e)
        {
            if(chkRange.Checked==true)
            {
                txtLowerRange.Text = "0";
                txtUpperRange.Text = "0";
                txtLRangeMale.Text = "0";
                txtURangeMale.Text = "0";
                txtLRangeFemale.Text = "0";
                txtURangeFemale.Text = "0";
                txtLRangeChild.Text = "0";
                txtURangeChild.Text = "0";
            }
            if (chkRange.Checked == false)
            {
                txtLowerRange.Text = "";
                txtUpperRange.Text = "";
                txtLRangeMale.Text = "";
                txtURangeMale.Text = "";
                txtLRangeFemale.Text = "";
                txtURangeFemale.Text = "";
                txtLRangeChild.Text = "";
                txtURangeChild.Text = "";
                txtReffValText.Text = "";
            }
        }

        private void txtReffValText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtReffValText.Focus();
            }           
        }

        private void cboSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cboGroupID.Focus();
            } 
        }

        private void cboGroupID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnShow.Focus();
            } 

        }

        private void txtResHeadName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtResHeadNameBeng.Focus();
            } 
        }

        private void txtResHeadNameBeng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cboUnitID.Focus();
            } 
        }

        private void cboUnitID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                chkLIS.Focus();
            } 
        }

        private void chkLIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                chkQualitative.Focus();
            } 
        }

        private void chkQualitative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cboQualitative.Focus();
            } 
        }

        private void cboQualitative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                chkGender.Focus();
            } 
        }

        private void chkGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRemarks.Focus();
            } 
            
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cboMachine.Focus();
            } 
        }

        private void cboMachine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLowerRange.Focus();
            } 
        }

        private void txtLowerRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtUpperRange.Focus();
            } 
        }

        private void txtUpperRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLRangeMale.Focus();
            } 
        }

        private void txtLRangeMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtURangeMale.Focus();
            } 
        }

        private void txtURangeMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLRangeFemale.Focus();
            } 
        }

        private void txtLRangeFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtURangeFemale.Focus();
            } 
        }

        private void txtURangeFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLRangeChild.Focus();
            } 
        }

        private void txtLRangeChild_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtURangeChild.Focus();
            } 
        }

        private void txtURangeChild_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtReffValText.Focus();
            } 
        }
        private void SearchListView(IEnumerable<ResultHead> oResults, string searchString = "")
        {
            IEnumerable<ResultHead> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.ResultHeadTitle.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);

                }
                lvResHead.Items.Clear();
                foreach (ResultHead rsh in query)
                {
                    ListViewItem itm = new ListViewItem(rsh.ResultHeadID);
                    itm.SubItems.Add(rsh.ResultHeadTitle);
                    itm.SubItems.Add(rsh.ResultHeadTitleBeng);
                    itm.SubItems.Add(rsh.GenderSentitive);
                    itm.SubItems.Add(rsh.QualitiveFlag);
                    itm.SubItems.Add(rsh.QualitiveGroup);
                    itm.SubItems.Add(rsh.Remarks);
                    itm.SubItems.Add(rsh.Serial.ToString());
                    itm.SubItems.Add(rsh.ReportGroup.ReportGroupID);
                    itm.SubItems.Add(rsh.ResultHeadUnit.UnitID);
                    itm.SubItems.Add(rsh.IsLisSyn);
                    itm.SubItems.Add(rsh.ReportSection.ReportSectionID);
                    lvResHead.Items.Add(itm);
                }
            }

        }

        private void txtResHeadName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(rshd, txtResHeadName.Text);
        }

        private void txtInterpretation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtInterpretation.Focus();
            } 
        }

        private void txtDefaultValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDefaultValue.Focus();
            } 
        }

        private void txtInterpretation_TextChanged(object sender, EventArgs e)
        {
            if (txtInterpretation.Text != "")
            {
                chkInterpretation.Checked = true;
                chkInterpretation.Enabled = false;
            }
            else
            {
                chkInterpretation.Checked = false;
                chkInterpretation.Enabled = true;
            }
        }

        private void txtResHeadName_TextChanged(object sender, EventArgs e)
        {
            txtResHeadNameBeng.Text = txtResHeadName.Text;
        }

        private void btnEditReffValue_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboSection", "cboGroupID", "txtResHeadName", "txtResHeadNameBeng", "cboUnitID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dmsSc.VerifyResHd(txtResHeadID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResHeadID.Select();
                return;
            }
            try
            {
                if (dgvResultRange.Rows.Count == 0)
                {
                    MessageBox.Show("At Least One Machine Must Be Added!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }             
                    ResultHead rshdobj = this.PopulateResHd();
                    short i = dmsSc.UpdateReshd(rshdobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvResultRange.Rows.Clear();
                        oResultHeads = dmsSc.GetResultHdReff().ToList();
                        RefreshGrid();
                        clear();
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
