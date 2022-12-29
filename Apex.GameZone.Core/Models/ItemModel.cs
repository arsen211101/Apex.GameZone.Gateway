using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Core.Entities
{
    public class ItemModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PricePerHour { get; set; }
        public int GameZoneId { get; set; }
        public ItemModel() { }
    }
}
