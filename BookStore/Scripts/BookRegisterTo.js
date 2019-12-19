$(document).ready(function () {
    $('#IdRegisterFormer').submit(function (event) {
        event.preventDefault();
        //var post_url = $(this).attr("action");
        var request_method = $(this).attr("method");
        var form_data = $(this).serializeArray();

        $.ajax({
            url: 'ShowSubmit',//post_url,
            type: request_method,
            dataType: 'json',
            method: request_method,
            data: form_data
        }).done(function (response) { //
            console.log('Submitted');
        });

   });


});