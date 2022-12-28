using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Core.Entities
{
    public class ProductModel:BaseModel
    {
        public string Name { get; set; }        
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal GrossPrice { get; set;}
        public int Balance { get; set; }
        public int GameZoneId { get; set; }
        public ProductModel() { }
    }
}
