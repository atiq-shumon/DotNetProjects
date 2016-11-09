<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme="DPOSThemes"  AutoEventWireup="true" CodeFile="MemberInfo.aspx.cs" Inherits="MemberInfo"  MasterPageFile="~/MasterPage.master" Title="::.. Member Info ..::"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
<SCRIPT language="JavaScript" src="../../../JavaScript/calendar.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../../JavaScript/calendar-en.js"></SCRIPT>

<SCRIPT language="JavaScript" src="../../../JavaScript/calendar-setup.js"></SCRIPT>
<LINK rel="stylesheet" type="text/css" href="../../../JavaScript/calendar-system.css" />
<DIV id="masterDiv" class="DPOSStyleSheet.css">
<SCRIPT language="javascript" type="text/javascript">
//function doNumericWithFloat()
//{
//if(event.keyCode<46||event.keyCode==47||event.keyCode>57)event.returnValue=false;
//}


function formatDateField(){
    var value=document.getElementById("ctl00_MainContent_txtBirthday").value;
    if(value.length==2){
      document.getElementById("ctl00_MainContent_txtBirthday").value=document.getElementById("ctl00_MainContent_txtBirthday").value+"/";
    } else if(value.length==5){
      document.getElementById("ctl00_MainContent_txtBirthday").value=document.getElementById("ctl00_MainContent_txtBirthday").value+"/20";
    }
}
function FocusControl_byEnter()
{
    if(event.keyCode==13)
    {
        if (document.activeElement.id =="ctl00_MainContent_txtManualCode")
        {
           document.getElementById("ctl00_MainContent_txtName").focus();
        }
    
    else if (document.activeElement.id =="ctl00_MainContent_txtName")
        {
            document.getElementById("ctl00_MainContent_txtAttention").focus();
        }

    else if (document.activeElement.id =="ctl00_MainContent_txtAttention")
        {
            document.getElementById("ctl00_MainContent_txtContactPerson").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtContactPerson")
        {
            document.getElementById("ctl00_MainContent_txtAddress").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtAddress")
        {
            document.getElementById("ctl00_MainContent_txtPhone").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtPhone")
        {
            document.getElementById("ctl00_MainContent_txtMobile").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtMobile")
        {
            document.getElementById("ctl00_MainContent_txtFax").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtFax")
        {
            document.getElementById("ctl00_MainContent_txtEmail").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtEmail")
        {
            document.getElementById("ctl00_MainContent_txtWebsite").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtWebsite")
        {
            document.getElementById("ctl00_MainContent_txtBirthday").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtBirthday")
        {
            document.getElementById("ctl00_MainContent_txtCreditLimit").focus();
        }
    else if (document.activeElement.id =="ctl00_MainContent_txtCreditLimit")
        {
            document.getElementById("ctl00_MainContent_btnSave").focus();
        }
    }
    else if(document.activeElement.id=="ctl00_MainContent_txtCreditLimit")
        {
            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
            event.returnValue=false;
            }
        }
}
           
</SCRIPT>
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD vAlign=top align=left>&nbsp;</TD></TR><TR><TD vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="5%">&nbsp;</TD><TD style="WIDTH: 722px" vAlign=top align=left><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 19px" vAlign=top align=left><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD></TR><TR><TD vAlign=top align=left><TABLE style="WIDTH: 101%"><TBODY><TR><TD style="WIDTH: 14%"><asp:Label id="Code" runat="server" text="Code"></asp:Label></TD><TD style="WIDTH: 28%">&nbsp;<asp:TextBox style="VERTICAL-ALIGN: top" id="txtCode" runat="server" Width="134px" ReadOnly="true" BorderStyle="Solid" BackColor="Info" BorderWidth="1px"></asp:TextBox><!--<asp:Button ID="btnCode" runat="server" Text="..." Font-Bold="True" Height="22px" Width="30px" />--><INPUT style="FONT-WEIGHT: bold; WIDTH: 30px; HEIGHT: 22px" onclick='window.open("MemberIdPopup.aspx", "example1", "width=600, height=200,left=300,right=50,top=300,toolbar=no, scrollbars=yes, resizable=yes")' type=button value="..." name="button" /> </TD><TD style="WIDTH: 14%"><asp:Label id="ManualCode" runat="server" text="Manual Code"></asp:Label></TD><TD style="WIDTH: 50%"><asp:TextBox id="txtManualCode" runat="server" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="20"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Name" runat="server" text="Name"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtName" runat="server" Width="452px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="100"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Width="5px" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" Display="Dynamic" ToolTip="Required!" ErrorMessage="Please enter member name." ControlToValidate="txtName">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Attention" runat="server" text="Attention"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtAttention" runat="server" Width="452px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="5"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="ContactPerson" runat="server" text="Contact Person"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtContactPerson" runat="server" Width="452px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="50"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Address" runat="server" text="Address"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtAddress" runat="server" Width="452px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="150"></asp:TextBox> <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" Width="5px" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" Display="Dynamic" ToolTip="Required!" ErrorMessage="Enter address" ControlToValidate="txtAddress">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Phone" runat="server" text="Phone"></asp:Label></TD><TD style="WIDTH: 28%">&nbsp;<asp:TextBox id="txtPhone" runat="server" Width="174px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="50"></asp:TextBox></TD><TD style="WIDTH: 14%"><asp:Label id="Mobile" runat="server" text="Mobile"></asp:Label></TD><TD style="WIDTH: 50%"><asp:TextBox id="txtMobile" runat="server" Width="149px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="50"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Fax" runat="server" text="Fax"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=2>&nbsp;<asp:TextBox id="txtFax" runat="server" Width="174px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="50"></asp:TextBox></TD><TD style="WIDTH: 50%">&nbsp;</TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Email" runat="server" text="E-mail"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtEmail" runat="server" Width="298px" BorderStyle="Solid" BorderWidth="1px" MaxLength="50"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" Display="Dynamic" ToolTip="Enter  e-mail address" ErrorMessage="Enter  e-mail address" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="Website" runat="server" text="Web Site"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=3>&nbsp;<asp:TextBox id="txtWebsite" runat="server" Width="298px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="70"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="BirthDay" runat="server" text="Birth Day"></asp:Label></TD><TD colSpan=2>&nbsp;<asp:TextBox style="VERTICAL-ALIGN: top" id="txtBirthday" runat="server" Width="130px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="10" ToolTip='Please enter date format "mm/dd/yyyy"'></asp:TextBox> <IMG id="imgBirthDay" alt="Pick Date" src="../../../Images/calendar.gif" />
<SCRIPT language="javascript" type="text/javascript">
                          Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                          Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
                          
                          function pageLoadedHandler(sender, args) 
                            { SetMyCalendar(); }
                          function EndRequestHandler(sender, args) 
                            { SetMyCalendar();}
                          function SetMyCalendar() 
                          {
                            if (document.getElementById("ctl00_MainContent_txtBirthday") )
                            {
                                Calendar.setup(
                                {
                                    inputField  : "ctl00_MainContent_txtBirthday",      
                                    ifFormat    : "mm/dd/y",    
                                    button      : "imgBirthDay",   
                                    weekNumbers : false
                                }
                                );    
                            }   
                           }	    

                           </SCRIPT>
 <asp:RangeValidator id="RangeValidator1" runat="server" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" ToolTip="Please enter a valid date." ErrorMessage="*" ControlToValidate="txtBirthday" MinimumValue="01/01/1973" MaximumValue="01/01/2999" Type="Date"></asp:RangeValidator>&nbsp;&nbsp;&nbsp;</TD><TD style="WIDTH: 50%">&nbsp;</TD></TR><TR><TD style="WIDTH: 14%"><asp:Label id="CreditLimit" runat="server" text="Credit Limit"></asp:Label></TD><TD style="WIDTH: 35%" colSpan=2>&nbsp;<asp:TextBox id="txtCreditLimit" runat="server" Width="174px" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="MemberTextFieldGroup" MaxLength="14"></asp:TextBox><asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" Font-Bold="True" ValidationGroup="MemberGroupTextField" SetFocusOnError="True" Display="Dynamic" ToolTip="You must enter a valid price." ErrorMessage="You must enter a valid price." ControlToValidate="txtCreditLimit" ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="WIDTH: 50%">&nbsp;</TD></TR><TR><TD style="WIDTH: 14%">&nbsp;</TD><TD style="WIDTH: 28%"><TABLE style="BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE: none" width="100%"><TBODY><TR><TD style="WIDTH: 65px; HEIGHT: 26px"><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="65px" ValidationGroup="MemberGroupTextField" UseSubmitBehavior="False" Text="Save"></asp:Button></TD><TD style="WIDTH: 119px; HEIGHT: 26px"><asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Width="65px" UseSubmitBehavior="False" Text="Cancel"></asp:Button></TD></TR></TBODY></TABLE></TD><TD style="WIDTH: 14%">&nbsp;</TD><TD style="WIDTH: 50%"><asp:ObjectDataSource id="ObjectDataSource1" runat="server" TypeName="DSL.POS.BusinessLogicLayer.Imp.MemberInfoBLImp" SelectMethod="showDataMemberInfo" DeleteMethod="DeleteMemberRecord" DataObjectTypeName="DSL.POS.DTO.DTO.MemberInfoDTO">
                    </asp:ObjectDataSource> <asp:HiddenField id="txtHideFieldPK" runat="server"></asp:HiddenField> </TD></TR></TBODY></TABLE></TD></TR><TR><TD vAlign=top align=left></TD></TR><TR><TD vAlign=top align=left><DIV style="OVERFLOW: auto; WIDTH: 725px; HEIGHT: 226px"><asp:GridView id="GridView1" runat="server" DataSourceID="ObjectDataSource1" OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_BeforeEdting" OnRowCommand="GridView1_RowEdting" SkinID="Skin1" DataKeyNames="PrimaryKey"><Columns>
<asp:BoundField DataField="PrimaryKey" Visible="False" SortExpression="PrimaryKey" HeaderText="PrimaryKey"></asp:BoundField>
<asp:BoundField DataField="CustId" SortExpression="CustId" HeaderText="Code">
<ItemStyle Width="120px" Wrap="False" HorizontalAlign="Center"></ItemStyle>

<HeaderStyle Wrap="False" HorizontalAlign="Center"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="CustName" SortExpression="CustName" HeaderText="Name">
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="CustAtten" SortExpression="CustAtten" HeaderText="Attention"></asp:BoundField>
<asp:BoundField DataField="ContactPerson" SortExpression="ContactPerson" HeaderText="Contact Person"></asp:BoundField>
<asp:BoundField DataField="CustAddr" SortExpression="CustAddr" HeaderText="Address"></asp:BoundField>
<asp:BoundField DataField="CustPhone" SortExpression="CustPhone" HeaderText="Phone"></asp:BoundField>
<asp:BoundField DataField="CreditLimit" SortExpression="CreditLimit" HeaderText="Credit Limit">
<ItemStyle HorizontalAlign="Right"></ItemStyle>

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
</asp:BoundField>
<asp:BoundField DataField="CustFax" Visible="False" SortExpression="CustFax" HeaderText="Fax"></asp:BoundField>
<asp:BoundField DataField="CustEmail" Visible="False" SortExpression="CustEmail" HeaderText="E-mail"></asp:BoundField>
<asp:CommandField UpdateText="" SelectText="" NewText="" CancelText="" InsertText="" DeleteText="" ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
</Columns>
</asp:GridView>&nbsp; <asp:ValidationSummary id="ValidationSummary1" runat="server" ValidationGroup="MemberGroupTextField" ShowSummary="False" ShowMessageBox="True"></asp:ValidationSummary> </DIV></TD></TR></TBODY></TABLE></TD><TD width="2%">&nbsp;</TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: 19px" vAlign=top align=left></TD></TR></TBODY></TABLE></DIV>
</ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
