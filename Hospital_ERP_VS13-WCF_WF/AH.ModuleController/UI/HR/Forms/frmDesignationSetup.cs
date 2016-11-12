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
using AH.ModuleController.UI.HR.Reports.Viewer;
namespace AH.ModuleController.UI.HR.Forms

{
    public partial class frmDesignationSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDesignationSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboDesigGroup", "cboDesigParent", "txtDesigName", "txtDesigNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Designation dsiobj = this.PopulateDsigSetup();
                if (Utility.IsDuplicateFoundInList(lvDsig, 1, txtDesigName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtDesigName.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveDesignation(dsiobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDesigName.Text = "";
                        txtDesigNameBeng.Text = "";
                        txtRemarks.Text = "";
                        //btnRefreshParent_Click(sender, e);
                        RefreshGrid();
                        txtDesigName.Focus();
                        
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
            if (cboDesigParent.SelectedValue != "")
            {
                LoadListView(cboDesigParent.SelectedValue.ToString());
            }
        }

        private void FormatGrid()
        {
            lvDsig.CheckBoxes = false;
            lvDsig.Columns.Add("ID", 100, HorizontalAlignment.Center);//0
            lvDsig.Columns.Add("Designation Name", 320, HorizontalAlignment.Left);//1
            lvDsig.Columns.Add("Designation Name(Beng)", 320, HorizontalAlignment.Left);//2
            lvDsig.Columns.Add("Designation Group",0, HorizontalAlignment.Left);//3
            lvDsig.Columns.Add("Level", 100, HorizontalAlignment.Center);//4
            lvDsig.Columns.Add("Parent Designation",0, HorizontalAlignment.Center);//5
            lvDsig.Columns.Add("Remarks", 245, HorizontalAlignment.Left);//6


        }

        private Designation PopulateDsigSetup()
        {           
            Designation tdsiobj = new Designation();
            tdsiobj.DesignationId = txtDesigID.Text;//0
            tdsiobj.DesignationTitle = txtDesigName.Text;//1
            tdsiobj.DesignationTitleBeng = txtDesigNameBeng.Text;//2   
            tdsiobj.DesignationLevel = txtDesigLevel.Text;//4
            tdsiobj.DesignationParentId = cboDesigParent.SelectedValue.ToString();//5
            tdsiobj.Remarks = txtRemarks.Text;//6           

            DesignationGroup grp = new DesignationGroup();
            grp.GroupId = cboDesigGroup.SelectedValue.ToString();//3
            tdsiobj.DesignationGroup = grp;
    
            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdsiobj.EntryParameter = ep;
            return tdsiobj;

        }

        private void frmDesignationSetup_Load(object sender, EventArgs e)
        {
            cboDepartmentType.DisplayMember = "Value";
            cboDepartmentType.ValueMember = "Key";
            cboDepartmentType.DataSource = new BindingSource(Utility.GetDeptTypes(), null);

            cboDesigParent.DisplayMember = "Value";
            cboDesigParent.ValueMember = "Key";
            cboDesigParent.DataSource = new BindingSource(hmsSC.GetDesigDict("D"), null);

            FormatGrid();
            RefreshGrid();
            txtDesigName.Focus();
        }
        private void LoadListView(string dsigr)
        {
            lvDsig.Items.Clear();
            if (cboDesigParent.SelectedValue != "")
            {
                List<Designation> dsig = hmsSC.GetDesignationParentWise(cboDesigParent.SelectedValue.ToString()).ToList();
                foreach (Designation ds in dsig)
                {
                    ListViewItem itm = new ListViewItem(ds.DesignationId);//0
                    itm.SubItems.Add(ds.DesignationTitle);//1
                    itm.SubItems.Add(ds.DesignationTitleBeng);//2
                    itm.SubItems.Add(ds.DesignationGroup.GroupId);//3
                    itm.SubItems.Add(ds.DesignationLevel);//4
                    itm.SubItems.Add(ds.DesignationParentId);//5
                    itm.SubItems.Add(ds.Remarks);  //6              
                    lvDsig.Items.Add(itm);

                }
            }


        }
        private void LoadAllListView()
        {
               lvDsig.Items.Clear();
                List<Designation> dsig = hmsSC.GetDesignation().ToList();
                foreach (Designation ds in dsig)
                {
                    ListViewItem itm = new ListViewItem(ds.DesignationId);//0
                    itm.SubItems.Add(ds.DesignationTitle);//1
                    itm.SubItems.Add(ds.DesignationTitleBeng);//2
                    itm.SubItems.Add(ds.DesignationGroup.GroupId);//3
                    itm.SubItems.Add(ds.DesignationLevel);//4
                    itm.SubItems.Add(ds.DesignationParentId);//5
                    itm.SubItems.Add(ds.Remarks);  //6              
                    lvDsig.Items.Add(itm);

                }

        }

        private void lvDsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsig.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDsig.SelectedItems[0];
                txtDesigID.Text = itm.SubItems[0].Text;
                txtDesigName.Text = itm.SubItems[1].Text;
                txtDesigNameBeng.Text = itm.SubItems[2].Text;               
                cboDesigGroup.SelectedValue = itm.SubItems[3].Text;                
                txtDesigLevel.Text = itm.SubItems[4].Text;
                cboDesigParent.Text = itm.SubItems[5].Text;
                txtRemarks.Text = itm.SubItems[6].Text;
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDesigID","cboDesigGroup", "cboDesigParent", "txtDesigName", "txtDesigNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyDsig(txtDesigID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesigID.Select();
                btnNew.PerformClick();
                return;

            }
            try
            {
                Designation dsiobj = this.PopulateDsigSetup();
                short i = hmsSC.UpdateDsig(dsiobj);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDesigName.Text = "";
                    txtDesigNameBeng.Text = "";
                    txtRemarks.Text = "";
                    //btnRefreshParent_Click(sender, e);
                    RefreshGrid();
                    txtDesigName.Focus();
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
        private void cboDesigParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesigParent.SelectedValue != "")
            {
                LoadListView(cboDesigParent.SelectedValue.ToString());
            }
        }

        private void lvDsig_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtDesigLevel.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtDesigLevel.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportViewer vr = new frmReportViewer();
            vr.selector = ViewerSelector.DesignationList;
            vr.ViewReport();
        }

        private void btnRefreshParent_Click(object sender, EventArgs e)
        {
            cboDesigParent.DisplayMember = "Value";
            cboDesigParent.ValueMember = "Key";
            cboDesigParent.DataSource = new BindingSource(hmsSC.GetDesignationType(cboDepartmentType.SelectedValue.ToString()), null);
        }

        private void txtDesigName_TextChanged(object sender, EventArgs e)
        {
            txtDesigNameBeng.Text = txtDesigName.Text;
        }

        private void cboDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDesigGroup.DisplayMember = "Value";
            cboDesigGroup.ValueMember = "Key";
            cboDesigGroup.DataSource = new BindingSource(hmsSC.GetDesignGrpTypeDict(cboDepartmentType.SelectedValue.ToString()), null);

            //cboDesigParent.DisplayMember = "Value";
            //cboDesigParent.ValueMember = "Key";
            //cboDesigParent.DataSource = new BindingSource(hmsSC.GetDesignationType(cboDepartmentType.SelectedValue.ToString()), null);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllListView();
        }

    }
}
