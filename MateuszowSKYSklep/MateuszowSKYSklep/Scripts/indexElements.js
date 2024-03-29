﻿$(function() {
    var interval;
    var pause = 5000;
    var animationSpeed = 1500;

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
    $('#preorderleft').on('mouseenter', stopSlider).on('mouseleave', startSlider);
    $('#preorderright').on('mouseenter', stopSlider).on('mouseleave', startSlider);

    $('#preorderleft').click(function () {
        $('#preordercontainer').animate({ 'margin-left': '+=960' }, animationSpeed, function() {

            $('#preordercontainer').prepend($('.preorderimage:last'));
            $('#preordercontainer').css('margin-left', '-=960');

        });
    });

    $('#preorderright').click(function () {
        $('#preordercontainer').animate({ 'margin-left': '-=960' }, animationSpeed, function() {

            $('#preordercontainer').append($('.preorderimage:first'));
            $('#preordercontainer').css('margin-left', '+=960');
        });
    });

    startSlider();
});