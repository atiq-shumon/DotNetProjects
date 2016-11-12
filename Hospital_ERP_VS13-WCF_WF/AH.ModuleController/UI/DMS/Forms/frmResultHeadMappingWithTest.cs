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
    public partial class frmResultHeadMappingWithTest : AH.Shared.UI.frmSmartFormStandard
    {
        DMSSR.DMSWSClient dmsSC = new DMSSR.DMSWSClient();
        private List<ResultHead> rshd;
        public string DepartmentID { set; get; }
        public string GroupID { set; get; }
        public string MainID { set; get; }
        public string DetailID { set; get; }
        string HdGrp = "";
        string Srl = "";
        int Pos;
        public frmResultHeadMappingWithTest()
        {
            InitializeComponent();
        }
        private void frmResultHeadMappingWithTest_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid(dgvInitialGrid);
                FormatAssociatedGrid();

                cboDeptID.DisplayMember = "Value";
                cboDeptID.ValueMember = "Key";
                cboDeptID.DataSource = new BindingSource(dmsSC.GetDepartments("D"), null);

                if (DepartmentID != null)
                {
                    cboDeptID.SelectedValue = DepartmentID.ToString();
                    cboGroupID.SelectedValue = GroupID.ToString();
                    cboMainID.SelectedValue = MainID.ToString();
                    cboTestDet.SelectedValue = DetailID.ToString();
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
        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeptID.SelectedValue != "")
            {
                cboGroupID.DisplayMember = "Value";
                cboGroupID.ValueMember = "Key";
                cboGroupID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetDiagnGrpDeptWise("D", cboDeptID.SelectedValue.ToString())), null);
                if (cboGroupID.SelectedValue != null)
                {
                    cboMainID.DisplayMember = "Value";
                    cboMainID.ValueMember = "Key";
                    cboMainID.DataSource = new BindingSource(Utility.VerifyDic(dmsSC.GetMainDeptwise("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString())), null);
                }
            }
        }

        private void cboMainID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMainID.SelectedValue != null)
            {
                cboTestDet.DisplayMember = "Value";
                cboTestDet.ValueMember = "Key";
                cboTestDet.DataSource = new BindingSource(dmsSC.GetTestDetsDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString()), null);
            }

            if (cboMainID.SelectedValue != null)
            {
                cboTestDetRpt.DisplayMember = "Value";
                cboTestDetRpt.ValueMember = "Key";
                cboTestDetRpt.DataSource = new BindingSource(dmsSC.GetTestDetsDict("D", cboDeptID.SelectedValue.ToString(), cboGroupID.SelectedValue.ToString(), cboMainID.SelectedValue.ToString()), null);
            }
        }

        private void FormatGrid(DataGridView dgv)
        {
            this.dgvInitialGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvInitialGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvInitialGrid.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            chk.Visible = true;
            chk.Width = 53;
            dgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "ID";
            ID.DataPropertyName = "ID";
            ID.Width = 120;
            ID.ReadOnly = true;
            dgv.Columns.Add(ID);

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.Name = "Name";
            Name.DataPropertyName = "Name";
            Name.Width = 317;
            Name.ReadOnly = true;
            dgv.Columns.Add(Name);
        }

        private void FormatAssociatedGrid()
        {            
            dgvAssociatedGrid.ColumnCount = 9;
            this.dgvAssociatedGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvAssociatedGrid.Columns[0].Name = "Blank";
            dgvAssociatedGrid.Columns[0].Width = 0;
            dgvAssociatedGrid.Columns[0].Visible = false;
            dgvAssociatedGrid.Columns[1].Name = "ID";
            dgvAssociatedGrid.Columns[1].Width = 50;
            dgvAssociatedGrid.Columns[1].ReadOnly = true;
            dgvAssociatedGrid.Columns[2].Name = "Name";
            dgvAssociatedGrid.Columns[2].Width = 200;
            dgvAssociatedGrid.Columns[2].ReadOnly = true;
            dgvAssociatedGrid.Columns[3].Name = "HeadGroupID";
            dgvAssociatedGrid.Columns[3].Width = 0;
            dgvAssociatedGrid.Columns[3].Visible = false;
            dgvAssociatedGrid.Columns[4].Name = "Head Group";
            dgvAssociatedGrid.Columns[4].Width = 180;
            dgvAssociatedGrid.Columns[4].ReadOnly = true;
            dgvAssociatedGrid.Columns[5].Name = "Hd Grp Srl";
            dgvAssociatedGrid.Columns[5].Width = 50;
            dgvAssociatedGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssociatedGrid.Columns[6].Name = "Serial";
            dgvAssociatedGrid.Columns[6].Width = 50;
            dgvAssociatedGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAssociatedGrid.Columns[7].Name = "Test Det";
            dgvAssociatedGrid.Columns[7].Width = 0;
            dgvAssociatedGrid.Columns[7].Visible = false;
            dgvAssociatedGrid.Columns[8].Name = "Test Details";
            dgvAssociatedGrid.Columns[8].Width = 200;
            dgvAssociatedGrid.Columns[8].ReadOnly = true;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btnEdit);
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.DefaultCellStyle.ForeColor = Color.SeaGreen;
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 45;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAssociatedGrid.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.DefaultCellStyle.ForeColor = Color.Navy;
            btn.UseColumnTextForButtonValue = true;
            btn.Width = 50;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            
            try
            {
                dgvInitialGrid.DataSource = null;
                dgvInitialGrid.Rows.Clear();
             if (cboTestDet.SelectedValue != null)
             {
                 int i = 0;
                 LoadReportGrpWithHead(cboTestDet.SelectedValue.ToString());
                 List<ResultHead> rshd = dmsSC.GetHdByGrp(txtRptGrpID.Text.ToString()).ToList();
                 if (rshd.Count > 0)
                 {
                     foreach (ResultHead rsh in rshd)
                     {
                         dgvInitialGrid.Rows.Add(1);
                         dgvInitialGrid.Rows[i].Cells[1].Value = rsh.ResultHeadID;
                         dgvInitialGrid.Rows[i].Cells[2].Value = rsh.ResultHeadTitle;                       
                         i = i + 1;
                     }
                     dgvInitialGrid.AllowUserToAddRows = false;                     
                 }
                 else
                 {
                     return;
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
            if (cboTestDet.SelectedValue != null)
            {
                RefreshResultHead(cboTestDet.SelectedValue.ToString(), txtRptGrpID.Text.ToString());
                LoadAssociatedListView(cboTestDet.SelectedValue.ToString());
                LoadResultHeadGroup();
            }
            //dgvAssociatedGrid.CurrentCell.Selected = false;
        }
        private void LoadResultHeadGroup()
        {
            cboHeadGroupID.DisplayMember = "Value";
            cboHeadGroupID.ValueMember = "key";
            cboHeadGroupID.DataSource = new BindingSource(dmsSC.GetGrpByDeptSecDic(cboDeptID.SelectedValue.ToString(), txtSecID.Text.ToString()), null);
        }
        private void RefreshResultHead(string TestDetail, string ReportGroup)
        {
            try
            {
                dgvAssociatedGrid.DataSource = null;
                dgvInitialGrid.Rows.Clear();
                if (cboTestDet.SelectedValue != null)
                {
                    int i = 0;
                    LoadReportGrpWithHead(cboTestDet.SelectedValue.ToString());
                    rshd = dmsSC.GetHdByGrp(txtRptGrpID.Text.ToString()).ToList();
                    if (rshd.Count > 0)
                    {
                        foreach (ResultHead rsh in rshd)
                        {
                            dgvInitialGrid.Rows.Add(1);
                            dgvInitialGrid.Rows[i].Cells[1].Value = rsh.ResultHeadID;
                            dgvInitialGrid.Rows[i].Cells[2].Value = rsh.ResultHeadTitle;
                            i = i + 1;
                        }
                        dgvInitialGrid.AllowUserToAddRows = false;
                    }
                    else
                    {
                        return;
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

        private void PopulateDataToGrid(DataGridView dgv, string ResHeadTitle)
        {
            try
            {
                if (rshd != null)
                {
                    IEnumerable<ResultHead> TestsListLocal;
                    if (!(ResHeadTitle.Length > 0))
                    {
                        TestsListLocal = rshd;
                    }
                    else
                    {
                        TestsListLocal = rshd.Where(x => x.ResultHeadTitle.ToLower().Contains(ResHeadTitle.ToLower()));
                    }
                    dgv.DataSource = TestsListLocal.Select(data => new
                    {
                        ID = data.ResultHeadID,
                        Name = data.ResultHeadTitle
                    }).ToList();
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

        private void LoadAssociatedListView(string TestDetail)
        {
            try
            {
                dgvAssociatedGrid.DataSource = null;
                dgvAssociatedGrid.Rows.Clear();
                int i = 0;
                List<ResultHead> rshd = dmsSC.GetResultHdMap(cboTestDet.SelectedValue.ToString()).ToList();
                if (rshd.Count > 0)
                {
                    foreach (ResultHead rsh in rshd)
                    {
                        dgvAssociatedGrid.Rows.Add(1);
                        dgvAssociatedGrid.Rows[i].Cells[1].Value = rsh.ResultHeadID;
                        dgvAssociatedGrid.Rows[i].Cells[2].Value = rsh.ResultHeadTitle;
                        dgvAssociatedGrid.Rows[i].Cells[3].Value = rsh.ResultGroup.ResultHeadGroupID;
                        dgvAssociatedGrid.Rows[i].Cells[4].Value = rsh.ResultGroup.ResultHeadGroupTitle;
                        dgvAssociatedGrid.Rows[i].Cells[5].Value = rsh.HdGrpSerial.ToString();
                        dgvAssociatedGrid.Rows[i].Cells[6].Value = rsh.Serial.ToString();
                        dgvAssociatedGrid.Rows[i].Cells[7].Value = rsh.TestSub.TestSubID;
                        dgvAssociatedGrid.Rows[i].Cells[8].Value = rsh.TestSub.TestSubTitle;
                        i = i + 1;
                    }
                    dgvAssociatedGrid.AllowUserToAddRows = false;
                }
                else
                {
                    return;
                }
                dgvAssociatedGrid.CurrentCell = null;
                dgvAssociatedGrid.ClearSelection();
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


        private void LoadReportGrpWithHead(string TestDetail)
        {
            try
            {
                if (cboTestDet.SelectedValue != null)
                {
                    List<ResultHead> rshd = new List<ResultHead>();
                    rshd = dmsSC.GetRprGrpByTest(cboTestDet.SelectedValue.ToString()).ToList();
                    foreach (ResultHead rsh in rshd)
                    {
                        txtRptGrpID.Text = rsh.ReportGroup.ReportGroupID;
                        txtRptGrpTitle.Text = rsh.ReportGroup.ReportGroupTitle;
                        txtCatagoryID.Text = rsh.ReportGroup.TestCategory.TestCategoryID;
                        txtCatagory.Text = rsh.ReportGroup.TestCategory.TestCategoryTitle;
                        txtPanelID.Text = rsh.ReportGroup.GroupPanel.PanelID;
                        txtPanelTitle.Text = rsh.ReportGroup.GroupPanel.PanelTitle;
                        txtSecID.Text = rsh.ReportGroup.ReportSection.ReportSectionID;
                        txtReportSection.Text = rsh.ReportGroup.ReportSection.ReportSectionTitle;
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
        private void btnAddResultHeadGrp_Click(object sender, EventArgs e)
        {
            frmResHeadGroup orehGrp = new frmResHeadGroup();
            if (cboDeptID.SelectedValue != "")
            {
                orehGrp.DeptID = cboDeptID.SelectedValue.ToString();
                if (txtSecID.Text != "")
                {
                    orehGrp.SecID = txtSecID.Text.ToString();
                }
            }
            orehGrp.ShowDialog();
        }
        private void btnRefreshResultHeadGrp_Click(object sender, EventArgs e)
        {
            LoadResultHeadGroup();
        }
        private void btnAddResultHead_Click(object sender, EventArgs e)
        {
            frmResHead oResh = new frmResHead();
            if (txtSecID.Text != "")
            {
                oResh.SecID = txtSecID.Text.ToString();
                if (txtRptGrpID.Text != "")
                {
                    oResh.GrpID = txtRptGrpID.Text.ToString();
                }
            }
            oResh.ShowDialog();
        }
        private void btnRefreshResultHead_Click(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }
        private void btnAddTestDet_Click(object sender, EventArgs e)
        {
            frmDiagnosticDetailSetup oDet = new frmDiagnosticDetailSetup();
            {
                if (cboDeptID.SelectedValue != "")
                {
                    oDet.Department = cboDeptID.SelectedValue.ToString();
                    if (cboGroupID.SelectedValue != "")
                    {
                        oDet.Group = cboGroupID.SelectedValue.ToString();
                        if (cboMainID.SelectedValue != "")
                        {
                            oDet.Main = cboMainID.SelectedValue.ToString();
                        }
                    }
                }
            }
            oDet.ShowDialog();
        }
        private void cboTestDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }
        private ResultHead PopulateResHd()
        {
            string string1 = "";
            ResultHead reshd = new ResultHead();

            TestSub oTest = new TestSub();
            oTest.TestSubID = cboTestDet.SelectedValue.ToString();
            reshd.TestSub = oTest;

            ReportGroup rpt = new ReportGroup();
            rpt.ReportGroupID = txtRptGrpID.Text.ToString();
            reshd.ReportGroup = rpt;

            ResultHeadGroup rshdgr = new ResultHeadGroup();
            rshdgr.ResultHeadGroupID = cboHeadGroupID.SelectedValue.ToString();
            reshd.ResultGroup = rshdgr;

            for (int i = 0; i < dgvAssociatedGrid.Rows.Count; i++)
            {
                string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +  
                            ":" + ";";
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
        private ResultHead PopulateResHdForUpdate()
        {
            string string1 = "";
            ResultHead reshd = new ResultHead();

            TestSub oTest = new TestSub();
            oTest.TestSubID = cboTestDet.SelectedValue.ToString();
            reshd.TestSub = oTest;

            ReportGroup rpt = new ReportGroup();
            rpt.ReportGroupID = txtRptGrpID.Text.ToString();
            reshd.ReportGroup = rpt;

            ResultHeadGroup rshdgr = new ResultHeadGroup();
            rshdgr.ResultHeadGroupID = cboHeadGroupID.SelectedValue.ToString();
            reshd.ResultGroup = rshdgr;

            for (int i = 0; i < dgvAssociatedGrid.Rows.Count; i++)
            {
                string1 += dgvAssociatedGrid.Rows[i].Cells[1].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[3].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[5].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[6].Value +
                            ":" + dgvAssociatedGrid.Rows[i].Cells[7].Value +
                            ":" + ";";
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboTestDet", "cboSection", "cboRptGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }           
            try
            {
                ResultHead reshd = this.PopulateResHd();
                short i = dmsSC.SaveResultHeadMapping(reshd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAssociatedGrid.DataSource = null;
                    dgvAssociatedGrid.Rows.Clear();
                    this.btnShow_Click(sender, e);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            for (int i = 0; i < dgvInitialGrid.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvInitialGrid.Rows[i].Cells[0].Value) == true)
                {
                    if (dgvInitialGrid[0, i].Value != null)
                    {
                        mAdditem(dgvInitialGrid[1, i].Value.ToString(), dgvInitialGrid[2, i].Value.ToString(),
                                cboHeadGroupID.SelectedValue.ToString(), cboHeadGroupID.Text.ToString(),
                                cboTestDetRpt.SelectedValue.ToString(), cboTestDetRpt.Text.ToString());
                    }
                    dgvInitialGrid.Rows[i].Cells[0].Value = false;
                }
                dgvAssociatedGrid.AllowUserToAddRows = false;
            }    
        }
        private void mAdditem(string HeadID, string HeadTitle, string HeadGrpID, string HeadGrpTitle,string TestDetID,string TestDetTitle)
        {
            int selRaw;
            string strDown = "";
            string strGrp = "";
            Boolean blngCheck = false;
            for (int j = 0; j < dgvAssociatedGrid.RowCount; j++)
            {
                if (dgvAssociatedGrid[1, j].Value != null)
                {
                    strDown = dgvAssociatedGrid[1, j].Value.ToString();
                    strGrp = dgvAssociatedGrid[3, j].Value.ToString();
                }
                if (HeadID == strDown.ToString() && HeadGrpID == strGrp.ToString())
                {
                    blngCheck = true;
                }
            }
            if (blngCheck == false)
            {
                dgvAssociatedGrid.AllowUserToAddRows = true;
                selRaw = Convert.ToInt16(dgvAssociatedGrid.RowCount.ToString());
                selRaw = selRaw - 1;
                dgvAssociatedGrid.Rows.Add(1);
                for (int i = 1; i < dgvAssociatedGrid.Rows.Count; i++)
                {
                    dgvAssociatedGrid[1, selRaw].Value = HeadID.ToString();
                    dgvAssociatedGrid[2, selRaw].Value = HeadTitle.ToString();
                    dgvAssociatedGrid[3, selRaw].Value = HeadGrpID.ToString();
                    dgvAssociatedGrid[4, selRaw].Value = HeadGrpTitle.ToString();
                    dgvAssociatedGrid[7, selRaw].Value = TestDetID.ToString();
                    dgvAssociatedGrid[8, selRaw].Value = TestDetTitle.ToString(); 
                }

            }
        }
        private void dgvAssociatedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row > -1)
                {
                    if (dgvAssociatedGrid.Rows.Count > 0)
                    {
                        Pos = e.RowIndex;
                        if (dgvAssociatedGrid.Rows[row].Cells[3].Value.ToString() == "0")
                        {
                            cboHeadGroupID.Text = "--Select--";
                        }
                        if (dgvAssociatedGrid.Rows[row].Cells[3].Value.ToString() != "0")
                        {
                            cboHeadGroupID.SelectedValue = dgvAssociatedGrid.Rows[row].Cells[3].Value.ToString();
                        }
                        cboTestDetRpt.Text = dgvAssociatedGrid.Rows[row].Cells[8].Value.ToString();
                    }
                }

                if (dgvAssociatedGrid.Columns[e.ColumnIndex].Name == "btn")
                {
                    if (dgvAssociatedGrid.CurrentCell != null)
                    {
                        int selectedIndex = dgvAssociatedGrid.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DialogResult msg = MessageBox.Show("Do You want to Delete?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (msg == DialogResult.Yes)
                            {
                                dgvAssociatedGrid.Rows.RemoveAt(selectedIndex);
                                dgvAssociatedGrid.Refresh();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }

                if (dgvAssociatedGrid.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    if (dgvAssociatedGrid.CurrentCell != null)
                    {
                        DialogResult msg = MessageBox.Show("Do You want to Update?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (msg == DialogResult.Yes)
                        {
                            this.btnEdit_Click(sender, e);
                        }
                        else
                        {
                            return;
                        }
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
            List<string> vf = new List<string>() { "cboDeptID", "cboGroupID", "cboMainID", "cboTestDet", "cboSection", "cboRptGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvAssociatedGrid.Rows.Count == 0)
            {
                MessageBox.Show("No Result Head Associated with Test", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ResultHead reshd = this.PopulateResHdForUpdate();
                short i = dmsSC.UpdateResultHeadMapping(reshd);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAssociatedGrid.DataSource = null;
                    dgvAssociatedGrid.Rows.Clear();
                    this.btnShow_Click(sender, e);
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            dgvInitialGrid.Rows.Clear();
            dgvAssociatedGrid.Rows.Clear();
        }

        private void chkTestList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int rcont = 0; rcont < dgvInitialGrid.Rows.Count; rcont++)
                {
                    if (chkTestList.Checked == true)
                    {
                        Convert.ToBoolean(dgvInitialGrid.Rows[rcont].Cells["chk"].Value = true);
                    }
                    else
                    {
                        Convert.ToBoolean(dgvInitialGrid.Rows[rcont].Cells["chk"].Value = false);
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
        private void txtSearchTest_TextChanged(object sender, EventArgs e)
        {
            cboTestDet.SelectedIndex = cboTestDet.FindString(txtSearchTest.Text);
        }
        private void dgvAssociatedGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                double i;
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Enter Numeric Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        private void txtSearchResHead_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateDataToGrid(dgvInitialGrid, txtSearchResHead.Text);
            dgvInitialGrid.Refresh();       
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cboTestDetRpt.SelectedIndex = cboTestDetRpt.FindString(txtSearch.Text);
        }
        private void cboHeadGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAssociatedGrid.CurrentCell != null)
            {
                if (dgvAssociatedGrid.Rows.Count > 0)
                {
                    int k = dgvAssociatedGrid.CurrentCell.RowIndex;
                    dgvAssociatedGrid.Rows[k].Cells[3].Value = cboHeadGroupID.SelectedValue.ToString();
                    if (cboHeadGroupID.SelectedValue == "")
                    {
                        dgvAssociatedGrid.Rows[k].Cells[4].Value = "";
                    }
                    if (cboHeadGroupID.SelectedValue != "")
                    {
                        dgvAssociatedGrid.Rows[k].Cells[4].Value = cboHeadGroupID.Text.ToString();
                    }
                }
            }
        }

        private void cboTestDetRpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAssociatedGrid.CurrentCell != null)
            {
                if (dgvAssociatedGrid.Rows.Count > 0)
                {
                    int l = dgvAssociatedGrid.CurrentCell.RowIndex;
                    dgvAssociatedGrid.Rows[l].Cells[7].Value = cboTestDetRpt.SelectedValue.ToString();
                    dgvAssociatedGrid.Rows[l].Cells[8].Value = cboTestDetRpt.Text.ToString();
                }
            }
        }

    }
}
