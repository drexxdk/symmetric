$(function () {
    var header_nav = $("header nav"),
        ul_select = header_nav.find("ul.select"),
        li_dropdown = header_nav.find("li.dropdown"),
        nav_button = header_nav.children("span"),
        back_to_top = $('#back-to-top');

    $(document).bind("click touchstart", function (event) {
        // seperate bind to ensure safari works correctly on touch devices

        var target = $(event.target);
        // mobile menu button
        if (target.closest(nav_button).length == 1) {
            nav_button.toggleClass("open");
        } else if (target.closest(nav_button).length === 0 && target.closest(nav_button.siblings("ul")).length === 0) {
            nav_button.removeClass("open");
        }
    });

    $(document).bind("click", function (event) {
        var target = $(event.target);

        // dropdown
        var dropdown_button = target.closest(li_dropdown.children("span").children("span"));
        if (dropdown_button.length) {
            dropdown_button = dropdown_button.parent();
            li_dropdown.children("span.open").not(dropdown_button).removeClass("open");
            dropdown_button.toggleClass("open");
        } else {
            li_dropdown.children("span.open").removeClass("open");
        }

        // select
        if (target.closest(ul_select).length === 0) {
            ul_select.find(".open").removeClass("open");
        }
    });

    function scroll_to_top() {
        var scrollTop = $(window).scrollTop();
        if (scrollTop > 100) {
            back_to_top.addClass('show');
        } else {
            back_to_top.removeClass('show');
        }
    };

    scroll_to_top();
    $(window).on('scroll', function () {
        scroll_to_top();
    });

    back_to_top.on('click', function () {
        $('html,body').animate({
            scrollTop: 0
        }, 700);
    });

    ul_select.on("click", "li:first-child", function () {
        $(this).toggleClass("open");
    });

    ul_select.on("click", "li:not(:first-child)", function () {
        var $this = $(this);
        $this.siblings(".open").removeClass("open");
        $this.prependTo($this.parent());
    });
});