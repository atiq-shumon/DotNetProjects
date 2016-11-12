using AH.ModuleController.ACMSSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using AH.ModuleController.UI.ACMS.Reports.ParameterForms;

namespace AH.ModuleController.UI.ACMS.Forms
{
    public partial class frmAccessLevel : AH.Shared.UI.frmSmartFormStandard
    {
        ACMSSR.ACMSWSClient clnt = new ACMSWSClient();
        public frmAccessLevel()
        {
            InitializeComponent();
        }

        List<AccessControlRO> oACROs = new List<AccessControlRO>();
        string Moduleid = "";
        int position = 0;
        private void frmAccessLevel_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Select();
            btnLoad.Visible = false;
            oACROs = clnt.GetUserAccessControl().ToList();

        } 
        public void StyleModuleGrid()
        {
            dgvModule.ClearSelection();
            #region ColumnSize
            dgvModule.Columns["Module_ID"].Width = 80;
            dgvModule.Columns["ModuleName"].Width = 220;
            dgvModule.Columns["Module_ID"].HeaderText = "ID";
            dgvModule.Columns["ModuleName"].HeaderText = "Module Name"; 
            #endregion
            
            #region Readonly
            dgvModule.Columns["Module_ID"].ReadOnly = true;
            dgvModule.Columns["ModuleName"].ReadOnly = true;
            #endregion
        }  
        public void StyleModuleGridInfo()
        {
            dgvModuleInfo.ClearSelection();
            #region ColumnSize
            dgvModuleInfo.Columns["Grp_Title"].Width = 150;
            dgvModuleInfo.Columns["Obj_Name"].Width = 150;
            dgvModuleInfo.Columns["ObjType"].Width = 80;
            dgvModuleInfo.Columns["Auth_Level"].Width = 150;

            dgvModuleInfo.Columns["Grp_Title"].HeaderText = "Group";
            dgvModuleInfo.Columns["Obj_Name"].HeaderText = "Object Name";
            dgvModuleInfo.Columns["ObjType"].HeaderText = "Type";
            dgvModuleInfo.Columns["Auth_Level"].HeaderText = "Authentication Level";

            #endregion
            #region ColumnVisibility
            dgvModuleInfo.Columns["Emp_ID"].Visible = false;
            dgvModuleInfo.Columns["Nick_Name"].Visible = false;
            dgvModuleInfo.Columns["E_Mail"].Visible = false;
            dgvModuleInfo.Columns["Grp_ID"].Visible = false;            
            dgvModuleInfo.Columns["Remarks"].Visible = false;
            dgvModuleInfo.Columns["Module_ID"].Visible = false;
            dgvModuleInfo.Columns["ModuleName"].Visible = false;
            dgvModuleInfo.Columns["Obj_Type"].Visible = false;
            dgvModuleInfo.Columns["Auth_Lvl"].Visible = false;
            dgvModuleInfo.Columns["ModuleName"].Visible = false;            
            #endregion
            #region Readonly
            dgvModuleInfo.Columns["Obj_Name"].ReadOnly = true;
            dgvModuleInfo.Columns["ObjType"].ReadOnly = true;
            dgvModuleInfo.Columns["Auth_Level"].ReadOnly = true;
            dgvModuleInfo.Columns["Grp_Title"].ReadOnly = true;
            #endregion
        }  
        public class TempAccessControl
        {
            public string Emp_ID { get; set; }
            public string Nick_Name { get; set; }
            public string E_Mail { get; set; }
            public string Grp_ID { get; set; }
            public string Grp_Title { get; set; }
            public string Remarks { get; set; }
            public string Module_ID { get; set; }
            public string ModuleName { get; set; }
            public string Obj_Name { get; set; }
            public string Obj_Type { get; set; }
            public string ObjType { get; set; }
            public string Auth_Lvl { get; set; }
            public string Auth_Level { get; set; }
        }  
        public class TempModule
        {
            public string Module_ID { get; set; }
            public string ModuleName { get; set; }             
        }  
        public class TempModuleInfromation
        {
            public string Emp_ID { get; set; }
            public string Nick_Name { get; set; }
            public string E_Mail { get; set; }
            public string Grp_ID { get; set; }
            public string Grp_Title { get; set; }
            public string Remarks { get; set; }
            public string Module_ID { get; set; }
            public string ModuleName { get; set; }
            public string Obj_Name { get; set; }
            public string Obj_Type { get; set; }
            public string ObjType { get; set; }
            public string Auth_Lvl { get; set; }
            public string Auth_Level { get; set; }
        }
        List<TempAccessControl> oTACs = new List<TempAccessControl>();
        List<TempModule> oTModules = new List<TempModule>();
        List<TempModuleInfromation> oTModuleIns = new List<TempModuleInfromation>();  
        private void MakeListbyEmployee()
        {
            List<TempAccessControl> oTACs = new List<TempAccessControl>();
            if (txtEmployeeID.Text != "")
            {
                for (int i = 0; i < oACROs.Count; i++)
                {
                    if (oACROs[i].Emp_ID.ToString() == txtEmployeeID.Text.ToString())
                    {
                        TempAccessControl oTAC = new TempAccessControl();
                        oTAC.Emp_ID = string.IsNullOrEmpty(oACROs[i].Emp_ID.ToString()) ? "0" : oACROs[i].Emp_ID.ToString();
                        oTAC.Nick_Name = string.IsNullOrEmpty(oACROs[i].Nick_Name.ToString()) ? "0" : oACROs[i].Nick_Name.ToString(); 
                        oTAC.E_Mail = string.IsNullOrEmpty(oACROs[i].E_Mail.ToString()) ? "0" : oACROs[i].E_Mail.ToString();
                        oTAC.Grp_ID = string.IsNullOrEmpty(oACROs[i].Grp_ID.ToString()) ? "0" : oACROs[i].Grp_ID.ToString();
                        oTAC.Grp_Title = string.IsNullOrEmpty(oACROs[i].Grp_Title.ToString()) ? "0" : oACROs[i].Grp_Title.ToString();
                        oTAC.Remarks = string.IsNullOrEmpty(oACROs[i].Remarks.ToString()) ? "0" : oACROs[i].Remarks.ToString();
                        oTAC.Module_ID = string.IsNullOrEmpty(oACROs[i].Module_ID.ToString()) ? "0" : oACROs[i].Module_ID.ToString();
                        oTAC.ModuleName = string.IsNullOrEmpty(oACROs[i].ModuleName.ToString()) ? "0" : oACROs[i].ModuleName.ToString();
                        oTAC.Obj_Name = string.IsNullOrEmpty(oACROs[i].Obj_Name.ToString()) ? "0" : oACROs[i].Obj_Name.ToString(); 
                        oTAC.Obj_Type = string.IsNullOrEmpty(oACROs[i].Obj_Type.ToString()) ? "0" : oACROs[i].Obj_Type.ToString();
                        oTAC.ObjType =  string.IsNullOrEmpty(oACROs[i].ObjType.ToString()) ? "0" : oACROs[i].ObjType.ToString(); 
                        oTAC.Auth_Lvl = string.IsNullOrEmpty(oACROs[i].Auth_Lvl.ToString()) ? "0" : oACROs[i].Auth_Lvl.ToString();
                        oTAC.Auth_Level = oACROs[i].Auth_Level.ToString();
                        oTACs.Add(oTAC);                         
                    }
                }
                if (oTACs.Count>0)
                {
                    if (oTACs.Count == 1)
                    {
                        if (oTACs[0].Module_ID == "0" && oTACs[0].ModuleName == "0")
                        {
                            dgvModule.DataSource = null;
                            dgvModuleInfo.DataSource = null;
                            return;
                        }
                    }
                    else 
                    {
                        MakeTempModule(oTACs);
                    }
                   
                }
            }
        } 
        private void MakeTempModule(List<TempAccessControl> oTACs)
        {
            
            List<TempModule> oTModules = new List<TempModule>();
            var distinctKeys = oTACs.Select(e => new { e.Module_ID, e.ModuleName})
                            .Distinct().ToList();

            for (int i = 0; i < distinctKeys.Count; i++)
            {
                
                TempModule oTModule = new TempModule();
                oTModule.Module_ID = distinctKeys[i].Module_ID.ToString();
                oTModule.ModuleName = distinctKeys[i].ModuleName.ToString();                    
                oTModules.Add(oTModule);                
            }
            dgvModule.DataSource = null;
            dgvModule.DataSource = oTModules;
            StyleModuleGrid();

                //var dupes = oTACs.GroupBy(x => new { x.Module_ID, x.ModuleName })
                //       .Where(x => x.Skip(1).Any()).ToList();



                //var groupedCustomerList = oTACs
                //    .GroupBy(u => u.Module_ID)
                //    .Select(grp => grp.ToList())
                //    .ToList();

                //dgvModule.DataSource = groupedCustomerList;

         
        }  
        private void MakeTempModuleInformation(string moduleID)
        {
            List<TempModuleInfromation> oTModuleIns = new List<TempModuleInfromation>();
            List<TempAccessControl> oTACs = new List<TempAccessControl>();
            if (txtEmployeeID.Text != "")
            {
                for (int i = 0; i < oACROs.Count; i++)
                {
                    if (oACROs[i].Emp_ID.ToString() == txtEmployeeID.Text.ToString())
                    {
                        TempAccessControl oTAC = new TempAccessControl();
                        oTAC.Emp_ID = string.IsNullOrEmpty(oACROs[i].Emp_ID.ToString()) ? "0" : oACROs[i].Emp_ID.ToString();
                        oTAC.Nick_Name = string.IsNullOrEmpty(oACROs[i].Nick_Name.ToString()) ? "0" : oACROs[i].Nick_Name.ToString();
                        oTAC.E_Mail = string.IsNullOrEmpty(oACROs[i].E_Mail.ToString()) ? "0" : oACROs[i].E_Mail.ToString();
                        oTAC.Grp_ID = string.IsNullOrEmpty(oACROs[i].Grp_ID.ToString()) ? "0" : oACROs[i].Grp_ID.ToString();
                        oTAC.Grp_Title = string.IsNullOrEmpty(oACROs[i].Grp_Title.ToString()) ? "0" : oACROs[i].Grp_Title.ToString();
                        oTAC.Remarks = string.IsNullOrEmpty(oACROs[i].Remarks.ToString()) ? "0" : oACROs[i].Remarks.ToString();
                        oTAC.Module_ID = string.IsNullOrEmpty(oACROs[i].Module_ID.ToString()) ? "0" : oACROs[i].Module_ID.ToString();
                        oTAC.ModuleName = string.IsNullOrEmpty(oACROs[i].ModuleName.ToString()) ? "0" : oACROs[i].ModuleName.ToString();
                        oTAC.Obj_Name = string.IsNullOrEmpty(oACROs[i].Obj_Name.ToString()) ? "0" : oACROs[i].Obj_Name.ToString();
                        oTAC.Obj_Type = string.IsNullOrEmpty(oACROs[i].Obj_Type.ToString()) ? "0" : oACROs[i].Obj_Type.ToString();
                        oTAC.ObjType = string.IsNullOrEmpty(oACROs[i].ObjType.ToString()) ? "0" : oACROs[i].ObjType.ToString();
                        oTAC.Auth_Lvl = string.IsNullOrEmpty(oACROs[i].Auth_Lvl.ToString()) ? "0" : oACROs[i].Auth_Lvl.ToString();
                        oTAC.Auth_Level = oACROs[i].Auth_Level.ToString();
                        oTACs.Add(oTAC);
                    }
                }
            }
            for (int i = 0; i < oTACs.Count; i++)
            {
                if (oTACs[i].Module_ID.ToString() == Moduleid.ToString())
                {
                    TempModuleInfromation oTModuleIn = new TempModuleInfromation();
                    oTModuleIn.Module_ID = oTACs[i].Module_ID.ToString();
                    oTModuleIn.ModuleName = oTACs[i].ModuleName.ToString();
                    oTModuleIn.Emp_ID = oTACs[i].Emp_ID.ToString();
                    oTModuleIn.Nick_Name = oTACs[i].Nick_Name.ToString();
                    oTModuleIn.E_Mail = oTACs[i].E_Mail.ToString();
                    oTModuleIn.Grp_ID = oTACs[i].Grp_ID.ToString();
                    oTModuleIn.Grp_Title = oTACs[i].Grp_Title.ToString();
                    oTModuleIn.Remarks = oTACs[i].Remarks.ToString();
                    oTModuleIn.Obj_Name = oTACs[i].Obj_Name.ToString();
                    oTModuleIn.Obj_Type = oTACs[i].Obj_Type.ToString();
                    oTModuleIn.Auth_Lvl = oTACs[i].Auth_Lvl.ToString();
                    oTModuleIn.Auth_Level = oTACs[i].Auth_Level.ToString();
                    oTModuleIn.ObjType = oTACs[i].ObjType.ToString();
                    oTModuleIns.Add(oTModuleIn);
                   }
            }

            dgvModuleInfo.DataSource = null;
            dgvModuleInfo.DataSource = oTModuleIns;
            StyleModuleGridInfo();
        }                                                                     
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //List<TempAccessControl> oTACs = new List<TempAccessControl>();
            //List<TempModule> oTModules = new List<TempModule>();
            //List<TempModuleInfromation> oTModuleIns = new List<TempModuleInfromation>();
            //dgvModule.DataSource = null;
            //dgvModuleInfo.DataSource = null;               
            //MakeListbyEmployee();
        } 
        private void dgvModule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Moduleid ="";
            position = 0;
            List<TempAccessControl> oTempACs = new List<TempAccessControl>();
            if (dgvModule.Rows.Count > 0)
            {                

                if (this.dgvModule.CurrentRow != null)
                {
                    position = dgvModule.CurrentRow.Index;
                    Moduleid = dgvModule.Rows[position].Cells["Module_ID"].Value.ToString();
                    MakeTempModuleInformation(Moduleid);                        
                }
            }
        }

        private void ReturnedData(string returnString, Object sender, EventArgs e)
        {
            txtEmployeeID.Text = returnString;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = null;
            dgvModuleInfo.DataSource = null;
            frmACMSSerach frm = new frmACMSSerach();
            frm.onPrintButtonClicked = new frmACMSSerach.PrintButtonClick(ReturnedData);
            frm.ShowDialog();
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            List<TempAccessControl> oTACs = new List<TempAccessControl>();
            List<TempModule> oTModules = new List<TempModule>();
            List<TempModuleInfromation> oTModuleIns = new List<TempModuleInfromation>();
            dgvModule.DataSource = null;
            dgvModuleInfo.DataSource = null;
            MakeListbyEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
