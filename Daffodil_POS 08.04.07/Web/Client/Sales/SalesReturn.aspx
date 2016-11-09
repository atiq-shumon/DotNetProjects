<%@ Page Language="C#" Theme="DPOSThemes" StylesheetTheme ="DPOSThemes" AutoEventWireup="true" CodeFile="SalesReturn.aspx.cs" Inherits="SalesReturn"  MasterPageFile="~/MasterPage.master" Title ="::.. Sales Return ..::"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">

    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<DIV id="masterDiv" class="DPOSStyleSheet"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 754px" vAlign=top align=left></TD></TR><TR><TD style="WIDTH: 754px; HEIGHT: 919px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="5%"></TD><TD><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 17px" vAlign=top align=left><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg">
</asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg">
</asp:Label></TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left></TD></TR><TR><TD vAlign=top align=left><asp:Panel id="pnlMemberId" runat="server" Width="100%" DefaultButton="btnClickMemberID"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 116px"><asp:Label id="CustomerId" runat="server" text="Member ID">
                        </asp:Label></TD><TD style="WIDTH: 218px"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtCustomerId" runat="server" Width="180px" BorderStyle="Solid" BackColor="Info" ValidationGroup="MemberGroupValidation" BorderWidth="1px">
                        </asp:TextBox></TD><TD style="WIDTH: 94px"><asp:Button id="btnClickMemberID" onclick="btnClickMemberID_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False">
                        </asp:Button><asp:Label id="Date" runat="server" Visible="False" text="Date" Enabled="False"></asp:Label> <asp:Button id="btnCustomerId" runat="server" Width="30px" Height="22px" Font-Bold="True" Visible="False" ValidationGroup="MemberGroupValidation" Text="..." UseSubmitBehavior="False" Enabled="False"></asp:Button></TD><TD><asp:TextBox style="VERTICAL-ALIGN: top" id="txtDate" runat="server" Width="183px" BorderStyle="Solid" BackColor="Info" Visible="False" BorderWidth="1px"></asp:TextBox></TD></TR></TBODY></TABLE></asp:Panel></TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><asp:Panel id="pnlMember" runat="server" Width="597px" Height="80px" Visible="False"><TABLE style="WIDTH: 116%" id="tblMem"><TBODY><TR><TD style="WIDTH: 116px"><asp:Label id="CustomerName" runat="server" text="Member Name"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtCustomerName" runat="server" Width="504px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" ValidationGroup="MemberGroupValidation" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="Address" runat="server" text="Address"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtAddress" runat="server" Width="504px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" ValidationGroup="MemberGroupValidation" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="DepositBalance" runat="server" text="Deposit Balance"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtDepositBalance" runat="server" Width="180px" ReadOnly="True" BorderStyle="Solid" BackColor="Info" ValidationGroup="MemberGroupValidation" BorderWidth="1px"></asp:TextBox></TD></TR></TBODY></TABLE></asp:Panel></TD></TR><TR><TD vAlign=top align=left><asp:Panel id="pnlProcuct" runat="server" Width="100%" DefaultButton="btnClickProductCode"><TABLE width="100%"><TBODY><TR></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 116px"><asp:Label id="InvoiceNo" runat="server" text="Invoice No"></asp:Label></TD><TD style="VERTICAL-ALIGN: top" colSpan=1><asp:TextBox style="VERTICAL-ALIGN: top" id="txtInvoiceNo" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox> <asp:Button id="btnInvoice" onclick="btnInvoice_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False"></asp:Button></TD><TD id="tdHide" colSpan=2><asp:Panel id="pnlInvoiceDate" runat="server" Width="300px" Visible="False" __designer:wfdid="w4"><asp:Label id="Label1" runat="server" Text="Invoice Date"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox id="txtInvoiceDate" runat="server" Width="183px" BorderWidth="1px"></asp:TextBox></asp:Panel></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="Label5" runat="server" text="Product Name" __designer:wfdid="w2"></asp:Label></TD><TD style="VERTICAL-ALIGN: top" colSpan=1><asp:DropDownList id="ddlProductName" runat="server" Width="185px" __designer:wfdid="w1"></asp:DropDownList></TD><TD style="VERTICAL-ALIGN: top" colSpan=1><asp:Label id="Product" runat="server" text="Product Code">
                </asp:Label></TD><TD style="VERTICAL-ALIGN: top"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtProduct" runat="server" Width="183px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="ProductName" runat="server" text="Product Name"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtProductName" runat="server" Width="505px" BorderStyle="Solid" BackColor="Info" ValidationGroup="ProductGroupValidation" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="Rate" runat="server" text="Rate"></asp:Label></TD><TD style="WIDTH: 220px"><asp:TextBox id="txtRate" runat="server" Width="180px" BorderStyle="Solid" ValidationGroup="ProductGroupValidation" BorderWidth="1px"></asp:TextBox></TD><TD style="WIDTH: 94px"><asp:Label style="VERTICAL-ALIGN: top" id="Discount" runat="server" Text="Discount"></asp:Label></TD><TD style="WIDTH: 246px"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtDiscount" runat="server" Width="183px" BorderStyle="Solid" ValidationGroup="ProductGroupValidation" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 116px"><asp:Label id="Label2" runat="server" Text="Quantity"></asp:Label></TD><TD style="WIDTH: 220px"><asp:TextBox accessKey="q" style="VERTICAL-ALIGN: top" id="txtQuantity" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Font-Bold="True" ValidationGroup="ProductGroupValidation" SetFocusOnError="True" ErrorMessage="Enter a valid number." ControlToValidate="txtQuantity" ValidationExpression="\d+[.]?[\d]{0,4}" ToolTip="Enter a valid number." Display="Dynamic">*</asp:RegularExpressionValidator></TD><TD style="VERTICAL-ALIGN: top; WIDTH: 94px">&nbsp; <asp:Button style="VERTICAL-ALIGN: top" id="btnAdd" onclick="btnAdd_Click" runat="server" Width="60px" Text="Add" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnClickProductCode" tabIndex=1 onclick="btnClickProductCode_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnClickProduct_ddl" tabIndex=2 onclick="btnClickProduct_ddl_Click" runat="server" Width="1px" Height="1px" Text="." UseSubmitBehavior="False"></asp:Button></TD><TD style="VERTICAL-ALIGN: top; WIDTH: 246px"></TD></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 116px; HEIGHT: 21px"></TD><TD style="WIDTH: 220px; HEIGHT: 21px">&nbsp;&nbsp;</TD><TD style="VERTICAL-ALIGN: top; WIDTH: 94px; HEIGHT: 21px">&nbsp;&nbsp; </TD><TD style="WIDTH: 246px; HEIGHT: 21px"></TD></TR></TBODY></TABLE></asp:Panel> </TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><DIV style="OVERFLOW: auto; WIDTH: 677px; HEIGHT: 120px"><asp:GridView id="GridView1" runat="server" EmptyDataText="There are no data!" OnRowEditing="GridView1_RowEditing" DataKeyNames="PK" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowEdting" AutoGenerateColumns="False">
                        <columns>
