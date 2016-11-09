<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BoothErrorPage.aspx.cs" Inherits="Admin_Setup_Booth_BoothErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="width: 699pt; border-collapse: collapse;
            height: 71px" x:str="">
            <colgroup>
                <col style="width: 226pt; mso-width-source: userset; mso-width-alt: 11008" width="301" />
                <col style="width: 48pt" width="64" />
            </colgroup>
            <tr height="41" style="height: 30.75pt">
                <td class="xl22" style="border-left-color: #e0dfe3; border-bottom-color: #e0dfe3; border-top-color: #e0dfe3; height: 22pt; background-color: transparent;
                    border-right-color: #e0dfe3; width: 88%;">
                    &nbsp;<asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Images/DSL/DSL.JPG"
                        Width="812px" /></td>
                <td style="font-size: 24pt; border-left-color: #e0dfe3; border-bottom-color: #e0dfe3; border-top-color: #e0dfe3; height: 22pt; background-color: transparent;
                    border-right-color: #e0dfe3; text-align: center;" width="20%">
                    &nbsp;</td>
            </tr>
            <tr height="26" style="font-size: 24pt; height: 19.5pt">
                <td class="xl23" style="border-left-color: #e0dfe3; border-bottom-color: #e0dfe3;
                    vertical-align: top; border-top-color: #e0dfe3; background-color: transparent;
                    text-align: center; border-right-color: #e0dfe3; width: 88%; height: 20pt;">
                    <span style="color: #ffffff; background-color: #33ccff"><strong style="vertical-align: middle;
                        text-align: justify">::..Your Booth is not registered or unauthorized. Please call
                        your system administrator..::</strong></span></td>
                <td style="border-left-color: #e0dfe3; border-bottom-color: #e0dfe3; vertical-align: top; border-top-color: #e0dfe3; background-color: transparent; text-align: center;
                    border-right-color: #e0dfe3; height: 20pt;" width="20%">
                    <asp:LinkButton ID="linkCancel" runat="server" PostBackUrl="~/Default.aspx">Cancel</asp:LinkButton></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
