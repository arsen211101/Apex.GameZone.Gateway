using System;

namespace Apex.GameZone.API.ViewModels.Checkout
{
    public class ItemCheckoutViewModel :CommonViewModel
    {
        public int CheckoutId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Bill { get; set; }
    }
}
