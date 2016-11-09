<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DatetimeShow.ascx.cs" Inherits="DatetimeShow" %>
<script language="javascript" type="text/javascript">

// ------------------------------------------------------------------------------------------------  GET DATE FUNCTION-->
function gettheDate() {
Todays = new Date();
TheDate = "" + Todays.getDate() + " / " + (Todays.getMonth()+ 1) +" / "+
Todays.getYear() 
//this.date.value = TheDate;
document.getElementById('ctl00_MainContent_DatetimeShow1_txtDate').value=TheDate;

}

var timerID = null;
var timerRunning = false;

// ------------------------------------------------------------------------------------------------  STOP CLOCK FUNCTION-->
function stopclock (){
        if(timerRunning);
                clearTimeout(timerID);
        timerRunning = false;
    }
// ------------------------------------------------------------------------------------------------  START CLOCK-->
function startclock () {
        stopclock();
        gettheDate()
        showtime();
    }
//  ------------------------------------------------------------------------------------------------  SHOW TIME-->
function showtime () {
        var now = new Date();
        var hours = now.getHours();
        var minutes = now.getMinutes();
        var seconds = now.getSeconds()
        var timeValue = "" + ((hours >12) ? hours -12 :hours)
        timeValue += ((minutes < 10) ? ":0" : ":") + minutes
        timeValue += ((seconds < 10) ? ":0" : ":") + seconds
        timeValue += (hours >= 12) ? " P.M." : " A.M."
        //face.value = timeValue;
        document.getElementById('ctl00_MainContent_DatetimeShow1_txtTime').value=timeValue;
        //document.getElementById('ctl00_MainContent_face').value=timeValue;
        // you could replace the above with this
        // and have a clock on the status bar:
        // window.status = timeValue;
        timerID = setTimeout("showtime()",1000);
        timerRunning = true;
    }

// ------------------------------------------------------------------------------------------------  END OF JAVASCRIPT CODE --->


</script> 

<div style="color: #ffffff; font-weight: bold; background-color: transparent;">
    Date:<asp:TextBox ID="txtDate" runat="server" Width="84px" ForeColor="Red"></asp:TextBox>Time:<asp:TextBox
        ID="txtTime" runat="server" Width="74px" BorderStyle="None" ForeColor="Red"></asp:TextBox></div>
