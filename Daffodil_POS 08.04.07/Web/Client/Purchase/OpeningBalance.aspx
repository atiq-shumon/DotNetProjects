<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OpeningBalance.aspx.cs" Inherits="Client_Purchase_OpeningBalance"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<SCRIPT language="JavaScript" src="../../JavaScript/calendar.js"></SCRIPT>
<SCRIPT language="JavaScript" src="../../JavaScript/calendar-en.js"></SCRIPT>
<SCRIPT language="JavaScript" src="../../JavaScript/calendar-setup.js"></SCRIPT>
<script language="javascript" type="text/javascript">
 function clickbtn(btnctrl)
	{
		if (event.keyCode==13)
		{
		    document.getElementById(btnctrl).click();						
		    return false;
		}
	}	
	function FocusControl_byEnter()
    {
    if(event.keyCode==13)
         {
            if(document.activeElement.id=="ctl00_MainContent_txtOpeningDate")
            {
                document.getElementById('ctl00_MainContent_txtOpeningQty').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtOpeningQty")
            {
                document.getElementById('ctl00_MainContent_txtOpeningRate').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtOpeningRate")
            {
                document.getElementById('ctl00_MainContent_txtOpeningDiscount').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtOpeningDiscount")
            {
                document.getElementById('ctl00_MainContent_btnSave').focus();
            }
          }
    }
</script>

    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel id="UpdatePanel1" runat="server">
        <contenttemplate>
<TABLE width="100%"><TBODY><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%">&nbsp;</TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg"></asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg"></asp:Label></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%">&nbsp;</TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%"><asp:Label id="lblProductName" runat="server" Text="Product Name"></asp:Label></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:DropDownList id="ddlProductName" runat="server" Width="197px"></asp:DropDownList></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%"><asp:Label id="lblOpeningDate" runat="server" Text="Opening Date"></asp:Label></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:TextBox id="txtOpeningDate" runat="server"></asp:TextBox> <IMG style="WIDTH: 37px" id="imgOpeningDate" alt="Pick Date" src="../../Images/calendar.gif" /> <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" Width="5px" ToolTip="Please enter a valid date, " SetFocusOnError="True" ValidationGroup="PurchaseGroupTextField" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtOpeningDate" __designer:wfdid="w26">*</asp:RequiredFieldValidator> <asp:RangeValidator id="RangeValidator2" runat="server" __designer:dtid="3096224743817248" ToolTip="Please enter a valid date." SetFocusOnError="True" ErrorMessage="*" ControlToValidate="txtOpeningDate" __designer:wfdid="w27" MaximumValue="01/01/2999" MinimumValue="01/01/1973" Type="Date"></asp:RangeValidator>
<SCRIPT language="javascript" type="text/javascript">
                            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                              Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler);
                              
                              function pageLoadedHandler(sender, args) 
                                { SetMyCalendar(); }
                              function EndRequestHandler(sender, args) 
                                { SetMyCalendar();}
                              function SetMyCalendar() 
                              {
                                if (document.getElementById("ctl00_MainContent_txtOpeningDate") )
                                {
                                    Calendar.setup(
                                    {
                                        inputField  : "ctl00_MainContent_txtOpeningDate",      
                                        ifFormat    : "mm/dd/y",    
                                        button      : "imgOpeningDate",
                                        weekNumbers : false
                                    }
                                    );    
                                 } 
                                
                               }
                               	
                        </SCRIPT>
 </TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%"><asp:Label id="lblOpeningQty" runat="server" Text="Opening Qty"></asp:Label></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:TextBox id="txtOpeningQty" runat="server"></asp:TextBox></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%; HEIGHT: 21px"></TD><TD style="WIDTH: 20%"><asp:Label id="lblOpeningRate" runat="server" Text="Opening Rate"></asp:Label></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:TextBox id="txtOpeningRate" runat="server"></asp:TextBox></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%"><asp:Label id="lblOpeningDiscount" runat="server" Text="Opening Discount"></asp:Label></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><asp:TextBox id="txtOpeningDiscount" runat="server"></asp:TextBox></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%; HEIGHT: 51px"></TD><TD style="WIDTH: 20%"></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 17%"><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="60px" Text="Save" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnProduct" onclick="btnProduct_Click" runat="server" Width="1px" UseSubmitBehavior="False"></asp:Button></TD><TD width="60%"><asp:Button id="btnCancel" onclick="btnCancel_Click" runat="server" Width="60px" Text="Cancel" UseSubmitBehavior="False"></asp:Button></TD></TR></TBODY></TABLE></TD><TD style="WIDTH: 5%"></TD></TR><TR><TD style="WIDTH: 5%"></TD><TD style="WIDTH: 20%"></TD><TD style="WIDTH: 70%; TEXT-ALIGN: left"></TD><TD style="WIDTH: 5%"></TD></TR></TBODY></TABLE><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 10%"></TD><TD width="80%"></TD><TD style="WIDTH: 10%"></TD></TR><TR><TD style="WIDTH: 10%"></TD><TD width="80%"><asp:GridView id="GridView1" runat="server" EmptyDataText="Empty data table." SkinID="Skin1" AutoGenerateColumns="False"></asp:GridView> <asp:HiddenField id="HiddenField1" runat="server"></asp:HiddenField> <asp:HiddenField id="hfProductCode" runat="server"></asp:HiddenField> <asp:HiddenField id="txtHideFieldPK" runat="server" __designer:wfdid="w1"></asp:HiddenField> </TD><TD style="WIDTH: 10%"></TD></TR><TR><TD style="WIDTH: 10%"></TD><TD width="80%"></TD><TD style="WIDTH: 10%"></TD></TR></TBODY></TABLE>
</contenttemplate>
    </asp:UpdatePanel>
</asp:Content>

