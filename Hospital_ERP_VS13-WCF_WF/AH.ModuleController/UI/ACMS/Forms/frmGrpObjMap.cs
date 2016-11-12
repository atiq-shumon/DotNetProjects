using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.ACMSSR ;
//using AH.Shared.MODEL;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmGrpObjMap : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();

        List<GroupObjectMap> objMap = new List<GroupObjectMap>();
        List<ObjectSetup> oUserObjs = new List<ObjectSetup>();
        List<GroupObjectMap> oGroupObjectMaps = new List<GroupObjectMap>();
        EntryParameter oEntryParameter = new EntryParameter();
        private string objects = "";

        public frmGrpObjMap()
        {
            InitializeComponent();
            
        }

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

         private void LoadObjecType()
         {
             cboObjectType.ValueMember = "Key";
             cboObjectType.DisplayMember = "Value";
             cboObjectType.DataSource = new BindingSource(Utility.GetObjectTypes(), null);
         }

        
        private void frmGrpObjMap_Load(object sender, EventArgs e)
        {
            
            LoadModule();
            LoadUserGroupCombo();
            LoadObjecType();
          
            AddGridColumn(grdAllObjectName);
            AddGridColumn(grdAssignObjectName);

            grdAllObjectName.Columns[1].Visible = false;
            grdAssignObjectName.Columns[1].Visible = false;
            grdAllObjectName.Columns[3].Visible = false;
            grdAllObjectName.Columns[4].Visible = false;
            grdAssignObjectName.Columns[3].Visible = false;

         
            chkListboxAuthenticationLevel.DataSource = new BindingSource(new BindingSource(Utility.GetAuthenticationLevels(), null), null);
            chkListboxAuthenticationLevel.DisplayMember = "Value";
            chkListboxAuthenticationLevel.ValueMember = "Key";
      
        }

        
        private List<GroupObjectMap> PopulateObject()
        {
            List<GroupObjectMap> oGroupObjectMaps = new List<GroupObjectMap>();

            GroupObjectMap oGroupObjectMap = new GroupObjectMap();

            Module oModule = new Module();
            oModule.ModuleID = cboModule.SelectedValue.ToString();
            oGroupObjectMap.Module = oModule;

            UserGroup oUserGroup = new UserGroup();
            oUserGroup.GroupID = cboUserGroup.SelectedValue.ToString();
            oGroupObjectMap.UserGroup = oUserGroup;

            ObjectSetup oObjectSetup = new ObjectSetup();
            oObjectSetup.ObjType =cboObjectType.SelectedValue.ToString();
            oObjectSetup.ObjID = objects;       
            oGroupObjectMap.ObjectSetup = oObjectSetup;

            EntryParameter oEntryParameter = new EntryParameter();
            oEntryParameter.CompanyID = Utility.CompanyID;
            oEntryParameter.LocationID = Utility.LocationID;
            oEntryParameter.MachineID = Utility.MachineID;
            oEntryParameter.EntryBy = Utility.UserId;
            oEntryParameter.UpdateBy = Utility.UserId;
            oGroupObjectMap.EntryParameter = oEntryParameter;

            oGroupObjectMaps.Add(oGroupObjectMap);

            return oGroupObjectMaps;
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


            objects = "";

            for (int i = 0; i < grdAssignObjectName.Rows.Count; i++)
            {
                if (grdAssignObjectName.Rows[i].Cells[1].Value != null && grdAssignObjectName.Rows[i].Cells[3].Value != null)
                {
                    if (objects != "")
                    {
                        objects = grdAssignObjectName.Rows[i].Cells[1].Value.ToString() + ":" + grdAssignObjectName.Rows[i].Cells[3].Value + "," + objects;
                           
                    }
                    if (objects == "")
                    {
                        objects = grdAssignObjectName.Rows[i].Cells[1].Value.ToString() + ":" +grdAssignObjectName.Rows[i].Cells[3].Value+",";
                    }
                    
                }
            }

            
                if (MessageBox.Show("Are You Sure to Assign?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                   
                     try
                     {
                         oGroupObjectMaps = clnt.SaveGroupObjectMap(PopulateObject().ToArray()).ToList();
                         if (oGroupObjectMaps[0].EntryParameter.ErrorMessage == "")
                         {                          
                             btnShow.PerformClick();
                            // UncheckAllItems();
                             return;                           
                         }
                         if (oGroupObjectMaps[0].EntryParameter.ErrorMessage != "")
                         {
                             MessageBox.Show(oGroupObjectMaps[0].EntryParameter.ErrorMessage);
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

        private void grid_data_AllObject()
        {
            List<string> vf = new List<string>() { "cboModule", "cboUserGroup", "cboUserGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            grdAllObjectName.Rows.Clear();
            oUserObjs = clnt.GetsObjSetupCbo(cboModule.SelectedValue.ToString(), cboObjectType.SelectedValue.ToString(), cboUserGroup.SelectedValue.ToString()).ToList();
            for (int r = 0; r < oUserObjs.Count; r++)
            {
                grdAllObjectName.Rows.Add();               
            }

            int strdpt = 0;
            for (int rcont = 0; rcont < oUserObjs.Count; rcont++)
            {
                grdAllObjectName[0, rcont].Value = false;
                grdAllObjectName[1, strdpt].Value = oUserObjs[strdpt].ObjID.ToString();
                grdAllObjectName[2, strdpt].Value = oUserObjs[strdpt].ObjName.ToString();              
                strdpt++;
            }
            grdAllObjectName.AllowUserToAddRows = false;
        }

        private void grid_data_AssignedObject()
        {
            List<string> vf = new List<string>() { "cboModule", "cboUserGroup", "cboUserGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            grdAssignObjectName.Rows.Clear();
            objMap = clnt.GetsGroupObjectMap(cboModule.SelectedValue.ToString(), cboObjectType.SelectedValue.ToString(), cboUserGroup.SelectedValue.ToString()).ToList();
            for (int r = 0; r < objMap.Count; r++)
            {
                grdAssignObjectName.Rows.Add();
            }

            int strdpt = 0;
            for (int rcont = 0; rcont < objMap.Count; rcont++)
            {
                grdAssignObjectName[0, rcont].Value = false;
                grdAssignObjectName[1, strdpt].Value = objMap[strdpt].ObjectSetup.ObjID.ToString();
                grdAssignObjectName[2, strdpt].Value = objMap[strdpt].ObjectSetup.ObjName.ToString();
                grdAssignObjectName[3, strdpt].Value = objMap[strdpt].AuthLevID.ToString();
                grdAssignObjectName[4, strdpt].Value = objMap[strdpt].AuthenticationLevel.ToString();
                strdpt++;
              
            }
            grdAssignObjectName.AllowUserToAddRows = false;
        }


        private void btnShow_Click(object sender, EventArgs e)
         {
            List<string> vf = new List<string>() { "cboModule", "cboObjectType", "cboUserGroup"};
             Control control = Utility.ReqFieldValidator(this, vf);
             if (control != null)
             {
                 MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 control.Focus();
                 return;
             }

             grid_data_AllObject();
             grid_data_AssignedObject();
             UncheckAllItems();
             chkSelectAll.Checked = false;
             chkSelectAllObject.Checked = false;
           
        }

        private DataGridViewTextBoxColumn FormatGrid(string pname, string htext, int cwidth, Boolean true_false, string font, int fontsize, DataGridViewContentAlignment Algin)
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

        
        private void AddGridColumn(DataGridView dgv)
        {
            dgv.Columns.Add(CreateGridColumnchkFormat("CheckBox", "", 20, true, DataGridViewContentAlignment.BottomLeft, false, false, "checkbox"));
            dgv.Columns.Add(FormatGrid("", "", 0, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("ObjectName", "Object Name", 250, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleLeft));
            dgv.Columns.Add(FormatGrid("AuthenticationID", "Authentication ID", 100, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
            dgv.Columns.Add(FormatGrid("AuthenticationLevel", "Authentication Level", 200, true, "Microsoft Sans Serif", 8, DataGridViewContentAlignment.MiddleCenter));
         
            grdAssignObjectName.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        public DataGridViewCheckBoxColumn CreateGridColumnchkFormat(string pname, string htext, int cwidth, Boolean visibility, DataGridViewContentAlignment Algin, bool IsReadOnly, bool Isfrozen, string columnType)
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
        List<int> rows = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            chkSelectAll.Checked = false;
          
            List<string> vf = new List<string>() { "cboModule", "cboUserGroup", "chkListboxAuthenticationLevel" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }
            for (int i = 0; i < chkListboxAuthenticationLevel.Items.Count;i++)
            {
                if (chkListboxAuthenticationLevel.GetItemChecked(i))
                {
                    AddRemoveFromGrid(grdAllObjectName, grdAssignObjectName);
                    return;
                }
               
            }
                        
            MessageBox.Show("Please Select Object name and Authentication Level !!!");
                
        }

        private void AddRemoveFromGrid(DataGridView fromGrid, DataGridView toGrid)
        {
            rows.Clear();
            for (int i = 0; i < fromGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(fromGrid.Rows[i].Cells[0].Value) == true)
                {
                    string[] row = new string[] { fromGrid.Rows[i].Cells[0].Value.ToString(), fromGrid.Rows[i].Cells[1].Value.ToString(), fromGrid.Rows[i].Cells[2].Value.ToString() };
                    AddRowsToCollection(toGrid, row);
                    rows.Add(i);
                    toGrid.Rows[0].Cells[3].Value = chkListboxAuthenticationLevel.SelectedValue.ToString();
                    toGrid.Rows[0].Cells[4].Value = chkListboxAuthenticationLevel.Text;
                }
                
            }

            ResetCheckBox(toGrid);
            for (int i = rows.Count - 1; i >= 0; i--)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {       
            chkSelectAllObject.Checked = false;

            List<string> vf = new List<string>() { "cboModule", "cboUserGroup" };
            Control control = Utility.ReqFieldValidator(this, vf);
            if (control != null)
            {
                MessageBox.Show(Utility.getFMS(control.Name) + Utility.Req, Utility.MessageCaptionMsg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return;
            }

            AddRemoveFromGrid(grdAssignObjectName,grdAllObjectName);
        }
      
        private void chkListboxAuthenticationLevel_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chkListboxAuthenticationLevel.Items.Count; ++ix)            
                if (ix != e.Index) chkListboxAuthenticationLevel.SetItemChecked(ix, false);          
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {               
                for (int i = 0; i < grdAssignObjectName.RowCount; i++)
                {
                    grdAssignObjectName[0, i].Value = true;
                }             
            }
            else
            {
                for (int i = 0; i < grdAssignObjectName.RowCount; i++)
                {
                    grdAssignObjectName[0, i].Value = false;
                }
            }
                
        }

        private void chkSelectAllObject_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAllObject.Checked == true)
            {
                for (int i = 0; i < grdAllObjectName.RowCount; i++)
                {  
                  
                    grdAllObjectName[0, i].Value = true;
                  
                }
            }
            else
            {
                for (int i = 0; i < grdAllObjectName.RowCount; i++)
                {
                    grdAllObjectName[0, i].Value = false;

                }
            }
        }

        private void UncheckAllItems()
        {
            while (chkListboxAuthenticationLevel.CheckedIndices.Count > 0)
                chkListboxAuthenticationLevel.SetItemChecked(chkListboxAuthenticationLevel.CheckedIndices[0], false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdAllObjectName.Rows.Clear();
            grdAssignObjectName.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

    }
}
