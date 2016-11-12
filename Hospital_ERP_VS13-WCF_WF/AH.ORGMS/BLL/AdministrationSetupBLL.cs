using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ORGMS.DAL;
using AH.ORGMS.MODEL;
using AH.Shared.MODEL;


namespace AH.ORGMS.BLL
{
    public class AdministrationSetupBLL
    {
        public List<Department> GetDepartments()
        {
            return new AdministrationSetupDAL().GetDepartments();
        }
        public Dictionary<string, string> GetDepartments(string type)
        {
            Dictionary<string, string> deptDic = new Dictionary<string, string>();
            deptDic.Add("", "--Select--");
            foreach (Department dept in new AdministrationSetupDAL().GetDepartments())
            {
                deptDic.Add(dept.DepartmentID, dept.DepartmentTitle);
            }

            return deptDic;
        }
        public List<Department> GetDepartmentsetup(string deptgr)
        {
            return new AdministrationSetupDAL().GetDepartmentsetup(deptgr);
        }
        public List<DeptUnitAss> GetDeptSetup(string deptgr)
        {
            return new AdministrationSetupDAL().GetDeptSetup(deptgr);
        }

        public Dictionary<string, string> GetDepartmentsetup(string type, string deptgr)
        {
            Dictionary<string, string> deptDic = new Dictionary<string, string>();
            deptDic.Add("", "--Select--");
            foreach (Department dept in new AdministrationSetupDAL().GetDepartmentsetup(deptgr))
            {
                deptDic.Add(dept.DepartmentID, dept.DepartmentTitle);
            }

            return deptDic;
        }
        public Dictionary<string, string> GetDepartmentsetupDic(string type, string deptgr)
        {
            Dictionary<string, string> deptDic = new Dictionary<string, string>();
            foreach (DeptUnitAss dept in new AdministrationSetupDAL().GetDeptSetup(deptgr))
            {
                deptDic.Add(dept.Department.DepartmentID, dept.Department.DepartmentTitle);
            }
            return deptDic;
        }

