using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.HRSR;

namespace AH.ModuleController.UI.HR.Forms
{
    public partial class frmNurseSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmNurseSetup()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNurseSetup_Load(object sender, EventArgs e)
        {
            cboDeptID.DisplayMember = "Value";
            cboDeptID.ValueMember = "Key";
            cboDeptID.DataSource = new BindingSource(hmsSC.GetDeptDictionary("D"), null);

            cboDesignation.DisplayMember = "Value";
            cboDesignation.ValueMember = "Key";
            cboDesignation.DataSource = new BindingSource(hmsSC.GetDesigDict("D"), null);

            cboUnitID.DisplayMember = "Value";
            cboUnitID.ValueMember = "Key";
            cboUnitID.DataSource = new BindingSource(hmsSC.GetUnitDict("D"), null);

            cboRoomNo.DisplayMember = "Value";
            cboRoomNo.ValueMember = "Key";
            cboRoomNo.DataSource = new BindingSource(hmsSC.GetRoomsDict("D"), null);

            FormatGrid();
            LoadListView();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtNurseID", "txtNurseName", "cboDeptID", "cboDesignation", "cboRoomNo", "txtDegree", "cboNurseType" };
            Control control = Utility.ReqFieldValidator(this,vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvNurseSetup, 1, txtNurseName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtNurseName.Focus();
                    return;
                }
                else
                {
                    Nurse nrs = this.populateNurseSetup();
                    short i = hmsSC.SaveNurse(nrs);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        RefreshGrid();
                        txtNurseID.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private Nurse populateNurseSetup()
        {
            Nurse nrs = new Nurse();
            nrs.ID = txtNurseID.Text;
            nrs.Name = txtNurseName.Text;
            nrs.NameBeng = txtNurseNameBeng.Text;
            nrs.Degree1 = txtDegree.Text;
            nrs.NurseType = "1";
            nrs.Signature = txtSignature.Text;

            Department dpt = new Department();
            dpt.DepartmentID = cboDeptID.SelectedValue.ToString();
            nrs.Department = dpt;

            DepartmentUnit dunit = new DepartmentUnit();
            dunit.UnitId = cboUnitID.SelectedValue.ToString();
            nrs.DepartmentUnit = dunit;

            Designation dsig = new Designation();
            dsig.DesignationId = cboDesignation.SelectedValue.ToString();
            nrs.Designation = dsig;

            Room rm = new Room();
            rm.RoomID = cboRoomNo.SelectedValue.ToString();
            nrs.Room = rm;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            nrs.EntryParameter = ep;

            return nrs;
        }
        private void FormatGrid()
        {
            lvNurseSetup.CheckBoxes = false;
            lvNurseSetup.Columns.Add("NurseID",150,HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("NurseName",250,HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("NurseNameBeng",0,HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("NurseType", 0, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("Degree", 0, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("Designation", 215, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("Department", 200, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("Unit", 150, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("RoomNo", 0, HorizontalAlignment.Left);
            lvNurseSetup.Columns.Add("Signature", 0, HorizontalAlignment.Left);
        }
        private void LoadListView()
        {
            lvNurseSetup.Items.Clear();

            List<Nurse> nurs = hmsSC.GetNurse().ToList();
            foreach (Nurse nrs in nurs)
            {
                ListViewItem itm = new ListViewItem(nrs.ID);
                itm.SubItems.Add(nrs.Name);
                itm.SubItems.Add(nrs.NameBeng);
                itm.SubItems.Add(nrs.NurseType);
                itm.SubItems.Add(nrs.Degree1);
                itm.SubItems.Add(nrs.Designation.DesignationTitle);
                itm.SubItems.Add(nrs.Department.DepartmentTitle);
                itm.SubItems.Add(nrs.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(nrs.Room.RoomID);
                itm.SubItems.Add(nrs.Signature);
                lvNurseSetup.Items.Add(itm);
            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }

        private void lvNurseSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNurseSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvNurseSetup.SelectedItems[0];
                txtNurseID.Text = itm.SubItems[0].Text;
                txtNurseName.Text = itm.SubItems[1].Text;
                txtNurseNameBeng.Text = itm.SubItems[2].Text;
                cboNurseType.SelectedText = itm.SubItems[3].Text;
                txtDegree.Text = itm.SubItems[4].Text;
                cboDesignation.Text = itm.SubItems[5].Text;
                cboDeptID.Text = itm.SubItems[6].Text;
                cboUnitID.Text = itm.SubItems[7].Text;
                cboRoomNo.SelectedValue = itm.SubItems[8].Text;
                txtSignature.Text = itm.SubItems[9].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtNurseID", "txtNurseName" };
            Control control = Utility.ReqFieldValidator(this, vf);

            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                Nurse nrs = this.populateNurseSetup();
                short i = hmsSC.ModifyNurse(nrs);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnNew.PerformClick();
                    RefreshGrid();
                    txtNurseID.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lvNurseSetup_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
       
    }
}
