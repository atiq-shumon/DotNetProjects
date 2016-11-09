<%@ page language="C#" theme="DPOSThemes" stylesheettheme="DPOSThemes" autoeventwireup="true" inherits="SalesInfo, App_Web_jxa7k8pl" masterpagefile="~/MasterPage.master" title=" Sales Information Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">

    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<DIV id="masterDiv" class="DPOSStyleSheet"><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="WIDTH: 754px" vAlign=top align=left></TD></TR><TR><TD style="WIDTH: 754px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="5%"></TD><TD><TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 17px" vAlign=top align=left><asp:Label id="lblErrorMessage" runat="server" CssClass="errormsg">
</asp:Label> <asp:Label id="lblSuccessMessage" runat="server" CssClass="successmsg">
</asp:Label></TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 17%"><asp:Label id="InvoiceNo" runat="server" text="Invoice No">
</asp:Label> </TD><TD style="WIDTH: 222px"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtInvoiceNo" runat="server" Width="180px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="InvoiceNoGroup">
</asp:TextBox><asp:Button id="btnInvoiceNo" runat="server" Font-Bold="True" Text="..." Width="30px" ValidationGroup="InvoiceNoGroup" Height="22px" UseSubmitBehavior="False">
</asp:Button></TD><TD style="WIDTH: 13%">&nbsp;<asp:Label id="Date" runat="server" text="Date" Visible="False"></asp:Label></TD><TD style="VERTICAL-ALIGN: top"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtDate" runat="server" Width="184px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" Visible="False"></asp:TextBox> <!-- <img id="imgSalesDate" alt="Pick Date" src="../../Images/calendar.gif" style="width: 42px; height: 20px" hidefocus="hideFocus" />--></TD></TR></TBODY></TABLE></TD></TR><TR><TD vAlign=top align=left><asp:Panel id="pnlMemberId" runat="server" Width="100%" DefaultButton="btnClickMemberID"><TABLE width="100%"><TBODY><TR><TD style="WIDTH: 17%"><asp:Label id="CustomerId" runat="server" text="Member ID">
                        </asp:Label></TD><TD style="WIDTH: 222px"><asp:TextBox style="VERTICAL-ALIGN: top" id="txtCustomerId" runat="server" Width="180px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="MemberGroupValidation">
                        </asp:TextBox><asp:Button id="btnCustomerId" runat="server" Font-Bold="True" Text="..." Width="30px" ValidationGroup="MemberGroupValidation" Height="22px" UseSubmitBehavior="False">
                        </asp:Button></TD><TD style="WIDTH: 11%"><asp:Button id="btnClickMemberID" onclick="btnClickMemberID_Click" runat="server" Text="." Width="1px" Height="1px" UseSubmitBehavior="False">
                        </asp:Button></TD><TD>&nbsp;</TD></TR></TBODY></TABLE></asp:Panel></TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><asp:Panel id="pnlMember" runat="server" Width="597px" Height="80px" Visible="False">
                    <table id="tblMem" style="WIDTH: 117%">
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="CustomerName"  text="Member Name" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtCustomerName" runat="server" Width="503px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="Address"  text="Address" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtAddress" runat="server" Width="503px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox></td>
                    </tr>
                    <tr> 
                      <td style="width: 116px"><asp:Label ID="DepositBalance"  text="Deposit Balance" runat="server"></asp:Label></td>
                      <td colspan="3"><asp:TextBox ID="txtDepositBalance" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px" BackColor="Info" ReadOnly="True" ValidationGroup="MemberGroupValidation"></asp:TextBox> 
                      </td>
                    </tr>
                    </table>
                    
                </asp:Panel></TD></TR><TR><TD vAlign=top align=left><asp:Panel id="pnlProcuct" runat="server" Width="100%" DefaultButton="btnClickProductCode"><TABLE width="100%"><TBODY><TR></TR><TR><TD style="WIDTH: 116px"><asp:Label id="Product" runat="server" text="Product Code">
                </asp:Label></TD><TD style="VERTICAL-ALIGN: top" colSpan=3><asp:TextBox style="VERTICAL-ALIGN: top" id="txtProduct" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox><asp:Button id="btnProducId" runat="server" Font-Bold="True" Text="..." Width="30px" Height="22px" UseSubmitBehavior="False"></asp:Button></TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="ProductName" runat="server" text="Product Name"></asp:Label></TD><TD colSpan=3><asp:TextBox id="txtProductName" runat="server" Width="505px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="ProductGroupValidation"></asp:TextBox> </TD></TR><TR><TD style="WIDTH: 116px"><asp:Label id="Rate" runat="server" text="Rate"></asp:Label></TD><TD style="WIDTH: 220px"><asp:TextBox id="txtRate" runat="server" Width="180px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="ProductGroupValidation"></asp:TextBox></TD><TD style="WIDTH: 94px"><asp:Label style="VERTICAL-ALIGN: top" id="Discount" runat="server" Text="Discount"></asp:Label></TD><TD><asp:TextBox style="VERTICAL-ALIGN: top" id="txtDiscount" runat="server" Width="183px" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="ProductGroupValidation"></asp:TextBox></TD></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 116px"><asp:Label id="Label2" runat="server" Text="Quantity"></asp:Label></TD><TD style="WIDTH: 220px"><asp:TextBox accessKey="q" style="VERTICAL-ALIGN: top" id="txtQuantity" runat="server" Width="180px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator3" runat="server" Font-Bold="True" ValidationGroup="ProductGroupValidation" ControlToValidate="txtQuantity" Display="Dynamic" ErrorMessage="Enter a valid number." SetFocusOnError="True" ToolTip="Enter a valid number." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD><TD style="VERTICAL-ALIGN: top; WIDTH: 94px">&nbsp; <asp:Button style="VERTICAL-ALIGN: top" id="btnAdd" onclick="btnAdd_Click" runat="server" Text="Add" Width="60px" UseSubmitBehavior="False"></asp:Button> <asp:Button id="btnClickProductCode" onclick="btnClickProductCode_Click" runat="server" Text="." Width="1px" Height="1px" UseSubmitBehavior="False"></asp:Button></TD><TD style="VERTICAL-ALIGN: top"></TD></TR><TR><TD style="VERTICAL-ALIGN: top; WIDTH: 116px; HEIGHT: 21px"></TD><TD style="WIDTH: 220px; HEIGHT: 21px">&nbsp;&nbsp;</TD><TD style="VERTICAL-ALIGN: top; WIDTH: 94px; HEIGHT: 21px">&nbsp;&nbsp; </TD><TD style="HEIGHT: 21px"></TD></TR></TBODY></TABLE></asp:Panel> </TD></TR><TR><TD style="HEIGHT: auto" vAlign=top align=left><DIV style="OVERFLOW: auto; WIDTH: 677px; HEIGHT: 120px"><asp:GridView id="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowEdting" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="PK" OnRowEditing="GridView1_RowEditing" EmptyDataText="There are no data!">
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
                    </asp:GridView> <asp:ValidationSummary id="ValidationSummary1" runat="server" ValidationGroup="SalesGroupTextField" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary> </DIV></TD></TR><TR><TD vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD style="HEIGHT: 27px" vAlign=top align=right width="15%"></TD><TD style="HEIGHT: 27px" vAlign=top align=right width="25%"></TD><TD style="VERTICAL-ALIGN: bottom; HEIGHT: 27px" vAlign=top align=right width="25%"><asp:Label id="TotalProduct" runat="server" Text="Total Amount"></asp:Label></TD><TD style="VERTICAL-ALIGN: bottom; HEIGHT: 27px" vAlign=top align=left width="35%"><asp:TextBox id="txtTotalAmount" runat="server" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="SalesGroupTextField" value=""></asp:TextBox></TD></TR><TR><TD>&nbsp;</TD><TD></TD><TD vAlign=top align=right><asp:Label id="Label1" runat="server" text="Discount"></asp:Label></TD><TD><asp:TextBox accessKey="d" id="txtDiscountTotal" runat="server" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField" value=""></asp:TextBox> <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" Font-Bold="True" ValidationGroup="SalesGroupTextField" ControlToValidate="txtDiscountTotal" Display="Dynamic" ErrorMessage="You must enter a valid price." SetFocusOnError="True" ToolTip="You must enter a valid price." ValidationExpression="\d+[.]?[\d]{0,4}">*</asp:RegularExpressionValidator></TD></TR><TR><TD>&nbsp;</TD><TD>&nbsp;</TD><TD vAlign=top align=right><asp:Label id="PaymentMode" runat="server" text="Payment Mode"></asp:Label></TD><TD><asp:DropDownList id="ddlPaymentMode" runat="server" Width="156px" ValidationGroup="SalesGroupTextField"> 
                        </asp:DropDownList> <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ValidationGroup="SalesGroupTextField" ControlToValidate="ddlPaymentMode" ErrorMessage="Select a payment mode!" SetFocusOnError="True">*</asp:RequiredFieldValidator></TD></TR><TR><TD style="HEIGHT: 24px"></TD><TD style="HEIGHT: 24px"></TD><TD style="HEIGHT: 24px" vAlign=top align=right><asp:Label id="Label3" runat="server" Text="Payment Amount"></asp:Label></TD><TD style="HEIGHT: 24px"><asp:TextBox accessKey="p" id="txtPaymentAmount" runat="server" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></TD></TR><TR><TD></TD><TD></TD><TD vAlign=top align=right><asp:Label id="PaidAmount" runat="server" text="Paid Amount" value=""></asp:Label></TD><TD><asp:TextBox id="txtPaidAmount" runat="server" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></TD></TR><TR><TD></TD><TD></TD><TD vAlign=top align=right><asp:Label id="Label4" runat="server" Text="Return Amount"></asp:Label></TD><TD><asp:TextBox id="txtReturnAmount" runat="server" BorderStyle="Solid" BackColor="Info" BorderWidth="1px" ValidationGroup="SalesGroupTextField"></asp:TextBox></TD></TR><TR><TD>&nbsp;</TD><TD>&nbsp;</TD><TD vAlign=top align=right><asp:Label id="Due" runat="server" text="Due Amount"></asp:Label></TD><TD><asp:TextBox id="txtDue" runat="server" BorderStyle="Solid" BorderWidth="1px" ValidationGroup="SalesGroupTextField" value="">
                      </asp:TextBox></TD></TR></TBODY></TABLE></TD></TR><TR><TD style="HEIGHT: 36px" vAlign=top align=left><TABLE width="100%"><TBODY><TR><TD width="10%"><asp:Button id="btnNew" runat="server" Text="New" Width="60px" UseSubmitBehavior="False"></asp:Button></TD><TD width="10%"><asp:Button id="btnSave" onclick="btnSave_Click" runat="server" Text="Save" Width="60px" ValidationGroup="SalesGroupTextField" UseSubmitBehavior="False"></asp:Button></TD><TD>&nbsp;</TD><TD>&nbsp;</TD></TR></TBODY></TABLE><asp:HiddenField id="hfP_PK" runat="server"></asp:HiddenField> </TD></TR></TBODY></TABLE><asp:HiddenField id="HiddenField1" runat="server"></asp:HiddenField> <asp:HiddenField id="hfMemberPK" runat="server"></asp:HiddenField> <asp:HiddenField id="hfVat" runat="server"></asp:HiddenField> <asp:HiddenField id="hfTax" runat="server"></asp:HiddenField> </TD><TD width="2%"></TD></TR></TBODY></TABLE></TD></TR><TR></TR></TBODY></TABLE></DIV>
