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
using System.Text;
//using DSL.POS.Facade;

public partial class ui_setup_FindData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["PrintGridviewColumns"] != null &&
               Session["PrintGridViewDataSource"] != null)
        {
            //Add the columns to the print gridview
            foreach (DataControlField dcf in (DataControlFieldCollection)Session["PrintGridviewColumns"])
            {
                this.GridView1.Columns.Add(dcf);
                if ((dcf.HeaderText == "Name") || (dcf.HeaderText == "Cash Limit"))
                {
                    break;
                }
            }

            //Set the data source and databind
            this.GridView1.DataSource = Session["PrintGridViewDataSource"];
            this.GridView1.DataBind();

            //Do some java script to bring up the printer dialog
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language='javascript'>");
            sb.Append("window.print();");
            sb.Append("</script>");

            ClientScript.RegisterStartupScript(this.GetType(), "print", sb.ToString());
            Session["PrintGridviewColumns"] = null;
            Session["PrintGridViewDataSource"] = null;
        }

    }
}
