using System.Collections.Generic;

namespace AW.UI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public IEnumerable<ProductSubcategory> ProductSubcategories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}