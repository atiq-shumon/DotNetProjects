<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BranchInfoPopup.aspx.cs" Inherits="Admin_Setup_Branch_BranchInfoPopup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="70%">
    <tr>
    <td style="width: 122px">
        <asp:Label ID="Label1" runat="server" Text="Branch Code"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtBranchCode" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td style="width: 122px" >
        <asp:Label ID="Label2" runat="server" Text="Branch Name"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtBranchName" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td style="width: 122px" ></td>
    <td>
        <asp:Button ID="btnSearch" runat="server" Text="Search" /></td>
    </tr>

    <tr>
    <td  colspan ="2">
        <asp:GridView ID="GridView1" HeaderStyle-BackColor="gray" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Branch Code" ></asp:BoundField>
                <asp:BoundField HeaderText="Branch Name" ></asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </td>

    </tr>

    </table>
    
    </div>
    </form>
</body>
</html>
