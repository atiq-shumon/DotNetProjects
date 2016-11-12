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
using AH.ModuleController.UI.ACCMS.Reports.Viewer;
using System.IO;
using MayhediExportExcelToTree;


namespace AH.ModuleController.UI.ACCMS.Forms
{
    public partial class frmTreeView : AH.Shared.UI.frmSmartFormStandard
    {
        private System.Windows.Forms.TreeNode NodeX;
        private const string mcGROUP_PREFIX = "G_";
        private const string mcLEDGER_PREFIX = "L_";
        List <string>  objLedger=new List<string>();
        AccountsMSSR.ACCMSWSClient accmSc = new AccountsMSSR.ACCMSWSClient();
        public frmTreeView()
        {
            InitializeComponent();
            
        }
        #region "Treeview"
        private void GetGroupsTreeView()
        {
            string strGroup;
            string strCodeAllo;
            int i = 0;
            System.Windows.Forms.TreeNode oNodex = null;
            this.tvwGroup.Nodes.Clear();
            oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            oNodex.Expand();
            oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
            oNodex.Expand();
            oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
            oNodex.Expand();
            oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
            oNodex.Expand();
            List<GroupsConfig> grp = accmSc.GetGroupTreeview().ToList();
            foreach (GroupsConfig grps in grp)
            {
                strGroup = grps.GrName.ToString();
                strCodeAllo = grps.Grcode.ToString();
                oNodex = tvwGroup.Nodes.Find(mcGROUP_PREFIX + grps.GrParent.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strCodeAllo + '~' + strGroup, "closed");
                tvwGroup.Nodes[i].Tag = grps.GrPrimaryType.ToString();
                //int j= accmSc.SaveTree(mcGROUP_PREFIX + grps.GrParent.ToString(),mcGROUP_PREFIX + strGroup,strGroup);
                oNodex.Expand();
                oNodex.EnsureVisible();
                GetLedgerItem(strGroup);
                i = i + i;
            }
        }
        private void GetGroupsTreeViewSelection()
        {
            //string strGroup;
           // int i = 0;
            //System.Windows.Forms.TreeNode oNodex = null;
            //this.tvwGroup.Nodes.Clear();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
            //oNodex.Expand();
            //oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
            //oNodex.Expand();
          
        }
        private void  GetLedgerItem(string vstrRoot)
        {
            string strChild;
            //objLedger.Clear();
            List<Ledgers> objLed = accmSc.GetLegerTreeview(vstrRoot).ToList();
            foreach (Ledgers  ldr in objLed)
            {
                strChild = ldr.strLedgerCode + '~' + ldr.strLedgerName.ToString();
                NodeX = tvwGroup.Nodes.Find(mcGROUP_PREFIX + vstrRoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + strChild, strChild, "leaf");
                objLedger.Add(strChild);
                NodeX.ImageIndex = 1;
            }
        }
        private void frmTreeView_Load(object sender, EventArgs e)
        {
            try
            {
                GetGroupsTreeView();
                //GetGroupsTreeView1();
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

        private void GetGroupsTreeView1()
        {
            string strGroup;
            int i = 0;
            string strCodeAllo;
            System.Windows.Forms.TreeNode oNodex = null;
            try
            {
                this.treeviewprint.Nodes.Clear();
                oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
                oNodex.Expand();
                oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
                oNodex.Expand();
                oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
                oNodex.Expand();
                oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
                oNodex.Expand();
                List<GroupsConfig> grp = accmSc.GetGroupTreeview().ToList();
                foreach (GroupsConfig grps in grp)
                {
                    strGroup = grps.GrName.ToString();
                    strCodeAllo = grps.Grcode.ToString();
                    oNodex.Expand();
                    oNodex = treeviewprint.Nodes.Find(mcGROUP_PREFIX + grps.GrParent.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strCodeAllo + '~' + strGroup, "closed");
                    treeviewprint.Nodes[i].Tag = grps.GrPrimaryType.ToString();
                    //int j= accmSc.SaveTree(mcGROUP_PREFIX + grps.GrParent.ToString(),mcGROUP_PREFIX + strGroup,strGroup);
                    oNodex.EnsureVisible();
                    GetLedgerItem1(strGroup);
                    i = i + i;
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
        private void GetLedgerItem1(string vstrRoot)
        {
            string strChild;
            try
            {
                //objLedger.Clear();
                List<Ledgers> objLed = accmSc.GetLegerTreeview(vstrRoot).ToList();
                foreach (Ledgers ldr in objLed)
                {
                    //strChild = ldr.strLedgerName.ToString();
                    //strChild = ldr.CodeAllocation + ldr.strLedgerCode + '~' + ldr.strLedgerName.ToString();
                    strChild = ldr.strLedgerCode + '~' + ldr.strLedgerName.ToString();

                    NodeX = treeviewprint.Nodes.Find(mcGROUP_PREFIX + vstrRoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + strChild, strChild, "leaf");
                    objLedger.Add(strChild);
                    NodeX.ImageIndex = 1;
                    NodeX.Expand();
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

            //frmReportViewer frm = new frmReportViewer();
            //frm.selector = ViewerSelector.Treeview;
            //frm.ShowDialog();
            //StringBuilder sb = new StringBuilder();
            //foreach (TreeNode node in tvwGroup.Nodes)
            //{
            //    sb.AppendLine(node.Name);
            //}
            //SaveFileDialog saveList = new SaveFileDialog();
            //saveList.DefaultExt = "*.txt";
            //saveList.Filter = "All Files|*.txt";
            //if (saveList.ShowDialog() == DialogResult.OK)
            //{
            //    System.IO.File.WriteAllText(saveList.FileName, sb.ToString());
            //}
            //CallRecursive(tvwGroup);
            try
            {
                GetGroupsTreeView1();
                var print = new TreeviewPrinting.PrintHelper();
                //print.PrintPreviewTree(this.treeviewprint, "Chart of Accounts of Ali Hospital");
                print.PrintTree(this.treeviewprint, "     Chart of Accounts of Ali Hospital");
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
        #region "Treeview Event"
        private void tvwGroup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var relativeMousePosition = tvwGroup.PointToClient(Cursor.Position);
                //foreach (string ldr in objLedger)
                //{
                //    if (ldr.ToString() == tvwGroup.SelectedNode.Text)
                //    {
                //        MessageBox.Show("It is a Last Level");
                //        return;

                //    }
                //}
                this.mnuGroup.Show(tvwGroup, relativeMousePosition);

            }
        }
        private void mnuGroup_Opening(object sender, CancelEventArgs e)
        {
            //frmGroupConfig frm = new frmGroupConfig();
            //frm.ShowDialog();
        }
        //private void FindByTag()
        //{
        //    TreeNodeCollection nodes = treeView1.Nodes;
        //    foreach (TreeNode n in nodes)
        //    {
        //        FindRecursiveTag(n);
        //    }
        //}

        //private void FindRecursiveTag(TreeNode treeNode)
        //{
        //    foreach (TreeNode tn in treeNode.Nodes)
        //    {
        //        // if the text properties match, color the item
        //        if (tn.Tag.ToString() == this.txtTagSearch.Text)
        //            tn.BackColor = Color.Yellow;

        //        FindRecursiveTag(tn);
        //    }
        //}
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetGroupsTreeView();
        }
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            string strLedger = "", Grcode="";
            strLedger = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);

            int intlen = tvwGroup.SelectedNode.Text.ToString().Length;
            Grcode = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.ToString().LastIndexOf("~") + 1).ToString();
            Grcode = tvwGroup.SelectedNode.Text.ToString().Substring(0, (intlen - Grcode.Length) - 1);

            if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
            {
                foreach (string ldr in objLedger)
                {
                    if (ldr.Substring(ldr.LastIndexOf("~") + 1) == strLedger)
                    {
                        MessageBox.Show("It is a Last Level");
                        return;

                    }
                }

               

                int index;
                TreeNode obj = new TreeNode();
                obj = tvwGroup.SelectedNode;
                index = tvwGroup.Nodes.IndexOf(obj);
                string str = string.Empty;
                str = index.ToString();
                //MessageBox.Show("index of selected tree node is " + str);
                frmLedger frm = new frmLedger();
                //frm.under = tvwGroup.SelectedNode.Text;
                frm.under = strLedger;
                frm.ledgercode = Grcode;
                frm.strMode = "Add";
                //frm.strindex = tvwGroup.SelectedNode.Parent.Text.ToString();
                frm.ShowDialog();
                //GetGroupsTreeView();
            }
        }
        private void mnuGroupAdd_Click(object sender, EventArgs e)
        {
            string strGroup = "";
            if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
            {
                strGroup = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);
                foreach (string ldr in objLedger)
                {
                    //if (ldr.ToString() == tvwGroup.SelectedNode.Text)
                    if (ldr.Substring(ldr.LastIndexOf("~") + 1).ToString() == strGroup)
                    {
                        MessageBox.Show("It is a Last Level");
                        return;
                    }
                }
                
                int index;
                TreeNode obj = new TreeNode();
                obj = tvwGroup.SelectedNode;
                
                index = tvwGroup.Nodes.IndexOf(obj);
                string str = string.Empty;
                str = index.ToString();

                frmGroupConfig frm = new frmGroupConfig();
                frm.strMode = "Add";
                //frm.strUnder = tvwGroup.SelectedNode.Text;
                frm.strUnder = strGroup;
                frm.strindex = tvwGroup.SelectedNode.Parent.Text.ToString();
                frm.ShowDialog();
                //GetGroupsTreeView();
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                GetGroupsTreeView1();
                var print = new TreeviewPrinting.PrintHelper();
                print.PrintPreviewTree(this.treeviewprint, "Chart of Accounts of Ali Hospital");
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
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            
            string strGroup = "";
            try
            {
                strGroup = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);

                if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
                {
                    foreach (string ldr in objLedger)
                    {
                        //  if (ldr.ToString() == tvwGroup.SelectedNode.Text)
                        if (ldr.Substring(ldr.LastIndexOf("~") + 1).ToString() == strGroup)
                        {
                            MessageBox.Show("It is a Last Level");
                            return;

                        }
                    }

                    frmGroupConfig frm = new frmGroupConfig();
                    frm.strMode = "Edit";
                    frm.strUnder = "";
                    frm.strindex = tvwGroup.SelectedNode.Parent.Text.ToString();
                    frm.ShowDialog();
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
        private void mnuLedgerEdit_Click(object sender, EventArgs e)
        {
            string strLedger = "";
            try
            {
                strLedger = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);

                if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
                {
                    foreach (string ldr in objLedger)
                    {
                        if (ldr.Substring(ldr.LastIndexOf("~") + 1).ToString() == strLedger)
                        {
                            //MessageBox.Show("It is a Last Level");
                            //return;
                            int index;
                            TreeNode obj = new TreeNode();
                            obj = tvwGroup.SelectedNode;
                            index = tvwGroup.Nodes.IndexOf(obj);
                            string str = string.Empty;
                            str = index.ToString();
                            //MessageBox.Show("index of selected tree node is " + str);
                            frmLedger frm = new frmLedger();
                            //frm.under = tvwGroup.SelectedNode.Text;
                            frm.strMode = "Edit";
                            //frm.strindex = tvwGroup.SelectedNode.Parent.Text.ToString();
                            frm.ShowDialog();
                            //GetGroupsTreeView();
                        }
                    }
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
        #endregion
        private void tvwGroup_DoubleClick(object sender, EventArgs e)
        {
            //string strGroup = "";
            //System.Windows.Forms.TreeNode oNodex = null;
            //int i = 0;
            //string strSelection;
            //strSelection = tvwGroup.SelectedNode.Text;
            //// GetGroupsTreeViewSelection();
            ////this.tvwGroup.Nodes.Clear();
            ////oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            ////oNodex.Expand();
            ////oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
            ////oNodex.Expand();
            ////oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
            ////oNodex.Expand();
            ////oNodex = tvwGroup.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
            ////oNodex.Expand();
            ////MessageBox.Show(strSelection);
            //List<GroupsConfig> grp = accmSc.GetGroupTreeviewSelection(strSelection).ToList();
            //foreach (GroupsConfig grps in grp)
            //{
            //    strGroup = grps.GrName.ToString();

            //    foreach (TreeNode tn in tvwGroup.SelectedNode.Nodes)
            //    {
            //        string strName = tn.Text;
            //        //MessageBox.Show("Parent" + strName);
            //        if (strName == strGroup )
            //        {
            //            return;
            //        }
            //        foreach (TreeNode child in tn.Nodes)
            //        {
            //            string strChild = child.Text;
            //            if (strChild == strGroup )
            //            {
            //                return;
            //            }
            //            //MessageBox.Show("Child" + strName);
            //        }

            //    }
            //    oNodex = tvwGroup.Nodes.Find(mcGROUP_PREFIX + grps.GrParent.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strGroup, "closed");
            //    tvwGroup.Nodes[i].Tag = grps.GrPrimaryType.ToString();
            //    //int j= accmSc.SaveTree(mcGROUP_PREFIX + grps.GrParent.ToString(),mcGROUP_PREFIX + strGroup,strGroup);
            //    oNodex.Expand();
            //    oNodex.EnsureVisible();
            //    GetLedgerItem(strGroup);
            //    i = i + i;
            //}
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            GetGroupsTreeViewscript();
        }

        private void GetGroupsTreeViewscript()
        {
            string strGroup,Grcode;
            int i = 0;
            string strCodeAllo;
            //System.Windows.Forms.TreeNode oNodex = null;
            //this.treeviewprint.Nodes.Clear();
            //oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Assets", "Assets", "closed");
            //oNodex.Expand();
            //oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Liabilities", "Liabilities", "closed");
            //oNodex.Expand();
            //oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Income", "Income", "closed");
            //oNodex.Expand();
            //oNodex = treeviewprint.Nodes.Add(mcGROUP_PREFIX + "Expenses", "Expenses", "closed");
            //oNodex.Expand();
            List<GroupsConfig> grp = accmSc.GetGroupTreeview().ToList();
            foreach (GroupsConfig grps in grp)
            {
                strGroup = grps.GrName.ToString();
                strCodeAllo = grps.Grcode.ToString();
                strCodeAllo = strCodeAllo + '~' + strGroup;
                //oNodex.Expand();
                //oNodex = treeviewprint.Nodes.Find(mcGROUP_PREFIX + grps.GrParent.ToString(), true)[0].Nodes.Add(mcGROUP_PREFIX + strGroup, strCodeAllo, "closed");
                //treeviewprint.Nodes[i].Tag = grps.GrPrimaryType.ToString();
                ////int j= accmSc.SaveTree(mcGROUP_PREFIX + grps.GrParent.ToString(),mcGROUP_PREFIX + strGroup,strGroup);
                //oNodex.EnsureVisible();
                int intlen = strCodeAllo.Length;
                Grcode = strCodeAllo.Substring(strCodeAllo.LastIndexOf("~") +1).ToString();
                Grcode = strCodeAllo.Substring(0, (intlen - Grcode.Length)-1);
                GetLedgerItemscript(strGroup,Grcode);
                i = i + i;
            }
            MessageBox.Show("Success");
        }
        private void GetLedgerItemscript(string vstrRoot,string vstrRoot1)
        {
            string strChild, strChild1="";
            //objLedger.Clear();
            List<Ledgers> objLed = accmSc.GetLegerTreeview(vstrRoot).ToList();
            foreach (Ledgers ldr in objLed)
            {
                //if (vstrRoot1=="20209")
                //{
                //    MessageBox.Show("cc");
                //}
                //strChild = ldr.strLedgerName.ToString();
                strChild = ldr.CodeAllocation + ldr.strLedgerCode + '~' + ldr.strLedgerName.ToString();
                var results = strChild.Split(new string[] { "~" }, StringSplitOptions.None);
                strChild1 = results[0].ToString();
                int intlem = vstrRoot1.Length;
                if (results[1].ToString() == "Ali Hospital")
                {
                    strChild1 = results[0].ToString().Substring(3, 7);
                }
                else
                {
                    strChild1 = results[0].ToString().Substring(intlem, 7);
                }

                short j = accmSc.UpdateScript(strChild1, vstrRoot1);
                //NodeX = treeviewprint.Nodes.Find(mcGROUP_PREFIX + vstrRoot, true)[0].Nodes.Add(mcLEDGER_PREFIX + strChild, strChild, "leaf");
                //objLedger.Add(strChild);
                //NodeX.ImageIndex = 1;
                //NodeX.Expand();
            }
        }
        private Ledgers Ledger()
        {
            

            Ledgers lgr = new Ledgers();
           
            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            lgr.EntryParameter = ep;
            return lgr;
        }

        private GroupsConfig Groupcon()
        {


            GroupsConfig grp = new GroupsConfig();

            EntryParameter ep = new EntryParameter();
            ep.EntryBy = Utility.UserId;
            ep.CompanyID = Utility.CompanyID;
            ep.LocationID = Utility.LocationID;
            ep.MachineID = Utility.MachineID;
            grp.EntryParameter = ep;
            return grp;
        }
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            string strLedger = "";
            strLedger = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);

            if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
            {
                foreach (string ldr in objLedger)
                {
                    if (ldr.Substring(ldr.LastIndexOf("~") + 1).ToString() == strLedger)
                    {
                        //MessageBox.Show("It is a Last Level");
                        //return;
                        //int index;
                        //TreeNode obj = new TreeNode();
                        //obj = tvwGroup.SelectedNode;
                        //index = tvwGroup.Nodes.IndexOf(obj);
                        //string str = string.Empty;
                        //str = index.ToString();
                        Ledgers Lr = Ledger();
                        try
                        {
                            short i = accmSc.DeleteLedgerTreeview(strLedger.Trim().ToString(), Lr);
                            MessageBox.Show("Delete Success");
                            btnrefresh.PerformClick();
                            
                        }
                        catch
                        {
                            MessageBox.Show("Transaction Found Cannot Delete");
                        }

        
                    }
                }
            }
        }

       

        private void mnuGDelete_Click(object sender, EventArgs e)
        {
             string strGroup = "";
            strGroup = tvwGroup.SelectedNode.Text.ToString().Substring(tvwGroup.SelectedNode.Text.LastIndexOf("~") + 1);

            if ((tvwGroup.SelectedNode.Text != "Assets" && (tvwGroup.SelectedNode.Text != "Liabilities" && tvwGroup.SelectedNode.Text != "Income") && tvwGroup.SelectedNode.Text != "Expenses"))
            {
                foreach (string ldr in objLedger)
                {
                    //  if (ldr.ToString() == tvwGroup.SelectedNode.Text)
                    if (ldr.Substring(ldr.LastIndexOf("~") + 1).ToString() == strGroup)
                    {
                        MessageBox.Show("It is a Last Level");
                        return;
                    }
                }

                TreeNodeCollection nodes = tvwGroup.SelectedNode.Nodes;
                foreach (TreeNode n in nodes)
                {
                    CheckchildNode(n);
                    MessageBox.Show("Child Node, Found Cannot Delete");
                    return;
                }

                GroupsConfig Grp = Groupcon();
                try
                {
                    short i = accmSc.DeleteGroupTreeview(strGroup.ToString(), Grp);
                    MessageBox.Show("Delete Success");
                    btnrefresh.PerformClick();
                    
                }
                catch
                {
                    MessageBox.Show("Transaction, Found Cannot Delete");
                }
            }

        }



        private void CheckchildNode(TreeNode treeNode)
        {
            
            System.Diagnostics.Debug.WriteLine(treeNode.Text);
            foreach (TreeNode tn in treeNode.Nodes)
            {
                CheckchildNode(tn);
            }
        }

       

        private void btnNew_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            SaveFileDialog optSave = new SaveFileDialog();
            optSave.ValidateNames = true;
            optSave.Title = "Browse Text Files";
            optSave.Filter = "xlsx (*.xlsx)|*.xlsx";
            optSave.FilterIndex = 2;
            optSave.RestoreDirectory = true;

            if (optSave.ShowDialog() == DialogResult.OK)
            {
                Chosen_File = optSave.FileName;
            }
            if (Chosen_File == String.Empty)
            {
                return;
            }
            Export.ExportToExcel(tvwGroup, Chosen_File);
            MessageBox.Show("Export Success");
        }

        




    }
}
