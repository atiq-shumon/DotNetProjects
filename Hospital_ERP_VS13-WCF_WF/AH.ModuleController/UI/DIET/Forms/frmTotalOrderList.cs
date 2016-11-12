using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.DIETSR;
using AH.ModuleController.UI.IPD.Forms;



namespace AH.ModuleController.UI.DIET.Forms
{
    public partial class frmTotalOrderList : AH.Shared.UI.frmSmartFormStandard
    {
        DIETSR.DIETWSClient dietSC = new DIETSR.DIETWSClient();
       
        public frmTotalOrderList()
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
            return Deptcolumn;
        }
        
        private void AddGridColumn()
        {       
            dgvPatientList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("NurseStation", "Nurse Station", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("DietTypeId", "DietTypeId", 0, false, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.Columns.Add(FormatGrid("DietType", "DietType", 220, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvPatientList.Columns.Add(FormatGrid("Total", " Total", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvPatientList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        private void AddGridFormat()
        {
            dgvTotalDietList.Columns.Add(FormatGrid("SL.", "SL.", 35, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvTotalDietList.Columns.Add(FormatGrid("DietType", "DietType", 250, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgvTotalDietList.Columns.Add(FormatGrid("Total", " Total", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
          //  dgvTotalDietList.Columns.Add(FormatGrid("OrderDateTime", " OrderDateTime", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgvTotalDietList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
       
        private void frmPatientList_Load(object sender, EventArgs e)
        {
           // AddGridColumn();
            PatientAdmissionUtility obj = new PatientAdmissionUtility();
            obj.cboReceivingNurseStation(cboReceivingNurseStation);

            cboMealType.DisplayMember = "MealName";
            cboMealType.ValueMember = "MealID";
            cboMealType.DataSource = dietSC.LoadmealSetup();
            AddGridFormat();

          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboReceivingNurseStation", "cboMealType" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            //dgvPatientList.Rows.Clear();
            //List<IPDDiet> patLists = new List<IPDDiet>();
            //patLists.Clear();
            //patLists = dietSC.GetTotalOrderList(dtpDate.Value, cboMealType.SelectedValue.ToString()).ToList();
            //if (patLists.Count > 0)
            //{
            //    for (int rcont = 0; rcont < patLists.Count; rcont++)
            //    {
            //        dgvPatientList.Rows.Add();
            //        dgvPatientList[0, rcont].Value = rcont + 1;
            //        dgvPatientList[1, rcont].Value = patLists[rcont].NurseStationTitle;
            //        dgvPatientList[2, rcont].Value = patLists[rcont].DietTypeID;
            //        dgvPatientList[3, rcont].Value = patLists[rcont].DietTypeTitle;
            //    }
            //}
            LoadAssignedDiet();
            //CheckedCheckBox();         
        }
        private void CheckedCheckBox()
        {
            for (int i = 0; i < dgvPatientList.Rows.Count; i++)
            {
                dgvPatientList.Rows[i].Cells[0].Value = true;
            }
        }
       
        private void LoadAssignedDiet()
        {
            List<IPDDiet> diets = new List<IPDDiet>();
            diets.Clear();
            diets = dietSC.Total(dtpDate.Value, cboMealType.SelectedValue.ToString()).ToList();
            //if (dgvPatientList.Rows.Count > 0)
            //{          
            //    diets.Clear();
            //    diets = dietSC.Total(dtpDate.Value,cboMealType.SelectedValue.ToString()).ToList();
            //    for (int rcont = 0; rcont < diets.Count; rcont++)
            //    {
            //        for (int r = 0; r < dgvPatientList.Rows.Count; r++)
            //        {
            //            if (dgvPatientList[2, r].Value.ToString() == diets[rcont].DietTypeID.ToString())
            //            {
            //                dgvPatientList[4, r].Value = diets[rcont].Total.ToString();                        
            //            }
            //        }
            //    }
            //}
            dgvTotalDietList.Rows.Clear();
            if (diets.Count > 0)
            {             
                for (int rcont = 0; rcont < diets.Count; rcont++)
                {
                    dgvTotalDietList.Rows.Add();
                    dgvTotalDietList[0, rcont].Value = rcont + 1;
                    dgvTotalDietList[1, rcont].Value = diets[rcont].DietTypeTitle;
                    dgvTotalDietList[2, rcont].Value = diets[rcont].Total.ToString();
                   // dgvTotalDietList[3, rcont].Value = diets[rcont].DietDateTime.ToString();
                }
            }
            else
            {
                MessageBox.Show("Order List Empty", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvTotalDietList.Rows.Clear();
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvPatientList[column, row];
            DataGridViewCell cell2 = dgvPatientList[column, row - 1];
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

        private void dgvPatientList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //  e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex < 0 || e.ColumnIndex < 0)
            //    return;
            //switch (e.ColumnIndex)
            //{
            //    case 1:
            //        if (e.RowIndex != 0 && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //        {
            //            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //        }
            //        else
            //        {
            //            e.AdvancedBorderStyle.Top = dgvPatientList.AdvancedCellBorderStyle.Top;
            //        }
            //        break;
            //    default:
            //        {
            //            e.AdvancedBorderStyle.Top = dgvPatientList.AdvancedCellBorderStyle.Top;
            //            break;
            //        }
            //        if (dgvPatientList.Rows.Count == e.RowIndex + 1)
            //        {
            //            //  e.AdvancedBorderStyle.Top = dgvSpecimenColl.AdvancedCellBorderStyle.Top;
            //            e.AdvancedBorderStyle.Bottom = dgvPatientList.AdvancedCellBorderStyle.Top;
            //        }
              
            //}
        }

        private void dgvPatientList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        //    if (e.RowIndex == 0)
        //        return;
          
        //    switch (e.ColumnIndex)
        //    {
        //        case 1:
        //            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        //            {
        //                e.Value = "";
        //                e.FormattingApplied = true;
        //            }
        //            break;
           
        //    }
        }
    }
}
