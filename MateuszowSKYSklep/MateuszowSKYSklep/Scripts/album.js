$(function () {

    var width = 1024;
    var animationSpeed = 1000;
    var pause = 3000;
    var currentSlide = 1;

    var $miniaturer = $('#topminiaturer');
    var $miniatureContainer = $miniaturer.find('#topminiatures');
    var $miniatures = $miniatureContainer.find('.topminiature');

    var interval;

    var end = true;

    /*function startSlider() {
        interval = setInterval(function () {
            end = false;
            $slideContainer.animate({ 'margin-left': '-=' + width }, animationSpeed, function () {

                currentSlide++;
                if (currentSlide === $slides.length - 1) {
                    currentSlide = 1;
                    $slideContainer.css('margin-left', -1024);
                }

                $miniatureContainer.animate({ 'margin-left': '-=146' }, animationSpeed, function () {
                    if (currentSlide === 5)
                        $miniatureContainer.css('margin-left', -145);
                });

                end = true;
            });
        }, pause);
    }

    function stopSlider() {
        clearInterval(interval);
    }*/

    /* $slider.on('mouseenter', stopSlider).on('mouseleave', startSlider);
     $miniaturer.on('mouseenter', stopSlider).on('mouseleave', startSlider);*/


    $('#rightminiaturebtn').click(function() {
        $miniatureContainer.animate({ 'margin-left': '-=176' }, animationSpeed, function() {
            currentSlide++;

            if (currentSlide === 5)
                $miniatureContainer.css('margin-left', -352);
            else if (currentSlide === 11)
                currentSlide = 1;
        });
        console.log(currentSlide);
    });

    $('#leftminiaturebtn').click(function () {
        $miniatureContainer.animate({ 'margin-left': '+=176' }, animationSpeed, function () {
            currentSlide--;

            if (currentSlide === 0) 
                currentSlide = 10;
            else if (currentSlide === 4)
                $miniatureContainer.css('margin-left', -1936);
        });

        console.log(currentSlide);
    });

});