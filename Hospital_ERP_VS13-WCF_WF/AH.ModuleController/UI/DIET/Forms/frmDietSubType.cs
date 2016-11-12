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

    
    public partial class frmDietSubType : AH.Shared.UI.frmSmartFormStandard
    {

        FNBSR.FNBWSClient fnbs = new FNBSR.FNBWSClient();
        public frmDietSubType()
        {
            InitializeComponent();
        }

        private void frmDietSubType_Load(object sender, EventArgs e)
        {

            FormaList();
            cboDietType.ValueMember = "key";
            cboDietType.DisplayMember = "value";
            cboDietType.DataSource = new BindingSource(fnbs.GetDietSubType(), null);
            LoadListViewFood();
        }
        private bool ValidateFields()
        {

            List<string> vf = new List<string>() { "txtSubMenuName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            if (cboDietType.Text == "--Select--")
            {
                MessageBox.Show("Cannot Empty");
                cboDietType.Focus();
            }
            
            return true;
        }

        private void FormaList()
        {
            lvwSubItem.CheckBoxes = false;
            lvwSubItem.Columns.Add("Diet ID", 150, HorizontalAlignment.Left);
            lvwSubItem.Columns.Add("Name", 520, HorizontalAlignment.Left);
            lvwSubItem.Columns.Add("Diet Type", 0, HorizontalAlignment.Left);
            
        }
        private DietSubType PopulateDietType()
        {
            DietSubType objdt = new DietSubType();
            if (txtDietSubType.Text != "")
            {
                objdt.DietSubID = txtDietSubType.Text;
            }
            else
            {
                objdt.DietSubID = "";
            }
            objdt.DietTypeID = cboDietType.SelectedValue.ToString();
            objdt.DietSubTypeName = txtSubMenuName.Text; 
           
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objdt.EntryParameter = ep;
            return objdt;
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

                    DietSubType objDietType = this.PopulateDietType();
                    string  strDt = fnbs.SaveDietSubType(objDietType);
                    if (strDt == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListViewFood();
                        txtDietSubType.Text = "";
                        txtSubMenuName.Text = "";
                        txtDietSubType.Focus();
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




        private void LoadListViewFood()
        {
            try
            {
                lvwSubItem.Items.Clear();
                List<DietSubType> objSubType = fnbs.DisplaySubType().ToList();
                if (objSubType.Count > 0)
                {
                    foreach (DietSubType objDc in objSubType)
                    {
                        ListViewItem itm = new ListViewItem(objDc.DietSubID);
                        itm.SubItems.Add(objDc.DietSubTypeName);
                        itm.SubItems.Add(objDc.DietTypeID);
                        lvwSubItem.Items.Add(itm);
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

        private void lvwSubItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSubItem.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lvwSubItem.SelectedItems[0];
                txtDietSubType.Text = itm.SubItems[0].Text;
                cboDietType.SelectedValue = itm.SubItems[2].Text;
                txtSubMenuName.Text = itm.SubItems[1].Text;
                txtSubMenuName.Focus();


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;

            if (ValidateFields() == false)
            {
                return;
            }
            try
            {

                    DietSubType objDietType = this.PopulateDietType();
                    string strDt = fnbs.UpdateDietSubType(objDietType);
                    if (strDt == "0")
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadListViewFood();
                        txtDietSubType.Text = "";
                        txtSubMenuName.Text = "";
                        txtSubMenuName.Select();
                        txtSubMenuName.Focus();
                        
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

        private void mClear()
        {
            txtSubMenuName.Text = "";
            cboDietType.SelectedValue = 1;
            txtSubMenuName.Text = "";
            txtSubMenuName.Focus();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void txtSubMenuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboDietType.Focus();
            }
        }

        private void cboDietType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSubMenuName.Select();
            txtSubMenuName.Focus();
        }













    }
}
