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
    public partial class frmLedger : AH.Shared.UI.frmSmartFormStandard
    {
        private double mdblDebit;
        private double mdblCredit;
        private double mdblOpeningBalance;
        public string under { set; get; }
        public string ledgercode { set; get; }
        public long lngSlNo { get; set;}
        private System.Windows.Forms.TreeNode NodeX;
        private const string mcGROUP_PREFIX = "G_";
        private const string mcLEDGER_PREFIX = "L_";
        public string strMode { set; get; }
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        List<Ledgers> ldr;
        public frmLedger()
        {
            InitializeComponent();
        }
        #region "ListView"
        private void LoadListViewDetails()
        {
            lvwVoucherDetails.Items.Clear();

            ldr = accmSc.GetLedgersDetails().ToList();
            int i = 0;
            foreach (Ledgers ledgers in ldr)
            {
                ListViewItem itm = new ListViewItem(ledgers.lngSlNo.ToString());
                itm.SubItems.Add(ledgers.strLedgerName);
                itm.SubItems.Add(ledgers.strGrUnder);
                //itm.SubItems.Add(ledgers.);
                if (double.Parse(ledgers.dblopeningBalance.ToString()) < 0)
                {
                    itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Dr");
                }
                else
                {
                    itm.SubItems.Add("0");
                }

                if (double.Parse(ledgers.dblopeningBalance.ToString()) > 0)
                {
                    itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Cr");
                }
                else
                {
                    itm.SubItems.Add("0");
                }
                if (ledgers.lngDefaultLedger.ToString() != "")
                {
                    itm.SubItems.Add(ledgers.lngDefaultLedger.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }
                if (ledgers.intCostCenter.ToString() != "")
                {
                    itm.SubItems.Add(ledgers.intCostCenter.ToString());
                }
                else
                {
                    itm.SubItems.Add("");
                }

                lvwVoucherDetails.Items.Add(itm);
            }
        }
        private void FormatGrid1()
        {
            lvwVoucherDetails.CheckBoxes = false;
            lvwVoucherDetails.Columns.Add("Sl No", 0, HorizontalAlignment.Center);
            lvwVoucherDetails.Columns.Add("Ledger Name", 350, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Under", 370, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Oepning Dr", 0, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Opening Cr", 0, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("Default Ledger", 0, HorizontalAlignment.Left);
            lvwVoucherDetails.Columns.Add("CostCenter", 0, HorizontalAlignment.Left);
        }
        #endregion
        #region "Function"
        private void mChangeOpening(string vstrDrCr)
        {

            double dblDebit;
            double dblCredit;
            double dblDiff;

            if (lngSlNo >0)
            {
                if (mdblOpeningBalance < 0)
                {
                    mdblDebit = mdblDebit + mdblOpeningBalance;
                }
                if (mdblOpeningBalance > 0)
                {
                    mdblCredit = mdblCredit - mdblOpeningBalance;
                }
            }
            if (vstrDrCr == "Dr")
            {

                dblDebit = double.Parse(mdblDebit.ToString()) + Utility.val(txtOpeningBalance.Text);
                lblDebit.Text = Math.Abs(dblDebit).ToString() + " Dr";
                lblCredit.Text = Math.Abs(mdblCredit).ToString() + " Cr";
                dblDiff = mdblCredit - dblDebit;
                if (dblDiff < 0)
                {
                    lblDifferenceTitle.Visible = true;
                    lblDifference.Visible = true;
                    lblDifference.Text = Math.Abs(dblDiff).ToString() + " Dr";
                }

                else if (dblDiff > 0)
                {
                    lblDifferenceTitle.Visible = true;
                    lblDifference.Visible = true;
                    lblDifference.Text = Math.Abs(dblDiff).ToString() + " Cr";
                }
                else
                {
                    lblDifferenceTitle.Visible = false;
                    lblDifference.Visible = false;
                }
            }
            if (vstrDrCr == "Cr")
            {
                dblCredit = double.Parse(mdblCredit.ToString()) + Utility.val(txtOpeningBalance.Text);
                lblDebit.Text = Math.Abs(mdblDebit).ToString() + " Dr";
                lblCredit.Text = Math.Abs(dblCredit).ToString() + " Cr";
                dblDiff = dblCredit - mdblDebit;
                if (dblDiff < 0)
                {
                    lblDifferenceTitle.Visible = true;
                    lblDifference.Visible = true;
                    lblDifference.Text = Math.Abs(dblDiff).ToString() + " Dr";
                }
                else if (dblDiff > 0)
                {
                    lblDifferenceTitle.Visible = true;
                    lblDifference.Visible = true;
                    lblDifference.Text = Math.Abs(dblDiff).ToString() + " Cr";
                }
                else
                {
                    lblDifferenceTitle.Visible = false;
                    lblDifference.Visible = false;
                }
            }
            if (lngSlNo >0)
            {
                if (mdblOpeningBalance < 0)
                {
                    mdblDebit = mdblDebit - mdblOpeningBalance;
                }
                if (mdblOpeningBalance > 0)
                {
                    mdblCredit = mdblCredit + mdblOpeningBalance;
                }
            }

        }
        private void GetDRCRDiffer()
        {
            double dblDifference;
            List<Ledgers> objldr = accmSc.GetDebitTotal().ToList();
            foreach (Ledgers ldr in objldr)
            {
                mdblDebit = Convert.ToDouble(ldr.dblopeningBalance);
            }

            if (mdblDebit != 0)
            {
                lblDebit.Text = Math.Abs(mdblDebit).ToString()  + " Dr";
            }
            //mdblCredit = GetCreditTotal();
            List<Ledgers> objlCr = accmSc.GetCreditTotal().ToList();
            foreach (Ledgers ldr in objlCr)
            {
                mdblCredit = Convert.ToDouble(ldr.dblopeningBalance);
            }
            if (mdblCredit != 0)
            {
                lblDebit.Text = Math.Abs(mdblDebit).ToString() + " Cr";
            }
            dblDifference = double.Parse((mdblCredit - mdblDebit).ToString(("##########0.00")));
            if (dblDifference < 0)
            {
                lblDifferenceTitle.Visible = true;
                lblDifference.Visible = true;
                lblDifference.Text = Convert.ToDouble(Math.Abs(dblDifference)) + " Dr";
            }
            else if (dblDifference > 0)
            {
                lblDifferenceTitle.Visible = true;
                lblDifference.Visible = true;
                lblDifference.Text = Convert.ToDouble(Math.Abs(dblDifference)) + " Cr";
            }
            else
            {
                lblDifferenceTitle.Visible = false;
                lblDifference.Visible = false;
            }
        }
        private void LoadModule()
        {
            //cboUnder.ValueMember = "Key";
            //cboUnder.DisplayMember = "Value";
            //cboUnder.DataSource = new BindingSource(accmSc.GetLedgerUnder("D"), null);
            lstLedger.ValueMember = "Key";
            lstLedger.DisplayMember = "Value";
            lstLedger.DataSource = new BindingSource(accmSc.GetLedgerUnder("D"), null);
            
        }
        #endregion
        #region "Treeview"
        private void GetGroupsTreeView()
        {
            //string strGroup;
            //System.Windows.Forms.TreeNode oNodex = null;
            //this.tvwGroup.Nodes.Clear();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
            //oNodex.Expand();
            //List<GroupsConfig> grp = accmSc.GetGroupTreeview().ToList();
            //foreach (GroupsConfig grps in grp)
            //{
            //    strGroup = grps.GrName.ToString();
            //    oNodex = tvwGroup.Nodes.Find(mcGROUP_PREFIX + grps.GrParent.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strGroup, "closed");
            //    oNodex.EnsureVisible();
            //    GetLedgerItem(strGroup);
            //}
        }
        private void GetLedgerItem(string vstrRoot)
        {
            //string strChild;
            //List<Ledgers> objLed = accmSc.GetLegerTreeview(vstrRoot).ToList();
            //foreach (Ledgers ldr in objLed)
            //{
            //    strChild = ldr.strLedgerName.ToString();
            //    NodeX = tvwGroup.Nodes.Find(mcGROUP_PREFIX + vstrRoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + strChild, strChild, "leaf");
            //    NodeX.ImageIndex = 1;
            //}
        }
        #endregion
        #region "Validation"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtLedgerName","txtUnder" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            //if (cboUnder.Text == "")
            //{
            //    MessageBox.Show(Utility.getFMS(cboUnder.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cboUnder.Focus();
            //    return false;
            //}
            if (cboStatus.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboStatus.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStatus.Focus();
                return false;
            }
            return true;
        }
        #endregion
        #region "CreateControlListbox"
        private void CreatelistBoxControl()
        {
            ListBox lstLedger = new ListBox();
            lstLedger.Size = new System.Drawing.Size(200, 100);
            lstLedger.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form. 
            this.Controls.Add(lstLedger);
        }
        #endregion
        #region "Load"
        private void frmLedger_Load(object sender, EventArgs e)
        {
            txtLedgerName.Select();
            btnEdit.Enabled = false;
            //CreatelistBoxControl();
            if (strMode=="Edit")
            {
                chkEdit.Checked = true;
                lblSearch.Visible = true;
                txtSearch.Visible = true;
            }
            else
            {
                txtUnder.Text = under.ToString();
                txtCode.Text = ledgercode.ToString();
                chkEdit.Checked = false;
                btnDetails.Visible = false;
            }
            LoadModule();
            GetDRCRDiffer();
            FormatGrid();
            FormatGrid1();
            LoadListView();
            LoadListViewDetails();
            //GetGroupsTreeView();
            //if (lngSlNo > 0)
            //{
            //    List <Ledgers> ldr = accmSc.GetDisplayLedgers(lngSlNo).ToList();
            //    foreach (Ledgers ldrs in ldr)
            //    {
            //        GetLedgeerDisplay(ldrs);
            //    }
            //}
        }
        #endregion
        #region "Populated Ledger"
        private Ledgers PopulateLedgers()
        {
            int intCostCenter=0;
            Ledgers objLedgers = new Ledgers();
            if (cboCostCenter.Text == "Yes")
                intCostCenter = 1;
            
            if (lngSlNo > 0)
            {
                objLedgers.lngSlNo = lngSlNo;
            }
            objLedgers.strLedgerName  = txtLedgerName.Text;
            objLedgers.strGrUnder = txtUnder.Text;
            objLedgers.strCurrencsysymbol = txtCurrencySymbol.Text;
            if (txtOpeningBalance.Text.ToString() != "")
            {
                objLedgers.dblopeningBalance = double.Parse(txtOpeningBalance.Text.ToString());
            }
            objLedgers.strAddress1 = txtAddress1.Text;
            objLedgers.straddress2 = txtAddress2.Text;
            objLedgers.strCity = txtCity.Text;
            objLedgers.strPostal = txtPostal.Text;
            objLedgers.strFax = txtFax.Text;
            objLedgers.strPhone = txtPhoneNo.Text;
            objLedgers.strEmail = txtEmail.Text;
            objLedgers.strStatus = cboStatus.Text;
            objLedgers.strDRCR = txtDrCr.Text;
            objLedgers.strComments = txtComments.Text;
            objLedgers.intCostCenter =intCostCenter;
            objLedgers.strLedgerCode = txtCode.Text.ToString();


            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objLedgers.EntryParameter = ep;
            return objLedgers;
        }
        private void FormatGrid()
        {
            lvwLedgerList.CheckBoxes = false;
            lvwLedgerList.Columns.Add("Sl No", 0, HorizontalAlignment.Center);
            lvwLedgerList.Columns.Add("Ledger Name", 260, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvwLedgerList.Items.Clear();

            List<Ledgers> ldr = accmSc.GetLedgersDetails().ToList();
            int i = 0;
            foreach (Ledgers ledgers in ldr)
            {
                ListViewItem itm = new ListViewItem(ledgers.lngSlNo.ToString());
                itm.SubItems.Add(ledgers.strLedgerName);
                lvwLedgerList.Items.Add(itm);
            }
        }
        #endregion
        #region "Button"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            if (Utility.IsDuplicateFoundInList(lvwLedgerList, 1, txtLedgerName.Text) == true)
            {
                MessageBox.Show("Cannot Inssert Duplicate Value", "AGH Accounts");
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    Ledgers objldr = this.PopulateLedgers();
                    short i = accmSc.SaveLedgerSetup(objldr);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLedgerName.Text = "";
                        //txtUnder.Text = "";
                        txtLedgerName.Focus();
                        LoadListViewDetails();
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
        private void btnTreeView_Click(object sender, EventArgs e)
        {
            frmTreeView frm = new frmTreeView();
            frm.ShowDialog();
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
                    Ledgers objldr = this.PopulateLedgers();
                    short i = accmSc.UpdateLedgerSetup(objldr);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        //MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListViewDetails();
                        txtLedgerName.Text = "";
                        txtUnder.Text = "";
                        txtLedgerName.Focus();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            //grpSerach.Visible = false;
            txtUnder.Focus();
        }
        private void btnReferesh_Click(object sender, EventArgs e)
        {
            GetGroupsTreeView();
            LoadListViewDetails();
        }
        private void txtDrCr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //grpSerach.Visible = true;
            txtUnder.Text = "";
            txtUnder.Focus();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCurrencySymbol.Text = "BDT";
            txtDrCr.Text = "Dr";
            txtUnder.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            lstLedger.Visible = false;
            txtLedgerName.Focus();
        }
        #endregion
        #region  "Display"
        private void GetLedgerDisplay(Ledgers objLedgers)
        {
            long lngLedgerPrimaryType;
            double dblOpeninhBalance;
            double dblOpeninhBalance1;
            //Ledgers objLedgers = new Ledgers();
            //lblu
            txtLedgerName.Text = objLedgers.strLedgerName;
            txtUnder.Text = objLedgers.strGrUnder;
            txtCurrencySymbol.Text = objLedgers.strCurrencsysymbol;
            lngLedgerPrimaryType = long.Parse(objLedgers.lngLedgerPrimaryType.ToString());
            mdblOpeningBalance = double.Parse(objLedgers.dblopeningBalance.ToString());
            dblOpeninhBalance = double.Parse(objLedgers.dblopeningBalance.ToString());
            if (Math.Abs(dblOpeninhBalance) != 0)
            {
                dblOpeninhBalance1 = Math.Abs(dblOpeninhBalance);
                txtOpeningBalance.Text = dblOpeninhBalance1.ToString();
            }
            else
            {
                txtOpeningBalance.Text = "0";
            }
            //txtAddress1.Text = objLedgers.strAddress1.ToString();
            //txtAddress2.Text = objLedgers.straddress2.ToString();
            //txtCity.Text = objLedgers.strCity.ToString();
            //txtPostal.Text = objLedgers.strPostal.ToString();
            //txtFax.Text = objLedgers.strFax.ToString();
            //txtPhoneNo.Text = objLedgers.strPhone.ToString();
            //txtEmail.Text = objLedgers.strEmail.ToString();
            //txtComments.Text = objLedgers.strComments.ToString();
            if (Int32.Parse(objLedgers.strStatus.ToString()) == 1)
            {
                cboStatus.Text = "Yes";
            }
            else
            {
                cboStatus.Text = "No";
            }

            if ((lngLedgerPrimaryType == 1) || (lngLedgerPrimaryType == 4))
            {
                txtDrCr.Text = "Dr";
            }
            {
                txtDrCr.Text = "Cr";
            }

            if (dblOpeninhBalance < 0)
            {
                txtDrCr.Text = "Dr";
            }
            else if (dblOpeninhBalance > 0)
            {
                txtDrCr.Text = "Cr";
            }
            if  (long.Parse(objLedgers.lngDefaultLedger.ToString()) == 1)
            {
                txtUnder.Enabled = false;
            }
            else
            {
                txtUnder.Enabled = true;
            }

            if (Int32.Parse(objLedgers.intCostCenter.ToString()) == 1)
            {
                cboCostCenter.Text = "Yes";
            }
            else
            {
                cboCostCenter.Text = "No";
            }


        }
        #endregion
        #region "SelectedIndexchanged"
        private void lvwVoucherDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwVoucherDetails.SelectedItems.Count > 0)
            {
               btnEdit.Enabled = true;
               btnSave.Enabled = false;
   
               lngSlNo = (Int32.Parse(lvwVoucherDetails.FocusedItem.SubItems[0].Text));
                if (lngSlNo > 0)
                {
                    List<Ledgers> ldr = accmSc.GetDisplayLedgers(lngSlNo).ToList();
                    foreach (Ledgers ldrs in ldr)
                    {
                        GetLedgerDisplay(ldrs);
                    }
                   
                    txtLedgerName.Select();
                    lstLedger.Visible = false;
                }
            }
        }
        #endregion
        #region "Keypress"
        private void txtOpeningBalance_Leave(object sender, EventArgs e)
        {

            mChangeOpening(txtDrCr.Text);
            txtDrCr.Focus();
        }
        private void txtDrCr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                txtDrCr.Text = "";
                txtDrCr.Text = "Dr";
                mChangeOpening(txtDrCr.Text);
            }
            else if (e.KeyCode == Keys.C)
            {
                txtDrCr.Text = "";
                txtDrCr.Text = "Cr";
                mChangeOpening(txtDrCr.Text);
            }
        }
       
       
       
        private void lstLedger_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(lstLedger.SelectedValue.ToString());
            txtUnder.Text = lstLedger.Text;
            //txtUnder.SelectedValue = txtUnder.Text;
            lstLedger.Visible = false;
            //grpSerach.Visible = false;
            //txtOpeningBalance.Focus();
            cboStatus.Focus();
        }
        private void txtLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLedgerName.Text.Length > 1 && txtLedgerName.Text.Substring(txtLedgerName.Text.Length - 1, 1) == " ")
            {
                // convert first character to upper case after space
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
            else if (txtLedgerName.Text.Length == 0)
            {
                // convert first character typed in texbox to upper case
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
            if (e.KeyChar == (char)Keys.Return)
            {
                txtUnder.Focus();
            }
        }
        private void cboUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //txtOpeningBalance.Focus();
                cboCostCenter.Focus();
            }
        }
        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboStatus.Focus();
            }
        }
        private void cboStatus_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
        #region "Key"

        private void cboUnder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F))
            {
                //grpSerach.Visible = true;
                txtUnder.Focus();
            }
        }

        private void cboCostCenter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //txtOpeningBalance.Focus();
                cboStatus.Focus();
            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchListView(ldr, txtSearch.Text);
        }

        private void SearchListView(IEnumerable<Ledgers> tests, string searchString = "")
        {
            IEnumerable<Ledgers> query;
          
            if (!(searchString.Length > 0))
            {
                query = tests;
            }
            else
            {
                query = (from test in tests
                         where test.strLedgerName.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)
                         select test);

            }

            lvwVoucherDetails.Items.Clear();

            foreach (Ledgers ledgers in query)
             {
                    ListViewItem itm = new ListViewItem(ledgers.lngSlNo.ToString());
                    itm.SubItems.Add(ledgers.strLedgerName);
                    itm.SubItems.Add(ledgers.strGrUnder);
                    //itm.SubItems.Add(ledgers.);
                    if (double.Parse(ledgers.dblopeningBalance.ToString()) < 0)
                    {
                        itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Dr");
                    }
                    else
                    {
                        itm.SubItems.Add("0");
                    }

                    if (double.Parse(ledgers.dblopeningBalance.ToString()) > 0)
                    {
                        itm.SubItems.Add(Math.Abs(double.Parse(ledgers.dblopeningBalance.ToString())) + "Cr");
                    }
                    else
                    {
                        itm.SubItems.Add("0");
                    }

                    itm.SubItems.Add(ledgers.lngDefaultLedger.ToString());
                    itm.SubItems.Add(ledgers.intCostCenter.ToString());
                    lvwVoucherDetails.Items.Add(itm);
                }
        }

        private void txtLedger_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
            //    if (lstLedger.Items.Count > 0)
            //    {
            //        if (lstLedger.SelectedIndex == -1)
            //        {
            //            txtUnder.Text = lstLedger.Items[0].ToString();
            //        }
            //        else
            //        {
            //            txtUnder.Text = lstLedger.Text;
            //        }
            //        //txtUnder.SelectedValue = txtUnder.Text;
            //        //txtOpeningBalance.Focus();
            cboStatus.Focus();
            //        lstLedger.Visible = false;
            //        //grpSerach.Visible = false;
                }
            //}
        }

        private void txtLedger_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == (Keys.Control | Keys.Z))
            //{
            //    lstLedger.Visible = true;
            //    frmTreeView frm = new frmTreeView();
            //    frm.ShowDialog();
            //    LoadModule();
            //}

            //if (e.KeyCode == Keys.Up)
            //{
            //    if (lstLedger.SelectedItem != null)
            //    {
            //        lstLedger.SelectedIndex = lstLedger.SelectedIndex - 1;
            //    }
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    if (lstLedger.Items.Count - 1 > lstLedger.SelectedIndex)
            //    {
            //        lstLedger.SelectedIndex = lstLedger.SelectedIndex + 1;
            //    }
            //}
        }

        private void txtLedger_TextChanged(object sender, EventArgs e)
        {
            //lstLedger.Visible = true;
            //lstLedger.SelectedIndex = lstLedger.FindString(txtUnder.Text);
        }

        private void txtOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            lstLedger.Visible = false;
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked == true)
            {
                this.Width = 861;
                this.Height = 624;
                pnlMain.Width = 856;
                pnlMain.Height = 473;
                btnNew.Location = new Point(388, 222);
                btnDetails.Location = new Point(392, 530);
                btnSave.Location = new Point(502, 530);
                btnEdit.Location = new Point(616, 530);
                //btnDelete.Location = new Point(516, 458);
                //btnTreeView.Location = new Point(631, 459);
                btnClose.Location = new Point(729, 530);
                
            }
            else
            {
                this.Width = 861;
                this.Height = 327;
                pnlMain.Width = 856;
                pnlMain.Height = 166;
                btnNew.Location = new Point(391, 595);
                btnDetails.Location = new Point(392, 223);
                btnSave.Location = new Point(502, 223);
                btnEdit.Location = new Point(616, 223);
                //btnDelete.Location = new Point(516, 170);
                //btnTreeView.Location = new Point(631, 171);
               
                btnClose.Location = new Point(729, 223);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmLedgerList frm = new frmLedgerList();
            frm.ShowDialog();
            LoadListViewDetails();
        }

        //private void txtLedgerName_KeyUp(object sender, KeyEventArgs e)
        //{
        //  PropercaseFirst(txtLedgerName.Text);
        //}

        //static string PropercaseFirst(string s)
        //{
        //    // Check for empty string.
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        return string.Empty;
        //    }
        //    // Return char and concat substring.
        //    return char.ToUpper(s[0]) + s.Substring(1);
        //}
        #endregion
    }
}
