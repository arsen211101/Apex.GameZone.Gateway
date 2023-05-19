using Apex.GameZone.Core.Models;

namespace Apex.GameZone.API.ViewModels.CashRegister
{
    public class CashoutModel : BaseModel
    {
        public string Balance { get; set; }

        public string ChashOutAmount { get; set; }

        public bool IsActive { get; set; }
    }
}