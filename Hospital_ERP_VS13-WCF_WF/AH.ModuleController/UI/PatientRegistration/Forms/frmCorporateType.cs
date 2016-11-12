using AH.DUtility;
using AH.ModuleController.PatientRegistrationSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AH.ModuleController.UI.PatientRegistration.Forms
{
    public partial class frmCorporateType : AH.Shared.UI.frmSmartFormStandard
    {
        PatientRegistrationSR.PatientRegistrationWSClient ob = new PatientRegistrationSR.PatientRegistrationWSClient();
        List<CorporateType> ctype;

        public frmCorporateType()
        {
            InitializeComponent();
        }

        private void frmCorporateType_Load(object sender, EventArgs e)
        {
            FormatlvCorpType();
            LoadCorporateDetailsList();
            this.txtCorpTitle.Focus();
        }

        private void FormatlvCorpType()
        {
            lvCorpType.CheckBoxes = false;
            lvCorpType.Columns.Add("Corporate ID", 0, HorizontalAlignment.Left); //0
            lvCorpType.Columns.Add("Corporate Type ID", 0, HorizontalAlignment.Left);//1
            lvCorpType.Columns.Add("Corporate Type Title", 200, HorizontalAlignment.Left);
            lvCorpType.Columns.Add("Corporate Type Title Bangla", 200, HorizontalAlignment.Left);//2
            lvCorpType.Columns.Add("Corporate Address", 200, HorizontalAlignment.Left);//3
            lvCorpType.Columns.Add("Corporate Web", 100, HorizontalAlignment.Left);//4
            lvCorpType.Columns.Add("Corporate Email", 150, HorizontalAlignment.Left);//5
            lvCorpType.Columns.Add("Corporate Phone", 150, HorizontalAlignment.Left);//6
            lvCorpType.Columns.Add("Corporate Mobile", 158, HorizontalAlignment.Left);//7
        }
        private void LoadCorporateDetailsList()
        {
            lvCorpType.Items.Clear();
            ctype = ob.GetCorpTypes().ToList();
            foreach (CorporateType ct in ctype)
            {
                ListViewItem itm = new ListViewItem(ct.CorpID);
                itm.SubItems.Add(ct.CorpTypeID);
                itm.SubItems.Add(ct.CorpTitle);
                itm.SubItems.Add(ct.CorpTitleBeng);
                itm.SubItems.Add(ct.CorpAddress);
                itm.SubItems.Add(ct.CorpWeb);
                itm.SubItems.Add(ct.CorpEmail);
                itm.SubItems.Add(ct.CorpPhone);
                itm.SubItems.Add(ct.CorpMobile);
                lvCorpType.Items.Add(itm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCorpTypeId", "txtCorpTitle", "txtCorpTitleBeng", "txtCorpAddrss" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (txtCorpEmail.Text != "")
            {
                if (txtCorpEmail.Text != string.Empty)
                {
                    if (!Utility.IsValidEmail(txtCorpEmail.Text))
                    {
                        MessageBox.Show("Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCorpEmail.Focus();
                        return;
                    }
                }
            }

            if (txtCorpMobile.Text != "")
            {
                if (txtCorpMobile.TextLength != 11)
                {
                    this.txtCorpMobile.Focus();
                    MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                CorporateType Corptype = this.populateCorpType();
                short i = ob.SaveCorpType(Corptype);
                  if (i == 0)
                  {
                      MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                  }
                  else if (i > 0)
                  {
                      MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                      btnNew.PerformClick();
                      LoadCorporateDetailsList();
                      this.txtCorpTitle.Focus();
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private CorporateType populateCorpType()
        {
            CorporateType ctObj = new CorporateType();
            ctObj.CorpID = txtCorpId.Text;
            ctObj.CorpTypeID = txtCorpTypeId.Text;
            ctObj.CorpTitle = txtCorpTitle.Text;
            ctObj.CorpTitleBeng = txtCorpTitleBeng.Text;
            ctObj.CorpAddress = txtCorpAddrss.Text;
            ctObj.CorpWeb = txtCorpWeb.Text;
            ctObj.CorpEmail = txtCorpEmail.Text;
            ctObj.CorpPhone = txtCorpPhone.Text;
            ctObj.CorpMobile = txtCorpMobile.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            ctObj.EntryParameter = ep;

            return ctObj;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCorpTypeId.Text = "00";
            txtCorpTitle.Text = string.Empty;
            txtCorpTitleBeng.Text = string.Empty;
            txtCorpAddrss.Text = string.Empty;
            txtCorpWeb.Text = string.Empty;
            txtCorpEmail.Text = string.Empty;
            txtCorpPhone.Text = string.Empty;
            txtCorpMobile.Text = string.Empty;
            btnSave.Enabled = true;
        }

        private void txtCorpTitle_TextChanged(object sender, EventArgs e)
        {
            txtCorpTitleBeng.Text = txtCorpTitle.Text;
        }

        private void txtCorpTitle_Leave(object sender, EventArgs e)
        {
            if (txtCorpTitle.Text != "")
            {
              //  txtCorpTitle.Text = Utility.ProperCase(txtCorpTitle.Text);
            } 
        }

        private void lvCorpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCorpType.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                ListViewItem itm = lvCorpType.SelectedItems[0];
                txtCorpId.Text = itm.SubItems[0].Text;
                txtCorpTypeId.Text = itm.SubItems[1].Text;
                txtCorpTitle.Text = itm.SubItems[2].Text;
                txtCorpTitleBeng.Text = itm.SubItems[3].Text;
                txtCorpAddrss.Text = itm.SubItems[4].Text;
                txtCorpWeb.Text = itm.SubItems[5].Text;
                txtCorpEmail.Text = itm.SubItems[6].Text;
                txtCorpPhone.Text = itm.SubItems[7].Text;
                txtCorpMobile.Text = itm.SubItems[8].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCorpId","txtCorpTypeId", "txtCorpTitle", "txtCorpTitleBeng", "txtCorpAddrss" };

            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (txtCorpEmail.Text != "")
            {
                if (txtCorpEmail.Text != string.Empty)
                {
                    if (!Utility.IsValidEmail(txtCorpEmail.Text))
                    {
                        MessageBox.Show("Email is incorrect,Please Check!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCorpEmail.Focus();
                        return;
                    }
                }
            }

            if (txtCorpMobile.Text != "")
            {
                if (txtCorpMobile.TextLength != 11)
                {
                    this.txtCorpMobile.Focus();
                    MessageBox.Show("Mobile number should be 11 digit ,Please check!!!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                CorporateType Corptype = this.populateCorpType();
                short i = ob.UpdateCorpType(Corptype);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    LoadCorporateDetailsList();
                    this.txtCorpTitle.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtCorpTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCorpTitle.Text != "")
            {
                GetSimilerCorpNameList(lvCorpType, txtCorpTitle.Text);
            }
            else
            {
                LoadCorporateDetailsList();
            }
        }
        private void GetSimilerCorpNameList(ListView lvCorpType, string CorpTitle)
        {
            IEnumerable<CorporateType> CorporateTypeListLocal;

            if (!(CorpTitle.Length > 0))
            {
                CorporateTypeListLocal = ctype;
            }
            else
            {
                CorporateTypeListLocal = ctype.Where(x => x.CorpTitle.ToLower().Contains(CorpTitle.ToLower()));
            }
            lvCorpType.Items.Clear();

            foreach (CorporateType ct in CorporateTypeListLocal)
            {
                ListViewItem itm = new ListViewItem(ct.CorpID);
                itm.SubItems.Add(ct.CorpTypeID);
                itm.SubItems.Add(ct.CorpTitle);
                itm.SubItems.Add(ct.CorpTitleBeng);
                itm.SubItems.Add(ct.CorpAddress);
                itm.SubItems.Add(ct.CorpWeb);
                itm.SubItems.Add(ct.CorpEmail);
                itm.SubItems.Add(ct.CorpPhone);
                itm.SubItems.Add(ct.CorpMobile);
                lvCorpType.Items.Add(itm);
            }
        }
    }
}
