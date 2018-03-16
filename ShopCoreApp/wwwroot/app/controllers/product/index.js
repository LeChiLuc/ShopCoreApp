var productController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            app.configs.pageSize = $(this).val();
            app.configs.pageIndex = 1;
            loadData(true);
        });
    }

    function loadData(isPageChanged) {
        var template = $('#template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data:{
                categoryId: null,
                keyword: $('#txtKeyword').val(),
                page: app.configs.pageIndex,
                pageSize: app.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (response) {
                console.log(response.Results);
                $.each(response.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Name: item.Name,
                        Category: item.ProductCategory.Name,
                        Price: app.formatNumber(item.Price,0),
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=55px />' : '<img src="' + item.Image + '" width=55 />',
                        CreatedDate: app.dateTimeFormatJson(item.DateCreated),
                        Status: app.getStatus(item.Status)
                    });
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                    
                });
            },
            error: function (status) {
                console.log(status);
                app.notify('Cannot loading data','error');
            }
        });
    }
    
    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / app.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                app.configs.pageIndex = p;
                setTimeout(callBack(), 100);
            }
        });
    }
}