using Apex.GameZone.Shared.Enums;

namespace Apex.GameZone.API.ViewModels.Section;

public class SectionViewModel : CommonViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DeviceTypes Type { get; set; }
    public int PricePerHour { get; set; }
    public bool IsVip { get; set; }
    public bool IsBusy { get; set; }
    public int GameZoneId { get; set; }
}