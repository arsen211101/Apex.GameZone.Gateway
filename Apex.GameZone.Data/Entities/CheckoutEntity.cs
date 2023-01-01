using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Data.Entities;

public class CheckoutEntity : BaseEntity
{
    public int GameZoneId { get; set; }

    [ForeignKey(nameof(GameZoneId))] public GameZoneEntity GameZone { get; set; }

    public int SectionId { get; set; }

    [ForeignKey(nameof(SectionId))] public SectionEntity SectionEntity { get; set; }

    public DateTime Start { get; set; }

    public DateTime? ExpectedEnd { get; set; }

    public DateTime? End { get; set; }

    public int Bill { get; set; }

    public ICollection<ItemCheckoutEntity> ConnectedItems { get; set; }
    public ICollection<ProductCheckoutEntity> ConnectedProducts { get; set; }
}