        public Dictionary<string, string> GetDepartmentGroupWise(string deptgr)
        {
            Dictionary<string, string> deptDic = new Dictionary<string, string>();
            deptDic.Add("", "--Select--");
            foreach (Department dept in new AdministrationSetupDAL().GetDepartmentsetup(deptgr))
            {
                deptDic.Add(dept.DepartmentID, dept.DepartmentTitle);
            }

            return deptDic;
        }
        //public Dictionary<string, string> GetUnits()
        //{
        //    return new AdministrationSetupDAL().GetUnits();
        //}
        public int VerifyDeptSetup(string vdept)
        {
            return new AdministrationSetupDAL().VerifyDeptSetup(vdept);
        }
        public short SaveDept(Department dept)
        {
            return new AdministrationSetupDAL().SaveDept(dept);
        }
        public short UpdateDept(Department tdpt)
        {
            return new AdministrationSetupDAL().UpdateDept(tdpt);
        }
        public int VerifyDeptGr(string groupid)
        {
            return new AdministrationSetupDAL().VerifyDeptGr(groupid);
        }
        public short SaveDeptGroup(DepartmentGroup deptgr)
        {
            return new AdministrationSetupDAL().SaveDeptGroup(deptgr);
        }
        public short UpdateDeptGroup(DepartmentGroup tDptGr)
        {
            return new AdministrationSetupDAL().UpdateDeptGroup(tDptGr);
        }
        public List<Designation> GetDesignationParentWise(string dsigParent)
        {
            return new AdministrationSetupDAL().GetDesignationParentWise(dsigParent);
        }
        public int VerifyDsig(string dsigid)
        {
            return new AdministrationSetupDAL().VerifyDsig(dsigid);
        }
        public short SaveDesignation(Designation tdsig)
        {
            return new AdministrationSetupDAL().SaveDesignation(tdsig);
        }
        public short UpdateDsig(Designation udsig)
        {
            return new AdministrationSetupDAL().UpdateDsig(udsig);
        }
        public int VerifyDesigGr(string groupid)
        {
            return new AdministrationSetupDAL().VerifyDesigGr(groupid);
        }
        public short SaveDesignationGr(DesignationGroup dsiggr)
        {
            return new AdministrationSetupDAL().SaveDesignationGr(dsiggr);
        }
        public short UpdateDsigGr(DesignationGroup dsigGr)
        {
            return new AdministrationSetupDAL().UpdateDsigGr(dsigGr);
        }
        public int VerifyUnit(string unitid)
        {
            return new AdministrationSetupDAL().VerifyUnit(unitid);
        }
        public short SaveUnit(DepartmentUnit dunit)
        {
            return new AdministrationSetupDAL().SaveUnit(dunit);
        }
        public short UpdateUnit(DepartmentUnit dunit)
        {
            return new AdministrationSetupDAL().UpdateUnit(dunit);
        }
        public List<DepartmentGroup> GetDeptGroup()
        {
            return new AdministrationSetupDAL().GetDeptGroup();
        }
        public Dictionary<string, string> GetDeptGroup(string type)
        {
            Dictionary<string, string> deptDic = new Dictionary<string, string>();
            deptDic.Add("", "--Select--");
            foreach (DepartmentGroup deptGrp in new AdministrationSetupDAL().GetDeptGroup())
            {
                deptDic.Add(deptGrp.DepartmentGroupID, deptGrp.DepartmentGroupTitle);
            }

            return deptDic;
        }       
        public List<Designation> GetDesignation()
        {
            return new AdministrationSetupDAL().GetDesignation();
        }
        public Dictionary<string, string> GetDesignation(string type)
        {
            Dictionary<string, string> dsig = new Dictionary<string, string>();
            dsig.Add("", "--Select--");
            foreach (Designation tdsig in new AdministrationSetupDAL().GetDesignation())
            {
                dsig.Add(tdsig.DesignationId, tdsig.DesignationTitle);
            }
            return dsig;
        }
        public List<Designation> GetDesignationTypeWise(string DsigType)
        {
            return new AdministrationSetupDAL().GetDesignationTypeWise(DsigType);
        }
        public Dictionary<string, string> GetDesignationType(string type)
        {
            Dictionary<string, string> dsig = new Dictionary<string, string>();
            dsig.Add("", "--Select--");
            foreach (Designation tdsig in new AdministrationSetupDAL().GetDesignationTypeWise(type))
            {
                dsig.Add(tdsig.DesignationId, tdsig.DesignationTitle);
            }
            return dsig;
        }
        public List<DesignationGroup> GetDesignGrp()
        {
            return new AdministrationSetupDAL().GetDesignGrp();
        }
        public Dictionary<string, string> GetDesignGrp(string type)
        {
            Dictionary<string, string> dsigDic = new Dictionary<string, string>();
            dsigDic.Add("", "--Select--");
            foreach (DesignationGroup dsigGrp in new AdministrationSetupDAL().GetDesignGrp())
            {
                dsigDic.Add(dsigGrp.GroupId, dsigGrp.GroupTitle);
            }
            return dsigDic;

        }
        public List<DesignationGroup> GetDesignGrpType(string Type)
        {
            return new AdministrationSetupDAL().GetDesignGrpType(Type);
        }
        public Dictionary<string, string> GetDesignGrpTypeDict(string type)
        {
            Dictionary<string, string> dsigDic = new Dictionary<string, string>();
            dsigDic.Add("", "--Select--");
            foreach (DesignationGroup dsigGrp in new AdministrationSetupDAL().GetDesignGrpType(type))
            {
                dsigDic.Add(dsigGrp.GroupId, dsigGrp.GroupTitle);
            }
            return dsigDic;
        }
        public List<DepartmentUnit> GetUnit(string Dept)
        {
            return new AdministrationSetupDAL().GetUnit(Dept);
        }
        public List<DepartmentUnit> GetUnits()
        {
             return new AdministrationSetupDAL().GetUnits();
        }
        public List<DeptUnitAss> GetUnitList(string deptid)
        {
            return new AdministrationSetupDAL().GetUnitList(deptid);
        }
        public Dictionary<string, string> GetUnitDictionary(string type,string Dept)
        {
            Dictionary<string, string> tunit = new Dictionary<string, string>();
            tunit.Add("", "--Select--");
            foreach (DeptUnitAss unt in new AdministrationSetupDAL().GetUnitList(Dept))
            {
                tunit.Add(unt.DepartmentUnit.UnitId, unt.DepartmentUnit.UnitTitle);
            }
            return tunit;
        }
        public Dictionary<string, string> GetUnitDict(string Dept)
        {
            Dictionary<string, string> tunit = new Dictionary<string, string>();
            tunit.Add("", "--Select--");
            foreach (DepartmentUnit unt in new AdministrationSetupDAL().GetUnit(Dept))
            {
                tunit.Add(unt.UnitId, unt.UnitTitle);
            }
            return tunit;
        }
        
        public int VerifyDocId(string docid)
        {
            return new AdministrationSetupDAL().VerifyDocId(docid);
        }
        
