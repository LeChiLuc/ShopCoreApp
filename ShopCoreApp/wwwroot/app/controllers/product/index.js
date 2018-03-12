var productController = function () {
    this.initialize = function () {
        loadData();
    }

    function registerEvents() {
        //todo: binding events to controls
    }

    function loadData() {
        var template = $('#template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Name: item.Name,
                        Category: item.ProductCategory.Name,
                        Price: app.formatNumber(item.Price,0),
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=55px />' : '<img src="' + item.Image + '" width=55 />',
                        CreatedDate: app.dateTimeFormatJson(item.DateCreated),
                        Status: app.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
                $('#datatable').DataTable();
            },
            error: function (status) {
                console.log(status);
                app.notify('Cannot loading data','error');
            }
        })
    }
}