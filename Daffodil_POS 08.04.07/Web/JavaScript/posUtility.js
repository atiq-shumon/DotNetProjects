// JScript File

//Formate DateTime

FormatDateField = function formatDateField(params){

		//var value = f.value;
		var value=document.getElementById("params").value;
		if(value.length==2){
		  document.getElementById("params").value=document.getElementById("params").value+"/";
		} else if(value.length==5){
		    document.getElementById("params").value  =document.getElementById("params").value+"/";
		//  f.value=f.value+"/";
		}
	}	