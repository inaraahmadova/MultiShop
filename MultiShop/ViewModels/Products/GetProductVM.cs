namespace MultiShop.ViewModels.Products
{
    public class GetProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int StockCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
