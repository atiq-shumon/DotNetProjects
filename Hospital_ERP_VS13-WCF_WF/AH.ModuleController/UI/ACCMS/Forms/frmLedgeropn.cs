using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;
namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmLedgeropn : AH.Shared.UI.frmSmartFormStandard
    {
       
        AccountsMSSR.ACCMSWSClient accmsc = new AccountsMSSR.ACCMSWSClient();
        public frmLedgeropn()
        {
            InitializeComponent();
        }
        #region "Load"
        private void GetBranchConfig()
        {
            try
            {
                cboCompany.ValueMember = "Key";
                cboCompany.DisplayMember = "Value";
                cboCompany.DataSource = new BindingSource(accmsc.GetBranchConfig("D"), null);
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
        private void GetLedgerInformation(string strControl)
        {
            //cboLedgerName.ValueMember = "Key";
            //cboLedgerName.DisplayMember = "Value";
            //cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);
            lstLedger.ValueMember = "Key";
            lstLedger.DisplayMember = "Value";
            lstLedger.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);

        }
        #endregion
        #region "FormLoad"
        private void frmLedgeropn_Load(object sender, EventArgs e)
        {
            try
            {
                GetBranchConfig();
                txtLedger.Focus();
                GetLedgerInformation("Ledger");
                FormatGrid();
                LoadListView();
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
        #region "Populated"
        private LedgerOpening PopulateLedgers()
        {
            LedgerOpening objLedgers = new LedgerOpening();
            objLedgers.OpnID  = txtopnID.Text.ToString();
            //objLedgers.LedgerCode  = cboLedgerName.SelectedValue.ToString();
            //objLedgers.LedgerName  = cboLedgerName.Text ;
            objLedgers.LedgerCode = lstLedger.SelectedValue.ToString();
            objLedgers.LedgerName = lstLedger.Text;

            objLedgers.BranchCode = cboCompany.SelectedValue.ToString();
            objLedgers.OpnDate  = dteOpeningDate.Text.ToString();
            objLedgers.DRCR = txtDrCr.Text.ToString();
            if (objLedgers.DRCR.ToString() == "Dr")
            {
                objLedgers.dblOpeningAmount = Convert.ToDouble(txtOpnAmount.Text) * -1;
            }
            else if (objLedgers.DRCR.ToString() == "Cr")
            {
                objLedgers.dblOpeningAmount = Convert.ToDouble(txtOpnAmount.Text);
            }
            
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objLedgers.EntryParameter = ep;
            return objLedgers;
        }
        #endregion
        #region "Validation"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtLedger" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboCompany.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboCompany.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCompany.Focus();
                return false;
            }
            //if (cboLedgerName.Text == "")
            //{
            //    MessageBox.Show(Utility.getFMS(cboLedgerName.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboLedgerName.Focus();
            //    return false;
            //}
            return true;
        }
        #endregion
        #region "button"
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
                    LedgerOpening objldr = this.PopulateLedgers();
                    short i = accmsc.InsertLedgerOpening(objldr);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtLedger.Focus();
                        LoadListView();
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
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    LedgerOpening objldr = this.PopulateLedgers();
                    short i = accmsc.UpdateLedgerOpening(objldr);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtLedger.Focus();
                        LoadListView();
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDrCr.Text = "Dr";
            txtLedger.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
        #endregion
        #region "Listview"
        private void LoadListView()
        {
            lvwLedgerOpn.Items.Clear();
            double dblDrCrAmount;
            List<LedgerOpening> ldr = accmsc.GetLedgerOpn().ToList();
            foreach (LedgerOpening ledgers in ldr)
            {
                ListViewItem itm = new ListViewItem(ledgers.OpnID.ToString());
                itm.SubItems.Add(ledgers.LedgerName.ToString());
                itm.SubItems.Add(ledgers.BranchCode.ToString());
                itm.SubItems.Add(ledgers.OpnDate.ToString());
                if (ledgers.DRCR.ToString() == "Dr")
                {
                    dblDrCrAmount = (ledgers.dblOpeningAmount * -1);
                    itm.SubItems.Add(dblDrCrAmount.ToString());
                }
                else if (ledgers.DRCR.ToString() == "Cr")
                {
                    itm.SubItems.Add(ledgers.dblOpeningAmount.ToString());
                }
                itm.SubItems.Add(ledgers.DRCR.ToString());
                itm.SubItems.Add(ledgers.LedgerCode.ToString());
                lvwLedgerOpn.Items.Add(itm);
            }
        }
        private void FormatGrid()
        {
            lvwLedgerOpn.CheckBoxes = false;
            lvwLedgerOpn.Columns.Add("Opn ID", 0, HorizontalAlignment.Center);
            lvwLedgerOpn.Columns.Add("Ledger Name", 260, HorizontalAlignment.Left);
            lvwLedgerOpn.Columns.Add("Branch Name", 0, HorizontalAlignment.Left);
            lvwLedgerOpn.Columns.Add("Date", 150, HorizontalAlignment.Left);
            lvwLedgerOpn.Columns.Add("Oepning", 200, HorizontalAlignment.Left);
            lvwLedgerOpn.Columns.Add("Dr/Cr", 290, HorizontalAlignment.Left);
            lvwLedgerOpn.Columns.Add("LedgerCode", 0, HorizontalAlignment.Left);
        }
        #endregion
        #region "Chanage"
        private void lvwLedgerOpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            double dblAmount;
            if (lvwLedgerOpn.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true ;
                btnSave.Enabled = false;
                ListViewItem itm = lvwLedgerOpn.SelectedItems[0];
                txtopnID.Text = itm.SubItems[0].Text;
                cboCompany.SelectedValue = itm.SubItems[2].Text;
                dteOpeningDate.Text = itm.SubItems[3].Text.ToString();
                if (Convert.ToDouble(itm.SubItems[4].Text.ToString()) < 0)
                {
                    dblAmount = Convert.ToDouble(itm.SubItems[4].Text.ToString());
                    txtOpnAmount.Text =  (dblAmount *-1).ToString();
                }
                else
                {
                    txtOpnAmount.Text = itm.SubItems[4].Text.ToString();
                }
                txtDrCr.Text  = itm.SubItems[5].Text;
                //lstLedger.SelectedValue = itm.SubItems[6].Text;
                txtLedger.Text = itm.SubItems[1].Text;
                dteOpeningDate.Select();
                lstLedger.Visible = false;
            }
        }
        #endregion
        #region "Keypress"
        private void cboLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dteOpeningDate.Focus();
            }
        }
        private void dteOpeningDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboCompany.Focus();
            }
        }
        private void cboCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtOpnAmount.Focus();
            }
        }
        private void txtOpnAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSave.Focus();
            }
        }
        private void txtLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (lstLedger.Items.Count > 0)
                {
                    txtLedger.Text = lstLedger.Text;
                    dteOpeningDate.Focus();
                    lstLedger.Visible = false;
                }
            }
        }
        private void txtLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                frmLedger frm = new frmLedger();
                frm.ShowDialog();
                GetLedgerInformation("Ledger");

            }
            
            if (e.KeyCode == Keys.Up)
            {
                if (lstLedger.SelectedItem != null)
                {
                    lstLedger.SelectedIndex = lstLedger.SelectedIndex - 1;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lstLedger.Items.Count - 1 > lstLedger.SelectedIndex)
                {
                    lstLedger.SelectedIndex = lstLedger.SelectedIndex + 1;
                }
            }
        }
        #endregion
        #region "Key"
        private void txtDrCr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                txtDrCr.Text = "";
                txtDrCr.Text = "Dr";
                //mChangeOpening(txtDrCr.Text);
            }
            else if (e.KeyCode == Keys.C)
            {
                txtDrCr.Text = "";
                txtDrCr.Text = "Cr";
                // mChangeOpening(txtDrCr.Text);
            }
        }
        private void txtLedger_TextChanged(object sender, EventArgs e)
        {
            lstLedger.Visible = true;
            lstLedger.SelectedIndex = lstLedger.FindString(txtLedger.Text);
        }
        private void lstLedger_DoubleClick(object sender, EventArgs e)
        {
           
            txtLedger.Text = lstLedger.Text;
            //cboLedgerName.Text = txtLedger.Text;
            lstLedger.Visible = false;
            dteOpeningDate.Focus();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
