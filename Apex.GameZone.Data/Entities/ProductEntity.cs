using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Data.Entities;

public class ProductEntity : BaseEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }

    public int ActualPrice { get; set; }

    public int Quantity { get; set; }

    public int GameZoneId { get; set; }

    [ForeignKey(nameof(GameZoneId))] public GameZoneEntity GameZoneEntity { get; set; }
}