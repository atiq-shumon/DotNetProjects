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
 

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmDiagnosticResultVerification : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();
        List<DiagnosticReport> list = new List<DiagnosticReport>();
        List<DiagnosticReport> resultToVerify = new List<DiagnosticReport>();
        List<ResultHead> heads = new List<ResultHead>();
        private string topTitle;
        private string mrID = "";    
        private string Department;
        private string ReportGroup;
        private string ReportSection;
        private string DepartmentID;
        private string ReportGroupID;
        private string ReportSectionID;
        private string mode;
        public frmDiagnosticResultVerification(string mrID, string saveBtnText, string Department, string ReportGroup, string reportSection,string deptID,string rptGroupID,string rptSectionID,string mode)
        {
            InitializeComponent();
           
                if (mode == "V")
                {
                    topTitle = "Diagnostic Result Verification";
                }
                if (mode == "F")
                {
                    topTitle = "Diagnostic Result Finalization";
                }
                    
                this.Department = Department;
                this.ReportGroup = ReportGroup;
                this.ReportSection = reportSection;
                frmLabel.Text = topTitle;
                btnSave.Text = saveBtnText;             
                this.DepartmentID=deptID;
                this.ReportGroupID=rptGroupID;
                this.ReportSectionID = rptSectionID;
                this.mode = mode;
        }

   
        private void FormatTestGrid()
        {
            lvSPCTests.CheckBoxes = false;
            lvSPCTests.Columns.Add("Sample Collected For", 250, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Test Name", 200, HorizontalAlignment.Left);           
            lvSPCTests.Columns.Add("Main", 160, HorizontalAlignment.Left);
            lvSPCTests.Columns.Add("testDetailsID", 0, HorizontalAlignment.Left);
        }

        private void CreateColumnProgrammatically(DataGridView dtv)
        {
                dtv.DataSource = null;
                dtv.Rows.Clear();
                dtv.Columns.Clear();
       
                dtv.AutoGenerateColumns = false;
                dtv.RowHeadersVisible = false;
            
                dtv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dtv.AllowUserToResizeRows = false;
                dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtv.AllowUserToAddRows = false;
                dtv.AllowUserToDeleteRows = false; 

                DataGridViewCellStyle style =
                dtv.ColumnHeadersDefaultCellStyle;
                style.BackColor = Color.LightGreen;
                style.ForeColor = Color.Black;
                style.Font = new Font(dtv.Font, FontStyle.Bold);
             

                DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
                colDate.ReadOnly = false;
                colDate.Name = "Date";
                colDate.DataPropertyName = "Date";
                colDate.Width = 100;
                colDate.Selected = false;
                colDate.ReadOnly = true;
                dtv.Columns.Add(colDate);

                DataGridViewTextBoxColumn testDetailsID = new DataGridViewTextBoxColumn();
                testDetailsID.Name = "testDetailsID";
                testDetailsID.DataPropertyName = "TestSubID";
                testDetailsID.Width =0;
                testDetailsID.Selected = false;
                testDetailsID.Visible = false;
                dtv.Columns.Add(testDetailsID);

                DataGridViewTextBoxColumn dtvTestDetailsTitle = new DataGridViewTextBoxColumn();
                dtvTestDetailsTitle.Name = "Test Name";
                dtvTestDetailsTitle.DataPropertyName = "TestSubTitle";
                dtvTestDetailsTitle.Width =190;
                dtvTestDetailsTitle.Selected = false;
                dtvTestDetailsTitle.Visible = true;
                dtvTestDetailsTitle.ReadOnly = true;              
                dtv.Columns.Add(dtvTestDetailsTitle);

                DataGridViewTextBoxColumn dtvResultHdID = new DataGridViewTextBoxColumn();
                dtvResultHdID.Name = "Head Code";
                dtvResultHdID.DataPropertyName = "ResultHeadID";
                dtvResultHdID.Width = 0;
                dtvResultHdID.Selected = false;
                dtvResultHdID.Visible = false;
                dtv.Columns.Add(dtvResultHdID);

                DataGridViewTextBoxColumn dtvResultHdGroup = new DataGridViewTextBoxColumn();
                dtvResultHdGroup.Name = "HeadGroup";
                dtvResultHdGroup.DataPropertyName = "ResultHeadGroupID";
                dtvResultHdGroup.Selected = false;
                dtvResultHdGroup.Width = 0;
                dtvResultHdGroup.Visible = false;
                dtv.Columns.Add(dtvResultHdGroup);

                DataGridViewTextBoxColumn dtvResultHdTitle = new DataGridViewTextBoxColumn();
                dtvResultHdTitle.Name = "HeadTitle";
                dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
                dtvResultHdTitle.Width = 200;
                dtvResultHdTitle.DefaultCellStyle.ForeColor = Color.DarkBlue;
                dtvResultHdTitle.Selected = false;
                dtvResultHdTitle.ReadOnly = true;
                dtv.Columns.Add(dtvResultHdTitle);

                DataGridViewTextBoxColumn colResult = new DataGridViewTextBoxColumn();
                colResult.ReadOnly = false;
                colResult.Name = "Result";
                colResult.DataPropertyName = "ResultValue";
                colResult.Width = 115;
                colResult.DefaultCellStyle.ForeColor = Color.Red;
                colResult.Selected = false;
                colResult.ReadOnly = false;
                dtv.Columns.Add(colResult);

                DataGridViewTextBoxColumn colMachine = new DataGridViewTextBoxColumn();
                colMachine.ReadOnly = false;
                colMachine.Selected = false;
                colMachine.Name = "Machine";
                colMachine.DataPropertyName = "Machine";
                colMachine.Width = 72;
                colMachine.ReadOnly = true;
                dtv.Columns.Add(colMachine);

                DataGridViewTextBoxColumn colSpec = new DataGridViewTextBoxColumn();
                colSpec.Name = "SpeceimenID";
                colSpec.DataPropertyName = "SpeceimenID";
                colSpec.Width =0;
                colSpec.Selected = false;
                colSpec.Visible = false;
                dtv.Columns.Add(colSpec);

                DataGridViewTextBoxColumn colDraftResult = new DataGridViewTextBoxColumn();
                colDraftResult.Name = "DraftResult";
                colDraftResult.DataPropertyName = "DraftResult";
                colDraftResult.Width = 0;
                colDraftResult.Selected = false;
                colDraftResult.Visible = false;
                dtv.Columns.Add(colDraftResult);

                DataGridViewTextBoxColumn colmachineID = new DataGridViewTextBoxColumn();
                colmachineID.Name = "machineID";
                colmachineID.DataPropertyName = "machineID";
                colmachineID.Width = 0;
                colmachineID.Selected = false;
                colmachineID.Visible = false;
                dtv.Columns.Add(colmachineID);       
                dtv.AllowUserToResizeColumns = false;

                        
        }
        private void PopulateDataToGrid()
        {
            int index = 0;   
            list.Clear();
            list.AddRange(drsClient.GetResultToVerify(txtMrID.Text, ReportGroupID).ToList());
            foreach (DiagnosticReport data in list)
            {             
                string[] row = new string[] { data.head.EntryParameter.EntryDate.ToString(),data.head.TestSub.TestSubID,data.head.TestSub.TestSubTitle,data.head.ResultHeadID, data.head.ResultGroup.ResultHeadGroupID, data.head.ResultHeadTitle, data.head.ResultValue, data.head.Machine.MachineTitle, data.SpecimenCollection.SpecimenCollectionID, data.DraftResultID, data.head.Machine.MachineID };
                AddRowsToCollection(dgvResultEntry, row,index);
                ColurTheGrid(data.DraftResultID);
                index++;
            }               
        }
        private void PopulateLatestDataToGrid(string var)
        {
            resultToVerify.Clear();
            if (var == "V")
            {
               resultToVerify.Clear();
               resultToVerify.AddRange(drsClient.GetLatestResultToVerify(txtMrID.Text, ReportGroupID).ToList());
               // resultToVerify.AddRange(drsClient.GetResultToVerify(txtSpecimenNo.Text, ReportGroupID).ToList());

                if (resultToVerify.Count > 0)
                {
                    int index = 0;
                    foreach (DiagnosticReport data in resultToVerify)
                    {
                        string[] row = new string[] { data.head.EntryParameter.EntryDate.ToString(),data.head.TestSub.TestSubID,data.head.TestSub.TestSubTitle,data.head.ResultHeadID, data.head.ResultGroup.ResultHeadGroupID, data.head.ResultHeadTitle, data.head.ResultValue, data.head.Machine.MachineTitle, data.SpecimenCollection.SpecimenCollectionID, data.DraftResultID, data.head.Machine.MachineID };
                        AddRowsToCollection(dgvLatestResult, row,index);
                        index++;
                    }
                }
                //for (int i = 0; i < dgvLatestResult.Rows.Count; i++)
                //{
                //    if (dgvLatestResult.Rows[i].Cells[6].Value.ToString() == "" || dgvLatestResult.Rows[i].Cells[6].Value == null)
                //    {
                //        dgvLatestResult.Rows[i].ReadOnly = true;
                //        dgvLatestResult.Rows[i].DefaultCellStyle.BackColor = Color.Bisque;
                //    }

                //}
            }
            if(var=="F")
            {
                resultToVerify.Clear();
                resultToVerify.AddRange(drsClient.GetResultToFinalised(txtMrID.Text, ReportGroupID).ToList());
                if (resultToVerify.Count > 0)
                {
                    short index = 0;
                    foreach (DiagnosticReport data in resultToVerify)
                    {
                        string[] row = new string[] { data.head.EntryParameter.EntryDate.ToString(), data.head.TestSub.TestSubID, data.head.TestSub.TestSubTitle, data.head.ResultHeadID, data.head.ResultGroup.ResultHeadGroupID, data.head.ResultHeadTitle, data.head.ResultValue, data.head.Machine.MachineTitle, data.SpecimenCollection.SpecimenCollectionID, data.DraftResultID, data.head.Machine.MachineID };
                        AddRows(dgvLatestResult, row, index);
                        index++;
                        //txtAdvice.Text = data.Advice;
                        //txtCommnets.Text = data.Comments;
                        if (data.Comments != null && data.Comments != string.Empty)
                        {
                            txtCommnets.Text = data.Comments.Replace("\\r\\n", Environment.NewLine);
                        }
                        if (data.Advice != null && data.Advice != string.Empty)
                        {
                            txtAdvice.Text = data.Advice.Replace("\\r\\n", Environment.NewLine);
                        }
                    }
                }
               
            }
          
        }
        private void ColurTheGrid(string resultID)
        {
            for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            {
                dgvResultEntry.Rows[i].ReadOnly = true;
                dgvResultEntry.Rows[0].Selected = false;
                if (dgvResultEntry.Rows[i].Cells[9].Value.ToString() == resultID)
                    dgvResultEntry.Rows[i].DefaultCellStyle.BackColor = Color.Ivory;
                else
                    dgvResultEntry.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }
        //private void MakeReadOnly()
        //{
        //    for (int i = 0; i < dgvResultEntry.Rows.Count;i++ )
        //    {
        //        dgvResultEntry.Rows[i].ReadOnly = true;              
        //    }
        //}
        private void AddRowsToCollection(DataGridView dtv, string[] row,int index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void AddRows(DataGridView dtv, string[] row,short index)
        {
            dtv.Rows.Insert(index, row);
        }
        private void dtv_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int iRow = dgvLatestResult.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Down)
            {
                dgvLatestResult.Columns[0].Selected = false;
                dgvLatestResult.Columns[5].Selected = false;
                dgvLatestResult.Columns[4].Selected = true;
                dgvLatestResult.Columns[7].Selected = false;
                dgvLatestResult.Rows[iRow].Cells[6].Selected = true;
                if (iRow < dgvLatestResult.Rows.Count - 1)
                {
                    dgvLatestResult.CurrentCell = dgvLatestResult[5, iRow + 0];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                dgvLatestResult.Columns[0].Selected = false;
                dgvLatestResult.Columns[5].Selected = false;
                dgvLatestResult.Columns[6].Selected = true;
                dgvLatestResult.Columns[7].Selected = false;
                dgvLatestResult.Rows[iRow].Cells[6].Selected = true;
                if (iRow < dgvLatestResult.Rows.Count - 1)
                {
                    dgvLatestResult.CurrentCell = dgvLatestResult[4, iRow + 1];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                int iUpRow = dgvLatestResult.CurrentCell.RowIndex;
                if (iUpRow != 0)
                {
                    dgvLatestResult.Columns[0].Selected = false;
                    dgvLatestResult.Columns[5].Selected = false;
                    dgvLatestResult.Columns[6].Selected = true;
                    dgvLatestResult.Columns[7].Selected = false;
                    dgvLatestResult.Rows[iRow].Cells[6].Selected = true;
                    dgvLatestResult.CurrentCell = dgvLatestResult[5, iRow - 0];
                }
            }
       
        }  
        private void frmDiagnosticResultEntry_Load(object sender, EventArgs e)
        {
          
                dgvLatestResult.Visible = true;
                dgvResultView.Visible = false;
                lblDep.Text = Department;
                lblRrpGrp.Text = ReportGroup;
                lblReportSection.Text = ReportSection;
      
                if (mode == "V")
                {
                    string j = drsClient.SaveDiagnosResultFromMachin(DepartmentID, ReportSectionID, ReportGroupID, Utility.CompanyID, Utility.LocationID, Utility.MachineID);
                    //List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStnWiseMrForFinalised(ReportGroupID, ReportSectionID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    //Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                    lstOPD.Items.Clear();
                    List<SpecimenCollection> list = drsClient.GetOPDDMRToVerify(ReportSectionID, ReportGroupID).ToList();
                    loadOPDMoneyReceiptList(list);
                    btnRptPreview.Visible = false;
                }
                if (mode == "F")
                {
                    lstOPD.Items.Clear();
                    List<SpecimenCollection> list = drsClient.GetOPDDMRToFinalised(ReportSectionID, ReportGroupID).ToList();
                    loadOPDMoneyReceiptList(list);

                    //List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStnWiseMrForFinalised(ReportGroupID, ReportSectionID,"E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    //Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);

                    btnRecentResult.Text = "Result to be Finalized";
                    btnVerifiedResult.Text = "Previous Finalized Result";
                    btnRptPreview.Visible = true;
                }
                FormatTestGrid();

                formatOPDListView();
                txtMrID.Focus();
        

        }

    
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending List", 150, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {
            lstOPD.Items.Clear();
            List<SpecimenCollection> list = drsClient.OPDPendingSpecimenListForResult(ReportGroupID, DepartmentID).ToList();
            foreach (SpecimenCollection spc in list)
            {
                ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                lstOPD.Items.Add(itm);
            }
        }
        private void loadOPDMoneyReceiptList(List<SpecimenCollection> list)
        {           
            foreach (SpecimenCollection spc in list)
            {
                ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                lstOPD.Items.Add(itm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMrID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (dgvLatestResult.Rows.Count > 0)
            {
                for (int i = 0; i < dgvLatestResult.Rows.Count; i++)
                {
                    if (dgvLatestResult.Rows[i].Cells[6].Value == null || dgvLatestResult.Rows[i].Cells[6].Value.ToString().Trim() == string.Empty)
                    {
                        MessageBox.Show("Cannot Insert Null Value,Please Check!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot Insert Null Value,Please Check!");
                return;
            }

            try
            {
                if (resultToVerify.Count > 0)
                {
                    if (mode == "V")
                    {
                        DiagnosticReport rshdobj = this.PopulateDiagResult();
                        string j = drsClient.SaveVerifiedDiagnosticResult(rshdobj);
                        if (j == "0")
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Result Verify Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtMrID.Select();
                            btnRefresh.PerformClick();
                            lvSPCTests.Clear();
                        }
                    }
                    if (mode == "F")
                    {
                        DiagnosticReport rshdobj = this.EditDiagResult();
                        string j = drsClient.SaveFinalDiagnosticResult(rshdobj);
                        if (j == "0")
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Result Finalize Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtMrID.Select();
                            btnRefresh.PerformClick();
                            lvSPCTests.Clear();
                            //  btnRefresh.PerformClick();
                            printResult(j);
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
     
        private void printResult(string resultId)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.InvestigationReport;
            vr.TransactionNo = resultId;         
            vr.ViewReport();  
        }
        string results="";
        private DiagnosticReport PopulateDiagResult()
        {
            DiagnosticReport diag = new DiagnosticReport();
            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtMrID.Text;
            diag.SpecimenCollection = spcColl;

            diag.Advice = txtAdvice.Text.Trim().Replace("\r\n", "\\r\\n");
            diag.Comments = txtCommnets.Text.Trim().Replace("\r\n", "\\r\\n");

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
            results = "";
            for (int i = 0; i < dgvLatestResult.Rows.Count; i++)
            {
                if (dgvLatestResult.Rows[i].Cells[6].Value != null && dgvLatestResult.Rows[i].Cells[6].Value.ToString().Trim() != string.Empty)
                {
                   
                    results =results+dgvLatestResult.Rows[i].Cells[10].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[4].Value.ToString() + "$" +
                             dgvLatestResult.Rows[i].Cells[3].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[6].Value.ToString() + "$" +
                             dgvLatestResult.Rows[i].Cells[8].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[9].Value.ToString() + "$" +
                             dgvLatestResult.Rows[i].Cells[1].Value.ToString()+ ";";
                }

            }

            diag.Results = results;//heads.ToArray(); ;
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
                dgvResultView.DataSource = null;
                dgvResultView.Rows.Clear();
                dgvResultView.Columns.Clear();

                if (drsClient.verifyMrno(txtMrID.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMrID.Select();
                    return;
                }

                SpecimenCollection spc = new SpecimenCollection();
                spc = drsClient.GetSpecimenCollection(txtMrID.Text);
                LoadDetails(spc);
                LoadTestsByMrID(txtMrID.Text, ReportGroupID);

                CreateColumnProgrammatically(dgvResultEntry);
                CreateColumnProgrammatically(dgvLatestResult);

                if (mode == "V")
                {

                    PopulateDataToGrid();
                    PopulateLatestDataToGrid("V");
                    // dgvResultEntry.ClearSelection();
                    // .ClearSelection();

                }
                if (mode == "F")
                {
                    PopulateDataToGrid();
                    PopulateLatestDataToGrid("F");
                    dgvResultEntry.ClearSelection();
                    dgvLatestResult.ClearSelection();

                }

                //dgvResultEntry.Rows[0].Cells[0].Selected = false;            
                //dgvLatestResult.Rows[0].Cells[0].Selected = false;
                // dgvLatestResult.Rows[0].Cells[6].Selected = true;
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
        private void LoadDetails(SpecimenCollection spc)
        {
            txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = txtMrID.Text;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;

            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
          //  txtMoneyReceipt.Text = spc.DiagnosticMR.MRNo;

        }
        private void LoadDetailsByResultId(DiagnosticReport spc)
        {
            txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            if (spc.Comments != null && spc.Comments != string.Empty)
            {
                txtCommnets.Text = spc.Comments.Replace("\\r\\n", Environment.NewLine);
            }
            if (spc.Advice != null && spc.Advice != string.Empty)
            {
                txtAdvice.Text = spc.Advice.Replace("\\r\\n", Environment.NewLine);
            }
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       

        }
        private void LoadTestsByMrID(string mrID, string ReportGroupID)
        {
            lvSPCTests.Items.Clear();
            List<TestSub> tss = drsClient.GetTestByMRID(txtMrID.Text, ReportGroupID).ToList();
            foreach (TestSub ts in tss)
            {
                ListViewItem itm = new ListViewItem(ts.TestSubTitleAlias);
                itm.SubItems.Add(ts.TestSubTitle);
                itm.SubItems.Add(ts.TestMainTitle.ToString());
                itm.SubItems.Add(ts.TestSubID.ToString());
                lvSPCTests.Items.Add(itm);
            }

        } 
   
        private DiagnosticReport EditDiagResult()
         {
            DiagnosticReport diag = new DiagnosticReport();
            diag.Advice = txtAdvice.Text.Trim().Replace("\r\n", "\\r\\n");
            diag.Comments = txtCommnets.Text.Trim().Replace("\r\n", "\\r\\n");

            InPatient pat = new InPatient();
            pat.HCN = txtHCN.Text;
            pat.RegistrationNo = txtRegID.Text;
            diag.Patient = pat;

            ReportGroup rpt = new ReportGroup();
            rpt.ReportGroupID = ReportGroupID;

            ReportSection reptSec = new ReportSection();
            reptSec.ReportSectionID = ReportSectionID;
            rpt.ReportSection = reptSec;
            diag.ReportGroup = rpt;

            DiagnosticMR dmr = new DiagnosticMR();
            dmr.MRNo = txtMrID.Text;
            diag.DiagnosticMR = dmr;

            results = "";
            List<ResultHead> heads = new List<ResultHead>();
            
            for (int i = 0; i < dgvLatestResult.Rows.Count; i++)
            {
                if (dgvLatestResult.Rows[i].Cells[6].Value != null && dgvLatestResult.Rows[i].Cells[6].Value.ToString().Trim() != string.Empty)
                {
                   
                    results = results+dgvLatestResult.Rows[i].Cells[10].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[4].Value.ToString() + "$" +
                              dgvLatestResult.Rows[i].Cells[3].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[6].Value.ToString() + "$" + 
                              dgvLatestResult.Rows[i].Cells[8].Value.ToString() + "$" + dgvLatestResult.Rows[i].Cells[9].Value.ToString() +
                              "$" + dgvLatestResult.Rows[i].Cells[1].Value.ToString() + ";";

                }

            }          
       
            diag.Results = results;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diag.EntryParameter = ep;

            return diag;

        }
      
        private void txtSpecimenNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMrID.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void dgvLatestResult_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvLatestResult.IsCurrentCellDirty)
            {
                dgvLatestResult.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {         
            //txtSpecimenNo.Text = "";
            //txtPatientName.Text = "";
            //txtSpecimenName.Text = "";
            //txtMrNo.Text = "";

           // lvSPCTests.Clear();
            dgvResultEntry.DataSource = null;
            dgvResultEntry.Rows.Clear();
            dgvResultEntry.Columns.Clear();

            dgvLatestResult.DataSource = null;
            dgvLatestResult.Rows.Clear();
            dgvLatestResult.Columns.Clear();

            dgvResultView.DataSource = null;
            dgvResultView.Rows.Clear();
            dgvResultView.Columns.Clear();

            lvSPCTests.Items.Clear();

            txtMrID.Select();

        }
        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOPD.SelectedItems.Count > 0)
            {
                btnNew.PerformClick();
                ListViewItem itm = lstOPD.SelectedItems[0];
                txtMrID.Text = itm.SubItems[0].Text;                
            }
            
        }
        private void txtSpecimenNo_TextChanged(object sender, EventArgs e)
        {
            if (txtMrID.Text == "")
            {
               
                dgvResultHeads.DataSource = null;
              
            }
            if (txtMrID.Text != "" && txtMrID.TextLength == 11)
            {
                btnPatientSearch.PerformClick();
            }
           
        }

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMrID.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            }
        }
 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (mode == "V")
            {
                lstOPD.Items.Clear();

                List<SpecimenCollection> list = drsClient.GetReportListToVerify(ReportSectionID, ReportGroupID).ToList();
                List<AH.DUtility.NursingTree> ipdSpc = new List<DUtility.NursingTree>();
                ipdSpc.Clear();

                tvNursStnMoneyReceipt.Nodes.Clear();
                btnNew.PerformClick();
                this.tvMoneyReceipt_SelectedIndexChanged(sender, e);
                loadOPDMoneyReceiptList(list);
            }
            if (mode == "F")
            {
                lstOPD.Items.Clear();
                List<SpecimenCollection> list = drsClient.GetReportListToFinalised(ReportSectionID, ReportGroupID).ToList();
                loadOPDMoneyReceiptList(list);

                List<AH.DUtility.NursingTree> ipdSpc = new List<DUtility.NursingTree>();
                ipdSpc.Clear();
 
                btnNew.PerformClick();
                this.tvMoneyReceipt_SelectedIndexChanged(sender, e);
            }
        }

        private void dgvLatestResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                dgvLatestResult.Columns[0].Selected = false;
                dgvLatestResult.Columns[1].Selected = false;
                dgvLatestResult.Columns[2].Selected = false;
                dgvLatestResult.Columns[3].Selected = false;
                dgvLatestResult.Columns[6].Selected = true;
                dgvLatestResult.Columns[5].Selected = false;
                dgvLatestResult.Columns[6].Selected = false;
                dgvLatestResult.Columns[7].Selected = false;
                dgvLatestResult.Columns[8].Selected = false;
                int iColumn = dgvLatestResult.CurrentCell.ColumnIndex;
                int iRow = dgvLatestResult.CurrentCell.RowIndex;
                dgvLatestResult.Rows[iRow].Cells[6].Selected = true;
                if (iRow < dgvLatestResult.Rows.Count - 1)
                {
                    dgvLatestResult.CurrentCell = dgvLatestResult[6, iRow + 0];
                    iRow = iRow + 1;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtAdvice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtCommnets_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void btnVerifiedResult_Click(object sender, EventArgs e)
        {
            if (drsClient.verifyMrno(txtMrID.Text) == "0")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMrID.Select();
                return;
            }
            dgvLatestResult.Visible = false;
            dgvResultView.Visible = true;
            CreateUpdateValueProgrammatically(dgvResultView);
            if (mode == "V")
            {
                resultToVerify.Clear();
                resultToVerify.AddRange(drsClient.GetUpdatedVerifiedResult(txtMrID.Text, ReportGroupID).ToList());
            }
            if (mode == "F")
            {
                resultToVerify.Clear();
                resultToVerify.AddRange(drsClient.GetFinalisedResult(txtMrID.Text, ReportGroupID).ToList());
            }

            if (resultToVerify.Count > 0)
            {
                short indx = 0;
                foreach (DiagnosticReport data in resultToVerify)
                {
                    string[] row = new string[] { data.head.EntryParameter.EntryDate.ToString(), data.head.ResultHeadTitle, data.head.ResultValue, data.head.Machine.MachineTitle };
                    AddRows(dgvResultView, row, indx);
                    indx++;
                }
            }  
           
            dgvResultView.ClearSelection();
        }

        private void CreateUpdateValueProgrammatically(DataGridView dtv)
        {
            dtv.DataSource = null;
            dtv.Rows.Clear();
            dtv.Columns.Clear();

            dtv.AutoGenerateColumns = false;
            dtv.RowHeadersVisible = false;

            dtv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtv.AllowUserToResizeRows = false;
            dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtv.AllowUserToAddRows = false;
            dtv.AllowUserToDeleteRows = false;

            DataGridViewCellStyle style =
            dtv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.DodgerBlue;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvResultEntry.Font, FontStyle.Bold);


            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.ReadOnly = false;
            colDate.Name = "Date";
            colDate.DataPropertyName = "Date";
            colDate.Width = 105;
            colDate.Selected = false;
            colDate.ReadOnly = true;
            dtv.Columns.Add(colDate);


            DataGridViewTextBoxColumn dtvResultHdTitle = new DataGridViewTextBoxColumn();
            dtvResultHdTitle.Name = "HeadTitle";
            dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
            dtvResultHdTitle.Width = 225;
            dtvResultHdTitle.Selected = false;
            dtvResultHdTitle.ReadOnly = true;
            dtv.Columns.Add(dtvResultHdTitle);

            DataGridViewTextBoxColumn colResult = new DataGridViewTextBoxColumn();
            colResult.ReadOnly = true;
            colResult.Name = "Result";
            colResult.DataPropertyName = "ResultValue";
            colResult.Width = 115;
            colResult.Selected = false;      
            dtv.Columns.Add(colResult);

            DataGridViewTextBoxColumn colMachine = new DataGridViewTextBoxColumn();
            colMachine.Selected = false;
            colMachine.Name = "Machine";
            colMachine.DataPropertyName = "Machine";
            colMachine.Width = 85;
            colMachine.ReadOnly = true;
            dtv.Columns.Add(colMachine);


        }

        private void btnRecentResult_Click(object sender, EventArgs e)
        {
            if (drsClient.verifyMrno(txtMrID.Text) == "0")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMrID.Select();
                return;
            }
            dgvLatestResult.Visible = true;
            dgvResultView.Visible = false;
            CreateColumnProgrammatically(dgvLatestResult);
            if (mode == "V")
            {
                PopulateLatestDataToGrid("V");
            }
            if (mode == "F")
            {
                PopulateLatestDataToGrid("F");
            }
            
            dgvLatestResult.ClearSelection();
        }

        private void lvSPCTests_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (lvSPCTests.SelectedItems.Count > 0)
            //{             
            //    ListViewItem itm = lvSPCTests.SelectedItems[0];
            //    dgvResultEntry.Rows.Clear();
            //    dgvResultView.Rows.Clear() ;
            //    dgvLatestResult.Rows.Clear();
            //    DiagnosticReport spc = new DiagnosticReport();
            //    spc = drsClient.GetSpecimenCollectionByResultID(txtSpecimenNo.Text, itm.SubItems[3].Text);
            //    LoadDetailsByResultId(spc);
            //    if (mode == "V")
            //    {

            //        PopulateDataToGrid();
            //        PopulateLatestDataToGrid("V");
            //        dgvResultEntry.ClearSelection();
            //        dgvLatestResult.ClearSelection();

            //    }
            //    if (mode == "F")
            //    {
            //        PopulateDataToGrid();
            //        PopulateLatestDataToGrid("F");
            //        dgvResultEntry.ClearSelection();
            //        dgvLatestResult.ClearSelection();

            //    }
            //}
        }

        private void txtMrID_TextChanged(object sender, EventArgs e)
        {
            if (txtMrID.Text.Length == Utility.ScanLength && txtMrID.Text != "")
            {
                btnPatientSearch_Click(sender, e);
            }
        }
        bool IsTheSameCellValue(int column, int row,DataGridView dgv)
        {
            DataGridViewCell cell1 = dgv[2, row];
            DataGridViewCell cell2 = dgv[2, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            if (cell1.Value.ToString() == cell2.Value.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsRepeatedCellValue(int p1, int p2)
        {
            throw new NotImplementedException();
        }
        private void dgvResultEntry_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == 2 && e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvResultEntry))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvResultEntry.AdvancedCellBorderStyle.Top;
            }
            if (dgvResultEntry.Rows.Count == e.RowIndex + 1)
            {
                //  e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                e.AdvancedBorderStyle.Bottom = dgvResultEntry.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvResultEntry_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (e.ColumnIndex == 2 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvResultEntry))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void dgvLatestResult_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == 2 && e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvLatestResult))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvLatestResult.AdvancedCellBorderStyle.Top;
            }
            if (dgvLatestResult.Rows.Count == e.RowIndex + 1)
            {              
                e.AdvancedBorderStyle.Bottom = dgvLatestResult.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvLatestResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (e.ColumnIndex == 2 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex, dgvLatestResult))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
  
        private void btnRptPreview_Click(object sender, EventArgs e)
        {
            if (drsClient.verifyMrno(txtMrID.Text) == "0")
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMrID.Select();
                return;
            }
            try
            {
                DiagnosticReport rshdobj = this.EditDiagResult();
                string j = drsClient.SaveFinalDiagnosticResultPreview(rshdobj);
                printResultPreview(txtMrID.Text, ReportSectionID, ReportGroupID);
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
        private void printResultPreview(string moneyReceiptID, string ReportSectionID, string ReportGroupID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.InvestigationReportPreview;
            vr.TransactionNo = moneyReceiptID;
            vr.RptSectionID = ReportSectionID;
            vr.RptGroupID = ReportGroupID;
            //vr.ReportTitle = "AH Health Card";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();
         
        }

        private void tvMoneyReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvNursStnMoneyReceipt.Nodes.Clear();
            tvEmergency.Nodes.Clear();
            if (mode == "V")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStationMrForVerified(ReportGroupID, DepartmentID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStationMrForVerified(ReportGroupID, DepartmentID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
            }
            if (mode == "F")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStnWiseMrForFinalised(ReportGroupID, ReportSectionID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStnWiseMrForFinalised(ReportGroupID, ReportSectionID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
              
            }
        }

        private void tvEmergency_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEmergency.SelectedNode.Parent != null)
            {
                txtMrID.Text = tvEmergency.SelectedNode.Text.ToString();
            }
        }
    }
}

