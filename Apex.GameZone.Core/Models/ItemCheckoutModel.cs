using Apex.GameZone.Data.Entities;

namespace Apex.GameZone.Core.Models
{
    public class ItemCheckoutModel
    {
        public CheckoutEntity CheckoutEntity { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Bill { get; set; }
    }
}
