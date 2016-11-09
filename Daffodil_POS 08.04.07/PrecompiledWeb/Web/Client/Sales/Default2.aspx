<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Client_Sales_Default2, App_Web_jxa7k8pl" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
&nbsp;<asp:TextBox id="TextBox3" runat="server" __designer:wfdid="w1"></asp:TextBox> <asp:TextBox id="TextBox1" runat="server" __designer:wfdid="w1"></asp:TextBox> <asp:TextBox id="TextBox2" runat="server" __designer:wfdid="w2"></asp:TextBox> <INPUT id="Button3" onclick="return Button3_onclick()" type=button value="button" />&nbsp; <asp:Button id="Button1" onclick="Button1_Click" runat="server" UseSubmitBehavior="False" Text="Button"></asp:Button> <asp:Button id="Button2" onclick="Button2_Click" runat="server" UseSubmitBehavior="False" Text="Button"></asp:Button> <BR /><BR /><BR /><asp:Button id="Button4" runat="server" __designer:wfdid="w1" Text="Button" OnClick="Button4_Click"></asp:Button>
</ContentTemplate>
        </asp:UpdatePanel>
        <script language="C#" runat="server">
        
        </script>
        
    <script language="javascript">
    
   /*Sys.WebForms.PageRequestManager.getInstance().add_endRequest( endRequest );
   function endRequest( sender, e ) {
        if( e.get_error() ){
               focusit();
               e.set_errorHandled( true );
        }
   }
function focusit()
    {
    document.getElementById('ctl00_MainContent_TextBox2').focus();
    return false;
    }        */
    //document.getElementById('Button3').click();
    </script>
        
    <script language="javascript">
		function clickbtn(btnctrl)
		{		
		//alert();
		    //var ab=btnctrl.toString();
			if (event.keyCode==13)
			{
			document.getElementById(btnctrl).click();			
			//nero.eProceed.click();
			return false;
			}
		}			


		</script>    
</asp:Content>

