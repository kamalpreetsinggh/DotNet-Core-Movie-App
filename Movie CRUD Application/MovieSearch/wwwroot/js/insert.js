﻿$('[data-attr="add"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Insert",
            type: "POST",
            data: $('#addMovie').serialize(),
            success: function (response) {
                $('#PartialResultView').html(response)
                window.location.href ='/'
            },
            Error: function (err) {

            }
        });
});