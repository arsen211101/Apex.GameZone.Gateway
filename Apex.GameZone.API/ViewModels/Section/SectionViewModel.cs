using Apex.GameZone.Core.Models;
using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.API.ViewModels.Section
{
    public class SectionViewModel : CommonViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DeviceTypes Type { get; set; }
        public decimal PricePerHour { get; set; }
        public bool IsVip { get; set; }
        public int GameZoneId { get; set; }

        public SectionViewModel() {  }
    }
}
