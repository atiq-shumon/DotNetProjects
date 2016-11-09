<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NavigationTree.ascx.cs" Inherits="UserControls_NavigationTree" %>
<asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" ShowLines="True" OnDataBinding="TreeView1_DataBinding" OnDataBound="TreeView1_DataBound" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" OnTreeNodeDataBound="TreeView1_TreeNodeDataBound">
    <DataBindings>
        <asp:TreeNodeBinding DataMember="TopMenu" Text="Menu Options" Value="Options" />
        <asp:TreeNodeBinding DataMember="Login" NavigateUrlField="url" Text="Login" Value="Login" />
        <asp:TreeNodeBinding DataMember="ChangePassword" NavigateUrlField="url" Text="Change Password"
            Value="ChangePassword" />
        <asp:TreeNodeBinding DataMember="Setup" Text="Setup" Value="setup" />
        <asp:TreeNodeBinding DataMember="BranchTypeInfo" NavigateUrlField="url" Text="BranchTypeInfo"
            Value="BranchTypeInfo" />
        <asp:TreeNodeBinding DataMember="BranchInfo" NavigateUrlField="url" Text="Branch Info"
            Value="BranchInfo" />
        <asp:TreeNodeBinding DataMember="BoothInfo" NavigateUrlField="url" Text="Booth Info"
            Value="BoothInfo" />
        <asp:TreeNodeBinding DataMember="BoothRegistration" NavigateUrlField="url" Text="Booth Registration"
            Value="BoothRegistration" />
        <asp:TreeNodeBinding DataMember="ProductCategoryInfo" NavigateUrlField="url" Text="Product Category Info"
            Value="ProductCategoryInfo" />
        <asp:TreeNodeBinding DataMember="ProductSubCategoryInfo" NavigateUrlField="url" Text="Product Sub CategoryInfo"
            Value="ProductSubCategoryInfo" />
        <asp:TreeNodeBinding DataMember="ProductUnitInfo" NavigateUrlField="url" Text="Product Unit Info"
            Value="ProductUnitInfo" />
        <asp:TreeNodeBinding DataMember="ProductBrandInfo" NavigateUrlField="url" Text="Product Brand Info"
            Value="ProductBrandInfo" />
        <asp:TreeNodeBinding DataMember="ProductInfo" NavigateUrlField="url" Text="Product Info"
            Value="ProductInfo" />
        <asp:TreeNodeBinding DataMember="SupplierInfo" NavigateUrlField="url" Text="Supplier Info"
            Value="SupplierInfo" />
        <asp:TreeNodeBinding DataMember="MemberInfo" NavigateUrlField="url" Text="Member Info"
            Value="MemberInfo" />
        <asp:TreeNodeBinding DataMember="Purchase" Text="Purchase" Value="purchase" />
        <asp:TreeNodeBinding DataMember="PurchaseInfo" NavigateUrlField="url" Text="Purchase Info"
            Value="PurchaseInfo" />
        <asp:TreeNodeBinding DataMember="Sales" Text="Sales" Value="sales" />
        <asp:TreeNodeBinding DataMember="SalesInfo" NavigateUrlField="url" Text="Sales Info"
            Value="SalesInfo" />
        <asp:TreeNodeBinding DataMember="Report" Text="Report" Value="report" />
        <asp:TreeNodeBinding DataMember="PurchaseReport" NavigateUrlField="url" Text="Purchase Report"
            Value="PurchaseReport" />
        <asp:TreeNodeBinding DataMember="SalesReport" NavigateUrlField="url" Text="Sales Report"
            Value="SalesReport" />
        <asp:TreeNodeBinding DataMember="SetupReport" NavigateUrlField="url" Text="Setup Report"
            Value="SetupReport" />
        <asp:TreeNodeBinding DataMember="StockReport" NavigateUrlField="url" Text="Stock Report"
            Value="StockReport" />
        <asp:TreeNodeBinding DataMember="Administration" Text="Administration" Value="administration" />
        <asp:TreeNodeBinding DataMember="CreateUser" NavigateUrlField="url" Text="Create User"
            Value="CreateUser" />
    </DataBindings>
</asp:TreeView>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/UserControls/NavigationTree.xml">
</asp:XmlDataSource>
