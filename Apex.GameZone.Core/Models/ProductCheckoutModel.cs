using Apex.GameZone.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.Core.Models;

public class ProductCheckoutModel : BaseModel
{
    public int CheckoutId { get; set; }
    public CheckoutModel check { get; set; }

    public int ProductId { get; set; }
     public ProductModel product { get; set; }

    public int Quantity { get; set; }
}