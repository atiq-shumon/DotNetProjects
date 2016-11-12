using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDrugDose : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmDrugDose()
        {
            InitializeComponent();
        }

        private void cboHM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel14_Click(object sender, EventArgs e)
        {

        }

        private void FormatDataGridView(DataGridView dtv)
        {
            dtv.Height = 300;
            dtv.Width = 700;
            dtv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colDrugId = new DataGridViewTextBoxColumn();
            colDrugId.Name = "DRUGID";
            colDrugId.DataPropertyName = "DRUGID";
            colDrugId.Width = 0;
            colDrugId.Visible = false;
            dtv.Columns.Add(colDrugId);
            DataGridViewTextBoxColumn colDrugTitle = new DataGridViewTextBoxColumn();
            colDrugTitle.Name = "Drug Name";
            colDrugTitle.DataPropertyName = "DRUGNAME";
            colDrugTitle.Width = 200;
            colDrugTitle.Visible = true;
            dtv.Columns.Add(colDrugTitle);

            DataGridViewTextBoxColumn colCompanyID = new DataGridViewTextBoxColumn();
            colCompanyID.Name = "COMPANYID";
            colCompanyID.DataPropertyName = "COMPANYID";
            colCompanyID.Width = 0;
            colCompanyID.Visible = false;
            dtv.Columns.Add(colCompanyID);
            DataGridViewTextBoxColumn colCompanyTitle = new DataGridViewTextBoxColumn();
            colCompanyTitle.Name = "Company";
            colCompanyTitle.DataPropertyName = "COMPANYNAME";
            colCompanyTitle.Width = 150;
            colCompanyTitle.Visible = true;
            dtv.Columns.Add(colCompanyTitle);
            DataGridViewTextBoxColumn colGroupID = new DataGridViewTextBoxColumn();
            colGroupID.Name = "GROUPID";
            colGroupID.DataPropertyName = "GROUPID";
            colGroupID.Width = 0;
            colGroupID.Visible = false;
            dtv.Columns.Add(colGroupID);
            DataGridViewTextBoxColumn colGroupTitle = new DataGridViewTextBoxColumn();
            colGroupTitle.Name = "Group";
            colGroupTitle.DataPropertyName = "GROUPNAME";
            colGroupTitle.Width = 150;
            colGroupTitle.Visible = true;
            dtv.Columns.Add(colGroupTitle);
            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.Name = "TYPEID";
            colTypeID.DataPropertyName = "TYPEID";
            colTypeID.Width = 0;
            colTypeID.Visible = false;
            dtv.Columns.Add(colTypeID);
            DataGridViewTextBoxColumn colPackName = new DataGridViewTextBoxColumn();
            colPackName.Name = "Unit Pack";
            colPackName.DataPropertyName = "PACKNAME";
            colPackName.Width = 80;
            dtv.Columns.Add(colPackName);
            DataGridViewTextBoxColumn colUnitID = new DataGridViewTextBoxColumn();
            colUnitID.Name = "UNITID";
            colUnitID.DataPropertyName = "UNITID";
            colUnitID.Width = 0;
            colUnitID.Visible = false;
            dtv.Columns.Add(colUnitID);
            DataGridViewTextBoxColumn colUnitName = new DataGridViewTextBoxColumn();
            colUnitName.Name = "Unit";
            colUnitName.DataPropertyName = "UNITNAME";
            colUnitName.Width = 50;
            dtv.Columns.Add(colUnitName);

        }
        private void FormatData(DataGridView dtv)
        {
            dtv.ColumnHeadersVisible = true;
            dtv.AllowUserToAddRows = false;
            dtv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtv.AutoGenerateColumns = false;

            dtv.Columns[0].Name = "DRUGID";
            dtv.Columns[0].DataPropertyName = "DRUGID";
            dtv.Columns[0].Width = 0;
            dtv.Columns[0].Visible = false;
            dtv.Columns[0].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);

            dtv.Columns[1].Name = "DRUGNAME";
            dtv.Columns[1].DataPropertyName = "DRUGNAME";
            dtv.Columns[1].Width = 150;
            dtv.Columns[1].Visible = true;
            dtv.Columns[1].DefaultCellStyle.Font = new Font("Garamond", 10, FontStyle.Italic);



        }
        private void frmDrugDose_Load(object sender, EventArgs e)
        {
            
            cboDurationIndicator.ValueMember = "Key";
            cboDurationIndicator.DisplayMember = "Value";
            cboDurationIndicator.DataSource = new BindingSource(Utility.GetDurationIndicators(), null);

            cboHM.ValueMember = "Key";
            cboHM.DisplayMember = "Value";
            cboHM.DataSource = new BindingSource(Utility.GetMinuteGaps(), null);

            cboBeforeOrAfter.ValueMember = "Key";
            cboBeforeOrAfter.DisplayMember = "Value";
            cboBeforeOrAfter.DataSource = new BindingSource(Utility.GetPrefSuffTimes(), null);

            cboMeal.ValueMember = "Key";
            cboMeal.DisplayMember = "Value";
            cboMeal.DataSource = new BindingSource(Utility.GetMealNames(), null);



            cboRoute.ValueMember = "Key";
            cboRoute.DisplayMember = "Value";
            cboRoute.DataSource = new BindingSource(Utility.GetMedicineRoutes(), null);

            cboAgeGroup.ValueMember = "Key";
            cboAgeGroup.DisplayMember = "Value";
            cboAgeGroup.DataSource = new BindingSource(Utility.GetAgeGroups(),null);

            cboConsumption.ValueMember = "ID";
            cboConsumption.DisplayMember = "Name";
            cboConsumption.DataSource = phrSr.GetConsumption();

            txtDrugID.Select();
            FormatDataGridView(dgvDrugDose);
            //FormatData(dgvDrugDose);
            dgvDrugDose.Visible = false;

            txtDose.Text = "0+0+0";
            FormatGrid();
            LoadListView();

        }
        private void RefreshListBox()
        {
            txtDrugID.Text = string.Empty;
            txtDrugName.Text = string.Empty;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtDose" };
            Control control = Utility.ReqFieldValidator(this,vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvDrugDose, 1, txtDrugName.Text))
            {
                MessageBox.Show("This Drugs is already Added");
                RefreshListBox();
                return;
            }
            try
            {

                DrugDose mstr = this.populateDrugDose();
                short i = phrSr.SaveDrugDose(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnSave.Enabled = false;
                    btnNew.PerformClick();
                    txtDose.Text = "0 + 0 + 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private DrugDose populateDrugDose()
        {
            DrugDose dr = new DrugDose();
            dr.AgeGroup = cboAgeGroup.SelectedValue.ToString();
            dr.DoseStr = txtDose.Text;
            dr.MinUseDuration = int.Parse(txtMinUseDuration.Text);

            dr.RouteID = cboRoute.SelectedValue.ToString();
            dr.BeforeAfterMeal = char.Parse(cboBeforeOrAfter.SelectedValue.ToString());
            dr.MealTimeDuration = int.Parse(cboHM.SelectedValue.ToString());
            dr.MealID = char.Parse(cboMeal.SelectedValue.ToString());
            dr.DurationIndicator = char.Parse(cboDurationIndicator.SelectedValue.ToString());
            //dr.DoseConsQty = txtConsQty.Text;

            ConsumptionForm ocons = new ConsumptionForm();
            ocons.ID = cboConsumption.SelectedValue.ToString();
            ocons.ConsQty = float.Parse(txtConsQty.Text);
            dr.ConsumptionForm = ocons;

            DrugMaster dc = new DrugMaster();
            dc.ID = txtDrugID.Text;
            dr.DrugMaster = dc;

            


            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            dr.EntryParameter = ep;

            return dr;
        }
        private void FormatGrid()
        {
            lvDrugDose.CheckBoxes = false;
            lvDrugDose.Columns.Add("DrugID", 80, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DrugName", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("AgeGroup", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("AgeGroupName", 80, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("Dose", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("Route", 80, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("RouteName", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("BeforeAfterMeal", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("BeforeAfterMealName", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealTimeDuration", 50, HorizontalAlignment.Left);
            //lvDrugDose.Columns.Add("MealTimeDurationName", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealName", 100, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MinUseDuration", 80, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DurationIndicator", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DurationIndicatorName", 100, HorizontalAlignment.Left);

        }
        private void LoadListView()
        {
            lvDrugDose.Items.Clear();
            List<DrugDose> drdose = phrSr.GetDrugDose().ToList();
            int i = 0;
            foreach (DrugDose dr in drdose)
            {
                ListViewItem itm = new ListViewItem(dr.DrugMaster.ID);
                itm.SubItems.Add(dr.DrugMaster.Name);
                itm.SubItems.Add(dr.AgeGroup);
                itm.SubItems.Add(dr.AgeGroupName);
                itm.SubItems.Add(dr.DoseStr);
                itm.SubItems.Add(dr.RouteID);
                itm.SubItems.Add(dr.RouteName);
                itm.SubItems.Add(dr.BeforeAfterMeal.ToString());
                itm.SubItems.Add(dr.B_A_MealName);
                itm.SubItems.Add(dr.MealTimeDuration.ToString());
                
                itm.SubItems.Add(dr.MealID.ToString());
                itm.SubItems.Add(dr.MealName);
                itm.SubItems.Add(dr.MinUseDuration.ToString());
                itm.SubItems.Add(dr.DurationIndicator.ToString());
                itm.SubItems.Add(dr.Dur_Ind_Name);
                lvDrugDose.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDose" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {

                DrugDose mstr = this.populateDrugDose();
                short i = phrSr.UpdateDrugDose(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtDose.Text = "0 + 0 + 0";
                    //btnNew.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvDrugDose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugDose.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugDose.SelectedItems[0];
                txtDrugID.Text = itm.SubItems[0].Text;
                txtDrugName.Text = itm.SubItems[1].Text;
                cboAgeGroup.SelectedValue = itm.SubItems[2].Text;

                txtDose.Text = itm.SubItems[4].Text;
                cboRoute.SelectedValue = itm.SubItems[5].Text;

                cboBeforeOrAfter.SelectedValue = itm.SubItems[7].Text;

                cboHM.SelectedValue = itm.SubItems[9].Text;
                cboMeal.SelectedValue = itm.SubItems[10].Text;

                txtMinUseDuration.Text = itm.SubItems[12].Text;
                cboDurationIndicator.SelectedValue = itm.SubItems[13].Text;

            }
        }
        private void populateDataToGrid(DataGridView dtv, string drugname)
        {
            dtv.Visible = true;
            List<DrugMaster> list = new List<DrugMaster>();
            list.AddRange(phrSr.GetDrugMasterList(drugname).ToList());
            dgvDrugDose.DataSource = list.Select(data => new
            {
                DRUGID = data.ID,
                DRUGNAME = data.Name,
                COMPANYID = data.DrugCompany.ID,
                COMPANYNAME = data.DrugCompany.Name,
                GROUPID = data.DrugGroup.ID,
                GROUPNAME = data.DrugGroup.Name,
                TYPEID = data.DrugPackType.ID,
                PACKNAME = data.DrugPackType.Name,
                UNITID = data.DrugUnit.ID,
                UNITNAME = data.DrugUnit.Name
            }).ToList();
            this.dgvDrugDose.Focus();
        }
      


       

        private void dgvDrugDose_KeyPress(object sender, KeyPressEventArgs e)
        {
            setvaluesfromGrid(dgvDrugDose,sender);
        }
        private void setvaluesfromGrid(DataGridView dtv, object sender)
        {



            if (dtv.Rows.Count > 0)
            {
                int currentRow = dtv.CurrentRow.Index;
                   currentRow--;
                
                txtDrugID.Text = dtv["DRUGID", currentRow+1].Value.ToString();
                txtDrugName.Text = dtv["DRUG NAME", currentRow+1].Value.ToString();
                txtDrugCompany.Text = dtv["COMPANYID", currentRow+1].Value.ToString();
                txtDrugGroup.Text = dtv["GROUPID", currentRow+1].Value.ToString();
                txtDrugUnit.Text = dtv["UNITID", currentRow+1].Value.ToString();
                txtDrugPacket.Text = dtv["TYPEID", currentRow+1].Value.ToString();
                dtv.Visible = false;
                txtDrugID.Select();

            }
            else
            {
                dtv.Visible = false;
                txtDrugID.Select();
            }

        }

        private void txtDrugID_TextChanged(object sender, EventArgs e)
        {
            //txtDrugName.Text = string.Empty;
        }

        private void txtDose_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void txtDose_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtDose_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txtDose_Leave_1(object sender, EventArgs e)
        {
            if (!Utility.IsDosePatternValid(txtDose.Text))
            {
                MessageBox.Show("Invalid Dose Pattern,Pattern Format should be 1+1+1 !!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDose.Select();
                return;
            }   
        }

        private void smartLabel15_Click(object sender, EventArgs e)
        {

        }

        private void cboMeal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMinUseDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMinUseDuration.Text == "" && e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void txtDrugID_KeyDown_1(object sender, KeyEventArgs e)
        {
          
            int number2;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtDrugID.Text, out number2))
                {
                    txtDose.Select();
                }
                else
                {
            populateDataToGrid(dgvDrugDose, txtDrugID.Text);
            this.dgvDrugDose.Focus();
                }
                if (dgvDrugDose.Rows.Count == 0)
                {
                    dgvDrugDose.Visible = false;
                }
            }
            if (e.KeyCode == Keys.Down)
            {

                if (txtDrugID.Text.Length == 0)
                {
                    MessageBox.Show("Please Put a Valid Name", DUtility.Utility.MessageCaptionMsg, MessageBoxButtons.OK);
                    return;
                }
                populateDataToGrid(dgvDrugDose, txtDrugID.Text);
                dgvDrugDose.Focus();
                if (dgvDrugDose.RowCount == 0)
                {
                    txtDrugID.Text = "";
                    return;
                }

            }
        }

        private void dgvDrugDose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDrugDose.Rows[e.RowIndex];
                txtDrugID.Text = row.Cells["DRUGID"].Value.ToString();
                txtDrugName.Text = row.Cells["DRUG NAME"].Value.ToString();
                dgvDrugDose.Visible = false;
                txtDrugID.Select();
            }
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            dgvDrugDose.Visible = false;
        }

        private void smartLabel23_Click(object sender, EventArgs e)
        {

        }

        private void txtConsQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel4_Click(object sender, EventArgs e)
        {

        }

        private void cboConsumption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
