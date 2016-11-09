<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NotAuthorized.aspx.cs" Inherits="CustomErrorPages_NotAuthorized" Title="Not Authorized" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<center>
    <asp:Label ID="Label14" runat="server" SkinID="FormHeading" Text="You are not authorized to view this page!"></asp:Label><br /><br />
    <asp:Label ID="Label1" runat="server" Text="You may not have appropriate access rights to view this page."></asp:Label><br /><br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Go to Home Page</asp:HyperLink><br />
</center> 
</asp:Content>


