using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.FNBSR;
using AH.DUtility;

namespace AH.ModuleController.UI.FNB.Forms
{
    public partial class frmWeeklySetmenu : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        List<WeeklySetupMeal> Io;

        public frmWeeklySetmenu()
        {
            InitializeComponent();
        }

        private void mWeekSetup()
        {
            comboSource.Add("0", "Sunday");
            comboSource.Add("1", "Monday");
            comboSource.Add("2", "Tuesday");
            comboSource.Add("3", "Wednesday");
            comboSource.Add("4", "Thursday");
            comboSource.Add("5", "Friday");
            comboSource.Add("6", "Saturday");
            cboWeeksetup.DataSource = new BindingSource(comboSource, null);
            cboWeeksetup.DisplayMember = "Value";
            cboWeeksetup.ValueMember = "Key";
        }
        private void FormaList()
        {
            lvwWeekSetup.CheckBoxes = false;
            lvwWeekSetup.Columns.Add("Week Day", 0, HorizontalAlignment.Left);
            //lvwWeekSetup.Columns.Add("Start Date", 400, HorizontalAlignment.Center);
            //lvwWeekSetup.Columns.Add("End Date", 400, HorizontalAlignment.Center);
            lvwWeekSetup.Columns.Add("Set Menu ID", 250, HorizontalAlignment.Left);
            lvwWeekSetup.Columns.Add("Type ID", 0, HorizontalAlignment.Left);
            lvwWeekSetup.Columns.Add("Type Name", 250, HorizontalAlignment.Left);
            lvwWeekSetup.Columns.Add("Meal ID", 0, HorizontalAlignment.Left);
            lvwWeekSetup.Columns.Add("Meal Name", 250, HorizontalAlignment.Left);
           
          

           
        }
        private void frmWeeklySetmenu_Load(object sender, EventArgs e)
        {
            try
            {
                mWeekSetup();
                FormaList();
                cbomealId.DataSource = new BindingSource(fnbs.LoadWeeklyMealSetup(), null);
                cbomealId.DisplayMember = "value";
                cbomealId.ValueMember = "Key";

                cboSetmenuTypeID.DataSource = fnbs.LaodWeeklySetMenuType().ToList();
                cboSetmenuTypeID.ValueMember = "WeeklySetMenuTypeID";
                cboSetmenuTypeID.DisplayMember = "WeeklySetMenuTypeName";


                cboMenuId.ValueMember = "Key";
                cboMenuId.DisplayMember = "Value";
                cboMenuId.DataSource = new BindingSource(fnbs.GetFoodMenuItemSetup(), null);


                LoadListView();
                cboSetmenuTypeID.Focus();
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
        private bool ValidateFields()
        {

            if (cboWeeksetup.Text == "")
            {
                MessageBox.Show("Cannot Empty");
                cboWeeksetup.Focus();
                return false;
            }
            if (cbomealId.Text == "")
            {
                MessageBox.Show("Cannot Empty");
                cbomealId.Focus();
                return false;
            }

            return true;
        }

        private WeeklySetupMeal Populateweeklysetup()
        {

            WeeklySetupMeal objweekly = new WeeklySetupMeal();

            objweekly.SetMenuID = txtOldSetmenuID.Text;
            objweekly.WeeklySetMenuTypeID = cboSetmenuTypeID.SelectedValue.ToString();
            //objweekly.StartDate = dteStartDate.Text;
            //objweekly.EndDate = dteEndDate.Text;
            //objweekly.setmenyy
            objweekly.WeekDayNo = cboWeeksetup.SelectedValue.ToString();
            objweekly.MealID = cbomealId.SelectedValue.ToString();
            objweekly.SetMenuID = cboMenuId.SelectedValue.ToString();

            objweekly.OldWeekDayNo  = txtOldWdayNo.Text.ToString();
            objweekly.OldMealID = txtOldMealID.Text.ToString();
            objweekly.OldSetMenuID  = txtOldSetmenuID.Text.ToString();
            objweekly.OldSetMenuTypeID  = txtOldFoodMenuID.Text.ToString();



            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objweekly.EntryParameter = ep;
            return objweekly;
        }
        private void LoadListView()
        {
            try
            {
                lvwWeekSetup.Items.Clear();
                Io = fnbs.GetWeeklyMealSetup().ToList();
                if (Io.Count > 0)
                {
                    foreach (WeeklySetupMeal objws in Io)
                    {
                        ListViewItem itm = new ListViewItem(objws.WeekDayNo);
                        itm.SubItems.Add(objws.SetMenuID);
                        itm.SubItems.Add(objws.WeeklySetMenuTypeID);
                        itm.SubItems.Add(objws.WeeklySetMenuTypeName);
                        itm.SubItems.Add(objws.MealID);
                        itm.SubItems.Add(objws.MealName);
                        lvwWeekSetup.Items.Add(itm);
                    }
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    WeeklySetupMeal objWs = this.Populateweeklysetup();
                    short i = fnbs.InsertWeeklysetup(objWs);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {

                        LoadListView();
                        btnNew.PerformClick();
                    }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    WeeklySetupMeal objWs = this.Populateweeklysetup();
                    short i = fnbs.UpdateWeeklysetup(objWs);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        LoadListView();
                        btnNew.PerformClick();
                    }
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

        private void lvwWeekSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwWeekSetup.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwWeekSetup.SelectedItems[0];
                cboWeeksetup.SelectedValue = itm.SubItems[0].Text;
                txtOldWdayNo.Text = itm.SubItems[0].Text;

                cbomealId.SelectedValue = itm.SubItems[4].Text;
                txtOldMealID.Text = itm.SubItems[4].Text;

                txtOldFoodMenuID.Text = itm.SubItems[1].Text;
                cboMenuId.SelectedValue = itm.SubItems[1].Text;

                txtOldSetmenuID.Text = itm.SubItems[2].Text;
                cboSetmenuTypeID.SelectedValue = itm.SubItems[2].Text;
                
                cboSetmenuTypeID.Focus();

            }
        }

        private void cboSetmenuTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
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
            actual = this.cboSetmenuTypeID.Text;

            // Find the first match for the typed value.
            index = this.cboSetmenuTypeID.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboSetmenuTypeID.Items[index].ToString();

                // Select this item from the list.
                this.cboSetmenuTypeID.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboSetmenuTypeID.SelectionStart = actual.Length;
                this.cboSetmenuTypeID.SelectionLength = found.Length;
            }
        }

