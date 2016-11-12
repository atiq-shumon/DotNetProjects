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
    public partial class frmDoctorSetup : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        public frmDoctorSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDocName", "cboDeptID", "txtDocName", "txtDocNameBeng", "txtDegree1", "cboDesignation", "cboRoomNo" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            try
            {
                if (Utility.IsDuplicateFoundInList(lvDocSetup, 1, txtDocName.Text))
                {
                    MessageBox.Show("Cannot Insert Duplicate Name");
                    txtDocName.Focus();
                    return;
                }
                else
                {
                    Doctor doct = this.PopulateDocSetup();
                    short i = hmsSC.SaveDocSetup(doct);
                    if (i == 0)
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (i > 0)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                        txtDocName.Focus();
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void RefreshGrid()
        {
            LoadListView();
        }
        private Doctor PopulateDocSetup()
        {
            Doctor docobj = new Doctor();
            docobj.ID = txtDocID.Text;
            docobj.Name = txtDocName.Text;
            docobj.NameBeng = txtDocNameBeng.Text;
            docobj.Doctype = cboDoctorType.SelectedValue.ToString();
            docobj.Degree1 = txtDegree1.Text;
            docobj.Degree2 = txtDegree2.Text;
            docobj.Degree3 = txtDegree3.Text;
            docobj.Degree4 = txtDegree4.Text;
            //docobj.AvailableDays = txtAvailDays.Text;
            //docobj.AvailableDaysBeng = txtAvailDaysBeng.Text;
            //docobj.Signature = txtSignature.Text;

            Department tdept = new Department();
            tdept.DepartmentID = cboDeptID.SelectedValue.ToString();
            docobj.Department = tdept;

            DepartmentUnit tunit = new DepartmentUnit();
            tunit.UnitId = cboUnitID.SelectedValue.ToString();
            docobj.DepartmentUnit = tunit;

            Designation tdsig = new Designation();
            tdsig.DesignationId = cboDesignation.SelectedValue.ToString();
            docobj.Designation = tdsig;

            Room trm = new Room();
            trm.RoomID = cboRoomNo.SelectedValue.ToString();
            docobj.Room = trm;

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            docobj.EntryParameter = ep;

            return docobj;
        }

        private void FormatGrid()
        {
            lvDocSetup.CheckBoxes = false;
            lvDocSetup.Columns.Add("Doctor ID", 150, HorizontalAlignment.Center);
            lvDocSetup.Columns.Add("Doctor Name", 250, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Department", 200, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Unit", 150, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Designation", 215, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("DoctorNameBangla", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("DoctorType", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Degree1", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Degree2", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Degree3", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Degree4", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("RoomNo", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("AvailableDays", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("AvailableDaysBangla", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Signature", 0, HorizontalAlignment.Left);
            lvDocSetup.Columns.Add("Available Days", 340, HorizontalAlignment.Center);

        }

        private void frmDoctorSetup_Load(object sender, EventArgs e)
        {

            
            //cboDoctorType.DisplayMember = "Value";
            //cboDoctorType.ValueMember = "Key";
            //cboDoctorType.DataSource = new BindingSource(hmsSC.GetDoctorTypes(), null);
            
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
        private void LoadListView()
        {
            lvDocSetup.Items.Clear();

            List<Doctor> tdoc = hmsSC.GetDoctors().ToList();
            foreach (Doctor tdc in tdoc)
            {
                ListViewItem itm = new ListViewItem(tdc.ID);
                itm.SubItems.Add(tdc.Name);
                itm.SubItems.Add(tdc.Department.DepartmentTitle);
                itm.SubItems.Add(tdc.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(tdc.Designation.DesignationTitle);
                itm.SubItems.Add(tdc.NameBeng);
                itm.SubItems.Add(tdc.Doctype);
                itm.SubItems.Add(tdc.Degree1);
                itm.SubItems.Add(tdc.Degree2);
                itm.SubItems.Add(tdc.Degree3);
                itm.SubItems.Add(tdc.Degree4);
                itm.SubItems.Add(tdc.Room.RoomNo.ToString());
                itm.SubItems.Add(tdc.AvailableDays);
                itm.SubItems.Add(tdc.AvailableDaysBeng);
                itm.SubItems.Add(tdc.Signature);
                lvDocSetup.Items.Add(itm);


            }

        }

        private void lvDocSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDocSetup.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvDocSetup.SelectedItems[0];
                txtDocID.Text = itm.SubItems[0].Text;
                txtDocName.Text = itm.SubItems[1].Text;
                cboDeptID.Text = itm.SubItems[2].Text;
                cboUnitID.Text = itm.SubItems[3].Text;
                cboDesignation.Text = itm.SubItems[4].Text;
                txtDocNameBeng.Text = itm.SubItems[5].Text;
                cboDoctorType.SelectedValue = itm.SubItems[6].Text;
                txtDegree1.Text = itm.SubItems[7].Text;
                txtDegree2.Text = itm.SubItems[8].Text;
                txtDegree3.Text = itm.SubItems[9].Text;
                txtDegree4.Text = itm.SubItems[10].Text;
                cboRoomNo.Text = itm.SubItems[11].Text;
                //txtAvailDays.Text = itm.SubItems[12].Text;
                //txtAvailDaysBeng.Text = itm.SubItems[13].Text;
                //txtSignature.Text = itm.SubItems[14].Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "txtDocName" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            if (hmsSC.VerifyDocId(txtDocID.Text) == 0)
            {
                MessageBox.Show(Utility.VerifyMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocName.Select();
                btnNew.PerformClick();
                return;
            }
            try
            {
                Doctor doct = this.PopulateDocSetup();
                short i = hmsSC.UpdateDocSetup(doct);
                if (i == 0)
                {
                    MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (i > 0)
                {
                    MessageBox.Show(Utility.UpdateMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick();
                    txtDocName.Focus();
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void cboDeptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboUnitID.DisplayMember = "Value";
            cboUnitID.ValueMember = "Key";
            cboUnitID.DataSource = new BindingSource(Utility.VerifyDic(hmsSC.GetDeptUnitDic("D", cboDeptID.SelectedValue.ToString())), null);
        }

        private void lvDocSetup_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

  
    }
}
