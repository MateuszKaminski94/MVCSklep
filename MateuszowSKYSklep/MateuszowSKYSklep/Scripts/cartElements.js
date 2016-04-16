$(function() {

    $(".removeProduct").click(function () {

        var recordToDelete = $(this).attr("data-id");

        if (recordToDelete != '') {

            // Send post request with AJAX
            $.post("/Cart/RemoveFromCart", { "gameid": recordToDelete },
                function (response) {
                    // Success
                    if (response.RemovedItemCount == 0) {

                        $('#cart-row-' + response.RemoveItemId).fadeOut('slow', function () {
                            if (response.CartItemsCount == 0) {
                                $("#cart-empty-message").removeClass("hidden");
                            }
                        });
                    } else {
                        $('#cart-item-count-' + response.RemoveItemId).text(response.RemovedItemCount);
                    }

                    if (response.CartItemsCount == 0) {
                        $('#cart-button-checkout').addClass('hidden');
                        $('#total-price').addClass('invisible');
                    }

                    $('#total-price-value').text(response.CartTotal);
                    $('#cart-header-items-count').text(response.CartItemsCount);

                });

            return false;
        }
    });


});