</ContentTemplate>
        </asp:UpdatePanel>
 
 <SCRIPT language="javascript" type="text/javascript">

//set value for Paid Amount
function CalculatePaidAmount()
{
   var vTotalAmount=document.getElementById('ctl00_MainContent_txtTotalAmount').value;
   var vDiscountTotal=document.getElementById('ctl00_MainContent_txtDiscountTotal').value;
   var vPaidAmount=vTotalAmount-vDiscountTotal;
   document.getElementById('ctl00_MainContent_txtPaidAmount').value=vPaidAmount;
   var vDue= vPaidAmount;
   document.getElementById('ctl00_MainContent_txtDue').value=vDue;
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

           
            if (document.activeElement.id=="ctl00_MainContent_txtDiscountTotal")
            {
                document.getElementById('ctl00_MainContent_ddlPaymentMode').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_ddlPaymentMode")
            {
                document.getElementById('ctl00_MainContent_txtPaymentAmount').focus();
            }
            else if(document.activeElement.id=="ctl00_MainContent_txtPaymentAmount")
            {
                document.getElementById('ctl00_MainContent_btnSave').focus();
            }

        }
   else if(document.activeElement.id=="ctl00_MainContent_txtDiscountTotal"||document.activeElement.id=="ctl00_MainContent_txtPaymentAmount")
        {
            if (event.keyCode<46||event.keyCode==47||event.keyCode>57)
            {
                event.returnValue=false;
            }
        }

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

//function test()
//{
//if((event.keyCode==13) && (document.getElementById('ctl00_MainContent_txtProduct').focus()))
//document.getElementById('ctl00_MainContent_txtQuantity').focus();
//}

</SCRIPT>
 
 
</asp:Content>
