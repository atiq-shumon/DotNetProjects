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
    public partial class frmDrugMaster : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        List<DrugDose> drugDoses;
        List<DrugMaster> det;
        public frmDrugMaster()
        {
            InitializeComponent();
        }

        private void FormatGrid()
        {
            lvDrugMaster.CheckBoxes = false;
            lvDrugMaster.Columns.Add("ID",80,HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Brand Name", 380, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Drug NameBeng", 0, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Company", 250, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Generic Name", 280, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Dosage Form", 150, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Unit", 70, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("ReorderQuantity", 0, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("SerialPriority", 0, HorizontalAlignment.Left);
            lvDrugMaster.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            
        }
        private void LoadListView(string drugcompany)
        {
            lvDrugMaster.Items.Clear();

            if(drugcompany.Length != 0)
            {
                det = phrSr.GetDrugMasterByCompany(drugcompany).ToList();
            }
            
            int i = 0;

            foreach (DrugMaster dm in det)
            {
                ListViewItem itm = new ListViewItem(dm.ID);
                itm.SubItems.Add(dm.Name);
                itm.SubItems.Add(dm.NameBeng);
                itm.SubItems.Add(dm.DrugCompany.Name);
                itm.SubItems.Add(dm.DrugGroup.Name);
                itm.SubItems.Add(dm.DrugPackType.Name);
                itm.SubItems.Add(dm.DrugUnit.Name);
                itm.SubItems.Add(dm.ReorderQty.ToString());
                itm.SubItems.Add(dm.Priority.ToString());
                itm.SubItems.Add(dm.SerialPriority.ToString());
                itm.SubItems.Add(dm.Remarks);
                lvDrugMaster.Items.Add(itm);
            }

        }
        private void frmDrugMaster_Load(object sender, EventArgs e)
        {           
            cboDrugCompany.DisplayMember = "name";
            cboDrugCompany.ValueMember = "id";
            cboDrugCompany.DataSource = new BindingSource(phrSr.GetDrugCompanyDictionary(), null);

            cboDrugGroup.DisplayMember = "Value";
            cboDrugGroup.ValueMember = "Key";
            cboDrugGroup.DataSource = new BindingSource(phrSr.GetDrugGroupDic("D"), null);

            cboDrugUnit.DisplayMember = "Value";
            cboDrugUnit.ValueMember = "Key";
            cboDrugUnit.DataSource = new BindingSource(phrSr.GetDrugUnitDic("J"), null);

            cboDrugPacket.DisplayMember = "Value";
            cboDrugPacket.ValueMember = "Key";
            cboDrugPacket.DataSource = new BindingSource(phrSr.GetDrugPacketDic("P"), null);
           
            //////////////Drug Dose //////////////////////////////
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

            cboRoute.ValueMember = "ID";
            cboRoute.DisplayMember = "Name";
            cboRoute.DataSource = phrSr.GetDrugRoute();

            cboAgeGroup.ValueMember = "Key";
            cboAgeGroup.DisplayMember = "Value";
            cboAgeGroup.DataSource = new BindingSource(Utility.GetAgeGroups(), null);

            cboConsumption.ValueMember = "ID";
            cboConsumption.DisplayMember = "Name";
            cboConsumption.DataSource = phrSr.GetConsumption();
            //drugDoses = phrSr.GetDrugDose().ToList();
            FormatGrid();
            FormatGridView();
            txtDose.Text = "0+0+0";         
        }
        

        private void RefreshGrid()
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtName", "txtNameBeng", "txtReorderQty" };
            Control control = Utility.ReqFieldValidator(this,vf);
            
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvDrugMaster, 1, txtName.Text))
            {
                MessageBox.Show("This Item is already saved");                
                return;
            }

            if(lvDrugDose.Items.Count < 6)
            {
                MessageBox.Show("Please add Drug Dose");
                return;
            }
            try
            {
                DrugMaster mstr = this.populateDrugMaster();
                short i = phrSr.SaveDrugMaster(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    cboDrugCompany.Select();
                    txtName.Text = string.Empty;
                    txtNameBeng.Text = string.Empty;
                    lvDrugMaster.Items.Clear();
                    lvDrugDose.Items.Clear();
                    txtDose.Text = "0+0+0";
                    btnEdit.Enabled = false;                    
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
        private DrugMaster populateDrugMaster()
        {
            DrugMaster ms = new DrugMaster();
            ms.ID = txtDrugID.Text;
            ms.Name = txtName.Text;
            ms.NameBeng = txtNameBeng.Text;
            ms.Remarks = txtRemarks.Text;
            ms.ReorderQty = int.Parse(txtReorderQty.Text);
            //ms.StockQty = int.Parse(txtStockQty.Text);
            ms.Priority = 1;
            ms.SerialPriority = 1;
           

            DrugCompany dc = new DrugCompany();
            dc.ID = cboDrugCompany.SelectedValue.ToString();
            ms.DrugCompany = dc;

            DrugGroup dgr = new DrugGroup();
            dgr.ID = cboDrugGroup.SelectedValue.ToString();
            ms.DrugGroup = dgr;

            DrugUnit un = new DrugUnit();
            un.ID = cboDrugUnit.SelectedValue.ToString();
            ms.DrugUnit = un;

            DrugPackType pac = new DrugPackType();
            pac.ID = cboDrugPacket.SelectedValue.ToString();
            ms.DrugPackType = pac;

            string prString = "";
            foreach (ListViewItem itemRow in lvDrugDose.Items)
            {

                prString += itemRow.SubItems[0].Text + "," + itemRow.SubItems[1].Text + "," + itemRow.SubItems[2].Text + "," + itemRow.SubItems[3].Text + "," + itemRow.SubItems[4].Text + "," + itemRow.SubItems[5].Text + "," + itemRow.SubItems[6].Text + "," + itemRow.SubItems[7].Text + "," + itemRow.SubItems[8].Text + "," + itemRow.SubItems[9].Text ;
                prString += ";";
            }

            ms.DrugDoseString = prString;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ms.EntryParameter = ep;

            return ms;
        }

        private void cboDrugPacket_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboDrugPacket_Click(object sender, EventArgs e)
        {
                      
        }

        private void lvDrugMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugMaster.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugMaster.SelectedItems[0];
                txtDrugID.Text = itm.SubItems[0].Text;
                txtName.Text = itm.SubItems[1].Text;
                txtNameBeng.Text = itm.SubItems[2].Text;
                cboDrugCompany.Text = itm.SubItems[3].Text;
                cboDrugGroup.Text = itm.SubItems[4].Text;
                cboDrugPacket.Text = itm.SubItems[5].Text;
                cboDrugUnit.Text = itm.SubItems[6].Text;
                txtReorderQty.Text = itm.SubItems[7].Text;
                txtPriority.Text = itm.SubItems[8].Text;
                txtSerialPriority.Text = itm.SubItems[9].Text;
                txtRemarks.Text = itm.SubItems[10].Text;
                LoadListViewDrugs(itm.SubItems[0].Text);
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }
        private void LoadDrugDosse(string drugID)
        { 
          
        }

        private void smartLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtName", "txtNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                cboDrugCompany.Select();
                return;
            }
            try
            {
                DrugMaster mstr = this.populateDrugMaster();
                short i = phrSr.UpdateDrugMaster(mstr);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView(cboDrugCompany.SelectedValue.ToString());
                    drugDoses = phrSr.GetDrugDose().ToList();
                    cboDrugCompany.Select();
                    //btnNew.PerformClick();
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

        private void smartLabel9_Click(object sender, EventArgs e)
        {

        }

        private void smartNumericTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDose_TextChanged(object sender, EventArgs e)
        {

            
        }       

        private void smartLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtReorderQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtSerialPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void smartLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            frmDrugCompany ocompany = new frmDrugCompany();
            ocompany.ShowDialog();
        }

        private void btnCompanyRefresh_Click(object sender, EventArgs e)
        {
            cboDrugCompany.DisplayMember = "Value";
            cboDrugCompany.ValueMember = "Key";
            cboDrugCompany.DataSource = new BindingSource(phrSr.GetDrugCompDic("D"), null);
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmDrugUnit ounit = new frmDrugUnit();
            ounit.ShowDialog();
        }

        private void btnUnitRefresh_Click(object sender, EventArgs e)
        {
            cboDrugUnit.DisplayMember = "Value";
            cboDrugUnit.ValueMember = "Key";
            cboDrugUnit.DataSource = new BindingSource(phrSr.GetDrugUnitDic("J"), null);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmDrugPacketType otype = new frmDrugPacketType();
            otype.ShowDialog();
        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            cboDrugPacket.DisplayMember = "Value";
            cboDrugPacket.ValueMember = "Key";
            cboDrugPacket.DataSource = new BindingSource(phrSr.GetDrugPacketDic("P"), null);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            frmDrugGroupSetup ogrp = new frmDrugGroupSetup();
            ogrp.ShowDialog();
        }

        private void btnGroupRefresh_Click(object sender, EventArgs e)
        {
            cboDrugGroup.DisplayMember = "Value";
            cboDrugGroup.ValueMember = "Key";
            cboDrugGroup.DataSource = new BindingSource(phrSr.GetDrugGroupDic("D"), null);
        }

        private void frmLabel_Click(object sender, EventArgs e)
        {

        }
        private void FormatGridView()
        {
            lvDrugDose.CheckBoxes = false;
            //lvDrugDose.Columns.Add("DrugID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("AgeGroup",0,HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DoseID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("RouteID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("B/A-MealID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealTimeDurationID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MinUseDurationID", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DurationIndicatorID",0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("ConsQty", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("Consumption", 0, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("AgeGroupName", 150, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("Dose", 60, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("Route", 60, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("B/A-Meal", 90, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealTimeDuration", 80, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MealName", 60, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("MinUseDuration", 50, HorizontalAlignment.Left);
            lvDrugDose.Columns.Add("DurationIndicator", 100, HorizontalAlignment.Left);
        }
        private void LoadListDetails()
        {

            //lvDrugDose.Items.Clear();
            if (Utility.IsDuplicateFoundInList(lvDrugDose, 0, cboAgeGroup.SelectedValue.ToString()))
            {              
                    lvDrugDose.SelectedItems[0].SubItems[1].Text = txtDose.Text;
                    lvDrugDose.SelectedItems[0].SubItems[2].Text = cboRoute.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[3].Text = cboBeforeOrAfter.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[4].Text = cboHM.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[5].Text = cboMeal.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[6].Text = txtMinUseDuration.Text;
                    lvDrugDose.SelectedItems[0].SubItems[7].Text = cboDurationIndicator.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[8].Text = txtConsQty.Text;
                    lvDrugDose.SelectedItems[0].SubItems[9].Text = cboConsumption.SelectedValue.ToString();
                    lvDrugDose.SelectedItems[0].SubItems[11].Text = txtDose.Text;
                    lvDrugDose.SelectedItems[0].SubItems[12].Text = cboRoute.Text;
                    lvDrugDose.SelectedItems[0].SubItems[13].Text = cboBeforeOrAfter.Text;
                    lvDrugDose.SelectedItems[0].SubItems[14].Text = cboHM.Text;
                    lvDrugDose.SelectedItems[0].SubItems[15].Text = cboMeal.Text;
                    lvDrugDose.SelectedItems[0].SubItems[16].Text = txtMinUseDuration.Text;
                    lvDrugDose.SelectedItems[0].SubItems[17].Text = cboDurationIndicator.Text;               
            }
            else
            {
                ListViewItem itm = new ListViewItem(cboAgeGroup.SelectedValue.ToString());
                itm.SubItems.Add(txtDose.Text);
                itm.SubItems.Add(cboRoute.SelectedValue.ToString());
                itm.SubItems.Add(cboBeforeOrAfter.SelectedValue.ToString());
                itm.SubItems.Add(cboHM.SelectedValue.ToString());
                itm.SubItems.Add(cboMeal.SelectedValue.ToString());
                itm.SubItems.Add(txtMinUseDuration.Text);
                itm.SubItems.Add(cboDurationIndicator.SelectedValue.ToString());
                itm.SubItems.Add(txtConsQty.Text);
                itm.SubItems.Add(cboConsumption.SelectedValue.ToString());
                itm.SubItems.Add(cboAgeGroup.Text);
                itm.SubItems.Add(txtDose.Text);
                itm.SubItems.Add(cboRoute.Text);
                itm.SubItems.Add(cboBeforeOrAfter.Text);
                itm.SubItems.Add(cboHM.Text);
                itm.SubItems.Add(cboMeal.Text);
                itm.SubItems.Add(txtMinUseDuration.Text);
                itm.SubItems.Add(cboDurationIndicator.Text);
                lvDrugDose.Items.Add(itm);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboBeforeOrAfter", "cboMeal", "cboHM", "txtConsQty", "txtMinUseDuration", "cboDurationIndicator" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtMinUseDuration.Text))
            {
                MessageBox.Show("Please input Min use duration ");
                return;
            }
            if (string.IsNullOrEmpty(txtConsQty.Text))
            {
                MessageBox.Show("Please input ConsQty ");
                return;
            }
            if (!Utility.IsDosePatternValid(txtDose.Text))
            {
                MessageBox.Show("Invalid Dose Pattern,Pattern Format should be 1+1+1 !!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDose.Select();
                return;
            }           
             LoadListDetails();           
        }

         
        private void LoadListViewDrugs(string drugID)
        {
            lvDrugDose.Items.Clear();
            List<DrugDose> selectedDrugs = drugDoses.Where(c => c.DrugMaster.ID==drugID).ToList();
            int i = 0;
            foreach (DrugDose dr in selectedDrugs)
            {
                ListViewItem itm = new ListViewItem(dr.AgeGroup);
                //itm.SubItems.Add(dr.AgeGroup);
                itm.SubItems.Add(dr.DoseStr);
                itm.SubItems.Add(dr.RouteID);
                //itm.SubItems.Add(dr.RouteName);
                itm.SubItems.Add(dr.BeforeAfterMeal.ToString());
                //itm.SubItems.Add(dr.B_A_MealName);
                itm.SubItems.Add(dr.MealTimeDuration.ToString());
                itm.SubItems.Add(dr.MealID.ToString());
                itm.SubItems.Add(dr.MinUseDuration.ToString());
                itm.SubItems.Add(dr.DurationIndicator.ToString());
                //itm.SubItems.Add(dr.Dur_Ind_Name);
                itm.SubItems.Add(dr.ConsumptionForm.ConsQty.ToString());
                itm.SubItems.Add(dr.ConsumptionForm.ID);
                itm.SubItems.Add(dr.AgeGroupName);
                itm.SubItems.Add(dr.DoseStr);
                itm.SubItems.Add(dr.RouteName);
                itm.SubItems.Add(dr.B_A_MealName);
                itm.SubItems.Add(dr.M_T_DurationName);
                itm.SubItems.Add(dr.MealName);
                itm.SubItems.Add(dr.MinUseDuration.ToString());
                itm.SubItems.Add(dr.Dur_Ind_Name);
                lvDrugDose.Items.Add(itm);
            }
        }

        private void cboDrugCompany_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        
        private void txtDose_Leave(object sender, EventArgs e)
        {
                 
        }

        private void btnConsFormAdd_Click(object sender, EventArgs e)
        {
            frmConsumptionForm ocons = new frmConsumptionForm();
            ocons.ShowDialog();
        }

        private void btnConsFormRefresh_Click(object sender, EventArgs e)
        {
            cboConsumption.ValueMember = "ID";
            cboConsumption.DisplayMember = "Name";
            cboConsumption.DataSource = phrSr.GetConsumption();
        }

        private void lvDrugDose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrugDose.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrugDose.SelectedItems[0];
                cboAgeGroup.SelectedValue = itm.SubItems[0].Text;

                txtDose.Text = itm.SubItems[1].Text;
                cboRoute.SelectedValue = itm.SubItems[2].Text;

                cboBeforeOrAfter.SelectedValue = itm.SubItems[3].Text;

                cboHM.SelectedValue = itm.SubItems[4].Text;
                cboMeal.SelectedValue = itm.SubItems[5].Text;

                txtMinUseDuration.Text = itm.SubItems[6].Text;
                cboDurationIndicator.SelectedValue = itm.SubItems[7].Text;
                txtConsQty.Text = itm.SubItems[8].Text;
                cboConsumption.SelectedValue = itm.SubItems[9].Text;

            }
        }
        private void SearchListView(IEnumerable<DrugMaster> oResults, string searchString = "")
        {
            IEnumerable<DrugMaster> query;
            if (oResults != null)
            {
                if (!(searchString.Length > 0))
                {
                    query = oResults;
                }
                else
                {
                    query = (from oRes in oResults
                             where oRes.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                             select oRes);
                }
                lvDrugMaster.Items.Clear();
                foreach (DrugMaster dm in query)
                {
                    ListViewItem itm = new ListViewItem(dm.ID);
                    itm.SubItems.Add(dm.Name);
                    itm.SubItems.Add(dm.NameBeng);
                    itm.SubItems.Add(dm.DrugCompany.Name);
                    itm.SubItems.Add(dm.DrugGroup.Name);
                    itm.SubItems.Add(dm.DrugPackType.Name);
                    itm.SubItems.Add(dm.DrugUnit.Name);
                    itm.SubItems.Add(dm.ReorderQty.ToString());
                    itm.SubItems.Add(dm.Priority.ToString());
                    itm.SubItems.Add(dm.SerialPriority.ToString());
                    itm.SubItems.Add(dm.Remarks);
                    lvDrugMaster.Items.Add(itm);
                }
            }

        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(det, txtName.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDose.Text = "0+0+0";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            lvDrugMaster.Items.Clear();
            lvDrugDose.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cboDrugCompany.SelectedIndex != 0)
            {
                LoadListView(cboDrugCompany.SelectedValue.ToString());
                drugDoses = phrSr.GetDrugDose().ToList();
            }
        }

        private void cboDrugGroup_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) ||
                    (e.KeyCode == Keys.Left) ||
                    (e.KeyCode == Keys.Right) ||
                    (e.KeyCode == Keys.Up) ||
                    (e.KeyCode == Keys.Down) ||
                    (e.KeyCode == Keys.Delete) ||
                    (e.KeyCode == Keys.PageUp) ||
                    (e.KeyCode == Keys.PageDown) ||
                    (e.KeyCode == Keys.Home) ||
                    (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.cboDrugGroup.Text;

            // Find the first match for the typed value.
            index = this.cboDrugGroup.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboDrugGroup.Items[index].ToString();
                // Select this item from the list.
                //this.comboBox1.GetItemText(index);
                this.cboDrugGroup.SelectedIndex = cboDrugGroup.FindString(found);
                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboDrugGroup.SelectionStart = actual.Length;
                this.cboDrugGroup.SelectionLength = found.Length;

            }

        }

        private void btnRouteAdd_Click(object sender, EventArgs e)
        {
            frmDrugRouteSetup oroute = new frmDrugRouteSetup();
            oroute.ShowDialog();
        }

        private void btnRouteFormRefresh_Click(object sender, EventArgs e)
        {
            cboRoute.ValueMember = "ID";
            cboRoute.DisplayMember = "Name";
            cboRoute.DataSource = phrSr.GetDrugRoute();
        }

    }
}
