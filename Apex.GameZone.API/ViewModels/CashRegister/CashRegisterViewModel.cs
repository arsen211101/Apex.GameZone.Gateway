namespace Apex.GameZone.API.ViewModels.CashRegister
{
    public class CashRegisterViewModel : CommonViewModel
    {
        public int GameZoneId { get; set; }
        public string Balance  { get; set; }
        public string ChashOutAmount { get; set; }
        public bool IsActive { get; set; }
    }
}