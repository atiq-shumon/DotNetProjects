using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmDesignatonGroup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDesignatonGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupName", "txtGroupNameBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
               if( Utility.IsDuplicateFoundInList(lvDsigGr, 1, txtGroupName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtGroupName.Focus();
                    return;
                }
                else
                {
                    DesignationGroup dsigrobj = this.PopulateDsigGrSetup();
                    short i = hmsSC.SaveDesignationGr(dsigrobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtGroupName.Focus();
                        RefreshGrid();
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

        //public Boolean IsDuplicateFoundInList(ListView lvDsigGr, short i, string Name)
        //{

        //    for (i = 0; i < lvDsigGr.Items.Count; i++)
        //    {
        //        if (lvDsigGr.Items[i].SubItems[1].Text.ToString() == txtGroupName.Text.ToString()) ;
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}

        private void RefreshGrid()
        {
            LoadListView(cboType.SelectedValue.ToString());
        }
        private void FormatGrid()
        {
            lvDsigGr.CheckBoxes = false;
            lvDsigGr.Columns.Add("Group ID", 100, HorizontalAlignment.Center);
            lvDsigGr.Columns.Add("Group Name", 200, HorizontalAlignment.Left);
            lvDsigGr.Columns.Add("Group Name(Beng)", 200, HorizontalAlignment.Left);
            lvDsigGr.Columns.Add("Remarks", 340, HorizontalAlignment.Left);
        }

        private DesignationGroup PopulateDsigGrSetup()
        {
            DesignationGroup tdsiggr = new DesignationGroup();
            tdsiggr.GroupId = txtGroupID.Text;
            tdsiggr.GroupTitle = txtGroupName.Text;
            tdsiggr.GroupTitleBeng = txtGroupNameBeng.Text;
            tdsiggr.Remarks = txtRemarks.Text;
            DesignationType oDesigType = new DesignationType();
            oDesigType.TypeID = cboType.SelectedValue.ToString();
            tdsiggr.DesignationType = oDesigType;
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdsiggr.EntryParameter = ep;
            return tdsiggr;
        }
        private void frmDesignatonGroup_Load(object sender, EventArgs e)
        {
            cboType.DisplayMember = "Value";
            cboType.ValueMember = "Key";
            cboType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);
            FormatGrid();
            RefreshGrid();
            txtGroupName.Focus();
        }
        private void LoadListView(string Type)
        {
            lvDsigGr.Items.Clear();

            List<DesignationGroup> dsigr = hmsSC.GetDesignGrpType(Type).ToList();
            foreach (DesignationGroup dr in dsigr)
            {
                ListViewItem itm = new ListViewItem(dr.GroupId);
                itm.SubItems.Add(dr.GroupTitle);
                itm.SubItems.Add(dr.GroupTitleBeng);
                itm.SubItems.Add(dr.Remarks);
                lvDsigGr.Items.Add(itm);
            }

        }

        private void lvDsigGr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsigGr.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDsigGr.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupName" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyDesigGr(txtGroupID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroupID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                DesignationGroup dsigrobj = this.PopulateDsigGrSetup();
                short i = hmsSC.UpdateDsigGr(dsigrobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtGroupName.Focus();
                    RefreshGrid();
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

        private void lvDsigGr_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            txtGroupNameBeng.Text = txtGroupName.Text;
        }
    }
}
