$('[data-attr="update"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Update",
            type: "POST",
            data: $('#updateMovieForm').serialize(),
            success: function (response) {
                $('#PartialResultView').html(response)
                window.location.href = '/'
            },
            Error: function (err) {

            }
        });
});