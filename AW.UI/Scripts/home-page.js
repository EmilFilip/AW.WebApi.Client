$(function () {
    var homePage = new HomePage();
    homePage.initialise();
});

function HomePage() {
    this.initialise = function () {
        $('#categorySelectBox').on('change', this.getSubcategories)
        $('#subcategorySelectBox').on('change', this.getProducts)
    };

    this.getSubcategories = function () {
        var categoryId = $('#categorySelectBox').val();
        $.ajax({
            url: 'Home/GetSubcategories',
            cache: false,
            dataType: 'json',
            type: 'GET',
            data: { categoryId: categoryId },
            success: function (data) {
                $("#productsGrid").find("tr:gt(0)").remove();
                $("#subcategorySelectBox option").remove(); // Remove all <option> child tags.
                $("#subcategorySelectBox").append('<option value="" disabled selected>Select Subcategory</option>');
                $.each(data, function (index, item) { // Iterates through a collection
                    $("#subcategorySelectBox").append( // Append an object to the inside of the select box
                        $("<option></option>") // Yes you can do this.
                            .text(item.Name)
                            .val(item.Key)
                    );
                });
            },
        });
    };

    this.getProducts = function () {
        var subcategoryId = $('#subcategorySelectBox').val();
        $.ajax({
            url: 'Home/GetProducts',
            cache: false,
            dataType: 'json',
            type: 'GET',
            data: { subcategoryId: subcategoryId },
            success: function (data) {
                $("#productsGrid").find("tr:gt(0)").remove();
                $.each(data, function (index, item) { // Iterates through a collection
                    $("#productsGrid").append(
                        "<tr><td>" + item.Id + "</td>" +
                        "<td>" + item.AlternateKey + "</td>" +
                        "<td>" + item.Name + "</td>" +
                        "<td>" + item.Price + "</td>" +
                        "<td>" + item.StockLevel + "</td>" +
                        "<td>" + '<a href="#">Update, </a><a href="#">Delete</a>' + "</td></tr>"
                    );
                });
            },
        });
    };
} 