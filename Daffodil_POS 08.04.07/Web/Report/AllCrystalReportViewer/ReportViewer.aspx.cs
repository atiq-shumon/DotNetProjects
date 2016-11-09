using System;
using System.IO;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DSL.POS.Report;
using DSL.POS.Report.Setup;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.ComponentModel;

public partial class Report_AllCrystalReport_ReportViewer : System.Web.UI.Page
{

    private ReportDocument oReportDocument = new ReportDocument();

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            oReportDocument = CommonViewer.CRReportDefinition;

            this.CrystalReportViewer1.ReportSource = oReportDocument;
            this.CrystalReportViewer1.Visible = true;

        }
        catch (Exception exp)
        {
            throw exp;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MemoryStream oStream; // using System.IO
        oStream = (MemoryStream)
        oReportDocument.ExportToStream(
        CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
        Response.Clear();
        Response.Buffer = true;
        Response.ContentType = "application/pdf";
        Response.BinaryWrite(oStream.ToArray());
        //Response.Flush();
        ////Do some java script to bring up the printer dialog
        //StringBuilder sb = new StringBuilder();
        //sb.Append("<script>");
        //sb.Append(Environment.NewLine);
        //sb.Append("window.open(\"Web\\Report\\AllCrystalReport\\ReportViewer.aspx.cs\",\"Print\",\"top=5,left=5,scrollbars=yes\");");
        //sb.Append(Environment.NewLine);
        //sb.Append("</script>");

        //ClientScript.RegisterStartupScript(this.GetType(), "print", sb.ToString());
        Response.End();

    }
    //private ExportOptions oExportOptions;
    //private DiskFileDestinationOptions oDiskFileDestinationOptions = new DiskFileDestinationOptions();
    //private string fileName;


    //private void Page_Init(object sender, EventArgs e)
    //{

    //    DataSet oDataSet = new DataSet();
    //    DateTime dt1, dt2;

    //    try 
    //    {
    //    string strCommonPath = CommonViewer.ReportPath;
    //    oDataSet = CommonViewer.ReportDataSet;

    //    dt1 = Convert.ToDateTime("02/02/2000");
    //    dt2 = Convert.ToDateTime("02/02/2007");
    //    string reportPath = Server.MapPath(strCommonPath);
    //    oReportDocument.Load(reportPath);
    //    oReportDocument.SetDataSource(oDataSet.Tables[0]);
    //    oReportDocument.SetParameterValue("@PraStartDate", dt1);
    //    oReportDocument.SetParameterValue("@PraEndDate", dt2);
    //    this.CrystalReportViewer1.ReportSource = oReportDocument;
    //    this.CrystalReportViewer1.Visible = true;    
    //    //this.CrystalReportViewer1.SeparatePages = false;
    //    //this.CrystalReportViewer1.DisplayGroupTree = false;
    //    //this.CrystalReportViewer1.DisplayToolbar = false;
    //    //Create export file path in client machine 
    //    ////fileName = "c:\\exports\\" + Session.SessionID.ToString() + ".pdf";



    //    ////oDiskFileDestinationOptions.DiskFileName = fileName;
    //    ////oExportOptions = oReportDocument.ExportOptions;
    //    ////oExportOptions.DestinationOptions = oDiskFileDestinationOptions;
    //    ////oExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
    //    ////oExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
    //    ////oReportDocument.Export(oExportOptions);

    //    //create the directory in the local machine
    //    //Directory.CreateDirectory(fileName);


    //    // The following code writes the pdf file to the Client’s browser.
    //    ////Response.ClearContent();
    //    ////Response.ClearHeaders();
    //    ////Response.ContentType = "application/pdf";
    //    ////Response.WriteFile(fileName);

    //    ////Response.Flush();
    //    ////Response.Close();
    //    //this.CrystalReportViewer1.ReportSource = oReportDocument;

    //    //delete the exported file from disk
    //    //File.Delete(fileName);
    //    }
    //    catch(Exception exp)
    //    {
    //        throw exp;
    //    }


    //}
    
}
