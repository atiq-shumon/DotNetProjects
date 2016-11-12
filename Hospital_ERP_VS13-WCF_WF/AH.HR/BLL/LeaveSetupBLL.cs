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
    public class LeaveSetupBLL
    {
        public short SaveLeaveType(LeaveType oLvType)
        {
            return new LeaveSetupDAL().SaveLeaveType(oLvType);
        }

        public List<LeaveType> GetLeaveType()
        {
            return new LeaveSetupDAL().GetLeaveType();
        }

        public List<LeaveType> GetLeaveTypeSetup(string oLvTpSet)
        {
            return new LeaveSetupDAL().GetLeaveTypeSetup(oLvTpSet);
        }

        public short UpdateLeaveType(LeaveType oLvType)
        {
            return new LeaveSetupDAL().UpdateLeaveType(oLvType);
        }

        public Dictionary<string, string> GetLeave(string type)
        {
            Dictionary<string, string> olvDic = new Dictionary<string, string>();
            olvDic.Add("", "--Select--");
            foreach (LeaveType olv in new LeaveSetupDAL().GetLeave())
            {
                olvDic.Add(olv.TypeID, olv.TypeTitle);
            }

            return olvDic;
        }

        public List<LeaveDaysSetup> GetLeaveDay(string oLvTpSet)
        {
            return new LeaveSetupDAL().GetLeaveDay(oLvTpSet);
        }

        public List<LeaveDaysSetup> GetLeaveDays(string oLvTpSet, string oYear)
        {
            return new LeaveSetupDAL().GetLeaveDays(oLvTpSet, oYear);
        }
        public short SaveLeaveDays(LeaveDaysSetup oLvDaysSet)
        {
            return new LeaveSetupDAL().SaveLeaveDays(oLvDaysSet);
        }

        public short UpdateLeaveDays(LeaveDaysSetup oLvDaysSet)
        {
            return new LeaveSetupDAL().UpdateLeaveDays(oLvDaysSet);
        }

        public string SaveEmpLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
        {
            return new LeaveSetupDAL().SaveEmpLeaveRegister(oEmpLeaveRegis);
        }

        public List<EmpLeaveRegister> GetLeaveRegister(string oLvType)
        {
            return new LeaveSetupDAL().GetLeaveRegister(oLvType);
        }

        public short UpdateLeaveRegister(EmpLeaveRegister oEmpLeaveRegis)
        {
            return new LeaveSetupDAL().UpdateLeaveRegister(oEmpLeaveRegis);
        }
        public List<LeaveRO> GetLeaveRequestListRptPrsn(string EmpID)
        {
            return new LeaveSetupDAL().GetLeaveRequestListRptPrsn(EmpID);
        }

        public List<LeaveRO> GetLeaveRequestList(string EmpID)
        {
            return new LeaveSetupDAL().GetLeaveRequestList(EmpID);
        }
        public short SaveLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            return new LeaveSetupDAL().SaveLeaveCancelCause(oLvCanCaus);
        }
        public List<LeaveCancelCause> GetLeaveCancelCause()
        {
            return new LeaveSetupDAL().GetLeaveCancelCause();
        }
        public short UpdateLeaveCancelCause(LeaveCancelCause oLvCanCaus)
        {
            return new LeaveSetupDAL().UpdateLeaveCancelCause(oLvCanCaus);
        }
        public Dictionary<string, string> GetLvCanCause(string type)
        {
            Dictionary<string, string> olvDic = new Dictionary<string, string>();
            olvDic.Add("", "--Select--");
            foreach (LeaveCancelCause olv in new LeaveSetupDAL().GetLeaveCancelCause())
            {
                olvDic.Add(olv.CauseId, olv.CauseTitle);
            }

            return olvDic;
        }
        public EmpLeaveRegister GetLeaveReg(string oEmp, string oLvType, string Serial)
        {
            return new LeaveSetupDAL().GetLeaveReg(oEmp, oLvType, Serial);
        }
        public List<LeaveRO> GetLeaveRequestListHR()
        {
            return new LeaveSetupDAL().GetLeaveRequestListHR();
        }
    }
}
