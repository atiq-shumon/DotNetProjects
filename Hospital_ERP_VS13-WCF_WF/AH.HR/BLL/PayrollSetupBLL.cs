using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PRMS.MODEL;
using AH.HR.MODEL;
using AH.HR.DAL;
using AH.Shared.MODEL;

namespace AH.HR.BLL
{
    public class PayrollSetupBLL
    {
        public short SaveSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            return new PayrollSetupDAL().SaveSalaryHeadGroup(oSalGrp);
        }

        public List<SalaryHeadGroup> GetSalHeadGroup()
        {
            return new PayrollSetupDAL().GetSalHeadGroup();
        }
        public List<SalaryHeadGroup> GetSalHeadGroupSetup(string oSalHdGrp)
        {
            return new PayrollSetupDAL().GetSalHeadGroupSetup(oSalHdGrp);
        }
        public short UpdateSalaryHeadGroup(SalaryHeadGroup oSalGrp)
        {
            return new PayrollSetupDAL().UpdateSalaryHeadGroup(oSalGrp);
        }



        public List<SalaryHead> GetSalaryHead()
        {
            return new PayrollSetupDAL().GetSalaryHead();
        }

        //public Dictionary<string, string> GetSalaryHead(string type)
        //{
        //    Dictionary<string, string> salhdDic = new Dictionary<string, string>();
        //    foreach (SalaryHead salhdgrp in new PayrollSetupDAL().GetSalaryHead())
        //    {
        //        salhdDic.Add(salhdgrp.HeadID, salhdgrp.HeadTitle);
        //    }

        //    return salhdDic;
        //}      
        public List<SalaryHead> GetSalaryHeadsetup(string oSalHdG, string oSalHdH)
        {
            return new PayrollSetupDAL().GetSalaryHeadsetup(oSalHdG, oSalHdH);
        }

        //public Dictionary<string, string> GetSalaryHeadsetup(string type, string oSalHd)
        //{
        //    Dictionary<string, string> salhdDic = new Dictionary<string, string>();

        //    foreach (SalaryHead salhd in new PayrollSetupDAL().GetSalaryHeadsetup(oSalHd))
        //    {
        //        salhdDic.Add(salhd.HeadID, salhd.HeadTitle);
        //    }

        //    return salhdDic;
        //}

        public Dictionary<string, string> GetSalHeadGroup(string type)
        {
            Dictionary<string, string> salhdgrpDic = new Dictionary<string, string>();
            salhdgrpDic.Add("", "--Select--");
            foreach (SalaryHeadGroup salhdGrp in new PayrollSetupDAL().GetSalHeadGroupSetup(type))
            {
                salhdgrpDic.Add(salhdGrp.HeadGroupID, salhdGrp.HeadGroupTitle);
            }

            return salhdgrpDic;
        }

        public short SaveSalaryHead(SalaryHead oSalHead)
        {
            return new PayrollSetupDAL().SaveSalaryHead(oSalHead);
        }
        public short UpdateSalaryHead(SalaryHead oSalHead)
        {
            return new PayrollSetupDAL().UpdateSalaryHead(oSalHead);
        }


        public List<SalaryGradeSetup> GetSalGradeSetup()
        {
            return new PayrollSetupDAL().GetSalGradeSetup();
        }
        public List<SalaryGradeSetup> GetGradeSetup(string level)
        {
            return new PayrollSetupDAL().GetGradeSetup(level);
        }
        public Dictionary<string, string> GetGradeDict(string level)
        {
            Dictionary<string, string> salGrdDic = new Dictionary<string, string>();
            salGrdDic.Add("", "--Select--");
            foreach (SalaryGradeSetup salGrd in new PayrollSetupDAL().GetGradeSetup(level))
            {
                salGrdDic.Add(salGrd.GradeID, salGrd.GradeTitle);
            }

            return salGrdDic;
        }
        public short SaveSalaryGrade(SalaryGradeSetup oSalGrade)
        {
            return new PayrollSetupDAL().SaveSalaryGrade(oSalGrade);
        }

        public short UpdateGradeSetup(SalaryGradeSetup oSalGrade)
        {
            return new PayrollSetupDAL().UpdateGradeSetup(oSalGrade);
        }


        public Dictionary<string, string> GetGrade(string type)
        {
            Dictionary<string, string> salGrdDic = new Dictionary<string, string>();
            salGrdDic.Add("", "--Select--");
            foreach (SalaryGradeSetup salGrd in new PayrollSetupDAL().GetSalGradeSetup())
            {
                salGrdDic.Add(salGrd.GradeID, salGrd.GradeTitle);
            }

            return salGrdDic;
        }

        public List<ScaleMSetup> GetScaleMSetup(string oSclMSetup)
        {
            return new PayrollSetupDAL().GetScaleMSetup(oSclMSetup);
        }
        public short SaveScaleMSetup(ScaleMSetup oSclMSet)
        {
            return new PayrollSetupDAL().SaveScaleMSetup(oSclMSet);
        }

        public short UpdateScaleMSetup(ScaleMSetup oSclMSet)
        {
            return new PayrollSetupDAL().UpdateScaleMSetup(oSclMSet);
        }

        public List<ScaleMSetup> GetScaleMSet()
        {
            return new PayrollSetupDAL().GetScaleMSet();
        }

