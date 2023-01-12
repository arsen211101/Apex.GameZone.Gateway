using Apex.GameZone.Core.Models;

namespace Apex.GameZone.API.ViewModels.Checkout
{
    public class ProductCheckoutViewModel : CommonViewModel

    {
        public int CheckoutId { get; set; }
        public CheckoutModel check { get; set; }

        public int ProductId { get; set; }
        public ProductModel product { get; set; }

        public int Quantity { get; set; }
    }
}