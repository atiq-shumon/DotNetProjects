using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;


namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmCompanySetup : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmCompanySetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<string> vf = new List<string>() { "txtCompanyName", "txtCompanyNameBang", "txtAddress", "txtWeb", "txtPhone", "txtMail" };
            Control control = Utility.ReqFieldValidator(this,vf);
            
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
            try
            {
                CompanySetup ocomp = this.populateCompanySetup();
                short i = invSr.SaveCompanyDetails(ocomp);
               
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    RefreshGrid();
                    txtCompanyName.Select();
                   
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

         

        private CompanySetup populateCompanySetup()
        {
            CompanySetup ocompany = new CompanySetup();
            ocompany.ID = txtCompanyID.Text;
            ocompany.Name = txtCompanyName.Text;
            ocompany.NameBeng = txtCompanyNameBang.Text;
            ocompany.Address = txtAddress.Text;
            ocompany.Web = txtWeb.Text;
            ocompany.Phone = txtPhone.Text;
            ocompany.Fax = txtFax.Text;
            ocompany.Email = txtMail.Text;
            ocompany.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ocompany.EntryParameter = ep;

            return ocompany;
        }
        private void FormatGrid()
        {

            lvCompany.CheckBoxes = false;

            lvCompany.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvCompany.Columns.Add("NameBeng", 0, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Address", 150, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Web", 150, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Fax", 100, HorizontalAlignment.Left);
            lvCompany.Columns.Add("E-Mail", 150, HorizontalAlignment.Left);
            lvCompany.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvCompany.Items.Clear();

            List<CompanySetup> ocompany = invSr.GetCompanyDetails().ToList();
            int i = 0;
            foreach (CompanySetup com in ocompany)
            {
                ListViewItem itm = new ListViewItem(com.ID);
                itm.SubItems.Add(com.Name);
                itm.SubItems.Add(com.NameBeng);
                itm.SubItems.Add(com.Address);
                itm.SubItems.Add(com.Web);
                itm.SubItems.Add(com.Phone);
                itm.SubItems.Add(com.Fax);
                itm.SubItems.Add(com.Email);
                itm.SubItems.Add(com.Remarks);
                lvCompany.Items.Add(itm);


            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void frmCompanySetup_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtCompanyName.Select();
            btnEdit.Enabled = false;
        }

        private void lvCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCompany.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvCompany.SelectedItems[0];
                txtCompanyID.Text = itm.SubItems[0].Text;
                txtCompanyName.Text = itm.SubItems[1].Text;
                txtCompanyNameBang.Text = itm.SubItems[2].Text;
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
            
            try
            {
                CompanySetup ocomp = this.populateCompanySetup();
                short i = invSr.ModifyCompanyDetails(ocomp);

                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    RefreshGrid();
                    txtCompanyName.Select();

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        
    }
}
