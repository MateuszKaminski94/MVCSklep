$(function () {

    var animationSpeed = 1000;

    var $miniaturer = $('#detailtopminiaturer');
    var $miniatureContainer = $miniaturer.find('#detailtopminiatures');

    var $imgArray = document.getElementsByClassName("detailtopminiature");

    var $tmpLength = $imgArray.length;

    for (var i = 0; i < 3;i++)
    {
        $miniatureContainer.prepend($('.detailtopminiature:last'));
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

    if ($('.detailtopbackgrounde').length) {

        console.log("generujemy");
        $('.detailtopbackgrounde img')[0].src = $('.detailtopminiature img')[2].src;
        $('.detailtopbackgrounde img')[1].src = $('.detailtopminiature img')[3].src;
        $('.detailtopbackgrounde img')[2].src = $('.detailtopminiature img')[4].src;
    }

    $('#detailrightminiaturebtn').click(function() {

        $('#detailtopbackgroundes').animate({ 'margin-left': '-=960' }, animationSpeed, function () {

            $('.detailtopbackgrounde img')[0].src = $('.detailtopminiature img')[3].src;
            $('.detailtopbackgrounde img')[1].src = $('.detailtopminiature img')[4].src;
            $('.detailtopbackgrounde img')[2].src = $('.detailtopminiature img')[5].src;

            $('#detailtopbackgroundes').css('margin-left', '+=960');

            $miniatureContainer.animate({ 'margin-left': '-=176' }, animationSpeed, function() {

                $miniatureContainer.append($('.detailtopminiature:first'));
                $miniatureContainer.css('margin-left', '+=176');
            });
        });
    });

    $('#detailleftminiaturebtn').click(function() {

        $('#detailtopbackgroundes').animate({ 'margin-left': '+=960' }, animationSpeed, function() {

            $('.detailtopbackgrounde img')[0].src = $('.detailtopminiature img')[1].src;
            $('.detailtopbackgrounde img')[1].src = $('.detailtopminiature img')[2].src;
            $('.detailtopbackgrounde img')[2].src = $('.detailtopminiature img')[3].src;

            //console.log($('.detailtopbackgrounde img')[0].src);

            $('#detailtopbackgroundes').css('margin-left', '-=960');

            $miniatureContainer.animate({ 'margin-left': '+=176' }, animationSpeed, function() {

                $miniatureContainer.prepend($('.detailtopminiature:last'));
                $miniatureContainer.css('margin-left', '-=176');

            });

        });
    });

});