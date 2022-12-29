namespace Apex.GameZone.Core.Models
{
    public class GameZoneModel : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<SectionModel> Sections { get; set; }
        public ICollection<ItemModel> Items { get; set; }
        public ICollection<ProductModel> Products { get; set; }

        public GameZoneModel() { }
    }
}
