jQuery($ => {
    let $td = $('td').on('click', function () {
        $td.removeClass('greyout').not(this).addClass('greyout');
    })
});