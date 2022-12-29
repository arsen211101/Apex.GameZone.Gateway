namespace Apex.GameZone.API.ViewModels.Product
{
    public class ProductViewModel : CommonViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ActualPrice { get; set; }
        public int Quantity { get; set; }
        public int GameZoneId { get; set; }

        public ProductViewModel() { }
    }
}