<asp:CommandField ButtonType="Button" ShowEditButton="True"></asp:CommandField>
<asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
<asp:BoundField DataField="Product Code" SortExpression="Product Code" HeaderText="Code">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="Product Name" SortExpression="Product Name" HeaderText="Product Name">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="Quantity" SortExpression="Quantity" HeaderText="Quantity">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="Rate" SortExpression="Rate" HeaderText="Rate">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="TAX" SortExpression="TAX" HeaderText="Tax">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="Discount" SortExpression="Discount" HeaderText="Discount">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="Total Amount" SortExpression="Total Amount" HeaderText="Total Amount">
    <HeaderStyle Wrap="False" />
</asp:BoundField>
<asp:BoundField DataField="PK" Visible="False" SortExpression="PK" HeaderText="PK"></asp:BoundField>
</columns>
                    </asp:GridView> <asp:ValidationSummary id="ValidationSummary1" runat="server" ShowSummary="False" ShowMessageBox="True" ValidationGroup="SalesGroupTextField"></asp:ValidationSummary> </DIV></TD></TR><TR><TD vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="HEIGHT: 27px" vAlign=top align=right width="15%"></TD><TD style="HEIGHT: 27px" vAlign=top align=right width="25%"></TD><TD style="VERTICAL-ALIGN: bottom; HEIGHT: 27px" vAlign=top align=right width="25%"><asp:Label id="TotalProduct" runat="server" Text="Total Amount"></asp:Label></TD><TD style="VERTICAL-ALIGN: bottom; HEIGHT: 27px" vAlign=top align=left width="35%"><asp:TextBox id="txtTotalAmount" runat="server" BorderStyle="Solid" BackColor="Info" ValidationGroup="SalesGroupTextField" value="" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD>&nbsp;</TD><TD>&nbsp;</TD><TD vAlign=top align=right><asp:Label id="ReturnMode" runat="server" text="Return Mode"></asp:Label></TD><TD><asp:DropDownList id="ddlReturnMode" runat="server" Width="156px" ValidationGroup="SalesGroupTextField"></asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ValidationGroup="SalesGroupTextField" SetFocusOnError="True" ErrorMessage="Select a payment mode!" ControlToValidate="ddlReturnMode">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="HEIGHT: 24px"></TD><TD style="HEIGHT: 24px"></TD><TD style="HEIGHT: 24px" vAlign=top align=right><asp:Label id="Label3" runat="server" Text="Retrun Amount"></asp:Label></TD><TD style="HEIGHT: 24px"><asp:TextBox accessKey="p" id="txtReturnAmount" runat="server" BorderStyle="Solid" ValidationGroup="SalesGroupTextField" BorderWidth="1px"></asp:TextBox></TD></TR><TR><TD>&nbsp;<asp:Label id="lblRemarks" runat="server" text="Remarks"></asp:Label></TD><TD colSpan=3>&nbsp;<asp:TextBox id="txtRemarks" runat="server" Width="492px" BorderStyle="Solid" ValidationGroup="SalesGroupTextField" value="" BorderWidth="1px" __designer:wfdid="w2"></asp:TextBox></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: 36px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="10%"><asp:Button id="btnNew" runat="server" Width="60px" Text="New" UseSubmitBehavior="False"></asp:Button></TD><TD width="10%"><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Width="60px" ValidationGroup="SalesGroupTextField" Text="Save" UseSubmitBehavior="False"></asp:Button></TD><TD>&nbsp;</TD><TD>&nbsp;</TD></TR></TBODY></TABLE><asp:HiddenField id="hfP_PK" runat="server"></asp:HiddenField> </TD></TR></TBODY></TABLE><asp:HiddenField id="HiddenField1" runat="server"></asp:HiddenField> <asp:HiddenField id="hfMemberPK" runat="server"></asp:HiddenField> <asp:HiddenField id="hfVat" runat="server"></asp:HiddenField> <asp:HiddenField id="hfTax" runat="server"></asp:HiddenField> <asp:HiddenField id="hfInvoiceNo" runat="server" __designer:wfdid="w2"></asp:HiddenField> </TD><TD width="2%"></TD></TR></TBODY></TABLE></TD></TR><TR></TR></TBODY></TABLE></DIV>
