using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmSupplier : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
        public frmSupplier()
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
            List<string> vf = new List<string>() { "txtSupplierName", "txtSupplierNameBeng", "txtContactPerson","txtAddress", "txtPhone" };
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
            try
            {
                Supplier sup = this.populateSupplier();
                short i = invSr.SaveSupplier(sup);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    btnNew.PerformClick();
                    txtSupplierName.Select();

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
        private Supplier populateSupplier()
        {
            Supplier sp = new Supplier();
            sp.ID = txtSupplierID.Text;
            sp.Name = txtSupplierName.Text;
            sp.NameBeng = txtSupplierNameBeng.Text;
            sp.ContactPerson = txtContactPerson.Text;
            sp.Priority = "1";
            sp.Address = txtAddress.Text;
            sp.Web = txtWeb.Text;
            sp.Phone = txtPhone.Text;
            sp.Fax = txtFax.Text;
            sp.Email = txtMail.Text;
            sp.Remarks = txtRemarks.Text;

            Ledgers oledger = new Ledgers();
            oledger.strLedgerCode = cboAccCode.SelectedValue.ToString();
            sp.Acc_code = oledger;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            sp.EntryParameter = ep;

            return sp;
        }
        private void FormatGrid()
        {
            lvSupplier.CheckBoxes = false;
            lvSupplier.Columns.Add("SupplierID", 0, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Supplier", 150, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("SupplierNameBeng", 0, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Address", 180, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Web", 120, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Fax", 100, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Email", 100, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("ContactPerson", 100, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("AccCode", 70, HorizontalAlignment.Left);
            lvSupplier.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvSupplier.Items.Clear();

            List<Supplier> sup = invSr.GetSupplierList().ToList();
            int i = 0;
            foreach (Supplier sp in sup)
            {
                ListViewItem itm = new ListViewItem(sp.ID);
                itm.SubItems.Add(sp.Name);
                itm.SubItems.Add(sp.NameBeng);
                itm.SubItems.Add(sp.Address);
                itm.SubItems.Add(sp.Web);
                itm.SubItems.Add(sp.Phone);
                itm.SubItems.Add(sp.Fax);
                itm.SubItems.Add(sp.Email);
                itm.SubItems.Add(sp.ContactPerson);
                itm.SubItems.Add(sp.Priority);
                itm.SubItems.Add(sp.Acc_code.strGrUnder);
                itm.SubItems.Add(sp.Remarks);
                lvSupplier.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {

            LoadListView();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            cboAccCode.ValueMember = "Key";
            cboAccCode.DisplayMember = "Value";
            cboAccCode.DataSource = new BindingSource(invSr.GetSupplierLedger("203"), null);


            txtSupplierName.Select();
            FormatGrid();
            LoadListView();
            btnEdit.Enabled = false;
        }

        private void lvSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSupplier.SelectedItems[0];
                txtSupplierID.Text = itm.SubItems[0].Text;
                txtSupplierName.Text = itm.SubItems[1].Text;
                txtSupplierNameBeng.Text = itm.SubItems[2].Text;
                txtAddress.Text = itm.SubItems[3].Text;
                txtWeb.Text = itm.SubItems[4].Text;
                txtPhone.Text = itm.SubItems[5].Text;
                txtFax.Text = itm.SubItems[6].Text;
                txtMail.Text = itm.SubItems[7].Text;
                txtContactPerson.Text = itm.SubItems[8].Text;
                txtPriority.Text = itm.SubItems[9].Text;
                cboAccCode.SelectedValue = itm.SubItems[10].Text;
                txtRemarks.Text = itm.SubItems[11].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier sup = this.populateSupplier();
                short i = invSr.ModifySupplierList(sup);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    //btnNew.PerformClick();
                    txtSupplierName.Select();

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
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