        private void cboWeeksetup_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
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
            actual = this.cboWeeksetup.Text;

            // Find the first match for the typed value.
            index = this.cboWeeksetup.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboWeeksetup.Items[index].ToString();

                // Select this item from the list.
                this.cboWeeksetup.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboWeeksetup.SelectionStart = actual.Length;
                this.cboWeeksetup.SelectionLength = found.Length;
            }
        }

        private void cbomealId_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
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
            actual = this.cbomealId.Text;

            // Find the first match for the typed value.
            index = this.cbomealId.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cbomealId.Items[index].ToString();

                // Select this item from the list.
                this.cbomealId.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cbomealId.SelectionStart = actual.Length;
                this.cbomealId.SelectionLength = found.Length;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;

        }

        private void cboMenuId_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
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
            actual = this.cboMenuId.Text;

            // Find the first match for the typed value.
            index = this.cboMenuId.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.cboMenuId.Items[index].ToString();

                // Select this item from the list.
                this.cboMenuId.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.cboMenuId.SelectionStart = actual.Length;
                this.cboMenuId.SelectionLength = found.Length;
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmfoodMenutype objfrm = new frmfoodMenutype();
            objfrm.ShowDialog();
        }

        private void btnTypeRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cboSetmenuTypeID.DataSource = fnbs.LaodWeeklySetMenuType().ToList();
                cboSetmenuTypeID.ValueMember = "WeeklySetMenuTypeID";
                cboSetmenuTypeID.DisplayMember = "WeeklySetMenuTypeName";
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

        private void btnMealID_Click(object sender, EventArgs e)
        {
            frmMealSetupConfig objfrm = new frmMealSetupConfig();
            objfrm.ShowDialog();
        }

        private void btnFoodRefMeal_Click(object sender, EventArgs e)
        {
            cbomealId.DataSource = new BindingSource(fnbs.LoadWeeklyMealSetup(), null);
            cbomealId.DisplayMember = "value";
            cbomealId.ValueMember = "Key";
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            frmFoodMenuSetup objFrm = new frmFoodMenuSetup();
            objFrm.ShowDialog();
        }

        private void btnRefFoodMneu_Click(object sender, EventArgs e)
        {
            try
            {
                cboMenuId.ValueMember = "Key";
                cboMenuId.DisplayMember = "Value";
                cboMenuId.DataSource = new BindingSource(fnbs.GetFoodMenuItemSetup(), null);
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (cboWeeksetup.Text.ToString() != "--Select--" && cboWeeksetup.Text.ToString() != "" && cbomealId.SelectedValue.ToString() != "--Select--" && cbomealId.Text.ToString() != "")
            {
                lvwWeekSetup.Items.Clear();
                //SearchListView(Io, cboWeeksetup.SelectedValue.ToString());
                List<WeeklySetupMeal> WS = fnbs.GetWeeklyDayMeal(cboWeeksetup.SelectedValue.ToString(), cbomealId.SelectedValue.ToString()).ToList();
                foreach (WeeklySetupMeal objws in WS)
                {
                    ListViewItem itm = new ListViewItem(objws.WeekDayNo);
                    itm.SubItems.Add(objws.SetMenuID);
                    itm.SubItems.Add(objws.WeeklySetMenuTypeID);
                    itm.SubItems.Add(objws.WeeklySetMenuTypeName);
                    itm.SubItems.Add(objws.MealID);
                    itm.SubItems.Add(objws.MealName);
                    lvwWeekSetup.Items.Add(itm);
                }
            }
        }
        private void SearchListView(IEnumerable<WeeklySetupMeal> tests, string searchString = "")
        {
            IEnumerable<WeeklySetupMeal> query;
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.WeekDayNo.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         
                         select test);

            }
            if (Io.Count > 0)
            {
                lvwWeekSetup.Items.Clear();
                foreach (WeeklySetupMeal objws in query)
                {
                    ListViewItem itm = new ListViewItem(objws.WeekDayNo);
                    itm.SubItems.Add(objws.SetMenuID);
                    itm.SubItems.Add(objws.WeeklySetMenuTypeID);
                    itm.SubItems.Add(objws.WeeklySetMenuTypeName);
                    itm.SubItems.Add(objws.MealID);
                    itm.SubItems.Add(objws.MealName);
                    lvwWeekSetup.Items.Add(itm);
                }
            }
        }



    }
}
