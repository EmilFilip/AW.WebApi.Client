namespace AW.UI.Models
{
    public class Product
    {

        public string AlternateKey { get; set; }
        public int? ProductSubcategoryKey { get; set; }
        public string Name { get; set; }
        public short? StockLevel { get; set; }
        public decimal? Price { get; set; }
    }
}