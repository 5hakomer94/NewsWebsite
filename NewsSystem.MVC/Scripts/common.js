/// <reference path="jquery-1.12.4.intellisense.js" />
(function () {
    $(document).ready(function () {
        $('#menu-wrapper').load('/PagePartials/menu.html');
        $('#footer-Wrapper').load('/PagePartials/footer.html');
        $('select').select2({
            dir: 'rtl'
        });

    });
})();