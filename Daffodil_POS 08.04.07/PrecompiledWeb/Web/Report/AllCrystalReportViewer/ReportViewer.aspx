<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Report_AllCrystalReport_ReportViewer, App_Web_uqtcuzoz" title="Report Viewer Page" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Print" /><br />
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="false"
        Width="790px" Height="600px"  style="overflow: auto" BestFitPage="False" DisplayGroupTree="False" DisplayToolbar="False" />
   </asp:Content>

