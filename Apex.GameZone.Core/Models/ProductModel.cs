namespace Apex.GameZone.Core.Models;

public class ProductModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int ActualPrice { get; set; }
    public int Quantity { get; set; }
    public int GameZoneId { get; set; }
}