(function ($) {

    $.fn.enableCellNavigation = function () {

        var keys = {
            left: 37,
            up: 38,
            right: 39,
            down: 40,
            enter: 13
        };

        // select all on focus
        // works for input elements, and will put focus into
        // adjacent input or textarea. once in a textarea,
        // however, it will not attempt to break out because
        // that just seems too messy imho.
        this.find('input').keydown(function (e) {

            // shortcut for key other than arrow keys
            if ($.inArray(e.which, [keys.left, keys.up, keys.right, keys.down, keys.enter]) < 0) {
                return;
            }

            var input = e.target;
            var td = $(e.target).closest('td');
            var moveTo = null;
            console.log(e);
            switch (e.which) {

                case keys.left:
                    {
                        if (input.selectionStart == 0) {
                            moveTo = td.prev('td:has(input,textarea)');
                        }
                        break;
                    }
                case keys.right:
                    {
                        if (input.selectionEnd == input.value.length) {
                            moveTo = td.next('td:has(input,textarea)');
                        }
                        break;
                    }

                case keys.up:
                case keys.enter:
                case keys.down:
                    {

                        var tr = td.closest('tr');
                        var pos = td[0].cellIndex;

                        var moveToRow = null;
                        if (e.which == keys.down || e.which == keys.enter) {
                            moveToRow = tr.next('tr');
                        } else if (e.which == keys.up) {
                            moveToRow = tr.prev('tr');
                        }

                        if (moveToRow.length) {
                            moveTo = $(moveToRow[0].cells[pos]);
                        }

                        break;
                    }

            }

            if (moveTo && moveTo.length) {

                e.preventDefault();

                moveTo.find('input,textarea').each(function (i, input) {
                    input.focus();
                    input.select();
                });

            }

        });

    };

})(jQuery);


// use the plugin
$(function () {
    $('#depenses').enableCellNavigation();
});