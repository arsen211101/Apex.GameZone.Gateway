namespace Apex.GameZone.Core.Models;

public class ItemCheckoutModel :BaseModel
{
    public int CheckoutId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int Bill { get; set; }
}