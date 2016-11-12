using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DRSSR;
using AH.DUtility;
using AH.ModuleController.UI.DRS.Reports.Viewer;
using System.Collections;
 

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmMicroBiologyResultEntry : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();
        private string Department;
        private string ReportGroup;
        private string ReportSection;
        private string DepartmentID;
        private string ReportGroupID;
        private string ReportSectionID;
        private string mode;
        private string testDeailsID;
        private string varMrID;
        public frmMicroBiologyResultEntry(string Department, string reportSection, string ReportGroup, string deptID, string rptGroupID, string rptSectionID, string mode)
        {
            InitializeComponent();
            this.Department = Department;
            this.ReportGroup = ReportGroup;
            this.ReportSection = reportSection;
            this.DepartmentID = deptID;
            this.ReportGroupID = rptGroupID;
            this.ReportSectionID = rptSectionID;
            this.mode = mode;
        }


        private void FormatTestGrid()
        {
            lvSPCTests.CheckBoxes = false;
            lvSPCTests.Columns.Add("Test Name", 150, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Sample Collected For", 300, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Main", 150, HorizontalAlignment.Left);
            lvSPCTests.Columns.Add("testDetailsID",0, HorizontalAlignment.Left);
            lvSPCTests.Columns.Add("SpecimanCollID", 0, HorizontalAlignment.Left);

        }

        private void FormatGrid(DataGridView dtv)
        {
            //dtv.Columns.Clear();
            //dtv.Rows.Clear();
            dtv.ScrollBars = ScrollBars.Vertical;
            dtv.Width = 538;
            dtv.AutoGenerateColumns = false;
            DataGridViewCellStyle style =
            dtv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;        
            style.Font = new Font(dgvResultEntry.Font, FontStyle.Bold);

            dtv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtv.AllowUserToResizeRows = false;
            dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            DataGridViewTextBoxColumn dtvResultHdID = new DataGridViewTextBoxColumn();
            dtvResultHdID.Name = "Head Code";
            dtvResultHdID.DataPropertyName = "ResultHeadID";
            dtvResultHdID.Width = 0;
            dtvResultHdID.Visible = false;
            dtv.Columns.Add(dtvResultHdID);

            DataGridViewTextBoxColumn dtvResultHdGroup = new DataGridViewTextBoxColumn();
            dtvResultHdGroup.Name = "HeadGroup";
            dtvResultHdGroup.DataPropertyName = "ResultHeadGroupID";
            dtvResultHdGroup.Width = 0;
            dtvResultHdGroup.Visible = false;
            dtv.Columns.Add(dtvResultHdGroup);

            DataGridViewTextBoxColumn dtvResultHdTitle = new DataGridViewTextBoxColumn();
            dtvResultHdTitle.Name = "Antibiotics";
            dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
            dtvResultHdTitle.Width = 290;
            dtvResultHdTitle.ReadOnly = true;
            dtvResultHdTitle.Selected = false;
            dtv.Columns.Add(dtvResultHdTitle);

            DataGridViewTextBoxColumn colResultA = new DataGridViewTextBoxColumn();
            colResultA.ReadOnly = false;
            colResultA.Name = "A";
            colResultA.DataPropertyName = "ResultA";
            colResultA.Width = 75;
            colResultA.MaxInputLength = 1;
            dtv.Columns.Add(colResultA);

            DataGridViewTextBoxColumn colResultB = new DataGridViewTextBoxColumn();
            colResultB.ReadOnly = false;
            colResultB.Name = "B";
            colResultB.DataPropertyName = "ResultB";
            colResultB.Width = 75;
            colResultB.MaxInputLength = 1;
            dtv.Columns.Add(colResultB);

            DataGridViewTextBoxColumn colResultC = new DataGridViewTextBoxColumn();
            colResultC.ReadOnly = false;
            colResultC.Name = "C";
            colResultC.DataPropertyName = "ResultC";
            colResultC.Width = 75;
            colResultC.MaxInputLength = 1;
            dtv.Columns.Add(colResultC);

            //DataGridViewTextBoxColumn spc = new DataGridViewTextBoxColumn();
            //spc.Name = "Spceiman";
            //spc.DataPropertyName = "SpecimenID";
            //spc.Visible = false;
            //spc.Width = 0;
            //dtv.Columns.Add(spc);
            //dtv.AllowUserToResizeColumns = false;
            //dtv.Columns.Add(spc);        
        }
        private void FormatGridForLageView(DataGridView dtv)
        {
            //dtv.Columns.Clear();
            //dtv.Rows.Clear();
            dtv.ScrollBars = ScrollBars.Vertical;
            dtv.Width = 538;
            dtv.AutoGenerateColumns = false;
            DataGridViewCellStyle style =
            dtv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvResultEntry.Font, FontStyle.Bold);

            dtv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtv.AllowUserToResizeRows = false;
            dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv.DefaultCellStyle.SelectionBackColor = Color.LightGray;

      
            DataGridViewTextBoxColumn dtvResultHdTitle = new DataGridViewTextBoxColumn();
            dtvResultHdTitle.Name = "Antibiotics";
            dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
            dtvResultHdTitle.Width = 290;
            dtvResultHdTitle.ReadOnly = true;
            dtvResultHdTitle.Selected = false;
            dtv.Columns.Add(dtvResultHdTitle);

         
            DataGridViewTextBoxColumn colResultA = new DataGridViewTextBoxColumn();
            colResultA.ReadOnly = false;
            colResultA.Name = "A";
            colResultA.DataPropertyName = "ResultA";
            colResultA.Width = 75;
            colResultA.MaxInputLength = 1;
            dtv.Columns.Add(colResultA);

            DataGridViewTextBoxColumn colResultB = new DataGridViewTextBoxColumn();
            colResultB.ReadOnly = false;
            colResultB.Name = "B";
            colResultB.DataPropertyName = "ResultB";
            colResultB.Width = 75;
            colResultB.MaxInputLength = 1;
            dtv.Columns.Add(colResultB);

            DataGridViewTextBoxColumn colResultC = new DataGridViewTextBoxColumn();
            colResultC.ReadOnly = false;
            colResultC.Name = "C";
            colResultC.DataPropertyName = "ResultC";
            colResultC.Width = 75;
            colResultC.MaxInputLength = 1;
            dtv.Columns.Add(colResultC);

            DataGridViewTextBoxColumn dtvResultHdTitle1 = new DataGridViewTextBoxColumn();
            dtvResultHdTitle1.Name = "Antibiotics";
            dtvResultHdTitle1.DataPropertyName = "ResultHeadTitle1";
            dtvResultHdTitle1.Width = 290;
            dtvResultHdTitle1.ReadOnly = true;
            dtvResultHdTitle1.Selected = false;
            dtv.Columns.Add(dtvResultHdTitle1);


            DataGridViewTextBoxColumn colResultA1 = new DataGridViewTextBoxColumn();
            colResultA1.ReadOnly = false;
            colResultA1.Name = "A";
            colResultA1.DataPropertyName = "ResultA1";
            colResultA1.Width = 75;
            colResultA1.MaxInputLength = 1;
            dtv.Columns.Add(colResultA1);

            DataGridViewTextBoxColumn colResultB1 = new DataGridViewTextBoxColumn();
            colResultB1.ReadOnly = false;
            colResultB1.Name = "B";
            colResultB1.DataPropertyName = "ResultB1";
            colResultB1.Width = 75;
            colResultB1.MaxInputLength = 1;
            dtv.Columns.Add(colResultB1);

            DataGridViewTextBoxColumn colResultC1 = new DataGridViewTextBoxColumn();
            colResultC1.ReadOnly = false;
            colResultC1.Name = "C";
            colResultC1.DataPropertyName = "ResultC1";
            colResultC1.Width = 75;
            colResultC1.MaxInputLength = 1;
            dtv.Columns.Add(colResultC1);
        }

        private void PopulateDataToGrid()
        {
            dgvResultEntry.Rows.Clear();
            short index = 0;
            List<DiagnosticReport> oDiag = new List<DiagnosticReport>();
            if (mode == "V")
            {
                oDiag.Clear();
                oDiag.AddRange(drsClient.GetMicroBioResultToVerify(txtMoneyRecpNo.Text, ReportGroupID,testDeailsID).ToList());
                foreach (DiagnosticReport data in oDiag)
                {
                    string[] row = new string[] { data.head.ResultHeadID, data.head.ResultGroup.ResultHeadGroupID, data.head.ResultHeadTitle, data.ResultA, data.ResultB, data.ResultC };
                    AddRows(dgvResultEntry, row, index);
                    index++;
                }
            }
            if(mode == "F")
            {
                oDiag.Clear();
                oDiag.AddRange(drsClient.GetMicroBioResultToFinalised(txtMoneyRecpNo.Text, ReportGroupID, txtSpceiman.Text, testDeailsID).ToList());
                foreach (DiagnosticReport data in oDiag)
                {
                    string[] row = new string[] { data.head.ResultHeadID, data.head.ResultGroup.ResultHeadGroupID, data.head.ResultHeadTitle, data.ResultA, data.ResultB, data.ResultC };
                    AddRows(dgvResultEntry, row, index);
                    index++;
                }
            }
        }


        private void AddRows(DataGridView dtv, string[] row, short index)
        {
            dtv.Rows.Insert(index, row);
        }

        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        private void AddColumnsProgrammatically()
        {

            checkBoxColumn.HeaderText = "Intermediate";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvResultEntry.Columns.Insert(6, checkBoxColumn);

            checkBoxColumn.HeaderText = "Sensitive";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvResultEntry.Columns.Insert(7, checkBoxColumn);

            checkBoxColumn.HeaderText = "Resistant";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvResultEntry.Columns.Insert(8, checkBoxColumn);


        }

        private void frmDiagnosticResultEntry_Load(object sender, EventArgs e)
        {
            //chkNoGrowth.Checked = false;
            //lblDep.Text = Department;
            //lblRrpGrp.Text = ReportGroup;
            //lblReportSection.Text = ReportSection;
            //FormatTestGrid();
          
            //formatOPDListView();
            //loadOPDSpceimenList();
            //FormatGrid(dgvResultEntry);
            //dgvResultEntry.Columns[4].ReadOnly = true;        
            //dgvResultEntry.Columns[5].ReadOnly = true;
            //chkIntensity1.Enabled = false;
            //chkIntensity2.Enabled = false;
            //chkIntensity3.Enabled = false;
            //txtPower1.Enabled = false;
            //txtPower2.Enabled = false;
            //txtPower3.Enabled = false;
            
            //btnLargeView.Visible = false;
           

            //cboMachineName.DisplayMember = "Value";
            //cboMachineName.ValueMember = "Key";
            //cboMachineName.DataSource = new BindingSource(dmsSc.GetMacSetup("D"), null);
          
                chkNoGrowth.Checked = false;
                lblDep.Text = Department;
                lblRrpGrp.Text = ReportGroup;
                lblReportSection.Text = ReportSection;
                FormatGrid(dgvResultEntry);

                formatOPDListView();
                loadOPDSpceimenList();
                FormatTestGrid();

                dgvResultEntry.Columns[4].ReadOnly = true;
                dgvResultEntry.Columns[5].ReadOnly = true;
                chkIntensity1.Enabled = false;
                chkIntensity2.Enabled = false;
                chkIntensity3.Enabled = false;
                txtPower1.Enabled = false;
                txtPower2.Enabled = false;
                txtPower3.Enabled = false;

                btnLargeView.Visible = false;
                lvSPCTests.HideSelection = false;
                txtHours.Enabled = false;
                // chkGrowth.Checked = true;
                if (mode == "V")
                {
                    btnPreview.Visible = false;
                }
                if (mode == "F" || mode == "E")
                {
                    btnPreview.Visible = true;
                }
       
       
        }
       
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending List", 140, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {
            tvNursStnMoneyReceipt.Nodes.Clear();
            List<SpecimenCollection> OList = new List<SpecimenCollection>();
            if (mode == "E")
            {
                lstOPD.Items.Clear();
                OList = drsClient.MBioOPDPendingSpcmenLstForRslt(ReportGroupID, DepartmentID).ToList();
                foreach (SpecimenCollection spc in OList)
                {
                    ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                    itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                    lstOPD.Items.Add(itm);
                }

            }
            if (mode == "V")
            {
                frmLabel.Text = "Microbiology Result Verification";
                btnSave.Text = "Verify";
              //  lblText.Text = "Money Receipt No";
                List<DiagnosticMR> diags = new List<DiagnosticMR>();
                lstOPD.Items.Clear();
                diags = drsClient.GetMicroBioRprtLstToVerify(ReportSectionID, ReportGroupID).ToList();
                foreach (DiagnosticMR diag in diags)
                {
                    ListViewItem itm = new ListViewItem(diag.MRNo);
                    itm.SubItems.Add(diag.MRNo);
                    lstOPD.Items.Add(itm);
                }
              
            }

            if (mode == "F")
            {
                frmLabel.Text = "Microbiology Result Finalization";
                btnSave.Text = "Finalize";
              //  lblText.Text = "Money Receipt No";
                List<DiagnosticMR> diags = new List<DiagnosticMR>();
                lstOPD.Items.Clear();
                diags = drsClient.GetMicroBioRprtLstToFinalised(ReportSectionID, ReportGroupID).ToList();
                foreach (DiagnosticMR diag in diags)
                {
                    ListViewItem itm = new ListViewItem(diag.MRNo);
                    itm.SubItems.Add(diag.MRNo);
                    lstOPD.Items.Add(itm);
                }
            
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMoneyRecpNo"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (chkGrowth.Checked == false && chkNoGrowth.Checked == false)
            {
                MessageBox.Show("Click either Growth or NoGrowth", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtResultA.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Result A required", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResultA.Focus();
                return;
            }
            if (rdoBtnHours.Checked == false && rdoBtnDay.Checked == false && chkNoGrowth.Checked == true)
            {
                MessageBox.Show("Click either Hours or Day", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int flag = 0;
            if (chkGrowth.Checked == true)
            {
                for (int row = 0; row < dgvResultEntry.Rows.Count; row++)
                {
                    if (dgvResultEntry.Rows[row].Cells[3].Value != null && dgvResultEntry.Rows[row].Cells[3].Value.ToString().Trim() != "")
                    {
                        flag = 1;
                    }                   
                }
                if (flag == 0)
                {
                    MessageBox.Show("Cannot Insert Empty Value,Please Check!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                   
            }

                try
                {
                    if (mode == "E")
                    {
                        DiagnosticReport rshdobj = this.PopulateDiagResult();
                        string j = drsClient.SaveMicroBiologyResult(rshdobj);

                        if (j == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           // lvSPCTests.Clear();
                        }
                        else
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtMoneyRecpNo.Select();
                           // lvSPCTests.Clear();
                            loadOPDSpceimenList();
                            txtMoneyRecpNo.Text = varMrID;
                            LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                        }
                    }
                    if (mode == "V")
                    {
                        DiagnosticReport rshdobj = this.PopulateDiagResult();
                        string j = drsClient.SaveMicroBiologyVerifiedResult(rshdobj);

                        if (j == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lvSPCTests.Clear();
                        }
                        else
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtMoneyRecpNo.Select();
                            txtMoneyRecpNo.Text = varMrID;
                            LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                            loadOPDSpceimenList();
                        }

                    }
                    if (mode == "F")
                    {
                        DiagnosticReport rshdobj = this.PopulateDiagResult();
                        string j = drsClient.SaveMicroBiologyFinaldResult(rshdobj);

                        if (j == "0")
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lvSPCTests.Clear();
                        }
                        else
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtMoneyRecpNo.Select();
                            txtMoneyRecpNo.Text = varMrID;
                            LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                            loadOPDSpceimenList();
                            printResult(j);
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
        private void printResult(string resultId)
        {
            int count = drsClient.GetMicroBioResCnt(resultId);
            frmReportViewer vr = new frmReportViewer();
             if (count < 40)
             {               
                 vr.selector = ViewerSelector.multicolumn;
             }
           if(count>40)
             {   
             vr.selector = ViewerSelector.CultureAndSensiReport;
             }
            vr.TransactionNo = resultId;
            //vr.ReportTitle = "AH Health Card";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();
        }
        string results="";
        private DiagnosticReport PopulateDiagResult()
        {
            DiagnosticReport diag = new DiagnosticReport();

            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtSpceiman.Text;
            spcColl.Remarks = "r";
            diag.Comments = txtComments.Text;
            if (rdoBtnDay.Checked == true)
            { 
                diag.Tempareture = txtTemp.Text == "" && txtHours.Text == "" ? "" : txtTemp.Text + "+" + txtHours.Text+"+"+"1";
            }

            else if (rdoBtnHours.Checked == true)
            {
                diag.Tempareture = txtTemp.Text == "" && txtHours.Text == "" ? "" : txtTemp.Text + "+" + txtHours.Text+"+"+"0";
            }
            else
            {
                diag.Tempareture = txtTemp.Text == "" && txtHours.Text == "" ? "" : txtTemp.Text + "+" + txtHours.Text;
            }
            diag.SpecimenCollection = spcColl;

            ReportGroup rpt = new ReportGroup();
            rpt.ReportGroupID = ReportGroupID;

            ReportSection rptSec = new ReportSection();
            rptSec.ReportSectionID = ReportSectionID;
            rpt.ReportSection = rptSec;
            diag.ReportGroup = rpt;

            InPatient pat = new InPatient();
            pat.HCN = txtHCN.Text;
            pat.RegistrationNo = txtRegID.Text;
            diag.Patient = pat;

            DiagnosticMR dmr = new DiagnosticMR();
            dmr.MRNo = txtMrNo.Text;
            diag.DiagnosticMR = dmr;


            diag.TestDetailsID = testDeailsID;

            results = "";
            if (chkNoGrowth.Checked == true)
            {
                diag.GrowthResultsA = txtResultA.Text.Trim().Replace("\r\n", "\\r\\n")+"~" + txtPower1.Text;
                diag.GrowthResultsB = txtGrowthResultB.Text == "" ? "" : txtGrowthResultB.Text.Trim().Replace("\r\n", "\\r\\n");
                diag.GrowthResultsC = txtGrowthResultC.Text == "" ? "" : txtGrowthResultC.Text.Trim().Replace("\r\n", "\\r\\n");
                diag.IsGrowth = Convert.ToInt16("0");
                diag.Results = "0";

            }
            else
            {
                diag.GrowthResultsA = txtResultA.Text.Trim().Replace("\r\n", "\\r\\n") + "~" + txtPower1.Text;
                diag.GrowthResultsB = txtGrowthResultB.Text == "" ? "" : txtGrowthResultB.Text.Trim().Replace("\r\n", "\\r\\n") + "~" + txtPower2.Text;
                diag.GrowthResultsC = txtGrowthResultC.Text == "" ? "" : txtGrowthResultC.Text.Trim().Replace("\r\n", "\\r\\n") + "~" + txtPower3.Text;
                if (mode == "E")
                {
                    diag.IsGrowth = Convert.ToInt16("1");
                    for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
                    {
                        if (dgvResultEntry.Rows[i].Cells[3].Value != null ||
                            dgvResultEntry.Rows[i].Cells[4].Value !=null ||
                            dgvResultEntry.Rows[i].Cells[5].Value!=null)
                            {
                                if ((Convert.ToString( dgvResultEntry.Rows[i].Cells[3].Value).ToString().Trim()!="") ||
                                    (Convert.ToString( dgvResultEntry.Rows[i].Cells[4].Value).ToString().Trim()!="")||
                                    (Convert.ToString( dgvResultEntry.Rows[i].Cells[5].Value).ToString().Trim()!=""))                           
                                    {
                                        results = results + "000" + "$" +
                                               dgvResultEntry.Rows[i].Cells[0].Value.ToString() + "$" +
                                               dgvResultEntry.Rows[i].Cells[1].Value.ToString() + "$" +
                                               (dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString()) + "$" +
                                               (dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString()) + "$" +
                                               (dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString()) + ";";
                                    }
                            }

                    }
                    diag.DraftResultID = "0";
                }
                else
                {
                    diag.IsGrowth = Convert.ToInt16("1");
                    for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
                    {
                        if (dgvResultEntry.Rows[i].Cells[3].Value != null ||
                           dgvResultEntry.Rows[i].Cells[4].Value != null ||
                           dgvResultEntry.Rows[i].Cells[5].Value != null)
                        {
                            if ((Convert.ToString(dgvResultEntry.Rows[i].Cells[3].Value).ToString().Trim() != "") ||
                                (Convert.ToString(dgvResultEntry.Rows[i].Cells[4].Value).ToString().Trim() != "") ||
                                (Convert.ToString(dgvResultEntry.Rows[i].Cells[5].Value).ToString().Trim() != ""))
                            {
                                results = results + "000" + "$" +
                                        dgvResultEntry.Rows[i].Cells[0].Value.ToString() + "$" +
                                        dgvResultEntry.Rows[i].Cells[1].Value.ToString() + "$" +
                                        (dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString()) + "$" +
                                        (dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString()) + "$" +
                                        (dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString()) + ";";
                            }
                        }

                    }
                    diag.DraftResultID =txtDraftID.Text;
                }

                  diag.Results = results;
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diag.EntryParameter = ep;

            return diag;

        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "txtMoneyRecpNo" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                if (mode == "E")
                {

                    //if (drsClient.verifySpecimenNumbers(txtSpecimenNo.Text, DepartmentID, ReportGroupID) == "0")
                    //{
                    //    MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    txtSpecimenNo.Select();
                    //    txtSpecimenNo.Text = "";
                    //    btnNew.PerformClick();
                    //    return;
                    //}
                    SpecimenCollection spc = new SpecimenCollection();
                    spc = drsClient.GetSpecimenCollection(txtMoneyRecpNo.Text);
                    LoadDetails(spc);

                }
                // LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);  
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
        private void CheckTestDetails()
        {
            List<TestFee>  list=new  List<TestFee>();
            list = drsClient.GetEntryReportDetails(txtMoneyRecpNo.Text, ReportGroupID).ToList();
            for(int lst=0;lst<list.Count;lst++)
            {
                for(int i=0;i<lvSPCTests.Items.Count;i++)
                {
                    if(lvSPCTests.Columns[3].Text.ToString()==list[lst].TestSub.ToString ())
                    {
                        //lvSPCTests.Items[i].Tex
                    }
                }
            }
        }
        private void LoadDetailsByResultId(DiagnosticReport spc)
        {
            txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text =spc.Specimen.SpecimenID;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            txtComments.Text = spc.Comments;
            if (spc.IsGrowth == 0)
            {
                chkNoGrowth.Checked = true;
            }
            else
            {
                chkGrowth.Checked = true;
            }
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
          //  txtAdvice.Text = spc.Advice;

        }
        private void GetNoGrowthResultToVerify(DiagnosticReport diag)
        {
            txtComments.Text = "";
            txtTemp.Text = "";
            txtHours.Text = "";
            txtResultA.Text = "";
            if (diag.Comments != null && diag.Comments != string.Empty)
            {
                txtComments.Text = diag.Comments.Trim().Replace("\\r\\n", Environment.NewLine);
            }
            if (diag.GrowthResultsA != null && diag.GrowthResultsA!=string.Empty)
            {
                txtResultA.Text = Utility.GetStringPart(diag.GrowthResultsA.Replace("\\r\\n", Environment.NewLine), "~");
            }
            if (diag.Tempareture != null && diag.Tempareture!=string.Empty)
            {
                txtTemp.Text = Utility.GetStringPart(diag.Tempareture, "+");
                string var = Utility.GetStringPart(diag.Tempareture, "+", false);
                txtHours.Text = Utility.GetStringPart(var, "+");
                string var1 = Utility.GetStringPart(var, "+", true);
                if (var1 == "0")
                {
                    rdoBtnHours.Checked = true;
                }
                if(var1=="1")
                {
                    rdoBtnDay.Checked = true;
                }
            }
        }
        private void GetGrowthResult(List<DiagnosticReport> diags)
        {
            foreach (DiagnosticReport diag in diags)
            {
                if (diag.Comments != null && diag.Comments != string.Empty)
                {
                    txtComments.Text = diag.Comments.Replace("\\r\\n", Environment.NewLine);
                }
               // txtGrowthResultA.Text = diag.GrowthResultsA.Replace("\\r\\n", Environment.NewLine);
                txtResultA.Text = Utility.GetStringPart(diag.GrowthResultsA.Replace("\\r\\n", Environment.NewLine), "~");
                txtPower1.Text = Utility.GetStringPart(diag.GrowthResultsA, "~", true);
                if (txtPower1.Text.Length!=0)
                {
                    chkIntensity1.Checked = true;
                }
                if (diag.GrowthResultsB.Length != 0)
                {
                    txtGrowthResultB.Text = Utility.GetStringPart(diag.GrowthResultsB.Replace("\\r\\n", Environment.NewLine), "~");
                    txtPower2.Text = Utility.GetStringPart(diag.GrowthResultsB, "~", true);
                    if(txtPower2.Text.Length!=0)
                    {
                        chkIntensity2.Checked = true;
                    }
                }
                if (diag.GrowthResultsC.Length != 0)
                {
                    txtGrowthResultC.Text = Utility.GetStringPart(diag.GrowthResultsC.Replace("\\r\\n", Environment.NewLine), "~");
                    txtPower3.Text = Utility.GetStringPart(diag.GrowthResultsC, "~", true);
                    if (txtPower3.Text.Length != 0)
                    {
                        chkIntensity3.Checked = true;
                    }
                }
                txtDraftID.Text = diag.DraftResultID;
                txtSpcecimenID.Text = diag.SpecimenCollection.SpecimenCollectionID;
                if (diag.Tempareture!=null && diag.Tempareture!=string.Empty)
                {
                    //txtTemp.Text = Utility.GetStringPart(diag.Tempareture, "+");
                    //txtHours.Text = Utility.GetStringPart(diag.Tempareture, "+", true);
                    txtTemp.Text = Utility.GetStringPart(diag.Tempareture, "+");
                    string var = Utility.GetStringPart(diag.Tempareture, "+", false);
                    if (var.Length != 0)
                    {
                        txtHours.Text = Utility.GetStringPart(var, "+");
                        string var1 = Utility.GetStringPart(var, "+", true);
                        if (var1 == "0")
                        {
                            rdoBtnHours.Checked = true;
                        }
                        if (var1 == "1")
                        {
                            rdoBtnDay.Checked = true;
                        }
                    }
                }
             
            }
        }
        private void LoadTestsByMrID(string mrID, string ReportGroupID)
        {
            lvSPCTests.Items.Clear();
            if (mode == "E")
            {
                List<TestSub> tss = drsClient.GetReportTestDetails(txtMoneyRecpNo.Text, ReportGroupID).ToList();
                foreach (TestSub ts in tss)
                {
                    ListViewItem itm = new ListViewItem(ts.TestSubTitle);
                    itm.SubItems.Add(ts.TestSubTitleAlias);
                    itm.SubItems.Add(ts.TestMainTitle.ToString());
                    itm.SubItems.Add(ts.TestSubID.ToString());
                    itm.SubItems.Add(ts.Specimen.SpecimenID.ToString());
                    lvSPCTests.Items.Add(itm);
                }
            }
            if (mode == "V")
            {
                List<TestSub> tss = drsClient.GetTestNameForVerify(txtMoneyRecpNo.Text, ReportGroupID).ToList();
                foreach (TestSub ts in tss)
                {
                    ListViewItem itm = new ListViewItem(ts.TestSubTitleAlias);
                    itm.SubItems.Add(ts.TestSubTitle);
                    itm.SubItems.Add(ts.TestMainTitle.ToString());
                    itm.SubItems.Add(ts.TestSubID.ToString());
                    itm.SubItems.Add(ts.Specimen.SpecimenID.ToString());
                    lvSPCTests.Items.Add(itm);
                }
            }
            if (mode == "F")
            {
                List<TestSub> tss = drsClient.GetTestNameForFinalize(txtMoneyRecpNo.Text, ReportGroupID).ToList();
                foreach (TestSub ts in tss)
                {
                    ListViewItem itm = new ListViewItem(ts.TestSubTitleAlias);
                    itm.SubItems.Add(ts.TestSubTitle);
                    itm.SubItems.Add(ts.TestMainTitle.ToString());
                    itm.SubItems.Add(ts.TestSubID.ToString());
                    itm.SubItems.Add(ts.Specimen.SpecimenID.ToString());
                    lvSPCTests.Items.Add(itm);
                }
            }
        }
        private void PopulateDataToGrid(string SpecimenNo, string ReportGroupID,string testDetailsID)
        {
            List<ResultHead> list = new List<ResultHead>();
            list.AddRange(drsClient.GetResHeads(SpecimenNo, ReportGroupID, testDetailsID));
            if (list.Count > 0)
            {
                dgvResultEntry.DataSource = list.Select(data => new { data.ResultHeadID, data.ResultGroup.ResultHeadGroupID, data.ResultHeadTitle, data.RangeText }).ToList();
                dgvResultEntry.Rows[0].Cells[2].Selected = false;
                dgvResultEntry.Rows[0].Cells[3].Selected = true;
            }
           
        }
        private void LoadDetails(SpecimenCollection spc)
        {
            txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = txtMoneyRecpNo.Text;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
         //   txtSpceiman.Text = spc.DiagnosticMR.MRNo;

        }

        private void txtSpecimenNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMoneyRecpNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void emptyFields()
        {
            txtResultA.Text = string.Empty;
            chkIntensity1.Checked = false;
            txtPower1.Text = string.Empty;

            txtGrowthResultB.Text = string.Empty;
            chkIntensity2.Checked = false;
            txtPower2.Text = string.Empty;

            txtGrowthResultC.Text = string.Empty;
            chkIntensity3.Checked = false;
            txtPower3.Text = string.Empty;
            //txtMoneyRecpNo.Text = txtMoneyRecpNo.Text;
            //dgvResultEntry.Rows.Clear();         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {        
            txtMrNo.Text = varMrID;       
            dgvLargeView.Rows.Clear();
            lvSPCTests.Items.Clear();
            dgvResultEntry.DataSource = null;
            btnLargeView.Visible = false;
        }

        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
             
                //chkGrowth.Checked = false;
                //chkNoGrowth.Checked = false;
                //txtSpceiman.Text = "";
                //  btnNew.PerformClick();
                if (lstOPD.SelectedItems.Count > 0)
                {
                    varMrID = "";
                    txtTemp.Text = "";
                    txtHours.Text = "";
                    rdoBtnHours.Checked = false;
                    rdoBtnDay.Checked = false;
                    dgvResultEntry.DataSource = null;
                    btnLargeView.Visible = false;

                    ListViewItem itm = lstOPD.SelectedItems[0];
                    txtMoneyRecpNo.Text = itm.SubItems[0].Text;
                    varMrID = txtMoneyRecpNo.Text;
                    LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                }
                if (lvSPCTests.Items.Count > 0)
                {
                    lvSPCTests.Items[0].Selected = true;
                }
                //CheckTestDetails(); 
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
        private void txtSpecimenNo_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneyRecpNo.Text != "" && txtMoneyRecpNo.TextLength == 11)
            {
                btnPatientSearch.PerformClick();
            }
        }

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMoneyRecpNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
                LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
            }

        }

     
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtGrowthResult_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }
        }

        private void txtGrowthResultB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }

        }

        private void txtGrowthResultC_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }
        }

        private void smartTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }
        }

        private void txtComments_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.isEnterTabAllow = false;
            }
            else
            {
                this.isEnterTabAllow = true;
            }

        }

        private void chkNoGrowth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoGrowth.Checked == true)
            {
                txtGrowthResultB.Enabled = false;
                txtGrowthResultC.Enabled = false;         
                lblGrowth.Text = "No Growth";
                txtResultA.Text = "No Growth";
                chkGrowth.Checked = false;
                dgvResultEntry.Visible = false;
                chkIntensity1.Enabled = false;
                chkIntensity2.Enabled = false;
                chkIntensity3.Enabled = false;
                chkIntensity1.Checked = false;
                chkIntensity2.Checked = false;
                chkIntensity3.Checked = false;
                txtTemp.Text = "37";
                txtHours.Text = "72";
                txtHours.Enabled = false;
                rdoBtnHours.Checked = true;
            }
            else
            {
                //chkGrowth.Checked = true;
                //txtGrowthResultB.Enabled = true;
                //txtGrowthResultC.Enabled = true;
                //dgvResultEntry.Enabled = true;
                //lblGrowth.Text = "Growth Result A";
                txtTemp.Enabled = false;
                txtTemp.Text = "";
                txtHours.Text = "";
                rdoBtnHours.Checked = false;
                txtHours.Enabled = true;
            }
        }

        private void chkGrowth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrowth.Checked == true)
            {
                chkNoGrowth.Checked = false;
                txtGrowthResultB.Enabled = true;
                txtGrowthResultC.Enabled = true;           
                lblGrowth.Text = "Growth of (A) :";
                txtResultA.Text = "";
                dgvResultEntry.Visible = true;
                chkIntensity1.Enabled = true;
                chkIntensity2.Enabled = true;
                chkIntensity3.Enabled = true;
                txtTemp.Enabled = true;
                txtHours.Enabled = true;
                txtTemp.Text = "";
                txtHours.Text = "";
                rdoBtnHours.Checked = false;
             
            }
            else 
            {
                dgvResultEntry.Visible = false;
            }

        }

        private void dgvResultEntry_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (mode == "E")
            //{
            //    if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            //    {
            //        if (Convert.ToString(e.FormattedValue).ToUpper() != "S" && Convert.ToString(e.FormattedValue).ToUpper() != "I"
            //            && Convert.ToString(e.FormattedValue).ToUpper() != "R" && Convert.ToString(e.FormattedValue) != null )
            //        {
            //            e.Cancel = true;
            //            MessageBox.Show("Please Input S or R or I", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }

            //    }
            //}
           
        }

        private void dgvResultEntry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvResultEntry.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dgvResultEntry_KeyDown(object sender, KeyEventArgs e)
        {
            dgvResultEntry.Columns[2].Selected = false;

            int col = dgvResultEntry.CurrentCell.ColumnIndex;
            int row = dgvResultEntry.CurrentCell.RowIndex;

            if (col < dgvResultEntry.ColumnCount - 1)
            {
                col++;
            }
            else
            {
                col = 0;
                row++;
            }

            //if (row == dgvResultEntry.RowCount)
            //    dgvResultEntry.Rows.Add();

            //dgvResultEntry.CurrentCell = dgvResultEntry[col, row];
            //e.Handled = true;
        }

        private void dgvResultEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //int iRow = dgvResultEntry.CurrentCell.RowIndex;
            //if (e.KeyCode == Keys.Down)
            //{
            //    dgvResultEntry.Columns[2].Selected = false;
            //    dgvResultEntry.Columns[3].Selected = true;
            //    dgvResultEntry.Columns[4].Selected = true;
            //    dgvResultEntry.Columns[5].Selected = true;
            //    dgvResultEntry.Rows[iRow].Cells[3].Selected = true;
            //    if (iRow < dgvResultEntry.Rows.Count - 1)
            //    {
            //        dgvResultEntry.CurrentCell = dgvResultEntry[3, iRow + 0];
            //        iRow = iRow + 1;
            //    }
            //}

            //if (e.KeyCode == Keys.Enter)
            //{
            //    dgvResultEntry.Columns[2].Selected = false;
            //    dgvResultEntry.Columns[3].Selected = true;
            //    dgvResultEntry.Columns[4].Selected = false;
            //    dgvResultEntry.Columns[5].Selected = true;
            //    dgvResultEntry.Rows[iRow].Cells[3].Selected = true;
            //    if (iRow < dgvResultEntry.Rows.Count - 1)
            //    {
            //        dgvResultEntry.CurrentCell = dgvResultEntry[2, iRow + 1];
            //        iRow = iRow + 1;
            //    }
            //}

            //if (e.KeyCode == Keys.Up)
            //{
            //    int iUpRow = dgvResultEntry.CurrentCell.RowIndex;
            //    if (iUpRow != 0)
            //    {
            //        dgvResultEntry.Columns[2].Selected = false;
            //        dgvResultEntry.Columns[3].Selected = true;
            //        dgvResultEntry.Columns[4].Selected = true;
            //        dgvResultEntry.Columns[5].Selected = true;
            //        dgvResultEntry.Rows[iRow].Cells[3].Selected = true;
            //        dgvResultEntry.CurrentCell = dgvResultEntry[3, iRow - 0];
            //    }
            //}
        }

        private void txtGrowthResultB_TextChanged(object sender, EventArgs e)
        {            
            dgvResultEntry.Columns[4].ReadOnly = false;
         // dgvResultEntry.Columns[4].DefaultCellStyle.BackColor = Color.White;

        }

        private void txtGrowthResultC_TextChanged(object sender, EventArgs e)
        {
            dgvResultEntry.Columns[5].ReadOnly = false;
        }
        private void chkIntensity1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIntensity1.Checked==true)
            {
                txtPower1.Enabled = true;
                txtPower1.Select();
            }
            else
            {
                txtPower1.Enabled = false;
                txtPower1.BackColor = Color.LightGray;
            }
        }

        private void chkIntensity2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntensity2.Checked == true)
            {
                txtPower2.Enabled = true;
                txtPower2.Select();
            }
            else
            {
                txtPower2.Enabled = false;
                txtPower2.BackColor = Color.LightGray;
            }
        }

        private void chkIntensity3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntensity3.Checked == true)
            {
                txtPower3.Enabled = true;
                txtPower3.Select();
            }
            else
            {
                txtPower3.Enabled = false;
                txtPower3.BackColor = Color.LightGray;
            }
        }

        private void lvSPCTests_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (lvSPCTests.SelectedItems.Count > 0)
                {
                    dgvResultEntry.DataSource = null;
                    dgvResultEntry.Rows.Clear();
                    emptyFields();
                    testDeailsID = "";
                    ListViewItem itm = lvSPCTests.SelectedItems[0];
                    testDeailsID = itm.SubItems[3].Text;
                    if (mode == "E")
                    {
                        PopulateDataToGrid(txtMoneyRecpNo.Text, ReportGroupID, itm.SubItems[3].Text);
                    }
                    // chkGrowth.Checked = true;
                    txtSpceiman.Text = itm.SubItems[4].Text;
                    if (mode == "V")
                    {
                        //   btnNew.PerformClick();
                        DiagnosticReport spc = new DiagnosticReport();
                        spc = drsClient.GetSpecimenCollectionByResultID(txtMoneyRecpNo.Text, itm.SubItems[3].Text);
                        LoadDetailsByResultId(spc);

                        // LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                        if (chkNoGrowth.Checked == true)
                        {
                            DiagnosticReport diag = new DiagnosticReport();
                            diag = drsClient.GetNoGrowthResultToVerify(txtMoneyRecpNo.Text, ReportGroupID, testDeailsID);
                            GetNoGrowthResultToVerify(diag);
                        }
                        else
                        {
                            List<DiagnosticReport> diags = drsClient.GetMicroBioResultToVerify(txtMoneyRecpNo.Text, ReportGroupID, testDeailsID).ToList();
                            GetGrowthResult(diags);
                            PopulateDataToGrid();
                        }

                    }
                    if (mode == "F")
                    {
                        DiagnosticReport spc = new DiagnosticReport();
                        spc = drsClient.GetSpecimenCollectionByResultID(txtMoneyRecpNo.Text, itm.SubItems[3].Text);
                        LoadDetailsByResultId(spc);

                        //  LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
                        if (chkNoGrowth.Checked == true)
                        {
                            DiagnosticReport diag = new DiagnosticReport();
                            diag = drsClient.GetNoGrowthResultToFinal(txtMoneyRecpNo.Text, ReportGroupID, itm.SubItems[3].Text);
                            GetNoGrowthResultToVerify(diag);
                        }
                        else
                        {
                            List<DiagnosticReport> diags = drsClient.GetMicroBioResultToFinalised(txtMoneyRecpNo.Text, ReportGroupID, txtSpceiman.Text, itm.SubItems[3].Text).ToList();
                            GetGrowthResult(diags);
                            PopulateDataToGrid();
                        }
                    }

                }
                //lvSPCTests.HideSelection = false;
                if (dgvResultEntry.Rows.Count > 0)
                {
                    btnLargeView.Visible = true;
                    // chkGrowth.Checked = true;
                }
                else
                {
                    btnLargeView.Visible = false;
                    //chkGrowth.Checked = false;
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
         
        private void btnLargeView_Click(object sender, EventArgs e)     
        {
            try
            {
                if (dgvResultEntry.Rows.Count > 0)
                {
                    dgvLargeView.Columns.Clear();
                    FormatGridForLageView(dgvLargeView);

                    pnlDgvContainer.Top = panel8.Top + panel8.Height+75;
                    pnlDgvContainer.Left = (panel8.Left + panel8.Width / 2)-95;

                    dgvLargeView.Columns[0].Width = 220;
                    dgvLargeView.Columns[1].Width = 80;
                    dgvLargeView.Columns[2].Width = 80;
                    dgvLargeView.Columns[3].Width = 80;

                    dgvLargeView.Columns[4].Width =220;
                    dgvLargeView.Columns[5].Width = 80;
                    dgvLargeView.Columns[6].Width = 80;
                    dgvLargeView.Columns[7].Width = 80;
                    dgvLargeView.Height =625;
                    dgvLargeView.Width = 970;
                    pnlDgvContainer.Visible = true;
                    dgvLargeView.Visible = true;

                    pnlDgvContainer.Height = 630;
                    pnlDgvContainer.Width = 975;
                    txtComments.SendToBack();
                    int k = 0;
                    if (dgvResultEntry.Rows.Count % 2 == 0)
                    {
                        for (int i = 0; i < (dgvResultEntry.Rows.Count / 2); i++)
                        {
                            dgvLargeView.Rows.Add();
                        }

                        for (int i = 0; i < (dgvResultEntry.Rows.Count / 2); i++)
                        {
                            dgvLargeView.Rows[i].Cells[0].Value = dgvResultEntry.Rows[i].Cells[2].Value.ToString();
                            if (dgvLargeView.Rows[i].Cells[0].Value.ToString() == dgvResultEntry.Rows[i].Cells[2].Value.ToString())
                            {
                                dgvLargeView.Rows[i].Cells[1].Value = dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString().ToUpper();
                                dgvLargeView.Rows[i].Cells[2].Value = dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString().ToUpper();
                                dgvLargeView.Rows[i].Cells[3].Value = dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString().ToUpper();
                            }
                        }
                        for (int i = ((dgvResultEntry.Rows.Count) / 2); i < dgvResultEntry.Rows.Count; i++)
                        {
                            dgvLargeView.Rows[k].Cells[4].Value = dgvResultEntry.Rows[i].Cells[2].Value.ToString();
                            if (dgvLargeView.Rows[k].Cells[4].Value.ToString() == dgvResultEntry.Rows[i].Cells[2].Value.ToString())
                            {
                                dgvLargeView.Rows[k].Cells[5].Value = dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString().ToUpper();
                                dgvLargeView.Rows[k].Cells[6].Value = dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString().ToUpper();
                                dgvLargeView.Rows[k].Cells[7].Value = dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString().ToUpper();
                            }
                            k++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (dgvResultEntry.Rows.Count / 2) + 1; i++)
                        {
                            dgvLargeView.Rows.Add();
                        }
                        for (int i = 0; i <= (dgvResultEntry.Rows.Count / 2); i++)
                        {
                            dgvLargeView.Rows[i].Cells[0].Value = dgvResultEntry.Rows[i].Cells[2].Value.ToString();
                            if (dgvLargeView.Rows[i].Cells[0].Value.ToString() == dgvResultEntry.Rows[i].Cells[2].Value.ToString())
                            {
                                dgvLargeView.Rows[i].Cells[1].Value = dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString().ToUpper();
                                dgvLargeView.Rows[i].Cells[2].Value = dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString().ToUpper();
                                dgvLargeView.Rows[i].Cells[3].Value = dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString().ToUpper();
                            }
                        }
                        for (int i = ((dgvResultEntry.Rows.Count) / 2)+1; i < dgvResultEntry.Rows.Count; i++)
                        {
                            dgvLargeView.Rows[k].Cells[4].Value = dgvResultEntry.Rows[i].Cells[2].Value.ToString();
                            if (dgvLargeView.Rows[k].Cells[4].Value.ToString() == dgvResultEntry.Rows[i].Cells[2].Value.ToString())
                            {
                                dgvLargeView.Rows[k].Cells[5].Value = dgvResultEntry.Rows[i].Cells[3].Value == null ? " " : dgvResultEntry.Rows[i].Cells[3].Value.ToString().ToUpper();
                                dgvLargeView.Rows[k].Cells[6].Value = dgvResultEntry.Rows[i].Cells[4].Value == null ? " " : dgvResultEntry.Rows[i].Cells[4].Value.ToString().ToUpper();
                                dgvLargeView.Rows[k].Cells[7].Value = dgvResultEntry.Rows[i].Cells[5].Value == null ? " " : dgvResultEntry.Rows[i].Cells[5].Value.ToString().ToUpper();
                            }
                            k++;
                        }
                    }

                  
                    dgvResultEntry.Enabled = false;
                    dgvResultEntry.BackgroundColor = Color.DimGray;


                    DataGridViewCellStyle style = dgvLargeView.ColumnHeadersDefaultCellStyle;
                    style.BackColor = Color.LightGreen;
                    style.ForeColor = Color.Black;

                    btnClos.Top = pnlDgvContainer.Top-117 ;
                    btnClos.Left = (pnlDgvContainer.Left + 750);

                    dgvResultEntry.Rows[0].Cells[2].Selected = false;
                    dgvResultEntry.Rows[0].Cells[3].Selected = true;
                    lstOPD.Enabled = false;
                    lvSPCTests.Enabled = false;
                    btnLargeView.Enabled=false;
                    btnNew.Enabled = false;
                    btnSave.Enabled = false;

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

        private void btnClos_Click(object sender, EventArgs e)
        {
            lstOPD.Enabled = true;
            lvSPCTests.Enabled = true;
            btnLargeView.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = true;

            int k = dgvLargeView.Rows.Count;
            dgvResultEntry.Enabled = true;
            dgvResultEntry.BackgroundColor = Color.White;
            for (int i = 0; i < dgvLargeView.Rows.Count; i++)
            {
                if (dgvResultEntry.Rows[i].Cells[2].Value != null)
                {
                    if (dgvResultEntry.Rows[i].Cells[2].Value == dgvLargeView.Rows[i].Cells[0].Value)
                    {
                        dgvResultEntry.Rows[i].Cells[3].Value = dgvLargeView.Rows[i].Cells[1].Value == null ? " " : dgvLargeView.Rows[i].Cells[1].Value.ToString().ToUpper();

                        if (txtGrowthResultB.Text != string.Empty)
                        {
                            dgvResultEntry.Rows[i].Cells[4].Value = dgvLargeView.Rows[i].Cells[2].Value == null ? " " : dgvLargeView.Rows[i].Cells[2].Value.ToString().ToUpper();
                        }
                        if (txtGrowthResultC.Text != string.Empty)
                        {
                            dgvResultEntry.Rows[i].Cells[5].Value = dgvLargeView.Rows[i].Cells[3].Value == null ? " " : dgvLargeView.Rows[i].Cells[3].Value.ToString().ToUpper();
                        }
                    }
                }
            }

            for (int i = 0; i < dgvLargeView.Rows.Count; i++)
            {
                if(dgvLargeView.Rows[i].Cells[4].Value!=null){

                if (dgvResultEntry.Rows[k].Cells[2].Value.ToString() == dgvLargeView.Rows[i].Cells[4].Value.ToString() )
                {
                    dgvResultEntry.Rows[k].Cells[3].Value = dgvLargeView.Rows[i].Cells[5].Value == null ? " " : dgvLargeView.Rows[i].Cells[5].Value.ToString().ToUpper();

                    if (txtGrowthResultB.Text != string.Empty)
                    {
                        dgvResultEntry.Rows[k].Cells[4].Value = dgvLargeView.Rows[i].Cells[6].Value == null ? " " : dgvLargeView.Rows[i].Cells[6].Value.ToString().ToUpper();
                    }
                    if (txtGrowthResultC.Text != string.Empty)
                    {
                        dgvResultEntry.Rows[k].Cells[5].Value = dgvLargeView.Rows[i].Cells[7].Value == null ? " " : dgvLargeView.Rows[i].Cells[7].Value.ToString().ToUpper();
                    }
                }
            }
                k++;
            }
            pnlDgvContainer.Visible = false;      
            dgvLargeView.Columns.Clear();
 
        }

        private void dgvLargeView_KeyDown(object sender, KeyEventArgs e)
        {
            dgvLargeView.Columns[3].Selected = true;
            //dgvLargeView.Columns[2].Selected = false;

            int col = dgvLargeView.CurrentCell.ColumnIndex;
            int row = dgvLargeView.CurrentCell.RowIndex;

            if (col < dgvLargeView.ColumnCount - 1)
            {
                col++;
            }
            else
            {
                col = 0;
                row++;
            }

        }
        private void printWorkSheet(string moneyReceipt, string reportGrpID, string testDeailsID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.CultureAndSensitivityWorkSheet;
            vr.TransactionNo = moneyReceipt;
            vr.RptGroupID = reportGrpID;
            vr.TestDetailID = testDeailsID;
            vr.ViewReport();
        }
        private void btnWorkSheet_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMoneyRecpNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            printWorkSheet(txtMoneyRecpNo.Text, ReportGroupID, testDeailsID);
        }

        private void rdoBtnHours_CheckedChanged(object sender, EventArgs e)
        {
           if(rdoBtnHours.Checked==true)
           {
               txtHours.Enabled = true;
              // rdoBtnDay.Checked = false;
           }
           //else
           //{
           //    txtHours.Enabled = false;
           //}
        }

        private void rdoBtnDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnHours.Checked == true)
            {
                txtHours.Enabled = true;
               // rdoBtnHours.Checked = false;
            }
            //else
            //{
            //    txtHours.Enabled = false;
            //}
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (drsClient.verifyMrno(txtMoneyRecpNo.Text) == "0")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoneyRecpNo.Select();
                return;
            }

            if (mode == "F" || mode == "E")
            {
                if (chkGrowth.Checked == false && chkNoGrowth.Checked == false)
                {
                    MessageBox.Show("Click either Growth or NoGrowth", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtResultA.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Result A required", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtResultA.Focus();
                    return;
                }
                if (rdoBtnHours.Checked == false && rdoBtnDay.Checked == false && chkNoGrowth.Checked == true)
                {
                    MessageBox.Show("Click either Hours or Day", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int flag = 0;
                if (chkGrowth.Checked == true)
                {
                    for (int row = 0; row < dgvResultEntry.Rows.Count; row++)
                    {
                        if (dgvResultEntry.Rows[row].Cells[3].Value != null && dgvResultEntry.Rows[row].Cells[3].Value.ToString().Trim() != "")
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Cannot Insert Empty Value,Please Check!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                try
                {
                    DiagnosticReport rshdobj = this.PopulateDiagResult();
                    string j = drsClient.SaveMicroBiologyFinaldResultPrev(rshdobj);
                    printResultPreview("Pre-00001");
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
        private void printResultPreview(string resultId)
        {         
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.MicroBioReportPreview;   
            vr.TransactionNo = resultId;      
            vr.ViewReport();
        }

        private void tvEmergency_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEmergency.SelectedNode.Parent != null)
            {
                txtMoneyRecpNo.Text = tvEmergency.SelectedNode.Text.ToString();
                LoadTestsByMrID(txtMoneyRecpNo.Text, ReportGroupID);
            }
        }

        private void tvMoneyReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvNursStnMoneyReceipt.Nodes.Clear();
            tvEmergency.Nodes.Clear();

            if (mode == "E")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioIPDNursStationWiseSpecimenNoForResult(ReportGroupID, DepartmentID,"I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioIPDNursStationWiseSpecimenNoForResult(ReportGroupID, DepartmentID,"E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
            }
            if (mode == "V")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioNSTNMrForVerified(ReportGroupID, ReportSectionID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioNSTNMrForVerified(ReportGroupID, ReportSectionID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
            }

            if (mode == "F")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioNSTNMrForFinalised(ReportGroupID, ReportSectionID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.MBioNSTNMrForFinalised(ReportGroupID, ReportSectionID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
            }
        }
    }
}

