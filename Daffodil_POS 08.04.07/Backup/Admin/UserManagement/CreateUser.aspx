<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateUser.aspx.cs" Inherits="Admin_UserManagement_CreateUser" Title="::.. New User Info ..::" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
        Height="175px" OnActiveStepChanged="CreateUserWizard1_ActiveStepChanged" OnContinueButtonClick="CreateUserWizard1_ContinueButtonClick"
        OnCreatedUser="CreateUserWizard1_CreatedUser" OnNextButtonClick="CreateUserWizard1_NextButtonClick"
        Width="336px">
        <WizardSteps>
            <asp:WizardStep runat="server" Title="Please tell us about yourself" ID="WizardStep1">
                <table style="width: 100%">
                    <tr>
                        <td align="right" contenteditable="true">
                            <asp:Label ID="Label3" runat="server" SkinID="FormLabel" Text="First Name :"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                Display="Dynamic" ErrorMessage="Please enter first name"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" contenteditable="true">
                            <asp:Label ID="Label4" runat="server" SkinID="FormLabel" Text="Last Name :"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                                Display="Dynamic" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </asp:WizardStep>
            <asp:CreateUserWizardStep runat="server">
            </asp:CreateUserWizardStep>
            <asp:WizardStep runat="server" StepType="Step" Title="Choose your role" ID="WizardStep2">
                <table width="100%">
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="Label1" runat="server" Text="Create As :"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="256px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </asp:WizardStep>
            <asp:CompleteWizardStep runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
        <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
        <TitleTextStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
        <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
            BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
        <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px"
            Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
        <CreateUserButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
            BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
        <ContinueButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
            BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
        <StepStyle Font-Size="0.8em" />
        <StartNavigationTemplate>
            <asp:Button ID="StartNextButton" runat="server" BackColor="White" BorderColor="#507CD1"
                BorderStyle="Solid" BorderWidth="1px" CommandName="MoveNext" Font-Names="Verdana"
                ForeColor="#284E98" Text="Next" />
        </StartNavigationTemplate>
    </asp:CreateUserWizard>
   
</asp:Content>