</ContentTemplate>
        </asp:UpdatePanel>
 
 <SCRIPT language="javascript" type="text/javascript">

//set value for Return Amount
function CalculateRetrunAmount()
{
   var vTotalAmount=document.getElementById('ctl00_MainContent_txtTotalAmount').value;
   var vRetrunAmount = vTotalAmount
   document.getElementById('ctl00_MainContent_txtReturnAmount').value=vPaidAmount;

}

//Call on PaymentAmount Field
function CalculateRetrunDue()
{
   // alert("fgjf");
   var vPaidAmount=0;
   var vPaymentAmount=0;
   if (document.getElementById('ctl00_MainContent_txtPaidAmount').value != "")
     vPaidAmount=document.getElementById('ctl00_MainContent_txtPaidAmount').value;
   if (document.getElementById('ctl00_MainContent_txtPaymentAmount').value!="")
        vPaymentAmount=document.getElementById('ctl00_MainContent_txtPaymentAmount').value;
    // PaymentAmount Grater then PaidAmount
    if (parseFloat(vPaymentAmount) > parseFloat(vPaidAmount))
        {
            var vReturnAmount= (parseFloat(vPaymentAmount)-parseFloat(vPaidAmount));
            document.getElementById('ctl00_MainContent_txtReturnAmount').value=vReturnAmount;
            document.getElementById('ctl00_MainContent_txtDue').value=0;
        }
    //PaymentAmount less then Paidamount
    else if (parseFloat(vPaymentAmount) < parseFloat(vPaidAmount))
        {
            var vTDueAmount=(parseFloat(vPaidAmount)-parseFloat(vPaymentAmount));
            document.getElementById('ctl00_MainContent_txtDue').value=vTDueAmount;
            document.getElementById('ctl00_MainContent_txtReturnAmount').value=0;
        }

    //  PaymentAmount equels to PaidAmount 
    else if (vPaymentAmount==vPaidAmount)
        {
            document.getElementById('ctl00_MainContent_txtReturnAmount').value=0;
            document.getElementById('ctl00_MainContent_txtDue').value=0;
        }
}


function FocusControl_byEnter()
{
    if(event.keyCode==13)
         {

            if (document.activeElement.id=="ctl00_MainContent_txtInvoiceNo")
            {
                if(document.getElementById('ctl00_MainContent_txtInvoiceNo').focus())
                {
                document.getElementById('tdHide').style['display']='';
                document.getElementById('ctl00_MainContent_txtInvoiceDate').focus();
                }
                else
                {
                document.getElementById('tdHide').style['display']='none';
                document.getElementById('ctl00_MainContent_txtProduct').focus();
                return false;
                }

            }

            else  if(document.activeElement.id=="ctl00_MainContent_ddlReturnMode")
            {
                document.getElementById('ctl00_MainContent_txtReturnAmount').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtReturnAmount")
            {
                document.getElementById('ctl00_MainContent_txtRemarks').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtRemarks")
            {
                document.getElementById('ctl00_MainContent_btnSave').focus();
            }

        }
//   else if(document.activeElement.id=="ctl00_MainContent_txtDiscountTotal"||document.activeElement.id=="ctl00_MainContent_txtPaymentAmount")
//        {
//            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
//            {
//                event.returnValue=false;
//            }
//        }

    else if(document.activeElement.id=="ctl00_MainContent_txtQuantity")
        {
            if (event.keyCode<48||event.keyCode>57)
            {
                event.returnValue=false;
            }
        }
}

    function clickbtn(btnctrl)
	{
		if (event.keyCode==13)
		{
		    document.getElementById(btnctrl).click();						
		    return false;
		}
	}		

</SCRIPT>
 
 
</asp:Content>
