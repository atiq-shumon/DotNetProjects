using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using AH.ModuleController.ATMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ATMS.Forms
{
    public partial class frmServiceProviderInformation : AH.Shared.UI.frmSmartFormStandard
    {
        bool invalid = false;
        ATMSSR.ATMSWSClient atms = new ATMSSR.ATMSWSClient();

        #region "Load"
        public frmServiceProviderInformation()
        {
            InitializeComponent();
        }
        #endregion
        #region "Click"
        private void frmLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region "Keypress"
        private void txtServiceProviderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Return)
            {
                txtAddress.Focus();
            }

        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtWeb.Focus();
            }
        }
        private void txtWeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtPhone.Focus();
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtFax.Focus();
            }
        }
        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtEmail.Focus();
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtContactPerson.Focus();
            }
        }
        private void txtContactPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void cboAccCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtRemarks.Focus();
            }
        }
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboPriority.Focus();
            }
        }
        private void cboPriority_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Cbostatus.Focus();
            }
        }
        private void Cbostatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
        #endregion
        #region "Validationfileds"
        private bool validationfields()
        {
            if (txtServiceProviderName.Text.ToString() == "")
            {
                txtServiceProviderName.Focus();
                return true;
            }
            if (txtEmail.Text.ToString() == "")
            {
                txtEmail.Focus();
                return true;
            }

            if (cboPriority.Text.ToString() == "")
            {
                cboPriority.Focus();
                return true;
            }

            if (Cbostatus.Text.ToString() == "")
            {
                Cbostatus.Focus();
                return true;
            }
            if (IsValidEmail(txtEmail.Text.ToString()) ==false )
            {
                MessageBox.Show("Invalid Email Address!!");
                txtEmail.Focus();
                return true;
            }

            if (txtWeb.Text.ToString() =="")
            {
                MessageBox.Show("Cannot Empty!!");
                txtWeb.Focus();
                return true;
            }

            //if (CheckUrlStatus(txtWeb.Text) =="" ))
            //{
            //    MessageBox.Show("Cannot Empty!!");
            //    txtWeb.Focus();
            //    return true;
            //}
            //CheckUrlStatus(txtWeb.Text);
            return false;
        }
        #endregion 
        #region "Check Email"
        protected void  CheckUrlStatus(string Website)
        {
            string pattern = default(string);
            pattern = "http(s)?://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\\'\\,]*)?";

            //System.Text.RegularExpressions.Regex rURL = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            //                                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            //                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (Regex.IsMatch(Website, pattern))
            {
                MessageBox.Show("Valid URL");
            }
            else
            {
                MessageBox.Show("Not Valid URL");
            }
        }  
        private ServiceProvider PopulateServiceProvider()
        {
            ServiceProvider objSp = new ServiceProvider();
            if (txtServiceCode.Text != "")
            {
                objSp.ID = txtServiceCode.Text;
            }
            objSp.ServiceProviderName = txtServiceProviderName.Text;
            objSp.Address = txtAddress.Text;
            objSp.Web = txtWeb.Text;
            objSp.Phone = txtPhone.Text;
            objSp.Fax = txtFax.Text;
            objSp.Email = txtEmail.Text;
            objSp.ContactPerson = txtContactPerson.Text;
            objSp.Acccode = cboAccCode.Text;
            objSp.Remarks = txtRemarks.Text;
            objSp.Priority = cboPriority.Text;
            objSp.Active = Cbostatus.Text.ToString().Substring(0, 1);

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objSp.EntryParameter = ep;
            return objSp;
        }
        private  bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
                return;
            }
            else
            {
                try
                {
                    var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {

                        ServiceProvider SP = this.PopulateServiceProvider();
                        short i = atms.SaveServiceProviderInfor(SP);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayDetails();
                            btnNew.PerformClick();
                            txtServiceProviderName.Focus();

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
        }
        #endregion 
        #region "Display Details"
        private void DisplayDetails()
        {
            lvwService.Items.Clear();
            try
            {
                List<ServiceProvider> objSP = atms.GetDetailsInformation("Service", "").ToList();
                foreach (ServiceProvider Recipr in objSP)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Recipr.ID;
                    item.SubItems.Add(Recipr.ServiceProviderName);
                    item.SubItems.Add(Recipr.Address);
                    item.SubItems.Add(Recipr.Web);
                    item.SubItems.Add(Recipr.Phone);
                    item.SubItems.Add(Recipr.Fax);
                    item.SubItems.Add(Recipr.Email);
                    item.SubItems.Add(Recipr.ContactPerson);

                    item.SubItems.Add(Recipr.Acccode);
                    item.SubItems.Add(Recipr.Remarks);
                    item.SubItems.Add(Recipr.Priority);
                    item.SubItems.Add(Recipr.Active);
                    lvwService.Items.Add(item);
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
        #endregion 
        #region "Edit"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validationfields() == true)
            {
               return ;
            }
            else
            {
                try
                {
                    var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (strResponse == DialogResult.Yes)
                    {
                        ServiceProvider SP = this.PopulateServiceProvider();
                        short i = atms.UpdateServiceProviderInfor(SP);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnNew.PerformClick();
                            txtServiceProviderName.Focus();
                            DisplayDetails();
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
        }
        #endregion
        #region "format"
        private void format()
        {
            lvwService.Clear();
            lvwService.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lvwService.Columns.Add("Service Provider Name", 100, HorizontalAlignment.Left);
            lvwService.Columns.Add("Address", 200, HorizontalAlignment.Left);
            lvwService.Columns.Add("Web", 0, HorizontalAlignment.Left);
            lvwService.Columns.Add("Phone", 200, HorizontalAlignment.Left);
            lvwService.Columns.Add("Fax", 0, HorizontalAlignment.Left);
            lvwService.Columns.Add("Email", 200, HorizontalAlignment.Left);
            lvwService.Columns.Add("Contact Person", 150, HorizontalAlignment.Left);
            lvwService.Columns.Add("Acc Code", 0, HorizontalAlignment.Left);
            lvwService.Columns.Add("Remarks", 0, HorizontalAlignment.Left);
            lvwService.Columns.Add("Priority", 0, HorizontalAlignment.Left);
            lvwService.Columns.Add("Active", 0, HorizontalAlignment.Left);
        }
        #endregion
        #region "Load"
        private void frmServiceProviderInformation_Load(object sender, EventArgs e)
        {
           format();
           DisplayDetails();
           //comboBox1.ValueMember = "Key";
           //comboBox1.DisplayMember = "Value";
           //comboBox1.DataSource = new BindingSource(atms.GetServiceProviderInfo("LoadService", ""), null);
        }
        #endregion
        #region "Changed"
        private void lvwService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwService.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                txtServiceProviderName.Focus();
                //txtServiceProviderName.Select();
                ListViewItem itm = lvwService.SelectedItems[0];
                txtServiceCode.Text = itm.SubItems[0].Text;
                txtServiceProviderName.Text = itm.SubItems[1].Text;
                txtAddress.Text = itm.SubItems[2].Text;
                txtWeb.Text = itm.SubItems[3].Text;
                txtPhone.Text = itm.SubItems[4].Text;
                txtFax.Text = itm.SubItems[5].Text;
                txtEmail.Text = itm.SubItems[6].Text;
                txtContactPerson.Text = itm.SubItems[7].Text;
                cboAccCode.Text = itm.SubItems[8].Text;
                txtRemarks.Text = itm.SubItems[9].Text;
                cboPriority.Text = itm.SubItems[10].Text;
                if (itm.SubItems[11].Text == "A")
                    Cbostatus.Text = "Active";
                else
                {
                    Cbostatus.Text = "Inactive";
                }
            }
        }
        #endregion 
        #region "Click"
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtServiceProviderName.Focus();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion


    }
}
