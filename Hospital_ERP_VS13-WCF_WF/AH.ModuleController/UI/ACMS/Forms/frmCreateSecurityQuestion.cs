using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
//using AH.ModuleController.AccountsMSSR;
using AH.ModuleController.ACMSSR;
//using AH.Shared.MODEL;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmCreateSecurityQuestion : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmCreateSecurityQuestion()
        {
            InitializeComponent();
        }
        private bool SavePreRequisit()
        {
            List<string> vf = new List<string>() { "txtQTitle", "txtQTitleBangla" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }
        private bool EditDeletePreRequisit()
        {
            List<string> vf = new List<string>() { "txtQTitle", "txtQTitleBangla", "txtQID" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }
            return true;
        }
        SecurityQuestion oSecurityQuestionBO = new SecurityQuestion();
        EntryParameter oEntryParameter = new EntryParameter();
        private SecurityQuestion PopulateObject()
        {
            oSecurityQuestionBO.QID = txtQID.Text;
            oSecurityQuestionBO.QTitle = txtQTitle.Text;
            oSecurityQuestionBO.QTitleBangla = txtQTitleBangla.Text;
            oSecurityQuestionBO.Remarks = txtQRemarks.Text;
            //oSecurityQuestionBO.Active = "1";
            //oSecurityQuestionBO.Version = "1";
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;

            oSecurityQuestionBO.EntryParameter = oEntryParameter;
            return oSecurityQuestionBO;
        }
        private void LoadListView()
        {
            lvSecQuestion.Items.Clear();
            
            List<SecurityQuestion>  oSecurityQuestionBOs = clnt.GetsSecurityQuestions().ToList<SecurityQuestion>();
            foreach (SecurityQuestion fcat in oSecurityQuestionBOs)
            {
                ListViewItem itm = new ListViewItem(fcat.QID);
                itm.SubItems.Add(fcat.QTitle.ToString());
                itm.SubItems.Add(fcat.QTitleBangla.ToString());
                itm.SubItems.Add(fcat.Remarks.ToString());
                lvSecQuestion.Items.Add(itm);
            }
            this.lvSecQuestion.View = View.Details;
        }
        private void FormatGrid()
        {
            lvSecQuestion.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lvSecQuestion.Columns.Add("Question", 250, HorizontalAlignment.Center);
            lvSecQuestion.Columns.Add("Question Bangla", 250, HorizontalAlignment.Left);
            lvSecQuestion.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }


        private void frmCreateSecurityQuestion_Load(object sender, EventArgs e)
        {
            txtQTitle.Select();
            FormatGrid();
            LoadListView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            if (!SavePreRequisit())
            {
                return;
            }
            if (SavePreRequisit())
            {
                try
                {
                    oSecurityQuestionBO = clnt.SaveSecQuestion(PopulateObject());
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        btnNew.PerformClick();
                        return;
                    }
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oSecurityQuestionBO.EntryParameter.ErrorMessage.ToString());
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

        private void lvSecQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSecQuestion.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSecQuestion.SelectedItems[0];
                txtQID.Text = itm.SubItems[0].Text;
                txtQTitle.Text = itm.SubItems[1].Text;
                txtQTitleBangla.Text = itm.SubItems[2].Text;
                txtQRemarks.Text = itm.SubItems[3].Text;
            }
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!EditDeletePreRequisit())
            {
                return;
            }
            if (EditDeletePreRequisit())
            {
                try
                {
                    oSecurityQuestionBO = clnt.EditSecQuestion(PopulateObject());
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage == "")
                    {
                        MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnNew.PerformClick();
                        return;
                    }
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oSecurityQuestionBO.EntryParameter.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!EditDeletePreRequisit())
            {
                return;
            }
            if (EditDeletePreRequisit())
            {
                try
                {
                    oSecurityQuestionBO = clnt.DeleteSecQuest(txtQID.Text.ToString());
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage == "")
                    {
                        LoadListView();
                        btnNew.PerformClick();

                    }
                    if (oSecurityQuestionBO.EntryParameter.ErrorMessage != "")
                    {
                        MessageBox.Show(oSecurityQuestionBO.EntryParameter.ErrorMessage.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void txtQTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQTitleBangla.Focus();
            }
        }

        private void txtQTitleBangla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQRemarks.Focus();
            }
        }

        private void txtQRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtQTitle_TextChanged(object sender, EventArgs e)
        {
            txtQTitleBangla.Text = txtQTitle.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}
