<%@ page language="C#" autoeventwireup="true" inherits="Purchase_PurchaseSupplierCodePopup, App_Web_wljhitgo" %>

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
    <td style="width: 109px">
        <asp:Label ID="Label1" runat="server" Text="Supplier Code"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtSupplierCode" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td style="width: 109px" >
        <asp:Label ID="Label2" runat="server" Text="Supplier Name"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td style="width: 109px" ></td>
    <td>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
    </tr>
    <tr>
    <td colspan="2">
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
