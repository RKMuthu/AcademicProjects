var i=0;
function addText() {
	var regExp=new RegExp("^[a-z0-9]+=[a-z0-9]+$",'i');
	if(regExp.test($('#inputText').val()))
		{	
	if(i===0)
		{
		i=1;
		$('#txtarea').val($('#inputText').val()+"\n");
		}
	else
		{
		$('#txtarea').val($('#txtarea').val()+$('#inputText').val()+"\n");
		}
		$('#inputText').val('');
		}
	else
		{
		alert("Please enter the proper format of name=val andd accepts only alpha numeric");
		}
	
}

function deleteSelected() {
	 var field = document.getElementById("txtarea");
     var startPos = field.selectionStart;
     var endPos = field.selectionEnd;        
     var field_value = field.value;
     var selectedText = field_value.substring(startPos,endPos);
     var s=field_value.replace(selectedText, '');
     s=s.replace('\n\n', '\n');
     $('#txtarea').val(s);
}

function sortbyValue() {
	var textarea = document.getElementById("txtarea");
	var s = textarea.value.split("\n")
	var outputs=switchValues(s);
	outputs.sort();
	outputs[outputs.length]="\n";
	var output=switchValues(outputs);
	addtoTextArea(output);
}

function addtoTextArea(inputs)
{
	var s='';
	for(var i=0;i<inputs.length;i++)
		{
			s=s+inputs[i]+"\n";
		}
	$('#txtarea').val(s);
}

function switchValues(inputs)
{
	var outputs=[inputs.length-1];
	for(var i=0;i<inputs.length-1;i++)
		{
		var temp=inputs[i].split("=");
		outputs[i]=temp[1]+"="+temp[0];
		}
	return outputs; 
}
function sortbyName()
{
	var textarea = document.getElementById("txtarea");
	textarea.value = textarea.value.split("\n").sort().join("\n");
	var newText = $('textarea').val().replace(/^.*\n/g,"");
	$('textarea').val(newText);
	textarea.value=textarea.value+"\n";
}

function showXML() {
	var textareaValue = document.getElementById("txtarea").value.split("\n");
	var s="<values>";
	for(var i=0;i<textareaValue.length-1;i++)
		{
		s=s+"<value>"+textareaValue[i]+"</value>";
		}
	s=s+"</values>";
	alert(s);
}