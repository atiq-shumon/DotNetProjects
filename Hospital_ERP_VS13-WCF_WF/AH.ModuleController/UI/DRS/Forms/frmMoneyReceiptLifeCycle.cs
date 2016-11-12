using AH.DUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.DRSSR;
using System.Linq;
using AH.ModuleController.UI.DRS.Reports.Viewer;

namespace AH.ModuleController.UI.DRS.Forms
{
    public partial class frmMoneyReceiptLifeCycle : AH.Shared.UI.frmSmartFormStandard
    {   
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();     
        private string Rptgroup;
        private string mrID;
        public frmMoneyReceiptLifeCycle(string mrID)
        {         
            InitializeComponent();
            this.mrID = mrID;
        }

        private void frmWorkSheet_Load(object sender, EventArgs e)
        {        
                AddGridColumn(dgvReportList);
                if (mrID!="D")
                {
                    txtMoneyRecipt.Text
                        = mrID;
                }
                txtMoneyRecipt.Focus();
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
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvReportList.Font, FontStyle.Bold);
            Deptcolumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            return Deptcolumn;
        }
        private void AddGridColumn(DataGridView dgv)
        {           
            dgv.Columns.Add(FormatGrid("reportGroup", "ReportGroup", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("TestName", "TestName", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Billing", "Billing", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("SampleID", "SampleID", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            //dgv.Columns.Add(FormatGrid("StikerPrint", "Stiker Print", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("SCollected", "S. Collected", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("SReceived", "S. Received", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ResultEntry", "Result Entry", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ResultVerify", "Result Verify", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ResultFinalized", "Result Finalized",150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ResultPrinted", "Result Printed",150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ResultrePrinted", "Result Re-Printed",150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportID", "ReportID", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));

            dgv.Columns.Add(FormatGrid("IsSampleCancel", "IsCancel",50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("SampleCancelBY", "Cancel By", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
   
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
  
     

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "txtMoneyRecipt" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }
                if (drsSc.verifyMrno(txtMoneyRecipt.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoneyRecipt.Select();
                    btnNew.PerformClick();
                    return;
                }
                List<InvestigationReportRO> OList = new List<InvestigationReportRO>();
                OList.Clear();
                OList = drsSc.MoneyReceiptLifeCycle(txtMoneyRecipt.Text).ToList();
                dgvReportList.Rows.Clear();
                if (OList.Count > 0)
                {
                    for (int rcont = 0; rcont < OList.Count; rcont++)
                    {
                        txtPatientName.Text = OList[rcont].PatientName;
                        txtAge.Text = OList[rcont].Age;
                        txtHCN.Text = OList[rcont].HCN;
                        txtSex.Text = OList[rcont].Sex;                    
                        dgvReportList.Rows.Add();
                  
                        dgvReportList[0, rcont].Value = OList[rcont].ReportGroup;                     
                        dgvReportList[1, rcont].Value = OList[rcont].TestDetailID;
                        dgvReportList[2, rcont].Value = OList[rcont].MREntryBy;// +"\r\n" + OList[rcont].MREntryDate;
                        dgvReportList[3, rcont].Value = OList[rcont].SpecimenNo;
                        dgvReportList[4, rcont].Value = OList[rcont].SampleCollected;
                        dgvReportList[5, rcont].Value = OList[rcont].SampleReceivedBy ;
                        dgvReportList[6, rcont].Value = OList[rcont].ResultEntryBy;
                        dgvReportList[7, rcont].Value = OList[rcont].VerifiedBy;
                        dgvReportList[8, rcont].Value = OList[rcont].EntryBy;
                        dgvReportList[9, rcont].Value = OList[rcont].PrintedBY;
                        dgvReportList[10, rcont].Value = OList[rcont].RePrintedBY;
                        dgvReportList[11, rcont].Value = OList[rcont].result_id;
                        if(OList[rcont].IsCancel.ToString()=="0")
                        {
                            dgvReportList[12, rcont].Value ="NO";
                        }
                        else
                        {
                            dgvReportList[12, rcont].Value = "Yes";
                        }
                      
                        dgvReportList[13, rcont].Value = OList[rcont].CancelBy;

                    }
                    dgvReportList.Rows[0].Cells[0].Selected = false;
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
   
        private void printWorkSheet(string moneyReceipt, string reportGrpID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.WorkSheet;
            vr.TransactionNo = moneyReceipt;
            vr.RptGroupID = reportGrpID;        
            vr.ViewReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvReportList.Rows.Clear();
        }

        private void txtMoneyRecipt_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnPatientSearch.Text.Length == Utility.ScanLength)
            {
                btnPatientSearch_Click(sender, e);
            }
        }

        private void txtMoneyRecipt_Leave(object sender, EventArgs e)
        {
            txtMoneyRecipt.Text = txtMoneyRecipt.Text.ToUpper();
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvReportList[column, row];
            DataGridViewCell cell2 = dgvReportList[column, row - 1];
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
        private void dgvReportList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            switch (e.ColumnIndex)
            {
                case 0:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 1:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 2:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 3:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 4:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 5:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 6:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 7:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 8:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 9:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 11:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;
                case 12:
                    if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    }
                    else
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
                    break;

                default:
                    {
                        e.AdvancedBorderStyle.Top = dgvReportList.AdvancedCellBorderStyle.Top;
                        break;
                    }
                    if (dgvReportList.Rows.Count == e.RowIndex + 1)
                    {
                        //  e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
                        e.AdvancedBorderStyle.Bottom = dgvReportList.AdvancedCellBorderStyle.Top;
                    }
            }
        }

        private void dgvReportList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
          
            switch (e.ColumnIndex)
            {
                case 0:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 1:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 2:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 3:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 4:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 5:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 6:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 7:
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
                case 9:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 11:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;
                case 12:
                    if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                    break;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMoneyRecipt_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneyRecipt.Text != "" && txtMoneyRecipt.TextLength == 11)
            {
                txtMoneyRecipt.Text = txtMoneyRecipt.Text.ToUpper();
                btnPatientSearch.PerformClick();
            }
        }

    }
}
