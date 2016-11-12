using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.PatReg.MODEL;
using AH.DMS.MODEL;
using AH.DUtility;
using AH.DMS.DAL;
using AH.DTMS.MODEL;
using AH.HR.BLL;
using AH.ORGMS.BLL;

namespace AH.DMS.BLL
{
    public class TestCancelBLL
    {
        public string SaveTestCancel(DiagnosticMR mr)
        {
            return new TestCancelDAL().SaveTestCancel(mr);
        }

        public short SaveTestCancelCause(TestCancelCause oCanCause)
        {
            return new TestCancelDAL().SaveTestCancelCause(oCanCause);          
        }
        public List<TestCancelCause> GetCancelCause()
        {
            return new TestCancelDAL().GetCancelCause();
        }
        public short UpdateCancelCause(TestCancelCause oCanCause)
        {
            return new TestCancelDAL().UpdateCancelCause(oCanCause);
        }

        public Dictionary<string, string> GetCancelCauseDic(string type)
        {
            Dictionary<string, string> olvDic = new Dictionary<string, string>();
            olvDic.Add("", "--Select--");
            foreach (TestCancelCause olv in new TestCancelDAL().GetCancelCause())
            {
                olvDic.Add(olv.CauseId, olv.CauseTitle);
            }

            return olvDic;
        }
         public short SaveRefundCause(RefundCause oRefundCause)
        {
            return new TestCancelDAL().SaveRefundCause(oRefundCause);
        }
        public short UpdateRefundCause(RefundCause oRefundCause)
         {
             return new TestCancelDAL().UpdateRefundCause(oRefundCause);
         }
        public List<RefundCause> GetRefundCause()
        {
            return new TestCancelDAL().GetRefundCause();
        }
        public Dictionary<string, string> GetRefundCauseDic(string type)
        {
            Dictionary<string, string> oRefundDic = new Dictionary<string, string>();
            oRefundDic.Add("", "--Select--");
            foreach (RefundCause oRefund in new TestCancelDAL().GetRefundCause())
            {
                oRefundDic.Add(oRefund.CauseId, oRefund.CauseTitle);
            }

            return oRefundDic;
        }
    }
}
