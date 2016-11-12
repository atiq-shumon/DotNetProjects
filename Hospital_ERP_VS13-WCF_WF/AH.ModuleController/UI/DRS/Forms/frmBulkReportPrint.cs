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
    public partial class frmBulkReportPrint : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();
       
        public frmBulkReportPrint()
        {
            InitializeComponent();
          
        }

        private void frmBulkReportPrint_Load(object sender, EventArgs e)
        {
            
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsClient.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);

                cboDepartment.Text = lblDeptID.Text;
                cboDepartment.Enabled = false;
                //cboDepartment.BackColor = Color.White;
                //cboDepartment.ForeColor = Color.DarkBlue;
                AddGridColumn(dgvReportList);
         
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboRptSection.DisplayMember = "Value";
                cboRptSection.ValueMember = "Key";
                cboRptSection.DataSource = new BindingSource(Utility.VerifyDic(drsClient.GetRptSecSetup(cboDepartment.SelectedValue.ToString())), null);
            }
        }

        private void cboRptSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRptSection.SelectedValue != "")
            {
                cboRptGroup.DisplayMember = "Value";
                cboRptGroup.ValueMember = "Key";
                cboRptGroup.DataSource = new BindingSource(drsClient.GetRptgrpDic(cboRptSection.SelectedValue.ToString()), null);
            }
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
            //dgv.Columns.Add(CreateGridColumnchkFormat("CheckBox", "",30, true, DataGridViewContentAlignment.BottomLeft, false, false, "checkbox")); 
            dgv.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("Hcn", "Hcn", 105, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("MoneyReceipt", "MoneyReceipt", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("ReportId", "ReportId", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("PatientName", "PatientName", 230, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("ReportSection", "ReportSection", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("ReportGroup", "ReportGroup", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));

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
        private void ColourGrid()
        {
            for(int i=0;i<dgvReportList.Rows.Count;i++)
            {
                if(i%2!=0)
                dgvReportList.Rows[i].DefaultCellStyle.BackColor = Color.LavenderBlush;
            }
        }
        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try//dgvReportList.Columns.Clear();
            {
                dgvReportList.Rows.Clear();
                List<SpecimenCollection> spcList = new List<SpecimenCollection>();
                spcList.Clear();
                if (cboRptGroup.SelectedValue != "" && cboRptSection.SelectedValue != "")
                    spcList = drsClient.BulkReportPrint(cboRptSection.SelectedValue.ToString(), cboRptGroup.SelectedValue.ToString(), dptStartDate.Value.ToString("dd-MM-yyyy"), dptEndDate.Value.ToString("dd-MM-yyyy")).ToList();

                for (int rcont = 0; rcont < spcList.Count; rcont++)
                {
                    dgvReportList.Rows.Add();
                    dgvReportList[0, rcont].Value = rcont + 1;
                    dgvReportList[1, rcont].Value = spcList[rcont].Patient.HCN.ToString();
                    dgvReportList[2, rcont].Value = spcList[rcont].DiagnosticMR.MRNo.ToString();
                    dgvReportList[3, rcont].Value = spcList[rcont].result_id.ToString();
                    dgvReportList[4, rcont].Value = spcList[rcont].Patient.Name.ToString();
                    dgvReportList[5, rcont].Value = spcList[rcont].ReportGroup.ReportSection.ReportSectionTitle.ToString();
                    dgvReportList[6, rcont].Value = spcList[rcont].ReportGroup.ReportGroupTitle.ToString();

                }
                dgvReportList.AllowUserToAddRows = false;
                ColourGrid();
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
        string results = "";
        private DiagnosticReport PopulateUpdateData()
        {
            DiagnosticReport diag = new DiagnosticReport();

            for (int i = 0; i < dgvReportList.Rows.Count; i++)
            {                        
                results = results + dgvReportList.Rows[i].Cells[3].Value.ToString() + ";";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReportList.Rows.Count > 0)
            {
                try
                {
                    DiagnosticReport oDiag = this.PopulateUpdateData();
                    string vrfy = drsClient.UpdatePrintFlag(oDiag);
                    if (vrfy == "1")
                    {
                        printReport(cboRptSection.SelectedValue.ToString(), cboRptGroup.SelectedValue.ToString(), dptStartDate.Value.ToString("dd-MM-yyyy"), dptEndDate.Value.ToString("dd-MM-yyyy"));
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

            }
            else
            {
                MessageBox.Show("There is no report to print !", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void printReport(string ReportSecId, string ReportId, string  StartDate, string  EndDate)
        {
            frmReportViewer vr = new frmReportViewer();      
            if(ReportId=="0021")
            {
                vr.selector = ViewerSelector.StainBulkReportPrint;
            }
            else if (ReportId == "0020")
            {
                vr.selector = ViewerSelector.CultureBulkReportPrint;
            }
            else
            {
                vr.selector = ViewerSelector.InvestBulkReportPrint;
            }         
            vr.RptSectionID = ReportSecId;
            vr.RptGroupID = ReportId;
            vr.ToDate=StartDate;
            vr.FromDate = EndDate;
            vr.ViewReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {          
            dgvReportList.Rows.Clear();
        }    
          
    }
}

