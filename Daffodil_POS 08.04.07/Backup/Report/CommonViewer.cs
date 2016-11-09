using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace DSL.POS.Report
{
  public  class CommonViewer
    {


      private static ReportDocument _crReportDefinition;
     
      /// <summary>
      /// Get or set report ReportDocument.
      /// </summary>
      public static ReportDocument CRReportDefinition
      {
        set
        {
            _crReportDefinition = value;
        }
        get
        {
            return _crReportDefinition;
        }
      }
    
    }
}
