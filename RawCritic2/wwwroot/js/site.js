// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.expand').each(function () {
    var reducedHeight = $(this).height();
    $(this).css('height', 'auto');
    var fullHeight = $(this).height();
    $(this).height(reducedHeight);

    $(this).data('reducedHeight', reducedHeight);
    $(this).data('fullHeight', fullHeight);
}).click(function () {
    $(this).animate({ height: $(this).height() == $(this).data('reducedHeight') ? $(this).data('fullHeight') : $(this).data('reducedHeight') }, 500);
});