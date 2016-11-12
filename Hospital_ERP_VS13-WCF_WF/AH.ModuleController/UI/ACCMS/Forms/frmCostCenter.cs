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
    public partial class frmCostCenter : AH.Shared.UI.frmSmartFormStandard
    {
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmCostCenter()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            LoadListView();
        }
        #region "Grid"
        private void FormatGrid()
        {
            lvPurpose.CheckBoxes = false;
            lvPurpose.Columns.Add("ID", 450, HorizontalAlignment.Center);
            lvPurpose.Columns.Add("Allocation Code", 0, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("Cost Center Name", 450, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("Purpose Name(Beng)", 0, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("AccountCode", 0, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("typeid",0,HorizontalAlignment.Left);
            lvPurpose.Columns.Add("grp", 0, HorizontalAlignment.Left);
            lvPurpose.Columns.Add("CatID", 0, HorizontalAlignment.Left);
        }
        #endregion
        #region "Load Ledger"
        private void GetLedgerInformation(string strControl)
        {
            try
            {
                //cboLedgerName.ValueMember = "Key";
                //cboLedgerName.DisplayMember = "Value";
                //cboLedgerName.DataSource = new BindingSource(accmsc.GetLedgerInformation(strControl), null);
                lstLedger.ValueMember = "Key";
                lstLedger.DisplayMember = "Value";
                lstLedger.DataSource = new BindingSource(accmSc.GetLedgerInformation(strControl), null);
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
        #region "LaodList"
        private void LoadListView()
        {
            lvPurpose.Items.Clear();
            List<Purpose> purp = accmSc.GetPurpose().ToList();
            //int i = 0;
            foreach (Purpose purs in purp)
            {
                ListViewItem itm = new ListViewItem(purs.PurposeID);
                itm.SubItems.Add(purs.Codeallocation.ToString());
                itm.SubItems.Add(purs.PurposeTitle);
                itm.SubItems.Add(purs.PurposeTitleBeng);
                itm.SubItems.Add(purs.COA.AccCode);
                itm.SubItems.Add(purs.Purposecategory.ToString());
                itm.SubItems.Add(purs.TypeID.ToString());
                itm.SubItems.Add(purs.GrpID.ToString());
                itm.SubItems.Add(purs.TypeID.ToString());
                
                lvPurpose.Items.Add(itm);
            }
        }
        private Purpose PopulatePurpose()
        {
            Purpose prsobj = new Purpose();
            prsobj.PurposeID = txtPurposeID.Text;
            prsobj.Codeallocation = txtCodeAllo.Text;
            prsobj.PurposeTitle = txtCostcenterName.Text;
            prsobj.PurposeTitleBeng = txtPurposeNameBeng.Text;
            prsobj.Purposecategory = cboDepartment.SelectedValue.ToString();
            prsobj.PurposecategoryName = cboDepartment.Text;
            prsobj.TypeID = cboDepartmentType.SelectedValue.ToString();
            prsobj.GrpID = cboDepartmentGroup.SelectedValue.ToString();
            

            COA cdobj = new COA();
            cdobj.AccCode = lstLedger.SelectedValue.ToString();
            prsobj.COA = cdobj;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            prsobj.EntryParameter = ep;
            return prsobj;
        }
        private void frmPurposeSetup_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadListView();
                GetLedgerInformation("Costcenter");
                //GetCostCategory();

                cboDepartmentType.DisplayMember = "Value";
                cboDepartmentType.ValueMember = "Key";
                cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);


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
        #region "LoadCategory"
        private void GetCostCategory()
        {
            try
            {
                cboDepartment.ValueMember = "Key";
                cboDepartment.DisplayMember = "Value";
                cboDepartment.DataSource = new BindingSource(accmSc.LoadCategory(), null);
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
        #region "Changed"
        private void lvPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPurpose.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvPurpose.SelectedItems[0];
                txtPurposeID.Text = itm.SubItems[0].Text;
                txtCodeAllo.Text = itm.SubItems[1].Text;
                txtCostcenterName.Text = itm.SubItems[2].Text;
                txtPurposeNameBeng.Text = itm.SubItems[3].Text;
                //txtAccCode.Text = itm.SubItems[3].Text;
                lstLedger.SelectedValue = itm.SubItems[4].Text;
                txtAccCode.Text = lstLedger.Text;
               

                cboDepartmentType.SelectedValue = itm.SubItems[6].Text;
                cboDepartmentGroup.SelectedValue = itm.SubItems[7].Text;
                cboDepartment.SelectedValue = itm.SubItems[5].Text.Trim();

                lstLedger.Visible = false;
            }
        }
        #endregion
        #region "Edit/New"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCostcenterName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            if (cboDepartment.Text == "Select")
            {
                MessageBox.Show("Category Name Cannot Empty");
                 cboDepartment.Focus();
                 return ;
            }
            if (accmSc.VerifyPurpose(txtPurposeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurposeID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                Purpose ps = this.PopulatePurpose();
                short i = accmSc.UpdatePurpose(ps);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCostcenterName.Focus();
                    RefreshGrid();
                    lstLedger.Visible = false;
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                }

            }

            //catch (System.ServiceModel.CommunicationException commp)
            //{
            //    MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCostcenterName.Focus();
            lstLedger.Visible = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        #endregion 
        #region "Keypress"
        private void txtAccCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (lstLedger.Items.Count > 0)
                {
                    txtAccCode.Text = lstLedger.Text;
                    btnSave.Focus();
                    lstLedger.Visible = false;
                }
            }
        }
        private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                lstLedger.Visible = true;
                frmLedger frm = new frmLedger();
                frm.ShowDialog();
                GetLedgerInformation("Costcenter");
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
        private void txtAccCode_TextChanged(object sender, EventArgs e)
        {
            lstLedger.Visible = true;
            lstLedger.SelectedIndex = lstLedger.FindString(txtAccCode.Text);
        }
        #endregion 
        #region "Click"
        private void lstLedger_DoubleClick(object sender, EventArgs e)
        {
            txtAccCode.Text = lstLedger.Text;
            lstLedger.Visible=false;
            btnSave.Focus();
        }
        #endregion
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtCostcenterName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (cboDepartment.Text == "select")
            {
                MessageBox.Show("Category Name Cannot be Empty");
                cboDepartment.Focus();
                return;
            }
            try
            {
                Purpose ps = this.PopulatePurpose();
                short i = accmSc.SavePurposeSetup(ps);
                if (i == 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtCostcenterName.Focus();
                    RefreshGrid();
                    lstLedger.Visible = false;
                }

            }

            //catch (System.ServiceModel.CommunicationException commp)
            //{
            //    MessageBox.Show(Utility.CommunicationErrorMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion
        #region "Keypress"
        private void cbocostcategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtCostcenterName.Focus();
            }
        }
        private void txtCostcenterName_KeyUp(object sender, KeyEventArgs e)
        {
            PropercaseFirst(txtCostcenterName.Text);
        }
        static string PropercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        private void txtCostcenterName_KeyPress(object sender, KeyPressEventArgs e)
        {
     
            if (txtCostcenterName.Text.Length > 1 && txtCostcenterName.Text.Substring(txtCostcenterName.Text.Length - 1, 1) == " ")
            {
                // convert first character to upper case after space
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
            else if (txtCostcenterName.Text.Length == 0)
            {
                // convert first character typed in texbox to upper case
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            }
            
            if (e.KeyChar == (char)Keys.Return)
            {
                txtAccCode.Focus();
            }
        }
        #endregion
        #region "Keydown"
        //private void cbocostcategoryName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == (Keys.Control | Keys.Z))
        //    {
        //        //lstLedger.Visible = true;
        //        frmCostCategory frm = new frmCostCategory();
        //        frm.ShowDialog();
        //        //GetCostCategory();
        //        cboDepartment.Focus();
        //    }
        //}
        #endregion
        #region "Button"
        private void btnTreeView_Click(object sender, EventArgs e)
        {
            frmCategoryTreeview frm = new frmCategoryTreeview();
            frm.ShowDialog();
        }
        #endregion

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentType.SelectedValue != null)
            {
                cboDepartmentGroup.DisplayMember = "Value";
                cboDepartmentGroup.ValueMember = "Key";
                cboDepartmentGroup.DataSource = new BindingSource(accmSc.GetDeptGroupDicByType(cboDepartmentType.SelectedValue.ToString()), null);
            }

        }

        private void cboDepartmentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentGroup.SelectedValue != null)
            {
                cboDepartment.DisplayMember = "Value";
                cboDepartment.ValueMember = "Key";
                cboDepartment.DataSource = new BindingSource(accmSc.GetDepartmentsetupDic(null, cboDepartmentGroup.SelectedValue.ToString()), null);
            }

        }

        private void cboDepartmentGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Return)
            {
                cboDepartment.Focus();
            }
        }

      

    }
}
