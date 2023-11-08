// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
                    $('#tblMaster').bootstrapTable('insertRow', {
                        index: 1,
                        row: {
                            id: randomId,
                            username: $('#txtUsername').val(),
                            password: $('#txtPassword').val(),
                            is_enabled: 1
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
function loadListData() {
    $.ajax({
        url: '/User/GetListData',
        type: 'POST',
        dataType: 'JSON',
        success: function (res) {
            console.log(res);
            if (res.data !== null && res.data.length > 0) {
                for (var i = 0; i < res.data.length; i++) {
                    $('#tblMaster').bootstrapTable('insertRow', {
                        index: res.data[i].id,
                        row: {
                            id: res.data[i].id,
                            username: res.data[i].username,
                            password: res.data[i].password,
                            is_enabled: res.data[i].is_enabled
                        }
                    })
                }
            }
        },
        error: function (e) {
            console.log(e);
        }
    })
}

function deleteRow(id) {
    $('#tblMaster').bootstrapTable('removeByUniqueId', id);
}

function editRow(id) {
    let tableRow = $('#tblMaster').bootstrapTable('getRowByUniqueId', id);
    // ketika kita klik edit kita mau kolomnya terisi atribut-atribut object saat ini
    $('#txtUsername').val(tableRow.username);
    $('#txtPassword').val(tableRow.password);
    if (tableRow.is_enabled == 1) {
        $('#isEnabled').prop('checked', true);
    } else {
        $('#isEnabled').prop('checked', false);
    }
    // ketika semuanya sudah terisi sesuai dengan object saat ini, kita ingin tombolnya berubah menjadi tombol update
    document.getElementById("btnSubmit").style.display = "none";
    document.getElementById("btnUpdate").style.display = "inline-block";
    let tableIndex;
    $('#tblMaster').on('click-row.bs.table', function (e, row, $element) {
        tableIndex = $element.data('index');
    });
    // ketika kita update kita mau objek saat ini terisi dengan apa yang tersedia di kolom yang sudah terisi
    $('#btnUpdate').click(function () {
        $('#tblMaster').bootstrapTable('updateRow', {
            index: tableIndex,
            row: {
                id: row.id,
                username: $('#txtUsername').val(),
                password: $('#txtPassword').val(),
                is_enabled: 1
             }
        })
        document.getElementById("btnSubmit").style.display = "inline-block";
        document.getElementById("btnUpdate").style.display = "none";
        resetTeks();
    })
}


function viewButton(value, row, index) {
    console.log(row);
    var html = '<button onclick="deleteRow(' + row.id + ')" class="delete btn btn-sm btn-danger">Delete</button>';
    html = html + '<button onclick="editRow(' + row.id + ')" class="delete btn btn-sm btn-warning">Edit</button>';
    return html;
}
$(document).ready(function () {
    resetTeks();
    add();
    submit();
    loadListData();
});