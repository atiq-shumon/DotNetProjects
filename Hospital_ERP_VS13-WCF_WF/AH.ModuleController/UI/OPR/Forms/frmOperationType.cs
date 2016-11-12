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
    public partial class frmOperationType : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOperationType()
        {
            InitializeComponent();
        }


        #region "Format Greid"
        private void FormatGrid()
        {
            lstOT.CheckBoxes = false;
            lstOT.Columns.Add("Type ID", 100, HorizontalAlignment.Center);
            lstOT.Columns.Add("Type Name", 200, HorizontalAlignment.Left);
            lstOT.Columns.Add("Type Name(Bangla)", 200, HorizontalAlignment.Left);
            lstOT.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }
        #endregion
        #region "Populatedoperationtype"
        private OperationType PopulateOperationType()
        {
            OperationType otobj = new OperationType();
            otobj.ID = txtTypeID.Text;
            otobj.Title = txtTypeName.Text;
            otobj.TitleBeng = txtTypeName.Text;
            otobj.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            otobj.EntryParameter = ep;

            return otobj;
        }
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            lstOT.Items.Clear();
            try
            {

                List<OperationType> otypes = accmSc.GetOperationConfig().ToList();
                // int i = 0;
                foreach (OperationType ot in otypes)
                {
                    ListViewItem itm = new ListViewItem(ot.ID);
                    itm.SubItems.Add(ot.Title);
                    itm.SubItems.Add(ot.TitleBeng);
                    itm.SubItems.Add(ot.Remarks);
                    lstOT.Items.Add(itm);
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
        #region "Save"
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeName" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lstOT, 1, txtTypeName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeName.Focus();
                    return;
                }
                OperationType otype = this.PopulateOperationType();
                short i = accmSc.SaveOperationType(otype);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Focus();
                    LoadListView();
                    btnSave.Enabled = true;
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
        #endregion
        #region "formLoad"
        private void frmOperationType_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadListView();
            txtTypeName.Select();
        }
        #endregion
        #region "Edit"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtTypeID", "txtTypeName", "txtTypeNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (accmSc.VerifyOperation(txtTypeID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeID.Select();
                btnNew.PerformClick();
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                return;
            }
            try
            {

                OperationType otype = this.PopulateOperationType();
                short i = accmSc.UpdateOperation(otype);
                if (i == 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtTypeName.Focus();
                    LoadListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        #endregion
        #region "SelectedindexChanged"
        private void lstOT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOT.SelectedItems.Count > 0)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ListViewItem itm = lstOT.SelectedItems[0];
                txtTypeID.Text = itm.SubItems[0].Text;
                txtTypeName.Text = itm.SubItems[1].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                txtTypeID.Select();
            }
        }
        #endregion
        #region "Click"
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtTypeName.Focus();
        }
        #endregion
        #region "Keypress"
        private void txtTypeName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //bool blngCheck = accmSc.GetOperationStatus("A116-000004");

        }

        


    }
}