        public short SaveDeptUnitAss(DeptUnitAss dasign)
        {
            return new AdministrationSetupDAL().SaveDeptUnitAss(dasign);
        }
        public short EditDeptUnitAss(DeptUnitAss dasign)
        {
            return new AdministrationSetupDAL().EditDeptUnitAss(dasign);
        }
        public List<DeptUnitAss> GetDeptUnitAssign()
        {
            return new AdministrationSetupDAL().GetDeptUnitAssign();
        }
        public List<DeptUnitAss> GetDeptUnitAssigned(string DeptGrp, string deptid)
        {
            return new AdministrationSetupDAL().GetDeptUnitAssigned(DeptGrp,deptid);
        }
        public List<DeptUnitAss> GetAssignedUnit(string DeptGroup,string Department)
        {
            return new AdministrationSetupDAL().GetAssignedUnit(DeptGroup, Department);
        }
        public Dictionary<string, string> GetDeptUnitDic(string DeptGrp, string deptid)
        {
            Dictionary<string, string> dptunt = new Dictionary<string, string>();
            foreach (DeptUnitAss dpt in new AdministrationSetupDAL().GetDeptUnitAssigned(DeptGrp,deptid))
            {
                dptunt.Add(dpt.DepartmentUnit.UnitId, dpt.DepartmentUnit.UnitTitle);
            }
            return dptunt;
        }
        public string verifyDeptUnitAssign(string dept, string unit)
        {
            return new AdministrationSetupDAL().verifyDeptUnitAssign(dept,unit);
        }
        public List<DeptUnitAss> GetGroupDeptUnit(string DeptGroup)
        {
            return new AdministrationSetupDAL().GetGroupDeptUnit(DeptGroup);
        }
        
        public List<Designation> GetDesignationGrpWise(string dsigr)
        {
            return new AdministrationSetupDAL().GetDesignationGrpWise(dsigr);
        }
        public Dictionary<string, string> GetDesignationGroupWise(string type, string dsigr)
        {
            Dictionary<string, string> dsr = new Dictionary<string, string>();
            dsr.Add("", "--Select--");
            foreach (Designation gr in new AdministrationSetupDAL().GetDesignationGrpWise(dsigr))
            {
                dsr.Add(gr.DesignationId,gr.DesignationTitle);

            }
            return dsr;
        }

        public List<DepartmentGroup> GetGroupUnderCategory(string oGrp)
        {
            return new AdministrationSetupDAL().GetGroupUnderCategory(oGrp);
        }
        public Dictionary<string, string> GetGroupCategory(string oGrpCat)
        {
            Dictionary<string, string> oCat = new Dictionary<string, string>();
            oCat.Add("", "--Select--");
            foreach (DepartmentGroup gr in new AdministrationSetupDAL().GetGroupUnderCategory(oGrpCat))
            {
                oCat.Add(gr.DepartmentGroupID, gr.DepartmentGroupTitle);

            }
            return oCat;
        }
        public List<Department> GetDeptUnderGroup(string oGrp)
        {
            return new AdministrationSetupDAL().GetDeptUnderGroup(oGrp);
        }
        public Dictionary<string, string> GetDeptByGroup(string oDept)
        {
            Dictionary<string, string> oDeptDic = new Dictionary<string, string>();
            oDeptDic.Add("", "--Select--");
            foreach (Department gr in new AdministrationSetupDAL().GetDeptUnderGroup(oDept))
            {
                oDeptDic.Add(gr.DepartmentID, gr.DepartmentTitle);

            }
            return oDeptDic;
        }
        public List<Designation> GetDesigUnderGroup(string oGrp)
        {
            return new AdministrationSetupDAL().GetDesigUnderGroup(oGrp);
        }
     
