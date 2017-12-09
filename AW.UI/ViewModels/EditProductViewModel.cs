using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AW.UI.ViewModels
{
    public class EditProductViewModel
    {

        [Required]
        public string Key { get; set; }

        [Required]
        [DisplayName("Product Subcategory Id")]
        public int ProductSubcategoryId { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Stock Level")]
        public short StockLevel { get; set; }

        [Required]
        [DisplayName("Product Price")]
        public decimal Price { get; set; }
    }
}