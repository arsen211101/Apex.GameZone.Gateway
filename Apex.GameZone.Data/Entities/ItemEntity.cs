using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Data.Entities;

public class ItemEntity : BaseEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public int PricePerHour { get; set; }

    public int GameZoneId { get; set; }

    [ForeignKey(nameof(GameZoneId))] public GameZoneEntity GameZoneEntity { get; set; }
}