         public List<DepartmentGroup> GetDeptGroupsByType(string dptType)
        {
            return new AdministrationSetupDAL().GetDeptGroupsByType(dptType);  
        }
         public Dictionary<string, string> GetDeptGroupDicByType(string type)
         {
             Dictionary<string, string> deptDic = new Dictionary<string, string>();
             foreach (DepartmentGroup deptGrp in new AdministrationSetupDAL().GetDeptGroupsByType(type))
             {
                 deptDic.Add(deptGrp.DepartmentGroupID, deptGrp.DepartmentGroupTitle);
             }

             return deptDic;
         }
         public List<DistrictThana> GetDistrict()
         {
             return new AdministrationSetupDAL().GetDistrict();  
         }
         public Dictionary<string, string> GetDistrictDict(string type)
         {
             Dictionary<string, string> deptDic = new Dictionary<string, string>();
             deptDic.Add("", "--Select--");
             foreach (DistrictThana deptGrp in new AdministrationSetupDAL().GetDistrict())
             {
                 deptDic.Add(deptGrp.DistName, deptGrp.DistName);
             }

             return deptDic;
         }
         public short SaveThana(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupDAL().SaveThana(oDistrictThana); 
         }
         public short UpdateThana(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupDAL().UpdateThana(oDistrictThana); 
         }
         public List<DistrictThana> GetThana(string District)
         {
             return new AdministrationSetupDAL().GetThana(District); 
         }
         public Dictionary<string, string> GetThanaDict(string District)
         {
             Dictionary<string, string> ThanaDic = new Dictionary<string, string>();
             ThanaDic.Add("", "--Select--");
             foreach (DistrictThana Dist in new AdministrationSetupDAL().GetThana(District))
             {
                 ThanaDic.Add(Dist.ThanaName, Dist.ThanaName);
             }

             return ThanaDic;
         }
         public List<DistrictThana> GetDistrictAndThana()
         {
             return new AdministrationSetupDAL().GetDistrictAndThana(); 
         }
         public short SavePostOffice(DistrictThana oDistrictThana)
         {
             return new AdministrationSetupDAL().SavePostOffice(oDistrictThana); 
         }
        public short UpdatePostOffice(DistrictThana oDistrictThana)
        {
            return new AdministrationSetupDAL().UpdatePostOffice(oDistrictThana); 
        }
        public List<DistrictThana> GetPostOffice(string District, string Thana)
         {
             return new AdministrationSetupDAL().GetPostOffice(District,Thana); 
         }
        public Dictionary<string, string> GetPostOfficeDict(string District, string Thana)
        {
            Dictionary<string, string> PostOfficeDict = new Dictionary<string, string>();
            PostOfficeDict.Add("", "--Select--");
            foreach (DistrictThana oPostOffice in new AdministrationSetupDAL().GetPostOffice(District, Thana))
            {
                PostOfficeDict.Add(oPostOffice.PostCode, oPostOffice.PostOfficeName + "-" + oPostOffice.PostCode);
            }
            return PostOfficeDict;
        }
        public short SaveBankSetup(BankInfo oBank)
        {
            return new AdministrationSetupDAL().SaveBankSetup(oBank); 
        }
         public short UpdateBankSetup(BankInfo oBank)
        {
            return new AdministrationSetupDAL().UpdateBankSetup(oBank);
        }
         public List<BankInfo> GetBankSetup()
         {
             return new AdministrationSetupDAL().GetBankSetup();
         }
         public Dictionary<string, string> GetBankDict(string type)
         {
             Dictionary<string, string> BankDic = new Dictionary<string, string>();
             BankDic.Add("", "--Select--");
             foreach (BankInfo oBank in new AdministrationSetupDAL().GetBankSetup())
             {
                 BankDic.Add(oBank.BankID, oBank.BankTitle);
             }

             return BankDic;
         }
         public short SaveOrganogram(Organogram oOrganogram)
         {
             return new AdministrationSetupDAL().SaveOrganogram(oOrganogram);
         }
         public List<Organogram> GetOrganogramSetup(string DepartmentGroup, string Department, string Unit)
         {
             return new AdministrationSetupDAL().GetOrganogramSetup(DepartmentGroup, Department, Unit);
         }
         public Dictionary<string, string> GetOrganogramDesig(string DepartmentGroup, string Department, string Unit)
         {
             Dictionary<string, string> DesigDic = new Dictionary<string, string>();
             DesigDic.Add("", "--Select--");
             foreach (Organogram oDesig in new AdministrationSetupDAL().GetOrganogramSetup(DepartmentGroup, Department, Unit))
             {
                 DesigDic.Add(oDesig.Designation.DesignationId, oDesig.Designation.DesignationTitle);
             }

             return DesigDic;
         }
         public short SaveFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
         {
             return new AdministrationSetupDAL().SaveFoodSubsidySetup(oFoodSubsidy);
         }
         public string UpdateFoodSubsidySetup(FoodSubsidy oFoodSubsidy)
         {
             return new AdministrationSetupDAL().UpdateFoodSubsidySetup(oFoodSubsidy);
         }
         public List<FoodSubsidy> GetFoodSubsidySetup()
         {
             return new AdministrationSetupDAL().GetFoodSubsidySetup();
         }
        public FoodSubsidy GetFoodSubsidy(string EmpID)
         {
             return new AdministrationSetupDAL().GetFoodSubsidy(EmpID);
         }
    }
}