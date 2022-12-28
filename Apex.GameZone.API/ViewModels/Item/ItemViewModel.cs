using Apex.GameZone.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.API.ViewModels.Item
{
    public class ItemViewModel:CommonViewModel
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal PricePerHour { get; set; }

            public GameZoneModel GameZoneEntity { get; set; }

            public ItemViewModel() { }
    }
}
