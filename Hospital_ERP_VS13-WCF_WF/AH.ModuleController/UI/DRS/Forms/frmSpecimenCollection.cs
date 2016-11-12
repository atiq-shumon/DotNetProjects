using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DRSSR;
using AH.ModuleController.UI.DRS.Reports.Viewer;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmSpecimenCollection : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient dsrClnt = new DRSSR.DRSWSClient();
        private string nurseSationID;
        private string mode;
        public frmSpecimenCollection(string nurseSationID,string mode)
        {
            InitializeComponent();
            this.nurseSationID = nurseSationID;
            this.mode = mode;
        }
        int isCheckFlag = 0;
      
        private void btnSave_Click(object sender, EventArgs e)
        {
        //  int count = 0;
            List<string> vf = new List<string>() { "txtMRNo" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            try
            {
                if (dsrClnt.verifyMrno(txtMRNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMRNo.Select();
                    txtMRNo.Text = "";
                    btnNew.PerformClick();
                    return;
                }           
                for (int row = 0; row < dgvSpecimenColl.Rows.Count; row++)
                {                          
                    if (Convert.ToBoolean(dgvSpecimenColl.Rows[row].Cells[0].Value) == true)
                    {
                      //  count++;
                        isCheckFlag = 1;
                    }
                }
                if (isCheckFlag != 1)
                {
                    MessageBox.Show("No Test selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (count > 12)
                //{
                //    MessageBox.Show("Can not select more than 12 test at a time", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                SpecimenCollection tbd = this.PopulateSpecimentCollection();
                string i = dsrClnt.SaveSpecimenCollection(tbd);
                
                if (i.Length == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i.Length > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblWait.Visible = true;
                    lblWait.Text = "Please wait while printing label.......";
                    printSpecimenCollLabel(i);
                    lblWait.Text = "";
                    btnNew.PerformClick();
                    btnRefresh.PerformClick();                   
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

        private void printSpecimenCollLabel(string spcNo)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.SpecimenDetailsReport;
            vr.TransactionNo = spcNo;
            vr.isPrintDirect = true;
            vr.ViewReport();         
        }    
        private SpecimenCollection PopulateSpecimentCollection()
        {
            

            SpecimenCollection spcColl = new SpecimenCollection();
            spcColl.SpecimenCollectionID = txtSpcCollId.Text;
            spcColl.ReportPriority = "0";

            InPatient inObj = new InPatient();
            inObj.HCN = txtHCN.Text;
            inObj.RegistrationNo = txtRegNo.Text;
            spcColl.Patient = inObj;

            DiagnosticMR dmr = new DiagnosticMR();
            dmr.MRNo = txtMRNo.Text;
            spcColl.DiagnosticMR = dmr;

            spcColl.Remarks = txtRemarks.Text;
            string tests = "";
           // List<TestFee> tests = new List<TestFee>();

            for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSpecimenColl.Rows[i].Cells[0].Value) == true)
                {
                  
                    tests = tests + dgvSpecimenColl.Rows[i].Cells[12].Value.ToString() + ":" +
                        dgvSpecimenColl.Rows[i].Cells[13].Value.ToString() + ":" + 
                        "0:"+ 
                        dgvSpecimenColl.Rows[i].Cells[7].Value.ToString() + ":" +
                        dgvSpecimenColl.Rows[i].Cells[3].Value.ToString() + ":" +
                        dgvSpecimenColl.Rows[i].Cells[4].Value.ToString() + ":" + 
                        dgvSpecimenColl.Rows[i].Cells[9].Value.ToString() + ":" + 
                        dgvSpecimenColl.Rows[i].Cells[2].Value.ToString() + ":" +
                        dgvSpecimenColl.Rows[i].Cells[11].Value.ToString()+ ":" +
                        dgvSpecimenColl.Rows[i].Cells[5].Value.ToString() + ":" +
                        dgvSpecimenColl.Rows[i].Cells[15].Value.ToString()+ ":" +
                        dgvSpecimenColl.Rows[i].Cells[14].Value.ToString()+ ":"+
                        dgvSpecimenColl.Rows[i].Cells[18].Value.ToString()+ ";";

                  
                } 
            }
            spcColl.CollTests = tests;
          //  spcColl.Tests = tests.ToArray<TestFee>();
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            spcColl.EntryParameter = ep;
            return spcColl;

        }
  
        private void frmSpecimenCollection_Load(object sender, EventArgs e)
        {
                if (mode == "I")
                {
                    List<AH.DUtility.NursingTree> purchaseorder = dsrClnt.GetNursStationWiseMoneyReceipt(nurseSationID).Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, purchaseorder);
                }
                if (mode == "E")
                {
                    List<AH.DUtility.NursingTree> purchaseorder = dsrClnt.GetMRForEmergencySampleColl(nurseSationID).Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                    Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, purchaseorder);
                }
            
                lblWait.Visible = false;
                // frmSpecimenCollection.AutoGenerateColumns = false;
                dgvSpecimenColl.AutoGenerateColumns = false;
                txtMRNo.Select();
       
        }
        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin,bool visible)
        {
            DataGridViewTextBoxColumn Deptcolumn = new DataGridViewTextBoxColumn();
            Deptcolumn.DataPropertyName = pname;
            Deptcolumn.HeaderText = htext;
            Deptcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Deptcolumn.DefaultCellStyle.BackColor = Color.White;
            Deptcolumn.Visible = true_false;
            Deptcolumn.DefaultCellStyle.Alignment = Algin;
            Deptcolumn.Width = cwidth;
            Deptcolumn.ReadOnly = true;
            Deptcolumn.Visible = visible;
            Deptcolumn.Selected = false;          
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);

            DataGridViewCellStyle style = dgvSpecimenColl.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Navy;

            return Deptcolumn;
        }
        private void AddGridColumn(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add(FormatGrid("TestSubTitle", "Requested Test", 300, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft, true));
            dgv.Columns.Add(FormatGrid("TestSubID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("DepartmentID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("GroupId", " ", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("PanelID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("Container", "Container Name", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("ReportGroupID", " ", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("ReportGroupTitle", "Report Group", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("TestMainID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("TestMainTitle", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("FeeCategory", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("SpecimenID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("RoomID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("MethodID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("MRTestSubID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("EntryDate", "Date", 180, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("LabelGroup", "lblGrp", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("holderID", "holderID",0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
  
        private void PopulateDataToGrid(string mrno)
        {         
            List<TestFee> list = new List<TestFee>();
            list.AddRange(dsrClnt.GetDmrTestForSpc(mrno));
            short index = 0;
            foreach (TestFee data in list)
            {
                string[] row = new string[]{ data.TestSub.TestSubTitle,
                                             data.TestSub.TestSubID, 
                                             data.TestSub.TestDepartment.DepartmentID,
                                             data.TestSub.TestGroup.GroupId,
                                             data.TestSub.PanelID,
                                             data.SpecimenHolder.HolderTitle.ToString(),
                                             data.TestSub.ReportGroup.ReportGroupID,
                                             data.TestSub.ReportGroup.ReportGroupTitle,
                                             data.TestSub.TestMainID,
                                             data.TestSub.TestMainTitle,
                                             data.FeeCategory.FeeCategoryID,
                                             data.TestSub.Specimen.SpecimenID,
                                             data.TestSub.LabRoom.RoomID,
                                             data.TestSub.TestMethod.MethodID,
                                             data.TestSub.MRTestSubID,
                                             data.EParameter.EntryDate.ToString(),
                                             data.TestSub.LabelGroup.ToString(),
                                             data.SpecimenHolder.HolderID.ToString()};
                AddRowsToCollection(dgvSpecimenColl,index, row);
                //ControlListViewUI(Convert.ToInt16(data.SpecimenHolder.HolderID));
                index++;
            }

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvSpecimenColl.Columns.Insert(0, checkBoxColumn);        
        

        }

        private void AddRowsToCollection(DataGridView dtv,short index, string[] row)
        {
            dtv.Rows.Insert(index, row);
        }

        private void btnPatientMr_Click(object sender, EventArgs e)
        {       
            if (dsrClnt.verifyMrno(txtMRNo.Text) == "0" )
            {
                MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMRNo.Select();
                txtMRNo.Text = "";
                btnNew.PerformClick();
                return;
            }           
            InPatient pat = dsrClnt.GetCurrentPatient(txtMRNo.Text);         
            LoadPatient(pat);

            if (txtMRNo.Text !=string.Empty)
            {                      
                AddGridColumn(dgvSpecimenColl);
                PopulateDataToGrid(txtMRNo.Text);         
            }
            dgvSpecimenColl.ClearSelection();
            dgvSpecimenColl.Columns[6].DefaultCellStyle.ForeColor = Color.Red;
        }
        private void LoadPatient(InPatient pat)
        {
            txtPatientName.Text = pat.Name;
            txtHCN.Text = pat.HCN;
            txtRegNo.Text = pat.RegistrationNo;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAge.Text  = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
            txtSex.Text = pat.Sex;
        }

        private void txtMRNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMRNo.Text.Length == Utility.ScanLength)
            {          
                btnPatientMr_Click(sender, e);
            }
        }
        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {
            //if (txtMRNo.Text == "")
            //{
            //    lvMRTests.Items.Clear();
            //    btnNew.PerformClick();
            //}
            if (txtMRNo.Text != "" && txtMRNo.TextLength == 11)
            {
                txtMRNo.Text = txtMRNo.Text.ToUpper();         
                btnPatientMr.PerformClick();
            }
        }
      
        private void tvNursStnMoneyReceipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           ////// if (!tvNursStnMoneyReceipt.Nodes[0].IsSelected)
           // if (tvNursStnMoneyReceipt.SelectedNode.Parent!=null)
           // {
           //     txtMRNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
           // }          
        }  
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tvNursStnMoneyReceipt.Nodes.Clear();
            if (mode == "I")
            {
                List<AH.DUtility.NursingTree> purchaseorder = dsrClnt.GetNursStationWiseMoneyReceipt(nurseSationID).Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, purchaseorder);
            }
            if (mode == "E")
            {
                List<AH.DUtility.NursingTree> purchaseorder = dsrClnt.GetMRForEmergencySampleColl(nurseSationID).Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, purchaseorder);
            }
        }

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
                {
                    txtMRNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmSpecimenLabelList frmSpcList = new frmSpecimenLabelList("","");
            //frmSpcList.frmLabel.Text = "Diagnostic Money Receipt List";
            //frmSpcList.ShowDialog();
            
        }

        private void ControlListViewUI(short mode)
        {
            switch (mode)
            {
                case 1:
                    for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                    {
                        if (dgvSpecimenColl.Rows[i].Cells[16].Value.ToString()=="1")
                            dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;                          
                    }
                    break;
                case 2:
                    for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                    {
                        if (dgvSpecimenColl.Rows[i].Cells[16].Value.ToString() == "2")
                        dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                       
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                        {
                            if (dgvSpecimenColl.Rows[i].Cells[16].Value.ToString() == "3")
                                dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;                           
                        }
                        break;
                    }
                default:
                    {
                        for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                        {
                            dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;                           
                        }
                        break;
                    }  
   
               }

         }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblWait.Text = "";
            dgvSpecimenColl.Rows.Clear();
            dgvSpecimenColl.Columns.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void txtMRNo_Leave(object sender, EventArgs e)
        {
           
        }


        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvSpecimenColl[column, row];
            DataGridViewCell cell2 = dgvSpecimenColl[column, row - 1];
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

        private void dgvSpecimenColl_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            switch (e.ColumnIndex)
            {
                case 6:
                        if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                        {
                            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                        }
                        else
                        {
                            e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                        }
                    break;
                case 8:
                        if ( e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                        {
                            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                        }
                        else
                        {
                            e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                        }
                    break;
                case 16:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                    }
                    break;
             
                default:
                    {
                        e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;           
                        break;
                    }

            }
            //if (e.ColumnIndex == 6 && e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
            //}
            if (dgvSpecimenColl.Rows.Count == e.RowIndex + 1)
            {
                //e.AdvancedBorderStyle.Top = dgvResultEntry.AdvancedCellBorderStyle.Top;
                e.AdvancedBorderStyle.Bottom = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvSpecimenColl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            //if (e.ColumnIndex == 6 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.Value = "";
            //    e.FormattingApplied = true;
            //}
            switch (e.ColumnIndex)
            {
                case 6:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 8:
                        if ( IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                        {
                            e.Value = "";
                            e.FormattingApplied = true;
                        }
                    break;
                case 16:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
             
                //default:
                //    {

                //        e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;           
                //        break;
                //    }

            }
        }
       
    }
}
