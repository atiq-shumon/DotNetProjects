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
    public partial class frmReportPrintInterface : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();

        public frmReportPrintInterface()
        {
            InitializeComponent();       
        }

        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
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
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);
            DataGridViewCellStyle style =
            dgvReportList.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.DodgerBlue;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvReportList.Font, FontStyle.Bold);

            return Deptcolumn;
        }
        private void AddGridColumn(DataGridView dgv)
        {
            dgv.Columns.Add(CreateGridColumnchkFormat("CheckBox", "",30, true, DataGridViewContentAlignment.MiddleCenter, false, false, "checkbox"));
            dgv.Columns.Add(FormatGrid("ReportId", "ReportId", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportSection", "ReportSection", 140, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportGroup", "ReportGroup", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportGrpId", "Report Group", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Test Name", "Test Name", 210, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
       
            dgv.Columns.Add(CreateGridColumnButtonFormat("Report Print","Print"));

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        private void FormateAllTestGrid(DataGridView dgv)
        {
            dgv.Columns.Add(FormatGrid("Lab ID", "Collection ID", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportSection", "Report Section", 180, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportGroup", "Report Group", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Test Name", "Test Name", 250, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        public DataGridViewCheckBoxColumn CreateGridColumnchkFormat(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;

            return Ckbox;

        }
        public DataGridViewButtonColumn CreateGridColumnButtonFormat(string name,string buttonText)
        {
            DataGridViewButtonColumn oButton = new DataGridViewButtonColumn();
            oButton.HeaderText = "Print";
            oButton.Name = name;
            oButton.Text = buttonText;
            oButton.UseColumnTextForButtonValue = true;
            return oButton;
          
        }
        private void AddCheckBoxHeader()
        {
            Rectangle rect = dgvReportList.GetCellDisplayRectangle(0, -1, true);
            rect.X = rect.Location.X + (rect.Width / 4);
            rect.Y = 4;
            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(13, 13);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            dgvReportList.Controls.Add(checkboxHeader);

        }  
 
        private void ColourGrid()
        {
            for (int i = 0; i <dgvAllTestList.Rows.Count; i++)
            {
                if(i%2!=0)
                dgvAllTestList.Rows[i].DefaultCellStyle.BackColor = Color.LavenderBlush;
            }
        }
        private void formatOPDListView()
        {
            lstOPD.CheckBoxes = false;
            lstOPD.Columns.Add("Pending List", 100, HorizontalAlignment.Center);
        }
        private void loadOPDMoneyRecepitList()
        {
            lstOPD.Items.Clear();
            List<DiagnosticMR> list = drsClient.GetMrListToPrint().ToList();
            foreach (DiagnosticMR oDMr in list)
            {
                ListViewItem itm = new ListViewItem(oDMr.MRNo);
                itm.SubItems.Add(oDMr.MRNo);
                lstOPD.Items.Add(itm);
            }
        }
        private void frmReportPrintInterface_Load(object sender, EventArgs e)
        {          
                AddGridColumn(dgvReportList);
                formatOPDListView();
                loadOPDMoneyRecepitList();
                List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetIPDMRList().Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
                Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
                FormateAllTestGrid(dgvAllTestList);
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAllTestList.Rows.Clear();
                if (drsClient.verifyMrno(txtMoneyRecipt.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoneyRecipt.Select();
                    return;
                }
                //DiagnosticReport oDMr = new DiagnosticReport();
                //oDMr = drsClient.GetSpecimenCollectionByResultID(txtMoneyRecipt.Text);
                //LoadDetailsByResultId(oDMr);

                dgvReportList.Rows.Clear();
                List<SpecimenCollection> spcList = new List<SpecimenCollection>();
                spcList = drsClient.GetAllReportsByMRID(txtMoneyRecipt.Text).ToList();
                LoadDetailsByResultId(spcList);
                if (spcList.Count > 0)
                {
                    for (int rcont = 0; rcont < spcList.Count; rcont++)
                    {
                        dgvReportList.Rows.Add();
                        dgvReportList[0, rcont].Value = false;
                        dgvReportList[1, rcont].Value = spcList[rcont].result_id.ToString();
                        dgvReportList[2, rcont].Value = spcList[rcont].ReportGroup.ReportSection.ReportSectionTitle.ToString();
                        dgvReportList[3, rcont].Value = spcList[rcont].ReportGroup.ReportGroupTitle.ToString();
                        dgvReportList[4, rcont].Value = spcList[rcont].ReportGroup.ReportGroupID;
                        dgvReportList[5, rcont].Value = spcList[rcont].TestTitle;

                    }
                    dgvReportList.Rows[0].Cells[0].Selected = false;
                    // AddCheckBoxHeader();

                }

                spcList.Clear();
                spcList = drsClient.GetAllReport(txtMoneyRecipt.Text).ToList();
                LoadDetailsByResultId(spcList);
                if (spcList.Count > 0)
                {
                    for (int cnt = 0; cnt < spcList.Count; cnt++)
                    {
                        dgvAllTestList.Rows.Add();
                        dgvAllTestList[0, cnt].Value = spcList[cnt].SpecimenCollectionID;
                        dgvAllTestList[1, cnt].Value = spcList[cnt].ReportGroup.ReportSection.ReportSectionTitle.ToString();
                        dgvAllTestList[2, cnt].Value = spcList[cnt].ReportGroup.ReportGroupTitle.ToString();
                        dgvAllTestList[3, cnt].Value = spcList[cnt].TestTitle;
                    }
                    dgvAllTestList.Rows[0].Cells[0].Selected = false;
                    ColourGrid();
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

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox headerBox = ((CheckBox)dgvReportList.Controls.Find("checkboxHeader", true)[0]);

            if (headerBox.Checked == true)
            {               
                for (int i = 0; i < dgvReportList.RowCount; i++)
                {
                    dgvReportList.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvReportList.RowCount; i++)
                {
                    dgvReportList.Rows[i].Cells[0].Value = false;
                }
            }  
        }
        private void LoadDetailsByResultId(List<SpecimenCollection> oDMr)
        {
            for (int i = 0; i < oDMr.Count;)
            {
                txtPatientName.Text = oDMr[i].Patient.Name;
                txtHCN.Text = oDMr[i].Patient.HCN;
                AH.DUtility.Age age = Utility.CalculateAge(oDMr[i].Patient.DOB);
                txtAge.Text = Utility.GetAgeStr(Convert.ToInt16(age.Year), Convert.ToInt16(age.Month), Convert.ToInt16(age.Day), Convert.ToInt16(age.Hour));
                txtSex.Text = oDMr[i].Patient.Sex;
                return;
            }
         
        }
        private void lstOPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOPD.SelectedItems.Count > 0)
            {
                ListViewItem itm = lstOPD.SelectedItems[0];
                txtMoneyRecipt.Text = itm.SubItems[0].Text;
            }
        }

        private void dgvReportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 &&  e.RowIndex!=-1)
            {
                try
                {
                    for (int row = 0; row < dgvReportList.Rows.Count; row++)
                    {
                        if (Convert.ToBoolean(dgvReportList.Rows[row].Cells[0].Value) == true)
                        {
                            //  count++;
                            isCheckFlag = 1;
                            break;
                        }
                    }
                    if (isCheckFlag != 1)
                    {
                        MessageBox.Show("No report is selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DiagnosticReport oDiag = this.PopulateUpdateData();
                    string vrfy = drsClient.UpdatePrintFlag(oDiag);
                    if (vrfy == "1")
                    {
                        for (int i = 0; i < dgvReportList.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value) == true)
                            {
                                printReport(dgvReportList.Rows[i].Cells[4].Value.ToString(), dgvReportList.Rows[i].Cells[1].Value.ToString());
                            }
                        }
                        btnNew.PerformClick();
                        loadOPDMoneyRecepitList();
                    }
                    else
                    {
                        MessageBox.Show("There is an Error!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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

                //if (e.ColumnIndex == 5)
                //{
                //    for (int i = 0; i < dgvReportList.Rows.Count; i++)
                //    {
                //        if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value) == true)
                //        {
                //            printReport(dgvReportList.Rows[i].Cells[4].Value.ToString(), dgvReportList.Rows[i].Cells[1].Value.ToString());
                //        }
                //    }
                //}
            }
        }
        private void printReport(string ReportId, string resultId)
        {
            frmReportViewer vr = new frmReportViewer();
            if (ReportId == "0021")
            {
                vr.selector = ViewerSelector.StainReport;              
            }
            else if (ReportId == "0020")
            {
                vr.selector = ViewerSelector.multicolumn;
            }
            else
            {
                vr.selector = ViewerSelector.InvestigationReport ;    
            }
            vr.TransactionNo = resultId;
            vr.ViewReport();
        }
        string results = "";
        private DiagnosticReport PopulateUpdateData()
        {
            DiagnosticReport diag = new DiagnosticReport();

            results = "";
            for (int i = 0; i < dgvReportList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value )== true)
                {
                    results = results + dgvReportList.Rows[i].Cells[1].Value.ToString() + ";";
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
        int isCheckFlag = 0;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = 0; row < dgvReportList.Rows.Count; row++)
                {
                    if (Convert.ToBoolean(dgvReportList.Rows[row].Cells[0].Value) == true)
                    {
                        //  count++;
                        isCheckFlag = 1;
                    }
                }
                if (isCheckFlag != 1)
                {
                    MessageBox.Show("No report is selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DiagnosticReport oDiag = this.PopulateUpdateData();
                string vrfy = drsClient.UpdatePrintFlag(oDiag);
                if (vrfy == "1")
                {
                    for (int i = 0; i < dgvReportList.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value) == true)
                        {
                            printReport(dgvReportList.Rows[i].Cells[4].Value.ToString(), dgvReportList.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                    btnNew.PerformClick();
                    loadOPDMoneyRecepitList(); 
                }
                else
                {
                    MessageBox.Show("There is an Error!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
              dgvReportList.Rows.Clear();
              dgvAllTestList.Rows.Clear();
              //CheckBox headerBox = ((CheckBox)dgvReportList.Controls.Find("checkboxHeader", true)[0]);

              //if (headerBox.Checked == true)
              //{
              //    headerBox.Checked = false;
              //}
        }

        private void txtMoneyRecipt_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneyRecipt.Text != "" && txtMoneyRecipt.TextLength == 11)
            {
                btnPatientDetails.PerformClick();
            }
        }

        private void tvNursStnMoneyReceipt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvNursStnMoneyReceipt.SelectedNode.Parent != null)
            {
                txtMoneyRecipt.Text = tvNursStnMoneyReceipt.SelectedNode.Text.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadOPDMoneyRecepitList(); 
            tvNursStnMoneyReceipt.Nodes.Clear();
            List<AH.DUtility.NursingTree> ipdSpc = drsClient.GetIPDMRList().Select(c => new AH.DUtility.NursingTree { NursingStationID = c.NursingStationID, NursingStationTitle = c.NursingStationTitle, ReqID = c.ReqID }).ToList();
            Utility.PopulateTreeNursing(tvNursStnMoneyReceipt, ipdSpc);
        }

        private void dgvReportList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMoneyRecipt_Leave(object sender, EventArgs e)
        {
            txtMoneyRecipt.Text = txtMoneyRecipt.Text.ToUpper();
        }

    }
}

