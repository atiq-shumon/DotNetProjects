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
    public partial class frmDepartmentGroup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public string DeptType { set; get; }
        public string TypeID { set; get; }
        public frmDepartmentGroup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() {"cboType", "txtGroupName", "txtGroupNameBeng"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                DepartmentGroup dgobj = this.PopulateDeptGRSetup();
                if (Utility.IsDuplicateFoundInList(lvDeptGrp, 1, txtGroupName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGroupName.Focus();
                    return;
                }
                else
                {
                    short i = hmsSC.SaveDeptGroup(dgobj);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption,MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void RefreshGrid()
        {
            LoadListView(cboType.SelectedValue.ToString());
        }

        private void FormatGrid()
        {
            lvDeptGrp.CheckBoxes = false;
            lvDeptGrp.Columns.Add("Group ID", 135, HorizontalAlignment.Center);
            lvDeptGrp.Columns.Add("Group Name", 220, HorizontalAlignment.Left);
            lvDeptGrp.Columns.Add("Group Name(Beng)", 220, HorizontalAlignment.Left);
            lvDeptGrp.Columns.Add("Remarks", 300, HorizontalAlignment.Left);
            lvDeptGrp.Columns.Add("Serial", 0, HorizontalAlignment.Left);
            lvDeptGrp.Columns.Add("catagory", 0, HorizontalAlignment.Left);


        }

        private DepartmentGroup PopulateDeptGRSetup()
        {
            DepartmentGroup tdgObj = new DepartmentGroup();
            tdgObj.DepartmentGroupID = txtGroupID.Text;
            tdgObj.DepartmentGroupTitle = txtGroupName.Text;
            tdgObj.DepartmentGroupTitleBeng = txtGroupNameBeng.Text;
            tdgObj.DepartmentTypeID = cboType.SelectedValue.ToString();

            //DepartmentType oDept = new DepartmentType();
            //oDept.TypeID = cboType.SelectedValue.ToString();
            //tdgObj.DepartmentType = oDept;           

            tdgObj.Remarks = txtRemarks.Text;
            //tdgObj.Serial =Convert.ToString(Convert.ToInt32(txtSerial.Text.ToString());

            EntryParameter ep = new EntryParameter();
            ep.CompanyID = Utility.CompanyID;
            ep.EntryBy = Utility.UserId;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            tdgObj.EntryParameter = ep;

            return tdgObj;

        }

        private void frmDepartmentGroup_Load(object sender, EventArgs e)
        {
            cboType.DisplayMember = "Value";
            cboType.ValueMember = "Key";
            cboType.DataSource =new BindingSource(Utility.GetDeptTypes(),null);

            if (DeptType != null)
            {
                cboType.Text = DeptType;
            }
            if (TypeID != null)
            {
                cboType.SelectedValue = TypeID;
            }

            FormatGrid();
            LoadListView(cboType.SelectedValue.ToString());
            txtGroupName.Focus();
        }

        private void LoadListView(string dptCat)
        {
            lvDeptGrp.Items.Clear();

            List<DepartmentGroup> depts = hmsSC.GetDeptGroupsByType(dptCat).ToList();
            foreach (DepartmentGroup dg in depts)
            {
                ListViewItem itm = new ListViewItem(dg.DepartmentGroupID);
                itm.SubItems.Add(dg.DepartmentGroupTitle);
                itm.SubItems.Add(dg.DepartmentGroupTitleBeng);
                itm.SubItems.Add(dg.Remarks);
                itm.SubItems.Add(dg.Serial.ToString());
                lvDeptGrp.Items.Add(itm);
            }

        }

        private void lvDeptGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDeptGrp.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDeptGrp.SelectedItems[0];
                txtGroupID.Text = itm.SubItems[0].Text;
                txtGroupName.Text = itm.SubItems[1].Text;
                txtGroupNameBeng.Text = itm.SubItems[2].Text;
                txtRemarks.Text = itm.SubItems[3].Text;
                txtSerial.Text = itm.SubItems[4].Text;
            }          
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtGroupID","cboType", "txtGroupName", "txtGroupNameBeng" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyDeptGr(txtGroupID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGroupID.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                DepartmentGroup dgobj = this.PopulateDeptGRSetup();
                short i = hmsSC.UpdateDeptGroup(dgobj);
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
        private void lvDeptGrp_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            txtGroupNameBeng.Text = txtGroupName.Text;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView(cboType.SelectedValue.ToString());
        }



        //public Boolean  IsDuplicateFoundInList(ListView lv, short columnIndex,string keyword)

        //{

        //    for (int i = 1; i < lv.Items.Count; i++)
        //    {
        //        ListViewItem itm = lv.Items[i];
        //       if (itm.SubItems[columnIndex].Text.ToString() == keyword.ToString())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}


    }
}



 


