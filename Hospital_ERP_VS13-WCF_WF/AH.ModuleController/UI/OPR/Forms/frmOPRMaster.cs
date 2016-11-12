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
    public partial class frmOPRMaster : AH.Shared.UI.frmSmartFormStandard
    {
        OPRMSSR.OPRWSClient accmSc = new OPRMSSR.OPRWSClient();
        public frmOPRMaster()
        {
            InitializeComponent();
        }


        #region "LoadOperationtype"
        private void LoadOperationtype()
        {
            cboOperationType.ValueMember = "Key";
            cboOperationType.DisplayMember = "Value";
            cboOperationType.DataSource = new BindingSource(accmSc.GetOperationType("D"),null);
        }
        #endregion
        #region "LoadGrade"
        private void LoadGradeType()
        {
            cboGradeName.ValueMember = "Key";
            cboGradeName.DisplayMember = "Value";
            cboGradeName.DataSource = new BindingSource(accmSc.LoadGrade("D"), null);
        }
        #endregion
        #region "Anesthesia"
        private void LoadAnesthesiaID()
        {
            cboAnesthesiaName.ValueMember = "Key";
            cboAnesthesiaName.DisplayMember = "Value";
            cboAnesthesiaName.DataSource = new BindingSource(accmSc.LoadAnesthesiaID("D"), null);
        }
        #endregion
        #region "formLoad"
        private void frmOPRMaster_Load(object sender, EventArgs e)
        {
            try
            {
                FormatGrid();
                LoadOperationtype();
                LoadGradeType();
                LoadAnesthesiaID();
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
        #region "Validationfileds"
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
            if (cboActive.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboActive.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboOperationType.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboOperationType.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboAnesthesiaName.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboAnesthesiaName.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            if (cboGradeName.Text == "")
            {
                MessageBox.Show(Utility.getFMS(cboGradeName.Text) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            double dblAmount;
            double dblOprAmount;
            dblOprAmount = Utility.val(txtOperationFees.Text.ToString());
            dblAmount = (Utility.val(txtDoctorFees.Text.ToString())  + Utility.val( txtAnesthesiaFees.Text) + Utility.val(txtAssistantFees.Text));
            if (dblOprAmount != dblAmount)
            {
                //MessageBox.Show(Utility.getFMS(txtOperationFees.Text) + Utility.Req, "Amount Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMismatch.Text = "Mismatch Amount: " + (dblOprAmount - dblAmount).ToString();
                MessageBox.Show("Amount Mismatch");

                txtOperationFees.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region "Formatgrid"
        private void FormatGrid()
        {
            lvwOperationMaster.CheckBoxes = false;
            lvwOperationMaster.Columns.Add("Opr Id", 160, HorizontalAlignment.Center);
            lvwOperationMaster.Columns.Add("Title Name", 220, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Operation Type", 0, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Grade Name", 0, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Anesthesia Name", 0, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Opr Fees", 100, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Dr Fees", 100, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Anes Fees", 100, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Assiatant Fees", 120, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Time hour", 120, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Remarks", 100, HorizontalAlignment.Left);
            lvwOperationMaster.Columns.Add("Status", 100, HorizontalAlignment.Left);
        }
        #endregion
        #region "LoadListview"
        private void LoadListView()
        {
            lvwOperationMaster.Items.Clear();
            try
            {
                List<OperationMaster> oprMaster = accmSc.LoadOperationMaster().ToList();
                foreach (OperationMaster bo in oprMaster)
                {

                    ListViewItem itm = new ListViewItem(bo.OperationID);
                    itm.SubItems.Add(bo.operationTitle);
                    itm.SubItems.Add(bo.OperationTypeCode);
                    // itm.SubItems.Add(bo.operationTitleBang);
                    itm.SubItems.Add(bo.GradeID);
                    itm.SubItems.Add(bo.Anesthesiatitle);
                    itm.SubItems.Add(bo.OperationFees.ToString());
                    itm.SubItems.Add(bo.DrFees.ToString());
                    itm.SubItems.Add(bo.AnesFees.ToString());
                    itm.SubItems.Add(bo.AssistantFees.ToString());
                    itm.SubItems.Add(bo.ExpectedTimeHour.ToString());
                    itm.SubItems.Add(bo.Remarks);
                    if (bo.Active == "1")
                    {
                        itm.SubItems.Add("Active");
                    }
                    else
                    {
                        itm.SubItems.Add("Inactive");
                    }
                    lvwOperationMaster.Items.Add(itm);
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
        #region "PopulateMaster"
        private OperationMaster PopulateMaster()
        {
            {
                
                OperationMaster oprMaster = new OperationMaster();
                oprMaster.OperationID = txtOprID.Text.ToString();
                oprMaster.operationTitle = txtOperationTitle.Text.ToString();
                oprMaster.operationTitleBang = txtOperationTitle.Text.ToString();
                oprMaster.OperationTypeCode = cboOperationType.SelectedValue.ToString();
                oprMaster.GradeID = cboGradeName.SelectedValue.ToString();
                oprMaster.Anesthesiatitle = cboAnesthesiaName.SelectedValue.ToString();
                oprMaster.OperationFees = Convert.ToDouble(txtOperationFees.Text);
                oprMaster.DrFees = Convert.ToDouble(txtDoctorFees.Text);
                oprMaster.AnesFees = Convert.ToDouble(txtAnesthesiaFees.Text);
                oprMaster.AssistantFees = Convert.ToDouble(txtAssistantFees.Text);
                oprMaster.ExpectedTimeHour = Convert.ToDouble(txtexpectedHour.Text);
                oprMaster.Remarks = txtRemarks.Text.ToString();

                if (cboActive.Text.ToString() == "Active")
                {
                    oprMaster.Active = "1";
                }
                else
                {
                    oprMaster.Active = "0";
                }
                EntryParameter ep = new EntryParameter();
                ep.EntryBy = Utility.UserId;
                ep.CompanyID = Utility.CompanyID;
                ep.LocationID = Utility.LocationID;
                ep.MachineID = Utility.MachineID;
                oprMaster.EntryParameter = ep;
                return oprMaster;
            }
        }
        #endregion
        #region "Save/Edit"
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvwOperationMaster, 1, txtOperationTitle.Text) == true)
                {
                    MessageBox.Show("Cannot Insert Duplicate Value", "AGH Operation");
                    return;
                }

                var strResponse = MessageBox.Show("Do You  want to Save?", "Save Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    OperationMaster oprMas = this.PopulateMaster();
                    short i = accmSc.SaveOperationSetup(oprMas);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtOperationTitle.Focus();
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
        private void lvwOperationMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwOperationMaster.SelectedItems.Count > 0)
            {
                txtOprID.ReadOnly = true;
                ListViewItem itm = lvwOperationMaster.SelectedItems[0];
                txtOprID.Text = itm.SubItems[0].Text;
                txtOperationTitle.Text = itm.SubItems[1].Text;
                cboOperationType.SelectedValue = itm.SubItems[2].Text;
                cboGradeName.SelectedValue=itm.SubItems[3].Text;
                cboAnesthesiaName.SelectedValue=itm.SubItems[4].Text;
                txtOperationFees.Text =itm.SubItems[5].Text;
                txtDoctorFees.Text =itm.SubItems[6].Text;
                txtAnesthesiaFees.Text =itm.SubItems[7].Text;
                txtAssistantFees.Text = itm.SubItems[8].Text;
                txtexpectedHour.Text = itm.SubItems[9].Text;
                txtRemarks.Text = itm.SubItems[10].Text;
                if (itm.SubItems[11].Text == "Active")
                {
                    cboActive.Text = "Active";
                }
                else
                {
                    cboActive.Text = "Inactive";
                }
                txtOperationTitle.Select();

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

                var strResponse = MessageBox.Show("Do You  want to Update?", "Update Button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (strResponse == DialogResult.Yes)
                {

                    OperationMaster oprMas = this.PopulateMaster();
                    short i = accmSc.UpdateOperationSetup(oprMas);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        lblMismatch.Text = "";
                        txtOperationTitle.Focus();
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            lblMismatch.Text = "";
            txtOperationTitle.Focus();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }



    }
}
