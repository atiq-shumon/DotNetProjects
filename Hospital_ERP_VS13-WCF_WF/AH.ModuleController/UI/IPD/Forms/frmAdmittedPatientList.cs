using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AH.ModuleController.IPDSR;
using AH.DUtility;

namespace AH.ModuleController.UI.IPD.Forms
{
    public partial class frmAdmittedPatientList : AH.Shared.UI.frmSmartFormStandard
    {
        IPDSR.IPDWSClient ipdSc = new IPDSR.IPDWSClient();
        public frmAdmittedPatientList()
        {
            InitializeComponent();
        }
        List<InPatient> patList;      
      //List<InPatient> inPats = new List<InPatient>();
        private void FormatGrid()
        {
            lstAdmittedPatientList.CheckBoxes = false;
            lstAdmittedPatientList.Columns.Add("Registration ID", 100, HorizontalAlignment.Center);
            lstAdmittedPatientList.Columns.Add("HCN", 100, HorizontalAlignment.Center);
            lstAdmittedPatientList.Columns.Add("Patient Name", 200, HorizontalAlignment.Left);
            lstAdmittedPatientList.Columns.Add("Cell Phone", 100, HorizontalAlignment.Left);
            lstAdmittedPatientList.Columns.Add("Department Name", 150, HorizontalAlignment.Left);
            lstAdmittedPatientList.Columns.Add("Unit", 150, HorizontalAlignment.Left);
            lstAdmittedPatientList.Columns.Add("Floor No", 50, HorizontalAlignment.Center);
            lstAdmittedPatientList.Columns.Add("Room No", 100, HorizontalAlignment.Center);
            lstAdmittedPatientList.Columns.Add("Bed No", 100, HorizontalAlignment.Center);
            lstAdmittedPatientList.Columns.Add("Advance Amount", 150, HorizontalAlignment.Right);

        }
        private void LoadListView()
        {
            lstAdmittedPatientList.Items.Clear();
            foreach (InPatient inPat in patList)
            {
                ListViewItem itm = new ListViewItem(inPat.RegistrationNo);
                itm.SubItems.Add(inPat.HCN.ToString());
                itm.SubItems.Add(inPat.Name.ToString());
                itm.SubItems.Add(inPat.CellPhone);
                itm.SubItems.Add(inPat.Department.DepartmentTitle);
                itm.SubItems.Add(inPat.DepartmentUnit.UnitTitle);
                itm.SubItems.Add(inPat.Room.Floor);
                itm.SubItems.Add(inPat.Room.RoomTitle);
                itm.SubItems.Add(inPat.Bed.BedTitle);
                itm.SubItems.Add(inPat.Payment.Amount.ToString());
                lstAdmittedPatientList.Items.Add(itm);
                
            }

        }

        private void frmAdmittedPatientList_Load(object sender, EventArgs e)
        {
                patList = ipdSc.GetAdmittedPatientList().ToList();
                FormatGrid();
                LoadListView();
                cboPatientDepartment();
                cboFloor();
                cboFloorNo.Enabled = false;
                txtPatientName.Enabled = false;
                cboPatDept.Enabled = false;

        }


        private void SearchPatientList()
        {            
               IEnumerable<InPatient> query = patList;

               if (cboFloorNo.Text != "--Select--")
               {
                   query = (from inPats in patList
                            where inPats.Room.Floor.StartsWith(cboFloorNo.Text.ToString())
                            select inPats);
               }
               if (cboPatDept.Text != "--Select--" && cboUnit.SelectedValue!=null &&cboFloorNo.Text.Length>0 && rdoSearchByDepartment.Checked==true)
               {
                   query = (from inPats in patList
                            where inPats.DepartmentUnit.UnitTitle.ToUpper().Contains(cboUnit.Text.ToUpper().ToString())
                            select inPats);
               }

               if (txtPatientName.Text.Length > 0 && cboPatDept.Text.Length > 0 && cboFloorNo.Text.Length > 0 && rdoNameWise.Checked == true)
                {                   
                    query = (from inPats in patList
                             where inPats.Name.ToUpper().Contains(txtPatientName.Text.ToUpper())                         
                             select inPats);
                }
                
                lstAdmittedPatientList.Items.Clear();

                foreach (InPatient inPat in query)
                {
                    ListViewItem itm = new ListViewItem(inPat.RegistrationNo);
                    itm.SubItems.Add(inPat.HCN);
                    itm.SubItems.Add(inPat.Name);
                    itm.SubItems.Add(inPat.CellPhone);
                    itm.SubItems.Add(inPat.Department.DepartmentTitle);
                    itm.SubItems.Add(inPat.DepartmentUnit.UnitTitle);
                    itm.SubItems.Add(inPat.Room.Floor);
                    itm.SubItems.Add(inPat.Room.RoomTitle);
                    itm.SubItems.Add(inPat.Bed.BedTitle);
                    itm.SubItems.Add(inPat.Payment.Amount.ToString());
                    lstAdmittedPatientList.Items.Add(itm);
                }
            //}
        }
      
