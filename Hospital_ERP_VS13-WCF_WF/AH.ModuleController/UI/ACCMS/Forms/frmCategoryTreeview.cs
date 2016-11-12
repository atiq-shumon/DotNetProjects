using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AH.ModuleController.AccountsMSSR;
using AH.DUtility;

namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmCategoryTreeview : AH.Shared.UI.frmSmartFormStandard
    {
        private System.Windows.Forms.TreeNode NodeX;
        private const string mcGROUP_PREFIX = "G_";
        private const string mcLEDGER_PREFIX = "L_";
        List<string> objLedger = new List<string>();

        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmCategoryTreeview()
        {
            InitializeComponent();
        }

        #region "Tree"
        private void mLaod()
        {
            System.Windows.Forms.TreeNode oNodex = null;
            this.tvwcostcategory.Nodes.Clear();
            List<CostCategoryTreeview> objTreeview = accmSc.GetCostcategoryTreeview("CostcategoryTreeview", "", "").ToList();
            foreach (CostCategoryTreeview tree in objTreeview)
            {
                string strCategorycode = tree.CategoryID.ToString();
                string strName = tree.CategoryName.ToString();
                oNodex = tvwcostcategory.Nodes.Add(mcGROUP_PREFIX + tree.CategoryID.ToString(), tree.CategoryName.ToString(), "closed");
                //oNodex.Expand();
                GetChild(strCategorycode);
            }
        }
        private void GetChild(string vstrReoot)
        {
            List<CostCategoryTreeview> objTreeview = accmSc.GetCostcenterTreeview("CostcenterTreeview", vstrReoot, "").ToList();
            foreach (CostCategoryTreeview tree in objTreeview)
            {
                string stCostcenterName = tree.CostcenterName.ToString();
                NodeX = tvwcostcategory.Nodes.Find(mcGROUP_PREFIX + vstrReoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + stCostcenterName, stCostcenterName, "leaf");
                NodeX.Expand();
                tvwcostcategory.ExpandAll();
            }
        }
        #endregion
        #region "Load"
        private void frmCategoryTreeview_Load(object sender, EventArgs e)
        {
            try
            {
                mLaod();
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
        #endregion
        #region "Print"
        private void mLaodPrint()
        {
            try
            {
                System.Windows.Forms.TreeNode oNodex = null;
                this.tvwPrint.Nodes.Clear();
                List<CostCategoryTreeview> objTreeview = accmSc.GetCostcategoryTreeview("CostcategoryTreeview", "", "").ToList();
                foreach (CostCategoryTreeview tree in objTreeview)
                {
                    string strCategorycode = tree.CategoryID.ToString();
                    string strName = tree.CategoryName.ToString();
                    oNodex = tvwPrint.Nodes.Add(mcGROUP_PREFIX + tree.CategoryID.ToString(), tree.CategoryName.ToString(), "closed");
                    //oNodex.Expand();
                    GetChild1(strCategorycode);
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
        private void GetChild1(string vstrReoot)
        {
            try
            {
                List<CostCategoryTreeview> objTreeview = accmSc.GetCostcenterTreeview("CostcenterTreeview", vstrReoot, "").ToList();
                foreach (CostCategoryTreeview tree in objTreeview)
                {
                    string stCostcenterName = tree.CostcenterName.ToString();
                    NodeX = tvwPrint.Nodes.Find(mcGROUP_PREFIX + vstrReoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + stCostcenterName, stCostcenterName, "leaf");
                    NodeX.Expand();
                    tvwPrint.ExpandAll();
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                mLaodPrint();
                //var print = new TreeviewPrinting.PrintHelper();
                //print.PrintPreviewTree(this.tvwPrint, "Cost Center of Ali Hospital");
                var print = new TreeviewPrinting.PrintHelper();
                //print.PrintPreviewTree(this.treeviewprint, "Chart of Accounts of Ali Hospital");
                print.PrintTree(this.tvwPrint, "Chart of Cost Center of Ali Hospital");
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
        #endregion
        #region "Preview"
        private void btnPreview_Click(object sender, EventArgs e)
        {
            mLaodPrint();
            //var print = new TreeviewPrinting.PrintHelper();
            //print.PrintPreviewTree(this.tvwPrint, "Cost Center of Ali Hospital");
            var print = new TreeviewPrinting.PrintHelper();
            print.PrintPreviewTree(this.tvwPrint, "Chart of Accounts of Ali Hospital");
           // print.PrintTree(this.tvwPrint, "Chart of Accounts of Ali Hospital");
        }
        #endregion
    }
}
