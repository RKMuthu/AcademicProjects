$(document).ready(hi);
	function hi()
	{
	$.ajax({
                type: "GET",
                url: "http://localhost/api/diseases",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: jsonresult
            });
    $('#categories').click(catclick);
	
	}
	
	function catclick()
	{
	$(this).css("height","auto");
	}
	
	function jsonresult(data)
	{
		alert(data.result[1].Toxin_Cname);
	}