using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.ACCMS.DAL;
using AH.Shared.MODEL;
using AH.ACCMS.MODEL;

namespace AH.ACCMS.BLL
{
    public class RevenueSetupBLL
    {
        public short SaveRevenueHeadGr(RevenueHeadGroup rvgr)
        {
            return new RevenueSetupDAL().SaveRevenueHeadGr(rvgr);
        }
        public short UpdateRevHdGr(RevenueHeadGroup urvgr)
        {
            return new RevenueSetupDAL().UpdateRevHdGr(urvgr);
        }
        public short SaveRevenueHead(RevenueHead rvihd)
        {
            return new RevenueSetupDAL().SaveRevenueHead(rvihd);
        }
        public short UpdateRevHead(RevenueHead urvshd)
        {
            return new RevenueSetupDAL().UpdateRevHead(urvshd);
        }
        public List<RevenueHeadGroup> GetRevHdGrps()
        {
            return new RevenueSetupDAL().GetRevHdGrps();
        }
        public int VerifyRevHdGr(string groupid)
        {
            return new RevenueSetupDAL().VerifyRevHdGr(groupid);
        }
        public Dictionary<string, string> GetRevHdGrps(string type)
        {
            Dictionary<string, string> rvgr = new Dictionary<string, string>();
            foreach (RevenueHeadGroup rvh in new RevenueSetupDAL().GetRevHdGrps())
            {
                rvgr.Add(rvh.ID, rvh.Title);
            }
            return rvgr;
        }

        public List<RevenueHead> GetRevenueHead()
        {
            return new RevenueSetupDAL().GetRevenueHead();
        }
        public List<RevenueHead> GetRevenueHeads(string headgr)
        {
            return new RevenueSetupDAL().GetRevenueHeads(headgr);
        }
        public Dictionary<string, string> GetRevenueHead(string type)
        {
            Dictionary<string, string> rvhd = new Dictionary<string, string>();

            foreach (RevenueHead rvh in new RevenueSetupDAL().GetRevenueHead())
            {
                rvhd.Add(rvh.ID, rvh.Title);
            }
            return rvhd;
        }
        public int VerifyRevHead(string headid)
        {
            return new RevenueSetupDAL().VerifyRevHead(headid);
        }
        public Dictionary<string, string> GetRevenueHeads(string type, string headgr)
        {
            Dictionary<string, string> revhd = new Dictionary<string, string>();
            foreach (RevenueHead rvhd in new RevenueSetupDAL().GetRevenueHeads(headgr))
            {
                revhd.Add(rvhd.ID, rvhd.Title);
            }
            return revhd;
        }

        public short SaveHeadAssign(DepartmentRevenueHead hdas)
        {
            return new RevenueSetupDAL().SaveHeadAssign(hdas);
        }
        public short UpdateHdAss(DepartmentRevenueHead uhdas)
        {
            return new RevenueSetupDAL().UpdateHdAss(uhdas);
        }
        public List<DepartmentRevenueHead> GetHeadAssign()
        {
            return new RevenueSetupDAL().GetHeadAssign();
        }
        public List<DepartmentRevenueHead> GetHeadAssign(string departmentID)
        {
            return new RevenueSetupDAL().GetHeadAssign(departmentID);
        }

        public Dictionary<string, string> GetRevenueGroup()
        {
            Dictionary<string, string> obgcGrp = new Dictionary<string, string>();
            foreach (RevenueHeadGroup objcat in new RevenueSetupDAL().GetRevenueGroup())
            {
                obgcGrp.Add(objcat.ID, objcat.Title);
            }
            return obgcGrp;

        }

    }
}
