using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using System.Linq;
using AH.ModuleController.ACMSSR;


namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmAssignUser : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmAssignUser()
        {
            InitializeComponent();
        }
        UserGroupAssign oUserGroupAssign = new UserGroupAssign();
        List<UserGroupAssign> oUserGroupAssigns = new List<UserGroupAssign>();
        EntryParameter oEntryParameter = new EntryParameter();
       

        private void LoadModule()
        {
            cboModule.ValueMember = "Key";
            cboModule.DisplayMember = "Value";
            cboModule.DataSource = new BindingSource(Utility.GetModuleNames(), null);
        }
        private void LoadUserGroupCombo()
        {
            List<UserGroup> oUserGroupBOs = new List<UserGroup>();
            oUserGroupBOs = clnt.GetsUserGroupCbo().ToList();
            cboUserGroup.DataSource = oUserGroupBOs;
            cboUserGroup.DisplayMember = "GroupTitle";
            cboUserGroup.ValueMember = "GroupID";
        }

        #region CreateGridAllUser
        public DataGridViewCheckBoxColumn Create_Grid_Column_chk(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
        {
            DataGridViewCheckBoxColumn Ckbox = new DataGridViewCheckBoxColumn();
            Ckbox.DataPropertyName = pname;
            Ckbox.HeaderText = htext;
            Ckbox.Name = pname;
            Ckbox.DefaultCellStyle.ForeColor = Color.Black;
            Ckbox.DefaultCellStyle.BackColor = Color.White;
            Ckbox.Visible = visibility;
            Ckbox.DefaultCellStyle.Alignment = Algin;
            Ckbox.Width = cwidth - 1;
            Ckbox.ReadOnly = IsReadOnly;
            Ckbox.Frozen = Isfrozen;
            
            return Ckbox;

        }
        private DataGridViewTextBoxColumn CreateAllUserGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Deptcolumn = new DataGridViewTextBoxColumn();
            Deptcolumn.DataPropertyName = pname;
            Deptcolumn.HeaderText = htext;
            Deptcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Deptcolumn.DefaultCellStyle.BackColor = Color.White;
            Deptcolumn.Visible = true_false;
            Deptcolumn.DefaultCellStyle.Alignment = Algin;
            Deptcolumn.Width = cwidth;
            Deptcolumn.ReadOnly = true;
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);

            return Deptcolumn;
        }
        private void AllUser_Grid()
        {
            grdAllUser.Columns.Add(Create_Grid_Column_chk("CheckBox", "", 20, true, DataGridViewContentAlignment.BottomLeft, false, false, "checkbox"));
            grdAllUser.Columns.Add(CreateAllUserGrid("EmpID", "Employee ID", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            grdAllUser.Columns.Add(CreateAllUserGrid("NickName", "Nick Name", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            grdAllUser.Columns.Add(CreateAllUserGrid("Department", "Department Name", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            grdAllUser.Columns.Add(CreateAllUserGrid("unit", "Unit Name", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            grdAllUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        #endregion

        #region CreateAssignUser
        private DataGridViewTextBoxColumn CreateAssignUser(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
        {
            DataGridViewTextBoxColumn Deptcolumn = new DataGridViewTextBoxColumn();
            Deptcolumn.DataPropertyName = pname;
            Deptcolumn.HeaderText = htext;
            Deptcolumn.DefaultCellStyle.ForeColor = Color.Black;
            Deptcolumn.DefaultCellStyle.BackColor = Color.White;
            Deptcolumn.Visible = true_false;
            Deptcolumn.DefaultCellStyle.Alignment = Algin;
            Deptcolumn.Width = cwidth;
            Deptcolumn.ReadOnly = true;
            Deptcolumn.DefaultCellStyle.Font = new Font(font, fontsize, FontStyle.Regular);

            return Deptcolumn;
        }
        private void AssignUser_Grid()
        {
            grdAssignUser.Columns.Add(Create_Grid_Column_chk("", "", 20, true, DataGridViewContentAlignment.BottomLeft, false, false, "checkbox"));
            grdAssignUser.Columns.Add(CreateAllUserGrid("EmpID", "Employee ID", 80, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            grdAssignUser.Columns.Add(CreateAllUserGrid("NickName", "Nick Name", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.TopLeft));
            grdAssignUser.Columns.Add(CreateAllUserGrid("Department", "Department Name", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            grdAssignUser.Columns.Add(CreateAllUserGrid("unit", "Unit Name", 150, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            grdAssignUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        #endregion

        private void grid_data_bind(string ModuleID, string GroupID)
        {
            grdAllUser.Rows.Clear();
            grdAllUser.AllowUserToAddRows = true;
            List<User> oUserBOs = new List<User>();
            oUserBOs = clnt.GetsUserNotAssigned(ModuleID, GroupID).ToList();
            for (int r = 0; r < oUserBOs.Count; r++)
            {
                grdAllUser.Rows.Add();
            }
            int strdpt = 0;
            for (int rcont = 0; rcont < oUserBOs.Count; rcont++)
            {
                grdAllUser[0, rcont].Value = false;
              //  strdpt = Convert.ToInt32(grdAllUser.RowCount.ToString());
                //strdpt = strdpt - 1;
                grdAllUser[1, strdpt].Value = oUserBOs[strdpt].EmpID.ToString();
                grdAllUser[2, strdpt].Value = oUserBOs[strdpt].NickName.ToString();
                grdAllUser[3, strdpt].Value = oUserBOs[strdpt].Department.DepartmentTitle.ToString();
                grdAllUser[4, strdpt].Value = oUserBOs[strdpt].DepartmentUnit.UnitTitle.ToString();
                strdpt++;

            }
            grdAllUser.AllowUserToAddRows = false;
        }

         List<User> oUserBOs = new List<User>();

        private void grid_data_AssignedUser()
        {
            if (cboModule.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Provide Module");
                return;
            }
            if (cboUserGroup.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Provide User Group");
                return;
            }
            grdAssignUser.Rows.Clear();
            oUserBOs = clnt.GetsAssignedUser(cboModule.SelectedValue.ToString(), cboUserGroup.SelectedValue.ToString()).ToList();
            for (int r = 0; r < oUserBOs.Count; r++)
            {
                grdAssignUser.Rows.Add();
            }

            int strdpt = 0;
            for (int rcont = 0; rcont < oUserBOs.Count; rcont++)
            {            
                grdAssignUser[0, rcont].Value = false; 
                grdAssignUser[1, strdpt].Value = oUserBOs[strdpt].EmpID.ToString();
                grdAssignUser[2, strdpt].Value = oUserBOs[strdpt].NickName.ToString();
                grdAssignUser[3, strdpt].Value = oUserBOs[strdpt].Department.DepartmentTitle.ToString();
                grdAssignUser[4, strdpt].Value = oUserBOs[strdpt].DepartmentUnit.UnitTitle.ToString();
                strdpt++;
            }
            grdAllUser.AllowUserToAddRows = false;
        }

        private void frmAssignUser_Load(object sender, EventArgs e)
        {
            AllUser_Grid();
            AssignUser_Grid();
            LoadModule();
            LoadUserGroupCombo();
        }
     
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            oUserBOs.Clear();
            List<string> vf = new List<string>() { "cboModule", "cboUserGroup"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            
             //   grdAllUser.AllowUserToDeleteRows = true;
                AddRemoveFromGrid(grdAllUser, grdAssignUser);
       }

        List<int>rows = new List<int>();
        private void AddRemoveFromGrid(DataGridView fromGrid, DataGridView toGrid)
        {
           rows.Clear();
            for (int i = 0; i <fromGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(fromGrid.Rows[i].Cells[0].Value) == true && fromGrid.Rows[i].Cells[1].Value!=null)
                {
                    string[] row = new string[] { fromGrid.Rows[i].Cells[0].Value.ToString(), fromGrid.Rows[i].Cells[1].Value.ToString(), fromGrid.Rows[i].Cells[2].Value.ToString(), fromGrid.Rows[i].Cells[3].Value.ToString(), fromGrid.Rows[i].Cells[4].Value.ToString() };
                    
                    AddRowsToCollection(toGrid, row);
                    rows.Add(i);
                }
            }

            ResetCheckBox(toGrid);
            for (int i = rows.Count-1; i >=0; i--)
            {
                fromGrid.Rows.RemoveAt(rows[i]);
            }
           
        }

        private void ResetCheckBox(DataGridView dtv)
        {
            foreach (DataGridViewRow row in dtv.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                chk.Value = CheckState.Unchecked;
            }
         
        }
        private void AddRowsToCollection(DataGridView dtv, string[] row)
        {
            DataGridViewRow rw = new DataGridViewRow();
            dtv.Rows.Insert(0, row);
        }


        private string UserIDs = "";

        private UserGroupAssign PopulateObject()
        {
            EntryParameter oEntryParameter = new EntryParameter();
            UserGroup oUserGroup = new UserGroup();
            Module oModule = new Module();

            oModule.ModuleID = cboModule.SelectedValue.ToString();
            oUserGroupAssign.EmpIDs = UserIDs;
           // oEntryParameter.EntryBy = UserIDs;
            oUserGroup.GroupID = cboUserGroup.SelectedValue.ToString();
            oEntryParameter.Active = "1";
            oEntryParameter.Version = "1";
            oEntryParameter.EntryBy = Utility.UserId;
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oUserGroupAssign.EntryParameter = oEntryParameter;
            oUserGroupAssign.UserGroup = oUserGroup;
            oUserGroupAssign.Module = oModule;

            return oUserGroupAssign;
        }
        private AccessControl LoginHistory()
        {
            AccessControl OAcc = new AccessControl();
            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.EntryBy = Utility.UserId;
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            OAcc.EntryParameter = oEntryParameter;
       
            return OAcc;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> vf = new List<string>() { "cboModule", "cboUserGroup"};
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            //if (cboModule.SelectedValue.ToString() == "")
            //{
            //    MessageBox.Show("Module Name Requires");
            //    return;
            //}

            //if (cboUserGroup.SelectedValue.ToString() == "")
            //{
            //    MessageBox.Show("User Group Requires");
            //    return;
            //}

            UserIDs = "";

            for (int i = 0; i < grdAssignUser.Rows.Count; i++)
            {
                if (grdAssignUser.Rows[i].Cells[1].Value != null)
                {
                    if (UserIDs != "")
                    {
                        UserIDs = grdAssignUser.Rows[i].Cells[1].Value.ToString()+ ":" +  UserIDs;
                    }
                    if (UserIDs == "")
                    {
                        UserIDs = grdAssignUser.Rows[i].Cells[1].Value.ToString() + ":";
                    }
                    //if (i == grdAssignUser.Rows.Count - 2)
                    //{
                    //    UserIDs = UserIDs + ":";
                    //}
                }
            }

            try
            {
                if (UserIDs == "" && grdAllUser.Rows.Count<=0)
                {
                    MessageBox.Show("Provide Data First");
                    return;
                }
                if (UserIDs == "" && grdAllUser.Rows.Count >0)
                {
                    for (int i = 0; i < grdAssignUser.Rows.Count; i++)
                    {
                        if (grdAllUser.Rows[i].Cells[1].Value != null)
                        {
                            if (UserIDs != "")
                            {
                                UserIDs = UserIDs + ":" + grdAllUser.Rows[i].Cells[1].Value.ToString();
                            }
                            if (UserIDs == "")
                            {
                                UserIDs = grdAllUser.Rows[i].Cells[1].Value.ToString();
                            }
                            //if (i == grdAllUser.Rows.Count - 2)
                            //{
                            //    UserIDs = UserIDs + ":";
                            //}
                        }
                    }
                   
                }
                if (MessageBox.Show("Are You Sure to Assign?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clnt.SaveLoginHistory(LoginHistory());
                   // oUserGroupAssign = clnt.SaveUserGroupAssign(PopulateObject());
                    short i = clnt.SaveUserGroupAssign(PopulateObject());
                    //if (oUserGroupAssign.EntryParameter.ErrorMessage == "")
                    //{
                    //    MessageBox.Show("Data Saved Successfully");
                    //    btnNew.PerformClick();
                    //}
                    //if (oUserGroupAssign.EntryParameter.ErrorMessage != "")
                    //{
                    //    MessageBox.Show(oUserGroupAssign.EntryParameter.ErrorMessage.ToString());
                    //}
                    if (i == 1)
                    {
                        MessageBox.Show(Utility.InsertMsg, Utility.MessageSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew.PerformClick();
                    }
                    else if(i==2)
                    {
                        MessageBox.Show("Object Is not Assign Yet,Please check !!!", Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                    }
                    else
                    {
                        MessageBox.Show(Utility.MistakeMsg, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cboModule.SelectedValue != null && cboUserGroup.SelectedValue != null)
            {
                if (cboModule.SelectedValue.ToString() != "" && cboUserGroup.SelectedValue.ToString() != "")
                {
                    grid_data_bind(cboModule.SelectedValue.ToString(), cboUserGroup.SelectedValue.ToString());
                }
            }

            grid_data_AssignedUser();
        }

        private void grdAssignUser_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            //position = 0;
            //position = grdAllUser.Rows.Count - 1;
            //int rPosition = 0;

            //if (grdAssignUser.Rows.Count > 0)
            //{
            //    rPosition = grdAssignUser.CurrentCell.RowIndex;
            //}

            //if (grdAssignUser.Rows[rPosition].Cells[0].Value == null)
            //{
            //    MessageBox.Show("Don't Select Empty Field");
            //    return;
            //}

            //try
            //{
            //    if (grdAllUser.Rows.Count <= 0)
            //    {
            //        List<TempListEmp> oTempListEmps = new List<TempListEmp>();
            //        TempListEmp oTempListEmp = new TempListEmp();
            //        oTempListEmp.EmpID = grdAssignUser.Rows[rPosition].Cells[0].Value.ToString();
            //        oTempListEmp.NickName = grdAssignUser.Rows[rPosition].Cells[1].Value.ToString();
            //        oTempListEmps.Add(oTempListEmp);
            //        grdAllUser.Rows.Clear();
            //        grdAssignUser.AllowUserToAddRows = true;
            //        for (int rcont = 0; rcont < oTempListEmps.Count; rcont++)
            //        {
            //            grdAllUser.Rows.Add();
            //            grdAllUser[1, 0].Value = oTempListEmps[0].EmpID.ToString();
            //            grdAllUser[2, 0].Value = oTempListEmps[0].NickName.ToString();
            //        }
            //        grdAssignUser.Rows.RemoveAt(rPosition);
            //        return;
            //    }

            //    if (grdAllUser.Rows.Count > 0)
            //    {
            //        List<TempListEmp> oTempListEmps = new List<TempListEmp>();

            //        for (int i = 0; i < grdAllUser.Rows.Count; i++)
            //        {
            //            TempListEmp oTempListEmp = new TempListEmp();
            //            oTempListEmp.EmpID = grdAllUser.Rows[i].Cells[1].Value.ToString();
            //            oTempListEmp.NickName = grdAllUser.Rows[i].Cells[2].Value.ToString();
            //            oTempListEmps.Add(oTempListEmp);
            //        }
            //        for (int i = 0; i < grdAssignUser.Rows.Count; i++)
            //        {
            //            if (i == rPosition)
            //            {
            //                TempListEmp oTempListEmp = new TempListEmp();
            //                oTempListEmp.EmpID = grdAssignUser.Rows[rPosition].Cells[0].Value.ToString();
            //                oTempListEmp.NickName = grdAssignUser.Rows[rPosition].Cells[1].Value.ToString();

            //                position = position + 1;
            //                oTempListEmps.Insert(position, oTempListEmp);
            //            }
            //        }

            //        grdAllUser.DataSource = null;
            //        grdAllUser.Rows.Clear();
            //        grdAssignUser.AllowUserToAddRows = true;

            //        for (int rcont = 0; rcont < oTempListEmps.Count; rcont++)
            //        {
            //            grdAllUser.Rows.Add();
            //            grdAllUser[1, rcont].Value = oTempListEmps[rcont].EmpID.ToString();
            //            grdAllUser[2, rcont].Value = oTempListEmps[rcont].NickName.ToString();
            //        }
            //        grdAssignUser.Rows.RemoveAt(rPosition);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AddRemoveFromGrid(grdAssignUser,grdAllUser);
            ResetCheckBox(grdAllUser);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdAllUser.Rows.Clear();
            grdAssignUser.Rows.Clear();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboModule.SelectedValue != null && cboUserGroup.SelectedValue != null)
            {
                if (txtSearch.Text.Length == 4)
                {
                    for (int row = 0; row < grdAllUser.Rows.Count; row++)
                    {
                        if (grdAllUser.Rows[row].Cells[1].Value.ToString() == txtSearch.Text)
                            grdAllUser.Rows[row].Cells[1].Selected = true;
                    }
                    
                }
                //if (txtSearch.Text == "")
                //{
                //    grdAllUser.Rows[0].Cells[1].Selected = true;
                //}
                                
            }
        
        }

        private void txtSearchAssignUser_TextChanged(object sender, EventArgs e)
        {
            if (cboModule.SelectedValue != null && cboUserGroup.SelectedValue != null)
            {
                if (txtSearchAssignUser.Text.Length == 4)
                {
                    for (int row = 0; row < grdAssignUser.Rows.Count; row++)
                    {
                        if (grdAssignUser.Rows[row].Cells[1].Value.ToString() == txtSearchAssignUser.Text)
                            grdAssignUser.Rows[row].Cells[1].Selected = true;
                    }

                }
                //if (txtSearch.Text == "")
                //{
                //    grdAllUser.Rows[0].Cells[1].Selected = true;
                //}

            }
        
        }

    }
}

