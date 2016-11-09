<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="ui_setup_SupplierInfo, App_Web_chmdtl3c" title="Supplier Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="masterDiv" class="DPOSStyleSheet.css">
<script language ="javascript" type="text/javascript">

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_txtShortName")
        {
        document.getElementById('ctl00_MainContent_txtSupplierName').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtSupplierName")
        {
        document.getElementById('ctl00_MainContent_txtAddress').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtAddress")
        {
        document.getElementById('ctl00_MainContent_txtContractPerson').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtContractPerson")
        {
        document.getElementById('ctl00_MainContent_txtPhone').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtPhone")
        {
        document.getElementById('ctl00_MainContent_txtFax').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtFax")
        {
        document.getElementById('ctl00_MainContent_txtEmail').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtEmail")
        {
        document.getElementById('ctl00_MainContent_txtWebAddress').focus();
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtWebAddress")
        {
        document.getElementById('ctl00_MainContent_btnSave').focus();
        }
    }
}
</script>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td align="left" valign="top">
        &nbsp;</td>
  </tr>
  <tr>
    <td align="left" valign="top" ><table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr align="left" valign="top"> 
          <td width="2%">&nbsp;</td>
          <td width="96%"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td align="left" valign="top" style="width: 743px" ><asp:Label ID="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label></td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="height: 19px; width: 743px;">
                    &nbsp;</td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="width: 743px"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="width: 100%">
                    <tr align="left" valign="top"> 
                      <td style="width: 5%; height: 24px;"> <asp:Label ID="Label1" runat="server" Text="Code" Height="19px"></asp:Label></td>
                      <td style="width: 33%; height: 24px;"><asp:TextBox ID="txtSupplierCode" runat="server" BackColor="Info" ReadOnly="True" BorderStyle="Solid" BorderWidth="1px" Width="147px" style="vertical-align: top" maxlength="6"></asp:TextBox>
                      <!--<asp:Button ID="btnFind" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />-->
<input type="button" name="button" value="..." onclick= 'window.open("SupplierPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' style="font-weight: bold; width: 30px; height: 22px"/>                      
                      
                      </td>
                      <td style="width: 7%; height: 24px;"> &nbsp;<asp:Label ID="lblShortName" runat="server" Text="Short Name" Width="90px"></asp:Label></td>
                      <td style="width: 50%; height: 24px;">
                <asp:TextBox ID="txtShortName" runat="server" Width="191px" BorderStyle="Solid" BorderWidth="1px" maxlength="25"></asp:TextBox></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%; height: 22px;"> 
                <asp:Label ID="lblSupplierName" runat="server" Text="Name" Width="115px" Height="19px"></asp:Label></td>
                      <td colspan="3" style="width: 30%; height: 22px;">
                <asp:TextBox ID="txtSupplierName" runat="server" Width="487px" OnTextChanged="txtSupplierName_TextChanged" BorderStyle="Solid" BorderWidth="1px" maxlength="100"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSupplierName"
                              ErrorMessage="Please enter supplier name." ToolTip="Required!" ValidationGroup="SupplierGroupTextField"
                              Width="5px" SetFocusOnError="True">*</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%;">
                <asp:Label ID="lblAddress" runat="server" Text="Address" Width="115px" Height="19px"></asp:Label></td>
                      <td colspan="3" style="width: 30%;">
                <asp:TextBox ID="txtAddress" runat="server" Width="487px" BorderStyle="Solid" BorderWidth="1px" maxlength="150"></asp:TextBox></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%">
                <asp:Label ID="lblContractPerson" runat="server" Text="Contract Person" Width="104px" Height="19px"></asp:Label></td>
                      <td colspan="3" style="width: 30%"><asp:TextBox ID="txtContractPerson" runat="server" Width="487px" BorderStyle="Solid" BorderWidth="1px" maxlength="50" ></asp:TextBox></td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%">
                <asp:Label ID="lblPhone" runat="server" Text="Phone" Width="115px" Height="19px"></asp:Label></td>
                      <td style="width: 33%">
                <asp:TextBox ID="txtPhone" runat="server" Width="181px" BorderStyle="Solid" BorderWidth="1px" maxlength="30"></asp:TextBox></td>
	                  <td style="width: 7%">
                          &nbsp;<asp:Label ID="lblFax" runat="server" Text="Fax" Width="92px" Height="19px"></asp:Label></td>
                      <td style="width: 50%">
                <asp:TextBox ID="txtFax" runat="server" Width="191px" BorderStyle="Solid" BorderWidth="1px" maxlength="30"></asp:TextBox></td>
					</tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%; height: 24px;">
                <asp:Label ID="lblEmail" runat="server" Text="E-mail" Width="115px" Height="19px"></asp:Label></td>
                    <td style="width: 33%; height: 24px;">
                <asp:TextBox ID="txtEmail" runat="server" Width="181px" BorderStyle="Solid" BorderWidth="1px" maxlength="30"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEMail"
                            ErrorMessage="Please enter an e-mail address. Example: kasem_prcn@yahoo.com." ToolTip="Enter  e-mail address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ValidationGroup="SupplierGroupTextField" SetFocusOnError="True">*</asp:RegularExpressionValidator></td>
                      <td style="width: 7%; height: 24px;">
                          &nbsp;<asp:Label ID="lblWebAddress" runat="server" Text="Web Address" Width="92px" Height="19px"></asp:Label></td>
                    <td style="width: 50%; height: 24px;">
                <asp:TextBox ID="txtWebAddress" runat="server" Width="191px" BorderStyle="Solid" BorderWidth="1px" maxlength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr align="left" valign="top"> 
                      <td style="width: 5%"></td>
                      <td style="width: 33%">
                      <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Save" ValidationGroup="SupplierGroupTextField" Width="65px" UseSubmitBehavior="False"/>
                          <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="65px" OnClick="btnCancel_Click" UseSubmitBehavior="False" /></td>
					<td style="width: 7%"></td>
                      <td style="width: 50%">
                          <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph"
                              ValidationGroup="SupplierGroupTextField" ShowMessageBox="True" ShowSummary="False" />
                      </td>
                    </tr>
                  </table>
                    &nbsp;</td>
              </tr>
              <tr>
                <td align="left" valign="top" style="width: 743px" >
    <div id="divGridView" style="overflow-x:scroll; width: 753px; height: 370px; overflow: auto;">
    <asp:GridView ID="GridView1" runat="server"
        DataSourceID="ObjectDataSource1" 
        OnRowCommand="GridView1_RowEdting"
        OnRowEditing="GridView1_BeforeEdting"    
        OnRowDataBound="GridView1_RowDataBound"    
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="PrimaryKey" SkinID="Skin1" UseAccessibleHeader="False" EmptyDataText="There are no Data!" Height="168px" OnRowDeleted="GridView1_RowDeleted">
        <emptydatarowstyle backcolor="#FFFFC0" />
        <Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="SupplierCode" SortExpression="SupplierCode" HeaderText="Code">
<ItemStyle Width="120px" Wrap="True" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="SupplierName" SortExpression="SupplierName" HeaderText="Name">
<HeaderStyle Wrap="True" HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="ContractPerson" SortExpression="ContractPerson" HeaderText="Contract Person">
<HeaderStyle Wrap="True"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="ShortName" SortExpression="ShortName" HeaderText="Nick Name"></asp:BoundField>
<asp:BoundField DataField="Fax" SortExpression="Fax" HeaderText="Fax"></asp:BoundField>
<asp:BoundField DataField="Email" SortExpression="Email" HeaderText="Email"></asp:BoundField>
<asp:BoundField DataField="WebAddress" SortExpression="WebAddress" HeaderText="Web Address"></asp:BoundField>
<asp:BoundField DataField="Phone" SortExpression="Phone" HeaderText="Phone"></asp:BoundField>
<asp:CommandField ButtonType="Button" HeaderText="Edit" ShowEditButton="True"></asp:CommandField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
</Columns>
    </asp:GridView>
    </div>
    </td>
              </tr>
              <tr> 
                <td align="left" valign="top" style="width: 743px" >
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="showDataSupplierInfo"
        TypeName="DSL.POS.BusinessLogicLayer.Imp.SupplierInfoBLImp" DataObjectTypeName="DSL.POS.DTO.DTO.SupplierInfoDTO" DeleteMethod="DeleteSupplierRecord"></asp:ObjectDataSource>
    <asp:HiddenField ID="txtHideFieldPK" runat="server" />
    </td>
              </tr>
            </table></td>
          <td width="2%"></td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td align="left" valign="top" style="height: 19px">
        </td>
  </tr>
</table>
    
   
</div>
</asp:Content>

