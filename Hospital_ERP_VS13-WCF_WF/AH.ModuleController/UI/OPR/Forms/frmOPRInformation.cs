using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.OPRMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.OPR.Forms
{
    public partial class frmOPRInformation : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOPRInformation()
        {
            InitializeComponent();
        }


        #region "Validationfields"
        private bool ValidateFields()
        {
            List<string> vf = new List<string>() { "txtRemarks" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "Loadoperationtype"
        private void LoadOperationtype()
        {
            cboOperationType.ValueMember = "Key";
            cboOperationType.DisplayMember = "Value";
            cboOperationType.DataSource = new BindingSource(accmSc.GetOperationType("D"), null);
        }
        #endregion
        #region "Formatgrid"
        private void FormatGrid()
        {
            lvwOperationName.CheckBoxes = false;
            lvwOperationName.Columns.Add("Operation Id", 260, HorizontalAlignment.Left);
            lvwOperationName.Columns.Add("Operation Name", 400, HorizontalAlignment.Left);
            
        }
        #endregion
        #region "formLaod"
        private void frmOPRInformation_Load(object sender, EventArgs e)
        {
            try
            {
                LoadOperationtype();
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
        private OperationMaster PopulateOperationInfo()
        {
            OperationMaster objInfo = new OperationMaster();
            objInfo.OperationID = txtOtId.Text.ToString();
            objInfo.operationTitle  = txtOperationName.Text.ToString();
            objInfo.OperationTypeCode = cboOperationType.SelectedValue.ToString();
            
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            objInfo.EntryParameter = ep;
            return objInfo;
        }
        #endregion
        #region "LoadList"
        private void LoadListView()
        {
            try
            {
                lvwOperationName.Items.Clear();
                List<OperationMaster> objOpr = accmSc.GetoperationInformation().ToList();
                foreach (OperationMaster om in objOpr)
                {
                    ListViewItem itm = new ListViewItem(om.OperationID);
                    itm.SubItems.Add(om.operationTitle.ToString());
                    itm.SubItems.Add(om.OperationTypeCode.ToString());
                    lvwOperationName.Items.Add(itm);
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
        #region "Save/Edit/Delete"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                var strResponse = MessageBox.Show("Do You Want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    OperationMaster oprMaster = this.PopulateOperationInfo();
                    short i = accmSc.SavedOperationInfo(oprMaster);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtOperationName.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
                var strResponse = MessageBox.Show("Do You Want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {
                    OperationMaster oprMaster = this.PopulateOperationInfo();
                    short i = accmSc.UpdatOperationInfo(oprMaster);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtOperationName.Focus();
                        LoadListView();
                        btnSave.Enabled = true;
                        btnEdit.Enabled = false;
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var strResponse = MessageBox.Show("Do You Want to Delete?", "Delete Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (strResponse == DialogResult.Yes)
            {
                OperationMaster oprMaster = this.PopulateOperationInfo();
                short i = accmSc.DeleteOperationInfo(lvwOperationName.SelectedItems[0].Text, oprMaster);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtOperationName.Focus();
                    LoadListView();
                }
            }
        }
        #endregion
        #region "SelectedChange"
        private void lvwOperationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwOperationName.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                ListViewItem itm = lvwOperationName.SelectedItems[0];
                txtOtId.Text = itm.SubItems[0].Text;
                txtOperationName.Text = itm.SubItems[1].Text;
                cboOperationType.SelectedValue = itm.SubItems[2].Text;
                txtOperationName.Focus();

            }
        }
        #endregion
        #region "New"
        private void btnNew_Click(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtOperationName.Focus();

        }
        #endregion
        #region "Keypress"
        private void txtOperationName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cboOperationType.Focus();
            }
        }
        private void cboOperationType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
               btnSave.Focus();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Operation> objchek = accmSc.GetOperationStatus("A116-000011").ToList();
            //foreach (Operation strTest in objchek)
            //{
            //    MessageBox.Show(strTest.ToString());
            //}


        }




    }
}
