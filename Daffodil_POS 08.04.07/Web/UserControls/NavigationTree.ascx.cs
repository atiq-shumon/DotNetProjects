using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class UserControls_NavigationTree : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public TreeView NavigationTree
    {
        get
        {
            return TreeView1;
        }
    }
    protected void TreeView1_DataBinding(object sender, EventArgs e)
    {

    }
    protected void TreeView1_DataBound(object sender, EventArgs e)
    {
        if (Roles.IsUserInRole(ConfigurationManager.AppSettings["adminrolename"]))
        {
            TreeNode n = TreeView1.Nodes[0];
            n.ChildNodes.RemoveAt(4);
        }
        if (Roles.IsUserInRole(ConfigurationManager.AppSettings["poweruserrolename"]))
        {
            TreeNode n = TreeView1.Nodes[0];
            n.ChildNodes.RemoveAt(3);
        }
        if (Roles.IsUserInRole(ConfigurationManager.AppSettings["purchaseuserrolename"]))
        {
            TreeNode n = TreeView1.Nodes[0];
            n.ChildNodes.RemoveAt(3);
        }
        if (Roles.IsUserInRole(ConfigurationManager.AppSettings["salesuserrolename"]))
        {
            TreeNode n = TreeView1.Nodes[0];
            n.ChildNodes.RemoveAt(4);
        }
        if (Roles.IsUserInRole(ConfigurationManager.AppSettings["generaluserrolename"]))
        {
            TreeNode n = TreeView1.Nodes[0];
            n.ChildNodes.RemoveAt(5);
        }
        
    }
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {

    }
    protected void TreeView1_TreeNodeDataBound(object sender, TreeNodeEventArgs e)
    {
        if (e.Node.Parent != null)
        {
            if (e.Node.Parent.Value == "setup")
            {
                e.Node.NavigateUrl = Page.ResolveUrl("~/" + ConfigurationManager.AppSettings["poweruserfolder"] + "/" + e.Node.NavigateUrl);
            }
            if (e.Node.Parent.Value == "purchase")
            {
                e.Node.NavigateUrl = Page.ResolveUrl("~/" + ConfigurationManager.AppSettings["purchaseuserfolder"] + "/" + e.Node.NavigateUrl);
            }
            if (e.Node.Parent.Value == "sales")
            {
                e.Node.NavigateUrl = Page.ResolveUrl("~/" + ConfigurationManager.AppSettings["salesuserfolder"] + "/" + e.Node.NavigateUrl);
            }
            if (e.Node.Parent.Value == "report")
            {
                e.Node.NavigateUrl = Page.ResolveUrl("~/" + ConfigurationManager.AppSettings["generaluserfolder"] + "/" + e.Node.NavigateUrl);
            }
            if (e.Node.Parent.Value == "administration")
            {
                e.Node.NavigateUrl = Page.ResolveUrl("~/" + ConfigurationManager.AppSettings["adminfolder"] + "/" + e.Node.NavigateUrl);
            }

        }
    }
}
