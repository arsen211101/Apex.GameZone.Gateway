using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Data.Entities
{
    public class ProductCheckoutEntity : BaseEntity
    {
        public int CheckoutId { get; set; }

        [ForeignKey(nameof(CheckoutId))]
        public CheckoutEntity CheckoutEntity { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public ProductEntity ProductEntity { get; set; }
    }
}
