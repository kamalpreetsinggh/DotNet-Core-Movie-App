$('[data-attr="add"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/Insert",
            type: "POST",
            data: $('#addMovie').serialize(),
            success: function (response) {
                $('#insertForm').hide()
                $('#PartialResultView').html(response)
            },
            Error: function (err) {
            }
        });
});