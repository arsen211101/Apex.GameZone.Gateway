using System.Collections.Generic;
using Apex.GameZone.API.ViewModels.Item;
using Apex.GameZone.API.ViewModels.Product;
using Apex.GameZone.API.ViewModels.Section;

namespace Apex.GameZone.API.ViewModels;

public class GameZoneViewModel : CommonViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public List<SectionViewModel> Sections { get; set; }
    public List<ItemViewModel> Items { get; set; }
    public List<ProductViewModel> Products { get; set; }
}