using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.HRSR;
using AH.DUtility;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmSalaryHeadGroup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmSalaryHeadGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboHeadType", "txtHeadGroupTitle", "txtHeadGroupTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvSalHeadGrp, 3, txtHeadGroupTitle.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtHeadGroupTitle.Focus();
                    return;
                }
                else
                {                                     
                        SalaryHeadGroup oSalGrp = this.PopulateSalHdGrpSetup();
                        short i = hmsSC.SaveSalaryHeadGroup(oSalGrp);
                        if (i == 0)
                        {
                            MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (i > 0)
                        {
                            MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                            RefreshGrid();
                            txtHeadGroupTitle.Text = "";
                            txtHeadGroupTitleBeng.Text = "";
                            txtRemarks.Text = "";
                            txtHeadGroupTitle.Focus();
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
        private void RefreshGrid()
        {
            LoadListView();
        }
        private void FormatGrid()
        {
            lvSalHeadGrp.CheckBoxes = false;
            lvSalHeadGrp.Columns.Add("Head Type", 100, HorizontalAlignment.Left);
            lvSalHeadGrp.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvSalHeadGrp.Columns.Add("Head Group ID", 100, HorizontalAlignment.Left);
            lvSalHeadGrp.Columns.Add("Head Group Name", 200, HorizontalAlignment.Left);
            lvSalHeadGrp.Columns.Add("Head Group Name(Beng)", 200, HorizontalAlignment.Left);
            lvSalHeadGrp.Columns.Add("Remarks", 200, HorizontalAlignment.Left);
        }
        private SalaryHeadGroup PopulateSalHdGrpSetup()
        {
            SalaryHeadGroup oSalGrp = new SalaryHeadGroup();
            oSalGrp.HeadType = cboHeadType.SelectedValue.ToString();
            oSalGrp.HeadGroupID = txtHeadGroupID.Text;
            oSalGrp.HeadGroupTitle = txtHeadGroupTitle.Text;
            oSalGrp.HeadGroupTitleBeng = txtHeadGroupTitleBeng.Text;
            oSalGrp.SerialNumber = txtSerial.Text;

            oSalGrp.Remarks = txtRemarks.Text;

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.UpdateBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            oSalGrp.EntryParameter = ep;
            return oSalGrp;
        }
        private void frmSalaryHeadGroup_Load(object sender, EventArgs e)
        {
            cboHeadType.DisplayMember = "Value";
            cboHeadType.ValueMember = "Key";
            cboHeadType.DataSource = new BindingSource(Utility.GetSalaryTypes(),null);
            FormatGrid();
            LoadListView();
            txtHeadGroupTitle.Focus();
        }

        private void lvSalHeadGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSalHeadGrp.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvSalHeadGrp.SelectedItems[0];
                cboHeadType.SelectedValue = itm.SubItems[0].Text;
                txtSerial.Text = itm.SubItems[1].Text;
                txtHeadGroupID.Text = itm.SubItems[2].Text;
                txtHeadGroupTitle.Text = itm.SubItems[3].Text;
                txtHeadGroupTitleBeng.Text = itm.SubItems[4].Text;
                txtRemarks.Text = itm.SubItems[5].Text;
            }
        }
        private void LoadListView()
        {
            lvSalHeadGrp.Items.Clear();
            List<SalaryHeadGroup> oSalHdGrps = new List<SalaryHeadGroup>();
            oSalHdGrps = hmsSC.GetSalHeadGroupSetup(cboHeadType.SelectedValue.ToString()).ToList();
            foreach (SalaryHeadGroup salhdgrp in oSalHdGrps)
            {
                ListViewItem itm = new ListViewItem(salhdgrp.HeadType);
                itm.SubItems.Add(salhdgrp.SerialNumber);
                itm.SubItems.Add(salhdgrp.HeadGroupID);
                itm.SubItems.Add(salhdgrp.HeadGroupTitle);
                itm.SubItems.Add(salhdgrp.HeadGroupTitleBeng);               
                itm.SubItems.Add(salhdgrp.Remarks);
                lvSalHeadGrp.Items.Add(itm);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtHeadGroupID", "cboHeadType", "txtHeadGroupTitle", "txtHeadGroupTitleBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                SalaryHeadGroup oSalGrp = this.PopulateSalHdGrpSetup();
                short i = hmsSC.UpdateSalaryHeadGroup(oSalGrp);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    txtHeadGroupID.Text = "";
                    txtHeadGroupTitle.Text = "";
                    txtHeadGroupTitleBeng.Text = "";
                    txtRemarks.Text = "";
                    txtHeadGroupTitle.Focus();
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
        private void cboHeadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void lvSalHeadGrp_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtHeadGroupTitle_TextChanged(object sender, EventArgs e)
        {
            txtHeadGroupTitleBeng.Text = txtHeadGroupTitle.Text;
        }
    }
}
