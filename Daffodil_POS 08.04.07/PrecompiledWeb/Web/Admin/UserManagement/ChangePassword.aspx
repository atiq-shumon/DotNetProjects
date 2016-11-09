<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_UserManagement_ChangePassword, App_Web_-s9ls25s" title="Change Password Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <asp:ChangePassword id="ChangePassword1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
        BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
        Font-Size="0.8em" ContinueDestinationPageUrl="~/Default.aspx" Height="191px" Width="768px">
        <cancelbuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid" borderwidth="1px"
            font-names="Verdana" font-size="0.8em" forecolor="#284E98" />
        <instructiontextstyle font-italic="True" forecolor="Black" />
        <passwordhintstyle font-italic="True" forecolor="#507CD1" />
        <changepasswordbuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid"
            borderwidth="1px" font-names="Verdana" font-size="0.8em" forecolor="#284E98" />
        <continuebuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid"
            borderwidth="1px" font-names="Verdana" font-size="0.8em" forecolor="#284E98" />
        <titletextstyle backcolor="#507CD1" font-bold="True" font-size="0.9em" forecolor="White" />
        <textboxstyle font-size="0.8em" />
    </asp:ChangePassword>
    
</asp:Content>

