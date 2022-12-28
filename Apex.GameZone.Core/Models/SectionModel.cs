using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.Core.Entities
{
    public class SectionModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DeviceTypes Type { get; set; }
        public decimal PricePerHour { get; set; }
        public bool IsVip { get; set; }
        public int GameZoneId { get; set; }

        public SectionModel() { }
    }
}
