var MAIN = {
    register: function () {
        MAIN.UI.register();
        MAIN.EVENTS.register();
    },
    UI: {
        register: function () {

        }
    },
    ROUTINES: {

    },
    EVENTS: {
        register: function () {
            MAIN.EVENTS.btnCreate();
        },
        btnCreate: function () {
            $('#btnCreate').unbind().bind('click', function () {
                var kode_barang = $('#kode_barang').val();
                var nama_barang = $('#nama_barang').val();
                var stock_barang = $('#stock_barang').val();
                var harga_barang = $('#harga_barang').val();
                //var stock_on_hand = 0;

                $.ajax({
                    url: '/MasterBarang/Create',
                    dataType: 'JSON',
                    type: 'POST',
                    data: {
                        kode_barang: kode_barang,
                        nama_barang: nama_barang,
                        harga_barang: harga_barang,
                    },
                    success: function (r) {
                        if (r.status_code === 200) {
                            alert(r.message);
                        } else {
                            alert(r.message);
                        }
                    },
                    error: function (e) {
                        console.log(e);
                    }
                })
            });
        }
    }
}
$(document).ready(function () {
    MAIN.register.apply();
});