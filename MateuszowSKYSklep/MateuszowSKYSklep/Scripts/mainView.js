$(function () {
    $('#show').click(function () {
        var menu = $('#genre');
        var triangle = $('#show');
        if (menu.is(':hidden'))
        {
            menu.slideDown();
            triangle.animate({ borderSpacing: 90 }, {
                step: function (now, fx) {
                    $(this).css('-webkit-transform', 'rotate(' + now + 'deg)');
                    $(this).css('-moz-transform', 'rotate(' + now + 'deg)');
                    $(this).css('transform', 'rotate(' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');
        }
        else
        {
            menu.slideUp();
            triangle.animate({ borderSpacing: -90 }, {
                step: function (now, fx) {
                    $(this).css('-webkit-transform', 'rotate(' + now + 'deg)');
                    $(this).css('-moz-transform', 'rotate(' + now + 'deg)');
                    $(this).css('transform', 'rotate(' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');
        }
    });
});



