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
    public partial class frmDiagnosticResultEntry : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();
        List<ResultHead> list = new List<ResultHead>();
        List<ResultHead> resultToVerify = new List<ResultHead>();
        List<ResultHead> heads = new List<ResultHead>();
        private string topTitle;
        private string mrID = "";
       // private string specimanID;
        private string Department;
        private string ReportGroup;
        private string ReportSection;
        private string DepartmentID;
        private string ReportGroupID;
        private string ReportSectionID;
        private string update;
        public frmDiagnosticResultEntry(string mrID, string saveBtnText, string Department, string ReportGroup, string reportSection
            ,string deptID,string rptGroupID,string rptSectionID,string update)
        {
            InitializeComponent();
            if (mrID.Length > 0)
            {
                if (update == "V")
                {
                    topTitle = "Diagnostic Result Verification";
                }
                if (update == "F")
                {
                    topTitle = "Diagnostic Result Finalisation";
                }

                this.mrID = mrID;
           //   this.specimanID = specimanID;
                this.Department = Department;
                this.ReportGroup = ReportGroup;
                this.ReportSection = reportSection;

            }
            else
            {
                topTitle = "Diagnostic Result Entry";               
            }
                frmLabel.Text = topTitle;
                btnSave.Text = saveBtnText;
                this.Department = Department;
                this.ReportGroup = ReportGroup;
                this.ReportSection = reportSection;
                this.DepartmentID=deptID;
                this.ReportGroupID=rptGroupID;
                this.ReportSectionID = rptSectionID;
                this.update = update;
        }

   
        private void FormatTestGrid()
        {
            lvSPCTests.CheckBoxes = false;
            lvSPCTests.Columns.Add("Test Name", 150, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Sample Collected For", 300, HorizontalAlignment.Center);
            lvSPCTests.Columns.Add("Main", 150, HorizontalAlignment.Left);           
        }

        private void CreateColumnProgrammatically(List<ResultHead> list, string resultID)
        {
                dgvResultEntry.DataSource = null;
                dgvResultEntry.Rows.Clear();
                dgvResultEntry.Columns.Clear();

                dgvResultEntry.AutoGenerateColumns = false;
                dgvResultEntry.RowHeadersVisible = false;
                dgvResultEntry.BackgroundColor = Color.White;             
                dgvResultEntry.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvResultEntry.AllowUserToResizeRows = false;
                dgvResultEntry.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvResultEntry.AllowUserToAddRows = false;
                dgvResultEntry.AllowUserToDeleteRows = false; 

                DataGridViewCellStyle style =
                dgvResultEntry.ColumnHeadersDefaultCellStyle;
                style.BackColor = Color.DodgerBlue;
                style.ForeColor = Color.White;
           
                style.Font = new Font(dgvResultEntry.Font, FontStyle.Bold);
         
                DataGridViewTextBoxColumn dtvResultHdID = new DataGridViewTextBoxColumn();
                dtvResultHdID.Name = "Head Code";
                dtvResultHdID.DataPropertyName = "ResultHeadID";
                dtvResultHdID.Width = 0;
                dtvResultHdID.Visible = false;
                dgvResultEntry.Columns.Add(dtvResultHdID);

                DataGridViewTextBoxColumn dtvResultHdGroup = new DataGridViewTextBoxColumn();
                dtvResultHdGroup.Name = "HeadGroup";
                dtvResultHdGroup.DataPropertyName = "ResultHeadGroupID";
                dtvResultHdGroup.Width = 0;
                dtvResultHdGroup.Visible = false;
                dgvResultEntry.Columns.Add(dtvResultHdGroup);

                DataGridViewTextBoxColumn dtvResultHdTitle = new DataGridViewTextBoxColumn();
                dtvResultHdTitle.Name = "HeadTitle";
                dtvResultHdTitle.DataPropertyName = "ResultHeadTitle";
                dtvResultHdTitle.Width = 400;
                dgvResultEntry.Columns.Add(dtvResultHdTitle);

                if (resultID == "")
                {                  
                    dgvResultEntry.DataSource = list.Select(data => new { data.ResultHeadID, data.ResultGroup.ResultHeadGroupID, data.ResultHeadTitle}).Distinct().ToList();
                    IEnumerable<ResultHead> query;
                    query = list.OrderBy(c => c.Machine.MachineID).GroupBy(c => c.Machine.MachineID).Select(g => g.First()).ToList();
                    int index = 3;
                    foreach (var name in query)
                    {
                        AddColumnsProgrammatically(name.Machine.MachineTitle, name.Machine.MachineID, index);
                        index = index + 2;
                    }
                    var reffColl = new DataGridViewTextBoxColumn();
                    reffColl.HeaderText = "";
                    reffColl.Name = "Reff.";
                    reffColl.Width = 0;
                    reffColl.Visible = false;
                    dgvResultEntry.Columns.AddRange(new DataGridViewColumn[] { reffColl });

                    var SpcId = new DataGridViewTextBoxColumn();
                    SpcId.HeaderText = "";
                    SpcId.Name = "SpcId";
                    SpcId.Width = 0;
                    SpcId.Visible = false;
                    dgvResultEntry.Columns.AddRange(new DataGridViewColumn[] { SpcId });
                   // dgvResultEntry.PreviewKeyDown += dgvResultEntry_PreviewKeyDown;
                  
                }
                else
                {
                    dgvResultEntry.DataSource = list.Select(data => new { data.ResultHeadID, data.ResultGroup.ResultHeadGroupID, data.ResultHeadTitle }).Distinct().ToList();
                    IEnumerable<ResultHead> query;
                    query = list.OrderBy(c => c.Machine.MachineID).GroupBy(c => c.Machine.MachineID).Select(g => g.First()).ToList();
                    int index = 3;
                    foreach (var name in query)
                    {
                        AddColumnsProgrammatically(name.Machine.MachineTitle, name.Machine.MachineID, index);
                        index = index + 2;
                    }
                    lblText.Text = "Money Receipt No";
                    
                    txtSpecimenNo.Enabled = false;

                    DeleteCheckBoxFromCell();
                    MakeTextFieldReadOnly();
                    GetResultHead();

                    var reffColl = new DataGridViewTextBoxColumn();
                    reffColl.HeaderText = "Reference Value";
                    reffColl.Name = "Reff.";
                    reffColl.Width = 300;
                    dgvResultEntry.Columns.AddRange(new DataGridViewColumn[] { reffColl });
                                   
                    var SpcId = new DataGridViewTextBoxColumn();
                    SpcId.HeaderText = "";
                    SpcId.Name = "SpcId";
                    SpcId.Width = 0;
                    SpcId.Visible = false;
                    dgvResultEntry.Columns.AddRange(new DataGridViewColumn[] { SpcId });

                    AddReferenceValue();
                }

                dgvResultEntry.AllowUserToResizeColumns = false;
          
        }
        private void AddReferenceValue()
        {
            int i=0;
            foreach (var reff in resultToVerify)
            {
                dgvResultEntry.Rows[i].Cells[dgvResultEntry.Columns.Count - 2].Value = reff.RangeText;
                dgvResultEntry.Rows[i].Cells[dgvResultEntry.Columns.Count - 2].ReadOnly = true;
              //  dgvResultEntry.Rows[i].Cells[dgvResultEntry.Columns.Count - 1].Value = reff.SpecimenCollectionID;
                i++;                
            }
        }
 
        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        private void AddColumnsProgrammatically(string HeaderText, string Name,int index)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();            
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvResultEntry.Columns.Insert(index, checkBoxColumn);
            AddCheckBoxHeader(index);
        
            var addColl = new DataGridViewTextBoxColumn();
            addColl.HeaderText = HeaderText;
            addColl.Name = Name;
            
            addColl.Width = 150;
            dgvResultEntry.Columns.AddRange(new DataGridViewColumn[] { addColl });
            
        }

        private void AddCheckBoxHeader(int index)
        {
            Rectangle rect = dgvResultEntry.GetCellDisplayRectangle(index, -1, true);
            rect.X = rect.Location.X + (rect.Width / 4);
            rect.Y = 4;         
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";        
            checkboxHeader.Size = new Size(13, 13);
            checkboxHeader.Location = rect.Location;         
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            dgvResultEntry.Controls.Add(checkboxHeader);
            
        }  
 
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
            UncheckCellCheckBox();
            int Index = 0;
            for (int coll = 1; coll < dgvResultEntry.Columns.Count - 4; )
            {
                coll = coll + 2;
                CheckBox headerBox = ((CheckBox)dgvResultEntry.Controls.Find("checkboxHeader", true)[Index]);             
                Index++;

                for (int i = 0; i < dgvResultEntry.RowCount; i++)
                {
                    if (dgvResultEntry.Rows[i].Cells[coll] is DataGridViewTextBoxCell)
                    {
                        dgvResultEntry.Rows[i].Cells[coll].Value = "";
                    }
                    else
                    {                       
                        if (headerBox.Checked == true && Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[coll].Value) == true)
                        {                          
                            headerBox.CheckState = CheckState.Unchecked;
                        }                       
                    }
                }
            }
        

            int headerIndex = 0;
            for (int coll = 1; coll < dgvResultEntry.Columns.Count - 4; )
            {
                coll = coll + 2;
                CheckBox headerBox = ((CheckBox)dgvResultEntry.Controls.Find("checkboxHeader", true)[headerIndex]);
                headerIndex++;
                if (headerBox.Checked == true)
                {
                    for (int i = 0; i < dgvResultEntry.RowCount; i++)
                    {
                        if (dgvResultEntry.Rows[i].Cells[coll] is DataGridViewTextBoxCell)
                        {
                            dgvResultEntry.Rows[i].Cells[coll].Value = "";
                        }
                        else
                        {
                            dgvResultEntry.Rows[i].Cells[coll].Value = true;                           
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dgvResultEntry.RowCount; i++)
                    {
                        if (dgvResultEntry.Rows[i].Cells[coll] is DataGridViewTextBoxCell)
                        {
                            dgvResultEntry.Rows[i].Cells[coll].Value = "";                         
                        }
                        else
                        {
                            dgvResultEntry.Rows[i].Cells[coll].Value = false;
                        }
                    }
                }            
            }                  
        }
        private void UncheckCellCheckBox()
        {
            int Index = 0;
            for (int coll = 1; coll < dgvResultEntry.Columns.Count - 4; )
            {
                coll = coll + 2;
                CheckBox headerBox = ((CheckBox)dgvResultEntry.Controls.Find("checkboxHeader", true)[Index]);
                Index++;

                for (int i = 0; i < dgvResultEntry.RowCount; i++)
                {
                    if (dgvResultEntry.Rows[i].Cells[coll] is DataGridViewTextBoxCell)
                    {
                        dgvResultEntry.Rows[i].Cells[coll].Value = "";
                    }
                    else
                    {
                        if (headerBox.Checked == false && Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[coll].Value) == true)
                        {
                           dgvResultEntry.Rows[i].Cells[coll].Value = false;                        
                        }
                    }
                }
            }
        }
        private void DeleteCheckBoxFromCell()
        {
            int rowIndex = 0;
            for(int row=0;row<dgvResultEntry.Rows.Count;row++)
            {
                GetMachine(dgvResultEntry.Rows[row].Cells[0].Value.ToString(), rowIndex, mrID);
                rowIndex++;
            }
            DeleteCheckBox();
           
        }
        private void GetMachine(string resultHeadID, int rowIndex, string resultID)
        {
           
            if (resultID == "")
            {
                IEnumerable<ResultHead> machineList;
                machineList = (from result in list
                               where result.ResultHeadID == resultHeadID
                               select result).ToList();
                foreach (ResultHead data in machineList)
                {
                    for (int Coll = 3; Coll < dgvResultEntry.Columns.Count-1; Coll++)
                    {
                        if (Coll % 2 != 0)
                        {
                            int Colls = Coll + 1;

                            if (dgvResultEntry.Columns[Colls].Name == data.Machine.MachineID.ToString())
                            {
                                dgvResultEntry.Rows[rowIndex].Cells[Coll].Style.BackColor = Color.LightGray;
                            }

                        }

                    }
                }
            }  
            else
            {
                IEnumerable<ResultHead> machineList;
                machineList = (from result in resultToVerify
                               where result.ResultHeadID == resultHeadID
                               select result).ToList();
                foreach (ResultHead data in machineList)
                {
                    for (int Coll = 3; Coll < dgvResultEntry.Columns.Count-1; Coll++)
                    {
                        if (Coll % 2 != 0)
                        {
                            int Colls = Coll + 1;

                            if (dgvResultEntry.Columns[Colls].Name == data.Machine.MachineID.ToString())
                            {
                                dgvResultEntry.Rows[rowIndex].Cells[Coll].Style.BackColor = Color.LightGray;
                            }
                        }
                    }
                }               
            }
        }
        private void GetResultHead()
        {
            int rowIndex = 0;
            for (int row = 0; row < dgvResultEntry.Rows.Count; row++)
            {
                GetResult(dgvResultEntry.Rows[row].Cells[0].Value.ToString(), rowIndex);
                rowIndex++;
            }
           
        }
       private void GetResult(string resultHeadID, int rowIndex)
        {
            IEnumerable<ResultHead> machineList;
            machineList = (from result in resultToVerify
                           where result.ResultHeadID == resultHeadID
                           select result).ToList();
            foreach (ResultHead data in machineList)
            {
                for (int Coll = 3; Coll < dgvResultEntry.Columns.Count-1; Coll++)
                {
                    if (Coll % 2 != 0)
                    {
                        int Colls = Coll + 1;

                        if (dgvResultEntry.Columns[Colls].Name == data.Machine.MachineID.ToString())
                        {
                            dgvResultEntry.Rows[rowIndex].Cells[Colls].Value = data.ResultValue;
                            dgvResultEntry.Rows[rowIndex].Cells[Coll].Value = true;
                        }
                    }

                }
            }
        }

       private void MakeTextFieldReadOnly()
       {
            for (int rowIndex=0;rowIndex < dgvResultEntry.Rows.Count; rowIndex++)
            {
                for (int Coll = 3; Coll < dgvResultEntry.Columns.Count-2; Coll++)
                {
                    if (Coll % 2 != 0)
                    {
                        if (dgvResultEntry.Rows[rowIndex].Cells[Coll] is DataGridViewTextBoxCell)
                        {
                            dgvResultEntry.Rows[rowIndex].Cells[Coll].ReadOnly = true;
                            dgvResultEntry.Rows[rowIndex].Cells[Coll+1].ReadOnly = true;
                        }
                    }
                }
            }
        }
     private void DeleteCheckBox()
        {
           for(int row=0;row<dgvResultEntry.Rows.Count;row++)
             {
                 for(int coll=0;coll<dgvResultEntry.Columns.Count;coll++)
                 {
                     if(dgvResultEntry.Rows[row].Cells[coll].Style.BackColor!=Color.LightGray)
                     {
                         dgvResultEntry.Rows[row].Cells[coll].Value = null;
                         dgvResultEntry.Rows[row].Cells[coll] = new DataGridViewTextBoxCell();
                         dgvResultEntry.Rows[row].Cells[coll].Value = "";                 
                     }
                     else
                     {
                         dgvResultEntry.Rows[row].Cells[coll].Style.BackColor = Color.White;
                     }
                 }
             }
        }
     private void dgvResultEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {          
            int iRow = dgvResultEntry.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Down)
            {            
                dgvResultEntry.Columns[3].Selected = false;
                dgvResultEntry.Columns[5].Selected = true;
                dgvResultEntry.Columns[5].Selected = false;
                dgvResultEntry.Rows[iRow].Cells[5].Selected = true;
                if (iRow < dgvResultEntry.Rows.Count - 1)
                {
                    dgvResultEntry.CurrentCell = dgvResultEntry[2, iRow + 0];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                dgvResultEntry.Columns[2].Selected = false;
                dgvResultEntry.Columns[5].Selected = true;
                dgvResultEntry.Columns[4].Selected = false;
                dgvResultEntry.Rows[iRow].Cells[5].Selected = true;
                if (iRow < dgvResultEntry.Rows.Count - 1)
                {
                    dgvResultEntry.CurrentCell = dgvResultEntry[3, iRow + 1];
                    iRow = iRow + 1;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                int iUpRow = dgvResultEntry.CurrentCell.RowIndex;
                if (iUpRow != 0)
                {
                    dgvResultEntry.Columns[2].Selected = false;
                    dgvResultEntry.Columns[5].Selected = true;
                    dgvResultEntry.Columns[4].Selected = false;
                    dgvResultEntry.Rows[iRow].Cells[3].Selected = true;
                    dgvResultEntry.CurrentCell = dgvResultEntry[2, iRow - 0];
                }
            }
       
        }
     
        private void frmDiagnosticResultEntry_Load(object sender, EventArgs e)
        {
            lblDep.Text = Department;
            lblRrpGrp.Text = ReportGroup;
            lblReportSection.Text = ReportSection;
            if (mrID == "")
            {
              //  txtSpecimenNo.Text = "";
                loadOPDSpceimenList();
            }
            else
            {
              //  txtSpecimenNo.Text = mrID;
                if (update == "V")
                {
                    lstOPD.Items.Clear();
                    List<SpecimenCollection> list = drsClient.GetReportListToVerify(ReportSectionID, ReportGroupID).ToList();
                    loadOPDMoneyReceiptList(list);
                }
                if (update == "F")
                {
                    lstOPD.Items.Clear();
                    List<SpecimenCollection> list = drsClient.GetReportListToFinalised(ReportSectionID, ReportGroupID).ToList();
                    loadOPDMoneyReceiptList(list);
                }

            }
           
            FormatTestGrid();
            List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetIPDNursStationWiseSpecimenNoForResult(ReportGroupID, DepartmentID).Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
            Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
            formatOPDListView();
           

        }
     
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending List", 200, HorizontalAlignment.Center);
        }
        private void loadOPDSpceimenList()
        {
            //lstOPD.Items.Clear();
            //List<SpecimenCollection> list = drsClient.OPDPendingSpecimenListForResult(ReportGroupID, DepartmentID).ToList();
            //foreach (SpecimenCollection spc in list)
            //{
            //    ListViewItem itm = new ListViewItem(spc.SpecimenCollectionID);
            //    itm.SubItems.Add(spc.SpecimenCollectionID);
            //    lstOPD.Items.Add(itm);
            //}
        }
        private void loadOPDMoneyReceiptList(List<SpecimenCollection> list)
        {           
            //foreach (SpecimenCollection spc in list)
            //{
            //    ListViewItem itm = new ListViewItem(spc.DiagnosticMR.MRNo);
            //    itm.SubItems.Add(spc.DiagnosticMR.MRNo);
            //    lstOPD.Items.Add(itm);
            //}
        }
        int isCheckFlag = 0;
        int value = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {            
            //List<string> vf = new List<string>() { "txtSpecimenNo" };
            //Control control = Utility.ReqFieldValidator(this, vf);
            //if (control != null)
            //{
            //    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    control.Focus();
            //    return;
            //}

         
            //for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //{
            //    for (int j = 3; j < (dgvResultEntry.Columns.Count) - 2;j++)
            //    {
            //        if (j % 2 != 0)
            //        {
            //            if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
            //            {
            //                dgvResultEntry.Rows[i].Cells[j].Value = "";
            //            }

            //            else
            //            {
            //                if (Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
            //                {
            //                    if (dgvResultEntry.Rows[i].Cells[j + 1].Value == null || dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString().Trim() == string.Empty)
            //                    {
            //                        MessageBox.Show("Cannot Insert Null Value,Please Check!");
            //                        return;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}          
            //if (mrID.Length == 0)
            //    {                    
            //        try
            //        {

            //            for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //            {
            //                isCheckFlag = 0;
            //                value=0;
            //                for (int j = 3; j < (dgvResultEntry.Columns.Count) - 2;j++ )
            //                {
            //                    if (j % 2 != 0)
            //                    {
            //                        if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
            //                        {
            //                            dgvResultEntry.Rows[i].Cells[j].Value = "";
            //                        }

            //                        else
            //                        {
            //                            if(dgvResultEntry.Rows[i].Cells[j+1].Value!="")
            //                            {
            //                                value = 1;
            //                            }
            //                            if(Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
            //                            {                                           
            //                                isCheckFlag = 1;
            //                            }
            //                        }
            //                    }

            //                }
            //                if (isCheckFlag != 1 && value==1)
            //                {
            //                    MessageBox.Show("Can't save without check!");
            //                    return;
            //                }
            //            }

            //            /*************************************************************************/
            //            DiagnosticReport rshdobj = this.PopulateDiagResult();
            //            if (heads.Count > 0)
            //            {
            //                string j = drsClient.SaveDiagnosticResult(rshdobj);

            //                if (j == "0")
            //                {
            //                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    lvSPCTests.Clear();
            //                }
            //                else if (j == "1")
            //                {
            //                    MessageBox.Show("Result Has Already Created,Please Check!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    btnNew.PerformClick();
            //                    lvSPCTests.Clear();

            //                }
            //                else
            //                {
            //                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    btnNew.PerformClick();
            //                    txtSpecimenNo.Select();
            //                    lvSPCTests.Clear();
            //                    loadOPDSpceimenList();
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Can not insert null value!");
            //                return;
            //            }

            //        }

            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //    else
            //     {
            //         for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //         {
            //             isCheckFlag = 0;
            //             for (int j = 1; j < (dgvResultEntry.Columns.Count) - 4; )
            //             {
            //                 j = j + 2;
            //                 if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
            //                 {
            //                     dgvResultEntry.Rows[i].Cells[j].Value = "";
            //                 }

            //                 else
            //                 {
            //                     if (Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
            //                     {
            //                         isCheckFlag = 1;
            //                     }
            //                 }

            //             }
            //             if (isCheckFlag != 1)
            //             {
            //                 MessageBox.Show("Can't save without check!");
            //                 return;
            //             }
            //         }
                     
            //        try
            //        {
            //            if (update == "V")
            //            {
            //                DiagnosticReport rshdobj = this.EditDiagResult();
            //                string j = drsClient.VerifyDiagnosticResult(rshdobj);
            //                if (j == "0")
            //                {
            //                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //                else
            //                {
            //                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    btnNew.PerformClick();
            //                    txtSpecimenNo.Select();                             
            //                }
            //            }
            //            if (update == "F")
            //            {
            //                DiagnosticReport rshdobj = this.PopulateFinalDiagResult();
            //                string j = drsClient.SaveFinalDiagnosticResult(rshdobj);
            //                if (j == "0")
            //                {
            //                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //                else
            //                {
            //                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    btnNew.PerformClick();
            //                    txtSpecimenNo.Select();
            //                    printResult(j);
            //                }
            //            }
            //        }

            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
 
            //    }
                   
        }
     
        private void printResult(string resultId)
        {
            //frmReportViewer vr = new frmReportViewer();
            //vr.selector = ViewerSelector.InvestigationReport;
            //vr.TransactionNo = resultId;
            ////vr.ReportTitle = "AH Health Card";
            ////vr.ReportSecondParameter = "Date Range: " + Utility.FormatDateRange(dtStartDate.Text, dtEndDate.Text);
            //vr.ViewReport();  
        }
        
        private DiagnosticReport PopulateDiagResult()
        {
            DiagnosticReport diag = new DiagnosticReport();
           // SpecimenCollection spcColl = new SpecimenCollection();
           // spcColl.SpecimenCollectionID = txtSpecimenNo.Text;
           // diag.SpecimenCollection = spcColl;
           // diag.Advice = txtAdvice.Text;
           // diag.Comments= txtCommnets.Text;

           // ReportGroup rpt = new ReportGroup();
           // rpt.ReportGroupID = ReportGroupID;

           // ReportSection rptSec = new ReportSection();
           // rptSec.ReportSectionID = ReportSectionID;
           // rpt.ReportSection = rptSec;
           // diag.ReportGroup = rpt;

           // InPatient pat = new InPatient();
           // pat.HCN = txtHCN.Text;
           // pat.RegistrationNo = txtRegID.Text;
           // diag.Patient = pat;
         
           // DiagnosticMR dmr = new DiagnosticMR();
           // dmr.MRNo = txtMrNo.Text;
           // diag.DiagnosticMR = dmr;

           //// List<ResultHead> heads = new List<ResultHead>();

           // for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
           // {
           //     for (int j = 1; j < (dgvResultEntry.Columns.Count) - 4;)
           //     {
           //         j = j + 2;
           //         if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
           //         {
           //             dgvResultEntry.Rows[i].Cells[j].Value = "";
           //         }

           //         else
           //         {
           //             if (Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
           //             {
           //                 if (dgvResultEntry.Rows[i].Cells[j + 1].Value != null && dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString().Trim() != string.Empty)
           //                 {
           //                     ResultHead rsh = new ResultHead();
           //                     Machine machine = new Machine();
           //                     machine.MachineID = dgvResultEntry.Columns[j + 1].Name;
           //                     rsh.Machine = machine;
           //                     rsh.ResultHeadID = dgvResultEntry.Rows[i].Cells[0].Value.ToString();

           //                     ResultHeadGroup hd = new ResultHeadGroup();
           //                     hd.ResultHeadGroupID = dgvResultEntry.Rows[i].Cells[1].Value.ToString();
           //                     rsh.ResultGroup = hd;
           //                     rsh.ResultValue = dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString();
           //                     heads.Add(rsh);

           //                 }
           //             }
           //         }
           //     }
           // }          

           // diag.heads = heads.ToArray(); ;
           // EntryParameter ep = new EntryParameter(); 
           // ep.EntryBy = Utility.UserId;
           // ep.CompanyID = Utility.CompanyID;
           // ep.LocationID = Utility.LocationID;
           // ep.MachineID = Utility.MachineID;
           // diag.EntryParameter = ep;

            return diag;

        }
        private DiagnosticReport PopulateFinalDiagResult()
        {
            DiagnosticReport diag = new DiagnosticReport();         
            //diag.Advice = txtAdvice.Text;
            //diag.Comments = txtCommnets.Text;

            //ReportGroup rpt = new ReportGroup();
            //rpt.ReportGroupID = ReportGroupID;

            //ReportSection rptSec = new ReportSection();
            //rptSec.ReportSectionID = ReportSectionID;
            //rpt.ReportSection = rptSec;
            //diag.ReportGroup = rpt;

            //InPatient pat = new InPatient();
            //pat.HCN = txtHCN.Text;
            //pat.RegistrationNo = txtRegID.Text;
            //diag.Patient = pat;

            //DiagnosticMR dmr = new DiagnosticMR();
            //dmr.MRNo = txtMrNo.Text;
            //diag.DiagnosticMR = dmr;

            //List<ResultHead> heads = new List<ResultHead>();

            //for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //{
            //    for (int j = 1; j < (dgvResultEntry.Columns.Count) - 4; )
            //    {
            //        j = j + 2;
            //        if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
            //        {
            //            dgvResultEntry.Rows[i].Cells[j].Value = "";
            //        }

            //        else
            //        {
            //            if (Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
            //            {
            //                if (dgvResultEntry.Rows[i].Cells[j + 1].Value != null && dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString().Trim() != string.Empty)
            //                {
            //                    ResultHead rsh = new ResultHead();
            //                    Machine machine = new Machine();
            //                    machine.MachineID = dgvResultEntry.Columns[j + 1].Name;
            //                    rsh.Machine = machine;
            //                    rsh.ResultHeadID = dgvResultEntry.Rows[i].Cells[0].Value.ToString();

            //                    ResultHeadGroup hd = new ResultHeadGroup();
            //                    hd.ResultHeadGroupID = dgvResultEntry.Rows[i].Cells[1].Value.ToString();
            //                    rsh.ResultGroup = hd;
            //                    rsh.ResultValue = dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString();
            //                    rsh.SpecimenCollectionID = dgvResultEntry.Rows[i].Cells[dgvResultEntry.Columns.Count-1].Value.ToString();
            //                    heads.Add(rsh);

            //                }
            //            }
            //        }
            //    }
            //}

            //diag.heads = heads.ToArray(); ;
            //EntryParameter ep = new EntryParameter();
            //ep.EntryBy = Utility.UserId;
            //ep.CompanyID = Utility.CompanyID;
            //ep.LocationID = Utility.LocationID;
            //ep.MachineID = Utility.MachineID;
            //diag.EntryParameter = ep;

            return diag;

        }
      
        private void btnPatientSearch_Click(object sender, EventArgs e)
        {          
            //if (mrID == "")
            //{
            //    if (drsClient.verifySpecimenNumbers(txtSpecimenNo.Text, DepartmentID, ReportGroupID) == "0")
            //    {
            //        MessageBox.Show(Utility.GetMsg(Utility.Msg.SpcNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtSpecimenNo.Select();                
            //        return;
            //    }
            //    dgvResultEntry.DataSource = null;
            //    dgvResultEntry.Refresh();
            //    SpecimenCollection spc = new SpecimenCollection();
            //    spc=drsClient.GetSpecimenCollection(txtSpecimenNo.Text);
            //    LoadDetails(spc);
            //    LoadTests(txtSpecimenNo.Text, ReportGroupID);
            //    list.Clear();
            //    list = drsClient.GetResHead(txtSpecimenNo.Text, ReportGroupID).ToList();
            //    if (list.Count > 0)
            //    {
            //        CreateColumnProgrammatically(list, mrID);
            //        DeleteCheckBoxFromCell();
            //        MakeTextFieldReadOnly();
            //    }

            //}
            //else
            //{
            //    DiagnosticReport spc =new  DiagnosticReport();

            //    spc = drsClient.GetSpecimenCollectionByResultID(txtSpecimenNo.Text);
            //    LoadDetailsByResultId(spc);
            //    LoadTestsByMrID(txtSpecimenNo.Text, ReportGroupID); 
           
            //    if (update == "V")
            //    {                 
            //      resultToVerify = drsClient.GetResultToVerify(txtSpecimenNo.Text, ReportGroupID).ToList();                 
            //    }
            //    if (update == "F")
            //    {                 
            //        resultToVerify = drsClient.GetResultToFinalised(txtSpecimenNo.Text, ReportGroupID).ToList();
            //    }
            //    CreateColumnProgrammatically(resultToVerify, txtSpecimenNo.Text);
            //}
        
        }
        private void LoadDetails(SpecimenCollection spc)
        {
            //txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            //txtPatientName.Text = spc.Patient.Name;
            //txtHCN.Text = spc.Patient.HCN;
            //txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            //txtRegID.Text = spc.Patient.RegistrationNo;
            //txtMrNo.Text = spc.DiagnosticMR.MRNo;
            //txtReportGr.Text = spc.ReportGroup.ReportGroupID;

        }

        private void LoadDetailsByResultId(DiagnosticReport spc)
        {
            //txtSpecimenName.Text = spc.Specimen.SpecimenTitle;
            //txtPatientName.Text = spc.Patient.Name;
            //txtHCN.Text = spc.Patient.HCN;
            //txtSpcecimenID.Text = spc.Specimen.SpecimenID;
            //txtRegID.Text = spc.Patient.RegistrationNo;
            //txtMrNo.Text = spc.DiagnosticMR.MRNo;
            //txtReportGr.Text = spc.ReportGroup.ReportGroupID;
            //txtCommnets.Text = spc.Comments;
            //txtAdvice.Text = spc.Advice;

        }
        private void LoadTestsByMrID(string mrID, string ReportGroupID)
        {
            //lvSPCTests.Items.Clear();
            //List<TestSub> tss = drsClient.GetTestByMRID(txtSpecimenNo.Text, ReportGroupID).ToList();
            //foreach (TestSub ts in tss)
            //{
            //    ListViewItem itm = new ListViewItem(ts.TestSubTitle);
            //    itm.SubItems.Add(ts.TestSubTitleAlias);
            //    itm.SubItems.Add(ts.TestMainTitle.ToString());
            //    lvSPCTests.Items.Add(itm);
            //}

        } 
        private void LoadTests(string specimenNo, string ReportGroupID)
        {           
        //    lvSPCTests.Items.Clear();
        //    List<TestSub> tss = drsClient.GetSpcTestReportGroup(specimenNo,ReportGroupID).ToList();       
        //    foreach (TestSub ts in tss)
        //    {
        //        ListViewItem itm = new ListViewItem(ts.TestSubTitle);
        //        itm.SubItems.Add(ts.TestSubTitleAlias);
        //        itm.SubItems.Add(ts.TestMainTitle.ToString());
        //        lvSPCTests.Items.Add(itm);
        //    }  
        
        } 
        private DiagnosticReport EditDiagResult()
         {
            DiagnosticReport diag = new DiagnosticReport();
            //diag.Advice = txtAdvice.Text;
            //diag.Comments = txtCommnets.Text;

            //ReportGroup rpt = new ReportGroup();
            //rpt.ReportGroupID = txtReportGr.Text;
            //ReportSection reptSec = new ReportSection();
            //reptSec.ReportSectionID = ReportSectionID;
            //rpt.ReportSection = reptSec;
            //diag.ReportGroup = rpt;

            //DiagnosticMR dmr = new DiagnosticMR();
            //dmr.MRNo = txtSpecimenNo.Text;
            //diag.DiagnosticMR = dmr;

            //List<ResultHead> heads = new List<ResultHead>();

            //for (int i = 0; i < dgvResultEntry.Rows.Count; i++)
            //{
            //    for (int j = 1; j < (dgvResultEntry.Columns.Count) - 4; )
            //    {
            //        j = j + 2;
            //        if (dgvResultEntry.Rows[i].Cells[j] is DataGridViewTextBoxCell)
            //        {
            //            dgvResultEntry.Rows[i].Cells[j].Value = "";
            //        }

            //        else
            //        {
            //            if (Convert.ToBoolean(dgvResultEntry.Rows[i].Cells[j].Value) == true)
            //            {
            //                if (dgvResultEntry.Rows[i].Cells[j + 1].Value != null && dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString().Trim() != string.Empty)
            //                {
            //                    ResultHead rsh = new ResultHead();
            //                    Machine machine = new Machine();
            //                    machine.MachineID = dgvResultEntry.Columns[j + 1].Name;
            //                    rsh.Machine = machine;
            //                    rsh.ResultHeadID = dgvResultEntry.Rows[i].Cells[0].Value.ToString();

            //                    ResultHeadGroup hd = new ResultHeadGroup();
            //                    hd.ResultHeadGroupID = dgvResultEntry.Rows[i].Cells[1].Value.ToString();
            //                    rsh.ResultGroup = hd;
            //                    rsh.ResultValue = dgvResultEntry.Rows[i].Cells[j + 1].Value.ToString();
            //                    heads.Add(rsh);
            //                }
            //            }
            //        }
            //    }
            //}          
            //diag.heads = heads.ToArray(); ;
            //EntryParameter ep = new EntryParameter();
            //ep.EntryBy = Utility.UserId;
            //ep.CompanyID = Utility.CompanyID;
            //ep.LocationID = Utility.LocationID;
            //ep.MachineID = Utility.MachineID;
            //diag.EntryParameter = ep;

            return diag;

        }
      
        private void txtSpecimenNo_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtSpecimenNo.Text.Length == Utility.ScanLength)
            //{
            //    btnPatientSearch_Click(sender, e);
            //}
        }
       
        private void dgvResultEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
        //    for (int row = 0; row < dgvResultEntry.Rows.Count; row++)
        //    {
        //        int col = row;
        //        for (int r = 3; r < dgvResultEntry.Columns.Count-2; r++)
        //        {
        //            if (r % 2 != 0)
        //            {    
        //                if (dgvResultEntry.Rows[col].Cells[r] is DataGridViewTextBoxCell)
        //                {
        //                   dgvResultEntry.Rows[col].Cells[r].Value = "";
        //                }
        //                else
        //                {
        //                    if (r != e.ColumnIndex && e.RowIndex == col)
        //                        dgvResultEntry[r, col].Value = false;                           
        //                }                                                             
        //            }
        //        }
        //    }        
        }
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
  
        }
        private void dgvResultEntry_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (this.dgvResultEntry.IsCurrentCellDirty)
            //{
            //    dgvResultEntry.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {          
            //int Index = 0;
            //int colCount = dgvResultEntry.Columns.Count;
            //for (int coll = 3; coll < colCount - 2;coll++)
            //{             
            //    if (coll % 2 != 0)
            //    {
            //        CheckBox headerBox = ((CheckBox)dgvResultEntry.Controls.Find("checkboxHeader", true)[0]);
            //        headerBox.Dispose();
            //        dgvResultEntry.Controls.Remove(headerBox);
            //    }
               
            //}
            
            //txtSpecimenNo.Text = "";
            //txtPatientName.Text = "";
            //txtSpecimenName.Text = "";
            //txtMrNo.Text = "";
            ////lvSPCTests.Clear();
            //dgvResultEntry.DataSource = null;
            //dgvResultEntry.Rows.Clear();
            //dgvResultEntry.Columns.Clear();           
            //txtSpecimenNo.Select();        
  
        }
         
        private void dgvResultEntry_SelectionChanged(object sender, EventArgs e)     
        {
           // dgvResultEntry.ClearSelection();
        }

        private void dgvResultEntry_Scroll(object sender, ScrollEventArgs e)
        {
            //int Index = 0;
            //for (int coll = 3; coll < dgvResultEntry.Columns.Count - 2; coll++)
            //{
            //    if (coll % 2 != 0)
            //    {
            //        CheckBox headerBox = ((CheckBox)dgvResultEntry.Controls.Find("checkboxHeader", true)[Index]);
            //        Index++;

            //        if (e.ScrollOrientation.Equals(ScrollOrientation.HorizontalScroll))
            //        {
            //            headerBox.Location = new Point(headerBox.Location.X - (e.NewValue - e.OldValue), headerBox.Location.Y);
            //        }
            //        if (headerBox.Location.X < dgvResultEntry.Location.X + 50)
            //        {
            //            headerBox.Visible = false;
            //        }
            //        else
            //        {
            //            headerBox.Visible = true;
            //        }
            //    }
            //}    
        }

        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {       
            //if (lstOPD.SelectedItems.Count > 0)
            //{
            //    btnNew.PerformClick();
            //    ListViewItem itm = lstOPD.SelectedItems[0];
            //    txtSpecimenNo.Text = itm.SubItems[0].Text;
            //    //this.mrID = itm.SubItems[0].Text; ;
            //}
        }
        private void txtSpecimenNo_TextChanged(object sender, EventArgs e)
        {
            //if (txtSpecimenNo.Text == "")
            //{
            //   // lvSPCTests.Items.Clear();
            //    dgvResultHeads.DataSource = null;
            //    //btnNew.PerformClick();
            //}
            //if (txtSpecimenNo.Text != "" && txtSpecimenNo.TextLength == 11)
            //{
            //    btnPatientSearch.PerformClick();
            //}
           
        }

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            //{
            //    txtSpecimenNo.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            //}

        }

        private void dgvResultEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResultEntry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{             
            //    if (dgvResultEntry.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.Cell)
            //        dgvResultEntry.BeginEdit(true);
            //    else
            //        dgvResultEntry.EndEdit();
            //}
        }

        private void dgvResultEntry_KeyDown(object sender, KeyEventArgs e)
        {
            //dgvResultEntry.Columns[0].Selected = false;
            //dgvResultEntry.Columns[1].Selected = false;
            //dgvResultEntry.Columns[2].Selected = false;
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;
            //    int iColumn = dgvResultEntry.CurrentCell.ColumnIndex;
            //    int iRow = dgvResultEntry.CurrentCell.RowIndex;
            //    if (iColumn == dgvResultEntry.Columns.Count - 1)
            //        dgvResultEntry.CurrentCell = dgvResultEntry[0, iRow + 1];
            //    else
            //        dgvResultEntry.CurrentCell = dgvResultEntry[iColumn + 1, iRow];

            //}
        }
    }
}

