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
    public partial class frmSpecimenCancellation : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient dsrClnt = new DRSSR.DRSWSClient();
        public frmSpecimenCancellation()
        {
            InitializeComponent();                  
        }
        int isCheckFlag = 0;   
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtSpcNo" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
     
            try
            {
                if (dsrClnt.verifyMrno(txtMrNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMrNo.Select();
                    txtMrNo.Text = "";
                    btnNew.PerformClick();
                    return;
                }
                //if (dsrClnt.verifySpecimenNo(txtSpcNo.Text) == "0")
                //{
                //    MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtSpcNo.Select();                 
                //    return;
                //}
                isCheckFlag = 0;
                for (int row = 0; row < dgvSpecimenColl.Rows.Count; row++)
                {
                    if (Convert.ToBoolean(dgvSpecimenColl.Rows[row].Cells[0].Value) == true)
                    {
                        isCheckFlag = 1;
                    }
                }
                if (isCheckFlag != 1)
                {
                    MessageBox.Show("No Test selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SpecimenCollection tbd = this.PopulateSpecimentCollection();
                short i = dsrClnt.UpdateSpecimenReceivedBy(tbd);
                
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i ==1)
                {
                    MessageBox.Show("Received Successfully ", Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);                             
                    btnRefresh.PerformClick();                  
                    txtMrNo.Select();
                    lvMRTests.Items.Clear();
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
       
        }
      
        private SpecimenCollection PopulateSpecimentCollection()
        {
            SpecimenCollection spcColl = new SpecimenCollection();          
          //  List<TestFee> tests = new List<TestFee>();
            string test = "";
            for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSpecimenColl.Rows[i].Cells[0].Value) == true)
                {

                    test = test+txtMrNo.Text + ":" + dgvSpecimenColl.Rows[i].Cells[2].Value.ToString() + ";";

                }
            }
            spcColl.CollTests = test;            
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

            List<AH.DUtility.NursingTree> ipdMoneyReceipt = dsrClnt.GetNurseStatonWiseMRNoForSampleReciv("I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdMoneyReceipt);
                btnSave.Text = "Received";
                formatOPDListView();
                loadOPDSpceimenList();
                //if(spcNo.Length>10)
                //{
                //    txtMrNo.Text = spcNo;
                //}
                txtMrNo.Select();
       
        }
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending Label", 200, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {
            lstOPD.Items.Clear();
            List<SpecimenCollection> list = dsrClnt.OPDPendingMoneyRecipt().ToList();          
            foreach (SpecimenCollection spc in list)
            {
                ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
                itm.SubItems.Add(spc.DiagnosticMR.MRNo);
                lstOPD.Items.Add(itm);
            }
        }
        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin, bool visible)
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
            dgv.Columns.Add(FormatGrid("TestSubTitle", "Requested Test", 250, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft, true));
            dgv.Columns.Add(FormatGrid("TestSubID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("DepartmentID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("GroupId", " ", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("PanelID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
           // dgv.Columns.Add(FormatGrid("PanelTitle", "Panel Name", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, true));
            dgv.Columns.Add(FormatGrid("Container", "Container Name", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("ReportGroupID", " ", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("ReportGroupTitle", "Report Group", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("TestMainID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("TestMainTitle", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("FeeCategory", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("SpecimenID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("RoomID", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));
            dgv.Columns.Add(FormatGrid("EntryDate", "Date", 180, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.BottomCenter, true));
            dgv.Columns.Add(FormatGrid("LabelGroup", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter, false));        
      
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void PopulateDataToGrid(string mrNo)         
        {  
            List<TestFee> list = new List<TestFee>();
            list.AddRange(dsrClnt.GetSpcCollforCancellation(mrNo));
            short index = 0;
            foreach (TestFee data in list)
            {
                string[] row = new string[]{ data.TestSub.TestSubTitle, data.TestSub.TestSubID, data.TestSub.TestDepartment.DepartmentID,
                data.TestSub.TestGroup.GroupId,data.TestSub.PanelID,data.SpecimenHolder.HolderTitle.ToString(),data.TestSub.ReportGroup.ReportGroupID,data.TestSub.ReportGroup.ReportGroupTitle,
                data.TestSub.TestMainID,data.TestSub.TestMainTitle,data.FeeCategory.FeeCategoryID,data.TestSub.Specimen.SpecimenID,data.TestSub.LabRoom.RoomID,data.EParameter.EntryDate.ToString()
               , data.TestSub.LabelGroup.ToString()};
                AddRowsToCollection(dgvSpecimenColl,index, row);
               // ControlListViewUI(Convert.ToInt16(data.TestSub.LabelGroup));
                index++;
            }

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";          
            dgvSpecimenColl.Columns.Insert(0, checkBoxColumn);

        }

        private void AddRowsToCollection(DataGridView dtv, short index,string[] row)
        {
            dtv.Rows.Insert(index, row);
        }
        private void CheckedCheckBox()
        {
            for(int i=0;i<dgvSpecimenColl.Rows.Count;i++)
            {
                dgvSpecimenColl.Rows[i].Cells[0].Value = true;
            }
        }
        private void ControlListViewUI(short mode)
        {
            switch (mode)
            {
                case 1:
                    for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                    {
                        if (dgvSpecimenColl.Rows[i].Cells[14].Value.ToString() == "1")
                            dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;                       
                    }
                    break;
                case 2:
                    for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                    {
                        if (dgvSpecimenColl.Rows[i].Cells[14].Value.ToString() == "2")
                            dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;

                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < dgvSpecimenColl.Rows.Count; i++)
                        {
                            if (dgvSpecimenColl.Rows[i].Cells[14].Value.ToString() == "3")
                                dgvSpecimenColl.Rows[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
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
        private void LoadPatient(InPatient pat)
        {
            txtPatientName.Text = pat.Name;
            txtHCN.Text = pat.HCN;
            txtRegNo.Text = pat.RegistrationNo;
            AH.DUtility.Age age = Utility.CalculateAge(pat.DOB);
            txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));
            txtSex.Text = pat.Sex;
        }

        private void btnPatientMr_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsrClnt.verifyMrno(txtMrNo.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMrNo.Select();
                    txtMrNo.Text = "";
                    btnNew.PerformClick();
                    return;
                }

                InPatient pat = dsrClnt.GetCurrentPatient(txtMrNo.Text);
                LoadPatient(pat);
                //if (dsrClnt.verifySpecimenNo(txtSpcNo.Text) == "0")
                //{
                //    MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    btnNew.PerformClick();
                //    txtSpcNo.Select();
                //    return;
                //}

                // SpecimenCollection spc = dsrClnt.GetSpecimenCollection(txtSpcNo.Text);
                // LoadPatient(spc);

                if (txtMrNo.Text != string.Empty)
                {
                    AddGridColumn(dgvSpecimenColl);
                    PopulateDataToGrid(txtMrNo.Text);
                }
                CheckedCheckBox();
                dgvSpecimenColl.ClearSelection();
                dgvSpecimenColl.Columns[6].DefaultCellStyle.ForeColor = Color.Red;
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
        private void LoadPatient(SpecimenCollection spc)
        {
            txtPatientName.Text = spc.Patient.Name;
            txtHCN.Text = spc.Patient.HCN;
            txtRegNo.Text = spc.Patient.RegistrationNo;
            AH.DUtility.Age age = Utility.CalculateAge(spc.Patient.DOB);
            txtAge.Text  = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));       
            txtSex.Text = spc.Patient.Sex;
        }

        private void txtMRNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMrNo.Text.Length == Utility.ScanLength)
            {
                btnPatientMr_Click(sender, e);
            }
        }
        private void txtMRNo_TextChanged(object sender, EventArgs e)
        {
            if (txtMrNo.Text == "")
            {            
                btnNew.PerformClick();
            }
            if (txtMrNo.Text != "" && txtMrNo.TextLength == 11)
            {
                txtMrNo.Text = txtMrNo.Text.ToUpper();
                btnPatientMr.PerformClick();
            }
        }
      
        private void tvNursStnMoneyReceipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (!tvNursStnMoneyReceipt.Nodes[0].IsSelected)
            //if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            //{
            //    txtSpcNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            //}
           
        }  
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                tvNursStnMoneyReceipt.Nodes.Clear();
                btnNew.PerformClick();
                List<AH.DUtility.NursingTree> ipdMoneyReceipt = dsrClnt.GetNurseStatonWiseMRNoForSampleReciv("I").Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdMoneyReceipt);
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

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMrNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmSpecimenLabelList frmSpcList = new frmSpecimenLabelList(txtDepartment.Text,txtReportGroup.Text);
            //frmSpcList.ShowDialog();            
        }
      
        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOPD.SelectedItems.Count > 0)
            {
                ListViewItem itm = lstOPD.SelectedItems[0];
                txtMrNo.Text = itm.SubItems[0].Text;              
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMrNo.Text = "";         
            dgvSpecimenColl.Rows.Clear();
            dgvSpecimenColl.Columns.Clear();
        }

        private void txtMrNo_Leave(object sender, EventArgs e)
        {
            txtMrNo.Text = txtMrNo.Text.ToUpper();
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
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 14:
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
              //  e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
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
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 14:
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

        private void tvMoneyReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tvMoneyReceipt.SelectedTab==tbEmrg)
            {

            }
        }
    }
}
