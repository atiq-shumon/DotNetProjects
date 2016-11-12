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
    public partial class frmWorkSheet : AH.Shared.UI.frmSmartFormStandard
    {   
        DRSSR.DRSWSClient drsSc = new DRSSR.DRSWSClient();     
        private string Rptgroup;
        public frmWorkSheet(string Rptgroup)
        {
            this.Rptgroup = Rptgroup;
            InitializeComponent();
        }

        private void frmWorkSheet_Load(object sender, EventArgs e)
        {        
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetDepartmentsetupDic(null, Utility.GetDeptGroupCode(Utility.DeptGroupCode.Ancillary))), null);

                cboDepartment.Text = lblDeptID.Text;
                cboDepartment.Enabled = false;
                cboDepartment.ForeColor = Color.Black;
                AddGridColumn(dgvReportList);
                txtMRNo.Focus(); 
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != "")
            {
                cboRptSection.DisplayMember = "Value";
                cboRptSection.ValueMember = "Key";
                cboRptSection.DataSource = new BindingSource(Utility.VerifyDic(drsSc.GetRptSecSetup(cboDepartment.SelectedValue.ToString())), null);
            }
        }


        private void cboRptSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRptSection.SelectedValue != "")
            {
                cboRptGroup.DisplayMember = "Value";
                cboRptGroup.ValueMember = "Key";
                cboRptGroup.DataSource = new BindingSource(drsSc.GetRptgrpDic(cboRptSection.SelectedValue.ToString()), null);
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
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            style.Font = new Font(dgvReportList.Font, FontStyle.Bold);

            return Deptcolumn;
        }
        private void AddGridColumn(DataGridView dgv)
        {
            //dgv.Columns.Add(CreateGridColumnchkFormat("CheckBox", "", 30, true, DataGridViewContentAlignment.MiddleCenter, false, false, "checkbox"));

            dgv.Columns.Add(FormatGrid("SectionID", "SectionID",0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("MrID", "Mr NO", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("PatientName", "Name", 110, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Age", "Age", 110, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Gender", "Gender",50, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("HCN", "HCN", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("reportSection", "ReportSection",100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("reportGroup", "ReportGroup", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("SampleID", "SampleID", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("Specimen", "Specimen", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("TestName", "TestName", 300, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
           // dgv.Columns.Add(CreateGridColumnButtonFormat("Report Print", "Print"));

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
        public DataGridViewButtonColumn CreateGridColumnButtonFormat(string name, string buttonText)
        {
            DataGridViewButtonColumn oButton = new DataGridViewButtonColumn();
            oButton.HeaderText = "Print";
            oButton.Name = name;
            oButton.Text = buttonText;
            oButton.UseColumnTextForButtonValue = true;
            return oButton;

        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vf = new List<string>() { "txtMRNo", "cboRptSection" };
                Control control = Utility.ReqFieldValidator(this, vf);
                if (control != null)
                {
                    MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return;
                }

                List<InvestigationReportRO> OList = new List<InvestigationReportRO>();
                OList.Clear();
                OList = drsSc.GetWorkSheetForUI(cboRptSection.SelectedValue.ToString(), txtMRNo.Text).ToList();
                dgvReportList.Rows.Clear();
                if (OList.Count > 0)
                {
                    for (int rcont = 0; rcont < OList.Count; rcont++)
                    {
                        dgvReportList.Rows.Add();
                        dgvReportList[0, rcont].Value = OList[rcont].ReportSectionID;
                        dgvReportList[1, rcont].Value = OList[rcont].MRNo;
                        dgvReportList[2, rcont].Value = OList[rcont].PatientName;
                        dgvReportList[3, rcont].Value = OList[rcont].Age;
                        dgvReportList[4, rcont].Value = OList[rcont].Sex;
                        dgvReportList[5, rcont].Value = OList[rcont].HCN;
                        dgvReportList[6, rcont].Value = OList[rcont].ReportSection;
                        dgvReportList[7, rcont].Value = OList[rcont].ReportGroup;
                        dgvReportList[8, rcont].Value = OList[rcont].SpecimenNo;
                        dgvReportList[9, rcont].Value = OList[rcont].Specimen;
                        dgvReportList[10, rcont].Value = OList[rcont].TestDetailID;

                    }
                    dgvReportList.Rows[0].Cells[0].Selected = false;
                }
                else
                {
                    MessageBox.Show("No record found !");
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
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox headerBox = ((CheckBox)dgvReportList.Controls.Find("checkboxHeader", true)[0]);

            if (headerBox.Checked == true)
            {
                for (int i = 0; i < dgvReportList.RowCount; i++)
                {
                    dgvReportList.Rows[i].Cells[0].Value = headerBox.Checked ;
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
        int isCheckFlag;
        private void dgvReportList_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
            //if (e.ColumnIndex == 11 && e.RowIndex!=-1)
            //{
            //    isCheckFlag = 0;
            //    for (int row = 0; row < dgvReportList.Rows.Count; row++)
            //    {
            //        if (Convert.ToBoolean(dgvReportList.Rows[row].Cells[0].Value) == true)
            //        {
            //            isCheckFlag = 1;
            //            break;
            //        }
            //    }
            //    if (isCheckFlag != 1)
            //    {
            //        MessageBox.Show("No report is selected", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    try
            //    {
            //        for (int i = 0; i < dgvReportList.Rows.Count; i++)
            //        {
            //            if (Convert.ToBoolean(dgvReportList.Rows[i].Cells[0].Value) == true)
            //            {
            //                printWorkSheet(dgvReportList.Rows[i].Cells[1].Value.ToString(), cboRptGroup.SelectedValue.ToString());
                            
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
       
        }
   
        private void printWorkSheet(string moneyReceipt, string reportSecID)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.WorkSheet;
            vr.TransactionNo = moneyReceipt;
            vr.RptSectionID = reportSecID;        
            vr.ViewReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvReportList.Rows.Count > 0)
            {
                printWorkSheet(dgvReportList.Rows[0].Cells[1].Value.ToString(), dgvReportList.Rows[0].Cells[0].Value.ToString());
            }
        }

        private void txtMRNo_Leave(object sender, EventArgs e)
        {
            txtMRNo.Text = txtMRNo.Text.ToUpper();
        }

    }
}
