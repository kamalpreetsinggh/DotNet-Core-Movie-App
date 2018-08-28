$('[data-attr="delete"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Delete",
            type: "POST",
            data: $('#deleteMovieForm').serialize(),
            success: function (response) {
                $('#PartialResultView').html(response)
                window.location.href = '/'
            },
            Error: function (err) {

            }
        });
});