<%@ page language="C#" autoeventwireup="true" inherits="Admin_Setup_Product_ProductUnitInfoPopup, App_Web_zyhzjyic" %>

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
        <asp:Label ID="Label1" runat="server" Text="Product Unit Code"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtProductUnitCode" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td style="width: 122px" >
        <asp:Label ID="Label2" runat="server" Text="Product Unit Name"></asp:Label></td>
    <td>
        <asp:TextBox ID="txtProductUnitName" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td style="width: 122px" ></td>
    <td>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
    </tr>

    <tr>
    <td  colspan ="2">
        <asp:GridView ID="GridView1" HeaderStyle-BackColor="gray" runat="server" AutoGenerateColumns="False">
            <HeaderStyle BackColor="Gray" />
            <Columns>
                <asp:BoundField DataField="PU_Code" HeaderText="Product Unit Code" />
                <asp:BoundField DataField="PU_Name" HeaderText="Product Unit Name" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetProductUnitInfo" TypeName="DSL.POS.BusinessLogicLayer.Imp.ProductUnitBLImpl"></asp:ObjectDataSource>
    </td>

    </tr>

    </table>
    
    </div>
    </form>
</body>
</html>