        public Dictionary<string, string> GetScale(string type)
        {
            Dictionary<string, string> GetSclDic = new Dictionary<string, string>();
            GetSclDic.Add("", "--Select--");
            foreach (ScaleMSetup sclM in new PayrollSetupDAL().GetScaleMSet())
            {
                GetSclDic.Add(sclM.ScaleMID, sclM.ScaleTitle);
            }

            return GetSclDic;
        }

        public Dictionary<string, string> GetSalHd(string type)
        {
            Dictionary<string, string> SclDic = new Dictionary<string, string>();
            SclDic.Add("", "--Select--");
            foreach (SalaryHead sclH in new PayrollSetupDAL().GetSalaryHead())
            {
                SclDic.Add(sclH.HeadID, sclH.HeadTitle);
            }

            return SclDic;
        }
        public int VerifyScaleSetup(string vscl)
        {
            return new PayrollSetupDAL().VerifyScaleSetup(vscl);
        }

        public List<ScaleDSetup> GetScaleDSetup(string oSalHdG, string oSalM)
        {
            return new PayrollSetupDAL().GetScaleDSetup(oSalHdG, oSalM);
        }

        public short SaveScaleDSetup(ScaleDSetup oSclDSet)
        {
            return new PayrollSetupDAL().SaveScaleDSetup(oSclDSet);
        }

         public short UpdateScaleDSetup(ScaleDSetup oSclDSet)
        {
            return new PayrollSetupDAL().UpdateScaleDSetup(oSclDSet);
        }

         public short SaveStepDetailsSetup(ScaleDSetup oStepDetails)
         {
             return new PayrollSetupDAL().SaveStepDetailsSetup(oStepDetails);
         }

         public List<ScaleMSetup> GetScaleUnderGrade(string oSalHdG)
         {
             return new PayrollSetupDAL().GetScaleUnderGrade(oSalHdG);
         }

         public short SaveSalaryCycle(SalaryCycle oSalCycle)
         {
             return new PayrollSetupDAL().SaveSalaryCycle(oSalCycle);
         }

         public short UpdateSalaryCycle(SalaryCycle oSalCycle)
         {
             return new PayrollSetupDAL().UpdateSalaryCycle(oSalCycle);
         }

         public List<SalaryCycle> GetSalaryCycle(string Year)
         {
             return new PayrollSetupDAL().GetSalaryCycle(Year);
         }

         public List<SalaryCycle> GetMonthID()
         {
             return new PayrollSetupDAL().GetMonthID();
         }
         public List<SalaryCycle> GetMonthByYear(string year)
         {
             return new PayrollSetupDAL().GetMonthByYear(year);
         }
         public Dictionary<string, string> GetMonthUnderYear(string type)
         {
             Dictionary<string, string> oMonthIDDic = new Dictionary<string, string>();
             oMonthIDDic.Add("", "--Select--");
             foreach (SalaryCycle sal in new PayrollSetupDAL().GetMonthByYear(type))
             {
                 oMonthIDDic.Add(sal.Month, sal.Month);
             }

             return oMonthIDDic;
         }

         public Dictionary<string, string> GetEmp(string type)
         {
             Dictionary<string, string> oEMPDic = new Dictionary<string, string>();
             oEMPDic.Add("", "--Select--");
             foreach (EmployeeMaster sal in new PayrollSetupDAL().GetEmp())
             {
                 oEMPDic.Add(sal.EmpId, sal.EmpNameBeng);
             }

             return oEMPDic;
         }

         public string SavePayroll(Payroll oPay)
         {
             return new PayrollSetupDAL().SavePayroll(oPay);
         }


        //public EmployeeMaster GetEmpMaster(string ID)
        // {
        //     return new PayrollSetupDAL().GetEmpMaster(ID);
        // }

        public List<Payroll> CheckMonth(string ID)
        {
            return new PayrollSetupDAL().CheckMonth(ID);
        }
        public List<PayrollRO> GetPayrollForUpdate(string Emp, string DeptGrp, string Dept, string Unit, string Month, string Year)
        {
            return new PayrollSetupDAL().GetPayrollForUpdate(Emp, DeptGrp, Dept,Unit, Month, Year);
        }

        public string SaveUpdatedPayroll(PayrollRO oPayUp)
        {
            return new PayrollSetupDAL().SaveUpdatedPayroll(oPayUp);
        }
        public List<PayrollRO> ShowPayrollDetails(string Mode, string DeptGrp, string Dept, string Unit, string Month)
        {
            return new PayrollSetupDAL().ShowPayrollDetails(Mode,DeptGrp, Dept, Unit, Month);
        }
        public string saveManualPayroll(Payroll oPay)
        {
            return new PayrollSetupDAL().saveManualPayroll(oPay);
        }
        public string SaveSalaryDisbursing(Payroll oPay)
        {
            return new PayrollSetupDAL().SaveSalaryDisbursing(oPay);
        }
        public short SavePayrollBase(PayrollBase oPayrollBase)
        {
            return new PayrollSetupDAL().SavePayrollBase(oPayrollBase);
        }
        public List<PayrollBase> GetPayrollBase(string EmpID)
        {
            return new PayrollSetupDAL().GetPayrollBase(EmpID);
        }
    }
}
