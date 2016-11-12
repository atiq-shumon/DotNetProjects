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
    public partial class frmManualDiagnosticResultEntry : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();       
        private string Department;
        private string ReportGroup;
        private string ReportSection;
        private string DepartmentID;
        private string ReportGroupID;
        private string ReportSectionID;    
        public frmManualDiagnosticResultEntry(string Department, string ReportGroup, string reportSection,string deptID,string rptGroupID,string rptSectionID)
        {
            InitializeComponent();
            this.Department = Department;
            this.ReportGroup = ReportGroup;
            this.ReportSection = reportSection;
            this.DepartmentID = deptID;
            this.ReportGroupID = rptGroupID;
            this.ReportSectionID = rptSectionID;              
        }

   
        private void FormatTestGrid()
        {
            lvSPCTests.CheckBoxes = false;
            lvSPCTests.Columns.Add("Test Name", 250, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Sample Collected For", 300, HorizontalAlignment.Left);
            lvSPCTests.Columns.Add("Main", 150, HorizontalAlignment.Left);
            lvSPCTests.Columns.Add("testdeatilsID",0, HorizontalAlignment.Left); 
        }

        private void FormatGrid(DataGridView dtv)
        {
            //dtv.Columns.Clear();
            //dtv.Rows.Clear();
            dtv.Width = 1290;
            dtv.AutoGenerateColumns = false;
            DataGridViewCellStyle style =
            dtv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.DodgerBlue;
            style.ForeColor = Color.White;

            style.Font = new Font(dgvResultEntry.Font, FontStyle.Bold);

            dtv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtv.AllowUserToResizeRows = false;
            dtv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtv.DefaultCellStyle.SelectionBackColor = Color.LightGray;

            DataGridViewTextBoxColumn dtvTestDeailsID = new DataGridViewTextBoxColumn();
            dtvTestDeailsID.Name = "TestDeatilsID";
            dtvTestDeailsID.DataPropertyName = "TestSubID";
            dtvTestDeailsID.Width = 0;
            dtvTestDeailsID.Visible = false;
            dtv.Columns.Add(dtvTestDeailsID);

            DataGridViewTextBoxColumn dtvTestDetailsTitle = new DataGridViewTextBoxColumn();
            dtvTestDetailsTitle.Name = "Test Name";
            dtvTestDetailsTitle.DataPropertyName = "TestSubTitle";
            dtvTestDetailsTitle.Width = 200;
            dtvTestDetailsTitle.Visible = true;
            dtvTestDetailsTitle.ReadOnly = true;
            dtvTestDetailsTitle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtvTestDetailsTitle.DefaultCellStyle.ForeColor = Color.DarkBlue;
            dtv.Columns.Add(dtvTestDetailsTitle);

           
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
            dtvResultHdTitle.Name = "HeadTitle";
            dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
            dtvResultHdTitle.Width = 300;
            dtvResultHdTitle.ReadOnly = true;
            dtv.Columns.Add(dtvResultHdTitle);

            DataGridViewTextBoxColumn colResult = new DataGridViewTextBoxColumn();
            colResult.ReadOnly = false;
            colResult.Name = "Result";
            colResult.DataPropertyName = "ResultValue";
            colResult.Width = 280;         
            dtv.Columns.Add(colResult);

            DataGridViewTextBoxColumn colReff = new DataGridViewTextBoxColumn();
            colReff.Name = "Reference Value";
            colReff.DataPropertyName = "RangeText";
            colReff.Width = 400;
            dtv.Columns.Add(colReff);
            dtv.AllowUserToResizeColumns = false;


            DataGridViewTextBoxColumn spc = new DataGridViewTextBoxColumn();
            spc.Name = "SpecimenID";
            spc.DataPropertyName = "SpecimenID";
            spc.Visible = false;
            spc.Width =0;
            dtv.Columns.Add(spc);
            dtv.AllowUserToResizeColumns = false;

            DataGridViewTextBoxColumn resultEntry = new DataGridViewTextBoxColumn();
            resultEntry.Name = "EntryStatus";
            resultEntry.DataPropertyName = "EntryStatus";
            resultEntry.Visible = true;
            resultEntry.Width = 80;
            resultEntry.ReadOnly = true;
            dtv.Columns.Add(resultEntry);
            dtv.AllowUserToResizeColumns = true;

            dgvResultEntry.PreviewKeyDown += dgvResultEntry_PreviewKeyDown;
        }

        private void dgvResultEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // e.supress = true;
            int iRow = dgvResultEntry.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Down)
            {
                dgvResultEntry.Columns[4].Selected = false;
                dgvResultEntry.Columns[5].Selected = true;               
                dgvResultEntry.Columns[6].Selected = false;
                dgvResultEntry.Rows[iRow].Cells[4].Selected = true;
                if (iRow < dgvResultEntry.Rows.Count - 1)
                {
                    dgvResultEntry.CurrentCell = dgvResultEntry[5, iRow + 0];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                dgvResultEntry.Columns[4].Selected = false;
                dgvResultEntry.Columns[5].Selected = true;
                dgvResultEntry.Columns[6].Selected = false;
                dgvResultEntry.Rows[iRow].Cells[4].Selected = true;
                if (iRow < dgvResultEntry.Rows.Count - 1)
                {
                    dgvResultEntry.CurrentCell = dgvResultEntry[4, iRow + 1];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                int iUpRow = dgvResultEntry.CurrentCell.RowIndex;
                if (iUpRow != 0)
                {
                    dgvResultEntry.Columns[4].Selected = false;
                    dgvResultEntry.Columns[5].Selected = true;
                    dgvResultEntry.Columns[6].Selected = false;
                    dgvResultEntry.Rows[iRow].Cells[4].Selected = true;
                    dgvResultEntry.CurrentCell = dgvResultEntry[5, iRow - 0];
                }
            }         
        }

          
        private void frmDiagnosticResultEntry_Load(object sender, EventArgs e)
        {
         
                lblDep.Text = Department;
                lblRrpGrp.Text = ReportGroup;
                lblReportSection.Text = ReportSection;
                FormatGrid(dgvResultEntry);         
                formatOPDListView();
                loadOPDSpceimenList();
                FormatTestGrid();

                cboMachine.DisplayMember = "Value";
                cboMachine.ValueMember = "Key";
                cboMachine.DataSource = new BindingSource(drsClient.GetMacSetup("D"), null);

                dgvResultEntry.AutoGenerateColumns = false;
         
        }
     
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending List", 110, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {
            lstOPD.Items.Clear();
            List<SpecimenCollection> OList = drsClient.OPDPendingSpecimenListForResult(ReportGroupID, DepartmentID).ToList();
            foreach (SpecimenCollection spc in OList)
            {
                ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                lstOPD.Items.Add(itm);
            }
        }
      
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMrID", "cboMachine" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                int flag = 0;
                for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
                {
                    if (dgvResultEntry.Rows[i].Cells[5].Value != null && dgvResultEntry.Rows[i].Cells[5].Value.ToString().Trim() != string.Empty
                        && dgvResultEntry.Rows[i].Cells[1].Value != null)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {

                    MessageBox.Show("Cannot insert null value,please check", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvResultEntry.Rows[0].Cells[5].Selected = true;
                    return;
                }
                DiagnosticReport rshdobj = this.PopulateDiagResult();
                string j = drsClient.SaveDiagnosticResult(rshdobj);

                if (j == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //  lvSPCTests.Clear();
                }
                else
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtMrID.Select();
                //  lvSPCTests.Clear();
                    loadOPDSpceimenList();
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

            //try
            //{
            //    //for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //    //{
            //    //    if (dgvResultEntry.Rows[i].Cells[3].Value == null || dgvResultEntry.Rows[i].Cells[3].Value.ToString().Trim() == string.Empty)
            //    //    {
            //    //        if (MessageBox.Show("Are You Sure To Proceed Blank Result?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    //        {
            //                DiagnosticReport rshdobj = this.PopulateDiagResult();
            //                string j = drsClient.SaveDiagnosticResult(rshdobj);

            //                if (j == "0")
            //                {
            //                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    //  lvSPCTests.Clear();
            //                }
            //                else
            //                {
            //                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    btnNew.PerformClick();
            //                    txtMrID.Select();
            //                    //  lvSPCTests.Clear();
            //                    loadOPDSpceimenList();
            //                }
            //          //  }

            //            MessageBox.Show("Cannot insert null value,please check", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
              
            //}


            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
         
        }
        string results = "";
        private DiagnosticReport PopulateDiagResult()
        {
            DiagnosticReport diag = new DiagnosticReport();
            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtMrID.Text;
            spcColl.Remarks = "r";
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

            results = "";

            for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            {
                if (dgvResultEntry.Rows[i].Cells[5].Value != null && dgvResultEntry.Rows[i].Cells[5].Value.ToString().Trim() != string.Empty)
                {
                    results = results+cboMachine.SelectedValue.ToString() + "$" +
                        dgvResultEntry.Rows[i].Cells[3].Value.ToString()+"$"+
                        dgvResultEntry.Rows[i].Cells[2].Value.ToString()+"$"+
                        dgvResultEntry.Rows[i].Cells[5].Value.ToString()+"$"+
                        dgvResultEntry.Rows[i].Cells[7].Value.ToString()+"$"+
                        dgvResultEntry.Rows[i].Cells[0].Value.ToString()+";";
                  

                }

            }
            diag.Results=results;      
            EntryParameter ep = new EntryParameter(); 
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            diag.EntryParameter = ep;

            return diag;

        }
        private DiagnosticReport ReportPreView()
        {
            DiagnosticReport diag = new DiagnosticReport();

            diag.Advice = "";
            diag.Comments = "Preview From Result Entry";

            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtMrID.Text;
            spcColl.Remarks = "r";
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

            results = "";

            for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            {
                if (dgvResultEntry.Rows[i].Cells[5].Value != null && dgvResultEntry.Rows[i].Cells[5].Value.ToString().Trim() != string.Empty)
                {
                    results = results + cboMachine.SelectedValue.ToString() + "$" +
                        dgvResultEntry.Rows[i].Cells[3].Value.ToString() + "$" +
                        dgvResultEntry.Rows[i].Cells[2].Value.ToString() + "$" +
                        dgvResultEntry.Rows[i].Cells[5].Value.ToString() + "$" +
                        dgvResultEntry.Rows[i].Cells[7].Value.ToString() + "$" +"D-00001"+"$"+
                        dgvResultEntry.Rows[i].Cells[0].Value.ToString() + ";";


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
      
        private void btnPatientSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMrID.Text != "")
                {
                    List<string> vf = new List<string>() { "cboMachine" };
                    Control control = Utility.ReqFieldValidator(this, vf);
                    if (control != null)
                    {
                        MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        return;
                    }

                    //if (drsClient.verifySpecimenNumbers(txtMrID.Text, DepartmentID, ReportGroupID) == "0")
                    //    {
                    //        MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        txtMrID.Select();
                    //        txtMrID.Text = "";
                    //        btnNew.PerformClick();
                    //        return;
                    //    }               
                    SpecimenCollection spc = new SpecimenCollection();
                    spc = drsClient.GetSpecimenCollection(txtMrID.Text);
                    LoadDetails(spc);
                    LoadTests(txtMrID.Text, ReportGroupID);
                    if (cboMachine.SelectedValue != null || cboMachine.SelectedValue != string.Empty)
                    {
                        PopulateDataToGrid(txtMrID.Text, ReportGroupID, cboMachine.SelectedValue.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please select a MR No");
                    lstOPD.Select();
                }
                ColorGrid();
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
        private void PopulateDataToGrid(string mrID, string ReportGroupID,string machineID)
        {
            try { 
            List<ResultHead> list = new List<ResultHead>();
            list.AddRange(drsClient.GetResHead(mrID, ReportGroupID, machineID));
             if (list.Count > 0)
              {
                dgvResultEntry.DataSource = list.Select(data => new {data.TestSub.TestSubID,data.TestSub.TestSubTitle, data.ResultHeadID, data.ResultGroup.ResultHeadGroupID, data.ResultHeadTitle, data.RangeText, data.SpecimenID}).ToList();
                dgvResultEntry.Rows[0].Cells[1].Selected = false;
                dgvResultEntry.Rows[0].Cells[5].Selected = true;
              }
             else 
             {
                 MessageBox.Show("Result head is not assign for this machine");
                 dgvResultEntry.DataSource = null;
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
        private void ColorGrid()
        {
            if (txtMrID.Text != "")
            {
                List<DiagnosticReport> resultToVerify = new List<DiagnosticReport>();                   
                        resultToVerify.AddRange(drsClient.GetResultToVerify(txtMrID.Text, ReportGroupID).ToList());
                   if (resultToVerify.Count > 0)
                    {
                        foreach (DiagnosticReport data in resultToVerify)
                        {
                            for (int row = 0; row < dgvResultEntry.Rows.Count; row++)
                            {
                                if (dgvResultEntry.Rows[row].Cells[2].Value != null)
                                {
                                    if (dgvResultEntry.Rows[row].Cells[2].Value.ToString() == data.head.ResultHeadID)
                                    {
                                        dgvResultEntry.Rows[row].Cells[8].Value = "Yes";
                                        dgvResultEntry.Rows[row].Cells[8].Style.ForeColor = Color.Red;
                                    }
                                }
                            }

                        }
                    }
                    for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
                    {
                        if (dgvResultEntry.Rows[i].Cells[7].Value==string.Empty || dgvResultEntry.Rows[i].Cells[7].Value == null)
                        {
                            dgvResultEntry.Rows[i].ReadOnly = true;
                            dgvResultEntry.Rows[i].DefaultCellStyle.BackColor = Color.OldLace;
                        }
                        //if (dgvResultEntry.Rows[i+1].Cells[0].Value.ToString() == dgvResultEntry.Rows[i].Cells[0].Value.ToString())
                        //{                          
                        //    dgvResultEntry.Rows[i+1].Cells[1].Value="";
                        //}
                    }
                   // dgvResultEntry.Rows.Insert(dgvResultEntry.Rows.Count+1);
             }
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvResultEntry[1, row];
            DataGridViewCell cell2 = dgvResultEntry[1, row - 1];
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
        private void LoadDetails(SpecimenCollection spc)
        {
            try
            {txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            txtRegID.Text = spc.Patient.RegistrationNo;
            txtMrNo.Text = spc.DiagnosticMR.MRNo;
            txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            txtMoneyReceipt.Text = spc.DiagnosticMR.MRNo;
            txtGender.Text = spc.Patient.Sex;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));   
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

        private void LoadTests(string specimenNo, string ReportGroupID)
        {           
            lvSPCTests.Items.Clear();
            List<TestSub> tss = drsClient.GetSpcTestReportGroup(specimenNo,ReportGroupID).ToList();       
            foreach (TestSub ts in tss)
            {
                ListViewItem itm = new ListViewItem(ts.TestSubTitle);
                itm.SubItems.Add(ts.TestSubTitleAlias);
                itm.SubItems.Add(ts.TestMainTitle.ToString());
                itm.SubItems.Add(ts.TestSubID.ToString());
                lvSPCTests.Items.Add(itm);
            }         
        }    
        private void txtSpecimenNo_KeyUp(object sender, KeyEventArgs e)
        {
            
        }     
 
        private void btnNew_Click(object sender, EventArgs e)
        {                  
            //txtSpecimenNo.Text = "";
            //txtPatientName.Text = "";
            //txtSpecimenName.Text = "";
            //txtMrNo.Text = "";      
            dgvResultEntry.DataSource = null;
            lvSPCTests.Items.Clear();
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
                    ListViewItem itm = lstOPD.SelectedItems[0];
                    txtMrID.Text = itm.SubItems[0].Text;
                    // PopulateDataToGrid(txtMrID.Text, ReportGroupID);
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
        private void txtSpecimenNo_TextChanged(object sender, EventArgs e)
        {
            //if (txtMrID.Text != "" && txtMrID.TextLength == 11)
            //{
            //    btnPatientSearch.PerformClick();
            //}           
        }
      
        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMrID.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            }

        }

        private void dgvResultEntry_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
           
            if (e.ColumnIndex == 1  && e.RowIndex!=0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvResultEntry.AdvancedCellBorderStyle.Top; 
            }
            if (dgvResultEntry.Rows.Count == e.RowIndex+1)
            {
                //e.AdvancedBorderStyle.Top = dgvResultEntry.AdvancedCellBorderStyle.Top;
                e.AdvancedBorderStyle.Bottom = dgvResultEntry.AdvancedCellBorderStyle.Top;
            }
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void lvSPCTests_SelectedIndexChanged(object sender, EventArgs e)
        {       
            //if (lvSPCTests.SelectedItems.Count > 0)
            //{
            //    dgvResultEntry.DataSource = null;            
            //    ListViewItem itm = lvSPCTests.SelectedItems[0];               
            //   // PopulateDataToGrid(txtSpecimenNo.Text, ReportGroupID,itm.SubItems[3].Text);
              
            //}
           
        }

        private void txtMrID_TextChanged(object sender, EventArgs e)
        {
            if (txtMrID.Text.Length == Utility.ScanLength && txtMrID.Text != "" )
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void dgvResultEntry_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (e.ColumnIndex == 1 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void btnWorkSheet_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtMrID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            int flag = 0;
            for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            {
                if (dgvResultEntry.Rows[i].Cells[5].Value != null && dgvResultEntry.Rows[i].Cells[5].Value.ToString().Trim() != string.Empty
                    && dgvResultEntry.Rows[i].Cells[1].Value != null)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {

                MessageBox.Show("Cannot preview null value,please check", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvResultEntry.Rows[0].Cells[5].Selected = true;
                return;
            }
            DiagnosticReport rshdobj = this.ReportPreView();
            string j = drsClient.SaveFinalDiagnosticResultPreview(rshdobj);
            printResultPreview(txtMrID.Text, ReportSectionID, ReportGroupID);
        }
        private void printResultPreview(string moneyReceiptID, string ReportSectionID, string ReportGroupID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.InvestigationReportPreview;
            vr.TransactionNo = moneyReceiptID;
            vr.RptSectionID = ReportSectionID;
            vr.RptGroupID = ReportGroupID;         
            vr.ViewReport();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.tvMoneyReceipt_SelectedIndexChanged(sender, e);
                btnNew.PerformClick();
               
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

        private void tvEmergency_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEmergency.SelectedNode.Parent != null)
            {
                txtMrID.Text = tvEmergency.SelectedNode.Text.ToString();
            }
        }

        private void tvMoneyReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvNursStnMoneyReceipt.Nodes.Clear();
            tvEmergency.Nodes.Clear();
            if(tvMoneyReceipt.SelectedTab==tabIPD)
            {
                List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNursStationWiseMRNoForResult(ReportGroupID, DepartmentID,"I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
            }
            if (tvMoneyReceipt.SelectedTab == tbEmrg)
            {
                List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetNursStationWiseMRNoForResult(ReportGroupID, DepartmentID,"E").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvEmergency, ipdSpc);
            }
        }
    }
}

