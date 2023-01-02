using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Data.Entities;

public class ItemCheckoutEntity : BaseEntity
{
    public int CheckoutId { get; set; }

    [ForeignKey(nameof(CheckoutId))] public CheckoutEntity CheckoutEntity { get; set; }

    public int? ItemId { get; set; }

    [ForeignKey(nameof(ItemId))] public ItemEntity ItemEntity { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    [Column(TypeName = "decimal(18,2)")] public decimal Bill { get; set; }
}