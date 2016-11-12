using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.PHRMSSR;

namespace AH.ModuleController.UI.PHRMS.Forms
{
    public partial class frmDrugCompany : AH.Shared.UI.frmSmartFormStandard
    {
        PHRMSSR.PHRMSWSClient phrSr = new PHRMSSR.PHRMSWSClient();
        public frmDrugCompany()
        {
            InitializeComponent();
        }
        public bool IsValidEmailAddress(string email)
        {
            if (Regex.IsMatch(email, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugName", "txtDrugNameBang", "txtAddress", "txtMail", "txtPhone", "txtFax" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtPhone.TextLength > 20)
            {
                txtPhone.Focus();
                MessageBox.Show("Phone number should be 20 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFax.TextLength > 20)
            {
                txtFax.Focus();
                MessageBox.Show("Fax number should be 20 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMail.Text != string.Empty)
            {
                bool emailverification = IsValidEmailAddress(txtMail.Text);

                if (!emailverification)
                {

                    MessageBox.Show("Your Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMail.Focus();

                    return;
                }
            }
            if (Utility.IsDuplicateFoundInList(lvDrug, 1, txtDrugName.Text))
            {
                MessageBox.Show("This Company Name is a duplicate");
                return;
            }
            try
            {
                DrugCompany dg = this.populateDrugCompany();
                short i = phrSr.SaveDrugCompany(dg);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDrugName.Select();
                    RefreshGrid();
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
           
        private DrugCompany populateDrugCompany()
        {
            DrugCompany dr = new DrugCompany();
            dr.ID = txtDrugCompanyID.Text;
            dr.Name = txtDrugName.Text;
            dr.NameBeng = txtDrugNameBang.Text;
            dr.Address = txtAddress.Text;
            dr.Web = txtWeb.Text;
            dr.Phone = txtPhone.Text;
            dr.Fax = txtFax.Text;
            dr.Email = txtMail.Text;
            dr.Remarks = txtRemarks.Text;

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
            lvDrug.CheckBoxes = false;

            lvDrug.Columns.Add("ID",0,HorizontalAlignment.Left);
            lvDrug.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvDrug.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvDrug.Columns.Add("Address", 150, HorizontalAlignment.Left);
            lvDrug.Columns.Add("Web", 150, HorizontalAlignment.Left);
            lvDrug.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            lvDrug.Columns.Add("Fax", 100, HorizontalAlignment.Left);
            lvDrug.Columns.Add("E-Mail", 150, HorizontalAlignment.Left);
            lvDrug.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
           
        }
        private void LoadListView()
        {
            lvDrug.Items.Clear();

            List<DrugCompany> dgcom = phrSr.GetDrugCompany().ToList();
            int i = 0;
            foreach (DrugCompany dg in dgcom)
            {
                ListViewItem itm = new ListViewItem(dg.ID);
                itm.SubItems.Add(dg.Name);
                itm.SubItems.Add(dg.NameBeng);
                itm.SubItems.Add(dg.Address);
                itm.SubItems.Add(dg.Web);
                itm.SubItems.Add(dg.Phone);
                itm.SubItems.Add(dg.Fax);
                itm.SubItems.Add(dg.Email);
                itm.SubItems.Add(dg.Remarks);               
                lvDrug.Items.Add(itm);
            }

        }

        private void frmDrugCompany_Load(object sender, EventArgs e)
        {
            txtDrugName.Select();
            FormatGrid();
            LoadListView();
        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrug.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDrug.SelectedItems[0];
                txtDrugCompanyID.Text = itm.SubItems[0].Text;
                txtDrugName.Text = itm.SubItems[1].Text;
                txtDrugNameBang.Text = itm.SubItems[2].Text;
                txtAddress.Text = itm.SubItems[3].Text;
                txtWeb.Text = itm.SubItems[4].Text;
                txtPhone.Text = itm.SubItems[5].Text;
                txtFax.Text = itm.SubItems[6].Text;
                txtMail.Text = itm.SubItems[7].Text;
                txtRemarks.Text = itm.SubItems[8].Text;
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDrugName", "txtDrugNameBang", "txtAddress", "txtMail" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                DrugCompany dg = this.populateDrugCompany();
                short i = phrSr.UpdateDrugCompany(dg);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    txtDrugName.Select();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

    }
}
