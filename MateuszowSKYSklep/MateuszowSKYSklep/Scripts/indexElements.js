$(function() {
    var interval;
    var pause = 5000;
    var animationSpeed = 1000;

    var end = true;

    var $preorderArray = document.getElementsByClassName("preorderimage");

    $('#preordercontainer').prepend($('.preorderimage:last'));

    $('#preordercontainer').css('margin-left', -960);

    function startSlider() {
        interval = setInterval(function() {
            end = false;
            $('#preordercontainer').animate({ 'margin-left': '-=960' }, animationSpeed, function() {


                $('#preordercontainer').append($('.preorderimage:first'));
                $('#preordercontainer').css('margin-left', '+=960');
                end = true;
            });
        }, pause);
    }

    function stopSlider() {
        clearInterval(interval);
    }

    $('#preordercontainer').on('mouseenter', stopSlider).on('mouseleave', startSlider);

    $('#slider-left').click(function() {
        $('#preordercontainer').animate({ 'margin-left': '+=960' }, animationSpeed, function() {

            $('#preordercontainer').prepend($('.preorderimage:last'));
            $('#preordercontainer').css('margin-left', '-=960');

        });
    });

    $('#slider-right').click(function() {
        $('#preordercontainer').animate({ 'margin-left': '-=960' }, animationSpeed, function() {

            $('#preordercontainer').append($('.preorderimage:first'));
            $('#preordercontainer').css('margin-left', '+=960');
        });
    });

    startSlider();
});