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
    public partial class frmStainReportResultEntry : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();
        private string Department;
        private string ReportGroup;
        private string ReportSection;
        private string DepartmentID;
        private string ReportGroupID;
        private string ReportSectionID;
        private string mode;
        string TestDetailsID;
        string gramString, StringAFB, fungulStain;
        string varMrID;
        public frmStainReportResultEntry(string Department,string reportSection, string ReportGroup,  string deptID, string rptGroupID, string rptSectionID, string mode)
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
            lvSPCTests.Columns.Add("SpecimanCollID",0, HorizontalAlignment.Left);   
        }

        private void frmDiagnosticResultEntry_Load(object sender, EventArgs e)
        {       
                lblDep.Text = Department;
                lblRrpGrp.Text = ReportGroup;
                lblReportSection.Text = ReportSection;

                formatOPDListView();
                loadOPDSpceimenList();
                FormatTestGrid();
                if (mode == "V" )
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
            lstOPD.Columns.Add("Pending List", 150, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {      
            List<SpecimenCollection> OList = new List<SpecimenCollection>();
            if (mode == "E")
            {
                lstOPD.Items.Clear();
                OList = drsClient.OPDPendingSpecimenListForResult(ReportGroupID, DepartmentID).ToList();
                foreach (SpecimenCollection spc in OList)
                {
                    ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                    itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                    lstOPD.Items.Add(itm);
                }
                lblMachine.Visible = false;
                txtMachineName.Visible = false;
                smartLabel6.Visible = false;
                lblDateTime.Visible = false;
                smartLabel18.Visible = false;
                txtDateTime.Visible = false;
            }
            if (mode=="V")
            {
                frmLabel.Text = "Microbiology Result Verification";
                lstOPD.Items.Clear();
                OList = drsClient.GetOPDDMRToVerify(ReportSectionID, ReportGroupID).ToList();
                foreach (SpecimenCollection spc in OList)
                {
                    ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                    itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                    lstOPD.Items.Add(itm);
                }            
            }

            if (mode == "F")
            {
                frmLabel.Text = "Microbiology Result Finalization";
                lstOPD.Items.Clear();
                OList = drsClient.GetOPDDMRToFinalised(ReportSectionID, ReportGroupID).ToList();

                foreach (SpecimenCollection spc in OList)
                {
                    ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                    itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                    lstOPD.Items.Add(itm);
                }

                List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStnWiseMrForFinalised(ReportGroupID, ReportSectionID,"E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
            }

        }
        private void LoadDetailsByResultId(DiagnosticReport spc)
        {
            txtSpecimen.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            txtComment.Text = spc.Comments;
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
         // txtAdvice.Text = spc.Advice;

        }
        //private void LoadTestsByMrID(string mrID, string ReportGroupID)
        //{
        //    lvSPCTests.Items.Clear();
        //    List<TestSub> tss = drsClient.GetTestByMRID(txtMoneyReptNo.Text, ReportGroupID).ToList();
        //    foreach (TestSub ts in tss)
        //    {
        //        ListViewItem itm = new ListViewItem(ts.TestSubTitleAlias);
        //        itm.SubItems.Add(ts.TestSubTitle);
        //        itm.SubItems.Add(ts.TestMainTitle.ToString());
        //        itm.SubItems.Add(ts.Specimen.SpecimenID.ToString());
        //        lvSPCTests.Items.Add(itm);
        //    }

        //} 
        private void LoadLatestResult()
        {
            List<DiagnosticReport> resultToVerify = new List<DiagnosticReport>();
            {
                if (mode == "V")
                    resultToVerify = drsClient.GetStainDraftResult(txtMoneyReptNo.Text, ReportGroupID, TestDetailsID).ToList();
            }
            if(mode=="F")
            {
                resultToVerify = drsClient.GetStainResultToFinalised(txtMoneyReptNo.Text, ReportGroupID, TestDetailsID).ToList();
            }
            if (resultToVerify.Count > 0)
            {
                foreach (DiagnosticReport data in resultToVerify)
                {
                    if(data.head.ResultHeadID=="00052")
                    { 
                        txtGramStain.Text = data.head.ResultValue.Replace("\\r\\n", Environment.NewLine);
                    }
                   if(data.head.ResultHeadID=="00051")
                   {
                       txtAFBStain.Text = data.head.ResultValue.Replace("\\r\\n", Environment.NewLine);
                   }
                   if (data.head.ResultHeadID == "00459")
                   {
                       txtFungulStain.Text = data.head.ResultValue.Replace("\\r\\n", Environment.NewLine);
                   }
                    txtMachineName.Text = data.head.Machine.MachineTitle;
                    txtDateTime.Text = data.head.EntryParameter.EntryDate.ToString();
                    txtDraftId.Text = data.DraftResultID;                 
                    txtSpecimenId.Text = data.SpecimenCollection.SpecimenCollectionID;
                   // txtComment.Text = data.Comments;                  
                }
            }
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMoneyReptNo", "txtSpecimanId" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                if (txtGramStain.Text.Trim() == "" && txtAFBStain.Text.Trim() == "" && txtFungulStain.Text.Trim() == "")
                {
                    MessageBox.Show("Can't Insert Null Value!", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mode == "E")
                {
                    DiagnosticReport rshdobj = this.PopulateDiagResult();
                    string j = drsClient.STN_SAVE_T_DR_DET_DRAFT(rshdobj);

                    if (j == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lvSPCTests.Clear();
                    }
                    else
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        //txtMoneyReptNo.Select();                      
                        //lvSPCTests.Clear();
                        txtMoneyReptNo.Text = varMrID;
                        LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                        loadOPDSpceimenList();                         
                    }
                }
                if(mode=="V")
                {
                    DiagnosticReport rshdobj = this.EditDiagResult();
                    string j = drsClient.SaveVerifiedDiagnosticResult(rshdobj);
                    if (j == "0")
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Result Verify Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtMoneyReptNo.Select();
                        txtMoneyReptNo.Text = varMrID;
                        LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                        loadOPDSpceimenList();
                        //  btnRefresh.PerformClick();
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
                        MessageBox.Show("Result Finalized Successfully!", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtMoneyReptNo.Select();
                        txtMoneyReptNo.Text = varMrID;
                        LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                        //  btnRefresh.PerformClick();
                        printResult(j);
                        loadOPDSpceimenList();
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
            vr.selector = ViewerSelector.StainReport;
            vr.TransactionNo = resultId;
            //vr.ReportTitle = "AH Health Card";
            //vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            vr.ViewReport();
        }
        
        private DiagnosticReport PopulateDiagResult()
        {
            gramString = ""; StringAFB = ""; fungulStain = "";

            DiagnosticReport diag = new DiagnosticReport();
            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtSpecimanId.Text;
            spcColl.Remarks = txtComment.Text;
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

            List<ResultHead> heads = new List<ResultHead>();
            if (txtGramStain.Text!="")
            {
                gramString = "000" + "$" + "0048" + "$" + "00052" + "$" + txtGramStain.Text.Trim().Replace("\r\n", "\\r\\n") +"$"+TestDetailsID + ";";               
            }
            if (txtAFBStain.Text != "")
            {
                StringAFB = "000" + "$" + "0049" + "$" + "00051" + "$" + txtAFBStain.Text.Trim().Replace("\r\n", "\\r\\n") +"$" + TestDetailsID +";";
            }
            if (txtFungulStain.Text != "")
            {
                fungulStain = "000" + "$" + "0" + "$" + "00459" + "$" + txtFungulStain.Text.Trim().Replace("\r\n", "\\r\\n") + "$" + TestDetailsID + ";";
            }
            diag.Results = gramString + StringAFB + fungulStain;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diag.EntryParameter = ep;

            return diag;

        }
        private DiagnosticReport EditDiagResult()
        {
         
            DiagnosticReport diag = new DiagnosticReport();
            diag.Advice ="";
            diag.Comments = txtComment.Text;

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
            dmr.MRNo = txtMoneyReptNo.Text;
            diag.DiagnosticMR = dmr;

            List<ResultHead> heads = new List<ResultHead>();

            gramString = ""; StringAFB = ""; fungulStain = "";
            if (txtSpecimenId.Text=="")
            {
                txtSpecimenId.Text = txtSpecimanId.Text;
            }
            if (txtDraftId.Text == "")
            {
                txtDraftId.Text = "0";
            }
            if (txtGramStain.Text.Trim() != "")
            {
                gramString = "000" + "$" + "0048" + "$" + "00052" + "$" + txtGramStain.Text.Trim().Replace("\r\n", "\\r\\n") + "$" + txtSpecimenId.Text + "$" + txtDraftId.Text + "$" + TestDetailsID + ";";
            }
            if (txtAFBStain.Text != "")
            {
                StringAFB = "000" + "$" + "0049" + "$" + "00051" + "$" + txtAFBStain.Text.Trim().Replace("\r\n", "\\r\\n") + "$" +txtSpecimenId.Text + "$" +txtDraftId.Text + "$" + TestDetailsID + ";";
            }

            if (txtFungulStain.Text != "")
            {
                fungulStain = "000" + "$" + "0" + "$" + "00459" + "$" + txtFungulStain.Text.Trim().Replace("\r\n", "\\r\\n") + "$" + txtSpecimenId.Text + "$" +txtDraftId.Text + "$" + TestDetailsID + ";";
            }

            diag.Results = gramString + StringAFB + fungulStain;
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
            //if (mode == "E")
            //{
            //    //if (drsClient.verifySpecimenNumbers(txtMoneyReptNo.Text, DepartmentID, ReportGroupID) == "0")
            //    //{
            //    //    MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //    txtMoneyReptNo.Select();
            //    //    txtMoneyReptNo.Text = "";
            //    //    btnNew.PerformClick();
            //    //    return;
            //    //}
            //    SpecimenCollection spc = new SpecimenCollection();
            //    spc = drsClient.GetSpecimenCollection(txtMoneyReptNo.Text);
            //    LoadDetails(spc);
               
            //}                     
           // LoadTests(txtMoneyReptNo.Text, ReportGroupID);
            //if(update=="V")
            //{
            //    DiagnosticReport spc = new DiagnosticReport();
            //    spc = drsClient.GetSpecimenCollectionByResultID(txtSpecimenNo.Text);
            //    LoadDetailsByResultId(spc);
            //    LoadTestsByMrID(txtSpecimenNo.Text, ReportGroupID);              
            //    LoadLatestResult();
            //    frmLabel.Text = "Microbiology Result Verification";
            //    LoadTestsByMrID(txtSpecimenNo.Text, ReportGroupID);      
            //}
            //if (update == "F")
            //{
            //    DiagnosticReport spc = new DiagnosticReport();
            //    spc = drsClient.GetSpecimenCollectionByResultID(txtSpecimenNo.Text);
            //    LoadDetailsByResultId(spc);
            //    LoadTestsByMrID(txtSpecimenNo.Text, ReportGroupID);
            //    LoadLatestResult();
            //    frmLabel.Text = "Microbiology Result Finalization";
            //    LoadTestsByMrID(txtSpecimenNo.Text, ReportGroupID);      

            //}
          
        }
   
        private void LoadDetails(SpecimenCollection spc)
        {
            txtSpecimen.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
            //txtSpecimanId.Text = spc.DiagnosticMR.MRNo;

        }
         private void LoadTestsByMrID(string mrID, string ReportGroupID)
        {
            lvSPCTests.Items.Clear();
            if (mode == "E")
            {
                List<TestSub> tss = drsClient.GetReportTestDetails(txtMoneyReptNo.Text, ReportGroupID).ToList();
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
                List<TestSub> tss = drsClient.GetTestNameForVerify(txtMoneyReptNo.Text, ReportGroupID).ToList();
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
                List<TestSub> tss = drsClient.GetTestNameForFinalize(txtMoneyReptNo.Text, ReportGroupID).ToList();
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
        //private void LoadTests(string specimenNo, string ReportGroupID)
        //{
        //    lvSPCTests.Items.Clear();
        //    if (update == "E")
        //    {
        //        List<TestSub> tss = new List<TestSub>();
        //        tss = drsClient.GetSpcTestReportGroup(specimenNo, ReportGroupID).ToList();
        //        foreach (TestSub ts in tss)
        //        {
        //            ListViewItem itm = new ListViewItem(ts.TestSubTitle);
        //            itm.SubItems.Add(ts.TestSubTitleAlias);
        //            itm.SubItems.Add(ts.TestMainTitle.ToString());
        //            itm.SubItems.Add(ts.TestSubID.ToString());
        //            lvSPCTests.Items.Add(itm);
        //        }
        //    }
        //    else
        //    {
        //        List<TestSub> tss = new List<TestSub>();
        //        tss = drsClient.GetTestByMRID(txtMoneyReptNo.Text, ReportGroupID).ToList();
        //        foreach (TestSub ts in tss)
        //        {
        //            ListViewItem itm = new ListViewItem(ts.TestSubTitleAlias);
        //            itm.SubItems.Add(ts.TestSubTitle);
        //            itm.SubItems.Add(ts.TestMainTitle.ToString());
        //            itm.SubItems.Add(ts.TestSubID.ToString());
        //            lvSPCTests.Items.Add(itm);
        //        }
        //    }
      //  }    
        private void txtSpecimenNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMoneyReptNo.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }
       
 
        private void btnNew_Click(object sender, EventArgs e)
        {
           // txtMoneyReptNo.Text = txtMoneyReptNo.Text;
            lvSPCTests.Items.Clear();
   
            //txtSpecimenNo.Text = "";
            //txtPatientName.Text = "";
            //txtSpecimenName.Text = "";
            //txtMrNo.Text = "";      
            //dgvResultEntry.DataSource = null;
            //dgvResultEntry.Rows.Clear();
            //dgvResultEntry.Columns.Clear();           
            //txtSpecimenNo.Select();        
  
        }

        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOPD.SelectedItems.Count > 0)
                {
                    //btnNew.PerformClick();
                    emptyFields();
                    ListViewItem itm = lstOPD.SelectedItems[0];
                    txtMoneyReptNo.Text = itm.SubItems[0].Text;
                    LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                }
                //lvSPCTests.Items[0].Selected = true;
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
            if (txtMoneyReptNo.Text != "" && txtMoneyReptNo.TextLength == 11)
            {
                btnPatientSearch.PerformClick();
            }           
        }
      
        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMoneyReptNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
                LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
            }

        }

      
        private void txtGramStain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtAFBStain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtOtherStain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void txtComment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
        private void emptyFields()
        {
            txtPatientName.Text = string.Empty;
            txtSpecimanId.Text = string.Empty;
            txtMoneyReptNo.Text = string.Empty;         
            txtSpecimen.Text = string.Empty;
            txtGramStain.Text = string.Empty;
            txtFungulStain.Text = string.Empty;
            txtAFBStain.Text = string.Empty;
            txtComment.Text = string.Empty;

        }
        private void lvSPCTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvSPCTests.SelectedItems.Count > 0)
                {
                    TestDetailsID = "";
                    ListViewItem itm = lvSPCTests.SelectedItems[0];
                    txtSpecimanId.Text = itm.SubItems[4].Text;
                    if (mode == "E")
                    {
                        SpecimenCollection spc = new SpecimenCollection();
                        spc = drsClient.GetSpecimenCollection(txtMoneyReptNo.Text);
                        LoadDetails(spc);
                        TestDetailsID = itm.SubItems[3].Text;
                    }

                    if (mode == "V")
                    {
                        DiagnosticReport spc = new DiagnosticReport();
                        spc = drsClient.GetSpecimenCollectionByResultID(txtMoneyReptNo.Text, itm.SubItems[3].Text);
                        LoadDetailsByResultId(spc);
                        //  LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                        TestDetailsID = itm.SubItems[3].Text;
                        LoadLatestResult();

                        //LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                    }
                    if (mode == "F")
                    {
                        DiagnosticReport spc = new DiagnosticReport();
                        spc = drsClient.GetSpecimenCollectionByResultID(txtMoneyReptNo.Text, itm.SubItems[3].Text);
                        LoadDetailsByResultId(spc);
                        // LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
                        TestDetailsID = itm.SubItems[3].Text;
                        LoadLatestResult();

                        // LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);

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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> vf = new List<string>() { "txtMoneyReptNo", "txtSpecimen" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                if (drsClient.verifyMrno(txtMoneyReptNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoneyReptNo.Select();
                    return;
                }
                try
                {
                    if (txtGramStain.Text.Trim() == "" && txtAFBStain.Text.Trim() == "" && txtFungulStain.Text.Trim() == "")
                    {
                        MessageBox.Show("Can't Insert Null Value!", Utility.MistakeMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DiagnosticReport rshdobj = this.EditDiagResult();
                    string j = drsClient.SaveFinalDiagnosticResultPreview(rshdobj);
                    printResultPreview(txtMoneyReptNo.Text, ReportSectionID, ReportGroupID);
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
            vr.selector = ViewerSelector.StainReportPreview;
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

            if (mode == "E")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GET_IPD_SPEC_NO_FOR_RESL_STAN(ReportGroupID, DepartmentID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GET_IPD_SPEC_NO_FOR_RESL_STAN(ReportGroupID, DepartmentID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
                }
               
            
            }
            if (mode == "V")
            {
                if (tvMoneyReceipt.SelectedTab == tabIPD)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStationMrForVerified(ReportGroupID, ReportSectionID, "I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                }
                if (tvMoneyReceipt.SelectedTab == tbEmrg)
                {
                    List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNurseStationMrForVerified(ReportGroupID, ReportSectionID, "E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
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
                txtMoneyReptNo.Text = tvEmergency.SelectedNode.Text.ToString();
                LoadTestsByMrID(txtMoneyReptNo.Text, ReportGroupID);
            }
        }
    }
}

