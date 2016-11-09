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
using DSL.POS.Report;
using DSL.POS.Report.Setup;
using System.ComponentModel;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

public partial class Client_Sales_Default2 : System.Web.UI.Page
{
    private ReportDocument oReportDocument = new ReportDocument();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            TextBox1.Attributes.Add("onkeypress", "clickbtn('"+ Button1.ClientID +"')");
            TextBox2.Attributes.Add("onkeypress", "clickbtn('" + Button2.ClientID + "')");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "pan 1";
        ScriptManager1.SetFocus(TextBox2);
        //string script = "document.getElementById('" + TextBox1.ClientID + "').focus();";
                
        //script = script + " WebForm_AutoFocus('" + TextBox1.ClientID + "');";

        //Page.ClientScript.RegisterStartupScript(this.GetTy pe(), "script1", script, true); 
        //ScriptManager sm = new ScriptManager();
        //sm.SetFocus(TextBox2);
        //CallbackPanel1.Controls.Add(new LiteralControl(String.Format(@"<script type=""text/javascript"">document.getElementById(""{0}"").focus();</script>", TextBox1.ClientID)));

        //string timeout="setTimeout(\"$('"+ TextBox2.ClientID + "').focus(); \",1000);";
        //ClientScript.RegisterStartupScript(this.GetType(), "onkeypress", timeout, true);
        //System.Web.UI.ClientScriptManager a = new ClientScriptManager();
        
        //ClientScript.RegisterStartupScript(this.GetType, "focusit", timeout, true);
        //TextBox2.Focus();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = Request.UserHostAddress.ToString();
        //TextBox1.Focus();
        ScriptManager1.SetFocus(TextBox1);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //ReportSalesInfo  oReportSalesInfo= new ReportSalesInfo ();

        //Guid SalesInfoPk = Guid.NewGuid();

        //SalesInfoPk = (Guid)TypeDescriptor.GetConverter(SalesInfoPk).ConvertFromString("00000000-0000-0000-0000-000000000000");


        //DateTime dt1, dt2;
        //dt1 = Convert.ToDateTime("02/02/2000");
        //dt2 = Convert.ToDateTime("02/02/2007");
        //Guid productCategoryPk = Guid.NewGuid();
        //Guid productSubCategoryPk = Guid.NewGuid();
        //Guid productBrandPk = Guid.NewGuid();

        //productCategoryPk = (Guid)TypeDescriptor.GetConverter(productCategoryPk).ConvertFromString("00000000-0000-0000-0000-000000000000");
        //productSubCategoryPk = (Guid)TypeDescriptor.GetConverter(productSubCategoryPk).ConvertFromString("00000000-0000-0000-0000-000000000000");
        //productBrandPk = (Guid)TypeDescriptor.GetConverter(productBrandPk).ConvertFromString("00000000-0000-0000-0000-000000000000");


        //DataSet rptDS = new DataSet();
        //rptDS = oReportSalesInfo.GetSalesInfo(dt1, dt2);//, productCategoryPk, productSubCategoryPk, productBrandPk);

        ////CommonViewer.ReportDataSet = rptDS;
        ////CommonViewer.ReportPath = "CrysSalesRegister.rpt";
        ////CommonViewer.Param1 = "02/02/2000";
        ////CommonViewer.Param2 = "02/02/2007";

        //string parm1, parm2;
        //string crPath = "CrysSalesRegister.rpt";
        
        //parm1 = "02/02/2000"; ;
        //parm2 = "02/02/2007";


        //string reportPath = Server.MapPath(crPath);
        //oReportDocument.Load(reportPath);
        //oReportDocument.SetDataSource(rptDS.Tables[0]);
        //oReportDocument.SetParameterValue("@Param1", parm1);
        //oReportDocument.SetParameterValue("@Param2", parm2);
        
        
        //CommonViewer.CRReportDefinition = oReportDocument;

        //Response.Redirect("/Web/Report/AllCrystalReport/ReportViewer.aspx");
         
    }
}
