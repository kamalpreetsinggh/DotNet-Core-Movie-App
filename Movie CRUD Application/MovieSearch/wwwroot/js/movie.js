
$('[data-attr="search"]').on('click', function () {
    $.ajax(
        {
            type: "GET",
            url: "/Movie/SearchById",
            data: { 'id': $('#inputSearchID').val() },
            success: function (response) {
                $('#loadOnStartUp').hide();
                $('#loadAfterSearch').html('');
                $('#loadAfterSearch').html(response);
            },
            error: function (err) {
                $('#loadOnStartUp').hide();
                $('#loadAfterSearch').html('');
                $('#loadAfterSearch').html(err.statusText);
            }
        });
});