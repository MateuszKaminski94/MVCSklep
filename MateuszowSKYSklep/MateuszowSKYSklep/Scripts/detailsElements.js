$(function () {

    var animationSpeed = 1000;

    var $miniaturer = $('#topminiaturer');
    var $miniatureContainer = $miniaturer.find('#topminiatures');

    var $imgArray = document.getElementsByClassName("topminiature");

    var $tmpLength = $imgArray.length;

    for (var i = 0; i < 3;i++)
    {
        $miniatureContainer.prepend($('.topminiature:last'));
    }
    
    if ($imgArray.length < 7) {
        //console.log($imgArray.length);
        for (var i = 1; i < (8 / ($tmpLength+1)); i++)
        {
            $miniatureContainer.find('li').clone(true).appendTo($miniatureContainer);
        }
        //console.log($imgArray.length);
    }

    $miniatureContainer.css('width', 176 * $imgArray.length);

    $miniatureContainer.css('margin-left', -176);

    if ($('#detailtopbackgroundes').hasClass('detailtopbackgrounde'))
    {
        $('.detailtopbackgrounde img')[0].src = $('.topminiature img')[2].src;
        $('.detailtopbackgrounde img')[1].src = $('.topminiature img')[3].src;
        $('.detailtopbackgrounde img')[2].src = $('.topminiature img')[4].src;
    }

    $('#rightminiaturebtn').click(function() {

        $('#detailtopbackgroundes').animate({ 'margin-left': '-=960' }, animationSpeed, function () {

            $('.detailtopbackgrounde img')[0].src = $('.topminiature img')[3].src;
            $('.detailtopbackgrounde img')[1].src = $('.topminiature img')[4].src;
            $('.detailtopbackgrounde img')[2].src = $('.topminiature img')[5].src;

            $('#detailtopbackgroundes').css('margin-left', '+=960');

            $miniatureContainer.animate({ 'margin-left': '-=176' }, animationSpeed, function() {

                $miniatureContainer.append($('.topminiature:first'));
                $miniatureContainer.css('margin-left', '+=176');
            });
        });
    });

    $('#leftminiaturebtn').click(function() {

        $('#detailtopbackgroundes').animate({ 'margin-left': '+=960' }, animationSpeed, function() {

            $('.detailtopbackgrounde img')[0].src = $('.topminiature img')[1].src;
            $('.detailtopbackgrounde img')[1].src = $('.topminiature img')[2].src;
            $('.detailtopbackgrounde img')[2].src = $('.topminiature img')[3].src;

            //console.log($('.detailtopbackgrounde img')[0].src);

            $('#detailtopbackgroundes').css('margin-left', '-=960');

            $miniatureContainer.animate({ 'margin-left': '+=176' }, animationSpeed, function() {

                $miniatureContainer.prepend($('.topminiature:last'));
                $miniatureContainer.css('margin-left', '-=176');

            });

        });
    });

});