<%@ page language="C#" autoeventwireup="true" inherits="Admin_Setup_Product_ProductInfoPopup, App_Web_zyhzjyic" %>

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
    <td style="width: 114px">
        <asp:Label ID="Label1" runat="server" Text="Product Code"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td style="width: 114px">
        <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td style="width: 114px"></td>
    <td>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
    </tr>

    <tr>
    <td colspan ="2">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </td>
    
    </tr>

    </table>
    
    </div>
    </form>
</body>
</html>
