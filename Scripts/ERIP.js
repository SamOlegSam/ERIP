function forfilter() {

    var isValid = true;

    if ($('#dataS').val() == "") {
        $('#dataS').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#dataS').css('border-color', 'lightgrey');
    }

    if ($('#dataPo').val() == "") {
        $('#dataPo').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#dataPo').css('border-color', 'lightgrey');
    }
        
    if (isValid == false) {
        return false;
    }

    var data = {
        'dataS': $('#dataS').val(),
        'dataPo': $('#dataPo').val(),
        'usluga': $('#usluga').val(),

    };

    $.ajax({
        url: "/Home/forfilter",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
        success: function (result) {
            $('#filter').html(result);
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

}
//------------------------------------------------------------------------

//----------ОТЧЕТЫ---------//
function ReportEXCEL() {
    window.location = "/Home/Export/";
    //var stringhref = "Export?";
        
}
function Export() {
    var stringhref = "/Home/Export?";

    stringhref += "dataS=" + $('#dataS').val() + "&" + "dataPo=" + $('#dataPo').val() + "&" + "usluga=" + $('#usluga').val();
    //window.open(stringhref, '_blank');
    window.location = stringhref;
    //window.location = "/Home/Export/";
}