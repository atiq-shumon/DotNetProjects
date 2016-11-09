<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Report_Default" Title="::.. All Report Page ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top" style="height:60px; text-align: center; background-color: turquoise;">
        <strong><span style="font-size: 24pt">Point of Sales Report</span></strong></td>
  </tr>
  <tr>
    <td align="left" valign="top">
    
    <table width="100%" >
        <tr>
          <td width="10%">&nbsp;</td>
          <td>
          <table style="width:100%;">
          <tr>
          <td style="width:10%; text-align: right; height: 62px;">
          <img src="../Images/TreeLineImages/hrisS.jpg" style="width: 60px; height: 56px; border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid;" id="IMG1" /></td>
          <td style="width:80%; height: 62px;">
              <strong>
                  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Report/Sales/SalesReport.aspx">Sales Report</asp:HyperLink></strong></td>
              <td style="width: 10%; height: 62px;">
              </td>
          </tr>
              <tr>
                  <td style="width: 10%; text-align: right;">
                      <img src="../Images/TreeLineImages/hris.gif" style="width: 60px; height: 56px; border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid;" dynsrc="Sales/SalesReport.aspx" /></td>
                  <td style="width: 80%;">
                      <strong>
                          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Report/Purchase/PurchaseReport.aspx">Purchase Report</asp:HyperLink></strong></td>
                  <td style="width: 10%;">
                  </td>
              </tr>
              <tr>
                  <td style="width: 10%; text-align: right;"><img src="../Images/TreeLineImages/references.jpg" style="width: 60px; height: 56px; border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid;" dynsrc="Setup/SetupReport.aspx" />
                  </td>
                  <td style="width: 80%;">
                      <strong>
                          <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Report/Setup/SetupReport.aspx">Setup Report</asp:HyperLink></strong></td>
                  <td style="width: 10%;">
                  </td>
              </tr>
              <tr>
                  <td style="width: 10%; text-align: right">
                  </td>
                  <td style="width: 80%">
                      <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Report/Stock/StockReport.aspx"
                          Style="font-weight: bold">Stock Report</asp:HyperLink></td>
                  <td style="width: 10%">
                  </td>
              </tr>
          </table>
          </td>
          <td width="10%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top" style="height:20px; text-align: center; background-color: turquoise;"></td>
  </tr>
</table>

</asp:Content>

