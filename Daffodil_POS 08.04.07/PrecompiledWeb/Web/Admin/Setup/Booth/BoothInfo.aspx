<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="ui_setup_BoothInfo, App_Web_qryxc9bu" title="Booth Info Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<DIV id="masterDiv" class="DPOSStyleSheet.css"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD vAlign=top align=left>&nbsp;</TD></TR><TR><TD vAlign=top align=left><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR vAlign=top align=left><TD style="WIDTH: 10%">&nbsp;</TD><TD style="WIDTH: 89%"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 702px" vAlign=top align=left><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD></TR><TR><TD style="WIDTH: 702px" vAlign=top align=left>&nbsp;</TD></TR><TR><TD style="WIDTH: 702px" vAlign=top align=left><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR vAlign=top align=left><TD style="WIDTH: 15%; HEIGHT: 23px"><asp:Label id="Label1" runat="server" Text="Booth No."></asp:Label></TD><TD style="WIDTH: 85%; HEIGHT: 23px">&nbsp;<asp:TextBox style="VERTICAL-ALIGN: top; BACKGROUND-COLOR: infobackground" id="txtBoothNo" runat="server" ReadOnly="True" Width="210px" Enabled="False" BorderWidth="1px" BorderStyle="Solid"></asp:TextBox><!--<asp:Button ID="btnFind" runat="server" Text="..." Height="22px" Width="34px" Font-Bold="True" />--><INPUT style="FONT-WEIGHT: bold; WIDTH: 30px; HEIGHT: 22px" onclick='window.open("BoothNoPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' type=button value="..." name="button" /> </TD></TR><TR vAlign=top align=left><TD style="WIDTH: 15%; HEIGHT: 26px"><asp:Label id="lblBranchName" runat="server" Text="Branch Name" Width="95px"></asp:Label></TD><TD style="WIDTH: 85%; HEIGHT: 26px">&nbsp;<asp:DropDownList style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" id="ddlBranchName" runat="server" Width="248px" OnSelectedIndexChanged="ddlBranchName_SelectedIndexChanged"> 
                        </asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ValidationGroup="BoothInfoGroupField" ToolTip="Select a branch name!" SetFocusOnError="True" ErrorMessage="Select a branch name!" Display="Dynamic" ControlToValidate="ddlBranchName">*</asp:RequiredFieldValidator></TD></TR><TR vAlign=top align=left><TD style="WIDTH: 15%; HEIGHT: 24px"><asp:Label id="lblCashLimit" runat="server" Text="Cash Limit"></asp:Label></TD><TD style="WIDTH: 85%; HEIGHT: 24px">&nbsp;<asp:TextBox id="txtCashLimit" runat="server" Width="244px" BorderWidth="1px" BorderStyle="Solid" OnTextChanged="txtCashLimit_TextChanged" MaxLength="14"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="5px" ValidationGroup="BoothInfoGroupField" ToolTip="Required Field!" SetFocusOnError="True" ErrorMessage="Cash Limit Field can't be blank !" Display="Dynamic" ControlToValidate="txtCashLimit">*</asp:RequiredFieldValidator> <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ValidationGroup="BoothInfoGroupField" ToolTip="You must enter a valid price." SetFocusOnError="True" ErrorMessage="Please enter a valid price." Display="Dynamic" ControlToValidate="txtCashLimit" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR vAlign=top align=left><TD style="WIDTH: 15%; HEIGHT: 24px"><asp:Label id="lblBoothStatus" runat="server" Text="Booth Status"></asp:Label></TD><TD style="WIDTH: 85%; HEIGHT: 24px"><asp:CheckBox id="chkBoothStatus" runat="server" Checked="True"></asp:CheckBox></TD></TR><TR vAlign=top align=left><TD style="WIDTH: 15%">&nbsp;</TD><TD style="WIDTH: 85%"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR vAlign=top align=left><TD style="WIDTH: 11%; HEIGHT: 24px">&nbsp;<asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Text="Save" Width="65px" ValidationGroup="BoothInfoGroupField" UseSubmitBehavior="False"></asp:Button></TD><TD style="HEIGHT: 24px" width="85%">&nbsp;<asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Text="Cancel" Width="65px" UseSubmitBehavior="False"></asp:Button></TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>&nbsp;</TD></TR><TR><TD style="WIDTH: 702px" vAlign=top align=left><!--  <div id="GridViewDiv" style="width: 518px; height: 323px" >--><asp:GridView id="GridView1" runat="server" DataSourceID="ObjectDataSource1" Width="496px" SkinID="Skin1" OnRowEditing="GridView1_BeforeEdting" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowEdting" DataKeyNames="PrimaryKey" AutoGenerateColumns="False" OnRowDeleted="GridView1_RowDeleted"><Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="BR_PK" Visible="False" SortExpression="BR_PK" HeaderText="BR_PK"></asp:BoundField>
<asp:BoundField DataField="BoothNo" SortExpression="BoothNo" HeaderText="BoothNo">
<ItemStyle Width="20%" Wrap="True" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="BoothCashLimit" SortExpression="BoothCashLimit" HeaderText="Booth Cash Limit">
<ItemStyle Width="60%" Wrap="False" HorizontalAlign="Right"></ItemStyle>

<HeaderStyle Wrap="False" HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:CheckBoxField DataField="BoothStatus" SortExpression="BoothStatus" HeaderText="Status">
<ItemStyle HorizontalAlign="Center"></ItemStyle>
</asp:CheckBoxField>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
</Columns>
</asp:GridView> <asp:ValidationSummary id="ValidationSummary1" runat="server" Width="282px" ValidationGroup="BoothInfoGroupField" ShowSummary="False" ShowMessageBox="True"></asp:ValidationSummary> <asp:HiddenField id="txtHideFieldPK" runat="server"></asp:HiddenField> <asp:ObjectDataSource id="ObjectDataSource1" runat="server" DeleteMethod="DeleteBoothRecord" DataObjectTypeName="DSL.POS.DTO.DTO.BoothInfoDTO" TypeName="DSL.POS.BusinessLogicLayer.Imp.BoothInfoBLImp" SelectMethod="showDataBoothInfo">
    </asp:ObjectDataSource> </TD></TR><TR><TD style="WIDTH: 702px" vAlign=top align=left></TD></TR></TBODY></TABLE></TD><TD style="WIDTH: 4%">&nbsp;</TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: 19px" vAlign=top align=left></TD></TR></TBODY></TABLE></DIV>
</ContentTemplate>
        </asp:UpdatePanel>




<script language="javascript" type="text/javascript">

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_ddlBranchName")
        {
        document.getElementById('ctl00_MainContent_txtCashLimit').focus();
        }
        else if(document.activeElement.id=="ctl00_MainContent_txtCashLimit")
        {
        document.getElementById('ctl00_MainContent_chkBoothStatus').focus();
        }
        else if(document.activeElement.id=="ctl00_MainContent_chkBoothStatus")
        {
       document.getElementById('ctl00_MainContent_btnSave').focus();
        }
    }
    else if(document.activeElement.id=="ctl00_MainContent_txtCashLimit")
        {
            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
            event.returnValue=false;
            }
        }
}


</script>


</asp:Content>