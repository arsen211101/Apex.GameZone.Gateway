namespace Apex.GameZone.Data.Entities
{
    public class GameZoneEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<SectionEntity> Sections { get; set; }
        public ICollection<ItemEntity> Items { get; set; }
        public ICollection<ProductEntity> Products { get; set; }

        public GameZoneEntity() { }
    }
}