        private void txtPatientName_KeyUp(object sender, KeyEventArgs e)
        {           
            SearchPatientList();
        }

        public void cboPatientDepartment()
        {         
            var oBedTypeCategories = patList.GroupBy(x => x.Department.DepartmentID).Select(g => g.First()).Distinct().ToList();
            List<Department> oDepts = new List<Department>();
           
            Department oDeptOuter = new Department();
            oDeptOuter.DepartmentID ="" ;
            oDeptOuter.DepartmentTitle = "--Select--";
            oDepts.Add(oDeptOuter);             
           
            foreach (var type in oBedTypeCategories)
            {               
                Department oDept = new Department();
                oDept.DepartmentID =type.Department.DepartmentID ;
                oDept.DepartmentTitle = type.Department.DepartmentTitle;
                oDepts.Add(oDept);             
            }           
            cboPatDept.DisplayMember = "DepartmentTitle";
            cboPatDept.ValueMember = "DepartmentID";
            cboPatDept.DataSource = new BindingSource(oDepts, null);
        }
        private void cboPatDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatDept.SelectedValue != "")
            {
                cboUnit.DisplayMember = "Value";
                cboUnit.ValueMember = "Key";
                cboUnit.DataSource = new BindingSource(Utility.VerifyDic(ipdSc.GetDeptUnitDic(Utility.GetDeptGroupCode(Utility.DeptGroupCode.Clinical), cboPatDept.SelectedValue.ToString())), null);
            }
           // if (cboPatDept.Text != "--Select--")          
        }
        public void cboFloor()
        {           
            var oBedTypeCategories = patList.GroupBy(x => x.Room.Floor).Select(g => g.First()).Distinct().ToList();
            List<Room> oRooms = new List<Room>();

            Room oRoomOuter = new Room();
            oRoomOuter.Floor = "--Select--";
            oRooms.Add(oRoomOuter); 
            foreach (var type in oBedTypeCategories)
            {
                Room oRoom = new Room();
                oRoom.Floor = type.Room.Floor;
                oRooms.Add(oRoom);
            }           
            cboFloorNo.DisplayMember = "Floor";       
            cboFloorNo.DataSource = new BindingSource(oRooms, null);
        }

        private void cboFloorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           SearchPatientList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAdmittedPatientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoNameWise_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoNameWise.Checked==true)
            {
                txtPatientName.Enabled = true;
                txtPatientName.Focus();
                rdoSearchByDepartment.Checked = false;
                rdoFloorWise.Checked = false;
            }
        }

        private void rdoSearchByDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchByDepartment.Checked == true)
            {
                cboFloorNo.Enabled = false;
                txtPatientName.Enabled = false;
                cboPatDept.Enabled = true;
            }

        }

        private void rdoFloorWise_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoFloorWise.Checked==true)
            {
                cboFloorNo.Enabled = true;
                txtPatientName.Enabled = false;
                cboPatDept.Enabled = false;
            }
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchPatientList();
        }

        private void btnRrefresh_Click(object sender, EventArgs e)
        {
            patList = ipdSc.GetAdmittedPatientList().ToList();
            LoadListView();
        }
    }
}
