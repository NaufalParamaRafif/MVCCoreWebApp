// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//var $table = $('#tblMaster');
//var $button = $('#btnDelete');

//$(function () {
//    $button.click(function () {
//        var ids = $.map($table.bootstrapTable('getSelections'), function (row) {
//            return row.id
//        })
//        $table.bootstrapTable('remove', {
//            field: 'id',
//            values: ids
//        })
//    })
//})

function deleteSelectedRow() {
    var ids = $.map($('#tblMaster').bootstrapTable('getSelections'), function (row) {
        return row.id
    })
    $('#tblMaster').bootstrapTable('remove', {
        field: 'id',
        values: ids
    })
}

function validate() {
    var enabled = document.getElementById('isEnabled')
    if (enabled.checked == 1) {
        return 1;
    } else {
        return 0;
    }
};

function resetTeks() {
    $('#txtUsername').val('');
    $('#txtPassword').val('');
    $('#isEnabled').prop('checked', false);
}

function add() {
    $('#btnClear').unbind().bind('click', function () {
        resetTeks();
    });
}

function submit() {
    $('#btnSubmit').unbind().bind('click', function () {
        $.ajax({
            url: '/User/Create',
            type: 'POST',
            dataType: 'JSON',
            data: {
                username: $('#txtUsername').val(),
                password: $('#txtPassword').val(),
                is_enabled: 0,
            },
            success: function (res) {
                console.log(res);
                if (res.status_code === 100) {
                    //alert(res.message);
                    Swal.fire(
                        'Good job!',
                        res.message,
                        'error'
                    )
                } else {
                    var randomId = 100 + ~~(Math.random() * 100)
                    var opalll = validate();
                    
                    $('#tblMaster').bootstrapTable('insertRow', {
                        index: 0,
                        row: {
                            id: randomId,
                            username: $('#txtUsername').val(),
                            password: $('#txtPassword').val(),
                            is_enabled: opalll
                        }
                    })
                }
            },
            error: function (e) {
                console.log(e);
            }
        })
    });
}

$(document).ready(function () {
    resetTeks();
    add();
    submit();
});