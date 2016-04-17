$(function () {
    $('#show').click(function () {
        var menu = $('#genre');
        var triangle = $('#show');
        if (!menu.is(':hidden')) {
            menu.slideUp();
            $('#show').css('background-color', '#32353a');
            triangle.animate({ borderSpacing: 90 }, {
                step: function (now, fx) {
                    $('#show img').css('-webkit-transform', 'rotate(' +'-'+ now + 'deg)');
                    $('#show img').css('-moz-transform', 'rotate(' + '-' + now + 'deg)');
                    $('#show img').css('transform', 'rotate(' + '-' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');
        }
        else {
            menu.slideDown();
            $('#show').css('background-color', '#494d55');
            triangle.animate({ borderSpacing: 0 }, {
                step: function (now, fx) {
                    $('#show img').css('-webkit-transform', 'rotate(' + '-' + now + 'deg)');
                    $('#show img').css('-moz-transform', 'rotate(' + '-' + now + 'deg)');
                    $('#show img').css('transform', 'rotate(' + '-' + now + 'deg)');
                },
                duration: 'slow'
            }, 'linear');
        }
    });

    var selectview = function (id) {

        window.location.href = 'game-' + id + '.html';
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

    $('#searchfilter').each(setupAutoComplete);

    $('#searchbutton').click(function () {
        if ($('#searchfilter').is(':hidden')) {
            $('#searchfilter').css('display', 'block');
            $('#search').css('background-color', '#494d55');
        }
        else {
            $('#searchfilter').css('display', 'none');
            $('#search').css('background-color', '#32353a');
        }
        //$('#searchfilter').toggle(function() {});
    });

    $('#user').click(function () {
        if ($('#userbox').is(':hidden')) {
            $('#userbox').css('display', 'block');
            $('#user').css('background-color', '#494d55');
        }
        else {
            $('#userbox').css('display', 'none');
            $('#user').css('background-color', '#32353a');
        }
        //$('#searchfilter').toggle(function() {});
    });
       
    
    //$('#search').toggle(
    //            function () {
    //                $('#search').css('background-color', '#494d55');
    //            },
    //        function () {
    //            $('#search').css('background-color', '#32353a');
    //        });


    //});

});



