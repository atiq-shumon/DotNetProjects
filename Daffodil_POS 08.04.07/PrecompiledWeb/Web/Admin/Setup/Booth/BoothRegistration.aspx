<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Admin_Setup_Booth_BoothRegistration, App_Web_qryxc9bu" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
  
<DIV style="TEXT-ALIGN: center" id="masterDiv" class="DPOSStyleSheet.css">

<table cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td vAlign=top align=left>&nbsp;<asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label></TD></TR><TR><TD vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 5%">&nbsp;</TD><TD><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><tbody><tr><td vAlign=top align=left><table style="BORDER-TOP-STYLE: solid; BORDER-RIGHT-STYLE: solid; BORDER-LEFT-STYLE: solid; BORDER-COLLAPSE: collapse; BORDER-BOTTOM-STYLE: solid" width="100%" border=0><TBODY><TR><TD style="FONT-WEIGHT: bold; FONT-SIZE: 20pt; BORDER-TOP-STYLE: solid; FONT-FAMILY: Verdana; BORDER-RIGHT-STYLE: solid; BORDER-LEFT-STYLE: solid; HEIGHT: 70px; TEXT-ALIGN: center; BORDER-BOTTOM-STYLE: solid">

</td></tr><tr><td style="BORDER-TOP-STYLE: solid; BORDER-RIGHT-STYLE: solid; BORDER-LEFT-STYLE: solid; HEIGHT: 200px; BACKGROUND-COLOR: #9999cc; BORDER-BOTTOM-STYLE: solid"><TABLE style="BORDER-RIGHT: silver thick solid; BORDER-TOP: silver thick solid; BORDER-LEFT: silver thick solid; BORDER-BOTTOM: silver thick solid; BACKGROUND-COLOR: white" width="60%" align=center border=0><TBODY><TR><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: center" colSpan=3><asp:Label id="Label1" runat="server" Text="Registration Type" Font-Bold="True" Font-Italic="True" Font-Size="Larger" ForeColor="#C000C0"></asp:Label></TD></TR><TR><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 45%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: right"><asp:CheckBox id="chkPermanent" runat="server" Text="Permanent" Font-Bold="True"></asp:CheckBox></TD><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: left" width="30%"><asp:CheckBox id="chkDemo" runat="server" Text="Demo" Font-Bold="True"></asp:CheckBox></TD>
<td id="tdHide" style=" display:none; border-right : #ccccff thin solid; border-top : #ccccff thin solid; border-left : #ccccff thin solid; width : 30%; border-bottom : #ccccff thin solid"  width="25%"><asp:Panel id="pnlDay" runat="server" Font-Bold="True"><asp:TextBox id="txtBoothExpiresDate" runat="server" Width="53px" BorderStyle="Solid" BorderWidth="1px" MaxLength="3"></asp:TextBox>Days</asp:Panel></td></tr><tr><td style="border-right : #ccccff thin solid; BORDER-TOP: #ccccff thin solid; border-left : #ccccff thin solid; width : 45%; border-bottom : #ccccff thin solid; text-align : right"><asp:Label id="Label2" runat="server" Text="Booth No." Font-Bold="True"></asp:Label></td><td style="border-right : #ccccff thin solid; BORDER-TOP: #ccccff thin solid; border-left : #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: left">&nbsp;<asp:DropDownList id="ddlBoothNo" runat="server" Font-Bold="True" Width="85px"></asp:DropDownList> </TD><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid">&nbsp;<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" SetFocusOnError="True" Display="Dynamic" ControlToValidate="ddlBoothNo" ErrorMessage="Please ! select a booth no.">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 45%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: right">&nbsp;</TD><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: left"></TD><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid">&nbsp;<asp:Button id="btnBoothReg" onclick="btnBoothReg_Click" runat="server" Text="Registration" Font-Bold="True" Font-Names="Verdana" BackColor="Gainsboro" UseSubmitBehavior="False"></asp:Button></TD></TR><TR><TD style="BORDER-RIGHT: #ccccff thin solid; BORDER-TOP: #ccccff thin solid; BORDER-LEFT: #ccccff thin solid; WIDTH: 30%; BORDER-BOTTOM: #ccccff thin solid; TEXT-ALIGN: right" colSpan=3><asp:ValidationSummary id="ValidationSummary1" runat="server" ShowSummary="False" ShowMessageBox="True" DisplayMode="SingleParagraph"></asp:ValidationSummary>&nbsp;&nbsp; </TD></TR></TBODY></TABLE></TD></TR><TR><TD style="BORDER-TOP-STYLE: solid; BORDER-RIGHT-STYLE: solid; BORDER-LEFT-STYLE: solid; HEIGHT: 50px; BACKGROUND-COLOR: lightblue; BORDER-BOTTOM-STYLE: solid"></TD></TR></TBODY></TABLE></TD></TR><TR><TD vAlign=top align=left></TD></TR></TBODY></TABLE><asp:HiddenField id="txtHideFieldPK" runat="server"></asp:HiddenField></TD><TD style="WIDTH: 5%">&nbsp;</TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: 17px" vAlign=top align=left></TD></TR></TBODY></TABLE>

</DIV>
</ContentTemplate>
        </asp:UpdatePanel>
<script language="javascript" type="text/javascript" >

function doNumeric()
{
if(event.keyCode!=13 && event.keyCode<48||event.keyCode>57)event.returnValue=false;
}

function FocusControl_byEnter()
{
if(event.keyCode==13)
     {
        if (document.activeElement.id=="ctl00_MainContent_chkPermanent")
        {
           if(document.getElementById('ctl00_MainContent_chkPermanent').checked)
           {
            document.getElementById('ctl00_MainContent_ddlBoothNo').focus();
            }
            else
            {
            document.getElementById('ctl00_MainContent_chkDemo').focus();
            return false;
            }

        }
        else if (document.activeElement.id=="ctl00_MainContent_chkDemo")
        {
            if(document.getElementById('ctl00_MainContent_chkDemo').checked)
            {
            document.getElementById('tdHide').style['display']='';
            document.getElementById('ctl00_MainContent_txtBoothExpiresDate').focus();
            }
            else
            {
            document.getElementById('tdHide').style['display']='none';
            document.getElementById('ctl00_MainContent_ddlBoothNo').focus();
            return false;
            }
      
        }
        else if (document.activeElement.id=="ctl00_MainContent_txtBoothExpiresDate")
        {
        document.getElementById('ctl00_MainContent_ddlBoothNo').focus();
        }
        else if(document.activeElement.id=="ctl00_MainContent_ddlBoothNo")
        {
        document.getElementById('ctl00_MainContent_btnBoothReg').focus();
        }
    }
}

</script>
</asp:Content>

