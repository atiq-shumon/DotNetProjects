<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="ui_setup_BranchInfo, App_Web_gpsu6vxa" title="Branch Info Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css" >
<script language="javascript"  type="text/javascript" >
//function doNumericWithFloat()
//{
//if(event.keyCode!=13 && event.keyCode<46||event.keyCode==47||event.keyCode>57)event.returnValue=false;
//}

//function doNumeric()
//{
//if(event.keyCode!=13 && event.keyCode<48||event.keyCode>57)event.returnValue=false;
//}
function test()
    {
        alert("Data Save Successfully.");
    }
    
function FocusControl_byEnter()
{
    if(event.keyCode==13)
    {
        if (document.activeElement.id =="ctl00_MainContent_ddlBranchType")
        {
           
           document.getElementById("ctl00_MainContent_txtBranchName").focus();
        }
    
        else if (document.activeElement.id =="ctl00_MainContent_txtBranchName")
            {
                document.getElementById("ctl00_MainContent_txtBranchAddress").focus();
            }

        else if (document.activeElement.id =="ctl00_MainContent_txtBranchAddress")
            {
                document.getElementById("ctl00_MainContent_txtContactPerson").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtContactPerson")
            {
                document.getElementById("ctl00_MainContent_txtContactPersonPhone").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtContactPersonPhone")
            {
                document.getElementById("ctl00_MainContent_txtBranchPrefix").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtBranchPrefix")
            {
                document.getElementById("ctl00_MainContent_txtTelephone1").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtTelephone1")
            {
                document.getElementById("ctl00_MainContent_txtTelephone2").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtTelephone2")
            {
                document.getElementById("ctl00_MainContent_txtTelephone3").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtTelephone3")
            {
                document.getElementById("ctl00_MainContent_txtFax").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtFax")
            {
                document.getElementById("ctl00_MainContent_txtEMail").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtEMail")
            {
                document.getElementById("ctl00_MainContent_txtCashInSafeLimit").focus();
            }
        else if (document.activeElement.id =="ctl00_MainContent_txtCashInSafeLimit")
            {
                document.getElementById("ctl00_MainContent_btnAdd").focus();
            }
    }
    else if(document.activeElement.id =="ctl00_MainContent_txtCashInSafeLimit")
        {
            if(event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
                event.returnValue=false;
            }
            
        }
}
           
</script>  
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top" >&nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top" >
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td style="width: 5%">&nbsp;</td>
          <td style="width: 90%">
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top" ><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top" >
                <table border="0" cellspacing="0" cellpadding="0" style="width: 674px">
                <tr align="left" valign="top"> 
                      <td style="width: 28%;"> <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label></td>
                      <td style="width: 32%;"><asp:TextBox ID="txtBranchCode" runat="server" BackColor="Info" ReadOnly="True" BorderStyle="Solid" BorderWidth="1px" style="vertical-align: top" Width="115px" MaxLength="3"></asp:TextBox><asp:Button
                              ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" UseSubmitBehavior="False" /></td>
                      <td style="width: 27%;"> <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label></td>
                      <td style="width: 62%;"><asp:DropDownList ID="ddlBranchType" runat="server" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid" Width="153px"> 
                        </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlBranchType"
                              Display="Dynamic" ErrorMessage="Select a branch type!" SetFocusOnError="True"
                              ToolTip="Select a branch type!" ValidationGroup="BranchGroupTextField">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%;" > <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                      <td colspan="3" style="width: 30%;" ><asp:TextBox ID="txtBranchName" runat="server" Width="450px" BackColor="White" MaxLength="50" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBranchName"
                              ErrorMessage="Branch name can't be blank !. Please enter." ToolTip="Required!" ValidationGroup="BranchGroupTextField" Width="5px" Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%"><asp:Label ID="Label7" runat="server" Text="Address"></asp:Label></td>
                      <td colspan="3" style="width: 30%"><asp:TextBox ID="txtBranchAddress" runat="server" BackColor="White" MaxLength="150" BorderStyle="Solid" BorderWidth="1px" Width="450px"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBranchAddress"
                              ErrorMessage="address can't be blank !." ValidationGroup="BranchGroupTextField" Width="7px" ToolTip="Required!" Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%; height: 22px;" ><asp:Label ID="Label4" runat="server" Text="Contact Person"></asp:Label></td>
                      <td colspan="3" style="width: 30%; height: 22px;" ><asp:TextBox ID="txtContactPerson" runat="server" BackColor="White" MaxLength="50" BorderStyle="Solid" BorderWidth="1px" Width="450px"></asp:TextBox>
                          </td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%;"><asp:Label ID="Label5" runat="server" Text="Contact Person Phone"></asp:Label></td>
                      <td style="width: 32%;"><asp:TextBox ID="txtContactPersonPhone" runat="server" BackColor="White" MaxLength="15" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></td>
	                  <td style="width: 27%;"><asp:Label ID="Label6" runat="server" Text="Prefix"></asp:Label></td>
                      <td style="width: 62%;"><asp:TextBox ID="txtBranchPrefix" runat="server" BackColor="White" MaxLength="3" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBranchPrefix"
                              ErrorMessage="prefix can't be blank !." ToolTip="Required!" ValidationGroup="BranchGroupTextField" Display="Dynamic" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
					</tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%"><asp:Label ID="Label8" runat="server" Text="Telephone1"></asp:Label></td>
                    <td style="width: 32%"><asp:TextBox ID="txtTelephone1" runat="server" BackColor="White" MaxLength="15" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></td>
                      <td style="width: 27%"><asp:Label ID="Label9" runat="server" Text="Telephone2"></asp:Label></td>
                    <td style="width: 62%"><asp:TextBox ID="txtTelephone2" runat="server" BackColor="White" MaxLength="15" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></td>
                    </tr>
                    <tr align="left" valign="top"> 

                      <td style="width: 28%" ><asp:Label ID="Label10" runat="server" Text="Telephone3"></asp:Label></td>
                      <td style="width: 32%" ><asp:TextBox ID="txtTelephone3" runat="server" BackColor="White" MaxLength="15" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></td>
                      <td style="width: 27%" ><asp:Label ID="Label11" runat="server" Text="Fax"></asp:Label></td>
                      <td style="width: 62%" ><asp:TextBox ID="txtFax" runat="server" BackColor="White" MaxLength="25" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 28%; height: 11px;"><asp:Label ID="Label12" runat="server" Text="E-mail"></asp:Label></td>
                      <td style="width: 32%; height: 11px;"><asp:TextBox ID="txtEMail" runat="server" BackColor="White" MaxLength="25" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEMail"
                              ErrorMessage="Enter  e-mail address" ToolTip="Enter  e-mail address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                              ValidationGroup="BranchGroupTextField" Display="Dynamic">*</asp:RegularExpressionValidator></td>
                      <td style="width: 27%; height: 11px;"><asp:Label ID="Label13" runat="server" Text="Cash In Safe Limit"></asp:Label></td>
                      <td style="width: 62%; height: 11px;"><asp:TextBox ID="txtCashInSafeLimit" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" MaxLength="14"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCashInSafeLimit"
                              ErrorMessage="Cash in safe limit  can't be blank !." ToolTip="Required!" ValidationGroup="BranchGroupTextField" Width="1px" Font-Bold="False" Display="Dynamic">*</asp:RequiredFieldValidator>
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCashInSafeLimit"
                              ErrorMessage="You must enter a valid price." ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}"
                              ValidationGroup="BranchGroupTextField" Font-Bold="True" Display="Dynamic">*</asp:RegularExpressionValidator>
                          </td>
                    </tr>
                    <tr>
                      <td style="width: 28%; height: 43px;"></td>
                      <td style="width: 32%; height: 43px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td style="width: 71px"><asp:Button ID="btnAdd" runat="server"
								Text="Save" OnClick="btnAdd_Click" Width="65px" ValidationGroup="BranchGroupTextField" UseSubmitBehavior="False" /></td>
                            <td>
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="65px" OnClick="btnCancel_Click" UseSubmitBehavior="False" /></td>
                          </tr>
                        </table></td>
                      <td style="width: 27%; height: 43px; vertical-align: top;"><asp:Button ID="btnPrint" runat="server"
								Text="Print"  Width="65px" AccessKey="P" TabIndex="2" OnClick="btnPrint_Click" Visible="False" /></td>
                      <td style="width: 62%; height: 43px"></td>
                    </tr>
					
                  </table>
                    </td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height: 210px" >
                <div id="divGridView" class="DPOSStyleSheet.css" style="width: 711px; height: 322px">
                <asp:GridView ID="GridView1" 
			runat="server" 
			AutoGenerateColumns="False" 
			DataSourceID="ObjectDataSource1"
			OnRowCommand ="GridView1_RowEditing"
			OnRowDataBound = "GridView1_RowDataBound"
			OnRowEditing="GridView1_BeforeEditing" SkinID="Skin1" DataKeyNames="PrimaryKey" OnRowDeleted="GridView1_RowDeleted"
			>
					<Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="BranchCode" SortExpression="BranchCode" HeaderText="Code">
<ItemStyle Width="50px" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="BranchName" SortExpression="BranchName" HeaderText="Name">
<ItemStyle Wrap="True"></ItemStyle>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="ContactPerson" SortExpression="ContactPerson" HeaderText="Contact Person">
<ItemStyle Wrap="True"></ItemStyle>

<HeaderStyle Wrap="True"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="ContactPersonPhone" SortExpression="ContactPersonPhone" HeaderText="Contact Person Phone">
<ItemStyle Wrap="True"></ItemStyle>

<HeaderStyle Wrap="True"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="BranchAddress" SortExpression="BranchAddress" HeaderText="Address">
<ItemStyle Wrap="True"></ItemStyle>
</asp:BoundField>
<asp:BoundField DataField="Fax" SortExpression="Fax" HeaderText="Fax">
<ItemStyle Wrap="False"></ItemStyle>
</asp:BoundField>
<asp:BoundField DataField="CashInSafeLimit" SortExpression="CashInSafeLimit" HeaderText="Cash In Safe Limit">
<ItemStyle Wrap="True" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle Wrap="True" HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:CommandField ShowCancelButton="False" ButtonType="Button" ShowEditButton="True"></asp:CommandField>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
                    <RowStyle Wrap="True" />
                    <PagerStyle Wrap="True" />
                    <HeaderStyle Wrap="False" />
			</asp:GridView>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="44px" ShowMessageBox="True"
        ValidationGroup="BranchGroupTextField" Width="184px" ShowSummary="False" />
			</div>
			</td>
              </tr>
            </table></td>
          <td style="width: 2%">&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top" ></td>
  </tr>
</table>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetBranchInfo" TypeName="DSL.POS.BusinessLogicLayer.Imp.BranchInfoBLImpl" DataObjectTypeName="DSL.POS.DTO.DTO.BranchInfoDTO" DeleteMethod="deleteBranch">
    </asp:ObjectDataSource>
    <asp:HiddenField ID="txtBR_PK" runat="server" />
    &nbsp;

 </div> 
</asp:Content>

