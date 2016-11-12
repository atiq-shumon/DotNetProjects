using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using AH.DUtility;
using AH.ModuleController.INVMSSR;

namespace AH.ModuleController.UI.INVMS.Forms
{
    public partial class frmTreeView : AH.Shared.UI.frmSmartFormStandard
    {
        INVMSSR.INVMSWSClient invSr = new INVMSSR.INVMSWSClient();
       
        public frmTreeView()
        {
            InitializeComponent();
           
        }
      

        public class TreeItem
        {
            public string Name;
            public int Level;
            public TreeItem(string name, int level)
            {
                Name = name; Level = level;
            }
        }
        private void LoadListView()
        {

            //List<TreeNode> rootsd = new List<TreeNode>();
            //TreeView tree = new TreeView();
            //rootsd.Add(tree.Nodes.Add("Root"));

            List<ItemMaster> spchls = invSr.GetItemMaster().ToList();
            int i = 0;
            foreach (ItemMaster spchld in spchls)
            {
                List<TreeItem> items = new List<TreeItem>();
                items.Add(new TreeItem(spchld.Day.ToString(), 0));
                items.Add(new TreeItem(spchld.ID, 1));
                //items.Add(new TreeItem(spchld.HolderTitleBeng, 2));
                
                PopulateTree(trList,items);

            }
        }

        public static void PopulateTree(TreeView tree, ICollection<TreeItem> items)
        {

            List<TreeNode> rootsd = new List<TreeNode>();
            rootsd.Add(tree.Nodes.Add(DateTime.UtcNow.Year.ToString()));

            foreach (TreeItem item in items)
            {
                if (item.Level == rootsd.Count)
                    rootsd.Add(rootsd[rootsd.Count - 1].LastNode);
                rootsd[item.Level].Nodes.Add(item.Name);
            }
           
            
        }
        public void PopulateCategories()
        {
            //TreeNode main = trList.Nodes.Add();
            TreeNode parentnode;
            TreeNode childnode;
            TreeNode subnode;
            string strGroup;
            System.Windows.Forms.TreeNode oNodex = null;
            List<ItemMaster> master = invSr.GetItemMaster().ToList();

            var americanCulture = new CultureInfo("en-US");

            for (int i = 2012; i <= DateTime.UtcNow.Year; i++)
            {
                parentnode = trList.Nodes.Add(i.ToString());

               // MessageBox.Show(parentnode.Text.ToString().Substring(7, 4));
                foreach (var month in  System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames)
                {
                    childnode = parentnode.Nodes.Add(month.ToString());

                   
                        foreach (ItemMaster itm in master)
                        {
                            DateTime dtedate = Convert.ToDateTime(itm.Day.ToString());
                            string satdate = dtedate.ToString("MMM");
                            string yrdate = dtedate.ToString("yyyy");
                            string daydate = dtedate.ToString("dd");

                            if (parentnode.Text.ToString() == yrdate.ToString())
                            {
                                if (childnode.Text.ToString().Substring(0, 3) == satdate.Substring(0, 3))
                                {
                                    subnode = childnode.Nodes.Add(itm.Day.ToString("dd/MM/yyyy"));

                                   
                                    subnode.Nodes.Add(itm.Name.ToString());
                                   
                                }
                            }

                        }
                    
                }
                
            }
            
      
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            PopulateCategories();
            

        }

        
    }
}
