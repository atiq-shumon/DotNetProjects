<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_UserManagement_CreateUser, App_Web_-s9ls25s" title="New User Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <asp:CreateUserWizard id="CreateUserWizard1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Width="776px" Height="318px">
        <wizardsteps>
<asp:CreateUserWizardStep runat="server"></asp:CreateUserWizardStep>
<asp:CompleteWizardStep runat="server"></asp:CompleteWizardStep>
</wizardsteps>
        <sidebarstyle backcolor="#507CD1" font-size="0.9em" verticalalign="Top" />
        <titletextstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
        <sidebarbuttonstyle backcolor="#507CD1" font-names="Verdana" forecolor="White" />
        <navigationbuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid"
            borderwidth="1px" font-names="Verdana" forecolor="#284E98" />
        <headerstyle backcolor="#284E98" bordercolor="#EFF3FB" borderstyle="Solid" borderwidth="2px"
            font-bold="True" font-size="0.9em" forecolor="White" horizontalalign="Center" />
        <createuserbuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid"
            borderwidth="1px" font-names="Verdana" forecolor="#284E98" />
        <continuebuttonstyle backcolor="White" bordercolor="#507CD1" borderstyle="Solid"
            borderwidth="1px" font-names="Verdana" forecolor="#284E98" />
        <stepstyle font-size="0.8em" />
    </asp:CreateUserWizard>
   
</asp:Content>

