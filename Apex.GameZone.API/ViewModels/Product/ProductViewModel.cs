using Apex.GameZone.Core.Entities;

namespace Apex.GameZone.API.ViewModels.Product
{
    public class ProductViewModel : CommonViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal GrossPrice { get; set; }
        public int Balance { get; set; }
        public GameZoneViewModel GameZoneModel { get; set; }

        public ProductViewModel() { }
    }
}
