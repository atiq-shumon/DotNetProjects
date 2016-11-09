<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateRoles.aspx.cs" Inherits="Admin_UserManagement_CreateRoles" Title="User Rights Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
    <br />
    <table style="width: 532px">
        <tr>
            <td style="width: 89px">
            </td>
            <td style="width: 104px; text-align: right">
                <asp:Label id="Label1" runat="server" Text="Role Name"></asp:Label></td>
            <td>
                <asp:TextBox id="txtRoleName" runat="server">
    </asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 89px">
            </td>
            <td style="width: 104px; text-align: right">
                <asp:Label id="Label2" runat="server" Text="Description"></asp:Label></td>
            <td>
                <asp:TextBox id="txtRoleDescription" runat="server">
                </asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 89px">
            </td>
            <td style="width: 104px; text-align: right">
            </td>
            <td>
                <asp:Button id="btnAdd" runat="server" onclick="btnAdd_Click" Text="Save" Width="50px" /></td>
        </tr>
    </table>
    
</asp:Content>

