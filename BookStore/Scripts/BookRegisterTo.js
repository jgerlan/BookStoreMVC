$(function () {
    $('#IdRegisterFormer').on('submit', function (e) {
        e.preventDefault();

        $.ajax({
            type: 'post',
            url: 'BookStore/BookRegister',
            data: $('#IdRegisterFormer').serialize(),
            sucess: function () {
                alert('form was submitted');    
            }
        });
    })
});