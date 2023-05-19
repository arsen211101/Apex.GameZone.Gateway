using Apex.GameZone.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apex.GameZone.API.ViewModels.CashRegister
{
    public class CashoutEntity : BaseEntity
    {
        public string Balance { get; set; }
 
        public string ChashOutAmount { get; set; }

        public bool IsActive { get; set; }

        public int GameZoneId { get; set; }

        [ForeignKey(nameof(GameZoneId))]
        public GameZoneEntity GameZone { get; set; }
    }
}