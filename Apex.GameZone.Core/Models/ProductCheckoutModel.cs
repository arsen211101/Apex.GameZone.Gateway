using Apex.GameZone.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Core.Models
{
    public class ProductCheckoutModel
    {
        public CheckoutEntity CheckoutEntity { get; set; }

        public ProductEntity ProductEntity { get; set; }
    }
}
