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
using DSL.Common.Security;

public partial class Admin_TestLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DPOSMembershipProvider obj = new DPOSMembershipProvider();
        obj.ValidateUser(this.txtUserName.Text, this.txtPassword.Text);

        Response.Redirect("Default.aspx");

        //this.txtUserName.Focus();

    }
}
