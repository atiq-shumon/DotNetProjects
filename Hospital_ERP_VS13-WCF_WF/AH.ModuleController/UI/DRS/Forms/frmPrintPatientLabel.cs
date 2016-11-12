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
    public partial class frmPrintPatientLabel : AH.Shared.UI.frmSmartFormStandard
    {
        DRSSR.DRSWSClient drsClient = new DRSSR.DRSWSClient();

        public frmPrintPatientLabel()
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
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvReportList.Font, FontStyle.Bold);

            return Deptcolumn;
        }
        private void AddGridColumn(DataGridView dgv)
        {
            dgv.Columns.Add(CreateGridColumnchkFormat("CheckBox", "",30, true, DataGridViewContentAlignment.MiddleCenter, false, false, "checkbox"));
            dgv.Columns.Add(FormatGrid("HCN", "HCN", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("PatientName", "PatientName", 120, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Age", "Age", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Gender", "Gender", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportGrpId", "Report Group", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ReportGroup", "Report Group", 170, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Date", "Date", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
       
            dgv.Columns.Add(CreateGridColumnButtonFormat("Report Print","Print"));
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
    
        private void frmReportPrintInterface_Load(object sender, EventArgs e)
        {
            AddGridColumn(dgvReportList);        
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (drsClient.verifyMrno(txtMoneyRecipt.Text) == "0")
                {
                    MessageBox.Show(Utility.GetMsg(Utility.Msg.ValidMRNo), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoneyRecipt.Select();
                    return;
                }

                dgvReportList.Rows.Clear();
                List<DiagnosticReport> drs = new List<DiagnosticReport>();
                drs = drsClient.PatientListForLabelPrint(txtMoneyRecipt.Text).ToList();

                if (drs.Count > 0)
                {
                    for (int rcont = 0; rcont < drs.Count; rcont++)
                    {
                        dgvReportList.Rows.Add();
                        dgvReportList[0, rcont].Value = false;
                        dgvReportList[1, rcont].Value = drs[rcont].Patient.HCN.ToString();
                        dgvReportList[2, rcont].Value = drs[rcont].Patient.Name;
                        dgvReportList[3, rcont].Value = drs[rcont].Age;
                        dgvReportList[4, rcont].Value = drs[rcont].Patient.Sex;
                        dgvReportList[5, rcont].Value = drs[rcont].ReportGroup.ReportGroupID;
                        dgvReportList[6, rcont].Value = drs[rcont].ReportGroup.ReportGroupTitle;
                        dgvReportList[7, rcont].Value = drs[rcont].EntryParameter.EntryDate;

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

        int isCheckFlag;
        private void dgvReportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                try
                {
                    for (int row = 0; row < dgvReportList.Rows.Count; row++)
                    {
                        if (Convert.ToBoolean(dgvReportList.Rows[row].Cells[0].Value) == true)
                        {                           
                            isCheckFlag = 1;
                            break;
                        }
                    }
                    if (isCheckFlag != 1)
                    {
                        MessageBox.Show("No report is selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    for (int i = 0; i < dgvReportList.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value) == true)
                        {
                            printReport(txtMoneyRecipt.Text, dgvReportList.Rows[i].Cells[5].Value.ToString());
                        }
                    }
                   // btnNew.PerformClick();     
                                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              
            }
        }
        private void printReport(string mrID, string reportGroupID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.printPatientLabel;
            vr.TransactionNo = mrID;
            vr.RptGroupID = reportGroupID;
            vr.ViewReport();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvReportList.Rows.Clear();
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

