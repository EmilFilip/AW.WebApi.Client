using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.UI.Helpers
{
    public static class Constants
    {
        public const string customHeaderKey = "HeaderAuthorization";
        public const string customHeaderValue = "=saASFe982dq19Dskadj";

        public const string baseLink = "http://localhost:57578/api/";
        public const string categoriesLink = "ProductCategory/GetproductCategories";
        public const string subcategoriesLink = "ProductCategory/GetProductSubcategoriesByProductCategoryId/";
        public const string subcategoryProductsLink = "ProductSubcategory/GetProductsByProductSubCategory/";
        public const string createProductLink = "Product/CreateProduct/";
    }
}