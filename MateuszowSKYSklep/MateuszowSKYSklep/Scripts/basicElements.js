$(function () {
    $('#show').click(function () {
        var menu = $('#genre');
        var triangle = $('#show');
        if (menu.is(':hidden')) {
            menu.slideDown();
            /*triangle.animate({ borderSpacing: 90 }, {
                step: function (now, fx) {
                    $(this).css('-webkit-transform', 'rotate(' + now + 'deg)');
                    $(this).css('-moz-transform', 'rotate(' + now + 'deg)');
                    $(this).css('transform', 'rotate(' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');*/
        }
        else {
            menu.slideUp();
            /*triangle.animate({ borderSpacing: -90 }, {
                step: function (now, fx) {
                    $(this).css('-webkit-transform', 'rotate(' + now + 'deg)');
                    $(this).css('-moz-transform', 'rotate(' + now + 'deg)');
                    $(this).css('transform', 'rotate(' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');*/
        }
    });

    var selectview = function (id) {

        window.location.href = 'game-'+id+'.html';
    };

    var setupAutoComplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-autocomplete-source"),
            select: function (event, ui) {
                $input = $(this);
                $input.val(ui.item.label);
                var $form = $input.parents("form:first");
                $form.submit(selectview(ui.item.id));
            }
        };

        $input.autocomplete(options);
    };

    $('#search-filter').each(setupAutoComplete);

});



