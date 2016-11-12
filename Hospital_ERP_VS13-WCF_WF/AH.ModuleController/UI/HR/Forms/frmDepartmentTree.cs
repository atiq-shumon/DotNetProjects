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
    public partial class frmDepartmentTree : AH.Shared.UI.frmSmartFormStandard
    {
        HRSR.HRWSClient hmsSC = new HRSR.HRWSClient();
        List<RptDepartment> Departments;       
        public frmDepartmentTree()
        {
            InitializeComponent();
        }
        public void LoadAllDepartment()
        {
            Departments = hmsSC.GetRptDepartment().ToList();
        }       
        private void PopulateTreeView()
        {

            List<DepartmentType> departmentTypes = new List<DepartmentType>();
            List<DepartmentGroup> departmentGroups = new List<DepartmentGroup>();
            List<Department> departments = new List<Department>();
            List<DeptUnitAss> departmentUnits = new List<DeptUnitAss>();

            DeptTreeView.Nodes.Clear();
            var varDepartmentTypes = Departments.GroupBy(c => c.DeptType).Select(g => g.First()).ToList();           
            var varDepartmentGroups = Departments.GroupBy(c => c.Dept_grp).Select(g => g.First()).ToList();
            var varDepartments = Departments.GroupBy(c => c.Dept_id).Select(g => g.First()).ToList();
            var varDepartmentUnits = Departments.GroupBy(c => c.UnitID).Select(g => g.First()).ToList();

            foreach (var type in varDepartmentTypes)
            {
                DepartmentType otype = new DepartmentType();
                otype.TypeID = type.TypeID;
                otype.TypeTitle = type.DeptType;
                departmentTypes.Add(otype);            
            }        
            foreach (var group in varDepartmentGroups)
            {
                DepartmentType dtype = new DepartmentType();
                DepartmentCategory oCategory = new DepartmentCategory();
                DepartmentGroup dg = new DepartmentGroup();
               
                dtype.TypeID = group.TypeID;
                oCategory.DepartmentType = dtype;
                dg.DepartmentType = dtype;

                oCategory.DepartmentCategoryID = group.Dept_category;
                dg.DepartmentCategory = oCategory;

                dg.DepartmentGroupID = group.Dept_grp;
                dg.DepartmentGroupTitle = group.Grp_title;

                departmentGroups.Add(dg);
            }
            foreach (var dept in varDepartments)
            {
                DepartmentType dtype = new DepartmentType();
                DepartmentCategory oCategory = new DepartmentCategory();
                DepartmentGroup dg = new DepartmentGroup();
                Department dep = new Department();

                dtype.TypeID = dept.DeptType;
                oCategory.DepartmentType = dtype;
                dep.DepartmentType = dtype;

                oCategory.DepartmentCategoryID = dept.Dept_category;
                dep.DepartmentCategory = oCategory;

                dg.DepartmentGroupID = dept.Dept_grp;
                dep.DepartmentGroup = dg;

                dep.DepartmentID = dept.Dept_id;
                dep.DepartmentTitle = dept.Dept_title;
                 
                departments.Add(dep);
            }
            foreach (var unit in varDepartmentUnits)
            {
                DepartmentType dtype = new DepartmentType();
                DepartmentCategory oCategory = new DepartmentCategory();
                DepartmentGroup dg = new DepartmentGroup();
                Department dep = new Department();
                DeptUnitAss dunit = new DeptUnitAss();
                DepartmentUnit uni = new DepartmentUnit();

                dtype.TypeID = unit.DeptType;
                oCategory.DepartmentType = dtype;
                dep.DepartmentType = dtype;
                

                oCategory.DepartmentCategoryID = unit.Dept_category;
                dep.DepartmentCategory = oCategory;

                dg.DepartmentGroupID = unit.Dept_grp;
                dep.DepartmentGroup = dg;

                dep.DepartmentID = unit.Dept_id;
                dep.DepartmentTitle = unit.Dept_title;
                dunit.Department = dep;

                uni.UnitId = unit.UnitID;
                uni.UnitTitle = unit.UnitTitle;
                dunit.DepartmentUnit = uni;

                departmentUnits.Add(dunit);
            }
           
           for (int i = 0; i <departmentTypes.Count ; i++)
            {
                DeptTreeView.Nodes.Add(departmentTypes[i].TypeTitle);          
                 
                  List<DepartmentGroup> departmentGroupTwo = departmentGroups.Where(x => x.DepartmentType.TypeID == departmentTypes[i].TypeID).ToList();
                    for (int j = 0; j < departmentGroupTwo.Count; j++)
                    {
                        DeptTreeView.Nodes[i].Nodes.Add(departmentGroupTwo[j].DepartmentGroupTitle);
                        DeptTreeView.Nodes[i].ForeColor = Color.Black;                        
                        DeptTreeView.Nodes[i].Tag = departmentGroupTwo[j].DepartmentGroupID;
                        //DeptTreeView.Nodes[i].ExpandAll();

                        List<Department> departmentTwo = departments.Where(x => x.DepartmentGroup.DepartmentGroupID == departmentGroupTwo[j].DepartmentGroupID).ToList();
                        for (int k = 0; k < departmentTwo.Count; k++)
                        {
                            DeptTreeView.Nodes[i].Nodes[j].Nodes.Add(departmentTwo[k].DepartmentTitle);
                            DeptTreeView.Nodes[i].Nodes[j].ForeColor = Color.Blue;
                            DeptTreeView.Nodes[i].Nodes[j].Tag = departmentTwo[k].DepartmentID;
                            //DeptTreeView.Nodes[i].Nodes[j].ExpandAll();
                            

                            List<DeptUnitAss> departmentUnitTwo = departmentUnits.Where(x => x.Department.DepartmentID == departmentTwo[k].DepartmentID).ToList();
                            for (int l = 0; l < departmentUnitTwo.Count; l++)
                            {
                                DeptTreeView.Nodes[i].Nodes[j].Nodes[k].Nodes.Add(departmentUnitTwo[l].DepartmentUnit.UnitTitle);
                                DeptTreeView.Nodes[i].Nodes[j].Nodes[k].ForeColor = Color.Brown;
                                DeptTreeView.Nodes[i].Nodes[j].Nodes[k].Tag = departmentUnitTwo[l].DepartmentUnit.UnitId;
                                //DeptTreeView.Nodes[i].Nodes[j].Nodes[k].ExpandAll();
                            }
                        }

                    }
               }              
        }
        private void frmDepartmentTree_Load(object sender, EventArgs e)
        {
            LoadAllDepartment();
            PopulateTreeView();
        }
       
        private void DeptTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {               
                for (int i = 0; i < DeptTreeView.Nodes.Count;i++ )
                {
                    for (int j = 0; j < DeptTreeView.Nodes[i].Nodes.Count; j++)
                    {
                        for (int k = 0; k < DeptTreeView.Nodes[i].Nodes[j].Nodes.Count; k++)
                        {
                            if (this.DeptTreeView.Nodes[i].IsSelected || this.DeptTreeView.Nodes[i].Nodes[j].IsSelected || this.DeptTreeView.Nodes[i].Nodes[j].Nodes[k].IsSelected)
                            {
                                if (this.DeptTreeView.Nodes[i].IsSelected)
                                {
                                    btnMenuAddDeptGrp.Enabled = true;
                                    btnMenuClose.Enabled = true;
                                    btnMenuClose.Enabled = true;
                                    btnMenuAddDept.Enabled = false;
                                    btnMenuAddUnit.Enabled = false;
                                }
                                if (this.DeptTreeView.Nodes[i].Nodes[j].IsSelected)
                                {
                                    btnMenuAddDept.Enabled = true;
                                    btnMenuClose.Enabled = true;
                                    btnMenuClose.Enabled = true;
                                    btnMenuAddDeptGrp.Enabled = false;
                                    btnMenuAddUnit.Enabled = false;
                                }
                                if (this.DeptTreeView.Nodes[i].Nodes[j].Nodes[k].IsSelected)
                                {
                                    btnMenuAddDeptGrp.Enabled = false;
                                    btnMenuClose.Enabled = true;
                                    btnMenuClose.Enabled = true;
                                    btnMenuAddDept.Enabled = false;
                                    btnMenuAddUnit.Enabled = true;
                                }
                                var relativeMousePosition = DeptTreeView.PointToClient(Cursor.Position);
                                this.ContxMenuTree.Show(DeptTreeView, relativeMousePosition);
                            }
                        }
                    }
                }
            }
        }
        private void btnMenuClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnMenuRefresh_Click(object sender, EventArgs e)
        {
            LoadAllDepartment();
            PopulateTreeView();
        }   
        private void btnMenuAddDept_Click(object sender, EventArgs e)
        {
            frmAssignOrganogram oDept = new frmAssignOrganogram();        
            oDept.ShowDialog();         
        }

        private void btnMenuAddDeptGrp_Click(object sender, EventArgs e)
        {
            frmDepartmentGroup oDeptGrp = new frmDepartmentGroup();
            if (DeptTreeView.SelectedNode.Text != null)
            {
                oDeptGrp.DeptType = DeptTreeView.SelectedNode.Text.ToString();
            }
            oDeptGrp.ShowDialog();    
        }

        private void btnMenuAddUnit_Click(object sender, EventArgs e)
        {
        //    frmDeptUnitAss oUnit = new frmDeptUnitAss();
        //    if (DeptTreeView.SelectedNode.Text != null)
        //    {
        //        oUnit.Dept = DeptTreeView.SelectedNode.Text.ToString();
        //    }
        //    oUnit.ShowDialog();  
        }      
    }
}
