$(".orderstateddl").on('change', function (e) {
    //e.preventDefault();

    var f = $(this.form);
    var tr = f.closest("tr");

    var action = f.attr("action");
    var serializedForm = f.serialize();
    $.post(action, serializedForm).done(function (data) {
        if (data == '@SpodIglyMVC.Models.OrderState.New.ToString()') {
            tr.addClass("newOrder")
        }
        else {
            tr.removeClass("newOrder");
        }
    });
});