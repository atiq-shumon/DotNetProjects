using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AH.INVMS.DAL;
using AH.INVMS.MODEL;

namespace AH.INVMS.BLL
{
    public class ItemIssueBLL
    {
        public string SaveItemIssue(ItemIssue oitems)
        {
            return new ItemIssueDAL().SaveItemIssue(oitems);
        }
        public short SaveIssueType(IssueType otype)
        {
            return new ItemIssueDAL().SaveIssueType(otype);
        }
        public short ModifyIssueType(IssueType otype)
        {
            return new ItemIssueDAL().ModifyIssueType(otype);
        }
        public List<IssueType> GetIssueType()
        {
            return new ItemIssueDAL().GetIssueType();
        }
        public short SaveCostCenter(CostCenter ocost)
        {
            return new ItemIssueDAL().SaveCostCenter(ocost);
        }
        public short ModifyCostCenter(CostCenter ocost)
        {
            return new ItemIssueDAL().ModifyCostCenter(ocost);
        }
        public List<CostCenter> GetCostCenter()
        {
            return new ItemIssueDAL().GetCostCenter();
        }
        public List<CostCenter> GetCostCenterByIssueType(string issuetype)
        {
            return new ItemIssueDAL().GetCostCenterByIssueType(issuetype);
        }
        public string SaveIssueReturn(IssueReturn oret)
        {
            return new ItemIssueDAL().SaveIssueReturn(oret);
        }
        public List<AssetTrackerMaster> GetAssetTrackerSerialNo(string itemid)
        {
            return new ItemIssueDAL().GetAssetTrackerSerialNo(itemid);
        }
        public List<ItemIssue> GetIssueDetails(string issueid)
        {
            return new ItemIssueDAL().GetIssueDetails(issueid);
        }
        public List<AssetTrackerMaster> GetAssetSerialNoForIssueReturn(string issueid,string itemid)
        {
            return new ItemIssueDAL().GetAssetSerialNoForIssueReturn(issueid,itemid);
        }
        public List<ItemOrder> GetItemDetailsBatch(string itemid, string drid)
        {
            return new ItemIssueDAL().GetItemDetailsBatch(itemid,drid);
        }
    }
}
