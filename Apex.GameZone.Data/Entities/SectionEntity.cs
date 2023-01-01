using System.ComponentModel.DataAnnotations.Schema;
using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.Data.Entities;

public class SectionEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceTypes Type { get; set; }

    [Column(TypeName = "decimal(18,4)")] public decimal PricePerHour { get; set; }

    public bool IsVip { get; set; }

    public int GameZoneId { get; set; }

    [ForeignKey(nameof(GameZoneId))] public GameZoneEntity GameZoneEntity { get; set; }
}