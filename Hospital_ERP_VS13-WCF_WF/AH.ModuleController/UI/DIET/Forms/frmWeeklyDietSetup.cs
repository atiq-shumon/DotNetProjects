using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.FNBSR;

namespace AH.ModuleController.UI.DIET.Forms
{
    public partial class frmWeeklyDietSetup : AH.Shared.UI.frmSmartFormStandard
    {
        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        public frmWeeklyDietSetup()
        {
            InitializeComponent();
        }



        private void FormaList()
        {
            lvwWeeklyDiet.CheckBoxes = false;
            lvwWeeklyDiet.Columns.Add("Diet ID", 80, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Diet Name", 300, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Day No", 0, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("DietType", 0, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Sub Menu", 0, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Diet Type", 200, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Day Name", 130, HorizontalAlignment.Left);
            lvwWeeklyDiet.Columns.Add("Day Time", 110, HorizontalAlignment.Left);
        }

        private void frmWeeklyDietSetup_Load(object sender, EventArgs e)
        {
            FormaList();
            cboDietTypeID.ValueMember = "key";
            cboDietTypeID.DisplayMember = "value";
            cboDietTypeID.DataSource = new BindingSource(fnbs.GetDietSubType(), null);
            mWeekSetup();
            LoadListView();
        }

        private void mWeekSetup()
        {
            comboSource.Add("", "--Select--");
            comboSource.Add("0", "Sunday");
            comboSource.Add("1", "Monday");
            comboSource.Add("2", "Tuesday");
            comboSource.Add("3", "Wednesday");
            comboSource.Add("4", "Thursday");
            comboSource.Add("5", "Friday");
            comboSource.Add("6", "Saturday");
            cboDayNo.DataSource = new BindingSource(comboSource, null);
            cboDayNo.DisplayMember = "Value";
            cboDayNo.ValueMember = "Key";
        }

        private void txtDietMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys.Return)
            {
                cboDayNo.Focus();
            }
        }

        private void cboDayNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDietTypeID.Focus();
            }
        }

        private void cboDietTypeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboSetMenuID.Focus();
            }
        }


        private void cboSetMenuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtTime.Focus();
            }
        }

        private void cboDietTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string where = "";

            if (cboDietTypeID.Text != "--Select--")
            {
                where = cboDietTypeID.SelectedValue.ToString();
                cboSetMenuID.ValueMember = "DietSubID";
                cboSetMenuID.DisplayMember = "DietSubMenuName";
                cboSetMenuID.DataSource = new BindingSource(fnbs.GetSubType(where), null);
            }

        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtDietMenu" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (cboDayNo.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboDayNo.Focus();
            }

            if (cboDietTypeID.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboDietTypeID.Focus();
            }

            return true;
        }


        private WeeklyDietSetup PopulateWeeklySetup()
        {
            WeeklyDietSetup objws = new WeeklyDietSetup();
            if (txtWeeklyDiet.Text != "")
            {
                objws.DietMenuID = txtWeeklyDiet.Text;
            }
            else
            {
                objws.DietMenuID = "";
            }

            
            if (txtDietMenu.Text != "")
            {
                objws.DietSubMenuName = txtDietMenu.Text;
            }
            else
            {
                objws.DietSubMenuName = "";
            }


            objws.WeekDayNo = cboDayNo.SelectedValue.ToString();
            objws.DietTypeID = cboDietTypeID.SelectedValue.ToString();
            objws.DietTime = txtTime.Text.ToString();

            if (cboSetMenuID.Text != "--Select--")
            {
            objws.WeeklyDietMenu = cboSetMenuID.SelectedValue.ToString();
            }
            else
            {
                objws.WeeklyDietMenu="";
            }
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objws.EntryParameter = ep;
            return objws;
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

                    WeeklyDietSetup objWk = this.PopulateWeeklySetup();
                    string strWk = fnbs.InsertWeeklyDietMenu(objWk);
                    if (strWk == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListView();
                        txtDietMenu.Text = "";
                       // cboSetMenuID.SelectedValue = 1;
                        cboDietTypeID.Text = "--Select--";
                        cboDayNo.Text = "--Select--";
                        txtDietMenu.Select();
                        txtDietMenu.Focus();
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


        private void LoadListView()
        {
            try
            {
                lvwWeeklyDiet.Items.Clear();
                List<WeeklyDietSetup> objSubType = fnbs.GetWeeklyDietSetup("").ToList();
                if (objSubType.Count > 0)
                {
                    foreach (WeeklyDietSetup objWs in objSubType)
                    {
                        ListViewItem itm = new ListViewItem(objWs.DietMenuID);
                        itm.SubItems.Add(objWs.WeeklyDietMenu);
                        itm.SubItems.Add(objWs.WeekDayNo);
                        itm.SubItems.Add(objWs.DietTypeID);
                        itm.SubItems.Add(objWs.DietSubID);
                        itm.SubItems.Add(objWs.DietTypeMenuName);
                        itm.SubItems.Add(objWs.WeekDayName);
                        itm.SubItems.Add(objWs.DietTime);
                        lvwWeeklyDiet.Items.Add(itm);

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

        private void lvwWeeklyDiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwWeeklyDiet.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwWeeklyDiet.SelectedItems[0];
                txtWeeklyDiet.Text = itm.SubItems[0].Text;
                txtDietMenu.Text = itm.SubItems[1].Text;
                cboDayNo.SelectedValue = itm.SubItems[2].Text;
                cboDietTypeID.SelectedValue = itm.SubItems[3].Text;
                cboSetMenuID.SelectedValue = itm.SubItems[4].Text;
                txtTime.Text  = itm.SubItems[7].Text;
                txtDietMenu.Select();
                txtDietMenu.Focus();

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
                WeeklyDietSetup objWk = this.PopulateWeeklySetup();
                string strWk = fnbs.UpdatetWeeklyDietMenu(objWk);
                if (strWk == "0")
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadListView();
                    txtDietMenu.Text = "";
                    txtWeeklyDiet.Text = "";
                    //cboSetMenuID.SelectedValue = 0;
                    //cboDietTypeID.SelectedValue = 1;
                    //cboDayNo.SelectedValue = 1;
                    txtDietMenu.Select();
                    txtDietMenu.Focus();
                    btnSave.Enabled = true;
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

        private void cboSetMenuID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnSave.Enabled)
                {
                    btnSave.Focus();
                }
                else
                {
                    btnEdit.Focus();
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtDietMenu.Focus();
        }











    }
}
