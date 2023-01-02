using System.ComponentModel.DataAnnotations.Schema;
using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.Data.Entities;

public class SectionEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceTypes Type { get; set; }

   public int PricePerHour { get; set; }

    public bool IsVip { get; set; }
    public bool IsBusy { get; set; }

    public int GameZoneId { get; set; }

    [ForeignKey(nameof(GameZoneId))] public GameZoneEntity GameZoneEntity { get; set; }
}